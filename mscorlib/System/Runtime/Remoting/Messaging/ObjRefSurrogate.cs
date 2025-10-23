using System;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000384 RID: 900
	internal class ObjRefSurrogate : ISerializationSurrogate
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x00078AE6 File Offset: 0x00076CE6
		public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc)
		{
			if (obj == null || si == null)
			{
				throw new ArgumentNullException();
			}
			((ObjRef)obj).GetObjectData(si, sc);
			si.AddValue("fIsMarshalled", 0);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00078B0D File Offset: 0x00076D0D
		public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			throw new NotSupportedException("Do not use RemotingSurrogateSelector when deserializating");
		}
	}
}
