using System;
using System.Runtime.Serialization;

namespace System.Security
{
	/// <summary>The exception that is thrown when there is a syntax error in XML parsing. This class cannot be inherited.</summary>
	// Token: 0x02000279 RID: 633
	[Serializable]
	public sealed class XmlSyntaxException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with default properties.</summary>
		// Token: 0x0600163A RID: 5690 RVA: 0x0005B170 File Offset: 0x00059370
		public XmlSyntaxException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with the line number where the exception was detected.</summary>
		/// <param name="lineNumber">The line number of the XML stream where the XML syntax error was detected. </param>
		// Token: 0x0600163B RID: 5691 RVA: 0x0005B170 File Offset: 0x00059370
		public XmlSyntaxException(int lineNumber)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with a specified error message and the line number where the exception was detected.</summary>
		/// <param name="lineNumber">The line number of the XML stream where the XML syntax error was detected. </param>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x0600163C RID: 5692 RVA: 0x0005B170 File Offset: 0x00059370
		public XmlSyntaxException(int lineNumber, string message)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0000E339 File Offset: 0x0000C539
		private XmlSyntaxException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
