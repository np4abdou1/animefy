using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the invoke dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200012F RID: 303
	public abstract class InvokeBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic invoke operation.</param>
		/// <param name="args">The arguments of the dynamic invoke operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009B8 RID: 2488 RVA: 0x00024D88 File Offset: 0x00022F88
		public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackInvoke(target, args, null);
		}

		/// <summary>Performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic invoke operation.</param>
		/// <param name="args">The arguments of the dynamic invoke operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009B9 RID: 2489
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic invoke operation.</summary>
		/// <param name="target">The target of the dynamic invoke operation.</param>
		/// <param name="args">An array of arguments of the dynamic invoke operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009BA RID: 2490 RVA: 0x00024D93 File Offset: 0x00022F93
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindInvoke(this, args);
		}
	}
}
