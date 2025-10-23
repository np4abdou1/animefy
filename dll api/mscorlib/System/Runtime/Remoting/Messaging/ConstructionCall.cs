using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> interface to create a request message that constitutes a constructor call on a remote object.</summary>
	// Token: 0x0200036C RID: 876
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00076ABB File Offset: 0x00074CBB
		internal ConstructionCall(Type type)
		{
			this._activationType = type;
			this._activationTypeName = type.AssemblyQualifiedName;
			this._isContextOk = true;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00076ADD File Offset: 0x00074CDD
		internal ConstructionCall(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00076AE8 File Offset: 0x00074CE8
		internal override void InitDictionary()
		{
			ConstructionCallDictionary constructionCallDictionary = new ConstructionCallDictionary(this);
			this.ExternalProperties = constructionCallDictionary;
			this.InternalProperties = constructionCallDictionary.GetInternalProperties();
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00076B0F File Offset: 0x00074D0F
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x00076B17 File Offset: 0x00074D17
		internal bool IsContextOk
		{
			get
			{
				return this._isContextOk;
			}
			set
			{
				this._isContextOk = value;
			}
		}

		/// <summary>Gets the type of the remote object to activate. </summary>
		/// <returns>The <see cref="T:System.Type" /> of the remote object to activate.</returns>
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00076B20 File Offset: 0x00074D20
		public Type ActivationType
		{
			get
			{
				if (this._activationType == null)
				{
					this._activationType = Type.GetType(this._activationTypeName);
				}
				return this._activationType;
			}
		}

		/// <summary>Gets the full type name of the remote object to activate. </summary>
		/// <returns>A <see cref="T:System.String" /> containing the full type name of the remote object to activate.</returns>
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00076B47 File Offset: 0x00074D47
		public string ActivationTypeName
		{
			get
			{
				return this._activationTypeName;
			}
		}

		/// <summary>Gets or sets the activator that activates the remote object. </summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.Activation.IActivator" /> that activates the remote object.</returns>
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00076B4F File Offset: 0x00074D4F
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00076B57 File Offset: 0x00074D57
		public IActivator Activator
		{
			get
			{
				return this._activator;
			}
			set
			{
				this._activator = value;
			}
		}

		/// <summary>Gets the call site activation attributes for the remote object. </summary>
		/// <returns>An array of type <see cref="T:System.Object" /> containing the call site activation attributes for the remote object.</returns>
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00076B60 File Offset: 0x00074D60
		public object[] CallSiteActivationAttributes
		{
			get
			{
				return this._activationAttributes;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00076B68 File Offset: 0x00074D68
		internal void SetActivationAttributes(object[] attributes)
		{
			this._activationAttributes = attributes;
		}

		/// <summary>Gets a list of properties that define the context in which the remote object is to be created. </summary>
		/// <returns>A <see cref="T:System.Collections.IList" /> that contains a list of properties that define the context in which the remote object is to be created.</returns>
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00076B71 File Offset: 0x00074D71
		public IList ContextProperties
		{
			get
			{
				if (this._contextProperties == null)
				{
					this._contextProperties = new ArrayList();
				}
				return this._contextProperties;
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x00076B8C File Offset: 0x00074D8C
		internal override void InitMethodProperty(string key, object value)
		{
			if (key == "__Activator")
			{
				this._activator = (IActivator)value;
				return;
			}
			if (key == "__CallSiteActivationAttributes")
			{
				this._activationAttributes = (object[])value;
				return;
			}
			if (key == "__ActivationType")
			{
				this._activationType = (Type)value;
				return;
			}
			if (key == "__ContextProperties")
			{
				this._contextProperties = (IList)value;
				return;
			}
			if (!(key == "__ActivationTypeName"))
			{
				base.InitMethodProperty(key, value);
				return;
			}
			this._activationTypeName = (string)value;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00076C28 File Offset: 0x00074E28
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			IList list = this._contextProperties;
			if (list != null && list.Count == 0)
			{
				list = null;
			}
			info.AddValue("__Activator", this._activator);
			info.AddValue("__CallSiteActivationAttributes", this._activationAttributes);
			info.AddValue("__ActivationType", null);
			info.AddValue("__ContextProperties", list);
			info.AddValue("__ActivationTypeName", this._activationTypeName);
		}

		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00076C9C File Offset: 0x00074E9C
		public override IDictionary Properties
		{
			get
			{
				return base.Properties;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00076CA4 File Offset: 0x00074EA4
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x00076CAC File Offset: 0x00074EAC
		internal RemotingProxy SourceProxy
		{
			get
			{
				return this._sourceProxy;
			}
			set
			{
				this._sourceProxy = value;
			}
		}

		// Token: 0x04000B95 RID: 2965
		private IActivator _activator;

		// Token: 0x04000B96 RID: 2966
		private object[] _activationAttributes;

		// Token: 0x04000B97 RID: 2967
		private IList _contextProperties;

		// Token: 0x04000B98 RID: 2968
		private Type _activationType;

		// Token: 0x04000B99 RID: 2969
		private string _activationTypeName;

		// Token: 0x04000B9A RID: 2970
		private bool _isContextOk;

		// Token: 0x04000B9B RID: 2971
		[NonSerialized]
		private RemotingProxy _sourceProxy;
	}
}
