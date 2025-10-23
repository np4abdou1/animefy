using System;
using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the exception thrown when XML Schema Definition Language (XSD) schema validation errors and warnings are encountered in an XML document being validated. </summary>
	// Token: 0x02000323 RID: 803
	[Serializable]
	public class XmlSchemaValidationException : XmlSchemaException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects specified.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object.</param>
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0007DF8F File Offset: 0x0007C18F
		protected XmlSchemaValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Constructs a new <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> object with the given <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> information that contains all the properties of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" />.</summary>
		/// <param name="info">
		///       <see cref="T:System.Runtime.Serialization.SerializationInfo" />
		///     </param>
		/// <param name="context">
		///       <see cref="T:System.Runtime.Serialization.StreamingContext" />
		///     </param>
		// Token: 0x06001AA2 RID: 6818 RVA: 0x0007DF99 File Offset: 0x0007C199
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaValidationException" /> class.</summary>
		// Token: 0x06001AA3 RID: 6819 RVA: 0x0007DFA3 File Offset: 0x0007C1A3
		public XmlSchemaValidationException() : base(null)
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00097B80 File Offset: 0x00095D80
		internal XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition) : base(res, new string[]
		{
			arg
		}, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00097BAA File Offset: 0x00095DAA
		internal XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) : base(res, args, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0009AF47 File Offset: 0x00099147
		internal XmlSchemaValidationException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) : base(res, args, innerException, sourceUri, lineNumber, linePosition, null)
		{
		}
	}
}
