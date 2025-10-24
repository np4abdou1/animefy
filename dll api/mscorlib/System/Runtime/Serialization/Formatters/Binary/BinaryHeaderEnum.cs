using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003BC RID: 956
	internal enum BinaryHeaderEnum
	{
		// Token: 0x04000C66 RID: 3174
		SerializedStreamHeader,
		// Token: 0x04000C67 RID: 3175
		Object,
		// Token: 0x04000C68 RID: 3176
		ObjectWithMap,
		// Token: 0x04000C69 RID: 3177
		ObjectWithMapAssemId,
		// Token: 0x04000C6A RID: 3178
		ObjectWithMapTyped,
		// Token: 0x04000C6B RID: 3179
		ObjectWithMapTypedAssemId,
		// Token: 0x04000C6C RID: 3180
		ObjectString,
		// Token: 0x04000C6D RID: 3181
		Array,
		// Token: 0x04000C6E RID: 3182
		MemberPrimitiveTyped,
		// Token: 0x04000C6F RID: 3183
		MemberReference,
		// Token: 0x04000C70 RID: 3184
		ObjectNull,
		// Token: 0x04000C71 RID: 3185
		MessageEnd,
		// Token: 0x04000C72 RID: 3186
		Assembly,
		// Token: 0x04000C73 RID: 3187
		ObjectNullMultiple256,
		// Token: 0x04000C74 RID: 3188
		ObjectNullMultiple,
		// Token: 0x04000C75 RID: 3189
		ArraySinglePrimitive,
		// Token: 0x04000C76 RID: 3190
		ArraySingleObject,
		// Token: 0x04000C77 RID: 3191
		ArraySingleString,
		// Token: 0x04000C78 RID: 3192
		CrossAppDomainMap,
		// Token: 0x04000C79 RID: 3193
		CrossAppDomainString,
		// Token: 0x04000C7A RID: 3194
		CrossAppDomainAssembly,
		// Token: 0x04000C7B RID: 3195
		MethodCall,
		// Token: 0x04000C7C RID: 3196
		MethodReturn
	}
}
