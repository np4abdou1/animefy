using System;
using System.Globalization;
using System.Xml;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000359 RID: 857
	internal sealed class XPathScanner
	{
		// Token: 0x06001D9E RID: 7582 RVA: 0x000ACACC File Offset: 0x000AACCC
		public XPathScanner(string xpathExpr)
		{
			if (xpathExpr == null)
			{
				throw XPathException.Create("'{0}' is an invalid expression.", string.Empty);
			}
			this._xpathExpr = xpathExpr;
			this.NextChar();
			this.NextLex();
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x000ACB21 File Offset: 0x000AAD21
		public string SourceText
		{
			get
			{
				return this._xpathExpr;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x000ACB29 File Offset: 0x000AAD29
		private char CurrentChar
		{
			get
			{
				return this._currentChar;
			}
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000ACB34 File Offset: 0x000AAD34
		private bool NextChar()
		{
			if (this._xpathExprIndex < this._xpathExpr.Length)
			{
				string xpathExpr = this._xpathExpr;
				int xpathExprIndex = this._xpathExprIndex;
				this._xpathExprIndex = xpathExprIndex + 1;
				this._currentChar = xpathExpr[xpathExprIndex];
				return true;
			}
			this._currentChar = '\0';
			return false;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x000ACB80 File Offset: 0x000AAD80
		public XPathScanner.LexKind Kind
		{
			get
			{
				return this._kind;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000ACB88 File Offset: 0x000AAD88
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000ACB90 File Offset: 0x000AAD90
		public string Prefix
		{
			get
			{
				return this._prefix;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x000ACB98 File Offset: 0x000AAD98
		public string StringValue
		{
			get
			{
				return this._stringValue;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000ACBA0 File Offset: 0x000AADA0
		public double NumberValue
		{
			get
			{
				return this._numberValue;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		public bool CanBeFunction
		{
			get
			{
				return this._canBeFunction;
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000ACBB0 File Offset: 0x000AADB0
		private void SkipSpace()
		{
			while (this._xmlCharType.IsWhiteSpace(this.CurrentChar) && this.NextChar())
			{
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000ACBD0 File Offset: 0x000AADD0
		public bool NextLex()
		{
			this.SkipSpace();
			char currentChar = this.CurrentChar;
			if (currentChar <= '@')
			{
				if (currentChar == '\0')
				{
					this._kind = XPathScanner.LexKind.Eof;
					return false;
				}
				switch (currentChar)
				{
				case '!':
					this._kind = XPathScanner.LexKind.Bang;
					this.NextChar();
					if (this.CurrentChar == '=')
					{
						this._kind = XPathScanner.LexKind.Ne;
						this.NextChar();
						return true;
					}
					return true;
				case '"':
				case '\'':
					this._kind = XPathScanner.LexKind.String;
					this._stringValue = this.ScanString();
					return true;
				case '#':
				case '$':
				case '(':
				case ')':
				case '*':
				case '+':
				case ',':
				case '-':
				case '=':
				case '@':
					break;
				case '%':
				case '&':
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
				case ':':
				case ';':
				case '?':
					goto IL_21D;
				case '.':
					this._kind = XPathScanner.LexKind.Dot;
					this.NextChar();
					if (this.CurrentChar == '.')
					{
						this._kind = XPathScanner.LexKind.DotDot;
						this.NextChar();
						return true;
					}
					if (XmlCharType.IsDigit(this.CurrentChar))
					{
						this._kind = XPathScanner.LexKind.Number;
						this._numberValue = this.ScanFraction();
						return true;
					}
					return true;
				case '/':
					this._kind = XPathScanner.LexKind.Slash;
					this.NextChar();
					if (this.CurrentChar == '/')
					{
						this._kind = XPathScanner.LexKind.SlashSlash;
						this.NextChar();
						return true;
					}
					return true;
				case '<':
					this._kind = XPathScanner.LexKind.Lt;
					this.NextChar();
					if (this.CurrentChar == '=')
					{
						this._kind = XPathScanner.LexKind.Le;
						this.NextChar();
						return true;
					}
					return true;
				case '>':
					this._kind = XPathScanner.LexKind.Gt;
					this.NextChar();
					if (this.CurrentChar == '=')
					{
						this._kind = XPathScanner.LexKind.Ge;
						this.NextChar();
						return true;
					}
					return true;
				default:
					goto IL_21D;
				}
			}
			else if (currentChar != '[' && currentChar != ']' && currentChar != '|')
			{
				goto IL_21D;
			}
			this._kind = (XPathScanner.LexKind)Convert.ToInt32(this.CurrentChar, CultureInfo.InvariantCulture);
			this.NextChar();
			return true;
			IL_21D:
			if (XmlCharType.IsDigit(this.CurrentChar))
			{
				this._kind = XPathScanner.LexKind.Number;
				this._numberValue = this.ScanNumber();
			}
			else
			{
				if (!this._xmlCharType.IsStartNCNameSingleChar(this.CurrentChar))
				{
					throw XPathException.Create("'{0}' has an invalid token.", this.SourceText);
				}
				this._kind = XPathScanner.LexKind.Name;
				this._name = this.ScanName();
				this._prefix = string.Empty;
				if (this.CurrentChar == ':')
				{
					this.NextChar();
					if (this.CurrentChar == ':')
					{
						this.NextChar();
						this._kind = XPathScanner.LexKind.Axe;
					}
					else
					{
						this._prefix = this._name;
						if (this.CurrentChar == '*')
						{
							this.NextChar();
							this._name = "*";
						}
						else
						{
							if (!this._xmlCharType.IsStartNCNameSingleChar(this.CurrentChar))
							{
								throw XPathException.Create("'{0}' has an invalid qualified name.", this.SourceText);
							}
							this._name = this.ScanName();
						}
					}
				}
				else
				{
					this.SkipSpace();
					if (this.CurrentChar == ':')
					{
						this.NextChar();
						if (this.CurrentChar != ':')
						{
							throw XPathException.Create("'{0}' has an invalid qualified name.", this.SourceText);
						}
						this.NextChar();
						this._kind = XPathScanner.LexKind.Axe;
					}
				}
				this.SkipSpace();
				this._canBeFunction = (this.CurrentChar == '(');
			}
			return true;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000ACF50 File Offset: 0x000AB150
		private double ScanNumber()
		{
			int startIndex = this._xpathExprIndex - 1;
			int num = 0;
			while (XmlCharType.IsDigit(this.CurrentChar))
			{
				this.NextChar();
				num++;
			}
			if (this.CurrentChar == '.')
			{
				this.NextChar();
				num++;
				while (XmlCharType.IsDigit(this.CurrentChar))
				{
					this.NextChar();
					num++;
				}
			}
			return XmlConvert.ToXPathDouble(this._xpathExpr.Substring(startIndex, num));
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000ACFC4 File Offset: 0x000AB1C4
		private double ScanFraction()
		{
			int startIndex = this._xpathExprIndex - 2;
			int num = 1;
			while (XmlCharType.IsDigit(this.CurrentChar))
			{
				this.NextChar();
				num++;
			}
			return XmlConvert.ToXPathDouble(this._xpathExpr.Substring(startIndex, num));
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000AD008 File Offset: 0x000AB208
		private string ScanString()
		{
			char currentChar = this.CurrentChar;
			this.NextChar();
			int startIndex = this._xpathExprIndex - 1;
			int num = 0;
			while (this.CurrentChar != currentChar)
			{
				if (!this.NextChar())
				{
					throw XPathException.Create("This is an unclosed string.");
				}
				num++;
			}
			this.NextChar();
			return this._xpathExpr.Substring(startIndex, num);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000AD064 File Offset: 0x000AB264
		private string ScanName()
		{
			int startIndex = this._xpathExprIndex - 1;
			int num = 0;
			while (this._xmlCharType.IsNCNameSingleChar(this.CurrentChar))
			{
				this.NextChar();
				num++;
			}
			return this._xpathExpr.Substring(startIndex, num);
		}

		// Token: 0x04001377 RID: 4983
		private string _xpathExpr;

		// Token: 0x04001378 RID: 4984
		private int _xpathExprIndex;

		// Token: 0x04001379 RID: 4985
		private XPathScanner.LexKind _kind;

		// Token: 0x0400137A RID: 4986
		private char _currentChar;

		// Token: 0x0400137B RID: 4987
		private string _name;

		// Token: 0x0400137C RID: 4988
		private string _prefix;

		// Token: 0x0400137D RID: 4989
		private string _stringValue;

		// Token: 0x0400137E RID: 4990
		private double _numberValue = double.NaN;

		// Token: 0x0400137F RID: 4991
		private bool _canBeFunction;

		// Token: 0x04001380 RID: 4992
		private XmlCharType _xmlCharType = XmlCharType.Instance;

		// Token: 0x0200035A RID: 858
		public enum LexKind
		{
			// Token: 0x04001382 RID: 4994
			Comma = 44,
			// Token: 0x04001383 RID: 4995
			Slash = 47,
			// Token: 0x04001384 RID: 4996
			At = 64,
			// Token: 0x04001385 RID: 4997
			Dot = 46,
			// Token: 0x04001386 RID: 4998
			LParens = 40,
			// Token: 0x04001387 RID: 4999
			RParens,
			// Token: 0x04001388 RID: 5000
			LBracket = 91,
			// Token: 0x04001389 RID: 5001
			RBracket = 93,
			// Token: 0x0400138A RID: 5002
			Star = 42,
			// Token: 0x0400138B RID: 5003
			Plus,
			// Token: 0x0400138C RID: 5004
			Minus = 45,
			// Token: 0x0400138D RID: 5005
			Eq = 61,
			// Token: 0x0400138E RID: 5006
			Lt = 60,
			// Token: 0x0400138F RID: 5007
			Gt = 62,
			// Token: 0x04001390 RID: 5008
			Bang = 33,
			// Token: 0x04001391 RID: 5009
			Dollar = 36,
			// Token: 0x04001392 RID: 5010
			Apos = 39,
			// Token: 0x04001393 RID: 5011
			Quote = 34,
			// Token: 0x04001394 RID: 5012
			Union = 124,
			// Token: 0x04001395 RID: 5013
			Ne = 78,
			// Token: 0x04001396 RID: 5014
			Le = 76,
			// Token: 0x04001397 RID: 5015
			Ge = 71,
			// Token: 0x04001398 RID: 5016
			And = 65,
			// Token: 0x04001399 RID: 5017
			Or = 79,
			// Token: 0x0400139A RID: 5018
			DotDot = 68,
			// Token: 0x0400139B RID: 5019
			SlashSlash = 83,
			// Token: 0x0400139C RID: 5020
			Name = 110,
			// Token: 0x0400139D RID: 5021
			String = 115,
			// Token: 0x0400139E RID: 5022
			Number = 100,
			// Token: 0x0400139F RID: 5023
			Axe = 97,
			// Token: 0x040013A0 RID: 5024
			Eof = 69
		}
	}
}
