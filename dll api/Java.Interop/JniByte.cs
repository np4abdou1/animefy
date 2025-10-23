using System;

namespace Java.Interop
{
	// Token: 0x02000050 RID: 80
	internal static class JniByte
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000C97A File Offset: 0x0000AB7A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniByte._TypeRef, "java/lang/Byte");
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000C98C File Offset: 0x0000AB8C
		internal unsafe static JniObjectReference CreateLocalRef(sbyte value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniByte.TypeRef.GetCachedConstructor(ref JniByte.init, "(B)V");
			return JniByte.TypeRef.NewObject(JniByte.init, ptr);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		internal static sbyte GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniByte.TypeRef.GetCachedInstanceMethod(ref JniByte.byteValue, "byteValue", "()B");
			sbyte result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallByteMethod(self, JniByte.byteValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000C0 RID: 192
		private static JniType _TypeRef;

		// Token: 0x040000C1 RID: 193
		private static JniMethodInfo init;

		// Token: 0x040000C2 RID: 194
		private static JniMethodInfo byteValue;
	}
}
