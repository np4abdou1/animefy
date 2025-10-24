using System;
using System.Reflection;
using System.Security;

namespace System
{
	// Token: 0x02000075 RID: 117
	internal static class SecurityUtils
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x00004D67 File Offset: 0x00002F67
		private static void DemandReflectionAccess(Type type)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00004D67 File Offset: 0x00002F67
		[SecuritySafeCritical]
		private static void DemandGrantSet(Assembly assembly)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000BE58 File Offset: 0x0000A058
		private static bool HasReflectionPermission(Type type)
		{
			try
			{
				SecurityUtils.DemandReflectionAccess(type);
				return true;
			}
			catch (SecurityException)
			{
			}
			return false;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000BE88 File Offset: 0x0000A088
		internal static object SecureCreateInstance(Type type)
		{
			return SecurityUtils.SecureCreateInstance(type, null, false);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000BE94 File Offset: 0x0000A094
		internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance;
			if (!type.IsVisible)
			{
				SecurityUtils.DemandReflectionAccess(type);
			}
			else if (allowNonPublic && !SecurityUtils.HasReflectionPermission(type))
			{
				allowNonPublic = false;
			}
			if (allowNonPublic)
			{
				bindingFlags |= BindingFlags.NonPublic;
			}
			return Activator.CreateInstance(type, bindingFlags, null, args, null);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000BEEB File Offset: 0x0000A0EB
		internal static object SecureCreateInstance(Type type, object[] args)
		{
			return SecurityUtils.SecureCreateInstance(type, args, false);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic)
		{
			return SecurityUtils.SecureConstructorInvoke(type, argTypes, args, allowNonPublic, BindingFlags.Default);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000BF04 File Offset: 0x0000A104
		internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (!type.IsVisible)
			{
				SecurityUtils.DemandReflectionAccess(type);
			}
			else if (allowNonPublic && !SecurityUtils.HasReflectionPermission(type))
			{
				allowNonPublic = false;
			}
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | extraFlags;
			if (!allowNonPublic)
			{
				bindingFlags &= ~BindingFlags.NonPublic;
			}
			ConstructorInfo constructor = type.GetConstructor(bindingFlags, null, argTypes, null);
			if (constructor != null)
			{
				return constructor.Invoke(args);
			}
			return null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000BF70 File Offset: 0x0000A170
		private static bool GenericArgumentsAreVisible(MethodInfo method)
		{
			if (method.IsGenericMethod)
			{
				Type[] genericArguments = method.GetGenericArguments();
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (!genericArguments[i].IsVisible)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args)
		{
			Type declaringType = method.DeclaringType;
			if (declaringType == null)
			{
				if (!method.IsPublic || !SecurityUtils.GenericArgumentsAreVisible(method))
				{
					SecurityUtils.DemandGrantSet(method.Module.Assembly);
				}
			}
			else if (!declaringType.IsVisible || !method.IsPublic || !SecurityUtils.GenericArgumentsAreVisible(method))
			{
				SecurityUtils.DemandReflectionAccess(declaringType);
			}
			return method.Invoke(target, args);
		}
	}
}
