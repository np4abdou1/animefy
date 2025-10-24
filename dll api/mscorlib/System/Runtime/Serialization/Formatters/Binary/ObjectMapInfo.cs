using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E1 RID: 993
	internal sealed class ObjectMapInfo
	{
		// Token: 0x06001E3A RID: 7738 RVA: 0x0007FD45 File Offset: 0x0007DF45
		internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, Type[] memberTypes)
		{
			this.objectId = objectId;
			this.numMembers = numMembers;
			this.memberNames = memberNames;
			this.memberTypes = memberTypes;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0007FD6C File Offset: 0x0007DF6C
		internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes)
		{
			bool result = true;
			if (this.numMembers == numMembers)
			{
				for (int i = 0; i < numMembers; i++)
				{
					if (!this.memberNames[i].Equals(memberNames[i]))
					{
						result = false;
						break;
					}
					if (memberTypes != null && this.memberTypes[i] != memberTypes[i])
					{
						result = false;
						break;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000D87 RID: 3463
		internal int objectId;

		// Token: 0x04000D88 RID: 3464
		private int numMembers;

		// Token: 0x04000D89 RID: 3465
		private string[] memberNames;

		// Token: 0x04000D8A RID: 3466
		private Type[] memberTypes;
	}
}
