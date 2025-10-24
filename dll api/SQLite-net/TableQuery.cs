using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace SQLite
{
	// Token: 0x0200003C RID: 60
	public class TableQuery<T> : BaseTableQuery, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000071E2 File Offset: 0x000053E2
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000071EA File Offset: 0x000053EA
		public SQLiteConnection Connection { get; private set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000071F3 File Offset: 0x000053F3
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000071FB File Offset: 0x000053FB
		public TableMapping Table { get; private set; }

		// Token: 0x06000190 RID: 400 RVA: 0x00007204 File Offset: 0x00005404
		private TableQuery(SQLiteConnection conn, TableMapping table)
		{
			this.Connection = conn;
			this.Table = table;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000721A File Offset: 0x0000541A
		public TableQuery(SQLiteConnection conn)
		{
			this.Connection = conn;
			this.Table = this.Connection.GetMapping(typeof(T), CreateFlags.None);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007248 File Offset: 0x00005448
		public TableQuery<U> Clone<U>()
		{
			TableQuery<U> tableQuery = new TableQuery<U>(this.Connection, this.Table);
			tableQuery._where = this._where;
			tableQuery._deferred = this._deferred;
			if (this._orderBys != null)
			{
				tableQuery._orderBys = new List<BaseTableQuery.Ordering>(this._orderBys);
			}
			tableQuery._limit = this._limit;
			tableQuery._offset = this._offset;
			tableQuery._joinInner = this._joinInner;
			tableQuery._joinInnerKeySelector = this._joinInnerKeySelector;
			tableQuery._joinOuter = this._joinOuter;
			tableQuery._joinOuterKeySelector = this._joinOuterKeySelector;
			tableQuery._joinSelector = this._joinSelector;
			tableQuery._selector = this._selector;
			return tableQuery;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000072FC File Offset: 0x000054FC
		public TableQuery<T> Where(Expression<Func<T, bool>> predExpr)
		{
			if (predExpr.NodeType == ExpressionType.Lambda)
			{
				Expression body = predExpr.Body;
				TableQuery<T> tableQuery = this.Clone<T>();
				tableQuery.AddWhere(body);
				return tableQuery;
			}
			throw new NotSupportedException("Must be a predicate");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007332 File Offset: 0x00005532
		public int Delete()
		{
			return this.Delete(null);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000733C File Offset: 0x0000553C
		public int Delete(Expression<Func<T, bool>> predExpr)
		{
			if (this._limit != null || this._offset != null)
			{
				throw new InvalidOperationException("Cannot delete with limits or offsets");
			}
			if (this._where == null && predExpr == null)
			{
				throw new InvalidOperationException("No condition specified");
			}
			Expression expression = this._where;
			if (predExpr != null && predExpr.NodeType == ExpressionType.Lambda)
			{
				expression = ((expression != null) ? Expression.AndAlso(expression, predExpr.Body) : predExpr.Body);
			}
			List<object> list = new List<object>();
			string text = "delete from \"" + this.Table.TableName + "\"";
			TableQuery<T>.CompileResult compileResult = this.CompileExpr(expression, list);
			text = text + " where " + compileResult.CommandText;
			return this.Connection.CreateCommand(text, list.ToArray()).ExecuteNonQuery();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00007408 File Offset: 0x00005608
		public TableQuery<T> Take(int n)
		{
			TableQuery<T> tableQuery = this.Clone<T>();
			tableQuery._limit = new int?(n);
			return tableQuery;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000741C File Offset: 0x0000561C
		public TableQuery<T> Skip(int n)
		{
			TableQuery<T> tableQuery = this.Clone<T>();
			tableQuery._offset = new int?(n);
			return tableQuery;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007430 File Offset: 0x00005630
		public T ElementAt(int index)
		{
			return this.Skip(index).Take(1).First();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007444 File Offset: 0x00005644
		public TableQuery<T> Deferred()
		{
			TableQuery<T> tableQuery = this.Clone<T>();
			tableQuery._deferred = true;
			return tableQuery;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007453 File Offset: 0x00005653
		public TableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return this.AddOrderBy<U>(orderExpr, true);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000745D File Offset: 0x0000565D
		public TableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return this.AddOrderBy<U>(orderExpr, false);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007453 File Offset: 0x00005653
		public TableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr)
		{
			return this.AddOrderBy<U>(orderExpr, true);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000745D File Offset: 0x0000565D
		public TableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr)
		{
			return this.AddOrderBy<U>(orderExpr, false);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007468 File Offset: 0x00005668
		private TableQuery<T> AddOrderBy<U>(Expression<Func<T, U>> orderExpr, bool asc)
		{
			if (orderExpr.NodeType != ExpressionType.Lambda)
			{
				throw new NotSupportedException("Must be a predicate");
			}
			UnaryExpression unaryExpression = orderExpr.Body as UnaryExpression;
			MemberExpression memberExpression;
			if (unaryExpression != null && unaryExpression.NodeType == ExpressionType.Convert)
			{
				memberExpression = (unaryExpression.Operand as MemberExpression);
			}
			else
			{
				memberExpression = (orderExpr.Body as MemberExpression);
			}
			if (memberExpression != null && memberExpression.Expression.NodeType == ExpressionType.Parameter)
			{
				TableQuery<T> tableQuery = this.Clone<T>();
				if (tableQuery._orderBys == null)
				{
					tableQuery._orderBys = new List<BaseTableQuery.Ordering>();
				}
				tableQuery._orderBys.Add(new BaseTableQuery.Ordering
				{
					ColumnName = this.Table.FindColumnWithPropertyName(memberExpression.Member.Name).Name,
					Ascending = asc
				});
				return tableQuery;
			}
			throw new NotSupportedException("Order By does not support: " + ((orderExpr != null) ? orderExpr.ToString() : null));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007546 File Offset: 0x00005746
		private void AddWhere(Expression pred)
		{
			if (this._where == null)
			{
				this._where = pred;
				return;
			}
			this._where = Expression.AndAlso(this._where, pred);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000756C File Offset: 0x0000576C
		private SQLiteCommand GenerateCommand(string selectionList)
		{
			if (this._joinInner != null && this._joinOuter != null)
			{
				throw new NotSupportedException("Joins are not supported.");
			}
			string text = string.Concat(new string[]
			{
				"select ",
				selectionList,
				" from \"",
				this.Table.TableName,
				"\""
			});
			List<object> list = new List<object>();
			if (this._where != null)
			{
				TableQuery<T>.CompileResult compileResult = this.CompileExpr(this._where, list);
				text = text + " where " + compileResult.CommandText;
			}
			if (this._orderBys != null && this._orderBys.Count > 0)
			{
				string str = string.Join(", ", (from o in this._orderBys
				select "\"" + o.ColumnName + "\"" + (o.Ascending ? "" : " desc")).ToArray<string>());
				text = text + " order by " + str;
			}
			if (this._limit != null)
			{
				text = text + " limit " + this._limit.Value.ToString();
			}
			if (this._offset != null)
			{
				if (this._limit == null)
				{
					text += " limit -1 ";
				}
				text = text + " offset " + this._offset.Value.ToString();
			}
			return this.Connection.CreateCommand(text, list.ToArray());
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000076DC File Offset: 0x000058DC
		private TableQuery<T>.CompileResult CompileExpr(Expression expr, List<object> queryArgs)
		{
			if (expr == null)
			{
				throw new NotSupportedException("Expression is NULL");
			}
			if (expr is BinaryExpression)
			{
				BinaryExpression binaryExpression = (BinaryExpression)expr;
				if (binaryExpression.Left.NodeType == ExpressionType.Call)
				{
					MethodCallExpression methodCallExpression = (MethodCallExpression)binaryExpression.Left;
					if (methodCallExpression.Method.DeclaringType.FullName == "Microsoft.VisualBasic.CompilerServices.Operators" && methodCallExpression.Method.Name == "CompareString")
					{
						binaryExpression = Expression.MakeBinary(binaryExpression.NodeType, methodCallExpression.Arguments[0], methodCallExpression.Arguments[1]);
					}
				}
				TableQuery<T>.CompileResult compileResult = this.CompileExpr(binaryExpression.Left, queryArgs);
				TableQuery<T>.CompileResult compileResult2 = this.CompileExpr(binaryExpression.Right, queryArgs);
				string commandText;
				if (compileResult.CommandText == "?" && compileResult.Value == null)
				{
					commandText = this.CompileNullBinaryExpression(binaryExpression, compileResult2);
				}
				else if (compileResult2.CommandText == "?" && compileResult2.Value == null)
				{
					commandText = this.CompileNullBinaryExpression(binaryExpression, compileResult);
				}
				else
				{
					commandText = string.Concat(new string[]
					{
						"(",
						compileResult.CommandText,
						" ",
						this.GetSqlName(binaryExpression),
						" ",
						compileResult2.CommandText,
						")"
					});
				}
				return new TableQuery<T>.CompileResult
				{
					CommandText = commandText
				};
			}
			if (expr.NodeType == ExpressionType.Not)
			{
				Expression operand = ((UnaryExpression)expr).Operand;
				TableQuery<T>.CompileResult compileResult3 = this.CompileExpr(operand, queryArgs);
				object obj = compileResult3.Value;
				if (obj is bool)
				{
					obj = !(bool)obj;
				}
				return new TableQuery<T>.CompileResult
				{
					CommandText = "NOT(" + compileResult3.CommandText + ")",
					Value = obj
				};
			}
			if (expr.NodeType == ExpressionType.Call)
			{
				MethodCallExpression methodCallExpression2 = (MethodCallExpression)expr;
				TableQuery<T>.CompileResult[] array = new TableQuery<T>.CompileResult[methodCallExpression2.Arguments.Count];
				TableQuery<T>.CompileResult compileResult4 = (methodCallExpression2.Object != null) ? this.CompileExpr(methodCallExpression2.Object, queryArgs) : null;
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.CompileExpr(methodCallExpression2.Arguments[i], queryArgs);
				}
				string commandText2 = "";
				if (methodCallExpression2.Method.Name == "Like" && array.Length == 2)
				{
					commandText2 = string.Concat(new string[]
					{
						"(",
						array[0].CommandText,
						" like ",
						array[1].CommandText,
						")"
					});
				}
				else if (methodCallExpression2.Method.Name == "Contains" && array.Length == 2)
				{
					commandText2 = string.Concat(new string[]
					{
						"(",
						array[1].CommandText,
						" in ",
						array[0].CommandText,
						")"
					});
				}
				else if (methodCallExpression2.Method.Name == "Contains" && array.Length == 1)
				{
					if (methodCallExpression2.Object != null && methodCallExpression2.Object.Type == typeof(string))
					{
						commandText2 = string.Concat(new string[]
						{
							"( instr(",
							compileResult4.CommandText,
							",",
							array[0].CommandText,
							") >0 )"
						});
					}
					else
					{
						commandText2 = string.Concat(new string[]
						{
							"(",
							array[0].CommandText,
							" in ",
							compileResult4.CommandText,
							")"
						});
					}
				}
				else if (methodCallExpression2.Method.Name == "StartsWith" && array.Length >= 1)
				{
					StringComparison stringComparison = StringComparison.CurrentCulture;
					if (array.Length == 2)
					{
						stringComparison = (StringComparison)array[1].Value;
					}
					switch (stringComparison)
					{
					case StringComparison.CurrentCulture:
					case StringComparison.Ordinal:
						commandText2 = string.Concat(new string[]
						{
							"( substr(",
							compileResult4.CommandText,
							", 1, ",
							array[0].Value.ToString().Length.ToString(),
							") =  ",
							array[0].CommandText,
							")"
						});
						break;
					case StringComparison.CurrentCultureIgnoreCase:
					case StringComparison.OrdinalIgnoreCase:
						commandText2 = string.Concat(new string[]
						{
							"(",
							compileResult4.CommandText,
							" like (",
							array[0].CommandText,
							" || '%'))"
						});
						break;
					}
				}
				else if (methodCallExpression2.Method.Name == "EndsWith" && array.Length >= 1)
				{
					StringComparison stringComparison2 = StringComparison.CurrentCulture;
					if (array.Length == 2)
					{
						stringComparison2 = (StringComparison)array[1].Value;
					}
					switch (stringComparison2)
					{
					case StringComparison.CurrentCulture:
					case StringComparison.Ordinal:
						commandText2 = string.Concat(new string[]
						{
							"( substr(",
							compileResult4.CommandText,
							", length(",
							compileResult4.CommandText,
							") - ",
							array[0].Value.ToString().Length.ToString(),
							"+1, ",
							array[0].Value.ToString().Length.ToString(),
							") =  ",
							array[0].CommandText,
							")"
						});
						break;
					case StringComparison.CurrentCultureIgnoreCase:
					case StringComparison.OrdinalIgnoreCase:
						commandText2 = string.Concat(new string[]
						{
							"(",
							compileResult4.CommandText,
							" like ('%' || ",
							array[0].CommandText,
							"))"
						});
						break;
					}
				}
				else if (methodCallExpression2.Method.Name == "Equals" && array.Length == 1)
				{
					commandText2 = string.Concat(new string[]
					{
						"(",
						compileResult4.CommandText,
						" = (",
						array[0].CommandText,
						"))"
					});
				}
				else if (methodCallExpression2.Method.Name == "ToLower")
				{
					commandText2 = "(lower(" + compileResult4.CommandText + "))";
				}
				else if (methodCallExpression2.Method.Name == "ToUpper")
				{
					commandText2 = "(upper(" + compileResult4.CommandText + "))";
				}
				else if (methodCallExpression2.Method.Name == "Replace" && array.Length == 2)
				{
					commandText2 = string.Concat(new string[]
					{
						"(replace(",
						compileResult4.CommandText,
						",",
						array[0].CommandText,
						",",
						array[1].CommandText,
						"))"
					});
				}
				else if (methodCallExpression2.Method.Name == "IsNullOrEmpty" && array.Length == 1)
				{
					commandText2 = string.Concat(new string[]
					{
						"(",
						array[0].CommandText,
						" is null or",
						array[0].CommandText,
						" ='' )"
					});
				}
				else
				{
					commandText2 = methodCallExpression2.Method.Name.ToLower() + "(" + string.Join(",", (from a in array
					select a.CommandText).ToArray<string>()) + ")";
				}
				return new TableQuery<T>.CompileResult
				{
					CommandText = commandText2
				};
			}
			if (expr.NodeType == ExpressionType.Constant)
			{
				ConstantExpression constantExpression = (ConstantExpression)expr;
				queryArgs.Add(constantExpression.Value);
				return new TableQuery<T>.CompileResult
				{
					CommandText = "?",
					Value = constantExpression.Value
				};
			}
			if (expr.NodeType == ExpressionType.Convert)
			{
				UnaryExpression unaryExpression = (UnaryExpression)expr;
				Type type = unaryExpression.Type;
				TableQuery<T>.CompileResult compileResult5 = this.CompileExpr(unaryExpression.Operand, queryArgs);
				return new TableQuery<T>.CompileResult
				{
					CommandText = compileResult5.CommandText,
					Value = ((compileResult5.Value != null) ? TableQuery<T>.ConvertTo(compileResult5.Value, type) : null)
				};
			}
			if (expr.NodeType != ExpressionType.MemberAccess)
			{
				throw new NotSupportedException("Cannot compile: " + expr.NodeType.ToString());
			}
			MemberExpression memberExpression = (MemberExpression)expr;
			ParameterExpression parameterExpression = memberExpression.Expression as ParameterExpression;
			if (parameterExpression == null)
			{
				UnaryExpression unaryExpression2 = memberExpression.Expression as UnaryExpression;
				if (unaryExpression2 != null && unaryExpression2.NodeType == ExpressionType.Convert)
				{
					parameterExpression = (unaryExpression2.Operand as ParameterExpression);
				}
			}
			if (parameterExpression != null)
			{
				string name = this.Table.FindColumnWithPropertyName(memberExpression.Member.Name).Name;
				return new TableQuery<T>.CompileResult
				{
					CommandText = "\"" + name + "\""
				};
			}
			object obj2 = null;
			if (memberExpression.Expression != null)
			{
				TableQuery<T>.CompileResult compileResult6 = this.CompileExpr(memberExpression.Expression, queryArgs);
				if (compileResult6.Value == null)
				{
					throw new NotSupportedException("Member access failed to compile expression");
				}
				if (compileResult6.CommandText == "?")
				{
					queryArgs.RemoveAt(queryArgs.Count - 1);
				}
				obj2 = compileResult6.Value;
			}
			object obj3 = null;
			if (memberExpression.Member is PropertyInfo)
			{
				obj3 = ((PropertyInfo)memberExpression.Member).GetValue(obj2, null);
			}
			else
			{
				if (!(memberExpression.Member is FieldInfo))
				{
					string str = "MemberExpr: ";
					Type type2 = memberExpression.Member.GetType();
					throw new NotSupportedException(str + ((type2 != null) ? type2.ToString() : null));
				}
				obj3 = ((FieldInfo)memberExpression.Member).GetValue(obj2);
			}
			if (obj3 != null && obj3 is IEnumerable && !(obj3 is string) && !(obj3 is IEnumerable<byte>))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("(");
				string value = "";
				foreach (object item in ((IEnumerable)obj3))
				{
					queryArgs.Add(item);
					stringBuilder.Append(value);
					stringBuilder.Append("?");
					value = ",";
				}
				stringBuilder.Append(")");
				return new TableQuery<T>.CompileResult
				{
					CommandText = stringBuilder.ToString(),
					Value = obj3
				};
			}
			queryArgs.Add(obj3);
			return new TableQuery<T>.CompileResult
			{
				CommandText = "?",
				Value = obj3
			};
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008214 File Offset: 0x00006414
		private static object ConvertTo(object obj, Type t)
		{
			Type underlyingType = Nullable.GetUnderlyingType(t);
			if (!(underlyingType != null))
			{
				return Convert.ChangeType(obj, t);
			}
			if (obj == null)
			{
				return null;
			}
			return Convert.ChangeType(obj, underlyingType);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00008248 File Offset: 0x00006448
		private string CompileNullBinaryExpression(BinaryExpression expression, TableQuery<T>.CompileResult parameter)
		{
			if (expression.NodeType == ExpressionType.Equal)
			{
				return "(" + parameter.CommandText + " is ?)";
			}
			if (expression.NodeType == ExpressionType.NotEqual)
			{
				return "(" + parameter.CommandText + " is not ?)";
			}
			if (expression.NodeType == ExpressionType.GreaterThan || expression.NodeType == ExpressionType.GreaterThanOrEqual || expression.NodeType == ExpressionType.LessThan || expression.NodeType == ExpressionType.LessThanOrEqual)
			{
				return "(" + parameter.CommandText + " < ?)";
			}
			throw new NotSupportedException("Cannot compile Null-BinaryExpression with type " + expression.NodeType.ToString());
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000082F8 File Offset: 0x000064F8
		private string GetSqlName(Expression expr)
		{
			ExpressionType nodeType = expr.NodeType;
			if (nodeType == ExpressionType.GreaterThan)
			{
				return ">";
			}
			if (nodeType == ExpressionType.GreaterThanOrEqual)
			{
				return ">=";
			}
			if (nodeType == ExpressionType.LessThan)
			{
				return "<";
			}
			if (nodeType == ExpressionType.LessThanOrEqual)
			{
				return "<=";
			}
			if (nodeType == ExpressionType.And)
			{
				return "&";
			}
			if (nodeType == ExpressionType.AndAlso)
			{
				return "and";
			}
			if (nodeType == ExpressionType.Or)
			{
				return "|";
			}
			if (nodeType == ExpressionType.OrElse)
			{
				return "or";
			}
			if (nodeType == ExpressionType.Equal)
			{
				return "=";
			}
			if (nodeType == ExpressionType.NotEqual)
			{
				return "!=";
			}
			throw new NotSupportedException("Cannot get SQL for: " + nodeType.ToString());
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008394 File Offset: 0x00006594
		public int Count()
		{
			return this.GenerateCommand("count(*)").ExecuteScalar<int>();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000083A6 File Offset: 0x000065A6
		public int Count(Expression<Func<T, bool>> predExpr)
		{
			return this.Where(predExpr).Count();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000083B4 File Offset: 0x000065B4
		public IEnumerator<T> GetEnumerator()
		{
			if (!this._deferred)
			{
				return this.GenerateCommand("*").ExecuteQuery<T>().GetEnumerator();
			}
			return this.GenerateCommand("*").ExecuteDeferredQuery<T>().GetEnumerator();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000083EE File Offset: 0x000065EE
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000083F6 File Offset: 0x000065F6
		public List<T> ToList()
		{
			return this.GenerateCommand("*").ExecuteQuery<T>();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008408 File Offset: 0x00006608
		public T[] ToArray()
		{
			return this.GenerateCommand("*").ExecuteQuery<T>().ToArray();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000841F File Offset: 0x0000661F
		public T First()
		{
			return this.Take(1).ToList().First<T>();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00008432 File Offset: 0x00006632
		public T FirstOrDefault()
		{
			return this.Take(1).ToList().FirstOrDefault<T>();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008445 File Offset: 0x00006645
		public T First(Expression<Func<T, bool>> predExpr)
		{
			return this.Where(predExpr).First();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008453 File Offset: 0x00006653
		public T FirstOrDefault(Expression<Func<T, bool>> predExpr)
		{
			return this.Where(predExpr).FirstOrDefault();
		}

		// Token: 0x040000DE RID: 222
		private Expression _where;

		// Token: 0x040000DF RID: 223
		private List<BaseTableQuery.Ordering> _orderBys;

		// Token: 0x040000E0 RID: 224
		private int? _limit;

		// Token: 0x040000E1 RID: 225
		private int? _offset;

		// Token: 0x040000E2 RID: 226
		private BaseTableQuery _joinInner;

		// Token: 0x040000E3 RID: 227
		private Expression _joinInnerKeySelector;

		// Token: 0x040000E4 RID: 228
		private BaseTableQuery _joinOuter;

		// Token: 0x040000E5 RID: 229
		private Expression _joinOuterKeySelector;

		// Token: 0x040000E6 RID: 230
		private Expression _joinSelector;

		// Token: 0x040000E7 RID: 231
		private Expression _selector;

		// Token: 0x040000E8 RID: 232
		private bool _deferred;

		// Token: 0x0200003D RID: 61
		private class CompileResult
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060001AF RID: 431 RVA: 0x00008461 File Offset: 0x00006661
			// (set) Token: 0x060001B0 RID: 432 RVA: 0x00008469 File Offset: 0x00006669
			public string CommandText { get; set; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060001B1 RID: 433 RVA: 0x00008472 File Offset: 0x00006672
			// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000847A File Offset: 0x0000667A
			public object Value { get; set; }
		}
	}
}
