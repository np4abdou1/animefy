using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000FC RID: 252
	internal sealed class VariableBinder : ExpressionVisitor
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x00020D90 File Offset: 0x0001EF90
		internal static AnalyzedTree Bind(LambdaExpression lambda)
		{
			VariableBinder variableBinder = new VariableBinder();
			variableBinder.Visit(lambda);
			return variableBinder._tree;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00020DA4 File Offset: 0x0001EFA4
		private VariableBinder()
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		public override Expression Visit(Expression node)
		{
			if (!this._guard.TryEnterOnCurrentStack())
			{
				return this._guard.RunOnEmptyStack<VariableBinder, Expression, Expression>((VariableBinder @this, Expression e) => @this.Visit(e), this, node);
			}
			return base.Visit(node);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00020E26 File Offset: 0x0001F026
		protected internal override Expression VisitConstant(ConstantExpression node)
		{
			if (this._inQuote)
			{
				return node;
			}
			if (ILGen.CanEmitConstant(node.Value, node.Type))
			{
				return node;
			}
			this._constants.Peek().AddReference(node.Value, node.Type);
			return node;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00020E64 File Offset: 0x0001F064
		protected internal override Expression VisitUnary(UnaryExpression node)
		{
			if (node.NodeType == ExpressionType.Quote)
			{
				bool inQuote = this._inQuote;
				this._inQuote = true;
				this.Visit(node.Operand);
				this._inQuote = inQuote;
			}
			else
			{
				this.Visit(node.Operand);
			}
			return node;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			this._scopes.Push(this._tree.Scopes[node] = new CompilerScope(node, true));
			this._constants.Push(this._tree.Constants[node] = new BoundConstants());
			base.Visit(this.MergeScopes(node));
			this._constants.Pop();
			this._scopes.Pop();
			return node;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00020F30 File Offset: 0x0001F130
		protected internal override Expression VisitInvocation(InvocationExpression node)
		{
			LambdaExpression lambdaOperand = node.LambdaOperand;
			if (lambdaOperand != null)
			{
				this._scopes.Push(this._tree.Scopes[node] = new CompilerScope(lambdaOperand, false));
				base.Visit(this.MergeScopes(lambdaOperand));
				this._scopes.Pop();
				int i = 0;
				int argumentCount = node.ArgumentCount;
				while (i < argumentCount)
				{
					this.Visit(node.GetArgument(i));
					i++;
				}
				return node;
			}
			return base.VisitInvocation(node);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		protected internal override Expression VisitBlock(BlockExpression node)
		{
			if (node.Variables.Count == 0)
			{
				base.Visit(node.Expressions);
				return node;
			}
			this._scopes.Push(this._tree.Scopes[node] = new CompilerScope(node, false));
			base.Visit(this.MergeScopes(node));
			this._scopes.Pop();
			return node;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00021020 File Offset: 0x0001F220
		protected override CatchBlock VisitCatchBlock(CatchBlock node)
		{
			if (node.Variable == null)
			{
				this.Visit(node.Filter);
				this.Visit(node.Body);
				return node;
			}
			this._scopes.Push(this._tree.Scopes[node] = new CompilerScope(node, false));
			this.Visit(node.Filter);
			this.Visit(node.Body);
			this._scopes.Pop();
			return node;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000210A0 File Offset: 0x0001F2A0
		private ReadOnlyCollection<Expression> MergeScopes(Expression node)
		{
			LambdaExpression lambdaExpression = node as LambdaExpression;
			ReadOnlyCollection<Expression> readOnlyCollection;
			if (lambdaExpression != null)
			{
				readOnlyCollection = new ReadOnlyCollection<Expression>(new Expression[]
				{
					lambdaExpression.Body
				});
			}
			else
			{
				readOnlyCollection = ((BlockExpression)node).Expressions;
			}
			CompilerScope compilerScope = this._scopes.Peek();
			while (readOnlyCollection.Count == 1 && readOnlyCollection[0].NodeType == ExpressionType.Block)
			{
				BlockExpression blockExpression = (BlockExpression)readOnlyCollection[0];
				if (blockExpression.Variables.Count > 0)
				{
					foreach (ParameterExpression key in blockExpression.Variables)
					{
						if (compilerScope.Definitions.ContainsKey(key))
						{
							return readOnlyCollection;
						}
					}
					if (compilerScope.MergedScopes == null)
					{
						compilerScope.MergedScopes = new HashSet<BlockExpression>(ReferenceEqualityComparer<object>.Instance);
					}
					compilerScope.MergedScopes.Add(blockExpression);
					foreach (ParameterExpression key2 in blockExpression.Variables)
					{
						compilerScope.Definitions.Add(key2, VariableStorageKind.Local);
					}
				}
				readOnlyCollection = blockExpression.Expressions;
			}
			return readOnlyCollection;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000211F4 File Offset: 0x0001F3F4
		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			this.Reference(node, VariableStorageKind.Local);
			CompilerScope compilerScope = null;
			foreach (CompilerScope compilerScope2 in this._scopes)
			{
				if (compilerScope2.IsMethod || compilerScope2.Definitions.ContainsKey(node))
				{
					compilerScope = compilerScope2;
					break;
				}
			}
			if (compilerScope.ReferenceCount == null)
			{
				compilerScope.ReferenceCount = new Dictionary<ParameterExpression, int>();
			}
			Helpers.IncrementCount<ParameterExpression>(node, compilerScope.ReferenceCount);
			return node;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00021284 File Offset: 0x0001F484
		private void Reference(ParameterExpression node, VariableStorageKind storage)
		{
			CompilerScope compilerScope = null;
			foreach (CompilerScope compilerScope2 in this._scopes)
			{
				if (compilerScope2.Definitions.ContainsKey(node))
				{
					compilerScope = compilerScope2;
					break;
				}
				compilerScope2.NeedsClosure = true;
				if (compilerScope2.IsMethod)
				{
					storage = VariableStorageKind.Hoisted;
				}
			}
			if (compilerScope == null)
			{
				throw Error.UndefinedVariable(node.Name, node.Type, this.CurrentLambdaName);
			}
			if (storage == VariableStorageKind.Hoisted)
			{
				if (node.IsByRef)
				{
					throw Error.CannotCloseOverByRef(node.Name, this.CurrentLambdaName);
				}
				compilerScope.Definitions[node] = VariableStorageKind.Hoisted;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002133C File Offset: 0x0001F53C
		private string CurrentLambdaName
		{
			get
			{
				foreach (CompilerScope compilerScope in this._scopes)
				{
					LambdaExpression lambdaExpression = compilerScope.Node as LambdaExpression;
					if (lambdaExpression != null)
					{
						return lambdaExpression.Name;
					}
				}
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x04000283 RID: 643
		private readonly AnalyzedTree _tree = new AnalyzedTree();

		// Token: 0x04000284 RID: 644
		private readonly Stack<CompilerScope> _scopes = new Stack<CompilerScope>();

		// Token: 0x04000285 RID: 645
		private readonly Stack<BoundConstants> _constants = new Stack<BoundConstants>();

		// Token: 0x04000286 RID: 646
		private readonly StackGuard _guard = new StackGuard();

		// Token: 0x04000287 RID: 647
		private bool _inQuote;
	}
}
