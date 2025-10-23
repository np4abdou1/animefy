using System;

namespace System.Reflection
{
	/// <summary>Describes the constraints on a generic type parameter of a generic type or method.</summary>
	// Token: 0x0200049F RID: 1183
	[Flags]
	public enum GenericParameterAttributes
	{
		/// <summary>There are no special flags.</summary>
		// Token: 0x04000FEA RID: 4074
		None = 0,
		/// <summary>Selects the combination of all variance flags. This value is the result of using logical OR to combine the following flags: <see cref="F:System.Reflection.GenericParameterAttributes.Contravariant" /> and <see cref="F:System.Reflection.GenericParameterAttributes.Covariant" />.</summary>
		// Token: 0x04000FEB RID: 4075
		VarianceMask = 3,
		/// <summary>The generic type parameter is covariant. A covariant type parameter can appear as the result type of a method, the type of a read-only field, a declared base type, or an implemented interface.</summary>
		// Token: 0x04000FEC RID: 4076
		Covariant = 1,
		/// <summary>The generic type parameter is contravariant. A contravariant type parameter can appear as a parameter type in method signatures. </summary>
		// Token: 0x04000FED RID: 4077
		Contravariant = 2,
		/// <summary>Selects the combination of all special constraint flags. This value is the result of using logical OR to combine the following flags: <see cref="F:System.Reflection.GenericParameterAttributes.DefaultConstructorConstraint" />, <see cref="F:System.Reflection.GenericParameterAttributes.ReferenceTypeConstraint" />, and <see cref="F:System.Reflection.GenericParameterAttributes.NotNullableValueTypeConstraint" />.</summary>
		// Token: 0x04000FEE RID: 4078
		SpecialConstraintMask = 28,
		/// <summary>A type can be substituted for the generic type parameter only if it is a reference type.</summary>
		// Token: 0x04000FEF RID: 4079
		ReferenceTypeConstraint = 4,
		/// <summary>A type can be substituted for the generic type parameter only if it is a value type and is not nullable.</summary>
		// Token: 0x04000FF0 RID: 4080
		NotNullableValueTypeConstraint = 8,
		/// <summary>A type can be substituted for the generic type parameter only if it has a parameterless constructor.</summary>
		// Token: 0x04000FF1 RID: 4081
		DefaultConstructorConstraint = 16
	}
}
