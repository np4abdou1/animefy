using System;
using System.Runtime.InteropServices;

namespace Java.Interop
{
	// Token: 0x0200004C RID: 76
	[StructLayout(2)]
	public struct JniArgumentValue : IEquatable<JniArgumentValue>
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000C591 File Offset: 0x0000A791
		public JniArgumentValue(bool value)
		{
			this = default(JniArgumentValue);
			this.z = value;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000C5A1 File Offset: 0x0000A7A1
		public JniArgumentValue(sbyte value)
		{
			this = default(JniArgumentValue);
			this.b = value;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
		public JniArgumentValue(byte value)
		{
			this = new JniArgumentValue((sbyte)value);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000C5BB File Offset: 0x0000A7BB
		public JniArgumentValue(char value)
		{
			this = default(JniArgumentValue);
			this.c = value;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000C5CB File Offset: 0x0000A7CB
		public JniArgumentValue(short value)
		{
			this = default(JniArgumentValue);
			this.s = value;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000C5DB File Offset: 0x0000A7DB
		public JniArgumentValue(ushort value)
		{
			this = new JniArgumentValue((short)value);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000C5E5 File Offset: 0x0000A7E5
		public JniArgumentValue(int value)
		{
			this = default(JniArgumentValue);
			this.i = value;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000C5F5 File Offset: 0x0000A7F5
		public JniArgumentValue(uint value)
		{
			this = new JniArgumentValue((int)value);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000C5FE File Offset: 0x0000A7FE
		public JniArgumentValue(long value)
		{
			this = default(JniArgumentValue);
			this.j = value;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000C60E File Offset: 0x0000A80E
		public JniArgumentValue(ulong value)
		{
			this = new JniArgumentValue((long)value);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000C617 File Offset: 0x0000A817
		public JniArgumentValue(float value)
		{
			this = default(JniArgumentValue);
			this.f = value;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000C627 File Offset: 0x0000A827
		public JniArgumentValue(double value)
		{
			this = default(JniArgumentValue);
			this.d = value;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000C637 File Offset: 0x0000A837
		public JniArgumentValue(IntPtr value)
		{
			this = default(JniArgumentValue);
			this.l = value;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000C647 File Offset: 0x0000A847
		public JniArgumentValue(JniObjectReference value)
		{
			this = default(JniArgumentValue);
			this.l = value.Handle;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C660 File Offset: 0x0000A860
		public JniArgumentValue(IJavaPeerable value)
		{
			this = default(JniArgumentValue);
			if (value != null)
			{
				this.l = value.PeerReference.Handle;
				return;
			}
			this.l = IntPtr.Zero;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000C697 File Offset: 0x0000A897
		public override int GetHashCode()
		{
			return this.j.GetHashCode();
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		public override bool Equals(object obj)
		{
			JniArgumentValue? jniArgumentValue = obj as JniArgumentValue?;
			return jniArgumentValue != null && this.Equals(jniArgumentValue.Value);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C6D5 File Offset: 0x0000A8D5
		public bool Equals(JniArgumentValue other)
		{
			return this.j == other.j;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public override string ToString()
		{
			return string.Format("JniArgumentValue(z={0},b={1},c={2},s={3},i={4},j={5},f={6},d={7},l=0x{8})", new object[]
			{
				this.z,
				this.b,
				this.c,
				this.s,
				this.i,
				this.j,
				this.f,
				this.d,
				this.l.ToString("x")
			});
		}

		// Token: 0x040000B2 RID: 178
		[FieldOffset(0)]
		private bool z;

		// Token: 0x040000B3 RID: 179
		[FieldOffset(0)]
		private sbyte b;

		// Token: 0x040000B4 RID: 180
		[FieldOffset(0)]
		private char c;

		// Token: 0x040000B5 RID: 181
		[FieldOffset(0)]
		private short s;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(0)]
		private int i;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(0)]
		private long j;

		// Token: 0x040000B8 RID: 184
		[FieldOffset(0)]
		private float f;

		// Token: 0x040000B9 RID: 185
		[FieldOffset(0)]
		private double d;

		// Token: 0x040000BA RID: 186
		[FieldOffset(0)]
		private IntPtr l;
	}
}
