using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x00042DF5 File Offset: 0x00040FF5
		public XmlElementWrapper(XmlElement element) : base(element)
		{
			this._element = element;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00042E08 File Offset: 0x00041008
		public void SetAttributeNode(IXmlNode attribute)
		{
			XmlNodeWrapper xmlNodeWrapper = (XmlNodeWrapper)attribute;
			this._element.SetAttributeNode((XmlAttribute)xmlNodeWrapper.WrappedNode);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00042E33 File Offset: 0x00041033
		[return: Nullable(2)]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return this._element.GetPrefixOfNamespace(namespaceUri);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00042E41 File Offset: 0x00041041
		public bool IsEmpty
		{
			get
			{
				return this._element.IsEmpty;
			}
		}

		// Token: 0x04000814 RID: 2068
		private readonly XmlElement _element;
	}
}
