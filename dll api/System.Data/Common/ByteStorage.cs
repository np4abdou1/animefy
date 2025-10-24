using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000D2 RID: 210
	internal sealed class ByteStorage : DataStorage
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x00049577 File Offset: 0x00047777
		internal ByteStorage(DataColumn column) : base(column, typeof(byte), 0, StorageType.Byte)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00049594 File Offset: 0x00047794
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					ulong num = 0UL;
					checked
					{
						foreach (int num2 in records)
						{
							if (!this.IsNull(num2))
							{
								num += unchecked((ulong)this._values[num2]);
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
								num3 += (long)(unchecked((ulong)this._values[num5]));
							}
							num4++;
							flag = true;
						}
					}
					if (flag)
					{
						return checked((byte)(num3 / unchecked((long)num4)));
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					byte b = byte.MaxValue;
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
					byte b2 = 0;
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
				throw ExprException.Overflow(typeof(byte));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00049894 File Offset: 0x00047A94
		public override int Compare(int recordNo1, int recordNo2)
		{
			byte b = this._values[recordNo1];
			byte b2 = this._values[recordNo2];
			if (b == 0 || b2 == 0)
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return b.CompareTo(b2);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x000498D0 File Offset: 0x00047AD0
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
				byte b = this._values[recordNo];
				if (b == 0 && this.IsNull(recordNo))
				{
					return -1;
				}
				return b.CompareTo((byte)value);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00049917 File Offset: 0x00047B17
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToByte(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00049948 File Offset: 0x00047B48
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00049964 File Offset: 0x00047B64
		public override object Get(int record)
		{
			byte b = this._values[record];
			if (b != 0)
			{
				return b;
			}
			return base.GetBits(record);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0004998B File Offset: 0x00047B8B
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = 0;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToByte(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000499CC File Offset: 0x00047BCC
		public override void SetCapacity(int capacity)
		{
			byte[] array = new byte[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00049A12 File Offset: 0x00047C12
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToByte(s);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00049A1F File Offset: 0x00047C1F
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((byte)value);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00049A2C File Offset: 0x00047C2C
		protected override object GetEmptyStorage(int recordCount)
		{
			return new byte[recordCount];
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00049A34 File Offset: 0x00047C34
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((byte[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00049A56 File Offset: 0x00047C56
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (byte[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400048A RID: 1162
		private byte[] _values;
	}
}
