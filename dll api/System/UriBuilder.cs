using System;

namespace System
{
	/// <summary>Provides a custom constructor for uniform resource identifiers (URIs) and modifies URIs for the <see cref="T:System.Uri" /> class.</summary>
	// Token: 0x02000074 RID: 116
	public class UriBuilder
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified URI.</summary>
		/// <param name="uri">A URI string. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="uri" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.UriFormatException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.
		///         <paramref name="uri" /> is a zero length string or contains only spaces.-or- The parsing routine detected a scheme in an invalid form.-or- The parser detected more than two consecutive slashes in a URI that does not use the "file" scheme.-or- 
		///         <paramref name="uri" /> is not a valid URI. </exception>
		// Token: 0x060002D9 RID: 729 RVA: 0x0000B920 File Offset: 0x00009B20
		public UriBuilder(string uri)
		{
			Uri uri2 = new Uri(uri, UriKind.RelativeOrAbsolute);
			if (uri2.IsAbsoluteUri)
			{
				this.Init(uri2);
				return;
			}
			uri = Uri.UriSchemeHttp + Uri.SchemeDelimiter + uri;
			this.Init(new Uri(uri));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.UriBuilder" /> class with the specified <see cref="T:System.Uri" /> instance.</summary>
		/// <param name="uri">An instance of the <see cref="T:System.Uri" /> class. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="uri" /> is <see langword="null" />. </exception>
		// Token: 0x060002DA RID: 730 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public UriBuilder(Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			this.Init(uri);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000BA60 File Offset: 0x00009C60
		private void Init(Uri uri)
		{
			this._fragment = uri.Fragment;
			this._query = uri.Query;
			this._host = uri.Host;
			this._path = uri.AbsolutePath;
			this._port = uri.Port;
			this._scheme = uri.Scheme;
			this._schemeDelimiter = (uri.HasAuthority ? Uri.SchemeDelimiter : ":");
			string userInfo = uri.UserInfo;
			if (!string.IsNullOrEmpty(userInfo))
			{
				int num = userInfo.IndexOf(':');
				if (num != -1)
				{
					this._password = userInfo.Substring(num + 1);
					this._username = userInfo.Substring(0, num);
				}
				else
				{
					this._username = userInfo;
				}
			}
			this.SetFieldsFromUri(uri);
		}

		/// <summary>Gets or sets the path to the resource referenced by the URI.</summary>
		/// <returns>The path to the resource referenced by the URI.</returns>
		// Token: 0x1700006E RID: 110
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000BB18 File Offset: 0x00009D18
		public string Path
		{
			set
			{
				if (value == null || value.Length == 0)
				{
					value = "/";
				}
				this._path = Uri.InternalEscapeString(value.Replace('\\', '/'));
				this._changed = true;
			}
		}

		/// <summary>Gets or sets any query information included in the URI.</summary>
		/// <returns>The query information included in the URI.</returns>
		// Token: 0x1700006F RID: 111
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000BB48 File Offset: 0x00009D48
		public string Query
		{
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (value.Length > 0 && value[0] != '?')
				{
					value = "?" + value;
				}
				this._query = value;
				this._changed = true;
			}
		}

		/// <summary>Gets the <see cref="T:System.Uri" /> instance constructed by the specified <see cref="T:System.UriBuilder" /> instance.</summary>
		/// <returns>A <see cref="T:System.Uri" /> that contains the URI constructed by the <see cref="T:System.UriBuilder" />.</returns>
		/// <exception cref="T:System.UriFormatException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The URI constructed by the <see cref="T:System.UriBuilder" /> properties is invalid. </exception>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000BB83 File Offset: 0x00009D83
		public Uri Uri
		{
			get
			{
				if (this._changed)
				{
					this._uri = new Uri(this.ToString());
					this.SetFieldsFromUri(this._uri);
					this._changed = false;
				}
				return this._uri;
			}
		}

		/// <summary>Compares an existing <see cref="T:System.Uri" /> instance with the contents of the <see cref="T:System.UriBuilder" /> for equality.</summary>
		/// <param name="rparam">The object to compare with the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="rparam" /> represents the same <see cref="T:System.Uri" /> as the <see cref="T:System.Uri" /> constructed by this <see cref="T:System.UriBuilder" /> instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060002DF RID: 735 RVA: 0x0000BBB7 File Offset: 0x00009DB7
		public override bool Equals(object rparam)
		{
			return rparam != null && this.Uri.Equals(rparam.ToString());
		}

		/// <summary>Returns the hash code for the URI.</summary>
		/// <returns>The hash code generated for the URI.</returns>
		// Token: 0x060002E0 RID: 736 RVA: 0x0000BBCF File Offset: 0x00009DCF
		public override int GetHashCode()
		{
			return this.Uri.GetHashCode();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000BBDC File Offset: 0x00009DDC
		private void SetFieldsFromUri(Uri uri)
		{
			this._fragment = uri.Fragment;
			this._query = uri.Query;
			this._host = uri.Host;
			this._path = uri.AbsolutePath;
			this._port = uri.Port;
			this._scheme = uri.Scheme;
			this._schemeDelimiter = (uri.HasAuthority ? Uri.SchemeDelimiter : ":");
			string userInfo = uri.UserInfo;
			if (userInfo.Length > 0)
			{
				int num = userInfo.IndexOf(':');
				if (num != -1)
				{
					this._password = userInfo.Substring(num + 1);
					this._username = userInfo.Substring(0, num);
					return;
				}
				this._username = userInfo;
			}
		}

		/// <summary>Returns the display string for the specified <see cref="T:System.UriBuilder" /> instance.</summary>
		/// <returns>The string that contains the unescaped display string of the <see cref="T:System.UriBuilder" />.</returns>
		/// <exception cref="T:System.UriFormatException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The <see cref="T:System.UriBuilder" /> instance has a bad password. </exception>
		// Token: 0x060002E2 RID: 738 RVA: 0x0000BC90 File Offset: 0x00009E90
		public override string ToString()
		{
			if (this._username.Length == 0 && this._password.Length > 0)
			{
				throw new UriFormatException("Invalid URI: The username:password construct is badly formed.");
			}
			if (this._scheme.Length != 0)
			{
				UriParser syntax = UriParser.GetSyntax(this._scheme);
				if (syntax != null)
				{
					this._schemeDelimiter = ((syntax.InFact(UriSyntaxFlags.MustHaveAuthority) || (this._host.Length != 0 && syntax.NotAny(UriSyntaxFlags.MailToLikeUri) && syntax.InFact(UriSyntaxFlags.OptionalAuthority))) ? Uri.SchemeDelimiter : ":");
				}
				else
				{
					this._schemeDelimiter = ((this._host.Length != 0) ? Uri.SchemeDelimiter : ":");
				}
			}
			string text = (this._scheme.Length != 0) ? (this._scheme + this._schemeDelimiter) : string.Empty;
			return string.Concat(new string[]
			{
				text,
				this._username,
				(this._password.Length > 0) ? (":" + this._password) : string.Empty,
				(this._username.Length > 0) ? "@" : string.Empty,
				this._host,
				(this._port != -1 && this._host.Length > 0) ? (":" + this._port.ToString()) : string.Empty,
				(this._host.Length > 0 && this._path.Length != 0 && this._path[0] != '/') ? "/" : string.Empty,
				this._path,
				this._query,
				this._fragment
			});
		}

		// Token: 0x04000187 RID: 391
		private bool _changed = true;

		// Token: 0x04000188 RID: 392
		private string _fragment = string.Empty;

		// Token: 0x04000189 RID: 393
		private string _host = "localhost";

		// Token: 0x0400018A RID: 394
		private string _password = string.Empty;

		// Token: 0x0400018B RID: 395
		private string _path = "/";

		// Token: 0x0400018C RID: 396
		private int _port = -1;

		// Token: 0x0400018D RID: 397
		private string _query = string.Empty;

		// Token: 0x0400018E RID: 398
		private string _scheme = "http";

		// Token: 0x0400018F RID: 399
		private string _schemeDelimiter = Uri.SchemeDelimiter;

		// Token: 0x04000190 RID: 400
		private Uri _uri;

		// Token: 0x04000191 RID: 401
		private string _username = string.Empty;
	}
}
