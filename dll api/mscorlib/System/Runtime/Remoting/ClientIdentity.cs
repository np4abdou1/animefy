using System;

namespace System.Runtime.Remoting
{
	// Token: 0x02000307 RID: 775
	internal class ClientIdentity : Identity
	{
		// Token: 0x0600196D RID: 6509 RVA: 0x0006EAE6 File Offset: 0x0006CCE6
		public ClientIdentity(string objectUri, ObjRef objRef) : base(objectUri)
		{
			this._objRef = objRef;
			this._envoySink = ((this._objRef.EnvoyInfo != null) ? this._objRef.EnvoyInfo.EnvoySinks : null);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0006EB1C File Offset: 0x0006CD1C
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0006EB35 File Offset: 0x0006CD35
		public MarshalByRefObject ClientProxy
		{
			get
			{
				WeakReference proxyReference = this._proxyReference;
				return (MarshalByRefObject)((proxyReference != null) ? proxyReference.Target : null);
			}
			set
			{
				this._proxyReference = new WeakReference(value);
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0006EB43 File Offset: 0x0006CD43
		public override ObjRef CreateObjRef(Type requestedType)
		{
			return this._objRef;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x0006EB4B File Offset: 0x0006CD4B
		public string TargetUri
		{
			get
			{
				return this._objRef.URI;
			}
		}

		// Token: 0x04000A9B RID: 2715
		private WeakReference _proxyReference;
	}
}
