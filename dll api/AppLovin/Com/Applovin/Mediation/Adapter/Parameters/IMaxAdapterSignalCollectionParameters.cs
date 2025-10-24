using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapter.Parameters
{
	// Token: 0x02000115 RID: 277
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters", "", "Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterSignalCollectionParametersInvoker")]
	public interface IMaxAdapterSignalCollectionParameters : IMaxAdapterParameters, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000BDE RID: 3038
		MaxAdFormat AdFormat { [Register("getAdFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "GetGetAdFormatHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterSignalCollectionParametersInvoker, AppLovin")] get; }
	}
}
