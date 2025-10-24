using System;

namespace Java.Interop
{
	// Token: 0x02000084 RID: 132
	internal static class JniSystem
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000FDA2 File Offset: 0x0000DFA2
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniSystem._typeRef, "java/lang/System");
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		internal unsafe static int IdentityHashCode(JniObjectReference value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniSystem.TypeRef.GetCachedStaticMethod(ref JniSystem._identityHashCode, "identityHashCode", "(Ljava/lang/Object;)I");
			return JniEnvironment.StaticMethods.CallStaticIntMethod(JniSystem.TypeRef.PeerReference, JniSystem._identityHashCode, ptr);
		}

		// Token: 0x04000132 RID: 306
		private static JniType _typeRef;

		// Token: 0x04000133 RID: 307
		private static JniMethodInfo _identityHashCode;
	}
}
