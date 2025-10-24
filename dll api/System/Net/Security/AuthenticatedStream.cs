using System;
using System.IO;

namespace System.Net.Security
{
	/// <summary>Provides methods for passing credentials across a stream and requesting or performing authentication for client-server applications.</summary>
	// Token: 0x0200021C RID: 540
	public abstract class AuthenticatedStream : Stream
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.AuthenticatedStream" /> class. </summary>
		/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.AuthenticatedStream" />  for sending and receiving data.</param>
		/// <param name="leaveInnerStreamOpen">A <see cref="T:System.Boolean" /> that indicates whether closing this <see cref="T:System.Net.Security.AuthenticatedStream" />  object also closes <paramref name="innerStream" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="innerStream" /> is <see langword="null" />.-or-
		///         <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004BC08 File Offset: 0x00049E08
		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
			if (innerStream == null || innerStream == Stream.Null)
			{
				throw new ArgumentNullException("innerStream");
			}
			if (!innerStream.CanRead || !innerStream.CanWrite)
			{
				throw new ArgumentException(SR.GetString("The stream has to be read/write."), "innerStream");
			}
			this._InnerStream = innerStream;
			this._LeaveStreamOpen = leaveInnerStreamOpen;
		}

		/// <summary>Gets the stream used by this <see cref="T:System.Net.Security.AuthenticatedStream" /> for sending and receiving data.</summary>
		/// <returns>A <see cref="T:System.IO.Stream" /> object.</returns>
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0004BC64 File Offset: 0x00049E64
		protected Stream InnerStream
		{
			get
			{
				return this._InnerStream;
			}
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Security.AuthenticatedStream" /> and optionally releases the managed resources. </summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06000EB6 RID: 3766 RVA: 0x0004BC6C File Offset: 0x00049E6C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this._LeaveStreamOpen)
					{
						this._InnerStream.Flush();
					}
					else
					{
						this._InnerStream.Close();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether authentication was successful.</summary>
		/// <returns>
		///     <see langword="true" /> if successful authentication occurred; otherwise, <see langword="false" />. </returns>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000EB7 RID: 3767
		public abstract bool IsAuthenticated { get; }

		// Token: 0x04000BCA RID: 3018
		private Stream _InnerStream;

		// Token: 0x04000BCB RID: 3019
		private bool _LeaveStreamOpen;
	}
}
