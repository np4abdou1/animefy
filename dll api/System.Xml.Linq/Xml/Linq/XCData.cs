using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents a text node that contains CDATA. </summary>
	// Token: 0x02000007 RID: 7
	public class XCData : XText
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XCData" /> class. </summary>
		/// <param name="value">A string that contains the value of the <see cref="T:System.Xml.Linq.XCData" /> node.</param>
		// Token: 0x06000012 RID: 18 RVA: 0x000023D3 File Offset: 0x000005D3
		public XCData(string value) : base(value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XCData" /> class. </summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XCData" /> node to copy from.</param>
		// Token: 0x06000013 RID: 19 RVA: 0x000023DC File Offset: 0x000005DC
		public XCData(XCData other) : base(other)
		{
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XCData" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.CDATA" />.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000023E5 File Offset: 0x000005E5
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.CDATA;
			}
		}

		/// <summary>Writes this CDATA object to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x06000015 RID: 21 RVA: 0x000023E8 File Offset: 0x000005E8
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteCData(this.text);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002404 File Offset: 0x00000604
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
			return writer.WriteCDataAsync(this.text);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002430 File Offset: 0x00000630
		internal override XNode CloneNode()
		{
			return new XCData(this);
		}
	}
}
