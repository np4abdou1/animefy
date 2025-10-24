using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.Win32;

namespace System.Security.Cryptography
{
	/// <summary>The exception that is thrown when an error occurs during a cryptographic operation.</summary>
	// Token: 0x020002AA RID: 682
	[ComVisible(true)]
	[Serializable]
	public class CryptographicException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with default properties.</summary>
		// Token: 0x0600171F RID: 5919 RVA: 0x0005F7AF File Offset: 0x0005D9AF
		public CryptographicException() : base(Environment.GetResourceString("Error occurred during a cryptographic operation."))
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06001720 RID: 5920 RVA: 0x0005F7CC File Offset: 0x0005D9CC
		public CryptographicException(string message) : base(message)
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message in the specified format.</summary>
		/// <param name="format">The format used to output the error message. </param>
		/// <param name="insert">The error message that explains the reason for the exception. </param>
		// Token: 0x06001721 RID: 5921 RVA: 0x0005F7E0 File Offset: 0x0005D9E0
		public CryptographicException(string format, string insert) : base(string.Format(CultureInfo.CurrentCulture, format, insert))
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06001722 RID: 5922 RVA: 0x0005F7FF File Offset: 0x0005D9FF
		public CryptographicException(string message, Exception inner) : base(message, inner)
		{
			base.SetErrorCode(-2146233296);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with the specified <see langword="HRESULT" /> error code.</summary>
		/// <param name="hr">The <see langword="HRESULT" /> error code. </param>
		// Token: 0x06001723 RID: 5923 RVA: 0x0005F814 File Offset: 0x0005DA14
		[SecuritySafeCritical]
		public CryptographicException(int hr) : this(Win32Native.GetMessage(hr))
		{
			if (((long)hr & (long)((ulong)-2147483648)) != (long)((ulong)-2147483648))
			{
				hr = ((hr & 65535) | -2147024896);
			}
			base.SetErrorCode(hr);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.CryptographicException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06001724 RID: 5924 RVA: 0x0000E339 File Offset: 0x0000C539
		protected CryptographicException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
