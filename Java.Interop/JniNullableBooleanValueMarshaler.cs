using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200004F RID: 79
	internal sealed class JniNullableBooleanValueMarshaler : JniValueMarshaler<bool?>
	{
		// Token: 0x06000300 RID: 768 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		public override bool? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new bool?(JniBoolean.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000C910 File Offset: 0x0000AB10
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(bool? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniBoolean.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C944 File Offset: 0x0000AB44
		public override void DestroyGenericArgumentState(bool? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000BF RID: 191
		internal static readonly JniNullableBooleanValueMarshaler Instance = new JniNullableBooleanValueMarshaler();
	}
}
