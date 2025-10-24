using System;
using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Returns information about errors encountered by the <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class while inferring a schema from an XML document.</summary>
	// Token: 0x020002A1 RID: 673
	[Serializable]
	public class XmlSchemaInferenceException : XmlSchemaException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects specified that contain all the properties of the <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
		// Token: 0x0600154D RID: 5453 RVA: 0x0007DF8F File Offset: 0x0007C18F
		protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Streams all the <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> object properties into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object specified for the <see cref="T:System.Runtime.Serialization.StreamingContext" /> object specified.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
		// Token: 0x0600154E RID: 5454 RVA: 0x0007DF99 File Offset: 0x0007C199
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInferenceException" /> class.</summary>
		// Token: 0x0600154F RID: 5455 RVA: 0x0007DFA3 File Offset: 0x0007C1A3
		public XmlSchemaInferenceException() : base(null)
		{
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		internal XmlSchemaInferenceException(string res, string arg) : base(res, new string[]
		{
			arg
		}, null, null, 0, 0, null)
		{
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0007DFC4 File Offset: 0x0007C1C4
		internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) : base(res, null, null, null, lineNumber, linePosition, null)
		{
		}
	}
}
