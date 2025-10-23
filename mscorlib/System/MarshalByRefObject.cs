using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Lifetime;

namespace System
{
	/// <summary>Enables access to objects across application domain boundaries in applications that support remoting.</summary>
	// Token: 0x02000172 RID: 370
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public abstract class MarshalByRefObject
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0003E162 File Offset: 0x0003C362
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0003E16A File Offset: 0x0003C36A
		internal ServerIdentity ObjectIdentity
		{
			get
			{
				return this._identity;
			}
			set
			{
				this._identity = value;
			}
		}

		/// <summary>Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.</summary>
		/// <param name="requestedType">The <see cref="T:System.Type" /> of the object that the new <see cref="T:System.Runtime.Remoting.ObjRef" /> will reference. </param>
		/// <returns>Information required to generate a proxy.</returns>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">This instance is not a valid remoting object. </exception>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06000ECB RID: 3787 RVA: 0x0003E173 File Offset: 0x0003C373
		public virtual ObjRef CreateObjRef(Type requestedType)
		{
			if (this._identity == null)
			{
				throw new RemotingException(Locale.GetText("No remoting information was found for the object."));
			}
			return this._identity.CreateObjRef(requestedType);
		}

		/// <summary>Obtains a lifetime service object to control the lifetime policy for this instance.</summary>
		/// <returns>An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease" /> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" /> property.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		// Token: 0x06000ECC RID: 3788 RVA: 0x0003E199 File Offset: 0x0003C399
		public virtual object InitializeLifetimeService()
		{
			if (this._identity != null && this._identity.Lease != null)
			{
				return this._identity.Lease;
			}
			return new Lease();
		}

		// Token: 0x04000598 RID: 1432
		[NonSerialized]
		private ServerIdentity _identity;
	}
}
