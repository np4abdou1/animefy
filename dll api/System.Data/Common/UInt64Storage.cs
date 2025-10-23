using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x0200010B RID: 267
	internal sealed class UInt64Storage : DataStorage
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x00057756 File Offset: 0x00055956
		public UInt64Storage(DataColumn column) : base(column, typeof(ulong), UInt64Storage.s_defaultValue, StorageType.UInt64)
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00057778 File Offset: 0x00055978
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					ulong num = UInt64Storage.s_defaultValue;
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
					decimal d = UInt64Storage.s_defaultValue;
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
						return (ulong)(d / num3);
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					ulong num5 = ulong.MaxValue;
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
					ulong num7 = 0UL;
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
							num10 += this._values[num12];
							num11 += this._values[num12] * this._values[num12];
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
				throw ExprException.Overflow(typeof(ulong));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00057A98 File Offset: 0x00055C98
		public override int Compare(int recordNo1, int recordNo2)
		{
			ulong num = this._values[recordNo1];
			ulong num2 = this._values[recordNo2];
			if (num.Equals(UInt64Storage.s_defaultValue) || num2.Equals(UInt64Storage.s_defaultValue))
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

		// Token: 0x060011A6 RID: 4518 RVA: 0x00057AF0 File Offset: 0x00055CF0
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
				ulong num = this._values[recordNo];
				if (UInt64Storage.s_defaultValue == num && !base.HasValue(recordNo))
				{
					return -1;
				}
				return num.CompareTo((ulong)value);
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00057B3C File Offset: 0x00055D3C
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToUInt64(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00057B6D File Offset: 0x00055D6D
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00057B88 File Offset: 0x00055D88
		public override object Get(int record)
		{
			ulong num = this._values[record];
			if (!num.Equals(UInt64Storage.s_defaultValue))
			{
				return num;
			}
			return base.GetBits(record);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00057BBC File Offset: 0x00055DBC
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = UInt64Storage.s_defaultValue;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToUInt64(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00057C0C File Offset: 0x00055E0C
		public override void SetCapacity(int capacity)
		{
			ulong[] array = new ulong[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00057C52 File Offset: 0x00055E52
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToUInt64(s);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00057C5F File Offset: 0x00055E5F
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((ulong)value);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00057C6C File Offset: 0x00055E6C
		protected override object GetEmptyStorage(int recordCount)
		{
			return new ulong[recordCount];
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00057C74 File Offset: 0x00055E74
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((ulong[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00057C99 File Offset: 0x00055E99
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (ulong[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x04000558 RID: 1368
		private static readonly ulong s_defaultValue;

		// Token: 0x04000559 RID: 1369
		private ulong[] _values;
	}
}
