using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SQLite
{
	// Token: 0x02000028 RID: 40
	internal class EnumCacheInfo
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00004E48 File Offset: 0x00003048
		public EnumCacheInfo(Type type)
		{
			TypeInfo typeInfo = type.GetTypeInfo();
			this.IsEnum = typeInfo.IsEnum;
			if (this.IsEnum)
			{
				this.StoreAsText = typeInfo.CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(StoreAsTextAttribute));
				if (this.StoreAsText)
				{
					this.EnumValues = new Dictionary<int, string>();
					foreach (object obj in Enum.GetValues(type))
					{
						this.EnumValues[Convert.ToInt32(obj)] = obj.ToString();
					}
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004F14 File Offset: 0x00003114
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00004F1C File Offset: 0x0000311C
		public bool IsEnum { get; private set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004F25 File Offset: 0x00003125
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00004F2D File Offset: 0x0000312D
		public bool StoreAsText { get; private set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004F36 File Offset: 0x00003136
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00004F3E File Offset: 0x0000313E
		public Dictionary<int, string> EnumValues { get; private set; }
	}
}
