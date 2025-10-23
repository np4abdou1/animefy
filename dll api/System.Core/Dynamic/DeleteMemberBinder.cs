using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic delete member operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200011C RID: 284
	public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>Gets the name of the member to delete.</summary>
		/// <returns>The name of the member to delete.</returns>
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x000231F2 File Offset: 0x000213F2
		public string Name { get; }

		/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
		/// <returns>True if the string comparison should ignore the case, otherwise false.</returns>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000231FA File Offset: 0x000213FA
		public bool IgnoreCase { get; }

		/// <summary>Performs the binding of the dynamic delete member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic delete member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600091C RID: 2332 RVA: 0x00023202 File Offset: 0x00021402
		public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
		{
			return this.FallbackDeleteMember(target, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic delete member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic delete member operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600091D RID: 2333
		public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic delete member operation.</summary>
		/// <param name="target">The target of the dynamic delete member operation.</param>
		/// <param name="args">An array of arguments of the dynamic delete member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600091E RID: 2334 RVA: 0x0002320C File Offset: 0x0002140C
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindDeleteMember(this);
		}
	}
}
