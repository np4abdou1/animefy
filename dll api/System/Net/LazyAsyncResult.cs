using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000172 RID: 370
	internal class LazyAsyncResult : IAsyncResult
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00035938 File Offset: 0x00033B38
		private static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			get
			{
				LazyAsyncResult.ThreadContext threadContext = LazyAsyncResult.t_ThreadContext;
				if (threadContext == null)
				{
					threadContext = new LazyAsyncResult.ThreadContext();
					LazyAsyncResult.t_ThreadContext = threadContext;
				}
				return threadContext;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0003595B File Offset: 0x00033B5B
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
		{
			this.m_AsyncObject = myObject;
			this.m_AsyncState = myState;
			this.m_AsyncCallback = myCallBack;
			this.m_Result = DBNull.Value;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00035983 File Offset: 0x00033B83
		internal object AsyncObject
		{
			get
			{
				return this.m_AsyncObject;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0003598B File Offset: 0x00033B8B
		public object AsyncState
		{
			get
			{
				return this.m_AsyncState;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00035993 File Offset: 0x00033B93
		protected AsyncCallback AsyncCallback
		{
			get
			{
				return this.m_AsyncCallback;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003599C File Offset: 0x00033B9C
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				this.m_UserEvent = true;
				if (this.m_IntCompleted == 0)
				{
					Interlocked.CompareExchange(ref this.m_IntCompleted, int.MinValue, 0);
				}
				ManualResetEvent manualResetEvent = (ManualResetEvent)this.m_Event;
				while (manualResetEvent == null)
				{
					this.LazilyCreateEvent(out manualResetEvent);
				}
				return manualResetEvent;
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x000359E8 File Offset: 0x00033BE8
		private bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			waitHandle = new ManualResetEvent(false);
			bool result;
			try
			{
				if (Interlocked.CompareExchange(ref this.m_Event, waitHandle, null) == null)
				{
					if (this.InternalPeekCompleted)
					{
						waitHandle.Set();
					}
					result = true;
				}
				else
				{
					waitHandle.Close();
					waitHandle = (ManualResetEvent)this.m_Event;
					result = false;
				}
			}
			catch
			{
				this.m_Event = null;
				if (waitHandle != null)
				{
					waitHandle.Close();
				}
				throw;
			}
			return result;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00035A60 File Offset: 0x00033C60
		public bool CompletedSynchronously
		{
			get
			{
				int num = this.m_IntCompleted;
				if (num == 0)
				{
					num = Interlocked.CompareExchange(ref this.m_IntCompleted, int.MinValue, 0);
				}
				return num > 0;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00035A90 File Offset: 0x00033C90
		public bool IsCompleted
		{
			get
			{
				int num = this.m_IntCompleted;
				if (num == 0)
				{
					num = Interlocked.CompareExchange(ref this.m_IntCompleted, int.MinValue, 0);
				}
				return (num & int.MaxValue) != 0;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00035AC3 File Offset: 0x00033CC3
		internal bool InternalPeekCompleted
		{
			get
			{
				return (this.m_IntCompleted & int.MaxValue) != 0;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00035AD4 File Offset: 0x00033CD4
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00035ADC File Offset: 0x00033CDC
		internal bool EndCalled
		{
			get
			{
				return this.m_EndCalled;
			}
			set
			{
				this.m_EndCalled = value;
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00035AE8 File Offset: 0x00033CE8
		protected void ProtectedInvokeCallback(object result, IntPtr userToken)
		{
			if (result == DBNull.Value)
			{
				throw new ArgumentNullException("result");
			}
			if ((this.m_IntCompleted & 2147483647) == 0 && (Interlocked.Increment(ref this.m_IntCompleted) & 2147483647) == 1)
			{
				if (this.m_Result == DBNull.Value)
				{
					this.m_Result = result;
				}
				ManualResetEvent manualResetEvent = (ManualResetEvent)this.m_Event;
				if (manualResetEvent != null)
				{
					try
					{
						manualResetEvent.Set();
					}
					catch (ObjectDisposedException)
					{
					}
				}
				this.Complete(userToken);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00035B70 File Offset: 0x00033D70
		internal void InvokeCallback(object result)
		{
			this.ProtectedInvokeCallback(result, IntPtr.Zero);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00035B7E File Offset: 0x00033D7E
		internal void InvokeCallback()
		{
			this.ProtectedInvokeCallback(null, IntPtr.Zero);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00035B8C File Offset: 0x00033D8C
		protected virtual void Complete(IntPtr userToken)
		{
			bool flag = false;
			LazyAsyncResult.ThreadContext currentThreadContext = LazyAsyncResult.CurrentThreadContext;
			try
			{
				currentThreadContext.m_NestedIOCount++;
				if (this.m_AsyncCallback != null)
				{
					if (currentThreadContext.m_NestedIOCount >= 50)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.WorkerThreadComplete));
						flag = true;
					}
					else
					{
						this.m_AsyncCallback(this);
					}
				}
			}
			finally
			{
				currentThreadContext.m_NestedIOCount--;
				if (!flag)
				{
					this.Cleanup();
				}
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00035C10 File Offset: 0x00033E10
		private void WorkerThreadComplete(object state)
		{
			try
			{
				this.m_AsyncCallback(this);
			}
			finally
			{
				this.Cleanup();
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00035C44 File Offset: 0x00033E44
		internal object InternalWaitForCompletion()
		{
			return this.WaitForCompletion(true);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00035C50 File Offset: 0x00033E50
		private object WaitForCompletion(bool snap)
		{
			ManualResetEvent manualResetEvent = null;
			bool flag = false;
			if (!(snap ? this.IsCompleted : this.InternalPeekCompleted))
			{
				manualResetEvent = (ManualResetEvent)this.m_Event;
				if (manualResetEvent == null)
				{
					flag = this.LazilyCreateEvent(out manualResetEvent);
				}
			}
			if (manualResetEvent == null)
			{
				goto IL_73;
			}
			try
			{
				manualResetEvent.WaitOne(-1, false);
				goto IL_73;
			}
			catch (ObjectDisposedException)
			{
				goto IL_73;
			}
			finally
			{
				if (flag && !this.m_UserEvent)
				{
					ManualResetEvent manualResetEvent2 = (ManualResetEvent)this.m_Event;
					this.m_Event = null;
					if (!this.m_UserEvent)
					{
						manualResetEvent2.Close();
					}
				}
			}
			IL_6D:
			Thread.SpinWait(1);
			IL_73:
			if (this.m_Result != DBNull.Value)
			{
				return this.m_Result;
			}
			goto IL_6D;
		}

		// Token: 0x0400075D RID: 1885
		[ThreadStatic]
		private static LazyAsyncResult.ThreadContext t_ThreadContext;

		// Token: 0x0400075E RID: 1886
		private object m_AsyncObject;

		// Token: 0x0400075F RID: 1887
		private object m_AsyncState;

		// Token: 0x04000760 RID: 1888
		private AsyncCallback m_AsyncCallback;

		// Token: 0x04000761 RID: 1889
		private object m_Result;

		// Token: 0x04000762 RID: 1890
		private int m_IntCompleted;

		// Token: 0x04000763 RID: 1891
		private bool m_EndCalled;

		// Token: 0x04000764 RID: 1892
		private bool m_UserEvent;

		// Token: 0x04000765 RID: 1893
		private object m_Event;

		// Token: 0x02000173 RID: 371
		private class ThreadContext
		{
			// Token: 0x04000766 RID: 1894
			internal int m_NestedIOCount;
		}
	}
}
