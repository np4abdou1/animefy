using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	/// <summary>Specifies additional event schema information for an event.</summary>
	// Token: 0x020005C8 RID: 1480
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class EventAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Tracing.EventAttribute" /> class with the specified event identifier.</summary>
		/// <param name="eventId">The event identifier for the event.</param>
		// Token: 0x06002C54 RID: 11348 RVA: 0x000B7DB0 File Offset: 0x000B5FB0
		public EventAttribute(int eventId)
		{
			this.EventId = eventId;
		}

		/// <summary>Gets or sets the identifier for the event.</summary>
		/// <returns>The event identifier. This value should be between 0 and 65535.</returns>
		// Token: 0x170006B8 RID: 1720
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x000B7DBF File Offset: 0x000B5FBF
		private int EventId
		{
			[CompilerGenerated]
			set
			{
				this.<EventId>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets the level for the event.</summary>
		/// <returns>One of the enumeration values that specifies the level for the event.</returns>
		// Token: 0x170006B9 RID: 1721
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x000B7DC8 File Offset: 0x000B5FC8
		public EventLevel Level
		{
			[CompilerGenerated]
			set
			{
				this.<Level>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets the keywords for the event.</summary>
		/// <returns>A bitwise combination of the enumeration values.</returns>
		// Token: 0x170006BA RID: 1722
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x000B7DD1 File Offset: 0x000B5FD1
		public EventKeywords Keywords
		{
			[CompilerGenerated]
			set
			{
				this.<Keywords>k__BackingField = value;
			}
		}

		/// <summary>Gets or sets the message for the event.</summary>
		/// <returns>The message for the event.</returns>
		// Token: 0x170006BB RID: 1723
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x000B7DDA File Offset: 0x000B5FDA
		public string Message
		{
			[CompilerGenerated]
			set
			{
				this.<Message>k__BackingField = value;
			}
		}
	}
}
