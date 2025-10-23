using System;

namespace Java.Interop
{
	// Token: 0x0200005F RID: 95
	internal static class JniFloat
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000D32A File Offset: 0x0000B52A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniFloat._TypeRef, "java/lang/Float");
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000D33C File Offset: 0x0000B53C
		internal unsafe static JniObjectReference CreateLocalRef(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniFloat.TypeRef.GetCachedConstructor(ref JniFloat.init, "(F)V");
			return JniFloat.TypeRef.NewObject(JniFloat.init, ptr);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000D388 File Offset: 0x0000B588
		internal static float GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniFloat.TypeRef.GetCachedInstanceMethod(ref JniFloat.floatValue, "floatValue", "()F");
			float result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallFloatMethod(self, JniFloat.floatValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000D9 RID: 217
		private static JniType _TypeRef;

		// Token: 0x040000DA RID: 218
		private static JniMethodInfo init;

		// Token: 0x040000DB RID: 219
		private static JniMethodInfo floatValue;
	}
}
