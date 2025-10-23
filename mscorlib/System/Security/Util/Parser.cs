﻿using System;
using System.Text;

namespace System.Security.Util
{
	// Token: 0x02000289 RID: 649
	internal sealed class Parser
	{
		// Token: 0x06001695 RID: 5781 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		internal SecurityElement GetTopElement()
		{
			return this._doc.GetRootElement();
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0005C3E0 File Offset: 0x0005A5E0
		private void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int num = 1;
			SecurityElementType securityElementType = SecurityElementType.Regular;
			string text = null;
			bool flag5 = false;
			bool flag6 = false;
			int num2 = 0;
			for (;;)
			{
				short nextToken = stream.GetNextToken();
				while (nextToken != -1)
				{
					switch (nextToken & 255)
					{
					case 0:
						flag4 = true;
						flag6 = false;
						nextToken = stream.GetNextToken();
						if (nextToken == 2)
						{
							stream.TagLastToken(17408);
							for (;;)
							{
								nextToken = stream.GetNextToken();
								if (nextToken != 3)
								{
									break;
								}
								stream.ThrowAwayNextString();
								stream.TagLastToken(20480);
							}
							if (nextToken == -1)
							{
								goto Block_9;
							}
							if (nextToken != 1)
							{
								goto Block_10;
							}
							flag4 = false;
							index++;
							flag6 = false;
							num--;
							flag = true;
							goto IL_3B9;
						}
						else if (nextToken == 3)
						{
							flag3 = true;
							stream.TagLastToken(16640);
							index += SecurityDocument.EncodedStringSize(stream.GetNextString()) + 1;
							if (securityElementType != SecurityElementType.Regular)
							{
								goto Block_12;
							}
							flag = true;
							num++;
							goto IL_3B9;
						}
						else
						{
							if (nextToken == 6)
							{
								num2 = 1;
								do
								{
									nextToken = stream.GetNextToken();
									switch (nextToken)
									{
									case 0:
										num2++;
										break;
									case 1:
										num2--;
										break;
									case 3:
										stream.ThrowAwayNextString();
										stream.TagLastToken(20480);
										break;
									}
								}
								while (num2 > 0);
								flag4 = false;
								flag6 = false;
								flag = true;
								goto IL_3B9;
							}
							if (nextToken != 5)
							{
								goto IL_2B3;
							}
							nextToken = stream.GetNextToken();
							if (nextToken != 3)
							{
								goto Block_17;
							}
							flag3 = true;
							securityElementType = SecurityElementType.Format;
							stream.TagLastToken(16640);
							index += SecurityDocument.EncodedStringSize(stream.GetNextString()) + 1;
							num2 = 1;
							num++;
							flag = true;
							goto IL_3B9;
						}
						break;
					case 1:
						if (flag4)
						{
							flag4 = false;
							goto IL_3C4;
						}
						goto IL_2E0;
					case 2:
						nextToken = stream.GetNextToken();
						if (nextToken == 1)
						{
							stream.TagLastToken(17408);
							index++;
							num--;
							flag6 = false;
							flag = true;
							goto IL_3B9;
						}
						goto IL_329;
					case 3:
						if (flag4)
						{
							if (securityElementType == SecurityElementType.Comment)
							{
								stream.ThrowAwayNextString();
								stream.TagLastToken(20480);
								goto IL_3B9;
							}
							if (text == null)
							{
								text = stream.GetNextString();
								goto IL_3B9;
							}
							if (!flag5)
							{
								goto Block_5;
							}
							stream.TagLastToken(16896);
							index += SecurityDocument.EncodedStringSize(text) + SecurityDocument.EncodedStringSize(stream.GetNextString()) + 1;
							text = null;
							flag5 = false;
							goto IL_3B9;
						}
						else
						{
							if (flag6)
							{
								stream.TagLastToken(25344);
								index += SecurityDocument.EncodedStringSize(stream.GetNextString()) + SecurityDocument.EncodedStringSize(" ");
								goto IL_3B9;
							}
							stream.TagLastToken(17152);
							index += SecurityDocument.EncodedStringSize(stream.GetNextString()) + 1;
							flag6 = true;
							goto IL_3B9;
						}
						break;
					case 4:
						flag5 = true;
						goto IL_3B9;
					case 5:
						if (!flag4 || securityElementType != SecurityElementType.Format || num2 != 1)
						{
							goto IL_397;
						}
						nextToken = stream.GetNextToken();
						if (nextToken == 1)
						{
							stream.TagLastToken(17408);
							index++;
							num--;
							flag6 = false;
							flag = true;
							goto IL_3B9;
						}
						goto IL_37C;
					}
					goto Block_1;
					IL_3C4:
					nextToken = stream.GetNextToken();
					continue;
					IL_3B9:
					if (flag)
					{
						flag = false;
						flag2 = false;
						break;
					}
					flag2 = true;
					goto IL_3C4;
				}
				if (flag2)
				{
					index++;
					num--;
					flag6 = false;
				}
				else if (nextToken == -1 && (num != 1 || !flag3))
				{
					goto IL_3F5;
				}
				if (num <= 1)
				{
					return;
				}
			}
			Block_1:
			goto IL_3A8;
			Block_5:
			throw new XmlSyntaxException(this._t.LineNo);
			Block_9:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Unexpected end of file."));
			Block_10:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Expected > character."));
			Block_12:
			throw new XmlSyntaxException(this._t.LineNo);
			Block_17:
			throw new XmlSyntaxException(this._t.LineNo);
			IL_2B3:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Expected / character or string."));
			IL_2E0:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Unexpected > character."));
			IL_329:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Expected > character."));
			IL_37C:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Expected > character."));
			IL_397:
			throw new XmlSyntaxException(this._t.LineNo);
			IL_3A8:
			throw new XmlSyntaxException(this._t.LineNo);
			IL_3F5:
			throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Unexpected end of file."));
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0005C808 File Offset: 0x0005AA08
		private int DetermineFormat(TokenizerStream stream)
		{
			if (stream.GetNextToken() == 0 && stream.GetNextToken() == 5)
			{
				this._t.GetTokens(stream, -1, true);
				stream.GoToPosition(2);
				bool flag = false;
				bool flag2 = false;
				short nextToken = stream.GetNextToken();
				while (nextToken != -1 && nextToken != 1)
				{
					if (nextToken != 3)
					{
						if (nextToken != 4)
						{
							throw new XmlSyntaxException(this._t.LineNo, Environment.GetResourceString("Unexpected end of file."));
						}
						flag = true;
					}
					else
					{
						if (flag && flag2)
						{
							this._t.ChangeFormat(Encoding.GetEncoding(stream.GetNextString()));
							return 0;
						}
						if (!flag)
						{
							if (string.Compare(stream.GetNextString(), "encoding", StringComparison.Ordinal) == 0)
							{
								flag2 = true;
							}
						}
						else
						{
							flag = false;
							flag2 = false;
							stream.ThrowAwayNextString();
						}
					}
					nextToken = stream.GetNextToken();
				}
				return 0;
			}
			return 2;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0005C8CC File Offset: 0x0005AACC
		private void ParseContents()
		{
			TokenizerStream tokenizerStream = new TokenizerStream();
			this._t.GetTokens(tokenizerStream, 2, false);
			tokenizerStream.Reset();
			int position = this.DetermineFormat(tokenizerStream);
			tokenizerStream.GoToPosition(position);
			this._t.GetTokens(tokenizerStream, -1, false);
			tokenizerStream.Reset();
			int numData = 0;
			this.GetRequiredSizes(tokenizerStream, ref numData);
			this._doc = new SecurityDocument(numData);
			int num = 0;
			tokenizerStream.Reset();
			for (short nextFullToken = tokenizerStream.GetNextFullToken(); nextFullToken != -1; nextFullToken = tokenizerStream.GetNextFullToken())
			{
				if ((nextFullToken & 16384) == 16384)
				{
					short num2 = (short)((int)nextFullToken & 65280);
					if (num2 <= 17152)
					{
						if (num2 == 16640)
						{
							this._doc.AddToken(1, ref num);
							this._doc.AddString(tokenizerStream.GetNextString(), ref num);
							goto IL_19D;
						}
						if (num2 == 16896)
						{
							this._doc.AddToken(2, ref num);
							this._doc.AddString(tokenizerStream.GetNextString(), ref num);
							this._doc.AddString(tokenizerStream.GetNextString(), ref num);
							goto IL_19D;
						}
						if (num2 == 17152)
						{
							this._doc.AddToken(3, ref num);
							this._doc.AddString(tokenizerStream.GetNextString(), ref num);
							goto IL_19D;
						}
					}
					else
					{
						if (num2 == 17408)
						{
							this._doc.AddToken(4, ref num);
							goto IL_19D;
						}
						if (num2 == 20480)
						{
							tokenizerStream.ThrowAwayNextString();
							goto IL_19D;
						}
						if (num2 == 25344)
						{
							this._doc.AppendString(" ", ref num);
							this._doc.AppendString(tokenizerStream.GetNextString(), ref num);
							goto IL_19D;
						}
					}
					throw new XmlSyntaxException();
				}
				IL_19D:;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0005CA84 File Offset: 0x0005AC84
		private Parser(Tokenizer t)
		{
			this._t = t;
			this._doc = null;
			try
			{
				this.ParseContents();
			}
			finally
			{
				this._t.Recycle();
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0005CACC File Offset: 0x0005ACCC
		internal Parser(string input) : this(new Tokenizer(input))
		{
		}

		// Token: 0x040008C9 RID: 2249
		private SecurityDocument _doc;

		// Token: 0x040008CA RID: 2250
		private Tokenizer _t;
	}
}
