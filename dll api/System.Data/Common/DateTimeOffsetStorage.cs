using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000E3 RID: 227
	internal sealed class DateTimeOffsetStorage : DataStorage
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x0004C32D File Offset: 0x0004A52D
		internal DateTimeOffsetStorage(DataColumn column) : base(column, typeof(DateTimeOffset), DateTimeOffsetStorage.s_defaultValue, StorageType.DateTimeOffset)
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0004C34C File Offset: 0x0004A54C
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					DateTimeOffset dateTimeOffset = DateTimeOffset.MaxValue;
					foreach (int num in records)
					{
						if (base.HasValue(num))
						{
							dateTimeOffset = ((DateTimeOffset.Compare(this._values[num], dateTimeOffset) < 0) ? this._values[num] : dateTimeOffset);
							flag = true;
						}
					}
					if (flag)
					{
						return dateTimeOffset;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					DateTimeOffset dateTimeOffset2 = DateTimeOffset.MinValue;
					foreach (int num2 in records)
					{
						if (base.HasValue(num2))
						{
							dateTimeOffset2 = ((DateTimeOffset.Compare(this._values[num2], dateTimeOffset2) >= 0) ? this._values[num2] : dateTimeOffset2);
							flag = true;
						}
					}
					if (flag)
					{
						return dateTimeOffset2;
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
				{
					int num3 = 0;
					for (int k = 0; k < records.Length; k++)
					{
						if (base.HasValue(records[k]))
						{
							num3++;
						}
					}
					return num3;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(DateTimeOffset));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		public override int Compare(int recordNo1, int recordNo2)
		{
			DateTimeOffset dateTimeOffset = this._values[recordNo1];
			DateTimeOffset dateTimeOffset2 = this._values[recordNo2];
			if (dateTimeOffset == DateTimeOffsetStorage.s_defaultValue || dateTimeOffset2 == DateTimeOffsetStorage.s_defaultValue)
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return DateTimeOffset.Compare(dateTimeOffset, dateTimeOffset2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0004C534 File Offset: 0x0004A734
		public override int CompareValueTo(int recordNo, object value)
		{
			if (this._nullValue == value)
			{
				if (!base.HasValue(recordNo))
				{
					return 0;
				}
				return 1;
			}
			else
			{
				DateTimeOffset dateTimeOffset = this._values[recordNo];
				if (DateTimeOffsetStorage.s_defaultValue == dateTimeOffset && !base.HasValue(recordNo))
				{
					return -1;
				}
				return DateTimeOffset.Compare(dateTimeOffset, (DateTimeOffset)value);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0004C588 File Offset: 0x0004A788
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = (DateTimeOffset)value;
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0004C5AE File Offset: 0x0004A7AE
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		public override object Get(int record)
		{
			DateTimeOffset dateTimeOffset = this._values[record];
			if (dateTimeOffset != DateTimeOffsetStorage.s_defaultValue || base.HasValue(record))
			{
				return dateTimeOffset;
			}
			return this._nullValue;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0004C60D File Offset: 0x0004A80D
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = DateTimeOffsetStorage.s_defaultValue;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = (DateTimeOffset)value;
			base.SetNullBit(record, false);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0004C64C File Offset: 0x0004A84C
		public override void SetCapacity(int capacity)
		{
			DateTimeOffset[] array = new DateTimeOffset[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0004C692 File Offset: 0x0004A892
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToDateTimeOffset(s);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0004C69F File Offset: 0x0004A89F
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((DateTimeOffset)value);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004C6AC File Offset: 0x0004A8AC
		protected override object GetEmptyStorage(int recordCount)
		{
			return new DateTimeOffset[recordCount];
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0004C6B4 File Offset: 0x0004A8B4
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((DateTimeOffset[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0004C6E1 File Offset: 0x0004A8E1
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (DateTimeOffset[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x040004FD RID: 1277
		private static readonly DateTimeOffset s_defaultValue = DateTimeOffset.MinValue;

		// Token: 0x040004FE RID: 1278
		private DateTimeOffset[] _values;
	}
}
