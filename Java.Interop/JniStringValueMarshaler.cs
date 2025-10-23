using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000083 RID: 131
	internal sealed class JniStringValueMarshaler : JniValueMarshaler<string>
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x0000FD43 File Offset: 0x0000DF43
		public override string CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			return JniEnvironment.Strings.ToString(ref reference, options, targetType ?? typeof(string));
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000FD5B File Offset: 0x0000DF5B
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(string value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniEnvironment.Strings.NewString(value), null);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public override void DestroyGenericArgumentState(string value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x04000131 RID: 305
		internal static readonly JniStringValueMarshaler Instance = new JniStringValueMarshaler();
	}
}
