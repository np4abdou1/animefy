using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000335 RID: 821
	[Register("java/util/function/IntFunction", "", "Java.Util.Functions.IIntFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IIntFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060022FC RID: 8956
		Java.Lang.Object Apply(int value);
	}
}
