using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003AC RID: 940
	internal class TypeLoadExceptionHolder
	{
		// Token: 0x06001D2F RID: 7471 RVA: 0x0007BBAF File Offset: 0x00079DAF
		internal TypeLoadExceptionHolder(string typeName)
		{
			this.m_typeName = typeName;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x0007BBBE File Offset: 0x00079DBE
		internal string TypeName
		{
			get
			{
				return this.m_typeName;
			}
		}

		// Token: 0x04000C38 RID: 3128
		private string m_typeName;
	}
}
