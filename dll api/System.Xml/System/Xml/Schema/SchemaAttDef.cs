using System;

namespace System.Xml.Schema
{
	// Token: 0x020002AA RID: 682
	internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00082B14 File Offset: 0x00080D14
		public SchemaAttDef(XmlQualifiedName name, string prefix) : base(name, prefix)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00082B1E File Offset: 0x00080D1E
		public SchemaAttDef(XmlQualifiedName name) : base(name, null)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00082B28 File Offset: 0x00080D28
		private SchemaAttDef()
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00082B30 File Offset: 0x00080D30
		string IDtdAttributeInfo.Prefix
		{
			get
			{
				return this.Prefix;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00082B38 File Offset: 0x00080D38
		string IDtdAttributeInfo.LocalName
		{
			get
			{
				return this.Name.Name;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00082B45 File Offset: 0x00080D45
		int IDtdAttributeInfo.LineNumber
		{
			get
			{
				return this.LineNumber;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00082B4D File Offset: 0x00080D4D
		int IDtdAttributeInfo.LinePosition
		{
			get
			{
				return this.LinePosition;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00082B55 File Offset: 0x00080D55
		bool IDtdAttributeInfo.IsNonCDataType
		{
			get
			{
				return this.TokenizedType > XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00082B60 File Offset: 0x00080D60
		bool IDtdAttributeInfo.IsDeclaredInExternal
		{
			get
			{
				return this.IsDeclaredInExternal;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00082B68 File Offset: 0x00080D68
		bool IDtdAttributeInfo.IsXmlAttribute
		{
			get
			{
				return this.Reserved > SchemaAttDef.Reserve.None;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00082B73 File Offset: 0x00080D73
		string IDtdDefaultAttributeInfo.DefaultValueExpanded
		{
			get
			{
				return this.DefaultValueExpanded;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00082B7B File Offset: 0x00080D7B
		object IDtdDefaultAttributeInfo.DefaultValueTyped
		{
			get
			{
				return this.DefaultValueTyped;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00082B83 File Offset: 0x00080D83
		int IDtdDefaultAttributeInfo.ValueLineNumber
		{
			get
			{
				return this.ValueLineNumber;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00082B8B File Offset: 0x00080D8B
		int IDtdDefaultAttributeInfo.ValueLinePosition
		{
			get
			{
				return this.ValueLinePosition;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00082B93 File Offset: 0x00080D93
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00082B9B File Offset: 0x00080D9B
		internal int LinePosition
		{
			get
			{
				return this.linePos;
			}
			set
			{
				this.linePos = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00082BA4 File Offset: 0x00080DA4
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00082BAC File Offset: 0x00080DAC
		internal int LineNumber
		{
			get
			{
				return this.lineNum;
			}
			set
			{
				this.lineNum = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00082BB5 File Offset: 0x00080DB5
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00082BBD File Offset: 0x00080DBD
		internal int ValueLinePosition
		{
			get
			{
				return this.valueLinePos;
			}
			set
			{
				this.valueLinePos = value;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00082BC6 File Offset: 0x00080DC6
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00082BCE File Offset: 0x00080DCE
		internal int ValueLineNumber
		{
			get
			{
				return this.valueLineNum;
			}
			set
			{
				this.valueLineNum = value;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00082BD7 File Offset: 0x00080DD7
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x00082BED File Offset: 0x00080DED
		internal string DefaultValueExpanded
		{
			get
			{
				if (this.defExpanded == null)
				{
					return string.Empty;
				}
				return this.defExpanded;
			}
			set
			{
				this.defExpanded = value;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x00082BF6 File Offset: 0x00080DF6
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x00082C03 File Offset: 0x00080E03
		internal XmlTokenizedType TokenizedType
		{
			get
			{
				return base.Datatype.TokenizedType;
			}
			set
			{
				base.Datatype = XmlSchemaDatatype.FromXmlTokenizedType(value);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x00082C11 File Offset: 0x00080E11
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00082C19 File Offset: 0x00080E19
		internal SchemaAttDef.Reserve Reserved
		{
			get
			{
				return this.reserved;
			}
			set
			{
				this.reserved = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00082C22 File Offset: 0x00080E22
		internal bool DefaultValueChecked
		{
			get
			{
				return this.defaultValueChecked;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00082C2A File Offset: 0x00080E2A
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x00082C32 File Offset: 0x00080E32
		internal XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return this.schemaAttribute;
			}
			set
			{
				this.schemaAttribute = value;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00082C3C File Offset: 0x00080E3C
		internal void CheckXmlSpace(IValidationEventHandling validationEventHandling)
		{
			if (this.datatype.TokenizedType == XmlTokenizedType.ENUMERATION && this.values != null && this.values.Count <= 2)
			{
				string a = this.values[0].ToString();
				if (this.values.Count == 2)
				{
					string a2 = this.values[1].ToString();
					if ((a == "default" || a2 == "default") && (a == "preserve" || a2 == "preserve"))
					{
						return;
					}
				}
				else if (a == "default" || a == "preserve")
				{
					return;
				}
			}
			validationEventHandling.SendEvent(new XmlSchemaException("Invalid xml:space syntax.", string.Empty), XmlSeverityType.Error);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00082D0F File Offset: 0x00080F0F
		internal SchemaAttDef Clone()
		{
			return (SchemaAttDef)base.MemberwiseClone();
		}

		// Token: 0x04000E02 RID: 3586
		private string defExpanded;

		// Token: 0x04000E03 RID: 3587
		private int lineNum;

		// Token: 0x04000E04 RID: 3588
		private int linePos;

		// Token: 0x04000E05 RID: 3589
		private int valueLineNum;

		// Token: 0x04000E06 RID: 3590
		private int valueLinePos;

		// Token: 0x04000E07 RID: 3591
		private SchemaAttDef.Reserve reserved;

		// Token: 0x04000E08 RID: 3592
		private bool defaultValueChecked;

		// Token: 0x04000E09 RID: 3593
		private XmlSchemaAttribute schemaAttribute;

		// Token: 0x04000E0A RID: 3594
		public static readonly SchemaAttDef Empty = new SchemaAttDef();

		// Token: 0x020002AB RID: 683
		internal enum Reserve
		{
			// Token: 0x04000E0C RID: 3596
			None,
			// Token: 0x04000E0D RID: 3597
			XmlSpace,
			// Token: 0x04000E0E RID: 3598
			XmlLang
		}
	}
}
