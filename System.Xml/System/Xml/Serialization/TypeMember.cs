using System;

namespace System.Xml.Serialization
{
	// Token: 0x020001D9 RID: 473
	internal sealed class TypeMember
	{
		// Token: 0x06000FC3 RID: 4035 RVA: 0x000639D0 File Offset: 0x00061BD0
		internal TypeMember(Type type, string member)
		{
			this.type = type;
			this.member = member;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x000639E6 File Offset: 0x00061BE6
		public override int GetHashCode()
		{
			return this.type.GetHashCode() + this.member.GetHashCode();
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000639FF File Offset: 0x00061BFF
		public override bool Equals(object obj)
		{
			return obj is TypeMember && TypeMember.Equals(this, (TypeMember)obj);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00063A17 File Offset: 0x00061C17
		public static bool Equals(TypeMember tm1, TypeMember tm2)
		{
			return tm1 == tm2 || (tm1 != null && tm2 != null && (tm1.type == tm2.type && tm1.member == tm2.member));
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00063A50 File Offset: 0x00061C50
		public override string ToString()
		{
			return this.type.ToString() + " " + this.member;
		}

		// Token: 0x04000B40 RID: 2880
		private Type type;

		// Token: 0x04000B41 RID: 2881
		private string member;
	}
}
