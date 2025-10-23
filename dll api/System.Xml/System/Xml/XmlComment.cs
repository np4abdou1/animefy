using System;

namespace System.Xml
{
	/// <summary>Represents the content of an XML comment.</summary>
	// Token: 0x0200013A RID: 314
	public class XmlComment : XmlCharacterData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlComment" /> class.</summary>
		/// <param name="comment">The content of the comment element.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000AAC RID: 2732 RVA: 0x00046FE8 File Offset: 0x000451E8
		protected internal XmlComment(string comment, XmlDocument doc) : base(comment, doc)
		{
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For comment nodes, the value is <see langword="#comment" />.</returns>
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00047280 File Offset: 0x00045480
		public override string Name
		{
			get
			{
				return this.OwnerDocument.strCommentName;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For comment nodes, the value is <see langword="#comment" />.</returns>
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00047280 File Offset: 0x00045480
		public override string LocalName
		{
			get
			{
				return this.OwnerDocument.strCommentName;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For comment nodes, the value is XmlNodeType.Comment.</returns>
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0004728D File Offset: 0x0004548D
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Comment;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. Because comment nodes do not have children, the cloned node always includes the text content, regardless of the parameter setting. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000AB0 RID: 2736 RVA: 0x00047290 File Offset: 0x00045490
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateComment(this.Data);
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000AB1 RID: 2737 RVA: 0x000472A3 File Offset: 0x000454A3
		public override void WriteTo(XmlWriter w)
		{
			w.WriteComment(this.Data);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. Because comment nodes do not have children, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000AB2 RID: 2738 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}
	}
}
