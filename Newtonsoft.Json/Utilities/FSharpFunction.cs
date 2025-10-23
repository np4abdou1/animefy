using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C4 RID: 196
	[NullableContext(2)]
	[Nullable(0)]
	internal class FSharpFunction
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00020744 File Offset: 0x0001E944
		public FSharpFunction(object instance, [Nullable(new byte[]
		{
			1,
			2,
			1
		})] MethodCall<object, object> invoker)
		{
			this._instance = instance;
			this._invoker = invoker;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0002075A File Offset: 0x0001E95A
		[NullableContext(1)]
		public object Invoke(params object[] args)
		{
			return this._invoker(this._instance, args);
		}

		// Token: 0x04000447 RID: 1095
		private readonly object _instance;

		// Token: 0x04000448 RID: 1096
		[Nullable(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly MethodCall<object, object> _invoker;
	}
}
