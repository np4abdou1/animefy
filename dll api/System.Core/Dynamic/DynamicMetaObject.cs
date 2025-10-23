using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;

namespace System.Dynamic
{
	/// <summary>Represents the dynamic binding and a binding logic of an object participating in the dynamic binding.</summary>
	// Token: 0x0200011D RID: 285
	public class DynamicMetaObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.DynamicMetaObject" /> class.</summary>
		/// <param name="expression">The expression representing this <see cref="T:System.Dynamic.DynamicMetaObject" /> during the dynamic binding process.</param>
		/// <param name="restrictions">The set of binding restrictions under which the binding is valid.</param>
		// Token: 0x0600091F RID: 2335 RVA: 0x00023235 File Offset: 0x00021435
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			ContractUtils.RequiresNotNull(restrictions, "restrictions");
			this.Expression = expression;
			this.Restrictions = restrictions;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Dynamic.DynamicMetaObject" /> class.</summary>
		/// <param name="expression">The expression representing this <see cref="T:System.Dynamic.DynamicMetaObject" /> during the dynamic binding process.</param>
		/// <param name="restrictions">The set of binding restrictions under which the binding is valid.</param>
		/// <param name="value">The runtime value represented by the <see cref="T:System.Dynamic.DynamicMetaObject" />.</param>
		// Token: 0x06000920 RID: 2336 RVA: 0x0002326C File Offset: 0x0002146C
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) : this(expression, restrictions)
		{
			this._value = value;
		}

		/// <summary>The expression representing the <see cref="T:System.Dynamic.DynamicMetaObject" /> during the dynamic binding process.</summary>
		/// <returns>The expression representing the <see cref="T:System.Dynamic.DynamicMetaObject" /> during the dynamic binding process.</returns>
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0002327D File Offset: 0x0002147D
		public Expression Expression { get; }

		/// <summary>The set of binding restrictions under which the binding is valid.</summary>
		/// <returns>The set of binding restrictions.</returns>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00023285 File Offset: 0x00021485
		public BindingRestrictions Restrictions { get; }

		/// <summary>The runtime value represented by this <see cref="T:System.Dynamic.DynamicMetaObject" />.</summary>
		/// <returns>The runtime value represented by this <see cref="T:System.Dynamic.DynamicMetaObject" />.</returns>
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0002328D File Offset: 0x0002148D
		public object Value
		{
			get
			{
				if (!this.HasValue)
				{
					return null;
				}
				return this._value;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Dynamic.DynamicMetaObject" /> has the runtime value.</summary>
		/// <returns>True if the <see cref="T:System.Dynamic.DynamicMetaObject" /> has the runtime value, otherwise false.</returns>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002329F File Offset: 0x0002149F
		public bool HasValue
		{
			get
			{
				return this._value != DynamicMetaObject.s_noValueSentinel;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the runtime value or null if the <see cref="T:System.Dynamic.DynamicMetaObject" /> has no value associated with it.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the runtime value or null.</returns>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000232B4 File Offset: 0x000214B4
		public Type RuntimeType
		{
			get
			{
				if (!this.HasValue)
				{
					return null;
				}
				Type type = this.Expression.Type;
				if (type.IsValueType)
				{
					return type;
				}
				object value = this.Value;
				if (value == null)
				{
					return null;
				}
				return value.GetType();
			}
		}

		/// <summary>Gets the limit type of the <see cref="T:System.Dynamic.DynamicMetaObject" />.</summary>
		/// <returns>
		///     <see cref="P:System.Dynamic.DynamicMetaObject.RuntimeType" /> if runtime value is available, a type of the <see cref="P:System.Dynamic.DynamicMetaObject.Expression" /> otherwise.</returns>
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x000232F2 File Offset: 0x000214F2
		public Type LimitType
		{
			get
			{
				return this.RuntimeType ?? this.Expression.Type;
			}
		}

		/// <summary>Performs the binding of the dynamic conversion operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.ConvertBinder" /> that represents the details of the dynamic operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000927 RID: 2343 RVA: 0x00023309 File Offset: 0x00021509
		public virtual DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackConvert(this);
		}

		/// <summary>Performs the binding of the dynamic get member operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.GetMemberBinder" /> that represents the details of the dynamic operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000928 RID: 2344 RVA: 0x0002331D File Offset: 0x0002151D
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackGetMember(this);
		}

		/// <summary>Performs the binding of the dynamic set member operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.SetMemberBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="value">The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the value for the set member operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000929 RID: 2345 RVA: 0x00023331 File Offset: 0x00021531
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackSetMember(this, value);
		}

		/// <summary>Performs the binding of the dynamic delete member operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.DeleteMemberBinder" /> that represents the details of the dynamic operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092A RID: 2346 RVA: 0x00023346 File Offset: 0x00021546
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackDeleteMember(this);
		}

		/// <summary>Performs the binding of the dynamic get index operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.GetIndexBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="indexes">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - indexes for the get index operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092B RID: 2347 RVA: 0x0002335A File Offset: 0x0002155A
		public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackGetIndex(this, indexes);
		}

		/// <summary>Performs the binding of the dynamic set index operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.SetIndexBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="indexes">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - indexes for the set index operation.</param>
		/// <param name="value">The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the value for the set index operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092C RID: 2348 RVA: 0x0002336F File Offset: 0x0002156F
		public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackSetIndex(this, indexes, value);
		}

		/// <summary>Performs the binding of the dynamic delete index operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.DeleteIndexBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="indexes">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - indexes for the delete index operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092D RID: 2349 RVA: 0x00023385 File Offset: 0x00021585
		public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackDeleteIndex(this, indexes);
		}

		/// <summary>Performs the binding of the dynamic invoke member operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.InvokeMemberBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="args">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - arguments to the invoke member operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092E RID: 2350 RVA: 0x0002339A File Offset: 0x0002159A
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackInvokeMember(this, args);
		}

		/// <summary>Performs the binding of the dynamic invoke operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.InvokeBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="args">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - arguments to the invoke operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600092F RID: 2351 RVA: 0x000233AF File Offset: 0x000215AF
		public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackInvoke(this, args);
		}

		/// <summary>Performs the binding of the dynamic create instance operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.CreateInstanceBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="args">An array of <see cref="T:System.Dynamic.DynamicMetaObject" /> instances - arguments to the create instance operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000930 RID: 2352 RVA: 0x000233C4 File Offset: 0x000215C4
		public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackCreateInstance(this, args);
		}

		/// <summary>Performs the binding of the dynamic unary operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.UnaryOperationBinder" /> that represents the details of the dynamic operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000931 RID: 2353 RVA: 0x000233D9 File Offset: 0x000215D9
		public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackUnaryOperation(this);
		}

		/// <summary>Performs the binding of the dynamic binary operation.</summary>
		/// <param name="binder">An instance of the <see cref="T:System.Dynamic.BinaryOperationBinder" /> that represents the details of the dynamic operation.</param>
		/// <param name="arg">An instance of the <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the right hand side of the binary operation.</param>
		/// <returns>The new <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x06000932 RID: 2354 RVA: 0x000233ED File Offset: 0x000215ED
		public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			ContractUtils.RequiresNotNull(binder, "binder");
			return binder.FallbackBinaryOperation(this, arg);
		}

		/// <summary>Returns the enumeration of all dynamic member names.</summary>
		/// <returns>The list of dynamic member names.</returns>
		// Token: 0x06000933 RID: 2355 RVA: 0x00023402 File Offset: 0x00021602
		public virtual IEnumerable<string> GetDynamicMemberNames()
		{
			return Array.Empty<string>();
		}

		/// <summary>Creates a meta-object for the specified object.</summary>
		/// <param name="value">The object to get a meta-object for.</param>
		/// <param name="expression">The expression representing this <see cref="T:System.Dynamic.DynamicMetaObject" /> during the dynamic binding process.</param>
		/// <returns>If the given object implements <see cref="T:System.Dynamic.IDynamicMetaObjectProvider" /> and is not a remote object from outside the current AppDomain, returns the object's specific meta-object returned by <see cref="M:System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression)" />. Otherwise a plain new meta-object with no restrictions is created and returned.</returns>
		// Token: 0x06000934 RID: 2356 RVA: 0x0002340C File Offset: 0x0002160C
		public static DynamicMetaObject Create(object value, Expression expression)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			IDynamicMetaObjectProvider dynamicMetaObjectProvider = value as IDynamicMetaObjectProvider;
			if (dynamicMetaObjectProvider == null)
			{
				return new DynamicMetaObject(expression, BindingRestrictions.Empty, value);
			}
			DynamicMetaObject metaObject = dynamicMetaObjectProvider.GetMetaObject(expression);
			if (metaObject == null || !metaObject.HasValue || metaObject.Value == null || metaObject.Expression != expression)
			{
				throw Error.InvalidMetaObjectCreated(dynamicMetaObjectProvider.GetType());
			}
			return metaObject;
		}

		/// <summary>Represents an empty array of type <see cref="T:System.Dynamic.DynamicMetaObject" />. This field is read only.</summary>
		// Token: 0x040002BA RID: 698
		public static readonly DynamicMetaObject[] EmptyMetaObjects = Array.Empty<DynamicMetaObject>();

		// Token: 0x040002BB RID: 699
		private static readonly object s_noValueSentinel = new object();

		// Token: 0x040002BC RID: 700
		private readonly object _value = DynamicMetaObject.s_noValueSentinel;
	}
}
