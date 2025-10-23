using System;
using System.Threading;

namespace System.ComponentModel
{
	/// <summary>Tracks the lifetime of an asynchronous operation.</summary>
	// Token: 0x02000233 RID: 563
	public sealed class AsyncOperation
	{
		// Token: 0x06000F68 RID: 3944 RVA: 0x0004D009 File Offset: 0x0004B209
		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			this._userSuppliedState = userSuppliedState;
			this._syncContext = syncContext;
			this._alreadyCompleted = false;
			this._syncContext.OperationStarted();
		}

		/// <summary>Finalizes the asynchronous operation.</summary>
		// Token: 0x06000F69 RID: 3945 RVA: 0x0004D034 File Offset: 0x0004B234
		~AsyncOperation()
		{
			if (!this._alreadyCompleted && this._syncContext != null)
			{
				this._syncContext.OperationCompleted();
			}
		}

		/// <summary>Gets or sets an object used to uniquely identify an asynchronous operation.</summary>
		/// <returns>The state object passed to the asynchronous method invocation.</returns>
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004D078 File Offset: 0x0004B278
		public object UserSuppliedState
		{
			get
			{
				return this._userSuppliedState;
			}
		}

		/// <summary>Invokes a delegate on the thread or context appropriate for the application model.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.ComponentModel.AsyncOperation.PostOperationCompleted(System.Threading.SendOrPostCallback,System.Object)" /> method has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="d" /> is <see langword="null" />. </exception>
		// Token: 0x06000F6B RID: 3947 RVA: 0x0004D080 File Offset: 0x0004B280
		public void Post(SendOrPostCallback d, object arg)
		{
			this.PostCore(d, arg, false);
		}

		/// <summary>Ends the lifetime of an asynchronous operation.</summary>
		/// <param name="d">A <see cref="T:System.Threading.SendOrPostCallback" /> object that wraps the delegate to be called when the operation ends. </param>
		/// <param name="arg">An argument for the delegate contained in the <paramref name="d" /> parameter. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.ComponentModel.AsyncOperation.OperationCompleted" /> has been called previously for this task. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="d" /> is <see langword="null" />. </exception>
		// Token: 0x06000F6C RID: 3948 RVA: 0x0004D08B File Offset: 0x0004B28B
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
			this.PostCore(d, arg, true);
			this.OperationCompletedCore();
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0004D09C File Offset: 0x0004B29C
		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
			this.VerifyNotCompleted();
			this.VerifyDelegateNotNull(d);
			if (markCompleted)
			{
				this._alreadyCompleted = true;
			}
			this._syncContext.Post(d, arg);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0004D0C4 File Offset: 0x0004B2C4
		private void OperationCompletedCore()
		{
			try
			{
				this._syncContext.OperationCompleted();
			}
			finally
			{
				GC.SuppressFinalize(this);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0004D0F8 File Offset: 0x0004B2F8
		private void VerifyNotCompleted()
		{
			if (this._alreadyCompleted)
			{
				throw new InvalidOperationException("This operation has already had OperationCompleted called on it and further calls are illegal.");
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0004D10D File Offset: 0x0004B30D
		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d", "A non-null SendOrPostCallback must be supplied.");
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0004D122 File Offset: 0x0004B322
		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			return new AsyncOperation(userSuppliedState, syncContext);
		}

		// Token: 0x04000BFD RID: 3069
		private readonly SynchronizationContext _syncContext;

		// Token: 0x04000BFE RID: 3070
		private readonly object _userSuppliedState;

		// Token: 0x04000BFF RID: 3071
		private bool _alreadyCompleted;
	}
}
