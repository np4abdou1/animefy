using System;
using System.Reflection;
using Java.Interop;

namespace Android.Graphics
{
	// Token: 0x02000233 RID: 563
	public class ColorValueMarshaler : JniValueMarshaler<Color>
	{
		// Token: 0x060013DA RID: 5082 RVA: 0x00033473 File Offset: 0x00031673
		public override Color CreateGenericValue(ref JniObjectReference reference, JniObjectReferenceOptions options, Type targetType)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00033473 File Offset: 0x00031673
		public override JniValueMarshalerState CreateGenericObjectReferenceArgumentState(Color value, ParameterAttributes synchronize)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00033473 File Offset: 0x00031673
		public override void DestroyGenericArgumentState(Color value, ref JniValueMarshalerState state, ParameterAttributes synchronize)
		{
			throw new NotImplementedException();
		}
	}
}
