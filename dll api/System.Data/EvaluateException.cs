using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when the <see cref="P:System.Data.DataColumn.Expression" /> property of a <see cref="T:System.Data.DataColumn" /> cannot be evaluated.</summary>
	// Token: 0x02000062 RID: 98
	[Serializable]
	public class EvaluateException : InvalidExpressionException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class with the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">The data needed to serialize or deserialize an object. </param>
		/// <param name="context">The source and destination of a particular serialized stream. </param>
		// Token: 0x06000700 RID: 1792 RVA: 0x00022618 File Offset: 0x00020818
		protected EvaluateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class.</summary>
		// Token: 0x06000701 RID: 1793 RVA: 0x00022622 File Offset: 0x00020822
		public EvaluateException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.EvaluateException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000702 RID: 1794 RVA: 0x0002262A File Offset: 0x0002082A
		public EvaluateException(string s) : base(s)
		{
		}
	}
}
