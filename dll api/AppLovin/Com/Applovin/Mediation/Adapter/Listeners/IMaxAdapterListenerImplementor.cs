using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000119 RID: 281
	[Register("mono/com/applovin/mediation/adapter/listeners/MaxAdapterListenerImplementor")]
	internal sealed class IMaxAdapterListenerImplementor : Java.Lang.Object, IMaxAdapterListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x00020A13 File Offset: 0x0001EC13
		public IMaxAdapterListenerImplementor() : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/adapter/listeners/MaxAdapterListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00020A45 File Offset: 0x0001EC45
		internal static bool __IsEmpty(IMaxAdapterListenerImplementor value)
		{
			return true;
		}
	}
}
