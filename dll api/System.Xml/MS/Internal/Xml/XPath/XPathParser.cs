using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000357 RID: 855
	internal class XPathParser
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x000ABAAE File Offset: 0x000A9CAE
		private XPathParser(XPathScanner scanner)
		{
			this._scanner = scanner;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000ABAC0 File Offset: 0x000A9CC0
		public static AstNode ParseXPathExpression(string xpathExpression)
		{
			XPathScanner xpathScanner = new XPathScanner(xpathExpression);
			AstNode result = new XPathParser(xpathScanner).ParseExpression(null);
			if (xpathScanner.Kind != XPathScanner.LexKind.Eof)
			{
				throw XPathException.Create("'{0}' has an invalid token.", xpathScanner.SourceText);
			}
			return result;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000ABAFC File Offset: 0x000A9CFC
		private AstNode ParseExpression(AstNode qyInput)
		{
			int num = this._parseDepth + 1;
			this._parseDepth = num;
			if (num > 200)
			{
				throw XPathException.Create("The xpath query is too complex.");
			}
			AstNode result = this.ParseOrExpr(qyInput);
			this._parseDepth--;
			return result;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000ABB44 File Offset: 0x000A9D44
		private AstNode ParseOrExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseAndExpr(qyInput);
			while (this.TestOp("or"))
			{
				this.NextLex();
				astNode = new Operator(Operator.Op.OR, astNode, this.ParseAndExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000ABB80 File Offset: 0x000A9D80
		private AstNode ParseAndExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseEqualityExpr(qyInput);
			while (this.TestOp("and"))
			{
				this.NextLex();
				astNode = new Operator(Operator.Op.AND, astNode, this.ParseEqualityExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000ABBBC File Offset: 0x000A9DBC
		private AstNode ParseEqualityExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseRelationalExpr(qyInput);
			for (;;)
			{
				Operator.Op op = (this._scanner.Kind == XPathScanner.LexKind.Eq) ? Operator.Op.EQ : ((this._scanner.Kind == XPathScanner.LexKind.Ne) ? Operator.Op.NE : Operator.Op.INVALID);
				if (op == Operator.Op.INVALID)
				{
					break;
				}
				this.NextLex();
				astNode = new Operator(op, astNode, this.ParseRelationalExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x000ABC14 File Offset: 0x000A9E14
		private AstNode ParseRelationalExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseAdditiveExpr(qyInput);
			for (;;)
			{
				Operator.Op op = (this._scanner.Kind == XPathScanner.LexKind.Lt) ? Operator.Op.LT : ((this._scanner.Kind == XPathScanner.LexKind.Le) ? Operator.Op.LE : ((this._scanner.Kind == XPathScanner.LexKind.Gt) ? Operator.Op.GT : ((this._scanner.Kind == XPathScanner.LexKind.Ge) ? Operator.Op.GE : Operator.Op.INVALID)));
				if (op == Operator.Op.INVALID)
				{
					break;
				}
				this.NextLex();
				astNode = new Operator(op, astNode, this.ParseAdditiveExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x000ABC90 File Offset: 0x000A9E90
		private AstNode ParseAdditiveExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseMultiplicativeExpr(qyInput);
			for (;;)
			{
				Operator.Op op = (this._scanner.Kind == XPathScanner.LexKind.Plus) ? Operator.Op.PLUS : ((this._scanner.Kind == XPathScanner.LexKind.Minus) ? Operator.Op.MINUS : Operator.Op.INVALID);
				if (op == Operator.Op.INVALID)
				{
					break;
				}
				this.NextLex();
				astNode = new Operator(op, astNode, this.ParseMultiplicativeExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000ABCE8 File Offset: 0x000A9EE8
		private AstNode ParseMultiplicativeExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParseUnaryExpr(qyInput);
			for (;;)
			{
				Operator.Op op = (this._scanner.Kind == XPathScanner.LexKind.Star) ? Operator.Op.MUL : (this.TestOp("div") ? Operator.Op.DIV : (this.TestOp("mod") ? Operator.Op.MOD : Operator.Op.INVALID));
				if (op == Operator.Op.INVALID)
				{
					break;
				}
				this.NextLex();
				astNode = new Operator(op, astNode, this.ParseUnaryExpr(qyInput));
			}
			return astNode;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000ABD50 File Offset: 0x000A9F50
		private AstNode ParseUnaryExpr(AstNode qyInput)
		{
			bool flag = false;
			while (this._scanner.Kind == XPathScanner.LexKind.Minus)
			{
				this.NextLex();
				flag = !flag;
			}
			if (flag)
			{
				return new Operator(Operator.Op.MUL, this.ParseUnionExpr(qyInput), new Operand(-1.0));
			}
			return this.ParseUnionExpr(qyInput);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000ABDA4 File Offset: 0x000A9FA4
		private AstNode ParseUnionExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParsePathExpr(qyInput);
			while (this._scanner.Kind == XPathScanner.LexKind.Union)
			{
				this.NextLex();
				AstNode astNode2 = this.ParsePathExpr(qyInput);
				this.CheckNodeSet(astNode.ReturnType);
				this.CheckNodeSet(astNode2.ReturnType);
				astNode = new Operator(Operator.Op.UNION, astNode, astNode2);
			}
			return astNode;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000ABDFC File Offset: 0x000A9FFC
		private static bool IsNodeType(XPathScanner scaner)
		{
			return scaner.Prefix.Length == 0 && (scaner.Name == "node" || scaner.Name == "text" || scaner.Name == "processing-instruction" || scaner.Name == "comment");
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000ABE60 File Offset: 0x000AA060
		private AstNode ParsePathExpr(AstNode qyInput)
		{
			AstNode astNode;
			if (XPathParser.IsPrimaryExpr(this._scanner))
			{
				astNode = this.ParseFilterExpr(qyInput);
				if (this._scanner.Kind == XPathScanner.LexKind.Slash)
				{
					this.NextLex();
					astNode = this.ParseRelativeLocationPath(astNode);
				}
				else if (this._scanner.Kind == XPathScanner.LexKind.SlashSlash)
				{
					this.NextLex();
					astNode = this.ParseRelativeLocationPath(new Axis(Axis.AxisType.DescendantOrSelf, astNode));
				}
			}
			else
			{
				astNode = this.ParseLocationPath(null);
			}
			return astNode;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000ABED0 File Offset: 0x000AA0D0
		private AstNode ParseFilterExpr(AstNode qyInput)
		{
			AstNode astNode = this.ParsePrimaryExpr(qyInput);
			while (this._scanner.Kind == XPathScanner.LexKind.LBracket)
			{
				astNode = new Filter(astNode, this.ParsePredicate(astNode));
			}
			return astNode;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000ABF05 File Offset: 0x000AA105
		private AstNode ParsePredicate(AstNode qyInput)
		{
			this.CheckNodeSet(qyInput.ReturnType);
			this.PassToken(XPathScanner.LexKind.LBracket);
			AstNode result = this.ParseExpression(qyInput);
			this.PassToken(XPathScanner.LexKind.RBracket);
			return result;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000ABF2C File Offset: 0x000AA12C
		private AstNode ParseLocationPath(AstNode qyInput)
		{
			if (this._scanner.Kind == XPathScanner.LexKind.Slash)
			{
				this.NextLex();
				AstNode astNode = new Root();
				if (XPathParser.IsStep(this._scanner.Kind))
				{
					astNode = this.ParseRelativeLocationPath(astNode);
				}
				return astNode;
			}
			if (this._scanner.Kind == XPathScanner.LexKind.SlashSlash)
			{
				this.NextLex();
				return this.ParseRelativeLocationPath(new Axis(Axis.AxisType.DescendantOrSelf, new Root()));
			}
			return this.ParseRelativeLocationPath(qyInput);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000ABFA0 File Offset: 0x000AA1A0
		private AstNode ParseRelativeLocationPath(AstNode qyInput)
		{
			AstNode astNode = qyInput;
			for (;;)
			{
				astNode = this.ParseStep(astNode);
				if (XPathScanner.LexKind.SlashSlash == this._scanner.Kind)
				{
					this.NextLex();
					astNode = new Axis(Axis.AxisType.DescendantOrSelf, astNode);
				}
				else
				{
					if (XPathScanner.LexKind.Slash != this._scanner.Kind)
					{
						break;
					}
					this.NextLex();
				}
			}
			return astNode;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000ABFEE File Offset: 0x000AA1EE
		private static bool IsStep(XPathScanner.LexKind lexKind)
		{
			return lexKind == XPathScanner.LexKind.Dot || lexKind == XPathScanner.LexKind.DotDot || lexKind == XPathScanner.LexKind.At || lexKind == XPathScanner.LexKind.Axe || lexKind == XPathScanner.LexKind.Star || lexKind == XPathScanner.LexKind.Name;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000AC010 File Offset: 0x000AA210
		private AstNode ParseStep(AstNode qyInput)
		{
			AstNode astNode;
			if (XPathScanner.LexKind.Dot == this._scanner.Kind)
			{
				this.NextLex();
				astNode = new Axis(Axis.AxisType.Self, qyInput);
			}
			else if (XPathScanner.LexKind.DotDot == this._scanner.Kind)
			{
				this.NextLex();
				astNode = new Axis(Axis.AxisType.Parent, qyInput);
			}
			else
			{
				Axis.AxisType axisType = Axis.AxisType.Child;
				XPathScanner.LexKind kind = this._scanner.Kind;
				if (kind != XPathScanner.LexKind.At)
				{
					if (kind == XPathScanner.LexKind.Axe)
					{
						axisType = this.GetAxis();
						this.NextLex();
					}
				}
				else
				{
					axisType = Axis.AxisType.Attribute;
					this.NextLex();
				}
				XPathNodeType nodeType = (axisType == Axis.AxisType.Attribute) ? XPathNodeType.Attribute : XPathNodeType.Element;
				astNode = this.ParseNodeTest(qyInput, axisType, nodeType);
				while (XPathScanner.LexKind.LBracket == this._scanner.Kind)
				{
					astNode = new Filter(astNode, this.ParsePredicate(astNode));
				}
			}
			return astNode;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000AC0C4 File Offset: 0x000AA2C4
		private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType)
		{
			XPathScanner.LexKind kind = this._scanner.Kind;
			string prefix;
			string text;
			if (kind != XPathScanner.LexKind.Star)
			{
				if (kind != XPathScanner.LexKind.Name)
				{
					throw XPathException.Create("Expression must evaluate to a node-set.", this._scanner.SourceText);
				}
				if (this._scanner.CanBeFunction && XPathParser.IsNodeType(this._scanner))
				{
					prefix = string.Empty;
					text = string.Empty;
					nodeType = ((this._scanner.Name == "comment") ? XPathNodeType.Comment : ((this._scanner.Name == "text") ? XPathNodeType.Text : ((this._scanner.Name == "node") ? XPathNodeType.All : ((this._scanner.Name == "processing-instruction") ? XPathNodeType.ProcessingInstruction : XPathNodeType.Root))));
					this.NextLex();
					this.PassToken(XPathScanner.LexKind.LParens);
					if (nodeType == XPathNodeType.ProcessingInstruction && this._scanner.Kind != XPathScanner.LexKind.RParens)
					{
						this.CheckToken(XPathScanner.LexKind.String);
						text = this._scanner.StringValue;
						this.NextLex();
					}
					this.PassToken(XPathScanner.LexKind.RParens);
				}
				else
				{
					prefix = this._scanner.Prefix;
					text = this._scanner.Name;
					this.NextLex();
					if (text == "*")
					{
						text = string.Empty;
					}
				}
			}
			else
			{
				prefix = string.Empty;
				text = string.Empty;
				this.NextLex();
			}
			return new Axis(axisType, qyInput, prefix, text, nodeType);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000AC234 File Offset: 0x000AA434
		private static bool IsPrimaryExpr(XPathScanner scanner)
		{
			return scanner.Kind == XPathScanner.LexKind.String || scanner.Kind == XPathScanner.LexKind.Number || scanner.Kind == XPathScanner.LexKind.Dollar || scanner.Kind == XPathScanner.LexKind.LParens || (scanner.Kind == XPathScanner.LexKind.Name && scanner.CanBeFunction && !XPathParser.IsNodeType(scanner));
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x000AC288 File Offset: 0x000AA488
		private AstNode ParsePrimaryExpr(AstNode qyInput)
		{
			AstNode astNode = null;
			XPathScanner.LexKind kind = this._scanner.Kind;
			if (kind <= XPathScanner.LexKind.LParens)
			{
				if (kind != XPathScanner.LexKind.Dollar)
				{
					if (kind == XPathScanner.LexKind.LParens)
					{
						this.NextLex();
						astNode = this.ParseExpression(qyInput);
						if (astNode.Type != AstNode.AstType.ConstantOperand)
						{
							astNode = new Group(astNode);
						}
						this.PassToken(XPathScanner.LexKind.RParens);
					}
				}
				else
				{
					this.NextLex();
					this.CheckToken(XPathScanner.LexKind.Name);
					astNode = new Variable(this._scanner.Name, this._scanner.Prefix);
					this.NextLex();
				}
			}
			else if (kind != XPathScanner.LexKind.Number)
			{
				if (kind != XPathScanner.LexKind.Name)
				{
					if (kind == XPathScanner.LexKind.String)
					{
						astNode = new Operand(this._scanner.StringValue);
						this.NextLex();
					}
				}
				else if (this._scanner.CanBeFunction && !XPathParser.IsNodeType(this._scanner))
				{
					astNode = this.ParseMethod(null);
				}
			}
			else
			{
				astNode = new Operand(this._scanner.NumberValue);
				this.NextLex();
			}
			return astNode;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x000AC384 File Offset: 0x000AA584
		private AstNode ParseMethod(AstNode qyInput)
		{
			List<AstNode> list = new List<AstNode>();
			string name = this._scanner.Name;
			string prefix = this._scanner.Prefix;
			this.PassToken(XPathScanner.LexKind.Name);
			this.PassToken(XPathScanner.LexKind.LParens);
			if (this._scanner.Kind != XPathScanner.LexKind.RParens)
			{
				for (;;)
				{
					list.Add(this.ParseExpression(qyInput));
					if (this._scanner.Kind == XPathScanner.LexKind.RParens)
					{
						break;
					}
					this.PassToken(XPathScanner.LexKind.Comma);
				}
			}
			this.PassToken(XPathScanner.LexKind.RParens);
			XPathParser.ParamInfo paramInfo;
			if (prefix.Length != 0 || !XPathParser.s_functionTable.TryGetValue(name, out paramInfo))
			{
				return new Function(prefix, name, list);
			}
			int num = list.Count;
			if (num < paramInfo.Minargs)
			{
				throw XPathException.Create("Function '{0}' in '{1}' has an invalid number of arguments.", name, this._scanner.SourceText);
			}
			if (paramInfo.FType == Function.FunctionType.FuncConcat)
			{
				for (int i = 0; i < num; i++)
				{
					AstNode astNode = list[i];
					if (astNode.ReturnType != XPathResultType.String)
					{
						astNode = new Function(Function.FunctionType.FuncString, astNode);
					}
					list[i] = astNode;
				}
			}
			else
			{
				if (paramInfo.Maxargs < num)
				{
					throw XPathException.Create("Function '{0}' in '{1}' has an invalid number of arguments.", name, this._scanner.SourceText);
				}
				if (paramInfo.ArgTypes.Length < num)
				{
					num = paramInfo.ArgTypes.Length;
				}
				for (int j = 0; j < num; j++)
				{
					AstNode astNode2 = list[j];
					if (paramInfo.ArgTypes[j] != XPathResultType.Any && paramInfo.ArgTypes[j] != astNode2.ReturnType)
					{
						switch (paramInfo.ArgTypes[j])
						{
						case XPathResultType.Number:
							astNode2 = new Function(Function.FunctionType.FuncNumber, astNode2);
							break;
						case XPathResultType.String:
							astNode2 = new Function(Function.FunctionType.FuncString, astNode2);
							break;
						case XPathResultType.Boolean:
							astNode2 = new Function(Function.FunctionType.FuncBoolean, astNode2);
							break;
						case XPathResultType.NodeSet:
							if (!(astNode2 is Variable) && (!(astNode2 is Function) || astNode2.ReturnType != XPathResultType.Any))
							{
								throw XPathException.Create("The argument to function '{0}' in '{1}' cannot be converted to a node-set.", name, this._scanner.SourceText);
							}
							break;
						}
						list[j] = astNode2;
					}
				}
			}
			return new Function(paramInfo.FType, list);
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x000AC59F File Offset: 0x000AA79F
		private void CheckToken(XPathScanner.LexKind t)
		{
			if (this._scanner.Kind != t)
			{
				throw XPathException.Create("'{0}' has an invalid token.", this._scanner.SourceText);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x000AC5C5 File Offset: 0x000AA7C5
		private void PassToken(XPathScanner.LexKind t)
		{
			this.CheckToken(t);
			this.NextLex();
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000AC5D4 File Offset: 0x000AA7D4
		private void NextLex()
		{
			this._scanner.NextLex();
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000AC5E2 File Offset: 0x000AA7E2
		private bool TestOp(string op)
		{
			return this._scanner.Kind == XPathScanner.LexKind.Name && this._scanner.Prefix.Length == 0 && this._scanner.Name.Equals(op);
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000AC618 File Offset: 0x000AA818
		private void CheckNodeSet(XPathResultType t)
		{
			if (t != XPathResultType.NodeSet && t != XPathResultType.Any)
			{
				throw XPathException.Create("Expression must evaluate to a node-set.", this._scanner.SourceText);
			}
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000AC638 File Offset: 0x000AA838
		private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable()
		{
			return new Dictionary<string, XPathParser.ParamInfo>(36)
			{
				{
					"last",
					new XPathParser.ParamInfo(Function.FunctionType.FuncLast, 0, 0, XPathParser.s_temparray1)
				},
				{
					"position",
					new XPathParser.ParamInfo(Function.FunctionType.FuncPosition, 0, 0, XPathParser.s_temparray1)
				},
				{
					"name",
					new XPathParser.ParamInfo(Function.FunctionType.FuncName, 0, 1, XPathParser.s_temparray2)
				},
				{
					"namespace-uri",
					new XPathParser.ParamInfo(Function.FunctionType.FuncNameSpaceUri, 0, 1, XPathParser.s_temparray2)
				},
				{
					"local-name",
					new XPathParser.ParamInfo(Function.FunctionType.FuncLocalName, 0, 1, XPathParser.s_temparray2)
				},
				{
					"count",
					new XPathParser.ParamInfo(Function.FunctionType.FuncCount, 1, 1, XPathParser.s_temparray2)
				},
				{
					"id",
					new XPathParser.ParamInfo(Function.FunctionType.FuncID, 1, 1, XPathParser.s_temparray3)
				},
				{
					"string",
					new XPathParser.ParamInfo(Function.FunctionType.FuncString, 0, 1, XPathParser.s_temparray3)
				},
				{
					"concat",
					new XPathParser.ParamInfo(Function.FunctionType.FuncConcat, 2, 100, XPathParser.s_temparray4)
				},
				{
					"starts-with",
					new XPathParser.ParamInfo(Function.FunctionType.FuncStartsWith, 2, 2, XPathParser.s_temparray5)
				},
				{
					"contains",
					new XPathParser.ParamInfo(Function.FunctionType.FuncContains, 2, 2, XPathParser.s_temparray5)
				},
				{
					"substring-before",
					new XPathParser.ParamInfo(Function.FunctionType.FuncSubstringBefore, 2, 2, XPathParser.s_temparray5)
				},
				{
					"substring-after",
					new XPathParser.ParamInfo(Function.FunctionType.FuncSubstringAfter, 2, 2, XPathParser.s_temparray5)
				},
				{
					"substring",
					new XPathParser.ParamInfo(Function.FunctionType.FuncSubstring, 2, 3, XPathParser.s_temparray6)
				},
				{
					"string-length",
					new XPathParser.ParamInfo(Function.FunctionType.FuncStringLength, 0, 1, XPathParser.s_temparray4)
				},
				{
					"normalize-space",
					new XPathParser.ParamInfo(Function.FunctionType.FuncNormalize, 0, 1, XPathParser.s_temparray4)
				},
				{
					"translate",
					new XPathParser.ParamInfo(Function.FunctionType.FuncTranslate, 3, 3, XPathParser.s_temparray7)
				},
				{
					"boolean",
					new XPathParser.ParamInfo(Function.FunctionType.FuncBoolean, 1, 1, XPathParser.s_temparray3)
				},
				{
					"not",
					new XPathParser.ParamInfo(Function.FunctionType.FuncNot, 1, 1, XPathParser.s_temparray8)
				},
				{
					"true",
					new XPathParser.ParamInfo(Function.FunctionType.FuncTrue, 0, 0, XPathParser.s_temparray8)
				},
				{
					"false",
					new XPathParser.ParamInfo(Function.FunctionType.FuncFalse, 0, 0, XPathParser.s_temparray8)
				},
				{
					"lang",
					new XPathParser.ParamInfo(Function.FunctionType.FuncLang, 1, 1, XPathParser.s_temparray4)
				},
				{
					"number",
					new XPathParser.ParamInfo(Function.FunctionType.FuncNumber, 0, 1, XPathParser.s_temparray3)
				},
				{
					"sum",
					new XPathParser.ParamInfo(Function.FunctionType.FuncSum, 1, 1, XPathParser.s_temparray2)
				},
				{
					"floor",
					new XPathParser.ParamInfo(Function.FunctionType.FuncFloor, 1, 1, XPathParser.s_temparray9)
				},
				{
					"ceiling",
					new XPathParser.ParamInfo(Function.FunctionType.FuncCeiling, 1, 1, XPathParser.s_temparray9)
				},
				{
					"round",
					new XPathParser.ParamInfo(Function.FunctionType.FuncRound, 1, 1, XPathParser.s_temparray9)
				}
			};
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x000AC8E8 File Offset: 0x000AAAE8
		private static Dictionary<string, Axis.AxisType> CreateAxesTable()
		{
			return new Dictionary<string, Axis.AxisType>(13)
			{
				{
					"ancestor",
					Axis.AxisType.Ancestor
				},
				{
					"ancestor-or-self",
					Axis.AxisType.AncestorOrSelf
				},
				{
					"attribute",
					Axis.AxisType.Attribute
				},
				{
					"child",
					Axis.AxisType.Child
				},
				{
					"descendant",
					Axis.AxisType.Descendant
				},
				{
					"descendant-or-self",
					Axis.AxisType.DescendantOrSelf
				},
				{
					"following",
					Axis.AxisType.Following
				},
				{
					"following-sibling",
					Axis.AxisType.FollowingSibling
				},
				{
					"namespace",
					Axis.AxisType.Namespace
				},
				{
					"parent",
					Axis.AxisType.Parent
				},
				{
					"preceding",
					Axis.AxisType.Preceding
				},
				{
					"preceding-sibling",
					Axis.AxisType.PrecedingSibling
				},
				{
					"self",
					Axis.AxisType.Self
				}
			};
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000AC99C File Offset: 0x000AAB9C
		private Axis.AxisType GetAxis()
		{
			Axis.AxisType result;
			if (!XPathParser.s_AxesTable.TryGetValue(this._scanner.Name, out result))
			{
				throw XPathException.Create("'{0}' has an invalid token.", this._scanner.SourceText);
			}
			return result;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000AC9DC File Offset: 0x000AABDC
		// Note: this type is marked as 'beforefieldinit'.
		static XPathParser()
		{
			XPathResultType[] array = new XPathResultType[3];
			array[0] = XPathResultType.String;
			XPathParser.s_temparray6 = array;
			XPathParser.s_temparray7 = new XPathResultType[]
			{
				XPathResultType.String,
				XPathResultType.String,
				XPathResultType.String
			};
			XPathParser.s_temparray8 = new XPathResultType[]
			{
				XPathResultType.Boolean
			};
			XPathParser.s_temparray9 = new XPathResultType[1];
			XPathParser.s_functionTable = XPathParser.CreateFunctionTable();
			XPathParser.s_AxesTable = XPathParser.CreateAxesTable();
		}

		// Token: 0x04001366 RID: 4966
		private XPathScanner _scanner;

		// Token: 0x04001367 RID: 4967
		private int _parseDepth;

		// Token: 0x04001368 RID: 4968
		private static readonly XPathResultType[] s_temparray1 = Array.Empty<XPathResultType>();

		// Token: 0x04001369 RID: 4969
		private static readonly XPathResultType[] s_temparray2 = new XPathResultType[]
		{
			XPathResultType.NodeSet
		};

		// Token: 0x0400136A RID: 4970
		private static readonly XPathResultType[] s_temparray3 = new XPathResultType[]
		{
			XPathResultType.Any
		};

		// Token: 0x0400136B RID: 4971
		private static readonly XPathResultType[] s_temparray4 = new XPathResultType[]
		{
			XPathResultType.String
		};

		// Token: 0x0400136C RID: 4972
		private static readonly XPathResultType[] s_temparray5 = new XPathResultType[]
		{
			XPathResultType.String,
			XPathResultType.String
		};

		// Token: 0x0400136D RID: 4973
		private static readonly XPathResultType[] s_temparray6;

		// Token: 0x0400136E RID: 4974
		private static readonly XPathResultType[] s_temparray7;

		// Token: 0x0400136F RID: 4975
		private static readonly XPathResultType[] s_temparray8;

		// Token: 0x04001370 RID: 4976
		private static readonly XPathResultType[] s_temparray9;

		// Token: 0x04001371 RID: 4977
		private static Dictionary<string, XPathParser.ParamInfo> s_functionTable;

		// Token: 0x04001372 RID: 4978
		private static Dictionary<string, Axis.AxisType> s_AxesTable;

		// Token: 0x02000358 RID: 856
		private class ParamInfo
		{
			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000ACA86 File Offset: 0x000AAC86
			public Function.FunctionType FType
			{
				get
				{
					return this._ftype;
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000ACA8E File Offset: 0x000AAC8E
			public int Minargs
			{
				get
				{
					return this._minargs;
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000ACA96 File Offset: 0x000AAC96
			public int Maxargs
			{
				get
				{
					return this._maxargs;
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000ACA9E File Offset: 0x000AAC9E
			public XPathResultType[] ArgTypes
			{
				get
				{
					return this._argTypes;
				}
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x000ACAA6 File Offset: 0x000AACA6
			internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes)
			{
				this._ftype = ftype;
				this._minargs = minargs;
				this._maxargs = maxargs;
				this._argTypes = argTypes;
			}

			// Token: 0x04001373 RID: 4979
			private Function.FunctionType _ftype;

			// Token: 0x04001374 RID: 4980
			private int _minargs;

			// Token: 0x04001375 RID: 4981
			private int _maxargs;

			// Token: 0x04001376 RID: 4982
			private XPathResultType[] _argTypes;
		}
	}
}
