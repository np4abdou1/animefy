using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F4 RID: 244
	[NullableContext(1)]
	[Nullable(0)]
	internal static class TypeExtensions
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00024760 File Offset: 0x00022960
		public static MethodInfo Method(this Delegate d)
		{
			return d.Method;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00024768 File Offset: 0x00022968
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return memberInfo.MemberType;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00024770 File Offset: 0x00022970
		public static bool ContainsGenericParameters(this Type type)
		{
			return type.ContainsGenericParameters;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00024778 File Offset: 0x00022978
		public static bool IsInterface(this Type type)
		{
			return type.IsInterface;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00024780 File Offset: 0x00022980
		public static bool IsGenericType(this Type type)
		{
			return type.IsGenericType;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00024788 File Offset: 0x00022988
		public static bool IsGenericTypeDefinition(this Type type)
		{
			return type.IsGenericTypeDefinition;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00024790 File Offset: 0x00022990
		[return: Nullable(2)]
		public static Type BaseType(this Type type)
		{
			return type.BaseType;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00024798 File Offset: 0x00022998
		public static Assembly Assembly(this Type type)
		{
			return type.Assembly;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000247A0 File Offset: 0x000229A0
		public static bool IsEnum(this Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000247A8 File Offset: 0x000229A8
		public static bool IsClass(this Type type)
		{
			return type.IsClass;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000247B0 File Offset: 0x000229B0
		public static bool IsSealed(this Type type)
		{
			return type.IsSealed;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000247B8 File Offset: 0x000229B8
		public static bool IsAbstract(this Type type)
		{
			return type.IsAbstract;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000247C0 File Offset: 0x000229C0
		public static bool IsVisible(this Type type)
		{
			return type.IsVisible;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000247C8 File Offset: 0x000229C8
		public static bool IsValueType(this Type type)
		{
			return type.IsValueType;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000247D0 File Offset: 0x000229D0
		public static bool IsPrimitive(this Type type)
		{
			return type.IsPrimitive;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000247D8 File Offset: 0x000229D8
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, [Nullable(2)] [NotNullWhen(true)] out Type match)
		{
			Type type2 = type;
			while (type2 != null)
			{
				if (string.Equals(type2.FullName, fullTypeName, StringComparison.Ordinal))
				{
					match = type2;
					return true;
				}
				type2 = type2.BaseType();
			}
			if (searchInterfaces)
			{
				Type[] interfaces = type.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					if (string.Equals(interfaces[i].Name, fullTypeName, StringComparison.Ordinal))
					{
						match = type;
						return true;
					}
				}
			}
			match = null;
			return false;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00024840 File Offset: 0x00022A40
		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			Type type2;
			return type.AssignableToTypeName(fullTypeName, searchInterfaces, out type2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00024858 File Offset: 0x00022A58
		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			Type type2 = type;
			while (type2 != null)
			{
				foreach (Type type3 in ((IEnumerable<Type>)type2.GetInterfaces()))
				{
					if (type3 == interfaceType || (type3 != null && type3.ImplementInterface(interfaceType)))
					{
						return true;
					}
				}
				type2 = type2.BaseType();
			}
			return false;
		}
	}
}
