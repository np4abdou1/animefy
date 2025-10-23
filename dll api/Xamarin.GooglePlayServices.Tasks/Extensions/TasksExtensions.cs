using System;
using System.Threading.Tasks;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Lang;

namespace Android.Gms.Extensions
{
	// Token: 0x0200001C RID: 28
	public static class TasksExtensions
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00004698 File Offset: 0x00002898
		public static Task<TResult> AsAsync<TResult>(this Android.Gms.Tasks.Task task) where TResult : class, IJavaObject
		{
			AwaitableTaskCompleteListener<TResult> awaitableTaskCompleteListener = new AwaitableTaskCompleteListener<TResult>();
			task.AddOnCompleteListener(awaitableTaskCompleteListener);
			return awaitableTaskCompleteListener.AwaitAsync();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000046BC File Offset: 0x000028BC
		public static System.Threading.Tasks.Task AsAsync(this Android.Gms.Tasks.Task task)
		{
			AwaitableTaskCompleteListener<Java.Lang.Object> awaitableTaskCompleteListener = new AwaitableTaskCompleteListener<Java.Lang.Object>();
			task.AddOnCompleteListener(awaitableTaskCompleteListener);
			return awaitableTaskCompleteListener.AwaitAsync();
		}
	}
}
