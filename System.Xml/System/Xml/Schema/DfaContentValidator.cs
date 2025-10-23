using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000245 RID: 581
	internal sealed class DfaContentValidator : ContentValidator
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x00072FDE File Offset: 0x000711DE
		internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) : base(contentType, isOpen, isEmptiable)
		{
			this.transitionTable = transitionTable;
			this.symbols = symbols;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00072FF9 File Offset: 0x000711F9
		public override void InitValidation(ValidationState context)
		{
			context.CurrentState.State = 0;
			context.HasMatched = (this.transitionTable[0][this.symbols.Count] > 0);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00073024 File Offset: 0x00071224
		public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			int num = this.symbols[name];
			int num2 = this.transitionTable[context.CurrentState.State][num];
			errorCode = 0;
			if (num2 != -1)
			{
				context.CurrentState.State = num2;
				context.HasMatched = (this.transitionTable[context.CurrentState.State][this.symbols.Count] > 0);
				return this.symbols.GetParticle(num);
			}
			if (base.IsOpen && context.HasMatched)
			{
				return null;
			}
			context.NeedValidateChildren = false;
			errorCode = -1;
			return null;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000730B7 File Offset: 0x000712B7
		public override bool CompleteValidation(ValidationState context)
		{
			return context.HasMatched;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000730C4 File Offset: 0x000712C4
		public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			ArrayList arrayList = null;
			int[] array = this.transitionTable[context.CurrentState.State];
			if (array != null)
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					if (array[i] != -1)
					{
						if (arrayList == null)
						{
							arrayList = new ArrayList();
						}
						XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)this.symbols.GetParticle(i);
						if (xmlSchemaParticle == null)
						{
							string text = this.symbols.NameOf(i);
							if (text.Length != 0)
							{
								arrayList.Add(text);
							}
						}
						else
						{
							string nameString = xmlSchemaParticle.NameString;
							if (!arrayList.Contains(nameString))
							{
								arrayList.Add(nameString);
							}
						}
					}
				}
			}
			return arrayList;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0007315C File Offset: 0x0007135C
		public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			ArrayList arrayList = new ArrayList();
			int[] array = this.transitionTable[context.CurrentState.State];
			if (array != null)
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					if (array[i] != -1)
					{
						XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)this.symbols.GetParticle(i);
						if (xmlSchemaParticle != null)
						{
							ContentValidator.AddParticleToExpected(xmlSchemaParticle, schemaSet, arrayList);
						}
					}
				}
			}
			return arrayList;
		}

		// Token: 0x04000CB5 RID: 3253
		private int[][] transitionTable;

		// Token: 0x04000CB6 RID: 3254
		private SymbolsDictionary symbols;
	}
}
