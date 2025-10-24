using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace System.Security.Principal
{
	/// <summary>Represents a Windows user.</summary>
	// Token: 0x020002F7 RID: 759
	[ComVisible(true)]
	[Serializable]
	public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by the specified Windows account token, the specified authentication type, the specified Windows account type, and the specified authentication status.</summary>
		/// <param name="userToken">The account token for the user on whose behalf the code is running. </param>
		/// <param name="type">(Informational use only.) The type of authentication used to identify the user. For more information, see Remarks.</param>
		/// <param name="acctType">One of the enumeration values. </param>
		/// <param name="isAuthenticated">
		///       <see langword="true" /> to indicate that the user is authenticated; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="userToken" /> is 0.-or-
		///         <paramref name="userToken" /> is duplicated and invalid for impersonation.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
		// Token: 0x0600190A RID: 6410 RVA: 0x0006D6B3 File Offset: 0x0006B8B3
		public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
			this._type = type;
			this._account = acctType;
			this._authenticated = isAuthenticated;
			this._name = null;
			this.SetToken(userToken);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.WindowsIdentity" /> class for the user represented by information in a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> stream.</summary>
		/// <param name="info">The object containing the account information for the user. </param>
		/// <param name="context">An object that indicates the stream characteristics. </param>
		/// <exception cref="T:System.NotSupportedException">A <see cref="T:System.Security.Principal.WindowsIdentity" /> cannot be serialized across processes. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-A Win32 error occurred.</exception>
		// Token: 0x0600190B RID: 6411 RVA: 0x0006D6DF File Offset: 0x0006B8DF
		public WindowsIdentity(SerializationInfo info, StreamingContext context)
		{
			this._info = info;
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Principal.WindowsIdentity" />. </summary>
		// Token: 0x0600190C RID: 6412 RVA: 0x0006D6EE File Offset: 0x0006B8EE
		[ComVisible(false)]
		public void Dispose()
		{
			this._token = IntPtr.Zero;
		}

		/// <summary>Returns a <see cref="T:System.Security.Principal.WindowsIdentity" /> object that represents the current Windows user.</summary>
		/// <returns>An object that represents the current user.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. </exception>
		// Token: 0x0600190D RID: 6413 RVA: 0x0006D6FB File Offset: 0x0006B8FB
		public static WindowsIdentity GetCurrent()
		{
			return new WindowsIdentity(WindowsIdentity.GetCurrentToken(), null, WindowsAccountType.Normal, true);
		}

		/// <summary>Impersonates the user represented by the <see cref="T:System.Security.Principal.WindowsIdentity" /> object.</summary>
		/// <returns>An object that represents the Windows user prior to impersonation; this can be used to revert to the original user's context.</returns>
		/// <exception cref="T:System.InvalidOperationException">An anonymous identity attempted to perform an impersonation.</exception>
		/// <exception cref="T:System.Security.SecurityException">A Win32 error occurred.</exception>
		// Token: 0x0600190E RID: 6414 RVA: 0x0006D70A File Offset: 0x0006B90A
		public virtual WindowsImpersonationContext Impersonate()
		{
			return new WindowsImpersonationContext(this._token);
		}

		/// <summary>Gets the type of authentication used to identify the user.</summary>
		/// <returns>The type of authentication used to identify the user.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">Windows returned the Windows NT status code STATUS_ACCESS_DENIED.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the correct permissions. -or-The computer is not attached to a Windows 2003 or later domain.-or-The computer is not running Windows 2003 or later.-or-The user is not a member of the domain the computer is attached to.</exception>
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0006D717 File Offset: 0x0006B917
		public sealed override string AuthenticationType
		{
			get
			{
				return this._type;
			}
		}

		/// <summary>Gets the user's Windows logon name.</summary>
		/// <returns>The Windows logon name of the user on whose behalf the code is being run.</returns>
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0006D71F File Offset: 0x0006B91F
		public override string Name
		{
			get
			{
				if (this._name == null)
				{
					this._name = WindowsIdentity.GetTokenName(this._token);
				}
				return this._name;
			}
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		// Token: 0x06001911 RID: 6417 RVA: 0x0006D740 File Offset: 0x0006B940
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this._token = (IntPtr)this._info.GetValue("m_userToken", typeof(IntPtr));
			this._name = this._info.GetString("m_name");
			if (this._name != null)
			{
				if (WindowsIdentity.GetTokenName(this._token) != this._name)
				{
					throw new SerializationException("Token-Name mismatch.");
				}
			}
			else
			{
				this._name = WindowsIdentity.GetTokenName(this._token);
				if (this._name == null)
				{
					throw new SerializationException("Token doesn't match a user.");
				}
			}
			this._type = this._info.GetString("m_type");
			this._account = (WindowsAccountType)this._info.GetValue("m_acctType", typeof(WindowsAccountType));
			this._authenticated = this._info.GetBoolean("m_isAuthenticated");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of this execution context.</summary>
		/// <param name="info">An object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <param name="context">An object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param>
		// Token: 0x06001912 RID: 6418 RVA: 0x0006D828 File Offset: 0x0006BA28
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("m_userToken", this._token);
			info.AddValue("m_name", this._name);
			info.AddValue("m_type", this._type);
			info.AddValue("m_acctType", this._account);
			info.AddValue("m_isAuthenticated", this._authenticated);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0006D894 File Offset: 0x0006BA94
		private void SetToken(IntPtr token)
		{
			if (Environment.IsUnix)
			{
				this._token = token;
				if (this._type == null)
				{
					this._type = "POSIX";
				}
				if (this._token == IntPtr.Zero)
				{
					this._account = WindowsAccountType.System;
					return;
				}
			}
			else
			{
				if (token == WindowsIdentity.invalidWindows && this._account != WindowsAccountType.Anonymous)
				{
					throw new ArgumentException("Invalid token");
				}
				this._token = token;
				if (this._type == null)
				{
					this._type = "NTLM";
				}
			}
		}

		// Token: 0x06001914 RID: 6420
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetCurrentToken();

		// Token: 0x06001915 RID: 6421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetTokenName(IntPtr token);

		// Token: 0x04000A66 RID: 2662
		private IntPtr _token;

		// Token: 0x04000A67 RID: 2663
		private string _type;

		// Token: 0x04000A68 RID: 2664
		private WindowsAccountType _account;

		// Token: 0x04000A69 RID: 2665
		private bool _authenticated;

		// Token: 0x04000A6A RID: 2666
		private string _name;

		// Token: 0x04000A6B RID: 2667
		private SerializationInfo _info;

		// Token: 0x04000A6C RID: 2668
		private static IntPtr invalidWindows = IntPtr.Zero;
	}
}
