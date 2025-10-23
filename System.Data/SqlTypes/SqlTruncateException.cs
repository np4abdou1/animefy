using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>The exception that is thrown when you set a value into a <see cref="N:System.Data.SqlTypes" /> structure would truncate that value.</summary>
	// Token: 0x020000C5 RID: 197
	[Serializable]
	public sealed class SqlTruncateException : SqlTypeException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTruncateException" /> class.</summary>
		// Token: 0x06000DC5 RID: 3525 RVA: 0x0004645D File Offset: 0x0004465D
		public SqlTruncateException() : this(SQLResource.TruncationMessage, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTruncateException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0004646B File Offset: 0x0004466B
		public SqlTruncateException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTruncateException" /> class with a specified error message and a reference to the <see cref="T:System.Exception" />.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="e">A reference to an inner <see cref="T:System.Exception" />. </param>
		// Token: 0x06000DC7 RID: 3527 RVA: 0x00046475 File Offset: 0x00044675
		public SqlTruncateException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232014;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0004648A File Offset: 0x0004468A
		private SqlTruncateException(SerializationInfo si, StreamingContext sc) : base(SqlTruncateException.SqlTruncateExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0004649A File Offset: 0x0004469A
		private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlTruncateException(si.GetString("SqlTruncateExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
