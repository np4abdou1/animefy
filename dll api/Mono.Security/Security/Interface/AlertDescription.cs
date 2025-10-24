using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000039 RID: 57
	public enum AlertDescription : byte
	{
		// Token: 0x040000B4 RID: 180
		CloseNotify,
		// Token: 0x040000B5 RID: 181
		UnexpectedMessage = 10,
		// Token: 0x040000B6 RID: 182
		BadRecordMAC = 20,
		// Token: 0x040000B7 RID: 183
		DecryptionFailed_RESERVED,
		// Token: 0x040000B8 RID: 184
		RecordOverflow,
		// Token: 0x040000B9 RID: 185
		DecompressionFailure = 30,
		// Token: 0x040000BA RID: 186
		HandshakeFailure = 40,
		// Token: 0x040000BB RID: 187
		NoCertificate_RESERVED,
		// Token: 0x040000BC RID: 188
		BadCertificate,
		// Token: 0x040000BD RID: 189
		UnsupportedCertificate,
		// Token: 0x040000BE RID: 190
		CertificateRevoked,
		// Token: 0x040000BF RID: 191
		CertificateExpired,
		// Token: 0x040000C0 RID: 192
		CertificateUnknown,
		// Token: 0x040000C1 RID: 193
		IlegalParameter,
		// Token: 0x040000C2 RID: 194
		UnknownCA,
		// Token: 0x040000C3 RID: 195
		AccessDenied,
		// Token: 0x040000C4 RID: 196
		DecodeError,
		// Token: 0x040000C5 RID: 197
		DecryptError,
		// Token: 0x040000C6 RID: 198
		ExportRestriction = 60,
		// Token: 0x040000C7 RID: 199
		ProtocolVersion = 70,
		// Token: 0x040000C8 RID: 200
		InsuficientSecurity,
		// Token: 0x040000C9 RID: 201
		InternalError = 80,
		// Token: 0x040000CA RID: 202
		UserCancelled = 90,
		// Token: 0x040000CB RID: 203
		NoRenegotiation = 100,
		// Token: 0x040000CC RID: 204
		UnsupportedExtension = 110
	}
}
