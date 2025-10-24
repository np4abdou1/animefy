using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Sockets
{
	/// <summary>Provides client connections for TCP network services.</summary>
	// Token: 0x02000215 RID: 533
	public class TcpClient : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.TcpClient" /> class.</summary>
		// Token: 0x06000E6C RID: 3692 RVA: 0x0004AF09 File Offset: 0x00049109
		public TcpClient() : this(AddressFamily.InterNetwork)
		{
			bool on = Logging.On;
			bool on2 = Logging.On;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Sockets.TcpClient" /> class with the specified family.</summary>
		/// <param name="family">The <see cref="P:System.Net.IPAddress.AddressFamily" /> of the IP protocol. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="family" /> parameter is not equal to AddressFamily.InterNetwork -or- The <paramref name="family" /> parameter is not equal to AddressFamily.InterNetworkV6 </exception>
		// Token: 0x06000E6D RID: 3693 RVA: 0x0004AF20 File Offset: 0x00049120
		public TcpClient(AddressFamily family)
		{
			bool on = Logging.On;
			if (family != AddressFamily.InterNetwork && family != AddressFamily.InterNetworkV6)
			{
				throw new ArgumentException(SR.GetString("'{0}' Client can only accept InterNetwork or InterNetworkV6 addresses.", new object[]
				{
					"TCP"
				}), "family");
			}
			this.m_Family = family;
			this.initialize();
			bool on2 = Logging.On;
		}

		/// <summary>Gets or sets the underlying <see cref="T:System.Net.Sockets.Socket" />.</summary>
		/// <returns>The underlying network <see cref="T:System.Net.Sockets.Socket" />.</returns>
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0004AF7F File Offset: 0x0004917F
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x0004AF87 File Offset: 0x00049187
		public Socket Client
		{
			get
			{
				return this.m_ClientSocket;
			}
			set
			{
				this.m_ClientSocket = value;
			}
		}

		/// <summary>Connects the client to the specified port on the specified host.</summary>
		/// <param name="hostname">The DNS name of the remote host to which you intend to connect. </param>
		/// <param name="port">The port number of the remote host to which you intend to connect. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
		// Token: 0x06000E70 RID: 3696 RVA: 0x0004AF90 File Offset: 0x00049190
		public void Connect(string hostname, int port)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (hostname == null)
			{
				throw new ArgumentNullException("hostname");
			}
			if (!ValidationHelper.ValidateTcpPort(port))
			{
				throw new ArgumentOutOfRangeException("port");
			}
			if (this.m_Active)
			{
				throw new SocketException(SocketError.IsConnected);
			}
			IPAddress[] hostAddresses = Dns.GetHostAddresses(hostname);
			Exception ex = null;
			Socket socket = null;
			Socket socket2 = null;
			try
			{
				if (this.m_ClientSocket == null)
				{
					if (Socket.OSSupportsIPv4)
					{
						socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					}
					if (Socket.OSSupportsIPv6)
					{
						socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
					}
				}
				foreach (IPAddress ipaddress in hostAddresses)
				{
					try
					{
						if (this.m_ClientSocket == null)
						{
							if (ipaddress.AddressFamily == AddressFamily.InterNetwork && socket2 != null)
							{
								socket2.Connect(ipaddress, port);
								this.m_ClientSocket = socket2;
								if (socket != null)
								{
									socket.Close();
								}
							}
							else if (socket != null)
							{
								socket.Connect(ipaddress, port);
								this.m_ClientSocket = socket;
								if (socket2 != null)
								{
									socket2.Close();
								}
							}
							this.m_Family = ipaddress.AddressFamily;
							this.m_Active = true;
							break;
						}
						if (ipaddress.AddressFamily == this.m_Family)
						{
							this.Connect(new IPEndPoint(ipaddress, port));
							this.m_Active = true;
							break;
						}
					}
					catch (Exception ex2)
					{
						if (ex2 is ThreadAbortException || ex2 is StackOverflowException || ex2 is OutOfMemoryException)
						{
							throw;
						}
						ex = ex2;
					}
				}
			}
			catch (Exception ex3)
			{
				if (ex3 is ThreadAbortException || ex3 is StackOverflowException || ex3 is OutOfMemoryException)
				{
					throw;
				}
				ex = ex3;
			}
			finally
			{
				if (!this.m_Active)
				{
					if (socket != null)
					{
						socket.Close();
					}
					if (socket2 != null)
					{
						socket2.Close();
					}
					if (ex != null)
					{
						throw ex;
					}
					throw new SocketException(SocketError.NotConnected);
				}
			}
			bool on2 = Logging.On;
		}

		/// <summary>Connects the client to a remote TCP host using the specified remote network endpoint.</summary>
		/// <param name="remoteEP">The <see cref="T:System.Net.IPEndPoint" /> to which you intend to connect. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="remoteEp" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
		// Token: 0x06000E71 RID: 3697 RVA: 0x0004B19C File Offset: 0x0004939C
		public void Connect(IPEndPoint remoteEP)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (remoteEP == null)
			{
				throw new ArgumentNullException("remoteEP");
			}
			this.Client.Connect(remoteEP);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Begins an asynchronous request for a remote host connection. The remote host is specified by a host name (<see cref="T:System.String" />) and a port number (<see cref="T:System.Int32" />).</summary>
		/// <param name="host">The name of the remote host.</param>
		/// <param name="port">The port number of the remote host.</param>
		/// <param name="requestCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the operation is complete.</param>
		/// <param name="state">A user-defined object that contains information about the connect operation. This object is passed to the <paramref name="requestCallback" /> delegate when the operation is complete.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object that references the asynchronous connection.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="host" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		/// <exception cref="T:System.Security.SecurityException">A caller higher in the call stack does not have permission for the requested operation. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The port number is not valid.</exception>
		// Token: 0x06000E72 RID: 3698 RVA: 0x0004B1EF File Offset: 0x000493EF
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			bool on = Logging.On;
			IAsyncResult result = this.Client.BeginConnect(host, port, requestCallback, state);
			bool on2 = Logging.On;
			return result;
		}

		/// <summary>Ends a pending asynchronous connection attempt.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> object returned by a call to <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="asyncResult" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="asyncResult" /> parameter was not returned by a call to a <see cref="Overload:System.Net.Sockets.TcpClient.BeginConnect" /> method. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="M:System.Net.Sockets.TcpClient.EndConnect(System.IAsyncResult)" /> method was previously called for the asynchronous connection. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when attempting to access the <see cref="T:System.Net.Sockets.Socket" />. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The underlying <see cref="T:System.Net.Sockets.Socket" /> has been closed. </exception>
		// Token: 0x06000E73 RID: 3699 RVA: 0x0004B20D File Offset: 0x0004940D
		public void EndConnect(IAsyncResult asyncResult)
		{
			bool on = Logging.On;
			this.Client.EndConnect(asyncResult);
			this.m_Active = true;
			bool on2 = Logging.On;
		}

		/// <summary>Connects the client to the specified TCP port on the specified host as an asynchronous operation.</summary>
		/// <param name="host">The DNS name of the remote host to which you intend to connect. </param>
		/// <param name="port">The port number of the remote host to which you intend to connect. </param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />The task object representing the asynchronous operation.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="hostname" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="port" /> parameter is not between <see cref="F:System.Net.IPEndPoint.MinPort" /> and <see cref="F:System.Net.IPEndPoint.MaxPort" />. </exception>
		/// <exception cref="T:System.Net.Sockets.SocketException">An error occurred when accessing the socket. See the Remarks section for more information. </exception>
		/// <exception cref="T:System.ObjectDisposedException">
		///         <see cref="T:System.Net.Sockets.TcpClient" /> is closed. </exception>
		// Token: 0x06000E74 RID: 3700 RVA: 0x0004B22E File Offset: 0x0004942E
		public Task ConnectAsync(string host, int port)
		{
			return Task.Factory.FromAsync<string, int>(new Func<string, int, AsyncCallback, object, IAsyncResult>(this.BeginConnect), new Action<IAsyncResult>(this.EndConnect), host, port, null);
		}

		/// <summary>Returns the <see cref="T:System.Net.Sockets.NetworkStream" /> used to send and receive data.</summary>
		/// <returns>The underlying <see cref="T:System.Net.Sockets.NetworkStream" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Net.Sockets.TcpClient" /> is not connected to a remote host. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="T:System.Net.Sockets.TcpClient" /> has been closed. </exception>
		// Token: 0x06000E75 RID: 3701 RVA: 0x0004B258 File Offset: 0x00049458
		public NetworkStream GetStream()
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
			if (!this.Client.Connected)
			{
				throw new InvalidOperationException(SR.GetString("The operation is not allowed on non-connected sockets."));
			}
			if (this.m_DataStream == null)
			{
				this.m_DataStream = new NetworkStream(this.Client, true);
			}
			bool on2 = Logging.On;
			return this.m_DataStream;
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Sockets.TcpClient" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">Set to <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06000E76 RID: 3702 RVA: 0x0004B2C8 File Offset: 0x000494C8
		protected virtual void Dispose(bool disposing)
		{
			bool on = Logging.On;
			if (this.m_CleanedUp)
			{
				bool on2 = Logging.On;
				return;
			}
			if (disposing)
			{
				IDisposable dataStream = this.m_DataStream;
				if (dataStream != null)
				{
					dataStream.Dispose();
				}
				else
				{
					Socket client = this.Client;
					if (client != null)
					{
						try
						{
							client.InternalShutdown(SocketShutdown.Both);
						}
						finally
						{
							client.Close();
							this.Client = null;
						}
					}
				}
				GC.SuppressFinalize(this);
			}
			this.m_CleanedUp = true;
			bool on3 = Logging.On;
		}

		/// <summary>Releases the managed and unmanaged resources used by the <see cref="T:System.Net.Sockets.TcpClient" />.</summary>
		// Token: 0x06000E77 RID: 3703 RVA: 0x0004B344 File Offset: 0x00049544
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Frees resources used by the <see cref="T:System.Net.Sockets.TcpClient" /> class.</summary>
		// Token: 0x06000E78 RID: 3704 RVA: 0x0004B350 File Offset: 0x00049550
		~TcpClient()
		{
			this.Dispose(false);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0004B380 File Offset: 0x00049580
		private void initialize()
		{
			this.Client = new Socket(this.m_Family, SocketType.Stream, ProtocolType.Tcp);
			this.m_Active = false;
		}

		// Token: 0x04000B89 RID: 2953
		private Socket m_ClientSocket;

		// Token: 0x04000B8A RID: 2954
		private bool m_Active;

		// Token: 0x04000B8B RID: 2955
		private NetworkStream m_DataStream;

		// Token: 0x04000B8C RID: 2956
		private AddressFamily m_Family = AddressFamily.InterNetwork;

		// Token: 0x04000B8D RID: 2957
		private bool m_CleanedUp;
	}
}
