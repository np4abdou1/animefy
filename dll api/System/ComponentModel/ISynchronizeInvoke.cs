using System;

namespace System.ComponentModel
{
	/// <summary>Provides a way to synchronously or asynchronously execute a delegate.</summary>
	// Token: 0x02000242 RID: 578
	public interface ISynchronizeInvoke
	{
		/// <summary>Gets a value indicating whether the caller must call <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" /> when calling an object that implements this interface.</summary>
		/// <returns>
		///     <see langword="true" /> if the caller must call <see cref="M:System.ComponentModel.ISynchronizeInvoke.Invoke(System.Delegate,System.Object[])" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000FAD RID: 4013
		bool InvokeRequired { get; }

		/// <summary>Asynchronously executes the delegate on the thread that created this object.</summary>
		/// <param name="method">A <see cref="T:System.Delegate" /> to a method that takes parameters of the same number and type that are contained in <paramref name="args" />. </param>
		/// <param name="args">An array of type <see cref="T:System.Object" /> to pass as arguments to the given method. This can be <see langword="null" /> if no arguments are needed. </param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> interface that represents the asynchronous operation started by calling this method.</returns>
		// Token: 0x06000FAE RID: 4014
		IAsyncResult BeginInvoke(Delegate method, object[] args);
	}
}
