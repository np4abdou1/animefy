using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200005A RID: 90
	internal sealed class JniInt32ValueMarshaler : JniValueMarshaler<int>
	{
		// Token: 0x06000338 RID: 824 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000D016 File Offset: 0x0000B216
		public override int CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0;
			}
			return JniInteger.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000D02A File Offset: 0x0000B22A
		public override JniValueMarshalerState CreateGenericArgumentState(int value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000D038 File Offset: 0x0000B238
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(int value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniInteger.CreateLocalRef(value), null);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000D048 File Offset: 0x0000B248
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000D06C File Offset: 0x0000B26C
		public override void DestroyGenericArgumentState(int value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000D2 RID: 210
		internal static readonly JniInt32ValueMarshaler Instance = new JniInt32ValueMarshaler();
	}
}
