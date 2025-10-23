using System;

namespace Mono.Security.Interface
{
	// Token: 0x0200003A RID: 58
	public class Alert
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00009B74 File Offset: 0x00007D74
		public AlertLevel Level
		{
			get
			{
				return this.level;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00009B7C File Offset: 0x00007D7C
		public AlertDescription Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009B84 File Offset: 0x00007D84
		public Alert(AlertDescription description)
		{
			this.description = description;
			this.inferAlertLevel();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009B9C File Offset: 0x00007D9C
		private void inferAlertLevel()
		{
			AlertDescription alertDescription = this.description;
			if (alertDescription <= AlertDescription.ExportRestriction)
			{
				if (alertDescription <= AlertDescription.UnexpectedMessage)
				{
					if (alertDescription != AlertDescription.CloseNotify)
					{
						if (alertDescription != AlertDescription.UnexpectedMessage)
						{
							goto IL_C5;
						}
						goto IL_C5;
					}
				}
				else
				{
					if (alertDescription - AlertDescription.BadRecordMAC <= 2)
					{
						goto IL_C5;
					}
					switch (alertDescription)
					{
					case AlertDescription.DecompressionFailure:
					case (AlertDescription)31:
					case (AlertDescription)32:
					case (AlertDescription)33:
					case (AlertDescription)34:
					case (AlertDescription)35:
					case (AlertDescription)36:
					case (AlertDescription)37:
					case (AlertDescription)38:
					case (AlertDescription)39:
					case AlertDescription.HandshakeFailure:
					case AlertDescription.NoCertificate_RESERVED:
					case AlertDescription.BadCertificate:
					case AlertDescription.UnsupportedCertificate:
					case AlertDescription.CertificateRevoked:
					case AlertDescription.CertificateExpired:
					case AlertDescription.CertificateUnknown:
					case AlertDescription.IlegalParameter:
					case AlertDescription.UnknownCA:
					case AlertDescription.AccessDenied:
					case AlertDescription.DecodeError:
					case AlertDescription.DecryptError:
						goto IL_C5;
					default:
						if (alertDescription != AlertDescription.ExportRestriction)
						{
							goto IL_C5;
						}
						goto IL_C5;
					}
				}
			}
			else if (alertDescription <= AlertDescription.InternalError)
			{
				if (alertDescription - AlertDescription.ProtocolVersion > 1 && alertDescription != AlertDescription.InternalError)
				{
					goto IL_C5;
				}
				goto IL_C5;
			}
			else if (alertDescription != AlertDescription.UserCancelled && alertDescription != AlertDescription.NoRenegotiation)
			{
				if (alertDescription != AlertDescription.UnsupportedExtension)
				{
					goto IL_C5;
				}
				goto IL_C5;
			}
			this.level = AlertLevel.Warning;
			return;
			IL_C5:
			this.level = AlertLevel.Fatal;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00009C75 File Offset: 0x00007E75
		public override string ToString()
		{
			return string.Format("[Alert: {0}:{1}]", this.Level, this.Description);
		}

		// Token: 0x040000CD RID: 205
		private AlertLevel level;

		// Token: 0x040000CE RID: 206
		private AlertDescription description;
	}
}
