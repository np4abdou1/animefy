using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000465 RID: 1125
	internal static class AsyncTaskCache
	{
		// Token: 0x06002069 RID: 8297 RVA: 0x00088C44 File Offset: 0x00086E44
		private static Task<int>[] CreateInt32Tasks()
		{
			Task<int>[] array = new Task<int>[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = AsyncTaskCache.CreateCacheableTask<int>(i + -1);
			}
			return array;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00088C74 File Offset: 0x00086E74
		internal static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			return new Task<TResult>(false, result, (TaskCreationOptions)16384, default(CancellationToken));
		}

		// Token: 0x04000F61 RID: 3937
		internal static readonly Task<bool> TrueTask = AsyncTaskCache.CreateCacheableTask<bool>(true);

		// Token: 0x04000F62 RID: 3938
		internal static readonly Task<bool> FalseTask = AsyncTaskCache.CreateCacheableTask<bool>(false);

		// Token: 0x04000F63 RID: 3939
		internal static readonly Task<int>[] Int32Tasks = AsyncTaskCache.CreateInt32Tasks();
	}
}
