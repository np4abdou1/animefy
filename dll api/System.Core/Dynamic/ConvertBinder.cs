using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the convert dynamic operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000119 RID: 281
	public abstract class ConvertBinder : DynamicMetaObjectBinder
	{
		/// <summary>The type to convert to.</summary>
		/// <returns>The <see cref="T:System.Type" /> object that represents the type to convert to.</returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00023161 File Offset: 0x00021361
		public Type Type { get; }

		/// <summary>Performs the binding of the dynamic convert operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic convert operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000911 RID: 2321 RVA: 0x00023169 File Offset: 0x00021369
		public DynamicMetaObject FallbackConvert(DynamicMetaObject target)
		{
			return this.FallbackConvert(target, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic convert operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic convert operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000912 RID: 2322
		public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic convert operation.</summary>
		/// <param name="target">The target of the dynamic convert operation.</param>
		/// <param name="args">An array of arguments of the dynamic convert operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000913 RID: 2323 RVA: 0x00023173 File Offset: 0x00021373
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindConvert(this);
		}
	}
}
