using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x02000097 RID: 151
	[Register("androidx/recyclerview/widget/RecyclerViewAccessibilityDelegate", DoNotGenerateAcw = true)]
	public class RecyclerViewAccessibilityDelegate : AccessibilityDelegateCompat
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000168A8 File Offset: 0x00014AA8
		internal static IntPtr class_ref
		{
			get
			{
				return RecyclerViewAccessibilityDelegate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000168CC File Offset: 0x00014ACC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RecyclerViewAccessibilityDelegate._members;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000168D4 File Offset: 0x00014AD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RecyclerViewAccessibilityDelegate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000168F8 File Offset: 0x00014AF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RecyclerViewAccessibilityDelegate._members.ManagedPeerType;
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00016904 File Offset: 0x00014B04
		protected RecyclerViewAccessibilityDelegate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00016910 File Offset: 0x00014B10
		[Register(".ctor", "(Landroidx/recyclerview/widget/RecyclerView;)V", "")]
		public unsafe RecyclerViewAccessibilityDelegate(RecyclerView recyclerView) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
				base.SetHandle(RecyclerViewAccessibilityDelegate._members.InstanceMethods.StartCreateInstance("(Landroidx/recyclerview/widget/RecyclerView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerViewAccessibilityDelegate._members.InstanceMethods.FinishCreateInstance("(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(recyclerView);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000169C0 File Offset: 0x00014BC0
		private static Delegate GetGetItemDelegateHandler()
		{
			if (RecyclerViewAccessibilityDelegate.cb_getItemDelegate == null)
			{
				RecyclerViewAccessibilityDelegate.cb_getItemDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerViewAccessibilityDelegate.n_GetItemDelegate));
			}
			return RecyclerViewAccessibilityDelegate.cb_getItemDelegate;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000169E4 File Offset: 0x00014BE4
		private static IntPtr n_GetItemDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerViewAccessibilityDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemDelegate());
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000169F8 File Offset: 0x00014BF8
		[Register("getItemDelegate", "()Landroidx/core/view/AccessibilityDelegateCompat;", "GetGetItemDelegateHandler")]
		public virtual AccessibilityDelegateCompat GetItemDelegate()
		{
			return Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(RecyclerViewAccessibilityDelegate._members.InstanceMethods.InvokeVirtualObjectMethod("getItemDelegate.()Landroidx/core/view/AccessibilityDelegateCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000216 RID: 534
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerViewAccessibilityDelegate", typeof(RecyclerViewAccessibilityDelegate));

		// Token: 0x04000217 RID: 535
		private static Delegate cb_getItemDelegate;
	}
}
