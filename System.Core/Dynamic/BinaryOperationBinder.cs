using System;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>Represents the binary dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000110 RID: 272
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		/// <summary>The binary operation kind.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> object representing the kind of binary operation.</returns>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00022D11 File Offset: 0x00020F11
		public ExpressionType Operation { get; }

		/// <summary>Performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic binary operation.</param>
		/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060008F3 RID: 2291 RVA: 0x00022D19 File Offset: 0x00020F19
		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			return this.FallbackBinaryOperation(target, arg, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the binary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic binary operation.</param>
		/// <param name="arg">The right hand side operand of the dynamic binary operation.</param>
		/// <param name="errorSuggestion">The binding result if the binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060008F4 RID: 2292
		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic binary operation.</summary>
		/// <param name="target">The target of the dynamic operation.</param>
		/// <param name="args">An array of arguments of the dynamic operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060008F5 RID: 2293 RVA: 0x00022D24 File Offset: 0x00020F24
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.Requires(args.Length == 1, "args");
			DynamicMetaObject dynamicMetaObject = args[0];
			ContractUtils.RequiresNotNull(dynamicMetaObject, "args");
			return target.BindBinaryOperation(this, dynamicMetaObject);
		}
	}
}
