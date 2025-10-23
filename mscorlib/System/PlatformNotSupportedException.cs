using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a feature does not run on a particular platform.</summary>
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with default properties.</summary>
		// Token: 0x060007CF RID: 1999 RVA: 0x00023682 File Offset: 0x00021882
		public PlatformNotSupportedException() : base("Operation is not supported on this platform.")
		{
			base.HResult = -2146233031;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with a specified error message.</summary>
		/// <param name="message">The text message that explains the reason for the exception. </param>
		// Token: 0x060007D0 RID: 2000 RVA: 0x0002369A File Offset: 0x0002189A
		public PlatformNotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233031;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.PlatformNotSupportedException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060007D1 RID: 2001 RVA: 0x000236AE File Offset: 0x000218AE
		protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
