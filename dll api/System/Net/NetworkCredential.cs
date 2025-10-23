using System;
using System.Security;

namespace System.Net
{
	/// <summary>Provides credentials for password-based authentication schemes such as basic, digest, NTLM, and Kerberos authentication.</summary>
	// Token: 0x0200015C RID: 348
	public class NetworkCredential : ICredentials
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name and password.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		// Token: 0x06000975 RID: 2421 RVA: 0x000338D5 File Offset: 0x00031AD5
		public NetworkCredential(string userName, string password) : this(userName, password, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.NetworkCredential" /> class with the specified user name, password, and domain.</summary>
		/// <param name="userName">The user name associated with the credentials. </param>
		/// <param name="password">The password for the user name associated with the credentials. </param>
		/// <param name="domain">The domain associated with these credentials. </param>
		// Token: 0x06000976 RID: 2422 RVA: 0x000338E4 File Offset: 0x00031AE4
		public NetworkCredential(string userName, string password, string domain)
		{
			this.UserName = userName;
			this.Password = password;
			this.Domain = domain;
		}

		/// <summary>Gets or sets the user name associated with the credentials.</summary>
		/// <returns>The user name associated with the credentials.</returns>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00033901 File Offset: 0x00031B01
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00033909 File Offset: 0x00031B09
		public string UserName
		{
			get
			{
				return this.InternalGetUserName();
			}
			set
			{
				if (value == null)
				{
					this.m_userName = string.Empty;
					return;
				}
				this.m_userName = value;
			}
		}

		/// <summary>Gets or sets the password for the user name associated with the credentials.</summary>
		/// <returns>The password associated with the credentials. If this <see cref="T:System.Net.NetworkCredential" /> instance was initialized with the <paramref name="password" /> parameter set to <see langword="null" />, then the <see cref="P:System.Net.NetworkCredential.Password" /> property will return an empty string.</returns>
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00033921 File Offset: 0x00031B21
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00033929 File Offset: 0x00031B29
		public string Password
		{
			get
			{
				return this.InternalGetPassword();
			}
			set
			{
				this.m_password = UnsafeNclNativeMethods.SecureStringHelper.CreateSecureString(value);
			}
		}

		/// <summary>Gets or sets the domain or computer name that verifies the credentials.</summary>
		/// <returns>The name of the domain associated with the credentials.</returns>
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00033937 File Offset: 0x00031B37
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0003393F File Offset: 0x00031B3F
		public string Domain
		{
			get
			{
				return this.InternalGetDomain();
			}
			set
			{
				if (value == null)
				{
					this.m_domain = string.Empty;
					return;
				}
				this.m_domain = value;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00033957 File Offset: 0x00031B57
		internal string InternalGetUserName()
		{
			return this.m_userName;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0003395F File Offset: 0x00031B5F
		internal string InternalGetPassword()
		{
			return UnsafeNclNativeMethods.SecureStringHelper.CreateString(this.m_password);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003396C File Offset: 0x00031B6C
		internal string InternalGetDomain()
		{
			return this.m_domain;
		}

		/// <summary>Returns an instance of the <see cref="T:System.Net.NetworkCredential" /> class for the specified Uniform Resource Identifier (URI) and authentication type.</summary>
		/// <param name="uri">The URI that the client provides authentication for. </param>
		/// <param name="authType">The type of authentication requested, as defined in the <see cref="P:System.Net.IAuthenticationModule.AuthenticationType" /> property. </param>
		/// <returns>A <see cref="T:System.Net.NetworkCredential" /> object.</returns>
		// Token: 0x06000980 RID: 2432 RVA: 0x00014B09 File Offset: 0x00012D09
		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			return this;
		}

		// Token: 0x040006F7 RID: 1783
		private string m_domain;

		// Token: 0x040006F8 RID: 1784
		private string m_userName;

		// Token: 0x040006F9 RID: 1785
		private SecureString m_password;
	}
}
