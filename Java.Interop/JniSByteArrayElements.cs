using System;

namespace Java.Interop
{
	// Token: 0x0200002D RID: 45
	public sealed class JniSByteArrayElements : JniArrayElements
	{
		// Token: 0x0600023A RID: 570 RVA: 0x0000AD07 File Offset: 0x00008F07
		internal unsafe JniSByteArrayElements(JniObjectReference arrayHandle, sbyte* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe sbyte* Elements
		{
			get
			{
				return (sbyte*)((void*)base.Elements);
			}
		}

		// Token: 0x1700004A RID: 74
		public unsafe sbyte this[int index]
		{
			get
			{
				if (base.IsDisposed)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				return ref this.Elements[index];
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000AD40 File Offset: 0x00008F40
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseByteArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x0400008B RID: 139
		private JniObjectReference arrayHandle;
	}
}
