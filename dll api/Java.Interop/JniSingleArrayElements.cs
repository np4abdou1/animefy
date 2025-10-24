using System;

namespace Java.Interop
{
	// Token: 0x02000041 RID: 65
	public sealed class JniSingleArrayElements : JniArrayElements
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x0000BD86 File Offset: 0x00009F86
		internal unsafe JniSingleArrayElements(JniObjectReference arrayHandle, float* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe float* Elements
		{
			get
			{
				return (float*)((void*)base.Elements);
			}
		}

		// Token: 0x17000054 RID: 84
		public unsafe float this[int index]
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

		// Token: 0x060002AB RID: 683 RVA: 0x0000BDC2 File Offset: 0x00009FC2
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseFloatArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x040000A4 RID: 164
		private JniObjectReference arrayHandle;
	}
}
