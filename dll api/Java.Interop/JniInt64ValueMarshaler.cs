using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200005D RID: 93
	internal sealed class JniInt64ValueMarshaler : JniValueMarshaler<long>
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D206 File Offset: 0x0000B406
		public override long CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0L;
			}
			return JniLong.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D21B File Offset: 0x0000B41B
		public override JniValueMarshalerState CreateGenericArgumentState(long value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000D229 File Offset: 0x0000B429
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(long value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniLong.CreateLocalRef(value), null);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D238 File Offset: 0x0000B438
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D25C File Offset: 0x0000B45C
		public override void DestroyGenericArgumentState(long value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000D7 RID: 215
		internal static readonly JniInt64ValueMarshaler Instance = new JniInt64ValueMarshaler();
	}
}
