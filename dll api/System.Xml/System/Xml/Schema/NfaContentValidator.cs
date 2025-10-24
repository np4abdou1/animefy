using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000246 RID: 582
	internal sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x000731B9 File Offset: 0x000713B9
		internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) : base(contentType, isOpen, isEmptiable)
		{
			this.firstpos = firstpos;
			this.followpos = followpos;
			this.symbols = symbols;
			this.positions = positions;
			this.endMarkerPos = endMarkerPos;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000731EC File Offset: 0x000713EC
		public override void InitValidation(ValidationState context)
		{
			context.CurPos[0] = this.firstpos.Clone();
			context.CurPos[1] = new BitSet(this.firstpos.Count);
			context.CurrentState.CurPosIndex = 0;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00073228 File Offset: 0x00071428
		public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode)
		{
			BitSet bitSet = context.CurPos[context.CurrentState.CurPosIndex];
			int num = (context.CurrentState.CurPosIndex + 1) % 2;
			BitSet bitSet2 = context.CurPos[num];
			bitSet2.Clear();
			int num2 = this.symbols[name];
			object result = null;
			errorCode = 0;
			for (int num3 = bitSet.NextSet(-1); num3 != -1; num3 = bitSet.NextSet(num3))
			{
				if (num2 == this.positions[num3].symbol)
				{
					bitSet2.Or(this.followpos[num3]);
					result = this.positions[num3].particle;
					break;
				}
			}
			if (!bitSet2.IsEmpty)
			{
				context.CurrentState.CurPosIndex = num;
				return result;
			}
			if (base.IsOpen && bitSet[this.endMarkerPos])
			{
				return null;
			}
			context.NeedValidateChildren = false;
			errorCode = -1;
			return null;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00073308 File Offset: 0x00071508
		public override bool CompleteValidation(ValidationState context)
		{
			return context.CurPos[context.CurrentState.CurPosIndex][this.endMarkerPos];
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0007332C File Offset: 0x0007152C
		public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly)
		{
			ArrayList arrayList = null;
			BitSet bitSet = context.CurPos[context.CurrentState.CurPosIndex];
			for (int num = bitSet.NextSet(-1); num != -1; num = bitSet.NextSet(num))
			{
				if (arrayList == null)
				{
					arrayList = new ArrayList();
				}
				XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)this.positions[num].particle;
				if (xmlSchemaParticle == null)
				{
					string text = this.symbols.NameOf(this.positions[num].symbol);
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
			return arrayList;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000733D8 File Offset: 0x000715D8
		public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet)
		{
			ArrayList arrayList = new ArrayList();
			BitSet bitSet = context.CurPos[context.CurrentState.CurPosIndex];
			for (int num = bitSet.NextSet(-1); num != -1; num = bitSet.NextSet(num))
			{
				XmlSchemaParticle xmlSchemaParticle = (XmlSchemaParticle)this.positions[num].particle;
				if (xmlSchemaParticle != null)
				{
					ContentValidator.AddParticleToExpected(xmlSchemaParticle, schemaSet, arrayList);
				}
			}
			return arrayList;
		}

		// Token: 0x04000CB7 RID: 3255
		private BitSet firstpos;

		// Token: 0x04000CB8 RID: 3256
		private BitSet[] followpos;

		// Token: 0x04000CB9 RID: 3257
		private SymbolsDictionary symbols;

		// Token: 0x04000CBA RID: 3258
		private Positions positions;

		// Token: 0x04000CBB RID: 3259
		private int endMarkerPos;
	}
}
