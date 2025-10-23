using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000EC RID: 236
	internal sealed class Int32Storage : DataStorage
	{
		// Token: 0x06001009 RID: 4105 RVA: 0x0004DEDE File Offset: 0x0004C0DE
		internal Int32Storage(DataColumn column) : base(column, typeof(int), 0, StorageType.Int32)
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0004DEFC File Offset: 0x0004C0FC
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
								num += unchecked((long)this._values[num2]);
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
					long num3 = 0L;
					int num4 = 0;
					foreach (int num5 in records)
					{
						if (base.HasValue(num5))
						{
							checked
							{
								num3 += unchecked((long)this._values[num5]);
							}
							num4++;
							flag = true;
						}
					}
					if (flag)
					{
						return checked((int)(num3 / unchecked((long)num4)));
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					int num6 = int.MaxValue;
					foreach (int num7 in records)
					{
						if (base.HasValue(num7))
						{
							num6 = Math.Min(this._values[num7], num6);
							flag = true;
						}
					}
					if (flag)
					{
						return num6;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					int num8 = int.MinValue;
					foreach (int num9 in records)
					{
						if (base.HasValue(num9))
						{
							num8 = Math.Max(this._values[num9], num8);
							flag = true;
						}
					}
					if (flag)
					{
						return num8;
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
					int num10 = 0;
					for (int l = 0; l < records.Length; l++)
					{
						if (base.HasValue(records[l]))
						{
							num10++;
						}
					}
					return num10;
				}
				case AggregateType.Var:
				case AggregateType.StDev:
				{
					int num10 = 0;
					double num11 = 0.0;
					double num12 = 0.0;
					foreach (int num13 in records)
					{
						if (base.HasValue(num13))
						{
							num11 += (double)this._values[num13];
							num12 += (double)this._values[num13] * (double)this._values[num13];
							num10++;
						}
					}
					if (num10 <= 1)
					{
						return this._nullValue;
					}
					double num14 = (double)num10 * num12 - num11 * num11;
					if (num14 / (num11 * num11) < 1E-15 || num14 < 0.0)
					{
						num14 = 0.0;
					}
					else
					{
						num14 /= (double)(num10 * (num10 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(num14);
					}
					return num14;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(int));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0004E224 File Offset: 0x0004C424
		public override int Compare(int recordNo1, int recordNo2)
		{
			int num = this._values[recordNo1];
			int num2 = this._values[recordNo2];
			if (num == 0 || num2 == 0)
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

		// Token: 0x0600100C RID: 4108 RVA: 0x0004E264 File Offset: 0x0004C464
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
				int num = this._values[recordNo];
				if (num == 0 && !base.HasValue(recordNo))
				{
					return -1;
				}
				return num.CompareTo((int)value);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004E2AB File Offset: 0x0004C4AB
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToInt32(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0004E2DC File Offset: 0x0004C4DC
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
		public override object Get(int record)
		{
			int num = this._values[record];
			if (num != 0)
			{
				return num;
			}
			return base.GetBits(record);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0004E31F File Offset: 0x0004C51F
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = 0;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToInt32(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0004E360 File Offset: 0x0004C560
		public override void SetCapacity(int capacity)
		{
			int[] array = new int[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0004E3A6 File Offset: 0x0004C5A6
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToInt32(s);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0004E3B3 File Offset: 0x0004C5B3
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((int)value);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		protected override object GetEmptyStorage(int recordCount)
		{
			return new int[recordCount];
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((int[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0004E3ED File Offset: 0x0004C5ED
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (int[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400050D RID: 1293
		private int[] _values;
	}
}
