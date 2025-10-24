using System;

namespace Java.Interop
{
	// Token: 0x0200005C RID: 92
	internal static class JniLong
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000D13A File Offset: 0x0000B33A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniLong._TypeRef, "java/lang/Long");
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000D14C File Offset: 0x0000B34C
		internal unsafe static JniObjectReference CreateLocalRef(long value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniLong.TypeRef.GetCachedConstructor(ref JniLong.init, "(J)V");
			return JniLong.TypeRef.NewObject(JniLong.init, ptr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000D198 File Offset: 0x0000B398
		internal static long GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniLong.TypeRef.GetCachedInstanceMethod(ref JniLong.longValue, "longValue", "()J");
			long result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallLongMethod(self, JniLong.longValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000D4 RID: 212
		private static JniType _TypeRef;

		// Token: 0x040000D5 RID: 213
		private static JniMethodInfo init;

		// Token: 0x040000D6 RID: 214
		private static JniMethodInfo longValue;
	}
}
