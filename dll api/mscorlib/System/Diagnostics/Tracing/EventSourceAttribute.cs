using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	/// <summary>Allows the event tracing for Windows (ETW) name to be defined independently of the name of the event source class.   </summary>
	// Token: 0x020005CB RID: 1483
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class EventSourceAttribute : Attribute
	{
		/// <summary>Gets or sets the event source identifier.</summary>
		/// <returns>The event source identifier.</returns>
		// Token: 0x170006C0 RID: 1728
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x000B7F3E File Offset: 0x000B613E
		public string Guid
		{
			[CompilerGenerated]
			set
			{
				this.<Guid>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets the name of the event source.</summary>
		/// <returns>The name of the event source.</returns>
		// Token: 0x170006C1 RID: 1729
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x000B7F47 File Offset: 0x000B6147
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}
	}
}
