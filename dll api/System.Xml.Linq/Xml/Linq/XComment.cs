using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML comment. </summary>
	// Token: 0x02000008 RID: 8
	public class XComment : XNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XComment" /> class with the specified string content. </summary>
		/// <param name="value">A string that contains the contents of the new <see cref="T:System.Xml.Linq.XComment" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000018 RID: 24 RVA: 0x00002438 File Offset: 0x00000638
		public XComment(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.value = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XComment" /> class from an existing comment node. </summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XComment" /> node to copy from.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000019 RID: 25 RVA: 0x00002455 File Offset: 0x00000655
		public XComment(XComment other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.value = other.value;
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XComment" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Comment" />.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002477 File Offset: 0x00000677
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		/// <summary>Gets or sets the string value of this comment.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the string value of this comment.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000247A File Offset: 0x0000067A
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002482 File Offset: 0x00000682
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.value = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Write this comment to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x0600001D RID: 29 RVA: 0x000024B4 File Offset: 0x000006B4
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteComment(this.value);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000024D0 File Offset: 0x000006D0
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return writer.WriteCommentAsync(this.value);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000024FC File Offset: 0x000006FC
		internal override XNode CloneNode()
		{
			return new XComment(this);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002504 File Offset: 0x00000704
		internal override bool DeepEquals(XNode node)
		{
			XComment xcomment = node as XComment;
			return xcomment != null && this.value == xcomment.value;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000252E File Offset: 0x0000072E
		internal override int GetDeepHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x04000007 RID: 7
		internal string value;
	}
}
