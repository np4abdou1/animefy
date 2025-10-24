using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util.Concurrent
{
	// Token: 0x02000349 RID: 841
	[Register("java/util/concurrent/CompletionStage", "", "Java.Util.Concurrent.ICompletionStageInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ICompletionStage : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002461 RID: 9313
		ICompletionStage AcceptEither(ICompletionStage other, IConsumer action);

		// Token: 0x06002462 RID: 9314
		ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action);

		// Token: 0x06002463 RID: 9315
		ICompletionStage AcceptEitherAsync(ICompletionStage other, IConsumer action, IExecutor executor);

		// Token: 0x06002464 RID: 9316
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ApplyToEither(ICompletionStage other, IFunction fn);

		// Token: 0x06002465 RID: 9317
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn);

		// Token: 0x06002466 RID: 9318
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ApplyToEitherAsync(ICompletionStage other, IFunction fn, IExecutor executor);

		// Token: 0x06002467 RID: 9319
		ICompletionStage Exceptionally(IFunction fn);

		// Token: 0x06002468 RID: 9320
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage Handle(IBiFunction fn);

		// Token: 0x06002469 RID: 9321
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage HandleAsync(IBiFunction fn);

		// Token: 0x0600246A RID: 9322
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage HandleAsync(IBiFunction fn, IExecutor executor);

		// Token: 0x0600246B RID: 9323
		ICompletionStage RunAfterBoth(ICompletionStage other, IRunnable action);

		// Token: 0x0600246C RID: 9324
		ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action);

		// Token: 0x0600246D RID: 9325
		ICompletionStage RunAfterBothAsync(ICompletionStage other, IRunnable action, IExecutor executor);

		// Token: 0x0600246E RID: 9326
		ICompletionStage RunAfterEither(ICompletionStage other, IRunnable action);

		// Token: 0x0600246F RID: 9327
		ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action);

		// Token: 0x06002470 RID: 9328
		ICompletionStage RunAfterEitherAsync(ICompletionStage other, IRunnable action, IExecutor executor);

		// Token: 0x06002471 RID: 9329
		ICompletionStage ThenAccept(IConsumer action);

		// Token: 0x06002472 RID: 9330
		ICompletionStage ThenAcceptAsync(IConsumer action);

		// Token: 0x06002473 RID: 9331
		ICompletionStage ThenAcceptAsync(IConsumer action, IExecutor executor);

		// Token: 0x06002474 RID: 9332
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenAcceptBoth(ICompletionStage other, IBiConsumer action);

		// Token: 0x06002475 RID: 9333
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action);

		// Token: 0x06002476 RID: 9334
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenAcceptBothAsync(ICompletionStage other, IBiConsumer action, IExecutor executor);

		// Token: 0x06002477 RID: 9335
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenApply(IFunction fn);

		// Token: 0x06002478 RID: 9336
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenApplyAsync(IFunction fn);

		// Token: 0x06002479 RID: 9337
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenApplyAsync(IFunction fn, IExecutor executor);

		// Token: 0x0600247A RID: 9338
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		ICompletionStage ThenCombine(ICompletionStage other, IBiFunction fn);

		// Token: 0x0600247B RID: 9339
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn);

		// Token: 0x0600247C RID: 9340
		[JavaTypeParameters(new string[]
		{
			"U",
			"V"
		})]
		ICompletionStage ThenCombineAsync(ICompletionStage other, IBiFunction fn, IExecutor executor);

		// Token: 0x0600247D RID: 9341
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenCompose(IFunction fn);

		// Token: 0x0600247E RID: 9342
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenComposeAsync(IFunction fn);

		// Token: 0x0600247F RID: 9343
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		ICompletionStage ThenComposeAsync(IFunction fn, IExecutor executor);

		// Token: 0x06002480 RID: 9344
		ICompletionStage ThenRun(IRunnable action);

		// Token: 0x06002481 RID: 9345
		ICompletionStage ThenRunAsync(IRunnable action);

		// Token: 0x06002482 RID: 9346
		ICompletionStage ThenRunAsync(IRunnable action, IExecutor executor);

		// Token: 0x06002483 RID: 9347
		CompletableFuture ToCompletableFuture();

		// Token: 0x06002484 RID: 9348
		ICompletionStage WhenComplete(IBiConsumer action);

		// Token: 0x06002485 RID: 9349
		ICompletionStage WhenCompleteAsync(IBiConsumer action);

		// Token: 0x06002486 RID: 9350
		ICompletionStage WhenCompleteAsync(IBiConsumer action, IExecutor executor);
	}
}
