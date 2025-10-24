using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic set index operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000131 RID: 305
	public abstract class SetIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the dynamic set index operation.</summary>
		/// <param name="target">The target of the dynamic set index operation.</param>
		/// <param name="args">An array of arguments of the dynamic set index operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009C1 RID: 2497 RVA: 0x00024DF0 File Offset: 0x00022FF0
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.Requires(args.Length >= 2, "args");
			DynamicMetaObject value = args[args.Length - 1];
			DynamicMetaObject[] array = args.RemoveLast<DynamicMetaObject>();
			ContractUtils.RequiresNotNull(value, "args");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(array, "args");
			return target.BindSetIndex(this, array, value);
		}

		/// <summary>Performs the binding of the dynamic set index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic set index operation.</param>
		/// <param name="indexes">The arguments of the dynamic set index operation.</param>
		/// <param name="value">The value to set to the collection.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009C2 RID: 2498 RVA: 0x00024E54 File Offset: 0x00023054
		public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			return this.FallbackSetIndex(target, indexes, value, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic set index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic set index operation.</param>
		/// <param name="indexes">The arguments of the dynamic set index operation.</param>
		/// <param name="value">The value to set to the collection.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009C3 RID: 2499
		public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
}
