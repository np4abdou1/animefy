using System;

namespace System.Linq.Expressions
{
	// Token: 0x0200004E RID: 78
	internal sealed class CoalesceConversionBinaryExpression : BinaryExpression
	{
		// Token: 0x0600021C RID: 540 RVA: 0x000095BE File Offset: 0x000077BE
		internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) : base(left, right)
		{
			this._conversion = conversion;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000095CF File Offset: 0x000077CF
		internal override LambdaExpression GetConversion()
		{
			return this._conversion;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000095D7 File Offset: 0x000077D7
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Coalesce;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000095DA File Offset: 0x000077DA
		public sealed override Type Type
		{
			get
			{
				return base.Right.Type;
			}
		}

		// Token: 0x040000C2 RID: 194
		private readonly LambdaExpression _conversion;
	}
}
