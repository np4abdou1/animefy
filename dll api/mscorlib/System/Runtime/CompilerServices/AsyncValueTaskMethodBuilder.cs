using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000438 RID: 1080
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder
	{
		// Token: 0x04000F35 RID: 3893
		private AsyncTaskMethodBuilder _methodBuilder;

		// Token: 0x04000F36 RID: 3894
		private bool _haveResult;

		// Token: 0x04000F37 RID: 3895
		private bool _useBuilder;
	}
}
