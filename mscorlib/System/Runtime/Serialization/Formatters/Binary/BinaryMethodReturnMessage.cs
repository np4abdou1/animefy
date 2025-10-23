using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E3 RID: 995
	[Serializable]
	internal class BinaryMethodReturnMessage
	{
		// Token: 0x06001E45 RID: 7749 RVA: 0x0007FEB0 File Offset: 0x0007E0B0
		[SecurityCritical]
		internal BinaryMethodReturnMessage(object returnValue, object[] args, Exception e, LogicalCallContext callContext, object[] properties)
		{
			this._returnValue = returnValue;
			if (args == null)
			{
				args = new object[0];
			}
			this._outargs = args;
			this._args = args;
			this._exception = e;
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

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0007FF0B File Offset: 0x0007E10B
		public Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0007FF13 File Offset: 0x0007E113
		public object ReturnValue
		{
			get
			{
				return this._returnValue;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0007FF1B File Offset: 0x0007E11B
		public object[] Args
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0007FF23 File Offset: 0x0007E123
		public LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return this._logicalCallContext;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0007FF2B File Offset: 0x0007E12B
		public bool HasProperties
		{
			get
			{
				return this._properties != null;
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0007FF38 File Offset: 0x0007E138
		internal void PopulateMessageProperties(IDictionary dict)
		{
			foreach (DictionaryEntry dictionaryEntry in this._properties)
			{
				dict[dictionaryEntry.Key] = dictionaryEntry.Value;
			}
		}

		// Token: 0x04000D93 RID: 3475
		private object[] _outargs;

		// Token: 0x04000D94 RID: 3476
		private Exception _exception;

		// Token: 0x04000D95 RID: 3477
		private object _returnValue;

		// Token: 0x04000D96 RID: 3478
		private object[] _args;

		// Token: 0x04000D97 RID: 3479
		[SecurityCritical]
		private LogicalCallContext _logicalCallContext;

		// Token: 0x04000D98 RID: 3480
		private object[] _properties;
	}
}
