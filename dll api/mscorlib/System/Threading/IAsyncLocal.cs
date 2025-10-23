using System;

namespace System.Threading
{
	// Token: 0x020001A3 RID: 419
	internal interface IAsyncLocal
	{
		// Token: 0x06001042 RID: 4162
		void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
	}
}
