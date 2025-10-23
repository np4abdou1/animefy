using System;
using System.Threading;
using Android.Content;
using Android.OS;
using Android.Runtime;

namespace Android.App
{
	// Token: 0x02000271 RID: 625
	internal class SyncContext : SynchronizationContext
	{
		// Token: 0x060017CF RID: 6095 RVA: 0x0003DC5F File Offset: 0x0003BE5F
		public override SynchronizationContext CreateCopy()
		{
			return new SyncContext();
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0003DC68 File Offset: 0x0003BE68
		private static bool EnsureLooper(Looper looper, SendOrPostCallback d)
		{
			if (looper == null)
			{
				string[] array = new string[5];
				array[0] = "No Android message loop is available. Skipping invocation of `";
				int num = 1;
				Type declaringType = d.Method.DeclaringType;
				array[num] = ((declaringType != null) ? declaringType.FullName : null);
				array[2] = ".";
				array[3] = d.Method.Name;
				array[4] = "`!";
				string text = string.Concat(array);
				if (JNIEnvInit.IsRunningOnDesktop)
				{
					text += " Using `await` when running on the Android Designer is not currently supported. Please use the `View.IsInEditMode` property.";
				}
				Logger.Log(LogLevel.Error, "monodroid-synccontext", text);
				return false;
			}
			return true;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0003DCE8 File Offset: 0x0003BEE8
		public override void Post(SendOrPostCallback d, object state)
		{
			Context context = Application.Context;
			Looper looper = (context != null) ? context.MainLooper : null;
			if (!SyncContext.EnsureLooper(looper, d))
			{
				return;
			}
			using (Handler handler = new Handler(looper))
			{
				handler.Post(delegate()
				{
					d(state);
				});
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0003DD60 File Offset: 0x0003BF60
		public override void Send(SendOrPostCallback d, object state)
		{
			Looper mainLooper = Looper.MainLooper;
			if (!SyncContext.EnsureLooper(mainLooper, d))
			{
				return;
			}
			if (Looper.MyLooper() == mainLooper)
			{
				d(state);
				return;
			}
			ManualResetEvent m = new ManualResetEvent(false);
			using (Handler handler = new Handler(mainLooper))
			{
				handler.Post(delegate()
				{
					d(state);
					m.Set();
				});
			}
			m.WaitOne();
		}
	}
}
