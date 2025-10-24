using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when an action is tried on a <see cref="T:System.Data.DataRow" /> that has been deleted.</summary>
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class DeletedRowInaccessibleException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DeletedRowInaccessibleException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000152 RID: 338 RVA: 0x00007060 File Offset: 0x00005260
		protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DeletedRowInaccessibleException" /> class.</summary>
		// Token: 0x06000153 RID: 339 RVA: 0x00007096 File Offset: 0x00005296
		public DeletedRowInaccessibleException() : base("Deleted rows inaccessible.")
		{
			base.HResult = -2146232031;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DeletedRowInaccessibleException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x06000154 RID: 340 RVA: 0x000070AE File Offset: 0x000052AE
		public DeletedRowInaccessibleException(string s) : base(s)
		{
			base.HResult = -2146232031;
		}
	}
}
