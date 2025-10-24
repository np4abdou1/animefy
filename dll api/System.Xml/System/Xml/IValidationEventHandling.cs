using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000033 RID: 51
	internal interface IValidationEventHandling
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019D RID: 413
		object EventHandler { get; }

		// Token: 0x0600019E RID: 414
		void SendEvent(Exception exception, XmlSeverityType severity);
	}
}
