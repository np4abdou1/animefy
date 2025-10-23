using System;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	/// <summary>The exception that is thrown in a thread upon cancellation of an operation that the thread was executing.</summary>
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		/// <summary>Gets a token associated with the operation that was canceled.</summary>
		/// <returns>A token associated with the operation that was canceled, or a default token.</returns>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00022F0B File Offset: 0x0002110B
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00022F13 File Offset: 0x00021113
		public CancellationToken CancellationToken
		{
			get
			{
				return this._cancellationToken;
			}
			private set
			{
				this._cancellationToken = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a system-supplied error message.</summary>
		// Token: 0x060007B2 RID: 1970 RVA: 0x00022F1C File Offset: 0x0002111C
		public OperationCanceledException() : base("The operation was canceled.")
		{
			base.HResult = -2146233029;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
		// Token: 0x060007B3 RID: 1971 RVA: 0x00022F34 File Offset: 0x00021134
		public OperationCanceledException(string message) : base(message)
		{
			base.HResult = -2146233029;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message and a cancellation token.</summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="token">A cancellation token associated with the operation that was canceled.</param>
		// Token: 0x060007B4 RID: 1972 RVA: 0x00022F48 File Offset: 0x00021148
		public OperationCanceledException(string message, CancellationToken token) : this(message)
		{
			this.CancellationToken = token;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x060007B5 RID: 1973 RVA: 0x0000E339 File Offset: 0x0000C539
		protected OperationCanceledException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000348 RID: 840
		[NonSerialized]
		private CancellationToken _cancellationToken;
	}
}
