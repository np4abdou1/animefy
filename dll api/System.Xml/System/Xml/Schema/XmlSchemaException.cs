using System;
using System.Resources;
using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Returns detailed information about the schema exception.</summary>
	// Token: 0x020002EA RID: 746
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		/// <summary>Constructs a new <see langword="XmlSchemaException" /> object with the given <see langword="SerializationInfo" /> and <see langword="StreamingContext" /> information that contains all the properties of the <see langword="XmlSchemaException" />.</summary>
		/// <param name="info">SerializationInfo.</param>
		/// <param name="context">StreamingContext.</param>
		// Token: 0x06001924 RID: 6436 RVA: 0x000979A4 File Offset: 0x00095BA4
		protected XmlSchemaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.res = (string)info.GetValue("res", typeof(string));
			this.args = (string[])info.GetValue("args", typeof(string[]));
			this.sourceUri = (string)info.GetValue("sourceUri", typeof(string));
			this.lineNumber = (int)info.GetValue("lineNumber", typeof(int));
			this.linePosition = (int)info.GetValue("linePosition", typeof(int));
			string text = null;
			foreach (SerializationEntry serializationEntry in info)
			{
				if (serializationEntry.Name == "version")
				{
					text = (string)serializationEntry.Value;
				}
			}
			if (text == null)
			{
				this.message = XmlSchemaException.CreateMessage(this.res, this.args);
				return;
			}
			this.message = null;
		}

		/// <summary>Streams all the <see langword="XmlSchemaException" /> properties into the <see langword="SerializationInfo" /> class for the given <see langword="StreamingContext" />.</summary>
		/// <param name="info">The <see langword="SerializationInfo" />. </param>
		/// <param name="context">The <see langword="StreamingContext" /> information. </param>
		// Token: 0x06001925 RID: 6437 RVA: 0x00097AB8 File Offset: 0x00095CB8
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("res", this.res);
			info.AddValue("args", this.args);
			info.AddValue("sourceUri", this.sourceUri);
			info.AddValue("lineNumber", this.lineNumber);
			info.AddValue("linePosition", this.linePosition);
			info.AddValue("version", "2.0");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class.</summary>
		// Token: 0x06001926 RID: 6438 RVA: 0x0007DFA3 File Offset: 0x0007C1A3
		public XmlSchemaException() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message specified.</summary>
		/// <param name="message">A <see langword="string" /> description of the error condition.</param>
		// Token: 0x06001927 RID: 6439 RVA: 0x00097B32 File Offset: 0x00095D32
		public XmlSchemaException(string message) : this(message, null, 0, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message and original <see cref="T:System.Exception" /> object that caused this exception specified.</summary>
		/// <param name="message">A <see langword="string" /> description of the error condition.</param>
		/// <param name="innerException">The original T:System.Exception object that caused this exception.</param>
		// Token: 0x06001928 RID: 6440 RVA: 0x00097B3E File Offset: 0x00095D3E
		public XmlSchemaException(string message, Exception innerException) : this(message, innerException, 0, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaException" /> class with the exception message specified, and the original <see cref="T:System.Exception" /> object, line number, and line position of the XML that cause this exception specified.</summary>
		/// <param name="message">A <see langword="string" /> description of the error condition.</param>
		/// <param name="innerException">The original T:System.Exception object that caused this exception.</param>
		/// <param name="lineNumber">The line number of the XML that caused this exception.</param>
		/// <param name="linePosition">The line position of the XML that caused this exception.</param>
		// Token: 0x06001929 RID: 6441 RVA: 0x00097B4A File Offset: 0x00095D4A
		public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition) : this((message == null) ? "A schema error occurred." : "{0}", new string[]
		{
			message
		}, innerException, null, lineNumber, linePosition, null)
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00097B71 File Offset: 0x00095D71
		internal XmlSchemaException(string res, string[] args) : this(res, args, null, null, 0, 0, null)
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		internal XmlSchemaException(string res, string arg) : this(res, new string[]
		{
			arg
		}, null, null, 0, 0, null)
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00097B80 File Offset: 0x00095D80
		internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition) : this(res, new string[]
		{
			arg
		}, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00097B9A File Offset: 0x00095D9A
		internal XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition) : this(res, null, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00097BAA File Offset: 0x00095DAA
		internal XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition) : this(res, args, null, sourceUri, lineNumber, linePosition, null)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00097BBB File Offset: 0x00095DBB
		internal XmlSchemaException(string res, XmlSchemaObject source) : this(res, null, source)
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00097BC6 File Offset: 0x00095DC6
		internal XmlSchemaException(string res, string arg, XmlSchemaObject source) : this(res, new string[]
		{
			arg
		}, source)
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00097BDA File Offset: 0x00095DDA
		internal XmlSchemaException(string res, string[] args, XmlSchemaObject source) : this(res, args, null, source.SourceUri, source.LineNumber, source.LinePosition, source)
		{
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00097BF8 File Offset: 0x00095DF8
		internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) : base(XmlSchemaException.CreateMessage(res, args), innerException)
		{
			base.HResult = -2146231999;
			this.res = res;
			this.args = args;
			this.sourceUri = sourceUri;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
			this.sourceSchemaObject = source;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00097C4C File Offset: 0x00095E4C
		internal static string CreateMessage(string res, string[] args)
		{
			string result;
			try
			{
				result = Res.GetString(res, args);
			}
			catch (MissingManifestResourceException)
			{
				result = "UNKNOWN(" + res + ")";
			}
			return result;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00097C8C File Offset: 0x00095E8C
		internal string GetRes
		{
			get
			{
				return this.res;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00097C94 File Offset: 0x00095E94
		internal string[] Args
		{
			get
			{
				return this.args;
			}
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) location of the schema that caused the exception.</summary>
		/// <returns>The URI location of the schema that caused the exception.</returns>
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00097C9C File Offset: 0x00095E9C
		public string SourceUri
		{
			get
			{
				return this.sourceUri;
			}
		}

		/// <summary>Gets the line number indicating where the error occurred.</summary>
		/// <returns>The line number indicating where the error occurred.</returns>
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x00097CA4 File Offset: 0x00095EA4
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		/// <summary>Gets the line position indicating where the error occurred.</summary>
		/// <returns>The line position indicating where the error occurred.</returns>
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00097CAC File Offset: 0x00095EAC
		public int LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		/// <summary>The <see langword="XmlSchemaObject" /> that produced the <see langword="XmlSchemaException" />.</summary>
		/// <returns>A valid object instance represents a structural validation error in the XML Schema Object Model (SOM).</returns>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00097CB4 File Offset: 0x00095EB4
		public XmlSchemaObject SourceSchemaObject
		{
			get
			{
				return this.sourceSchemaObject;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00097CBC File Offset: 0x00095EBC
		internal void SetSource(string sourceUri, int lineNumber, int linePosition)
		{
			this.sourceUri = sourceUri;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00097CD3 File Offset: 0x00095ED3
		internal void SetSchemaObject(XmlSchemaObject source)
		{
			this.sourceSchemaObject = source;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00097CDC File Offset: 0x00095EDC
		internal void SetSource(XmlSchemaObject source)
		{
			this.sourceSchemaObject = source;
			this.sourceUri = source.SourceUri;
			this.lineNumber = source.LineNumber;
			this.linePosition = source.LinePosition;
		}

		/// <summary>Gets the description of the error condition of this exception.</summary>
		/// <returns>The description of the error condition of this exception.</returns>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00097D09 File Offset: 0x00095F09
		public override string Message
		{
			get
			{
				if (this.message != null)
				{
					return this.message;
				}
				return base.Message;
			}
		}

		// Token: 0x040010A5 RID: 4261
		private string res;

		// Token: 0x040010A6 RID: 4262
		private string[] args;

		// Token: 0x040010A7 RID: 4263
		private string sourceUri;

		// Token: 0x040010A8 RID: 4264
		private int lineNumber;

		// Token: 0x040010A9 RID: 4265
		private int linePosition;

		// Token: 0x040010AA RID: 4266
		[NonSerialized]
		private XmlSchemaObject sourceSchemaObject;

		// Token: 0x040010AB RID: 4267
		private string message;
	}
}
