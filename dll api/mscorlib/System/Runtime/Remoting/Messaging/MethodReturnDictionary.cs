using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200037F RID: 895
	internal class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x06001C1A RID: 7194 RVA: 0x0007865A File Offset: 0x0007685A
		public MethodReturnDictionary(IMethodReturnMessage message) : base(message)
		{
			if (message.Exception == null)
			{
				base.MethodKeys = MethodReturnDictionary.InternalReturnKeys;
				return;
			}
			base.MethodKeys = MethodReturnDictionary.InternalExceptionKeys;
		}

		// Token: 0x04000BC1 RID: 3009
		public static string[] InternalReturnKeys = new string[]
		{
			"__Uri",
			"__MethodName",
			"__TypeName",
			"__MethodSignature",
			"__OutArgs",
			"__Return",
			"__CallContext"
		};

		// Token: 0x04000BC2 RID: 3010
		public static string[] InternalExceptionKeys = new string[]
		{
			"__CallContext"
		};
	}
}
