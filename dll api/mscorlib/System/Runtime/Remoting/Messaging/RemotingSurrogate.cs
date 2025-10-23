using System;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000383 RID: 899
	internal class RemotingSurrogate : ISerializationSurrogate
	{
		// Token: 0x06001C37 RID: 7223 RVA: 0x00078ABA File Offset: 0x00076CBA
		public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc)
		{
			if (obj == null || si == null)
			{
				throw new ArgumentNullException();
			}
			if (RemotingServices.IsTransparentProxy(obj))
			{
				RemotingServices.GetRealProxy(obj).GetObjectData(si, sc);
				return;
			}
			RemotingServices.GetObjectData(obj, si, sc);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			throw new NotSupportedException();
		}
	}
}
