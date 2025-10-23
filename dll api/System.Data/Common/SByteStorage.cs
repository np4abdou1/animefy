using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000F1 RID: 241
	internal sealed class SByteStorage : DataStorage
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x0004F6F0 File Offset: 0x0004D8F0
		public SByteStorage(DataColumn column) : base(column, typeof(sbyte), 0, StorageType.SByte)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004F70C File Offset: 0x0004D90C
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
							if (!this.IsNull(num2))
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
						if (!this.IsNull(num5))
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
						return checked((sbyte)(num3 / unchecked((long)num4)));
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					sbyte b = sbyte.MaxValue;
					foreach (int num6 in records)
					{
						if (!this.IsNull(num6))
						{
							b = Math.Min(this._values[num6], b);
							flag = true;
						}
					}
					if (flag)
					{
						return b;
					}
					return this._nullValue;
				}
				case AggregateType.Max:
				{
					sbyte b2 = sbyte.MinValue;
					foreach (int num7 in records)
					{
						if (!this.IsNull(num7))
						{
							b2 = Math.Max(this._values[num7], b2);
							flag = true;
						}
					}
					if (flag)
					{
						return b2;
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
					int num8 = 0;
					double num9 = 0.0;
					double num10 = 0.0;
					foreach (int num11 in records)
					{
						if (!this.IsNull(num11))
						{
							num9 += (double)this._values[num11];
							num10 += (double)this._values[num11] * (double)this._values[num11];
							num8++;
						}
					}
					if (num8 <= 1)
					{
						return this._nullValue;
					}
					double num12 = (double)num8 * num10 - num9 * num9;
					if (num12 / (num9 * num9) < 1E-15 || num12 < 0.0)
					{
						num12 = 0.0;
					}
					else
					{
						num12 /= (double)(num8 * (num8 - 1));
					}
					if (kind == AggregateType.StDev)
					{
						return Math.Sqrt(num12);
					}
					return num12;
				}
				}
			}
			catch (OverflowException)
			{
				throw ExprException.Overflow(typeof(sbyte));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0004FA08 File Offset: 0x0004DC08
		public override int Compare(int recordNo1, int recordNo2)
		{
			sbyte b = this._values[recordNo1];
			sbyte value = this._values[recordNo2];
			if (b.Equals(0) || value.Equals(0))
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return b.CompareTo(value);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0004FA54 File Offset: 0x0004DC54
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
				sbyte b = this._values[recordNo];
				if (b == 0 && this.IsNull(recordNo))
				{
					return -1;
				}
				return b.CompareTo((sbyte)value);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0004FA9B File Offset: 0x0004DC9B
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToSByte(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0004FACC File Offset: 0x0004DCCC
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		public override object Get(int record)
		{
			sbyte b = this._values[record];
			if (!b.Equals(0))
			{
				return b;
			}
			return base.GetBits(record);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0004FB16 File Offset: 0x0004DD16
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = 0;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToSByte(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0004FB54 File Offset: 0x0004DD54
		public override void SetCapacity(int capacity)
		{
			sbyte[] array = new sbyte[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0004FB9A File Offset: 0x0004DD9A
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToSByte(s);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0004FBA7 File Offset: 0x0004DDA7
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((sbyte)value);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0004FBB4 File Offset: 0x0004DDB4
		protected override object GetEmptyStorage(int recordCount)
		{
			return new sbyte[recordCount];
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0004FBBC File Offset: 0x0004DDBC
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((sbyte[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0004FBDE File Offset: 0x0004DDDE
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (sbyte[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400051C RID: 1308
		private sbyte[] _values;
	}
}
