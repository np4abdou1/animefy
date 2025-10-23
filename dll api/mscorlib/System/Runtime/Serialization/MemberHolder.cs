using System;

namespace System.Runtime.Serialization
{
	// Token: 0x0200039A RID: 922
	[Serializable]
	internal sealed class MemberHolder
	{
		// Token: 0x06001C95 RID: 7317 RVA: 0x0007933D File Offset: 0x0007753D
		internal MemberHolder(Type type, StreamingContext ctx)
		{
			this._memberType = type;
			this._context = ctx;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00079353 File Offset: 0x00077553
		public override int GetHashCode()
		{
			return this._memberType.GetHashCode();
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00079360 File Offset: 0x00077560
		public override bool Equals(object obj)
		{
			MemberHolder memberHolder = obj as MemberHolder;
			return memberHolder != null && memberHolder._memberType == this._memberType && memberHolder._context.State == this._context.State;
		}

		// Token: 0x04000BF9 RID: 3065
		internal readonly Type _memberType;

		// Token: 0x04000BFA RID: 3066
		internal readonly StreamingContext _context;
	}
}
