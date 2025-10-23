﻿using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000ED RID: 237
	internal sealed class Int64Storage : DataStorage
	{
		// Token: 0x06001017 RID: 4119 RVA: 0x0004E402 File Offset: 0x0004C602
		internal Int64Storage(DataColumn column) : base(column, typeof(long), 0L, StorageType.Int64)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0004E420 File Offset: 0x0004C620
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					long num = 0L;
					checked
					{
						foreach (int num2 in records)
						{
							if (base.HasValue(num2))
							{
								num += this._values[num2];
								flag = true;
							}
						}
						if (flag)
						{
							return num;
						}
						return this._nullValue;
					}
				}
				case AggregateType.Mean:
				{
					decimal d = 0m;
					int num3 = 0;
					foreach (int num4 in records)
					{
						if (base.HasValue(num4))
						{
							d += this._values[num4];
							num3++;
							flag = true;
						}
					}
					if (flag)
					{
						return (long)(d / num3);
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					long num5 = long.MaxValue;
					foreach (int num6 in records)
					{
						if (base.HasValue(num6))
						{
							num5 = Math.Min(this._values[num6], num5);
							flag = true;
						}
					}
					if (flag)
					{
						return num5;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					long num7 = long.MinValue;
					foreach (int num8 in records)
					{
						if (base.HasValue(num8))
						{
							num7 = Math.Max(this._values[num8], num7);
							flag = true;
						}
					}
					if (flag)
					{
						return num7;
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
				case AggregateType.Var:
				case AggregateType.StDev:
				{
					int num9 = 0;
					double num10 = 0.0;
					double num11 = 0.0;
					foreach (int num12 in records)
					{
						if (base.HasValue(num12))
						{
							num10 += (double)this._values[num12];
							num11 += (double)this._values[num12] * (double)this._values[num12];
							num9++;
						}
					}
					if (num9 <= 1)
					{
						return this._nullValue;
					}
					double num13 = (double)num9 * num11 - num10 * num10;
					if (num13 / (num10 * num10) < 1E-15 || num13 < 0.0)
					{
						num13 = 0.0;
					}
					else
					{
						num13 /= (double)(num9 * (num9 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(num13);
					}
					return num13;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(long));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004E744 File Offset: 0x0004C944
		public override int Compare(int recordNo1, int recordNo2)
		{
			long num = this._values[recordNo1];
			long num2 = this._values[recordNo2];
			if (num == 0L || num2 == 0L)
			{
				int num3 = base.CompareBits(recordNo1, recordNo2);
				if (num3 != 0)
				{
					return num3;
				}
			}
			if (num < num2)
			{
				return -1;
			}
			if (num <= num2)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0004E784 File Offset: 0x0004C984
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
				long num = this._values[recordNo];
				if (num == 0L && !base.HasValue(recordNo))
				{
					return -1;
				}
				return num.CompareTo((long)value);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0004E7CB File Offset: 0x0004C9CB
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToInt64(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0004E7FC File Offset: 0x0004C9FC
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0004E818 File Offset: 0x0004CA18
		public override object Get(int record)
		{
			long num = this._values[record];
			if (num != 0L)
			{
				return num;
			}
			return base.GetBits(record);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0004E83F File Offset: 0x0004CA3F
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = 0L;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToInt64(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0004E880 File Offset: 0x0004CA80
		public override void SetCapacity(int capacity)
		{
			long[] array = new long[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0004E8C6 File Offset: 0x0004CAC6
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToInt64(s);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0004E8D3 File Offset: 0x0004CAD3
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((long)value);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0004E8E0 File Offset: 0x0004CAE0
		protected override object GetEmptyStorage(int recordCount)
		{
			return new long[recordCount];
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((long[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004E90D File Offset: 0x0004CB0D
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (long[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400050E RID: 1294
		private long[] _values;
	}
}
