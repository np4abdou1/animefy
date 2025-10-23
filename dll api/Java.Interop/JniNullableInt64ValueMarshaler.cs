using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200005E RID: 94
	internal sealed class JniNullableInt64ValueMarshaler : JniValueMarshaler<long?>
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0000D294 File Offset: 0x0000B494
		public override long? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new long?(JniLong.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(long? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniLong.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		public override void DestroyGenericArgumentState(long? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000D8 RID: 216
		internal static readonly JniNullableInt64ValueMarshaler Instance = new JniNullableInt64ValueMarshaler();
	}
}
