using System;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Contracts
{
	// Token: 0x02000275 RID: 629
	[Register("kotlin/contracts/Effect", "", "Kotlin.Contracts.IEffectInvoker")]
	public interface IEffect : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
