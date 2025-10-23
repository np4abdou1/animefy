using System;
using System.Data.Common;
using System.Globalization;

namespace System.Data
{
	// Token: 0x0200005D RID: 93
	internal sealed class ExpressionParser
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x00020D74 File Offset: 0x0001EF74
		internal ExpressionParser(DataTable table)
		{
			this._table = table;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00020DD0 File Offset: 0x0001EFD0
		internal void LoadExpression(string data)
		{
			int num;
			if (data == null)
			{
				num = 0;
				this._text = new char[num + 1];
			}
			else
			{
				num = data.Length;
				this._text = new char[num + 1];
				data.CopyTo(0, this._text, 0, num);
			}
			this._text[num] = '\0';
			if (this._expression != null)
			{
				this._expression = null;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00020E30 File Offset: 0x0001F030
		internal void StartScan()
		{
			this._op = 0;
			this._pos = 0;
			this._start = 0;
			this._topOperator = 0;
			OperatorInfo[] ops = this._ops;
			int topOperator = this._topOperator;
			this._topOperator = topOperator + 1;
			ops[topOperator] = new OperatorInfo(Nodes.Noop, 0, 0);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00020E7C File Offset: 0x0001F07C
		internal ExpressionNode Parse()
		{
			this._expression = null;
			this.StartScan();
			int num = 0;
			while (this._token != Tokens.EOS)
			{
				OperatorInfo operatorInfo;
				for (;;)
				{
					this.Scan();
					int topOperator;
					switch (this._token)
					{
					case Tokens.Name:
					case Tokens.Numeric:
					case Tokens.Decimal:
					case Tokens.Float:
					case Tokens.StringConst:
					case Tokens.Date:
					case Tokens.Parent:
					{
						ExpressionNode expressionNode = null;
						if (this._prevOperand != 0)
						{
							goto Block_5;
						}
						if (this._topOperator > 0)
						{
							operatorInfo = this._ops[this._topOperator - 1];
							if (operatorInfo._type == Nodes.Binop && operatorInfo._op == 5 && this._token != Tokens.Parent)
							{
								goto Block_9;
							}
						}
						this._prevOperand = 1;
						Tokens token = this._token;
						switch (token)
						{
						case Tokens.Name:
							operatorInfo = this._ops[this._topOperator - 1];
							expressionNode = new NameNode(this._table, this._text, this._start, this._pos);
							break;
						case Tokens.Numeric:
						{
							string constant = new string(this._text, this._start, this._pos - this._start);
							expressionNode = new ConstNode(this._table, ValueType.Numeric, constant);
							break;
						}
						case Tokens.Decimal:
						{
							string constant = new string(this._text, this._start, this._pos - this._start);
							expressionNode = new ConstNode(this._table, ValueType.Decimal, constant);
							break;
						}
						case Tokens.Float:
						{
							string constant = new string(this._text, this._start, this._pos - this._start);
							expressionNode = new ConstNode(this._table, ValueType.Float, constant);
							break;
						}
						case Tokens.BinaryConst:
							break;
						case Tokens.StringConst:
						{
							string constant = new string(this._text, this._start + 1, this._pos - this._start - 2);
							expressionNode = new ConstNode(this._table, ValueType.Str, constant);
							break;
						}
						case Tokens.Date:
						{
							string constant = new string(this._text, this._start + 1, this._pos - this._start - 2);
							expressionNode = new ConstNode(this._table, ValueType.Date, constant);
							break;
						}
						default:
							if (token == Tokens.Parent)
							{
								string relationName;
								try
								{
									this.Scan();
									if (this._token == Tokens.LeftParen)
									{
										this.ScanToken(Tokens.Name);
										relationName = NameNode.ParseName(this._text, this._start, this._pos);
										this.ScanToken(Tokens.RightParen);
										this.ScanToken(Tokens.Dot);
									}
									else
									{
										relationName = null;
										this.CheckToken(Tokens.Dot);
									}
								}
								catch (Exception e) when (ADP.IsCatchableExceptionType(e))
								{
									throw ExprException.LookupArgument();
								}
								this.ScanToken(Tokens.Name);
								string columnName = NameNode.ParseName(this._text, this._start, this._pos);
								operatorInfo = this._ops[this._topOperator - 1];
								expressionNode = new LookupNode(this._table, columnName, relationName);
							}
							break;
						}
						this.NodePush(expressionNode);
						continue;
					}
					case Tokens.ListSeparator:
					{
						if (this._prevOperand == 0)
						{
							goto Block_23;
						}
						this.BuildExpression(3);
						operatorInfo = this._ops[this._topOperator - 1];
						if (operatorInfo._type != Nodes.Call)
						{
							goto Block_24;
						}
						ExpressionNode argument = this.NodePop();
						FunctionNode functionNode = (FunctionNode)this.NodePop();
						functionNode.AddArgument(argument);
						this.NodePush(functionNode);
						this._prevOperand = 0;
						continue;
					}
					case Tokens.LeftParen:
						num++;
						if (this._prevOperand == 0)
						{
							operatorInfo = this._ops[this._topOperator - 1];
							if (operatorInfo._type == Nodes.Binop && operatorInfo._op == 5)
							{
								ExpressionNode expressionNode = new FunctionNode(this._table, "In");
								this.NodePush(expressionNode);
								OperatorInfo[] ops = this._ops;
								topOperator = this._topOperator;
								this._topOperator = topOperator + 1;
								ops[topOperator] = new OperatorInfo(Nodes.Call, 0, 2);
								continue;
							}
							OperatorInfo[] ops2 = this._ops;
							topOperator = this._topOperator;
							this._topOperator = topOperator + 1;
							ops2[topOperator] = new OperatorInfo(Nodes.Paren, 0, 2);
							continue;
						}
						else
						{
							this.BuildExpression(22);
							this._prevOperand = 0;
							ExpressionNode expressionNode2 = this.NodePeek();
							if (expressionNode2 == null || expressionNode2.GetType() != typeof(NameNode))
							{
								goto IL_41A;
							}
							NameNode nameNode = (NameNode)this.NodePop();
							ExpressionNode expressionNode = new FunctionNode(this._table, nameNode._name);
							Aggregate aggregate = (Aggregate)((FunctionNode)expressionNode).Aggregate;
							if (aggregate != Aggregate.None)
							{
								expressionNode = this.ParseAggregateArgument((FunctionId)aggregate);
								this.NodePush(expressionNode);
								this._prevOperand = 2;
								continue;
							}
							this.NodePush(expressionNode);
							OperatorInfo[] ops3 = this._ops;
							topOperator = this._topOperator;
							this._topOperator = topOperator + 1;
							ops3[topOperator] = new OperatorInfo(Nodes.Call, 0, 2);
							continue;
						}
						break;
					case Tokens.RightParen:
						if (this._prevOperand != 0)
						{
							this.BuildExpression(3);
						}
						if (this._topOperator <= 1)
						{
							goto Block_18;
						}
						this._topOperator--;
						operatorInfo = this._ops[this._topOperator];
						if (this._prevOperand == 0 && operatorInfo._type != Nodes.Call)
						{
							goto Block_20;
						}
						if (operatorInfo._type == Nodes.Call)
						{
							if (this._prevOperand != 0)
							{
								ExpressionNode argument2 = this.NodePop();
								FunctionNode functionNode2 = (FunctionNode)this.NodePop();
								functionNode2.AddArgument(argument2);
								functionNode2.Check();
								this.NodePush(functionNode2);
							}
						}
						else
						{
							ExpressionNode expressionNode = this.NodePop();
							expressionNode = new UnaryNode(this._table, 0, expressionNode);
							this.NodePush(expressionNode);
						}
						this._prevOperand = 2;
						num--;
						continue;
					case Tokens.ZeroOp:
					{
						if (this._prevOperand != 0)
						{
							goto Block_28;
						}
						OperatorInfo[] ops4 = this._ops;
						topOperator = this._topOperator;
						this._topOperator = topOperator + 1;
						ops4[topOperator] = new OperatorInfo(Nodes.Zop, this._op, 24);
						this._prevOperand = 2;
						continue;
					}
					case Tokens.UnaryOp:
						goto IL_654;
					case Tokens.BinaryOp:
						if (this._prevOperand != 0)
						{
							this._prevOperand = 0;
							this.BuildExpression(Operators.Priority(this._op));
							OperatorInfo[] ops5 = this._ops;
							topOperator = this._topOperator;
							this._topOperator = topOperator + 1;
							ops5[topOperator] = new OperatorInfo(Nodes.Binop, this._op, Operators.Priority(this._op));
							continue;
						}
						if (this._op == 15)
						{
							this._op = 2;
							goto IL_654;
						}
						if (this._op == 16)
						{
							this._op = 1;
							goto IL_654;
						}
						goto IL_5F4;
					case Tokens.Dot:
					{
						ExpressionNode expressionNode3 = this.NodePeek();
						if (expressionNode3 != null && expressionNode3.GetType() == typeof(NameNode))
						{
							this.Scan();
							if (this._token == Tokens.Name)
							{
								string name = ((NameNode)this.NodePop())._name + "." + NameNode.ParseName(this._text, this._start, this._pos);
								this.NodePush(new NameNode(this._table, name));
								continue;
							}
						}
						break;
					}
					case Tokens.EOS:
						goto IL_79;
					}
					goto Block_1;
					IL_654:
					OperatorInfo[] ops6 = this._ops;
					topOperator = this._topOperator;
					this._topOperator = topOperator + 1;
					ops6[topOperator] = new OperatorInfo(Nodes.Unop, this._op, Operators.Priority(this._op));
				}
				IL_79:
				if (this._prevOperand == 0)
				{
					if (this._topNode != 0)
					{
						operatorInfo = this._ops[this._topOperator - 1];
						throw ExprException.MissingOperand(operatorInfo);
					}
					continue;
				}
				else
				{
					this.BuildExpression(3);
					if (this._topOperator != 1)
					{
						throw ExprException.MissingRightParen();
					}
					continue;
				}
				Block_1:
				goto IL_76B;
				Block_5:
				throw ExprException.MissingOperator(new string(this._text, this._start, this._pos - this._start));
				Block_9:
				throw ExprException.InWithoutParentheses();
				IL_41A:
				throw ExprException.SyntaxError();
				Block_18:
				throw ExprException.TooManyRightParentheses();
				Block_20:
				throw ExprException.MissingOperand(operatorInfo);
				Block_23:
				throw ExprException.MissingOperandBefore(",");
				Block_24:
				throw ExprException.SyntaxError();
				IL_5F4:
				throw ExprException.MissingOperandBefore(Operators.ToString(this._op));
				Block_28:
				throw ExprException.MissingOperator(new string(this._text, this._start, this._pos - this._start));
				IL_76B:
				throw ExprException.UnknownToken(new string(this._text, this._start, this._pos - this._start), this._start + 1);
			}
			this._expression = this._nodeStack[0];
			return this._expression;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00021654 File Offset: 0x0001F854
		private ExpressionNode ParseAggregateArgument(FunctionId aggregate)
		{
			this.Scan();
			string columnName;
			bool flag;
			string relationName;
			try
			{
				if (this._token != Tokens.Child)
				{
					if (this._token != Tokens.Name)
					{
						throw ExprException.AggregateArgument();
					}
					columnName = NameNode.ParseName(this._text, this._start, this._pos);
					this.ScanToken(Tokens.RightParen);
					return new AggregateNode(this._table, aggregate, columnName);
				}
				else
				{
					flag = (this._token == Tokens.Child);
					this._prevOperand = 1;
					this.Scan();
					if (this._token == Tokens.LeftParen)
					{
						this.ScanToken(Tokens.Name);
						relationName = NameNode.ParseName(this._text, this._start, this._pos);
						this.ScanToken(Tokens.RightParen);
						this.ScanToken(Tokens.Dot);
					}
					else
					{
						relationName = null;
						this.CheckToken(Tokens.Dot);
					}
					this.ScanToken(Tokens.Name);
					columnName = NameNode.ParseName(this._text, this._start, this._pos);
					this.ScanToken(Tokens.RightParen);
				}
			}
			catch (Exception e) when (ADP.IsCatchableExceptionType(e))
			{
				throw ExprException.AggregateArgument();
			}
			return new AggregateNode(this._table, aggregate, columnName, !flag, relationName);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0002177C File Offset: 0x0001F97C
		private ExpressionNode NodePop()
		{
			ExpressionNode[] nodeStack = this._nodeStack;
			int num = this._topNode - 1;
			this._topNode = num;
			return nodeStack[num];
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000217A1 File Offset: 0x0001F9A1
		private ExpressionNode NodePeek()
		{
			if (this._topNode <= 0)
			{
				return null;
			}
			return this._nodeStack[this._topNode - 1];
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000217C0 File Offset: 0x0001F9C0
		private void NodePush(ExpressionNode node)
		{
			if (this._topNode >= 98)
			{
				throw ExprException.ExpressionTooComplex();
			}
			ExpressionNode[] nodeStack = this._nodeStack;
			int topNode = this._topNode;
			this._topNode = topNode + 1;
			nodeStack[topNode] = node;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000217F8 File Offset: 0x0001F9F8
		private void BuildExpression(int pri)
		{
			OperatorInfo operatorInfo;
			for (;;)
			{
				operatorInfo = this._ops[this._topOperator - 1];
				if (operatorInfo._priority < pri)
				{
					return;
				}
				this._topOperator--;
				ExpressionNode node;
				switch (operatorInfo._type)
				{
				case Nodes.Unop:
				{
					ExpressionNode right = this.NodePop();
					int op = operatorInfo._op;
					if (op != 1 && op != 3 && op == 25)
					{
						goto Block_6;
					}
					node = new UnaryNode(this._table, operatorInfo._op, right);
					goto IL_163;
				}
				case Nodes.UnopSpec:
				case Nodes.BinopSpec:
					return;
				case Nodes.Binop:
				{
					ExpressionNode right = this.NodePop();
					ExpressionNode left = this.NodePop();
					switch (operatorInfo._op)
					{
					case 4:
					case 6:
					case 22:
					case 23:
					case 24:
					case 25:
						goto IL_D3;
					}
					if (operatorInfo._op == 14)
					{
						node = new LikeNode(this._table, operatorInfo._op, left, right);
						goto IL_163;
					}
					node = new BinaryNode(this._table, operatorInfo._op, left, right);
					goto IL_163;
				}
				case Nodes.Zop:
					node = new ZeroOpNode(operatorInfo._op);
					goto IL_163;
				}
				break;
				IL_163:
				this.NodePush(node);
			}
			return;
			IL_D3:
			throw ExprException.UnsupportedOperator(operatorInfo._op);
			Block_6:
			throw ExprException.UnsupportedOperator(operatorInfo._op);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00021974 File Offset: 0x0001FB74
		internal void CheckToken(Tokens token)
		{
			if (this._token != token)
			{
				throw ExprException.UnknownToken(token, this._token, this._pos);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00021994 File Offset: 0x0001FB94
		internal Tokens Scan()
		{
			char[] text = this._text;
			this._token = Tokens.None;
			char c;
			for (;;)
			{
				this._start = this._pos;
				this._op = 0;
				char[] array = text;
				int pos = this._pos;
				this._pos = pos + 1;
				c = array[pos];
				if (c > '>')
				{
					goto IL_CD;
				}
				if (c > '\r')
				{
					switch (c)
					{
					case ' ':
						goto IL_111;
					case '!':
					case '"':
					case '$':
					case ',':
					case '.':
						goto IL_311;
					case '#':
						goto IL_136;
					case '%':
						goto IL_26E;
					case '&':
						goto IL_283;
					case '\'':
						goto IL_148;
					case '(':
						goto IL_11C;
					case ')':
						goto IL_129;
					case '*':
						goto IL_244;
					case '+':
						goto IL_21A;
					case '-':
						goto IL_22F;
					case '/':
						goto IL_259;
					}
					goto Block_5;
				}
				if (c != '\0')
				{
					switch (c)
					{
					case '\t':
					case '\n':
					case '\r':
						goto IL_111;
					}
					break;
				}
				goto IL_104;
				IL_111:
				this.ScanWhite();
			}
			goto IL_311;
			Block_5:
			switch (c)
			{
			case '<':
				this._token = Tokens.BinaryOp;
				this.ScanWhite();
				if (text[this._pos] == '=')
				{
					this._pos++;
					this._op = 11;
					goto IL_3E5;
				}
				if (text[this._pos] == '>')
				{
					this._pos++;
					this._op = 12;
					goto IL_3E5;
				}
				this._op = 9;
				goto IL_3E5;
			case '=':
				this._token = Tokens.BinaryOp;
				this._op = 7;
				goto IL_3E5;
			case '>':
				this._token = Tokens.BinaryOp;
				this.ScanWhite();
				if (text[this._pos] == '=')
				{
					this._pos++;
					this._op = 10;
					goto IL_3E5;
				}
				this._op = 8;
				goto IL_3E5;
			default:
				goto IL_311;
			}
			IL_CD:
			if (c <= '^')
			{
				if (c == '[')
				{
					this.ScanName(']', this._escape, "]\\");
					this.CheckToken(Tokens.Name);
					goto IL_3E5;
				}
				if (c != '^')
				{
					goto IL_311;
				}
				this._token = Tokens.BinaryOp;
				this._op = 24;
				goto IL_3E5;
			}
			else
			{
				if (c == '`')
				{
					this.ScanName('`', '`', "`");
					this.CheckToken(Tokens.Name);
					goto IL_3E5;
				}
				if (c == '|')
				{
					this._token = Tokens.BinaryOp;
					this._op = 23;
					goto IL_3E5;
				}
				if (c != '~')
				{
					goto IL_311;
				}
				this._token = Tokens.BinaryOp;
				this._op = 25;
				goto IL_3E5;
			}
			IL_104:
			this._token = Tokens.EOS;
			goto IL_3E5;
			IL_11C:
			this._token = Tokens.LeftParen;
			goto IL_3E5;
			IL_129:
			this._token = Tokens.RightParen;
			goto IL_3E5;
			IL_136:
			this.ScanDate();
			this.CheckToken(Tokens.Date);
			goto IL_3E5;
			IL_148:
			this.ScanString('\'');
			this.CheckToken(Tokens.StringConst);
			goto IL_3E5;
			IL_21A:
			this._token = Tokens.BinaryOp;
			this._op = 15;
			goto IL_3E5;
			IL_22F:
			this._token = Tokens.BinaryOp;
			this._op = 16;
			goto IL_3E5;
			IL_244:
			this._token = Tokens.BinaryOp;
			this._op = 17;
			goto IL_3E5;
			IL_259:
			this._token = Tokens.BinaryOp;
			this._op = 18;
			goto IL_3E5;
			IL_26E:
			this._token = Tokens.BinaryOp;
			this._op = 20;
			goto IL_3E5;
			IL_283:
			this._token = Tokens.BinaryOp;
			this._op = 22;
			goto IL_3E5;
			IL_311:
			if (c == this._listSeparator)
			{
				this._token = Tokens.ListSeparator;
			}
			else if (c == '.')
			{
				if (this._prevOperand == 0)
				{
					this.ScanNumeric();
				}
				else
				{
					this._token = Tokens.Dot;
				}
			}
			else if (c == '0' && (text[this._pos] == 'x' || text[this._pos] == 'X'))
			{
				this.ScanBinaryConstant();
				this._token = Tokens.BinaryConst;
			}
			else if (this.IsDigit(c))
			{
				this.ScanNumeric();
			}
			else
			{
				this.ScanReserved();
				if (this._token == Tokens.None)
				{
					if (this.IsAlphaNumeric(c))
					{
						this.ScanName();
						if (this._token != Tokens.None)
						{
							this.CheckToken(Tokens.Name);
							goto IL_3E5;
						}
					}
					this._token = Tokens.Unknown;
					throw ExprException.UnknownToken(new string(text, this._start, this._pos - this._start), this._start + 1);
				}
			}
			IL_3E5:
			return this._token;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00021D8C File Offset: 0x0001FF8C
		private void ScanNumeric()
		{
			char[] text = this._text;
			bool flag = false;
			bool flag2 = false;
			while (this.IsDigit(text[this._pos]))
			{
				this._pos++;
			}
			if (text[this._pos] == this._decimalSeparator)
			{
				flag = true;
				this._pos++;
			}
			while (this.IsDigit(text[this._pos]))
			{
				this._pos++;
			}
			if (text[this._pos] == this._exponentL || text[this._pos] == this._exponentU)
			{
				flag2 = true;
				this._pos++;
				if (text[this._pos] == '-' || text[this._pos] == '+')
				{
					this._pos++;
				}
				while (this.IsDigit(text[this._pos]))
				{
					this._pos++;
				}
			}
			if (flag2)
			{
				this._token = Tokens.Float;
				return;
			}
			if (flag)
			{
				this._token = Tokens.Decimal;
				return;
			}
			this._token = Tokens.Numeric;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00021E98 File Offset: 0x00020098
		private void ScanName()
		{
			char[] text = this._text;
			while (this.IsAlphaNumeric(text[this._pos]))
			{
				this._pos++;
			}
			this._token = Tokens.Name;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00021ED4 File Offset: 0x000200D4
		private void ScanName(char chEnd, char esc, string charsToEscape)
		{
			char[] text = this._text;
			do
			{
				if (text[this._pos] == esc && this._pos + 1 < text.Length && charsToEscape.IndexOf(text[this._pos + 1]) >= 0)
				{
					this._pos++;
				}
				this._pos++;
			}
			while (this._pos < text.Length && text[this._pos] != chEnd);
			if (this._pos >= text.Length)
			{
				throw ExprException.InvalidNameBracketing(new string(text, this._start, this._pos - 1 - this._start));
			}
			this._pos++;
			this._token = Tokens.Name;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00021F88 File Offset: 0x00020188
		private void ScanDate()
		{
			char[] text = this._text;
			do
			{
				this._pos++;
			}
			while (this._pos < text.Length && text[this._pos] != '#');
			if (this._pos < text.Length && text[this._pos] == '#')
			{
				this._token = Tokens.Date;
				this._pos++;
				return;
			}
			if (this._pos >= text.Length)
			{
				throw ExprException.InvalidDate(new string(text, this._start, this._pos - 1 - this._start));
			}
			throw ExprException.InvalidDate(new string(text, this._start, this._pos - this._start));
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00022038 File Offset: 0x00020238
		private void ScanBinaryConstant()
		{
			char[] text = this._text;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00022044 File Offset: 0x00020244
		private void ScanReserved()
		{
			char[] text = this._text;
			if (this.IsAlpha(text[this._pos]))
			{
				this.ScanName();
				string @string = new string(text, this._start, this._pos - this._start);
				CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
				int num = 0;
				int num2 = ExpressionParser.s_reservedwords.Length - 1;
				int num3;
				for (;;)
				{
					num3 = (num + num2) / 2;
					int num4 = compareInfo.Compare(ExpressionParser.s_reservedwords[num3]._word, @string, CompareOptions.IgnoreCase);
					if (num4 == 0)
					{
						break;
					}
					if (num4 < 0)
					{
						num = num3 + 1;
					}
					else
					{
						num2 = num3 - 1;
					}
					if (num > num2)
					{
						return;
					}
				}
				this._token = ExpressionParser.s_reservedwords[num3]._token;
				this._op = ExpressionParser.s_reservedwords[num3]._op;
				return;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00022110 File Offset: 0x00020310
		private void ScanString(char escape)
		{
			char[] text = this._text;
			while (this._pos < text.Length)
			{
				char[] array = text;
				int pos = this._pos;
				this._pos = pos + 1;
				char c = array[pos];
				if (c == escape && this._pos < text.Length && text[this._pos] == escape)
				{
					this._pos++;
				}
				else if (c == escape)
				{
					break;
				}
			}
			if (this._pos >= text.Length)
			{
				throw ExprException.InvalidString(new string(text, this._start, this._pos - 1 - this._start));
			}
			this._token = Tokens.StringConst;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000221A6 File Offset: 0x000203A6
		internal void ScanToken(Tokens token)
		{
			this.Scan();
			this.CheckToken(token);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000221B8 File Offset: 0x000203B8
		private void ScanWhite()
		{
			char[] text = this._text;
			while (this._pos < text.Length && this.IsWhiteSpace(text[this._pos]))
			{
				this._pos++;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000221F7 File Offset: 0x000203F7
		private bool IsWhiteSpace(char ch)
		{
			return ch <= ' ' && ch > '\0';
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00022204 File Offset: 0x00020404
		private bool IsAlphaNumeric(char ch)
		{
			switch (ch)
			{
			case '$':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case '_':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				return true;
			}
			return ch > '\u007f';
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00022382 File Offset: 0x00020582
		private bool IsDigit(char ch)
		{
			switch (ch)
			{
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				return true;
			default:
				return false;
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000223BC File Offset: 0x000205BC
		private bool IsAlpha(char ch)
		{
			switch (ch)
			{
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
			case 'G':
			case 'H':
			case 'I':
			case 'J':
			case 'K':
			case 'L':
			case 'M':
			case 'N':
			case 'O':
			case 'P':
			case 'Q':
			case 'R':
			case 'S':
			case 'T':
			case 'U':
			case 'V':
			case 'W':
			case 'X':
			case 'Y':
			case 'Z':
			case '_':
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
			case 'g':
			case 'h':
			case 'i':
			case 'j':
			case 'k':
			case 'l':
			case 'm':
			case 'n':
			case 'o':
			case 'p':
			case 'q':
			case 'r':
			case 's':
			case 't':
			case 'u':
			case 'v':
			case 'w':
			case 'x':
			case 'y':
			case 'z':
				return true;
			}
			return false;
		}

		// Token: 0x040001EB RID: 491
		private static readonly ExpressionParser.ReservedWords[] s_reservedwords = new ExpressionParser.ReservedWords[]
		{
			new ExpressionParser.ReservedWords("And", Tokens.BinaryOp, 26),
			new ExpressionParser.ReservedWords("Between", Tokens.BinaryOp, 6),
			new ExpressionParser.ReservedWords("Child", Tokens.Child, 0),
			new ExpressionParser.ReservedWords("False", Tokens.ZeroOp, 34),
			new ExpressionParser.ReservedWords("In", Tokens.BinaryOp, 5),
			new ExpressionParser.ReservedWords("Is", Tokens.BinaryOp, 13),
			new ExpressionParser.ReservedWords("Like", Tokens.BinaryOp, 14),
			new ExpressionParser.ReservedWords("Not", Tokens.UnaryOp, 3),
			new ExpressionParser.ReservedWords("Null", Tokens.ZeroOp, 32),
			new ExpressionParser.ReservedWords("Or", Tokens.BinaryOp, 27),
			new ExpressionParser.ReservedWords("Parent", Tokens.Parent, 0),
			new ExpressionParser.ReservedWords("True", Tokens.ZeroOp, 33)
		};

		// Token: 0x040001EC RID: 492
		private char _escape = '\\';

		// Token: 0x040001ED RID: 493
		private char _decimalSeparator = '.';

		// Token: 0x040001EE RID: 494
		private char _listSeparator = ',';

		// Token: 0x040001EF RID: 495
		private char _exponentL = 'e';

		// Token: 0x040001F0 RID: 496
		private char _exponentU = 'E';

		// Token: 0x040001F1 RID: 497
		internal char[] _text;

		// Token: 0x040001F2 RID: 498
		internal int _pos;

		// Token: 0x040001F3 RID: 499
		internal int _start;

		// Token: 0x040001F4 RID: 500
		internal Tokens _token;

		// Token: 0x040001F5 RID: 501
		internal int _op;

		// Token: 0x040001F6 RID: 502
		internal OperatorInfo[] _ops = new OperatorInfo[100];

		// Token: 0x040001F7 RID: 503
		internal int _topOperator;

		// Token: 0x040001F8 RID: 504
		internal int _topNode;

		// Token: 0x040001F9 RID: 505
		private readonly DataTable _table;

		// Token: 0x040001FA RID: 506
		internal ExpressionNode[] _nodeStack = new ExpressionNode[100];

		// Token: 0x040001FB RID: 507
		internal int _prevOperand;

		// Token: 0x040001FC RID: 508
		internal ExpressionNode _expression;

		// Token: 0x0200005E RID: 94
		private readonly struct ReservedWords
		{
			// Token: 0x060006FB RID: 1787 RVA: 0x000225D3 File Offset: 0x000207D3
			internal ReservedWords(string word, Tokens token, int op)
			{
				this._word = word;
				this._token = token;
				this._op = op;
			}

			// Token: 0x040001FD RID: 509
			internal readonly string _word;

			// Token: 0x040001FE RID: 510
			internal readonly Tokens _token;

			// Token: 0x040001FF RID: 511
			internal readonly int _op;
		}
	}
}
