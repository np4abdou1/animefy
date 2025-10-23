using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic set member operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x02000132 RID: 306
	public abstract class SetMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.SetMemberBinder" />.</summary>
		/// <param name="name">The name of the member to obtain.</param>
		/// <param name="ignoreCase">Is true if the name should be matched ignoring case; false otherwise.</param>
		// Token: 0x060009C4 RID: 2500 RVA: 0x00024E60 File Offset: 0x00023060
		protected SetMemberBinder(string name, bool ignoreCase)
		{
			ContractUtils.RequiresNotNull(name, "name");
			this.Name = name;
			this.IgnoreCase = ignoreCase;
		}

		/// <summary>The result type of the operation.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the result type of the operation.</returns>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000139F2 File Offset: 0x00011BF2
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>Gets the name of the member to obtain.</summary>
		/// <returns>The name of the member to obtain.</returns>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00024E81 File Offset: 0x00023081
		public string Name { get; }

		/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
		/// <returns>True if the case is ignored, otherwise false.</returns>
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00024E89 File Offset: 0x00023089
		public bool IgnoreCase { get; }

		/// <summary>Performs the binding of the dynamic set member operation.</summary>
		/// <param name="target">The target of the dynamic set member operation.</param>
		/// <param name="args">An array of arguments of the dynamic set member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009C8 RID: 2504 RVA: 0x00024E94 File Offset: 0x00023094
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.Requires(args.Length == 1, "args");
			DynamicMetaObject value = args[0];
			ContractUtils.RequiresNotNull(value, "args");
			return target.BindSetMember(this, value);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00007357 File Offset: 0x00005557
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>Performs the binding of the dynamic set member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic set member operation.</param>
		/// <param name="value">The value to set to the member.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009CA RID: 2506 RVA: 0x00024EDE File Offset: 0x000230DE
		public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value)
		{
			return this.FallbackSetMember(target, value, null);
		}

		/// <summary>Performs the binding of the dynamic set member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic set member operation.</param>
		/// <param name="value">The value to set to the member.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009CB RID: 2507
		public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}
}
