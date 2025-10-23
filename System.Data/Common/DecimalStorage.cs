using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000E9 RID: 233
	internal sealed class DecimalStorage : DataStorage
	{
		// Token: 0x06000FDF RID: 4063 RVA: 0x0004CED5 File Offset: 0x0004B0D5
		internal DecimalStorage(DataColumn column) : base(column, typeof(decimal), DecimalStorage.s_defaultValue, StorageType.Decimal)
		{
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004CEF4 File Offset: 0x0004B0F4
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					decimal num = DecimalStorage.s_defaultValue;
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
				case AggregateType.Mean:
				{
					decimal d = DecimalStorage.s_defaultValue;
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
						return d / num3;
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					decimal num5 = decimal.MaxValue;
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
					decimal num7 = decimal.MinValue;
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
					double num10 = (double)DecimalStorage.s_defaultValue;
					(double)DecimalStorage.s_defaultValue;
					double num11 = (double)DecimalStorage.s_defaultValue;
					double num12 = (double)DecimalStorage.s_defaultValue;
					foreach (int num13 in records)
					{
						if (base.HasValue(num13))
						{
							num11 += (double)this._values[num13];
							num12 += (double)this._values[num13] * (double)this._values[num13];
							num9++;
						}
					}
					if (num9 <= 1)
					{
						return this._nullValue;
					}
					num10 = (double)num9 * num12 - num11 * num11;
					if (num10 / (num11 * num11) < 1E-15 || num10 < 0.0)
					{
						num10 = 0.0;
					}
					else
					{
						num10 /= (double)(num9 * (num9 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(num10);
					}
					return num10;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(decimal));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0004D254 File Offset: 0x0004B454
		public override int Compare(int recordNo1, int recordNo2)
		{
			decimal d = this._values[recordNo1];
			decimal num = this._values[recordNo2];
			if (d == DecimalStorage.s_defaultValue || num == DecimalStorage.s_defaultValue)
			{
				int num2 = base.CompareBits(recordNo1, recordNo2);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return decimal.Compare(d, num);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0004D2AC File Offset: 0x0004B4AC
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
				decimal num = this._values[recordNo];
				if (DecimalStorage.s_defaultValue == num && !base.HasValue(recordNo))
				{
					return -1;
				}
				return decimal.Compare(num, (decimal)value);
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0004D300 File Offset: 0x0004B500
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToDecimal(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0004D331 File Offset: 0x0004B531
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0004D353 File Offset: 0x0004B553
		public override object Get(int record)
		{
			if (!base.HasValue(record))
			{
				return this._nullValue;
			}
			return this._values[record];
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004D378 File Offset: 0x0004B578
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = DecimalStorage.s_defaultValue;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToDecimal(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
		public override void SetCapacity(int capacity)
		{
			decimal[] array = new decimal[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0004D416 File Offset: 0x0004B616
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToDecimal(s);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004D423 File Offset: 0x0004B623
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((decimal)value);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004D430 File Offset: 0x0004B630
		protected override object GetEmptyStorage(int recordCount)
		{
			return new decimal[recordCount];
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004D438 File Offset: 0x0004B638
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((decimal[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0004D465 File Offset: 0x0004B665
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (decimal[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x04000509 RID: 1289
		private static readonly decimal s_defaultValue;

		// Token: 0x0400050A RID: 1290
		private decimal[] _values;
	}
}
