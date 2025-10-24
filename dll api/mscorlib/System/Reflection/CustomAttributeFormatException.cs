using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown when the binary format of a custom attribute is invalid.</summary>
	// Token: 0x02000495 RID: 1173
	[Serializable]
	public class CustomAttributeFormatException : FormatException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with the default properties.</summary>
		// Token: 0x060020E0 RID: 8416 RVA: 0x00089B4F File Offset: 0x00087D4F
		public CustomAttributeFormatException() : this("Binary format of the specified custom attribute was invalid.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with the specified message.</summary>
		/// <param name="message">The message that indicates the reason this exception was thrown. </param>
		// Token: 0x060020E1 RID: 8417 RVA: 0x00089B5C File Offset: 0x00087D5C
		public CustomAttributeFormatException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x060020E2 RID: 8418 RVA: 0x00089B66 File Offset: 0x00087D66
		public CustomAttributeFormatException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232827;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeFormatException" /> class with the specified serialization and context information.</summary>
		/// <param name="info">The data for serializing or deserializing the custom attribute. </param>
		/// <param name="context">The source and destination for the custom attribute. </param>
		// Token: 0x060020E3 RID: 8419 RVA: 0x00089B7B File Offset: 0x00087D7B
		protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
