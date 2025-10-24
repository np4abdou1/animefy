using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200008A RID: 138
	public abstract class JniValueMarshaler
	{
		// Token: 0x06000487 RID: 1159
		public abstract object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType = null);

		// Token: 0x06000488 RID: 1160 RVA: 0x00010A6F File Offset: 0x0000EC6F
		public virtual JniValueMarshalerState CreateArgumentState(object value, ParameterAttributes synchronize = ParameterAttributes.None)
		{
			return this.CreateObjectReferenceArgumentState(value, synchronize);
		}

		// Token: 0x06000489 RID: 1161
		public abstract JniValueMarshalerState CreateObjectReferenceArgumentState(object value, ParameterAttributes synchronize = ParameterAttributes.None);

		// Token: 0x0600048A RID: 1162
		public abstract void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize = ParameterAttributes.None);
	}
}
