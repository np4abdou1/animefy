using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000061 RID: 97
	internal sealed class JniNullableSingleValueMarshaler : JniValueMarshaler<float?>
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0000D488 File Offset: 0x0000B688
		public override float? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new float?(JniFloat.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(float? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniFloat.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		public override void DestroyGenericArgumentState(float? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000DD RID: 221
		internal static readonly JniNullableSingleValueMarshaler Instance = new JniNullableSingleValueMarshaler();
	}
}
