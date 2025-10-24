using System;

namespace Java.Interop
{
	// Token: 0x02000053 RID: 83
	internal static class JniCharacter
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000CB6A File Offset: 0x0000AD6A
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniCharacter._TypeRef, "java/lang/Character");
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		internal unsafe static JniObjectReference CreateLocalRef(char value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniCharacter.TypeRef.GetCachedConstructor(ref JniCharacter.init, "(C)V");
			return JniCharacter.TypeRef.NewObject(JniCharacter.init, ptr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		internal static char GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniCharacter.TypeRef.GetCachedInstanceMethod(ref JniCharacter.charValue, "charValue", "()C");
			char result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallCharMethod(self, JniCharacter.charValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000C5 RID: 197
		private static JniType _TypeRef;

		// Token: 0x040000C6 RID: 198
		private static JniMethodInfo init;

		// Token: 0x040000C7 RID: 199
		private static JniMethodInfo charValue;
	}
}
