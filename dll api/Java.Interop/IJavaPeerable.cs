using System;

namespace Java.Interop
{
	// Token: 0x02000005 RID: 5
	public interface IJavaPeerable : IDisposable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10
		int JniIdentityHashCode { get; }

		// Token: 0x0600000B RID: 11
		void SetJniIdentityHashCode(int value);

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12
		JniObjectReference PeerReference { get; }

		// Token: 0x0600000D RID: 13
		void SetPeerReference(JniObjectReference reference);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14
		JniPeerMembers JniPeerMembers { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15
		JniManagedPeerStates JniManagedPeerState { get; }

		// Token: 0x06000010 RID: 16
		void SetJniManagedPeerState(JniManagedPeerStates value);

		// Token: 0x06000011 RID: 17
		void DisposeUnlessReferenced();

		// Token: 0x06000012 RID: 18
		void Disposed();

		// Token: 0x06000013 RID: 19
		void Finalized();
	}
}
