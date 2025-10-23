using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines events for a class.</summary>
	// Token: 0x020004FC RID: 1276
	[StructLayout(0)]
	public sealed class EventBuilder
	{
		// Token: 0x0400120E RID: 4622
		internal string name;

		// Token: 0x0400120F RID: 4623
		private Type type;

		// Token: 0x04001210 RID: 4624
		private TypeBuilder typeb;

		// Token: 0x04001211 RID: 4625
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04001212 RID: 4626
		internal MethodBuilder add_method;

		// Token: 0x04001213 RID: 4627
		internal MethodBuilder remove_method;

		// Token: 0x04001214 RID: 4628
		internal MethodBuilder raise_method;

		// Token: 0x04001215 RID: 4629
		internal MethodBuilder[] other_methods;

		// Token: 0x04001216 RID: 4630
		internal EventAttributes attrs;

		// Token: 0x04001217 RID: 4631
		private int table_idx;
	}
}
