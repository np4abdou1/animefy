using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when incorrectly trying to create or access a relation.</summary>
	// Token: 0x0200001E RID: 30
	[Serializable]
	public class InvalidConstraintException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x0600015B RID: 347 RVA: 0x00007060 File Offset: 0x00005260
		protected InvalidConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class.</summary>
		// Token: 0x0600015C RID: 348 RVA: 0x0000711A File Offset: 0x0000531A
		public InvalidConstraintException() : base("Invalid constraint.")
		{
			base.HResult = -2146232028;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidConstraintException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x0600015D RID: 349 RVA: 0x00007132 File Offset: 0x00005332
		public InvalidConstraintException(string s) : base(s)
		{
			base.HResult = -2146232028;
		}
	}
}
