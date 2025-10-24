using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000340 RID: 832
	[Serializable]
	internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00074A40 File Offset: 0x00072C40
		internal static void RegisterCrossAppDomainChannel()
		{
			object obj = CrossAppDomainChannel.s_lock;
			lock (obj)
			{
				ChannelServices.RegisterChannel(new CrossAppDomainChannel());
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x00074A84 File Offset: 0x00072C84
		public virtual string ChannelName
		{
			get
			{
				return "MONOCAD";
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x00074A8B File Offset: 0x00072C8B
		public virtual int ChannelPriority
		{
			get
			{
				return 100;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00074A8F File Offset: 0x00072C8F
		public virtual object ChannelData
		{
			get
			{
				return new CrossAppDomainData(Thread.GetDomainID());
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void StartListening(object data)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00074A9C File Offset: 0x00072C9C
		public virtual IMessageSink CreateMessageSink(string url, object data, out string uri)
		{
			uri = null;
			if (data != null)
			{
				CrossAppDomainData crossAppDomainData = data as CrossAppDomainData;
				if (crossAppDomainData != null && crossAppDomainData.ProcessID == RemotingConfiguration.ProcessId)
				{
					return CrossAppDomainSink.GetSink(crossAppDomainData.DomainID);
				}
			}
			if (url != null && url.StartsWith("MONOCAD"))
			{
				throw new NotSupportedException("Can't create a named channel via crossappdomain");
			}
			return null;
		}

		// Token: 0x04000B3D RID: 2877
		private static object s_lock = new object();
	}
}
