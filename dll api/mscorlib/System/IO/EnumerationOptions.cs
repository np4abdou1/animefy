using System;

namespace System.IO
{
	// Token: 0x02000543 RID: 1347
	public class EnumerationOptions
	{
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x0009F961 File Offset: 0x0009DB61
		internal static EnumerationOptions Compatible { get; } = new EnumerationOptions
		{
			MatchType = MatchType.Win32,
			AttributesToSkip = (FileAttributes)0,
			IgnoreInaccessible = false
		};

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x0009F968 File Offset: 0x0009DB68
		internal static EnumerationOptions Default { get; }

		// Token: 0x060027DA RID: 10202 RVA: 0x0009F96F File Offset: 0x0009DB6F
		public EnumerationOptions()
		{
			this.IgnoreInaccessible = true;
			this.AttributesToSkip = (FileAttributes.Hidden | FileAttributes.System);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x0009F985 File Offset: 0x0009DB85
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x0009F98D File Offset: 0x0009DB8D
		public bool RecurseSubdirectories { get; set; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0009F996 File Offset: 0x0009DB96
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x0009F99E File Offset: 0x0009DB9E
		public bool IgnoreInaccessible { get; set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x0009F9A7 File Offset: 0x0009DBA7
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x0009F9AF File Offset: 0x0009DBAF
		public FileAttributes AttributesToSkip { get; set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x0009F9B8 File Offset: 0x0009DBB8
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x0009F9C0 File Offset: 0x0009DBC0
		public MatchType MatchType { get; set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0009F9C9 File Offset: 0x0009DBC9
		public MatchCasing MatchCasing { get; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0009F9D1 File Offset: 0x0009DBD1
		public bool ReturnSpecialDirectories { get; }

		// Token: 0x060027E5 RID: 10213 RVA: 0x0009F9DC File Offset: 0x0009DBDC
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerationOptions()
		{
			EnumerationOptions.<CompatibleRecursive>k__BackingField = new EnumerationOptions
			{
				RecurseSubdirectories = true,
				MatchType = MatchType.Win32,
				AttributesToSkip = (FileAttributes)0,
				IgnoreInaccessible = false
			};
			EnumerationOptions.Default = new EnumerationOptions();
		}
	}
}
