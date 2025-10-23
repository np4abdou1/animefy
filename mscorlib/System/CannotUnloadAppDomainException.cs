using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt to unload an application domain fails.</summary>
	// Token: 0x02000127 RID: 295
	[Serializable]
	public class CannotUnloadAppDomainException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class.</summary>
		// Token: 0x06000B79 RID: 2937 RVA: 0x0002FC3F File Offset: 0x0002DE3F
		public CannotUnloadAppDomainException() : base("Attempt to unload the AppDomain failed.")
		{
			base.HResult = -2146234347;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000B7A RID: 2938 RVA: 0x0002FC57 File Offset: 0x0002DE57
		public CannotUnloadAppDomainException(string message) : base(message)
		{
			base.HResult = -2146234347;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CannotUnloadAppDomainException" /> class from serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000B7B RID: 2939 RVA: 0x0000E339 File Offset: 0x0000C539
		protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
