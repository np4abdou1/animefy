using System;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E7 RID: 999
	internal sealed class SerObjectInfoCache
	{
		// Token: 0x06001E74 RID: 7796 RVA: 0x00080F00 File Offset: 0x0007F100
		internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
		{
			this.fullTypeName = typeName;
			this.assemblyString = assemblyName;
			this.hasTypeForwardedFrom = hasTypeForwardedFrom;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00080F20 File Offset: 0x0007F120
		internal SerObjectInfoCache(Type type)
		{
			TypeInformation typeInformation = BinaryFormatter.GetTypeInformation(type);
			this.fullTypeName = typeInformation.FullTypeName;
			this.assemblyString = typeInformation.AssemblyString;
			this.hasTypeForwardedFrom = typeInformation.HasTypeForwardedFrom;
		}

		// Token: 0x04000DBF RID: 3519
		internal string fullTypeName;

		// Token: 0x04000DC0 RID: 3520
		internal string assemblyString;

		// Token: 0x04000DC1 RID: 3521
		internal bool hasTypeForwardedFrom;

		// Token: 0x04000DC2 RID: 3522
		internal MemberInfo[] memberInfos;

		// Token: 0x04000DC3 RID: 3523
		internal string[] memberNames;

		// Token: 0x04000DC4 RID: 3524
		internal Type[] memberTypes;
	}
}
