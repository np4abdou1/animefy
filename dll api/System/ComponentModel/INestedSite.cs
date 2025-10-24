using System;

namespace System.ComponentModel
{
	/// <summary>Provides the ability to retrieve the full nested name of a component.</summary>
	// Token: 0x0200026C RID: 620
	public interface INestedSite : ISite, IServiceProvider
	{
		/// <summary>Gets the full name of the component in this site.</summary>
		/// <returns>The full name of the component in this site.</returns>
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060010A6 RID: 4262
		string FullName { get; }
	}
}
