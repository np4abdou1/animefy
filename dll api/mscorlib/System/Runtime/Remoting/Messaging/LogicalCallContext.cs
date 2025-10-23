using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Provides a set of properties that are carried with the execution code path during remote method calls.</summary>
	// Token: 0x0200035D RID: 861
	[SecurityCritical]
	[ComVisible(true)]
	[Serializable]
	public sealed class LogicalCallContext : ISerializable, ICloneable
	{
		// Token: 0x06001B33 RID: 6963 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal LogicalCallContext()
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000756CC File Offset: 0x000738CC
		[SecurityCritical]
		internal LogicalCallContext(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name.Equals("__RemotingData"))
				{
					this.m_RemotingData = (CallContextRemotingData)enumerator.Value;
				}
				else if (enumerator.Name.Equals("__SecurityData"))
				{
					if (context.State == StreamingContextStates.CrossAppDomain)
					{
						this.m_SecurityData = (CallContextSecurityData)enumerator.Value;
					}
				}
				else if (enumerator.Name.Equals("__HostContext"))
				{
					this.m_HostContext = enumerator.Value;
				}
				else if (enumerator.Name.Equals("__CorrelationMgrSlotPresent"))
				{
					this.m_IsCorrelationMgr = (bool)enumerator.Value;
				}
				else
				{
					this.Datastore[enumerator.Name] = enumerator.Value;
				}
			}
		}

		/// <summary>Populates a specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" />.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param>
		/// <param name="context">The contextual information about the source or destination of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have SerializationFormatter permission. </exception>
		// Token: 0x06001B35 RID: 6965 RVA: 0x000757B0 File Offset: 0x000739B0
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.SetType(LogicalCallContext.s_callContextType);
			if (this.m_RemotingData != null)
			{
				info.AddValue("__RemotingData", this.m_RemotingData);
			}
			if (this.m_SecurityData != null && context.State == StreamingContextStates.CrossAppDomain)
			{
				info.AddValue("__SecurityData", this.m_SecurityData);
			}
			if (this.m_HostContext != null)
			{
				info.AddValue("__HostContext", this.m_HostContext);
			}
			if (this.m_IsCorrelationMgr)
			{
				info.AddValue("__CorrelationMgrSlotPresent", this.m_IsCorrelationMgr);
			}
			if (this.HasUserData)
			{
				IDictionaryEnumerator enumerator = this.m_Datastore.GetEnumerator();
				while (enumerator.MoveNext())
				{
					info.AddValue((string)enumerator.Key, enumerator.Value);
				}
			}
		}

		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		// Token: 0x06001B36 RID: 6966 RVA: 0x00075880 File Offset: 0x00073A80
		[SecuritySafeCritical]
		public object Clone()
		{
			LogicalCallContext logicalCallContext = new LogicalCallContext();
			if (this.m_RemotingData != null)
			{
				logicalCallContext.m_RemotingData = (CallContextRemotingData)this.m_RemotingData.Clone();
			}
			if (this.m_SecurityData != null)
			{
				logicalCallContext.m_SecurityData = (CallContextSecurityData)this.m_SecurityData.Clone();
			}
			if (this.m_HostContext != null)
			{
				logicalCallContext.m_HostContext = this.m_HostContext;
			}
			logicalCallContext.m_IsCorrelationMgr = this.m_IsCorrelationMgr;
			if (this.HasUserData)
			{
				IDictionaryEnumerator enumerator = this.m_Datastore.GetEnumerator();
				if (!this.m_IsCorrelationMgr)
				{
					while (enumerator.MoveNext())
					{
						logicalCallContext.Datastore[(string)enumerator.Key] = enumerator.Value;
					}
				}
				else
				{
					while (enumerator.MoveNext())
					{
						string text = (string)enumerator.Key;
						if (text.Equals("System.Diagnostics.Trace.CorrelationManagerSlot"))
						{
							logicalCallContext.Datastore[text] = ((ICloneable)enumerator.Value).Clone();
						}
						else
						{
							logicalCallContext.Datastore[text] = enumerator.Value;
						}
					}
				}
			}
			return logicalCallContext;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00075988 File Offset: 0x00073B88
		[SecurityCritical]
		internal void Merge(LogicalCallContext lc)
		{
			if (lc != null && this != lc && lc.HasUserData)
			{
				IDictionaryEnumerator enumerator = lc.Datastore.GetEnumerator();
				while (enumerator.MoveNext())
				{
					this.Datastore[(string)enumerator.Key] = enumerator.Value;
				}
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</summary>
		/// <returns>A Boolean value indicating whether the current <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> contains information.</returns>
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000759D8 File Offset: 0x00073BD8
		public bool HasInfo
		{
			[SecurityCritical]
			get
			{
				bool result = false;
				if ((this.m_RemotingData != null && this.m_RemotingData.HasInfo) || (this.m_SecurityData != null && this.m_SecurityData.HasInfo) || this.m_HostContext != null || this.HasUserData)
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00075A24 File Offset: 0x00073C24
		private bool HasUserData
		{
			get
			{
				return this.m_Datastore != null && this.m_Datastore.Count > 0;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x00075A3E File Offset: 0x00073C3E
		internal CallContextRemotingData RemotingData
		{
			get
			{
				if (this.m_RemotingData == null)
				{
					this.m_RemotingData = new CallContextRemotingData();
				}
				return this.m_RemotingData;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00075A59 File Offset: 0x00073C59
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

		/// <summary>Retrieves an object associated with the specified name from the current instance.</summary>
		/// <param name="name">The name of the item in the call context. </param>
		/// <returns>The object in the logical call context associated with the specified name.</returns>
		// Token: 0x06001B3C RID: 6972 RVA: 0x00075A74 File Offset: 0x00073C74
		[SecurityCritical]
		public object GetData(string name)
		{
			return this.Datastore[name];
		}

		/// <summary>Stores the specified object in the current instance, and associates it with the specified name.</summary>
		/// <param name="name">The name with which to associate the new item in the call context. </param>
		/// <param name="data">The object to store in the call context. </param>
		// Token: 0x06001B3D RID: 6973 RVA: 0x00075A82 File Offset: 0x00073C82
		[SecurityCritical]
		public void SetData(string name, object data)
		{
			this.Datastore[name] = data;
			if (name.Equals("System.Diagnostics.Trace.CorrelationManagerSlot"))
			{
				this.m_IsCorrelationMgr = true;
			}
		}

		// Token: 0x04000B61 RID: 2913
		private static Type s_callContextType = typeof(LogicalCallContext);

		// Token: 0x04000B62 RID: 2914
		private Hashtable m_Datastore;

		// Token: 0x04000B63 RID: 2915
		private CallContextRemotingData m_RemotingData;

		// Token: 0x04000B64 RID: 2916
		private CallContextSecurityData m_SecurityData;

		// Token: 0x04000B65 RID: 2917
		private object m_HostContext;

		// Token: 0x04000B66 RID: 2918
		private bool m_IsCorrelationMgr;

		// Token: 0x0200035E RID: 862
		internal struct Reader
		{
			// Token: 0x06001B3F RID: 6975 RVA: 0x00075AB6 File Offset: 0x00073CB6
			public Reader(LogicalCallContext ctx)
			{
				this.m_ctx = ctx;
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00075ABF File Offset: 0x00073CBF
			public bool IsNull
			{
				get
				{
					return this.m_ctx == null;
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00075ACA File Offset: 0x00073CCA
			public bool HasInfo
			{
				get
				{
					return !this.IsNull && this.m_ctx.HasInfo;
				}
			}

			// Token: 0x06001B42 RID: 6978 RVA: 0x00075AE1 File Offset: 0x00073CE1
			public LogicalCallContext Clone()
			{
				return (LogicalCallContext)this.m_ctx.Clone();
			}

			// Token: 0x06001B43 RID: 6979 RVA: 0x00075AF3 File Offset: 0x00073CF3
			[SecurityCritical]
			public object GetData(string name)
			{
				if (!this.IsNull)
				{
					return this.m_ctx.GetData(name);
				}
				return null;
			}

			// Token: 0x04000B67 RID: 2919
			private LogicalCallContext m_ctx;
		}
	}
}
