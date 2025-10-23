using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to insert a null value into a column where <see cref="P:System.Data.DataColumn.AllowDBNull" /> is set to <see langword="false" />.</summary>
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class NoNullAllowedException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000161 RID: 353 RVA: 0x00007060 File Offset: 0x00005260
		protected NoNullAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class.</summary>
		// Token: 0x06000162 RID: 354 RVA: 0x00007172 File Offset: 0x00005372
		public NoNullAllowedException() : base("Null not allowed.")
		{
			base.HResult = -2146232026;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.NoNullAllowedException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000163 RID: 355 RVA: 0x0000718A File Offset: 0x0000538A
		public NoNullAllowedException(string s) : base(s)
		{
			base.HResult = -2146232026;
		}
	}
}
