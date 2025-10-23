using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Dynamic.Utils
{
	// Token: 0x02000142 RID: 322
	internal static class TypeUtils
	{
		// Token: 0x06000A1E RID: 2590 RVA: 0x00025BB7 File Offset: 0x00023DB7
		public static Type GetNonNullableType(this Type type)
		{
			if (!type.IsNullableType())
			{
				return type;
			}
			return type.GetGenericArguments()[0];
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00025BCB File Offset: 0x00023DCB
		public static Type GetNullableType(this Type type)
		{
			if (type.IsValueType && !type.IsNullableType())
			{
				return typeof(Nullable<>).MakeGenericType(new Type[]
				{
					type
				});
			}
			return type;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00025BF8 File Offset: 0x00023DF8
		public static bool IsNullableType(this Type type)
		{
			return type.IsConstructedGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00025C19 File Offset: 0x00023E19
		public static bool IsNullableOrReferenceType(this Type type)
		{
			return !type.IsValueType || type.IsNullableType();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00025C2B File Offset: 0x00023E2B
		public static bool IsBool(this Type type)
		{
			return type.GetNonNullableType() == typeof(bool);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00025C44 File Offset: 0x00023E44
		public static bool IsNumeric(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				TypeCode typeCode = type.GetTypeCode();
				if (typeCode - TypeCode.Char <= 10)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00025C74 File Offset: 0x00023E74
		public static bool IsInteger(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				TypeCode typeCode = type.GetTypeCode();
				if (typeCode - TypeCode.SByte <= 7)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00025CA4 File Offset: 0x00023EA4
		public static bool IsInteger64(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				TypeCode typeCode = type.GetTypeCode();
				if (typeCode - TypeCode.Int64 <= 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00025CD4 File Offset: 0x00023ED4
		public static bool IsArithmetic(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				TypeCode typeCode = type.GetTypeCode();
				if (typeCode - TypeCode.Int16 <= 7)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00025D04 File Offset: 0x00023F04
		public static bool IsUnsignedInt(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				switch (type.GetTypeCode())
				{
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00025D4C File Offset: 0x00023F4C
		public static bool IsIntegerOrBool(this Type type)
		{
			type = type.GetNonNullableType();
			if (!type.IsEnum)
			{
				TypeCode typeCode = type.GetTypeCode();
				if (typeCode == TypeCode.Boolean || typeCode - TypeCode.SByte <= 7)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00025D80 File Offset: 0x00023F80
		public static bool IsValidInstanceType(MemberInfo member, Type instanceType)
		{
			Type declaringType = member.DeclaringType;
			if (TypeUtils.AreReferenceAssignable(declaringType, instanceType))
			{
				return true;
			}
			if (declaringType == null)
			{
				return false;
			}
			if (instanceType.IsValueType)
			{
				if (TypeUtils.AreReferenceAssignable(declaringType, typeof(object)))
				{
					return true;
				}
				if (TypeUtils.AreReferenceAssignable(declaringType, typeof(ValueType)))
				{
					return true;
				}
				if (instanceType.IsEnum && TypeUtils.AreReferenceAssignable(declaringType, typeof(Enum)))
				{
					return true;
				}
				if (declaringType.IsInterface)
				{
					foreach (Type src in instanceType.GetTypeInfo().ImplementedInterfaces)
					{
						if (TypeUtils.AreReferenceAssignable(declaringType, src))
						{
							return true;
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00025E50 File Offset: 0x00024050
		public static bool HasIdentityPrimitiveOrNullableConversionTo(this Type source, Type dest)
		{
			return TypeUtils.AreEquivalent(source, dest) || (source.IsNullableType() && TypeUtils.AreEquivalent(dest, source.GetNonNullableType())) || (dest.IsNullableType() && TypeUtils.AreEquivalent(source, dest.GetNonNullableType())) || (source.IsConvertible() && dest.IsConvertible() && (dest.GetNonNullableType() != typeof(bool) || (source.IsEnum && source.GetEnumUnderlyingType() == typeof(bool))));
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00025EE4 File Offset: 0x000240E4
		public static bool HasReferenceConversionTo(this Type source, Type dest)
		{
			if (source == typeof(void) || dest == typeof(void))
			{
				return false;
			}
			Type nonNullableType = source.GetNonNullableType();
			Type nonNullableType2 = dest.GetNonNullableType();
			return nonNullableType.IsAssignableFrom(nonNullableType2) || nonNullableType2.IsAssignableFrom(nonNullableType) || (source.IsInterface || dest.IsInterface) || TypeUtils.IsLegalExplicitVariantDelegateConversion(source, dest) || ((source.IsArray || dest.IsArray) && source.StrictHasReferenceConversionTo(dest, true));
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00025F74 File Offset: 0x00024174
		private static bool StrictHasReferenceConversionTo(this Type source, Type dest, bool skipNonArray)
		{
			for (;;)
			{
				if (!skipNonArray)
				{
					if (source.IsValueType | dest.IsValueType)
					{
						break;
					}
					if (source.IsAssignableFrom(dest) || dest.IsAssignableFrom(source))
					{
						return true;
					}
					if (source.IsInterface)
					{
						if (dest.IsInterface || (dest.IsClass && !dest.IsSealed))
						{
							return true;
						}
					}
					else if (dest.IsInterface && source.IsClass && !source.IsSealed)
					{
						return true;
					}
				}
				if (!source.IsArray)
				{
					goto IL_B2;
				}
				if (!dest.IsArray)
				{
					goto IL_AA;
				}
				if (source.GetArrayRank() != dest.GetArrayRank() || source.IsSZArray != dest.IsSZArray)
				{
					return false;
				}
				source = source.GetElementType();
				dest = dest.GetElementType();
				skipNonArray = false;
			}
			return false;
			IL_AA:
			return TypeUtils.HasArrayToInterfaceConversion(source, dest);
			IL_B2:
			if (dest.IsArray)
			{
				return TypeUtils.HasInterfaceToArrayConversion(source, dest) || TypeUtils.IsImplicitReferenceConversion(typeof(Array), source);
			}
			return TypeUtils.IsLegalExplicitVariantDelegateConversion(source, dest);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00026060 File Offset: 0x00024260
		private static bool HasArrayToInterfaceConversion(Type source, Type dest)
		{
			if (!source.IsSZArray || !dest.IsInterface || !dest.IsGenericType)
			{
				return false;
			}
			Type[] genericArguments = dest.GetGenericArguments();
			if (genericArguments.Length != 1)
			{
				return false;
			}
			Type genericTypeDefinition = dest.GetGenericTypeDefinition();
			foreach (Type t in TypeUtils.s_arrayAssignableInterfaces)
			{
				if (TypeUtils.AreEquivalent(genericTypeDefinition, t))
				{
					return source.GetElementType().StrictHasReferenceConversionTo(genericArguments[0], false);
				}
			}
			return false;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000260D4 File Offset: 0x000242D4
		private static bool HasInterfaceToArrayConversion(Type source, Type dest)
		{
			if (!dest.IsSZArray || !source.IsInterface || !source.IsGenericType)
			{
				return false;
			}
			Type[] genericArguments = source.GetGenericArguments();
			if (genericArguments.Length != 1)
			{
				return false;
			}
			Type genericTypeDefinition = source.GetGenericTypeDefinition();
			foreach (Type t in TypeUtils.s_arrayAssignableInterfaces)
			{
				if (TypeUtils.AreEquivalent(genericTypeDefinition, t))
				{
					return genericArguments[0].StrictHasReferenceConversionTo(dest.GetElementType(), false);
				}
			}
			return false;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00026145 File Offset: 0x00024345
		private static bool IsCovariant(Type t)
		{
			return (t.GenericParameterAttributes & GenericParameterAttributes.Covariant) > GenericParameterAttributes.None;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00026152 File Offset: 0x00024352
		private static bool IsContravariant(Type t)
		{
			return (t.GenericParameterAttributes & GenericParameterAttributes.Contravariant) > GenericParameterAttributes.None;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002615F File Offset: 0x0002435F
		private static bool IsInvariant(Type t)
		{
			return (t.GenericParameterAttributes & GenericParameterAttributes.VarianceMask) == GenericParameterAttributes.None;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002616C File Offset: 0x0002436C
		private static bool IsDelegate(Type t)
		{
			return t.IsSubclassOf(typeof(MulticastDelegate));
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00026180 File Offset: 0x00024380
		public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
		{
			if (!TypeUtils.IsDelegate(source) || !TypeUtils.IsDelegate(dest) || !source.IsGenericType || !dest.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = source.GetGenericTypeDefinition();
			if (dest.GetGenericTypeDefinition() != genericTypeDefinition)
			{
				return false;
			}
			Type[] genericArguments = genericTypeDefinition.GetGenericArguments();
			Type[] genericArguments2 = source.GetGenericArguments();
			Type[] genericArguments3 = dest.GetGenericArguments();
			for (int i = 0; i < genericArguments.Length; i++)
			{
				Type type = genericArguments2[i];
				Type type2 = genericArguments3[i];
				if (!TypeUtils.AreEquivalent(type, type2))
				{
					Type t = genericArguments[i];
					if (TypeUtils.IsInvariant(t))
					{
						return false;
					}
					if (TypeUtils.IsCovariant(t))
					{
						if (!type.HasReferenceConversionTo(type2))
						{
							return false;
						}
					}
					else if (TypeUtils.IsContravariant(t) && (type.IsValueType || type2.IsValueType))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002624C File Offset: 0x0002444C
		public static bool IsConvertible(this Type type)
		{
			type = type.GetNonNullableType();
			if (type.IsEnum)
			{
				return true;
			}
			TypeCode typeCode = type.GetTypeCode();
			return typeCode - TypeCode.Boolean <= 11;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002627C File Offset: 0x0002447C
		public static bool HasReferenceEquality(Type left, Type right)
		{
			return !left.IsValueType && !right.IsValueType && (left.IsInterface || right.IsInterface || TypeUtils.AreReferenceAssignable(left, right) || TypeUtils.AreReferenceAssignable(right, left));
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000262B4 File Offset: 0x000244B4
		public static bool HasBuiltInEqualityOperator(Type left, Type right)
		{
			if (left.IsInterface && !right.IsValueType)
			{
				return true;
			}
			if (right.IsInterface && !left.IsValueType)
			{
				return true;
			}
			if (!left.IsValueType && !right.IsValueType && (TypeUtils.AreReferenceAssignable(left, right) || TypeUtils.AreReferenceAssignable(right, left)))
			{
				return true;
			}
			if (!TypeUtils.AreEquivalent(left, right))
			{
				return false;
			}
			Type nonNullableType = left.GetNonNullableType();
			return nonNullableType == typeof(bool) || nonNullableType.IsNumeric() || nonNullableType.IsEnum;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002633D File Offset: 0x0002453D
		public static bool IsImplicitlyConvertibleTo(this Type source, Type destination)
		{
			return TypeUtils.AreEquivalent(source, destination) || TypeUtils.IsImplicitNumericConversion(source, destination) || TypeUtils.IsImplicitReferenceConversion(source, destination) || TypeUtils.IsImplicitBoxingConversion(source, destination) || TypeUtils.IsImplicitNullableConversion(source, destination);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002636C File Offset: 0x0002456C
		public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType)
		{
			Type nonNullableType = convertFrom.GetNonNullableType();
			Type nonNullableType2 = convertToType.GetNonNullableType();
			MethodInfo[] methods = nonNullableType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			MethodInfo methodInfo = TypeUtils.FindConversionOperator(methods, convertFrom, convertToType);
			if (methodInfo != null)
			{
				return methodInfo;
			}
			MethodInfo[] methods2 = nonNullableType2.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			methodInfo = TypeUtils.FindConversionOperator(methods2, convertFrom, convertToType);
			if (methodInfo != null)
			{
				return methodInfo;
			}
			if (TypeUtils.AreEquivalent(nonNullableType, convertFrom) && TypeUtils.AreEquivalent(nonNullableType2, convertToType))
			{
				return null;
			}
			MethodInfo result;
			if ((result = TypeUtils.FindConversionOperator(methods, nonNullableType, nonNullableType2)) == null && (result = TypeUtils.FindConversionOperator(methods2, nonNullableType, nonNullableType2)) == null)
			{
				result = (TypeUtils.FindConversionOperator(methods, nonNullableType, convertToType) ?? TypeUtils.FindConversionOperator(methods2, nonNullableType, convertToType));
			}
			return result;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00026408 File Offset: 0x00024608
		private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo)
		{
			foreach (MethodInfo methodInfo in methods)
			{
				if ((methodInfo.Name == "op_Implicit" || methodInfo.Name == "op_Explicit") && TypeUtils.AreEquivalent(methodInfo.ReturnType, typeTo))
				{
					ParameterInfo[] parametersCached = methodInfo.GetParametersCached();
					if (parametersCached.Length == 1 && TypeUtils.AreEquivalent(parametersCached[0].ParameterType, typeFrom))
					{
						return methodInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002647C File Offset: 0x0002467C
		private static bool IsImplicitNumericConversion(Type source, Type destination)
		{
			TypeCode typeCode = source.GetTypeCode();
			TypeCode typeCode2 = destination.GetTypeCode();
			switch (typeCode)
			{
			case TypeCode.Char:
				if (typeCode2 - TypeCode.UInt16 <= 7)
				{
					return true;
				}
				break;
			case TypeCode.SByte:
				switch (typeCode2)
				{
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.Byte:
				if (typeCode2 - TypeCode.Int16 <= 8)
				{
					return true;
				}
				break;
			case TypeCode.Int16:
				switch (typeCode2)
				{
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.Single:
				case TypeCode.Double:
				case TypeCode.Decimal:
					return true;
				}
				break;
			case TypeCode.UInt16:
				if (typeCode2 - TypeCode.Int32 <= 6)
				{
					return true;
				}
				break;
			case TypeCode.Int32:
				if (typeCode2 == TypeCode.Int64 || typeCode2 - TypeCode.Single <= 2)
				{
					return true;
				}
				break;
			case TypeCode.UInt32:
				if (typeCode2 - TypeCode.Int64 <= 4)
				{
					return true;
				}
				break;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				if (typeCode2 - TypeCode.Single <= 2)
				{
					return true;
				}
				break;
			case TypeCode.Single:
				return typeCode2 == TypeCode.Double;
			}
			return false;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00026565 File Offset: 0x00024765
		private static bool IsImplicitReferenceConversion(Type source, Type destination)
		{
			return destination.IsAssignableFrom(source);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00026570 File Offset: 0x00024770
		private static bool IsImplicitBoxingConversion(Type source, Type destination)
		{
			return (source.IsValueType && (destination == typeof(object) || destination == typeof(ValueType))) || (source.IsEnum && destination == typeof(Enum));
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000265C5 File Offset: 0x000247C5
		private static bool IsImplicitNullableConversion(Type source, Type destination)
		{
			return destination.IsNullableType() && source.GetNonNullableType().IsImplicitlyConvertibleTo(destination.GetNonNullableType());
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000265E4 File Offset: 0x000247E4
		public static Type FindGenericType(Type definition, Type type)
		{
			while (type != null && type != typeof(object))
			{
				if (type.IsConstructedGenericType && TypeUtils.AreEquivalent(type.GetGenericTypeDefinition(), definition))
				{
					return type;
				}
				if (definition.IsInterface)
				{
					foreach (Type type2 in type.GetTypeInfo().ImplementedInterfaces)
					{
						Type type3 = TypeUtils.FindGenericType(definition, type2);
						if (type3 != null)
						{
							return type3;
						}
					}
				}
				type = type.BaseType;
			}
			return null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00026688 File Offset: 0x00024888
		public static MethodInfo GetBooleanOperator(Type type, string name)
		{
			MethodInfo anyStaticMethodValidated;
			for (;;)
			{
				anyStaticMethodValidated = type.GetAnyStaticMethodValidated(name, new Type[]
				{
					type
				});
				if (anyStaticMethodValidated != null && anyStaticMethodValidated.IsSpecialName && !anyStaticMethodValidated.ContainsGenericParameters)
				{
					break;
				}
				type = type.BaseType;
				if (!(type != null))
				{
					goto Block_3;
				}
			}
			return anyStaticMethodValidated;
			Block_3:
			return null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000266D4 File Offset: 0x000248D4
		public static Type GetNonRefType(this Type type)
		{
			if (!type.IsByRef)
			{
				return type;
			}
			return type.GetElementType();
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000266E6 File Offset: 0x000248E6
		public static bool AreEquivalent(Type t1, Type t2)
		{
			return t1 != null && t1.IsEquivalentTo(t2);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000266FA File Offset: 0x000248FA
		public static bool AreReferenceAssignable(Type dest, Type src)
		{
			return TypeUtils.AreEquivalent(dest, src) || (!dest.IsValueType && !src.IsValueType && dest.IsAssignableFrom(src));
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00026720 File Offset: 0x00024920
		public static bool IsSameOrSubclass(Type type, Type subType)
		{
			return TypeUtils.AreEquivalent(type, subType) || subType.IsSubclassOf(type);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00026734 File Offset: 0x00024934
		public static void ValidateType(Type type, string paramName)
		{
			TypeUtils.ValidateType(type, paramName, false, false);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002673F File Offset: 0x0002493F
		public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer)
		{
			if (TypeUtils.ValidateType(type, paramName, -1))
			{
				if (!allowByRef && type.IsByRef)
				{
					throw System.Linq.Expressions.Error.TypeMustNotBeByRef(paramName);
				}
				if (!allowPointer && type.IsPointer)
				{
					throw System.Linq.Expressions.Error.TypeMustNotBePointer(paramName);
				}
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002676F File Offset: 0x0002496F
		public static bool ValidateType(Type type, string paramName, int index)
		{
			if (type == typeof(void))
			{
				return false;
			}
			if (type.ContainsGenericParameters)
			{
				throw type.IsGenericTypeDefinition ? System.Linq.Expressions.Error.TypeIsGeneric(type, paramName, index) : System.Linq.Expressions.Error.TypeContainsGenericParameters(type, paramName, index);
			}
			return true;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000267A9 File Offset: 0x000249A9
		public static MethodInfo GetInvokeMethod(this Type delegateType)
		{
			return delegateType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000267B8 File Offset: 0x000249B8
		internal static bool IsUnsigned(this Type type)
		{
			return type.GetNonNullableType().GetTypeCode().IsUnsigned();
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000267CA File Offset: 0x000249CA
		internal static bool IsUnsigned(this TypeCode typeCode)
		{
			switch (typeCode)
			{
			case TypeCode.Char:
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				return true;
			}
			return false;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000267FD File Offset: 0x000249FD
		internal static bool IsFloatingPoint(this Type type)
		{
			return type.GetNonNullableType().GetTypeCode().IsFloatingPoint();
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002680F File Offset: 0x00024A0F
		internal static bool IsFloatingPoint(this TypeCode typeCode)
		{
			return typeCode - TypeCode.Single <= 1;
		}

		// Token: 0x04000308 RID: 776
		private static readonly Type[] s_arrayAssignableInterfaces = (from i in typeof(int[]).GetInterfaces()
		where i.IsGenericType
		select i.GetGenericTypeDefinition()).ToArray<Type>();
	}
}
