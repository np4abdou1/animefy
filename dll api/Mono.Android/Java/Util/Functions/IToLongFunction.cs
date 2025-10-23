using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033D RID: 829
	[Register("java/util/function/ToLongFunction", "", "Java.Util.Functions.IToLongFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IToLongFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002338 RID: 9016
		long ApplyAsLong(Java.Lang.Object value);
	}
}
