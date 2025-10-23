using System;

namespace Java.Interop
{
	// Token: 0x02000029 RID: 41
	public sealed class JniBooleanArrayElements : JniArrayElements
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000A9B3 File Offset: 0x00008BB3
		internal unsafe JniBooleanArrayElements(JniObjectReference arrayHandle, bool* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe bool* Elements
		{
			get
			{
				return (bool*)((void*)base.Elements);
			}
		}

		// Token: 0x17000048 RID: 72
		public unsafe bool this[int index]
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

		// Token: 0x06000227 RID: 551 RVA: 0x0000A9F9 File Offset: 0x00008BF9
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseBooleanArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x04000086 RID: 134
		private JniObjectReference arrayHandle;
	}
}
