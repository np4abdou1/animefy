using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000051 RID: 81
	internal sealed class JniSByteValueMarshaler : JniValueMarshaler<sbyte>
	{
		// Token: 0x06000308 RID: 776 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000CA46 File Offset: 0x0000AC46
		public override sbyte CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0;
			}
			return JniByte.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000CA5A File Offset: 0x0000AC5A
		public override JniValueMarshalerState CreateGenericArgumentState(sbyte value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000CA68 File Offset: 0x0000AC68
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(sbyte value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniByte.CreateLocalRef(value), null);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000CA78 File Offset: 0x0000AC78
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		public override void DestroyGenericArgumentState(sbyte value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000C3 RID: 195
		internal static readonly JniSByteValueMarshaler Instance = new JniSByteValueMarshaler();
	}
}
