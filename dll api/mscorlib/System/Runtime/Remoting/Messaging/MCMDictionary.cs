using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200037B RID: 891
	internal class MCMDictionary : MessageDictionary
	{
		// Token: 0x06001BDE RID: 7134 RVA: 0x00077770 File Offset: 0x00075970
		public MCMDictionary(IMethodMessage message) : base(message)
		{
			base.MethodKeys = MCMDictionary.InternalKeys;
		}

		// Token: 0x04000BAA RID: 2986
		public static string[] InternalKeys = new string[]
		{
			"__Uri",
			"__MethodName",
			"__TypeName",
			"__MethodSignature",
			"__Args",
			"__CallContext"
		};
	}
}
