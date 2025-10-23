using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Snackbar
{
	// Token: 0x02000092 RID: 146
	[Register("com/google/android/material/snackbar/ContentViewCallback", DoNotGenerateAcw = true)]
	internal class IContentViewCallbackInvoker : Java.Lang.Object, IContentViewCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0001B02C File Offset: 0x0001922C
		private static IntPtr java_class_ref
		{
			get
			{
				return IContentViewCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0001B050 File Offset: 0x00019250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContentViewCallbackInvoker._members;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0001B057 File Offset: 0x00019257
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0001B05F File Offset: 0x0001925F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContentViewCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0001B06B File Offset: 0x0001926B
		public static IContentViewCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContentViewCallback>(handle, transfer);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001B074 File Offset: 0x00019274
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContentViewCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.snackbar.ContentViewCallback'.");
			}
			return handle;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001B09F File Offset: 0x0001929F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001B0D0 File Offset: 0x000192D0
		public IContentViewCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContentViewCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001B108 File Offset: 0x00019308
		private static Delegate GetAnimateContentIn_IIHandler()
		{
			if (IContentViewCallbackInvoker.cb_animateContentIn_II == null)
			{
				IContentViewCallbackInvoker.cb_animateContentIn_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(IContentViewCallbackInvoker.n_AnimateContentIn_II));
			}
			return IContentViewCallbackInvoker.cb_animateContentIn_II;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001B12C File Offset: 0x0001932C
		private static void n_AnimateContentIn_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<IContentViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimateContentIn(p0, p1);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0001B140 File Offset: 0x00019340
		public unsafe void AnimateContentIn(int p0, int p1)
		{
			if (this.id_animateContentIn_II == IntPtr.Zero)
			{
				this.id_animateContentIn_II = JNIEnv.GetMethodID(this.class_ref, "animateContentIn", "(II)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_animateContentIn_II, ptr);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0001B1B7 File Offset: 0x000193B7
		private static Delegate GetAnimateContentOut_IIHandler()
		{
			if (IContentViewCallbackInvoker.cb_animateContentOut_II == null)
			{
				IContentViewCallbackInvoker.cb_animateContentOut_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(IContentViewCallbackInvoker.n_AnimateContentOut_II));
			}
			return IContentViewCallbackInvoker.cb_animateContentOut_II;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001B1DB File Offset: 0x000193DB
		private static void n_AnimateContentOut_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<IContentViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimateContentOut(p0, p1);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001B1EC File Offset: 0x000193EC
		public unsafe void AnimateContentOut(int p0, int p1)
		{
			if (this.id_animateContentOut_II == IntPtr.Zero)
			{
				this.id_animateContentOut_II = JNIEnv.GetMethodID(this.class_ref, "animateContentOut", "(II)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_animateContentOut_II, ptr);
		}

		// Token: 0x040002E1 RID: 737
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/ContentViewCallback", typeof(IContentViewCallbackInvoker));

		// Token: 0x040002E2 RID: 738
		private IntPtr class_ref;

		// Token: 0x040002E3 RID: 739
		private static Delegate cb_animateContentIn_II;

		// Token: 0x040002E4 RID: 740
		private IntPtr id_animateContentIn_II;

		// Token: 0x040002E5 RID: 741
		private static Delegate cb_animateContentOut_II;

		// Token: 0x040002E6 RID: 742
		private IntPtr id_animateContentOut_II;
	}
}
