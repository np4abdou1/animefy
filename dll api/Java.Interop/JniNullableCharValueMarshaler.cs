using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000055 RID: 85
	internal sealed class JniNullableCharValueMarshaler : JniValueMarshaler<char?>
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		public override char? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new char?(JniCharacter.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(char? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniCharacter.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public override void DestroyGenericArgumentState(char? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000C9 RID: 201
		internal static readonly JniNullableCharValueMarshaler Instance = new JniNullableCharValueMarshaler();
	}
}
