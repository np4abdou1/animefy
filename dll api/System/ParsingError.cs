using System;

namespace System
{
	// Token: 0x02000083 RID: 131
	internal enum ParsingError
	{
		// Token: 0x04000226 RID: 550
		None,
		// Token: 0x04000227 RID: 551
		BadFormat,
		// Token: 0x04000228 RID: 552
		BadScheme,
		// Token: 0x04000229 RID: 553
		BadAuthority,
		// Token: 0x0400022A RID: 554
		EmptyUriString,
		// Token: 0x0400022B RID: 555
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x0400022C RID: 556
		SchemeLimit,
		// Token: 0x0400022D RID: 557
		SizeLimit,
		// Token: 0x0400022E RID: 558
		MustRootedPath,
		// Token: 0x0400022F RID: 559
		BadHostName,
		// Token: 0x04000230 RID: 560
		NonEmptyHost,
		// Token: 0x04000231 RID: 561
		BadPort,
		// Token: 0x04000232 RID: 562
		BadAuthorityTerminator,
		// Token: 0x04000233 RID: 563
		CannotCreateRelative
	}
}
