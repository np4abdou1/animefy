using System;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	/// <summary>The dynamic call site binder that participates in the <see cref="T:System.Dynamic.DynamicMetaObject" /> binding protocol.</summary>
	// Token: 0x0200011E RID: 286
	public abstract class DynamicMetaObjectBinder : CallSiteBinder
	{
		/// <summary>The result type of the operation.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the result type of the operation.</returns>
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000139F2 File Offset: 0x00011BF2
		public virtual Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>Performs the runtime binding of the dynamic operation on a set of arguments.</summary>
		/// <param name="args">An array of arguments to the dynamic operation.</param>
		/// <param name="parameters">The array of <see cref="T:System.Linq.Expressions.ParameterExpression" /> instances that represent the parameters of the call site in the binding process.</param>
		/// <param name="returnLabel">A LabelTarget used to return the result of the dynamic binding.</param>
		/// <returns>An Expression that performs tests on the dynamic operation arguments, and performs the dynamic operation if the tests are valid. If the tests fail on subsequent occurrences of the dynamic operation, Bind will be called again to produce a new <see cref="T:System.Linq.Expressions.Expression" /> for the new argument types.</returns>
		// Token: 0x06000938 RID: 2360 RVA: 0x0002348C File Offset: 0x0002168C
		public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
		{
			ContractUtils.RequiresNotNull(args, "args");
			ContractUtils.RequiresNotNull(parameters, "parameters");
			ContractUtils.RequiresNotNull(returnLabel, "returnLabel");
			if (args.Length == 0)
			{
				throw Error.OutOfRange("args.Length", 1);
			}
			if (parameters.Count == 0)
			{
				throw Error.OutOfRange("parameters.Count", 1);
			}
			if (args.Length != parameters.Count)
			{
				throw new ArgumentOutOfRangeException("args");
			}
			Type type;
			if (this.IsStandardBinder)
			{
				type = this.ReturnType;
				if (returnLabel.Type != typeof(void) && !TypeUtils.AreReferenceAssignable(returnLabel.Type, type))
				{
					throw Error.BinderNotCompatibleWithCallSite(type, this, returnLabel.Type);
				}
			}
			else
			{
				type = returnLabel.Type;
			}
			DynamicMetaObject dynamicMetaObject = DynamicMetaObject.Create(args[0], parameters[0]);
			DynamicMetaObject[] args2 = DynamicMetaObjectBinder.CreateArgumentMetaObjects(args, parameters);
			DynamicMetaObject dynamicMetaObject2 = this.Bind(dynamicMetaObject, args2);
			if (dynamicMetaObject2 == null)
			{
				throw Error.BindingCannotBeNull();
			}
			Expression expression = dynamicMetaObject2.Expression;
			BindingRestrictions restrictions = dynamicMetaObject2.Restrictions;
			if (type != typeof(void) && !TypeUtils.AreReferenceAssignable(type, expression.Type))
			{
				if (dynamicMetaObject.Value is IDynamicMetaObjectProvider)
				{
					throw Error.DynamicObjectResultNotAssignable(expression.Type, dynamicMetaObject.Value.GetType(), this, type);
				}
				throw Error.DynamicBinderResultNotAssignable(expression.Type, this, type);
			}
			else
			{
				if (this.IsStandardBinder && args[0] is IDynamicMetaObjectProvider && restrictions == BindingRestrictions.Empty)
				{
					throw Error.DynamicBindingNeedsRestrictions(dynamicMetaObject.Value.GetType(), this);
				}
				if (expression.NodeType != ExpressionType.Goto)
				{
					expression = Expression.Return(returnLabel, expression);
				}
				if (restrictions != BindingRestrictions.Empty)
				{
					expression = Expression.IfThen(restrictions.ToExpression(), expression);
				}
				return expression;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0002362C File Offset: 0x0002182C
		private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters)
		{
			DynamicMetaObject[] array;
			if (args.Length != 1)
			{
				array = new DynamicMetaObject[args.Length - 1];
				for (int i = 1; i < args.Length; i++)
				{
					array[i - 1] = DynamicMetaObject.Create(args[i], parameters[i]);
				}
			}
			else
			{
				array = DynamicMetaObject.EmptyMetaObjects;
			}
			return array;
		}

		/// <summary>When overridden in the derived class, performs the binding of the dynamic operation.</summary>
		/// <param name="target">The target of the dynamic operation.</param>
		/// <param name="args">An array of arguments of the dynamic operation.</param>
		/// <returns>The <see cref="T:System.Dynamic.DynamicMetaObject" /> representing the result of the binding.</returns>
		// Token: 0x0600093A RID: 2362
		public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

		/// <summary>Gets an expression that will cause the binding to be updated. It indicates that the expression's binding is no longer valid. This is typically used when the "version" of a dynamic object has changed.</summary>
		/// <param name="type">The <see cref="P:System.Linq.Expressions.Expression.Type" /> property of the resulting expression; any type is allowed.</param>
		/// <returns>The update expression.</returns>
		// Token: 0x0600093B RID: 2363 RVA: 0x00023675 File Offset: 0x00021875
		public Expression GetUpdateExpression(Type type)
		{
			return Expression.Goto(CallSiteBinder.UpdateLabel, type);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00008049 File Offset: 0x00006249
		internal virtual bool IsStandardBinder
		{
			get
			{
				return false;
			}
		}
	}
}
