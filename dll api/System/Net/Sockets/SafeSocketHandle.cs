using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Sockets
{
	// Token: 0x02000216 RID: 534
	internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x0004B39C File Offset: 0x0004959C
		public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
			if (SafeSocketHandle.THROW_ON_ABORT_RETRIES)
			{
				this.threads_stacktraces = new Dictionary<Thread, StackTrace>();
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0004B3C0 File Offset: 0x000495C0
		protected override bool ReleaseHandle()
		{
			int num = 0;
			Socket.Blocking_icall(this.handle, false, out num);
			if (this.blocking_threads != null)
			{
				List<Thread> obj = this.blocking_threads;
				lock (obj)
				{
					int num2 = 0;
					while (this.blocking_threads.Count > 0)
					{
						if (num2++ >= 10)
						{
							if (SafeSocketHandle.THROW_ON_ABORT_RETRIES)
							{
								StringBuilder stringBuilder = new StringBuilder();
								stringBuilder.AppendLine("Could not abort registered blocking threads before closing socket.");
								foreach (Thread key in this.blocking_threads)
								{
									stringBuilder.AppendLine("Thread StackTrace:");
									stringBuilder.AppendLine(this.threads_stacktraces[key].ToString());
								}
								stringBuilder.AppendLine();
								throw new Exception(stringBuilder.ToString());
							}
							break;
						}
						else
						{
							if (this.blocking_threads.Count == 1 && this.blocking_threads[0] == Thread.CurrentThread)
							{
								break;
							}
							foreach (Thread thread in this.blocking_threads)
							{
								Socket.cancel_blocking_socket_operation(thread);
							}
							this.in_cleanup = true;
							Monitor.Wait(this.blocking_threads, 100);
						}
					}
				}
			}
			Socket.Close_icall(this.handle, out num);
			return num == 0;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0004B580 File Offset: 0x00049780
		public void RegisterForBlockingSyscall()
		{
			if (this.blocking_threads == null)
			{
				Interlocked.CompareExchange<List<Thread>>(ref this.blocking_threads, new List<Thread>(), null);
			}
			bool flag = false;
			try
			{
				base.DangerousAddRef(ref flag);
			}
			finally
			{
				List<Thread> obj = this.blocking_threads;
				lock (obj)
				{
					this.blocking_threads.Add(Thread.CurrentThread);
					if (SafeSocketHandle.THROW_ON_ABORT_RETRIES)
					{
						this.threads_stacktraces.Add(Thread.CurrentThread, new StackTrace(true));
					}
				}
				if (flag)
				{
					base.DangerousRelease();
				}
				if (base.IsClosed)
				{
					throw new SocketException(10004);
				}
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0004B638 File Offset: 0x00049838
		public void UnRegisterForBlockingSyscall()
		{
			List<Thread> obj = this.blocking_threads;
			lock (obj)
			{
				Thread currentThread = Thread.CurrentThread;
				this.blocking_threads.Remove(currentThread);
				if (SafeSocketHandle.THROW_ON_ABORT_RETRIES && this.blocking_threads.IndexOf(currentThread) == -1)
				{
					this.threads_stacktraces.Remove(currentThread);
				}
				if (this.in_cleanup && this.blocking_threads.Count == 0)
				{
					Monitor.Pulse(this.blocking_threads);
				}
			}
		}

		// Token: 0x04000B8E RID: 2958
		private List<Thread> blocking_threads;

		// Token: 0x04000B8F RID: 2959
		private Dictionary<Thread, StackTrace> threads_stacktraces;

		// Token: 0x04000B90 RID: 2960
		private bool in_cleanup;

		// Token: 0x04000B91 RID: 2961
		private static bool THROW_ON_ABORT_RETRIES = Environment.GetEnvironmentVariable("MONO_TESTS_IN_PROGRESS") == "yes";
	}
}
