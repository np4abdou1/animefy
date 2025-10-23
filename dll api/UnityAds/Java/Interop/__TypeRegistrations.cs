using System;

namespace Java.Interop
{
	// Token: 0x02000031 RID: 49
	internal class __TypeRegistrations
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00002090 File Offset: 0x00000290
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/unity3d/services/core/di",
				"com/unity3d/services/core/domain/task"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_unity3d_services_core_di_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_unity3d_services_core_domain_task_package)
			});
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000020DC File Offset: 0x000002DC
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000020FC File Offset: 0x000002FC
		private static Type lookup_com_unity3d_services_core_di_package(string klass)
		{
			if (__TypeRegistrations.package_com_unity3d_services_core_di_mappings == null)
			{
				__TypeRegistrations.package_com_unity3d_services_core_di_mappings = new string[]
				{
					"com/unity3d/services/core/di/IServiceComponent$DefaultImpls:Com.Unity3d.Services.Core.DI.ServiceComponentDefaultImpls",
					"com/unity3d/services/core/di/IServicesRegistry$DefaultImpls:Com.Unity3d.Services.Core.DI.ServicesRegistryDefaultImpls"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_unity3d_services_core_di_mappings, klass);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000212B File Offset: 0x0000032B
		private static Type lookup_com_unity3d_services_core_domain_task_package(string klass)
		{
			if (__TypeRegistrations.package_com_unity3d_services_core_domain_task_mappings == null)
			{
				__TypeRegistrations.package_com_unity3d_services_core_domain_task_mappings = new string[]
				{
					"com/unity3d/services/core/domain/task/BaseTask$DefaultImpls:Com.Unity3d.Services.Core.Domain.Task.BaseTaskDefaultImpls"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_unity3d_services_core_domain_task_mappings, klass);
		}

		// Token: 0x04000003 RID: 3
		private static string[] package_com_unity3d_services_core_di_mappings;

		// Token: 0x04000004 RID: 4
		private static string[] package_com_unity3d_services_core_domain_task_mappings;
	}
}
