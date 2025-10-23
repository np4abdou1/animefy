using System;
using System.Reflection;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Proxies
{
	// Token: 0x02000323 RID: 803
	internal class RemotingProxy : RealProxy, IRemotingTypeInfo
	{
		// Token: 0x06001A4B RID: 6731 RVA: 0x00072BD2 File Offset: 0x00070DD2
		internal RemotingProxy(Type type, ClientIdentity identity) : base(type, identity)
		{
			this._sink = identity.ChannelSink;
			this._hasEnvoySink = false;
			this._targetUri = identity.TargetUri;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00072BFB File Offset: 0x00070DFB
		internal RemotingProxy(Type type, string activationUrl, object[] activationAttributes) : base(type)
		{
			this._hasEnvoySink = false;
			this._ctorCall = ActivationServices.CreateConstructionCall(type, activationUrl, activationAttributes);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00072C1C File Offset: 0x00070E1C
		public override IMessage Invoke(IMessage request)
		{
			IMethodCallMessage methodCallMessage = request as IMethodCallMessage;
			if (methodCallMessage != null)
			{
				if (methodCallMessage.MethodBase == RemotingProxy._cache_GetHashCodeMethod)
				{
					return new MethodResponse(base.ObjectIdentity.GetHashCode(), null, null, methodCallMessage);
				}
				if (methodCallMessage.MethodBase == RemotingProxy._cache_GetTypeMethod)
				{
					return new MethodResponse(base.GetProxiedType(), null, null, methodCallMessage);
				}
			}
			IInternalMessage internalMessage = request as IInternalMessage;
			if (internalMessage != null)
			{
				if (internalMessage.Uri == null)
				{
					internalMessage.Uri = this._targetUri;
				}
				internalMessage.TargetIdentity = this._objectIdentity;
			}
			this._objectIdentity.NotifyClientDynamicSinks(true, request, true, false);
			IMessageSink messageSink;
			if (Thread.CurrentContext.HasExitSinks && !this._hasEnvoySink)
			{
				messageSink = Thread.CurrentContext.GetClientContextSinkChain();
			}
			else
			{
				messageSink = this._sink;
			}
			MonoMethodMessage monoMethodMessage = request as MonoMethodMessage;
			IMessage result;
			if (monoMethodMessage == null || monoMethodMessage.CallType == CallType.Sync)
			{
				result = messageSink.SyncProcessMessage(request);
			}
			else
			{
				AsyncResult asyncResult = monoMethodMessage.AsyncResult;
				IMessageCtrl messageCtrl = messageSink.AsyncProcessMessage(request, asyncResult);
				if (asyncResult != null)
				{
					asyncResult.SetMessageCtrl(messageCtrl);
				}
				result = new ReturnMessage(null, new object[0], 0, null, monoMethodMessage);
			}
			this._objectIdentity.NotifyClientDynamicSinks(false, request, true, false);
			return result;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00072D44 File Offset: 0x00070F44
		internal void AttachIdentity(Identity identity)
		{
			this._objectIdentity = identity;
			if (identity is ClientActivatedIdentity)
			{
				ClientActivatedIdentity clientActivatedIdentity = (ClientActivatedIdentity)identity;
				this._targetContext = clientActivatedIdentity.Context;
				base.AttachServer(clientActivatedIdentity.GetServerObject());
				clientActivatedIdentity.SetClientProxy((MarshalByRefObject)this.GetTransparentProxy());
			}
			if (identity is ClientIdentity)
			{
				((ClientIdentity)identity).ClientProxy = (MarshalByRefObject)this.GetTransparentProxy();
				this._targetUri = ((ClientIdentity)identity).TargetUri;
			}
			else
			{
				this._targetUri = identity.ObjectUri;
			}
			if (this._objectIdentity.EnvoySink != null)
			{
				this._sink = this._objectIdentity.EnvoySink;
				this._hasEnvoySink = true;
			}
			else
			{
				this._sink = this._objectIdentity.ChannelSink;
			}
			this._ctorCall = null;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00072E0C File Offset: 0x0007100C
		internal IMessage ActivateRemoteObject(IMethodMessage request)
		{
			if (this._ctorCall == null)
			{
				return new ConstructionResponse(this, null, (IMethodCallMessage)request);
			}
			this._ctorCall.CopyFrom(request);
			return ActivationServices.Activate(this, this._ctorCall);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00072E3C File Offset: 0x0007103C
		public string TypeName
		{
			get
			{
				if (this._objectIdentity is ClientIdentity)
				{
					ObjRef objRef = this._objectIdentity.CreateObjRef(null);
					if (objRef.TypeInfo != null)
					{
						return objRef.TypeInfo.TypeName;
					}
				}
				return base.GetProxiedType().AssemblyQualifiedName;
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00072E84 File Offset: 0x00071084
		public bool CanCastTo(Type fromType, object o)
		{
			if (this._objectIdentity is ClientIdentity)
			{
				ObjRef objRef = this._objectIdentity.CreateObjRef(null);
				if (objRef.IsReferenceToWellKnow && (fromType.IsInterface || base.GetProxiedType() == typeof(MarshalByRefObject)))
				{
					return true;
				}
				if (objRef.TypeInfo != null)
				{
					return objRef.TypeInfo.CanCastTo(fromType, o);
				}
			}
			return fromType.IsAssignableFrom(base.GetProxiedType());
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00072EF8 File Offset: 0x000710F8
		~RemotingProxy()
		{
			if (this._objectIdentity != null && !(this._objectIdentity is ClientActivatedIdentity))
			{
				RemotingServices.DisposeIdentity(this._objectIdentity);
			}
		}

		// Token: 0x04000AF9 RID: 2809
		private static MethodInfo _cache_GetTypeMethod = typeof(object).GetMethod("GetType");

		// Token: 0x04000AFA RID: 2810
		private static MethodInfo _cache_GetHashCodeMethod = typeof(object).GetMethod("GetHashCode");

		// Token: 0x04000AFB RID: 2811
		private IMessageSink _sink;

		// Token: 0x04000AFC RID: 2812
		private bool _hasEnvoySink;

		// Token: 0x04000AFD RID: 2813
		private ConstructionCall _ctorCall;
	}
}
