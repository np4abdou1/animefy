using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic get member operation at the call site, providing the binding semantic and the details about the operation.</summary>
	// Token: 0x0200012D RID: 301
	public abstract class GetMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.GetMemberBinder" />.</summary>
		/// <param name="name">The name of the member to obtain.</param>
		/// <param name="ignoreCase">Is true if the name should be matched ignoring case; false otherwise.</param>
		// Token: 0x060009AF RID: 2479 RVA: 0x00024D24 File Offset: 0x00022F24
		protected GetMemberBinder(string name, bool ignoreCase)
		{
			ContractUtils.RequiresNotNull(name, "name");
			this.Name = name;
			this.IgnoreCase = ignoreCase;
		}

		/// <summary>The result type of the operation.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the result type of the operation.</returns>
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000139F2 File Offset: 0x00011BF2
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>Gets the name of the member to obtain.</summary>
		/// <returns>The name of the member to obtain.</returns>
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00024D45 File Offset: 0x00022F45
		public string Name { get; }

		/// <summary>Gets the value indicating if the string comparison should ignore the case of the member name.</summary>
		/// <returns>True if the case is ignored, otherwise false.</returns>
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00024D4D File Offset: 0x00022F4D
		public bool IgnoreCase { get; }

		/// <summary>Performs the binding of the dynamic get member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic get member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009B3 RID: 2483 RVA: 0x00024D55 File Offset: 0x00022F55
		public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
		{
			return this.FallbackGetMember(target, null);
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic get member operation if the target dynamic object cannot bind.</summary>
		/// <param name="target">The target of the dynamic get member operation.</param>
		/// <param name="errorSuggestion">The binding result to use if binding fails, or null.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009B4 RID: 2484
		public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>Performs the binding of the dynamic get member operation.</summary>
		/// <param name="target">The target of the dynamic get member operation.</param>
		/// <param name="args">An array of arguments of the dynamic get member operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x060009B5 RID: 2485 RVA: 0x00024D5F File Offset: 0x00022F5F
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindGetMember(this);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00007357 File Offset: 0x00005557
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}
	}
}
