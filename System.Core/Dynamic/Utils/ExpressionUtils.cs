using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Dynamic.Utils
{
	// Token: 0x0200013A RID: 314
	internal static class ExpressionUtils
	{
		// Token: 0x060009E4 RID: 2532 RVA: 0x00025294 File Offset: 0x00023494
		public static ReadOnlyCollection<ParameterExpression> ReturnReadOnly(IParameterProvider provider, ref object collection)
		{
			ParameterExpression parameterExpression = collection as ParameterExpression;
			if (parameterExpression != null)
			{
				Interlocked.CompareExchange(ref collection, new ReadOnlyCollection<ParameterExpression>(new ListParameterProvider(provider, parameterExpression)), parameterExpression);
			}
			return (ReadOnlyCollection<ParameterExpression>)collection;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000252C8 File Offset: 0x000234C8
		public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection)
		{
			IReadOnlyList<T> readOnlyList = collection;
			ReadOnlyCollection<T> readOnlyCollection = readOnlyList as ReadOnlyCollection<T>;
			if (readOnlyCollection != null)
			{
				return readOnlyCollection;
			}
			Interlocked.CompareExchange<IReadOnlyList<T>>(ref collection, readOnlyList.ToReadOnly<T>(), readOnlyList);
			return (ReadOnlyCollection<T>)collection;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000252FC File Offset: 0x000234FC
		public static ReadOnlyCollection<Expression> ReturnReadOnly(IArgumentProvider provider, ref object collection)
		{
			Expression expression = collection as Expression;
			if (expression != null)
			{
				Interlocked.CompareExchange(ref collection, new ReadOnlyCollection<Expression>(new ListArgumentProvider(provider, expression)), expression);
			}
			return (ReadOnlyCollection<Expression>)collection;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00025330 File Offset: 0x00023530
		public static T ReturnObject<T>(object collectionOrT) where T : class
		{
			T t = collectionOrT as T;
			if (t != null)
			{
				return t;
			}
			return ((ReadOnlyCollection<T>)collectionOrT)[0];
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00025360 File Offset: 0x00023560
		public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName)
		{
			ParameterInfo[] parametersForValidation = ExpressionUtils.GetParametersForValidation(method, nodeKind);
			ExpressionUtils.ValidateArgumentCount(method, nodeKind, arguments.Count, parametersForValidation);
			Expression[] array = null;
			int i = 0;
			int num = parametersForValidation.Length;
			while (i < num)
			{
				Expression expression = arguments[i];
				ParameterInfo pi = parametersForValidation[i];
				expression = ExpressionUtils.ValidateOneArgument(method, nodeKind, expression, pi, methodParamName, "arguments", i);
				if (array == null && expression != arguments[i])
				{
					array = new Expression[arguments.Count];
					for (int j = 0; j < i; j++)
					{
						array[j] = arguments[j];
					}
				}
				if (array != null)
				{
					array[i] = expression;
				}
				i++;
			}
			if (array != null)
			{
				arguments = new TrueReadOnlyCollection<Expression>(array);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00025408 File Offset: 0x00023608
		public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis)
		{
			if (pis.Length != count)
			{
				if (nodeKind <= ExpressionType.Invoke)
				{
					if (nodeKind != ExpressionType.Call)
					{
						if (nodeKind != ExpressionType.Invoke)
						{
							goto IL_3A;
						}
						throw Error.IncorrectNumberOfLambdaArguments();
					}
				}
				else
				{
					if (nodeKind == ExpressionType.New)
					{
						throw Error.IncorrectNumberOfConstructorArguments();
					}
					if (nodeKind != ExpressionType.Dynamic)
					{
						goto IL_3A;
					}
				}
				throw Error.IncorrectNumberOfMethodCallArguments(method, "method");
				IL_3A:
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00025458 File Offset: 0x00023658
		public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1)
		{
			ExpressionUtils.RequiresCanRead(arguments, argumentParamName, index);
			Type type = pi.ParameterType;
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			TypeUtils.ValidateType(type, methodParamName, true, true);
			if (!TypeUtils.AreReferenceAssignable(type, arguments.Type) && !ExpressionUtils.TryQuote(type, ref arguments))
			{
				if (nodeKind <= ExpressionType.Invoke)
				{
					if (nodeKind != ExpressionType.Call)
					{
						if (nodeKind != ExpressionType.Invoke)
						{
							goto IL_92;
						}
						throw Error.ExpressionTypeDoesNotMatchParameter(arguments.Type, type, argumentParamName, index);
					}
				}
				else
				{
					if (nodeKind == ExpressionType.New)
					{
						throw Error.ExpressionTypeDoesNotMatchConstructorParameter(arguments.Type, type, argumentParamName, index);
					}
					if (nodeKind != ExpressionType.Dynamic)
					{
						goto IL_92;
					}
				}
				throw Error.ExpressionTypeDoesNotMatchMethodParameter(arguments.Type, type, method, argumentParamName, index);
				IL_92:
				throw ContractUtils.Unreachable;
			}
			return arguments;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000254FE File Offset: 0x000236FE
		public static void RequiresCanRead(Expression expression, string paramName)
		{
			ExpressionUtils.RequiresCanRead(expression, paramName, -1);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00025508 File Offset: 0x00023708
		public static void RequiresCanRead(Expression expression, string paramName, int idx)
		{
			ContractUtils.RequiresNotNull(expression, paramName, idx);
			ExpressionType nodeType = expression.NodeType;
			if (nodeType != ExpressionType.MemberAccess)
			{
				if (nodeType == ExpressionType.Index)
				{
					IndexExpression indexExpression = (IndexExpression)expression;
					if (indexExpression.Indexer != null && !indexExpression.Indexer.CanRead)
					{
						throw Error.ExpressionMustBeReadable(paramName, idx);
					}
				}
			}
			else
			{
				PropertyInfo propertyInfo = ((MemberExpression)expression).Member as PropertyInfo;
				if (propertyInfo != null && !propertyInfo.CanRead)
				{
					throw Error.ExpressionMustBeReadable(paramName, idx);
				}
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00025582 File Offset: 0x00023782
		public static bool TryQuote(Type parameterType, ref Expression argument)
		{
			if (TypeUtils.IsSameOrSubclass(typeof(LambdaExpression), parameterType) && parameterType.IsInstanceOfType(argument))
			{
				argument = Expression.Quote(argument);
				return true;
			}
			return false;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000255AC File Offset: 0x000237AC
		internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind)
		{
			ParameterInfo[] array = method.GetParametersCached();
			if (nodeKind == ExpressionType.Dynamic)
			{
				array = array.RemoveFirst<ParameterInfo>();
			}
			return array;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000255D0 File Offset: 0x000237D0
		internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current) where T : class
		{
			if (replacement == current)
			{
				return true;
			}
			if (replacement == null)
			{
				return current.Count == 0;
			}
			ICollection<T> collection = replacement as ICollection<T>;
			if (collection == null)
			{
				replacement = (collection = replacement.ToReadOnly<T>());
			}
			return ExpressionUtils.SameElementsInCollection<T>(collection, current);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00025610 File Offset: 0x00023810
		private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current) where T : class
		{
			int count = current.Count;
			if (replacement.Count != count)
			{
				return false;
			}
			if (count != 0)
			{
				int num = 0;
				using (IEnumerator<T> enumerator = replacement.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current != current[num])
						{
							return false;
						}
						num++;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00025688 File Offset: 0x00023888
		public static void ValidateArgumentCount(this LambdaExpression lambda)
		{
			if (((IParameterProvider)lambda).ParameterCount >= 65535)
			{
				throw Error.InvalidProgram();
			}
		}
	}
}
