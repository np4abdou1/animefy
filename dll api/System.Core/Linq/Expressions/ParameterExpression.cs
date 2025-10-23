using System;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	/// <summary>Represents a named parameter expression.</summary>
	// Token: 0x020000C1 RID: 193
	[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
	public class ParameterExpression : Expression
	{
		// Token: 0x060005BC RID: 1468 RVA: 0x000138A7 File Offset: 0x00011AA7
		internal ParameterExpression(string name)
		{
			this.Name = name;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000138B8 File Offset: 0x00011AB8
		internal static ParameterExpression Make(Type type, string name, bool isByRef)
		{
			if (isByRef)
			{
				return new ByRefParameterExpression(type, name);
			}
			if (!type.IsEnum)
			{
				switch (type.GetTypeCode())
				{
				case TypeCode.Object:
					if (type == typeof(object))
					{
						return new ParameterExpression(name);
					}
					if (type == typeof(Exception))
					{
						return new PrimitiveParameterExpression<Exception>(name);
					}
					if (type == typeof(object[]))
					{
						return new PrimitiveParameterExpression<object[]>(name);
					}
					break;
				case TypeCode.Boolean:
					return new PrimitiveParameterExpression<bool>(name);
				case TypeCode.Char:
					return new PrimitiveParameterExpression<char>(name);
				case TypeCode.SByte:
					return new PrimitiveParameterExpression<sbyte>(name);
				case TypeCode.Byte:
					return new PrimitiveParameterExpression<byte>(name);
				case TypeCode.Int16:
					return new PrimitiveParameterExpression<short>(name);
				case TypeCode.UInt16:
					return new PrimitiveParameterExpression<ushort>(name);
				case TypeCode.Int32:
					return new PrimitiveParameterExpression<int>(name);
				case TypeCode.UInt32:
					return new PrimitiveParameterExpression<uint>(name);
				case TypeCode.Int64:
					return new PrimitiveParameterExpression<long>(name);
				case TypeCode.UInt64:
					return new PrimitiveParameterExpression<ulong>(name);
				case TypeCode.Single:
					return new PrimitiveParameterExpression<float>(name);
				case TypeCode.Double:
					return new PrimitiveParameterExpression<double>(name);
				case TypeCode.Decimal:
					return new PrimitiveParameterExpression<decimal>(name);
				case TypeCode.DateTime:
					return new PrimitiveParameterExpression<DateTime>(name);
				case TypeCode.String:
					return new PrimitiveParameterExpression<string>(name);
				}
			}
			return new TypedParameterExpression(type, name);
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.ParameterExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000139F2 File Offset: 0x00011BF2
		public override Type Type
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x000139FE File Offset: 0x00011BFE
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Parameter;
			}
		}

		/// <summary>Gets the name of the parameter or variable.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the name of the parameter.</returns>
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00013A02 File Offset: 0x00011C02
		public string Name { get; }

		/// <summary>Indicates that this ParameterExpression is to be treated as a <see langword="ByRef" /> parameter.</summary>
		/// <returns>True if this ParameterExpression is a <see langword="ByRef" /> parameter, otherwise false.</returns>
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00013A0A File Offset: 0x00011C0A
		public bool IsByRef
		{
			get
			{
				return this.GetIsByRef();
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00008049 File Offset: 0x00006249
		internal virtual bool GetIsByRef()
		{
			return false;
		}

		/// <summary>Dispatches to the specific visit method for this node type. For example, <see cref="T:System.Linq.Expressions.MethodCallExpression" /> calls the <see cref="M:System.Linq.Expressions.ExpressionVisitor.VisitMethodCall(System.Linq.Expressions.MethodCallExpression)" />.</summary>
		/// <param name="visitor">The visitor to visit this node with.</param>
		/// <returns>The result of visiting this node.</returns>
		// Token: 0x060005C3 RID: 1475 RVA: 0x00013A12 File Offset: 0x00011C12
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitParameter(this);
		}
	}
}
