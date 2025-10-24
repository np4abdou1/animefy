using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	// Token: 0x02000306 RID: 774
	internal abstract class Identity
	{
		// Token: 0x06001960 RID: 6496 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		public Identity(string objectUri)
		{
			this._objectUri = objectUri;
		}

		// Token: 0x06001961 RID: 6497
		public abstract ObjRef CreateObjRef(Type requestedType);

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0006EA3B File Offset: 0x0006CC3B
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0006EA43 File Offset: 0x0006CC43
		public IMessageSink ChannelSink
		{
			get
			{
				return this._channelSink;
			}
			set
			{
				this._channelSink = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0006EA4C File Offset: 0x0006CC4C
		public IMessageSink EnvoySink
		{
			get
			{
				return this._envoySink;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x0006EA54 File Offset: 0x0006CC54
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x0006EA5C File Offset: 0x0006CC5C
		public string ObjectUri
		{
			get
			{
				return this._objectUri;
			}
			set
			{
				this._objectUri = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x0006EA65 File Offset: 0x0006CC65
		public bool IsConnected
		{
			get
			{
				return this._objectUri != null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0006EA70 File Offset: 0x0006CC70
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0006EA78 File Offset: 0x0006CC78
		public bool Disposed
		{
			get
			{
				return this._disposed;
			}
			set
			{
				this._disposed = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0006EA81 File Offset: 0x0006CC81
		public bool HasServerDynamicSinks
		{
			get
			{
				return this._serverDynamicProperties != null && this._serverDynamicProperties.HasProperties;
			}
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0006EA98 File Offset: 0x0006CC98
		public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this._clientDynamicProperties != null && this._clientDynamicProperties.HasProperties)
			{
				this._clientDynamicProperties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0006EABF File Offset: 0x0006CCBF
		public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this._serverDynamicProperties != null && this._serverDynamicProperties.HasProperties)
			{
				this._serverDynamicProperties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x04000A94 RID: 2708
		protected string _objectUri;

		// Token: 0x04000A95 RID: 2709
		protected IMessageSink _channelSink;

		// Token: 0x04000A96 RID: 2710
		protected IMessageSink _envoySink;

		// Token: 0x04000A97 RID: 2711
		private DynamicPropertyCollection _clientDynamicProperties;

		// Token: 0x04000A98 RID: 2712
		private DynamicPropertyCollection _serverDynamicProperties;

		// Token: 0x04000A99 RID: 2713
		protected ObjRef _objRef;

		// Token: 0x04000A9A RID: 2714
		private bool _disposed;
	}
}
