using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>The exception that is thrown when trying to access a drive or share that is not available.</summary>
	// Token: 0x02000540 RID: 1344
	[Serializable]
	public class DriveNotFoundException : IOException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with its message string set to a system-supplied message and its HRESULT set to COR_E_DIRECTORYNOTFOUND. </summary>
		// Token: 0x060027CA RID: 10186 RVA: 0x0009F736 File Offset: 0x0009D936
		public DriveNotFoundException() : base("Could not find the drive. The drive might not be ready or might not be mapped.")
		{
			base.HResult = -2147024893;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with the specified message string and the HRESULT set to COR_E_DIRECTORYNOTFOUND. </summary>
		/// <param name="message">A <see cref="T:System.String" /> object that describes the error. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
		// Token: 0x060027CB RID: 10187 RVA: 0x0009ADAC File Offset: 0x00098FAC
		public DriveNotFoundException(string message) : base(message)
		{
			base.HResult = -2147024893;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.DriveNotFoundException" /> class with the specified serialization and context information. </summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that contains the serialized object data about the exception being thrown. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination of the exception being thrown. </param>
		// Token: 0x060027CC RID: 10188 RVA: 0x0009ADC0 File Offset: 0x00098FC0
		protected DriveNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
