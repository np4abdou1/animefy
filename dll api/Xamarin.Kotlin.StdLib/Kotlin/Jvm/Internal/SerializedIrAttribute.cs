using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001CC RID: 460
	[Annotation("kotlin.jvm.internal.SerializedIr")]
	public class SerializedIrAttribute : Attribute
	{
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0004B0B7 File Offset: 0x000492B7
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0004B0BF File Offset: 0x000492BF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("b")]
		public string[] B { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
