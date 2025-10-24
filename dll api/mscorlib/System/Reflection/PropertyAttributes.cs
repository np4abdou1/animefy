using System;

namespace System.Reflection
{
	/// <summary>Defines the attributes that can be associated with a property. These attribute values are defined in corhdr.h.</summary>
	// Token: 0x020004B4 RID: 1204
	[Flags]
	public enum PropertyAttributes
	{
		/// <summary>Specifies that no attributes are associated with a property.</summary>
		// Token: 0x04001054 RID: 4180
		None = 0,
		/// <summary>Specifies that the property is special, with the name describing how the property is special.</summary>
		// Token: 0x04001055 RID: 4181
		SpecialName = 512,
		/// <summary>Specifies that the metadata internal APIs check the name encoding.</summary>
		// Token: 0x04001056 RID: 4182
		RTSpecialName = 1024,
		/// <summary>Specifies that the property has a default value.</summary>
		// Token: 0x04001057 RID: 4183
		HasDefault = 4096,
		/// <summary>Reserved.</summary>
		// Token: 0x04001058 RID: 4184
		Reserved2 = 8192,
		/// <summary>Reserved.</summary>
		// Token: 0x04001059 RID: 4185
		Reserved3 = 16384,
		/// <summary>Reserved.</summary>
		// Token: 0x0400105A RID: 4186
		Reserved4 = 32768,
		/// <summary>Specifies a flag reserved for runtime use only.</summary>
		// Token: 0x0400105B RID: 4187
		ReservedMask = 62464
	}
}
