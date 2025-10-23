using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Threading;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x0200034D RID: 845
	internal class ActivationServices
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00074EC6 File Offset: 0x000730C6
		private static IActivator ConstructionActivator
		{
			get
			{
				if (ActivationServices._constructionActivator == null)
				{
					ActivationServices._constructionActivator = new ConstructionLevelActivator();
				}
				return ActivationServices._constructionActivator;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00074EE0 File Offset: 0x000730E0
		public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
		{
			ctorCall.SourceProxy = proxy;
			IMessage message;
			if (Thread.CurrentContext.HasExitSinks && !ctorCall.IsContextOk)
			{
				message = Thread.CurrentContext.GetClientContextSinkChain().SyncProcessMessage(ctorCall);
			}
			else
			{
				message = ActivationServices.RemoteActivate(ctorCall);
			}
			if (message is IConstructionReturnMessage && ((IConstructionReturnMessage)message).Exception == null && proxy.ObjectIdentity == null)
			{
				Identity messageTargetIdentity = RemotingServices.GetMessageTargetIdentity(ctorCall);
				proxy.AttachIdentity(messageTargetIdentity);
			}
			return message;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00074F50 File Offset: 0x00073150
		public static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			IMessage result;
			try
			{
				result = ctorCall.Activator.Activate(ctorCall);
			}
			catch (Exception e)
			{
				result = new ReturnMessage(e, ctorCall);
			}
			return result;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00074F88 File Offset: 0x00073188
		public static object CreateProxyFromAttributes(Type type, object[] activationAttributes)
		{
			string text = null;
			foreach (object obj in activationAttributes)
			{
				if (!(obj is IContextAttribute))
				{
					throw new RemotingException("Activation attribute does not implement the IContextAttribute interface");
				}
				if (obj is UrlAttribute)
				{
					text = ((UrlAttribute)obj).UrlValue;
				}
			}
			if (text != null)
			{
				return RemotingServices.CreateClientProxy(type, text, activationAttributes);
			}
			ActivatedClientTypeEntry activatedClientTypeEntry = RemotingConfiguration.IsRemotelyActivatedClientType(type);
			if (activatedClientTypeEntry != null)
			{
				return RemotingServices.CreateClientProxy(activatedClientTypeEntry, activationAttributes);
			}
			if (type.IsContextful)
			{
				return RemotingServices.CreateClientProxyForContextBound(type, activationAttributes);
			}
			return null;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00075008 File Offset: 0x00073208
		public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes)
		{
			ConstructionCall constructionCall = new ConstructionCall(type);
			if (!type.IsContextful)
			{
				constructionCall.Activator = new AppDomainLevelActivator(activationUrl, ActivationServices.ConstructionActivator);
				constructionCall.IsContextOk = false;
				return constructionCall;
			}
			IActivator activator = ActivationServices.ConstructionActivator;
			activator = new ContextLevelActivator(activator);
			ArrayList arrayList = new ArrayList();
			if (activationAttributes != null)
			{
				arrayList.AddRange(activationAttributes);
			}
			bool flag = activationUrl == ChannelServices.CrossContextUrl;
			Context currentContext = Thread.CurrentContext;
			if (flag)
			{
				using (IEnumerator enumerator = arrayList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!((IContextAttribute)enumerator.Current).IsContextOK(currentContext, constructionCall))
						{
							flag = false;
							break;
						}
					}
				}
			}
			foreach (object obj in type.GetCustomAttributes(true))
			{
				if (obj is IContextAttribute)
				{
					flag = (flag && ((IContextAttribute)obj).IsContextOK(currentContext, constructionCall));
					arrayList.Add(obj);
				}
			}
			if (!flag)
			{
				constructionCall.SetActivationAttributes(arrayList.ToArray());
				foreach (object obj2 in arrayList)
				{
					((IContextAttribute)obj2).GetPropertiesForNewContext(constructionCall);
				}
			}
			if (activationUrl != ChannelServices.CrossContextUrl)
			{
				activator = new AppDomainLevelActivator(activationUrl, activator);
			}
			constructionCall.Activator = activator;
			constructionCall.IsContextOk = flag;
			return constructionCall;
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0007518C File Offset: 0x0007338C
		public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			object obj = ActivationServices.AllocateUninitializedClassInstance(ctorCall.ActivationType);
			ServerIdentity serverIdentity = (ServerIdentity)RemotingServices.GetMessageTargetIdentity(ctorCall);
			serverIdentity.AttachServerObject((MarshalByRefObject)obj, Thread.CurrentContext);
			ConstructionCall constructionCall = ctorCall as ConstructionCall;
			if (ctorCall.ActivationType.IsContextful && constructionCall != null && constructionCall.SourceProxy != null)
			{
				constructionCall.SourceProxy.AttachIdentity(serverIdentity);
				RemotingServices.InternalExecuteMessage((MarshalByRefObject)constructionCall.SourceProxy.GetTransparentProxy(), ctorCall);
			}
			else
			{
				ctorCall.MethodBase.Invoke(obj, ctorCall.Args);
			}
			return new ConstructionResponse(obj, null, ctorCall);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00075224 File Offset: 0x00073424
		public static object CreateProxyForType(Type type)
		{
			ActivatedClientTypeEntry activatedClientTypeEntry = RemotingConfiguration.IsRemotelyActivatedClientType(type);
			if (activatedClientTypeEntry != null)
			{
				return RemotingServices.CreateClientProxy(activatedClientTypeEntry, null);
			}
			WellKnownClientTypeEntry wellKnownClientTypeEntry = RemotingConfiguration.IsWellKnownClientType(type);
			if (wellKnownClientTypeEntry != null)
			{
				return RemotingServices.CreateClientProxy(wellKnownClientTypeEntry);
			}
			if (type.IsContextful)
			{
				return RemotingServices.CreateClientProxyForContextBound(type, null);
			}
			return null;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal static void PushActivationAttributes(Type serverType, object[] attributes)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal static void PopActivationAttributes(Type serverType)
		{
		}

		// Token: 0x06001AFD RID: 6909
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object AllocateUninitializedClassInstance(Type type);

		// Token: 0x06001AFE RID: 6910
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableProxyActivation(Type type, bool enable);

		// Token: 0x04000B48 RID: 2888
		private static IActivator _constructionActivator;
	}
}
