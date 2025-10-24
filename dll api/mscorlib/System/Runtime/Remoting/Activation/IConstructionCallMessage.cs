using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Represents the construction call request of an object.</summary>
	// Token: 0x02000352 RID: 850
	[ComVisible(true)]
	public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage
	{
		/// <summary>Gets the type of the remote object to activate.</summary>
		/// <returns>The type of the remote object to activate.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001B0A RID: 6922
		Type ActivationType { get; }

		/// <summary>Gets the full type name of the remote type to activate.</summary>
		/// <returns>The full type name of the remote type to activate.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001B0B RID: 6923
		string ActivationTypeName { get; }

		/// <summary>Gets or sets the activator that activates the remote object.</summary>
		/// <returns>The activator that activates the remote object.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001B0C RID: 6924
		// (set) Token: 0x06001B0D RID: 6925
		IActivator Activator { get; set; }

		/// <summary>Gets the call site activation attributes.</summary>
		/// <returns>The call site activation attributes.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001B0E RID: 6926
		object[] CallSiteActivationAttributes { get; }

		/// <summary>Gets a list of context properties that define the context in which the object is to be created.</summary>
		/// <returns>A list of properties of the context in which to construct the object.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001B0F RID: 6927
		IList ContextProperties { get; }
	}
}
