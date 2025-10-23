using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> interface to create a message that acts as a method response on a remote object.</summary>
	// Token: 0x0200037E RID: 894
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x00077FB4 File Offset: 0x000761B4
		internal MethodResponse(Exception e, IMethodCallMessage msg)
		{
			this._callMsg = msg;
			if (msg != null)
			{
				this._uri = msg.Uri;
			}
			else
			{
				this._uri = string.Empty;
			}
			this._exception = e;
			this._returnValue = null;
			this._outArgs = new object[0];
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00078004 File Offset: 0x00076204
		internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
			this._callMsg = msg;
			this._uri = msg.Uri;
			this._exception = null;
			this._returnValue = returnValue;
			this._args = outArgs;
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00078038 File Offset: 0x00076238
		internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
		{
			this._callMsg = msg;
			this._methodBase = msg.MethodBase;
			this._uri = msg.Uri;
			this._methodName = msg.MethodName;
			ArrayList arguments = retmsg.GetArguments();
			this._exception = retmsg.GetException(arguments);
			this._returnValue = retmsg.GetReturnValue(arguments);
			this._args = retmsg.GetArgs(arguments);
			this._callContext = retmsg.GetLogicalCallContext(arguments);
			if (this._callContext == null)
			{
				this._callContext = new LogicalCallContext();
			}
			if (retmsg.PropertiesCount > 0)
			{
				CADMessageBase.UnmarshalProperties(this.Properties, retmsg.PropertiesCount, arguments);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000780E0 File Offset: 0x000762E0
		internal MethodResponse(IMethodCallMessage msg, object handlerObject, BinaryMethodReturnMessage smuggledMrm)
		{
			if (msg != null)
			{
				this._methodBase = msg.MethodBase;
				this._methodName = msg.MethodName;
				this._uri = msg.Uri;
			}
			this._returnValue = smuggledMrm.ReturnValue;
			this._args = smuggledMrm.Args;
			this._exception = smuggledMrm.Exception;
			this._callContext = smuggledMrm.LogicalCallContext;
			if (smuggledMrm.HasProperties)
			{
				smuggledMrm.PopulateMessageProperties(this.Properties);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00078160 File Offset: 0x00076360
		internal MethodResponse(SerializationInfo info, StreamingContext context)
		{
			foreach (SerializationEntry serializationEntry in info)
			{
				this.InitMethodProperty(serializationEntry.Name, serializationEntry.Value);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000781A0 File Offset: 0x000763A0
		internal void InitMethodProperty(string key, object value)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 1960967436U)
			{
				if (num <= 1201911322U)
				{
					if (num != 990701179U)
					{
						if (num == 1201911322U)
						{
							if (key == "__CallContext")
							{
								this._callContext = (LogicalCallContext)value;
								return;
							}
						}
					}
					else if (key == "__Uri")
					{
						this._uri = (string)value;
						return;
					}
				}
				else if (num != 1637783905U)
				{
					if (num == 1960967436U)
					{
						if (key == "__OutArgs")
						{
							this._args = (object[])value;
							return;
						}
					}
				}
				else if (key == "__Return")
				{
					this._returnValue = value;
					return;
				}
			}
			else if (num <= 3166241401U)
			{
				if (num != 2010141056U)
				{
					if (num == 3166241401U)
					{
						if (key == "__MethodName")
						{
							this._methodName = (string)value;
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
			else if (num != 3626951189U)
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
			else if (key == "__fault")
			{
				this._exception = (Exception)value;
				return;
			}
			this.Properties[key] = value;
		}

		/// <summary>Gets the number of arguments passed to the method. </summary>
		/// <returns>A <see cref="T:System.Int32" /> that represents the number of arguments passed to a method.</returns>
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00078326 File Offset: 0x00076526
		public int ArgCount
		{
			get
			{
				if (this._args == null)
				{
					return 0;
				}
				return this._args.Length;
			}
		}

		/// <summary>Gets an array of arguments passed to the method. </summary>
		/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments passed to a method.</returns>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0007833A File Offset: 0x0007653A
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		/// <summary>Gets the exception thrown during the method call, or <see langword="null" /> if the method did not throw an exception. </summary>
		/// <returns>The <see cref="T:System.Exception" /> thrown during the method call, or <see langword="null" /> if the method did not throw an exception.</returns>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00078342 File Offset: 0x00076542
		public Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call. </summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> for the current method call.</returns>
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0007834A File Offset: 0x0007654A
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
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00078368 File Offset: 0x00076568
		public MethodBase MethodBase
		{
			get
			{
				if (null == this._methodBase)
				{
					if (this._callMsg != null)
					{
						this._methodBase = this._callMsg.MethodBase;
					}
					else if (this.MethodName != null && this.TypeName != null)
					{
						this._methodBase = RemotingServices.GetMethodBaseFromMethodMessage(this);
					}
				}
				return this._methodBase;
			}
		}

		/// <summary>Gets the name of the invoked method. </summary>
		/// <returns>A <see cref="T:System.String" /> that contains the name of the invoked method.</returns>
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x000783C0 File Offset: 0x000765C0
		public string MethodName
		{
			get
			{
				if (this._methodName == null && this._callMsg != null)
				{
					this._methodName = this._callMsg.MethodName;
				}
				return this._methodName;
			}
		}

		/// <summary>Gets an object that contains the method signature. </summary>
		/// <returns>A <see cref="T:System.Object" /> that contains the method signature.</returns>
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000783E9 File Offset: 0x000765E9
		public object MethodSignature
		{
			get
			{
				if (this._methodSignature == null && this._callMsg != null)
				{
					this._methodSignature = (Type[])this._callMsg.MethodSignature;
				}
				return this._methodSignature;
			}
		}

		/// <summary>Gets an array of arguments in the method call that are marked as <see langword="ref" /> or <see langword="out" /> parameters.</summary>
		/// <returns>An array of type <see cref="T:System.Object" /> that represents the arguments in the method call that are marked as <see langword="ref" /> or <see langword="out" /> parameters.</returns>
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00078418 File Offset: 0x00076618
		public object[] OutArgs
		{
			get
			{
				if (this._outArgs == null && this._args != null)
				{
					if (this._inArgInfo == null)
					{
						this._inArgInfo = new ArgInfo(this.MethodBase, ArgInfoType.Out);
					}
					this._outArgs = this._inArgInfo.GetInOutArgs(this._args);
				}
				return this._outArgs;
			}
		}

		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x0007846C File Offset: 0x0007666C
		public virtual IDictionary Properties
		{
			get
			{
				if (this.ExternalProperties == null)
				{
					MethodReturnDictionary methodReturnDictionary = new MethodReturnDictionary(this);
					this.ExternalProperties = methodReturnDictionary;
					this.InternalProperties = methodReturnDictionary.GetInternalProperties();
				}
				return this.ExternalProperties;
			}
		}

		/// <summary>Gets the return value of the method call. </summary>
		/// <returns>A <see cref="T:System.Object" /> that represents the return value of the method call.</returns>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000784A1 File Offset: 0x000766A1
		public object ReturnValue
		{
			get
			{
				return this._returnValue;
			}
		}

		/// <summary>Gets the full type name of the remote object on which the method call is being made. </summary>
		/// <returns>A <see cref="T:System.String" /> that contains the full type name of the remote object on which the method call is being made.</returns>
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000784A9 File Offset: 0x000766A9
		public string TypeName
		{
			get
			{
				if (this._typeName == null && this._callMsg != null)
				{
					this._typeName = this._callMsg.TypeName;
				}
				return this._typeName;
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of the remote object on which the method call is being made. </summary>
		/// <returns>The URI of a remote object.</returns>
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x000784D2 File Offset: 0x000766D2
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x000784FB File Offset: 0x000766FB
		public string Uri
		{
			get
			{
				if (this._uri == null && this._callMsg != null)
				{
					this._uri = this._callMsg.Uri;
				}
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00078504 File Offset: 0x00076704
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x0007850C File Offset: 0x0007670C
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
		// Token: 0x06001C15 RID: 7189 RVA: 0x00078515 File Offset: 0x00076715
		public object GetArg(int argNum)
		{
			if (this._args == null)
			{
				return null;
			}
			return this._args[argNum];
		}

		/// <summary>The <see cref="M:System.Runtime.Remoting.Messaging.MethodResponse.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method is not implemented. </summary>
		/// <param name="info">Data for serializing or deserializing the remote object.</param>
		/// <param name="context">Context of a certain serialized stream.</param>
		// Token: 0x06001C16 RID: 7190 RVA: 0x0007852C File Offset: 0x0007672C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (this._exception == null)
			{
				info.AddValue("__TypeName", this._typeName);
				info.AddValue("__MethodName", this._methodName);
				info.AddValue("__MethodSignature", this._methodSignature);
				info.AddValue("__Uri", this._uri);
				info.AddValue("__Return", this._returnValue);
				info.AddValue("__OutArgs", this._args);
			}
			else
			{
				info.AddValue("__fault", this._exception);
			}
			info.AddValue("__CallContext", this._callContext);
			if (this.InternalProperties != null)
			{
				foreach (object obj in this.InternalProperties)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					info.AddValue((string)dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00078634 File Offset: 0x00076834
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0007863C File Offset: 0x0007683C
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

		// Token: 0x06001C19 RID: 7193 RVA: 0x00078645 File Offset: 0x00076845
		bool IInternalMessage.HasProperties()
		{
			return this.ExternalProperties != null || this.InternalProperties != null;
		}

		// Token: 0x04000BB2 RID: 2994
		private string _methodName;

		// Token: 0x04000BB3 RID: 2995
		private string _uri;

		// Token: 0x04000BB4 RID: 2996
		private string _typeName;

		// Token: 0x04000BB5 RID: 2997
		private MethodBase _methodBase;

		// Token: 0x04000BB6 RID: 2998
		private object _returnValue;

		// Token: 0x04000BB7 RID: 2999
		private Exception _exception;

		// Token: 0x04000BB8 RID: 3000
		private Type[] _methodSignature;

		// Token: 0x04000BB9 RID: 3001
		private ArgInfo _inArgInfo;

		// Token: 0x04000BBA RID: 3002
		private object[] _args;

		// Token: 0x04000BBB RID: 3003
		private object[] _outArgs;

		// Token: 0x04000BBC RID: 3004
		private IMethodCallMessage _callMsg;

		// Token: 0x04000BBD RID: 3005
		private LogicalCallContext _callContext;

		// Token: 0x04000BBE RID: 3006
		private Identity _targetIdentity;

		/// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		// Token: 0x04000BBF RID: 3007
		protected IDictionary ExternalProperties;

		/// <summary>Specifies an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary>
		// Token: 0x04000BC0 RID: 3008
		protected IDictionary InternalProperties;
	}
}
