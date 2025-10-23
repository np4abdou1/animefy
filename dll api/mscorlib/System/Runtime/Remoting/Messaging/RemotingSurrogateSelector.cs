using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Selects the remoting surrogate that can be used to serialize an object that derives from a <see cref="T:System.MarshalByRefObject" />.</summary>
	// Token: 0x02000385 RID: 901
	[ComVisible(true)]
	public class RemotingSurrogateSelector : ISurrogateSelector
	{
		/// <summary>Returns the appropriate surrogate for the given type in the given context.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> for which the surrogate is requested. </param>
		/// <param name="context">The source or destination of serialization. </param>
		/// <param name="ssout">When this method returns, contains an <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that is appropriate for the specified object type. This parameter is passed uninitialized. </param>
		/// <returns>The appropriate surrogate for the given type in the given context.</returns>
		// Token: 0x06001C3E RID: 7230 RVA: 0x00078B1C File Offset: 0x00076D1C
		public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			if (type.IsMarshalByRef)
			{
				ssout = this;
				return RemotingSurrogateSelector._objRemotingSurrogate;
			}
			if (RemotingSurrogateSelector.s_cachedTypeObjRef.IsAssignableFrom(type))
			{
				ssout = this;
				return RemotingSurrogateSelector._objRefSurrogate;
			}
			if (this._next != null)
			{
				return this._next.GetSurrogate(type, context, out ssout);
			}
			ssout = null;
			return null;
		}

		// Token: 0x04000BD5 RID: 3029
		private static Type s_cachedTypeObjRef = typeof(ObjRef);

		// Token: 0x04000BD6 RID: 3030
		private static ObjRefSurrogate _objRefSurrogate = new ObjRefSurrogate();

		// Token: 0x04000BD7 RID: 3031
		private static RemotingSurrogate _objRemotingSurrogate = new RemotingSurrogate();

		// Token: 0x04000BD8 RID: 3032
		private ISurrogateSelector _next;
	}
}
