using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200009B RID: 155
	[NullableContext(1)]
	[Nullable(0)]
	internal class TypeInformation
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0001B92F File Offset: 0x00019B2F
		public Type Type { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001B937 File Offset: 0x00019B37
		public PrimitiveTypeCode TypeCode { get; }

		// Token: 0x06000526 RID: 1318 RVA: 0x0001B93F File Offset: 0x00019B3F
		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
			this.Type = type;
			this.TypeCode = typeCode;
		}
	}
}
