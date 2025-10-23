using System;

namespace Java.Interop
{
	// Token: 0x02000430 RID: 1072
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public class DoNotPackageAttribute : Attribute
	{
		// Token: 0x06002ECC RID: 11980 RVA: 0x00081DB7 File Offset: 0x0007FFB7
		public DoNotPackageAttribute(string jarFile)
		{
			this.JarFile = jarFile;
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00081DC6 File Offset: 0x0007FFC6
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x00081DCE File Offset: 0x0007FFCE
		public string JarFile { get; set; }
	}
}
