using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000044 RID: 68
	[Register("com/iab/omid/library/applovin/adsession/PossibleObstructionListener", "", "Com.Iab.Omid.Library.Applovin.Adsession.IPossibleObstructionListenerInvoker")]
	public interface IPossibleObstructionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001DE RID: 478
		[Register("onPossibleObstructionsDetected", "(Ljava/lang/String;Ljava/util/List;)V", "GetOnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_Handler:Com.Iab.Omid.Library.Applovin.Adsession.IPossibleObstructionListenerInvoker, AppLovin")]
		void OnPossibleObstructionsDetected(string p0, IList<View> p1);
	}
}
