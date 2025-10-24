using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when a duplicate database object name is encountered during an add operation in a <see cref="T:System.Data.DataSet" /> -related object.</summary>
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class DuplicateNameException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000155 RID: 341 RVA: 0x00007060 File Offset: 0x00005260
		protected DuplicateNameException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class.</summary>
		// Token: 0x06000156 RID: 342 RVA: 0x000070C2 File Offset: 0x000052C2
		public DuplicateNameException() : base("Duplicate name not allowed.")
		{
			base.HResult = -2146232030;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DuplicateNameException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000157 RID: 343 RVA: 0x000070DA File Offset: 0x000052DA
		public DuplicateNameException(string s) : base(s)
		{
			base.HResult = -2146232030;
		}
	}
}
