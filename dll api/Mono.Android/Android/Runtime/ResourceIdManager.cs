using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Android.Runtime
{
	// Token: 0x020002F4 RID: 756
	public static class ResourceIdManager
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x00051E38 File Offset: 0x00050038
		public static void UpdateIdValues()
		{
			if (ResourceIdManager.id_initialized)
			{
				return;
			}
			ResourceIdManager.id_initialized = true;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Type type = (executingAssembly != null) ? ResourceIdManager.GetResourceTypeFromAssembly(executingAssembly) : null;
			if (type == null)
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				for (int i = 0; i < assemblies.Length; i++)
				{
					type = ResourceIdManager.GetResourceTypeFromAssembly(assemblies[i]);
					if (type != null)
					{
						break;
					}
				}
			}
			if (type != null)
			{
				MethodInfo method = type.GetMethod("UpdateIdValues");
				if (method != null)
				{
					((Action)method.CreateDelegate(typeof(Action)))();
				}
			}
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00051EDC File Offset: 0x000500DC
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Types in Resource.designer.cs are preserved, because it is the root assembly passed to the linker.")]
		private static Type GetResourceTypeFromAssembly(Assembly assembly)
		{
			object[] customAttributes = assembly.GetCustomAttributes(typeof(ResourceDesignerAttribute), true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				ResourceDesignerAttribute resourceDesignerAttribute = customAttributes[i] as ResourceDesignerAttribute;
				if (resourceDesignerAttribute != null && resourceDesignerAttribute.IsApplication)
				{
					Type type = assembly.GetType(resourceDesignerAttribute.FullName);
					if (type != null)
					{
						return type;
					}
				}
			}
			return null;
		}

		// Token: 0x04000C69 RID: 3177
		private static bool id_initialized;
	}
}
