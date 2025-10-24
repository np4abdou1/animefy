using System;

namespace System.Reflection.Emit
{
	// Token: 0x020004FA RID: 1274
	internal class DynamicMethodTokenGenerator : TokenGenerator
	{
		// Token: 0x060024CA RID: 9418 RVA: 0x0009060B File Offset: 0x0008E80B
		public DynamicMethodTokenGenerator(DynamicMethod m)
		{
			this.m = m;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0009061A File Offset: 0x0008E81A
		public int GetToken(string str)
		{
			return this.m.AddRef(str);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0008A04D File Offset: 0x0008824D
		public int GetToken(MethodBase method, Type[] opt_param_types)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0009061A File Offset: 0x0008E81A
		public int GetToken(MemberInfo member, bool create_open_instance)
		{
			return this.m.AddRef(member);
		}

		// Token: 0x0400120A RID: 4618
		private DynamicMethod m;
	}
}
