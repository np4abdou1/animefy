using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000080 RID: 128
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/manager/RequestManagerFragment", DoNotGenerateAcw = true)]
	public class RequestManagerFragment : Fragment
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001164C File Offset: 0x0000F84C
		internal static IntPtr class_ref
		{
			get
			{
				return RequestManagerFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00011670 File Offset: 0x0000F870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestManagerFragment._members;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00011678 File Offset: 0x0000F878
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestManagerFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001169C File Offset: 0x0000F89C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestManagerFragment._members.ManagedPeerType;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000116A8 File Offset: 0x0000F8A8
		protected RequestManagerFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000116B4 File Offset: 0x0000F8B4
		[Register(".ctor", "()V", "")]
		public RequestManagerFragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(RequestManagerFragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			RequestManagerFragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00011722 File Offset: 0x0000F922
		private static Delegate GetGetRequestManagerHandler()
		{
			if (RequestManagerFragment.cb_getRequestManager == null)
			{
				RequestManagerFragment.cb_getRequestManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManagerFragment.n_GetRequestManager));
			}
			return RequestManagerFragment.cb_getRequestManager;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00011746 File Offset: 0x0000F946
		private static IntPtr n_GetRequestManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManager);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001175A File Offset: 0x0000F95A
		private static Delegate GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler()
		{
			if (RequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ == null)
			{
				RequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestManagerFragment.n_SetRequestManager_Lcom_bumptech_glide_RequestManager_));
			}
			return RequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00011780 File Offset: 0x0000F980
		private static void n_SetRequestManager_Lcom_bumptech_glide_RequestManager_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestManager)
		{
			RequestManagerFragment @object = Java.Lang.Object.GetObject<RequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestManager object2 = Java.Lang.Object.GetObject<RequestManager>(native_requestManager, JniHandleOwnership.DoNotTransfer);
			@object.RequestManager = object2;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000117A4 File Offset: 0x0000F9A4
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000117D8 File Offset: 0x0000F9D8
		public unsafe virtual RequestManager RequestManager
		{
			[Register("getRequestManager", "()Lcom/bumptech/glide/RequestManager;", "GetGetRequestManagerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestManager>(RequestManagerFragment._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManager.()Lcom/bumptech/glide/RequestManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequestManager", "(Lcom/bumptech/glide/RequestManager;)V", "GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					RequestManagerFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setRequestManager.(Lcom/bumptech/glide/RequestManager;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0001183C File Offset: 0x0000FA3C
		private static Delegate GetGetRequestManagerTreeNodeHandler()
		{
			if (RequestManagerFragment.cb_getRequestManagerTreeNode == null)
			{
				RequestManagerFragment.cb_getRequestManagerTreeNode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManagerFragment.n_GetRequestManagerTreeNode));
			}
			return RequestManagerFragment.cb_getRequestManagerTreeNode;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00011860 File Offset: 0x0000FA60
		private static IntPtr n_GetRequestManagerTreeNode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManagerTreeNode);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00011874 File Offset: 0x0000FA74
		public virtual IRequestManagerTreeNode RequestManagerTreeNode
		{
			[Register("getRequestManagerTreeNode", "()Lcom/bumptech/glide/manager/RequestManagerTreeNode;", "GetGetRequestManagerTreeNodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRequestManagerTreeNode>(RequestManagerFragment._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManagerTreeNode.()Lcom/bumptech/glide/manager/RequestManagerTreeNode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/RequestManagerFragment", typeof(RequestManagerFragment));

		// Token: 0x04000136 RID: 310
		private static Delegate cb_getRequestManager;

		// Token: 0x04000137 RID: 311
		private static Delegate cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;

		// Token: 0x04000138 RID: 312
		private static Delegate cb_getRequestManagerTreeNode;
	}
}
