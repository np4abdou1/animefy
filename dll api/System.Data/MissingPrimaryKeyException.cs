using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to access a row in a table that has no primary key.</summary>
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class MissingPrimaryKeyException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.MissingPrimaryKeyException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">A description of the source and destination of the specified serialized stream. </param>
		// Token: 0x0600015E RID: 350 RVA: 0x00007060 File Offset: 0x00005260
		protected MissingPrimaryKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.MissingPrimaryKeyException" /> class.</summary>
		// Token: 0x0600015F RID: 351 RVA: 0x00007146 File Offset: 0x00005346
		public MissingPrimaryKeyException() : base("Missing primary key.")
		{
			base.HResult = -2146232027;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.MissingPrimaryKeyException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000160 RID: 352 RVA: 0x0000715E File Offset: 0x0000535E
		public MissingPrimaryKeyException(string s) : base(s)
		{
			base.HResult = -2146232027;
		}
	}
}
