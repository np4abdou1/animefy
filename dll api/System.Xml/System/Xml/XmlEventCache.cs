using System;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;

namespace System.Xml
{
	// Token: 0x02000070 RID: 112
	internal sealed class XmlEventCache : XmlRawWriter
	{
		// Token: 0x0600039D RID: 925 RVA: 0x000146AE File Offset: 0x000128AE
		public XmlEventCache(string baseUri, bool hasRootNode)
		{
			this.baseUri = baseUri;
			this.hasRootNode = hasRootNode;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000146C4 File Offset: 0x000128C4
		public void EndEvents()
		{
			if (this.singleText.Count == 0)
			{
				this.AddEvent(XmlEventCache.XmlEventType.Unknown);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000146DC File Offset: 0x000128DC
		public void EventsToWriter(XmlWriter writer)
		{
			if (this.singleText.Count != 0)
			{
				writer.WriteString(this.singleText.GetResult());
				return;
			}
			XmlRawWriter xmlRawWriter = writer as XmlRawWriter;
			for (int i = 0; i < this.pages.Count; i++)
			{
				XmlEventCache.XmlEvent[] array = this.pages[i];
				for (int j = 0; j < array.Length; j++)
				{
					switch (array[j].EventType)
					{
					case XmlEventCache.XmlEventType.Unknown:
						return;
					case XmlEventCache.XmlEventType.DocType:
						writer.WriteDocType(array[j].String1, array[j].String2, array[j].String3, (string)array[j].Object);
						break;
					case XmlEventCache.XmlEventType.StartElem:
						writer.WriteStartElement(array[j].String1, array[j].String2, array[j].String3);
						break;
					case XmlEventCache.XmlEventType.StartAttr:
						writer.WriteStartAttribute(array[j].String1, array[j].String2, array[j].String3);
						break;
					case XmlEventCache.XmlEventType.EndAttr:
						writer.WriteEndAttribute();
						break;
					case XmlEventCache.XmlEventType.CData:
						writer.WriteCData(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.Comment:
						writer.WriteComment(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.PI:
						writer.WriteProcessingInstruction(array[j].String1, array[j].String2);
						break;
					case XmlEventCache.XmlEventType.Whitespace:
						writer.WriteWhitespace(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.String:
						writer.WriteString(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.Raw:
						writer.WriteRaw(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.EntRef:
						writer.WriteEntityRef(array[j].String1);
						break;
					case XmlEventCache.XmlEventType.CharEnt:
						writer.WriteCharEntity((char)array[j].Object);
						break;
					case XmlEventCache.XmlEventType.SurrCharEnt:
					{
						char[] array2 = (char[])array[j].Object;
						writer.WriteSurrogateCharEntity(array2[0], array2[1]);
						break;
					}
					case XmlEventCache.XmlEventType.Base64:
					{
						byte[] array3 = (byte[])array[j].Object;
						writer.WriteBase64(array3, 0, array3.Length);
						break;
					}
					case XmlEventCache.XmlEventType.BinHex:
					{
						byte[] array3 = (byte[])array[j].Object;
						writer.WriteBinHex(array3, 0, array3.Length);
						break;
					}
					case XmlEventCache.XmlEventType.XmlDecl1:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteXmlDeclaration((XmlStandalone)array[j].Object);
						}
						break;
					case XmlEventCache.XmlEventType.XmlDecl2:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteXmlDeclaration(array[j].String1);
						}
						break;
					case XmlEventCache.XmlEventType.StartContent:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.StartElementContent();
						}
						break;
					case XmlEventCache.XmlEventType.EndElem:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteEndElement(array[j].String1, array[j].String2, array[j].String3);
						}
						else
						{
							writer.WriteEndElement();
						}
						break;
					case XmlEventCache.XmlEventType.FullEndElem:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteFullEndElement(array[j].String1, array[j].String2, array[j].String3);
						}
						else
						{
							writer.WriteFullEndElement();
						}
						break;
					case XmlEventCache.XmlEventType.Nmsp:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteNamespaceDeclaration(array[j].String1, array[j].String2);
						}
						else
						{
							writer.WriteAttributeString("xmlns", array[j].String1, "http://www.w3.org/2000/xmlns/", array[j].String2);
						}
						break;
					case XmlEventCache.XmlEventType.EndBase64:
						if (xmlRawWriter != null)
						{
							xmlRawWriter.WriteEndBase64();
						}
						break;
					case XmlEventCache.XmlEventType.Close:
						writer.Close();
						break;
					case XmlEventCache.XmlEventType.Flush:
						writer.Flush();
						break;
					case XmlEventCache.XmlEventType.Dispose:
						((IDisposable)writer).Dispose();
						break;
					}
				}
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00014AEC File Offset: 0x00012CEC
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.AddEvent(XmlEventCache.XmlEventType.DocType, name, pubid, sysid, subset);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00014AFA File Offset: 0x00012CFA
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.AddEvent(XmlEventCache.XmlEventType.StartElem, prefix, localName, ns);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00014B06 File Offset: 0x00012D06
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.AddEvent(XmlEventCache.XmlEventType.StartAttr, prefix, localName, ns);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00014B12 File Offset: 0x00012D12
		public override void WriteEndAttribute()
		{
			this.AddEvent(XmlEventCache.XmlEventType.EndAttr);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00014B1B File Offset: 0x00012D1B
		public override void WriteCData(string text)
		{
			this.AddEvent(XmlEventCache.XmlEventType.CData, text);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00014B25 File Offset: 0x00012D25
		public override void WriteComment(string text)
		{
			this.AddEvent(XmlEventCache.XmlEventType.Comment, text);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00014B2F File Offset: 0x00012D2F
		public override void WriteProcessingInstruction(string name, string text)
		{
			this.AddEvent(XmlEventCache.XmlEventType.PI, name, text);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00014B3A File Offset: 0x00012D3A
		public override void WriteWhitespace(string ws)
		{
			this.AddEvent(XmlEventCache.XmlEventType.Whitespace, ws);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00014B44 File Offset: 0x00012D44
		public override void WriteString(string text)
		{
			if (this.pages == null)
			{
				this.singleText.ConcatNoDelimiter(text);
				return;
			}
			this.AddEvent(XmlEventCache.XmlEventType.String, text);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000BD85 File Offset: 0x00009F85
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.WriteString(new string(buffer, index, count));
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000BD95 File Offset: 0x00009F95
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.WriteRaw(new string(buffer, index, count));
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00014B64 File Offset: 0x00012D64
		public override void WriteRaw(string data)
		{
			this.AddEvent(XmlEventCache.XmlEventType.Raw, data);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00014B6F File Offset: 0x00012D6F
		public override void WriteEntityRef(string name)
		{
			this.AddEvent(XmlEventCache.XmlEventType.EntRef, name);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00014B7A File Offset: 0x00012D7A
		public override void WriteCharEntity(char ch)
		{
			this.AddEvent(XmlEventCache.XmlEventType.CharEnt, ch);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00014B8C File Offset: 0x00012D8C
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			char[] o = new char[]
			{
				lowChar,
				highChar
			};
			this.AddEvent(XmlEventCache.XmlEventType.SurrCharEnt, o);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00014BB1 File Offset: 0x00012DB1
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.AddEvent(XmlEventCache.XmlEventType.Base64, XmlEventCache.ToBytes(buffer, index, count));
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00014BC3 File Offset: 0x00012DC3
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			this.AddEvent(XmlEventCache.XmlEventType.BinHex, XmlEventCache.ToBytes(buffer, index, count));
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00014BD5 File Offset: 0x00012DD5
		public override void Close()
		{
			this.AddEvent(XmlEventCache.XmlEventType.Close);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00014BDF File Offset: 0x00012DDF
		public override void Flush()
		{
			this.AddEvent(XmlEventCache.XmlEventType.Flush);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00014BE9 File Offset: 0x00012DE9
		public override void WriteValue(string value)
		{
			this.WriteString(value);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00014BF4 File Offset: 0x00012DF4
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					this.AddEvent(XmlEventCache.XmlEventType.Dispose);
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00014C28 File Offset: 0x00012E28
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			this.AddEvent(XmlEventCache.XmlEventType.XmlDecl1, standalone);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00014C38 File Offset: 0x00012E38
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			this.AddEvent(XmlEventCache.XmlEventType.XmlDecl2, xmldecl);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00014C43 File Offset: 0x00012E43
		internal override void StartElementContent()
		{
			this.AddEvent(XmlEventCache.XmlEventType.StartContent);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00014C4D File Offset: 0x00012E4D
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			this.AddEvent(XmlEventCache.XmlEventType.EndElem, prefix, localName, ns);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00014C5A File Offset: 0x00012E5A
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			this.AddEvent(XmlEventCache.XmlEventType.FullEndElem, prefix, localName, ns);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00014C67 File Offset: 0x00012E67
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			this.AddEvent(XmlEventCache.XmlEventType.Nmsp, prefix, ns);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00014C73 File Offset: 0x00012E73
		internal override void WriteEndBase64()
		{
			this.AddEvent(XmlEventCache.XmlEventType.EndBase64);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00014C80 File Offset: 0x00012E80
		private void AddEvent(XmlEventCache.XmlEventType eventType)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00014CA8 File Offset: 0x00012EA8
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType, s1);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00014CD0 File Offset: 0x00012ED0
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType, s1, s2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00014CF8 File Offset: 0x00012EF8
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType, s1, s2, s3);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00014D24 File Offset: 0x00012F24
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType, s1, s2, s3, o);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00014D50 File Offset: 0x00012F50
		private void AddEvent(XmlEventCache.XmlEventType eventType, object o)
		{
			int num = this.NewEvent();
			this.pageCurr[num].InitEvent(eventType, o);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00014D78 File Offset: 0x00012F78
		private int NewEvent()
		{
			if (this.pages == null)
			{
				this.pages = new List<XmlEventCache.XmlEvent[]>();
				this.pageCurr = new XmlEventCache.XmlEvent[32];
				this.pages.Add(this.pageCurr);
				if (this.singleText.Count != 0)
				{
					this.pageCurr[0].InitEvent(XmlEventCache.XmlEventType.String, this.singleText.GetResult());
					this.pageSize++;
					this.singleText.Clear();
				}
			}
			else if (this.pageSize >= this.pageCurr.Length)
			{
				this.pageCurr = new XmlEventCache.XmlEvent[this.pageSize * 2];
				this.pages.Add(this.pageCurr);
				this.pageSize = 0;
			}
			int num = this.pageSize;
			this.pageSize = num + 1;
			return num;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00014E48 File Offset: 0x00013048
		private static byte[] ToBytes(byte[] buffer, int index, int count)
		{
			if (index != 0 || count != buffer.Length)
			{
				if (buffer.Length - index > count)
				{
					count = buffer.Length - index;
				}
				byte[] array = new byte[count];
				Array.Copy(buffer, index, array, 0, count);
				return array;
			}
			return buffer;
		}

		// Token: 0x04000281 RID: 641
		private List<XmlEventCache.XmlEvent[]> pages;

		// Token: 0x04000282 RID: 642
		private XmlEventCache.XmlEvent[] pageCurr;

		// Token: 0x04000283 RID: 643
		private int pageSize;

		// Token: 0x04000284 RID: 644
		private bool hasRootNode;

		// Token: 0x04000285 RID: 645
		private StringConcat singleText;

		// Token: 0x04000286 RID: 646
		private string baseUri;

		// Token: 0x02000071 RID: 113
		private enum XmlEventType
		{
			// Token: 0x04000288 RID: 648
			Unknown,
			// Token: 0x04000289 RID: 649
			DocType,
			// Token: 0x0400028A RID: 650
			StartElem,
			// Token: 0x0400028B RID: 651
			StartAttr,
			// Token: 0x0400028C RID: 652
			EndAttr,
			// Token: 0x0400028D RID: 653
			CData,
			// Token: 0x0400028E RID: 654
			Comment,
			// Token: 0x0400028F RID: 655
			PI,
			// Token: 0x04000290 RID: 656
			Whitespace,
			// Token: 0x04000291 RID: 657
			String,
			// Token: 0x04000292 RID: 658
			Raw,
			// Token: 0x04000293 RID: 659
			EntRef,
			// Token: 0x04000294 RID: 660
			CharEnt,
			// Token: 0x04000295 RID: 661
			SurrCharEnt,
			// Token: 0x04000296 RID: 662
			Base64,
			// Token: 0x04000297 RID: 663
			BinHex,
			// Token: 0x04000298 RID: 664
			XmlDecl1,
			// Token: 0x04000299 RID: 665
			XmlDecl2,
			// Token: 0x0400029A RID: 666
			StartContent,
			// Token: 0x0400029B RID: 667
			EndElem,
			// Token: 0x0400029C RID: 668
			FullEndElem,
			// Token: 0x0400029D RID: 669
			Nmsp,
			// Token: 0x0400029E RID: 670
			EndBase64,
			// Token: 0x0400029F RID: 671
			Close,
			// Token: 0x040002A0 RID: 672
			Flush,
			// Token: 0x040002A1 RID: 673
			Dispose
		}

		// Token: 0x02000072 RID: 114
		private struct XmlEvent
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00014E81 File Offset: 0x00013081
			public void InitEvent(XmlEventCache.XmlEventType eventType)
			{
				this.eventType = eventType;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00014E8A File Offset: 0x0001308A
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1)
			{
				this.eventType = eventType;
				this.s1 = s1;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00014E9A File Offset: 0x0001309A
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00014EB1 File Offset: 0x000130B1
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
				this.s3 = s3;
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00014ED0 File Offset: 0x000130D0
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
			{
				this.eventType = eventType;
				this.s1 = s1;
				this.s2 = s2;
				this.s3 = s3;
				this.o = o;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00014EF7 File Offset: 0x000130F7
			public void InitEvent(XmlEventCache.XmlEventType eventType, object o)
			{
				this.eventType = eventType;
				this.o = o;
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003CA RID: 970 RVA: 0x00014F07 File Offset: 0x00013107
			public XmlEventCache.XmlEventType EventType
			{
				get
				{
					return this.eventType;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003CB RID: 971 RVA: 0x00014F0F File Offset: 0x0001310F
			public string String1
			{
				get
				{
					return this.s1;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00014F17 File Offset: 0x00013117
			public string String2
			{
				get
				{
					return this.s2;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060003CD RID: 973 RVA: 0x00014F1F File Offset: 0x0001311F
			public string String3
			{
				get
				{
					return this.s3;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00014F27 File Offset: 0x00013127
			public object Object
			{
				get
				{
					return this.o;
				}
			}

			// Token: 0x040002A2 RID: 674
			private XmlEventCache.XmlEventType eventType;

			// Token: 0x040002A3 RID: 675
			private string s1;

			// Token: 0x040002A4 RID: 676
			private string s2;

			// Token: 0x040002A5 RID: 677
			private string s3;

			// Token: 0x040002A6 RID: 678
			private object o;
		}
	}
}
