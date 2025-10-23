using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000243 RID: 579
	internal class ContentValidator
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x00072534 File Offset: 0x00070734
		public ContentValidator(XmlSchemaContentType contentType)
		{
			this.contentType = contentType;
			this.isEmptiable = true;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0007254A File Offset: 0x0007074A
		protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			this.contentType = contentType;
			this.isOpen = isOpen;
			this.isEmptiable = isEmptiable;
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00072567 File Offset: 0x00070767
		public XmlSchemaContentType ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0007256F File Offset: 0x0007076F
		public bool PreserveWhitespace
		{
			get
			{
				return this.contentType == XmlSchemaContentType.TextOnly || this.contentType == XmlSchemaContentType.Mixed;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00072584 File Offset: 0x00070784
		public virtual bool IsEmptiable
		{
			get
			{
				return this.isEmptiable;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x0007258C File Offset: 0x0007078C
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x000725A7 File Offset: 0x000707A7
		public bool IsOpen
		{
			get
			{
				return this.contentType != XmlSchemaContentType.TextOnly && this.contentType != XmlSchemaContentType.Empty && this.isOpen;
			}
			set
			{
				this.isOpen = value;
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00008574 File Offset: 0x00006774
		public virtual void InitValidation(ValidationState context)
		{
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000725B0 File Offset: 0x000707B0
		public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			if (this.contentType == XmlSchemaContentType.TextOnly || this.contentType == XmlSchemaContentType.Empty)
			{
				context.NeedValidateChildren = false;
			}
			errorCode = -1;
			return null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public virtual bool CompleteValidation(ValidationState context)
		{
			return true;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			return null;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			return null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000725CE File Offset: 0x000707CE
		public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles)
		{
			ContentValidator.AddParticleToExpected(p, schemaSet, particles, false);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000725DC File Offset: 0x000707DC
		public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global)
		{
			if (!particles.Contains(p))
			{
				particles.Add(p);
			}
			XmlSchemaElement xmlSchemaElement = p as XmlSchemaElement;
			if (xmlSchemaElement != null && (global || !xmlSchemaElement.RefName.IsEmpty))
			{
				XmlSchemaSubstitutionGroup xmlSchemaSubstitutionGroup = (XmlSchemaSubstitutionGroup)schemaSet.SubstitutionGroups[xmlSchemaElement.QualifiedName];
				if (xmlSchemaSubstitutionGroup != null)
				{
					for (int i = 0; i < xmlSchemaSubstitutionGroup.Members.Count; i++)
					{
						XmlSchemaElement xmlSchemaElement2 = (XmlSchemaElement)xmlSchemaSubstitutionGroup.Members[i];
						if (!xmlSchemaElement.QualifiedName.Equals(xmlSchemaElement2.QualifiedName) && !particles.Contains(xmlSchemaElement2))
						{
							particles.Add(xmlSchemaElement2);
						}
					}
				}
			}
		}

		// Token: 0x04000CA7 RID: 3239
		private XmlSchemaContentType contentType;

		// Token: 0x04000CA8 RID: 3240
		private bool isOpen;

		// Token: 0x04000CA9 RID: 3241
		private bool isEmptiable;

		// Token: 0x04000CAA RID: 3242
		public static readonly ContentValidator Empty = new ContentValidator(XmlSchemaContentType.Empty);

		// Token: 0x04000CAB RID: 3243
		public static readonly ContentValidator TextOnly = new ContentValidator(XmlSchemaContentType.TextOnly, false, false);

		// Token: 0x04000CAC RID: 3244
		public static readonly ContentValidator Mixed = new ContentValidator(XmlSchemaContentType.Mixed);

		// Token: 0x04000CAD RID: 3245
		public static readonly ContentValidator Any = new ContentValidator(XmlSchemaContentType.Mixed, true, true);
	}
}
