using System;

namespace System.Reflection
{
	/// <summary>Specifies the attributes of an event.</summary>
	// Token: 0x02000497 RID: 1175
	[Flags]
	public enum EventAttributes
	{
		/// <summary>Specifies that the event has no attributes.</summary>
		// Token: 0x04000FCB RID: 4043
		None = 0,
		/// <summary>Specifies that the event is special in a way described by the name.</summary>
		// Token: 0x04000FCC RID: 4044
		SpecialName = 512,
		/// <summary>Specifies that the common language runtime should check name encoding.</summary>
		// Token: 0x04000FCD RID: 4045
		RTSpecialName = 1024,
		/// <summary>Specifies a reserved flag for common language runtime use only.</summary>
		// Token: 0x04000FCE RID: 4046
		ReservedMask = 1024
	}
}
