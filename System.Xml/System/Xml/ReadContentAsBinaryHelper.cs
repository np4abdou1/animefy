using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000039 RID: 57
	internal class ReadContentAsBinaryHelper
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x0000A738 File Offset: 0x00008938
		internal void Finish()
		{
			if (this.state != ReadContentAsBinaryHelper.State.None)
			{
				while (this.MoveToNextContentNode(true))
				{
				}
				if (this.state == ReadContentAsBinaryHelper.State.InReadElementContent)
				{
					if (this.reader.NodeType != XmlNodeType.EndElement)
					{
						throw new XmlException("'{0}' is an invalid XmlNodeType.", this.reader.NodeType.ToString(), this.reader as IXmlLineInfo);
					}
					this.reader.Read();
				}
			}
			this.Reset();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000A7AF File Offset: 0x000089AF
		internal void Reset()
		{
			this.state = ReadContentAsBinaryHelper.State.None;
			this.isEnd = false;
			this.valueOffset = 0;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000A7C8 File Offset: 0x000089C8
		private bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			for (;;)
			{
				switch (this.reader.NodeType)
				{
				case XmlNodeType.Attribute:
					goto IL_52;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					if (!moveIfOnContentNode)
					{
						return true;
					}
					goto IL_78;
				case XmlNodeType.EntityReference:
					if (this.reader.CanResolveEntity)
					{
						this.reader.ResolveEntity();
						goto IL_78;
					}
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
				case XmlNodeType.EndEntity:
					goto IL_78;
				}
				break;
				IL_78:
				moveIfOnContentNode = false;
				if (!this.reader.Read())
				{
					return false;
				}
			}
			return false;
			IL_52:
			return !moveIfOnContentNode;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000A864 File Offset: 0x00008A64
		internal Task FinishAsync()
		{
			ReadContentAsBinaryHelper.<FinishAsync>d__31 <FinishAsync>d__;
			<FinishAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<FinishAsync>d__.<>4__this = this;
			<FinishAsync>d__.<>1__state = -1;
			<FinishAsync>d__.<>t__builder.Start<ReadContentAsBinaryHelper.<FinishAsync>d__31>(ref <FinishAsync>d__);
			return <FinishAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		private Task<bool> MoveToNextContentNodeAsync(bool moveIfOnContentNode)
		{
			ReadContentAsBinaryHelper.<MoveToNextContentNodeAsync>d__36 <MoveToNextContentNodeAsync>d__;
			<MoveToNextContentNodeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<MoveToNextContentNodeAsync>d__.<>4__this = this;
			<MoveToNextContentNodeAsync>d__.moveIfOnContentNode = moveIfOnContentNode;
			<MoveToNextContentNodeAsync>d__.<>1__state = -1;
			<MoveToNextContentNodeAsync>d__.<>t__builder.Start<ReadContentAsBinaryHelper.<MoveToNextContentNodeAsync>d__36>(ref <MoveToNextContentNodeAsync>d__);
			return <MoveToNextContentNodeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000136 RID: 310
		private XmlReader reader;

		// Token: 0x04000137 RID: 311
		private ReadContentAsBinaryHelper.State state;

		// Token: 0x04000138 RID: 312
		private int valueOffset;

		// Token: 0x04000139 RID: 313
		private bool isEnd;

		// Token: 0x0200003A RID: 58
		private enum State
		{
			// Token: 0x0400013B RID: 315
			None,
			// Token: 0x0400013C RID: 316
			InReadContent,
			// Token: 0x0400013D RID: 317
			InReadElementContent
		}
	}
}
