using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the invoke member dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000130 RID: 304
	public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>Gets the name of the member to invoke.</summary>
		/// <returns>The name of the member to invoke.</returns>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00024DB3 File Offset: 0x00022FB3
		public string Name { get; }

		/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
		/// <returns>True if the case is ignored, otherwise false.</returns>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00024DBB File Offset: 0x00022FBB
		public bool IgnoreCase { get; }

		/// <summary>Performs the binding of the dynamic invoke member operation.</summary>
		/// <param name="target">The target of the dynamic invoke member operation.</param>
		/// <param name="args">An array of arguments of the dynamic invoke member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009BD RID: 2493 RVA: 0x00024DC3 File Offset: 0x00022FC3
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindInvokeMember(this, args);
		}

		/// <summary>Performs the binding of the dynamic invoke member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic invoke member operation.</param>
		/// <param name="args">The arguments of the dynamic invoke member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009BE RID: 2494 RVA: 0x00024DE3 File Offset: 0x00022FE3
		public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackInvokeMember(target, args, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic invoke member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic invoke member operation.</param>
		/// <param name="args">The arguments of the dynamic invoke member operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009BF RID: 2495
		public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>When overridden in the derived class, performs the binding of the dynamic invoke operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic invoke operation.</param>
		/// <param name="args">The arguments of the dynamic invoke operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009C0 RID: 2496
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
	}
}
