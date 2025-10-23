using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003AB RID: 939
	internal class ObjectHolderListEnumerator
	{
		// Token: 0x06001D2C RID: 7468 RVA: 0x0007BAE6 File Offset: 0x00079CE6
		internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
		{
			this.m_list = list;
			this.m_startingVersion = this.m_list.Version;
			this.m_currPos = -1;
			this.m_isFixupEnumerator = isFixupEnumerator;
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0007BB14 File Offset: 0x00079D14
		internal bool MoveNext()
		{
			if (this.m_isFixupEnumerator)
			{
				int num;
				do
				{
					num = this.m_currPos + 1;
					this.m_currPos = num;
				}
				while (num < this.m_list.Count && this.m_list.m_values[this.m_currPos].CompletelyFixed);
				return this.m_currPos != this.m_list.Count;
			}
			this.m_currPos++;
			return this.m_currPos != this.m_list.Count;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x0007BB9B File Offset: 0x00079D9B
		internal ObjectHolder Current
		{
			get
			{
				return this.m_list.m_values[this.m_currPos];
			}
		}

		// Token: 0x04000C34 RID: 3124
		private bool m_isFixupEnumerator;

		// Token: 0x04000C35 RID: 3125
		private ObjectHolderList m_list;

		// Token: 0x04000C36 RID: 3126
		private int m_startingVersion;

		// Token: 0x04000C37 RID: 3127
		private int m_currPos;
	}
}
