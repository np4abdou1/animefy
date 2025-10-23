﻿using System;
using System.Collections;
using System.Xml;

namespace System.Data.Common
{
	// Token: 0x020000EA RID: 234
	internal sealed class DoubleStorage : DataStorage
	{
		// Token: 0x06000FED RID: 4077 RVA: 0x0004D47A File Offset: 0x0004B67A
		internal DoubleStorage(DataColumn column) : base(column, typeof(double), 0.0, StorageType.Double)
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004D4A0 File Offset: 0x0004B6A0
		public override object Aggregate(int[] records, AggregateType kind)
		{
			bool flag = false;
			try
			{
				switch (kind)
				{
				case AggregateType.Sum:
				{
					double num = 0.0;
					foreach (int num2 in records)
					{
						if (!this.IsNull(num2))
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
					double num3 = 0.0;
					int num4 = 0;
					foreach (int num5 in records)
					{
						if (!this.IsNull(num5))
						{
							num3 += this._values[num5];
							num4++;
							flag = true;
						}
					}
					if (flag)
					{
						return num3 / (double)num4;
					}
					return this._nullValue;
				}
				case AggregateType.Min:
				{
					double num6 = double.MaxValue;
					foreach (int num7 in records)
					{
						if (!this.IsNull(num7))
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
					double num8 = double.MinValue;
					foreach (int num9 in records)
					{
						if (!this.IsNull(num9))
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
					return base.Aggregate(records, kind);
				case AggregateType.Var:
				case AggregateType.StDev:
				{
					int num10 = 0;
					double num11 = 0.0;
					double num12 = 0.0;
					foreach (int num13 in records)
					{
						if (!this.IsNull(num13))
						{
							num11 += this._values[num13];
							num12 += this._values[num13] * this._values[num13];
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
				throw ExprException.Overflow(typeof(double));
			}
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0004D7B4 File Offset: 0x0004B9B4
		public override int Compare(int recordNo1, int recordNo2)
		{
			double num = this._values[recordNo1];
			double num2 = this._values[recordNo2];
			if (num == 0.0 || num2 == 0.0)
			{
				int num3 = base.CompareBits(recordNo1, recordNo2);
				if (num3 != 0)
				{
					return num3;
				}
			}
			return num.CompareTo(num2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0004D804 File Offset: 0x0004BA04
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
				double num = this._values[recordNo];
				if (0.0 == num && this.IsNull(recordNo))
				{
					return -1;
				}
				return num.CompareTo((double)value);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004D854 File Offset: 0x0004BA54
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = ((IConvertible)value).ToDouble(base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0004D885 File Offset: 0x0004BA85
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0004D8A0 File Offset: 0x0004BAA0
		public override object Get(int record)
		{
			double num = this._values[record];
			if (num != 0.0)
			{
				return num;
			}
			return base.GetBits(record);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004D8D0 File Offset: 0x0004BAD0
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = 0.0;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = ((IConvertible)value).ToDouble(base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004D924 File Offset: 0x0004BB24
		public override void SetCapacity(int capacity)
		{
			double[] array = new double[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004D96A File Offset: 0x0004BB6A
		public override object ConvertXmlToObject(string s)
		{
			return XmlConvert.ToDouble(s);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004D977 File Offset: 0x0004BB77
		public override string ConvertObjectToXml(object value)
		{
			return XmlConvert.ToString((double)value);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004D984 File Offset: 0x0004BB84
		protected override object GetEmptyStorage(int recordCount)
		{
			return new double[recordCount];
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004D98C File Offset: 0x0004BB8C
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((double[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, this.IsNull(record));
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004D9AE File Offset: 0x0004BBAE
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (double[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x0400050B RID: 1291
		private double[] _values;
	}
}
