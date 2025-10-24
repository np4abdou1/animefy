using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Abstract class for that is the base class for all particle types (e.g. <see cref="T:System.Xml.Schema.XmlSchemaAny" />).</summary>
	// Token: 0x02000311 RID: 785
	public abstract class XmlSchemaParticle : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the number as a string value. The minimum number of times the particle can occur.</summary>
		/// <returns>The number as a string value. <see langword="String.Empty" /> indicates that <see langword="MinOccurs" /> is equal to the default value. The default is a null reference.</returns>
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00098992 File Offset: 0x00096B92
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x000989AC File Offset: 0x00096BAC
		[XmlAttribute("minOccurs")]
		public string MinOccursString
		{
			get
			{
				if ((this.flags & XmlSchemaParticle.Occurs.Min) != XmlSchemaParticle.Occurs.None)
				{
					return XmlConvert.ToString(this.minOccurs);
				}
				return null;
			}
			set
			{
				if (value == null)
				{
					this.minOccurs = 1m;
					this.flags &= ~XmlSchemaParticle.Occurs.Min;
					return;
				}
				this.minOccurs = XmlConvert.ToInteger(value);
				if (this.minOccurs < 0m)
				{
					throw new XmlSchemaException("The value for the 'minOccurs' attribute must be xsd:nonNegativeInteger.", string.Empty);
				}
				this.flags |= XmlSchemaParticle.Occurs.Min;
			}
		}

		/// <summary>Gets or sets the number as a string value. Maximum number of times the particle can occur.</summary>
		/// <returns>The number as a string value. <see langword="String.Empty" /> indicates that <see langword="MaxOccurs" /> is equal to the default value. The default is a null reference.</returns>
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00098A13 File Offset: 0x00096C13
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00098A4C File Offset: 0x00096C4C
		[XmlAttribute("maxOccurs")]
		public string MaxOccursString
		{
			get
			{
				if ((this.flags & XmlSchemaParticle.Occurs.Max) == XmlSchemaParticle.Occurs.None)
				{
					return null;
				}
				if (!(this.maxOccurs == 79228162514264337593543950335m))
				{
					return XmlConvert.ToString(this.maxOccurs);
				}
				return "unbounded";
			}
			set
			{
				if (value == null)
				{
					this.maxOccurs = 1m;
					this.flags &= ~XmlSchemaParticle.Occurs.Max;
					return;
				}
				if (value == "unbounded")
				{
					this.maxOccurs = decimal.MaxValue;
				}
				else
				{
					this.maxOccurs = XmlConvert.ToInteger(value);
					if (this.maxOccurs < 0m)
					{
						throw new XmlSchemaException("The value for the 'maxOccurs' attribute must be xsd:nonNegativeInteger or 'unbounded'.", string.Empty);
					}
					if (this.maxOccurs == 0m && (this.flags & XmlSchemaParticle.Occurs.Min) == XmlSchemaParticle.Occurs.None)
					{
						this.minOccurs = 0m;
					}
				}
				this.flags |= XmlSchemaParticle.Occurs.Max;
			}
		}

		/// <summary>Gets or sets the minimum number of times the particle can occur.</summary>
		/// <returns>The minimum number of times the particle can occur. The default is 1.</returns>
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00098AFA File Offset: 0x00096CFA
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x00098B04 File Offset: 0x00096D04
		[XmlIgnore]
		public decimal MinOccurs
		{
			get
			{
				return this.minOccurs;
			}
			set
			{
				if (value < 0m || value != decimal.Truncate(value))
				{
					throw new XmlSchemaException("The value for the 'minOccurs' attribute must be xsd:nonNegativeInteger.", string.Empty);
				}
				this.minOccurs = value;
				this.flags |= XmlSchemaParticle.Occurs.Min;
			}
		}

		/// <summary>Gets or sets the maximum number of times the particle can occur.</summary>
		/// <returns>The maximum number of times the particle can occur. The default is 1.</returns>
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00098B51 File Offset: 0x00096D51
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x00098B5C File Offset: 0x00096D5C
		[XmlIgnore]
		public decimal MaxOccurs
		{
			get
			{
				return this.maxOccurs;
			}
			set
			{
				if (value < 0m || value != decimal.Truncate(value))
				{
					throw new XmlSchemaException("The value for the 'maxOccurs' attribute must be xsd:nonNegativeInteger or 'unbounded'.", string.Empty);
				}
				this.maxOccurs = value;
				if (this.maxOccurs == 0m && (this.flags & XmlSchemaParticle.Occurs.Min) == XmlSchemaParticle.Occurs.None)
				{
					this.minOccurs = 0m;
				}
				this.flags |= XmlSchemaParticle.Occurs.Max;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00098BD1 File Offset: 0x00096DD1
		internal virtual bool IsEmpty
		{
			get
			{
				return this.maxOccurs == 0m;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00015248 File Offset: 0x00013448
		internal virtual string NameString
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00098BE4 File Offset: 0x00096DE4
		internal XmlQualifiedName GetQualifiedName()
		{
			XmlSchemaElement xmlSchemaElement = this as XmlSchemaElement;
			if (xmlSchemaElement != null)
			{
				return xmlSchemaElement.QualifiedName;
			}
			XmlSchemaAny xmlSchemaAny = this as XmlSchemaAny;
			if (xmlSchemaAny != null)
			{
				string text = xmlSchemaAny.Namespace;
				if (text != null)
				{
					text = text.Trim();
				}
				else
				{
					text = string.Empty;
				}
				return new XmlQualifiedName("*", (text.Length == 0) ? "##any" : text);
			}
			return XmlQualifiedName.Empty;
		}

		// Token: 0x040010FE RID: 4350
		private decimal minOccurs = 1m;

		// Token: 0x040010FF RID: 4351
		private decimal maxOccurs = 1m;

		// Token: 0x04001100 RID: 4352
		private XmlSchemaParticle.Occurs flags;

		// Token: 0x04001101 RID: 4353
		internal static readonly XmlSchemaParticle Empty = new XmlSchemaParticle.EmptyParticle();

		// Token: 0x02000312 RID: 786
		[Flags]
		private enum Occurs
		{
			// Token: 0x04001103 RID: 4355
			None = 0,
			// Token: 0x04001104 RID: 4356
			Min = 1,
			// Token: 0x04001105 RID: 4357
			Max = 2
		}

		// Token: 0x02000313 RID: 787
		private class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0000C89B File Offset: 0x0000AA9B
			internal override bool IsEmpty
			{
				get
				{
					return true;
				}
			}
		}
	}
}
