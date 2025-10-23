using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security
{
	/// <summary>Defines the underlying structure of all code access permissions.</summary>
	// Token: 0x02000280 RID: 640
	[ComVisible(true)]
	[Serializable]
	public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
	{
		/// <summary>Determines whether the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />.</summary>
		/// <param name="obj">The <see cref="T:System.Security.CodeAccessPermission" /> object to compare with the current <see cref="T:System.Security.CodeAccessPermission" />. </param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.Security.CodeAccessPermission" /> object is equal to the current <see cref="T:System.Security.CodeAccessPermission" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600164E RID: 5710 RVA: 0x0005B4D8 File Offset: 0x000596D8
		[ComVisible(false)]
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			CodeAccessPermission codeAccessPermission = obj as CodeAccessPermission;
			return this.IsSubsetOf(codeAccessPermission) && codeAccessPermission.IsSubsetOf(this);
		}

		/// <summary>Gets a hash code for the <see cref="T:System.Security.CodeAccessPermission" /> object that is suitable for use in hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Security.CodeAccessPermission" /> object.</returns>
		// Token: 0x0600164F RID: 5711 RVA: 0x0005B518 File Offset: 0x00059718
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>When implemented by a derived class, determines whether the current permission is a subset of the specified permission.</summary>
		/// <param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param>
		/// <returns>
		///     <see langword="true" /> if the current permission is a subset of the specified permission; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not <see langword="null" /> and is not of the same type as the current permission. </exception>
		// Token: 0x06001650 RID: 5712
		public abstract bool IsSubsetOf(IPermission target);

		/// <summary>Creates and returns a string representation of the current permission object.</summary>
		/// <returns>A string representation of the current permission object.</returns>
		// Token: 0x06001651 RID: 5713 RVA: 0x0005B520 File Offset: 0x00059720
		public override string ToString()
		{
			return this.ToXml().ToString();
		}

		/// <summary>When overridden in a derived class, creates an XML encoding of the security object and its current state.</summary>
		/// <returns>An XML encoding of the security object, including any state information.</returns>
		// Token: 0x06001652 RID: 5714
		public abstract SecurityElement ToXml();

		// Token: 0x06001653 RID: 5715 RVA: 0x0005B52D File Offset: 0x0005972D
		internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted)
		{
			if (state != PermissionState.None && state != PermissionState.Unrestricted)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), state), "state");
			}
			return state;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002A7D File Offset: 0x00000C7D
		void IPermission.Demand()
		{
		}
	}
}
