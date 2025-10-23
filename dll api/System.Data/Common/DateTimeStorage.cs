﻿using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000E4 RID: 228
	internal sealed class DateTimeStorage : DataStorage
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x0004C702 File Offset: 0x0004A902
		internal DateTimeStorage(DataColumn column) : base(column, typeof(DateTime), DateTimeStorage.s_defaultValue, StorageType.DateTime)
		{
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004C724 File Offset: 0x0004A924
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Min:
				{
					DateTime dateTime = DateTime.MaxValue;
					foreach (int num in records)
					{
						if (base.HasValue(num))
						{
							dateTime = ((DateTime.Compare(this._values[num], dateTime) < 0) ? this._values[num] : dateTime);
							flag = true;
						}
					}
					if (flag)
					{
						return dateTime;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					DateTime dateTime2 = DateTime.MinValue;
					foreach (int num2 in records)
					{
						if (base.HasValue(num2))
						{
							dateTime2 = ((DateTime.Compare(this._values[num2], dateTime2) >= 0) ? this._values[num2] : dateTime2);
							flag = true;
						}
					}
					if (flag)
					{
						return dateTime2;
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
				throw ExprException.Overflow(typeof(DateTime));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0004C8B4 File Offset: 0x0004AAB4
		public override int Compare(int recordNo1, int recordNo2)
		{
			DateTime dateTime = this._values[recordNo1];
			DateTime dateTime2 = this._values[recordNo2];
			if (dateTime == DateTimeStorage.s_defaultValue || dateTime2 == DateTimeStorage.s_defaultValue)
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return DateTime.Compare(dateTime, dateTime2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0004C90C File Offset: 0x0004AB0C
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
				DateTime dateTime = this._values[recordNo];
				if (DateTimeStorage.s_defaultValue == dateTime && !base.HasValue(recordNo))
				{
					return -1;
				}
				return DateTime.Compare(dateTime, (DateTime)value);
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0004C960 File Offset: 0x0004AB60
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToDateTime(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0004C991 File Offset: 0x0004AB91
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0004C9B4 File Offset: 0x0004ABB4
		public override object Get(int record)
		{
			DateTime dateTime = this._values[record];
			if (dateTime != DateTimeStorage.s_defaultValue || base.HasValue(record))
			{
				return dateTime;
			}
			return this._nullValue;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0004C9F4 File Offset: 0x0004ABF4
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = DateTimeStorage.s_defaultValue;
				base.SetNullBit(record, true);
				return;
			}
			DateTime dateTime = ((IConvertible)value).ToDateTime(base.FormatProvider);
			DateTime dateTime2;
			switch (base.DateTimeMode)
			{
			case DataSetDateTime.Local:
				if (dateTime.Kind == DateTimeKind.Local)
				{
					dateTime2 = dateTime;
				}
				else if (dateTime.Kind == DateTimeKind.Utc)
				{
					dateTime2 = dateTime.ToLocalTime();
				}
				else
				{
					dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
				}
				break;
			case DataSetDateTime.Unspecified:
			case DataSetDateTime.UnspecifiedLocal:
				dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
				break;
			case DataSetDateTime.Utc:
				if (dateTime.Kind == DateTimeKind.Utc)
				{
					dateTime2 = dateTime;
				}
				else if (dateTime.Kind == DateTimeKind.Local)
				{
					dateTime2 = dateTime.ToUniversalTime();
				}
				else
				{
					dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
				}
				break;
			default:
				throw ExceptionBuilder.InvalidDateTimeMode(base.DateTimeMode);
			}
			this._values[record] = dateTime2;
			base.SetNullBit(record, false);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0004CADC File Offset: 0x0004ACDC
		public override void SetCapacity(int capacity)
		{
			DateTime[] array = new DateTime[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0004CB24 File Offset: 0x0004AD24
		public override object ConvertXmlToObject(string s)
		{
			object result;
			if (base.DateTimeMode == DataSetDateTime.UnspecifiedLocal)
			{
				result = XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.Unspecified);
			}
			else
			{
				result = XmlConvert.ToDateTime(s, XmlDateTimeSerializationMode.RoundtripKind);
			}
			return result;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0004CB58 File Offset: 0x0004AD58
		public override string ConvertObjectToXml(object value)
		{
			string result;
			if (base.DateTimeMode == DataSetDateTime.UnspecifiedLocal)
			{
				result = XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.Local);
			}
			else
			{
				result = XmlConvert.ToString((DateTime)value, XmlDateTimeSerializationMode.RoundtripKind);
			}
			return result;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0004CB8B File Offset: 0x0004AD8B
		protected override object GetEmptyStorage(int recordCount)
		{
			return new DateTime[recordCount];
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0004CB94 File Offset: 0x0004AD94
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			DateTime[] array = (DateTime[])store;
			bool flag = !base.HasValue(record);
			if (flag || (base.DateTimeMode & DataSetDateTime.Local) == (DataSetDateTime)0)
			{
				array[storeIndex] = this._values[record];
			}
			else
			{
				array[storeIndex] = this._values[record].ToUniversalTime();
			}
			nullbits.Set(storeIndex, flag);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0004CBF8 File Offset: 0x0004ADF8
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (DateTime[])store;
			base.SetNullStorage(nullbits);
			if (base.DateTimeMode == DataSetDateTime.UnspecifiedLocal)
			{
				for (int i = 0; i < this._values.Length; i++)
				{
					if (base.HasValue(i))
					{
						this._values[i] = DateTime.SpecifyKind(this._values[i].ToLocalTime(), DateTimeKind.Unspecified);
					}
				}
				return;
			}
			if (base.DateTimeMode == DataSetDateTime.Local)
			{
				for (int j = 0; j < this._values.Length; j++)
				{
					if (base.HasValue(j))
					{
						this._values[j] = this._values[j].ToLocalTime();
					}
				}
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly DateTime s_defaultValue = DateTime.MinValue;

		// Token: 0x04000500 RID: 1280
		private DateTime[] _values;
	}
}
