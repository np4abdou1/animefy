using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000339 RID: 825
	[Register("java/util/function/ToDoubleFunction", "", "Java.Util.Functions.IToDoubleFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IToDoubleFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002320 RID: 8992
		double ApplyAsDouble(Java.Lang.Object value);
	}
}
