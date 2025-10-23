using System;

namespace System.Threading
{
	// Token: 0x020001BF RID: 447
	internal struct CancellationCallbackCoreWorkArguments
	{
		// Token: 0x060010C2 RID: 4290 RVA: 0x0004544C File Offset: 0x0004364C
		public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
		{
			this._currArrayFragment = currArrayFragment;
			this._currArrayIndex = currArrayIndex;
		}

		// Token: 0x0400065F RID: 1631
		internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment;

		// Token: 0x04000660 RID: 1632
		internal int _currArrayIndex;
	}
}
