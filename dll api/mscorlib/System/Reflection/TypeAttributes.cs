using System;

namespace System.Reflection
{
	/// <summary>Specifies type attributes.</summary>
	// Token: 0x020004C2 RID: 1218
	[Flags]
	public enum TypeAttributes
	{
		/// <summary>Specifies type visibility information.</summary>
		// Token: 0x04001067 RID: 4199
		VisibilityMask = 7,
		/// <summary>Specifies that the class is not public.</summary>
		// Token: 0x04001068 RID: 4200
		NotPublic = 0,
		/// <summary>Specifies that the class is public.</summary>
		// Token: 0x04001069 RID: 4201
		Public = 1,
		/// <summary>Specifies that the class is nested with public visibility.</summary>
		// Token: 0x0400106A RID: 4202
		NestedPublic = 2,
		/// <summary>Specifies that the class is nested with private visibility.</summary>
		// Token: 0x0400106B RID: 4203
		NestedPrivate = 3,
		/// <summary>Specifies that the class is nested with family visibility, and is thus accessible only by methods within its own type and any derived types.</summary>
		// Token: 0x0400106C RID: 4204
		NestedFamily = 4,
		/// <summary>Specifies that the class is nested with assembly visibility, and is thus accessible only by methods within its assembly.</summary>
		// Token: 0x0400106D RID: 4205
		NestedAssembly = 5,
		/// <summary>Specifies that the class is nested with assembly and family visibility, and is thus accessible only by methods lying in the intersection of its family and assembly.</summary>
		// Token: 0x0400106E RID: 4206
		NestedFamANDAssem = 6,
		/// <summary>Specifies that the class is nested with family or assembly visibility, and is thus accessible only by methods lying in the union of its family and assembly.</summary>
		// Token: 0x0400106F RID: 4207
		NestedFamORAssem = 7,
		/// <summary>Specifies class layout information.</summary>
		// Token: 0x04001070 RID: 4208
		LayoutMask = 24,
		/// <summary>Specifies that class fields are automatically laid out by the common language runtime.</summary>
		// Token: 0x04001071 RID: 4209
		AutoLayout = 0,
		/// <summary>Specifies that class fields are laid out sequentially, in the order that the fields were emitted to the metadata.</summary>
		// Token: 0x04001072 RID: 4210
		SequentialLayout = 8,
		/// <summary>Specifies that class fields are laid out at the specified offsets.</summary>
		// Token: 0x04001073 RID: 4211
		ExplicitLayout = 16,
		/// <summary>Specifies class semantics information; the current class is contextful (else agile).</summary>
		// Token: 0x04001074 RID: 4212
		ClassSemanticsMask = 32,
		/// <summary>Specifies that the type is a class.</summary>
		// Token: 0x04001075 RID: 4213
		Class = 0,
		/// <summary>Specifies that the type is an interface.</summary>
		// Token: 0x04001076 RID: 4214
		Interface = 32,
		/// <summary>Specifies that the type is abstract.</summary>
		// Token: 0x04001077 RID: 4215
		Abstract = 128,
		/// <summary>Specifies that the class is concrete and cannot be extended.</summary>
		// Token: 0x04001078 RID: 4216
		Sealed = 256,
		/// <summary>Specifies that the class is special in a way denoted by the name.</summary>
		// Token: 0x04001079 RID: 4217
		SpecialName = 1024,
		/// <summary>Specifies that the class or interface is imported from another module.</summary>
		// Token: 0x0400107A RID: 4218
		Import = 4096,
		/// <summary>Specifies that the class can be serialized.</summary>
		// Token: 0x0400107B RID: 4219
		Serializable = 8192,
		/// <summary>Specifies a Windows Runtime type.</summary>
		// Token: 0x0400107C RID: 4220
		WindowsRuntime = 16384,
		/// <summary>Used to retrieve string information for native interoperability.</summary>
		// Token: 0x0400107D RID: 4221
		StringFormatMask = 196608,
		/// <summary>LPTSTR is interpreted as ANSI.</summary>
		// Token: 0x0400107E RID: 4222
		AnsiClass = 0,
		/// <summary>LPTSTR is interpreted as UNICODE.</summary>
		// Token: 0x0400107F RID: 4223
		UnicodeClass = 65536,
		/// <summary>LPTSTR is interpreted automatically.</summary>
		// Token: 0x04001080 RID: 4224
		AutoClass = 131072,
		/// <summary>LPSTR is interpreted by some implementation-specific means, which includes the possibility of throwing a <see cref="T:System.NotSupportedException" />. Not used in the Microsoft implementation of the .NET Framework.</summary>
		// Token: 0x04001081 RID: 4225
		CustomFormatClass = 196608,
		/// <summary>Used to retrieve non-standard encoding information for native interop. The meaning of the values of these 2 bits is unspecified. Not used in the Microsoft implementation of the .NET Framework.</summary>
		// Token: 0x04001082 RID: 4226
		CustomFormatMask = 12582912,
		/// <summary>Specifies that calling static methods of the type does not force the system to initialize the type.</summary>
		// Token: 0x04001083 RID: 4227
		BeforeFieldInit = 1048576,
		/// <summary>Runtime should check name encoding.</summary>
		// Token: 0x04001084 RID: 4228
		RTSpecialName = 2048,
		/// <summary>Type has security associate with it.</summary>
		// Token: 0x04001085 RID: 4229
		HasSecurity = 262144,
		/// <summary>Attributes reserved for runtime use.</summary>
		// Token: 0x04001086 RID: 4230
		ReservedMask = 264192
	}
}
