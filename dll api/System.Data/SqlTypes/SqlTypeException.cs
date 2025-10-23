using System;
using System.Runtime.Serialization;

namespace System.Data.SqlTypes
{
	/// <summary>The base exception class for the <see cref="N:System.Data.SqlTypes" />.</summary>
	// Token: 0x020000C3 RID: 195
	[Serializable]
	public class SqlTypeException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class.</summary>
		// Token: 0x06000DBB RID: 3515 RVA: 0x00046397 File Offset: 0x00044597
		public SqlTypeException() : this("SqlType error.", null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		// Token: 0x06000DBC RID: 3516 RVA: 0x000463A5 File Offset: 0x000445A5
		public SqlTypeException(string message) : this(message, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The message that describes the exception. The caller of this constructor is required to ensure that this string has been localized for the current system culture. </param>
		/// <param name="e">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000DBD RID: 3517 RVA: 0x000463AF File Offset: 0x000445AF
		public SqlTypeException(string message, Exception e) : base(message, e)
		{
			base.HResult = -2146232016;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.SqlTypes.SqlTypeException" /> class with serialized data.</summary>
		/// <param name="si">The object that holds the serialized object data. </param>
		/// <param name="sc">The contextual information about the source or destination. </param>
		// Token: 0x06000DBE RID: 3518 RVA: 0x000463C4 File Offset: 0x000445C4
		protected SqlTypeException(SerializationInfo si, StreamingContext sc) : base(SqlTypeException.SqlTypeExceptionSerialization(si, sc), sc)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000463D4 File Offset: 0x000445D4
		private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc)
		{
			if (si != null && 1 == si.MemberCount)
			{
				new SqlTypeException(si.GetString("SqlTypeExceptionMessage")).GetObjectData(si, sc);
			}
			return si;
		}
	}
}
