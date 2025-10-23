using System;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200035C RID: 860
	internal class IllogicalCallContext
	{
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0007561C File Offset: 0x0007381C
		private Hashtable Datastore
		{
			get
			{
				if (this.m_Datastore == null)
				{
					this.m_Datastore = new Hashtable();
				}
				return this.m_Datastore;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00075637 File Offset: 0x00073837
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0007563F File Offset: 0x0007383F
		internal object HostContext
		{
			get
			{
				return this.m_HostContext;
			}
			set
			{
				this.m_HostContext = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00075648 File Offset: 0x00073848
		internal bool HasUserData
		{
			get
			{
				return this.m_Datastore != null && this.m_Datastore.Count > 0;
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00075662 File Offset: 0x00073862
		public void FreeNamedDataSlot(string name)
		{
			this.Datastore.Remove(name);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00075670 File Offset: 0x00073870
		public IllogicalCallContext CreateCopy()
		{
			IllogicalCallContext illogicalCallContext = new IllogicalCallContext();
			illogicalCallContext.HostContext = this.HostContext;
			if (this.HasUserData)
			{
				IDictionaryEnumerator enumerator = this.m_Datastore.GetEnumerator();
				while (enumerator.MoveNext())
				{
					illogicalCallContext.Datastore[(string)enumerator.Key] = enumerator.Value;
				}
			}
			return illogicalCallContext;
		}

		// Token: 0x04000B5F RID: 2911
		private Hashtable m_Datastore;

		// Token: 0x04000B60 RID: 2912
		private object m_HostContext;
	}
}
