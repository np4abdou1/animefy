using System;

namespace System.Reflection.Emit
{
	// Token: 0x02000504 RID: 1284
	internal interface TokenGenerator
	{
		// Token: 0x06002543 RID: 9539
		int GetToken(string str);

		// Token: 0x06002544 RID: 9540
		int GetToken(MemberInfo member, bool create_open_instance);

		// Token: 0x06002545 RID: 9541
		int GetToken(MethodBase method, Type[] opt_param_types);
	}
}
