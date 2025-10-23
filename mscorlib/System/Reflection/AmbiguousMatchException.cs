using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown when binding to a member results in more than one member matching the binding criteria. This class cannot be inherited.</summary>
	// Token: 0x02000481 RID: 1153
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AmbiguousMatchException" /> class with an empty message string and the root cause exception set to <see langword="null" />.</summary>
		// Token: 0x060020C0 RID: 8384 RVA: 0x00089A00 File Offset: 0x00087C00
		public AmbiguousMatchException() : base("Ambiguous match found.")
		{
			base.HResult = -2147475171;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AmbiguousMatchException" /> class with its message string set to the given message and the root cause exception set to <see langword="null" />.</summary>
		/// <param name="message">A string indicating the reason this exception was thrown. </param>
		// Token: 0x060020C1 RID: 8385 RVA: 0x00089A18 File Offset: 0x00087C18
		public AmbiguousMatchException(string message) : base(message)
		{
			base.HResult = -2147475171;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0000E339 File Offset: 0x0000C539
		internal AmbiguousMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
