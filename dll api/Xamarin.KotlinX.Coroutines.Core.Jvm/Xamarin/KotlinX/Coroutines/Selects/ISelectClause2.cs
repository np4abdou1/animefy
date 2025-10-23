using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000099 RID: 153
	[Register("kotlinx/coroutines/selects/SelectClause2", "", "Xamarin.KotlinX.Coroutines.Selects.ISelectClause2Invoker")]
	[JavaTypeParameters(new string[]
	{
		"P",
		"Q"
	})]
	public interface ISelectClause2 : ISelectClause, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
