using System;

namespace System.Xml
{
	/// <summary>Represents a processing instruction, which XML defines to keep processor-specific information in the text of the document.</summary>
	// Token: 0x02000154 RID: 340
	public class XmlProcessingInstruction : XmlLinkedNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlProcessingInstruction" /> class.</summary>
		/// <param name="target">The target of the processing instruction; see the <see cref="P:System.Xml.XmlProcessingInstruction.Target" /> property.</param>
		/// <param name="data">The content of the instruction; see the <see cref="P:System.Xml.XmlProcessingInstruction.Data" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000CAA RID: 3242 RVA: 0x0004E6BA File Offset: 0x0004C8BA
		protected internal XmlProcessingInstruction(string target, string data, XmlDocument doc) : base(doc)
		{
			this.target = target;
			this.data = data;
		}

		/// <summary>Gets the qualified name of the node.</summary>
		/// <returns>For processing instruction nodes, this property returns the target of the processing instruction.</returns>
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0004E6D1 File Offset: 0x0004C8D1
		public override string Name
		{
			get
			{
				if (this.target != null)
				{
					return this.target;
				}
				return string.Empty;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For processing instruction nodes, this property returns the target of the processing instruction.</returns>
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00047503 File Offset: 0x00045703
		public override string LocalName
		{
			get
			{
				return this.Name;
			}
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The entire content of the processing instruction, excluding the target.</returns>
		/// <exception cref="T:System.ArgumentException">Node is read-only. </exception>
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0004E6E7 File Offset: 0x0004C8E7
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0004E6EF File Offset: 0x0004C8EF
		public override string Value
		{
			get
			{
				return this.data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>Gets or sets the content of the processing instruction, excluding the target.</summary>
		/// <returns>The content of the processing instruction, excluding the target.</returns>
		// Token: 0x1700029D RID: 669
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x0004E6F8 File Offset: 0x0004C8F8
		public string Data
		{
			set
			{
				XmlNode parentNode = this.ParentNode;
				XmlNodeChangedEventArgs eventArgs = this.GetEventArgs(this, parentNode, parentNode, this.data, value, XmlNodeChangedAction.Change);
				if (eventArgs != null)
				{
					this.BeforeEvent(eventArgs);
				}
				this.data = value;
				if (eventArgs != null)
				{
					this.AfterEvent(eventArgs);
				}
			}
		}

		/// <summary>Gets or sets the concatenated values of the node and all its children.</summary>
		/// <returns>The concatenated values of the node and all its children.</returns>
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0004E6E7 File Offset: 0x0004C8E7
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x0004E6EF File Offset: 0x0004C8EF
		public override string InnerText
		{
			get
			{
				return this.data;
			}
			set
			{
				this.Data = value;
			}
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>For <see langword="XmlProcessingInstruction" /> nodes, this value is XmlNodeType.ProcessingInstruction.</returns>
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0004E739 File Offset: 0x0004C939
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.ProcessingInstruction;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. </param>
		/// <returns>The duplicate node.</returns>
		// Token: 0x06000CB3 RID: 3251 RVA: 0x0004E73C File Offset: 0x0004C93C
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateProcessingInstruction(this.target, this.data);
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CB4 RID: 3252 RVA: 0x0004E755 File Offset: 0x0004C955
		public override void WriteTo(XmlWriter w)
		{
			w.WriteProcessingInstruction(this.target, this.data);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />. Because ProcessingInstruction nodes do not have children, this method has no effect.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000CB5 RID: 3253 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x040008ED RID: 2285
		private string target;

		// Token: 0x040008EE RID: 2286
		private string data;
	}
}
