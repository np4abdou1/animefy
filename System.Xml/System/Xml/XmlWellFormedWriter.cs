using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x020000FA RID: 250
	internal class XmlWellFormedWriter : XmlWriter
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x0003A7A0 File Offset: 0x000389A0
		internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings)
		{
			this.writer = writer;
			this.rawWriter = (writer as XmlRawWriter);
			this.predefinedNamespaces = (writer as IXmlNamespaceResolver);
			if (this.rawWriter != null)
			{
				this.rawWriter.NamespaceResolver = new XmlWellFormedWriter.NamespaceResolverProxy(this);
			}
			this.checkCharacters = settings.CheckCharacters;
			this.omitDuplNamespaces = ((settings.NamespaceHandling & NamespaceHandling.OmitDuplicates) > NamespaceHandling.Default);
			this.writeEndDocumentOnClose = settings.WriteEndDocumentOnClose;
			this.conformanceLevel = settings.ConformanceLevel;
			this.stateTable = ((this.conformanceLevel == ConformanceLevel.Document) ? XmlWellFormedWriter.StateTableDocument : XmlWellFormedWriter.StateTableAuto);
			this.currentState = XmlWellFormedWriter.State.Start;
			this.nsStack = new XmlWellFormedWriter.Namespace[8];
			this.nsStack[0].Set("xmlns", "http://www.w3.org/2000/xmlns/", XmlWellFormedWriter.NamespaceKind.Special);
			this.nsStack[1].Set("xml", "http://www.w3.org/XML/1998/namespace", XmlWellFormedWriter.NamespaceKind.Special);
			if (this.predefinedNamespaces == null)
			{
				this.nsStack[2].Set(string.Empty, string.Empty, XmlWellFormedWriter.NamespaceKind.Implied);
			}
			else
			{
				string text = this.predefinedNamespaces.LookupNamespace(string.Empty);
				this.nsStack[2].Set(string.Empty, (text == null) ? string.Empty : text, XmlWellFormedWriter.NamespaceKind.Implied);
			}
			this.nsTop = 2;
			this.elemScopeStack = new XmlWellFormedWriter.ElementScope[8];
			this.elemScopeStack[0].Set(string.Empty, string.Empty, string.Empty, this.nsTop);
			this.elemScopeStack[0].xmlSpace = XmlSpace.None;
			this.elemScopeStack[0].xmlLang = null;
			this.elemTop = 0;
			this.attrStack = new XmlWellFormedWriter.AttrName[8];
			this.hasher = new SecureStringHasher();
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0003A965 File Offset: 0x00038B65
		public override WriteState WriteState
		{
			get
			{
				if (this.currentState <= XmlWellFormedWriter.State.Error)
				{
					return XmlWellFormedWriter.state2WriteState[(int)this.currentState];
				}
				return WriteState.Error;
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0003A97F File Offset: 0x00038B7F
		public override void WriteStartDocument()
		{
			this.WriteStartDocumentImpl(XmlStandalone.Omit);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0003A988 File Offset: 0x00038B88
		public override void WriteStartDocument(bool standalone)
		{
			this.WriteStartDocumentImpl(standalone ? XmlStandalone.Yes : XmlStandalone.No);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0003A998 File Offset: 0x00038B98
		public override void WriteEndDocument()
		{
			try
			{
				while (this.elemTop > 0)
				{
					this.WriteEndElement();
				}
				int num = (int)this.currentState;
				this.AdvanceState(XmlWellFormedWriter.Token.EndDocument);
				if (num != 7)
				{
					throw new ArgumentException(Res.GetString("Document does not have a root element."));
				}
				if (this.rawWriter == null)
				{
					this.writer.WriteEndDocument();
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003AA08 File Offset: 0x00038C08
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			try
			{
				if (name == null || name.Length == 0)
				{
					throw new ArgumentException(Res.GetString("The empty string '' is not a valid name."));
				}
				XmlConvert.VerifyQName(name, ExceptionType.XmlException);
				if (this.conformanceLevel == ConformanceLevel.Fragment)
				{
					throw new InvalidOperationException(Res.GetString("DTD is not allowed in XML fragments."));
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Dtd);
				if (this.dtdWritten)
				{
					this.currentState = XmlWellFormedWriter.State.Error;
					throw new InvalidOperationException(Res.GetString("The DTD has already been written out."));
				}
				if (this.conformanceLevel == ConformanceLevel.Auto)
				{
					this.conformanceLevel = ConformanceLevel.Document;
					this.stateTable = XmlWellFormedWriter.StateTableDocument;
				}
				if (this.checkCharacters)
				{
					int invCharIndex;
					if (pubid != null && (invCharIndex = this.xmlCharType.IsPublicId(pubid)) >= 0)
					{
						string name2 = "'{0}', hexadecimal value {1}, is an invalid character.";
						object[] args = XmlException.BuildCharExceptionArgs(pubid, invCharIndex);
						throw new ArgumentException(Res.GetString(name2, args), "pubid");
					}
					if (sysid != null && (invCharIndex = this.xmlCharType.IsOnlyCharData(sysid)) >= 0)
					{
						string name3 = "'{0}', hexadecimal value {1}, is an invalid character.";
						object[] args = XmlException.BuildCharExceptionArgs(sysid, invCharIndex);
						throw new ArgumentException(Res.GetString(name3, args), "sysid");
					}
					if (subset != null && (invCharIndex = this.xmlCharType.IsOnlyCharData(subset)) >= 0)
					{
						string name4 = "'{0}', hexadecimal value {1}, is an invalid character.";
						object[] args = XmlException.BuildCharExceptionArgs(subset, invCharIndex);
						throw new ArgumentException(Res.GetString(name4, args), "subset");
					}
				}
				this.writer.WriteDocType(name, pubid, sysid, subset);
				this.dtdWritten = true;
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0003AB78 File Offset: 0x00038D78
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			try
			{
				if (localName == null || localName.Length == 0)
				{
					throw new ArgumentException(Res.GetString("The empty string '' is not a valid local name."));
				}
				this.CheckNCName(localName);
				this.AdvanceState(XmlWellFormedWriter.Token.StartElement);
				if (prefix == null)
				{
					if (ns != null)
					{
						prefix = this.LookupPrefix(ns);
					}
					if (prefix == null)
					{
						prefix = string.Empty;
					}
				}
				else if (prefix.Length > 0)
				{
					this.CheckNCName(prefix);
					if (ns == null)
					{
						ns = this.LookupNamespace(prefix);
					}
					if (ns == null || (ns != null && ns.Length == 0))
					{
						throw new ArgumentException(Res.GetString("Cannot use a prefix with an empty namespace."));
					}
				}
				if (ns == null)
				{
					ns = this.LookupNamespace(prefix);
					if (ns == null)
					{
						ns = string.Empty;
					}
				}
				if (this.elemTop == 0 && this.rawWriter != null)
				{
					this.rawWriter.OnRootElement(this.conformanceLevel);
				}
				this.writer.WriteStartElement(prefix, localName, ns);
				int num = this.elemTop + 1;
				this.elemTop = num;
				int num2 = num;
				if (num2 == this.elemScopeStack.Length)
				{
					XmlWellFormedWriter.ElementScope[] destinationArray = new XmlWellFormedWriter.ElementScope[num2 * 2];
					Array.Copy(this.elemScopeStack, destinationArray, num2);
					this.elemScopeStack = destinationArray;
				}
				this.elemScopeStack[num2].Set(prefix, localName, ns, this.nsTop);
				this.PushNamespaceImplicit(prefix, ns);
				if (this.attrCount >= 14)
				{
					this.attrHashTable.Clear();
				}
				this.attrCount = 0;
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0003ACEC File Offset: 0x00038EEC
		public override void WriteEndElement()
		{
			try
			{
				this.AdvanceState(XmlWellFormedWriter.Token.EndElement);
				int num = this.elemTop;
				if (num == 0)
				{
					throw new XmlException("There was no XML start tag open.", string.Empty);
				}
				if (this.rawWriter != null)
				{
					this.elemScopeStack[num].WriteEndElement(this.rawWriter);
				}
				else
				{
					this.writer.WriteEndElement();
				}
				int prevNSTop = this.elemScopeStack[num].prevNSTop;
				if (this.useNsHashtable && prevNSTop < this.nsTop)
				{
					this.PopNamespaces(prevNSTop + 1, this.nsTop);
				}
				this.nsTop = prevNSTop;
				if ((this.elemTop = num - 1) == 0)
				{
					if (this.conformanceLevel == ConformanceLevel.Document)
					{
						this.currentState = XmlWellFormedWriter.State.AfterRootEle;
					}
					else
					{
						this.currentState = XmlWellFormedWriter.State.TopLevel;
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0003ADC4 File Offset: 0x00038FC4
		public override void WriteFullEndElement()
		{
			try
			{
				this.AdvanceState(XmlWellFormedWriter.Token.EndElement);
				int num = this.elemTop;
				if (num == 0)
				{
					throw new XmlException("There was no XML start tag open.", string.Empty);
				}
				if (this.rawWriter != null)
				{
					this.elemScopeStack[num].WriteFullEndElement(this.rawWriter);
				}
				else
				{
					this.writer.WriteFullEndElement();
				}
				int prevNSTop = this.elemScopeStack[num].prevNSTop;
				if (this.useNsHashtable && prevNSTop < this.nsTop)
				{
					this.PopNamespaces(prevNSTop + 1, this.nsTop);
				}
				this.nsTop = prevNSTop;
				if ((this.elemTop = num - 1) == 0)
				{
					if (this.conformanceLevel == ConformanceLevel.Document)
					{
						this.currentState = XmlWellFormedWriter.State.AfterRootEle;
					}
					else
					{
						this.currentState = XmlWellFormedWriter.State.TopLevel;
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003AE9C File Offset: 0x0003909C
		public override void WriteStartAttribute(string prefix, string localName, string namespaceName)
		{
			try
			{
				if (localName == null || localName.Length == 0)
				{
					if (!(prefix == "xmlns"))
					{
						throw new ArgumentException(Res.GetString("The empty string '' is not a valid local name."));
					}
					localName = "xmlns";
					prefix = string.Empty;
				}
				this.CheckNCName(localName);
				this.AdvanceState(XmlWellFormedWriter.Token.StartAttribute);
				if (prefix == null)
				{
					if (namespaceName != null && (!(localName == "xmlns") || !(namespaceName == "http://www.w3.org/2000/xmlns/")))
					{
						prefix = this.LookupPrefix(namespaceName);
					}
					if (prefix == null)
					{
						prefix = string.Empty;
					}
				}
				if (namespaceName == null)
				{
					if (prefix != null && prefix.Length > 0)
					{
						namespaceName = this.LookupNamespace(prefix);
					}
					if (namespaceName == null)
					{
						namespaceName = string.Empty;
					}
				}
				if (prefix.Length == 0)
				{
					if (localName[0] == 'x' && localName == "xmlns")
					{
						if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/2000/xmlns/")
						{
							throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
						}
						this.curDeclPrefix = string.Empty;
						this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.DefaultXmlns);
						goto IL_224;
					}
					else if (namespaceName.Length > 0)
					{
						prefix = this.LookupPrefix(namespaceName);
						if (prefix == null || prefix.Length == 0)
						{
							prefix = this.GeneratePrefix();
						}
					}
				}
				else
				{
					if (prefix[0] == 'x')
					{
						if (prefix == "xmlns")
						{
							if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/2000/xmlns/")
							{
								throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
							}
							this.curDeclPrefix = localName;
							this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.PrefixedXmlns);
							goto IL_224;
						}
						else if (prefix == "xml")
						{
							if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/XML/1998/namespace")
							{
								throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
							}
							if (localName == "space")
							{
								this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.XmlSpace);
								goto IL_224;
							}
							if (localName == "lang")
							{
								this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.XmlLang);
								goto IL_224;
							}
						}
					}
					this.CheckNCName(prefix);
					if (namespaceName.Length == 0)
					{
						prefix = string.Empty;
					}
					else
					{
						string text = this.LookupLocalNamespace(prefix);
						if (text != null && text != namespaceName)
						{
							prefix = this.GeneratePrefix();
						}
					}
				}
				if (prefix.Length != 0)
				{
					this.PushNamespaceImplicit(prefix, namespaceName);
				}
				IL_224:
				this.AddAttribute(prefix, localName, namespaceName);
				if (this.specAttr == XmlWellFormedWriter.SpecialAttribute.No)
				{
					this.writer.WriteStartAttribute(prefix, localName, namespaceName);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0003B118 File Offset: 0x00039318
		public override void WriteEndAttribute()
		{
			try
			{
				this.AdvanceState(XmlWellFormedWriter.Token.EndAttribute);
				if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
				{
					switch (this.specAttr)
					{
					case XmlWellFormedWriter.SpecialAttribute.DefaultXmlns:
					{
						string stringValue = this.attrValueCache.StringValue;
						if (this.PushNamespaceExplicit(string.Empty, stringValue))
						{
							if (this.rawWriter != null)
							{
								if (this.rawWriter.SupportsNamespaceDeclarationInChunks)
								{
									this.rawWriter.WriteStartNamespaceDeclaration(string.Empty);
									this.attrValueCache.Replay(this.rawWriter);
									this.rawWriter.WriteEndNamespaceDeclaration();
								}
								else
								{
									this.rawWriter.WriteNamespaceDeclaration(string.Empty, stringValue);
								}
							}
							else
							{
								this.writer.WriteStartAttribute(string.Empty, "xmlns", "http://www.w3.org/2000/xmlns/");
								this.attrValueCache.Replay(this.writer);
								this.writer.WriteEndAttribute();
							}
						}
						this.curDeclPrefix = null;
						break;
					}
					case XmlWellFormedWriter.SpecialAttribute.PrefixedXmlns:
					{
						string stringValue = this.attrValueCache.StringValue;
						if (stringValue.Length == 0)
						{
							throw new ArgumentException(Res.GetString("Cannot use a prefix with an empty namespace."));
						}
						if (stringValue == "http://www.w3.org/2000/xmlns/" || (stringValue == "http://www.w3.org/XML/1998/namespace" && this.curDeclPrefix != "xml"))
						{
							throw new ArgumentException(Res.GetString("Cannot bind to the reserved namespace."));
						}
						if (this.PushNamespaceExplicit(this.curDeclPrefix, stringValue))
						{
							if (this.rawWriter != null)
							{
								if (this.rawWriter.SupportsNamespaceDeclarationInChunks)
								{
									this.rawWriter.WriteStartNamespaceDeclaration(this.curDeclPrefix);
									this.attrValueCache.Replay(this.rawWriter);
									this.rawWriter.WriteEndNamespaceDeclaration();
								}
								else
								{
									this.rawWriter.WriteNamespaceDeclaration(this.curDeclPrefix, stringValue);
								}
							}
							else
							{
								this.writer.WriteStartAttribute("xmlns", this.curDeclPrefix, "http://www.w3.org/2000/xmlns/");
								this.attrValueCache.Replay(this.writer);
								this.writer.WriteEndAttribute();
							}
						}
						this.curDeclPrefix = null;
						break;
					}
					case XmlWellFormedWriter.SpecialAttribute.XmlSpace:
					{
						this.attrValueCache.Trim();
						string stringValue = this.attrValueCache.StringValue;
						if (stringValue == "default")
						{
							this.elemScopeStack[this.elemTop].xmlSpace = XmlSpace.Default;
						}
						else
						{
							if (!(stringValue == "preserve"))
							{
								throw new ArgumentException(Res.GetString("'{0}' is an invalid xml:space value.", new object[]
								{
									stringValue
								}));
							}
							this.elemScopeStack[this.elemTop].xmlSpace = XmlSpace.Preserve;
						}
						this.writer.WriteStartAttribute("xml", "space", "http://www.w3.org/XML/1998/namespace");
						this.attrValueCache.Replay(this.writer);
						this.writer.WriteEndAttribute();
						break;
					}
					case XmlWellFormedWriter.SpecialAttribute.XmlLang:
					{
						string stringValue = this.attrValueCache.StringValue;
						this.elemScopeStack[this.elemTop].xmlLang = stringValue;
						this.writer.WriteStartAttribute("xml", "lang", "http://www.w3.org/XML/1998/namespace");
						this.attrValueCache.Replay(this.writer);
						this.writer.WriteEndAttribute();
						break;
					}
					}
					this.specAttr = XmlWellFormedWriter.SpecialAttribute.No;
					this.attrValueCache.Clear();
				}
				else
				{
					this.writer.WriteEndAttribute();
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0003B474 File Offset: 0x00039674
		public override void WriteCData(string text)
		{
			try
			{
				if (text == null)
				{
					text = string.Empty;
				}
				this.AdvanceState(XmlWellFormedWriter.Token.CData);
				this.writer.WriteCData(text);
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0003B4BC File Offset: 0x000396BC
		public override void WriteComment(string text)
		{
			try
			{
				if (text == null)
				{
					text = string.Empty;
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Comment);
				this.writer.WriteComment(text);
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0003B504 File Offset: 0x00039704
		public override void WriteProcessingInstruction(string name, string text)
		{
			try
			{
				if (name == null || name.Length == 0)
				{
					throw new ArgumentException(Res.GetString("The empty string '' is not a valid name."));
				}
				this.CheckNCName(name);
				if (text == null)
				{
					text = string.Empty;
				}
				if (name.Length == 3 && string.Compare(name, "xml", StringComparison.OrdinalIgnoreCase) == 0)
				{
					if (this.currentState != XmlWellFormedWriter.State.Start)
					{
						throw new ArgumentException(Res.GetString((this.conformanceLevel == ConformanceLevel.Document) ? "Cannot write XML declaration. WriteStartDocument method has already written it." : "Cannot write XML declaration. XML declaration can be only at the beginning of the document."));
					}
					this.xmlDeclFollows = true;
					this.AdvanceState(XmlWellFormedWriter.Token.PI);
					if (this.rawWriter != null)
					{
						this.rawWriter.WriteXmlDeclaration(text);
					}
					else
					{
						this.writer.WriteProcessingInstruction(name, text);
					}
				}
				else
				{
					this.AdvanceState(XmlWellFormedWriter.Token.PI);
					this.writer.WriteProcessingInstruction(name, text);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0003B5E0 File Offset: 0x000397E0
		public override void WriteEntityRef(string name)
		{
			try
			{
				if (name == null || name.Length == 0)
				{
					throw new ArgumentException(Res.GetString("The empty string '' is not a valid name."));
				}
				this.CheckNCName(name);
				this.AdvanceState(XmlWellFormedWriter.Token.Text);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteEntityRef(name);
				}
				else
				{
					this.writer.WriteEntityRef(name);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0003B658 File Offset: 0x00039858
		public override void WriteCharEntity(char ch)
		{
			try
			{
				if (char.IsSurrogate(ch))
				{
					throw new ArgumentException(Res.GetString("The surrogate pair is invalid. Missing a low surrogate character."));
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Text);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteCharEntity(ch);
				}
				else
				{
					this.writer.WriteCharEntity(ch);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0003B6C4 File Offset: 0x000398C4
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			try
			{
				if (!char.IsSurrogatePair(highChar, lowChar))
				{
					throw XmlConvert.CreateInvalidSurrogatePairException(lowChar, highChar);
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Text);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteSurrogateCharEntity(lowChar, highChar);
				}
				else
				{
					this.writer.WriteSurrogateCharEntity(lowChar, highChar);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0003B72C File Offset: 0x0003992C
		public override void WriteWhitespace(string ws)
		{
			try
			{
				if (ws == null)
				{
					ws = string.Empty;
				}
				if (!XmlCharType.Instance.IsOnlyWhitespace(ws))
				{
					throw new ArgumentException(Res.GetString("Only white space characters should be used."));
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Whitespace);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteWhitespace(ws);
				}
				else
				{
					this.writer.WriteWhitespace(ws);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0003B7AC File Offset: 0x000399AC
		public override void WriteString(string text)
		{
			try
			{
				if (text != null)
				{
					this.AdvanceState(XmlWellFormedWriter.Token.Text);
					if (this.SaveAttrValue)
					{
						this.attrValueCache.WriteString(text);
					}
					else
					{
						this.writer.WriteString(text);
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003B808 File Offset: 0x00039A08
		public override void WriteChars(char[] buffer, int index, int count)
		{
			try
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (count < 0)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (count > buffer.Length - index)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Text);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteChars(buffer, index, count);
				}
				else
				{
					this.writer.WriteChars(buffer, index, count);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			try
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (count < 0)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (count > buffer.Length - index)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				this.AdvanceState(XmlWellFormedWriter.Token.RawData);
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteRaw(buffer, index, count);
				}
				else
				{
					this.writer.WriteRaw(buffer, index, count);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0003B938 File Offset: 0x00039B38
		public override void WriteRaw(string data)
		{
			try
			{
				if (data != null)
				{
					this.AdvanceState(XmlWellFormedWriter.Token.RawData);
					if (this.SaveAttrValue)
					{
						this.attrValueCache.WriteRaw(data);
					}
					else
					{
						this.writer.WriteRaw(data);
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0003B994 File Offset: 0x00039B94
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			try
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (count < 0)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (count > buffer.Length - index)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				this.AdvanceState(XmlWellFormedWriter.Token.Base64);
				this.writer.WriteBase64(buffer, index, count);
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0003BA14 File Offset: 0x00039C14
		public override void Close()
		{
			if (this.currentState != XmlWellFormedWriter.State.Closed)
			{
				try
				{
					if (this.writeEndDocumentOnClose)
					{
						while (this.currentState != XmlWellFormedWriter.State.Error)
						{
							if (this.elemTop <= 0)
							{
								break;
							}
							this.WriteEndElement();
						}
					}
					else if (this.currentState != XmlWellFormedWriter.State.Error && this.elemTop > 0)
					{
						try
						{
							this.AdvanceState(XmlWellFormedWriter.Token.EndElement);
						}
						catch
						{
							this.currentState = XmlWellFormedWriter.State.Error;
							throw;
						}
					}
					if (this.InBase64 && this.rawWriter != null)
					{
						this.rawWriter.WriteEndBase64();
					}
					this.writer.Flush();
				}
				finally
				{
					try
					{
						if (this.rawWriter != null)
						{
							this.rawWriter.Close(this.WriteState);
						}
						else
						{
							this.writer.Close();
						}
					}
					finally
					{
						this.currentState = XmlWellFormedWriter.State.Closed;
					}
				}
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0003BB00 File Offset: 0x00039D00
		public override void Flush()
		{
			try
			{
				this.writer.Flush();
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0003BB38 File Offset: 0x00039D38
		public override string LookupPrefix(string ns)
		{
			string result;
			try
			{
				if (ns == null)
				{
					throw new ArgumentNullException("ns");
				}
				for (int i = this.nsTop; i >= 0; i--)
				{
					if (this.nsStack[i].namespaceUri == ns)
					{
						string prefix = this.nsStack[i].prefix;
						for (i++; i <= this.nsTop; i++)
						{
							if (this.nsStack[i].prefix == prefix)
							{
								return null;
							}
						}
						return prefix;
					}
				}
				result = ((this.predefinedNamespaces != null) ? this.predefinedNamespaces.LookupPrefix(ns) : null);
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0003BBFC File Offset: 0x00039DFC
		public override void WriteValue(string value)
		{
			try
			{
				if (value != null)
				{
					if (this.SaveAttrValue)
					{
						this.AdvanceState(XmlWellFormedWriter.Token.Text);
						this.attrValueCache.WriteValue(value);
					}
					else
					{
						this.AdvanceState(XmlWellFormedWriter.Token.AtomicValue);
						this.writer.WriteValue(value);
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0003BC60 File Offset: 0x00039E60
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			if (this.IsClosedOrErrorState)
			{
				throw new InvalidOperationException(Res.GetString("The Writer is closed or in error state."));
			}
			try
			{
				this.AdvanceState(XmlWellFormedWriter.Token.Text);
				base.WriteBinHex(buffer, index, count);
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0003BCB4 File Offset: 0x00039EB4
		internal XmlRawWriter RawWriter
		{
			get
			{
				return this.rawWriter;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0003BCBC File Offset: 0x00039EBC
		private bool SaveAttrValue
		{
			get
			{
				return this.specAttr > XmlWellFormedWriter.SpecialAttribute.No;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0003BCC7 File Offset: 0x00039EC7
		private bool InBase64
		{
			get
			{
				return this.currentState == XmlWellFormedWriter.State.B64Content || this.currentState == XmlWellFormedWriter.State.B64Attribute || this.currentState == XmlWellFormedWriter.State.RootLevelB64Attr;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0003BCE8 File Offset: 0x00039EE8
		private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special)
		{
			this.specAttr = special;
			if (XmlWellFormedWriter.State.Attribute == this.currentState)
			{
				this.currentState = XmlWellFormedWriter.State.SpecialAttr;
			}
			else if (XmlWellFormedWriter.State.RootLevelAttr == this.currentState)
			{
				this.currentState = XmlWellFormedWriter.State.RootLevelSpecAttr;
			}
			if (this.attrValueCache == null)
			{
				this.attrValueCache = new XmlWellFormedWriter.AttributeValueCache();
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0003BD34 File Offset: 0x00039F34
		private void WriteStartDocumentImpl(XmlStandalone standalone)
		{
			try
			{
				this.AdvanceState(XmlWellFormedWriter.Token.StartDocument);
				if (this.conformanceLevel == ConformanceLevel.Auto)
				{
					this.conformanceLevel = ConformanceLevel.Document;
					this.stateTable = XmlWellFormedWriter.StateTableDocument;
				}
				else if (this.conformanceLevel == ConformanceLevel.Fragment)
				{
					throw new InvalidOperationException(Res.GetString("WriteStartDocument cannot be called on writers created with ConformanceLevel.Fragment."));
				}
				if (this.rawWriter != null)
				{
					if (!this.xmlDeclFollows)
					{
						this.rawWriter.WriteXmlDeclaration(standalone);
					}
				}
				else
				{
					this.writer.WriteStartDocument();
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0003BDC4 File Offset: 0x00039FC4
		private void StartFragment()
		{
			this.conformanceLevel = ConformanceLevel.Fragment;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0003BDD0 File Offset: 0x00039FD0
		private void PushNamespaceImplicit(string prefix, string ns)
		{
			int num = this.LookupNamespaceIndex(prefix);
			XmlWellFormedWriter.NamespaceKind kind;
			if (num != -1)
			{
				if (num > this.elemScopeStack[this.elemTop].prevNSTop)
				{
					if (this.nsStack[num].namespaceUri != ns)
					{
						throw new XmlException("The prefix '{0}' cannot be redefined from '{1}' to '{2}' within the same start element tag.", new string[]
						{
							prefix,
							this.nsStack[num].namespaceUri,
							ns
						});
					}
					return;
				}
				else if (this.nsStack[num].kind == XmlWellFormedWriter.NamespaceKind.Special)
				{
					if (!(prefix == "xml"))
					{
						throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
					}
					if (ns != this.nsStack[num].namespaceUri)
					{
						throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
					}
					kind = XmlWellFormedWriter.NamespaceKind.Implied;
				}
				else
				{
					kind = ((this.nsStack[num].namespaceUri == ns) ? XmlWellFormedWriter.NamespaceKind.Implied : XmlWellFormedWriter.NamespaceKind.NeedToWrite);
				}
			}
			else
			{
				if ((ns == "http://www.w3.org/XML/1998/namespace" && prefix != "xml") || (ns == "http://www.w3.org/2000/xmlns/" && prefix != "xmlns"))
				{
					throw new ArgumentException(Res.GetString("Prefix '{0}' cannot be mapped to namespace name reserved for \"xml\" or \"xmlns\".", new object[]
					{
						prefix
					}));
				}
				if (this.predefinedNamespaces != null)
				{
					kind = ((this.predefinedNamespaces.LookupNamespace(prefix) == ns) ? XmlWellFormedWriter.NamespaceKind.Implied : XmlWellFormedWriter.NamespaceKind.NeedToWrite);
				}
				else
				{
					kind = XmlWellFormedWriter.NamespaceKind.NeedToWrite;
				}
			}
			this.AddNamespace(prefix, ns, kind);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0003BF4C File Offset: 0x0003A14C
		private bool PushNamespaceExplicit(string prefix, string ns)
		{
			bool result = true;
			int num = this.LookupNamespaceIndex(prefix);
			if (num != -1)
			{
				if (num > this.elemScopeStack[this.elemTop].prevNSTop)
				{
					if (this.nsStack[num].namespaceUri != ns)
					{
						throw new XmlException("The prefix '{0}' cannot be redefined from '{1}' to '{2}' within the same start element tag.", new string[]
						{
							prefix,
							this.nsStack[num].namespaceUri,
							ns
						});
					}
					XmlWellFormedWriter.NamespaceKind kind = this.nsStack[num].kind;
					if (kind == XmlWellFormedWriter.NamespaceKind.Written)
					{
						throw XmlWellFormedWriter.DupAttrException((prefix.Length == 0) ? string.Empty : "xmlns", (prefix.Length == 0) ? "xmlns" : prefix);
					}
					if (this.omitDuplNamespaces && kind != XmlWellFormedWriter.NamespaceKind.NeedToWrite)
					{
						result = false;
					}
					this.nsStack[num].kind = XmlWellFormedWriter.NamespaceKind.Written;
					return result;
				}
				else if (this.nsStack[num].namespaceUri == ns && this.omitDuplNamespaces)
				{
					result = false;
				}
			}
			else if (this.predefinedNamespaces != null && this.predefinedNamespaces.LookupNamespace(prefix) == ns && this.omitDuplNamespaces)
			{
				result = false;
			}
			if ((ns == "http://www.w3.org/XML/1998/namespace" && prefix != "xml") || (ns == "http://www.w3.org/2000/xmlns/" && prefix != "xmlns"))
			{
				throw new ArgumentException(Res.GetString("Prefix '{0}' cannot be mapped to namespace name reserved for \"xml\" or \"xmlns\".", new object[]
				{
					prefix
				}));
			}
			if (prefix.Length > 0 && prefix[0] == 'x')
			{
				if (prefix == "xml")
				{
					if (ns != "http://www.w3.org/XML/1998/namespace")
					{
						throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
					}
				}
				else if (prefix == "xmlns")
				{
					throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
				}
			}
			this.AddNamespace(prefix, ns, XmlWellFormedWriter.NamespaceKind.Written);
			return result;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0003C12C File Offset: 0x0003A32C
		private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind)
		{
			int num = this.nsTop + 1;
			this.nsTop = num;
			int num2 = num;
			if (num2 == this.nsStack.Length)
			{
				XmlWellFormedWriter.Namespace[] destinationArray = new XmlWellFormedWriter.Namespace[num2 * 2];
				Array.Copy(this.nsStack, destinationArray, num2);
				this.nsStack = destinationArray;
			}
			this.nsStack[num2].Set(prefix, ns, kind);
			if (this.useNsHashtable)
			{
				this.AddToNamespaceHashtable(this.nsTop);
				return;
			}
			if (this.nsTop == 16)
			{
				this.nsHashtable = new Dictionary<string, int>(this.hasher);
				for (int i = 0; i <= this.nsTop; i++)
				{
					this.AddToNamespaceHashtable(i);
				}
				this.useNsHashtable = true;
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		private void AddToNamespaceHashtable(int namespaceIndex)
		{
			string prefix = this.nsStack[namespaceIndex].prefix;
			int prevNsIndex;
			if (this.nsHashtable.TryGetValue(prefix, out prevNsIndex))
			{
				this.nsStack[namespaceIndex].prevNsIndex = prevNsIndex;
			}
			this.nsHashtable[prefix] = namespaceIndex;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0003C228 File Offset: 0x0003A428
		private int LookupNamespaceIndex(string prefix)
		{
			if (this.useNsHashtable)
			{
				int result;
				if (this.nsHashtable.TryGetValue(prefix, out result))
				{
					return result;
				}
			}
			else
			{
				for (int i = this.nsTop; i >= 0; i--)
				{
					if (this.nsStack[i].prefix == prefix)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0003C27C File Offset: 0x0003A47C
		private void PopNamespaces(int indexFrom, int indexTo)
		{
			for (int i = indexTo; i >= indexFrom; i--)
			{
				if (this.nsStack[i].prevNsIndex == -1)
				{
					this.nsHashtable.Remove(this.nsStack[i].prefix);
				}
				else
				{
					this.nsHashtable[this.nsStack[i].prefix] = this.nsStack[i].prevNsIndex;
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0003C2F8 File Offset: 0x0003A4F8
		private static XmlException DupAttrException(string prefix, string localName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (prefix.Length > 0)
			{
				stringBuilder.Append(prefix);
				stringBuilder.Append(':');
			}
			stringBuilder.Append(localName);
			return new XmlException("'{0}' is a duplicate attribute name.", stringBuilder.ToString());
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0003C340 File Offset: 0x0003A540
		private void AdvanceState(XmlWellFormedWriter.Token token)
		{
			if (this.currentState < XmlWellFormedWriter.State.Closed)
			{
				XmlWellFormedWriter.State state;
				for (;;)
				{
					state = this.stateTable[(int)(((int)token << 4) + (int)this.currentState)];
					if (state < XmlWellFormedWriter.State.Error)
					{
						break;
					}
					if (state != XmlWellFormedWriter.State.Error)
					{
						switch (state)
						{
						case XmlWellFormedWriter.State.StartContent:
							goto IL_E3;
						case XmlWellFormedWriter.State.StartContentEle:
							goto IL_F0;
						case XmlWellFormedWriter.State.StartContentB64:
							goto IL_FD;
						case XmlWellFormedWriter.State.StartDoc:
							goto IL_10A;
						case XmlWellFormedWriter.State.StartDocEle:
							goto IL_117;
						case XmlWellFormedWriter.State.EndAttrSEle:
							goto IL_124;
						case XmlWellFormedWriter.State.EndAttrEEle:
							goto IL_137;
						case XmlWellFormedWriter.State.EndAttrSCont:
							goto IL_14A;
						case XmlWellFormedWriter.State.EndAttrSAttr:
							goto IL_15D;
						case XmlWellFormedWriter.State.PostB64Cont:
							if (this.rawWriter != null)
							{
								this.rawWriter.WriteEndBase64();
							}
							this.currentState = XmlWellFormedWriter.State.Content;
							continue;
						case XmlWellFormedWriter.State.PostB64Attr:
							if (this.rawWriter != null)
							{
								this.rawWriter.WriteEndBase64();
							}
							this.currentState = XmlWellFormedWriter.State.Attribute;
							continue;
						case XmlWellFormedWriter.State.PostB64RootAttr:
							if (this.rawWriter != null)
							{
								this.rawWriter.WriteEndBase64();
							}
							this.currentState = XmlWellFormedWriter.State.RootLevelAttr;
							continue;
						case XmlWellFormedWriter.State.StartFragEle:
							goto IL_1C8;
						case XmlWellFormedWriter.State.StartFragCont:
							goto IL_1D2;
						case XmlWellFormedWriter.State.StartFragB64:
							goto IL_1DC;
						case XmlWellFormedWriter.State.StartRootLevelAttr:
							goto IL_1E6;
						}
						break;
					}
					goto IL_D1;
				}
				goto IL_1EF;
				IL_D1:
				this.ThrowInvalidStateTransition(token, this.currentState);
				goto IL_1EF;
				IL_E3:
				this.StartElementContent();
				state = XmlWellFormedWriter.State.Content;
				goto IL_1EF;
				IL_F0:
				this.StartElementContent();
				state = XmlWellFormedWriter.State.Element;
				goto IL_1EF;
				IL_FD:
				this.StartElementContent();
				state = XmlWellFormedWriter.State.B64Content;
				goto IL_1EF;
				IL_10A:
				this.WriteStartDocument();
				state = XmlWellFormedWriter.State.Document;
				goto IL_1EF;
				IL_117:
				this.WriteStartDocument();
				state = XmlWellFormedWriter.State.Element;
				goto IL_1EF;
				IL_124:
				this.WriteEndAttribute();
				this.StartElementContent();
				state = XmlWellFormedWriter.State.Element;
				goto IL_1EF;
				IL_137:
				this.WriteEndAttribute();
				this.StartElementContent();
				state = XmlWellFormedWriter.State.Content;
				goto IL_1EF;
				IL_14A:
				this.WriteEndAttribute();
				this.StartElementContent();
				state = XmlWellFormedWriter.State.Content;
				goto IL_1EF;
				IL_15D:
				this.WriteEndAttribute();
				state = XmlWellFormedWriter.State.Attribute;
				goto IL_1EF;
				IL_1C8:
				this.StartFragment();
				state = XmlWellFormedWriter.State.Element;
				goto IL_1EF;
				IL_1D2:
				this.StartFragment();
				state = XmlWellFormedWriter.State.Content;
				goto IL_1EF;
				IL_1DC:
				this.StartFragment();
				state = XmlWellFormedWriter.State.B64Content;
				goto IL_1EF;
				IL_1E6:
				this.WriteEndAttribute();
				state = XmlWellFormedWriter.State.RootLevelAttr;
				IL_1EF:
				this.currentState = state;
				return;
			}
			if (this.currentState == XmlWellFormedWriter.State.Closed || this.currentState == XmlWellFormedWriter.State.Error)
			{
				throw new InvalidOperationException(Res.GetString("The Writer is closed or in error state."));
			}
			throw new InvalidOperationException(Res.GetString("Token {0} in state {1} would result in an invalid XML document.", new object[]
			{
				XmlWellFormedWriter.tokenName[(int)token],
				XmlWellFormedWriter.GetStateName(this.currentState)
			}));
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0003C544 File Offset: 0x0003A744
		private void StartElementContent()
		{
			int prevNSTop = this.elemScopeStack[this.elemTop].prevNSTop;
			for (int i = this.nsTop; i > prevNSTop; i--)
			{
				if (this.nsStack[i].kind == XmlWellFormedWriter.NamespaceKind.NeedToWrite)
				{
					this.nsStack[i].WriteDecl(this.writer, this.rawWriter);
				}
			}
			if (this.rawWriter != null)
			{
				this.rawWriter.StartElementContent();
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003C5BD File Offset: 0x0003A7BD
		private static string GetStateName(XmlWellFormedWriter.State state)
		{
			if (state >= XmlWellFormedWriter.State.Error)
			{
				return "Error";
			}
			return XmlWellFormedWriter.stateName[(int)state];
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0003C5D4 File Offset: 0x0003A7D4
		internal string LookupNamespace(string prefix)
		{
			for (int i = this.nsTop; i >= 0; i--)
			{
				if (this.nsStack[i].prefix == prefix)
				{
					return this.nsStack[i].namespaceUri;
				}
			}
			if (this.predefinedNamespaces == null)
			{
				return null;
			}
			return this.predefinedNamespaces.LookupNamespace(prefix);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0003C634 File Offset: 0x0003A834
		private string LookupLocalNamespace(string prefix)
		{
			for (int i = this.nsTop; i > this.elemScopeStack[this.elemTop].prevNSTop; i--)
			{
				if (this.nsStack[i].prefix == prefix)
				{
					return this.nsStack[i].namespaceUri;
				}
			}
			return null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003C694 File Offset: 0x0003A894
		private string GeneratePrefix()
		{
			string text = "p" + (this.nsTop - 2).ToString("d", CultureInfo.InvariantCulture);
			if (this.LookupNamespace(text) == null)
			{
				return text;
			}
			int num = 0;
			string text2;
			do
			{
				text2 = text + num.ToString(CultureInfo.InvariantCulture);
				num++;
			}
			while (this.LookupNamespace(text2) != null);
			return text2;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0003C6F4 File Offset: 0x0003A8F4
		private void CheckNCName(string ncname)
		{
			int length = ncname.Length;
			if ((this.xmlCharType.charProperties[(int)ncname[0]] & 4) != 0)
			{
				for (int i = 1; i < length; i++)
				{
					if ((this.xmlCharType.charProperties[(int)ncname[i]] & 8) == 0)
					{
						throw XmlWellFormedWriter.InvalidCharsException(ncname, i);
					}
				}
				return;
			}
			throw XmlWellFormedWriter.InvalidCharsException(ncname, 0);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0003C754 File Offset: 0x0003A954
		private static Exception InvalidCharsException(string name, int badCharIndex)
		{
			string[] array = XmlException.BuildCharExceptionArgs(name, badCharIndex);
			string[] array2 = new string[]
			{
				name,
				array[0],
				array[1]
			};
			string name2 = "Invalid name character in '{0}'. The '{1}' character, hexadecimal value {2}, cannot be included in a name.";
			object[] args = array2;
			return new ArgumentException(Res.GetString(name2, args));
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0003C794 File Offset: 0x0003A994
		private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState)
		{
			string @string = Res.GetString("Token {0} in state {1} would result in an invalid XML document.", new object[]
			{
				XmlWellFormedWriter.tokenName[(int)token],
				XmlWellFormedWriter.GetStateName(currentState)
			});
			if ((currentState == XmlWellFormedWriter.State.Start || currentState == XmlWellFormedWriter.State.AfterRootEle) && this.conformanceLevel == ConformanceLevel.Document)
			{
				throw new InvalidOperationException(@string + " " + Res.GetString("Make sure that the ConformanceLevel setting is set to ConformanceLevel.Fragment or ConformanceLevel.Auto if you want to write an XML fragment."));
			}
			throw new InvalidOperationException(@string);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0003C7F6 File Offset: 0x0003A9F6
		private bool IsClosedOrErrorState
		{
			get
			{
				return this.currentState >= XmlWellFormedWriter.State.Closed;
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0003C808 File Offset: 0x0003AA08
		private void AddAttribute(string prefix, string localName, string namespaceName)
		{
			int num = this.attrCount;
			this.attrCount = num + 1;
			int num2 = num;
			if (num2 == this.attrStack.Length)
			{
				XmlWellFormedWriter.AttrName[] destinationArray = new XmlWellFormedWriter.AttrName[num2 * 2];
				Array.Copy(this.attrStack, destinationArray, num2);
				this.attrStack = destinationArray;
			}
			this.attrStack[num2].Set(prefix, localName, namespaceName);
			if (this.attrCount < 14)
			{
				for (int i = 0; i < num2; i++)
				{
					if (this.attrStack[i].IsDuplicate(prefix, localName, namespaceName))
					{
						throw XmlWellFormedWriter.DupAttrException(prefix, localName);
					}
				}
				return;
			}
			if (this.attrCount == 14)
			{
				if (this.attrHashTable == null)
				{
					this.attrHashTable = new Dictionary<string, int>(this.hasher);
				}
				for (int j = 0; j < num2; j++)
				{
					this.AddToAttrHashTable(j);
				}
			}
			this.AddToAttrHashTable(num2);
			for (int k = this.attrStack[num2].prev; k > 0; k = this.attrStack[k].prev)
			{
				k--;
				if (this.attrStack[k].IsDuplicate(prefix, localName, namespaceName))
				{
					throw XmlWellFormedWriter.DupAttrException(prefix, localName);
				}
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0003C930 File Offset: 0x0003AB30
		private void AddToAttrHashTable(int attributeIndex)
		{
			string localName = this.attrStack[attributeIndex].localName;
			int count = this.attrHashTable.Count;
			this.attrHashTable[localName] = 0;
			if (count != this.attrHashTable.Count)
			{
				return;
			}
			int num = attributeIndex - 1;
			while (num >= 0 && !(this.attrStack[num].localName == localName))
			{
				num--;
			}
			this.attrStack[attributeIndex].prev = num + 1;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		public override Task WriteStartDocumentAsync()
		{
			return this.WriteStartDocumentImplAsync(XmlStandalone.Omit);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0003C9B9 File Offset: 0x0003ABB9
		public override Task WriteStartDocumentAsync(bool standalone)
		{
			return this.WriteStartDocumentImplAsync(standalone ? XmlStandalone.Yes : XmlStandalone.No);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0003C9C8 File Offset: 0x0003ABC8
		public override Task WriteEndDocumentAsync()
		{
			XmlWellFormedWriter.<WriteEndDocumentAsync>d__115 <WriteEndDocumentAsync>d__;
			<WriteEndDocumentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEndDocumentAsync>d__.<>4__this = this;
			<WriteEndDocumentAsync>d__.<>1__state = -1;
			<WriteEndDocumentAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteEndDocumentAsync>d__115>(ref <WriteEndDocumentAsync>d__);
			return <WriteEndDocumentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			XmlWellFormedWriter.<WriteDocTypeAsync>d__116 <WriteDocTypeAsync>d__;
			<WriteDocTypeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteDocTypeAsync>d__.<>4__this = this;
			<WriteDocTypeAsync>d__.name = name;
			<WriteDocTypeAsync>d__.pubid = pubid;
			<WriteDocTypeAsync>d__.sysid = sysid;
			<WriteDocTypeAsync>d__.subset = subset;
			<WriteDocTypeAsync>d__.<>1__state = -1;
			<WriteDocTypeAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteDocTypeAsync>d__116>(ref <WriteDocTypeAsync>d__);
			return <WriteDocTypeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0003CA70 File Offset: 0x0003AC70
		private Task TryReturnTask(Task task)
		{
			if (task.IsSuccess())
			{
				return AsyncHelper.DoneTask;
			}
			return this._TryReturnTask(task);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0003CA88 File Offset: 0x0003AC88
		private Task _TryReturnTask(Task task)
		{
			XmlWellFormedWriter.<_TryReturnTask>d__118 <_TryReturnTask>d__;
			<_TryReturnTask>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_TryReturnTask>d__.<>4__this = this;
			<_TryReturnTask>d__.task = task;
			<_TryReturnTask>d__.<>1__state = -1;
			<_TryReturnTask>d__.<>t__builder.Start<XmlWellFormedWriter.<_TryReturnTask>d__118>(ref <_TryReturnTask>d__);
			return <_TryReturnTask>d__.<>t__builder.Task;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0003CAD3 File Offset: 0x0003ACD3
		private Task SequenceRun(Task task, Func<Task> nextTaskFun)
		{
			if (task.IsSuccess())
			{
				return this.TryReturnTask(nextTaskFun());
			}
			return this._SequenceRun(task, nextTaskFun);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0003CAF4 File Offset: 0x0003ACF4
		private Task _SequenceRun(Task task, Func<Task> nextTaskFun)
		{
			XmlWellFormedWriter.<_SequenceRun>d__120 <_SequenceRun>d__;
			<_SequenceRun>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_SequenceRun>d__.<>4__this = this;
			<_SequenceRun>d__.task = task;
			<_SequenceRun>d__.nextTaskFun = nextTaskFun;
			<_SequenceRun>d__.<>1__state = -1;
			<_SequenceRun>d__.<>t__builder.Start<XmlWellFormedWriter.<_SequenceRun>d__120>(ref <_SequenceRun>d__);
			return <_SequenceRun>d__.<>t__builder.Task;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0003CB48 File Offset: 0x0003AD48
		public override Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			Task result;
			try
			{
				if (localName == null || localName.Length == 0)
				{
					throw new ArgumentException(Res.GetString("The empty string '' is not a valid local name."));
				}
				this.CheckNCName(localName);
				Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.StartElement);
				if (task.IsSuccess())
				{
					result = this.WriteStartElementAsync_NoAdvanceState(prefix, localName, ns);
				}
				else
				{
					result = this.WriteStartElementAsync_NoAdvanceState(task, prefix, localName, ns);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0003CBBC File Offset: 0x0003ADBC
		private Task WriteStartElementAsync_NoAdvanceState(string prefix, string localName, string ns)
		{
			Task result;
			try
			{
				if (prefix == null)
				{
					if (ns != null)
					{
						prefix = this.LookupPrefix(ns);
					}
					if (prefix == null)
					{
						prefix = string.Empty;
					}
				}
				else if (prefix.Length > 0)
				{
					this.CheckNCName(prefix);
					if (ns == null)
					{
						ns = this.LookupNamespace(prefix);
					}
					if (ns == null || (ns != null && ns.Length == 0))
					{
						throw new ArgumentException(Res.GetString("Cannot use a prefix with an empty namespace."));
					}
				}
				if (ns == null)
				{
					ns = this.LookupNamespace(prefix);
					if (ns == null)
					{
						ns = string.Empty;
					}
				}
				if (this.elemTop == 0 && this.rawWriter != null)
				{
					this.rawWriter.OnRootElement(this.conformanceLevel);
				}
				Task task = this.writer.WriteStartElementAsync(prefix, localName, ns);
				if (task.IsSuccess())
				{
					this.WriteStartElementAsync_FinishWrite(prefix, localName, ns);
					result = AsyncHelper.DoneTask;
				}
				else
				{
					result = this.WriteStartElementAsync_FinishWrite(task, prefix, localName, ns);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		private Task WriteStartElementAsync_NoAdvanceState(Task task, string prefix, string localName, string ns)
		{
			XmlWellFormedWriter.<WriteStartElementAsync_NoAdvanceState>d__123 <WriteStartElementAsync_NoAdvanceState>d__;
			<WriteStartElementAsync_NoAdvanceState>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartElementAsync_NoAdvanceState>d__.<>4__this = this;
			<WriteStartElementAsync_NoAdvanceState>d__.task = task;
			<WriteStartElementAsync_NoAdvanceState>d__.prefix = prefix;
			<WriteStartElementAsync_NoAdvanceState>d__.localName = localName;
			<WriteStartElementAsync_NoAdvanceState>d__.ns = ns;
			<WriteStartElementAsync_NoAdvanceState>d__.<>1__state = -1;
			<WriteStartElementAsync_NoAdvanceState>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteStartElementAsync_NoAdvanceState>d__123>(ref <WriteStartElementAsync_NoAdvanceState>d__);
			return <WriteStartElementAsync_NoAdvanceState>d__.<>t__builder.Task;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		private void WriteStartElementAsync_FinishWrite(string prefix, string localName, string ns)
		{
			try
			{
				int num = this.elemTop + 1;
				this.elemTop = num;
				int num2 = num;
				if (num2 == this.elemScopeStack.Length)
				{
					XmlWellFormedWriter.ElementScope[] destinationArray = new XmlWellFormedWriter.ElementScope[num2 * 2];
					Array.Copy(this.elemScopeStack, destinationArray, num2);
					this.elemScopeStack = destinationArray;
				}
				this.elemScopeStack[num2].Set(prefix, localName, ns, this.nsTop);
				this.PushNamespaceImplicit(prefix, ns);
				if (this.attrCount >= 14)
				{
					this.attrHashTable.Clear();
				}
				this.attrCount = 0;
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		private Task WriteStartElementAsync_FinishWrite(Task t, string prefix, string localName, string ns)
		{
			XmlWellFormedWriter.<WriteStartElementAsync_FinishWrite>d__125 <WriteStartElementAsync_FinishWrite>d__;
			<WriteStartElementAsync_FinishWrite>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartElementAsync_FinishWrite>d__.<>4__this = this;
			<WriteStartElementAsync_FinishWrite>d__.t = t;
			<WriteStartElementAsync_FinishWrite>d__.prefix = prefix;
			<WriteStartElementAsync_FinishWrite>d__.localName = localName;
			<WriteStartElementAsync_FinishWrite>d__.ns = ns;
			<WriteStartElementAsync_FinishWrite>d__.<>1__state = -1;
			<WriteStartElementAsync_FinishWrite>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteStartElementAsync_FinishWrite>d__125>(ref <WriteStartElementAsync_FinishWrite>d__);
			return <WriteStartElementAsync_FinishWrite>d__.<>t__builder.Task;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0003CE14 File Offset: 0x0003B014
		public override Task WriteEndElementAsync()
		{
			Task result;
			try
			{
				Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.EndElement);
				result = this.SequenceRun(task, new Func<Task>(this.WriteEndElementAsync_NoAdvanceState));
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0003CE5C File Offset: 0x0003B05C
		private Task WriteEndElementAsync_NoAdvanceState()
		{
			Task result;
			try
			{
				int num = this.elemTop;
				if (num == 0)
				{
					throw new XmlException("There was no XML start tag open.", string.Empty);
				}
				Task task;
				if (this.rawWriter != null)
				{
					task = this.elemScopeStack[num].WriteEndElementAsync(this.rawWriter);
				}
				else
				{
					task = this.writer.WriteEndElementAsync();
				}
				result = this.SequenceRun(task, new Func<Task>(this.WriteEndElementAsync_FinishWrite));
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0003CEE4 File Offset: 0x0003B0E4
		private Task WriteEndElementAsync_FinishWrite()
		{
			try
			{
				int num = this.elemTop;
				int prevNSTop = this.elemScopeStack[num].prevNSTop;
				if (this.useNsHashtable && prevNSTop < this.nsTop)
				{
					this.PopNamespaces(prevNSTop + 1, this.nsTop);
				}
				this.nsTop = prevNSTop;
				if ((this.elemTop = num - 1) == 0)
				{
					if (this.conformanceLevel == ConformanceLevel.Document)
					{
						this.currentState = XmlWellFormedWriter.State.AfterRootEle;
					}
					else
					{
						this.currentState = XmlWellFormedWriter.State.TopLevel;
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0003CF7C File Offset: 0x0003B17C
		public override Task WriteFullEndElementAsync()
		{
			Task result;
			try
			{
				Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.EndElement);
				result = this.SequenceRun(task, new Func<Task>(this.WriteFullEndElementAsync_NoAdvanceState));
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		private Task WriteFullEndElementAsync_NoAdvanceState()
		{
			Task result;
			try
			{
				int num = this.elemTop;
				if (num == 0)
				{
					throw new XmlException("There was no XML start tag open.", string.Empty);
				}
				Task task;
				if (this.rawWriter != null)
				{
					task = this.elemScopeStack[num].WriteFullEndElementAsync(this.rawWriter);
				}
				else
				{
					task = this.writer.WriteFullEndElementAsync();
				}
				result = this.SequenceRun(task, new Func<Task>(this.WriteEndElementAsync_FinishWrite));
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0003D04C File Offset: 0x0003B24C
		protected internal override Task WriteStartAttributeAsync(string prefix, string localName, string namespaceName)
		{
			Task result;
			try
			{
				if (localName == null || localName.Length == 0)
				{
					if (!(prefix == "xmlns"))
					{
						throw new ArgumentException(Res.GetString("The empty string '' is not a valid local name."));
					}
					localName = "xmlns";
					prefix = string.Empty;
				}
				this.CheckNCName(localName);
				Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.StartAttribute);
				if (task.IsSuccess())
				{
					result = this.WriteStartAttributeAsync_NoAdvanceState(prefix, localName, namespaceName);
				}
				else
				{
					result = this.WriteStartAttributeAsync_NoAdvanceState(task, prefix, localName, namespaceName);
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		private Task WriteStartAttributeAsync_NoAdvanceState(string prefix, string localName, string namespaceName)
		{
			Task result;
			try
			{
				if (prefix == null)
				{
					if (namespaceName != null && (!(localName == "xmlns") || !(namespaceName == "http://www.w3.org/2000/xmlns/")))
					{
						prefix = this.LookupPrefix(namespaceName);
					}
					if (prefix == null)
					{
						prefix = string.Empty;
					}
				}
				if (namespaceName == null)
				{
					if (prefix != null && prefix.Length > 0)
					{
						namespaceName = this.LookupNamespace(prefix);
					}
					if (namespaceName == null)
					{
						namespaceName = string.Empty;
					}
				}
				if (prefix.Length == 0)
				{
					if (localName[0] == 'x' && localName == "xmlns")
					{
						if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/2000/xmlns/")
						{
							throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
						}
						this.curDeclPrefix = string.Empty;
						this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.DefaultXmlns);
						goto IL_1DE;
					}
					else if (namespaceName.Length > 0)
					{
						prefix = this.LookupPrefix(namespaceName);
						if (prefix == null || prefix.Length == 0)
						{
							prefix = this.GeneratePrefix();
						}
					}
				}
				else
				{
					if (prefix[0] == 'x')
					{
						if (prefix == "xmlns")
						{
							if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/2000/xmlns/")
							{
								throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
							}
							this.curDeclPrefix = localName;
							this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.PrefixedXmlns);
							goto IL_1DE;
						}
						else if (prefix == "xml")
						{
							if (namespaceName.Length > 0 && namespaceName != "http://www.w3.org/XML/1998/namespace")
							{
								throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
							}
							if (localName == "space")
							{
								this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.XmlSpace);
								goto IL_1DE;
							}
							if (localName == "lang")
							{
								this.SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute.XmlLang);
								goto IL_1DE;
							}
						}
					}
					this.CheckNCName(prefix);
					if (namespaceName.Length == 0)
					{
						prefix = string.Empty;
					}
					else
					{
						string text = this.LookupLocalNamespace(prefix);
						if (text != null && text != namespaceName)
						{
							prefix = this.GeneratePrefix();
						}
					}
				}
				if (prefix.Length != 0)
				{
					this.PushNamespaceImplicit(prefix, namespaceName);
				}
				IL_1DE:
				this.AddAttribute(prefix, localName, namespaceName);
				if (this.specAttr == XmlWellFormedWriter.SpecialAttribute.No)
				{
					result = this.TryReturnTask(this.writer.WriteStartAttributeAsync(prefix, localName, namespaceName));
				}
				else
				{
					result = AsyncHelper.DoneTask;
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0003D324 File Offset: 0x0003B524
		private Task WriteStartAttributeAsync_NoAdvanceState(Task task, string prefix, string localName, string namespaceName)
		{
			XmlWellFormedWriter.<WriteStartAttributeAsync_NoAdvanceState>d__133 <WriteStartAttributeAsync_NoAdvanceState>d__;
			<WriteStartAttributeAsync_NoAdvanceState>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartAttributeAsync_NoAdvanceState>d__.<>4__this = this;
			<WriteStartAttributeAsync_NoAdvanceState>d__.task = task;
			<WriteStartAttributeAsync_NoAdvanceState>d__.prefix = prefix;
			<WriteStartAttributeAsync_NoAdvanceState>d__.localName = localName;
			<WriteStartAttributeAsync_NoAdvanceState>d__.namespaceName = namespaceName;
			<WriteStartAttributeAsync_NoAdvanceState>d__.<>1__state = -1;
			<WriteStartAttributeAsync_NoAdvanceState>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteStartAttributeAsync_NoAdvanceState>d__133>(ref <WriteStartAttributeAsync_NoAdvanceState>d__);
			return <WriteStartAttributeAsync_NoAdvanceState>d__.<>t__builder.Task;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0003D388 File Offset: 0x0003B588
		protected internal override Task WriteEndAttributeAsync()
		{
			Task result;
			try
			{
				Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.EndAttribute);
				result = this.SequenceRun(task, new Func<Task>(this.WriteEndAttributeAsync_NoAdvance));
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		private Task WriteEndAttributeAsync_NoAdvance()
		{
			Task result;
			try
			{
				if (this.specAttr != XmlWellFormedWriter.SpecialAttribute.No)
				{
					result = this.WriteEndAttributeAsync_SepcialAtt();
				}
				else
				{
					result = this.TryReturnTask(this.writer.WriteEndAttributeAsync());
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0003D420 File Offset: 0x0003B620
		private Task WriteEndAttributeAsync_SepcialAtt()
		{
			XmlWellFormedWriter.<WriteEndAttributeAsync_SepcialAtt>d__136 <WriteEndAttributeAsync_SepcialAtt>d__;
			<WriteEndAttributeAsync_SepcialAtt>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEndAttributeAsync_SepcialAtt>d__.<>4__this = this;
			<WriteEndAttributeAsync_SepcialAtt>d__.<>1__state = -1;
			<WriteEndAttributeAsync_SepcialAtt>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteEndAttributeAsync_SepcialAtt>d__136>(ref <WriteEndAttributeAsync_SepcialAtt>d__);
			return <WriteEndAttributeAsync_SepcialAtt>d__.<>t__builder.Task;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0003D464 File Offset: 0x0003B664
		public override Task WriteCDataAsync(string text)
		{
			XmlWellFormedWriter.<WriteCDataAsync>d__137 <WriteCDataAsync>d__;
			<WriteCDataAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCDataAsync>d__.<>4__this = this;
			<WriteCDataAsync>d__.text = text;
			<WriteCDataAsync>d__.<>1__state = -1;
			<WriteCDataAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteCDataAsync>d__137>(ref <WriteCDataAsync>d__);
			return <WriteCDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		public override Task WriteCommentAsync(string text)
		{
			XmlWellFormedWriter.<WriteCommentAsync>d__138 <WriteCommentAsync>d__;
			<WriteCommentAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCommentAsync>d__.<>4__this = this;
			<WriteCommentAsync>d__.text = text;
			<WriteCommentAsync>d__.<>1__state = -1;
			<WriteCommentAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteCommentAsync>d__138>(ref <WriteCommentAsync>d__);
			return <WriteCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		public override Task WriteProcessingInstructionAsync(string name, string text)
		{
			XmlWellFormedWriter.<WriteProcessingInstructionAsync>d__139 <WriteProcessingInstructionAsync>d__;
			<WriteProcessingInstructionAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteProcessingInstructionAsync>d__.<>4__this = this;
			<WriteProcessingInstructionAsync>d__.name = name;
			<WriteProcessingInstructionAsync>d__.text = text;
			<WriteProcessingInstructionAsync>d__.<>1__state = -1;
			<WriteProcessingInstructionAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteProcessingInstructionAsync>d__139>(ref <WriteProcessingInstructionAsync>d__);
			return <WriteProcessingInstructionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0003D550 File Offset: 0x0003B750
		public override Task WriteEntityRefAsync(string name)
		{
			XmlWellFormedWriter.<WriteEntityRefAsync>d__140 <WriteEntityRefAsync>d__;
			<WriteEntityRefAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEntityRefAsync>d__.<>4__this = this;
			<WriteEntityRefAsync>d__.name = name;
			<WriteEntityRefAsync>d__.<>1__state = -1;
			<WriteEntityRefAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteEntityRefAsync>d__140>(ref <WriteEntityRefAsync>d__);
			return <WriteEntityRefAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0003D59C File Offset: 0x0003B79C
		public override Task WriteCharEntityAsync(char ch)
		{
			XmlWellFormedWriter.<WriteCharEntityAsync>d__141 <WriteCharEntityAsync>d__;
			<WriteCharEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCharEntityAsync>d__.<>4__this = this;
			<WriteCharEntityAsync>d__.ch = ch;
			<WriteCharEntityAsync>d__.<>1__state = -1;
			<WriteCharEntityAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteCharEntityAsync>d__141>(ref <WriteCharEntityAsync>d__);
			return <WriteCharEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0003D5E8 File Offset: 0x0003B7E8
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			XmlWellFormedWriter.<WriteSurrogateCharEntityAsync>d__142 <WriteSurrogateCharEntityAsync>d__;
			<WriteSurrogateCharEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteSurrogateCharEntityAsync>d__.<>4__this = this;
			<WriteSurrogateCharEntityAsync>d__.lowChar = lowChar;
			<WriteSurrogateCharEntityAsync>d__.highChar = highChar;
			<WriteSurrogateCharEntityAsync>d__.<>1__state = -1;
			<WriteSurrogateCharEntityAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteSurrogateCharEntityAsync>d__142>(ref <WriteSurrogateCharEntityAsync>d__);
			return <WriteSurrogateCharEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0003D63C File Offset: 0x0003B83C
		public override Task WriteWhitespaceAsync(string ws)
		{
			XmlWellFormedWriter.<WriteWhitespaceAsync>d__143 <WriteWhitespaceAsync>d__;
			<WriteWhitespaceAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteWhitespaceAsync>d__.<>4__this = this;
			<WriteWhitespaceAsync>d__.ws = ws;
			<WriteWhitespaceAsync>d__.<>1__state = -1;
			<WriteWhitespaceAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteWhitespaceAsync>d__143>(ref <WriteWhitespaceAsync>d__);
			return <WriteWhitespaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0003D688 File Offset: 0x0003B888
		public override Task WriteStringAsync(string text)
		{
			Task result;
			try
			{
				if (text == null)
				{
					result = AsyncHelper.DoneTask;
				}
				else
				{
					Task task = this.AdvanceStateAsync(XmlWellFormedWriter.Token.Text);
					if (task.IsSuccess())
					{
						result = this.WriteStringAsync_NoAdvanceState(text);
					}
					else
					{
						result = this.WriteStringAsync_NoAdvanceState(task, text);
					}
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		private Task WriteStringAsync_NoAdvanceState(string text)
		{
			Task result;
			try
			{
				if (this.SaveAttrValue)
				{
					this.attrValueCache.WriteString(text);
					result = AsyncHelper.DoneTask;
				}
				else
				{
					result = this.TryReturnTask(this.writer.WriteStringAsync(text));
				}
			}
			catch
			{
				this.currentState = XmlWellFormedWriter.State.Error;
				throw;
			}
			return result;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0003D740 File Offset: 0x0003B940
		private Task WriteStringAsync_NoAdvanceState(Task task, string text)
		{
			XmlWellFormedWriter.<WriteStringAsync_NoAdvanceState>d__146 <WriteStringAsync_NoAdvanceState>d__;
			<WriteStringAsync_NoAdvanceState>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStringAsync_NoAdvanceState>d__.<>4__this = this;
			<WriteStringAsync_NoAdvanceState>d__.task = task;
			<WriteStringAsync_NoAdvanceState>d__.text = text;
			<WriteStringAsync_NoAdvanceState>d__.<>1__state = -1;
			<WriteStringAsync_NoAdvanceState>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteStringAsync_NoAdvanceState>d__146>(ref <WriteStringAsync_NoAdvanceState>d__);
			return <WriteStringAsync_NoAdvanceState>d__.<>t__builder.Task;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0003D794 File Offset: 0x0003B994
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			XmlWellFormedWriter.<WriteCharsAsync>d__147 <WriteCharsAsync>d__;
			<WriteCharsAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteCharsAsync>d__.<>4__this = this;
			<WriteCharsAsync>d__.buffer = buffer;
			<WriteCharsAsync>d__.index = index;
			<WriteCharsAsync>d__.count = count;
			<WriteCharsAsync>d__.<>1__state = -1;
			<WriteCharsAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteCharsAsync>d__147>(ref <WriteCharsAsync>d__);
			return <WriteCharsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0003D7F0 File Offset: 0x0003B9F0
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			XmlWellFormedWriter.<WriteRawAsync>d__148 <WriteRawAsync>d__;
			<WriteRawAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawAsync>d__.<>4__this = this;
			<WriteRawAsync>d__.buffer = buffer;
			<WriteRawAsync>d__.index = index;
			<WriteRawAsync>d__.count = count;
			<WriteRawAsync>d__.<>1__state = -1;
			<WriteRawAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteRawAsync>d__148>(ref <WriteRawAsync>d__);
			return <WriteRawAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0003D84C File Offset: 0x0003BA4C
		public override Task WriteRawAsync(string data)
		{
			XmlWellFormedWriter.<WriteRawAsync>d__149 <WriteRawAsync>d__;
			<WriteRawAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteRawAsync>d__.<>4__this = this;
			<WriteRawAsync>d__.data = data;
			<WriteRawAsync>d__.<>1__state = -1;
			<WriteRawAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteRawAsync>d__149>(ref <WriteRawAsync>d__);
			return <WriteRawAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0003D898 File Offset: 0x0003BA98
		private Task WriteStartDocumentImplAsync(XmlStandalone standalone)
		{
			XmlWellFormedWriter.<WriteStartDocumentImplAsync>d__155 <WriteStartDocumentImplAsync>d__;
			<WriteStartDocumentImplAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartDocumentImplAsync>d__.<>4__this = this;
			<WriteStartDocumentImplAsync>d__.standalone = standalone;
			<WriteStartDocumentImplAsync>d__.<>1__state = -1;
			<WriteStartDocumentImplAsync>d__.<>t__builder.Start<XmlWellFormedWriter.<WriteStartDocumentImplAsync>d__155>(ref <WriteStartDocumentImplAsync>d__);
			return <WriteStartDocumentImplAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0003D8E3 File Offset: 0x0003BAE3
		private Task AdvanceStateAsync_ReturnWhenFinish(Task task, XmlWellFormedWriter.State newState)
		{
			if (task.IsSuccess())
			{
				this.currentState = newState;
				return AsyncHelper.DoneTask;
			}
			return this._AdvanceStateAsync_ReturnWhenFinish(task, newState);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0003D904 File Offset: 0x0003BB04
		private Task _AdvanceStateAsync_ReturnWhenFinish(Task task, XmlWellFormedWriter.State newState)
		{
			XmlWellFormedWriter.<_AdvanceStateAsync_ReturnWhenFinish>d__157 <_AdvanceStateAsync_ReturnWhenFinish>d__;
			<_AdvanceStateAsync_ReturnWhenFinish>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_AdvanceStateAsync_ReturnWhenFinish>d__.<>4__this = this;
			<_AdvanceStateAsync_ReturnWhenFinish>d__.task = task;
			<_AdvanceStateAsync_ReturnWhenFinish>d__.newState = newState;
			<_AdvanceStateAsync_ReturnWhenFinish>d__.<>1__state = -1;
			<_AdvanceStateAsync_ReturnWhenFinish>d__.<>t__builder.Start<XmlWellFormedWriter.<_AdvanceStateAsync_ReturnWhenFinish>d__157>(ref <_AdvanceStateAsync_ReturnWhenFinish>d__);
			return <_AdvanceStateAsync_ReturnWhenFinish>d__.<>t__builder.Task;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0003D957 File Offset: 0x0003BB57
		private Task AdvanceStateAsync_ContinueWhenFinish(Task task, XmlWellFormedWriter.State newState, XmlWellFormedWriter.Token token)
		{
			if (task.IsSuccess())
			{
				this.currentState = newState;
				return this.AdvanceStateAsync(token);
			}
			return this._AdvanceStateAsync_ContinueWhenFinish(task, newState, token);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0003D97C File Offset: 0x0003BB7C
		private Task _AdvanceStateAsync_ContinueWhenFinish(Task task, XmlWellFormedWriter.State newState, XmlWellFormedWriter.Token token)
		{
			XmlWellFormedWriter.<_AdvanceStateAsync_ContinueWhenFinish>d__159 <_AdvanceStateAsync_ContinueWhenFinish>d__;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<_AdvanceStateAsync_ContinueWhenFinish>d__.<>4__this = this;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.task = task;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.newState = newState;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.token = token;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.<>1__state = -1;
			<_AdvanceStateAsync_ContinueWhenFinish>d__.<>t__builder.Start<XmlWellFormedWriter.<_AdvanceStateAsync_ContinueWhenFinish>d__159>(ref <_AdvanceStateAsync_ContinueWhenFinish>d__);
			return <_AdvanceStateAsync_ContinueWhenFinish>d__.<>t__builder.Task;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
		private Task AdvanceStateAsync(XmlWellFormedWriter.Token token)
		{
			if (this.currentState < XmlWellFormedWriter.State.Closed)
			{
				XmlWellFormedWriter.State state;
				for (;;)
				{
					state = this.stateTable[(int)(((int)token << 4) + (int)this.currentState)];
					if (state < XmlWellFormedWriter.State.Error)
					{
						break;
					}
					if (state != XmlWellFormedWriter.State.Error)
					{
						switch (state)
						{
						case XmlWellFormedWriter.State.StartContent:
							goto IL_E3;
						case XmlWellFormedWriter.State.StartContentEle:
							goto IL_F1;
						case XmlWellFormedWriter.State.StartContentB64:
							goto IL_FF;
						case XmlWellFormedWriter.State.StartDoc:
							goto IL_10D;
						case XmlWellFormedWriter.State.StartDocEle:
							goto IL_11B;
						case XmlWellFormedWriter.State.EndAttrSEle:
							goto IL_129;
						case XmlWellFormedWriter.State.EndAttrEEle:
							goto IL_14B;
						case XmlWellFormedWriter.State.EndAttrSCont:
							goto IL_16D;
						case XmlWellFormedWriter.State.EndAttrSAttr:
							goto IL_18F;
						case XmlWellFormedWriter.State.PostB64Cont:
							if (this.rawWriter != null)
							{
								goto Block_6;
							}
							this.currentState = XmlWellFormedWriter.State.Content;
							continue;
						case XmlWellFormedWriter.State.PostB64Attr:
							if (this.rawWriter != null)
							{
								goto Block_7;
							}
							this.currentState = XmlWellFormedWriter.State.Attribute;
							continue;
						case XmlWellFormedWriter.State.PostB64RootAttr:
							if (this.rawWriter != null)
							{
								goto Block_8;
							}
							this.currentState = XmlWellFormedWriter.State.RootLevelAttr;
							continue;
						case XmlWellFormedWriter.State.StartFragEle:
							goto IL_217;
						case XmlWellFormedWriter.State.StartFragCont:
							goto IL_221;
						case XmlWellFormedWriter.State.StartFragB64:
							goto IL_22B;
						case XmlWellFormedWriter.State.StartRootLevelAttr:
							goto IL_235;
						}
						break;
					}
					goto IL_D1;
				}
				goto IL_244;
				IL_D1:
				this.ThrowInvalidStateTransition(token, this.currentState);
				goto IL_244;
				IL_E3:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.StartElementContentAsync(), XmlWellFormedWriter.State.Content);
				IL_F1:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.StartElementContentAsync(), XmlWellFormedWriter.State.Element);
				IL_FF:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.StartElementContentAsync(), XmlWellFormedWriter.State.B64Content);
				IL_10D:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.WriteStartDocumentAsync(), XmlWellFormedWriter.State.Document);
				IL_11B:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.WriteStartDocumentAsync(), XmlWellFormedWriter.State.Element);
				IL_129:
				Task task = this.SequenceRun(this.WriteEndAttributeAsync(), new Func<Task>(this.StartElementContentAsync));
				return this.AdvanceStateAsync_ReturnWhenFinish(task, XmlWellFormedWriter.State.Element);
				IL_14B:
				task = this.SequenceRun(this.WriteEndAttributeAsync(), new Func<Task>(this.StartElementContentAsync));
				return this.AdvanceStateAsync_ReturnWhenFinish(task, XmlWellFormedWriter.State.Content);
				IL_16D:
				task = this.SequenceRun(this.WriteEndAttributeAsync(), new Func<Task>(this.StartElementContentAsync));
				return this.AdvanceStateAsync_ReturnWhenFinish(task, XmlWellFormedWriter.State.Content);
				IL_18F:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.WriteEndAttributeAsync(), XmlWellFormedWriter.State.Attribute);
				Block_6:
				return this.AdvanceStateAsync_ContinueWhenFinish(this.rawWriter.WriteEndBase64Async(), XmlWellFormedWriter.State.Content, token);
				Block_7:
				return this.AdvanceStateAsync_ContinueWhenFinish(this.rawWriter.WriteEndBase64Async(), XmlWellFormedWriter.State.Attribute, token);
				Block_8:
				return this.AdvanceStateAsync_ContinueWhenFinish(this.rawWriter.WriteEndBase64Async(), XmlWellFormedWriter.State.RootLevelAttr, token);
				IL_217:
				this.StartFragment();
				state = XmlWellFormedWriter.State.Element;
				goto IL_244;
				IL_221:
				this.StartFragment();
				state = XmlWellFormedWriter.State.Content;
				goto IL_244;
				IL_22B:
				this.StartFragment();
				state = XmlWellFormedWriter.State.B64Content;
				goto IL_244;
				IL_235:
				return this.AdvanceStateAsync_ReturnWhenFinish(this.WriteEndAttributeAsync(), XmlWellFormedWriter.State.RootLevelAttr);
				IL_244:
				this.currentState = state;
				return AsyncHelper.DoneTask;
			}
			if (this.currentState == XmlWellFormedWriter.State.Closed || this.currentState == XmlWellFormedWriter.State.Error)
			{
				throw new InvalidOperationException(Res.GetString("The Writer is closed or in error state."));
			}
			throw new InvalidOperationException(Res.GetString("Token {0} in state {1} would result in an invalid XML document.", new object[]
			{
				XmlWellFormedWriter.tokenName[(int)token],
				XmlWellFormedWriter.GetStateName(this.currentState)
			}));
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0003DC38 File Offset: 0x0003BE38
		private Task StartElementContentAsync_WithNS()
		{
			XmlWellFormedWriter.<StartElementContentAsync_WithNS>d__161 <StartElementContentAsync_WithNS>d__;
			<StartElementContentAsync_WithNS>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartElementContentAsync_WithNS>d__.<>4__this = this;
			<StartElementContentAsync_WithNS>d__.<>1__state = -1;
			<StartElementContentAsync_WithNS>d__.<>t__builder.Start<XmlWellFormedWriter.<StartElementContentAsync_WithNS>d__161>(ref <StartElementContentAsync_WithNS>d__);
			return <StartElementContentAsync_WithNS>d__.<>t__builder.Task;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0003DC7B File Offset: 0x0003BE7B
		private Task StartElementContentAsync()
		{
			if (this.nsTop > this.elemScopeStack[this.elemTop].prevNSTop)
			{
				return this.StartElementContentAsync_WithNS();
			}
			if (this.rawWriter != null)
			{
				this.rawWriter.StartElementContent();
			}
			return AsyncHelper.DoneTask;
		}

		// Token: 0x040006A9 RID: 1705
		private XmlWriter writer;

		// Token: 0x040006AA RID: 1706
		private XmlRawWriter rawWriter;

		// Token: 0x040006AB RID: 1707
		private IXmlNamespaceResolver predefinedNamespaces;

		// Token: 0x040006AC RID: 1708
		private XmlWellFormedWriter.Namespace[] nsStack;

		// Token: 0x040006AD RID: 1709
		private int nsTop;

		// Token: 0x040006AE RID: 1710
		private Dictionary<string, int> nsHashtable;

		// Token: 0x040006AF RID: 1711
		private bool useNsHashtable;

		// Token: 0x040006B0 RID: 1712
		private XmlWellFormedWriter.ElementScope[] elemScopeStack;

		// Token: 0x040006B1 RID: 1713
		private int elemTop;

		// Token: 0x040006B2 RID: 1714
		private XmlWellFormedWriter.AttrName[] attrStack;

		// Token: 0x040006B3 RID: 1715
		private int attrCount;

		// Token: 0x040006B4 RID: 1716
		private Dictionary<string, int> attrHashTable;

		// Token: 0x040006B5 RID: 1717
		private XmlWellFormedWriter.SpecialAttribute specAttr;

		// Token: 0x040006B6 RID: 1718
		private XmlWellFormedWriter.AttributeValueCache attrValueCache;

		// Token: 0x040006B7 RID: 1719
		private string curDeclPrefix;

		// Token: 0x040006B8 RID: 1720
		private XmlWellFormedWriter.State[] stateTable;

		// Token: 0x040006B9 RID: 1721
		private XmlWellFormedWriter.State currentState;

		// Token: 0x040006BA RID: 1722
		private bool checkCharacters;

		// Token: 0x040006BB RID: 1723
		private bool omitDuplNamespaces;

		// Token: 0x040006BC RID: 1724
		private bool writeEndDocumentOnClose;

		// Token: 0x040006BD RID: 1725
		private ConformanceLevel conformanceLevel;

		// Token: 0x040006BE RID: 1726
		private bool dtdWritten;

		// Token: 0x040006BF RID: 1727
		private bool xmlDeclFollows;

		// Token: 0x040006C0 RID: 1728
		private XmlCharType xmlCharType = XmlCharType.Instance;

		// Token: 0x040006C1 RID: 1729
		private SecureStringHasher hasher;

		// Token: 0x040006C2 RID: 1730
		internal static readonly string[] stateName = new string[]
		{
			"Start",
			"TopLevel",
			"Document",
			"Element Start Tag",
			"Element Content",
			"Element Content",
			"Attribute",
			"EndRootElement",
			"Attribute",
			"Special Attribute",
			"End Document",
			"Root Level Attribute Value",
			"Root Level Special Attribute Value",
			"Root Level Base64 Attribute Value",
			"After Root Level Attribute",
			"Closed",
			"Error"
		};

		// Token: 0x040006C3 RID: 1731
		internal static readonly string[] tokenName = new string[]
		{
			"StartDocument",
			"EndDocument",
			"PI",
			"Comment",
			"DTD",
			"StartElement",
			"EndElement",
			"StartAttribute",
			"EndAttribute",
			"Text",
			"CDATA",
			"Atomic value",
			"Base64",
			"RawData",
			"Whitespace"
		};

		// Token: 0x040006C4 RID: 1732
		private static WriteState[] state2WriteState = new WriteState[]
		{
			WriteState.Start,
			WriteState.Prolog,
			WriteState.Prolog,
			WriteState.Element,
			WriteState.Content,
			WriteState.Content,
			WriteState.Attribute,
			WriteState.Content,
			WriteState.Attribute,
			WriteState.Attribute,
			WriteState.Content,
			WriteState.Attribute,
			WriteState.Attribute,
			WriteState.Attribute,
			WriteState.Attribute,
			WriteState.Closed,
			WriteState.Error
		};

		// Token: 0x040006C5 RID: 1733
		private static readonly XmlWellFormedWriter.State[] StateTableDocument = new XmlWellFormedWriter.State[]
		{
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndDocument,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDocEle,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.StartContentEle,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrSEle,
			XmlWellFormedWriter.State.EndAttrSEle,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrEEle,
			XmlWellFormedWriter.State.EndAttrEEle,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrSAttr,
			XmlWellFormedWriter.State.EndAttrSAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContentB64,
			XmlWellFormedWriter.State.B64Content,
			XmlWellFormedWriter.State.B64Content,
			XmlWellFormedWriter.State.B64Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.B64Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error
		};

		// Token: 0x040006C6 RID: 1734
		private static readonly XmlWellFormedWriter.State[] StateTableAuto = new XmlWellFormedWriter.State[]
		{
			XmlWellFormedWriter.State.Document,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndDocument,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartDoc,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragEle,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContentEle,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.EndAttrSEle,
			XmlWellFormedWriter.State.EndAttrSEle,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrEEle,
			XmlWellFormedWriter.State.EndAttrEEle,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.EndAttrSAttr,
			XmlWellFormedWriter.State.EndAttrSAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartRootLevelAttr,
			XmlWellFormedWriter.State.StartRootLevelAttr,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Element,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.AfterRootLevelAttr,
			XmlWellFormedWriter.State.AfterRootLevelAttr,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.RootLevelSpecAttr,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.EndAttrSCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragB64,
			XmlWellFormedWriter.State.StartFragB64,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContentB64,
			XmlWellFormedWriter.State.B64Content,
			XmlWellFormedWriter.State.B64Content,
			XmlWellFormedWriter.State.B64Attribute,
			XmlWellFormedWriter.State.B64Content,
			XmlWellFormedWriter.State.B64Attribute,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelB64Attr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartFragCont,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.RootLevelSpecAttr,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.AfterRootLevelAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.TopLevel,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.StartContent,
			XmlWellFormedWriter.State.Content,
			XmlWellFormedWriter.State.PostB64Cont,
			XmlWellFormedWriter.State.PostB64Attr,
			XmlWellFormedWriter.State.AfterRootEle,
			XmlWellFormedWriter.State.Attribute,
			XmlWellFormedWriter.State.SpecialAttr,
			XmlWellFormedWriter.State.Error,
			XmlWellFormedWriter.State.RootLevelAttr,
			XmlWellFormedWriter.State.RootLevelSpecAttr,
			XmlWellFormedWriter.State.PostB64RootAttr,
			XmlWellFormedWriter.State.AfterRootLevelAttr,
			XmlWellFormedWriter.State.Error
		};

		// Token: 0x020000FB RID: 251
		private enum State
		{
			// Token: 0x040006C8 RID: 1736
			Start,
			// Token: 0x040006C9 RID: 1737
			TopLevel,
			// Token: 0x040006CA RID: 1738
			Document,
			// Token: 0x040006CB RID: 1739
			Element,
			// Token: 0x040006CC RID: 1740
			Content,
			// Token: 0x040006CD RID: 1741
			B64Content,
			// Token: 0x040006CE RID: 1742
			B64Attribute,
			// Token: 0x040006CF RID: 1743
			AfterRootEle,
			// Token: 0x040006D0 RID: 1744
			Attribute,
			// Token: 0x040006D1 RID: 1745
			SpecialAttr,
			// Token: 0x040006D2 RID: 1746
			EndDocument,
			// Token: 0x040006D3 RID: 1747
			RootLevelAttr,
			// Token: 0x040006D4 RID: 1748
			RootLevelSpecAttr,
			// Token: 0x040006D5 RID: 1749
			RootLevelB64Attr,
			// Token: 0x040006D6 RID: 1750
			AfterRootLevelAttr,
			// Token: 0x040006D7 RID: 1751
			Closed,
			// Token: 0x040006D8 RID: 1752
			Error,
			// Token: 0x040006D9 RID: 1753
			StartContent = 101,
			// Token: 0x040006DA RID: 1754
			StartContentEle,
			// Token: 0x040006DB RID: 1755
			StartContentB64,
			// Token: 0x040006DC RID: 1756
			StartDoc,
			// Token: 0x040006DD RID: 1757
			StartDocEle = 106,
			// Token: 0x040006DE RID: 1758
			EndAttrSEle,
			// Token: 0x040006DF RID: 1759
			EndAttrEEle,
			// Token: 0x040006E0 RID: 1760
			EndAttrSCont,
			// Token: 0x040006E1 RID: 1761
			EndAttrSAttr = 111,
			// Token: 0x040006E2 RID: 1762
			PostB64Cont,
			// Token: 0x040006E3 RID: 1763
			PostB64Attr,
			// Token: 0x040006E4 RID: 1764
			PostB64RootAttr,
			// Token: 0x040006E5 RID: 1765
			StartFragEle,
			// Token: 0x040006E6 RID: 1766
			StartFragCont,
			// Token: 0x040006E7 RID: 1767
			StartFragB64,
			// Token: 0x040006E8 RID: 1768
			StartRootLevelAttr
		}

		// Token: 0x020000FC RID: 252
		private enum Token
		{
			// Token: 0x040006EA RID: 1770
			StartDocument,
			// Token: 0x040006EB RID: 1771
			EndDocument,
			// Token: 0x040006EC RID: 1772
			PI,
			// Token: 0x040006ED RID: 1773
			Comment,
			// Token: 0x040006EE RID: 1774
			Dtd,
			// Token: 0x040006EF RID: 1775
			StartElement,
			// Token: 0x040006F0 RID: 1776
			EndElement,
			// Token: 0x040006F1 RID: 1777
			StartAttribute,
			// Token: 0x040006F2 RID: 1778
			EndAttribute,
			// Token: 0x040006F3 RID: 1779
			Text,
			// Token: 0x040006F4 RID: 1780
			CData,
			// Token: 0x040006F5 RID: 1781
			AtomicValue,
			// Token: 0x040006F6 RID: 1782
			Base64,
			// Token: 0x040006F7 RID: 1783
			RawData,
			// Token: 0x040006F8 RID: 1784
			Whitespace
		}

		// Token: 0x020000FD RID: 253
		private class NamespaceResolverProxy : IXmlNamespaceResolver
		{
			// Token: 0x060008F8 RID: 2296 RVA: 0x0003DE3A File Offset: 0x0003C03A
			internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter)
			{
				this.wfWriter = wfWriter;
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x00002B48 File Offset: 0x00000D48
			IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
			{
				throw new NotImplementedException();
			}

			// Token: 0x060008FA RID: 2298 RVA: 0x0003DE49 File Offset: 0x0003C049
			string IXmlNamespaceResolver.LookupNamespace(string prefix)
			{
				return this.wfWriter.LookupNamespace(prefix);
			}

			// Token: 0x060008FB RID: 2299 RVA: 0x0003DE57 File Offset: 0x0003C057
			string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
			{
				return this.wfWriter.LookupPrefix(namespaceName);
			}

			// Token: 0x040006F9 RID: 1785
			private XmlWellFormedWriter wfWriter;
		}

		// Token: 0x020000FE RID: 254
		private struct ElementScope
		{
			// Token: 0x060008FC RID: 2300 RVA: 0x0003DE65 File Offset: 0x0003C065
			internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop)
			{
				this.prevNSTop = prevNSTop;
				this.prefix = prefix;
				this.namespaceUri = namespaceUri;
				this.localName = localName;
				this.xmlSpace = (XmlSpace)(-1);
				this.xmlLang = null;
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x0003DE92 File Offset: 0x0003C092
			internal void WriteEndElement(XmlRawWriter rawWriter)
			{
				rawWriter.WriteEndElement(this.prefix, this.localName, this.namespaceUri);
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x0003DEAC File Offset: 0x0003C0AC
			internal void WriteFullEndElement(XmlRawWriter rawWriter)
			{
				rawWriter.WriteFullEndElement(this.prefix, this.localName, this.namespaceUri);
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x0003DEC6 File Offset: 0x0003C0C6
			internal Task WriteEndElementAsync(XmlRawWriter rawWriter)
			{
				return rawWriter.WriteEndElementAsync(this.prefix, this.localName, this.namespaceUri);
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
			internal Task WriteFullEndElementAsync(XmlRawWriter rawWriter)
			{
				return rawWriter.WriteFullEndElementAsync(this.prefix, this.localName, this.namespaceUri);
			}

			// Token: 0x040006FA RID: 1786
			internal int prevNSTop;

			// Token: 0x040006FB RID: 1787
			internal string prefix;

			// Token: 0x040006FC RID: 1788
			internal string localName;

			// Token: 0x040006FD RID: 1789
			internal string namespaceUri;

			// Token: 0x040006FE RID: 1790
			internal XmlSpace xmlSpace;

			// Token: 0x040006FF RID: 1791
			internal string xmlLang;
		}

		// Token: 0x020000FF RID: 255
		private enum NamespaceKind
		{
			// Token: 0x04000701 RID: 1793
			Written,
			// Token: 0x04000702 RID: 1794
			NeedToWrite,
			// Token: 0x04000703 RID: 1795
			Implied,
			// Token: 0x04000704 RID: 1796
			Special
		}

		// Token: 0x02000100 RID: 256
		private struct Namespace
		{
			// Token: 0x06000901 RID: 2305 RVA: 0x0003DEFA File Offset: 0x0003C0FA
			internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind)
			{
				this.prefix = prefix;
				this.namespaceUri = namespaceUri;
				this.kind = kind;
				this.prevNsIndex = -1;
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x0003DF18 File Offset: 0x0003C118
			internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter)
			{
				if (rawWriter != null)
				{
					rawWriter.WriteNamespaceDeclaration(this.prefix, this.namespaceUri);
					return;
				}
				if (this.prefix.Length == 0)
				{
					writer.WriteStartAttribute(string.Empty, "xmlns", "http://www.w3.org/2000/xmlns/");
				}
				else
				{
					writer.WriteStartAttribute("xmlns", this.prefix, "http://www.w3.org/2000/xmlns/");
				}
				writer.WriteString(this.namespaceUri);
				writer.WriteEndAttribute();
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x0003DF88 File Offset: 0x0003C188
			internal Task WriteDeclAsync(XmlWriter writer, XmlRawWriter rawWriter)
			{
				XmlWellFormedWriter.Namespace.<WriteDeclAsync>d__6 <WriteDeclAsync>d__;
				<WriteDeclAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<WriteDeclAsync>d__.<>4__this = this;
				<WriteDeclAsync>d__.writer = writer;
				<WriteDeclAsync>d__.rawWriter = rawWriter;
				<WriteDeclAsync>d__.<>1__state = -1;
				<WriteDeclAsync>d__.<>t__builder.Start<XmlWellFormedWriter.Namespace.<WriteDeclAsync>d__6>(ref <WriteDeclAsync>d__);
				return <WriteDeclAsync>d__.<>t__builder.Task;
			}

			// Token: 0x04000705 RID: 1797
			internal string prefix;

			// Token: 0x04000706 RID: 1798
			internal string namespaceUri;

			// Token: 0x04000707 RID: 1799
			internal XmlWellFormedWriter.NamespaceKind kind;

			// Token: 0x04000708 RID: 1800
			internal int prevNsIndex;
		}

		// Token: 0x02000102 RID: 258
		private struct AttrName
		{
			// Token: 0x06000906 RID: 2310 RVA: 0x0003E2DA File Offset: 0x0003C4DA
			internal void Set(string prefix, string localName, string namespaceUri)
			{
				this.prefix = prefix;
				this.namespaceUri = namespaceUri;
				this.localName = localName;
				this.prev = 0;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x0003E2F8 File Offset: 0x0003C4F8
			internal bool IsDuplicate(string prefix, string localName, string namespaceUri)
			{
				return this.localName == localName && (this.prefix == prefix || this.namespaceUri == namespaceUri);
			}

			// Token: 0x0400070F RID: 1807
			internal string prefix;

			// Token: 0x04000710 RID: 1808
			internal string namespaceUri;

			// Token: 0x04000711 RID: 1809
			internal string localName;

			// Token: 0x04000712 RID: 1810
			internal int prev;
		}

		// Token: 0x02000103 RID: 259
		private enum SpecialAttribute
		{
			// Token: 0x04000714 RID: 1812
			No,
			// Token: 0x04000715 RID: 1813
			DefaultXmlns,
			// Token: 0x04000716 RID: 1814
			PrefixedXmlns,
			// Token: 0x04000717 RID: 1815
			XmlSpace,
			// Token: 0x04000718 RID: 1816
			XmlLang
		}

		// Token: 0x02000104 RID: 260
		private class AttributeValueCache
		{
			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000908 RID: 2312 RVA: 0x0003E326 File Offset: 0x0003C526
			internal string StringValue
			{
				get
				{
					if (this.singleStringValue != null)
					{
						return this.singleStringValue;
					}
					return this.stringValue.ToString();
				}
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x0003E344 File Offset: 0x0003C544
			internal void WriteEntityRef(string name)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				if (!(name == "lt"))
				{
					if (!(name == "gt"))
					{
						if (!(name == "quot"))
						{
							if (!(name == "apos"))
							{
								if (!(name == "amp"))
								{
									this.stringValue.Append('&');
									this.stringValue.Append(name);
									this.stringValue.Append(';');
								}
								else
								{
									this.stringValue.Append('&');
								}
							}
							else
							{
								this.stringValue.Append('\'');
							}
						}
						else
						{
							this.stringValue.Append('"');
						}
					}
					else
					{
						this.stringValue.Append('>');
					}
				}
				else
				{
					this.stringValue.Append('<');
				}
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.EntityRef, name);
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x0003E423 File Offset: 0x0003C623
			internal void WriteCharEntity(char ch)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(ch);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.CharEntity, ch);
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x0003E44D File Offset: 0x0003C64D
			internal void WriteSurrogateCharEntity(char lowChar, char highChar)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(highChar);
				this.stringValue.Append(lowChar);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.SurrogateCharEntity, new char[]
				{
					lowChar,
					highChar
				});
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x0003E48C File Offset: 0x0003C68C
			internal void WriteWhitespace(string ws)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(ws);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.Whitespace, ws);
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x0003E4B1 File Offset: 0x0003C6B1
			internal void WriteString(string text)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				else if (this.lastItem == -1)
				{
					this.singleStringValue = text;
					return;
				}
				this.stringValue.Append(text);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.String, text);
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x0003E4E9 File Offset: 0x0003C6E9
			internal void WriteChars(char[] buffer, int index, int count)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(buffer, index, count);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.StringChars, new XmlWellFormedWriter.AttributeValueCache.BufferChunk(buffer, index, count));
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x0003E517 File Offset: 0x0003C717
			internal void WriteRaw(char[] buffer, int index, int count)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(buffer, index, count);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.RawChars, new XmlWellFormedWriter.AttributeValueCache.BufferChunk(buffer, index, count));
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x0003E545 File Offset: 0x0003C745
			internal void WriteRaw(string data)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(data);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.Raw, data);
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x0003E56A File Offset: 0x0003C76A
			internal void WriteValue(string value)
			{
				if (this.singleStringValue != null)
				{
					this.StartComplexValue();
				}
				this.stringValue.Append(value);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.ValueString, value);
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x0003E590 File Offset: 0x0003C790
			internal void Replay(XmlWriter writer)
			{
				if (this.singleStringValue != null)
				{
					writer.WriteString(this.singleStringValue);
					return;
				}
				for (int i = this.firstItem; i <= this.lastItem; i++)
				{
					XmlWellFormedWriter.AttributeValueCache.Item item = this.items[i];
					switch (item.type)
					{
					case XmlWellFormedWriter.AttributeValueCache.ItemType.EntityRef:
						writer.WriteEntityRef((string)item.data);
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.CharEntity:
						writer.WriteCharEntity((char)item.data);
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.SurrogateCharEntity:
					{
						char[] array = (char[])item.data;
						writer.WriteSurrogateCharEntity(array[0], array[1]);
						break;
					}
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Whitespace:
						writer.WriteWhitespace((string)item.data);
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.String:
						writer.WriteString((string)item.data);
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.StringChars:
					{
						XmlWellFormedWriter.AttributeValueCache.BufferChunk bufferChunk = (XmlWellFormedWriter.AttributeValueCache.BufferChunk)item.data;
						writer.WriteChars(bufferChunk.buffer, bufferChunk.index, bufferChunk.count);
						break;
					}
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Raw:
						writer.WriteRaw((string)item.data);
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.RawChars:
					{
						XmlWellFormedWriter.AttributeValueCache.BufferChunk bufferChunk = (XmlWellFormedWriter.AttributeValueCache.BufferChunk)item.data;
						writer.WriteChars(bufferChunk.buffer, bufferChunk.index, bufferChunk.count);
						break;
					}
					case XmlWellFormedWriter.AttributeValueCache.ItemType.ValueString:
						writer.WriteValue((string)item.data);
						break;
					}
				}
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
			internal void Trim()
			{
				if (this.singleStringValue != null)
				{
					this.singleStringValue = XmlConvert.TrimString(this.singleStringValue);
					return;
				}
				string text = this.stringValue.ToString();
				string text2 = XmlConvert.TrimString(text);
				if (text != text2)
				{
					this.stringValue = new StringBuilder(text2);
				}
				XmlCharType instance = XmlCharType.Instance;
				int num = this.firstItem;
				while (num == this.firstItem && num <= this.lastItem)
				{
					XmlWellFormedWriter.AttributeValueCache.Item item = this.items[num];
					switch (item.type)
					{
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Whitespace:
						this.firstItem++;
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.String:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Raw:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.ValueString:
						item.data = XmlConvert.TrimStringStart((string)item.data);
						if (((string)item.data).Length == 0)
						{
							this.firstItem++;
						}
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.StringChars:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.RawChars:
					{
						XmlWellFormedWriter.AttributeValueCache.BufferChunk bufferChunk = (XmlWellFormedWriter.AttributeValueCache.BufferChunk)item.data;
						int num2 = bufferChunk.index + bufferChunk.count;
						while (bufferChunk.index < num2 && instance.IsWhiteSpace(bufferChunk.buffer[bufferChunk.index]))
						{
							bufferChunk.index++;
							bufferChunk.count--;
						}
						if (bufferChunk.index == num2)
						{
							this.firstItem++;
						}
						break;
					}
					}
					num++;
				}
				num = this.lastItem;
				while (num == this.lastItem && num >= this.firstItem)
				{
					XmlWellFormedWriter.AttributeValueCache.Item item2 = this.items[num];
					switch (item2.type)
					{
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Whitespace:
						this.lastItem--;
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.String:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.Raw:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.ValueString:
						item2.data = XmlConvert.TrimStringEnd((string)item2.data);
						if (((string)item2.data).Length == 0)
						{
							this.lastItem--;
						}
						break;
					case XmlWellFormedWriter.AttributeValueCache.ItemType.StringChars:
					case XmlWellFormedWriter.AttributeValueCache.ItemType.RawChars:
					{
						XmlWellFormedWriter.AttributeValueCache.BufferChunk bufferChunk2 = (XmlWellFormedWriter.AttributeValueCache.BufferChunk)item2.data;
						while (bufferChunk2.count > 0 && instance.IsWhiteSpace(bufferChunk2.buffer[bufferChunk2.index + bufferChunk2.count - 1]))
						{
							bufferChunk2.count--;
						}
						if (bufferChunk2.count == 0)
						{
							this.lastItem--;
						}
						break;
					}
					}
					num--;
				}
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0003E979 File Offset: 0x0003CB79
			internal void Clear()
			{
				this.singleStringValue = null;
				this.lastItem = -1;
				this.firstItem = 0;
				this.stringValue.Length = 0;
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x0003E99C File Offset: 0x0003CB9C
			private void StartComplexValue()
			{
				this.stringValue.Append(this.singleStringValue);
				this.AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType.String, this.singleStringValue);
				this.singleStringValue = null;
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x0003E9C4 File Offset: 0x0003CBC4
			private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
			{
				int num = this.lastItem + 1;
				if (this.items == null)
				{
					this.items = new XmlWellFormedWriter.AttributeValueCache.Item[4];
				}
				else if (this.items.Length == num)
				{
					XmlWellFormedWriter.AttributeValueCache.Item[] destinationArray = new XmlWellFormedWriter.AttributeValueCache.Item[num * 2];
					Array.Copy(this.items, destinationArray, num);
					this.items = destinationArray;
				}
				if (this.items[num] == null)
				{
					this.items[num] = new XmlWellFormedWriter.AttributeValueCache.Item();
				}
				this.items[num].Set(type, data);
				this.lastItem = num;
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0003EA48 File Offset: 0x0003CC48
			internal Task ReplayAsync(XmlWriter writer)
			{
				XmlWellFormedWriter.AttributeValueCache.<ReplayAsync>d__24 <ReplayAsync>d__;
				<ReplayAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
				<ReplayAsync>d__.<>4__this = this;
				<ReplayAsync>d__.writer = writer;
				<ReplayAsync>d__.<>1__state = -1;
				<ReplayAsync>d__.<>t__builder.Start<XmlWellFormedWriter.AttributeValueCache.<ReplayAsync>d__24>(ref <ReplayAsync>d__);
				return <ReplayAsync>d__.<>t__builder.Task;
			}

			// Token: 0x04000719 RID: 1817
			private StringBuilder stringValue = new StringBuilder();

			// Token: 0x0400071A RID: 1818
			private string singleStringValue;

			// Token: 0x0400071B RID: 1819
			private XmlWellFormedWriter.AttributeValueCache.Item[] items;

			// Token: 0x0400071C RID: 1820
			private int firstItem;

			// Token: 0x0400071D RID: 1821
			private int lastItem = -1;

			// Token: 0x02000105 RID: 261
			private enum ItemType
			{
				// Token: 0x0400071F RID: 1823
				EntityRef,
				// Token: 0x04000720 RID: 1824
				CharEntity,
				// Token: 0x04000721 RID: 1825
				SurrogateCharEntity,
				// Token: 0x04000722 RID: 1826
				Whitespace,
				// Token: 0x04000723 RID: 1827
				String,
				// Token: 0x04000724 RID: 1828
				StringChars,
				// Token: 0x04000725 RID: 1829
				Raw,
				// Token: 0x04000726 RID: 1830
				RawChars,
				// Token: 0x04000727 RID: 1831
				ValueString
			}

			// Token: 0x02000106 RID: 262
			private class Item
			{
				// Token: 0x06000919 RID: 2329 RVA: 0x0000A20E File Offset: 0x0000840E
				internal Item()
				{
				}

				// Token: 0x0600091A RID: 2330 RVA: 0x0003EAAD File Offset: 0x0003CCAD
				internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data)
				{
					this.type = type;
					this.data = data;
				}

				// Token: 0x04000728 RID: 1832
				internal XmlWellFormedWriter.AttributeValueCache.ItemType type;

				// Token: 0x04000729 RID: 1833
				internal object data;
			}

			// Token: 0x02000107 RID: 263
			private class BufferChunk
			{
				// Token: 0x0600091B RID: 2331 RVA: 0x0003EABD File Offset: 0x0003CCBD
				internal BufferChunk(char[] buffer, int index, int count)
				{
					this.buffer = buffer;
					this.index = index;
					this.count = count;
				}

				// Token: 0x0400072A RID: 1834
				internal char[] buffer;

				// Token: 0x0400072B RID: 1835
				internal int index;

				// Token: 0x0400072C RID: 1836
				internal int count;
			}
		}
	}
}
