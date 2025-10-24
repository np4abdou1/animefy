using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace System.Runtime.Remoting
{
	/// <summary>Provides several methods for using and publishing remoted objects and proxies. This class cannot be inherited.</summary>
	// Token: 0x02000310 RID: 784
	[ComVisible(true)]
	public static class RemotingServices
	{
		// Token: 0x060019BD RID: 6589 RVA: 0x000708B8 File Offset: 0x0006EAB8
		static RemotingServices()
		{
			ISurrogateSelector selector = new RemotingSurrogateSelector();
			StreamingContext context = new StreamingContext(StreamingContextStates.Remoting, null);
			RemotingServices._serializationFormatter = new BinaryFormatter(selector, context);
			RemotingServices._deserializationFormatter = new BinaryFormatter(null, context);
			RemotingServices._serializationFormatter.AssemblyFormat = FormatterAssemblyStyle.Full;
			RemotingServices._deserializationFormatter.AssemblyFormat = FormatterAssemblyStyle.Full;
			RemotingServices.RegisterInternalChannels();
			RemotingServices.CreateWellKnownServerIdentity(typeof(RemoteActivator), "RemoteActivationService.rem", WellKnownObjectMode.Singleton);
			RemotingServices.FieldSetterMethod = typeof(object).GetMethod("FieldSetter", BindingFlags.Instance | BindingFlags.NonPublic);
			RemotingServices.FieldGetterMethod = typeof(object).GetMethod("FieldGetter", BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x060019BE RID: 6590
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args);

		// Token: 0x060019BF RID: 6591
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern MethodBase GetVirtualMethod(Type type, MethodBase method);

		/// <summary>Returns a Boolean value that indicates whether the given object is a transparent proxy or a real object.</summary>
		/// <param name="proxy">The reference to the object to check. </param>
		/// <returns>A Boolean value that indicates whether the object specified in the <paramref name="proxy" /> parameter is a transparent proxy or a real object.</returns>
		// Token: 0x060019C0 RID: 6592
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTransparentProxy(object proxy);

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000B18D File Offset: 0x0000938D
		internal static bool ProxyCheckCast(RealProxy rp, RuntimeType castType)
		{
			return true;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0007096C File Offset: 0x0006EB6C
		internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			Type type = target.GetType();
			MethodBase methodBase;
			if (reqMsg.MethodBase.DeclaringType == type || reqMsg.MethodBase == RemotingServices.FieldSetterMethod || reqMsg.MethodBase == RemotingServices.FieldGetterMethod)
			{
				methodBase = reqMsg.MethodBase;
			}
			else
			{
				methodBase = RemotingServices.GetVirtualMethod(type, reqMsg.MethodBase);
				if (methodBase == null)
				{
					throw new RemotingException(string.Format("Cannot resolve method {0}:{1}", type, reqMsg.MethodName));
				}
			}
			if (reqMsg.MethodBase.IsGenericMethod)
			{
				Type[] genericArguments = reqMsg.MethodBase.GetGenericArguments();
				methodBase = ((MethodInfo)methodBase).GetGenericMethodDefinition().MakeGenericMethod(genericArguments);
			}
			LogicalCallContext logicalCallContext = CallContext.SetLogicalCallContext(reqMsg.LogicalCallContext);
			ReturnMessage result;
			try
			{
				object[] array;
				object ret = RemotingServices.InternalExecute(methodBase, target, reqMsg.Args, out array);
				ParameterInfo[] parameters = methodBase.GetParameters();
				object[] array2 = new object[parameters.Length];
				int outArgsCount = 0;
				int num = 0;
				foreach (ParameterInfo parameterInfo in parameters)
				{
					if (parameterInfo.IsOut && !parameterInfo.ParameterType.IsByRef)
					{
						array2[outArgsCount++] = reqMsg.GetArg(parameterInfo.Position);
					}
					else if (parameterInfo.ParameterType.IsByRef)
					{
						array2[outArgsCount++] = array[num++];
					}
					else
					{
						array2[outArgsCount++] = null;
					}
				}
				LogicalCallContext logicalCallContext2 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
				result = new ReturnMessage(ret, array2, outArgsCount, logicalCallContext2, reqMsg);
			}
			catch (Exception e)
			{
				result = new ReturnMessage(e, reqMsg);
			}
			CallContext.SetLogicalCallContext(logicalCallContext);
			return result;
		}

		/// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" /> and URL.</summary>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of a well-known object on the server end to which you want to connect. </param>
		/// <param name="url">The URL of the server class. </param>
		/// <returns>A proxy to the remote object that points to an endpoint served by the specified well-known object.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C3 RID: 6595 RVA: 0x00070B0C File Offset: 0x0006ED0C
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url)
		{
			return RemotingServices.GetRemoteObject(new ObjRef(classToProxy, url, null), classToProxy);
		}

		/// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" />, URL, and channel-specific data.</summary>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of the well-known object to which you want to connect. </param>
		/// <param name="url">The URL of the well-known object. </param>
		/// <param name="data">Channel specific data. Can be <see langword="null" />. </param>
		/// <returns>A proxy that points to an endpoint that is served by the requested well-known object.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C4 RID: 6596 RVA: 0x00070B1C File Offset: 0x0006ED1C
		[ComVisible(true)]
		public static object Connect(Type classToProxy, string url, object data)
		{
			return RemotingServices.GetRemoteObject(new ObjRef(classToProxy, url, data), classToProxy);
		}

		/// <summary>Returns the <see cref="T:System.Type" /> of the object with the specified URI.</summary>
		/// <param name="URI">The URI of the object whose <see cref="T:System.Type" /> is requested. </param>
		/// <returns>The <see cref="T:System.Type" /> of the object with the specified URI.</returns>
		/// <exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception>
		// Token: 0x060019C5 RID: 6597 RVA: 0x00070B2C File Offset: 0x0006ED2C
		public static Type GetServerTypeForUri(string URI)
		{
			ServerIdentity serverIdentity = RemotingServices.GetIdentityForUri(URI) as ServerIdentity;
			if (serverIdentity == null)
			{
				return null;
			}
			return serverIdentity.ObjectType;
		}

		/// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it.</summary>
		/// <param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param>
		/// <returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C6 RID: 6598 RVA: 0x00070B50 File Offset: 0x0006ED50
		public static object Unmarshal(ObjRef objectRef)
		{
			return RemotingServices.Unmarshal(objectRef, true);
		}

		/// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it, refining it to the type on the server.</summary>
		/// <param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param>
		/// <param name="fRefine">
		///       <see langword="true" /> to refine the proxy to the type on the server; otherwise, <see langword="false" />. </param>
		/// <returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C7 RID: 6599 RVA: 0x00070B5C File Offset: 0x0006ED5C
		public static object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			Type type = fRefine ? objectRef.ServerType : typeof(MarshalByRefObject);
			if (type == null)
			{
				type = typeof(MarshalByRefObject);
			}
			if (objectRef.IsReferenceToWellKnow)
			{
				object remoteObject = RemotingServices.GetRemoteObject(objectRef, type);
				TrackingServices.NotifyUnmarshaledObject(remoteObject, objectRef);
				return remoteObject;
			}
			if (type.IsContextful)
			{
				ProxyAttribute proxyAttribute = (ProxyAttribute)Attribute.GetCustomAttribute(type, typeof(ProxyAttribute), true);
				if (proxyAttribute != null)
				{
					object transparentProxy = proxyAttribute.CreateProxy(objectRef, type, null, null).GetTransparentProxy();
					TrackingServices.NotifyUnmarshaledObject(transparentProxy, objectRef);
					return transparentProxy;
				}
			}
			object proxyForRemoteObject = RemotingServices.GetProxyForRemoteObject(objectRef, type);
			TrackingServices.NotifyUnmarshaledObject(proxyForRemoteObject, objectRef);
			return proxyForRemoteObject;
		}

		/// <summary>Takes a <see cref="T:System.MarshalByRefObject" />, registers it with the remoting infrastructure, and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class.</summary>
		/// <param name="Obj">The object to convert. </param>
		/// <returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">The <paramref name="Obj" /> parameter is an object proxy. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C8 RID: 6600 RVA: 0x00070BF1 File Offset: 0x0006EDF1
		public static ObjRef Marshal(MarshalByRefObject Obj)
		{
			return RemotingServices.Marshal(Obj, null, null);
		}

		/// <summary>Takes a <see cref="T:System.MarshalByRefObject" /> and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with the specified URI, and the provided <see cref="T:System.Type" />.</summary>
		/// <param name="Obj">The object to convert into a <see cref="T:System.Runtime.Remoting.ObjRef" />. </param>
		/// <param name="ObjURI">The URI the object specified in the <paramref name="Obj" /> parameter is marshaled with. Can be <see langword="null" />. </param>
		/// <param name="RequestedType">The <see cref="T:System.Type" /><paramref name="Obj" /> is marshaled as. Can be <see langword="null" />. </param>
		/// <returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">
		///         <paramref name="Obj" /> is a proxy of a remote object, and the <paramref name="ObjUri" /> parameter is not <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		// Token: 0x060019C9 RID: 6601 RVA: 0x00070BFC File Offset: 0x0006EDFC
		public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			if (RemotingServices.IsTransparentProxy(Obj))
			{
				RealProxy realProxy = RemotingServices.GetRealProxy(Obj);
				Identity objectIdentity = realProxy.ObjectIdentity;
				if (objectIdentity != null)
				{
					if (realProxy.GetProxiedType().IsContextful && !objectIdentity.IsConnected)
					{
						ClientActivatedIdentity clientActivatedIdentity = (ClientActivatedIdentity)objectIdentity;
						if (ObjURI == null)
						{
							ObjURI = RemotingServices.NewUri();
						}
						clientActivatedIdentity.ObjectUri = ObjURI;
						RemotingServices.RegisterServerIdentity(clientActivatedIdentity);
						clientActivatedIdentity.StartTrackingLifetime((ILease)Obj.InitializeLifetimeService());
						return clientActivatedIdentity.CreateObjRef(RequestedType);
					}
					if (ObjURI != null)
					{
						throw new RemotingException("It is not possible marshal a proxy of a remote object.");
					}
					ObjRef objRef = realProxy.ObjectIdentity.CreateObjRef(RequestedType);
					TrackingServices.NotifyMarshaledObject(Obj, objRef);
					return objRef;
				}
			}
			if (RequestedType == null)
			{
				RequestedType = Obj.GetType();
			}
			if (ObjURI == null)
			{
				if (Obj.ObjectIdentity == null)
				{
					ObjURI = RemotingServices.NewUri();
					RemotingServices.CreateClientActivatedServerIdentity(Obj, RequestedType, ObjURI);
				}
			}
			else
			{
				ClientActivatedIdentity clientActivatedIdentity2 = RemotingServices.GetIdentityForUri("/" + ObjURI) as ClientActivatedIdentity;
				if (clientActivatedIdentity2 == null || Obj != clientActivatedIdentity2.GetServerObject())
				{
					RemotingServices.CreateClientActivatedServerIdentity(Obj, RequestedType, ObjURI);
				}
			}
			ObjRef objRef2;
			if (RemotingServices.IsTransparentProxy(Obj))
			{
				objRef2 = RemotingServices.GetRealProxy(Obj).ObjectIdentity.CreateObjRef(RequestedType);
			}
			else
			{
				objRef2 = Obj.CreateObjRef(RequestedType);
			}
			TrackingServices.NotifyMarshaledObject(Obj, objRef2);
			return objRef2;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00070D18 File Offset: 0x0006EF18
		private static string NewUri()
		{
			if (RemotingServices.app_id == null)
			{
				object obj = RemotingServices.app_id_lock;
				lock (obj)
				{
					if (RemotingServices.app_id == null)
					{
						RemotingServices.app_id = Guid.NewGuid().ToString().Replace('-', '_') + "/";
					}
				}
			}
			int num = Interlocked.Increment(ref RemotingServices.next_id);
			return string.Concat(new string[]
			{
				RemotingServices.app_id,
				Environment.TickCount.ToString("x"),
				"_",
				num.ToString(),
				".rem"
			});
		}

		/// <summary>Returns the real proxy backing the specified transparent proxy.</summary>
		/// <param name="proxy">A transparent proxy. </param>
		/// <returns>The real proxy instance backing the transparent proxy.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x060019CB RID: 6603 RVA: 0x00070DD8 File Offset: 0x0006EFD8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static RealProxy GetRealProxy(object proxy)
		{
			if (!RemotingServices.IsTransparentProxy(proxy))
			{
				throw new RemotingException("Cannot get the real proxy from an object that is not a transparent proxy.");
			}
			return ((TransparentProxy)proxy)._rp;
		}

		/// <summary>Returns the method base from the given <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />.</summary>
		/// <param name="msg">The method message to extract the method base from. </param>
		/// <returns>The method base extracted from the <paramref name="msg" /> parameter.</returns>
		/// <exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception>
		// Token: 0x060019CC RID: 6604 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			Type type = Type.GetType(msg.TypeName);
			if (type == null)
			{
				throw new RemotingException("Type '" + msg.TypeName + "' not found.");
			}
			return RemotingServices.GetMethodBaseFromName(type, msg.MethodName, (Type[])msg.MethodSignature);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00070E4C File Offset: 0x0006F04C
		internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature)
		{
			if (type.IsInterface)
			{
				return RemotingServices.FindInterfaceMethod(type, methodName, signature);
			}
			MethodBase method;
			if (signature == null)
			{
				method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			else
			{
				method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
			}
			if (method != null)
			{
				return method;
			}
			if (methodName == "FieldSetter")
			{
				return RemotingServices.FieldSetterMethod;
			}
			if (methodName == "FieldGetter")
			{
				return RemotingServices.FieldGetterMethod;
			}
			if (signature == null)
			{
				return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			}
			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature)
		{
			MethodBase methodBase;
			if (signature == null)
			{
				methodBase = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			}
			else
			{
				methodBase = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, signature, null);
			}
			if (methodBase != null)
			{
				return methodBase;
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				methodBase = RemotingServices.FindInterfaceMethod(interfaces[i], methodName, signature);
				if (methodBase != null)
				{
					return methodBase;
				}
			}
			return null;
		}

		/// <summary>Serializes the specified marshal by reference object into the provided <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="obj">The object to serialize. </param>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> into which the object is serialized. </param>
		/// <param name="context">The source and destination of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> or <paramref name="info" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x060019CF RID: 6607 RVA: 0x00070F3A File Offset: 0x0006F13A
		public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			RemotingServices.Marshal((MarshalByRefObject)obj).GetObjectData(info, context);
		}

		/// <summary>Returns a Boolean value that indicates whether the method in the given message is overloaded.</summary>
		/// <param name="msg">The message that contains a call to the method in question. </param>
		/// <returns>
		///     <see langword="true" /> if the method called in <paramref name="msg" /> is overloaded; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x060019D0 RID: 6608 RVA: 0x00070F5C File Offset: 0x0006F15C
		public static bool IsMethodOverloaded(IMethodMessage msg)
		{
			RuntimeType runtimeType = (RuntimeType)msg.MethodBase.DeclaringType;
			return runtimeType.GetMethodsByName(msg.MethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, RuntimeType.MemberListType.CaseSensitive, runtimeType).Length > 1;
		}

		/// <summary>Returns a Boolean value that indicates whether the client that called the method specified in the given message is waiting for the server to finish processing the method before continuing execution.</summary>
		/// <param name="method">The method in question. </param>
		/// <returns>
		///     <see langword="true" /> if the method is one way; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x060019D1 RID: 6609 RVA: 0x00070F8F File Offset: 0x0006F18F
		public static bool IsOneWay(MethodBase method)
		{
			return method.IsDefined(typeof(OneWayAttribute), false);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00070FA4 File Offset: 0x0006F1A4
		internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes)
		{
			if (entry.ContextAttributes != null || activationAttributes != null)
			{
				ArrayList arrayList = new ArrayList();
				if (entry.ContextAttributes != null)
				{
					arrayList.AddRange(entry.ContextAttributes);
				}
				if (activationAttributes != null)
				{
					arrayList.AddRange(activationAttributes);
				}
				return RemotingServices.CreateClientProxy(entry.ObjectType, entry.ApplicationUrl, arrayList.ToArray());
			}
			return RemotingServices.CreateClientProxy(entry.ObjectType, entry.ApplicationUrl, null);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0007100C File Offset: 0x0006F20C
		internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes)
		{
			string text = url;
			if (!text.EndsWith("/"))
			{
				text += "/";
			}
			text += "RemoteActivationService.rem";
			string text2;
			RemotingServices.GetClientChannelSinkChain(text, null, out text2);
			return new RemotingProxy(objectType, text, activationAttributes).GetTransparentProxy();
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00071057 File Offset: 0x0006F257
		internal static object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			return RemotingServices.Connect(entry.ObjectType, entry.ObjectUrl, null);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0007106C File Offset: 0x0006F26C
		internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes)
		{
			if (type.IsContextful)
			{
				ProxyAttribute proxyAttribute = (ProxyAttribute)Attribute.GetCustomAttribute(type, typeof(ProxyAttribute), true);
				if (proxyAttribute != null)
				{
					return proxyAttribute.CreateInstance(type);
				}
			}
			return new RemotingProxy(type, ChannelServices.CrossContextUrl, activationAttributes).GetTransparentProxy();
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000710B4 File Offset: 0x0006F2B4
		internal static Identity GetIdentityForUri(string uri)
		{
			string text = RemotingServices.GetNormalizedUri(uri);
			Hashtable obj = RemotingServices.uri_hash;
			Identity result;
			lock (obj)
			{
				Identity identity = (Identity)RemotingServices.uri_hash[text];
				if (identity == null)
				{
					text = RemotingServices.RemoveAppNameFromUri(uri);
					if (text != null)
					{
						identity = (Identity)RemotingServices.uri_hash[text];
					}
				}
				result = identity;
			}
			return result;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00071128 File Offset: 0x0006F328
		private static string RemoveAppNameFromUri(string uri)
		{
			string text = RemotingConfiguration.ApplicationName;
			if (text == null)
			{
				return null;
			}
			text = "/" + text + "/";
			if (uri.StartsWith(text))
			{
				return uri.Substring(text.Length);
			}
			return null;
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00071168 File Offset: 0x0006F368
		internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy)
		{
			object channelData = (objRef.ChannelInfo != null) ? objRef.ChannelInfo.ChannelData : null;
			string uri;
			IMessageSink clientChannelSinkChain = RemotingServices.GetClientChannelSinkChain(objRef.URI, channelData, out uri);
			if (uri == null)
			{
				uri = objRef.URI;
			}
			Hashtable obj = RemotingServices.uri_hash;
			ClientIdentity result;
			lock (obj)
			{
				clientProxy = null;
				string normalizedUri = RemotingServices.GetNormalizedUri(objRef.URI);
				ClientIdentity clientIdentity = RemotingServices.uri_hash[normalizedUri] as ClientIdentity;
				if (clientIdentity != null)
				{
					clientProxy = clientIdentity.ClientProxy;
					if (clientProxy != null)
					{
						return clientIdentity;
					}
					RemotingServices.DisposeIdentity(clientIdentity);
				}
				clientIdentity = new ClientIdentity(uri, objRef);
				clientIdentity.ChannelSink = clientChannelSinkChain;
				RemotingServices.uri_hash[normalizedUri] = clientIdentity;
				if (proxyType != null)
				{
					RemotingProxy remotingProxy = new RemotingProxy(proxyType, clientIdentity);
					CrossAppDomainSink crossAppDomainSink = clientChannelSinkChain as CrossAppDomainSink;
					if (crossAppDomainSink != null)
					{
						remotingProxy.SetTargetDomain(crossAppDomainSink.TargetDomainId);
					}
					clientProxy = remotingProxy.GetTransparentProxy();
					clientIdentity.ClientProxy = (MarshalByRefObject)clientProxy;
				}
				result = clientIdentity;
			}
			return result;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00071280 File Offset: 0x0006F480
		private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri)
		{
			IMessageSink messageSink = ChannelServices.CreateClientChannelSinkChain(url, channelData, out objectUri);
			if (messageSink != null)
			{
				return messageSink;
			}
			if (url != null)
			{
				throw new RemotingException(string.Format("Cannot create channel sink to connect to URL {0}. An appropriate channel has probably not been registered.", url));
			}
			throw new RemotingException(string.Format("Cannot create channel sink to connect to the remote object. An appropriate channel has probably not been registered.", url));
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000712B2 File Offset: 0x0006F4B2
		internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			return new ClientActivatedIdentity(null, objectType)
			{
				ChannelSink = ChannelServices.CrossContextChannel
			};
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000712C6 File Offset: 0x0006F4C6
		internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			ClientActivatedIdentity clientActivatedIdentity = new ClientActivatedIdentity(objectUri, objectType);
			clientActivatedIdentity.AttachServerObject(realObject, Context.DefaultContext);
			RemotingServices.RegisterServerIdentity(clientActivatedIdentity);
			clientActivatedIdentity.StartTrackingLifetime((ILease)realObject.InitializeLifetimeService());
			return clientActivatedIdentity;
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000712F4 File Offset: 0x0006F4F4
		internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			ServerIdentity serverIdentity;
			if (mode == WellKnownObjectMode.SingleCall)
			{
				serverIdentity = new SingleCallIdentity(objectUri, Context.DefaultContext, objectType);
			}
			else
			{
				serverIdentity = new SingletonIdentity(objectUri, Context.DefaultContext, objectType);
			}
			RemotingServices.RegisterServerIdentity(serverIdentity);
			return serverIdentity;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00071328 File Offset: 0x0006F528
		private static void RegisterServerIdentity(ServerIdentity identity)
		{
			Hashtable obj = RemotingServices.uri_hash;
			lock (obj)
			{
				if (RemotingServices.uri_hash.ContainsKey(identity.ObjectUri))
				{
					throw new RemotingException("Uri already in use: " + identity.ObjectUri + ".");
				}
				RemotingServices.uri_hash[identity.ObjectUri] = identity;
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000713A0 File Offset: 0x0006F5A0
		internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			ClientActivatedIdentity clientActivatedIdentity = RemotingServices.GetIdentityForUri(objref.URI) as ClientActivatedIdentity;
			if (clientActivatedIdentity != null)
			{
				return clientActivatedIdentity.GetServerObject();
			}
			return RemotingServices.GetRemoteObject(objref, classToProxy);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000713D0 File Offset: 0x0006F5D0
		internal static object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			object result;
			RemotingServices.GetOrCreateClientIdentity(objRef, proxyType, out result);
			return result;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000713E8 File Offset: 0x0006F5E8
		internal static byte[] SerializeCallData(object obj)
		{
			LogicalCallContext.Reader logicalCallContext = Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext;
			if (!logicalCallContext.IsNull)
			{
				obj = new RemotingServices.CACD
				{
					d = obj,
					c = logicalCallContext.Clone()
				};
			}
			if (obj == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream();
			BinaryFormatter serializationFormatter = RemotingServices._serializationFormatter;
			lock (serializationFormatter)
			{
				RemotingServices._serializationFormatter.Serialize(memoryStream, obj);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00071478 File Offset: 0x0006F678
		internal static object DeserializeCallData(byte[] array)
		{
			if (array == null)
			{
				return null;
			}
			MemoryStream serializationStream = new MemoryStream(array);
			BinaryFormatter deserializationFormatter = RemotingServices._deserializationFormatter;
			object obj;
			lock (deserializationFormatter)
			{
				obj = RemotingServices._deserializationFormatter.Deserialize(serializationStream);
			}
			if (obj is RemotingServices.CACD)
			{
				RemotingServices.CACD cacd = (RemotingServices.CACD)obj;
				obj = cacd.d;
				LogicalCallContext logicalCallContext = (LogicalCallContext)cacd.c;
				if (logicalCallContext.HasInfo)
				{
					Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Merge(logicalCallContext);
				}
			}
			return obj;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0007150C File Offset: 0x0006F70C
		internal static byte[] SerializeExceptionData(Exception ex)
		{
			byte[] result = null;
			try
			{
			}
			finally
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryFormatter serializationFormatter = RemotingServices._serializationFormatter;
				lock (serializationFormatter)
				{
					RemotingServices._serializationFormatter.Serialize(memoryStream, ex);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00071570 File Offset: 0x0006F770
		internal static object GetDomainProxy(AppDomain domain)
		{
			byte[] array = null;
			Context currentContext = Thread.CurrentContext;
			try
			{
				array = (byte[])AppDomain.InvokeInDomain(domain, typeof(AppDomain).GetMethod("GetMarshalledDomainObjRef", BindingFlags.Instance | BindingFlags.NonPublic), domain, null);
			}
			finally
			{
				AppDomain.InternalSetContext(currentContext);
			}
			byte[] array2 = new byte[array.Length];
			array.CopyTo(array2, 0);
			return (AppDomain)RemotingServices.Unmarshal((ObjRef)CADSerializer.DeserializeObject(new MemoryStream(array2)));
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000715F0 File Offset: 0x0006F7F0
		private static void RegisterInternalChannels()
		{
			CrossAppDomainChannel.RegisterCrossAppDomainChannel();
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x000715F8 File Offset: 0x0006F7F8
		internal static void DisposeIdentity(Identity ident)
		{
			Hashtable obj = RemotingServices.uri_hash;
			lock (obj)
			{
				if (!ident.Disposed)
				{
					ClientIdentity clientIdentity = ident as ClientIdentity;
					if (clientIdentity != null)
					{
						RemotingServices.uri_hash.Remove(RemotingServices.GetNormalizedUri(clientIdentity.TargetUri));
					}
					else
					{
						RemotingServices.uri_hash.Remove(ident.ObjectUri);
					}
					ident.Disposed = true;
				}
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00071674 File Offset: 0x0006F874
		internal static Identity GetMessageTargetIdentity(IMessage msg)
		{
			if (msg is IInternalMessage)
			{
				return ((IInternalMessage)msg).TargetIdentity;
			}
			Hashtable obj = RemotingServices.uri_hash;
			Identity result;
			lock (obj)
			{
				string normalizedUri = RemotingServices.GetNormalizedUri(((IMethodMessage)msg).Uri);
				result = (RemotingServices.uri_hash[normalizedUri] as ServerIdentity);
			}
			return result;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000716E4 File Offset: 0x0006F8E4
		internal static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			if (msg is IInternalMessage)
			{
				((IInternalMessage)msg).TargetIdentity = ident;
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000716FC File Offset: 0x0006F8FC
		internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote)
		{
			if (pi.ParameterType.IsArray && ((Array)local).Rank == 1)
			{
				Array array = (Array)local;
				if (array.Rank == 1)
				{
					Array.Copy((Array)remote, array, array.Length);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00071749 File Offset: 0x0006F949
		private static string GetNormalizedUri(string uri)
		{
			if (uri.StartsWith("/"))
			{
				return uri.Substring(1);
			}
			return uri;
		}

		// Token: 0x04000AC6 RID: 2758
		private static Hashtable uri_hash = new Hashtable();

		// Token: 0x04000AC7 RID: 2759
		private static BinaryFormatter _serializationFormatter;

		// Token: 0x04000AC8 RID: 2760
		private static BinaryFormatter _deserializationFormatter;

		// Token: 0x04000AC9 RID: 2761
		private static string app_id;

		// Token: 0x04000ACA RID: 2762
		private static readonly object app_id_lock = new object();

		// Token: 0x04000ACB RID: 2763
		private static int next_id = 1;

		// Token: 0x04000ACC RID: 2764
		private static readonly MethodInfo FieldSetterMethod;

		// Token: 0x04000ACD RID: 2765
		private static readonly MethodInfo FieldGetterMethod;

		// Token: 0x02000311 RID: 785
		[Serializable]
		private class CACD
		{
			// Token: 0x04000ACE RID: 2766
			public object d;

			// Token: 0x04000ACF RID: 2767
			public object c;
		}
	}
}
