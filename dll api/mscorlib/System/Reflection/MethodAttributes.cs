using System;

namespace System.Reflection
{
	/// <summary>Specifies flags for method attributes. These flags are defined in the corhdr.h file.</summary>
	// Token: 0x020004A8 RID: 1192
	[Flags]
	public enum MethodAttributes
	{
		/// <summary>Retrieves accessibility information.</summary>
		// Token: 0x04001002 RID: 4098
		MemberAccessMask = 7,
		/// <summary>Indicates that the member cannot be referenced.</summary>
		// Token: 0x04001003 RID: 4099
		PrivateScope = 0,
		/// <summary>Indicates that the method is accessible only to the current class.</summary>
		// Token: 0x04001004 RID: 4100
		Private = 1,
		/// <summary>Indicates that the method is accessible to members of this type and its derived types that are in this assembly only.</summary>
		// Token: 0x04001005 RID: 4101
		FamANDAssem = 2,
		/// <summary>Indicates that the method is accessible to any class of this assembly.</summary>
		// Token: 0x04001006 RID: 4102
		Assembly = 3,
		/// <summary>Indicates that the method is accessible only to members of this class and its derived classes.</summary>
		// Token: 0x04001007 RID: 4103
		Family = 4,
		/// <summary>Indicates that the method is accessible to derived classes anywhere, as well as to any class in the assembly.</summary>
		// Token: 0x04001008 RID: 4104
		FamORAssem = 5,
		/// <summary>Indicates that the method is accessible to any object for which this object is in scope.</summary>
		// Token: 0x04001009 RID: 4105
		Public = 6,
		/// <summary>Indicates that the method is defined on the type; otherwise, it is defined per instance.</summary>
		// Token: 0x0400100A RID: 4106
		Static = 16,
		/// <summary>Indicates that the method cannot be overridden.</summary>
		// Token: 0x0400100B RID: 4107
		Final = 32,
		/// <summary>Indicates that the method is virtual.</summary>
		// Token: 0x0400100C RID: 4108
		Virtual = 64,
		/// <summary>Indicates that the method hides by name and signature; otherwise, by name only.</summary>
		// Token: 0x0400100D RID: 4109
		HideBySig = 128,
		/// <summary>Indicates that the method can only be overridden when it is also accessible.</summary>
		// Token: 0x0400100E RID: 4110
		CheckAccessOnOverride = 512,
		/// <summary>Retrieves vtable attributes.</summary>
		// Token: 0x0400100F RID: 4111
		VtableLayoutMask = 256,
		/// <summary>Indicates that the method will reuse an existing slot in the vtable. This is the default behavior.</summary>
		// Token: 0x04001010 RID: 4112
		ReuseSlot = 0,
		/// <summary>Indicates that the method always gets a new slot in the vtable.</summary>
		// Token: 0x04001011 RID: 4113
		NewSlot = 256,
		/// <summary>Indicates that the class does not provide an implementation of this method.</summary>
		// Token: 0x04001012 RID: 4114
		Abstract = 1024,
		/// <summary>Indicates that the method is special. The name describes how this method is special.</summary>
		// Token: 0x04001013 RID: 4115
		SpecialName = 2048,
		/// <summary>Indicates that the method implementation is forwarded through PInvoke (Platform Invocation Services).</summary>
		// Token: 0x04001014 RID: 4116
		PinvokeImpl = 8192,
		/// <summary>Indicates that the managed method is exported by thunk to unmanaged code.</summary>
		// Token: 0x04001015 RID: 4117
		UnmanagedExport = 8,
		/// <summary>Indicates that the common language runtime checks the name encoding.</summary>
		// Token: 0x04001016 RID: 4118
		RTSpecialName = 4096,
		/// <summary>Indicates that the method has security associated with it. Reserved flag for runtime use only.</summary>
		// Token: 0x04001017 RID: 4119
		HasSecurity = 16384,
		/// <summary>Indicates that the method calls another method containing security code. Reserved flag for runtime use only.</summary>
		// Token: 0x04001018 RID: 4120
		RequireSecObject = 32768,
		/// <summary>Indicates a reserved flag for runtime use only.</summary>
		// Token: 0x04001019 RID: 4121
		ReservedMask = 53248
	}
}
