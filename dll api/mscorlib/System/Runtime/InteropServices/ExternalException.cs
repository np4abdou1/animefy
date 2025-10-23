using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The base exception type for all COM interop exceptions and structured exception handling (SEH) exceptions.</summary>
	// Token: 0x020003F9 RID: 1017
	[Serializable]
	public class ExternalException : SystemException
	{
		/// <summary>Initializes a new instance of the <see langword="ExternalException" /> class with default properties.</summary>
		// Token: 0x06001F1B RID: 7963 RVA: 0x000862EC File Offset: 0x000844EC
		public ExternalException() : base("External component has thrown an exception.")
		{
			base.HResult = -2147467259;
		}

		/// <summary>Initializes a new instance of the <see langword="ExternalException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that specifies the reason for the exception. </param>
		// Token: 0x06001F1C RID: 7964 RVA: 0x00086304 File Offset: 0x00084504
		public ExternalException(string message) : base(message)
		{
			base.HResult = -2147467259;
		}

		/// <summary>Initializes a new instance of the <see langword="ExternalException" /> class with a specified error message and the HRESULT of the error.</summary>
		/// <param name="message">The error message that specifies the reason for the exception. </param>
		/// <param name="errorCode">The HRESULT of the error. </param>
		// Token: 0x06001F1D RID: 7965 RVA: 0x00086318 File Offset: 0x00084518
		public ExternalException(string message, int errorCode) : base(message)
		{
			base.HResult = errorCode;
		}

		/// <summary>Initializes a new instance of the <see langword="ExternalException" /> class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F1E RID: 7966 RVA: 0x0000E339 File Offset: 0x0000C539
		protected ExternalException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Returns a string that contains the HRESULT of the error.</summary>
		/// <returns>A string that represents the HRESULT. </returns>
		// Token: 0x06001F1F RID: 7967 RVA: 0x00086328 File Offset: 0x00084528
		public override string ToString()
		{
			string message = this.Message;
			string text = base.GetType().ToString() + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
			if (!string.IsNullOrEmpty(message))
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
