using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when the <see cref="P:System.Data.DataColumn.Expression" /> property of a <see cref="T:System.Data.DataColumn" /> contains a syntax error.</summary>
	// Token: 0x02000063 RID: 99
	[Serializable]
	public class SyntaxErrorException : InvalidExpressionException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The data needed to serialize or deserialize an object. </param>
		/// <param name="context">The source and destination of a specific serialized stream. </param>
		// Token: 0x06000703 RID: 1795 RVA: 0x00022618 File Offset: 0x00020818
		protected SyntaxErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class.</summary>
		// Token: 0x06000704 RID: 1796 RVA: 0x00022622 File Offset: 0x00020822
		public SyntaxErrorException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SyntaxErrorException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000705 RID: 1797 RVA: 0x0002262A File Offset: 0x0002082A
		public SyntaxErrorException(string s) : base(s)
		{
		}
	}
}
