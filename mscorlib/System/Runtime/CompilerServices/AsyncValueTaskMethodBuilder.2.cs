using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000439 RID: 1081
	[StructLayout(3)]
	public struct AsyncValueTaskMethodBuilder<TResult>
	{
		// Token: 0x06001FEA RID: 8170 RVA: 0x00087C50 File Offset: 0x00085E50
		public static AsyncValueTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncValueTaskMethodBuilder<TResult>);
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00087C66 File Offset: 0x00085E66
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			this._methodBuilder.Start<TStateMachine>(ref stateMachine);
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00087C74 File Offset: 0x00085E74
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			this._methodBuilder.SetStateMachine(stateMachine);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00087C82 File Offset: 0x00085E82
		public void SetResult(TResult result)
		{
			if (this._useBuilder)
			{
				this._methodBuilder.SetResult(result);
				return;
			}
			this._result = result;
			this._haveResult = true;
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00087CA7 File Offset: 0x00085EA7
		public void SetException(Exception exception)
		{
			this._methodBuilder.SetException(exception);
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00087CB5 File Offset: 0x00085EB5
		public ValueTask<TResult> Task
		{
			get
			{
				if (this._haveResult)
				{
					return new ValueTask<TResult>(this._result);
				}
				this._useBuilder = true;
				return new ValueTask<TResult>(this._methodBuilder.Task);
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00087CE2 File Offset: 0x00085EE2
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			this._useBuilder = true;
			this._methodBuilder.AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref awaiter, ref stateMachine);
		}

		// Token: 0x04000F38 RID: 3896
		private AsyncTaskMethodBuilder<TResult> _methodBuilder;

		// Token: 0x04000F39 RID: 3897
		private TResult _result;

		// Token: 0x04000F3A RID: 3898
		private bool _haveResult;

		// Token: 0x04000F3B RID: 3899
		private bool _useBuilder;
	}
}
