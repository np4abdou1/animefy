using System;

namespace System.Security
{
	/// <summary>Defines methods implemented by permission types.</summary>
	// Token: 0x02000277 RID: 631
	public interface IPermission : ISecurityEncodable
	{
		/// <summary>Throws a <see cref="T:System.Security.SecurityException" /> at run time if the security requirement is not met.</summary>
		// Token: 0x06001637 RID: 5687
		void Demand();

		/// <summary>Determines whether the current permission is a subset of the specified permission.</summary>
		/// <param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param>
		/// <returns>
		///     <see langword="true" /> if the current permission is a subset of the specified permission; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not <see langword="null" /> and is not of the same type as the current permission. </exception>
		// Token: 0x06001638 RID: 5688
		bool IsSubsetOf(IPermission target);
	}
}
