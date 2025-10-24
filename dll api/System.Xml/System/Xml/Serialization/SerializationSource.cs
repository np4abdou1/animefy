using System;

namespace System.Xml.Serialization
{
	// Token: 0x020001D5 RID: 469
	internal abstract class SerializationSource
	{
		// Token: 0x06000FA5 RID: 4005 RVA: 0x00062F1D File Offset: 0x0006111D
		public SerializationSource(string namspace, Type[] includedTypes)
		{
			this.namspace = namspace;
			this.includedTypes = includedTypes;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00062F3C File Offset: 0x0006113C
		protected bool BaseEquals(SerializationSource other)
		{
			if (this.namspace != other.namspace)
			{
				return false;
			}
			if (this.canBeGenerated != other.canBeGenerated)
			{
				return false;
			}
			if (this.includedTypes == null)
			{
				return other.includedTypes == null;
			}
			if (other.includedTypes == null || this.includedTypes.Length != other.includedTypes.Length)
			{
				return false;
			}
			for (int i = 0; i < this.includedTypes.Length; i++)
			{
				if (!this.includedTypes[i].Equals(other.includedTypes[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000B2C RID: 2860
		private Type[] includedTypes;

		// Token: 0x04000B2D RID: 2861
		private string namspace;

		// Token: 0x04000B2E RID: 2862
		private bool canBeGenerated = true;
	}
}
