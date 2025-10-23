using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000083 RID: 131
	[Register("com/bumptech/glide/manager/SupportRequestManagerFragment", DoNotGenerateAcw = true)]
	public class SupportRequestManagerFragment : Fragment
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00012374 File Offset: 0x00010574
		internal static IntPtr class_ref
		{
			get
			{
				return SupportRequestManagerFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00012398 File Offset: 0x00010598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SupportRequestManagerFragment._members;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000123A0 File Offset: 0x000105A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SupportRequestManagerFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000123C4 File Offset: 0x000105C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SupportRequestManagerFragment._members.ManagedPeerType;
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000123D0 File Offset: 0x000105D0
		protected SupportRequestManagerFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000123DC File Offset: 0x000105DC
		[Register(".ctor", "()V", "")]
		public SupportRequestManagerFragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SupportRequestManagerFragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SupportRequestManagerFragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001244A File Offset: 0x0001064A
		private static Delegate GetGetRequestManagerHandler()
		{
			if (SupportRequestManagerFragment.cb_getRequestManager == null)
			{
				SupportRequestManagerFragment.cb_getRequestManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SupportRequestManagerFragment.n_GetRequestManager));
			}
			return SupportRequestManagerFragment.cb_getRequestManager;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001246E File Offset: 0x0001066E
		private static IntPtr n_GetRequestManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SupportRequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManager);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00012482 File Offset: 0x00010682
		private static Delegate GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler()
		{
			if (SupportRequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ == null)
			{
				SupportRequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SupportRequestManagerFragment.n_SetRequestManager_Lcom_bumptech_glide_RequestManager_));
			}
			return SupportRequestManagerFragment.cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000124A8 File Offset: 0x000106A8
		private static void n_SetRequestManager_Lcom_bumptech_glide_RequestManager_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestManager)
		{
			SupportRequestManagerFragment @object = Java.Lang.Object.GetObject<SupportRequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestManager object2 = Java.Lang.Object.GetObject<RequestManager>(native_requestManager, JniHandleOwnership.DoNotTransfer);
			@object.RequestManager = object2;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000124CC File Offset: 0x000106CC
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00012500 File Offset: 0x00010700
		public unsafe virtual RequestManager RequestManager
		{
			[Register("getRequestManager", "()Lcom/bumptech/glide/RequestManager;", "GetGetRequestManagerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestManager>(SupportRequestManagerFragment._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManager.()Lcom/bumptech/glide/RequestManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRequestManager", "(Lcom/bumptech/glide/RequestManager;)V", "GetSetRequestManager_Lcom_bumptech_glide_RequestManager_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SupportRequestManagerFragment._members.InstanceMethods.InvokeVirtualVoidMethod("setRequestManager.(Lcom/bumptech/glide/RequestManager;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00012564 File Offset: 0x00010764
		private static Delegate GetGetRequestManagerTreeNodeHandler()
		{
			if (SupportRequestManagerFragment.cb_getRequestManagerTreeNode == null)
			{
				SupportRequestManagerFragment.cb_getRequestManagerTreeNode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SupportRequestManagerFragment.n_GetRequestManagerTreeNode));
			}
			return SupportRequestManagerFragment.cb_getRequestManagerTreeNode;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00012588 File Offset: 0x00010788
		private static IntPtr n_GetRequestManagerTreeNode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SupportRequestManagerFragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManagerTreeNode);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001259C File Offset: 0x0001079C
		public virtual IRequestManagerTreeNode RequestManagerTreeNode
		{
			[Register("getRequestManagerTreeNode", "()Lcom/bumptech/glide/manager/RequestManagerTreeNode;", "GetGetRequestManagerTreeNodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IRequestManagerTreeNode>(SupportRequestManagerFragment._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManagerTreeNode.()Lcom/bumptech/glide/manager/RequestManagerTreeNode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400014A RID: 330
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/SupportRequestManagerFragment", typeof(SupportRequestManagerFragment));

		// Token: 0x0400014B RID: 331
		private static Delegate cb_getRequestManager;

		// Token: 0x0400014C RID: 332
		private static Delegate cb_setRequestManager_Lcom_bumptech_glide_RequestManager_;

		// Token: 0x0400014D RID: 333
		private static Delegate cb_getRequestManagerTreeNode;
	}
}
