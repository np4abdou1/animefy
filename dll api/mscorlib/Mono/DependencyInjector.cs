using System;
using System.Reflection;

namespace Mono
{
	// Token: 0x0200000F RID: 15
	internal static class DependencyInjector
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000024AC File Offset: 0x000006AC
		internal static ISystemDependencyProvider SystemProvider
		{
			get
			{
				if (DependencyInjector.systemDependency != null)
				{
					return DependencyInjector.systemDependency;
				}
				object obj = DependencyInjector.locker;
				ISystemDependencyProvider result;
				lock (obj)
				{
					if (DependencyInjector.systemDependency != null)
					{
						result = DependencyInjector.systemDependency;
					}
					else
					{
						DependencyInjector.systemDependency = DependencyInjector.ReflectionLoad();
						if (DependencyInjector.systemDependency == null)
						{
							throw new PlatformNotSupportedException("Cannot find 'Mono.SystemDependencyProvider, System' dependency");
						}
						result = DependencyInjector.systemDependency;
					}
				}
				return result;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002524 File Offset: 0x00000724
		internal static void Register(ISystemDependencyProvider provider)
		{
			object obj = DependencyInjector.locker;
			lock (obj)
			{
				if (DependencyInjector.systemDependency != null && DependencyInjector.systemDependency != provider)
				{
					throw new InvalidOperationException();
				}
				DependencyInjector.systemDependency = provider;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002578 File Offset: 0x00000778
		private static ISystemDependencyProvider ReflectionLoad()
		{
			Type type = Type.GetType("Mono.SystemDependencyProvider, System");
			if (type == null)
			{
				return null;
			}
			PropertyInfo property = type.GetProperty("Instance", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);
			if (property == null)
			{
				return null;
			}
			return (ISystemDependencyProvider)property.GetValue(null);
		}

		// Token: 0x04000087 RID: 135
		private static object locker = new object();

		// Token: 0x04000088 RID: 136
		private static ISystemDependencyProvider systemDependency;
	}
}
