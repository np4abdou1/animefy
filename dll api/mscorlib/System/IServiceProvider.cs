using System;

namespace System
{
	/// <summary>Defines a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</summary>
	// Token: 0x02000123 RID: 291
	public interface IServiceProvider
	{
		/// <summary>Gets the service object of the specified type.</summary>
		/// <param name="serviceType">An object that specifies the type of service object to get. </param>
		/// <returns>A service object of type <paramref name="serviceType" />.-or- 
		///     <see langword="null" /> if there is no service object of type <paramref name="serviceType" />.</returns>
		// Token: 0x06000B46 RID: 2886
		object GetService(Type serviceType);
	}
}
