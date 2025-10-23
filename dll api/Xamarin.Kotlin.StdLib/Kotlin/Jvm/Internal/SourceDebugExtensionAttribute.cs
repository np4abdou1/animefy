using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001CE RID: 462
	[Annotation("kotlin.jvm.internal.SourceDebugExtension")]
	public class SourceDebugExtensionAttribute : Attribute
	{
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0004B2BC File Offset: 0x000494BC
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0004B2C4 File Offset: 0x000494C4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("value")]
		public string[] Value { [return: Nullable(new byte[]
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
