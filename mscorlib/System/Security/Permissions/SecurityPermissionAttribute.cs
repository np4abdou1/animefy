using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Allows security actions for <see cref="T:System.Security.Permissions.SecurityPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
	// Token: 0x02000298 RID: 664
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SecurityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Gets or sets a value indicating whether permission to bypass code verification is declared.</summary>
		/// <returns>
		///     <see langword="true" /> if permission to bypass code verification is declared; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000259 RID: 601
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0005DB36 File Offset: 0x0005BD36
		public bool SkipVerification
		{
			set
			{
				if (value)
				{
					this.m_Flags |= SecurityPermissionFlag.SkipVerification;
					return;
				}
				this.m_Flags &= ~SecurityPermissionFlag.SkipVerification;
			}
		}

		// Token: 0x0400090A RID: 2314
		private SecurityPermissionFlag m_Flags;
	}
}
