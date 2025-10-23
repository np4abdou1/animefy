using System;

namespace Java.Interop
{
	// Token: 0x02000035 RID: 53
	public sealed class JniInt16ArrayElements : JniArrayElements
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0000B39E File Offset: 0x0000959E
		internal unsafe JniInt16ArrayElements(JniObjectReference arrayHandle, short* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe short* Elements
		{
			get
			{
				return (short*)((void*)base.Elements);
			}
		}

		// Token: 0x1700004E RID: 78
		public unsafe short this[int index]
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

		// Token: 0x06000269 RID: 617 RVA: 0x0000B3DA File Offset: 0x000095DA
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseShortArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x04000095 RID: 149
		private JniObjectReference arrayHandle;
	}
}
