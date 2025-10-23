using System;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200036D RID: 877
	internal class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06001B92 RID: 7058 RVA: 0x00076CB5 File Offset: 0x00074EB5
		public ConstructionCallDictionary(IConstructionCallMessage message) : base(message)
		{
			base.MethodKeys = ConstructionCallDictionary.InternalKeys;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00076CCC File Offset: 0x00074ECC
		protected override object GetMethodProperty(string key)
		{
			if (key == "__Activator")
			{
				return ((IConstructionCallMessage)this._message).Activator;
			}
			if (key == "__CallSiteActivationAttributes")
			{
				return ((IConstructionCallMessage)this._message).CallSiteActivationAttributes;
			}
			if (key == "__ActivationType")
			{
				return ((IConstructionCallMessage)this._message).ActivationType;
			}
			if (key == "__ContextProperties")
			{
				return ((IConstructionCallMessage)this._message).ContextProperties;
			}
			if (!(key == "__ActivationTypeName"))
			{
				return base.GetMethodProperty(key);
			}
			return ((IConstructionCallMessage)this._message).ActivationTypeName;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00076D78 File Offset: 0x00074F78
		protected override void SetMethodProperty(string key, object value)
		{
			if (key == "__Activator")
			{
				((IConstructionCallMessage)this._message).Activator = (IActivator)value;
				return;
			}
			if (!(key == "__CallSiteActivationAttributes") && !(key == "__ActivationType") && !(key == "__ContextProperties") && !(key == "__ActivationTypeName"))
			{
				base.SetMethodProperty(key, value);
				return;
			}
			throw new ArgumentException("key was invalid");
		}

		// Token: 0x04000B9C RID: 2972
		public static string[] InternalKeys = new string[]
		{
			"__Uri",
			"__MethodName",
			"__TypeName",
			"__MethodSignature",
			"__Args",
			"__CallContext",
			"__CallSiteActivationAttributes",
			"__ActivationType",
			"__ContextProperties",
			"__Activator",
			"__ActivationTypeName"
		};
	}
}
