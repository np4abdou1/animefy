using System;

namespace System.Xml.Serialization
{
	/// <summary>Provides data for the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> event.</summary>
	// Token: 0x020001CB RID: 459
	public class XmlElementEventArgs : EventArgs
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00062BF9 File Offset: 0x00060DF9
		internal XmlElementEventArgs(XmlElement elem, int lineNumber, int linePosition, object o, string qnames)
		{
			this.elem = elem;
			this.o = o;
			this.qnames = qnames;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x04000B15 RID: 2837
		private object o;

		// Token: 0x04000B16 RID: 2838
		private XmlElement elem;

		// Token: 0x04000B17 RID: 2839
		private string qnames;

		// Token: 0x04000B18 RID: 2840
		private int lineNumber;

		// Token: 0x04000B19 RID: 2841
		private int linePosition;
	}
}
