using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000D1 RID: 209
	internal sealed class BooleanStorage : DataStorage
	{
		// Token: 0x06000E7D RID: 3709 RVA: 0x00049267 File Offset: 0x00047467
		internal BooleanStorage(DataColumn column) : base(column, typeof(bool), false, StorageType.Boolean)
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00049284 File Offset: 0x00047484
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					bool flag2 = true;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							flag2 = (this._values[num] && flag2);
							flag = true;
						}
					}
					if (flag)
					{
						return flag2;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					bool flag3 = false;
					foreach (int num2 in records)
					{
						if (!this.IsNull(num2))
						{
							flag3 = (this._values[num2] || flag3);
							flag = true;
						}
					}
					if (flag)
					{
						return flag3;
					}
					return this._nullValue;
				}
				case AggregateType.First:
					if (records.Length != 0)
					{
						return this._values[records[0]];
					}
					return null;
				case AggregateType.Count:
					return base.Aggregate(records, kind);
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(bool));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000493A0 File Offset: 0x000475A0
		public override int Compare(int recordNo1, int recordNo2)
		{
			bool flag = this._values[recordNo1];
			bool flag2 = this._values[recordNo2];
			if (!flag || !flag2)
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return flag.CompareTo(flag2);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000493DC File Offset: 0x000475DC
		public override int CompareValueTo(int recordNo, object value)
		{
			if (this._nullValue == value)
			{
				if (this.IsNull(recordNo))
				{
					return 0;
				}
				return 1;
			}
			else
			{
				bool flag = this._values[recordNo];
				if (!flag && this.IsNull(recordNo))
				{
					return -1;
				}
				return flag.CompareTo((bool)value);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00049423 File Offset: 0x00047623
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToBoolean(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00049454 File Offset: 0x00047654
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00049470 File Offset: 0x00047670
		public override object Get(int record)
		{
			bool flag = this._values[record];
			if (flag)
			{
				return flag;
			}
			return base.GetBits(record);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00049497 File Offset: 0x00047697
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = false;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToBoolean(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000494D8 File Offset: 0x000476D8
		public override void SetCapacity(int capacity)
		{
			bool[] array = new bool[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0004951E File Offset: 0x0004771E
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToBoolean(s);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0004952B File Offset: 0x0004772B
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((bool)value);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00049538 File Offset: 0x00047738
		protected override object GetEmptyStorage(int recordCount)
		{
			return new bool[recordCount];
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00049540 File Offset: 0x00047740
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((bool[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00049562 File Offset: 0x00047762
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (bool[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x04000489 RID: 1161
		private bool[] _values;
	}
}
