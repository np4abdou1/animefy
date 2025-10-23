using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E2 RID: 994
	[Serializable]
	internal sealed class BinaryMethodCallMessage
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x0007FDC4 File Offset: 0x0007DFC4
		[SecurityCritical]
		internal BinaryMethodCallMessage(string uri, string methodName, string typeName, Type[] instArgs, object[] args, object methodSignature, LogicalCallContext callContext, object[] properties)
		{
			this._methodName = methodName;
			this._typeName = typeName;
			if (args == null)
			{
				args = new object[0];
			}
			this._inargs = args;
			this._args = args;
			this._instArgs = instArgs;
			this._methodSignature = methodSignature;
			if (callContext == null)
			{
				this._logicalCallContext = new LogicalCallContext();
			}
			else
			{
				this._logicalCallContext = callContext;
			}
			this._properties = properties;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0007FE32 File Offset: 0x0007E032
		public string MethodName
		{
			get
			{
				return this._methodName;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0007FE3A File Offset: 0x0007E03A
		public string TypeName
		{
			get
			{
				return this._typeName;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0007FE42 File Offset: 0x0007E042
		public Type[] InstantiationArgs
		{
			get
			{
				return this._instArgs;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0007FE4A File Offset: 0x0007E04A
		public object MethodSignature
		{
			get
			{
				return this._methodSignature;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0007FE52 File Offset: 0x0007E052
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0007FE5A File Offset: 0x0007E05A
		public LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return this._logicalCallContext;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0007FE62 File Offset: 0x0007E062
		public bool HasProperties
		{
			get
			{
				return this._properties != null;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0007FE70 File Offset: 0x0007E070
		internal void PopulateMessageProperties(IDictionary dict)
		{
			foreach (DictionaryEntry dictionaryEntry in this._properties)
			{
				dict[dictionaryEntry.Key] = dictionaryEntry.Value;
			}
		}

		// Token: 0x04000D8B RID: 3467
		private object[] _inargs;

		// Token: 0x04000D8C RID: 3468
		private string _methodName;

		// Token: 0x04000D8D RID: 3469
		private string _typeName;

		// Token: 0x04000D8E RID: 3470
		private object _methodSignature;

		// Token: 0x04000D8F RID: 3471
		private Type[] _instArgs;

		// Token: 0x04000D90 RID: 3472
		private object[] _args;

		// Token: 0x04000D91 RID: 3473
		[SecurityCritical]
		private LogicalCallContext _logicalCallContext;

		// Token: 0x04000D92 RID: 3474
		private object[] _properties;
	}
}
