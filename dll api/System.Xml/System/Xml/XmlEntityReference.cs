﻿using System;

namespace System.Xml
{
	/// <summary>Represents an entity reference node.</summary>
	// Token: 0x02000142 RID: 322
	public class XmlEntityReference : XmlLinkedNode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlEntityReference" /> class.</summary>
		/// <param name="name">The name of the entity reference; see the <see cref="P:System.Xml.XmlEntityReference.Name" /> property.</param>
		/// <param name="doc">The parent XML document.</param>
		// Token: 0x06000B87 RID: 2951 RVA: 0x00049498 File Offset: 0x00047698
		protected internal XmlEntityReference(string name, XmlDocument doc) : base(doc)
		{
			if (!doc.IsLoading && name.Length > 0 && name[0] == '#')
			{
				throw new ArgumentException(Res.GetString("Cannot create an 'EntityReference' node with a name starting with '#'."));
			}
			this.name = doc.NameTable.Add(name);
			doc.fEntRefNodesPresent = true;
		}

		/// <summary>Gets the name of the node.</summary>
		/// <returns>The name of the entity referenced.</returns>
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x000494F1 File Offset: 0x000476F1
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the local name of the node.</summary>
		/// <returns>For <see langword="XmlEntityReference" /> nodes, this property returns the name of the entity referenced.</returns>
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000494F1 File Offset: 0x000476F1
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets or sets the value of the node.</summary>
		/// <returns>The value of the node. For <see langword="XmlEntityReference" /> nodes, this property returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Node is read-only. </exception>
		/// <exception cref="T:System.InvalidOperationException">Setting the property. </exception>
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0001520A File Offset: 0x0001340A
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000494F9 File Offset: 0x000476F9
		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("'EntityReference' nodes have no support for setting value."));
			}
		}

		/// <summary>Gets the type of the node.</summary>
		/// <returns>The node type. For <see langword="XmlEntityReference" /> nodes, the value is XmlNodeType.EntityReference.</returns>
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0004950A File Offset: 0x0004770A
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.EntityReference;
			}
		}

		/// <summary>Creates a duplicate of this node.</summary>
		/// <param name="deep">
		///       <see langword="true" /> to recursively clone the subtree under the specified node; <see langword="false" /> to clone only the node itself. For <see langword="XmlEntityReference" /> nodes, this method always returns an entity reference node with no children. The replacement text is set when the node is inserted into a parent. </param>
		/// <returns>The cloned node.</returns>
		// Token: 0x06000B8D RID: 2957 RVA: 0x0004950D File Offset: 0x0004770D
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateEntityReference(this.name);
		}

		/// <summary>Gets a value indicating whether the node is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the node is read-only; otherwise <see langword="false" />.Because <see langword="XmlEntityReference" /> nodes are read-only, this property always returns <see langword="true" />.</returns>
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00049520 File Offset: 0x00047720
		internal override void SetParent(XmlNode node)
		{
			base.SetParent(node);
			if (this.LastNode == null && node != null && node != this.OwnerDocument)
			{
				new XmlLoader().ExpandEntityReference(this);
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00049548 File Offset: 0x00047748
		internal override void SetParentForLoad(XmlNode node)
		{
			this.SetParent(node);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00049551 File Offset: 0x00047751
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x00049559 File Offset: 0x00047759
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00049564 File Offset: 0x00047764
		internal override bool IsValidChildType(XmlNodeType type)
		{
			switch (type)
			{
			case XmlNodeType.Element:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.EntityReference:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Comment:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				return true;
			}
			return false;
		}

		/// <summary>Saves the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B95 RID: 2965 RVA: 0x000495B6 File Offset: 0x000477B6
		public override void WriteTo(XmlWriter w)
		{
			w.WriteEntityRef(this.name);
		}

		/// <summary>Saves all the children of the node to the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="w">The <see langword="XmlWriter" /> to which you want to save. </param>
		// Token: 0x06000B96 RID: 2966 RVA: 0x000495C4 File Offset: 0x000477C4
		public override void WriteContentTo(XmlWriter w)
		{
			foreach (object obj in this)
			{
				((XmlNode)obj).WriteTo(w);
			}
		}

		/// <summary>Gets the base Uniform Resource Identifier (URI) of the current node.</summary>
		/// <returns>The location from which the node was loaded.</returns>
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00049618 File Offset: 0x00047818
		public override string BaseURI
		{
			get
			{
				return this.OwnerDocument.BaseURI;
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00049628 File Offset: 0x00047828
		private string ConstructBaseURI(string baseURI, string systemId)
		{
			if (baseURI == null)
			{
				return systemId;
			}
			int num = baseURI.LastIndexOf('/') + 1;
			string str = baseURI;
			if (num > 0 && num < baseURI.Length)
			{
				str = baseURI.Substring(0, num);
			}
			else if (num == 0)
			{
				str += "\\";
			}
			return str + systemId.Replace('\\', '/');
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00049680 File Offset: 0x00047880
		internal string ChildBaseURI
		{
			get
			{
				XmlEntity entityNode = this.OwnerDocument.GetEntityNode(this.name);
				if (entityNode == null)
				{
					return string.Empty;
				}
				if (entityNode.SystemId != null && entityNode.SystemId.Length > 0)
				{
					return this.ConstructBaseURI(entityNode.BaseURI, entityNode.SystemId);
				}
				return entityNode.BaseURI;
			}
		}

		// Token: 0x040008AC RID: 2220
		private string name;

		// Token: 0x040008AD RID: 2221
		private XmlLinkedNode lastChild;
	}
}
