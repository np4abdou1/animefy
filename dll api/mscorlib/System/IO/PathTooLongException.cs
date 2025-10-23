using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when a path or fully qualified file name is longer than the system-defined maximum length.</summary>
	// Token: 0x0200052D RID: 1325
	[Serializable]
	public class PathTooLongException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.PathTooLongException" /> class with its HRESULT set to COR_E_PATHTOOLONG.</summary>
		// Token: 0x06002718 RID: 10008 RVA: 0x0009C118 File Offset: 0x0009A318
		public PathTooLongException() : base("The specified file name or path is too long, or a component of the specified path is too long.")
		{
			base.HResult = -2147024690;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.PathTooLongException" /> class with its message string set to <paramref name="message" /> and its HRESULT set to COR_E_PATHTOOLONG.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. The content of <paramref name="message" /> is intended to be understood by humans. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		// Token: 0x06002719 RID: 10009 RVA: 0x0009C130 File Offset: 0x0009A330
		public PathTooLongException(string message) : base(message)
		{
			base.HResult = -2147024690;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.PathTooLongException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x0600271A RID: 10010 RVA: 0x0009ADC0 File Offset: 0x00098FC0
		protected PathTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
