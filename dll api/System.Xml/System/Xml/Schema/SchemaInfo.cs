using System;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x020002B5 RID: 693
	internal class SchemaInfo : IDtdInfo
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x0008A794 File Offset: 0x00088994
		internal SchemaInfo()
		{
			this.schemaType = SchemaType.None;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x0008A7FB File Offset: 0x000889FB
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x0008A803 File Offset: 0x00088A03
		public XmlQualifiedName DocTypeName
		{
			get
			{
				return this.docTypeName;
			}
			set
			{
				this.docTypeName = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x0008A80C File Offset: 0x00088A0C
		internal string InternalDtdSubset
		{
			set
			{
				this.internalDtdSubset = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0008A815 File Offset: 0x00088A15
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			get
			{
				return this.elementDecls;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0008A81D File Offset: 0x00088A1D
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			get
			{
				return this.undeclaredElementDecls;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0008A825 File Offset: 0x00088A25
		internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			get
			{
				if (this.generalEntities == null)
				{
					this.generalEntities = new Dictionary<XmlQualifiedName, SchemaEntity>();
				}
				return this.generalEntities;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x0008A840 File Offset: 0x00088A40
		internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			get
			{
				if (this.parameterEntities == null)
				{
					this.parameterEntities = new Dictionary<XmlQualifiedName, SchemaEntity>();
				}
				return this.parameterEntities;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0008A85B File Offset: 0x00088A5B
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0008A863 File Offset: 0x00088A63
		internal SchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
			set
			{
				this.schemaType = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0008A86C File Offset: 0x00088A6C
		internal Dictionary<string, bool> TargetNamespaces
		{
			get
			{
				return this.targetNamespaces;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0008A874 File Offset: 0x00088A74
		internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
		{
			get
			{
				return this.elementDeclsByType;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0008A87C File Offset: 0x00088A7C
		internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
		{
			get
			{
				return this.attributeDecls;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0008A884 File Offset: 0x00088A84
		internal Dictionary<string, SchemaNotation> Notations
		{
			get
			{
				if (this.notations == null)
				{
					this.notations = new Dictionary<string, SchemaNotation>();
				}
				return this.notations;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x0008A89F File Offset: 0x00088A9F
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0008A8A7 File Offset: 0x00088AA7
		internal int ErrorCount
		{
			get
			{
				return this.errorCount;
			}
			set
			{
				this.errorCount = value;
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0008A8B0 File Offset: 0x00088AB0
		internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname)
		{
			SchemaElementDecl result;
			if (this.elementDecls.TryGetValue(qname, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0008A8D0 File Offset: 0x00088AD0
		internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname)
		{
			SchemaElementDecl result;
			if (this.elementDeclsByType.TryGetValue(qname, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0008A8F0 File Offset: 0x00088AF0
		internal XmlSchemaElement GetElement(XmlQualifiedName qname)
		{
			SchemaElementDecl elementDecl = this.GetElementDecl(qname);
			if (elementDecl != null)
			{
				return elementDecl.SchemaElement;
			}
			return null;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0008A910 File Offset: 0x00088B10
		internal bool HasSchema(string ns)
		{
			return this.targetNamespaces.ContainsKey(ns);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0008A910 File Offset: 0x00088B10
		internal bool Contains(string ns)
		{
			return this.targetNamespaces.ContainsKey(ns);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0008A920 File Offset: 0x00088B20
		internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname)
		{
			SchemaAttDef schemaAttDef = null;
			if (ed != null)
			{
				schemaAttDef = ed.GetAttDef(qname);
				if (schemaAttDef == null)
				{
					if (!ed.ContentValidator.IsOpen || qname.Namespace.Length == 0)
					{
						throw new XmlSchemaException("The '{0}' attribute is not declared.", qname.ToString());
					}
					if (!this.attributeDecls.TryGetValue(qname, out schemaAttDef) && this.targetNamespaces.ContainsKey(qname.Namespace))
					{
						throw new XmlSchemaException("The '{0}' attribute is not declared.", qname.ToString());
					}
				}
			}
			return schemaAttDef;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0008A9A0 File Offset: 0x00088BA0
		internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState)
		{
			SchemaAttDef schemaAttDef = null;
			attributeMatchState = AttributeMatchState.UndeclaredAttribute;
			if (ed != null)
			{
				schemaAttDef = ed.GetAttDef(qname);
				if (schemaAttDef != null)
				{
					attributeMatchState = AttributeMatchState.AttributeFound;
					return schemaAttDef;
				}
				XmlSchemaAnyAttribute anyAttribute = ed.AnyAttribute;
				if (anyAttribute != null)
				{
					if (!anyAttribute.NamespaceList.Allows(qname))
					{
						attributeMatchState = AttributeMatchState.ProhibitedAnyAttribute;
					}
					else if (anyAttribute.ProcessContentsCorrect != XmlSchemaContentProcessing.Skip)
					{
						if (this.attributeDecls.TryGetValue(qname, out schemaAttDef))
						{
							if (schemaAttDef.Datatype.TypeCode == XmlTypeCode.Id)
							{
								attributeMatchState = AttributeMatchState.AnyIdAttributeFound;
							}
							else
							{
								attributeMatchState = AttributeMatchState.AttributeFound;
							}
						}
						else if (anyAttribute.ProcessContentsCorrect == XmlSchemaContentProcessing.Lax)
						{
							attributeMatchState = AttributeMatchState.AnyAttributeLax;
						}
					}
					else
					{
						attributeMatchState = AttributeMatchState.AnyAttributeSkip;
					}
				}
				else if (ed.ProhibitedAttributes.ContainsKey(qname))
				{
					attributeMatchState = AttributeMatchState.ProhibitedAttribute;
				}
			}
			else if (partialValidationType != null)
			{
				XmlSchemaAttribute xmlSchemaAttribute = partialValidationType as XmlSchemaAttribute;
				if (xmlSchemaAttribute != null)
				{
					if (qname.Equals(xmlSchemaAttribute.QualifiedName))
					{
						schemaAttDef = xmlSchemaAttribute.AttDef;
						attributeMatchState = AttributeMatchState.AttributeFound;
					}
					else
					{
						attributeMatchState = AttributeMatchState.AttributeNameMismatch;
					}
				}
				else
				{
					attributeMatchState = AttributeMatchState.ValidateAttributeInvalidCall;
				}
			}
			else if (this.attributeDecls.TryGetValue(qname, out schemaAttDef))
			{
				attributeMatchState = AttributeMatchState.AttributeFound;
			}
			else
			{
				attributeMatchState = AttributeMatchState.UndeclaredElementAndAttribute;
			}
			return schemaAttDef;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0008AA98 File Offset: 0x00088C98
		internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip)
		{
			AttributeMatchState attributeMatchState;
			SchemaAttDef attributeXsd = this.GetAttributeXsd(ed, qname, null, out attributeMatchState);
			switch (attributeMatchState)
			{
			case AttributeMatchState.UndeclaredAttribute:
				throw new XmlSchemaException("The '{0}' attribute is not declared.", qname.ToString());
			case AttributeMatchState.AnyAttributeSkip:
				skip = true;
				break;
			case AttributeMatchState.ProhibitedAnyAttribute:
			case AttributeMatchState.ProhibitedAttribute:
				throw new XmlSchemaException("The '{0}' attribute is not allowed.", qname.ToString());
			}
			return attributeXsd;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0008AB00 File Offset: 0x00088D00
		internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler)
		{
			if (this.schemaType == SchemaType.None)
			{
				this.schemaType = sinfo.SchemaType;
			}
			else if (this.schemaType != sinfo.SchemaType)
			{
				if (eventhandler != null)
				{
					eventhandler(this, new ValidationEventArgs(new XmlSchemaException("Different schema types cannot be mixed.", string.Empty)));
				}
				return;
			}
			foreach (string key in sinfo.TargetNamespaces.Keys)
			{
				if (!this.targetNamespaces.ContainsKey(key))
				{
					this.targetNamespaces.Add(key, true);
				}
			}
			foreach (KeyValuePair<XmlQualifiedName, SchemaElementDecl> keyValuePair in sinfo.elementDecls)
			{
				if (!this.elementDecls.ContainsKey(keyValuePair.Key))
				{
					this.elementDecls.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			foreach (KeyValuePair<XmlQualifiedName, SchemaElementDecl> keyValuePair2 in sinfo.elementDeclsByType)
			{
				if (!this.elementDeclsByType.ContainsKey(keyValuePair2.Key))
				{
					this.elementDeclsByType.Add(keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			foreach (SchemaAttDef schemaAttDef in sinfo.AttributeDecls.Values)
			{
				if (!this.attributeDecls.ContainsKey(schemaAttDef.Name))
				{
					this.attributeDecls.Add(schemaAttDef.Name, schemaAttDef);
				}
			}
			foreach (SchemaNotation schemaNotation in sinfo.Notations.Values)
			{
				if (!this.Notations.ContainsKey(schemaNotation.Name.Name))
				{
					this.Notations.Add(schemaNotation.Name.Name, schemaNotation);
				}
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0008AD60 File Offset: 0x00088F60
		internal void Finish()
		{
			Dictionary<XmlQualifiedName, SchemaElementDecl> dictionary = this.elementDecls;
			for (int i = 0; i < 2; i++)
			{
				foreach (SchemaElementDecl schemaElementDecl in dictionary.Values)
				{
					if (schemaElementDecl.HasNonCDataAttribute)
					{
						this.hasNonCDataAttributes = true;
					}
					if (schemaElementDecl.DefaultAttDefs != null)
					{
						this.hasDefaultAttributes = true;
					}
				}
				dictionary = this.undeclaredElementDecls;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		bool IDtdInfo.HasDefaultAttributes
		{
			get
			{
				return this.hasDefaultAttributes;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0008ADEC File Offset: 0x00088FEC
		bool IDtdInfo.HasNonCDataAttributes
		{
			get
			{
				return this.hasNonCDataAttributes;
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0008ADF4 File Offset: 0x00088FF4
		IDtdAttributeListInfo IDtdInfo.LookupAttributeList(string prefix, string localName)
		{
			XmlQualifiedName key = new XmlQualifiedName(prefix, localName);
			SchemaElementDecl result;
			if (!this.elementDecls.TryGetValue(key, out result))
			{
				this.undeclaredElementDecls.TryGetValue(key, out result);
			}
			return result;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0008AE2C File Offset: 0x0008902C
		IDtdEntityInfo IDtdInfo.LookupEntity(string name)
		{
			if (this.generalEntities == null)
			{
				return null;
			}
			XmlQualifiedName key = new XmlQualifiedName(name);
			SchemaEntity result;
			if (this.generalEntities.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x0008A7FB File Offset: 0x000889FB
		XmlQualifiedName IDtdInfo.Name
		{
			get
			{
				return this.docTypeName;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0008AE5D File Offset: 0x0008905D
		string IDtdInfo.InternalDtdSubset
		{
			get
			{
				return this.internalDtdSubset;
			}
		}

		// Token: 0x04000E5A RID: 3674
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls = new Dictionary<XmlQualifiedName, SchemaElementDecl>();

		// Token: 0x04000E5B RID: 3675
		private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls = new Dictionary<XmlQualifiedName, SchemaElementDecl>();

		// Token: 0x04000E5C RID: 3676
		private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities;

		// Token: 0x04000E5D RID: 3677
		private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities;

		// Token: 0x04000E5E RID: 3678
		private XmlQualifiedName docTypeName = XmlQualifiedName.Empty;

		// Token: 0x04000E5F RID: 3679
		private string internalDtdSubset = string.Empty;

		// Token: 0x04000E60 RID: 3680
		private bool hasNonCDataAttributes;

		// Token: 0x04000E61 RID: 3681
		private bool hasDefaultAttributes;

		// Token: 0x04000E62 RID: 3682
		private Dictionary<string, bool> targetNamespaces = new Dictionary<string, bool>();

		// Token: 0x04000E63 RID: 3683
		private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls = new Dictionary<XmlQualifiedName, SchemaAttDef>();

		// Token: 0x04000E64 RID: 3684
		private int errorCount;

		// Token: 0x04000E65 RID: 3685
		private SchemaType schemaType;

		// Token: 0x04000E66 RID: 3686
		private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType = new Dictionary<XmlQualifiedName, SchemaElementDecl>();

		// Token: 0x04000E67 RID: 3687
		private Dictionary<string, SchemaNotation> notations;
	}
}
