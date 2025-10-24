using System;

namespace System.Reflection.Emit
{
	// Token: 0x0200050F RID: 1295
	internal class ModuleBuilderTokenGenerator : TokenGenerator
	{
		// Token: 0x060025E2 RID: 9698 RVA: 0x00093829 File Offset: 0x00091A29
		public ModuleBuilderTokenGenerator(ModuleBuilder mb)
		{
			this.mb = mb;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00093838 File Offset: 0x00091A38
		public int GetToken(string str)
		{
			return this.mb.GetToken(str);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00093846 File Offset: 0x00091A46
		public int GetToken(MemberInfo member, bool create_open_instance)
		{
			return this.mb.GetToken(member, create_open_instance);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00093855 File Offset: 0x00091A55
		public int GetToken(MethodBase method, Type[] opt_param_types)
		{
			return this.mb.GetToken(method, opt_param_types);
		}

		// Token: 0x040012A2 RID: 4770
		private ModuleBuilder mb;
	}
}
