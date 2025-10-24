using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001D1 RID: 465
	[NullableContext(2)]
	[Nullable(0)]
	internal class XAttributeWrapper : XObjectWrapper
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00043686 File Offset: 0x00041886
		[Nullable(1)]
		private XAttribute Attribute
		{
			[NullableContext(1)]
			get
			{
				return (XAttribute)base.WrappedNode;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000433DE File Offset: 0x000415DE
		[NullableContext(1)]
		public XAttributeWrapper(XAttribute attribute) : base(attribute)
		{
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00043693 File Offset: 0x00041893
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x000436A0 File Offset: 0x000418A0
		public override string Value
		{
			get
			{
				return this.Attribute.Value;
			}
			set
			{
				this.Attribute.Value = (value ?? string.Empty);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x000436B7 File Offset: 0x000418B7
		public override string LocalName
		{
			get
			{
				return this.Attribute.Name.LocalName;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000436C9 File Offset: 0x000418C9
		public override string NamespaceUri
		{
			get
			{
				return this.Attribute.Name.NamespaceName;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x000436DB File Offset: 0x000418DB
		public override IXmlNode ParentNode
		{
			get
			{
				if (this.Attribute.Parent == null)
				{
					return null;
				}
				return XContainerWrapper.WrapNode(this.Attribute.Parent);
			}
		}
	}
}
