using System;

namespace Java.Interop
{
	// Token: 0x0200000C RID: 12
	[JniTypeSignature("java/lang/Object")]
	public class JavaObject : IJavaPeerable, IDisposable
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002CC9 File Offset: 0x00000EC9
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002CD1 File Offset: 0x00000ED1
		public int JniIdentityHashCode { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002CDA File Offset: 0x00000EDA
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public JniManagedPeerStates JniManagedPeerState { get; private set; }

		// Token: 0x06000076 RID: 118 RVA: 0x00002CEC File Offset: 0x00000EEC
		~JavaObject()
		{
			JniEnvironment.Runtime.ValueManager.FinalizePeer(this);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002D24 File Offset: 0x00000F24
		public JniObjectReference PeerReference
		{
			get
			{
				return new JniObjectReference(this.handle, this.handle_type);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002D37 File Offset: 0x00000F37
		public virtual JniPeerMembers JniPeerMembers
		{
			get
			{
				return JavaObject._members;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002D3E File Offset: 0x00000F3E
		public JavaObject(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			this.Construct(ref reference, options);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002D50 File Offset: 0x00000F50
		public unsafe JavaObject() : this(ref *JavaObject.InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			if (this.PeerReference.IsValid)
			{
				return;
			}
			JniObjectReference jniObjectReference = this.JniPeerMembers.InstanceMethods.StartCreateInstance("()V", base.GetType(), null);
			this.Construct(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
			this.JniPeerMembers.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002947 File Offset: 0x00000B47
		protected void Construct(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			JniEnvironment.Runtime.ValueManager.ConstructPeer(this, ref reference, options);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002DBC File Offset: 0x00000FBC
		protected void SetPeerReference(ref JniObjectReference reference, JniObjectReferenceOptions options)
		{
			if (options == JniObjectReferenceOptions.None)
			{
				((IJavaPeerable)this).SetPeerReference(default(JniObjectReference));
				return;
			}
			this.handle = reference.Handle;
			this.handle_type = reference.Type;
			JniObjectReference.Dispose(ref reference, options);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002A47 File Offset: 0x00000C47
		public void Dispose()
		{
			JniEnvironment.Runtime.ValueManager.DisposePeer(this);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002A59 File Offset: 0x00000C59
		public virtual void DisposeUnlessReferenced()
		{
			JniEnvironment.Runtime.ValueManager.DisposePeerUnlessReferenced(this);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000025B2 File Offset: 0x000007B2
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002DFC File Offset: 0x00000FFC
		public override bool Equals(object obj)
		{
			JniPeerMembers.AssertSelf(this);
			if (obj == this)
			{
				return true;
			}
			IJavaPeerable javaPeerable = obj as IJavaPeerable;
			return javaPeerable != null && JniEnvironment.Types.IsSameObject(this.PeerReference, javaPeerable.PeerReference);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002E32 File Offset: 0x00001032
		public override int GetHashCode()
		{
			return JavaObject._members.InstanceMethods.InvokeVirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002E4C File Offset: 0x0000104C
		public override string ToString()
		{
			JniObjectReference jniObjectReference = JavaObject._members.InstanceMethods.InvokeVirtualObjectMethod("toString.()Ljava/lang/String;", this, null);
			return JniEnvironment.Strings.ToString(ref jniObjectReference, JniObjectReferenceOptions.CopyAndDispose);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002E79 File Offset: 0x00001079
		void IJavaPeerable.Disposed()
		{
			this.Dispose(true);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002E82 File Offset: 0x00001082
		void IJavaPeerable.Finalized()
		{
			this.Dispose(false);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002E8B File Offset: 0x0000108B
		void IJavaPeerable.SetJniIdentityHashCode(int value)
		{
			this.JniIdentityHashCode = value;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002E94 File Offset: 0x00001094
		void IJavaPeerable.SetJniManagedPeerState(JniManagedPeerStates value)
		{
			this.JniManagedPeerState = value;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002E9D File Offset: 0x0000109D
		void IJavaPeerable.SetPeerReference(JniObjectReference reference)
		{
			this.SetPeerReference(ref reference, JniObjectReferenceOptions.Copy);
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new JniPeerMembers("java/lang/Object", typeof(JavaObject));

		// Token: 0x04000018 RID: 24
		private IntPtr handle;

		// Token: 0x04000019 RID: 25
		private JniObjectReferenceType handle_type;

		// Token: 0x0400001A RID: 26
		private IntPtr weak_handle;

		// Token: 0x0400001B RID: 27
		private int refs_added;

		// Token: 0x0400001C RID: 28
		protected unsafe static readonly JniObjectReference* InvalidJniObjectReference = null;
	}
}
