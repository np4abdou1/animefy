using System;
using System.Collections;

namespace System.Net
{
	/// <summary>Manages the authentication modules called during the client authentication process.</summary>
	// Token: 0x0200019B RID: 411
	public class AuthenticationManager
	{
		// Token: 0x06000B1D RID: 2845 RVA: 0x0003A874 File Offset: 0x00038A74
		private static void EnsureModules()
		{
			object obj = AuthenticationManager.locker;
			lock (obj)
			{
				if (AuthenticationManager.modules == null)
				{
					AuthenticationManager.modules = new ArrayList();
					AuthenticationManager.modules.Add(new NtlmClient());
					AuthenticationManager.modules.Add(new DigestClient());
					AuthenticationManager.modules.Add(new BasicClient());
				}
			}
		}

		/// <summary>Calls each registered authentication module to find the first module that can respond to the authentication request.</summary>
		/// <param name="challenge">The challenge returned by the Internet resource. </param>
		/// <param name="request">The <see cref="T:System.Net.WebRequest" /> that initiated the authentication challenge. </param>
		/// <param name="credentials">The <see cref="T:System.Net.ICredentials" /> associated with this request. </param>
		/// <returns>An instance of the <see cref="T:System.Net.Authorization" /> class containing the result of the authorization attempt. If there is no authentication module to respond to the challenge, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="challenge" /> is <see langword="null" />.-or- 
		///         <paramref name="request" /> is <see langword="null" />.-or- 
		///         <paramref name="credentials" /> is <see langword="null" />. </exception>
		// Token: 0x06000B1E RID: 2846 RVA: 0x0003A8F0 File Offset: 0x00038AF0
		public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (credentials == null)
			{
				throw new ArgumentNullException("credentials");
			}
			if (challenge == null)
			{
				throw new ArgumentNullException("challenge");
			}
			return AuthenticationManager.DoAuthenticate(challenge, request, credentials);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0003A924 File Offset: 0x00038B24
		private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				foreach (object obj2 in AuthenticationManager.modules)
				{
					IAuthenticationModule authenticationModule = (IAuthenticationModule)obj2;
					Authorization authorization = authenticationModule.Authenticate(challenge, request, credentials);
					if (authorization != null)
					{
						authorization.ModuleAuthenticationType = authenticationModule.AuthenticationType;
						return authorization;
					}
				}
			}
			return null;
		}

		/// <summary>Preauthenticates a request.</summary>
		/// <param name="request">A <see cref="T:System.Net.WebRequest" /> to an Internet resource. </param>
		/// <param name="credentials">The <see cref="T:System.Net.ICredentials" /> associated with the request. </param>
		/// <returns>An instance of the <see cref="T:System.Net.Authorization" /> class if the request can be preauthenticated; otherwise, <see langword="null" />. If <paramref name="credentials" /> is <see langword="null" />, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="request" /> is <see langword="null" />. </exception>
		// Token: 0x06000B20 RID: 2848 RVA: 0x0003A9CC File Offset: 0x00038BCC
		public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (credentials == null)
			{
				return null;
			}
			AuthenticationManager.EnsureModules();
			ArrayList obj = AuthenticationManager.modules;
			lock (obj)
			{
				foreach (object obj2 in AuthenticationManager.modules)
				{
					IAuthenticationModule authenticationModule = (IAuthenticationModule)obj2;
					Authorization authorization = authenticationModule.PreAuthenticate(request, credentials);
					if (authorization != null)
					{
						authorization.ModuleAuthenticationType = authenticationModule.AuthenticationType;
						return authorization;
					}
				}
			}
			return null;
		}

		// Token: 0x04000809 RID: 2057
		private static ArrayList modules;

		// Token: 0x0400080A RID: 2058
		private static object locker = new object();

		// Token: 0x0400080B RID: 2059
		private static ICredentialPolicy credential_policy = null;
	}
}
