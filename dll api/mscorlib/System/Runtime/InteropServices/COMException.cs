using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception that is thrown when an unrecognized HRESULT is returned from a COM method call.</summary>
	// Token: 0x020003FE RID: 1022
	[Serializable]
	public class COMException : ExternalException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with default values.</summary>
		// Token: 0x06001F2E RID: 7982 RVA: 0x000865A5 File Offset: 0x000847A5
		public COMException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified message.</summary>
		/// <param name="message">The message that indicates the reason for the exception. </param>
		// Token: 0x06001F2F RID: 7983 RVA: 0x000865AD File Offset: 0x000847AD
		public COMException(string message) : base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class with a specified message and error code.</summary>
		/// <param name="message">The message that indicates the reason the exception occurred. </param>
		/// <param name="errorCode">The error code (HRESULT) value associated with this exception. </param>
		// Token: 0x06001F30 RID: 7984 RVA: 0x000865B6 File Offset: 0x000847B6
		public COMException(string message, int errorCode) : base(message)
		{
			base.HResult = errorCode;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.COMException" /> class from serialization data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that supplies the contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F31 RID: 7985 RVA: 0x000865C6 File Offset: 0x000847C6
		protected COMException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Converts the contents of the exception to a string.</summary>
		/// <returns>A string containing the <see cref="P:System.Exception.HResult" />, <see cref="P:System.Exception.Message" />, <see cref="P:System.Exception.InnerException" />, and <see cref="P:System.Exception.StackTrace" /> properties of the exception.</returns>
		// Token: 0x06001F32 RID: 7986 RVA: 0x000865D0 File Offset: 0x000847D0
		public override string ToString()
		{
			string message = this.Message;
			string text = base.GetType().ToString() + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
			if (message != null && message.Length > 0)
			{
				text = text + ": " + message;
			}
			Exception innerException = base.InnerException;
			if (innerException != null)
			{
				text = text + " ---> " + innerException.ToString();
			}
			if (this.StackTrace != null)
			{
				text = text + Environment.NewLine + this.StackTrace;
			}
			return text;
		}
	}
}
