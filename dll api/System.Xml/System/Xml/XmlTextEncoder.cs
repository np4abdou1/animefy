using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace System.Xml
{
	// Token: 0x02000079 RID: 121
	internal class XmlTextEncoder
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00016126 File Offset: 0x00014326
		internal XmlTextEncoder(TextWriter textWriter)
		{
			this.textWriter = textWriter;
			this.quoteChar = '"';
			this.xmlCharType = XmlCharType.Instance;
		}

		// Token: 0x170000BA RID: 186
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00016148 File Offset: 0x00014348
		internal char QuoteChar
		{
			set
			{
				this.quoteChar = value;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00016151 File Offset: 0x00014351
		internal void StartAttribute(bool cacheAttrValue)
		{
			this.inAttribute = true;
			this.cacheAttrValue = cacheAttrValue;
			if (cacheAttrValue)
			{
				if (this.attrValue == null)
				{
					this.attrValue = new StringBuilder();
					return;
				}
				this.attrValue.Length = 0;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00016184 File Offset: 0x00014384
		internal void EndAttribute()
		{
			if (this.cacheAttrValue)
			{
				this.attrValue.Length = 0;
			}
			this.inAttribute = false;
			this.cacheAttrValue = false;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000161A8 File Offset: 0x000143A8
		internal string AttributeValue
		{
			get
			{
				if (this.cacheAttrValue)
				{
					return this.attrValue.ToString();
				}
				return string.Empty;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000161C3 File Offset: 0x000143C3
		internal void WriteSurrogateChar(char lowChar, char highChar)
		{
			if (!XmlCharType.IsLowSurrogate((int)lowChar) || !XmlCharType.IsHighSurrogate((int)highChar))
			{
				throw XmlConvert.CreateInvalidSurrogatePairException(lowChar, highChar);
			}
			this.textWriter.Write(highChar);
			this.textWriter.Write(lowChar);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000161F8 File Offset: 0x000143F8
		internal void Write(char[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (0 > offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (0 > count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > array.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this.cacheAttrValue)
			{
				this.attrValue.Append(array, offset, count);
			}
			int num = offset + count;
			int num2 = offset;
			char c = '\0';
			for (;;)
			{
				int num3 = num2;
				while (num2 < num && (this.xmlCharType.charProperties[(int)(c = array[num2])] & 128) != 0)
				{
					num2++;
				}
				if (num3 < num2)
				{
					this.textWriter.Write(array, num3, num2 - num3);
				}
				if (num2 == num)
				{
					return;
				}
				if (c <= '&')
				{
					switch (c)
					{
					case '\t':
						this.textWriter.Write(c);
						break;
					case '\n':
					case '\r':
						if (this.inAttribute)
						{
							this.WriteCharEntityImpl(c);
						}
						else
						{
							this.textWriter.Write(c);
						}
						break;
					case '\v':
					case '\f':
						goto IL_1A9;
					default:
						if (c != '"')
						{
							if (c != '&')
							{
								goto IL_1A9;
							}
							this.WriteEntityRefImpl("amp");
						}
						else if (this.inAttribute && this.quoteChar == c)
						{
							this.WriteEntityRefImpl("quot");
						}
						else
						{
							this.textWriter.Write('"');
						}
						break;
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_1A9;
						}
						this.WriteEntityRefImpl("gt");
					}
					else
					{
						this.WriteEntityRefImpl("lt");
					}
				}
				else if (this.inAttribute && this.quoteChar == c)
				{
					this.WriteEntityRefImpl("apos");
				}
				else
				{
					this.textWriter.Write('\'');
				}
				IL_1ED:
				num2++;
				continue;
				IL_1A9:
				if (XmlCharType.IsHighSurrogate((int)c))
				{
					if (num2 + 1 < num)
					{
						this.WriteSurrogateChar(array[++num2], c);
						goto IL_1ED;
					}
					break;
				}
				else
				{
					if (XmlCharType.IsLowSurrogate((int)c))
					{
						goto Block_23;
					}
					this.WriteCharEntityImpl(c);
					goto IL_1ED;
				}
			}
			throw new ArgumentException(Res.GetString("The second character surrogate pair is not in the input buffer to be written."));
			Block_23:
			throw XmlConvert.CreateInvalidHighSurrogateCharException(c);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000163FC File Offset: 0x000145FC
		internal void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			if (!XmlCharType.IsLowSurrogate((int)lowChar) || !XmlCharType.IsHighSurrogate((int)highChar))
			{
				throw XmlConvert.CreateInvalidSurrogatePairException(lowChar, highChar);
			}
			int num = XmlCharType.CombineSurrogateChar((int)lowChar, (int)highChar);
			if (this.cacheAttrValue)
			{
				this.attrValue.Append(highChar);
				this.attrValue.Append(lowChar);
			}
			this.textWriter.Write("&#x");
			this.textWriter.Write(num.ToString("X", NumberFormatInfo.InvariantInfo));
			this.textWriter.Write(';');
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00016484 File Offset: 0x00014684
		internal void Write(string text)
		{
			if (text == null)
			{
				return;
			}
			if (this.cacheAttrValue)
			{
				this.attrValue.Append(text);
			}
			int length = text.Length;
			int i = 0;
			int num = 0;
			char c = '\0';
			for (;;)
			{
				if (i >= length || (this.xmlCharType.charProperties[(int)(c = text[i])] & 128) == 0)
				{
					if (i == length)
					{
						break;
					}
					if (this.inAttribute)
					{
						if (c != '\t')
						{
							goto IL_90;
						}
						i++;
					}
					else
					{
						if (c != '\t' && c != '\n' && c != '\r' && c != '"' && c != '\'')
						{
							goto IL_90;
						}
						i++;
					}
				}
				else
				{
					i++;
				}
			}
			this.textWriter.Write(text);
			return;
			IL_90:
			char[] helperBuffer = new char[256];
			for (;;)
			{
				if (num < i)
				{
					this.WriteStringFragment(text, num, i - num, helperBuffer);
				}
				if (i == length)
				{
					return;
				}
				if (c <= '&')
				{
					switch (c)
					{
					case '\t':
						this.textWriter.Write(c);
						break;
					case '\n':
					case '\r':
						if (this.inAttribute)
						{
							this.WriteCharEntityImpl(c);
						}
						else
						{
							this.textWriter.Write(c);
						}
						break;
					case '\v':
					case '\f':
						goto IL_1BF;
					default:
						if (c != '"')
						{
							if (c != '&')
							{
								goto IL_1BF;
							}
							this.WriteEntityRefImpl("amp");
						}
						else if (this.inAttribute && this.quoteChar == c)
						{
							this.WriteEntityRefImpl("quot");
						}
						else
						{
							this.textWriter.Write('"');
						}
						break;
					}
				}
				else if (c != '\'')
				{
					if (c != '<')
					{
						if (c != '>')
						{
							goto IL_1BF;
						}
						this.WriteEntityRefImpl("gt");
					}
					else
					{
						this.WriteEntityRefImpl("lt");
					}
				}
				else if (this.inAttribute && this.quoteChar == c)
				{
					this.WriteEntityRefImpl("apos");
				}
				else
				{
					this.textWriter.Write('\'');
				}
				IL_205:
				i++;
				num = i;
				while (i < length)
				{
					if ((this.xmlCharType.charProperties[(int)(c = text[i])] & 128) == 0)
					{
						break;
					}
					i++;
				}
				continue;
				IL_1BF:
				if (XmlCharType.IsHighSurrogate((int)c))
				{
					if (i + 1 < length)
					{
						this.WriteSurrogateChar(text[++i], c);
						goto IL_205;
					}
					break;
				}
				else
				{
					if (XmlCharType.IsLowSurrogate((int)c))
					{
						goto Block_27;
					}
					this.WriteCharEntityImpl(c);
					goto IL_205;
				}
			}
			throw XmlConvert.CreateInvalidSurrogatePairException(text[i], c);
			Block_27:
			throw XmlConvert.CreateInvalidHighSurrogateCharException(c);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000166CC File Offset: 0x000148CC
		internal void WriteRawWithSurrogateChecking(string text)
		{
			if (text == null)
			{
				return;
			}
			if (this.cacheAttrValue)
			{
				this.attrValue.Append(text);
			}
			int length = text.Length;
			int num = 0;
			char c = '\0';
			char c2;
			for (;;)
			{
				if (num >= length || ((this.xmlCharType.charProperties[(int)(c = text[num])] & 16) == 0 && c >= ' '))
				{
					if (num == length)
					{
						goto IL_A4;
					}
					if (XmlCharType.IsHighSurrogate((int)c))
					{
						if (num + 1 >= length)
						{
							goto IL_7F;
						}
						c2 = text[num + 1];
						if (!XmlCharType.IsLowSurrogate((int)c2))
						{
							break;
						}
						num += 2;
					}
					else
					{
						if (XmlCharType.IsLowSurrogate((int)c))
						{
							goto Block_9;
						}
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			throw XmlConvert.CreateInvalidSurrogatePairException(c2, c);
			IL_7F:
			throw new ArgumentException(Res.GetString("The surrogate pair is invalid. Missing a low surrogate character."));
			Block_9:
			throw XmlConvert.CreateInvalidHighSurrogateCharException(c);
			IL_A4:
			this.textWriter.Write(text);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001678C File Offset: 0x0001498C
		internal void WriteRaw(char[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (0 > count)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (0 > offset)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count > array.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this.cacheAttrValue)
			{
				this.attrValue.Append(array, offset, count);
			}
			this.textWriter.Write(array, offset, count);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00016800 File Offset: 0x00014A00
		internal void WriteCharEntity(char ch)
		{
			if (XmlCharType.IsSurrogate((int)ch))
			{
				throw new ArgumentException(Res.GetString("The surrogate pair is invalid. Missing a low surrogate character."));
			}
			int num = (int)ch;
			string text = num.ToString("X", NumberFormatInfo.InvariantInfo);
			if (this.cacheAttrValue)
			{
				this.attrValue.Append("&#x");
				this.attrValue.Append(text);
				this.attrValue.Append(';');
			}
			this.WriteCharEntityImpl(text);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00016874 File Offset: 0x00014A74
		internal void WriteEntityRef(string name)
		{
			if (this.cacheAttrValue)
			{
				this.attrValue.Append('&');
				this.attrValue.Append(name);
				this.attrValue.Append(';');
			}
			this.WriteEntityRefImpl(name);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000168B0 File Offset: 0x00014AB0
		private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer)
		{
			int num = helperBuffer.Length;
			while (count > 0)
			{
				int num2 = count;
				if (num2 > num)
				{
					num2 = num;
				}
				str.CopyTo(offset, helperBuffer, 0, num2);
				this.textWriter.Write(helperBuffer, 0, num2);
				offset += num2;
				count -= num2;
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000168F4 File Offset: 0x00014AF4
		private void WriteCharEntityImpl(char ch)
		{
			int num = (int)ch;
			this.WriteCharEntityImpl(num.ToString("X", NumberFormatInfo.InvariantInfo));
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001691A File Offset: 0x00014B1A
		private void WriteCharEntityImpl(string strVal)
		{
			this.textWriter.Write("&#x");
			this.textWriter.Write(strVal);
			this.textWriter.Write(';');
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00016945 File Offset: 0x00014B45
		private void WriteEntityRefImpl(string name)
		{
			this.textWriter.Write('&');
			this.textWriter.Write(name);
			this.textWriter.Write(';');
		}

		// Token: 0x040002D3 RID: 723
		private TextWriter textWriter;

		// Token: 0x040002D4 RID: 724
		private bool inAttribute;

		// Token: 0x040002D5 RID: 725
		private char quoteChar;

		// Token: 0x040002D6 RID: 726
		private StringBuilder attrValue;

		// Token: 0x040002D7 RID: 727
		private bool cacheAttrValue;

		// Token: 0x040002D8 RID: 728
		private XmlCharType xmlCharType;
	}
}
