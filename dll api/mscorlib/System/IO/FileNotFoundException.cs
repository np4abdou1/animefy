using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when an attempt to access a file that does not exist on disk fails.</summary>
	// Token: 0x02000527 RID: 1319
	[Serializable]
	public class FileNotFoundException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with its message string set to a system-supplied message and its HRESULT set to COR_E_FILENOTFOUND.</summary>
		// Token: 0x060026D7 RID: 9943 RVA: 0x0009AFD8 File Offset: 0x000991D8
		public FileNotFoundException() : base("Unable to find the specified file.")
		{
			base.HResult = -2147024894;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with its message string set to <paramref name="message" /> and its HRESULT set to COR_E_FILENOTFOUND.</summary>
		/// <param name="message">A description of the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x060026D8 RID: 9944 RVA: 0x0009AFF0 File Offset: 0x000991F0
		public FileNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024894;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with its message string set to <paramref name="message" />, specifying the file name that cannot be found, and its HRESULT set to COR_E_FILENOTFOUND.</summary>
		/// <param name="message">A description of the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		/// <param name="fileName">The full name of the file with the invalid image. </param>
		// Token: 0x060026D9 RID: 9945 RVA: 0x0009B004 File Offset: 0x00099204
		public FileNotFoundException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024894;
			this.FileName = fileName;
		}

		/// <summary>Gets the error message that explains the reason for the exception.</summary>
		/// <returns>The error message.</returns>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x0009B01F File Offset: 0x0009921F
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0009B030 File Offset: 0x00099230
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.FileName == null && base.HResult == -2146233088)
				{
					this._message = "Unable to find the specified file.";
					return;
				}
				if (this.FileName != null)
				{
					this._message = FileLoadException.FormatFileLoadExceptionMessage(this.FileName, base.HResult);
				}
			}
		}

		/// <summary>Gets the name of the file that cannot be found.</summary>
		/// <returns>The name of the file, or <see langword="null" /> if no file name was passed to the constructor for this instance.</returns>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x0009B085 File Offset: 0x00099285
		public string FileName { get; }

		/// <summary>Gets the log file that describes why loading of an assembly failed.</summary>
		/// <returns>The errors reported by the assembly cache.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0009B08D File Offset: 0x0009928D
		public string FusionLog { get; }

		/// <summary>Returns the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</summary>
		/// <returns>The fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</returns>
		// Token: 0x060026DE RID: 9950 RVA: 0x0009B098 File Offset: 0x00099298
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

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.FileNotFoundException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">An object that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">An object that contains contextual information about the source or destination.</param>
		// Token: 0x060026DF RID: 9951 RVA: 0x0009B162 File Offset: 0x00099362
		protected FileNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.FileName = info.GetString("FileNotFound_FileName");
			this.FusionLog = info.GetString("FileNotFound_FusionLog");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The object that contains contextual information about the source or destination. </param>
		// Token: 0x060026E0 RID: 9952 RVA: 0x0009B18E File Offset: 0x0009938E
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("FileNotFound_FileName", this.FileName, typeof(string));
			info.AddValue("FileNotFound_FusionLog", this.FusionLog, typeof(string));
		}
	}
}
