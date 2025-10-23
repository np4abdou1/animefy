using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000194 RID: 404
	[StructLayout(2)]
	internal struct Variant
	{
		// Token: 0x06000F7B RID: 3963 RVA: 0x00040E90 File Offset: 0x0003F090
		public void Clear()
		{
			if (this.vt == 8)
			{
				Marshal.FreeBSTR(this.bstrVal);
				return;
			}
			if ((this.vt == 9 || this.vt == 13) && this.pdispVal != IntPtr.Zero)
			{
				Marshal.Release(this.pdispVal);
			}
		}

		// Token: 0x040005DB RID: 1499
		[FieldOffset(0)]
		public short vt;

		// Token: 0x040005DC RID: 1500
		[FieldOffset(2)]
		public ushort wReserved1;

		// Token: 0x040005DD RID: 1501
		[FieldOffset(4)]
		public ushort wReserved2;

		// Token: 0x040005DE RID: 1502
		[FieldOffset(6)]
		public ushort wReserved3;

		// Token: 0x040005DF RID: 1503
		[FieldOffset(8)]
		public long llVal;

		// Token: 0x040005E0 RID: 1504
		[FieldOffset(8)]
		public int lVal;

		// Token: 0x040005E1 RID: 1505
		[FieldOffset(8)]
		public byte bVal;

		// Token: 0x040005E2 RID: 1506
		[FieldOffset(8)]
		public short iVal;

		// Token: 0x040005E3 RID: 1507
		[FieldOffset(8)]
		public float fltVal;

		// Token: 0x040005E4 RID: 1508
		[FieldOffset(8)]
		public double dblVal;

		// Token: 0x040005E5 RID: 1509
		[FieldOffset(8)]
		public short boolVal;

		// Token: 0x040005E6 RID: 1510
		[FieldOffset(8)]
		public IntPtr bstrVal;

		// Token: 0x040005E7 RID: 1511
		[FieldOffset(8)]
		public sbyte cVal;

		// Token: 0x040005E8 RID: 1512
		[FieldOffset(8)]
		public ushort uiVal;

		// Token: 0x040005E9 RID: 1513
		[FieldOffset(8)]
		public uint ulVal;

		// Token: 0x040005EA RID: 1514
		[FieldOffset(8)]
		public ulong ullVal;

		// Token: 0x040005EB RID: 1515
		[FieldOffset(8)]
		public int intVal;

		// Token: 0x040005EC RID: 1516
		[FieldOffset(8)]
		public uint uintVal;

		// Token: 0x040005ED RID: 1517
		[FieldOffset(8)]
		public IntPtr pdispVal;

		// Token: 0x040005EE RID: 1518
		[FieldOffset(8)]
		public BRECORD bRecord;
	}
}
