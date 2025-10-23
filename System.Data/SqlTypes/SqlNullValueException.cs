using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>The exception that is thrown when the <see langword="Value" /> property of a <see cref="N:System.Data.SqlTypes" /> structure is set to null.</summary>
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public sealed class SqlNullValueException : SqlTypeException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a system-supplied message that describes the error.</summary>
		// Token: 0x06000DC0 RID: 3520 RVA: 0x000463FA File Offset: 0x000445FA
		public SqlNullValueException() : this(SQLResource.NullValueMessage, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a specified message that describes the error.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture.</param>
		// Token: 0x06000DC1 RID: 3521 RVA: 0x00046408 File Offset: 0x00044608
		public SqlNullValueException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlNullValueException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		/// <param name="e">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000DC2 RID: 3522 RVA: 0x00046412 File Offset: 0x00044612
		public SqlNullValueException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232015;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00046427 File Offset: 0x00044627
		private SqlNullValueException(SerializationInfo si, StreamingContext sc) : base(SqlNullValueException.SqlNullValueExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00046437 File Offset: 0x00044637
		private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlNullValueException(si.GetString("SqlNullValueExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
