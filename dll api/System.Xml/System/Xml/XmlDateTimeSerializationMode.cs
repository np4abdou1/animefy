using System;

namespace System.Xml
{
	/// <summary>Specifies how to treat the time value when converting between string and <see cref="T:System.DateTime" />.</summary>
	// Token: 0x0200019F RID: 415
	public enum XmlDateTimeSerializationMode
	{
		/// <summary>Treat as local time. If the <see cref="T:System.DateTime" /> object represents a Coordinated Universal Time (UTC), it is converted to the local time.</summary>
		// Token: 0x04000A9D RID: 2717
		Local,
		/// <summary>Treat as a UTC. If the <see cref="T:System.DateTime" /> object represents a local time, it is converted to a UTC.</summary>
		// Token: 0x04000A9E RID: 2718
		Utc,
		/// <summary>Treat as a local time if a <see cref="T:System.DateTime" /> is being converted to a string.</summary>
		// Token: 0x04000A9F RID: 2719
		Unspecified,
		/// <summary>Time zone information should be preserved when converting.</summary>
		// Token: 0x04000AA0 RID: 2720
		RoundtripKind
	}
}
