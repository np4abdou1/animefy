using System;

namespace System.Xml.Schema
{
	// Token: 0x02000226 RID: 550
	internal class AutoValidator : BaseValidator
	{
		// Token: 0x0600121A RID: 4634 RVA: 0x00070089 File Offset: 0x0006E289
		public AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) : base(reader, schemaCollection, eventHandling)
		{
			this.schemaInfo = new SchemaInfo();
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool PreserveWhitespace
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000700A0 File Offset: 0x0006E2A0
		public override void Validate()
		{
			switch (this.DetectValidationType())
			{
			case ValidationType.Auto:
			case ValidationType.DTD:
				break;
			case ValidationType.XDR:
				this.reader.Validator = new XdrValidator(this);
				this.reader.Validator.Validate();
				return;
			case ValidationType.Schema:
				this.reader.Validator = new XsdValidator(this);
				this.reader.Validator.Validate();
				break;
			default:
				return;
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00008574 File Offset: 0x00006774
		public override void CompleteValidation()
		{
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0001520A File Offset: 0x0001340A
		public override object FindId(string name)
		{
			return null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00070110 File Offset: 0x0006E310
		private ValidationType DetectValidationType()
		{
			if (this.reader.Schemas != null && this.reader.Schemas.Count > 0)
			{
				XmlSchemaCollectionEnumerator enumerator = this.reader.Schemas.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SchemaInfo schemaInfo = enumerator.CurrentNode.SchemaInfo;
					if (schemaInfo.SchemaType == SchemaType.XSD)
					{
						return ValidationType.Schema;
					}
					if (schemaInfo.SchemaType == SchemaType.XDR)
					{
						return ValidationType.XDR;
					}
				}
			}
			if (this.reader.NodeType == XmlNodeType.Element)
			{
				SchemaType schemaType = base.SchemaNames.SchemaTypeFromRoot(this.reader.LocalName, this.reader.NamespaceURI);
				if (schemaType == SchemaType.XSD)
				{
					return ValidationType.Schema;
				}
				if (schemaType == SchemaType.XDR)
				{
					return ValidationType.XDR;
				}
				int attributeCount = this.reader.AttributeCount;
				for (int i = 0; i < attributeCount; i++)
				{
					this.reader.MoveToAttribute(i);
					string namespaceURI = this.reader.NamespaceURI;
					string localName = this.reader.LocalName;
					if (Ref.Equal(namespaceURI, base.SchemaNames.NsXmlNs))
					{
						if (XdrBuilder.IsXdrSchema(this.reader.Value))
						{
							this.reader.MoveToElement();
							return ValidationType.XDR;
						}
					}
					else
					{
						if (Ref.Equal(namespaceURI, base.SchemaNames.NsXsi))
						{
							this.reader.MoveToElement();
							return ValidationType.Schema;
						}
						if (Ref.Equal(namespaceURI, base.SchemaNames.QnDtDt.Namespace) && Ref.Equal(localName, base.SchemaNames.QnDtDt.Name))
						{
							this.reader.SchemaTypeObject = XmlSchemaDatatype.FromXdrName(this.reader.Value);
							this.reader.MoveToElement();
							return ValidationType.XDR;
						}
					}
				}
				if (attributeCount > 0)
				{
					this.reader.MoveToElement();
				}
			}
			return ValidationType.Auto;
		}
	}
}
