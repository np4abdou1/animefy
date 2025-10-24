using System;

namespace System.Xml.Schema
{
	// Token: 0x0200025E RID: 606
	internal class Datatype_dateTimeBase : Datatype_anySimpleType
	{
		// Token: 0x060013C3 RID: 5059 RVA: 0x00075FB4 File Offset: 0x000741B4
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlDateTimeConverter.Create(schemaType);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00075FBC File Offset: 0x000741BC
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.dateTimeFacetsChecker;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00075FC3 File Offset: 0x000741C3
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.DateTime;
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00075FC7 File Offset: 0x000741C7
		internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags)
		{
			this.dateTimeFlags = dateTimeFlags;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00075FD6 File Offset: 0x000741D6
		public override Type ValueType
		{
			get
			{
				return Datatype_dateTimeBase.atomicValueType;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00075FDD File Offset: 0x000741DD
		internal override Type ListValueType
		{
			get
			{
				return Datatype_dateTimeBase.listValueType;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00075C07 File Offset: 0x00073E07
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace | RestrictionFlags.MaxInclusive | RestrictionFlags.MaxExclusive | RestrictionFlags.MinInclusive | RestrictionFlags.MinExclusive;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00075FE4 File Offset: 0x000741E4
		internal override int Compare(object value1, object value2)
		{
			DateTime dateTime = (DateTime)value1;
			DateTime value3 = (DateTime)value2;
			if (dateTime.Kind == DateTimeKind.Unspecified || value3.Kind == DateTimeKind.Unspecified)
			{
				return dateTime.CompareTo(value3);
			}
			return dateTime.ToUniversalTime().CompareTo(value3.ToUniversalTime());
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00076030 File Offset: 0x00074230
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.dateTimeFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				XsdDateTime xdt;
				if (!XsdDateTime.TryParse(s, this.dateTimeFlags, out xdt))
				{
					ex = new FormatException(Res.GetString("The string '{0}' is not a valid {1} value.", new object[]
					{
						s,
						this.dateTimeFlags.ToString()
					}));
				}
				else
				{
					DateTime dateTime = DateTime.MinValue;
					try
					{
						dateTime = xdt;
					}
					catch (ArgumentException ex)
					{
						return ex;
					}
					ex = DatatypeImplementation.dateTimeFacetsChecker.CheckValueFacets(dateTime, this);
					if (ex == null)
					{
						typedValue = dateTime;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D5E RID: 3422
		private static readonly Type atomicValueType = typeof(DateTime);

		// Token: 0x04000D5F RID: 3423
		private static readonly Type listValueType = typeof(DateTime[]);

		// Token: 0x04000D60 RID: 3424
		private XsdDateTimeFlags dateTimeFlags;
	}
}
