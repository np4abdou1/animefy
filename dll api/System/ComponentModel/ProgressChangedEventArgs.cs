using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> event.</summary>
	// Token: 0x0200029F RID: 671
	public class ProgressChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ProgressChangedEventArgs" /> class.</summary>
		/// <param name="progressPercentage">The percentage of an asynchronous task that has been completed.</param>
		/// <param name="userState">A unique user state.</param>
		// Token: 0x060011B4 RID: 4532 RVA: 0x000531D7 File Offset: 0x000513D7
		public ProgressChangedEventArgs(int progressPercentage, object userState)
		{
			this.progressPercentage = progressPercentage;
			this.userState = userState;
		}

		// Token: 0x04000CB0 RID: 3248
		private readonly int progressPercentage;

		// Token: 0x04000CB1 RID: 3249
		private readonly object userState;
	}
}
