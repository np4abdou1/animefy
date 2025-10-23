using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Provides methods for building signatures.</summary>
	// Token: 0x02000516 RID: 1302
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_SignatureHelper))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(0)]
	public sealed class SignatureHelper
	{
		// Token: 0x040013A9 RID: 5033
		private ModuleBuilder module;

		// Token: 0x040013AA RID: 5034
		private Type[] arguments;

		// Token: 0x040013AB RID: 5035
		private SignatureHelper.SignatureHelperType type;

		// Token: 0x040013AC RID: 5036
		private Type returnType;

		// Token: 0x040013AD RID: 5037
		private CallingConventions callConv;

		// Token: 0x040013AE RID: 5038
		private CallingConvention unmanagedCallConv;

		// Token: 0x040013AF RID: 5039
		private Type[][] modreqs;

		// Token: 0x040013B0 RID: 5040
		private Type[][] modopts;

		// Token: 0x02000517 RID: 1303
		internal enum SignatureHelperType
		{
			// Token: 0x040013B2 RID: 5042
			HELPER_FIELD,
			// Token: 0x040013B3 RID: 5043
			HELPER_LOCAL,
			// Token: 0x040013B4 RID: 5044
			HELPER_METHOD,
			// Token: 0x040013B5 RID: 5045
			HELPER_PROPERTY
		}
	}
}
