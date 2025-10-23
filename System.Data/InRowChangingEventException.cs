using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Represents the exception that is thrown when you call the <see cref="M:System.Data.DataRow.EndEdit" /> method within the <see cref="E:System.Data.DataTable.RowChanging" /> event.</summary>
	// Token: 0x0200001D RID: 29
	[Serializable]
	public class InRowChangingEventException : DataException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InRowChangingEventException" /> class with serialization information.</summary>
		/// <param name="info">The data that is required to serialize or deserialize an object. </param>
		/// <param name="context">Description of the source and destination of the specified serialized stream. </param>
		// Token: 0x06000158 RID: 344 RVA: 0x00007060 File Offset: 0x00005260
		protected InRowChangingEventException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InRowChangingEventException" /> class.</summary>
		// Token: 0x06000159 RID: 345 RVA: 0x000070EE File Offset: 0x000052EE
		public InRowChangingEventException() : base("Operation not supported in the RowChanging event.")
		{
			base.HResult = -2146232029;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.InRowChangingEventException" /> class with the specified string.</summary>
		/// <param name="s">The string to display when the exception is thrown. </param>
		// Token: 0x0600015A RID: 346 RVA: 0x00007106 File Offset: 0x00005306
		public InRowChangingEventException(string s) : base(s)
		{
			base.HResult = -2146232029;
		}
	}
}
