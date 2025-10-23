using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x0200008C RID: 140
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.Metadata")]
	public class MetadataAttribute : Attribute
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00009707 File Offset: 0x00007907
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000970F File Offset: 0x0000790F
		[Register("bv")]
		public int[] Bv { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00009718 File Offset: 0x00007918
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00009720 File Offset: 0x00007920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("d1")]
		public string[] D1 { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00009729 File Offset: 0x00007929
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00009731 File Offset: 0x00007931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("d2")]
		public string[] D2 { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000973A File Offset: 0x0000793A
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00009742 File Offset: 0x00007942
		[Register("k")]
		public int K { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000974B File Offset: 0x0000794B
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00009753 File Offset: 0x00007953
		[Register("mv")]
		public int[] Mv { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000975C File Offset: 0x0000795C
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00009764 File Offset: 0x00007964
		[Register("pn")]
		public string Pn { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000976D File Offset: 0x0000796D
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00009775 File Offset: 0x00007975
		[Register("xi")]
		public int Xi { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000977E File Offset: 0x0000797E
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00009786 File Offset: 0x00007986
		[Register("xs")]
		public string Xs { get; set; }
	}
}
