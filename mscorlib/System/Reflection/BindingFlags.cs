using System;

namespace System.Reflection
{
	/// <summary>Specifies flags that control binding and the way in which the search for members and types is conducted by reflection.</summary>
	// Token: 0x02000492 RID: 1170
	[Flags]
	public enum BindingFlags
	{
		/// <summary>Specifies that no binding flags are defined.</summary>
		// Token: 0x04000FAC RID: 4012
		Default = 0,
		/// <summary>Specifies that the case of the member name should not be considered when binding.</summary>
		// Token: 0x04000FAD RID: 4013
		IgnoreCase = 1,
		/// <summary>Specifies that only members declared at the level of the supplied type's hierarchy should be considered. Inherited members are not considered.</summary>
		// Token: 0x04000FAE RID: 4014
		DeclaredOnly = 2,
		/// <summary>Specifies that instance members are to be included in the search.</summary>
		// Token: 0x04000FAF RID: 4015
		Instance = 4,
		/// <summary>Specifies that static members are to be included in the search.</summary>
		// Token: 0x04000FB0 RID: 4016
		Static = 8,
		/// <summary>Specifies that public members are to be included in the search.</summary>
		// Token: 0x04000FB1 RID: 4017
		Public = 16,
		/// <summary>Specifies that non-public members are to be included in the search.</summary>
		// Token: 0x04000FB2 RID: 4018
		NonPublic = 32,
		/// <summary>Specifies that public and protected static members up the hierarchy should be returned. Private static members in inherited classes are not returned. Static members include fields, methods, events, and properties. Nested types are not returned.</summary>
		// Token: 0x04000FB3 RID: 4019
		FlattenHierarchy = 64,
		/// <summary>Specifies that a method is to be invoked. This must not be a constructor or a type initializer.This flag is passed to an <see langword="InvokeMember" /> method to invoke a method. </summary>
		// Token: 0x04000FB4 RID: 4020
		InvokeMethod = 256,
		/// <summary>Specifies that reflection should create an instance of the specified type. Calls the constructor that matches the given arguments. The supplied member name is ignored. If the type of lookup is not specified, (Instance | Public) will apply. It is not possible to call a type initializer.This flag is passed to an <see langword="InvokeMember" /> method to invoke a constructor. </summary>
		// Token: 0x04000FB5 RID: 4021
		CreateInstance = 512,
		/// <summary>Specifies that the value of the specified field should be returned.This flag is passed to an <see langword="InvokeMember" /> method to get a field value. </summary>
		// Token: 0x04000FB6 RID: 4022
		GetField = 1024,
		/// <summary>Specifies that the value of the specified field should be set.This flag is passed to an <see langword="InvokeMember" /> method to set a field value. </summary>
		// Token: 0x04000FB7 RID: 4023
		SetField = 2048,
		/// <summary>Specifies that the value of the specified property should be returned.This flag is passed to an <see langword="InvokeMember" /> method to invoke a property getter. </summary>
		// Token: 0x04000FB8 RID: 4024
		GetProperty = 4096,
		/// <summary>Specifies that the value of the specified property should be set. For COM properties, specifying this binding flag is equivalent to specifying <see langword="PutDispProperty" /> and <see langword="PutRefDispProperty" />.This flag is passed to an <see langword="InvokeMember" /> method to invoke a property setter. </summary>
		// Token: 0x04000FB9 RID: 4025
		SetProperty = 8192,
		/// <summary>Specifies that the <see langword="PROPPUT" /> member on a COM object should be invoked. <see langword="PROPPUT" /> specifies a property-setting function that uses a value. Use <see langword="PutDispProperty" /> if a property has both <see langword="PROPPUT" /> and <see langword="PROPPUTREF" /> and you need to distinguish which one is called.</summary>
		// Token: 0x04000FBA RID: 4026
		PutDispProperty = 16384,
		/// <summary>Specifies that the <see langword="PROPPUTREF" /> member on a COM object should be invoked. <see langword="PROPPUTREF" /> specifies a property-setting function that uses a reference instead of a value. Use <see langword="PutRefDispProperty" /> if a property has both <see langword="PROPPUT" /> and <see langword="PROPPUTREF" /> and you need to distinguish which one is called.</summary>
		// Token: 0x04000FBB RID: 4027
		PutRefDispProperty = 32768,
		/// <summary>Specifies that types of the supplied arguments must exactly match the types of the corresponding formal parameters. Reflection throws an exception if the caller supplies a non-null <see langword="Binder" /> object, since that implies that the caller is supplying <see langword="BindToXXX" /> implementations that will pick the appropriate method.</summary>
		// Token: 0x04000FBC RID: 4028
		ExactBinding = 65536,
		/// <summary>Not implemented.</summary>
		// Token: 0x04000FBD RID: 4029
		SuppressChangeType = 131072,
		/// <summary>Returns the set of members whose parameter count matches the number of supplied arguments. This binding flag is used for methods with parameters that have default values and methods with variable arguments (varargs). This flag should only be used with <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
		// Token: 0x04000FBE RID: 4030
		OptionalParamBinding = 262144,
		/// <summary>Used in COM interop to specify that the return value of the member can be ignored.</summary>
		// Token: 0x04000FBF RID: 4031
		IgnoreReturn = 16777216,
		// Token: 0x04000FC0 RID: 4032
		DoNotWrapExceptions = 33554432
	}
}
