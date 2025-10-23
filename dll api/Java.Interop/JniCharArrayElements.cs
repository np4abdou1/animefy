using System;

namespace Java.Interop
{
	// Token: 0x02000031 RID: 49
	public sealed class JniCharArrayElements : JniArrayElements
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0000B04F File Offset: 0x0000924F
		internal unsafe JniCharArrayElements(JniObjectReference arrayHandle, char* elements, int size) : base((IntPtr)((void*)elements), size)
		{
			this.arrayHandle = arrayHandle;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000A9C9 File Offset: 0x00008BC9
		public new unsafe char* Elements
		{
			get
			{
				return (char*)((void*)base.Elements);
			}
		}

		// Token: 0x1700004C RID: 76
		public unsafe char this[int index]
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

		// Token: 0x06000253 RID: 595 RVA: 0x0000B08B File Offset: 0x0000928B
		protected override void Synchronize(JniReleaseArrayElementsMode releaseMode)
		{
			JniEnvironment.Arrays.ReleaseCharArrayElements(this.arrayHandle, this.Elements, releaseMode);
		}

		// Token: 0x04000090 RID: 144
		private JniObjectReference arrayHandle;
	}
}
