using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Holds a message returned in response to a method call on a remote object.</summary>
	// Token: 0x02000386 RID: 902
	[ComVisible(true)]
	public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class with all the information returning to the caller after the method call.</summary>
		/// <param name="ret">The object returned by the invoked method from which the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> instance originated. </param>
		/// <param name="outArgs">The objects returned from the invoked method as <see langword="out" /> parameters. </param>
		/// <param name="outArgsCount">The number of <see langword="out" /> parameters returned from the invoked method. </param>
		/// <param name="callCtx">The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the method call. </param>
		/// <param name="mcm">The original method call to the invoked method. </param>
		// Token: 0x06001C40 RID: 7232 RVA: 0x00078B90 File Offset: 0x00076D90
		public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
		{
			this._returnValue = ret;
			this._args = outArgs;
			this._callCtx = callCtx;
			if (mcm != null)
			{
				this._uri = mcm.Uri;
				this._methodBase = mcm.MethodBase;
			}
			if (this._args == null)
			{
				this._args = new object[outArgsCount];
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class.</summary>
		/// <param name="e">The exception that was thrown during execution of the remotely called method. </param>
		/// <param name="mcm">An <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> with which to create an instance of the <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> class. </param>
		// Token: 0x06001C41 RID: 7233 RVA: 0x00078BEB File Offset: 0x00076DEB
		public ReturnMessage(Exception e, IMethodCallMessage mcm)
		{
			this._exception = e;
			if (mcm != null)
			{
				this._methodBase = mcm.MethodBase;
				this._callCtx = mcm.LogicalCallContext;
			}
			this._args = new object[0];
		}

		/// <summary>Gets the number of arguments of the called method.</summary>
		/// <returns>The number of arguments of the called method.</returns>
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00078C21 File Offset: 0x00076E21
		public int ArgCount
		{
			get
			{
				return this._args.Length;
			}
		}

		/// <summary>Gets a specified argument passed to the method called on the remote object.</summary>
		/// <returns>An argument passed to the method called on the remote object.</returns>
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00078C2B File Offset: 0x00076E2B
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		/// <summary>Gets the <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> of the called method.</returns>
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00078C33 File Offset: 0x00076E33
		public LogicalCallContext LogicalCallContext
		{
			get
			{
				if (this._callCtx == null)
				{
					this._callCtx = new LogicalCallContext();
				}
				return this._callCtx;
			}
		}

		/// <summary>Gets the <see cref="T:System.Reflection.MethodBase" /> of the called method.</summary>
		/// <returns>The <see cref="T:System.Reflection.MethodBase" /> of the called method.</returns>
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00078C4E File Offset: 0x00076E4E
		public MethodBase MethodBase
		{
			get
			{
				return this._methodBase;
			}
		}

		/// <summary>Gets the name of the called method.</summary>
		/// <returns>The name of the method that the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" /> originated from.</returns>
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00078C56 File Offset: 0x00076E56
		public string MethodName
		{
			get
			{
				if (this._methodBase != null && this._methodName == null)
				{
					this._methodName = this._methodBase.Name;
				}
				return this._methodName;
			}
		}

		/// <summary>Gets an array of <see cref="T:System.Type" /> objects containing the method signature.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects containing the method signature.</returns>
		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x00078C88 File Offset: 0x00076E88
		public object MethodSignature
		{
			get
			{
				if (this._methodBase != null && this._methodSignature == null)
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

		/// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> of properties contained in the current <see cref="T:System.Runtime.Remoting.Messaging.ReturnMessage" />.</returns>
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00078CE9 File Offset: 0x00076EE9
		public virtual IDictionary Properties
		{
			get
			{
				if (this._properties == null)
				{
					this._properties = new MethodReturnDictionary(this);
				}
				return this._properties;
			}
		}

		/// <summary>Gets the name of the type on which the remote method was called.</summary>
		/// <returns>The type name of the remote object on which the remote method was called.</returns>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00078D05 File Offset: 0x00076F05
		public string TypeName
		{
			get
			{
				if (this._methodBase != null && this._typeName == null)
				{
					this._typeName = this._methodBase.DeclaringType.AssemblyQualifiedName;
				}
				return this._typeName;
			}
		}

		/// <summary>Gets or sets the URI of the remote object on which the remote method was called.</summary>
		/// <returns>The URI of the remote object on which the remote method was called.</returns>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00078D39 File Offset: 0x00076F39
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x00078D41 File Offset: 0x00076F41
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

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00078D4A File Offset: 0x00076F4A
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00078D52 File Offset: 0x00076F52
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

		/// <summary>Returns a specified argument passed to the remote method during the method call.</summary>
		/// <param name="argNum">The zero-based index of the requested argument. </param>
		/// <returns>An argument passed to the remote method during the method call.</returns>
		// Token: 0x06001C4E RID: 7246 RVA: 0x00078D5B File Offset: 0x00076F5B
		public object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Gets the exception that was thrown during the remote method call.</summary>
		/// <returns>The exception thrown during the method call, or <see langword="null" /> if an exception did not occur during the call.</returns>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00078D65 File Offset: 0x00076F65
		public Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		/// <summary>Gets a specified object passed as an <see langword="out" /> or <see langword="ref" /> parameter to the called method.</summary>
		/// <returns>An object passed as an <see langword="out" /> or <see langword="ref" /> parameter to the called method.</returns>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00078D70 File Offset: 0x00076F70
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

		/// <summary>Gets the object returned by the called method.</summary>
		/// <returns>The object returned by the called method.</returns>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00078DC4 File Offset: 0x00076FC4
		public virtual object ReturnValue
		{
			get
			{
				return this._returnValue;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00078DCC File Offset: 0x00076FCC
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00078DD4 File Offset: 0x00076FD4
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

		// Token: 0x06001C54 RID: 7252 RVA: 0x00078DDD File Offset: 0x00076FDD
		bool IInternalMessage.HasProperties()
		{
			return this._properties != null;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00078DDD File Offset: 0x00076FDD
		internal bool HasProperties()
		{
			return this._properties != null;
		}

		// Token: 0x04000BD9 RID: 3033
		private object[] _outArgs;

		// Token: 0x04000BDA RID: 3034
		private object[] _args;

		// Token: 0x04000BDB RID: 3035
		private LogicalCallContext _callCtx;

		// Token: 0x04000BDC RID: 3036
		private object _returnValue;

		// Token: 0x04000BDD RID: 3037
		private string _uri;

		// Token: 0x04000BDE RID: 3038
		private Exception _exception;

		// Token: 0x04000BDF RID: 3039
		private MethodBase _methodBase;

		// Token: 0x04000BE0 RID: 3040
		private string _methodName;

		// Token: 0x04000BE1 RID: 3041
		private Type[] _methodSignature;

		// Token: 0x04000BE2 RID: 3042
		private string _typeName;

		// Token: 0x04000BE3 RID: 3043
		private MethodReturnDictionary _properties;

		// Token: 0x04000BE4 RID: 3044
		private Identity _targetIdentity;

		// Token: 0x04000BE5 RID: 3045
		private ArgInfo _inArgInfo;
	}
}
