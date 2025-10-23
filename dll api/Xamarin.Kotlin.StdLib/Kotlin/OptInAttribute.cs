using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000090 RID: 144
	[Annotation("kotlin.OptIn")]
	public class OptInAttribute : Attribute
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00009E04 File Offset: 0x00008004
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00009E0C File Offset: 0x0000800C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("markerClass")]
		public Class[] MarkerClass { [return: Nullable(new byte[]
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
