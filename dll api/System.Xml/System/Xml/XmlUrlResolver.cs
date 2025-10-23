using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml
{
	/// <summary>Resolves external XML resources named by a Uniform Resource Identifier (URI).</summary>
	// Token: 0x020001BC RID: 444
	public class XmlUrlResolver : XmlResolver
	{
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00061E68 File Offset: 0x00060068
		private static XmlDownloadManager DownloadManager
		{
			get
			{
				if (XmlUrlResolver.s_DownloadManager == null)
				{
					object value = new XmlDownloadManager();
					Interlocked.CompareExchange<object>(ref XmlUrlResolver.s_DownloadManager, value, null);
				}
				return (XmlDownloadManager)XmlUrlResolver.s_DownloadManager;
			}
		}

		/// <summary>Maps a URI to an object that contains the actual resource.</summary>
		/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
		/// <param name="role">Currently not used.</param>
		/// <param name="ofObjectToReturn">The type of object to return. The current implementation only returns <see cref="T:System.IO.Stream" /> objects.</param>
		/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="ofObjectToReturn" /> is neither <see langword="null" /> nor a <see langword="Stream" /> type.</exception>
		/// <exception cref="T:System.UriFormatException">The specified URI is not an absolute URI.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="absoluteUri" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Exception">There is a runtime error (for example, an interrupted server connection).</exception>
		// Token: 0x06000F3F RID: 3903 RVA: 0x00061EA4 File Offset: 0x000600A4
		public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			if (ofObjectToReturn == null || ofObjectToReturn == typeof(Stream) || ofObjectToReturn == typeof(object))
			{
				return XmlUrlResolver.DownloadManager.GetStream(absoluteUri, this._credentials, this._proxy, this._cachePolicy);
			}
			throw new XmlException("Object type is not supported.", string.Empty);
		}

		/// <summary>Resolves the absolute URI from the base and relative URIs.</summary>
		/// <param name="baseUri">The base URI used to resolve the relative URI.</param>
		/// <param name="relativeUri">The URI to resolve. The URI can be absolute or relative. If absolute, this value effectively replaces the <paramref name="baseUri" /> value. If relative, it combines with the <paramref name="baseUri" /> to make an absolute URI.</param>
		/// <returns>The absolute URI, or <see langword="null" /> if the relative URI cannot be resolved.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="baseUri" /> is <see langword="null" /> or <paramref name="relativeUri" /> is <see langword="null" />.</exception>
		// Token: 0x06000F40 RID: 3904 RVA: 0x00061F0B File Offset: 0x0006010B
		public override Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			return base.ResolveUri(baseUri, relativeUri);
		}

		/// <summary>Asynchronously maps a URI to an object that contains the actual resource.</summary>
		/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
		/// <param name="role">Currently not used.</param>
		/// <param name="ofObjectToReturn">The type of object to return. The current implementation only returns <see cref="T:System.IO.Stream" /> objects.</param>
		/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
		// Token: 0x06000F41 RID: 3905 RVA: 0x00061F18 File Offset: 0x00060118
		public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			XmlUrlResolver.<GetEntityAsync>d__15 <GetEntityAsync>d__;
			<GetEntityAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<GetEntityAsync>d__.<>4__this = this;
			<GetEntityAsync>d__.absoluteUri = absoluteUri;
			<GetEntityAsync>d__.ofObjectToReturn = ofObjectToReturn;
			<GetEntityAsync>d__.<>1__state = -1;
			<GetEntityAsync>d__.<>t__builder.Start<XmlUrlResolver.<GetEntityAsync>d__15>(ref <GetEntityAsync>d__);
			return <GetEntityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000AEB RID: 2795
		private static object s_DownloadManager;

		// Token: 0x04000AEC RID: 2796
		private ICredentials _credentials;

		// Token: 0x04000AED RID: 2797
		private IWebProxy _proxy;

		// Token: 0x04000AEE RID: 2798
		private RequestCachePolicy _cachePolicy;
	}
}
