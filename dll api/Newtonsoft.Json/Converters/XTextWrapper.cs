using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CC RID: 460
	[NullableContext(2)]
	[Nullable(0)]
	internal class XTextWrapper : XObjectWrapper
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000433D1 File Offset: 0x000415D1
		[Nullable(1)]
		private XText Text
		{
			[NullableContext(1)]
			get
			{
				return (XText)base.WrappedNode;
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000433DE File Offset: 0x000415DE
		[NullableContext(1)]
		public XTextWrapper(XText text) : base(text)
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x000433E7 File Offset: 0x000415E7
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x000433F4 File Offset: 0x000415F4
		public override string Value
		{
			get
			{
				return this.Text.Value;
			}
			set
			{
				this.Text.Value = (value ?? string.Empty);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0004340B File Offset: 0x0004160B
		public override IXmlNode ParentNode
		{
			get
			{
				if (this.Text.Parent == null)
				{
					return null;
				}
				return XContainerWrapper.WrapNode(this.Text.Parent);
			}
		}
	}
}
