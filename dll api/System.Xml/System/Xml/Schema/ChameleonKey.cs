using System;

namespace System.Xml.Schema
{
	// Token: 0x0200022A RID: 554
	internal class ChameleonKey
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x00071023 File Offset: 0x0006F223
		public ChameleonKey(string ns, XmlSchema originalSchema)
		{
			this.targetNS = ns;
			this.chameleonLocation = originalSchema.BaseUri;
			if (this.chameleonLocation.OriginalString.Length == 0)
			{
				this.originalSchema = originalSchema;
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00071058 File Offset: 0x0006F258
		public override int GetHashCode()
		{
			if (this.hashCode == 0)
			{
				this.hashCode = this.targetNS.GetHashCode() + this.chameleonLocation.GetHashCode() + ((this.originalSchema == null) ? 0 : this.originalSchema.GetHashCode());
			}
			return this.hashCode;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000710A8 File Offset: 0x0006F2A8
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			ChameleonKey chameleonKey = obj as ChameleonKey;
			return chameleonKey != null && (this.targetNS.Equals(chameleonKey.targetNS) && this.chameleonLocation.Equals(chameleonKey.chameleonLocation)) && this.originalSchema == chameleonKey.originalSchema;
		}

		// Token: 0x04000C65 RID: 3173
		internal string targetNS;

		// Token: 0x04000C66 RID: 3174
		internal Uri chameleonLocation;

		// Token: 0x04000C67 RID: 3175
		internal XmlSchema originalSchema;

		// Token: 0x04000C68 RID: 3176
		private int hashCode;
	}
}
