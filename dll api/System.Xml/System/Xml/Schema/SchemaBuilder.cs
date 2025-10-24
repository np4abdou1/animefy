using System;

namespace System.Xml.Schema
{
	// Token: 0x020002AC RID: 684
	internal abstract class SchemaBuilder
	{
		// Token: 0x060015C6 RID: 5574
		internal abstract bool ProcessElement(string prefix, string name, string ns);

		// Token: 0x060015C7 RID: 5575
		internal abstract void ProcessAttribute(string prefix, string name, string ns, string value);

		// Token: 0x060015C8 RID: 5576
		internal abstract bool IsContentParsed();

		// Token: 0x060015C9 RID: 5577
		internal abstract void ProcessMarkup(XmlNode[] markup);

		// Token: 0x060015CA RID: 5578
		internal abstract void ProcessCData(string value);

		// Token: 0x060015CB RID: 5579
		internal abstract void StartChildren();

		// Token: 0x060015CC RID: 5580
		internal abstract void EndChildren();
	}
}
