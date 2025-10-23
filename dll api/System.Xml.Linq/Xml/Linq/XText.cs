using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents a text node. </summary>
	// Token: 0x02000038 RID: 56
	public class XText : XNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XText" /> class. </summary>
		/// <param name="value">The <see cref="T:System.String" /> that contains the value of the <see cref="T:System.Xml.Linq.XText" /> node.</param>
		// Token: 0x06000199 RID: 409 RVA: 0x00008B32 File Offset: 0x00006D32
		public XText(string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.text = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XText" /> class from another <see cref="T:System.Xml.Linq.XText" /> object.</summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XText" /> node to copy from.</param>
		// Token: 0x0600019A RID: 410 RVA: 0x00008B4F File Offset: 0x00006D4F
		public XText(XText other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.text = other.text;
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XText" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Text" />.</returns>
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00008B71 File Offset: 0x00006D71
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Text;
			}
		}

		/// <summary>Gets or sets the value of this node.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the value of this node.</returns>
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00008B74 File Offset: 0x00006D74
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00008B7C File Offset: 0x00006D7C
		public string Value
		{
			get
			{
				return this.text;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.text = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x0600019E RID: 414 RVA: 0x00008BAE File Offset: 0x00006DAE
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (this.parent is XDocument)
			{
				writer.WriteWhitespace(this.text);
				return;
			}
			writer.WriteString(this.text);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008BE4 File Offset: 0x00006DE4
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
			if (!(this.parent is XDocument))
			{
				return writer.WriteStringAsync(this.text);
			}
			return writer.WriteWhitespaceAsync(this.text);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008C35 File Offset: 0x00006E35
		internal override void AppendText(StringBuilder sb)
		{
			sb.Append(this.text);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00008C44 File Offset: 0x00006E44
		internal override XNode CloneNode()
		{
			return new XText(this);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008C4C File Offset: 0x00006E4C
		internal override bool DeepEquals(XNode node)
		{
			return node != null && this.NodeType == node.NodeType && this.text == ((XText)node).text;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008C77 File Offset: 0x00006E77
		internal override int GetDeepHashCode()
		{
			return this.text.GetHashCode();
		}

		// Token: 0x040000E6 RID: 230
		internal string text;
	}
}
