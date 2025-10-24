using System;
using Android.Runtime;

namespace Warkiz.Widgets
{
	// Token: 0x02000005 RID: 5
	[Register("com/warkiz/widget/ColorCollector", "", "Warkiz.Widgets.IColorCollectorInvoker")]
	public interface IColorCollector : IJavaObject, IDisposable
	{
		// Token: 0x060000A0 RID: 160
		[Register("collectSectionTrackColor", "([I)Z", "GetCollectSectionTrackColor_arrayIHandler:Warkiz.Widgets.IColorCollectorInvoker, Warkiz.IndicatorSeekBar")]
		bool CollectSectionTrackColor(int[] colorIntArr);
	}
}
