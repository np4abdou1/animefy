using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200022F RID: 559
	internal class SelectorActiveAxis : ActiveAxis
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000712EB File Offset: 0x0006F4EB
		public int lastDepth
		{
			get
			{
				if (this.KSpointer != 0)
				{
					return ((KSStruct)this.KSs[this.KSpointer - 1]).depth;
				}
				return -1;
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00071314 File Offset: 0x0006F514
		public SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs) : base(axisTree)
		{
			this.KSs = new ArrayList();
			this.cs = cs;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0007132F File Offset: 0x0006F52F
		public override bool EndElement(string localname, string URN)
		{
			base.EndElement(localname, URN);
			return this.KSpointer > 0 && base.CurrentDepth == this.lastDepth;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00071354 File Offset: 0x0006F554
		public int PushKS(int errline, int errcol)
		{
			KeySequence ks = new KeySequence(this.cs.TableDim, errline, errcol);
			KSStruct ksstruct;
			if (this.KSpointer < this.KSs.Count)
			{
				ksstruct = (KSStruct)this.KSs[this.KSpointer];
				ksstruct.ks = ks;
				for (int i = 0; i < this.cs.TableDim; i++)
				{
					ksstruct.fields[i].Reactivate(ks);
				}
			}
			else
			{
				ksstruct = new KSStruct(ks, this.cs.TableDim);
				for (int j = 0; j < this.cs.TableDim; j++)
				{
					ksstruct.fields[j] = new LocatedActiveAxis(this.cs.constraint.Fields[j], ks, j);
					this.cs.axisFields.Add(ksstruct.fields[j]);
				}
				this.KSs.Add(ksstruct);
			}
			ksstruct.depth = base.CurrentDepth - 1;
			int kspointer = this.KSpointer;
			this.KSpointer = kspointer + 1;
			return kspointer;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0007145C File Offset: 0x0006F65C
		public KeySequence PopKS()
		{
			ArrayList kss = this.KSs;
			int num = this.KSpointer - 1;
			this.KSpointer = num;
			return ((KSStruct)kss[num]).ks;
		}

		// Token: 0x04000C7C RID: 3196
		private ConstraintStruct cs;

		// Token: 0x04000C7D RID: 3197
		private ArrayList KSs;

		// Token: 0x04000C7E RID: 3198
		private int KSpointer;
	}
}
