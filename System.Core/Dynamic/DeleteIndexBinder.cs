using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic delete index operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200011B RID: 283
	public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the dynamic delete index operation.</summary>
		/// <param name="target">The target of the dynamic delete index operation.</param>
		/// <param name="args">An array of arguments of the dynamic delete index operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000917 RID: 2327 RVA: 0x000231C7 File Offset: 0x000213C7
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindDeleteIndex(this, args);
		}

		/// <summary>Performs the binding of the dynamic delete index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic delete index operation.</param>
		/// <param name="indexes">The arguments of the dynamic delete index operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000918 RID: 2328 RVA: 0x000231E7 File Offset: 0x000213E7
		public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return this.FallbackDeleteIndex(target, indexes, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic delete index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic delete index operation.</param>
		/// <param name="indexes">The arguments of the dynamic delete index operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000919 RID: 2329
		public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
}
