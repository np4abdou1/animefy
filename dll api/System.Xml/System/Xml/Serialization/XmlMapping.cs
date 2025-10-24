using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>Supports mappings between .NET Framework types and XML Schema data types. </summary>
	// Token: 0x020001EB RID: 491
	public abstract class XmlMapping
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x00065DD3 File Offset: 0x00063FD3
		internal XmlMapping(string elementName, string ns)
		{
			this._elementName = elementName;
			this._namespace = ns;
		}

		/// <summary>Get the name of the mapped element.</summary>
		/// <returns>The name of the mapped element.</returns>
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00065DE9 File Offset: 0x00063FE9
		public string ElementName
		{
			get
			{
				return this._elementName;
			}
		}

		/// <summary>Gets the namespace of the mapped element.</summary>
		/// <returns>The namespace of the mapped element.</returns>
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x00065DF1 File Offset: 0x00063FF1
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
		}

		/// <summary>Sets the key used to look up the mapping.</summary>
		/// <param name="key">A <see cref="T:System.String" /> that contains the lookup key.</param>
		// Token: 0x0600102B RID: 4139 RVA: 0x00065DF9 File Offset: 0x00063FF9
		public void SetKey(string key)
		{
			this.key = key;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00065E02 File Offset: 0x00064002
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00065E0A File Offset: 0x0006400A
		internal ObjectMap ObjectMap
		{
			get
			{
				return this.map;
			}
			set
			{
				this.map = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00065E13 File Offset: 0x00064013
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x00065E1B File Offset: 0x0006401B
		internal ArrayList RelatedMaps
		{
			get
			{
				return this.relatedMaps;
			}
			set
			{
				this.relatedMaps = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00065E24 File Offset: 0x00064024
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x00065E2C File Offset: 0x0006402C
		internal SerializationFormat Format
		{
			get
			{
				return this.format;
			}
			set
			{
				this.format = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00065E35 File Offset: 0x00064035
		internal SerializationSource Source
		{
			get
			{
				return this.source;
			}
		}

		// Token: 0x04000B75 RID: 2933
		private ObjectMap map;

		// Token: 0x04000B76 RID: 2934
		private ArrayList relatedMaps;

		// Token: 0x04000B77 RID: 2935
		private SerializationFormat format;

		// Token: 0x04000B78 RID: 2936
		private SerializationSource source;

		// Token: 0x04000B79 RID: 2937
		internal string _elementName;

		// Token: 0x04000B7A RID: 2938
		internal string _namespace;

		// Token: 0x04000B7B RID: 2939
		private string key;
	}
}
