using System;
using System.Reflection;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002B5 RID: 693
	internal sealed class IJavaObjectValueMarshaler : JniValueMarshaler<IJavaObject>
	{
		// Token: 0x06001A76 RID: 6774 RVA: 0x00033473 File Offset: 0x00031673
		public override IJavaObject CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00033473 File Offset: 0x00031673
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(IJavaObject value, ParameterAttributes synchronize)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00033473 File Offset: 0x00031673
		public override void DestroyGenericArgumentState(IJavaObject value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			throw new NotImplementedException();
		}
	}
}
