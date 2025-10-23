using System;

namespace System
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	internal class ReflectionOnlyType : RuntimeType
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x00038EC6 File Offset: 0x000370C6
		private ReflectionOnlyType()
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00038ECE File Offset: 0x000370CE
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new InvalidOperationException(Environment.GetResourceString("The requested operation is invalid in the ReflectionOnly context."));
			}
		}
	}
}
