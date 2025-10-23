using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Provides the basic functionality for a remoting activator class.</summary>
	// Token: 0x02000351 RID: 849
	[ComVisible(true)]
	public interface IActivator
	{
		/// <summary>Gets or sets the next activator in the chain.</summary>
		/// <returns>The next activator in the chain.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001B08 RID: 6920
		IActivator NextActivator { get; }

		/// <summary>Creates an instance of the object that is specified in the provided <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="msg">The information about the object that is needed to activate it, stored in a <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />. </param>
		/// <returns>Status of the object activation contained in a <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06001B09 RID: 6921
		IConstructionReturnMessage Activate(IConstructionCallMessage msg);
	}
}
