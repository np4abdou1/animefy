using System;

namespace System.Linq.Expressions
{
	/// <summary>Specifies what kind of jump this <see cref="T:System.Linq.Expressions.GotoExpression" /> represents.</summary>
	// Token: 0x0200008B RID: 139
	public enum GotoExpressionKind
	{
		/// <summary>A <see cref="T:System.Linq.Expressions.GotoExpression" /> that represents a jump to some location.</summary>
		// Token: 0x04000152 RID: 338
		Goto,
		/// <summary>A <see cref="T:System.Linq.Expressions.GotoExpression" /> that represents a return statement.</summary>
		// Token: 0x04000153 RID: 339
		Return,
		/// <summary>A <see cref="T:System.Linq.Expressions.GotoExpression" /> that represents a break statement.</summary>
		// Token: 0x04000154 RID: 340
		Break,
		/// <summary>A <see cref="T:System.Linq.Expressions.GotoExpression" /> that represents a continue statement.</summary>
		// Token: 0x04000155 RID: 341
		Continue
	}
}
