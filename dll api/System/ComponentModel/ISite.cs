using System;

namespace System.ComponentModel
{
	/// <summary>Provides functionality required by sites.</summary>
	// Token: 0x02000240 RID: 576
	public interface ISite : IServiceProvider
	{
		/// <summary>Gets the <see cref="T:System.ComponentModel.IContainer" /> associated with the <see cref="T:System.ComponentModel.ISite" /> when implemented by a class.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.IContainer" /> instance associated with the <see cref="T:System.ComponentModel.ISite" />.</returns>
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000FAA RID: 4010
		IContainer Container { get; }

		/// <summary>Determines whether the component is in design mode when implemented by a class.</summary>
		/// <returns>
		///     <see langword="true" /> if the component is in design mode; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000FAB RID: 4011
		bool DesignMode { get; }

		/// <summary>Gets or sets the name of the component associated with the <see cref="T:System.ComponentModel.ISite" /> when implemented by a class.</summary>
		/// <returns>The name of the component associated with the <see cref="T:System.ComponentModel.ISite" />; or <see langword="null" />, if no name is assigned to the component.</returns>
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000FAC RID: 4012
		string Name { get; }
	}
}
