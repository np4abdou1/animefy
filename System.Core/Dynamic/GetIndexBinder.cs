using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic get index operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200012C RID: 300
	public abstract class GetIndexBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the dynamic get index operation.</summary>
		/// <param name="target">The target of the dynamic get index operation.</param>
		/// <param name="args">An array of arguments of the dynamic get index operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009AC RID: 2476 RVA: 0x00024CF9 File Offset: 0x00022EF9
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindGetIndex(this, args);
		}

		/// <summary>Performs the binding of the dynamic get index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic get index operation.</param>
		/// <param name="indexes">The arguments of the dynamic get index operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009AD RID: 2477 RVA: 0x00024D19 File Offset: 0x00022F19
		public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes)
		{
			return this.FallbackGetIndex(target, indexes, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic get index operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic get index operation.</param>
		/// <param name="indexes">The arguments of the dynamic get index operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009AE RID: 2478
		public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}
}
