using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000109 RID: 265
	internal class ContextAwareResult : LazyAsyncResult
	{
		// Token: 0x06000796 RID: 1942 RVA: 0x00004D67 File Offset: 0x00002F67
		private void SafeCaptureIdentity()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00004D67 File Offset: 0x00002F67
		private void CleanupInternal()
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002B370 File Offset: 0x00029570
		internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack) : this(false, false, myObject, myState, myCallBack)
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002B37D File Offset: 0x0002957D
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) : this(captureIdentity, forceCaptureContext, false, myObject, myState, myCallBack)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002B38D File Offset: 0x0002958D
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) : base(myObject, myState, myCallBack)
		{
			if (forceCaptureContext)
			{
				this._flags = ContextAwareResult.StateFlags.CaptureContext;
			}
			if (captureIdentity)
			{
				this._flags |= ContextAwareResult.StateFlags.CaptureIdentity;
			}
			if (threadSafeContextCopy)
			{
				this._flags |= ContextAwareResult.StateFlags.ThreadSafeContextCopy;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002B3C7 File Offset: 0x000295C7
		internal object StartPostingAsyncOp()
		{
			return this.StartPostingAsyncOp(true);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0002B3D0 File Offset: 0x000295D0
		internal object StartPostingAsyncOp(bool lockCapture)
		{
			if (base.InternalPeekCompleted)
			{
				NetEventSource.Fail(this, "Called on completed result.", "StartPostingAsyncOp");
			}
			this._lock = (lockCapture ? new object() : null);
			this._flags |= ContextAwareResult.StateFlags.PostBlockStarted;
			return this._lock;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002B410 File Offset: 0x00029610
		internal bool FinishPostingAsyncOp()
		{
			if ((this._flags & (ContextAwareResult.StateFlags.PostBlockStarted | ContextAwareResult.StateFlags.PostBlockFinished)) != ContextAwareResult.StateFlags.PostBlockStarted)
			{
				return false;
			}
			this._flags |= ContextAwareResult.StateFlags.PostBlockFinished;
			ExecutionContext executionContext = null;
			return this.CaptureOrComplete(ref executionContext, false);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002B445 File Offset: 0x00029645
		protected override void Cleanup()
		{
			base.Cleanup();
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, "Cleanup");
			}
			this.CleanupInternal();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0002B468 File Offset: 0x00029668
		private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
		{
			if ((this._flags & ContextAwareResult.StateFlags.PostBlockStarted) == ContextAwareResult.StateFlags.None)
			{
				NetEventSource.Fail(this, "Called without calling StartPostingAsyncOp.", "CaptureOrComplete");
			}
			bool flag = base.AsyncCallback != null || (this._flags & ContextAwareResult.StateFlags.CaptureContext) > ContextAwareResult.StateFlags.None;
			if ((this._flags & ContextAwareResult.StateFlags.CaptureIdentity) != ContextAwareResult.StateFlags.None && !base.InternalPeekCompleted && !flag)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "starting identity capture", "CaptureOrComplete");
				}
				this.SafeCaptureIdentity();
			}
			if (flag && !base.InternalPeekCompleted)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "starting capture", "CaptureOrComplete");
				}
				if (cachedContext == null)
				{
					cachedContext = ExecutionContext.Capture();
				}
				if (cachedContext != null)
				{
					if (!returnContext)
					{
						this._context = cachedContext;
						cachedContext = null;
					}
					else
					{
						this._context = cachedContext;
					}
				}
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, FormattableStringFactory.Create("_context:{0}", new object[]
					{
						this._context
					}), "CaptureOrComplete");
				}
			}
			else
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "Skipping capture", "CaptureOrComplete");
				}
				cachedContext = null;
				if (base.AsyncCallback != null && !base.CompletedSynchronously)
				{
					NetEventSource.Fail(this, "Didn't capture context, but didn't complete synchronously!", "CaptureOrComplete");
				}
			}
			if (base.CompletedSynchronously)
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "Completing synchronously", "CaptureOrComplete");
				}
				base.Complete(IntPtr.Zero);
				return true;
			}
			return false;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0002B5BC File Offset: 0x000297BC
		protected override void Complete(IntPtr userToken)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("_context(set):{0} userToken:{1}", new object[]
				{
					this._context != null,
					userToken
				}), "Complete");
			}
			if ((this._flags & ContextAwareResult.StateFlags.PostBlockStarted) == ContextAwareResult.StateFlags.None)
			{
				base.Complete(userToken);
				return;
			}
			if (base.CompletedSynchronously)
			{
				return;
			}
			ExecutionContext context = this._context;
			if (userToken != IntPtr.Zero || context == null)
			{
				base.Complete(userToken);
				return;
			}
			ExecutionContext.Run(context, delegate(object s)
			{
				((ContextAwareResult)s).CompleteCallback();
			}, this);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0002B669 File Offset: 0x00029869
		private void CompleteCallback()
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, "Context set, calling callback.", "CompleteCallback");
			}
			base.Complete(IntPtr.Zero);
		}

		// Token: 0x04000512 RID: 1298
		private volatile ExecutionContext _context;

		// Token: 0x04000513 RID: 1299
		private object _lock;

		// Token: 0x04000514 RID: 1300
		private ContextAwareResult.StateFlags _flags;

		// Token: 0x0200010A RID: 266
		[Flags]
		private enum StateFlags : byte
		{
			// Token: 0x04000516 RID: 1302
			None = 0,
			// Token: 0x04000517 RID: 1303
			CaptureIdentity = 1,
			// Token: 0x04000518 RID: 1304
			CaptureContext = 2,
			// Token: 0x04000519 RID: 1305
			ThreadSafeContextCopy = 4,
			// Token: 0x0400051A RID: 1306
			PostBlockStarted = 8,
			// Token: 0x0400051B RID: 1307
			PostBlockFinished = 16
		}
	}
}
