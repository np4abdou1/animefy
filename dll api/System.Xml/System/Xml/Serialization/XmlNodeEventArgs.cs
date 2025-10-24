using System;

namespace System.Xml.Serialization
{
	/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event.</summary>
	// Token: 0x020001CD RID: 461
	public class XmlNodeEventArgs : EventArgs
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00062C26 File Offset: 0x00060E26
		internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o)
		{
			this.o = o;
			this.xmlNode = xmlNode;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x04000B1A RID: 2842
		private object o;

		// Token: 0x04000B1B RID: 2843
		private XmlNode xmlNode;

		// Token: 0x04000B1C RID: 2844
		private int lineNumber;

		// Token: 0x04000B1D RID: 2845
		private int linePosition;
	}
}
