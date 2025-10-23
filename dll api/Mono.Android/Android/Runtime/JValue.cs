using System;
using System.Runtime.InteropServices;

namespace Android.Runtime
{
	// Token: 0x020002EA RID: 746
	[StructLayout(2)]
	public struct JValue
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x000518FF File Offset: 0x0004FAFF
		public JValue(bool value)
		{
			this = default(JValue);
			this.z = value;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0005190F File Offset: 0x0004FB0F
		public JValue(sbyte value)
		{
			this = default(JValue);
			this.b = value;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0005191F File Offset: 0x0004FB1F
		public JValue(char value)
		{
			this = default(JValue);
			this.c = value;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0005192F File Offset: 0x0004FB2F
		public JValue(short value)
		{
			this = default(JValue);
			this.s = value;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0005193F File Offset: 0x0004FB3F
		public JValue(int value)
		{
			this = default(JValue);
			this.i = value;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0005194F File Offset: 0x0004FB4F
		public JValue(long value)
		{
			this = default(JValue);
			this.j = value;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0005195F File Offset: 0x0004FB5F
		public JValue(float value)
		{
			this = default(JValue);
			this.f = value;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0005196F File Offset: 0x0004FB6F
		public JValue(double value)
		{
			this = default(JValue);
			this.d = value;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0005197F File Offset: 0x0004FB7F
		public JValue(IntPtr value)
		{
			this = default(JValue);
			this.l = value;
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0005198F File Offset: 0x0004FB8F
		public JValue(IJavaObject value)
		{
			this = default(JValue);
			this.l = ((value == null) ? IntPtr.Zero : value.Handle);
		}

		// Token: 0x04000C3D RID: 3133
		[FieldOffset(0)]
		private bool z;

		// Token: 0x04000C3E RID: 3134
		[FieldOffset(0)]
		private sbyte b;

		// Token: 0x04000C3F RID: 3135
		[FieldOffset(0)]
		private char c;

		// Token: 0x04000C40 RID: 3136
		[FieldOffset(0)]
		private short s;

		// Token: 0x04000C41 RID: 3137
		[FieldOffset(0)]
		private int i;

		// Token: 0x04000C42 RID: 3138
		[FieldOffset(0)]
		private long j;

		// Token: 0x04000C43 RID: 3139
		[FieldOffset(0)]
		private float f;

		// Token: 0x04000C44 RID: 3140
		[FieldOffset(0)]
		private double d;

		// Token: 0x04000C45 RID: 3141
		[FieldOffset(0)]
		private IntPtr l;

		// Token: 0x04000C46 RID: 3142
		public static JValue Zero = new JValue(IntPtr.Zero);
	}
}
