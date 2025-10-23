using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Net.Sockets
{
	/// <summary>The exception that is thrown when a socket error occurs.</summary>
	// Token: 0x02000206 RID: 518
	[Serializable]
	public class SocketException : Win32Exception
	{
		// Token: 0x06000E61 RID: 3681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int WSAGetLastError_icall();

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the last operating system error code.</summary>
		// Token: 0x06000E62 RID: 3682 RVA: 0x0004AE8D File Offset: 0x0004908D
		public SocketException() : base(SocketException.WSAGetLastError_icall())
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004AE9A File Offset: 0x0004909A
		internal SocketException(int error, string message) : base(error, message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class with the specified error code.</summary>
		/// <param name="errorCode">The error code that indicates the error that occurred. </param>
		// Token: 0x06000E64 RID: 3684 RVA: 0x0004AEA4 File Offset: 0x000490A4
		public SocketException(int errorCode) : base(errorCode)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0004AEA4 File Offset: 0x000490A4
		internal SocketException(SocketError socketError) : base((int)socketError)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.SocketException" /> class from the specified instances of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> classes.</summary>
		/// <param name="serializationInfo">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> instance that contains the information that is required to serialize the new <see cref="T:System.Net.Sockets.SocketException" /> instance. </param>
		/// <param name="streamingContext">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains the source of the serialized stream that is associated with the new <see cref="T:System.Net.Sockets.SocketException" /> instance. </param>
		// Token: 0x06000E66 RID: 3686 RVA: 0x000467A1 File Offset: 0x000449A1
		protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Gets the error message that is associated with this exception.</summary>
		/// <returns>A string that contains the error message. </returns>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0004AEAD File Offset: 0x000490AD
		public override string Message
		{
			get
			{
				if (this.m_EndPoint == null)
				{
					return base.Message;
				}
				return base.Message + " " + this.m_EndPoint.ToString();
			}
		}

		/// <summary>Gets the error code that is associated with this exception.</summary>
		/// <returns>An integer error code that is associated with this exception.</returns>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0004AED9 File Offset: 0x000490D9
		public SocketError SocketErrorCode
		{
			get
			{
				return (SocketError)base.NativeErrorCode;
			}
		}

		// Token: 0x04000A97 RID: 2711
		[NonSerialized]
		private EndPoint m_EndPoint;
	}
}
