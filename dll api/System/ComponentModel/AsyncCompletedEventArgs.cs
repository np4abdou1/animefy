using System;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides data for the MethodName<see langword="Completed" /> event.</summary>
	// Token: 0x02000296 RID: 662
	public class AsyncCompletedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" /> class. </summary>
		/// <param name="error">Any error that occurred during the asynchronous operation.</param>
		/// <param name="cancelled">A value indicating whether the asynchronous operation was canceled.</param>
		/// <param name="userState">The optional user-supplied state object passed to the <see cref="M:System.ComponentModel.BackgroundWorker.RunWorkerAsync(System.Object)" /> method.</param>
		// Token: 0x0600117D RID: 4477 RVA: 0x00052047 File Offset: 0x00050247
		public AsyncCompletedEventArgs(Exception error, bool cancelled, object userState)
		{
			this.error = error;
			this.cancelled = cancelled;
			this.userState = userState;
		}

		/// <summary>Gets a value indicating whether an asynchronous operation has been canceled.</summary>
		/// <returns>
		///     <see langword="true" /> if the background operation has been canceled; otherwise <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00052064 File Offset: 0x00050264
		[SRDescription("True if operation was cancelled.")]
		public bool Cancelled
		{
			get
			{
				return this.cancelled;
			}
		}

		/// <summary>Gets a value indicating which error occurred during an asynchronous operation.</summary>
		/// <returns>An <see cref="T:System.Exception" /> instance, if an error occurred during an asynchronous operation; otherwise <see langword="null" />.</returns>
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0005206C File Offset: 0x0005026C
		[SRDescription("Exception that occurred during operation.  Null if no error.")]
		public Exception Error
		{
			get
			{
				return this.error;
			}
		}

		/// <summary>Raises a user-supplied exception if an asynchronous operation failed.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Cancelled" /> property is <see langword="true" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" /> property has been set by the asynchronous operation. The <see cref="P:System.Exception.InnerException" /> property holds a reference to <see cref="P:System.ComponentModel.AsyncCompletedEventArgs.Error" />. </exception>
		// Token: 0x06001180 RID: 4480 RVA: 0x00052074 File Offset: 0x00050274
		protected void RaiseExceptionIfNecessary()
		{
			if (this.Error != null)
			{
				throw new TargetInvocationException(SR.GetString("An exception occurred during the operation, making the result invalid.  Check InnerException for exception details."), this.Error);
			}
			if (this.Cancelled)
			{
				throw new InvalidOperationException(SR.GetString("Operation has been cancelled."));
			}
		}

		// Token: 0x04000C9C RID: 3228
		private readonly Exception error;

		// Token: 0x04000C9D RID: 3229
		private readonly bool cancelled;

		// Token: 0x04000C9E RID: 3230
		private readonly object userState;
	}
}
