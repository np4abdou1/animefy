using System;

namespace Java.Interop
{
	// Token: 0x0200004D RID: 77
	internal static class JniBoolean
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000C789 File Offset: 0x0000A989
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniBoolean._TypeRef, "java/lang/Boolean");
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000C79C File Offset: 0x0000A99C
		internal unsafe static JniObjectReference CreateLocalRef(bool value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniBoolean.TypeRef.GetCachedConstructor(ref JniBoolean.init, "(Z)V");
			return JniBoolean.TypeRef.NewObject(JniBoolean.init, ptr);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		internal static bool GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniBoolean.TypeRef.GetCachedInstanceMethod(ref JniBoolean.booleanValue, "booleanValue", "()Z");
			bool result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallBooleanMethod(self, JniBoolean.booleanValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000BB RID: 187
		private static JniType _TypeRef;

		// Token: 0x040000BC RID: 188
		private static JniMethodInfo init;

		// Token: 0x040000BD RID: 189
		private static JniMethodInfo booleanValue;
	}
}
