using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when part of a file or directory cannot be found.</summary>
	// Token: 0x02000521 RID: 1313
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryNotFoundException" /> class with its message string set to a system-supplied message and its HRESULT set to COR_E_DIRECTORYNOTFOUND.</summary>
		// Token: 0x060026C4 RID: 9924 RVA: 0x0009AD94 File Offset: 0x00098F94
		public DirectoryNotFoundException() : base("Attempted to access a path that is not on the disk.")
		{
			base.HResult = -2147024893;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryNotFoundException" /> class with its message string set to <paramref name="message" /> and its HRESULT set to COR_E_DIRECTORYNOTFOUND.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x060026C5 RID: 9925 RVA: 0x0009ADAC File Offset: 0x00098FAC
		public DirectoryNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryNotFoundException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060026C6 RID: 9926 RVA: 0x0009ADC0 File Offset: 0x00098FC0
		protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
