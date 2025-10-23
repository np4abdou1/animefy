using System;

namespace SQLitePCL
{
	// Token: 0x0200003F RID: 63
	public sealed class EntryPointAttribute : Attribute
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00003CE2 File Offset: 0x00001EE2
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00003CEA File Offset: 0x00001EEA
		public string Name { get; private set; }

		// Token: 0x06000209 RID: 521 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public EntryPointAttribute(string name)
		{
			this.Name = name;
		}
	}
}
