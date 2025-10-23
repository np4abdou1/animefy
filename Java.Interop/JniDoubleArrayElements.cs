using System;

namespace Java.Interop
{
	// Token: 0x02000045 RID: 69
	public sealed class JniDoubleArrayElements : JniArrayElements
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000C0D6 File Offset: 0x0000A2D6
		internal unsafe JniDoubleArrayElements(JniObjectReference arrayHandle, double* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe double* Elements
		{
			get
			{
				return (double*)((void*)base.Elements);
			}
		}

		// Token: 0x17000056 RID: 86
		public unsafe double this[int index]
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

		// Token: 0x060002C1 RID: 705 RVA: 0x0000C112 File Offset: 0x0000A312
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseDoubleArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x040000A9 RID: 169
		private JniObjectReference arrayHandle;
	}
}
