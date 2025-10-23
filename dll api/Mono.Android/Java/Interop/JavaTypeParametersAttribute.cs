using System;

namespace Java.Interop
{
	// Token: 0x0200043A RID: 1082
	public class JavaTypeParametersAttribute : Attribute
	{
		// Token: 0x06002F21 RID: 12065 RVA: 0x0008355B File Offset: 0x0008175B
		public JavaTypeParametersAttribute(string[] typeParameters)
		{
			this.TypeParameters = typeParameters;
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0008356A File Offset: 0x0008176A
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00083572 File Offset: 0x00081772
		public string[] TypeParameters { get; set; }
	}
}
