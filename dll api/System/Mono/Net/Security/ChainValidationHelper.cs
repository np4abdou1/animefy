using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000013 RID: 19
	internal class ChainValidationHelper : ICertificateValidator
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002F35 File Offset: 0x00001135
		internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings)
		{
			if (settings == null)
			{
				return new ChainValidationHelper(owner, provider, null, false, null);
			}
			if (settings.CertificateValidator != null)
			{
				return (ChainValidationHelper)settings.CertificateValidator;
			}
			return new ChainValidationHelper(owner, provider, settings, false, null);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002F64 File Offset: 0x00001164
		internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream)
		{
			ChainValidationHelper chainValidationHelper = new ChainValidationHelper(null, provider, settings, true, stream);
			settings = chainValidationHelper.settings;
			return chainValidationHelper;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F88 File Offset: 0x00001188
		private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream)
		{
			if (settings == null)
			{
				settings = MonoTlsSettings.CopyDefaultSettings();
			}
			if (cloneSettings)
			{
				settings = settings.CloneWithValidator(this);
			}
			if (provider == null)
			{
				provider = MonoTlsProviderFactory.GetProviderInternal();
			}
			this.provider = provider;
			this.settings = settings;
			this.tlsStream = stream;
			if (owner != null)
			{
				this.owner = new WeakReference<SslStream>(owner);
			}
			bool flag = false;
			if (settings != null)
			{
				this.certValidationCallback = ChainValidationHelper.GetValidationCallback(settings);
				this.certSelectionCallback = CallbackHelpers.MonoToInternal(settings.ClientCertificateSelectionCallback);
				flag = (settings.UseServicePointManagerCallback ?? (stream != null));
			}
			if (stream != null)
			{
				this.request = stream.Request;
				if (this.certValidationCallback == null)
				{
					this.certValidationCallback = this.request.ServerCertValidationCallback;
				}
				if (this.certSelectionCallback == null)
				{
					this.certSelectionCallback = new LocalCertSelectionCallback(ChainValidationHelper.DefaultSelectionCallback);
				}
				if (settings == null)
				{
					flag = true;
				}
			}
			if (flag && this.certValidationCallback == null)
			{
				this.certValidationCallback = ServicePointManager.ServerCertValidationCallback;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003084 File Offset: 0x00001284
		private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings)
		{
			if (settings.RemoteCertificateValidationCallback == null)
			{
				return null;
			}
			return new ServerCertValidationCallback(delegate(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e)
			{
				string text = null;
				SslStream sslStream = s as SslStream;
				if (sslStream != null)
				{
					text = sslStream.InternalTargetHost;
				}
				else
				{
					HttpWebRequest httpWebRequest = s as HttpWebRequest;
					if (httpWebRequest != null)
					{
						text = httpWebRequest.Host;
						if (!string.IsNullOrEmpty(text))
						{
							int num = text.IndexOf(':');
							if (num > 0)
							{
								text = text.Substring(0, num);
							}
						}
					}
				}
				return settings.RemoteCertificateValidationCallback(text, c, ch, (MonoSslPolicyErrors)e);
			});
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000030C0 File Offset: 0x000012C0
		private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers)
		{
			X509Certificate result;
			if (localCertificates == null || localCertificates.Count == 0)
			{
				result = null;
			}
			else
			{
				result = localCertificates[0];
			}
			return result;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000030E5 File Offset: 0x000012E5
		public MonoTlsSettings Settings
		{
			get
			{
				return this.settings;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000030ED File Offset: 0x000012ED
		public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate)
		{
			if (this.certSelectionCallback == null)
			{
				clientCertificate = null;
				return false;
			}
			clientCertificate = this.certSelectionCallback(targetHost, localCertificates, remoteCertificate, acceptableIssuers);
			return true;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003114 File Offset: 0x00001314
		public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain)
		{
			ValidationResult result;
			try
			{
				ValidationResult validationResult = this.ValidateChain(host, serverMode, leaf, chain, null, SslPolicyErrors.None);
				if (this.tlsStream != null)
				{
					this.tlsStream.CertificateValidationFailed = (validationResult == null || !validationResult.Trusted || validationResult.UserDenied);
				}
				result = validationResult;
			}
			catch
			{
				if (this.tlsStream != null)
				{
					this.tlsStream.CertificateValidationFailed = true;
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003184 File Offset: 0x00001384
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			X509Chain x509Chain = chain;
			bool flag = chain == null;
			ValidationResult result;
			try
			{
				ValidationResult validationResult = this.ValidateChain(host, server, leaf, ref chain, certs, errors);
				if (chain != x509Chain)
				{
					flag = true;
				}
				result = validationResult;
			}
			finally
			{
				if (flag && chain != null)
				{
					chain.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000031D4 File Offset: 0x000013D4
		private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors)
		{
			bool user_denied = false;
			bool flag = false;
			if (this.tlsStream != null)
			{
				this.request.ServicePoint.UpdateServerCertificate(leaf);
			}
			if (leaf == null)
			{
				errors |= SslPolicyErrors.RemoteCertificateNotAvailable;
				if (this.certValidationCallback != null)
				{
					flag = this.InvokeCallback(leaf, null, errors);
					user_denied = !flag;
				}
				return new ValidationResult(flag, user_denied, 0, new MonoSslPolicyErrors?((MonoSslPolicyErrors)errors));
			}
			if (!string.IsNullOrEmpty(host))
			{
				int num = host.IndexOf(':');
				if (num > 0)
				{
					host = host.Substring(0, num);
				}
			}
			ICertificatePolicy legacyCertificatePolicy = ServicePointManager.GetLegacyCertificatePolicy();
			int num2 = 0;
			bool flag2 = SystemCertificateValidator.NeedsChain(this.settings);
			if (!flag2 && this.certValidationCallback != null && (this.settings == null || this.settings.CallbackNeedsCertificateChain))
			{
				flag2 = true;
			}
			flag = this.provider.ValidateCertificate(this, host, server, certs, flag2, ref chain, ref errors, ref num2);
			if (num2 == 0 && errors != SslPolicyErrors.None)
			{
				num2 = -2146762485;
			}
			if (legacyCertificatePolicy != null && (!(legacyCertificatePolicy is DefaultCertificatePolicy) || this.certValidationCallback == null))
			{
				ServicePoint srvPoint = null;
				if (this.request != null)
				{
					srvPoint = this.request.ServicePointNoLock;
				}
				flag = legacyCertificatePolicy.CheckValidationResult(srvPoint, leaf, this.request, num2);
				user_denied = (!flag && !(legacyCertificatePolicy is DefaultCertificatePolicy));
			}
			if (this.certValidationCallback != null)
			{
				flag = this.InvokeCallback(leaf, chain, errors);
				user_denied = !flag;
			}
			return new ValidationResult(flag, user_denied, num2, new MonoSslPolicyErrors?((MonoSslPolicyErrors)errors));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003328 File Offset: 0x00001528
		private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors)
		{
			object obj = null;
			SslStream sslStream;
			if (this.request != null)
			{
				obj = this.request;
			}
			else if (this.owner != null && this.owner.TryGetTarget(out sslStream))
			{
				obj = sslStream;
			}
			return this.certValidationCallback.Invoke(obj, leaf, chain, errors);
		}

		// Token: 0x04000033 RID: 51
		private readonly WeakReference<SslStream> owner;

		// Token: 0x04000034 RID: 52
		private readonly MonoTlsSettings settings;

		// Token: 0x04000035 RID: 53
		private readonly MobileTlsProvider provider;

		// Token: 0x04000036 RID: 54
		private readonly ServerCertValidationCallback certValidationCallback;

		// Token: 0x04000037 RID: 55
		private readonly LocalCertSelectionCallback certSelectionCallback;

		// Token: 0x04000038 RID: 56
		private readonly MonoTlsStream tlsStream;

		// Token: 0x04000039 RID: 57
		private readonly HttpWebRequest request;
	}
}
