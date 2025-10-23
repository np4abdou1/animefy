using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> interface to create a request message that acts as a method call on a remote object.</summary>
	// Token: 0x0200037A RID: 890
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x00076EE4 File Offset: 0x000750E4
		internal MethodCall(SerializationInfo info, StreamingContext context)
		{
			this.Init();
			foreach (SerializationEntry serializationEntry in info)
			{
				this.InitMethodProperty(serializationEntry.Name, serializationEntry.Value);
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00076F2C File Offset: 0x0007512C
		internal MethodCall(CADMethodCallMessage msg)
		{
			this._uri = string.Copy(msg.Uri);
			ArrayList arguments = msg.GetArguments();
			this._args = msg.GetArgs(arguments);
			this._callContext = msg.GetLogicalCallContext(arguments);
			if (this._callContext == null)
			{
				this._callContext = new LogicalCallContext();
			}
			this._methodBase = msg.GetMethod();
			this.Init();
			if (msg.PropertiesCount > 0)
			{
				CADMessageBase.UnmarshalProperties(this.Properties, msg.PropertiesCount, arguments);
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00076FB4 File Offset: 0x000751B4
		internal MethodCall(object handlerObject, BinaryMethodCallMessage smuggledMsg)
		{
			if (handlerObject != null)
			{
				this._uri = (handlerObject as string);
				if (this._uri == null && handlerObject is MarshalByRefObject)
				{
					throw new NotImplementedException("MarshalByRefObject.GetIdentity");
				}
			}
			this._typeName = smuggledMsg.TypeName;
			this._methodName = smuggledMsg.MethodName;
			this._methodSignature = (Type[])smuggledMsg.MethodSignature;
			this._args = smuggledMsg.Args;
			this._genericArguments = smuggledMsg.InstantiationArgs;
			this._callContext = smuggledMsg.LogicalCallContext;
			this.ResolveMethod();
			if (smuggledMsg.HasProperties)
			{
				smuggledMsg.PopulateMessageProperties(this.Properties);
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal MethodCall()
		{
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00077058 File Offset: 0x00075258
		internal void CopyFrom(IMethodMessage call)
		{
			this._uri = call.Uri;
			this._typeName = call.TypeName;
			this._methodName = call.MethodName;
			this._args = call.Args;
			this._methodSignature = (Type[])call.MethodSignature;
			this._methodBase = call.MethodBase;
			this._callContext = call.LogicalCallContext;
			this.Init();
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000770C4 File Offset: 0x000752C4
		internal virtual void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1619225942U)
			{
				if (num != 990701179U)
				{
					if (num != 1201911322U)
					{
						if (num == 1619225942U)
						{
							if (key == "__Args")
							{
								this._args = (object[])value;
								return;
							}
						}
					}
					else if (key == "__CallContext")
					{
						this._callContext = (LogicalCallContext)value;
						return;
					}
				}
				else if (key == "__Uri")
				{
					this._uri = (string)value;
					return;
				}
			}
			else if (num <= 2850677384U)
			{
				if (num != 2010141056U)
				{
					if (num == 2850677384U)
					{
						if (key == "__GenericArguments")
						{
							this._genericArguments = (Type[])value;
							return;
						}
					}
				}
				else if (key == "__TypeName")
				{
					this._typeName = (string)value;
					return;
				}
			}
			else if (num != 3166241401U)
			{
				if (num == 3679129400U)
				{
					if (key == "__MethodSignature")
					{
						this._methodSignature = (Type[])value;
						return;
					}
				}
			}
			else if (key == "__MethodName")
			{
				this._methodName = (string)value;
				return;
			}
			this.Properties[key] = value;
		}

		/// <summary>The <see cref="M:System.Runtime.Remoting.Messaging.MethodCall.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method is not implemented. </summary>
		/// <param name="info">The data for serializing or deserializing the remote object.</param>
		/// <param name="context">The context of a certain serialized stream.</param>
		// Token: 0x06001BC7 RID: 7111 RVA: 0x00077218 File Offset: 0x00075418
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("__TypeName", this._typeName);
			info.AddValue("__MethodName", this._methodName);
			info.AddValue("__MethodSignature", this._methodSignature);
			info.AddValue("__Args", this._args);
			info.AddValue("__CallContext", this._callContext);
			info.AddValue("__Uri", this._uri);
			info.AddValue("__GenericArguments", this._genericArguments);
			if (this.InternalProperties != null)
			{
				foreach (object obj in this.InternalProperties)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					info.AddValue((string)dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		/// <summary>Gets the number of arguments passed to a method. </summary>
		/// <returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns>
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00077304 File Offset: 0x00075504
		public int ArgCount
		{
			get
			{
				return this._args.Length;
			}
		}

		/// <summary>Gets an array of arguments passed to a method. </summary>
		/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns>
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0007730E File Offset: 0x0007550E
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call. </summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns>
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00077316 File Offset: 0x00075516
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				if (this._callContext == null)
				{
					this._callContext = new LogicalCallContext();
				}
				return this._callContext;
			}
		}

		/// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method. </summary>
		/// <returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns>
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00077331 File Offset: 0x00075531
		public MethodBase MethodBase
		{
			get
			{
				if (this._methodBase == null)
				{
					this.ResolveMethod();
				}
				return this._methodBase;
			}
		}

		/// <summary>Gets the name of the invoked method. </summary>
		/// <returns>A <see cref="T:System.String" /> that contains the name of the invoked method.</returns>
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0007734D File Offset: 0x0007554D
		public string MethodName
		{
			get
			{
				if (this._methodName == null)
				{
					this._methodName = this._methodBase.Name;
				}
				return this._methodName;
			}
		}

		/// <summary>Gets an object that contains the method signature. </summary>
		/// <returns>A <see cref="T:System.Object" /> that contains the method signature.</returns>
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00077370 File Offset: 0x00075570
		public object MethodSignature
		{
			get
			{
				if (this._methodSignature == null && this._methodBase != null)
				{
					ParameterInfo[] parameters = this._methodBase.GetParameters();
					this._methodSignature = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						this._methodSignature[i] = parameters[i].ParameterType;
					}
				}
				return this._methodSignature;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x000773D1 File Offset: 0x000755D1
		public virtual IDictionary Properties
		{
			get
			{
				if (this.ExternalProperties == null)
				{
					this.InitDictionary();
				}
				return this.ExternalProperties;
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000773E8 File Offset: 0x000755E8
		internal virtual void InitDictionary()
		{
			MCMDictionary mcmdictionary = new MCMDictionary(this);
			this.ExternalProperties = mcmdictionary;
			this.InternalProperties = mcmdictionary.GetInternalProperties();
		}

		/// <summary>Gets the full type name of the remote object on which the method call is being made. </summary>
		/// <returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns>
		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0007740F File Offset: 0x0007560F
		public string TypeName
		{
			get
			{
				if (this._typeName == null)
				{
					this._typeName = this._methodBase.DeclaringType.AssemblyQualifiedName;
				}
				return this._typeName;
			}
		}

		/// <summary>Gets or sets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made.</summary>
		/// <returns>The URI of a remote object.</returns>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x00077435 File Offset: 0x00075635
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0007743D File Offset: 0x0007563D
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00077446 File Offset: 0x00075646
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0007744E File Offset: 0x0007564E
		string IInternalMessage.Uri
		{
			get
			{
				return this.Uri;
			}
			set
			{
				this.Uri = value;
			}
		}

		/// <summary>Gets a method argument, as an object, at a specified index. </summary>
		/// <param name="argNum">The index of the requested argument.</param>
		/// <returns>The method argument as an object.</returns>
		// Token: 0x06001BD5 RID: 7125 RVA: 0x00077457 File Offset: 0x00075657
		public object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Initializes a <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" />. </summary>
		// Token: 0x06001BD6 RID: 7126 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void Init()
		{
		}

		/// <summary>Sets method information from previously initialized remoting message properties. </summary>
		// Token: 0x06001BD7 RID: 7127 RVA: 0x00077464 File Offset: 0x00075664
		public void ResolveMethod()
		{
			if (this._uri != null)
			{
				Type serverTypeForUri = RemotingServices.GetServerTypeForUri(this._uri);
				if (serverTypeForUri == null)
				{
					string str = (this._typeName != null) ? (" (" + this._typeName + ")") : "";
					throw new RemotingException("Requested service not found" + str + ". No receiver for uri " + this._uri);
				}
				Type type = this.CastTo(this._typeName, serverTypeForUri);
				if (type == null)
				{
					throw new RemotingException(string.Concat(new string[]
					{
						"Cannot cast from client type '",
						this._typeName,
						"' to server type '",
						serverTypeForUri.FullName,
						"'"
					}));
				}
				this._methodBase = RemotingServices.GetMethodBaseFromName(type, this._methodName, this._methodSignature);
				if (this._methodBase == null)
				{
					string str2 = "Method ";
					string methodName = this._methodName;
					string str3 = " not found in ";
					Type type2 = type;
					throw new RemotingException(str2 + methodName + str3 + ((type2 != null) ? type2.ToString() : null));
				}
				if (type != serverTypeForUri && type.IsInterface && !serverTypeForUri.IsInterface)
				{
					this._methodBase = RemotingServices.GetVirtualMethod(serverTypeForUri, this._methodBase);
					if (this._methodBase == null)
					{
						string str4 = "Method ";
						string methodName2 = this._methodName;
						string str5 = " not found in ";
						Type type3 = serverTypeForUri;
						throw new RemotingException(str4 + methodName2 + str5 + ((type3 != null) ? type3.ToString() : null));
					}
				}
			}
			else
			{
				this._methodBase = RemotingServices.GetMethodBaseFromMethodMessage(this);
				if (this._methodBase == null)
				{
					throw new RemotingException("Method " + this._methodName + " not found in " + this.TypeName);
				}
			}
			if (this._methodBase.IsGenericMethod && this._methodBase.ContainsGenericParameters)
			{
				if (this.GenericArguments == null)
				{
					throw new RemotingException("The remoting infrastructure does not support open generic methods.");
				}
				this._methodBase = ((MethodInfo)this._methodBase).MakeGenericMethod(this.GenericArguments);
			}
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00077660 File Offset: 0x00075860
		private Type CastTo(string clientType, Type serverType)
		{
			clientType = MethodCall.GetTypeNameFromAssemblyQualifiedName(clientType);
			if (clientType == serverType.FullName)
			{
				return serverType;
			}
			Type baseType = serverType.BaseType;
			while (baseType != null)
			{
				if (clientType == baseType.FullName)
				{
					return baseType;
				}
				baseType = baseType.BaseType;
			}
			foreach (Type type in serverType.GetInterfaces())
			{
				if (clientType == type.FullName)
				{
					return type;
				}
			}
			return null;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000776D8 File Offset: 0x000758D8
		private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			int num = aqname.IndexOf("]]");
			int num2 = aqname.IndexOf(',', (num == -1) ? 0 : (num + 2));
			if (num2 != -1)
			{
				aqname = aqname.Substring(0, num2).Trim();
			}
			return aqname;
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00077718 File Offset: 0x00075918
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00077720 File Offset: 0x00075920
		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return this._targetIdentity;
			}
			set
			{
				this._targetIdentity = value;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00077729 File Offset: 0x00075929
		bool IInternalMessage.HasProperties()
		{
			return this.ExternalProperties != null || this.InternalProperties != null;
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00077740 File Offset: 0x00075940
		private Type[] GenericArguments
		{
			get
			{
				if (this._genericArguments != null)
				{
					return this._genericArguments;
				}
				return this._genericArguments = this.MethodBase.GetGenericArguments();
			}
		}

		// Token: 0x04000B9F RID: 2975
		private string _uri;

		// Token: 0x04000BA0 RID: 2976
		private string _typeName;

		// Token: 0x04000BA1 RID: 2977
		private string _methodName;

		// Token: 0x04000BA2 RID: 2978
		private object[] _args;

		// Token: 0x04000BA3 RID: 2979
		private Type[] _methodSignature;

		// Token: 0x04000BA4 RID: 2980
		private MethodBase _methodBase;

		// Token: 0x04000BA5 RID: 2981
		private LogicalCallContext _callContext;

		// Token: 0x04000BA6 RID: 2982
		private Identity _targetIdentity;

		// Token: 0x04000BA7 RID: 2983
		private Type[] _genericArguments;

		/// <summary>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		// Token: 0x04000BA8 RID: 2984
		protected IDictionary ExternalProperties;

		/// <summary>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		// Token: 0x04000BA9 RID: 2985
		protected IDictionary InternalProperties;
	}
}
