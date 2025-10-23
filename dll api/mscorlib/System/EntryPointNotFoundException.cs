using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt to load a class fails due to the absence of an entry method.</summary>
	// Token: 0x02000097 RID: 151
	[Serializable]
	public class EntryPointNotFoundException : TypeLoadException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class.</summary>
		// Token: 0x06000532 RID: 1330 RVA: 0x00013A85 File Offset: 0x00011C85
		public EntryPointNotFoundException() : base("Entry point was not found.")
		{
			base.HResult = -2146233053;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06000533 RID: 1331 RVA: 0x00013A9D File Offset: 0x00011C9D
		public EntryPointNotFoundException(string message) : base(message)
		{
			base.HResult = -2146233053;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.EntryPointNotFoundException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000534 RID: 1332 RVA: 0x00013694 File Offset: 0x00011894
		protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
