using System;

namespace System
{
	/// <summary>Specifies whether a <see cref="T:System.DateTime" /> object represents a local time, a Coordinated Universal Time (UTC), or is not specified as either local time or UTC.</summary>
	// Token: 0x02000090 RID: 144
	public enum DateTimeKind
	{
		/// <summary>The time represented is not specified as either local time or Coordinated Universal Time (UTC).</summary>
		// Token: 0x04000211 RID: 529
		Unspecified,
		/// <summary>The time represented is UTC.</summary>
		// Token: 0x04000212 RID: 530
		Utc,
		/// <summary>The time represented is local time.</summary>
		// Token: 0x04000213 RID: 531
		Local
	}
}
