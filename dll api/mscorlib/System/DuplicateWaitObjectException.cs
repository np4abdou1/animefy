using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an object appears more than once in an array of synchronization objects.</summary>
	// Token: 0x02000096 RID: 150
	[Serializable]
	public class DuplicateWaitObjectException : ArgumentException
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00013A4F File Offset: 0x00011C4F
		private static string DuplicateWaitObjectMessage
		{
			get
			{
				if (DuplicateWaitObjectException.s_duplicateWaitObjectMessage == null)
				{
					DuplicateWaitObjectException.s_duplicateWaitObjectMessage = "Duplicate objects in argument.";
				}
				return DuplicateWaitObjectException.s_duplicateWaitObjectMessage;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DuplicateWaitObjectException" /> class.</summary>
		// Token: 0x06000530 RID: 1328 RVA: 0x00013A6D File Offset: 0x00011C6D
		public DuplicateWaitObjectException() : base(DuplicateWaitObjectException.DuplicateWaitObjectMessage)
		{
			base.HResult = -2146233047;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DuplicateWaitObjectException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000531 RID: 1329 RVA: 0x0000E8CA File Offset: 0x0000CACA
		protected DuplicateWaitObjectException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000222 RID: 546
		private static volatile string s_duplicateWaitObjectMessage;
	}
}
