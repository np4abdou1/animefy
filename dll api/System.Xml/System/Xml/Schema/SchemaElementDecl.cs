using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema
{
	// Token: 0x020002B2 RID: 690
	internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x0008A2F4 File Offset: 0x000884F4
		internal SchemaElementDecl()
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0008A312 File Offset: 0x00088512
		internal SchemaElementDecl(XmlSchemaDatatype dtype)
		{
			base.Datatype = dtype;
			this.contentValidator = ContentValidator.TextOnly;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0008A342 File Offset: 0x00088542
		internal SchemaElementDecl(XmlQualifiedName name, string prefix) : base(name, prefix)
		{
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0008A362 File Offset: 0x00088562
		internal static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			return new SchemaElementDecl
			{
				Datatype = DatatypeImplementation.AnySimpleType.Datatype
			};
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0008A379 File Offset: 0x00088579
		bool IDtdAttributeListInfo.HasNonCDataAttributes
		{
			get
			{
				return this.hasNonCDataAttribute;
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0008A384 File Offset: 0x00088584
		IDtdAttributeInfo IDtdAttributeListInfo.LookupAttribute(string prefix, string localName)
		{
			XmlQualifiedName key = new XmlQualifiedName(localName, prefix);
			SchemaAttDef result;
			if (this.attdefs.TryGetValue(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0008A3AC File Offset: 0x000885AC
		IEnumerable<IDtdDefaultAttributeInfo> IDtdAttributeListInfo.LookupDefaultAttributes()
		{
			return this.defaultAttdefs;
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x0008A3B4 File Offset: 0x000885B4
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x0008A3BC File Offset: 0x000885BC
		internal bool IsIdDeclared
		{
			get
			{
				return this.isIdDeclared;
			}
			set
			{
				this.isIdDeclared = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0008A379 File Offset: 0x00088579
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x0008A3C5 File Offset: 0x000885C5
		internal bool HasNonCDataAttribute
		{
			get
			{
				return this.hasNonCDataAttribute;
			}
			set
			{
				this.hasNonCDataAttribute = value;
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0008A3CE File Offset: 0x000885CE
		internal SchemaElementDecl Clone()
		{
			return (SchemaElementDecl)base.MemberwiseClone();
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0008A3DB File Offset: 0x000885DB
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x0008A3E3 File Offset: 0x000885E3
		internal bool IsAbstract
		{
			get
			{
				return this.isAbstract;
			}
			set
			{
				this.isAbstract = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0008A3EC File Offset: 0x000885EC
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x0008A3F4 File Offset: 0x000885F4
		internal bool IsNillable
		{
			get
			{
				return this.isNillable;
			}
			set
			{
				this.isNillable = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0008A3FD File Offset: 0x000885FD
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x0008A405 File Offset: 0x00088605
		internal XmlSchemaDerivationMethod Block
		{
			get
			{
				return this.block;
			}
			set
			{
				this.block = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x0008A40E File Offset: 0x0008860E
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x0008A416 File Offset: 0x00088616
		internal bool IsNotationDeclared
		{
			get
			{
				return this.isNotationDeclared;
			}
			set
			{
				this.isNotationDeclared = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0008A41F File Offset: 0x0008861F
		internal bool HasDefaultAttribute
		{
			get
			{
				return this.defaultAttdefs != null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x0008A42A File Offset: 0x0008862A
		internal bool HasRequiredAttribute
		{
			get
			{
				return this.hasRequiredAttribute;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x0008A432 File Offset: 0x00088632
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x0008A43A File Offset: 0x0008863A
		internal ContentValidator ContentValidator
		{
			get
			{
				return this.contentValidator;
			}
			set
			{
				this.contentValidator = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0008A443 File Offset: 0x00088643
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x0008A44B File Offset: 0x0008864B
		internal XmlSchemaAnyAttribute AnyAttribute
		{
			get
			{
				return this.anyAttribute;
			}
			set
			{
				this.anyAttribute = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x0008A454 File Offset: 0x00088654
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x0008A45C File Offset: 0x0008865C
		internal CompiledIdentityConstraint[] Constraints
		{
			get
			{
				return this.constraints;
			}
			set
			{
				this.constraints = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x0008A465 File Offset: 0x00088665
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x0008A46D File Offset: 0x0008866D
		internal XmlSchemaElement SchemaElement
		{
			get
			{
				return this.schemaElement;
			}
			set
			{
				this.schemaElement = value;
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0008A478 File Offset: 0x00088678
		internal void AddAttDef(SchemaAttDef attdef)
		{
			this.attdefs.Add(attdef.Name, attdef);
			if (attdef.Presence == SchemaDeclBase.Use.Required || attdef.Presence == SchemaDeclBase.Use.RequiredFixed)
			{
				this.hasRequiredAttribute = true;
			}
			if (attdef.Presence == SchemaDeclBase.Use.Default || attdef.Presence == SchemaDeclBase.Use.Fixed)
			{
				if (this.defaultAttdefs == null)
				{
					this.defaultAttdefs = new List<IDtdDefaultAttributeInfo>();
				}
				this.defaultAttdefs.Add(attdef);
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0008A4E0 File Offset: 0x000886E0
		internal SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			SchemaAttDef result;
			if (this.attdefs.TryGetValue(qname, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x0008A3AC File Offset: 0x000885AC
		internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			get
			{
				return this.defaultAttdefs;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0008A500 File Offset: 0x00088700
		internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			get
			{
				return this.attdefs;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x0008A508 File Offset: 0x00088708
		internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
		{
			get
			{
				return this.prohibitedAttributes;
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0008A510 File Offset: 0x00088710
		internal void CheckAttributes(Hashtable presence, bool standalone)
		{
			foreach (SchemaAttDef schemaAttDef in this.attdefs.Values)
			{
				if (presence[schemaAttDef.Name] == null)
				{
					if (schemaAttDef.Presence == SchemaDeclBase.Use.Required)
					{
						throw new XmlSchemaException("The required attribute '{0}' is missing.", schemaAttDef.Name.ToString());
					}
					if (standalone && schemaAttDef.IsDeclaredInExternal && (schemaAttDef.Presence == SchemaDeclBase.Use.Default || schemaAttDef.Presence == SchemaDeclBase.Use.Fixed))
					{
						throw new XmlSchemaException("The standalone document declaration must have a value of 'no'.", string.Empty);
					}
				}
			}
		}

		// Token: 0x04000E33 RID: 3635
		private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs = new Dictionary<XmlQualifiedName, SchemaAttDef>();

		// Token: 0x04000E34 RID: 3636
		private List<IDtdDefaultAttributeInfo> defaultAttdefs;

		// Token: 0x04000E35 RID: 3637
		private bool isIdDeclared;

		// Token: 0x04000E36 RID: 3638
		private bool hasNonCDataAttribute;

		// Token: 0x04000E37 RID: 3639
		private bool isAbstract;

		// Token: 0x04000E38 RID: 3640
		private bool isNillable;

		// Token: 0x04000E39 RID: 3641
		private bool hasRequiredAttribute;

		// Token: 0x04000E3A RID: 3642
		private bool isNotationDeclared;

		// Token: 0x04000E3B RID: 3643
		private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes = new Dictionary<XmlQualifiedName, XmlQualifiedName>();

		// Token: 0x04000E3C RID: 3644
		private ContentValidator contentValidator;

		// Token: 0x04000E3D RID: 3645
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04000E3E RID: 3646
		private XmlSchemaDerivationMethod block;

		// Token: 0x04000E3F RID: 3647
		private CompiledIdentityConstraint[] constraints;

		// Token: 0x04000E40 RID: 3648
		private XmlSchemaElement schemaElement;

		// Token: 0x04000E41 RID: 3649
		internal static readonly SchemaElementDecl Empty = new SchemaElementDecl();
	}
}
