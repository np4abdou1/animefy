using System;

namespace Java.Interop
{
	// Token: 0x02000039 RID: 57
	public sealed class JniInt32ArrayElements : JniArrayElements
	{
		// Token: 0x0600027C RID: 636 RVA: 0x0000B6EA File Offset: 0x000098EA
		internal unsafe JniInt32ArrayElements(JniObjectReference arrayHandle, int* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe int* Elements
		{
			get
			{
				return (int*)((void*)base.Elements);
			}
		}

		// Token: 0x17000050 RID: 80
		public unsafe int this[int index]
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

		// Token: 0x0600027F RID: 639 RVA: 0x0000B726 File Offset: 0x00009926
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseIntArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x0400009A RID: 154
		private JniObjectReference arrayHandle;
	}
}
