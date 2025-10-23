using System;
using System.Net.Sockets;

namespace System.Net
{
	/// <summary>Identifies a network address. This is an <see langword="abstract" /> class.</summary>
	// Token: 0x0200014C RID: 332
	[Serializable]
	public abstract class EndPoint
	{
		/// <summary>Gets the address family to which the endpoint belongs.</summary>
		/// <returns>One of the <see cref="T:System.Net.Sockets.AddressFamily" /> values.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to get or set the property when the property is not overridden in a descendant class. </exception>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x000333FB File Offset: 0x000315FB
		public virtual AddressFamily AddressFamily
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		/// <summary>Serializes endpoint information into a <see cref="T:System.Net.SocketAddress" /> instance.</summary>
		/// <returns>A <see cref="T:System.Net.SocketAddress" /> instance that contains the endpoint information.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x0600094D RID: 2381 RVA: 0x00033402 File Offset: 0x00031602
		public virtual SocketAddress Serialize()
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}

		/// <summary>Creates an <see cref="T:System.Net.EndPoint" /> instance from a <see cref="T:System.Net.SocketAddress" /> instance.</summary>
		/// <param name="socketAddress">The socket address that serves as the endpoint for a connection. </param>
		/// <returns>A new <see cref="T:System.Net.EndPoint" /> instance that is initialized from the specified <see cref="T:System.Net.SocketAddress" /> instance.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x0600094E RID: 2382 RVA: 0x00033402 File Offset: 0x00031602
		public virtual EndPoint Create(SocketAddress socketAddress)
		{
			throw ExceptionHelper.MethodNotImplementedException;
		}
	}
}
