using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Parses a new URI scheme. This is an abstract class.</summary>
	// Token: 0x02000087 RID: 135
	public abstract class UriParser
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00014AF9 File Offset: 0x00012CF9
		internal string SchemeName
		{
			get
			{
				return this.m_Scheme;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00014B01 File Offset: 0x00012D01
		internal int DefaultPort
		{
			get
			{
				return this.m_Port;
			}
		}

		/// <summary>Invoked by a <see cref="T:System.Uri" /> constructor to get a <see cref="T:System.UriParser" /> instance</summary>
		/// <returns>A <see cref="T:System.UriParser" /> for the constructed <see cref="T:System.Uri" />.</returns>
		// Token: 0x06000383 RID: 899 RVA: 0x00014B09 File Offset: 0x00012D09
		protected virtual UriParser OnNewUri()
		{
			return this;
		}

		/// <summary>Initialize the state of the parser and validate the URI.</summary>
		/// <param name="uri">The T:System.Uri to validate.</param>
		/// <param name="parsingError">Validation errors, if any.</param>
		// Token: 0x06000384 RID: 900 RVA: 0x00014B0C File Offset: 0x00012D0C
		protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
		{
			parsingError = uri.ParseMinimal();
		}

		/// <summary>Called by <see cref="T:System.Uri" /> constructors and <see cref="Overload:System.Uri.TryCreate" /> to resolve a relative URI.</summary>
		/// <param name="baseUri">A base URI.</param>
		/// <param name="relativeUri">A relative URI.</param>
		/// <param name="parsingError">Errors during the resolve process, if any.</param>
		/// <returns>The string of the resolved relative <see cref="T:System.Uri" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="baseUri" /> parameter is not an absolute <see cref="T:System.Uri" />- or -
		///         <paramref name="baseUri" /> parameter requires user-driven parsing.</exception>
		// Token: 0x06000385 RID: 901 RVA: 0x00014B18 File Offset: 0x00012D18
		protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
		{
			if (baseUri.UserDrivenParsing)
			{
				throw new InvalidOperationException(SR.GetString("A derived type '{0}' is responsible for parsing this Uri instance. The base implementation must not be used.", new object[]
				{
					base.GetType().FullName
				}));
			}
			if (!baseUri.IsAbsoluteUri)
			{
				throw new InvalidOperationException(SR.GetString("This operation is not supported for a relative URI."));
			}
			string result = null;
			bool flag = false;
			Uri uri = Uri.ResolveHelper(baseUri, relativeUri, ref result, ref flag, out parsingError);
			if (parsingError != null)
			{
				return null;
			}
			if (uri != null)
			{
				return uri.OriginalString;
			}
			return result;
		}

		/// <summary>Determines whether <paramref name="baseUri" /> is a base URI for <paramref name="relativeUri" />.</summary>
		/// <param name="baseUri">The base URI.</param>
		/// <param name="relativeUri">The URI to test.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="baseUri" /> is a base URI for <paramref name="relativeUri" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000386 RID: 902 RVA: 0x00014B91 File Offset: 0x00012D91
		protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
		{
			return baseUri.IsBaseOfHelper(relativeUri);
		}

		/// <summary>Gets the components from a URI.</summary>
		/// <param name="uri">The URI to parse.</param>
		/// <param name="components">The <see cref="T:System.UriComponents" /> to retrieve from <paramref name="uri" />.</param>
		/// <param name="format">One of the <see cref="T:System.UriFormat" /> values that controls how special characters are escaped.</param>
		/// <returns>A string that contains the components.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="uriFormat" /> is invalid.- or -
		///         <paramref name="uriComponents" /> is not a combination of valid <see cref="T:System.UriComponents" /> values. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="uri" /> requires user-driven parsing- or -
		///         <paramref name="uri" /> is not an absolute URI. Relative URIs cannot be used with this method.</exception>
		// Token: 0x06000387 RID: 903 RVA: 0x00014B9C File Offset: 0x00012D9C
		protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
		{
			if ((components & UriComponents.SerializationInfoString) != (UriComponents)0 && components != UriComponents.SerializationInfoString)
			{
				throw new ArgumentOutOfRangeException("components", components, SR.GetString("UriComponents.SerializationInfoString must not be combined with other UriComponents."));
			}
			if ((format & (UriFormat)(-4)) != (UriFormat)0)
			{
				throw new ArgumentOutOfRangeException("format");
			}
			if (uri.UserDrivenParsing)
			{
				throw new InvalidOperationException(SR.GetString("A derived type '{0}' is responsible for parsing this Uri instance. The base implementation must not be used.", new object[]
				{
					base.GetType().FullName
				}));
			}
			if (!uri.IsAbsoluteUri)
			{
				throw new InvalidOperationException(SR.GetString("This operation is not supported for a relative URI."));
			}
			return uri.GetComponentsHelper(components, format);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00014C32 File Offset: 0x00012E32
		internal static bool ShouldUseLegacyV2Quirks
		{
			get
			{
				return UriParser.s_QuirksVersion <= UriParser.UriQuirksVersion.V2;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00014C40 File Offset: 0x00012E40
		static UriParser()
		{
			UriParser.m_Table = new Dictionary<string, UriParser>(25);
			UriParser.m_TempTable = new Dictionary<string, UriParser>(25);
			UriParser.HttpUri = new UriParser.BuiltInUriParser("http", 80, UriParser.HttpSyntaxFlags);
			UriParser.m_Table[UriParser.HttpUri.SchemeName] = UriParser.HttpUri;
			UriParser.HttpsUri = new UriParser.BuiltInUriParser("https", 443, UriParser.HttpUri.m_Flags);
			UriParser.m_Table[UriParser.HttpsUri.SchemeName] = UriParser.HttpsUri;
			UriParser.WsUri = new UriParser.BuiltInUriParser("ws", 80, UriParser.HttpSyntaxFlags);
			UriParser.m_Table[UriParser.WsUri.SchemeName] = UriParser.WsUri;
			UriParser.WssUri = new UriParser.BuiltInUriParser("wss", 443, UriParser.HttpSyntaxFlags);
			UriParser.m_Table[UriParser.WssUri.SchemeName] = UriParser.WssUri;
			UriParser.FtpUri = new UriParser.BuiltInUriParser("ftp", 21, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.FtpUri.SchemeName] = UriParser.FtpUri;
			UriParser.FileUri = new UriParser.BuiltInUriParser("file", -1, UriParser.FileSyntaxFlags);
			UriParser.m_Table[UriParser.FileUri.SchemeName] = UriParser.FileUri;
			UriParser.GopherUri = new UriParser.BuiltInUriParser("gopher", 70, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.GopherUri.SchemeName] = UriParser.GopherUri;
			UriParser.NntpUri = new UriParser.BuiltInUriParser("nntp", 119, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.NntpUri.SchemeName] = UriParser.NntpUri;
			UriParser.NewsUri = new UriParser.BuiltInUriParser("news", -1, UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.NewsUri.SchemeName] = UriParser.NewsUri;
			UriParser.MailToUri = new UriParser.BuiltInUriParser("mailto", 25, UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.MailToLikeUri | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.MailToUri.SchemeName] = UriParser.MailToUri;
			UriParser.UuidUri = new UriParser.BuiltInUriParser("uuid", -1, UriParser.NewsUri.m_Flags);
			UriParser.m_Table[UriParser.UuidUri.SchemeName] = UriParser.UuidUri;
			UriParser.TelnetUri = new UriParser.BuiltInUriParser("telnet", 23, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.TelnetUri.SchemeName] = UriParser.TelnetUri;
			UriParser.LdapUri = new UriParser.BuiltInUriParser("ldap", 389, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.LdapUri.SchemeName] = UriParser.LdapUri;
			UriParser.NetTcpUri = new UriParser.BuiltInUriParser("net.tcp", 808, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.NetTcpUri.SchemeName] = UriParser.NetTcpUri;
			UriParser.NetPipeUri = new UriParser.BuiltInUriParser("net.pipe", -1, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.NetPipeUri.SchemeName] = UriParser.NetPipeUri;
			UriParser.VsMacrosUri = new UriParser.BuiltInUriParser("vsmacros", -1, UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
			UriParser.m_Table[UriParser.VsMacrosUri.SchemeName] = UriParser.VsMacrosUri;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00014FE9 File Offset: 0x000131E9
		internal UriSyntaxFlags Flags
		{
			get
			{
				return this.m_Flags;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00014FF1 File Offset: 0x000131F1
		internal bool NotAny(UriSyntaxFlags flags)
		{
			return this.IsFullMatch(flags, UriSyntaxFlags.None);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00014FFB File Offset: 0x000131FB
		internal bool InFact(UriSyntaxFlags flags)
		{
			return !this.IsFullMatch(flags, UriSyntaxFlags.None);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00015008 File Offset: 0x00013208
		internal bool IsAllSet(UriSyntaxFlags flags)
		{
			return this.IsFullMatch(flags, flags);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00015014 File Offset: 0x00013214
		private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
		{
			UriSyntaxFlags uriSyntaxFlags;
			if ((flags & UriSyntaxFlags.UnEscapeDotsAndSlashes) == UriSyntaxFlags.None || !this.m_UpdatableFlagsUsed)
			{
				uriSyntaxFlags = this.m_Flags;
			}
			else
			{
				uriSyntaxFlags = ((this.m_Flags & ~UriSyntaxFlags.UnEscapeDotsAndSlashes) | this.m_UpdatableFlags);
			}
			return (uriSyntaxFlags & flags) == expected;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00015059 File Offset: 0x00013259
		internal UriParser(UriSyntaxFlags flags)
		{
			this.m_Flags = flags;
			this.m_Scheme = string.Empty;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00015074 File Offset: 0x00013274
		internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			UriParser uriParser = null;
			UriParser.m_Table.TryGetValue(lwrCaseScheme, out uriParser);
			if (uriParser != null)
			{
				return uriParser;
			}
			UriParser.m_TempTable.TryGetValue(lwrCaseScheme, out uriParser);
			if (uriParser != null)
			{
				return uriParser;
			}
			Dictionary<string, UriParser> table = UriParser.m_Table;
			UriParser result;
			lock (table)
			{
				if (UriParser.m_TempTable.Count >= 512)
				{
					UriParser.m_TempTable = new Dictionary<string, UriParser>(25);
				}
				uriParser = new UriParser.BuiltInUriParser(lwrCaseScheme, -1, UriSyntaxFlags.OptionalAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.V1_UnknownUri | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing);
				UriParser.m_TempTable[lwrCaseScheme] = uriParser;
				result = uriParser;
			}
			return result;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00015110 File Offset: 0x00013310
		internal static UriParser GetSyntax(string lwrCaseScheme)
		{
			UriParser uriParser = null;
			UriParser.m_Table.TryGetValue(lwrCaseScheme, out uriParser);
			if (uriParser == null)
			{
				UriParser.m_TempTable.TryGetValue(lwrCaseScheme, out uriParser);
			}
			return uriParser;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001513F File Offset: 0x0001333F
		internal bool IsSimple
		{
			get
			{
				return this.InFact(UriSyntaxFlags.SimpleUserSyntax);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001514C File Offset: 0x0001334C
		internal UriParser InternalOnNewUri()
		{
			UriParser uriParser = this.OnNewUri();
			if (this != uriParser)
			{
				uriParser.m_Scheme = this.m_Scheme;
				uriParser.m_Port = this.m_Port;
				uriParser.m_Flags = this.m_Flags;
			}
			return uriParser;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00015189 File Offset: 0x00013389
		internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
		{
			this.InitializeAndValidate(thisUri, out parsingError);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00015193 File Offset: 0x00013393
		internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
		{
			return this.Resolve(thisBaseUri, uriLink, out parsingError);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001519E File Offset: 0x0001339E
		internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
		{
			return this.IsBaseOf(thisBaseUri, uriLink);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000151A8 File Offset: 0x000133A8
		internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
		{
			return this.GetComponents(thisUri, uriComponents, uriFormat);
		}

		// Token: 0x04000243 RID: 579
		private static readonly Dictionary<string, UriParser> m_Table;

		// Token: 0x04000244 RID: 580
		private static Dictionary<string, UriParser> m_TempTable;

		// Token: 0x04000245 RID: 581
		private UriSyntaxFlags m_Flags;

		// Token: 0x04000246 RID: 582
		private volatile UriSyntaxFlags m_UpdatableFlags;

		// Token: 0x04000247 RID: 583
		private volatile bool m_UpdatableFlagsUsed;

		// Token: 0x04000248 RID: 584
		private int m_Port;

		// Token: 0x04000249 RID: 585
		private string m_Scheme;

		// Token: 0x0400024A RID: 586
		internal static UriParser HttpUri;

		// Token: 0x0400024B RID: 587
		internal static UriParser HttpsUri;

		// Token: 0x0400024C RID: 588
		internal static UriParser WsUri;

		// Token: 0x0400024D RID: 589
		internal static UriParser WssUri;

		// Token: 0x0400024E RID: 590
		internal static UriParser FtpUri;

		// Token: 0x0400024F RID: 591
		internal static UriParser FileUri;

		// Token: 0x04000250 RID: 592
		internal static UriParser GopherUri;

		// Token: 0x04000251 RID: 593
		internal static UriParser NntpUri;

		// Token: 0x04000252 RID: 594
		internal static UriParser NewsUri;

		// Token: 0x04000253 RID: 595
		internal static UriParser MailToUri;

		// Token: 0x04000254 RID: 596
		internal static UriParser UuidUri;

		// Token: 0x04000255 RID: 597
		internal static UriParser TelnetUri;

		// Token: 0x04000256 RID: 598
		internal static UriParser LdapUri;

		// Token: 0x04000257 RID: 599
		internal static UriParser NetTcpUri;

		// Token: 0x04000258 RID: 600
		internal static UriParser NetPipeUri;

		// Token: 0x04000259 RID: 601
		internal static UriParser VsMacrosUri;

		// Token: 0x0400025A RID: 602
		private static readonly UriParser.UriQuirksVersion s_QuirksVersion = BinaryCompatibility.TargetsAtLeast_Desktop_V4_5 ? UriParser.UriQuirksVersion.V3 : UriParser.UriQuirksVersion.V2;

		// Token: 0x0400025B RID: 603
		private static readonly UriSyntaxFlags HttpSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHaveUserInfo | UriSyntaxFlags.MayHavePort | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveQuery | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | (UriParser.ShouldUseLegacyV2Quirks ? UriSyntaxFlags.UnEscapeDotsAndSlashes : UriSyntaxFlags.None) | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x0400025C RID: 604
		private static readonly UriSyntaxFlags FileSyntaxFlags = UriSyntaxFlags.MustHaveAuthority | UriSyntaxFlags.MayHavePath | UriSyntaxFlags.MayHaveFragment | UriSyntaxFlags.AllowEmptyHost | UriSyntaxFlags.AllowUncHost | UriSyntaxFlags.AllowDnsHost | UriSyntaxFlags.AllowIPv4Host | UriSyntaxFlags.AllowIPv6Host | (UriParser.ShouldUseLegacyV2Quirks ? UriSyntaxFlags.None : UriSyntaxFlags.MayHaveQuery) | UriSyntaxFlags.FileLikeUri | UriSyntaxFlags.PathIsRooted | UriSyntaxFlags.AllowDOSPath | UriSyntaxFlags.ConvertPathSlashes | UriSyntaxFlags.CompressPath | UriSyntaxFlags.CanonicalizeAsFilePath | UriSyntaxFlags.UnEscapeDotsAndSlashes | UriSyntaxFlags.AllowIdn | UriSyntaxFlags.AllowIriParsing;

		// Token: 0x02000088 RID: 136
		private enum UriQuirksVersion
		{
			// Token: 0x0400025E RID: 606
			V2 = 2,
			// Token: 0x0400025F RID: 607
			V3
		}

		// Token: 0x02000089 RID: 137
		private class BuiltInUriParser : UriParser
		{
			// Token: 0x06000398 RID: 920 RVA: 0x000151B3 File Offset: 0x000133B3
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) : base(syntaxFlags | UriSyntaxFlags.SimpleUserSyntax | UriSyntaxFlags.BuiltInSyntax)
			{
				this.m_Scheme = lwrCaseScheme;
				this.m_Port = defaultPort;
			}
		}
	}
}
