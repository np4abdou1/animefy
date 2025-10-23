using System;

namespace Java.Interop
{
	// Token: 0x02000009 RID: 9
	public abstract class JniArrayElements : IDisposable
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000264A File Offset: 0x0000084A
		internal JniArrayElements(IntPtr elements, int size)
		{
			if (elements == IntPtr.Zero)
			{
				throw new ArgumentException("'elements' must not be IntPtr.Zero.", "elements");
			}
			this.elements = elements;
			this.size = size;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000267D File Offset: 0x0000087D
		internal bool IsDisposed
		{
			get
			{
				return this.elements == IntPtr.Zero;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000268F File Offset: 0x0000088F
		public IntPtr Elements
		{
			get
			{
				if (this.IsDisposed)
				{
					throw new ObjectDisposedException(base.GetType().FullName);
				}
				return this.elements;
			}
		}

		// Token: 0x0600004A RID: 74
		protected abstract void Synchronize(JniReleaseArrayElementsMode releaseMode);

		// Token: 0x0600004B RID: 75 RVA: 0x000026B0 File Offset: 0x000008B0
		public void Release(JniReleaseArrayElementsMode releaseMode)
		{
			if (this.IsDisposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			this.Synchronize(releaseMode);
			this.elements = IntPtr.Zero;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026DD File Offset: 0x000008DD
		public void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}
			this.Release(JniReleaseArrayElementsMode.Default);
		}

		// Token: 0x0400000A RID: 10
		private IntPtr elements;

		// Token: 0x0400000B RID: 11
		private int size;
	}
}
