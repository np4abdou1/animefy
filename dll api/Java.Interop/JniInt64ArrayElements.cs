using System;

namespace Java.Interop
{
	// Token: 0x0200003D RID: 61
	public sealed class JniInt64ArrayElements : JniArrayElements
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0000BA36 File Offset: 0x00009C36
		internal unsafe JniInt64ArrayElements(JniObjectReference arrayHandle, long* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe long* Elements
		{
			get
			{
				return (long*)((void*)base.Elements);
			}
		}

		// Token: 0x17000052 RID: 82
		public unsafe long this[int index]
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

		// Token: 0x06000295 RID: 661 RVA: 0x0000BA72 File Offset: 0x00009C72
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseLongArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x0400009F RID: 159
		private JniObjectReference arrayHandle;
	}
}
