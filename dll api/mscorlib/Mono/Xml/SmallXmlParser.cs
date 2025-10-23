﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Mono.Xml
{
	// Token: 0x0200002A RID: 42
	internal class SmallXmlParser
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00002B8C File Offset: 0x00000D8C
		private Exception Error(string msg)
		{
			return new SmallXmlParserException(msg, this.line, this.column);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002BA0 File Offset: 0x00000DA0
		private Exception UnexpectedEndError()
		{
			string[] array = new string[this.elementNames.Count];
			this.elementNames.CopyTo(array, 0);
			return this.Error(string.Format("Unexpected end of stream. Element stack content is {0}", string.Join(",", array)));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002BE8 File Offset: 0x00000DE8
		private bool IsNameChar(char c, bool start)
		{
			if (c <= '.')
			{
				if (c == '-' || c == '.')
				{
					return !start;
				}
			}
			else if (c == ':' || c == '_')
			{
				return true;
			}
			if (c > 'Ā')
			{
				if (c == 'ՙ' || c == 'ۥ' || c == 'ۦ')
				{
					return true;
				}
				if ('ʻ' <= c && c <= 'ˁ')
				{
					return true;
				}
			}
			switch (char.GetUnicodeCategory(c))
			{
			case UnicodeCategory.UppercaseLetter:
			case UnicodeCategory.LowercaseLetter:
			case UnicodeCategory.TitlecaseLetter:
			case UnicodeCategory.OtherLetter:
			case UnicodeCategory.LetterNumber:
				return true;
			case UnicodeCategory.ModifierLetter:
			case UnicodeCategory.NonSpacingMark:
			case UnicodeCategory.SpacingCombiningMark:
			case UnicodeCategory.EnclosingMark:
			case UnicodeCategory.DecimalDigitNumber:
				return !start;
			default:
				return false;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C8A File Offset: 0x00000E8A
		private bool IsWhitespace(int c)
		{
			return c - 9 <= 1 || c == 13 || c == 32;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public void SkipWhitespaces()
		{
			this.SkipWhitespaces(false);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002CA9 File Offset: 0x00000EA9
		private void HandleWhitespaces()
		{
			while (this.IsWhitespace(this.Peek()))
			{
				this.buffer.Append((char)this.Read());
			}
			if (this.Peek() != 60 && this.Peek() >= 0)
			{
				this.isWhitespace = false;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public void SkipWhitespaces(bool expected)
		{
			for (;;)
			{
				int num = this.Peek();
				if (num - 9 > 1 && num != 13 && num != 32)
				{
					break;
				}
				this.Read();
				if (expected)
				{
					expected = false;
				}
			}
			if (expected)
			{
				throw this.Error("Whitespace is expected.");
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002D2B File Offset: 0x00000F2B
		private int Peek()
		{
			return this.reader.Peek();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002D38 File Offset: 0x00000F38
		private int Read()
		{
			int num = this.reader.Read();
			if (num == 10)
			{
				this.resetColumn = true;
			}
			if (this.resetColumn)
			{
				this.line++;
				this.resetColumn = false;
				this.column = 1;
				return num;
			}
			this.column++;
			return num;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002D90 File Offset: 0x00000F90
		public void Expect(int c)
		{
			int num = this.Read();
			if (num < 0)
			{
				throw this.UnexpectedEndError();
			}
			if (num != c)
			{
				throw this.Error(string.Format("Expected '{0}' but got {1}", (char)c, (char)num));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002DD4 File Offset: 0x00000FD4
		private string ReadUntil(char until, bool handleReferences)
		{
			while (this.Peek() >= 0)
			{
				char c = (char)this.Read();
				if (c == until)
				{
					string result = this.buffer.ToString();
					this.buffer.Length = 0;
					return result;
				}
				if (handleReferences && c == '&')
				{
					this.ReadReference();
				}
				else
				{
					this.buffer.Append(c);
				}
			}
			throw this.UnexpectedEndError();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002E34 File Offset: 0x00001034
		public string ReadName()
		{
			int num = 0;
			if (this.Peek() < 0 || !this.IsNameChar((char)this.Peek(), true))
			{
				throw this.Error("XML name start character is expected.");
			}
			for (int i = this.Peek(); i >= 0; i = this.Peek())
			{
				char c = (char)i;
				if (!this.IsNameChar(c, false))
				{
					break;
				}
				if (num == this.nameBuffer.Length)
				{
					char[] destinationArray = new char[num * 2];
					Array.Copy(this.nameBuffer, destinationArray, num);
					this.nameBuffer = destinationArray;
				}
				this.nameBuffer[num++] = c;
				this.Read();
			}
			if (num == 0)
			{
				throw this.Error("Valid XML name is expected.");
			}
			return new string(this.nameBuffer, 0, num);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002EE4 File Offset: 0x000010E4
		public void Parse(TextReader input, SmallXmlParser.IContentHandler handler)
		{
			this.reader = input;
			this.handler = handler;
			handler.OnStartParsing(this);
			while (this.Peek() >= 0)
			{
				this.ReadContent();
			}
			this.HandleBufferedContent();
			if (this.elementNames.Count > 0)
			{
				throw this.Error(string.Format("Insufficient close tag: {0}", this.elementNames.Peek()));
			}
			handler.OnEndParsing(this);
			this.Cleanup();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F54 File Offset: 0x00001154
		private void Cleanup()
		{
			this.line = 1;
			this.column = 0;
			this.handler = null;
			this.reader = null;
			this.elementNames.Clear();
			this.xmlSpaces.Clear();
			this.attributes.Clear();
			this.buffer.Length = 0;
			this.xmlSpace = null;
			this.isWhitespace = false;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002FB8 File Offset: 0x000011B8
		public void ReadContent()
		{
			if (this.IsWhitespace(this.Peek()))
			{
				if (this.buffer.Length == 0)
				{
					this.isWhitespace = true;
				}
				this.HandleWhitespaces();
			}
			if (this.Peek() != 60)
			{
				this.ReadCharacters();
				return;
			}
			this.Read();
			int num = this.Peek();
			if (num != 33)
			{
				if (num != 47)
				{
					string text;
					if (num != 63)
					{
						this.HandleBufferedContent();
						text = this.ReadName();
						while (this.Peek() != 62 && this.Peek() != 47)
						{
							this.ReadAttribute(this.attributes);
						}
						this.handler.OnStartElement(text, this.attributes);
						this.attributes.Clear();
						this.SkipWhitespaces();
						if (this.Peek() == 47)
						{
							this.Read();
							this.handler.OnEndElement(text);
						}
						else
						{
							this.elementNames.Push(text);
							this.xmlSpaces.Push(this.xmlSpace);
						}
						this.Expect(62);
						return;
					}
					this.HandleBufferedContent();
					this.Read();
					text = this.ReadName();
					this.SkipWhitespaces();
					string text2 = string.Empty;
					if (this.Peek() != 63)
					{
						for (;;)
						{
							text2 += this.ReadUntil('?', false);
							if (this.Peek() == 62)
							{
								break;
							}
							text2 += "?";
						}
					}
					this.handler.OnProcessingInstruction(text, text2);
					this.Expect(62);
					return;
				}
				else
				{
					this.HandleBufferedContent();
					if (this.elementNames.Count == 0)
					{
						throw this.UnexpectedEndError();
					}
					this.Read();
					string text = this.ReadName();
					this.SkipWhitespaces();
					string text3 = (string)this.elementNames.Pop();
					this.xmlSpaces.Pop();
					if (this.xmlSpaces.Count > 0)
					{
						this.xmlSpace = (string)this.xmlSpaces.Peek();
					}
					else
					{
						this.xmlSpace = null;
					}
					if (text != text3)
					{
						throw this.Error(string.Format("End tag mismatch: expected {0} but found {1}", text3, text));
					}
					this.handler.OnEndElement(text);
					this.Expect(62);
					return;
				}
			}
			else
			{
				this.Read();
				if (this.Peek() == 91)
				{
					this.Read();
					if (this.ReadName() != "CDATA")
					{
						throw this.Error("Invalid declaration markup");
					}
					this.Expect(91);
					this.ReadCDATASection();
					return;
				}
				else
				{
					if (this.Peek() == 45)
					{
						this.ReadComment();
						return;
					}
					if (this.ReadName() != "DOCTYPE")
					{
						throw this.Error("Invalid declaration markup.");
					}
					throw this.Error("This parser does not support document type.");
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003250 File Offset: 0x00001450
		private void HandleBufferedContent()
		{
			if (this.buffer.Length == 0)
			{
				return;
			}
			if (this.isWhitespace)
			{
				this.handler.OnIgnorableWhitespace(this.buffer.ToString());
			}
			else
			{
				this.handler.OnChars(this.buffer.ToString());
			}
			this.buffer.Length = 0;
			this.isWhitespace = false;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000032B4 File Offset: 0x000014B4
		private void ReadCharacters()
		{
			this.isWhitespace = false;
			for (;;)
			{
				int num = this.Peek();
				if (num == -1)
				{
					break;
				}
				if (num != 38)
				{
					if (num == 60)
					{
						return;
					}
					this.buffer.Append((char)this.Read());
				}
				else
				{
					this.Read();
					this.ReadReference();
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003304 File Offset: 0x00001504
		private void ReadReference()
		{
			if (this.Peek() == 35)
			{
				this.Read();
				this.ReadCharacterReference();
				return;
			}
			string a = this.ReadName();
			this.Expect(59);
			if (a == "amp")
			{
				this.buffer.Append('&');
				return;
			}
			if (a == "quot")
			{
				this.buffer.Append('"');
				return;
			}
			if (a == "apos")
			{
				this.buffer.Append('\'');
				return;
			}
			if (a == "lt")
			{
				this.buffer.Append('<');
				return;
			}
			if (!(a == "gt"))
			{
				throw this.Error("General non-predefined entity reference is not supported in this parser.");
			}
			this.buffer.Append('>');
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000033D4 File Offset: 0x000015D4
		private int ReadCharacterReference()
		{
			int num = 0;
			if (this.Peek() == 120)
			{
				this.Read();
				for (int i = this.Peek(); i >= 0; i = this.Peek())
				{
					if (48 <= i && i <= 57)
					{
						num <<= 4 + i - 48;
					}
					else if (65 <= i && i <= 70)
					{
						num <<= 4 + i - 65 + 10;
					}
					else
					{
						if (97 > i || i > 102)
						{
							break;
						}
						num <<= 4 + i - 97 + 10;
					}
					this.Read();
				}
			}
			else
			{
				int num2 = this.Peek();
				while (num2 >= 0 && 48 <= num2 && num2 <= 57)
				{
					num <<= 4 + num2 - 48;
					this.Read();
					num2 = this.Peek();
				}
			}
			return num;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003490 File Offset: 0x00001690
		private void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
			this.SkipWhitespaces(true);
			if (this.Peek() == 47 || this.Peek() == 62)
			{
				return;
			}
			string text = this.ReadName();
			this.SkipWhitespaces();
			this.Expect(61);
			this.SkipWhitespaces();
			int num = this.Read();
			string value;
			if (num != 34)
			{
				if (num != 39)
				{
					throw this.Error("Invalid attribute value markup.");
				}
				value = this.ReadUntil('\'', true);
			}
			else
			{
				value = this.ReadUntil('"', true);
			}
			if (text == "xml:space")
			{
				this.xmlSpace = value;
			}
			a.Add(text, value);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003528 File Offset: 0x00001728
		private void ReadCDATASection()
		{
			int num = 0;
			while (this.Peek() >= 0)
			{
				char c = (char)this.Read();
				if (c == ']')
				{
					num++;
				}
				else
				{
					if (c == '>' && num > 1)
					{
						for (int i = num; i > 2; i--)
						{
							this.buffer.Append(']');
						}
						return;
					}
					for (int j = 0; j < num; j++)
					{
						this.buffer.Append(']');
					}
					num = 0;
					this.buffer.Append(c);
				}
			}
			throw this.UnexpectedEndError();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000035A8 File Offset: 0x000017A8
		private void ReadComment()
		{
			this.Expect(45);
			this.Expect(45);
			while (this.Read() != 45 || this.Read() != 45)
			{
			}
			if (this.Read() != 62)
			{
				throw this.Error("'--' is not allowed inside comment markup.");
			}
		}

		// Token: 0x040000BE RID: 190
		private SmallXmlParser.IContentHandler handler;

		// Token: 0x040000BF RID: 191
		private TextReader reader;

		// Token: 0x040000C0 RID: 192
		private Stack elementNames = new Stack();

		// Token: 0x040000C1 RID: 193
		private Stack xmlSpaces = new Stack();

		// Token: 0x040000C2 RID: 194
		private string xmlSpace;

		// Token: 0x040000C3 RID: 195
		private StringBuilder buffer = new StringBuilder(200);

		// Token: 0x040000C4 RID: 196
		private char[] nameBuffer = new char[30];

		// Token: 0x040000C5 RID: 197
		private bool isWhitespace;

		// Token: 0x040000C6 RID: 198
		private SmallXmlParser.AttrListImpl attributes = new SmallXmlParser.AttrListImpl();

		// Token: 0x040000C7 RID: 199
		private int line = 1;

		// Token: 0x040000C8 RID: 200
		private int column;

		// Token: 0x040000C9 RID: 201
		private bool resetColumn;

		// Token: 0x0200002B RID: 43
		public interface IContentHandler
		{
			// Token: 0x0600007F RID: 127
			void OnStartParsing(SmallXmlParser parser);

			// Token: 0x06000080 RID: 128
			void OnEndParsing(SmallXmlParser parser);

			// Token: 0x06000081 RID: 129
			void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

			// Token: 0x06000082 RID: 130
			void OnEndElement(string name);

			// Token: 0x06000083 RID: 131
			void OnProcessingInstruction(string name, string text);

			// Token: 0x06000084 RID: 132
			void OnChars(string text);

			// Token: 0x06000085 RID: 133
			void OnIgnorableWhitespace(string text);
		}

		// Token: 0x0200002C RID: 44
		public interface IAttrList
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000086 RID: 134
			int Length { get; }

			// Token: 0x06000087 RID: 135
			string GetName(int i);

			// Token: 0x06000088 RID: 136
			string GetValue(int i);

			// Token: 0x06000089 RID: 137
			string GetValue(string name);

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600008A RID: 138
			string[] Names { get; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600008B RID: 139
			string[] Values { get; }
		}

		// Token: 0x0200002D RID: 45
		private class AttrListImpl : SmallXmlParser.IAttrList
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600008C RID: 140 RVA: 0x000035E4 File Offset: 0x000017E4
			public int Length
			{
				get
				{
					return this.attrNames.Count;
				}
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000035F1 File Offset: 0x000017F1
			public string GetName(int i)
			{
				return this.attrNames[i];
			}

			// Token: 0x0600008E RID: 142 RVA: 0x000035FF File Offset: 0x000017FF
			public string GetValue(int i)
			{
				return this.attrValues[i];
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00003610 File Offset: 0x00001810
			public string GetValue(string name)
			{
				for (int i = 0; i < this.attrNames.Count; i++)
				{
					if (this.attrNames[i] == name)
					{
						return this.attrValues[i];
					}
				}
				return null;
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000090 RID: 144 RVA: 0x00003655 File Offset: 0x00001855
			public string[] Names
			{
				get
				{
					return this.attrNames.ToArray();
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000091 RID: 145 RVA: 0x00003662 File Offset: 0x00001862
			public string[] Values
			{
				get
				{
					return this.attrValues.ToArray();
				}
			}

			// Token: 0x06000092 RID: 146 RVA: 0x0000366F File Offset: 0x0000186F
			internal void Clear()
			{
				this.attrNames.Clear();
				this.attrValues.Clear();
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00003687 File Offset: 0x00001887
			internal void Add(string name, string value)
			{
				this.attrNames.Add(name);
				this.attrValues.Add(value);
			}

			// Token: 0x040000CA RID: 202
			private List<string> attrNames = new List<string>();

			// Token: 0x040000CB RID: 203
			private List<string> attrValues = new List<string>();
		}
	}
}
