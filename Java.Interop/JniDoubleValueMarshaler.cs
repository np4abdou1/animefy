using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000063 RID: 99
	internal sealed class JniDoubleValueMarshaler : JniValueMarshaler<double>
	{
		// Token: 0x06000368 RID: 872 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000D5EA File Offset: 0x0000B7EA
		public override double CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0.0;
			}
			return JniDouble.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D606 File Offset: 0x0000B806
		public override JniValueMarshalerState CreateGenericArgumentState(double value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000D614 File Offset: 0x0000B814
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(double value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniDouble.CreateLocalRef(value), null);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000D624 File Offset: 0x0000B824
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000D648 File Offset: 0x0000B848
		public override void DestroyGenericArgumentState(double value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000E1 RID: 225
		internal static readonly JniDoubleValueMarshaler Instance = new JniDoubleValueMarshaler();
	}
}
