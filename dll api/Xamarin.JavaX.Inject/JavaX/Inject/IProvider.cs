using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace JavaX.Inject
{
	// Token: 0x0200000B RID: 11
	[Register("javax/inject/Provider", "", "JavaX.Inject.IProviderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600003D RID: 61
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler:JavaX.Inject.IProviderInvoker, Xamarin.JavaX.Inject")]
		Java.Lang.Object Get();
	}
}
