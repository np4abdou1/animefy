using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033B RID: 827
	[Register("java/util/function/ToIntFunction", "", "Java.Util.Functions.IToIntFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IToIntFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600232C RID: 9004
		int ApplyAsInt(Java.Lang.Object value);
	}
}
