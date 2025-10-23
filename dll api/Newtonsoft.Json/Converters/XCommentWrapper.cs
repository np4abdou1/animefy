using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CD RID: 461
	[NullableContext(2)]
	[Nullable(0)]
	internal class XCommentWrapper : XObjectWrapper
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0004342C File Offset: 0x0004162C
		[Nullable(1)]
		private XComment Text
		{
			[NullableContext(1)]
			get
			{
				return (XComment)base.WrappedNode;
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000433DE File Offset: 0x000415DE
		[NullableContext(1)]
		public XCommentWrapper(XComment text) : base(text)
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00043439 File Offset: 0x00041639
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00043446 File Offset: 0x00041646
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0004345D File Offset: 0x0004165D
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
