using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000241 RID: 577
	public interface IValueTaskSource<out TResult>
	{
		// Token: 0x060013E7 RID: 5095
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060013E8 RID: 5096
		void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060013E9 RID: 5097
		TResult GetResult(short token);
	}
}
