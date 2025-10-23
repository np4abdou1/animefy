using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200007F RID: 127
	internal sealed class VoidValueMarshaler : JniValueMarshaler
	{
		// Token: 0x0600042B RID: 1067 RVA: 0x0000256C File Offset: 0x0000076C
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000256C File Offset: 0x0000076C
		public override JniValueMarshalerState CreateObjectReferenceArgumentState(object value, ParameterAttributes synchronize)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000256C File Offset: 0x0000076C
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400012D RID: 301
		internal static VoidValueMarshaler Instance = new VoidValueMarshaler();
	}
}
