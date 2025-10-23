using System;

namespace System.Xml.Serialization
{
	/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> event.</summary>
	// Token: 0x020001C9 RID: 457
	public class XmlAttributeEventArgs : EventArgs
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x00062BCC File Offset: 0x00060DCC
		internal XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames)
		{
			this.attr = attr;
			this.o = o;
			this.qnames = qnames;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x04000B10 RID: 2832
		private object o;

		// Token: 0x04000B11 RID: 2833
		private XmlAttribute attr;

		// Token: 0x04000B12 RID: 2834
		private string qnames;

		// Token: 0x04000B13 RID: 2835
		private int lineNumber;

		// Token: 0x04000B14 RID: 2836
		private int linePosition;
	}
}
