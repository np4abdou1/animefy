using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000060 RID: 96
	internal sealed class JniSingleValueMarshaler : JniValueMarshaler<float>
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D3F6 File Offset: 0x0000B5F6
		public override float CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0f;
			}
			return JniFloat.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000D40E File Offset: 0x0000B60E
		public override JniValueMarshalerState CreateGenericArgumentState(float value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D41C File Offset: 0x0000B61C
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(float value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniFloat.CreateLocalRef(value), null);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D42C File Offset: 0x0000B62C
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D450 File Offset: 0x0000B650
		public override void DestroyGenericArgumentState(float value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000DC RID: 220
		internal static readonly JniSingleValueMarshaler Instance = new JniSingleValueMarshaler();
	}
}
