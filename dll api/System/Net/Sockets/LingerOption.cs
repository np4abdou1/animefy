using System;

namespace System.Net.Sockets
{
	/// <summary>Specifies whether a <see cref="T:System.Net.Sockets.Socket" /> will remain connected after a call to the <see cref="M:System.Net.Sockets.Socket.Close" /> or <see cref="M:System.Net.Sockets.TcpClient.Close" /> methods and the length of time it will remain connected, if data remains to be sent.</summary>
	// Token: 0x0200020A RID: 522
	public class LingerOption
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.LingerOption" /> class.</summary>
		/// <param name="enable">
		///       <see langword="true" /> to remain connected after the <see cref="M:System.Net.Sockets.Socket.Close" /> method is called; otherwise, <see langword="false" />. </param>
		/// <param name="seconds">The number of seconds to remain connected after the <see cref="M:System.Net.Sockets.Socket.Close" /> method is called. </param>
		// Token: 0x06000E69 RID: 3689 RVA: 0x0004AEE1 File Offset: 0x000490E1
		public LingerOption(bool enable, int seconds)
		{
			this.Enabled = enable;
			this.LingerTime = seconds;
		}

		/// <summary>Gets or sets a value that indicates whether to linger after the <see cref="T:System.Net.Sockets.Socket" /> is closed.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Sockets.Socket" /> should linger after <see cref="M:System.Net.Sockets.Socket.Close" /> is called; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002DD RID: 733
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0004AEF7 File Offset: 0x000490F7
		public bool Enabled
		{
			set
			{
				this.enabled = value;
			}
		}

		/// <summary>Gets or sets the amount of time to remain connected after calling the <see cref="M:System.Net.Sockets.Socket.Close" /> method if data remains to be sent.</summary>
		/// <returns>The amount of time, in seconds, to remain connected after calling <see cref="M:System.Net.Sockets.Socket.Close" />.</returns>
		// Token: 0x170002DE RID: 734
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x0004AF00 File Offset: 0x00049100
		public int LingerTime
		{
			set
			{
				this.lingerTime = value;
			}
		}

		// Token: 0x04000AE0 RID: 2784
		private bool enabled;

		// Token: 0x04000AE1 RID: 2785
		private int lingerTime;
	}
}
