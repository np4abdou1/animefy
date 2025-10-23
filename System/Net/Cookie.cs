using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Net
{
	/// <summary>Provides a set of properties and methods that are used to manage cookies. This class cannot be inherited.</summary>
	// Token: 0x0200017F RID: 383
	[Serializable]
	public sealed class Cookie
	{
		/// <summary>Gets or sets a comment that the server can add to a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>An optional comment to document intended usage for this <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000367E2 File Offset: 0x000349E2
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x000367EA File Offset: 0x000349EA
		public string Comment
		{
			get
			{
				return this.m_comment;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				this.m_comment = value;
			}
		}

		/// <summary>Gets or sets a URI comment that the server can provide with a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>An optional comment that represents the intended usage of the URI reference for this <see cref="T:System.Net.Cookie" />. The value must conform to URI format.</returns>
		// Token: 0x170001E1 RID: 481
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000367FD File Offset: 0x000349FD
		public Uri CommentUri
		{
			set
			{
				this.m_commentUri = value;
			}
		}

		/// <summary>Determines whether a page script or other active content can access this cookie.</summary>
		/// <returns>Boolean value that determines whether a page script or other active content can access this cookie.</returns>
		// Token: 0x170001E2 RID: 482
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00036806 File Offset: 0x00034A06
		public bool HttpOnly
		{
			set
			{
				this.m_httpOnly = value;
			}
		}

		/// <summary>Gets or sets the discard flag set by the server.</summary>
		/// <returns>
		///     <see langword="true" /> if the client is to discard the <see cref="T:System.Net.Cookie" /> at the end of the current session; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170001E3 RID: 483
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0003680F File Offset: 0x00034A0F
		public bool Discard
		{
			set
			{
				this.m_discard = value;
			}
		}

		/// <summary>Gets or sets the URI for which the <see cref="T:System.Net.Cookie" /> is valid.</summary>
		/// <returns>The URI for which the <see cref="T:System.Net.Cookie" /> is valid.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00036818 File Offset: 0x00034A18
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00036820 File Offset: 0x00034A20
		public string Domain
		{
			get
			{
				return this.m_domain;
			}
			set
			{
				this.m_domain = ((value == null) ? string.Empty : value);
				this.m_domain_implicit = false;
				this.m_domainKey = string.Empty;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00036848 File Offset: 0x00034A48
		private string _Domain
		{
			get
			{
				if (!this.Plain && !this.m_domain_implicit && this.m_domain.Length != 0)
				{
					return "$Domain=" + (this.IsQuotedDomain ? "\"" : string.Empty) + this.m_domain + (this.IsQuotedDomain ? "\"" : string.Empty);
				}
				return string.Empty;
			}
		}

		/// <summary>Gets or sets the current state of the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Net.Cookie" /> has expired; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000368B0 File Offset: 0x00034AB0
		public bool Expired
		{
			get
			{
				return this.m_expires != DateTime.MinValue && this.m_expires.ToLocalTime() <= DateTime.Now;
			}
		}

		/// <summary>Gets or sets the expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The expiration date and time for the <see cref="T:System.Net.Cookie" /> as a <see cref="T:System.DateTime" /> instance.</returns>
		// Token: 0x170001E7 RID: 487
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000368DB File Offset: 0x00034ADB
		public DateTime Expires
		{
			set
			{
				this.m_expires = value;
			}
		}

		/// <summary>Gets or sets the name for the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>The name for the <see cref="T:System.Net.Cookie" />.</returns>
		/// <exception cref="T:System.Net.CookieException">The value specified for a set operation is <see langword="null" /> or the empty string- or -The value specified for a set operation contained an illegal character. The following characters must not be used inside the <see cref="P:System.Net.Cookie.Name" /> property: equal sign, semicolon, comma, newline (\n), return (\r), tab (\t), and space character. The dollar sign character ("$") cannot be the first character.</exception>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x000368E4 File Offset: 0x00034AE4
		public string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000368EC File Offset: 0x00034AEC
		internal bool InternalSetName(string value)
		{
			if (ValidationHelper.IsBlankString(value) || value[0] == '$' || value.IndexOfAny(Cookie.Reserved2Name) != -1)
			{
				this.m_name = string.Empty;
				return false;
			}
			this.m_name = value;
			return true;
		}

		/// <summary>Gets or sets the URIs to which the <see cref="T:System.Net.Cookie" /> applies.</summary>
		/// <returns>The URIs to which the <see cref="T:System.Net.Cookie" /> applies.</returns>
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00036924 File Offset: 0x00034B24
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0003692C File Offset: 0x00034B2C
		public string Path
		{
			get
			{
				return this.m_path;
			}
			set
			{
				this.m_path = ((value == null) ? string.Empty : value);
				this.m_path_implicit = false;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00036946 File Offset: 0x00034B46
		private string _Path
		{
			get
			{
				if (!this.Plain && !this.m_path_implicit && this.m_path.Length != 0)
				{
					return "$Path=" + this.m_path;
				}
				return string.Empty;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0003697B File Offset: 0x00034B7B
		internal bool Plain
		{
			get
			{
				return this.Variant == CookieVariant.Plain;
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00036986 File Offset: 0x00034B86
		private static bool IsDomainEqualToHost(string domain, string host)
		{
			return host.Length + 1 == domain.Length && string.Compare(host, 0, domain, 1, host.Length, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000369B0 File Offset: 0x00034BB0
		internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			string host = uri.Host;
			int port = uri.Port;
			string absolutePath = uri.AbsolutePath;
			bool flag = true;
			if (set_default)
			{
				if (this.Version == 0)
				{
					variant = CookieVariant.Plain;
				}
				else if (this.Version == 1 && variant == CookieVariant.Unknown)
				{
					variant = CookieVariant.Rfc2109;
				}
				this.m_cookieVariant = variant;
			}
			if (this.m_name == null || this.m_name.Length == 0 || this.m_name[0] == '$' || this.m_name.IndexOfAny(Cookie.Reserved2Name) != -1)
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Name",
						(this.m_name == null) ? "<null>" : this.m_name
					}));
				}
				return false;
			}
			else if (this.m_value == null || ((this.m_value.Length <= 2 || this.m_value[0] != '"' || this.m_value[this.m_value.Length - 1] != '"') && this.m_value.IndexOfAny(Cookie.Reserved2Value) != -1))
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Value",
						(this.m_value == null) ? "<null>" : this.m_value
					}));
				}
				return false;
			}
			else if (this.Comment != null && (this.Comment.Length <= 2 || this.Comment[0] != '"' || this.Comment[this.Comment.Length - 1] != '"') && this.Comment.IndexOfAny(Cookie.Reserved2Value) != -1)
			{
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Comment",
						this.Comment
					}));
				}
				return false;
			}
			else
			{
				if (this.Path == null || (this.Path.Length > 2 && this.Path[0] == '"' && this.Path[this.Path.Length - 1] == '"') || this.Path.IndexOfAny(Cookie.Reserved2Value) == -1)
				{
					if (set_default && this.m_domain_implicit)
					{
						this.m_domain = host;
					}
					else
					{
						if (!this.m_domain_implicit)
						{
							string text = this.m_domain;
							if (!Cookie.DomainCharsTest(text))
							{
								if (isThrow)
								{
									throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
									{
										"Domain",
										(text == null) ? "<null>" : text
									}));
								}
								return false;
							}
							else
							{
								if (text[0] != '.')
								{
									if (variant != CookieVariant.Rfc2965 && variant != CookieVariant.Plain)
									{
										if (isThrow)
										{
											throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
											{
												"Domain",
												this.m_domain
											}));
										}
										return false;
									}
									else
									{
										text = "." + text;
									}
								}
								int num = host.IndexOf('.');
								if (isLocalDomain && string.Compare(localDomain, text, StringComparison.OrdinalIgnoreCase) == 0)
								{
									flag = true;
								}
								else if (text.IndexOf('.', 1, text.Length - 2) == -1)
								{
									if (!Cookie.IsDomainEqualToHost(text, host))
									{
										flag = false;
									}
								}
								else if (variant == CookieVariant.Plain)
								{
									if (!Cookie.IsDomainEqualToHost(text, host) && (host.Length <= text.Length || string.Compare(host, host.Length - text.Length, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) != 0))
									{
										flag = false;
									}
								}
								else if ((num == -1 || text.Length != host.Length - num || string.Compare(host, num, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) != 0) && !Cookie.IsDomainEqualToHost(text, host))
								{
									flag = false;
								}
								if (flag)
								{
									this.m_domainKey = text.ToLower(CultureInfo.InvariantCulture);
								}
							}
						}
						else if (string.Compare(host, this.m_domain, StringComparison.OrdinalIgnoreCase) != 0)
						{
							flag = false;
						}
						if (!flag)
						{
							if (isThrow)
							{
								throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
								{
									"Domain",
									this.m_domain
								}));
							}
							return false;
						}
					}
					if (set_default && this.m_path_implicit)
					{
						switch (this.m_cookieVariant)
						{
						case CookieVariant.Plain:
							this.m_path = absolutePath;
							goto IL_4B8;
						case CookieVariant.Rfc2109:
							this.m_path = absolutePath.Substring(0, absolutePath.LastIndexOf('/'));
							goto IL_4B8;
						}
						this.m_path = absolutePath.Substring(0, absolutePath.LastIndexOf('/') + 1);
					}
					else if (!absolutePath.StartsWith(CookieParser.CheckQuoted(this.m_path)))
					{
						if (isThrow)
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Path",
								this.m_path
							}));
						}
						return false;
					}
					IL_4B8:
					if (set_default && !this.m_port_implicit && this.m_port.Length == 0)
					{
						this.m_port_list = new int[]
						{
							port
						};
					}
					if (!this.m_port_implicit)
					{
						flag = false;
						int[] port_list = this.m_port_list;
						for (int i = 0; i < port_list.Length; i++)
						{
							if (port_list[i] == port)
							{
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							if (isThrow)
							{
								throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
								{
									"Port",
									this.m_port
								}));
							}
							return false;
						}
					}
					return true;
				}
				if (isThrow)
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Path",
						this.Path
					}));
				}
				return false;
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00036F00 File Offset: 0x00035100
		private static bool DomainCharsTest(string name)
		{
			if (name == null || name.Length == 0)
			{
				return false;
			}
			foreach (char c in name)
			{
				if ((c < '0' || c > '9') && c != '.' && c != '-' && (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '_')
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Gets or sets a list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</summary>
		/// <returns>The list of TCP ports that the <see cref="T:System.Net.Cookie" /> applies to.</returns>
		/// <exception cref="T:System.Net.CookieException">The value specified for a set operation could not be parsed or is not enclosed in double quotes. </exception>
		// Token: 0x170001EC RID: 492
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00036F64 File Offset: 0x00035164
		public string Port
		{
			set
			{
				this.m_port_implicit = false;
				if (value == null || value.Length == 0)
				{
					this.m_port = string.Empty;
					return;
				}
				if (value[0] != '"' || value[value.Length - 1] != '"')
				{
					throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
					{
						"Port",
						value
					}));
				}
				string[] array = value.Split(Cookie.PortSplitDelimiters);
				List<int> list = new List<int>();
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != string.Empty)
					{
						int num;
						if (!int.TryParse(array[i], out num))
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Port",
								value
							}));
						}
						if (num < 0 || num > 65535)
						{
							throw new CookieException(SR.GetString("The '{0}'='{1}' part of the cookie is invalid.", new object[]
							{
								"Port",
								value
							}));
						}
						list.Add(num);
					}
				}
				this.m_port_list = list.ToArray();
				this.m_port = value;
				this.m_version = 1;
				this.m_cookieVariant = CookieVariant.Rfc2965;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00037081 File Offset: 0x00035281
		internal int[] PortList
		{
			get
			{
				return this.m_port_list;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00037089 File Offset: 0x00035289
		private string _Port
		{
			get
			{
				if (!this.m_port_implicit)
				{
					return "$Port" + ((this.m_port.Length == 0) ? string.Empty : ("=" + this.m_port));
				}
				return string.Empty;
			}
		}

		/// <summary>Gets or sets the security level of a <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the client is only to return the cookie in subsequent requests if those requests use Secure Hypertext Transfer Protocol (HTTPS); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000370C7 File Offset: 0x000352C7
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x000370CF File Offset: 0x000352CF
		public bool Secure
		{
			get
			{
				return this.m_secure;
			}
			set
			{
				this.m_secure = value;
			}
		}

		/// <summary>Gets or sets the <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</summary>
		/// <returns>The <see cref="P:System.Net.Cookie.Value" /> for the <see cref="T:System.Net.Cookie" />.</returns>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000370D8 File Offset: 0x000352D8
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000370E0 File Offset: 0x000352E0
		public string Value
		{
			get
			{
				return this.m_value;
			}
			set
			{
				this.m_value = ((value == null) ? string.Empty : value);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000370F3 File Offset: 0x000352F3
		internal CookieVariant Variant
		{
			get
			{
				return this.m_cookieVariant;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000370FB File Offset: 0x000352FB
		internal string DomainKey
		{
			get
			{
				if (!this.m_domain_implicit)
				{
					return this.m_domainKey;
				}
				return this.Domain;
			}
		}

		/// <summary>Gets or sets the version of HTTP state maintenance to which the cookie conforms.</summary>
		/// <returns>The version of HTTP state maintenance to which the cookie conforms.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a version is not allowed. </exception>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00037112 File Offset: 0x00035312
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0003711A File Offset: 0x0003531A
		public int Version
		{
			get
			{
				return this.m_version;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.m_version = value;
				if (value > 0 && this.m_cookieVariant < CookieVariant.Rfc2109)
				{
					this.m_cookieVariant = CookieVariant.Rfc2109;
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00037148 File Offset: 0x00035348
		private string _Version
		{
			get
			{
				if (this.Version != 0)
				{
					return "$Version=" + (this.IsQuotedVersion ? "\"" : string.Empty) + this.m_version.ToString(NumberFormatInfo.InvariantInfo) + (this.IsQuotedVersion ? "\"" : string.Empty);
				}
				return string.Empty;
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000371A5 File Offset: 0x000353A5
		internal static IComparer GetComparer()
		{
			return Cookie.staticComparer;
		}

		/// <summary>Overrides the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary>
		/// <param name="comparand">A reference to a <see cref="T:System.Net.Cookie" />. </param>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Net.Cookie" /> is equal to <paramref name="comparand" />. Two <see cref="T:System.Net.Cookie" /> instances are equal if their <see cref="P:System.Net.Cookie.Name" />, <see cref="P:System.Net.Cookie.Value" />, <see cref="P:System.Net.Cookie.Path" />, <see cref="P:System.Net.Cookie.Domain" />, and <see cref="P:System.Net.Cookie.Version" /> properties are equal. <see cref="P:System.Net.Cookie.Name" /> and <see cref="P:System.Net.Cookie.Domain" /> string comparisons are case-insensitive.</returns>
		// Token: 0x06000A70 RID: 2672 RVA: 0x000371AC File Offset: 0x000353AC
		public override bool Equals(object comparand)
		{
			if (!(comparand is Cookie))
			{
				return false;
			}
			Cookie cookie = (Cookie)comparand;
			return string.Compare(this.Name, cookie.Name, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(this.Value, cookie.Value, StringComparison.Ordinal) == 0 && string.Compare(this.Path, cookie.Path, StringComparison.Ordinal) == 0 && string.Compare(this.Domain, cookie.Domain, StringComparison.OrdinalIgnoreCase) == 0 && this.Version == cookie.Version;
		}

		/// <summary>Overrides the <see cref="M:System.Object.GetHashCode" /> method.</summary>
		/// <returns>The 32-bit signed integer hash code for this instance.</returns>
		// Token: 0x06000A71 RID: 2673 RVA: 0x0003722C File Offset: 0x0003542C
		public override int GetHashCode()
		{
			return string.Concat(new string[]
			{
				this.Name,
				"=",
				this.Value,
				";",
				this.Path,
				"; ",
				this.Domain,
				"; ",
				this.Version.ToString()
			}).GetHashCode();
		}

		/// <summary>Overrides the <see cref="M:System.Object.ToString" /> method.</summary>
		/// <returns>Returns a string representation of this <see cref="T:System.Net.Cookie" /> object that is suitable for including in a HTTP Cookie: request header.</returns>
		// Token: 0x06000A72 RID: 2674 RVA: 0x000372A0 File Offset: 0x000354A0
		public override string ToString()
		{
			string domain = this._Domain;
			string path = this._Path;
			string port = this._Port;
			string version = this._Version;
			string text = string.Concat(new string[]
			{
				(version.Length == 0) ? string.Empty : (version + "; "),
				this.Name,
				"=",
				this.Value,
				(path.Length == 0) ? string.Empty : ("; " + path),
				(domain.Length == 0) ? string.Empty : ("; " + domain),
				(port.Length == 0) ? string.Empty : ("; " + port)
			});
			if (text == "=")
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x04000786 RID: 1926
		internal static readonly char[] PortSplitDelimiters = new char[]
		{
			' ',
			',',
			'"'
		};

		// Token: 0x04000787 RID: 1927
		internal static readonly char[] Reserved2Name = new char[]
		{
			' ',
			'\t',
			'\r',
			'\n',
			'=',
			';',
			','
		};

		// Token: 0x04000788 RID: 1928
		internal static readonly char[] Reserved2Value = new char[]
		{
			';',
			','
		};

		// Token: 0x04000789 RID: 1929
		private static Comparer staticComparer = new Comparer();

		// Token: 0x0400078A RID: 1930
		private string m_comment = string.Empty;

		// Token: 0x0400078B RID: 1931
		private Uri m_commentUri;

		// Token: 0x0400078C RID: 1932
		private CookieVariant m_cookieVariant = CookieVariant.Plain;

		// Token: 0x0400078D RID: 1933
		private bool m_discard;

		// Token: 0x0400078E RID: 1934
		private string m_domain = string.Empty;

		// Token: 0x0400078F RID: 1935
		private bool m_domain_implicit = true;

		// Token: 0x04000790 RID: 1936
		private DateTime m_expires = DateTime.MinValue;

		// Token: 0x04000791 RID: 1937
		private string m_name = string.Empty;

		// Token: 0x04000792 RID: 1938
		private string m_path = string.Empty;

		// Token: 0x04000793 RID: 1939
		private bool m_path_implicit = true;

		// Token: 0x04000794 RID: 1940
		private string m_port = string.Empty;

		// Token: 0x04000795 RID: 1941
		private bool m_port_implicit = true;

		// Token: 0x04000796 RID: 1942
		private int[] m_port_list;

		// Token: 0x04000797 RID: 1943
		private bool m_secure;

		// Token: 0x04000798 RID: 1944
		[OptionalField]
		private bool m_httpOnly;

		// Token: 0x04000799 RID: 1945
		private DateTime m_timeStamp = DateTime.Now;

		// Token: 0x0400079A RID: 1946
		private string m_value = string.Empty;

		// Token: 0x0400079B RID: 1947
		private int m_version;

		// Token: 0x0400079C RID: 1948
		private string m_domainKey = string.Empty;

		// Token: 0x0400079D RID: 1949
		internal bool IsQuotedVersion;

		// Token: 0x0400079E RID: 1950
		internal bool IsQuotedDomain;
	}
}
