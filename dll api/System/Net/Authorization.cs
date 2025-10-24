using System;

namespace System.Net
{
	/// <summary>Contains an authentication message for an Internet server.</summary>
	// Token: 0x02000149 RID: 329
	public class Authorization
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message.</summary>
		/// <param name="token">The encrypted authorization message expected by the server. </param>
		// Token: 0x06000944 RID: 2372 RVA: 0x0003338B File Offset: 0x0003158B
		public Authorization(string token)
		{
			this.m_Message = ValidationHelper.MakeStringNull(token);
			this.m_Complete = true;
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Net.Authorization" /> class with the specified authorization message and completion status.</summary>
		/// <param name="token">The encrypted authorization message expected by the server. </param>
		/// <param name="finished">The completion status of the authorization attempt. <see langword="true" /> if the authorization attempt is complete; otherwise, <see langword="false" />. </param>
		// Token: 0x06000945 RID: 2373 RVA: 0x000333A6 File Offset: 0x000315A6
		public Authorization(string token, bool finished)
		{
			this.m_Message = ValidationHelper.MakeStringNull(token);
			this.m_Complete = finished;
		}

		/// <summary>Gets the message returned to the server in response to an authentication challenge.</summary>
		/// <returns>The message that will be returned to the server in response to an authentication challenge.</returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x000333C1 File Offset: 0x000315C1
		public string Message
		{
			get
			{
				return this.m_Message;
			}
		}

		/// <summary>Gets the completion status of the authorization.</summary>
		/// <returns>
		///     <see langword="true" /> if the authentication process is complete; otherwise, <see langword="false" />.</returns>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000333C9 File Offset: 0x000315C9
		public bool Complete
		{
			get
			{
				return this.m_Complete;
			}
		}

		// Token: 0x04000686 RID: 1670
		private string m_Message;

		// Token: 0x04000687 RID: 1671
		private bool m_Complete;

		// Token: 0x04000688 RID: 1672
		internal string ModuleAuthenticationType;
	}
}
