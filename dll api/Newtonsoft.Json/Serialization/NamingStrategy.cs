using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000134 RID: 308
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NamingStrategy
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0002F154 File Offset: 0x0002D354
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0002F15C File Offset: 0x0002D35C
		public bool ProcessDictionaryKeys { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002F165 File Offset: 0x0002D365
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0002F16D File Offset: 0x0002D36D
		public bool ProcessExtensionDataNames { get; set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0002F176 File Offset: 0x0002D376
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0002F17E File Offset: 0x0002D37E
		public bool OverrideSpecifiedNames { get; set; }

		// Token: 0x06000985 RID: 2437 RVA: 0x0002F187 File Offset: 0x0002D387
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			if (hasSpecifiedName && !this.OverrideSpecifiedNames)
			{
				return name;
			}
			return this.ResolvePropertyName(name);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002F19D File Offset: 0x0002D39D
		public virtual string GetExtensionDataName(string name)
		{
			if (!this.ProcessExtensionDataNames)
			{
				return name;
			}
			return this.ResolvePropertyName(name);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002F1B0 File Offset: 0x0002D3B0
		public virtual string GetDictionaryKey(string key)
		{
			if (!this.ProcessDictionaryKeys)
			{
				return key;
			}
			return this.ResolvePropertyName(key);
		}

		// Token: 0x06000988 RID: 2440
		protected abstract string ResolvePropertyName(string name);

		// Token: 0x06000989 RID: 2441 RVA: 0x0002F1C4 File Offset: 0x0002D3C4
		public override int GetHashCode()
		{
			return ((base.GetType().GetHashCode() * 397 ^ this.ProcessDictionaryKeys.GetHashCode()) * 397 ^ this.ProcessExtensionDataNames.GetHashCode()) * 397 ^ this.OverrideSpecifiedNames.GetHashCode();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0002F21B File Offset: 0x0002D41B
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return this.Equals(obj as NamingStrategy);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0002F22C File Offset: 0x0002D42C
		[NullableContext(2)]
		protected bool Equals(NamingStrategy other)
		{
			return other != null && (base.GetType() == other.GetType() && this.ProcessDictionaryKeys == other.ProcessDictionaryKeys && this.ProcessExtensionDataNames == other.ProcessExtensionDataNames) && this.OverrideSpecifiedNames == other.OverrideSpecifiedNames;
		}
	}
}
