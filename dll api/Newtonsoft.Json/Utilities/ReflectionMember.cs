using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000E1 RID: 225
	[NullableContext(2)]
	[Nullable(0)]
	internal class ReflectionMember
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00022A4E File Offset: 0x00020C4E
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00022A56 File Offset: 0x00020C56
		public Type MemberType { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00022A5F File Offset: 0x00020C5F
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00022A67 File Offset: 0x00020C67
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<object, object> Getter { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00022A70 File Offset: 0x00020C70
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00022A78 File Offset: 0x00020C78
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Action<object, object> Setter { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }
	}
}
