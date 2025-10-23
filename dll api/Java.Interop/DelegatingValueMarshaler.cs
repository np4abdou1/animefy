using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000081 RID: 129
	internal sealed class DelegatingValueMarshaler<T> : JniValueMarshaler<T>
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		public DelegatingValueMarshaler(JniValueMarshaler valueMarshaler)
		{
			this.ValueMarshaler = valueMarshaler;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000FBAD File Offset: 0x0000DDAD
		public override T CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			return (T)((object)this.ValueMarshaler.CreateValue(ref reference, options, targetType ?? typeof(T)));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(T value, ParameterAttributes synchronize)
		{
			return this.ValueMarshaler.CreateObjectReferenceArgumentState(value, synchronize);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
		public override void DestroyGenericArgumentState(T value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			this.ValueMarshaler.DestroyArgumentState(value, ref state, synchronize);
		}

		// Token: 0x0400012F RID: 303
		private JniValueMarshaler ValueMarshaler;
	}
}
