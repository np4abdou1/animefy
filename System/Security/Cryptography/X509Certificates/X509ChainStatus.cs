using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Provides a simple structure for storing X509 chain status and error information.</summary>
	// Token: 0x02000100 RID: 256
	public struct X509ChainStatus
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0002A285 File Offset: 0x00028485
		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			this.status = flag;
			this.info = X509ChainStatus.GetInformation(flag);
		}

		/// <summary>Specifies the status of the X509 chain.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainStatusFlags" /> value.</returns>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0002A29A File Offset: 0x0002849A
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0002A2A2 File Offset: 0x000284A2
		public X509ChainStatusFlags Status
		{
			get
			{
				return this.status;
			}
			set
			{
				this.status = value;
			}
		}

		/// <summary>Specifies a description of the <see cref="P:System.Security.Cryptography.X509Certificates.X509Chain.ChainStatus" /> value.</summary>
		/// <returns>A localizable string.</returns>
		// Token: 0x17000143 RID: 323
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0002A2AB File Offset: 0x000284AB
		public string StatusInformation
		{
			set
			{
				this.info = value;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0002A2B4 File Offset: 0x000284B4
		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			if (flags <= X509ChainStatusFlags.InvalidNameConstraints)
			{
				if (flags <= X509ChainStatusFlags.RevocationStatusUnknown)
				{
					if (flags <= X509ChainStatusFlags.NotValidForUsage)
					{
						switch (flags)
						{
						case X509ChainStatusFlags.NoError:
						case X509ChainStatusFlags.NotTimeValid | X509ChainStatusFlags.NotTimeNested:
						case X509ChainStatusFlags.NotTimeValid | X509ChainStatusFlags.Revoked:
						case X509ChainStatusFlags.NotTimeNested | X509ChainStatusFlags.Revoked:
						case X509ChainStatusFlags.NotTimeValid | X509ChainStatusFlags.NotTimeNested | X509ChainStatusFlags.Revoked:
							goto IL_125;
						case X509ChainStatusFlags.NotTimeValid:
						case X509ChainStatusFlags.NotTimeNested:
						case X509ChainStatusFlags.Revoked:
						case X509ChainStatusFlags.NotSignatureValid:
							break;
						default:
							if (flags != X509ChainStatusFlags.NotValidForUsage)
							{
								goto IL_125;
							}
							break;
						}
					}
					else if (flags != X509ChainStatusFlags.UntrustedRoot && flags != X509ChainStatusFlags.RevocationStatusUnknown)
					{
						goto IL_125;
					}
				}
				else if (flags <= X509ChainStatusFlags.InvalidExtension)
				{
					if (flags != X509ChainStatusFlags.Cyclic && flags != X509ChainStatusFlags.InvalidExtension)
					{
						goto IL_125;
					}
				}
				else if (flags != X509ChainStatusFlags.InvalidPolicyConstraints && flags != X509ChainStatusFlags.InvalidBasicConstraints && flags != X509ChainStatusFlags.InvalidNameConstraints)
				{
					goto IL_125;
				}
			}
			else if (flags <= X509ChainStatusFlags.PartialChain)
			{
				if (flags <= X509ChainStatusFlags.HasNotDefinedNameConstraint)
				{
					if (flags != X509ChainStatusFlags.HasNotSupportedNameConstraint && flags != X509ChainStatusFlags.HasNotDefinedNameConstraint)
					{
						goto IL_125;
					}
				}
				else if (flags != X509ChainStatusFlags.HasNotPermittedNameConstraint && flags != X509ChainStatusFlags.HasExcludedNameConstraint && flags != X509ChainStatusFlags.PartialChain)
				{
					goto IL_125;
				}
			}
			else if (flags <= X509ChainStatusFlags.CtlNotSignatureValid)
			{
				if (flags != X509ChainStatusFlags.CtlNotTimeValid && flags != X509ChainStatusFlags.CtlNotSignatureValid)
				{
					goto IL_125;
				}
			}
			else if (flags != X509ChainStatusFlags.CtlNotValidForUsage && flags != X509ChainStatusFlags.OfflineRevocation && flags != X509ChainStatusFlags.NoIssuanceChainPolicy)
			{
				goto IL_125;
			}
			return Locale.GetText(flags.ToString());
			IL_125:
			return string.Empty;
		}

		// Token: 0x04000500 RID: 1280
		private X509ChainStatusFlags status;

		// Token: 0x04000501 RID: 1281
		private string info;
	}
}
