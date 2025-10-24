using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200004E RID: 78
	internal sealed class JniBooleanValueMarshaler : JniValueMarshaler<bool>
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000C83C File Offset: 0x0000AA3C
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000C856 File Offset: 0x0000AA56
		public override bool CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			return reference.IsValid && JniBoolean.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000C86A File Offset: 0x0000AA6A
		public override JniValueMarshalerState CreateGenericArgumentState(bool value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000C878 File Offset: 0x0000AA78
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(bool value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniBoolean.CreateLocalRef(value), null);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000C888 File Offset: 0x0000AA88
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		public override void DestroyGenericArgumentState(bool value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000BE RID: 190
		internal static readonly JniBooleanValueMarshaler Instance = new JniBooleanValueMarshaler();
	}
}
