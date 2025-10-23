using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000058 RID: 88
	internal sealed class JniNullableInt16ValueMarshaler : JniValueMarshaler<short?>
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		public override short? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new short?(JniShort.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(short? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniShort.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000CF14 File Offset: 0x0000B114
		public override void DestroyGenericArgumentState(short? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000CE RID: 206
		internal static readonly JniNullableInt16ValueMarshaler Instance = new JniNullableInt16ValueMarshaler();
	}
}
