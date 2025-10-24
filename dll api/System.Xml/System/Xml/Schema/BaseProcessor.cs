using System;

namespace System.Xml.Schema
{
	// Token: 0x02000227 RID: 551
	internal class BaseProcessor
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x000702C7 File Offset: 0x0006E4C7
		public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) : this(nameTable, schemaNames, eventHandler, new XmlSchemaCompilationSettings())
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000702D7 File Offset: 0x0006E4D7
		public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings)
		{
			this.nameTable = nameTable;
			this.schemaNames = schemaNames;
			this.eventHandler = eventHandler;
			this.compilationSettings = compilationSettings;
			this.NsXml = nameTable.Add("http://www.w3.org/XML/1998/namespace");
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0007030D File Offset: 0x0006E50D
		protected XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00070315 File Offset: 0x0006E515
		protected SchemaNames SchemaNames
		{
			get
			{
				if (this.schemaNames == null)
				{
					this.schemaNames = new SchemaNames(this.nameTable);
				}
				return this.schemaNames;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00070336 File Offset: 0x0006E536
		protected ValidationEventHandler EventHandler
		{
			get
			{
				return this.eventHandler;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0007033E File Offset: 0x0006E53E
		protected XmlSchemaCompilationSettings CompilationSettings
		{
			get
			{
				return this.compilationSettings;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x00070346 File Offset: 0x0006E546
		protected bool HasErrors
		{
			get
			{
				return this.errorCount != 0;
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00070354 File Offset: 0x0006E554
		protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item)
		{
			if (qname.Name.Length == 0)
			{
				return;
			}
			XmlSchemaObject xmlSchemaObject = table[qname];
			if (xmlSchemaObject == null)
			{
				table.Add(qname, item);
				return;
			}
			if (xmlSchemaObject == item)
			{
				return;
			}
			string code = "The global element '{0}' has already been declared.";
			if (item is XmlSchemaAttributeGroup)
			{
				if (Ref.Equal(this.nameTable.Add(qname.Namespace), this.NsXml))
				{
					XmlSchemaObject xmlSchemaObject2 = Preprocessor.GetBuildInSchema().AttributeGroups[qname];
					if (xmlSchemaObject == xmlSchemaObject2)
					{
						table.Insert(qname, item);
						return;
					}
					if (item == xmlSchemaObject2)
					{
						return;
					}
				}
				else if (this.IsValidAttributeGroupRedefine(xmlSchemaObject, item, table))
				{
					return;
				}
				code = "The attributeGroup '{0}' has already been declared.";
			}
			else if (item is XmlSchemaAttribute)
			{
				if (Ref.Equal(this.nameTable.Add(qname.Namespace), this.NsXml))
				{
					XmlSchemaObject xmlSchemaObject3 = Preprocessor.GetBuildInSchema().Attributes[qname];
					if (xmlSchemaObject == xmlSchemaObject3)
					{
						table.Insert(qname, item);
						return;
					}
					if (item == xmlSchemaObject3)
					{
						return;
					}
				}
				code = "The global attribute '{0}' has already been declared.";
			}
			else if (item is XmlSchemaSimpleType)
			{
				if (this.IsValidTypeRedefine(xmlSchemaObject, item, table))
				{
					return;
				}
				code = "The simpleType '{0}' has already been declared.";
			}
			else if (item is XmlSchemaComplexType)
			{
				if (this.IsValidTypeRedefine(xmlSchemaObject, item, table))
				{
					return;
				}
				code = "The complexType '{0}' has already been declared.";
			}
			else if (item is XmlSchemaGroup)
			{
				if (this.IsValidGroupRedefine(xmlSchemaObject, item, table))
				{
					return;
				}
				code = "The group '{0}' has already been declared.";
			}
			else if (item is XmlSchemaNotation)
			{
				code = "The notation '{0}' has already been declared.";
			}
			else if (item is XmlSchemaIdentityConstraint)
			{
				code = "The identity constraint '{0}' has already been declared.";
			}
			this.SendValidationEvent(code, qname.ToString(), item);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000704C4 File Offset: 0x0006E6C4
		private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			XmlSchemaAttributeGroup xmlSchemaAttributeGroup = item as XmlSchemaAttributeGroup;
			XmlSchemaAttributeGroup xmlSchemaAttributeGroup2 = existingObject as XmlSchemaAttributeGroup;
			if (xmlSchemaAttributeGroup2 == xmlSchemaAttributeGroup.Redefined)
			{
				if (xmlSchemaAttributeGroup2.AttributeUses.Count == 0)
				{
					table.Insert(xmlSchemaAttributeGroup.QualifiedName, xmlSchemaAttributeGroup);
					return true;
				}
			}
			else if (xmlSchemaAttributeGroup2.Redefined == xmlSchemaAttributeGroup)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00070510 File Offset: 0x0006E710
		private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			XmlSchemaGroup xmlSchemaGroup = item as XmlSchemaGroup;
			XmlSchemaGroup xmlSchemaGroup2 = existingObject as XmlSchemaGroup;
			if (xmlSchemaGroup2 == xmlSchemaGroup.Redefined)
			{
				if (xmlSchemaGroup2.CanonicalParticle == null)
				{
					table.Insert(xmlSchemaGroup.QualifiedName, xmlSchemaGroup);
					return true;
				}
			}
			else if (xmlSchemaGroup2.Redefined == xmlSchemaGroup)
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00070558 File Offset: 0x0006E758
		private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table)
		{
			XmlSchemaType xmlSchemaType = item as XmlSchemaType;
			XmlSchemaType xmlSchemaType2 = existingObject as XmlSchemaType;
			if (xmlSchemaType2 == xmlSchemaType.Redefined)
			{
				if (xmlSchemaType2.ElementDecl == null)
				{
					table.Insert(xmlSchemaType.QualifiedName, xmlSchemaType);
					return true;
				}
			}
			else if (xmlSchemaType2.Redefined == xmlSchemaType)
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0007059F File Offset: 0x0006E79F
		protected void SendValidationEvent(string code, XmlSchemaObject source)
		{
			this.SendValidationEvent(new XmlSchemaException(code, source), XmlSeverityType.Error);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000705AF File Offset: 0x0006E7AF
		protected void SendValidationEvent(string code, string msg, XmlSchemaObject source)
		{
			this.SendValidationEvent(new XmlSchemaException(code, msg, source), XmlSeverityType.Error);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000705C0 File Offset: 0x0006E7C0
		protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source)
		{
			this.SendValidationEvent(new XmlSchemaException(code, new string[]
			{
				msg1,
				msg2
			}, source), XmlSeverityType.Error);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000705DF File Offset: 0x0006E7DF
		protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source)
		{
			this.SendValidationEvent(new XmlSchemaException(code, args, innerException, source.SourceUri, source.LineNumber, source.LinePosition, source), XmlSeverityType.Error);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00070607 File Offset: 0x0006E807
		protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition)
		{
			this.SendValidationEvent(new XmlSchemaException(code, new string[]
			{
				msg1,
				msg2
			}, sourceUri, lineNumber, linePosition), XmlSeverityType.Error);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0007062A File Offset: 0x0006E82A
		protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, source), severity);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0007063A File Offset: 0x0006E83A
		protected void SendValidationEvent(XmlSchemaException e)
		{
			this.SendValidationEvent(e, XmlSeverityType.Error);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00070644 File Offset: 0x0006E844
		protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity)
		{
			this.SendValidationEvent(new XmlSchemaException(code, msg, source), severity);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00070656 File Offset: 0x0006E856
		protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			if (severity == XmlSeverityType.Error)
			{
				this.errorCount++;
			}
			if (this.eventHandler != null)
			{
				this.eventHandler(null, new ValidationEventArgs(e, severity));
				return;
			}
			if (severity == XmlSeverityType.Error)
			{
				throw e;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0007068A File Offset: 0x0006E88A
		protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity)
		{
			if (severity == XmlSeverityType.Error)
			{
				this.errorCount++;
			}
			if (this.eventHandler != null)
			{
				this.eventHandler(null, new ValidationEventArgs(e, severity));
			}
		}

		// Token: 0x04000C4E RID: 3150
		private XmlNameTable nameTable;

		// Token: 0x04000C4F RID: 3151
		private SchemaNames schemaNames;

		// Token: 0x04000C50 RID: 3152
		private ValidationEventHandler eventHandler;

		// Token: 0x04000C51 RID: 3153
		private XmlSchemaCompilationSettings compilationSettings;

		// Token: 0x04000C52 RID: 3154
		private int errorCount;

		// Token: 0x04000C53 RID: 3155
		private string NsXml;
	}
}
