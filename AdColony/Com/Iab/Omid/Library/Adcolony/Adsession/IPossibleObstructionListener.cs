using System;
using System.Collections.Generic;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002F RID: 47
	[Register("com/iab/omid/library/adcolony/adsession/PossibleObstructionListener", "", "Com.Iab.Omid.Library.Adcolony.Adsession.IPossibleObstructionListenerInvoker")]
	public interface IPossibleObstructionListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000187 RID: 391
		[Register("onPossibleObstructionsDetected", "(Ljava/lang/String;Ljava/util/List;)V", "GetOnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_Handler:Com.Iab.Omid.Library.Adcolony.Adsession.IPossibleObstructionListenerInvoker, AdColony")]
		void OnPossibleObstructionsDetected(string p0, IList<View> p1);
	}
}
