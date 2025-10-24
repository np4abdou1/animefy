using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an array with the wrong number of dimensions is passed to a method.</summary>
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class RankException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class.</summary>
		// Token: 0x060007DD RID: 2013 RVA: 0x000239B9 File Offset: 0x00021BB9
		public RankException() : base("Attempted to operate on an array with the incorrect number of dimensions.")
		{
			base.HResult = -2146233065;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x060007DE RID: 2014 RVA: 0x000239D1 File Offset: 0x00021BD1
		public RankException(string message) : base(message)
		{
			base.HResult = -2146233065;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.RankException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060007DF RID: 2015 RVA: 0x0000E339 File Offset: 0x0000C539
		protected RankException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
