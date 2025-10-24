using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000240 RID: 576
	public interface IValueTaskSource
	{
		// Token: 0x060013E4 RID: 5092
		ValueTaskSourceStatus GetStatus(short token);

		// Token: 0x060013E5 RID: 5093
		void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

		// Token: 0x060013E6 RID: 5094
		void GetResult(short token);
	}
}
