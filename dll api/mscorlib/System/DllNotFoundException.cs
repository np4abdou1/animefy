using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a DLL specified in a DLL import cannot be found.</summary>
	// Token: 0x02000094 RID: 148
	[Serializable]
	public class DllNotFoundException : TypeLoadException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with default properties.</summary>
		// Token: 0x06000508 RID: 1288 RVA: 0x00013668 File Offset: 0x00011868
		public DllNotFoundException() : base("Dll was not found.")
		{
			base.HResult = -2146233052;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06000509 RID: 1289 RVA: 0x00013680 File Offset: 0x00011880
		public DllNotFoundException(string message) : base(message)
		{
			base.HResult = -2146233052;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DllNotFoundException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x0600050A RID: 1290 RVA: 0x00013694 File Offset: 0x00011894
		protected DllNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
