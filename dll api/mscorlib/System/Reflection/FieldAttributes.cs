using System;

namespace System.Reflection
{
	/// <summary>Specifies flags that describe the attributes of a field.</summary>
	// Token: 0x0200049D RID: 1181
	[Flags]
	public enum FieldAttributes
	{
		/// <summary>Specifies the access level of a given field.</summary>
		// Token: 0x04000FD6 RID: 4054
		FieldAccessMask = 7,
		/// <summary>Specifies that the field cannot be referenced.</summary>
		// Token: 0x04000FD7 RID: 4055
		PrivateScope = 0,
		/// <summary>Specifies that the field is accessible only by the parent type.</summary>
		// Token: 0x04000FD8 RID: 4056
		Private = 1,
		/// <summary>Specifies that the field is accessible only by subtypes in this assembly.</summary>
		// Token: 0x04000FD9 RID: 4057
		FamANDAssem = 2,
		/// <summary>Specifies that the field is accessible throughout the assembly.</summary>
		// Token: 0x04000FDA RID: 4058
		Assembly = 3,
		/// <summary>Specifies that the field is accessible only by type and subtypes.</summary>
		// Token: 0x04000FDB RID: 4059
		Family = 4,
		/// <summary>Specifies that the field is accessible by subtypes anywhere, as well as throughout this assembly.</summary>
		// Token: 0x04000FDC RID: 4060
		FamORAssem = 5,
		/// <summary>Specifies that the field is accessible by any member for whom this scope is visible.</summary>
		// Token: 0x04000FDD RID: 4061
		Public = 6,
		/// <summary>Specifies that the field represents the defined type, or else it is per-instance.</summary>
		// Token: 0x04000FDE RID: 4062
		Static = 16,
		/// <summary>Specifies that the field is initialized only, and can be set only in the body of a constructor.</summary>
		// Token: 0x04000FDF RID: 4063
		InitOnly = 32,
		/// <summary>Specifies that the field's value is a compile-time (static or early bound) constant. Any attempt to set it throws a <see cref="T:System.FieldAccessException" />.</summary>
		// Token: 0x04000FE0 RID: 4064
		Literal = 64,
		/// <summary>Specifies that the field does not have to be serialized when the type is remoted.</summary>
		// Token: 0x04000FE1 RID: 4065
		NotSerialized = 128,
		/// <summary>Specifies a special method, with the name describing how the method is special.</summary>
		// Token: 0x04000FE2 RID: 4066
		SpecialName = 512,
		/// <summary>Reserved for future use.</summary>
		// Token: 0x04000FE3 RID: 4067
		PinvokeImpl = 8192,
		/// <summary>Specifies that the common language runtime (metadata internal APIs) should check the name encoding.</summary>
		// Token: 0x04000FE4 RID: 4068
		RTSpecialName = 1024,
		/// <summary>Specifies that the field has marshaling information.</summary>
		// Token: 0x04000FE5 RID: 4069
		HasFieldMarshal = 4096,
		/// <summary>Specifies that the field has a default value.</summary>
		// Token: 0x04000FE6 RID: 4070
		HasDefault = 32768,
		/// <summary>Specifies that the field has a relative virtual address (RVA). The RVA is the location of the method body in the current image, as an address relative to the start of the image file in which it is located.</summary>
		// Token: 0x04000FE7 RID: 4071
		HasFieldRVA = 256,
		/// <summary>Reserved.</summary>
		// Token: 0x04000FE8 RID: 4072
		ReservedMask = 38144
	}
}
