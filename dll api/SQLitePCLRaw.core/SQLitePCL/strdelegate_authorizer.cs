using System;

namespace SQLitePCL
{
	// Token: 0x02000008 RID: 8
	// (Invoke) Token: 0x06000011 RID: 17
	public delegate int strdelegate_authorizer(object user_data, int action_code, string param0, string param1, string dbName, string inner_most_trigger_or_view);
}
