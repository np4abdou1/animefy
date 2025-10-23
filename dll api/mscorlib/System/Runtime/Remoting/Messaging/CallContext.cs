using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Provides a set of properties that are carried with the execution code path. This class cannot be inherited.</summary>
	// Token: 0x0200035B RID: 859
	[SecurityCritical]
	[ComVisible(true)]
	[Serializable]
	public sealed class CallContext
	{
		// Token: 0x06001B27 RID: 6951 RVA: 0x00003ACD File Offset: 0x00001CCD
		private CallContext()
		{
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0002AC82 File Offset: 0x00028E82
		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			return null;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000755A8 File Offset: 0x000737A8
		internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			LogicalCallContext logicalCallContext = mutableExecutionContext.LogicalCallContext;
			mutableExecutionContext.LogicalCallContext = callCtx;
			return logicalCallContext;
		}

		/// <summary>Retrieves an object with the specified name from the logical call context.</summary>
		/// <param name="name">The name of the item in the logical call context. </param>
		/// <returns>The object in the logical call context associated with the specified name.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001B2A RID: 6954 RVA: 0x000755D0 File Offset: 0x000737D0
		[SecurityCritical]
		public static object LogicalGetData(string name)
		{
			return Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext.GetData(name);
		}

		/// <summary>Stores a given object in the logical call context and associates it with the specified name.</summary>
		/// <param name="name">The name with which to associate the new item in the logical call context. </param>
		/// <param name="data">The object to store in the logical call context, this object must be serializable. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001B2B RID: 6955 RVA: 0x000755F8 File Offset: 0x000737F8
		[SecurityCritical]
		public static void LogicalSetData(string name, object data)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.IllogicalCallContext.FreeNamedDataSlot(name);
			mutableExecutionContext.LogicalCallContext.SetData(name, data);
		}
	}
}
