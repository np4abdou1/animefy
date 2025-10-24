using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	/// <summary>The exception that is thrown when an error occurs while retrieving network information.</summary>
	// Token: 0x020001EB RID: 491
	[Serializable]
	public class NetworkInformationException : Win32Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class.</summary>
		// Token: 0x06000D57 RID: 3415 RVA: 0x00046794 File Offset: 0x00044994
		public NetworkInformationException() : base(Marshal.GetLastWin32Error())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkInformation.NetworkInformationException" /> class with serialized data.</summary>
		/// <param name="serializationInfo">A SerializationInfo object that contains the serialized exception data. </param>
		/// <param name="streamingContext">A StreamingContext that contains contextual information about the serialized exception. </param>
		// Token: 0x06000D58 RID: 3416 RVA: 0x000467A1 File Offset: 0x000449A1
		protected NetworkInformationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}
	}
}
