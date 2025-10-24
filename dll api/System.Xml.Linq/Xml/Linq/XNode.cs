using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents the abstract concept of a node (element, comment, document type, processing instruction, or text node) in the XML tree.  </summary>
	// Token: 0x02000031 RID: 49
	public abstract class XNode : XObject
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00008376 File Offset: 0x00006576
		internal XNode()
		{
		}

		/// <summary>Removes this node from its parent.</summary>
		/// <exception cref="T:System.InvalidOperationException">The parent is <see langword="null" />.</exception>
		// Token: 0x06000166 RID: 358 RVA: 0x0000837E File Offset: 0x0000657E
		public void Remove()
		{
			if (this.parent == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this.parent.RemoveNode(this);
		}

		/// <summary>Returns the indented XML for this node.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the indented XML.</returns>
		// Token: 0x06000167 RID: 359 RVA: 0x0000839F File Offset: 0x0000659F
		public override string ToString()
		{
			return this.GetXmlString(base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Writes this node to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x06000168 RID: 360
		public abstract void WriteTo(XmlWriter writer);

		// Token: 0x06000169 RID: 361
		public abstract Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken);

		// Token: 0x0600016A RID: 362 RVA: 0x000028A0 File Offset: 0x00000AA0
		internal virtual void AppendText(StringBuilder sb)
		{
		}

		// Token: 0x0600016B RID: 363
		internal abstract XNode CloneNode();

		// Token: 0x0600016C RID: 364
		internal abstract bool DeepEquals(XNode node);

		// Token: 0x0600016D RID: 365 RVA: 0x000083AD File Offset: 0x000065AD
		internal IEnumerable<XElement> GetAncestors(XName name, bool self)
		{
			for (XElement e = (self ? this : this.parent) as XElement; e != null; e = (e.parent as XElement))
			{
				if (name == null || e.name == name)
				{
					yield return e;
				}
			}
			yield break;
		}

		// Token: 0x0600016E RID: 366
		internal abstract int GetDeepHashCode();

		// Token: 0x0600016F RID: 367 RVA: 0x000083CC File Offset: 0x000065CC
		internal static XmlReaderSettings GetXmlReaderSettings(LoadOptions o)
		{
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			if ((o & LoadOptions.PreserveWhitespace) == LoadOptions.None)
			{
				xmlReaderSettings.IgnoreWhitespace = true;
			}
			xmlReaderSettings.DtdProcessing = DtdProcessing.Parse;
			xmlReaderSettings.MaxCharactersFromEntities = 10000000L;
			return xmlReaderSettings;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008400 File Offset: 0x00006600
		internal static XmlWriterSettings GetXmlWriterSettings(SaveOptions o)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			if ((o & SaveOptions.DisableFormatting) == SaveOptions.None)
			{
				xmlWriterSettings.Indent = true;
			}
			if ((o & SaveOptions.OmitDuplicateNamespaces) != SaveOptions.None)
			{
				xmlWriterSettings.NamespaceHandling |= NamespaceHandling.OmitDuplicates;
			}
			return xmlWriterSettings;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008434 File Offset: 0x00006634
		private string GetXmlString(SaveOptions o)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
				xmlWriterSettings.OmitXmlDeclaration = true;
				if ((o & SaveOptions.DisableFormatting) == SaveOptions.None)
				{
					xmlWriterSettings.Indent = true;
				}
				if ((o & SaveOptions.OmitDuplicateNamespaces) != SaveOptions.None)
				{
					xmlWriterSettings.NamespaceHandling |= NamespaceHandling.OmitDuplicates;
				}
				if (this is XText)
				{
					xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;
				}
				using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings))
				{
					XDocument xdocument = this as XDocument;
					if (xdocument != null)
					{
						xdocument.WriteContentTo(xmlWriter);
					}
					else
					{
						this.WriteTo(xmlWriter);
					}
				}
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x040000CF RID: 207
		internal XNode next;
	}
}
