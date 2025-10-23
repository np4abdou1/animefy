using System;

namespace Java.Interop
{
	// Token: 0x02000062 RID: 98
	internal static class JniDouble
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000D51E File Offset: 0x0000B71E
		private static JniType TypeRef
		{
			get
			{
				return JniType.GetCachedJniType(ref JniDouble._TypeRef, "java/lang/Double");
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000D530 File Offset: 0x0000B730
		internal unsafe static JniObjectReference CreateLocalRef(double value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			JniDouble.TypeRef.GetCachedConstructor(ref JniDouble.init, "(D)V");
			return JniDouble.TypeRef.NewObject(JniDouble.init, ptr);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000D57C File Offset: 0x0000B77C
		internal static double GetValueFromJni(ref JniObjectReference self, JniObjectReferenceOptions transfer, Type targetType)
		{
			JniDouble.TypeRef.GetCachedInstanceMethod(ref JniDouble.doubleValue, "doubleValue", "()D");
			double result;
			try
			{
				result = JniEnvironment.InstanceMethods.CallDoubleMethod(self, JniDouble.doubleValue);
			}
			finally
			{
				JniObjectReference.Dispose(ref self, transfer);
			}
			return result;
		}

		// Token: 0x040000DE RID: 222
		private static JniType _TypeRef;

		// Token: 0x040000DF RID: 223
		private static JniMethodInfo init;

		// Token: 0x040000E0 RID: 224
		private static JniMethodInfo doubleValue;
	}
}
