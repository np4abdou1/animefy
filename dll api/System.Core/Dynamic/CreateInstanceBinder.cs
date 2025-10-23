using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic create operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200011A RID: 282
	public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
	{
		/// <summary>Performs the binding of the dynamic create operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic create operation.</param>
		/// <param name="args">The arguments of the dynamic create operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000914 RID: 2324 RVA: 0x0002319C File Offset: 0x0002139C
		public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackCreateInstance(target, args, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic create operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic create operation.</param>
		/// <param name="args">The arguments of the dynamic create operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000915 RID: 2325
		public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic create operation.</summary>
		/// <param name="target">The target of the dynamic create operation.</param>
		/// <param name="args">An array of arguments of the dynamic create operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000916 RID: 2326 RVA: 0x000231A7 File Offset: 0x000213A7
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindCreateInstance(this, args);
		}
	}
}
