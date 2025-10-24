using System;

namespace System.ComponentModel
{
	/// <summary>Defines the interface for extending properties to other components in a container.</summary>
	// Token: 0x0200026A RID: 618
	public interface IExtenderProvider
	{
		/// <summary>Specifies whether this object can provide its extender properties to the specified object.</summary>
		/// <param name="extendee">The <see cref="T:System.Object" /> to receive the extender properties. </param>
		/// <returns>
		///     <see langword="true" /> if this object can provide extender properties to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010A3 RID: 4259
		bool CanExtend(object extendee);
	}
}
