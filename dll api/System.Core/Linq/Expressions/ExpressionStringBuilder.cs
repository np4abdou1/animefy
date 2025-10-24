using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Linq.Expressions
{
	// Token: 0x02000088 RID: 136
	internal sealed class ExpressionStringBuilder : ExpressionVisitor
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0001093A File Offset: 0x0000EB3A
		private ExpressionStringBuilder()
		{
			this._out = new StringBuilder();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001094D File Offset: 0x0000EB4D
		public override string ToString()
		{
			return this._out.ToString();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001095A File Offset: 0x0000EB5A
		private int GetLabelId(LabelTarget label)
		{
			return this.GetId(label);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001095A File Offset: 0x0000EB5A
		private int GetParamId(ParameterExpression p)
		{
			return this.GetId(p);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00010964 File Offset: 0x0000EB64
		private int GetId(object o)
		{
			if (this._ids == null)
			{
				this._ids = new Dictionary<object, int>();
			}
			int count;
			if (!this._ids.TryGetValue(o, out count))
			{
				count = this._ids.Count;
				this._ids.Add(o, count);
			}
			return count;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000109AE File Offset: 0x0000EBAE
		private void Out(string s)
		{
			this._out.Append(s);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000109BD File Offset: 0x0000EBBD
		private void Out(char c)
		{
			this._out.Append(c);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000109CC File Offset: 0x0000EBCC
		internal static string ExpressionToString(Expression node)
		{
			ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
			expressionStringBuilder.Visit(node);
			return expressionStringBuilder.ToString();
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000109E0 File Offset: 0x0000EBE0
		internal static string CatchBlockToString(CatchBlock node)
		{
			ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
			expressionStringBuilder.VisitCatchBlock(node);
			return expressionStringBuilder.ToString();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000109F4 File Offset: 0x0000EBF4
		internal static string SwitchCaseToString(SwitchCase node)
		{
			ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
			expressionStringBuilder.VisitSwitchCase(node);
			return expressionStringBuilder.ToString();
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00010A08 File Offset: 0x0000EC08
		internal static string MemberBindingToString(MemberBinding node)
		{
			ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
			expressionStringBuilder.VisitMemberBinding(node);
			return expressionStringBuilder.ToString();
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00010A1C File Offset: 0x0000EC1C
		internal static string ElementInitBindingToString(ElementInit node)
		{
			ExpressionStringBuilder expressionStringBuilder = new ExpressionStringBuilder();
			expressionStringBuilder.VisitElementInit(node);
			return expressionStringBuilder.ToString();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00010A30 File Offset: 0x0000EC30
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) where T : Expression
		{
			this.VisitExpressions<T>(open, expressions, close, ", ");
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00010A40 File Offset: 0x0000EC40
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) where T : Expression
		{
			this.Out(open);
			if (expressions != null)
			{
				bool flag = true;
				foreach (T t in expressions)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						this.Out(seperator);
					}
					this.Visit(t);
				}
			}
			this.Out(close);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		protected internal override Expression VisitBinary(BinaryExpression node)
		{
			if (node.NodeType == ExpressionType.ArrayIndex)
			{
				this.Visit(node.Left);
				this.Out('[');
				this.Visit(node.Right);
				this.Out(']');
			}
			else
			{
				ExpressionType nodeType = node.NodeType;
				string s;
				switch (nodeType)
				{
				case ExpressionType.Add:
				case ExpressionType.AddChecked:
					s = "+";
					goto IL_2CE;
				case ExpressionType.And:
					s = (ExpressionStringBuilder.IsBool(node) ? "And" : "&");
					goto IL_2CE;
				case ExpressionType.AndAlso:
					s = "AndAlso";
					goto IL_2CE;
				case ExpressionType.ArrayLength:
				case ExpressionType.ArrayIndex:
				case ExpressionType.Call:
				case ExpressionType.Conditional:
				case ExpressionType.Constant:
				case ExpressionType.Convert:
				case ExpressionType.ConvertChecked:
				case ExpressionType.Invoke:
				case ExpressionType.Lambda:
				case ExpressionType.ListInit:
				case ExpressionType.MemberAccess:
				case ExpressionType.MemberInit:
				case ExpressionType.Negate:
				case ExpressionType.UnaryPlus:
				case ExpressionType.NegateChecked:
				case ExpressionType.New:
				case ExpressionType.NewArrayInit:
				case ExpressionType.NewArrayBounds:
				case ExpressionType.Not:
				case ExpressionType.Parameter:
				case ExpressionType.Quote:
				case ExpressionType.TypeAs:
				case ExpressionType.TypeIs:
					break;
				case ExpressionType.Coalesce:
					s = "??";
					goto IL_2CE;
				case ExpressionType.Divide:
					s = "/";
					goto IL_2CE;
				case ExpressionType.Equal:
					s = "==";
					goto IL_2CE;
				case ExpressionType.ExclusiveOr:
					s = "^";
					goto IL_2CE;
				case ExpressionType.GreaterThan:
					s = ">";
					goto IL_2CE;
				case ExpressionType.GreaterThanOrEqual:
					s = ">=";
					goto IL_2CE;
				case ExpressionType.LeftShift:
					s = "<<";
					goto IL_2CE;
				case ExpressionType.LessThan:
					s = "<";
					goto IL_2CE;
				case ExpressionType.LessThanOrEqual:
					s = "<=";
					goto IL_2CE;
				case ExpressionType.Modulo:
					s = "%";
					goto IL_2CE;
				case ExpressionType.Multiply:
				case ExpressionType.MultiplyChecked:
					s = "*";
					goto IL_2CE;
				case ExpressionType.NotEqual:
					s = "!=";
					goto IL_2CE;
				case ExpressionType.Or:
					s = (ExpressionStringBuilder.IsBool(node) ? "Or" : "|");
					goto IL_2CE;
				case ExpressionType.OrElse:
					s = "OrElse";
					goto IL_2CE;
				case ExpressionType.Power:
					s = "**";
					goto IL_2CE;
				case ExpressionType.RightShift:
					s = ">>";
					goto IL_2CE;
				case ExpressionType.Subtract:
				case ExpressionType.SubtractChecked:
					s = "-";
					goto IL_2CE;
				case ExpressionType.Assign:
					s = "=";
					goto IL_2CE;
				default:
					switch (nodeType)
					{
					case ExpressionType.AddAssign:
					case ExpressionType.AddAssignChecked:
						s = "+=";
						goto IL_2CE;
					case ExpressionType.AndAssign:
						s = (ExpressionStringBuilder.IsBool(node) ? "&&=" : "&=");
						goto IL_2CE;
					case ExpressionType.DivideAssign:
						s = "/=";
						goto IL_2CE;
					case ExpressionType.ExclusiveOrAssign:
						s = "^=";
						goto IL_2CE;
					case ExpressionType.LeftShiftAssign:
						s = "<<=";
						goto IL_2CE;
					case ExpressionType.ModuloAssign:
						s = "%=";
						goto IL_2CE;
					case ExpressionType.MultiplyAssign:
					case ExpressionType.MultiplyAssignChecked:
						s = "*=";
						goto IL_2CE;
					case ExpressionType.OrAssign:
						s = (ExpressionStringBuilder.IsBool(node) ? "||=" : "|=");
						goto IL_2CE;
					case ExpressionType.PowerAssign:
						s = "**=";
						goto IL_2CE;
					case ExpressionType.RightShiftAssign:
						s = ">>=";
						goto IL_2CE;
					case ExpressionType.SubtractAssign:
					case ExpressionType.SubtractAssignChecked:
						s = "-=";
						goto IL_2CE;
					}
					break;
				}
				throw new InvalidOperationException();
				IL_2CE:
				this.Out('(');
				this.Visit(node.Left);
				this.Out(' ');
				this.Out(s);
				this.Out(' ');
				this.Visit(node.Right);
				this.Out(')');
			}
			return node;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			if (node.IsByRef)
			{
				this.Out("ref ");
			}
			string name = node.Name;
			if (string.IsNullOrEmpty(name))
			{
				this.Out("Param_" + this.GetParamId(node).ToString());
			}
			else
			{
				this.Out(name);
			}
			return node;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00010E28 File Offset: 0x0000F028
		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			if (node.ParameterCount == 1)
			{
				this.Visit(node.GetParameter(0));
			}
			else
			{
				this.Out('(');
				string s = ", ";
				int i = 0;
				int parameterCount = node.ParameterCount;
				while (i < parameterCount)
				{
					if (i > 0)
					{
						this.Out(s);
					}
					this.Visit(node.GetParameter(i));
					i++;
				}
				this.Out(')');
			}
			this.Out(" => ");
			this.Visit(node.Body);
			return node;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00010EAC File Offset: 0x0000F0AC
		protected internal override Expression VisitListInit(ListInitExpression node)
		{
			this.Visit(node.NewExpression);
			this.Out(" {");
			int i = 0;
			int count = node.Initializers.Count;
			while (i < count)
			{
				if (i > 0)
				{
					this.Out(", ");
				}
				this.VisitElementInit(node.Initializers[i]);
				i++;
			}
			this.Out('}');
			return node;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00010F14 File Offset: 0x0000F114
		protected internal override Expression VisitConditional(ConditionalExpression node)
		{
			this.Out("IIF(");
			this.Visit(node.Test);
			this.Out(", ");
			this.Visit(node.IfTrue);
			this.Out(", ");
			this.Visit(node.IfFalse);
			this.Out(')');
			return node;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00010F74 File Offset: 0x0000F174
		protected internal override Expression VisitConstant(ConstantExpression node)
		{
			if (node.Value != null)
			{
				string text = node.Value.ToString();
				if (node.Value is string)
				{
					this.Out('"');
					this.Out(text);
					this.Out('"');
				}
				else if (text == node.Value.GetType().ToString())
				{
					this.Out("value(");
					this.Out(text);
					this.Out(')');
				}
				else
				{
					this.Out(text);
				}
			}
			else
			{
				this.Out("null");
			}
			return node;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00011004 File Offset: 0x0000F204
		private void OutMember(Expression instance, MemberInfo member)
		{
			if (instance != null)
			{
				this.Visit(instance);
			}
			else
			{
				this.Out(member.DeclaringType.Name);
			}
			this.Out('.');
			this.Out(member.Name);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00011038 File Offset: 0x0000F238
		protected internal override Expression VisitMember(MemberExpression node)
		{
			this.OutMember(node.Expression, node.Member);
			return node;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00011050 File Offset: 0x0000F250
		protected internal override Expression VisitMemberInit(MemberInitExpression node)
		{
			if (node.NewExpression.ArgumentCount == 0 && node.NewExpression.Type.Name.Contains("<"))
			{
				this.Out("new");
			}
			else
			{
				this.Visit(node.NewExpression);
			}
			this.Out(" {");
			int i = 0;
			int count = node.Bindings.Count;
			while (i < count)
			{
				MemberBinding node2 = node.Bindings[i];
				if (i > 0)
				{
					this.Out(", ");
				}
				this.VisitMemberBinding(node2);
				i++;
			}
			this.Out('}');
			return node;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000110F0 File Offset: 0x0000F2F0
		protected override MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
		{
			this.Out(assignment.Member.Name);
			this.Out(" = ");
			this.Visit(assignment.Expression);
			return assignment;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001111C File Offset: 0x0000F31C
		protected override MemberListBinding VisitMemberListBinding(MemberListBinding binding)
		{
			this.Out(binding.Member.Name);
			this.Out(" = {");
			int i = 0;
			int count = binding.Initializers.Count;
			while (i < count)
			{
				if (i > 0)
				{
					this.Out(", ");
				}
				this.VisitElementInit(binding.Initializers[i]);
				i++;
			}
			this.Out('}');
			return binding;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00011188 File Offset: 0x0000F388
		protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding)
		{
			this.Out(binding.Member.Name);
			this.Out(" = {");
			int i = 0;
			int count = binding.Bindings.Count;
			while (i < count)
			{
				if (i > 0)
				{
					this.Out(", ");
				}
				this.VisitMemberBinding(binding.Bindings[i]);
				i++;
			}
			this.Out('}');
			return binding;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000111F4 File Offset: 0x0000F3F4
		protected override ElementInit VisitElementInit(ElementInit initializer)
		{
			this.Out(initializer.AddMethod.ToString());
			string s = ", ";
			this.Out('(');
			int i = 0;
			int argumentCount = initializer.ArgumentCount;
			while (i < argumentCount)
			{
				if (i > 0)
				{
					this.Out(s);
				}
				this.Visit(initializer.GetArgument(i));
				i++;
			}
			this.Out(')');
			return initializer;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00011258 File Offset: 0x0000F458
		protected internal override Expression VisitInvocation(InvocationExpression node)
		{
			this.Out("Invoke(");
			this.Visit(node.Expression);
			string s = ", ";
			int i = 0;
			int argumentCount = node.ArgumentCount;
			while (i < argumentCount)
			{
				this.Out(s);
				this.Visit(node.GetArgument(i));
				i++;
			}
			this.Out(')');
			return node;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000112B4 File Offset: 0x0000F4B4
		protected internal override Expression VisitMethodCall(MethodCallExpression node)
		{
			int num = 0;
			Expression expression = node.Object;
			if (node.Method.GetCustomAttribute(typeof(ExtensionAttribute)) != null)
			{
				num = 1;
				expression = node.GetArgument(0);
			}
			if (expression != null)
			{
				this.Visit(expression);
				this.Out('.');
			}
			this.Out(node.Method.Name);
			this.Out('(');
			int i = num;
			int argumentCount = node.ArgumentCount;
			while (i < argumentCount)
			{
				if (i > num)
				{
					this.Out(", ");
				}
				this.Visit(node.GetArgument(i));
				i++;
			}
			this.Out(')');
			return node;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00011350 File Offset: 0x0000F550
		protected internal override Expression VisitNewArray(NewArrayExpression node)
		{
			ExpressionType nodeType = node.NodeType;
			if (nodeType != ExpressionType.NewArrayInit)
			{
				if (nodeType == ExpressionType.NewArrayBounds)
				{
					this.Out("new ");
					this.Out(node.Type.ToString());
					this.VisitExpressions<Expression>('(', node.Expressions, ')');
				}
			}
			else
			{
				this.Out("new [] ");
				this.VisitExpressions<Expression>('{', node.Expressions, '}');
			}
			return node;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000113B8 File Offset: 0x0000F5B8
		protected internal override Expression VisitNew(NewExpression node)
		{
			this.Out("new ");
			this.Out(node.Type.Name);
			this.Out('(');
			ReadOnlyCollection<MemberInfo> members = node.Members;
			for (int i = 0; i < node.ArgumentCount; i++)
			{
				if (i > 0)
				{
					this.Out(", ");
				}
				if (members != null)
				{
					string name = members[i].Name;
					this.Out(name);
					this.Out(" = ");
				}
				this.Visit(node.GetArgument(i));
			}
			this.Out(')');
			return node;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001144C File Offset: 0x0000F64C
		protected internal override Expression VisitTypeBinary(TypeBinaryExpression node)
		{
			this.Out('(');
			this.Visit(node.Expression);
			ExpressionType nodeType = node.NodeType;
			if (nodeType != ExpressionType.TypeIs)
			{
				if (nodeType == ExpressionType.TypeEqual)
				{
					this.Out(" TypeEqual ");
				}
			}
			else
			{
				this.Out(" Is ");
			}
			this.Out(node.TypeOperand.Name);
			this.Out(')');
			return node;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000114B4 File Offset: 0x0000F6B4
		protected internal override Expression VisitUnary(UnaryExpression node)
		{
			ExpressionType nodeType = node.NodeType;
			if (nodeType <= ExpressionType.Quote)
			{
				if (nodeType <= ExpressionType.Convert)
				{
					if (nodeType == ExpressionType.ArrayLength)
					{
						this.Out("ArrayLength(");
						goto IL_19E;
					}
					if (nodeType == ExpressionType.Convert)
					{
						this.Out("Convert(");
						goto IL_19E;
					}
				}
				else
				{
					if (nodeType == ExpressionType.ConvertChecked)
					{
						this.Out("ConvertChecked(");
						goto IL_19E;
					}
					switch (nodeType)
					{
					case ExpressionType.Negate:
					case ExpressionType.NegateChecked:
						this.Out('-');
						goto IL_19E;
					case ExpressionType.UnaryPlus:
						this.Out('+');
						goto IL_19E;
					case ExpressionType.New:
					case ExpressionType.NewArrayInit:
					case ExpressionType.NewArrayBounds:
						break;
					case ExpressionType.Not:
						this.Out("Not(");
						goto IL_19E;
					default:
						if (nodeType == ExpressionType.Quote)
						{
							goto IL_19E;
						}
						break;
					}
				}
			}
			else if (nodeType <= ExpressionType.Increment)
			{
				if (nodeType == ExpressionType.TypeAs)
				{
					this.Out('(');
					goto IL_19E;
				}
				if (nodeType == ExpressionType.Decrement)
				{
					this.Out("Decrement(");
					goto IL_19E;
				}
				if (nodeType == ExpressionType.Increment)
				{
					this.Out("Increment(");
					goto IL_19E;
				}
			}
			else
			{
				if (nodeType == ExpressionType.Throw)
				{
					this.Out("throw(");
					goto IL_19E;
				}
				if (nodeType == ExpressionType.Unbox)
				{
					this.Out("Unbox(");
					goto IL_19E;
				}
				switch (nodeType)
				{
				case ExpressionType.PreIncrementAssign:
					this.Out("++");
					goto IL_19E;
				case ExpressionType.PreDecrementAssign:
					this.Out("--");
					goto IL_19E;
				case ExpressionType.PostIncrementAssign:
				case ExpressionType.PostDecrementAssign:
					goto IL_19E;
				case ExpressionType.OnesComplement:
					this.Out("~(");
					goto IL_19E;
				case ExpressionType.IsTrue:
					this.Out("IsTrue(");
					goto IL_19E;
				case ExpressionType.IsFalse:
					this.Out("IsFalse(");
					goto IL_19E;
				}
			}
			throw new InvalidOperationException();
			IL_19E:
			this.Visit(node.Operand);
			nodeType = node.NodeType;
			if (nodeType <= ExpressionType.NegateChecked)
			{
				if (nodeType - ExpressionType.Convert <= 1)
				{
					this.Out(", ");
					this.Out(node.Type.Name);
					this.Out(')');
					return node;
				}
				if (nodeType - ExpressionType.Negate <= 2)
				{
					return node;
				}
			}
			else
			{
				if (nodeType == ExpressionType.Quote)
				{
					return node;
				}
				if (nodeType == ExpressionType.TypeAs)
				{
					this.Out(" As ");
					this.Out(node.Type.Name);
					this.Out(')');
					return node;
				}
				switch (nodeType)
				{
				case ExpressionType.PreIncrementAssign:
				case ExpressionType.PreDecrementAssign:
					return node;
				case ExpressionType.PostIncrementAssign:
					this.Out("++");
					return node;
				case ExpressionType.PostDecrementAssign:
					this.Out("--");
					return node;
				}
			}
			this.Out(')');
			return node;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00011728 File Offset: 0x0000F928
		protected internal override Expression VisitBlock(BlockExpression node)
		{
			this.Out('{');
			foreach (ParameterExpression node2 in node.Variables)
			{
				this.Out("var ");
				this.Visit(node2);
				this.Out(';');
			}
			this.Out(" ... }");
			return node;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000117A0 File Offset: 0x0000F9A0
		protected internal override Expression VisitDefault(DefaultExpression node)
		{
			this.Out("default(");
			this.Out(node.Type.Name);
			this.Out(')');
			return node;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000117C7 File Offset: 0x0000F9C7
		protected internal override Expression VisitLabel(LabelExpression node)
		{
			this.Out("{ ... } ");
			this.DumpLabel(node.Target);
			this.Out(':');
			return node;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000117EC File Offset: 0x0000F9EC
		protected internal override Expression VisitGoto(GotoExpression node)
		{
			string s;
			switch (node.Kind)
			{
			case GotoExpressionKind.Goto:
				s = "goto";
				break;
			case GotoExpressionKind.Return:
				s = "return";
				break;
			case GotoExpressionKind.Break:
				s = "break";
				break;
			case GotoExpressionKind.Continue:
				s = "continue";
				break;
			default:
				throw new InvalidOperationException();
			}
			this.Out(s);
			this.Out(' ');
			this.DumpLabel(node.Target);
			if (node.Value != null)
			{
				this.Out(" (");
				this.Visit(node.Value);
				this.Out(")");
			}
			return node;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00011885 File Offset: 0x0000FA85
		protected internal override Expression VisitLoop(LoopExpression node)
		{
			this.Out("loop { ... }");
			return node;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00011893 File Offset: 0x0000FA93
		protected override SwitchCase VisitSwitchCase(SwitchCase node)
		{
			this.Out("case ");
			this.VisitExpressions<Expression>('(', node.TestValues, ')');
			this.Out(": ...");
			return node;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000118BC File Offset: 0x0000FABC
		protected internal override Expression VisitSwitch(SwitchExpression node)
		{
			this.Out("switch ");
			this.Out('(');
			this.Visit(node.SwitchValue);
			this.Out(") { ... }");
			return node;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000118EC File Offset: 0x0000FAEC
		protected override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			this.Out("catch (");
			this.Out(node.Test.Name);
			ParameterExpression variable = node.Variable;
			if (!string.IsNullOrEmpty((variable != null) ? variable.Name : null))
			{
				this.Out(' ');
				this.Out(node.Variable.Name);
			}
			this.Out(") { ... }");
			return node;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00011953 File Offset: 0x0000FB53
		protected internal override Expression VisitTry(TryExpression node)
		{
			this.Out("try { ... }");
			return node;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00011964 File Offset: 0x0000FB64
		protected internal override Expression VisitIndex(IndexExpression node)
		{
			if (node.Object != null)
			{
				this.Visit(node.Object);
			}
			else
			{
				this.Out(node.Indexer.DeclaringType.Name);
			}
			if (node.Indexer != null)
			{
				this.Out('.');
				this.Out(node.Indexer.Name);
			}
			this.Out('[');
			int i = 0;
			int argumentCount = node.ArgumentCount;
			while (i < argumentCount)
			{
				if (i > 0)
				{
					this.Out(", ");
				}
				this.Visit(node.GetArgument(i));
				i++;
			}
			this.Out(']');
			return node;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00011A08 File Offset: 0x0000FC08
		protected internal override Expression VisitExtension(Expression node)
		{
			MethodInfo method = node.GetType().GetMethod("ToString", Type.EmptyTypes);
			if (method.DeclaringType != typeof(Expression) && !method.IsStatic)
			{
				this.Out(node.ToString());
				return node;
			}
			this.Out('[');
			this.Out((node.NodeType == ExpressionType.Extension) ? node.GetType().FullName : node.NodeType.ToString());
			this.Out(']');
			return node;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00011A9C File Offset: 0x0000FC9C
		private void DumpLabel(LabelTarget target)
		{
			if (!string.IsNullOrEmpty(target.Name))
			{
				this.Out(target.Name);
				return;
			}
			this.Out("UnnamedLabel_" + this.GetLabelId(target).ToString());
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00011AE2 File Offset: 0x0000FCE2
		private static bool IsBool(Expression node)
		{
			return node.Type == typeof(bool) || node.Type == typeof(bool?);
		}

		// Token: 0x040000F9 RID: 249
		private readonly StringBuilder _out;

		// Token: 0x040000FA RID: 250
		private Dictionary<object, int> _ids;
	}
}
