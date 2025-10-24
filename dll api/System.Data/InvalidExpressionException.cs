using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you try to add a <see cref="T:System.Data.DataColumn" /> that contains an invalid <see cref="P:System.Data.DataColumn.Expression" /> to a <see cref="T:System.Data.DataColumnCollection" />.</summary>
	// Token: 0x02000061 RID: 97
	[Serializable]
	public class InvalidExpressionException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidExpressionException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The data needed to serialize or deserialize an object. </param>
		/// <param name="context">The source and destination of a given serialized stream. </param>
		// Token: 0x060006FD RID: 1789 RVA: 0x00007060 File Offset: 0x00005260
		protected InvalidExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidExpressionException" /> class.</summary>
		// Token: 0x060006FE RID: 1790 RVA: 0x00022607 File Offset: 0x00020807
		public InvalidExpressionException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InvalidExpressionException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x060006FF RID: 1791 RVA: 0x0002260F File Offset: 0x0002080F
		public InvalidExpressionException(string s) : base(s)
		{
		}
	}
}
