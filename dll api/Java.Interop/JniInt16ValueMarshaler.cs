using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000057 RID: 87
	internal sealed class JniInt16ValueMarshaler : JniValueMarshaler<short>
	{
		// Token: 0x06000328 RID: 808 RVA: 0x0000CE0C File Offset: 0x0000B00C
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000CE26 File Offset: 0x0000B026
		public override short CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return 0;
			}
			return JniShort.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000CE3A File Offset: 0x0000B03A
		public override JniValueMarshalerState CreateGenericArgumentState(short value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000CE48 File Offset: 0x0000B048
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(short value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniShort.CreateLocalRef(value), null);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000CE58 File Offset: 0x0000B058
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public override void DestroyGenericArgumentState(short value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000CD RID: 205
		internal static readonly JniInt16ValueMarshaler Instance = new JniInt16ValueMarshaler();
	}
}
