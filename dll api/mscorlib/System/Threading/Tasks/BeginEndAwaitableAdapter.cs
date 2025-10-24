using System;

namespace System.Threading.Tasks
{
	// Token: 0x02000209 RID: 521
	internal sealed class BeginEndAwaitableAdapter : RendezvousAwaitable<IAsyncResult>
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x0004AAF0 File Offset: 0x00048CF0
		public BeginEndAwaitableAdapter()
		{
			base.RunContinuationsAsynchronously = false;
		}

		// Token: 0x04000753 RID: 1875
		public static readonly AsyncCallback Callback = delegate(IAsyncResult asyncResult)
		{
			((BeginEndAwaitableAdapter)asyncResult.AsyncState).SetResult(asyncResult);
		};
	}
}
