using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000249 RID: 585
	internal sealed class AllElementsContentValidator : ContentValidator
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x00073AF2 File Offset: 0x00071CF2
		public AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable) : base(contentType, false, isEmptiable)
		{
			this.elements = new Hashtable(size);
			this.particles = new object[size];
			this.isRequired = new BitSet(size);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00073B24 File Offset: 0x00071D24
		public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable)
		{
			if (this.elements[name] != null)
			{
				return false;
			}
			int count = this.elements.Count;
			this.elements.Add(name, count);
			this.particles[count] = particle;
			if (!isEmptiable)
			{
				this.isRequired.Set(count);
				this.countRequired++;
			}
			return true;
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00073B86 File Offset: 0x00071D86
		public override bool IsEmptiable
		{
			get
			{
				return base.IsEmptiable || this.countRequired == 0;
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00073B9B File Offset: 0x00071D9B
		public override void InitValidation(ValidationState context)
		{
			context.AllElementsSet = new BitSet(this.elements.Count);
			context.CurrentState.AllElementsRequired = -1;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00073BC0 File Offset: 0x00071DC0
		public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			object obj = this.elements[name];
			errorCode = 0;
			if (obj == null)
			{
				context.NeedValidateChildren = false;
				return null;
			}
			int num = (int)obj;
			if (context.AllElementsSet[num])
			{
				errorCode = -2;
				return null;
			}
			if (context.CurrentState.AllElementsRequired == -1)
			{
				context.CurrentState.AllElementsRequired = 0;
			}
			context.AllElementsSet.Set(num);
			if (this.isRequired[num])
			{
				context.CurrentState.AllElementsRequired = context.CurrentState.AllElementsRequired + 1;
			}
			return this.particles[num];
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00073C50 File Offset: 0x00071E50
		public override bool CompleteValidation(ValidationState context)
		{
			return context.CurrentState.AllElementsRequired == this.countRequired || (this.IsEmptiable && context.CurrentState.AllElementsRequired == -1);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00073C80 File Offset: 0x00071E80
		public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			ArrayList arrayList = null;
			foreach (object obj in this.elements)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (!context.AllElementsSet[(int)dictionaryEntry.Value] && (!isRequiredOnly || this.isRequired[(int)dictionaryEntry.Value]))
				{
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					arrayList.Add(dictionaryEntry.Key);
				}
			}
			return arrayList;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00073D24 File Offset: 0x00071F24
		public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			ArrayList result = new ArrayList();
			foreach (object obj in this.elements)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (!context.AllElementsSet[(int)dictionaryEntry.Value] && (!isRequiredOnly || this.isRequired[(int)dictionaryEntry.Value]))
				{
					ContentValidator.AddParticleToExpected(this.particles[(int)dictionaryEntry.Value] as XmlSchemaParticle, schemaSet, result);
				}
			}
			return result;
		}

		// Token: 0x04000CC5 RID: 3269
		private Hashtable elements;

		// Token: 0x04000CC6 RID: 3270
		private object[] particles;

		// Token: 0x04000CC7 RID: 3271
		private BitSet isRequired;

		// Token: 0x04000CC8 RID: 3272
		private int countRequired;
	}
}
