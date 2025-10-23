using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.ComponentModel
{
	/// <summary>Throws an exception for a Win32 error code.</summary>
	// Token: 0x020002B0 RID: 688
	[SuppressUnmanagedCodeSecurity]
	[Serializable]
	public class Win32Exception : ExternalException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the last Win32 error that occurred.</summary>
		// Token: 0x06001280 RID: 4736 RVA: 0x00046794 File Offset: 0x00044994
		public Win32Exception() : this(Marshal.GetLastWin32Error())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error.</summary>
		/// <param name="error">The Win32 error code associated with this exception. </param>
		// Token: 0x06001281 RID: 4737 RVA: 0x00058CFC File Offset: 0x00056EFC
		public Win32Exception(int error) : this(error, Win32Exception.GetErrorMessage(error))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified error and the specified detailed description.</summary>
		/// <param name="error">The Win32 error code associated with this exception. </param>
		/// <param name="message">A detailed description of the error. </param>
		// Token: 0x06001282 RID: 4738 RVA: 0x00058D0B File Offset: 0x00056F0B
		public Win32Exception(int error, string message) : base(message)
		{
			this.nativeErrorCode = error;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Win32Exception" /> class with the specified context and the serialization information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> associated with this exception. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> that represents the context of this exception. </param>
		// Token: 0x06001283 RID: 4739 RVA: 0x00058D1B File Offset: 0x00056F1B
		protected Win32Exception(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.nativeErrorCode = info.GetInt32("NativeErrorCode");
		}

		/// <summary>Gets the Win32 error code associated with this exception.</summary>
		/// <returns>The Win32 error code associated with this exception.</returns>
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00058D36 File Offset: 0x00056F36
		public int NativeErrorCode
		{
			get
			{
				return this.nativeErrorCode;
			}
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name and line number at which this <see cref="T:System.ComponentModel.Win32Exception" /> occurred.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06001285 RID: 4741 RVA: 0x00058D3E File Offset: 0x00056F3E
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("NativeErrorCode", this.nativeErrorCode);
			base.GetObjectData(info, context);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00058D68 File Offset: 0x00056F68
		internal static string GetErrorMessage(int error)
		{
			if (error <= 120)
			{
				if (error <= 33)
				{
					switch (error)
					{
					case 0:
						return "Success";
					case 1:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 15:
					case 16:
						break;
					case 2:
						return "Cannot find the specified file";
					case 3:
						return "Cannot find the specified file";
					case 4:
						return "Too many open files";
					case 5:
						return "Access denied";
					case 6:
						return "Invalid handle";
					case 13:
						return "Invalid data";
					case 14:
						return "Out of memory";
					case 17:
						return "Not same device";
					case 18:
						return "No more files";
					default:
						if (error == 24)
						{
							return "Bad length";
						}
						switch (error)
						{
						case 31:
							return "General failure";
						case 32:
							return "Sharing violation";
						case 33:
							return "Lock violation";
						}
						break;
					}
				}
				else if (error <= 55)
				{
					if (error == 50)
					{
						return "Operation not supported";
					}
					if (error == 55)
					{
						return "Device does not exist";
					}
				}
				else
				{
					if (error == 87)
					{
						return "Invalid parameter";
					}
					if (error == 120)
					{
						return "Call not implemented";
					}
				}
			}
			else if (error <= 267)
			{
				if (error <= 127)
				{
					if (error == 123)
					{
						return "Invalid name";
					}
					if (error == 127)
					{
						return "Process not found";
					}
				}
				else
				{
					if (error == 183)
					{
						return "Already exists";
					}
					if (error == 267)
					{
						return "Is a directory";
					}
				}
			}
			else if (error <= 6000)
			{
				if (error == 995)
				{
					return "Operation aborted";
				}
				if (error == 6000)
				{
					return "Encryption failed";
				}
			}
			else
			{
				switch (error)
				{
				case 10004:
					return "interrupted";
				case 10005:
				case 10006:
				case 10007:
				case 10008:
				case 10010:
				case 10011:
				case 10012:
				case 10015:
				case 10016:
				case 10017:
				case 10018:
				case 10019:
				case 10020:
				case 10021:
				case 10023:
				case 10025:
				case 10026:
				case 10027:
				case 10028:
				case 10029:
				case 10030:
				case 10031:
				case 10032:
				case 10033:
				case 10034:
				case 10072:
				case 10073:
				case 10074:
				case 10075:
				case 10076:
				case 10077:
				case 10078:
				case 10079:
				case 10080:
				case 10081:
				case 10082:
				case 10083:
				case 10084:
				case 10085:
				case 10086:
				case 10087:
				case 10088:
				case 10089:
				case 10090:
				case 10094:
				case 10095:
				case 10096:
				case 10097:
				case 10098:
				case 10099:
				case 10100:
				case 10110:
				case 10111:
					break;
				case 10009:
					return "Bad file number";
				case 10013:
					return "Access denied";
				case 10014:
					return "Bad address";
				case 10022:
					return "Invalid arguments";
				case 10024:
					return "Too many open files";
				case 10035:
					return "Operation on non-blocking socket would block";
				case 10036:
					return "Operation in progress";
				case 10037:
					return "Operation already in progress";
				case 10038:
					return "The descriptor is not a socket";
				case 10039:
					return "Destination address required";
				case 10040:
					return "Message too long";
				case 10041:
					return "Protocol wrong type for socket";
				case 10042:
					return "Protocol option not supported";
				case 10043:
					return "Protocol not supported";
				case 10044:
					return "Socket not supported";
				case 10045:
					return "Operation not supported";
				case 10046:
					return "Protocol family not supported";
				case 10047:
					return "An address incompatible with the requested protocol was used";
				case 10048:
					return "Address already in use";
				case 10049:
					return "The requested address is not valid in this context";
				case 10050:
					return "Network subsystem is down";
				case 10051:
					return "Network is unreachable";
				case 10052:
					return "Connection broken, keep-alive detected a problem";
				case 10053:
					return "An established connection was aborted in your host machine.";
				case 10054:
					return "Connection reset by peer";
				case 10055:
					return "Not enough buffer space is available";
				case 10056:
					return "Socket is already connected";
				case 10057:
					return "The socket is not connected";
				case 10058:
					return "The socket has been shut down";
				case 10059:
					return "Too many references: cannot splice";
				case 10060:
					return "Connection timed out";
				case 10061:
					return "Connection refused";
				case 10062:
					return "Too many symbolic links encountered";
				case 10063:
					return "File name too long";
				case 10064:
					return "Host is down";
				case 10065:
					return "No route to host";
				case 10066:
					return "Directory not empty";
				case 10067:
					return "EPROCLIM";
				case 10068:
					return "Too many users";
				case 10069:
					return "Quota exceeded";
				case 10070:
					return "Stale NFS file handle";
				case 10071:
					return "Object is remote";
				case 10091:
					return "SYSNOTREADY";
				case 10092:
					return "VERNOTSUPPORTED";
				case 10093:
					return "Winsock not initialised";
				case 10101:
					return "EDISCON";
				case 10102:
					return "ENOMORE";
				case 10103:
					return "Operation canceled";
				case 10104:
					return "EINVALIDPROCTABLE";
				case 10105:
					return "EINVALIDPROVIDER";
				case 10106:
					return "EPROVIDERFAILEDINIT";
				case 10107:
					return "System call failed";
				case 10108:
					return "SERVICE_NOT_FOUND";
				case 10109:
					return "TYPE_NOT_FOUND";
				case 10112:
					return "EREFUSED";
				default:
					switch (error)
					{
					case 11001:
						return "No such host is known";
					case 11002:
						return "A temporary error occurred on an authoritative name server.  Try again later.";
					case 11003:
						return "No recovery";
					case 11004:
						return "No data";
					}
					break;
				}
			}
			return string.Format("mono-io-layer-error ({0})", error);
		}

		// Token: 0x04000D01 RID: 3329
		private readonly int nativeErrorCode;
	}
}
