using System;
using System.Runtime.CompilerServices;
using Android.Content.PM;
using Java.Interop;

namespace Android.App
{
	// Token: 0x02000259 RID: 601
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public sealed class ActivityAttribute : Attribute, IJniNameProviderAttribute
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000376D3 File Offset: 0x000358D3
		public string Name { get; }

		// Token: 0x170004CF RID: 1231
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x000376DB File Offset: 0x000358DB
		public ConfigChanges ConfigurationChanges
		{
			[CompilerGenerated]
			set
			{
				this.<ConfigurationChanges>k__BackingField = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x000376E4 File Offset: 0x000358E4
		public string Label
		{
			[CompilerGenerated]
			set
			{
				this.<Label>k__BackingField = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x000376ED File Offset: 0x000358ED
		public bool MainLauncher
		{
			[CompilerGenerated]
			set
			{
				this.<MainLauncher>k__BackingField = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x000376F6 File Offset: 0x000358F6
		public bool NoHistory
		{
			[CompilerGenerated]
			set
			{
				this.<NoHistory>k__BackingField = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x000376FF File Offset: 0x000358FF
		public string Theme
		{
			[CompilerGenerated]
			set
			{
				this.<Theme>k__BackingField = value;
			}
		}
	}
}
