using System;

namespace SQLite
{
	// Token: 0x02000011 RID: 17
	public class NotifyTableChangedEventArgs : EventArgs
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004244 File Offset: 0x00002444
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000424C File Offset: 0x0000244C
		public TableMapping Table { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004255 File Offset: 0x00002455
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000425D File Offset: 0x0000245D
		public NotifyTableChangedAction Action { get; private set; }

		// Token: 0x06000098 RID: 152 RVA: 0x00004266 File Offset: 0x00002466
		public NotifyTableChangedEventArgs(TableMapping table, NotifyTableChangedAction action)
		{
			this.Table = table;
			this.Action = action;
		}
	}
}
