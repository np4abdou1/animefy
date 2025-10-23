using System;
using System.Collections;
using System.Globalization;
using System.Numerics;

namespace System.Data.Common
{
	// Token: 0x020000D0 RID: 208
	internal sealed class BigIntegerStorage : DataStorage
	{
		// Token: 0x06000E6D RID: 3693 RVA: 0x00048CDD File Offset: 0x00046EDD
		internal BigIntegerStorage(DataColumn column) : base(column, typeof(BigInteger), BigInteger.Zero, StorageType.BigInteger)
		{
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00048CFC File Offset: 0x00046EFC
		public override object Aggregate(int[] records, AggregateType kind)
		{
			throw ExceptionBuilder.AggregateException(kind, this._dataType);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00048D0C File Offset: 0x00046F0C
		public override int Compare(int recordNo1, int recordNo2)
		{
			BigInteger bigInteger = this._values[recordNo1];
			BigInteger other = this._values[recordNo2];
			if (bigInteger.IsZero || other.IsZero)
			{
				int num = base.CompareBits(recordNo1, recordNo2);
				if (num != 0)
				{
					return num;
				}
			}
			return bigInteger.CompareTo(other);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00048D5C File Offset: 0x00046F5C
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
				BigInteger bigInteger = this._values[recordNo];
				if (bigInteger.IsZero && !base.HasValue(recordNo))
				{
					return -1;
				}
				return bigInteger.CompareTo((BigInteger)value);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00048DB0 File Offset: 0x00046FB0
		internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider)
		{
			if (value.GetType() == typeof(BigInteger))
			{
				return (BigInteger)value;
			}
			if (value.GetType() == typeof(string))
			{
				return BigInteger.Parse((string)value, formatProvider);
			}
			if (value.GetType() == typeof(long))
			{
				return (long)value;
			}
			if (value.GetType() == typeof(int))
			{
				return (int)value;
			}
			if (value.GetType() == typeof(short))
			{
				return (short)value;
			}
			if (value.GetType() == typeof(sbyte))
			{
				return (sbyte)value;
			}
			if (value.GetType() == typeof(ulong))
			{
				return (ulong)value;
			}
			if (value.GetType() == typeof(uint))
			{
				return (uint)value;
			}
			if (value.GetType() == typeof(ushort))
			{
				return (ushort)value;
			}
			if (value.GetType() == typeof(byte))
			{
				return (byte)value;
			}
			throw ExceptionBuilder.ConvertFailed(value.GetType(), typeof(BigInteger));
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00048F2C File Offset: 0x0004712C
		internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider)
		{
			if (type == typeof(string))
			{
				return value.ToString("D", formatProvider);
			}
			if (type == typeof(sbyte))
			{
				return (sbyte)value;
			}
			if (type == typeof(short))
			{
				return (short)value;
			}
			if (type == typeof(int))
			{
				return (int)value;
			}
			if (type == typeof(long))
			{
				return (long)value;
			}
			if (type == typeof(byte))
			{
				return (byte)value;
			}
			if (type == typeof(ushort))
			{
				return (ushort)value;
			}
			if (type == typeof(uint))
			{
				return (uint)value;
			}
			if (type == typeof(ulong))
			{
				return (ulong)value;
			}
			if (type == typeof(float))
			{
				return (float)value;
			}
			if (type == typeof(double))
			{
				return (double)value;
			}
			if (type == typeof(decimal))
			{
				return (decimal)value;
			}
			if (type == typeof(BigInteger))
			{
				return value;
			}
			throw ExceptionBuilder.ConvertFailed(typeof(BigInteger), type);
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000490CE File Offset: 0x000472CE
		public override object ConvertValue(object value)
		{
			if (this._nullValue != value)
			{
				if (value != null)
				{
					value = BigIntegerStorage.ConvertToBigInteger(value, base.FormatProvider);
				}
				else
				{
					value = this._nullValue;
				}
			}
			return value;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000490FA File Offset: 0x000472FA
		public override void Copy(int recordNo1, int recordNo2)
		{
			base.CopyBits(recordNo1, recordNo2);
			this._values[recordNo2] = this._values[recordNo1];
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0004911C File Offset: 0x0004731C
		public override object Get(int record)
		{
			BigInteger bigInteger = this._values[record];
			if (!bigInteger.IsZero)
			{
				return bigInteger;
			}
			return base.GetBits(record);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00049150 File Offset: 0x00047350
		public override void Set(int record, object value)
		{
			if (this._nullValue == value)
			{
				this._values[record] = BigInteger.Zero;
				base.SetNullBit(record, true);
				return;
			}
			this._values[record] = BigIntegerStorage.ConvertToBigInteger(value, base.FormatProvider);
			base.SetNullBit(record, false);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000491A0 File Offset: 0x000473A0
		public override void SetCapacity(int capacity)
		{
			BigInteger[] array = new BigInteger[capacity];
			if (this._values != null)
			{
				Array.Copy(this._values, 0, array, 0, Math.Min(capacity, this._values.Length));
			}
			this._values = array;
			base.SetCapacity(capacity);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000491E6 File Offset: 0x000473E6
		public override object ConvertXmlToObject(string s)
		{
			return BigInteger.Parse(s, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000491F8 File Offset: 0x000473F8
		public override string ConvertObjectToXml(object value)
		{
			return ((BigInteger)value).ToString("D", CultureInfo.InvariantCulture);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0004921D File Offset: 0x0004741D
		protected override object GetEmptyStorage(int recordCount)
		{
			return new BigInteger[recordCount];
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00049225 File Offset: 0x00047425
		protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex)
		{
			((BigInteger[])store)[storeIndex] = this._values[record];
			nullbits.Set(storeIndex, !base.HasValue(record));
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00049252 File Offset: 0x00047452
		protected override void SetStorage(object store, BitArray nullbits)
		{
			this._values = (BigInteger[])store;
			base.SetNullStorage(nullbits);
		}

		// Token: 0x04000488 RID: 1160
		private BigInteger[] _values;
	}
}
