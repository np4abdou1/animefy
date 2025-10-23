using System;
using System.Text;

namespace System.Xml.Serialization
{
	// Token: 0x020001D6 RID: 470
	internal class XmlTypeSerializationSource : SerializationSource
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x00062FCC File Offset: 0x000611CC
		public XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) : base(namspace, includedTypes)
		{
			if (attributeOverrides != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				attributeOverrides.AddKeyHash(stringBuilder);
				this.attributeOverridesHash = stringBuilder.ToString();
			}
			if (root != null)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				root.AddKeyHash(stringBuilder2);
				this.rootHash = stringBuilder2.ToString();
			}
			this.type = type;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00063024 File Offset: 0x00061224
		public override bool Equals(object o)
		{
			XmlTypeSerializationSource xmlTypeSerializationSource = o as XmlTypeSerializationSource;
			return xmlTypeSerializationSource != null && this.type.Equals(xmlTypeSerializationSource.type) && !(this.rootHash != xmlTypeSerializationSource.rootHash) && !(this.attributeOverridesHash != xmlTypeSerializationSource.attributeOverridesHash) && base.BaseEquals(xmlTypeSerializationSource);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00063083 File Offset: 0x00061283
		public override int GetHashCode()
		{
			return this.type.GetHashCode();
		}

		// Token: 0x04000B2F RID: 2863
		private string attributeOverridesHash;

		// Token: 0x04000B30 RID: 2864
		private Type type;

		// Token: 0x04000B31 RID: 2865
		private string rootHash;
	}
}
