using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt is made to access an element of an array or collection with an index that is outside its bounds. </summary>
	// Token: 0x020000C2 RID: 194
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IndexOutOfRangeException" /> class.</summary>
		// Token: 0x0600063C RID: 1596 RVA: 0x0001C222 File Offset: 0x0001A422
		public IndexOutOfRangeException() : base("Index was outside the bounds of the array.")
		{
			base.HResult = -2146233080;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.IndexOutOfRangeException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x0600063D RID: 1597 RVA: 0x0001C23A File Offset: 0x0001A43A
		public IndexOutOfRangeException(string message) : base(message)
		{
			base.HResult = -2146233080;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000E339 File Offset: 0x0000C539
		internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
