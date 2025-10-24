using System;

namespace System.Reflection
{
	// Token: 0x020004D6 RID: 1238
	internal struct MonoEventInfo
	{
		// Token: 0x04001120 RID: 4384
		public Type declaring_type;

		// Token: 0x04001121 RID: 4385
		public Type reflected_type;

		// Token: 0x04001122 RID: 4386
		public string name;

		// Token: 0x04001123 RID: 4387
		public MethodInfo add_method;

		// Token: 0x04001124 RID: 4388
		public MethodInfo remove_method;

		// Token: 0x04001125 RID: 4389
		public MethodInfo raise_method;

		// Token: 0x04001126 RID: 4390
		public EventAttributes attrs;

		// Token: 0x04001127 RID: 4391
		public MethodInfo[] other_methods;
	}
}
