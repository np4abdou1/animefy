using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000110 RID: 272
	[NullableContext(1)]
	public interface ITraceWriter
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060007CC RID: 1996
		TraceLevel LevelFilter { get; }

		// Token: 0x060007CD RID: 1997
		void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex);
	}
}
