using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Defines an environment for the objects that are resident inside it and for which a policy can be enforced.</summary>
	// Token: 0x0200032C RID: 812
	[ComVisible(true)]
	[StructLayout(0)]
	public class Context
	{
		// Token: 0x06001A7B RID: 6779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterContext(Context ctx);

		// Token: 0x06001A7C RID: 6780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ReleaseContext(Context ctx);

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> class.</summary>
		// Token: 0x06001A7D RID: 6781 RVA: 0x0007350B File Offset: 0x0007170B
		public Context()
		{
			this.domain_id = Thread.GetDomainID();
			this.context_id = Interlocked.Increment(ref Context.global_count);
			Context.RegisterContext(this);
		}

		/// <summary>Cleans up the backing objects for the nondefault contexts.</summary>
		// Token: 0x06001A7E RID: 6782 RVA: 0x00073534 File Offset: 0x00071734
		~Context()
		{
			Context.ReleaseContext(this);
		}

		/// <summary>Gets the default context for the current application domain.</summary>
		/// <returns>The default context for the <see cref="T:System.AppDomain" /> namespace.</returns>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00073560 File Offset: 0x00071760
		public static Context DefaultContext
		{
			get
			{
				return AppDomain.InternalGetDefaultContext();
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00073567 File Offset: 0x00071767
		internal bool IsDefaultContext
		{
			get
			{
				return this.context_id == 0;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00073572 File Offset: 0x00071772
		internal bool NeedsContextSink
		{
			get
			{
				return this.context_id != 0 || (Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties) || (this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties);
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000735A6 File Offset: 0x000717A6
		internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties)
			{
				Context.global_dynamic_properties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x000735C9 File Offset: 0x000717C9
		internal static bool HasGlobalDynamicSinks
		{
			get
			{
				return Context.global_dynamic_properties != null && Context.global_dynamic_properties.HasProperties;
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000735DE File Offset: 0x000717DE
		internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
			if (this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties)
			{
				this.context_dynamic_properties.NotifyMessage(start, req_msg, client_site, async);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00073605 File Offset: 0x00071805
		internal bool HasDynamicSinks
		{
			get
			{
				return this.context_dynamic_properties != null && this.context_dynamic_properties.HasProperties;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0007361C File Offset: 0x0007181C
		internal bool HasExitSinks
		{
			get
			{
				return !(this.GetClientContextSinkChain() is ClientContextTerminatorSink) || this.HasDynamicSinks || Context.HasGlobalDynamicSinks;
			}
		}

		/// <summary>Returns a specific context property, specified by name.</summary>
		/// <param name="name">The name of the property. </param>
		/// <returns>The specified context property.</returns>
		// Token: 0x06001A87 RID: 6791 RVA: 0x0007363C File Offset: 0x0007183C
		public virtual IContextProperty GetProperty(string name)
		{
			if (this.context_properties == null)
			{
				return null;
			}
			foreach (IContextProperty contextProperty in this.context_properties)
			{
				if (contextProperty.Name == name)
				{
					return contextProperty;
				}
			}
			return null;
		}

		/// <summary>Sets a specific context property by name.</summary>
		/// <param name="prop">The actual context property. </param>
		/// <exception cref="T:System.InvalidOperationException">There is an attempt to add properties to the default context. </exception>
		/// <exception cref="T:System.InvalidOperationException">The context is frozen. </exception>
		/// <exception cref="T:System.ArgumentNullException">The property or the property name is <see langword="null" />. </exception>
		// Token: 0x06001A88 RID: 6792 RVA: 0x000736A8 File Offset: 0x000718A8
		public virtual void SetProperty(IContextProperty prop)
		{
			if (prop == null)
			{
				throw new ArgumentNullException("IContextProperty");
			}
			if (this == Context.DefaultContext)
			{
				throw new InvalidOperationException("Can not add properties to default context");
			}
			if (this.context_properties == null)
			{
				this.context_properties = new List<IContextProperty>();
			}
			this.context_properties.Add(prop);
		}

		/// <summary>Freezes the context, making it impossible to add or remove context properties from the current context.</summary>
		/// <exception cref="T:System.InvalidOperationException">The context is already frozen. </exception>
		// Token: 0x06001A89 RID: 6793 RVA: 0x000736F8 File Offset: 0x000718F8
		public virtual void Freeze()
		{
			if (this.context_properties != null)
			{
				foreach (IContextProperty contextProperty in this.context_properties)
				{
					contextProperty.Freeze(this);
				}
			}
		}

		/// <summary>Returns a <see cref="T:System.String" /> class representation of the current context.</summary>
		/// <returns>A <see cref="T:System.String" /> class representation of the current context.</returns>
		// Token: 0x06001A8A RID: 6794 RVA: 0x00073754 File Offset: 0x00071954
		public override string ToString()
		{
			return "ContextID: " + this.context_id.ToString();
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0007376C File Offset: 0x0007196C
		internal IMessageSink GetServerContextSinkChain()
		{
			if (this.server_context_sink_chain == null)
			{
				if (Context.default_server_context_sink == null)
				{
					Context.default_server_context_sink = new ServerContextTerminatorSink();
				}
				this.server_context_sink_chain = Context.default_server_context_sink;
				if (this.context_properties != null)
				{
					for (int i = this.context_properties.Count - 1; i >= 0; i--)
					{
						IContributeServerContextSink contributeServerContextSink = this.context_properties[i] as IContributeServerContextSink;
						if (contributeServerContextSink != null)
						{
							this.server_context_sink_chain = contributeServerContextSink.GetServerContextSink(this.server_context_sink_chain);
						}
					}
				}
			}
			return this.server_context_sink_chain;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000737EC File Offset: 0x000719EC
		internal IMessageSink GetClientContextSinkChain()
		{
			if (this.client_context_sink_chain == null)
			{
				this.client_context_sink_chain = new ClientContextTerminatorSink(this);
				if (this.context_properties != null)
				{
					foreach (IContextProperty contextProperty in this.context_properties)
					{
						IContributeClientContextSink contributeClientContextSink = contextProperty as IContributeClientContextSink;
						if (contributeClientContextSink != null)
						{
							this.client_context_sink_chain = contributeClientContextSink.GetClientContextSink(this.client_context_sink_chain);
						}
					}
				}
			}
			return this.client_context_sink_chain;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00073874 File Offset: 0x00071A74
		internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute)
		{
			IMessageSink messageSink = new StackBuilderSink(obj, forceInternalExecute);
			messageSink = new ServerObjectTerminatorSink(messageSink);
			messageSink = new LeaseSink(messageSink);
			if (this.context_properties != null)
			{
				for (int i = this.context_properties.Count - 1; i >= 0; i--)
				{
					IContributeObjectSink contributeObjectSink = this.context_properties[i] as IContributeObjectSink;
					if (contributeObjectSink != null)
					{
						messageSink = contributeObjectSink.GetObjectSink(obj, messageSink);
					}
				}
			}
			return messageSink;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000738D8 File Offset: 0x00071AD8
		internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			IMessageSink messageSink = EnvoyTerminatorSink.Instance;
			if (this.context_properties != null)
			{
				foreach (IContextProperty contextProperty in this.context_properties)
				{
					IContributeEnvoySink contributeEnvoySink = contextProperty as IContributeEnvoySink;
					if (contributeEnvoySink != null)
					{
						messageSink = contributeEnvoySink.GetEnvoySink(serverObject, messageSink);
					}
				}
			}
			return messageSink;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00073944 File Offset: 0x00071B44
		internal static Context SwitchToContext(Context newContext)
		{
			return AppDomain.InternalSetContext(newContext);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0007394C File Offset: 0x00071B4C
		internal static Context CreateNewContext(IConstructionCallMessage msg)
		{
			Context context = new Context();
			foreach (object obj in msg.ContextProperties)
			{
				IContextProperty contextProperty = (IContextProperty)obj;
				if (context.GetProperty(contextProperty.Name) == null)
				{
					context.SetProperty(contextProperty);
				}
			}
			context.Freeze();
			using (IEnumerator enumerator = msg.ContextProperties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!((IContextProperty)enumerator.Current).IsNewContextOK(context))
					{
						throw new RemotingException("A context property did not approve the candidate context for activating the object");
					}
				}
			}
			return context;
		}

		// Token: 0x04000B14 RID: 2836
		private int domain_id;

		// Token: 0x04000B15 RID: 2837
		private int context_id;

		// Token: 0x04000B16 RID: 2838
		private UIntPtr static_data;

		// Token: 0x04000B17 RID: 2839
		private UIntPtr data;

		// Token: 0x04000B18 RID: 2840
		[ContextStatic]
		private static object[] local_slots;

		// Token: 0x04000B19 RID: 2841
		private static IMessageSink default_server_context_sink;

		// Token: 0x04000B1A RID: 2842
		private IMessageSink server_context_sink_chain;

		// Token: 0x04000B1B RID: 2843
		private IMessageSink client_context_sink_chain;

		// Token: 0x04000B1C RID: 2844
		private List<IContextProperty> context_properties;

		// Token: 0x04000B1D RID: 2845
		private static int global_count;

		// Token: 0x04000B1E RID: 2846
		private volatile LocalDataStoreHolder _localDataStore;

		// Token: 0x04000B1F RID: 2847
		private static LocalDataStoreMgr _localDataStoreMgr = new LocalDataStoreMgr();

		// Token: 0x04000B20 RID: 2848
		private static DynamicPropertyCollection global_dynamic_properties;

		// Token: 0x04000B21 RID: 2849
		private DynamicPropertyCollection context_dynamic_properties;

		// Token: 0x04000B22 RID: 2850
		private ContextCallbackObject callback_object;
	}
}
