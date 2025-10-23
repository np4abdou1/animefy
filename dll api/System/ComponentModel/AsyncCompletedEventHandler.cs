using System;

namespace System.ComponentModel
{
	/// <summary>Represents the method that will handle the MethodName<see langword="Completed" /> event of an asynchronous operation.</summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">An <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" /> that contains the event data. </param>
	// Token: 0x02000297 RID: 663
	// (Invoke) Token: 0x06001182 RID: 4482
	public delegate void AsyncCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
}
