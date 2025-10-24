using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the unary dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000133 RID: 307
	public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the unary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic unary operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009CC RID: 2508 RVA: 0x00024EE9 File Offset: 0x000230E9
		public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target)
		{
			return this.FallbackUnaryOperation(target, null);
		}

		/// <summary>Performs the binding of the unary dynamic operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic unary operation.</param>
		/// <param name="errorSuggestion">The binding result in case the binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009CD RID: 2509
		public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic unary operation.</summary>
		/// <param name="target">The target of the dynamic operation.</param>
		/// <param name="args">An array of arguments of the dynamic operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009CE RID: 2510 RVA: 0x00024EF3 File Offset: 0x000230F3
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindUnaryOperation(this);
		}
	}
}
