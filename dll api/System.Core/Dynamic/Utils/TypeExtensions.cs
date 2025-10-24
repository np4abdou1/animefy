﻿using System;
using System.Reflection;

namespace System.Dynamic.Utils
{
	// Token: 0x02000141 RID: 321
	internal static class TypeExtensions
	{
		// Token: 0x06000A17 RID: 2583 RVA: 0x00025AB0 File Offset: 0x00023CB0
		public static MethodInfo GetAnyStaticMethodValidated(this Type type, string name, Type[] types)
		{
			MethodInfo method = type.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, types, null);
			if (!method.MatchesArgumentTypes(types))
			{
				return null;
			}
			return method;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00025AD8 File Offset: 0x00023CD8
		private static bool MatchesArgumentTypes(this MethodInfo mi, Type[] argTypes)
		{
			if (mi == null)
			{
				return false;
			}
			ParameterInfo[] parametersCached = mi.GetParametersCached();
			if (parametersCached.Length != argTypes.Length)
			{
				return false;
			}
			for (int i = 0; i < parametersCached.Length; i++)
			{
				if (!TypeUtils.AreReferenceAssignable(parametersCached[i].ParameterType, argTypes[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00025B24 File Offset: 0x00023D24
		public static Type GetReturnType(this MethodBase mi)
		{
			if (!mi.IsConstructor)
			{
				return ((MethodInfo)mi).ReturnType;
			}
			return mi.DeclaringType;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00025B40 File Offset: 0x00023D40
		public static TypeCode GetTypeCode(this Type type)
		{
			return Type.GetTypeCode(type);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00025B48 File Offset: 0x00023D48
		internal static ParameterInfo[] GetParametersCached(this MethodBase method)
		{
			CacheDict<MethodBase, ParameterInfo[]> cacheDict = TypeExtensions.s_paramInfoCache;
			ParameterInfo[] parameters;
			if (!cacheDict.TryGetValue(method, out parameters))
			{
				parameters = method.GetParameters();
				Type declaringType = method.DeclaringType;
				if (declaringType != null && !declaringType.IsCollectible)
				{
					cacheDict[method] = parameters;
				}
			}
			return parameters;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00025B8D File Offset: 0x00023D8D
		internal static bool IsByRefParameter(this ParameterInfo pi)
		{
			return pi.ParameterType.IsByRef || (pi.Attributes & ParameterAttributes.Out) == ParameterAttributes.Out;
		}

		// Token: 0x04000307 RID: 775
		private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache = new CacheDict<MethodBase, ParameterInfo[]>(75);
	}
}
