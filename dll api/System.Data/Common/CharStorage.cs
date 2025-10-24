using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000D3 RID: 211
	internal sealed class CharStorage : DataStorage
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x00049A6B File Offset: 0x00047C6B
		internal CharStorage(DataColumn column) : base(column, typeof(char), '\0', StorageType.Char)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00049A88 File Offset: 0x00047C88
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					char c = char.MaxValue;
					foreach (int num in records)
					{
						if (!this.IsNull(num))
						{
							c = ((this._values[num] < c) ? this._values[num] : c);
							flag = true;
						}
					}
					if (flag)
					{
						return c;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					char c2 = '\0';
					foreach (int num2 in records)
					{
						if (!this.IsNull(num2))
						{
							c2 = ((this._values[num2] > c2) ? this._values[num2] : c2);
							flag = true;
						}
					}
					if (flag)
					{
						return c2;
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
				throw ExprException.Overflow(typeof(char));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00049BC0 File Offset: 0x00047DC0
		public override int Compare(int recordNo1, int recordNo2)
		{
			char c = this._values[recordNo1];
			char c2 = this._values[recordNo2];
			if (c == '\0' || c2 == '\0')
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return c.CompareTo(c2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00049BFC File Offset: 0x00047DFC
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
				char c = this._values[recordNo];
				if (c == '\0' && this.IsNull(recordNo))
				{
					return -1;
				}
				return c.CompareTo((char)value);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00049C43 File Offset: 0x00047E43
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToChar(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00049C74 File Offset: 0x00047E74
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00049C90 File Offset: 0x00047E90
		public override object Get(int record)
		{
			char c = this._values[record];
			if (c != '\0')
			{
				return c;
			}
			return base.GetBits(record);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00049CB8 File Offset: 0x00047EB8
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = '\0';
				base.SetNullBit(record, true);
				return;
			}
			char c = ((IConvertible)value).ToChar(base.FormatProvider);
			if ((c >= '\ud800' && c <= '\udfff') || (c < '!' && (c == '\t' || c == '\n' || c == '\r')))
			{
				throw ExceptionBuilder.ProblematicChars(c);
			}
			this._values[record] = c;
			base.SetNullBit(record, false);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00049D30 File Offset: 0x00047F30
		public override void SetCapacity(int capacity)
		{
			char[] array = new char[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00049D76 File Offset: 0x00047F76
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToChar(s);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00049D83 File Offset: 0x00047F83
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((char)value);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00049D90 File Offset: 0x00047F90
		protected override object GetEmptyStorage(int recordCount)
		{
			return new char[recordCount];
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00049D98 File Offset: 0x00047F98
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((char[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00049DBA File Offset: 0x00047FBA
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (char[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400048B RID: 1163
		private char[] _values;
	}
}
