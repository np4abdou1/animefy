using System;
using System.Runtime.CompilerServices;

namespace Android.App
{
	// Token: 0x02000274 RID: 628
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class UsesLibraryAttribute : Attribute
	{
		// Token: 0x060017D8 RID: 6104 RVA: 0x0000216A File Offset: 0x0000036A
		public UsesLibraryAttribute()
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0003DE3A File Offset: 0x0003C03A
		public UsesLibraryAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000514 RID: 1300
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0003DE49 File Offset: 0x0003C049
		public string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0003DE52 File Offset: 0x0003C052
		public bool Required
		{
			[CompilerGenerated]
			set
			{
				this.<Required>k__BackingField = value;
			}
		}
	}
}
