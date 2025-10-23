using System;

namespace SQLitePCL
{
	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x06000107 RID: 263
	public delegate int delegate_authorizer(object user_data, int action_code, utf8z param0, utf8z param1, utf8z dbName, utf8z inner_most_trigger_or_view);
}
