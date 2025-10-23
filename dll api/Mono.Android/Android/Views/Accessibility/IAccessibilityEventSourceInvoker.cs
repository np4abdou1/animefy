using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Accessibility
{
	// Token: 0x0200018D RID: 397
	[Register("android/view/accessibility/AccessibilityEventSource", DoNotGenerateAcw = true)]
	internal class IAccessibilityEventSourceInvoker : Java.Lang.Object, IAccessibilityEventSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000233CC File Offset: 0x000215CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IAccessibilityEventSourceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000233F0 File Offset: 0x000215F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAccessibilityEventSourceInvoker._members;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000233F7 File Offset: 0x000215F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x000233FF File Offset: 0x000215FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAccessibilityEventSourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002340B File Offset: 0x0002160B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAccessibilityEventSourceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.accessibility.AccessibilityEventSource'.");
			}
			return handle;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00023436 File Offset: 0x00021636
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00023468 File Offset: 0x00021668
		public IAccessibilityEventSourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAccessibilityEventSourceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000234A0 File Offset: 0x000216A0
		private static Delegate GetSendAccessibilityEvent_IHandler()
		{
			if (IAccessibilityEventSourceInvoker.cb_sendAccessibilityEvent_I == null)
			{
				IAccessibilityEventSourceInvoker.cb_sendAccessibilityEvent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IAccessibilityEventSourceInvoker.n_SendAccessibilityEvent_I));
			}
			return IAccessibilityEventSourceInvoker.cb_sendAccessibilityEvent_I;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x000234C4 File Offset: 0x000216C4
		private static void n_SendAccessibilityEvent_I(IntPtr jnienv, IntPtr native__this, int native_eventType)
		{
			Java.Lang.Object.GetObject<IAccessibilityEventSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SendAccessibilityEvent((EventTypes)native_eventType);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000234E4 File Offset: 0x000216E4
		public unsafe void SendAccessibilityEvent([GeneratedEnum] EventTypes eventType)
		{
			if (this.id_sendAccessibilityEvent_I == IntPtr.Zero)
			{
				this.id_sendAccessibilityEvent_I = JNIEnv.GetMethodID(this.class_ref, "sendAccessibilityEvent", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)eventType);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendAccessibilityEvent_I, ptr);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00023548 File Offset: 0x00021748
		private static Delegate GetSendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (IAccessibilityEventSourceInvoker.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				IAccessibilityEventSourceInvoker.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAccessibilityEventSourceInvoker.n_SendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return IAccessibilityEventSourceInvoker.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002356C File Offset: 0x0002176C
		private static void n_SendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IAccessibilityEventSource @object = Java.Lang.Object.GetObject<IAccessibilityEventSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SendAccessibilityEventUnchecked(object2);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00023590 File Offset: 0x00021790
		public unsafe void SendAccessibilityEventUnchecked(AccessibilityEvent e)
		{
			if (this.id_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ == IntPtr.Zero)
			{
				this.id_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ = JNIEnv.GetMethodID(this.class_ref, "sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_, ptr);
		}

		// Token: 0x0400062D RID: 1581
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityEventSource", typeof(IAccessibilityEventSourceInvoker));

		// Token: 0x0400062E RID: 1582
		private IntPtr class_ref;

		// Token: 0x0400062F RID: 1583
		private static Delegate cb_sendAccessibilityEvent_I;

		// Token: 0x04000630 RID: 1584
		private IntPtr id_sendAccessibilityEvent_I;

		// Token: 0x04000631 RID: 1585
		private static Delegate cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x04000632 RID: 1586
		private IntPtr id_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_;
	}
}
