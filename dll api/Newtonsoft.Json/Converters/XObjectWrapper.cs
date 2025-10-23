using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001D0 RID: 464
	[NullableContext(2)]
	[Nullable(0)]
	internal class XObjectWrapper : IXmlNode
	{
		// Token: 0x06000F8C RID: 3980 RVA: 0x0004364E File Offset: 0x0004184E
		public XObjectWrapper(XObject xmlObject)
		{
			this._xmlObject = xmlObject;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0004365D File Offset: 0x0004185D
		public object WrappedNode
		{
			get
			{
				return this._xmlObject;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00043665 File Offset: 0x00041865
		public virtual XmlNodeType NodeType
		{
			get
			{
				XObject xmlObject = this._xmlObject;
				if (xmlObject == null)
				{
					return XmlNodeType.None;
				}
				return xmlObject.NodeType;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00035A47 File Offset: 0x00033C47
		public virtual string LocalName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00043678 File Offset: 0x00041878
		[Nullable(1)]
		public virtual List<IXmlNode> ChildNodes
		{
			[NullableContext(1)]
			get
			{
				return XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00043678 File Offset: 0x00041878
		[Nullable(1)]
		public virtual List<IXmlNode> Attributes
		{
			[NullableContext(1)]
			get
			{
				return XmlNodeConverter.EmptyChildNodes;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00035A47 File Offset: 0x00033C47
		public virtual IXmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00035A47 File Offset: 0x00033C47
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x0004367F File Offset: 0x0004187F
		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0004367F File Offset: 0x0004187F
		[NullableContext(1)]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00035A47 File Offset: 0x00033C47
		public virtual string NamespaceUri
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400081D RID: 2077
		private readonly XObject _xmlObject;
	}
}
