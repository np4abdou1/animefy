using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027A RID: 634
	internal class Datatype_NOTATION : Datatype_anySimpleType
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0007636E File Offset: 0x0007456E
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.qnameFacetsChecker;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x000764BD File Offset: 0x000746BD
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Notation;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0004728D File Offset: 0x0004548D
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.NOTATION;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000764C1 File Offset: 0x000746C1
		public override Type ValueType
		{
			get
			{
				return Datatype_NOTATION.atomicValueType;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000764C8 File Offset: 0x000746C8
		internal override Type ListValueType
		{
			get
			{
				return Datatype_NOTATION.listValueType;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000764D0 File Offset: 0x000746D0
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			if (s == null || s.Length == 0)
			{
				return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
			}
			Exception ex = DatatypeImplementation.qnameFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				XmlQualifiedName xmlQualifiedName = null;
				try
				{
					string text;
					xmlQualifiedName = XmlQualifiedName.Parse(s, nsmgr, out text);
				}
				catch (ArgumentException ex)
				{
					return ex;
				}
				catch (XmlException ex)
				{
					return ex;
				}
				ex = DatatypeImplementation.qnameFacetsChecker.CheckValueFacets(xmlQualifiedName, this);
				if (ex == null)
				{
					typedValue = xmlQualifiedName;
					return null;
				}
			}
			return ex;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00076554 File Offset: 0x00074754
		internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
		{
			for (Datatype_NOTATION datatype_NOTATION = this; datatype_NOTATION != null; datatype_NOTATION = (Datatype_NOTATION)datatype_NOTATION.Base)
			{
				if (datatype_NOTATION.Restriction != null && (datatype_NOTATION.Restriction.Flags & RestrictionFlags.Enumeration) != (RestrictionFlags)0)
				{
					for (int i = 0; i < datatype_NOTATION.Restriction.Enumeration.Count; i++)
					{
						XmlQualifiedName name = (XmlQualifiedName)datatype_NOTATION.Restriction.Enumeration[i];
						if (!notations.Contains(name))
						{
							throw new XmlSchemaException("NOTATION cannot be used directly in a schema; only data types derived from NOTATION by specifying an enumeration value can be used in a schema. All enumeration facet values must match the name of a notation declared in the current schema.", caller);
						}
					}
					return;
				}
			}
			throw new XmlSchemaException("NOTATION cannot be used directly in a schema; only data types derived from NOTATION by specifying an enumeration value can be used in a schema. All enumeration facet values must match the name of a notation declared in the current schema.", caller);
		}

		// Token: 0x04000D69 RID: 3433
		private static readonly Type atomicValueType = typeof(XmlQualifiedName);

		// Token: 0x04000D6A RID: 3434
		private static readonly Type listValueType = typeof(XmlQualifiedName[]);
	}
}
