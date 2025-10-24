using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when a managed assembly is found but cannot be loaded.</summary>
	// Token: 0x02000525 RID: 1317
	[Serializable]
	public class FileLoadException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class, setting the <see cref="P:System.Exception.Message" /> property of the new instance to a system-supplied message that describes the error, such as "Could not load the specified file." This message takes into account the current system culture.</summary>
		// Token: 0x060026CE RID: 9934 RVA: 0x0009AE27 File Offset: 0x00099027
		public FileLoadException() : base("Could not load the specified file.")
		{
			base.HResult = -2146232799;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class with the specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x060026CF RID: 9935 RVA: 0x0009AE3F File Offset: 0x0009903F
		public FileLoadException(string message) : base(message)
		{
			base.HResult = -2146232799;
		}

		/// <summary>Gets the error message and the name of the file that caused this exception.</summary>
		/// <returns>A string containing the error message and the name of the file that caused this exception.</returns>
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0009AE53 File Offset: 0x00099053
		public override string Message
		{
			get
			{
				if (this._message == null)
				{
					this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult);
				}
				return this._message;
			}
		}

		/// <summary>Gets the name of the file that causes this exception.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the file with the invalid image, or a null reference if no file name was passed to the constructor for the current instance.</returns>
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x0009AE7A File Offset: 0x0009907A
		public string FileName { get; }

		/// <summary>Gets the log file that describes why an assembly load failed.</summary>
		/// <returns>A string containing errors reported by the assembly cache.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x0009AE82 File Offset: 0x00099082
		public string FusionLog { get; }

		/// <summary>Returns the fully qualified name of the current exception, and possibly the error message, the name of the inner exception, and the stack trace.</summary>
		/// <returns>A string containing the fully qualified name of this exception, and possibly the error message, the name of the inner exception, and the stack trace, depending on which <see cref="T:System.IO.FileLoadException" /> constructor is used.</returns>
		// Token: 0x060026D3 RID: 9939 RVA: 0x0009AE8C File Offset: 0x0009908C
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (this.FileName != null && this.FileName.Length != 0)
			{
				text = text + Environment.NewLine + SR.Format("File name: '{0}'", this.FileName);
			}
			if (base.InnerException != null)
			{
				text = text + " ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			if (this.FusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text += Environment.NewLine;
				text += Environment.NewLine;
				text += this.FusionLog;
			}
			return text;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileLoadException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060026D4 RID: 9940 RVA: 0x0009AF56 File Offset: 0x00099156
		protected FileLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileLoad_FileName");
			this.FusionLog = info.GetString("FileLoad_FusionLog");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the file name and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x060026D5 RID: 9941 RVA: 0x0009AF82 File Offset: 0x00099182
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileLoad_FileName", this.FileName, typeof(string));
			info.AddValue("FileLoad_FusionLog", this.FusionLog, typeof(string));
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0009AFC2 File Offset: 0x000991C2
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			if (fileName != null)
			{
				return SR.Format("Could not load the file '{0}'.", fileName);
			}
			return "Could not load the specified file.";
		}
	}
}
