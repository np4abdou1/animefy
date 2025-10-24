using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Mono.Security.Interface
{
	// Token: 0x02000044 RID: 68
	public sealed class MonoTlsSettings
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00009D25 File Offset: 0x00007F25
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00009D2D File Offset: 0x00007F2D
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00009D36 File Offset: 0x00007F36
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00009D3E File Offset: 0x00007F3E
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00009D47 File Offset: 0x00007F47
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00009D4F File Offset: 0x00007F4F
		public bool? UseServicePointManagerCallback
		{
			get
			{
				return this.useServicePointManagerCallback;
			}
			set
			{
				this.useServicePointManagerCallback = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00009D58 File Offset: 0x00007F58
		public bool CallbackNeedsCertificateChain
		{
			get
			{
				return this.callbackNeedsChain;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00009D60 File Offset: 0x00007F60
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00009D68 File Offset: 0x00007F68
		public DateTime? CertificateValidationTime { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00009D71 File Offset: 0x00007F71
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00009D79 File Offset: 0x00007F79
		public X509CertificateCollection TrustAnchors { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00009D82 File Offset: 0x00007F82
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00009D8A File Offset: 0x00007F8A
		public object UserSettings { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00009D93 File Offset: 0x00007F93
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00009D9B File Offset: 0x00007F9B
		internal string[] CertificateSearchPaths { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00009DA4 File Offset: 0x00007FA4
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00009DAC File Offset: 0x00007FAC
		internal bool SendCloseNotify { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00009DB5 File Offset: 0x00007FB5
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00009DBD File Offset: 0x00007FBD
		public string[] ClientCertificateIssuers { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00009DC6 File Offset: 0x00007FC6
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00009DCE File Offset: 0x00007FCE
		public bool DisallowUnauthenticatedCertificateRequest { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009DD7 File Offset: 0x00007FD7
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00009DDF File Offset: 0x00007FDF
		public TlsProtocols? EnabledProtocols { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00009DE8 File Offset: 0x00007FE8
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00009DF0 File Offset: 0x00007FF0
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers { get; set; }

		// Token: 0x06000170 RID: 368 RVA: 0x00009DF9 File Offset: 0x00007FF9
		public MonoTlsSettings()
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00009E0F File Offset: 0x0000800F
		public static MonoTlsSettings DefaultSettings
		{
			get
			{
				if (MonoTlsSettings.defaultSettings == null)
				{
					Interlocked.CompareExchange<MonoTlsSettings>(ref MonoTlsSettings.defaultSettings, new MonoTlsSettings(), null);
				}
				return MonoTlsSettings.defaultSettings;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009E2E File Offset: 0x0000802E
		public static MonoTlsSettings CopyDefaultSettings()
		{
			return MonoTlsSettings.DefaultSettings.Clone();
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00009E3A File Offset: 0x0000803A
		public ICertificateValidator CertificateValidator
		{
			get
			{
				return this.certificateValidator;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009E42 File Offset: 0x00008042
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			if (this.cloned)
			{
				this.certificateValidator = validator;
				return this;
			}
			return new MonoTlsSettings(this)
			{
				certificateValidator = validator
			};
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009E62 File Offset: 0x00008062
		public MonoTlsSettings Clone()
		{
			return new MonoTlsSettings(this);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00009E6C File Offset: 0x0000806C
		private MonoTlsSettings(MonoTlsSettings other)
		{
			this.RemoteCertificateValidationCallback = other.RemoteCertificateValidationCallback;
			this.ClientCertificateSelectionCallback = other.ClientCertificateSelectionCallback;
			this.checkCertName = other.checkCertName;
			this.checkCertRevocationStatus = other.checkCertRevocationStatus;
			this.UseServicePointManagerCallback = other.useServicePointManagerCallback;
			this.skipSystemValidators = other.skipSystemValidators;
			this.callbackNeedsChain = other.callbackNeedsChain;
			this.UserSettings = other.UserSettings;
			this.EnabledProtocols = other.EnabledProtocols;
			this.EnabledCiphers = other.EnabledCiphers;
			this.CertificateValidationTime = other.CertificateValidationTime;
			this.SendCloseNotify = other.SendCloseNotify;
			this.ClientCertificateIssuers = other.ClientCertificateIssuers;
			this.DisallowUnauthenticatedCertificateRequest = other.DisallowUnauthenticatedCertificateRequest;
			if (other.TrustAnchors != null)
			{
				this.TrustAnchors = new X509CertificateCollection(other.TrustAnchors);
			}
			if (other.CertificateSearchPaths != null)
			{
				this.CertificateSearchPaths = new string[other.CertificateSearchPaths.Length];
				other.CertificateSearchPaths.CopyTo(this.CertificateSearchPaths, 0);
			}
			this.cloned = true;
		}

		// Token: 0x040001F1 RID: 497
		private bool cloned;

		// Token: 0x040001F2 RID: 498
		private bool checkCertName = true;

		// Token: 0x040001F3 RID: 499
		private bool checkCertRevocationStatus;

		// Token: 0x040001F4 RID: 500
		private bool? useServicePointManagerCallback;

		// Token: 0x040001F5 RID: 501
		private bool skipSystemValidators;

		// Token: 0x040001F6 RID: 502
		private bool callbackNeedsChain = true;

		// Token: 0x040001F7 RID: 503
		private ICertificateValidator certificateValidator;

		// Token: 0x040001F8 RID: 504
		private static MonoTlsSettings defaultSettings;
	}
}
