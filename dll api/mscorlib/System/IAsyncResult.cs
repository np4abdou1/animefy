using System;
using System.Threading;

namespace System
{
	/// <summary>Represents the status of an asynchronous operation. </summary>
	// Token: 0x020000B7 RID: 183
	public interface IAsyncResult
	{
		/// <summary>Gets a value that indicates whether the asynchronous operation has completed.</summary>
		/// <returns>
		///     <see langword="true" /> if the operation is complete; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600061E RID: 1566
		bool IsCompleted { get; }

		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</returns>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600061F RID: 1567
		WaitHandle AsyncWaitHandle { get; }

		/// <summary>Gets a user-defined object that qualifies or contains information about an asynchronous operation.</summary>
		/// <returns>A user-defined object that qualifies or contains information about an asynchronous operation.</returns>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000620 RID: 1568
		object AsyncState { get; }

		/// <summary>Gets a value that indicates whether the asynchronous operation completed synchronously.</summary>
		/// <returns>
		///     <see langword="true" /> if the asynchronous operation completed synchronously; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000621 RID: 1569
		bool CompletedSynchronously { get; }
	}
}
