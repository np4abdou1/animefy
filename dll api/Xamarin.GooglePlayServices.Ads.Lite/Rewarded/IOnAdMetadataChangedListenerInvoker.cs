using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/gms/ads/rewarded/OnAdMetadataChangedListener", DoNotGenerateAcw = true)]
	internal class IOnAdMetadataChangedListenerInvoker : Java.Lang.Object, IOnAdMetadataChangedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000055E0 File Offset: 0x000037E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnAdMetadataChangedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00005604 File Offset: 0x00003804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnAdMetadataChangedListenerInvoker._members;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000560B File Offset: 0x0000380B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00005613 File Offset: 0x00003813
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnAdMetadataChangedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000561F File Offset: 0x0000381F
		public static IOnAdMetadataChangedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnAdMetadataChangedListener>(handle, transfer);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005628 File Offset: 0x00003828
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnAdMetadataChangedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.rewarded.OnAdMetadataChangedListener'.");
			}
			return handle;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005653 File Offset: 0x00003853
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005684 File Offset: 0x00003884
		public IOnAdMetadataChangedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnAdMetadataChangedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000056BC File Offset: 0x000038BC
		private static Delegate GetOnAdMetadataChangedHandler()
		{
			if (IOnAdMetadataChangedListenerInvoker.cb_onAdMetadataChanged == null)
			{
				IOnAdMetadataChangedListenerInvoker.cb_onAdMetadataChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOnAdMetadataChangedListenerInvoker.n_OnAdMetadataChanged));
			}
			return IOnAdMetadataChangedListenerInvoker.cb_onAdMetadataChanged;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000056E0 File Offset: 0x000038E0
		private static void n_OnAdMetadataChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOnAdMetadataChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdMetadataChanged();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000056EF File Offset: 0x000038EF
		public void OnAdMetadataChanged()
		{
			if (this.id_onAdMetadataChanged == IntPtr.Zero)
			{
				this.id_onAdMetadataChanged = JNIEnv.GetMethodID(this.class_ref, "onAdMetadataChanged", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdMetadataChanged);
		}

		// Token: 0x0400004B RID: 75
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/OnAdMetadataChangedListener", typeof(IOnAdMetadataChangedListenerInvoker));

		// Token: 0x0400004C RID: 76
		private IntPtr class_ref;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_onAdMetadataChanged;

		// Token: 0x0400004E RID: 78
		private IntPtr id_onAdMetadataChanged;
	}
}
