using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000080 RID: 128
	internal sealed class JavaPeerableValueMarshaler : JniValueMarshaler<IJavaPeerable>
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		public override IJavaPeerable CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			JniRuntime runtime = JniEnvironment.Runtime;
			JniValueMarshaler valueMarshaler = runtime.ValueManager.GetValueMarshaler(targetType ?? typeof(IJavaPeerable));
			if (valueMarshaler != JavaPeerableValueMarshaler.Instance)
			{
				return (IJavaPeerable)valueMarshaler.CreateValue(ref reference, options, targetType);
			}
			return runtime.ValueManager.CreatePeer(ref reference, options, targetType);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000FB28 File Offset: 0x0000DD28
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IJavaPeerable value, ParameterAttributes synchronize)
		{
			if (value == null || !value.PeerReference.IsValid)
			{
				return default(JniValueMarshalerState);
			}
			return new JniValueMarshalerState(value.PeerReference.NewLocalRef(), null);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000FB68 File Offset: 0x0000DD68
		public override void DestroyGenericArgumentState(IJavaPeerable value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x0400012E RID: 302
		internal static JavaPeerableValueMarshaler Instance = new JavaPeerableValueMarshaler();
	}
}
