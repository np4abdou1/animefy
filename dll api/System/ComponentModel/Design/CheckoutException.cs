using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel.Design
{
	/// <summary>The exception that is thrown when an attempt to check out a file that is checked into a source code management program is canceled or fails.</summary>
	// Token: 0x020002B5 RID: 693
	[Serializable]
	public class CheckoutException : ExternalException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class with no associated message or error code.</summary>
		// Token: 0x06001294 RID: 4756 RVA: 0x0005936C File Offset: 0x0005756C
		public CheckoutException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class with the specified message and error code.</summary>
		/// <param name="message">A message describing the exception. </param>
		/// <param name="errorCode">The error code to pass. </param>
		// Token: 0x06001295 RID: 4757 RVA: 0x00059374 File Offset: 0x00057574
		public CheckoutException(string message, int errorCode) : base(message, errorCode)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class using the specified serialization data and context. </summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used for deserialization.</param>
		/// <param name="context">The destination to be used for deserialization.</param>
		// Token: 0x06001296 RID: 4758 RVA: 0x0005937E File Offset: 0x0005757E
		protected CheckoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.CheckoutException" /> class that specifies that the check out was canceled. This field is read-only.</summary>
		// Token: 0x04000D0B RID: 3339
		public static readonly CheckoutException Canceled = new CheckoutException("The checkout was canceled by the user.", -2147467260);
	}
}
