using System;

namespace Java.Interop
{
	// Token: 0x02000056 RID: 86
	internal static class JniShort
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000CD5A File Offset: 0x0000AF5A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniShort._TypeRef, "java/lang/Short");
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000CD6C File Offset: 0x0000AF6C
		internal unsafe static JniObjectReference CreateLocalRef(short value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniShort.TypeRef.GetCachedConstructor(ref JniShort.init, "(S)V");
			return JniShort.TypeRef.NewObject(JniShort.init, ptr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		internal static short GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniShort.TypeRef.GetCachedInstanceMethod(ref JniShort.shortValue, "shortValue", "()S");
			short result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallShortMethod(self, JniShort.shortValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000CA RID: 202
		private static JniType _TypeRef;

		// Token: 0x040000CB RID: 203
		private static JniMethodInfo init;

		// Token: 0x040000CC RID: 204
		private static JniMethodInfo shortValue;
	}
}
