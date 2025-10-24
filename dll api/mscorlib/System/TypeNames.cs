using System;

namespace System
{
	// Token: 0x02000188 RID: 392
	internal class TypeNames
	{
		// Token: 0x02000189 RID: 393
		internal abstract class ATypeName : TypeName, IEquatable<TypeName>
		{
			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000F44 RID: 3908
			public abstract string DisplayName { get; }

			// Token: 0x06000F45 RID: 3909 RVA: 0x000400A9 File Offset: 0x0003E2A9
			public bool Equals(TypeName other)
			{
				return other != null && this.DisplayName == other.DisplayName;
			}

			// Token: 0x06000F46 RID: 3910 RVA: 0x000400C1 File Offset: 0x0003E2C1
			public override int GetHashCode()
			{
				return this.DisplayName.GetHashCode();
			}

			// Token: 0x06000F47 RID: 3911 RVA: 0x000400CE File Offset: 0x0003E2CE
			public override bool Equals(object other)
			{
				return this.Equals(other as TypeName);
			}
		}
	}
}
