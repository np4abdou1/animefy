using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E8 RID: 1000
	internal sealed class TypeInformation
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00080F5E File Offset: 0x0007F15E
		internal string FullTypeName
		{
			get
			{
				return this.fullTypeName;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00080F66 File Offset: 0x0007F166
		internal string AssemblyString
		{
			get
			{
				return this.assemblyString;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00080F6E File Offset: 0x0007F16E
		internal bool HasTypeForwardedFrom
		{
			get
			{
				return this.hasTypeForwardedFrom;
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00080F76 File Offset: 0x0007F176
		internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
		{
			this.fullTypeName = fullTypeName;
			this.assemblyString = assemblyString;
			this.hasTypeForwardedFrom = hasTypeForwardedFrom;
		}

		// Token: 0x04000DC5 RID: 3525
		private string fullTypeName;

		// Token: 0x04000DC6 RID: 3526
		private string assemblyString;

		// Token: 0x04000DC7 RID: 3527
		private bool hasTypeForwardedFrom;
	}
}
