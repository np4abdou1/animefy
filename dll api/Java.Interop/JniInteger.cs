using System;

namespace Java.Interop
{
	// Token: 0x02000059 RID: 89
	internal static class JniInteger
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000CF4A File Offset: 0x0000B14A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniInteger._TypeRef, "java/lang/Integer");
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000CF5C File Offset: 0x0000B15C
		internal unsafe static JniObjectReference CreateLocalRef(int value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniInteger.TypeRef.GetCachedConstructor(ref JniInteger.init, "(I)V");
			return JniInteger.TypeRef.NewObject(JniInteger.init, ptr);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		internal static int GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniInteger.TypeRef.GetCachedInstanceMethod(ref JniInteger.intValue, "intValue", "()I");
			int result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallIntMethod(self, JniInteger.intValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000CF RID: 207
		private static JniType _TypeRef;

		// Token: 0x040000D0 RID: 208
		private static JniMethodInfo init;

		// Token: 0x040000D1 RID: 209
		private static JniMethodInfo intValue;
	}
}
