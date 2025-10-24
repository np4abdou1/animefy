using System;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002C8 RID: 712
	[JniValueMarshaler(typeof(IJavaObjectValueMarshaler))]
	public interface IJavaObject : IDisposable
	{
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001AF3 RID: 6899
		IntPtr Handle { get; }
	}
}
