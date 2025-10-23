using System;

namespace System.Reflection
{
	// Token: 0x020004E0 RID: 1248
	internal struct MonoPropertyInfo
	{
		// Token: 0x04001146 RID: 4422
		public Type parent;

		// Token: 0x04001147 RID: 4423
		public Type declaring_type;

		// Token: 0x04001148 RID: 4424
		public string name;

		// Token: 0x04001149 RID: 4425
		public MethodInfo get_method;

		// Token: 0x0400114A RID: 4426
		public MethodInfo set_method;

		// Token: 0x0400114B RID: 4427
		public PropertyAttributes attrs;
	}
}
