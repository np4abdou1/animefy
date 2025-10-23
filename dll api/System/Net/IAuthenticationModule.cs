using System;

namespace System.Net
{
	/// <summary>Provides the base authentication interface for Web client authentication modules.</summary>
	// Token: 0x0200014F RID: 335
	public interface IAuthenticationModule
	{
		/// <summary>Returns an instance of the <see cref="T:System.Net.Authorization" /> class in respose to an authentication challenge from a server.</summary>
		/// <param name="challenge">The authentication challenge sent by the server. </param>
		/// <param name="request">The <see cref="T:System.Net.WebRequest" /> instance associated with the challenge. </param>
		/// <param name="credentials">The credentials associated with the challenge. </param>
		/// <returns>An <see cref="T:System.Net.Authorization" /> instance containing the authorization message for the request, or <see langword="null" /> if the challenge cannot be handled.</returns>
		// Token: 0x06000950 RID: 2384
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		/// <summary>Returns an instance of the <see cref="T:System.Net.Authorization" /> class for an authentication request to a server.</summary>
		/// <param name="request">The <see cref="T:System.Net.WebRequest" /> instance associated with the authentication request. </param>
		/// <param name="credentials">The credentials associated with the authentication request. </param>
		/// <returns>An <see cref="T:System.Net.Authorization" /> instance containing the authorization message for the request.</returns>
		// Token: 0x06000951 RID: 2385
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		/// <summary>Gets the authentication type provided by this authentication module.</summary>
		/// <returns>A string indicating the authentication type provided by this authentication module.</returns>
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000952 RID: 2386
		string AuthenticationType { get; }
	}
}
