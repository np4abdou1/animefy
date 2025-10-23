using System;
using System.IO;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when the file image of a dynamic link library (DLL) or an executable program is invalid. </summary>
	// Token: 0x02000084 RID: 132
	[Serializable]
	public class BadImageFormatException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class.</summary>
		// Token: 0x060002C8 RID: 712 RVA: 0x0000ED76 File Offset: 0x0000CF76
		public BadImageFormatException() : base("Format of the executable (.exe) or library (.dll) is invalid.")
		{
			base.HResult = -2147024885;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x060002C9 RID: 713 RVA: 0x0000ED8E File Offset: 0x0000CF8E
		public BadImageFormatException(string message) : base(message)
		{
			base.HResult = -2147024885;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with a specified error message and file name.</summary>
		/// <param name="message">A message that describes the error. </param>
		/// <param name="fileName">The full name of the file with the invalid image. </param>
		// Token: 0x060002CA RID: 714 RVA: 0x0000EDA2 File Offset: 0x0000CFA2
		public BadImageFormatException(string message, string fileName) : base(message)
		{
			base.HResult = -2147024885;
			this._fileName = fileName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.BadImageFormatException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060002CB RID: 715 RVA: 0x0000EDBD File Offset: 0x0000CFBD
		protected BadImageFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._fileName = info.GetString("BadImageFormat_FileName");
			this._fusionLog = info.GetString("BadImageFormat_FusionLog");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name, assembly cache log, and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x060002CC RID: 716 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("BadImageFormat_FileName", this._fileName, typeof(string));
			info.AddValue("BadImageFormat_FusionLog", this._fusionLog, typeof(string));
		}

		/// <summary>Gets the error message and the name of the file that caused this exception.</summary>
		/// <returns>A string containing the error message and the name of the file that caused this exception.</returns>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000EE29 File Offset: 0x0000D029
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000EE38 File Offset: 0x0000D038
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this._fileName == null && base.HResult == -2146233088)
				{
					this._message = "Format of the executable (.exe) or library (.dll) is invalid.";
					return;
				}
				this._message = FileLoadException.FormatFileLoadExceptionMessage(this._fileName, base.HResult);
			}
		}

		/// <summary>Returns the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</summary>
		/// <returns>A string containing the fully qualified name of this exception and possibly the error message, the name of the inner exception, and the stack trace.</returns>
		// Token: 0x060002CF RID: 719 RVA: 0x0000EE88 File Offset: 0x0000D088
		public override string ToString()
		{
			string text = base.GetType().ToString() + ": " + this.Message;
			if (this._fileName != null && this._fileName.Length != 0)
			{
				text = text + Environment.NewLine + SR.Format("File name: '{0}'", this._fileName);
			}
			if (base.InnerException != null)
			{
				text = text + " ---> " + base.InnerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			if (this._fusionLog != null)
			{
				if (text == null)
				{
					text = " ";
				}
				text += Environment.NewLine;
				text += Environment.NewLine;
				text += this._fusionLog;
			}
			return text;
		}

		// Token: 0x040001C9 RID: 457
		private string _fileName;

		// Token: 0x040001CA RID: 458
		private string _fusionLog;
	}
}
