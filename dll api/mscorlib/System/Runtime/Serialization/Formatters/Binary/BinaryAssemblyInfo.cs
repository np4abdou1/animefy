using System;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003CA RID: 970
	internal sealed class BinaryAssemblyInfo
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x0007CB8D File Offset: 0x0007AD8D
		internal BinaryAssemblyInfo(string assemblyString)
		{
			this.assemblyString = assemblyString;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0007CB9C File Offset: 0x0007AD9C
		internal BinaryAssemblyInfo(string assemblyString, Assembly assembly)
		{
			this.assemblyString = assemblyString;
			this.assembly = assembly;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		internal Assembly GetAssembly()
		{
			if (this.assembly == null)
			{
				this.assembly = FormatterServices.LoadAssemblyFromStringNoThrow(this.assemblyString);
				if (this.assembly == null)
				{
					throw new SerializationException(Environment.GetResourceString("Unable to find assembly '{0}'.", new object[]
					{
						this.assemblyString
					}));
				}
			}
			return this.assembly;
		}

		// Token: 0x04000CD1 RID: 3281
		internal string assemblyString;

		// Token: 0x04000CD2 RID: 3282
		private Assembly assembly;
	}
}
