using System;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000082 RID: 130
	internal sealed class ProxyValueMarshaler : JniValueMarshaler<object>
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x0000FBFC File Offset: 0x0000DDFC
		public override object CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			JniRuntime runtime = JniEnvironment.Runtime;
			if (targetType == null || targetType == typeof(object))
			{
				targetType = runtime.ValueManager.GetRuntimeType(reference);
			}
			if (targetType != null)
			{
				JniValueMarshaler valueMarshaler = runtime.ValueManager.GetValueMarshaler(targetType);
				if (valueMarshaler != ProxyValueMarshaler.Instance)
				{
					return valueMarshaler.CreateValue(ref reference, options, targetType);
				}
			}
			object obj = runtime.ValueManager.PeekValue(reference);
			if (obj != null)
			{
				JniObjectReference.Dispose(ref reference, options);
				return obj;
			}
			return runtime.ValueManager.CreatePeer(ref reference, options, targetType);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(object value, ParameterAttributes synchronize)
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			JniValueMarshaler valueMarshaler = JniEnvironment.Runtime.ValueManager.GetValueMarshaler(value.GetType());
			if (valueMarshaler != ProxyValueMarshaler.Instance)
			{
				return new JniValueMarshalerState(valueMarshaler.CreateObjectReferenceArgumentState(value, synchronize), valueMarshaler);
			}
			return new JniValueMarshalerState(JavaProxyObject.GetProxy(value).PeerReference.NewLocalRef(), null);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		public override void DestroyGenericArgumentState(object value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			JniValueMarshaler jniValueMarshaler = state.Extra as JniValueMarshaler;
			if (jniValueMarshaler != null)
			{
				jniValueMarshaler.DestroyArgumentState(value, ref state, synchronize);
				return;
			}
			JniObjectReference referenceValue = state.ReferenceValue;
			JniObjectReference.Dispose(ref referenceValue);
			state = default(JniValueMarshalerState);
		}

		// Token: 0x04000130 RID: 304
		internal static ProxyValueMarshaler Instance = new ProxyValueMarshaler();
	}
}
