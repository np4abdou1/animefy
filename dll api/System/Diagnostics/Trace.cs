using System;

namespace System.Diagnostics
{
	/// <summary>Provides a set of methods and properties that help you trace the execution of your code. This class cannot be inherited.</summary>
	// Token: 0x020000C0 RID: 192
	public sealed class Trace
	{
		/// <summary>Gets the collection of listeners that is monitoring the trace output.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.TraceListenerCollection" /> that represents a collection of type <see cref="T:System.Diagnostics.TraceListener" /> monitoring the trace output.</returns>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00024038 File Offset: 0x00022238
		public static TraceListenerCollection Listeners
		{
			get
			{
				return TraceInternal.Listeners;
			}
		}

		/// <summary>Gets or sets whether <see cref="M:System.Diagnostics.Trace.Flush" /> should be called on the <see cref="P:System.Diagnostics.Trace.Listeners" /> after every write.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="M:System.Diagnostics.Trace.Flush" /> is called on the <see cref="P:System.Diagnostics.Trace.Listeners" /> after every write; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x0002403F File Offset: 0x0002223F
		public static bool AutoFlush
		{
			get
			{
				return TraceInternal.AutoFlush;
			}
		}

		/// <summary>Gets the correlation manager for the thread for this trace.</summary>
		/// <returns>The <see cref="T:System.Diagnostics.CorrelationManager" /> object associated with the thread for this trace.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00024046 File Offset: 0x00022246
		public static CorrelationManager CorrelationManager
		{
			get
			{
				if (Trace.correlationManager == null)
				{
					Trace.correlationManager = new CorrelationManager();
				}
				return Trace.correlationManager;
			}
		}

		// Token: 0x040003A5 RID: 933
		private static volatile CorrelationManager correlationManager;
	}
}
