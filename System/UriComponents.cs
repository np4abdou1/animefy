using System;

namespace System
{
	/// <summary>Specifies the parts of a <see cref="T:System.Uri" />.</summary>
	// Token: 0x02000080 RID: 128
	[Flags]
	public enum UriComponents
	{
		/// <summary>The <see cref="P:System.Uri.Scheme" /> data.</summary>
		// Token: 0x0400020C RID: 524
		Scheme = 1,
		/// <summary>The <see cref="P:System.Uri.UserInfo" /> data.</summary>
		// Token: 0x0400020D RID: 525
		UserInfo = 2,
		/// <summary>The <see cref="P:System.Uri.Host" /> data.</summary>
		// Token: 0x0400020E RID: 526
		Host = 4,
		/// <summary>The <see cref="P:System.Uri.Port" /> data.</summary>
		// Token: 0x0400020F RID: 527
		Port = 8,
		/// <summary>The <see cref="P:System.Uri.LocalPath" /> data.</summary>
		// Token: 0x04000210 RID: 528
		Path = 16,
		/// <summary>The <see cref="P:System.Uri.Query" /> data.</summary>
		// Token: 0x04000211 RID: 529
		Query = 32,
		/// <summary>The <see cref="P:System.Uri.Fragment" /> data.</summary>
		// Token: 0x04000212 RID: 530
		Fragment = 64,
		/// <summary>The <see cref="P:System.Uri.Port" /> data. If no port data is in the <see cref="T:System.Uri" /> and a default port has been assigned to the <see cref="P:System.Uri.Scheme" />, the default port is returned. If there is no default port, -1 is returned.</summary>
		// Token: 0x04000213 RID: 531
		StrongPort = 128,
		/// <summary>The normalized form of the <see cref="P:System.Uri.Host" />.</summary>
		// Token: 0x04000214 RID: 532
		NormalizedHost = 256,
		/// <summary>Specifies that the delimiter should be included.</summary>
		// Token: 0x04000215 RID: 533
		KeepDelimiter = 1073741824,
		/// <summary>The complete <see cref="T:System.Uri" /> context that is needed for Uri Serializers. The context includes the IPv6 scope.</summary>
		// Token: 0x04000216 RID: 534
		SerializationInfoString = -2147483648,
		/// <summary>The <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.UserInfo" />, <see cref="P:System.Uri.Host" />, <see cref="P:System.Uri.Port" />, <see cref="P:System.Uri.LocalPath" />, <see cref="P:System.Uri.Query" />, and <see cref="P:System.Uri.Fragment" /> data.</summary>
		// Token: 0x04000217 RID: 535
		AbsoluteUri = 127,
		/// <summary>The <see cref="P:System.Uri.Host" /> and <see cref="P:System.Uri.Port" /> data. If no port data is in the Uri and a default port has been assigned to the <see cref="P:System.Uri.Scheme" />, the default port is returned. If there is no default port, -1 is returned.</summary>
		// Token: 0x04000218 RID: 536
		HostAndPort = 132,
		/// <summary>The <see cref="P:System.Uri.UserInfo" />, <see cref="P:System.Uri.Host" />, and <see cref="P:System.Uri.Port" /> data. If no port data is in the <see cref="T:System.Uri" /> and a default port has been assigned to the <see cref="P:System.Uri.Scheme" />, the default port is returned. If there is no default port, -1 is returned.</summary>
		// Token: 0x04000219 RID: 537
		StrongAuthority = 134,
		/// <summary>The <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.Host" />, and <see cref="P:System.Uri.Port" /> data.</summary>
		// Token: 0x0400021A RID: 538
		SchemeAndServer = 13,
		/// <summary>The <see cref="P:System.Uri.Scheme" />, <see cref="P:System.Uri.Host" />, <see cref="P:System.Uri.Port" />, <see cref="P:System.Uri.LocalPath" />, and <see cref="P:System.Uri.Query" /> data.</summary>
		// Token: 0x0400021B RID: 539
		HttpRequestUrl = 61,
		/// <summary>The <see cref="P:System.Uri.LocalPath" /> and <see cref="P:System.Uri.Query" /> data. Also see <see cref="P:System.Uri.PathAndQuery" />. </summary>
		// Token: 0x0400021C RID: 540
		PathAndQuery = 48
	}
}
