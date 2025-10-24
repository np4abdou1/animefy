using System;
using System.Globalization;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F6 RID: 1014
	internal sealed class PrimitiveArray
	{
		// Token: 0x06001F18 RID: 7960 RVA: 0x000860A0 File Offset: 0x000842A0
		internal PrimitiveArray(InternalPrimitiveTypeE code, Array array)
		{
			this.Init(code, array);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x000860B0 File Offset: 0x000842B0
		internal void Init(InternalPrimitiveTypeE code, Array array)
		{
			this.code = code;
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
				this.booleanA = (bool[])array;
				return;
			case InternalPrimitiveTypeE.Byte:
			case InternalPrimitiveTypeE.Currency:
			case InternalPrimitiveTypeE.Decimal:
			case InternalPrimitiveTypeE.TimeSpan:
			case InternalPrimitiveTypeE.DateTime:
				break;
			case InternalPrimitiveTypeE.Char:
				this.charA = (char[])array;
				return;
			case InternalPrimitiveTypeE.Double:
				this.doubleA = (double[])array;
				return;
			case InternalPrimitiveTypeE.Int16:
				this.int16A = (short[])array;
				return;
			case InternalPrimitiveTypeE.Int32:
				this.int32A = (int[])array;
				return;
			case InternalPrimitiveTypeE.Int64:
				this.int64A = (long[])array;
				return;
			case InternalPrimitiveTypeE.SByte:
				this.sbyteA = (sbyte[])array;
				return;
			case InternalPrimitiveTypeE.Single:
				this.singleA = (float[])array;
				return;
			case InternalPrimitiveTypeE.UInt16:
				this.uint16A = (ushort[])array;
				return;
			case InternalPrimitiveTypeE.UInt32:
				this.uint32A = (uint[])array;
				return;
			case InternalPrimitiveTypeE.UInt64:
				this.uint64A = (ulong[])array;
				break;
			default:
				return;
			}
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0008619C File Offset: 0x0008439C
		internal void SetValue(string value, int index)
		{
			switch (this.code)
			{
			case InternalPrimitiveTypeE.Boolean:
				this.booleanA[index] = bool.Parse(value);
				return;
			case InternalPrimitiveTypeE.Byte:
			case InternalPrimitiveTypeE.Currency:
			case InternalPrimitiveTypeE.Decimal:
			case InternalPrimitiveTypeE.TimeSpan:
			case InternalPrimitiveTypeE.DateTime:
				break;
			case InternalPrimitiveTypeE.Char:
				if (value[0] == '_' && value.Equals("_0x00_"))
				{
					this.charA[index] = '\0';
					return;
				}
				this.charA[index] = char.Parse(value);
				return;
			case InternalPrimitiveTypeE.Double:
				this.doubleA[index] = double.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.Int16:
				this.int16A[index] = short.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.Int32:
				this.int32A[index] = int.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.Int64:
				this.int64A[index] = long.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.SByte:
				this.sbyteA[index] = sbyte.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.Single:
				this.singleA[index] = float.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.UInt16:
				this.uint16A[index] = ushort.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.UInt32:
				this.uint32A[index] = uint.Parse(value, CultureInfo.InvariantCulture);
				return;
			case InternalPrimitiveTypeE.UInt64:
				this.uint64A[index] = ulong.Parse(value, CultureInfo.InvariantCulture);
				break;
			default:
				return;
			}
		}

		// Token: 0x04000E61 RID: 3681
		private InternalPrimitiveTypeE code;

		// Token: 0x04000E62 RID: 3682
		private bool[] booleanA;

		// Token: 0x04000E63 RID: 3683
		private char[] charA;

		// Token: 0x04000E64 RID: 3684
		private double[] doubleA;

		// Token: 0x04000E65 RID: 3685
		private short[] int16A;

		// Token: 0x04000E66 RID: 3686
		private int[] int32A;

		// Token: 0x04000E67 RID: 3687
		private long[] int64A;

		// Token: 0x04000E68 RID: 3688
		private sbyte[] sbyteA;

		// Token: 0x04000E69 RID: 3689
		private float[] singleA;

		// Token: 0x04000E6A RID: 3690
		private ushort[] uint16A;

		// Token: 0x04000E6B RID: 3691
		private uint[] uint32A;

		// Token: 0x04000E6C RID: 3692
		private ulong[] uint64A;
	}
}
