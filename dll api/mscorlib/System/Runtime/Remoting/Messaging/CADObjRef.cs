using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000365 RID: 869
	internal class CADObjRef
	{
		// Token: 0x06001B5E RID: 7006 RVA: 0x00075DC9 File Offset: 0x00073FC9
		public CADObjRef(ObjRef o, int sourceDomain)
		{
			this.objref = o;
			this.TypeInfo = o.SerializeType();
			this.SourceDomain = sourceDomain;
		}

		// Token: 0x04000B81 RID: 2945
		internal ObjRef objref;

		// Token: 0x04000B82 RID: 2946
		internal int SourceDomain;

		// Token: 0x04000B83 RID: 2947
		internal byte[] TypeInfo;
	}
}
