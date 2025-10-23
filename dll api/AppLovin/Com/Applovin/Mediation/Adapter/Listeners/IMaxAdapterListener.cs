using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000117 RID: 279
	[Register("com/applovin/mediation/adapter/listeners/MaxAdapterListener", "", "Com.Applovin.Mediation.Adapter.Listeners.IMaxAdapterListenerInvoker")]
	public interface IMaxAdapterListener : IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
