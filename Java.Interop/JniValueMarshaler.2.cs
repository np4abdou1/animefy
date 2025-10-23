using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x0200008B RID: 139
	public abstract class JniValueMarshaler<T> : JniValueMarshaler
	{
		// Token: 0x0600048C RID: 1164
		public abstract T CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType = null);

		// Token: 0x0600048D RID: 1165 RVA: 0x00010A79 File Offset: 0x0000EC79
		public virtual JniValueMarshalerState CreateGenericArgumentState(T value, ParameterAttributes synchronize = ParameterAttributes.None)
		{
			return this.CreateGenericObjectReferenceArgumentState(value, synchronize);
		}

		// Token: 0x0600048E RID: 1166
		public abstract JniValueMarshalerState CreateGenericObjectReferenceArgumentState(T value, ParameterAttributes synchronize = ParameterAttributes.None);

		// Token: 0x0600048F RID: 1167
		public abstract void DestroyGenericArgumentState(T value, ref JniValueMarshalerState state, ParameterAttributes synchronize = ParameterAttributes.None);

		// Token: 0x06000490 RID: 1168 RVA: 0x00010A83 File Offset: 0x0000EC83
		public override object CreateValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType = null)
		{
			return this.CreateGenericValue(ref reference, options, targetType ?? typeof(T));
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00010AA1 File Offset: 0x0000ECA1
		public override JniValueMarshalerState CreateArgumentState(object value, ParameterAttributes synchronize = ParameterAttributes.None)
		{
			return this.CreateGenericArgumentState((T)((object)value), synchronize);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		public override JniValueMarshalerState CreateObjectReferenceArgumentState(object value, ParameterAttributes synchronize = ParameterAttributes.None)
		{
			return this.CreateGenericObjectReferenceArgumentState((T)((object)value), synchronize);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00010ABF File Offset: 0x0000ECBF
		public override void DestroyArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize = ParameterAttributes.None)
		{
			this.DestroyGenericArgumentState((T)((object)value), ref state, synchronize);
		}
	}
}
