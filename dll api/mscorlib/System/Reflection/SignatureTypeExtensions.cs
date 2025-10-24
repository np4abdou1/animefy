using System;

namespace System.Reflection
{
	// Token: 0x020004BE RID: 1214
	internal static class SignatureTypeExtensions
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0008AC68 File Offset: 0x00088E68
		public static bool MatchesParameterTypeExactly(this Type pattern, ParameterInfo parameter)
		{
			SignatureType signatureType = pattern as SignatureType;
			if (signatureType != null)
			{
				return signatureType.MatchesExactly(parameter.ParameterType);
			}
			return pattern == parameter.ParameterType;
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0008AC98 File Offset: 0x00088E98
		internal static bool MatchesExactly(this SignatureType pattern, Type actual)
		{
			if (pattern.IsSZArray)
			{
				return actual.IsSZArray && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsVariableBoundArray)
			{
				return actual.IsVariableBoundArray && pattern.GetArrayRank() == actual.GetArrayRank() && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsByRef)
			{
				return actual.IsByRef && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (pattern.IsPointer)
			{
				return actual.IsPointer && pattern.ElementType.MatchesExactly(actual.GetElementType());
			}
			if (!pattern.IsConstructedGenericType)
			{
				return pattern.IsGenericMethodParameter && actual.IsGenericMethodParameter && pattern.GenericParameterPosition == actual.GenericParameterPosition;
			}
			if (!actual.IsConstructedGenericType)
			{
				return false;
			}
			if (!(pattern.GetGenericTypeDefinition() == actual.GetGenericTypeDefinition()))
			{
				return false;
			}
			Type[] genericTypeArguments = pattern.GenericTypeArguments;
			Type[] genericTypeArguments2 = actual.GenericTypeArguments;
			int num = genericTypeArguments.Length;
			if (num != genericTypeArguments2.Length)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				Type type = genericTypeArguments[i];
				SignatureType signatureType = type as SignatureType;
				if (signatureType != null)
				{
					if (!signatureType.MatchesExactly(genericTypeArguments2[i]))
					{
						return false;
					}
				}
				else if (type != genericTypeArguments2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0008ADE5 File Offset: 0x00088FE5
		internal static Type TryResolveAgainstGenericMethod(this SignatureType signatureType, MethodInfo genericMethod)
		{
			return signatureType.TryResolve(genericMethod.GetGenericArguments());
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0008ADF4 File Offset: 0x00088FF4
		private static Type TryResolve(this SignatureType signatureType, Type[] genericMethodParameters)
		{
			if (signatureType.IsSZArray)
			{
				Type type = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type == null)
				{
					return null;
				}
				return type.TryMakeArrayType();
			}
			else if (signatureType.IsVariableBoundArray)
			{
				Type type2 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type2 == null)
				{
					return null;
				}
				return type2.TryMakeArrayType(signatureType.GetArrayRank());
			}
			else if (signatureType.IsByRef)
			{
				Type type3 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type3 == null)
				{
					return null;
				}
				return type3.TryMakeByRefType();
			}
			else if (signatureType.IsPointer)
			{
				Type type4 = signatureType.ElementType.TryResolve(genericMethodParameters);
				if (type4 == null)
				{
					return null;
				}
				return type4.TryMakePointerType();
			}
			else
			{
				if (signatureType.IsConstructedGenericType)
				{
					Type[] genericTypeArguments = signatureType.GenericTypeArguments;
					int num = genericTypeArguments.Length;
					Type[] array = new Type[num];
					for (int i = 0; i < num; i++)
					{
						Type type5 = genericTypeArguments[i];
						SignatureType signatureType2 = type5 as SignatureType;
						if (signatureType2 != null)
						{
							array[i] = signatureType2.TryResolve(genericMethodParameters);
							if (array[i] == null)
							{
								return null;
							}
						}
						else
						{
							array[i] = type5;
						}
					}
					return signatureType.GetGenericTypeDefinition().TryMakeGenericType(array);
				}
				if (!signatureType.IsGenericMethodParameter)
				{
					return null;
				}
				int genericParameterPosition = signatureType.GenericParameterPosition;
				if (genericParameterPosition >= genericMethodParameters.Length)
				{
					return null;
				}
				return genericMethodParameters[genericParameterPosition];
			}
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0008AF08 File Offset: 0x00089108
		private static Type TryMakeArrayType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakeArrayType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0008AF34 File Offset: 0x00089134
		private static Type TryMakeArrayType(this Type type, int rank)
		{
			Type result;
			try
			{
				result = type.MakeArrayType(rank);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0008AF64 File Offset: 0x00089164
		private static Type TryMakeByRefType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakeByRefType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0008AF90 File Offset: 0x00089190
		private static Type TryMakePointerType(this Type type)
		{
			Type result;
			try
			{
				result = type.MakePointerType();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0008AFBC File Offset: 0x000891BC
		private static Type TryMakeGenericType(this Type type, Type[] instantiation)
		{
			Type result;
			try
			{
				result = type.MakeGenericType(instantiation);
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
