using System;
using System.IO;
using System.Threading.Tasks;

namespace System.Xml
{
	/// <summary>Resolves external XML resources named by a Uniform Resource Identifier (URI).</summary>
	// Token: 0x020001BB RID: 443
	public abstract class XmlResolver
	{
		/// <summary>When overridden in a derived class, maps a URI to an object that contains the actual resource.</summary>
		/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
		/// <param name="role">Currently not used.</param>
		/// <param name="ofObjectToReturn">The type of object to return. The current version only returns System.IO.Stream objects.</param>
		/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="ofObjectToReturn" /> is not a <see langword="Stream" /> type.</exception>
		/// <exception cref="T:System.UriFormatException">The specified URI is not an absolute URI.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="absoluteUri" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.Exception">There is a runtime error (for example, an interrupted server connection).</exception>
		// Token: 0x06000F38 RID: 3896
		public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

		/// <summary>When overridden in a derived class, resolves the absolute URI from the base and relative URIs.</summary>
		/// <param name="baseUri">The base URI used to resolve the relative URI.</param>
		/// <param name="relativeUri">The URI to resolve. The URI can be absolute or relative. If absolute, this value effectively replaces the <paramref name="baseUri" /> value. If relative, it combines with the <paramref name="baseUri" /> to make an absolute URI.</param>
		/// <returns>The absolute URI or <see langword="null" /> if the relative URI cannot be resolved.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="relativeUri" /> is <see langword="null" />.</exception>
		// Token: 0x06000F39 RID: 3897 RVA: 0x00061DB0 File Offset: 0x0005FFB0
		public virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			if (baseUri == null || (!baseUri.IsAbsoluteUri && baseUri.OriginalString.Length == 0))
			{
				Uri uri = new Uri(relativeUri, UriKind.RelativeOrAbsolute);
				if (!uri.IsAbsoluteUri && uri.OriginalString.Length > 0)
				{
					uri = new Uri(Path.GetFullPath(relativeUri));
				}
				return uri;
			}
			if (relativeUri == null || relativeUri.Length == 0)
			{
				return baseUri;
			}
			if (!baseUri.IsAbsoluteUri)
			{
				throw new NotSupportedException(Res.GetString("Relative URIs are not supported."));
			}
			return new Uri(baseUri, relativeUri);
		}

		/// <summary>Enables the resolver to return types other than <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="absoluteUri">The URI.</param>
		/// <param name="type">The type to return.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="type" /> is supported; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F3A RID: 3898 RVA: 0x00061E33 File Offset: 0x00060033
		public virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			if (absoluteUri == null)
			{
				throw new ArgumentNullException("absoluteUri");
			}
			return type == null || type == typeof(Stream);
		}

		/// <summary>Asynchronously maps a URI to an object that contains the actual resource.</summary>
		/// <param name="absoluteUri">The URI returned from <see cref="M:System.Xml.XmlResolver.ResolveUri(System.Uri,System.String)" />.</param>
		/// <param name="role">Currently not used.</param>
		/// <param name="ofObjectToReturn">The type of object to return. The current version only returns <see cref="T:System.IO.Stream" /> objects.</param>
		/// <returns>A stream object or <see langword="null" /> if a type other than stream is specified.</returns>
		// Token: 0x06000F3B RID: 3899 RVA: 0x00002B48 File Offset: 0x00000D48
		public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw new NotImplementedException();
		}
	}
}
