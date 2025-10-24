using System;
using System.Globalization;

namespace System.Reflection
{
	// Token: 0x020004D8 RID: 1240
	internal abstract class RtFieldInfo : FieldInfo
	{
		// Token: 0x06002335 RID: 9013
		internal abstract object UnsafeGetValue(object obj);

		// Token: 0x06002336 RID: 9014
		internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		// Token: 0x06002337 RID: 9015
		internal abstract void CheckConsistency(object target);
	}
}
