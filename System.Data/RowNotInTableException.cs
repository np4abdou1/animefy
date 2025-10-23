using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to perform an operation on a <see cref="T:System.Data.DataRow" /> that is not in a <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class RowNotInTableException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.RowNotInTableException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000167 RID: 359 RVA: 0x00007060 File Offset: 0x00005260
		protected RowNotInTableException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.RowNotInTableException" /> class.</summary>
		// Token: 0x06000168 RID: 360 RVA: 0x000071CA File Offset: 0x000053CA
		public RowNotInTableException() : base("Row not found in table.")
		{
			base.HResult = -2146232024;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.RowNotInTableException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000169 RID: 361 RVA: 0x000071E2 File Offset: 0x000053E2
		public RowNotInTableException(string s) : base(s)
		{
			base.HResult = -2146232024;
		}
	}
}
