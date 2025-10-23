using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200008F RID: 143
	[NullableContext(1)]
	[Nullable(0)]
	internal static class AsyncUtils
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x0001A5D2 File Offset: 0x000187D2
		internal static Task<bool> ToAsync(this bool value)
		{
			if (!value)
			{
				return AsyncUtils.False;
			}
			return AsyncUtils.True;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001A5E2 File Offset: 0x000187E2
		[NullableContext(2)]
		public static Task CancelIfRequestedAsync(this CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return null;
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001A5F5 File Offset: 0x000187F5
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static Task<T> CancelIfRequestedAsync<T>(this CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return null;
			}
			return cancellationToken.FromCanceled<T>();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001A608 File Offset: 0x00018808
		public static Task FromCanceled(this CancellationToken cancellationToken)
		{
			return new Task(delegate()
			{
			}, cancellationToken);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001A630 File Offset: 0x00018830
		public static Task<T> FromCanceled<[Nullable(2)] T>(this CancellationToken cancellationToken)
		{
			Func<T> function;
			if ((function = AsyncUtils.<>c__6<T>.<>9__6_0) == null)
			{
				Func<T> func = AsyncUtils.<>c__6<T>.<>9__6_0 = (() => default(T));
				function = func;
			}
			return new Task<T>(function, cancellationToken);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0001A664 File Offset: 0x00018864
		public static Task WriteAsync(this TextWriter writer, char value, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001A67D File Offset: 0x0001887D
		public static Task WriteAsync(this TextWriter writer, [Nullable(2)] string value, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001A696 File Offset: 0x00018896
		public static Task WriteAsync(this TextWriter writer, char[] value, int start, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value, start, count);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001A6B2 File Offset: 0x000188B2
		public static Task<int> ReadAsync(this TextReader reader, char[] buffer, int index, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return reader.ReadAsync(buffer, index, count);
			}
			return cancellationToken.FromCanceled<int>();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0001A6CE File Offset: 0x000188CE
		public static bool IsCompletedSuccessfully(this Task task)
		{
			return task.Status == TaskStatus.RanToCompletion;
		}

		// Token: 0x04000360 RID: 864
		public static readonly Task<bool> False = Task.FromResult<bool>(false);

		// Token: 0x04000361 RID: 865
		public static readonly Task<bool> True = Task.FromResult<bool>(true);

		// Token: 0x04000362 RID: 866
		internal static readonly Task CompletedTask = Task.Delay(0);
	}
}
