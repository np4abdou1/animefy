using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000405 RID: 1029
	[Register("java/lang/reflect/Member", "", "Java.Lang.Reflect.IMemberInvoker")]
	public interface IMember : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002D4C RID: 11596
		Class DeclaringClass { get; }

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002D4D RID: 11597
		bool IsSynthetic { get; }

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002D4E RID: 11598
		int Modifiers { get; }

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002D4F RID: 11599
		string Name { get; }
	}
}
