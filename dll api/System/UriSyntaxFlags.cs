using System;

namespace System
{
	// Token: 0x0200008C RID: 140
	[Flags]
	internal enum UriSyntaxFlags
	{
		// Token: 0x04000261 RID: 609
		None = 0,
		// Token: 0x04000262 RID: 610
		MustHaveAuthority = 1,
		// Token: 0x04000263 RID: 611
		OptionalAuthority = 2,
		// Token: 0x04000264 RID: 612
		MayHaveUserInfo = 4,
		// Token: 0x04000265 RID: 613
		MayHavePort = 8,
		// Token: 0x04000266 RID: 614
		MayHavePath = 16,
		// Token: 0x04000267 RID: 615
		MayHaveQuery = 32,
		// Token: 0x04000268 RID: 616
		MayHaveFragment = 64,
		// Token: 0x04000269 RID: 617
		AllowEmptyHost = 128,
		// Token: 0x0400026A RID: 618
		AllowUncHost = 256,
		// Token: 0x0400026B RID: 619
		AllowDnsHost = 512,
		// Token: 0x0400026C RID: 620
		AllowIPv4Host = 1024,
		// Token: 0x0400026D RID: 621
		AllowIPv6Host = 2048,
		// Token: 0x0400026E RID: 622
		AllowAnInternetHost = 3584,
		// Token: 0x0400026F RID: 623
		AllowAnyOtherHost = 4096,
		// Token: 0x04000270 RID: 624
		FileLikeUri = 8192,
		// Token: 0x04000271 RID: 625
		MailToLikeUri = 16384,
		// Token: 0x04000272 RID: 626
		V1_UnknownUri = 65536,
		// Token: 0x04000273 RID: 627
		SimpleUserSyntax = 131072,
		// Token: 0x04000274 RID: 628
		BuiltInSyntax = 262144,
		// Token: 0x04000275 RID: 629
		ParserSchemeOnly = 524288,
		// Token: 0x04000276 RID: 630
		AllowDOSPath = 1048576,
		// Token: 0x04000277 RID: 631
		PathIsRooted = 2097152,
		// Token: 0x04000278 RID: 632
		ConvertPathSlashes = 4194304,
		// Token: 0x04000279 RID: 633
		CompressPath = 8388608,
		// Token: 0x0400027A RID: 634
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x0400027B RID: 635
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x0400027C RID: 636
		AllowIdn = 67108864,
		// Token: 0x0400027D RID: 637
		AllowIriParsing = 268435456
	}
}
