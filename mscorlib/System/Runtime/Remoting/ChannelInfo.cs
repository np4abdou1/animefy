using System;
using System.Runtime.Remoting.Channels;

namespace System.Runtime.Remoting
{
	// Token: 0x020002FE RID: 766
	[Serializable]
	internal class ChannelInfo : IChannelInfo
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x0006E8DF File Offset: 0x0006CADF
		public ChannelInfo()
		{
			this.channelData = ChannelServices.GetCurrentChannelInfo();
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0006E8F2 File Offset: 0x0006CAF2
		public ChannelInfo(object remoteChannelData)
		{
			this.channelData = new object[]
			{
				remoteChannelData
			};
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x0006E90A File Offset: 0x0006CB0A
		public object[] ChannelData
		{
			get
			{
				return this.channelData;
			}
		}

		// Token: 0x04000A8B RID: 2699
		private object[] channelData;
	}
}
