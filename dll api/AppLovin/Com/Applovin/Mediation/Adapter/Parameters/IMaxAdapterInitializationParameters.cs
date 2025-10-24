using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Parameters
{
	// Token: 0x0200010F RID: 271
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters", "", "Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterInitializationParametersInvoker")]
	public interface IMaxAdapterInitializationParameters : IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
