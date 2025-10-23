using System;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002C6 RID: 710
	public static class Extensions
	{
		// Token: 0x06001AF1 RID: 6897 RVA: 0x000465EA File Offset: 0x000447EA
		public static TResult JavaCast<TResult>(this IJavaObject instance) where TResult : class, IJavaObject
		{
			return instance.JavaCast<TResult>();
		}
	}
}
