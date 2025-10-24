using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	/// <summary>The exception thrown when using invalid arguments that are enumerators.</summary>
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> class without a message.</summary>
		// Token: 0x06000FAF RID: 4015 RVA: 0x0004D6CB File Offset: 0x0004B8CB
		public InvalidEnumArgumentException() : this(null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> class with the specified message.</summary>
		/// <param name="message">The message to display with this exception. </param>
		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004D6D4 File Offset: 0x0004B8D4
		public InvalidEnumArgumentException(string message) : base(message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> class using the specified serialization data and context.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to be used for deserialization.</param>
		/// <param name="context">The destination to be used for deserialization.</param>
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004D6DD File Offset: 0x0004B8DD
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
