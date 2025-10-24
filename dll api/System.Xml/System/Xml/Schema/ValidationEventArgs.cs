using System;

namespace System.Xml.Schema
{
	/// <summary>Returns detailed information related to the <see langword="ValidationEventHandler" />.</summary>
	// Token: 0x020002BC RID: 700
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x0009156F File Offset: 0x0008F76F
		internal ValidationEventArgs(XmlSchemaException ex)
		{
			this.ex = ex;
			this.severity = XmlSeverityType.Error;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00091585 File Offset: 0x0008F785
		internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
		{
			this.ex = ex;
			this.severity = severity;
		}

		/// <summary>Gets the severity of the validation event.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSeverityType" /> value representing the severity of the validation event.</returns>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0009159B File Offset: 0x0008F79B
		public XmlSeverityType Severity
		{
			get
			{
				return this.severity;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaException" /> associated with the validation event.</summary>
		/// <returns>The <see langword="XmlSchemaException" /> associated with the validation event.</returns>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000915A3 File Offset: 0x0008F7A3
		public XmlSchemaException Exception
		{
			get
			{
				return this.ex;
			}
		}

		// Token: 0x04000F87 RID: 3975
		private XmlSchemaException ex;

		// Token: 0x04000F88 RID: 3976
		private XmlSeverityType severity;
	}
}
