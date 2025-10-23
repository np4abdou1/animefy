using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a method attempts to use a type that it does not have access to.</summary>
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class TypeAccessException : TypeLoadException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with a system-supplied message that describes the error.</summary>
		// Token: 0x06000A57 RID: 2647 RVA: 0x0002B3E7 File Offset: 0x000295E7
		public TypeAccessException() : base("Attempt to access the type failed.")
		{
			base.HResult = -2146233021;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TypeAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000A58 RID: 2648 RVA: 0x00013694 File Offset: 0x00011894
		protected TypeAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
