using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007F RID: 127
	[Register("com/bumptech/glide/manager/RequestManagerTreeNode", DoNotGenerateAcw = true)]
	internal class IRequestManagerTreeNodeInvoker : Java.Lang.Object, IRequestManagerTreeNode, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x000114CC File Offset: 0x0000F6CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequestManagerTreeNodeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRequestManagerTreeNodeInvoker._members;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x000114F7 File Offset: 0x0000F6F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x000114FF File Offset: 0x0000F6FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRequestManagerTreeNodeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001150B File Offset: 0x0000F70B
		public static IRequestManagerTreeNode GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequestManagerTreeNode>(handle, transfer);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00011514 File Offset: 0x0000F714
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequestManagerTreeNodeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.RequestManagerTreeNode'.");
			}
			return handle;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0001153F File Offset: 0x0000F73F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00011570 File Offset: 0x0000F770
		public IRequestManagerTreeNodeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequestManagerTreeNodeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000115A8 File Offset: 0x0000F7A8
		private static Delegate GetGetDescendantsHandler()
		{
			if (IRequestManagerTreeNodeInvoker.cb_getDescendants == null)
			{
				IRequestManagerTreeNodeInvoker.cb_getDescendants = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequestManagerTreeNodeInvoker.n_GetDescendants));
			}
			return IRequestManagerTreeNodeInvoker.cb_getDescendants;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000115CC File Offset: 0x0000F7CC
		private static IntPtr n_GetDescendants(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<RequestManager>.ToLocalJniHandle(Java.Lang.Object.GetObject<IRequestManagerTreeNode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Descendants);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000115E0 File Offset: 0x0000F7E0
		public ICollection<RequestManager> Descendants
		{
			get
			{
				if (this.id_getDescendants == IntPtr.Zero)
				{
					this.id_getDescendants = JNIEnv.GetMethodID(this.class_ref, "getDescendants", "()Ljava/util/Set;");
				}
				return JavaSet<RequestManager>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getDescendants), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000131 RID: 305
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/RequestManagerTreeNode", typeof(IRequestManagerTreeNodeInvoker));

		// Token: 0x04000132 RID: 306
		private IntPtr class_ref;

		// Token: 0x04000133 RID: 307
		private static Delegate cb_getDescendants;

		// Token: 0x04000134 RID: 308
		private IntPtr id_getDescendants;
	}
}
