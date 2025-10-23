using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000052 RID: 82
	internal sealed class JniNullableSByteValueMarshaler : JniValueMarshaler<sbyte?>
	{
		// Token: 0x06000310 RID: 784 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		public override sbyte? CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			if (!reference.IsValid)
			{
				return null;
			}
			return new sbyte?(JniByte.GetValueFromJni(ref reference, options, null));
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000CB00 File Offset: 0x0000AD00
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(sbyte? value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(JniByte.CreateLocalRef(value.Value), null);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000CB34 File Offset: 0x0000AD34
		public override void DestroyGenericArgumentState(sbyte? value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x040000C4 RID: 196
		internal static readonly JniNullableSByteValueMarshaler Instance = new JniNullableSByteValueMarshaler();
	}
}
