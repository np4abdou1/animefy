using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200005B RID: 91
	internal sealed class JniNullableInt32ValueMarshaler : JniValueMarshaler<int?>
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		public override int? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new int?(JniInteger.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(int? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniInteger.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000D104 File Offset: 0x0000B304
		public override void DestroyGenericArgumentState(int? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000D3 RID: 211
		internal static readonly JniNullableInt32ValueMarshaler Instance = new JniNullableInt32ValueMarshaler();
	}
}
