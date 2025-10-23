using System;
using System.Reflection.Emit;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000EF RID: 239
	internal interface ILocalCache
	{
		// Token: 0x0600081D RID: 2077
		LocalBuilder GetLocal(Type type);

		// Token: 0x0600081E RID: 2078
		void FreeLocal(LocalBuilder local);
	}
}
