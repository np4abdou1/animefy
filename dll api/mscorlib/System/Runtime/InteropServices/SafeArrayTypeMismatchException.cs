using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception thrown when the type of the incoming <see langword="SAFEARRAY" /> does not match the type specified in the managed signature.</summary>
	// Token: 0x02000402 RID: 1026
	[Serializable]
	public class SafeArrayTypeMismatchException : SystemException
	{
		/// <summary>Initializes a new instance of the <see langword="SafeArrayTypeMismatchException" /> class with default values.</summary>
		// Token: 0x06001F3D RID: 7997 RVA: 0x000866AB File Offset: 0x000848AB
		public SafeArrayTypeMismatchException() : base("Specified array was not of the expected type.")
		{
			base.HResult = -2146233037;
		}

		/// <summary>Initializes a new instance of the <see langword="SafeArrayTypeMismatchException" /> class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06001F3E RID: 7998 RVA: 0x0000E339 File Offset: 0x0000C539
		protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
