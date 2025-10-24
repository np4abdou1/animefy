using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000054 RID: 84
	internal sealed class JniCharValueMarshaler : JniValueMarshaler<char>
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return this.CreateGenericValue(ref reference, options, targetType);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000CC36 File Offset: 0x0000AE36
		public override char CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return '\0';
			}
			return JniCharacter.GetValueFromJni(ref reference, options, targetType);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000CC4A File Offset: 0x0000AE4A
		public override JniValueMarshalerState CreateGenericArgumentState(char value, ParameterAttributes synchronize = ParameterAttributes.In)
		{
			return new JniValueMarshalerState(new JniArgumentValue(value), null);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000CC58 File Offset: 0x0000AE58
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(char value, ParameterAttributes synchronize)
		{
			return new JniValueMarshalerState(JniCharacter.CreateLocalRef(value), null);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		public override void DestroyGenericArgumentState(char value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000C8 RID: 200
		internal static readonly JniCharValueMarshaler Instance = new JniCharValueMarshaler();
	}
}
