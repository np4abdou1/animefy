using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000373 RID: 883
	internal interface IInternalMessage
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001BAD RID: 7085
		// (set) Token: 0x06001BAE RID: 7086
		Identity TargetIdentity { get; set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001BAF RID: 7087
		// (set) Token: 0x06001BB0 RID: 7088
		string Uri { get; set; }

		// Token: 0x06001BB1 RID: 7089
		bool HasProperties();
	}
}
