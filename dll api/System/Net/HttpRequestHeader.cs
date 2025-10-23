using System;

namespace System.Net
{
	/// <summary>The HTTP headers that may be specified in a client request.</summary>
	// Token: 0x0200014E RID: 334
	public enum HttpRequestHeader
	{
		/// <summary>The Cache-Control header, which specifies directives that must be obeyed by all cache control mechanisms along the request/response chain.</summary>
		// Token: 0x040006B1 RID: 1713
		CacheControl,
		/// <summary>The Connection header, which specifies options that are desired for a particular connection.</summary>
		// Token: 0x040006B2 RID: 1714
		Connection,
		/// <summary>The Date header, which specifies the date and time at which the request originated.</summary>
		// Token: 0x040006B3 RID: 1715
		Date,
		/// <summary>The Keep-Alive header, which specifies a parameter used into order to maintain a persistent connection.</summary>
		// Token: 0x040006B4 RID: 1716
		KeepAlive,
		/// <summary>The Pragma header, which specifies implementation-specific directives that might apply to any agent along the request/response chain.</summary>
		// Token: 0x040006B5 RID: 1717
		Pragma,
		/// <summary>The Trailer header, which specifies the header fields present in the trailer of a message encoded with chunked transfer-coding.</summary>
		// Token: 0x040006B6 RID: 1718
		Trailer,
		/// <summary>The Transfer-Encoding header, which specifies what (if any) type of transformation that has been applied to the message body.</summary>
		// Token: 0x040006B7 RID: 1719
		TransferEncoding,
		/// <summary>The Upgrade header, which specifies additional communications protocols that the client supports.</summary>
		// Token: 0x040006B8 RID: 1720
		Upgrade,
		/// <summary>The Via header, which specifies intermediate protocols to be used by gateway and proxy agents.</summary>
		// Token: 0x040006B9 RID: 1721
		Via,
		/// <summary>The Warning header, which specifies additional information about that status or transformation of a message that might not be reflected in the message.</summary>
		// Token: 0x040006BA RID: 1722
		Warning,
		/// <summary>The Allow header, which specifies the set of HTTP methods supported.</summary>
		// Token: 0x040006BB RID: 1723
		Allow,
		/// <summary>The Content-Length header, which specifies the length, in bytes, of the accompanying body data.</summary>
		// Token: 0x040006BC RID: 1724
		ContentLength,
		/// <summary>The Content-Type header, which specifies the MIME type of the accompanying body data.</summary>
		// Token: 0x040006BD RID: 1725
		ContentType,
		/// <summary>The Content-Encoding header, which specifies the encodings that have been applied to the accompanying body data.</summary>
		// Token: 0x040006BE RID: 1726
		ContentEncoding,
		/// <summary>The Content-Langauge header, which specifies the natural language(s) of the accompanying body data.</summary>
		// Token: 0x040006BF RID: 1727
		ContentLanguage,
		/// <summary>The Content-Location header, which specifies a URI from which the accompanying body may be obtained.</summary>
		// Token: 0x040006C0 RID: 1728
		ContentLocation,
		/// <summary>The Content-MD5 header, which specifies the MD5 digest of the accompanying body data, for the purpose of providing an end-to-end message integrity check.</summary>
		// Token: 0x040006C1 RID: 1729
		ContentMd5,
		/// <summary>The Content-Range header, which specifies where in the full body the accompanying partial body data should be applied.</summary>
		// Token: 0x040006C2 RID: 1730
		ContentRange,
		/// <summary>The Expires header, which specifies the date and time after which the accompanying body data should be considered stale.</summary>
		// Token: 0x040006C3 RID: 1731
		Expires,
		/// <summary>The Last-Modified header, which specifies the date and time at which the accompanying body data was last modified.</summary>
		// Token: 0x040006C4 RID: 1732
		LastModified,
		/// <summary>The Accept header, which specifies the MIME types that are acceptable for the response.</summary>
		// Token: 0x040006C5 RID: 1733
		Accept,
		/// <summary>The Accept-Charset header, which specifies the character sets that are acceptable for the response.</summary>
		// Token: 0x040006C6 RID: 1734
		AcceptCharset,
		/// <summary>The Accept-Encoding header, which specifies the content encodings that are acceptable for the response.</summary>
		// Token: 0x040006C7 RID: 1735
		AcceptEncoding,
		/// <summary>The Accept-Langauge header, which specifies that natural languages that are preferred for the response.</summary>
		// Token: 0x040006C8 RID: 1736
		AcceptLanguage,
		/// <summary>The Authorization header, which specifies the credentials that the client presents in order to authenticate itself to the server.</summary>
		// Token: 0x040006C9 RID: 1737
		Authorization,
		/// <summary>The Cookie header, which specifies cookie data presented to the server.</summary>
		// Token: 0x040006CA RID: 1738
		Cookie,
		/// <summary>The Expect header, which specifies particular server behaviors that are required by the client.</summary>
		// Token: 0x040006CB RID: 1739
		Expect,
		/// <summary>The From header, which specifies an Internet E-mail address for the human user who controls the requesting user agent.</summary>
		// Token: 0x040006CC RID: 1740
		From,
		/// <summary>The Host header, which specifies the host name and port number of the resource being requested.</summary>
		// Token: 0x040006CD RID: 1741
		Host,
		/// <summary>The If-Match header, which specifies that the requested operation should be performed only if the client's cached copy of the indicated resource is current.</summary>
		// Token: 0x040006CE RID: 1742
		IfMatch,
		/// <summary>The If-Modified-Since header, which specifies that the requested operation should be performed only if the requested resource has been modified since the indicated data and time.</summary>
		// Token: 0x040006CF RID: 1743
		IfModifiedSince,
		/// <summary>The If-None-Match header, which specifies that the requested operation should be performed only if none of client's cached copies of the indicated resources are current.</summary>
		// Token: 0x040006D0 RID: 1744
		IfNoneMatch,
		/// <summary>The If-Range header, which specifies that only the specified range of the requested resource should be sent, if the client's cached copy is current.</summary>
		// Token: 0x040006D1 RID: 1745
		IfRange,
		/// <summary>The If-Unmodified-Since header, which specifies that the requested operation should be performed only if the requested resource has not been modified since the indicated date and time.</summary>
		// Token: 0x040006D2 RID: 1746
		IfUnmodifiedSince,
		/// <summary>The Max-Forwards header, which specifies an integer indicating the remaining number of times that this request may be forwarded.</summary>
		// Token: 0x040006D3 RID: 1747
		MaxForwards,
		/// <summary>The Proxy-Authorization header, which specifies the credentials that the client presents in order to authenticate itself to a proxy.</summary>
		// Token: 0x040006D4 RID: 1748
		ProxyAuthorization,
		/// <summary>The Referer header, which specifies the URI of the resource from which the request URI was obtained.</summary>
		// Token: 0x040006D5 RID: 1749
		Referer,
		/// <summary>The Range header, which specifies the the sub-range(s) of the response that the client requests be returned in lieu of the entire response.</summary>
		// Token: 0x040006D6 RID: 1750
		Range,
		/// <summary>The TE header, which specifies the transfer encodings that are acceptable for the response.</summary>
		// Token: 0x040006D7 RID: 1751
		Te,
		/// <summary>The Translate header, a Microsoft extension to the HTTP specification used in conjunction with WebDAV functionality.</summary>
		// Token: 0x040006D8 RID: 1752
		Translate,
		/// <summary>The User-Agent header, which specifies information about the client agent.</summary>
		// Token: 0x040006D9 RID: 1753
		UserAgent
	}
}
