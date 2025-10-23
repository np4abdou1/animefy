using System;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x02000233 RID: 563
	internal class KeySequence
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x000717FB File Offset: 0x0006F9FB
		internal KeySequence(int dim, int line, int col)
		{
			this.dim = dim;
			this.ks = new TypedObject[dim];
			this.posline = line;
			this.poscol = col;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0007182B File Offset: 0x0006FA2B
		public int PosLine
		{
			get
			{
				return this.posline;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00071833 File Offset: 0x0006FA33
		public int PosCol
		{
			get
			{
				return this.poscol;
			}
		}

		// Token: 0x170003DB RID: 987
		public object this[int index]
		{
			get
			{
				return this.ks[index];
			}
			set
			{
				this.ks[index] = (TypedObject)value;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00071858 File Offset: 0x0006FA58
		internal bool IsQualified()
		{
			for (int i = 0; i < this.ks.Length; i++)
			{
				if (this.ks[i] == null || this.ks[i].Value == null)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00071894 File Offset: 0x0006FA94
		public override int GetHashCode()
		{
			if (this.hashcode != -1)
			{
				return this.hashcode;
			}
			this.hashcode = 0;
			for (int i = 0; i < this.ks.Length; i++)
			{
				this.ks[i].SetDecimal();
				if (this.ks[i].IsDecimal)
				{
					for (int j = 0; j < this.ks[i].Dim; j++)
					{
						this.hashcode += this.ks[i].Dvalue[j].GetHashCode();
					}
				}
				else
				{
					Array array = this.ks[i].Value as Array;
					if (array != null)
					{
						XmlAtomicValue[] array2 = array as XmlAtomicValue[];
						if (array2 != null)
						{
							for (int k = 0; k < array2.Length; k++)
							{
								this.hashcode += ((XmlAtomicValue)array2.GetValue(k)).TypedValue.GetHashCode();
							}
						}
						else
						{
							for (int l = 0; l < ((Array)this.ks[i].Value).Length; l++)
							{
								this.hashcode += ((Array)this.ks[i].Value).GetValue(l).GetHashCode();
							}
						}
					}
					else
					{
						this.hashcode += this.ks[i].Value.GetHashCode();
					}
				}
			}
			return this.hashcode;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00071A04 File Offset: 0x0006FC04
		public override bool Equals(object other)
		{
			KeySequence keySequence = (KeySequence)other;
			for (int i = 0; i < this.ks.Length; i++)
			{
				if (!this.ks[i].Equals(keySequence.ks[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00071A48 File Offset: 0x0006FC48
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.ks[0].ToString());
			for (int i = 1; i < this.ks.Length; i++)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(this.ks[i].ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000C8A RID: 3210
		private TypedObject[] ks;

		// Token: 0x04000C8B RID: 3211
		private int dim;

		// Token: 0x04000C8C RID: 3212
		private int hashcode = -1;

		// Token: 0x04000C8D RID: 3213
		private int posline;

		// Token: 0x04000C8E RID: 3214
		private int poscol;
	}
}
