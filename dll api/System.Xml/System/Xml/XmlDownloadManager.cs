using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x020001A1 RID: 417
	internal class XmlDownloadManager
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x0005FEE3 File Offset: 0x0005E0E3
		internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			if (uri.Scheme == "file")
			{
				return new FileStream(uri.LocalPath, FileMode.Open, FileAccess.Read, FileShare.Read, 1);
			}
			return this.GetNonFileStream(uri, credentials, proxy, cachePolicy);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0005FF14 File Offset: 0x0005E114
		private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			WebRequest webRequest = WebRequest.Create(uri);
			if (credentials != null)
			{
				webRequest.Credentials = credentials;
			}
			if (proxy != null)
			{
				webRequest.Proxy = proxy;
			}
			if (cachePolicy != null)
			{
				webRequest.CachePolicy = cachePolicy;
			}
			WebResponse response = webRequest.GetResponse();
			HttpWebRequest httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest != null)
			{
				lock (this)
				{
					if (this.connections == null)
					{
						this.connections = new Hashtable();
					}
					OpenedHost openedHost = (OpenedHost)this.connections[httpWebRequest.Address.Host];
					if (openedHost == null)
					{
						openedHost = new OpenedHost();
					}
					if (openedHost.nonCachedConnectionsCount < httpWebRequest.ServicePoint.ConnectionLimit - 1)
					{
						if (openedHost.nonCachedConnectionsCount == 0)
						{
							this.connections.Add(httpWebRequest.Address.Host, openedHost);
						}
						openedHost.nonCachedConnectionsCount++;
						return new XmlRegisteredNonCachedStream(response.GetResponseStream(), this, httpWebRequest.Address.Host);
					}
					return new XmlCachedStream(response.ResponseUri, response.GetResponseStream());
				}
			}
			return response.GetResponseStream();
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00060040 File Offset: 0x0005E240
		internal void Remove(string host)
		{
			lock (this)
			{
				OpenedHost openedHost = (OpenedHost)this.connections[host];
				if (openedHost != null)
				{
					OpenedHost openedHost2 = openedHost;
					int num = openedHost2.nonCachedConnectionsCount - 1;
					openedHost2.nonCachedConnectionsCount = num;
					if (num == 0)
					{
						this.connections.Remove(host);
					}
				}
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000600AC File Offset: 0x0005E2AC
		internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			if (uri.Scheme == "file")
			{
				return Task.Run<Stream>(() => new FileStream(uri.LocalPath, FileMode.Open, FileAccess.Read, FileShare.Read, 1, true));
			}
			return this.GetNonFileStreamAsync(uri, credentials, proxy, cachePolicy);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00060100 File Offset: 0x0005E300
		private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy)
		{
			XmlDownloadManager.<GetNonFileStreamAsync>d__5 <GetNonFileStreamAsync>d__;
			<GetNonFileStreamAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Stream>.Create();
			<GetNonFileStreamAsync>d__.<>4__this = this;
			<GetNonFileStreamAsync>d__.uri = uri;
			<GetNonFileStreamAsync>d__.credentials = credentials;
			<GetNonFileStreamAsync>d__.proxy = proxy;
			<GetNonFileStreamAsync>d__.cachePolicy = cachePolicy;
			<GetNonFileStreamAsync>d__.<>1__state = -1;
			<GetNonFileStreamAsync>d__.<>t__builder.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>(ref <GetNonFileStreamAsync>d__);
			return <GetNonFileStreamAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000AA8 RID: 2728
		private Hashtable connections;
	}
}
