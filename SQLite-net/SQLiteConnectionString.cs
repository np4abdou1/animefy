using System;
using System.Globalization;

namespace SQLite
{
	// Token: 0x02000013 RID: 19
	public class SQLiteConnectionString
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000427C File Offset: 0x0000247C
		public string UniqueKey { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004284 File Offset: 0x00002484
		public string DatabasePath { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000428C File Offset: 0x0000248C
		public bool StoreDateTimeAsTicks { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004294 File Offset: 0x00002494
		public bool StoreTimeSpanAsTicks { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000429C File Offset: 0x0000249C
		public string DateTimeStringFormat { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000042A4 File Offset: 0x000024A4
		public DateTimeStyles DateTimeStyle { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000042AC File Offset: 0x000024AC
		public object Key { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000042B4 File Offset: 0x000024B4
		public SQLiteOpenFlags OpenFlags { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000042BC File Offset: 0x000024BC
		public Action<SQLiteConnection> PreKeyAction { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000042C4 File Offset: 0x000024C4
		public Action<SQLiteConnection> PostKeyAction { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000042CC File Offset: 0x000024CC
		public string VfsName { get; }

		// Token: 0x060000A4 RID: 164 RVA: 0x000042D4 File Offset: 0x000024D4
		public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks = true) : this(databasePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, storeDateTimeAsTicks, null, null, null, null, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000042F4 File Offset: 0x000024F4
		public SQLiteConnectionString(string databasePath, bool storeDateTimeAsTicks, object key = null, Action<SQLiteConnection> preKeyAction = null, Action<SQLiteConnection> postKeyAction = null, string vfsName = null) : this(databasePath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, storeDateTimeAsTicks, key, preKeyAction, postKeyAction, vfsName, "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", true)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004318 File Offset: 0x00002518
		public SQLiteConnectionString(string databasePath, SQLiteOpenFlags openFlags, bool storeDateTimeAsTicks, object key = null, Action<SQLiteConnection> preKeyAction = null, Action<SQLiteConnection> postKeyAction = null, string vfsName = null, string dateTimeStringFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", bool storeTimeSpanAsTicks = true)
		{
			if (key != null && !(key is byte[]) && !(key is string))
			{
				throw new ArgumentException("Encryption keys must be strings or byte arrays", "key");
			}
			this.UniqueKey = string.Format("{0}_{1:X8}", databasePath, (uint)openFlags);
			this.StoreDateTimeAsTicks = storeDateTimeAsTicks;
			this.StoreTimeSpanAsTicks = storeTimeSpanAsTicks;
			this.DateTimeStringFormat = dateTimeStringFormat;
			this.DateTimeStyle = (("o".Equals(this.DateTimeStringFormat, StringComparison.OrdinalIgnoreCase) || "r".Equals(this.DateTimeStringFormat, StringComparison.OrdinalIgnoreCase)) ? 128 : 0);
			this.Key = key;
			this.PreKeyAction = preKeyAction;
			this.PostKeyAction = postKeyAction;
			this.OpenFlags = openFlags;
			this.VfsName = vfsName;
			this.DatabasePath = databasePath;
		}

		// Token: 0x04000053 RID: 83
		private const string DateTimeSqliteDefaultFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff";
	}
}
