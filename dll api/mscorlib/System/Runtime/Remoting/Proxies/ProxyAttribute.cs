using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Proxies
{
	/// <summary>Indicates that an object type requires a custom proxy.</summary>
	// Token: 0x02000320 RID: 800
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(true)]
	public class ProxyAttribute : Attribute
	{
		/// <summary>Creates either an uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy, depending on whether the specified type can exist in the current context.</summary>
		/// <param name="serverType">The object type to create an instance of. </param>
		/// <returns>An uninitialized <see cref="T:System.MarshalByRefObject" /> or a transparent proxy.</returns>
		// Token: 0x06001A31 RID: 6705 RVA: 0x000724C8 File Offset: 0x000706C8
		public virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			return (MarshalByRefObject)new RemotingProxy(serverType, ChannelServices.CrossContextUrl, null).GetTransparentProxy();
		}

		/// <summary>Creates an instance of a remoting proxy for a remote object described by the specified <see cref="T:System.Runtime.Remoting.ObjRef" />, and located on the server.</summary>
		/// <param name="objRef">The object reference to the remote object for which to create a proxy. </param>
		/// <param name="serverType">The type of the server where the remote object is located. </param>
		/// <param name="serverObject">The server object. </param>
		/// <param name="serverContext">The context in which the server object is located. </param>
		/// <returns>The new instance of remoting proxy for the remote object that is described in the specified <see cref="T:System.Runtime.Remoting.ObjRef" />.</returns>
		// Token: 0x06001A32 RID: 6706 RVA: 0x000724E0 File Offset: 0x000706E0
		public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext)
		{
			return RemotingServices.GetRealProxy(RemotingServices.GetProxyForRemoteObject(objRef, serverType));
		}
	}
}
