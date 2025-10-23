using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CE RID: 462
	[NullableContext(2)]
	[Nullable(0)]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0004347E File Offset: 0x0004167E
		[Nullable(1)]
		private XProcessingInstruction ProcessingInstruction
		{
			[NullableContext(1)]
			get
			{
				return (XProcessingInstruction)base.WrappedNode;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000433DE File Offset: 0x000415DE
		[NullableContext(1)]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) : base(processingInstruction)
		{
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0004348B File Offset: 0x0004168B
		public override string LocalName
		{
			get
			{
				return this.ProcessingInstruction.Target;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00043498 File Offset: 0x00041698
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x000434A5 File Offset: 0x000416A5
		public override string Value
		{
			get
			{
				return this.ProcessingInstruction.Data;
			}
			set
			{
				this.ProcessingInstruction.Data = (value ?? string.Empty);
			}
		}
	}
}
