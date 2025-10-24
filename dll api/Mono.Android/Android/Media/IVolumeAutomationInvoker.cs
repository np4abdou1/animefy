using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000204 RID: 516
	[Register("android/media/VolumeAutomation", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IVolumeAutomationInvoker : Java.Lang.Object, IVolumeAutomation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00030EBC File Offset: 0x0002F0BC
		private static IntPtr java_class_ref
		{
			get
			{
				return IVolumeAutomationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00030EE0 File Offset: 0x0002F0E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVolumeAutomationInvoker._members;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00030EE7 File Offset: 0x0002F0E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00030EEF File Offset: 0x0002F0EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVolumeAutomationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00030EFB File Offset: 0x0002F0FB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVolumeAutomationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.media.VolumeAutomation'.");
			}
			return handle;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00030F26 File Offset: 0x0002F126
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00030F58 File Offset: 0x0002F158
		public IVolumeAutomationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVolumeAutomationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00030F90 File Offset: 0x0002F190
		private static Delegate GetCreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_Handler()
		{
			if (IVolumeAutomationInvoker.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ == null)
			{
				IVolumeAutomationInvoker.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IVolumeAutomationInvoker.n_CreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_));
			}
			return IVolumeAutomationInvoker.cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		private static IntPtr n_CreateVolumeShaper_Landroid_media_VolumeShaper_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			IVolumeAutomation @object = Java.Lang.Object.GetObject<IVolumeAutomation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			VolumeShaper.Configuration object2 = Java.Lang.Object.GetObject<VolumeShaper.Configuration>(native_configuration, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateVolumeShaper(object2));
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00030FDC File Offset: 0x0002F1DC
		public unsafe VolumeShaper CreateVolumeShaper(VolumeShaper.Configuration configuration)
		{
			if (this.id_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ == IntPtr.Zero)
			{
				this.id_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "createVolumeShaper", "(Landroid/media/VolumeShaper$Configuration;)Landroid/media/VolumeShaper;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
			return Java.Lang.Object.GetObject<VolumeShaper>(JNIEnv.CallObjectMethod(base.Handle, this.id_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000857 RID: 2135
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/VolumeAutomation", typeof(IVolumeAutomationInvoker));

		// Token: 0x04000858 RID: 2136
		private IntPtr class_ref;

		// Token: 0x04000859 RID: 2137
		private static Delegate cb_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_;

		// Token: 0x0400085A RID: 2138
		private IntPtr id_createVolumeShaper_Landroid_media_VolumeShaper_Configuration_;
	}
}
