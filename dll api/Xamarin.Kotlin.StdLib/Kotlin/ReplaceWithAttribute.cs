using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x02000098 RID: 152
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.ReplaceWith")]
	public class ReplaceWithAttribute : Attribute
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000A215 File Offset: 0x00008415
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000A21D File Offset: 0x0000841D
		[Register("expression")]
		public string Expression { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000A226 File Offset: 0x00008426
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000A22E File Offset: 0x0000842E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("imports")]
		public string[] Imports { [return: Nullable(new byte[]
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
