using System;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Represents a handle that has been registered when calling <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" />. This class cannot be inherited.</summary>
	// Token: 0x020001F4 RID: 500
	[ComVisible(true)]
	public sealed class RegisteredWaitHandle : MarshalByRefObject
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x000497AC File Offset: 0x000479AC
		internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			this._waitObject = waitObject;
			this._callback = callback;
			this._state = state;
			this._timeout = timeout;
			this._executeOnlyOnce = executeOnlyOnce;
			this._finalEvent = null;
			this._cancelEvent = new ManualResetEvent(false);
			this._callsInProcess = 0;
			this._unregistered = false;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00049808 File Offset: 0x00047A08
		internal void Wait(object state)
		{
			bool flag = false;
			try
			{
				this._waitObject.SafeWaitHandle.DangerousAddRef(ref flag);
				RegisteredWaitHandle obj;
				try
				{
					WaitHandle[] waitHandles = new WaitHandle[]
					{
						this._waitObject,
						this._cancelEvent
					};
					do
					{
						int num = WaitHandle.WaitAny(waitHandles, this._timeout, false);
						if (!this._unregistered)
						{
							obj = this;
							lock (obj)
							{
								this._callsInProcess++;
							}
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.DoCallBack), num == 258);
						}
					}
					while (!this._unregistered && !this._executeOnlyOnce);
				}
				catch
				{
				}
				obj = this;
				lock (obj)
				{
					this._unregistered = true;
					if (this._callsInProcess == 0 && this._finalEvent != null)
					{
						NativeEventCalls.SetEvent(this._finalEvent.SafeWaitHandle);
						this._finalEvent = null;
					}
				}
			}
			catch (ObjectDisposedException)
			{
				if (flag)
				{
					throw;
				}
			}
			finally
			{
				if (flag)
				{
					this._waitObject.SafeWaitHandle.DangerousRelease();
				}
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0004995C File Offset: 0x00047B5C
		private void DoCallBack(object timedOut)
		{
			try
			{
				if (this._callback != null)
				{
					this._callback(this._state, (bool)timedOut);
				}
			}
			finally
			{
				lock (this)
				{
					this._callsInProcess--;
					if (this._unregistered && this._callsInProcess == 0 && this._finalEvent != null)
					{
						NativeEventCalls.SetEvent(this._finalEvent.SafeWaitHandle);
						this._finalEvent = null;
					}
				}
			}
		}

		/// <summary>Cancels a registered wait operation issued by the <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" /> method.</summary>
		/// <param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to be signaled. </param>
		/// <returns>
		///     <see langword="true" /> if the function succeeds; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600122F RID: 4655 RVA: 0x00049A00 File Offset: 0x00047C00
		[ComVisible(true)]
		public bool Unregister(WaitHandle waitObject)
		{
			bool result;
			lock (this)
			{
				if (this._unregistered)
				{
					result = false;
				}
				else
				{
					this._finalEvent = waitObject;
					this._unregistered = true;
					this._cancelEvent.Set();
					result = true;
				}
			}
			return result;
		}

		// Token: 0x040006FB RID: 1787
		private WaitHandle _waitObject;

		// Token: 0x040006FC RID: 1788
		private WaitOrTimerCallback _callback;

		// Token: 0x040006FD RID: 1789
		private object _state;

		// Token: 0x040006FE RID: 1790
		private WaitHandle _finalEvent;

		// Token: 0x040006FF RID: 1791
		private ManualResetEvent _cancelEvent;

		// Token: 0x04000700 RID: 1792
		private TimeSpan _timeout;

		// Token: 0x04000701 RID: 1793
		private int _callsInProcess;

		// Token: 0x04000702 RID: 1794
		private bool _executeOnlyOnce;

		// Token: 0x04000703 RID: 1795
		private bool _unregistered;
	}
}
