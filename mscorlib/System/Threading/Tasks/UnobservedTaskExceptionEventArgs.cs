using System;

namespace System.Threading.Tasks
{
	/// <summary>Provides data for the event that is raised when a faulted <see cref="T:System.Threading.Tasks.Task" />'s exception goes unobserved.</summary>
	// Token: 0x02000236 RID: 566
	public class UnobservedTaskExceptionEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.UnobservedTaskExceptionEventArgs" /> class with the unobserved exception.</summary>
		/// <param name="exception">The Exception that has gone unobserved.</param>
		// Token: 0x060013D4 RID: 5076 RVA: 0x0004E8AA File Offset: 0x0004CAAA
		public UnobservedTaskExceptionEventArgs(AggregateException exception)
		{
			this.m_exception = exception;
		}

		// Token: 0x040007E3 RID: 2019
		private AggregateException m_exception;

		// Token: 0x040007E4 RID: 2020
		internal bool m_observed;
	}
}
