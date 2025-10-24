using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to change the value of a read-only column.</summary>
	// Token: 0x02000021 RID: 33
	[Serializable]
	public class ReadOnlyException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000164 RID: 356 RVA: 0x00007060 File Offset: 0x00005260
		protected ReadOnlyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class.</summary>
		// Token: 0x06000165 RID: 357 RVA: 0x0000719E File Offset: 0x0000539E
		public ReadOnlyException() : base("Column is marked read only.")
		{
			base.HResult = -2146232025;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.ReadOnlyException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000166 RID: 358 RVA: 0x000071B6 File Offset: 0x000053B6
		public ReadOnlyException(string s) : base(s)
		{
			base.HResult = -2146232025;
		}
	}
}
