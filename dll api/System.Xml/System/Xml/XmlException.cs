using System;
using System.Globalization;
using System.Resources;
using System.Runtime.Serialization;

namespace System.Xml
{
	/// <summary>Returns detailed information about the last exception.</summary>
	// Token: 0x020001B3 RID: 435
	[Serializable]
	public class XmlException : SystemException
	{
		/// <summary>Initializes a new instance of the <see langword="XmlException" /> class using the information in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
		/// <param name="info">The <see langword="SerializationInfo" /> object containing all the properties of an <see langword="XmlException" />. </param>
		/// <param name="context">The <see langword="StreamingContext" /> object containing the context information. </param>
		// Token: 0x06000EF0 RID: 3824 RVA: 0x00060F40 File Offset: 0x0005F140
		protected XmlException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.res = (string)info.GetValue("res", typeof(string));
			this.args = (string[])info.GetValue("args", typeof(string[]));
			this.lineNumber = (int)info.GetValue("lineNumber", typeof(int));
			this.linePosition = (int)info.GetValue("linePosition", typeof(int));
			this.sourceUri = string.Empty;
			string text = null;
			foreach (SerializationEntry serializationEntry in info)
			{
				string name = serializationEntry.Name;
				if (!(name == "sourceUri"))
				{
					if (name == "version")
					{
						text = (string)serializationEntry.Value;
					}
				}
				else
				{
					this.sourceUri = (string)serializationEntry.Value;
				}
			}
			if (text == null)
			{
				this.message = XmlException.CreateMessage(this.res, this.args, this.lineNumber, this.linePosition);
				return;
			}
			this.message = null;
		}

		/// <summary>Streams all the <see langword="XmlException" /> properties into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class for the given <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The <see langword="SerializationInfo" /> object. </param>
		/// <param name="context">The <see langword="StreamingContext" /> object. </param>
		// Token: 0x06000EF1 RID: 3825 RVA: 0x00061070 File Offset: 0x0005F270
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("res", this.res);
			info.AddValue("args", this.args);
			info.AddValue("lineNumber", this.lineNumber);
			info.AddValue("linePosition", this.linePosition);
			info.AddValue("sourceUri", this.sourceUri);
			info.AddValue("version", "2.0");
		}

		/// <summary>Initializes a new instance of the <see langword="XmlException" /> class.</summary>
		// Token: 0x06000EF2 RID: 3826 RVA: 0x000610EA File Offset: 0x0005F2EA
		public XmlException() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlException" /> class with a specified error message.</summary>
		/// <param name="message">The error description. </param>
		// Token: 0x06000EF3 RID: 3827 RVA: 0x000610F3 File Offset: 0x0005F2F3
		public XmlException(string message) : this(message, null, 0, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlException" /> class.</summary>
		/// <param name="message">The description of the error condition. </param>
		/// <param name="innerException">The <see cref="T:System.Exception" /> that threw the <see langword="XmlException" />, if any. This value can be <see langword="null" />. </param>
		// Token: 0x06000EF4 RID: 3828 RVA: 0x000610FF File Offset: 0x0005F2FF
		public XmlException(string message, Exception innerException) : this(message, innerException, 0, 0)
		{
		}

		/// <summary>Initializes a new instance of the <see langword="XmlException" /> class with the specified message, inner exception, line number, and line position.</summary>
		/// <param name="message">The error description. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. This value can be <see langword="null" />. </param>
		/// <param name="lineNumber">The line number indicating where the error occurred. </param>
		/// <param name="linePosition">The line position indicating where the error occurred. </param>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0006110B File Offset: 0x0005F30B
		public XmlException(string message, Exception innerException, int lineNumber, int linePosition) : this(message, innerException, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0006111C File Offset: 0x0005F31C
		internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) : base(XmlException.FormatUserMessage(message, lineNumber, linePosition), innerException)
		{
			base.HResult = -2146232000;
			this.res = ((message == null) ? "An XML error has occurred." : "{0}");
			this.args = new string[]
			{
				message
			};
			this.sourceUri = sourceUri;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00061180 File Offset: 0x0005F380
		internal XmlException(string res, string[] args) : this(res, args, null, 0, 0, null)
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0006118E File Offset: 0x0005F38E
		internal XmlException(string res, string arg) : this(res, new string[]
		{
			arg
		}, null, 0, 0, null)
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000611A5 File Offset: 0x0005F3A5
		internal XmlException(string res, string arg, string sourceUri) : this(res, new string[]
		{
			arg
		}, null, 0, 0, sourceUri)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000611BC File Offset: 0x0005F3BC
		internal XmlException(string res, string arg, IXmlLineInfo lineInfo) : this(res, new string[]
		{
			arg
		}, lineInfo, null)
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000611D1 File Offset: 0x0005F3D1
		internal XmlException(string res, string[] args, IXmlLineInfo lineInfo) : this(res, args, lineInfo, null)
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000611DD File Offset: 0x0005F3DD
		internal XmlException(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) : this(res, args, null, (lineInfo == null) ? 0 : lineInfo.LineNumber, (lineInfo == null) ? 0 : lineInfo.LinePosition, sourceUri)
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00061202 File Offset: 0x0005F402
		internal XmlException(string res, string arg, int lineNumber, int linePosition) : this(res, new string[]
		{
			arg
		}, null, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0006121A File Offset: 0x0005F41A
		internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri) : this(res, new string[]
		{
			arg
		}, null, lineNumber, linePosition, sourceUri)
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00061233 File Offset: 0x0005F433
		internal XmlException(string res, string[] args, int lineNumber, int linePosition) : this(res, args, null, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00061242 File Offset: 0x0005F442
		internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri) : this(res, args, null, lineNumber, linePosition, sourceUri)
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00061252 File Offset: 0x0005F452
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition) : this(res, args, innerException, lineNumber, linePosition, null)
		{
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00061264 File Offset: 0x0005F464
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) : base(XmlException.CreateMessage(res, args, lineNumber, linePosition), innerException)
		{
			base.HResult = -2146232000;
			this.res = res;
			this.args = args;
			this.sourceUri = sourceUri;
			this.lineNumber = lineNumber;
			this.linePosition = linePosition;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000612B4 File Offset: 0x0005F4B4
		private static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			if (message == null)
			{
				return XmlException.CreateMessage("An XML error has occurred.", null, lineNumber, linePosition);
			}
			if (lineNumber == 0 && linePosition == 0)
			{
				return message;
			}
			return XmlException.CreateMessage("{0}", new string[]
			{
				message
			}, lineNumber, linePosition);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000612E8 File Offset: 0x0005F4E8
		private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
		{
			string result;
			try
			{
				string @string;
				if (lineNumber == 0)
				{
					@string = Res.GetString(res, args);
				}
				else
				{
					string text = lineNumber.ToString(CultureInfo.InvariantCulture);
					string text2 = linePosition.ToString(CultureInfo.InvariantCulture);
					@string = Res.GetString(res, args);
					string name = "{0} Line {1}, position {2}.";
					object[] array = new string[]
					{
						@string,
						text,
						text2
					};
					@string = Res.GetString(name, array);
				}
				result = @string;
			}
			catch (MissingManifestResourceException)
			{
				result = "UNKNOWN(" + res + ")";
			}
			return result;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00061374 File Offset: 0x0005F574
		internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
		{
			return XmlException.BuildCharExceptionArgs(data[invCharIndex], (invCharIndex + 1 < data.Length) ? data[invCharIndex + 1] : '\0');
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00061399 File Offset: 0x0005F599
		internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
		{
			return XmlException.BuildCharExceptionArgs(data[invCharIndex], (invCharIndex + 1 < length) ? data[invCharIndex + 1] : '\0');
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000613B4 File Offset: 0x0005F5B4
		internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
		{
			string[] array = new string[2];
			if (XmlCharType.IsHighSurrogate((int)invChar) && nextChar != '\0')
			{
				int num = XmlCharType.CombineSurrogateChar((int)nextChar, (int)invChar);
				array[0] = new string(new char[]
				{
					invChar,
					nextChar
				});
				array[1] = string.Format(CultureInfo.InvariantCulture, "0x{0:X2}", num);
			}
			else
			{
				if (invChar == '\0')
				{
					array[0] = ".";
				}
				else
				{
					array[0] = invChar.ToString(CultureInfo.InvariantCulture);
				}
				array[1] = string.Format(CultureInfo.InvariantCulture, "0x{0:X2}", (int)invChar);
			}
			return array;
		}

		/// <summary>Gets the line number indicating where the error occurred.</summary>
		/// <returns>The line number indicating where the error occurred.</returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x00061440 File Offset: 0x0005F640
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		/// <summary>Gets the line position indicating where the error occurred.</summary>
		/// <returns>The line position indicating where the error occurred.</returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00061448 File Offset: 0x0005F648
		public int LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		/// <summary>Gets a message describing the current exception.</summary>
		/// <returns>The error message that explains the reason for the exception.</returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00061450 File Offset: 0x0005F650
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00061467 File Offset: 0x0005F667
		internal string ResString
		{
			get
			{
				return this.res;
			}
		}

		// Token: 0x04000ABD RID: 2749
		private string res;

		// Token: 0x04000ABE RID: 2750
		private string[] args;

		// Token: 0x04000ABF RID: 2751
		private int lineNumber;

		// Token: 0x04000AC0 RID: 2752
		private int linePosition;

		// Token: 0x04000AC1 RID: 2753
		[OptionalField]
		private string sourceUri;

		// Token: 0x04000AC2 RID: 2754
		private string message;
	}
}
