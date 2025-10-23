using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000064 RID: 100
	internal sealed class JniNullableDoubleValueMarshaler : JniValueMarshaler<double?>
	{
		// Token: 0x06000370 RID: 880 RVA: 0x0000D680 File Offset: 0x0000B880
		public override double? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new double?(JniDouble.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(double? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniDouble.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		public override void DestroyGenericArgumentState(double? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000E2 RID: 226
		internal static readonly JniNullableDoubleValueMarshaler Instance = new JniNullableDoubleValueMarshaler();
	}
}
