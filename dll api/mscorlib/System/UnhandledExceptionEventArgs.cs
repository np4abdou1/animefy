using System;

namespace System
{
	/// <summary>Provides data for the event that is raised when there is an exception that is not handled in any application domain.</summary>
	// Token: 0x02000116 RID: 278
	[Serializable]
	public class UnhandledExceptionEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UnhandledExceptionEventArgs" /> class with the exception object and a common language runtime termination flag.</summary>
		/// <param name="exception">The exception that is not handled. </param>
		/// <param name="isTerminating">
		///       <see langword="true" /> if the runtime is terminating; otherwise, <see langword="false" />. </param>
		// Token: 0x06000ABA RID: 2746 RVA: 0x0002BA46 File Offset: 0x00029C46
		public UnhandledExceptionEventArgs(object exception, bool isTerminating)
		{
			this._exception = exception;
			this._isTerminating = isTerminating;
		}

		// Token: 0x040003A9 RID: 937
		private object _exception;

		// Token: 0x040003AA RID: 938
		private bool _isTerminating;
	}
}
