using System;

namespace SQLitePCL
{
	// Token: 0x02000003 RID: 3
	public static class Batteries_V2
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public static void Init()
		{
			raw.SetProvider(new SQLite3Provider_e_sqlite3());
		}
	}
}
