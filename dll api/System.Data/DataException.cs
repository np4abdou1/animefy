using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when errors are generated using ADO.NET components.</summary>
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class DataException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified serialization information and context.</summary>
		/// <param name="info">The data necessary to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x0600014B RID: 331 RVA: 0x00007020 File Offset: 0x00005220
		protected DataException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class. This is the default constructor.</summary>
		// Token: 0x0600014C RID: 332 RVA: 0x0000702A File Offset: 0x0000522A
		public DataException() : base("Data Exception.")
		{
			base.HResult = -2146232032;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x0600014D RID: 333 RVA: 0x00007042 File Offset: 0x00005242
		public DataException(string s) : base(s)
		{
			base.HResult = -2146232032;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataException" /> class with the specified string and inner exception.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		/// <param name="innerException">A reference to an inner exception. </param>
		// Token: 0x0600014E RID: 334 RVA: 0x00007056 File Offset: 0x00005256
		public DataException(string s, Exception innerException) : base(s, innerException)
		{
		}
	}
}
