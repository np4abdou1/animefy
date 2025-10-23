using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	// Token: 0x0200020D RID: 525
	internal class XmlTypeMapElementInfo
	{
		// Token: 0x06001159 RID: 4441 RVA: 0x0006D7E4 File Offset: 0x0006B9E4
		public XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type)
		{
			this._member = member;
			this._type = type;
			if (type.IsValueType && type.IsNullable)
			{
				this._isNullable = true;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0006D835 File Offset: 0x0006BA35
		public TypeData TypeData
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0006D83D File Offset: 0x0006BA3D
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0006D845 File Offset: 0x0006BA45
		public object ChoiceValue
		{
			get
			{
				return this._choiceValue;
			}
			set
			{
				this._choiceValue = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0006D84E File Offset: 0x0006BA4E
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0006D856 File Offset: 0x0006BA56
		public string ElementName
		{
			get
			{
				return this._elementName;
			}
			set
			{
				this._elementName = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0006D85F File Offset: 0x0006BA5F
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0006D867 File Offset: 0x0006BA67
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				this._namespace = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0006D870 File Offset: 0x0006BA70
		public string DataTypeNamespace
		{
			get
			{
				if (this._mappedType == null)
				{
					return "http://www.w3.org/2001/XMLSchema";
				}
				return this._mappedType.XmlTypeNamespace;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0006D88B File Offset: 0x0006BA8B
		public string DataTypeName
		{
			get
			{
				if (this._mappedType == null)
				{
					return this.TypeData.XmlType;
				}
				return this._mappedType.XmlType;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0006D8AC File Offset: 0x0006BAAC
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0006D8B4 File Offset: 0x0006BAB4
		public XmlSchemaForm Form
		{
			get
			{
				return this._form;
			}
			set
			{
				this._form = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0006D8BD File Offset: 0x0006BABD
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x0006D8C5 File Offset: 0x0006BAC5
		public XmlTypeMapping MappedType
		{
			get
			{
				return this._mappedType;
			}
			set
			{
				this._mappedType = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0006D8CE File Offset: 0x0006BACE
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0006D8D6 File Offset: 0x0006BAD6
		public bool IsNullable
		{
			get
			{
				return this._isNullable;
			}
			set
			{
				this._isNullable = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0006D8DF File Offset: 0x0006BADF
		public XmlTypeMapMember Member
		{
			get
			{
				return this._member;
			}
		}

		// Token: 0x17000370 RID: 880
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0006D8E7 File Offset: 0x0006BAE7
		public int NestingLevel
		{
			set
			{
				this._nestingLevel = value;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		public bool MultiReferenceType
		{
			get
			{
				return this._mappedType != null && this._mappedType.MultiReferenceType;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0006D907 File Offset: 0x0006BB07
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0006D90F File Offset: 0x0006BB0F
		public bool WrappedElement
		{
			get
			{
				return this._wrappedElement;
			}
			set
			{
				this._wrappedElement = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0006D918 File Offset: 0x0006BB18
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x0006D92A File Offset: 0x0006BB2A
		public bool IsTextElement
		{
			get
			{
				return this.ElementName == "<text>";
			}
			set
			{
				if (!value)
				{
					throw new Exception("INTERNAL ERROR; someone wrote unexpected code in sys.xml");
				}
				this.ElementName = "<text>";
				this.Namespace = string.Empty;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0006D950 File Offset: 0x0006BB50
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x0006D962 File Offset: 0x0006BB62
		public bool IsUnnamedAnyElement
		{
			get
			{
				return this.ElementName == string.Empty;
			}
			set
			{
				if (!value)
				{
					throw new Exception("INTERNAL ERROR; someone wrote unexpected code in sys.xml");
				}
				this.ElementName = string.Empty;
				this.Namespace = string.Empty;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0006D988 File Offset: 0x0006BB88
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x0006D990 File Offset: 0x0006BB90
		public int ExplicitOrder
		{
			get
			{
				return this._explicitOrder;
			}
			set
			{
				this._explicitOrder = value;
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0006D99C File Offset: 0x0006BB9C
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)other;
			return !(this._elementName != xmlTypeMapElementInfo._elementName) && !(this._type.XmlType != xmlTypeMapElementInfo._type.XmlType) && !(this._namespace != xmlTypeMapElementInfo._namespace) && this._form == xmlTypeMapElementInfo._form && this._type == xmlTypeMapElementInfo._type && this._isNullable == xmlTypeMapElementInfo._isNullable && (this._choiceValue == null || this._choiceValue.Equals(xmlTypeMapElementInfo._choiceValue)) && this._choiceValue == xmlTypeMapElementInfo._choiceValue;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0006DA5C File Offset: 0x0006BC5C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000BED RID: 3053
		private string _elementName;

		// Token: 0x04000BEE RID: 3054
		private string _namespace = "";

		// Token: 0x04000BEF RID: 3055
		private XmlSchemaForm _form;

		// Token: 0x04000BF0 RID: 3056
		private XmlTypeMapMember _member;

		// Token: 0x04000BF1 RID: 3057
		private object _choiceValue;

		// Token: 0x04000BF2 RID: 3058
		private bool _isNullable;

		// Token: 0x04000BF3 RID: 3059
		private int _nestingLevel;

		// Token: 0x04000BF4 RID: 3060
		private XmlTypeMapping _mappedType;

		// Token: 0x04000BF5 RID: 3061
		private TypeData _type;

		// Token: 0x04000BF6 RID: 3062
		private bool _wrappedElement = true;

		// Token: 0x04000BF7 RID: 3063
		private int _explicitOrder = -1;
	}
}
