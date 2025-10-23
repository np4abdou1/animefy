using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200002A RID: 42
	[Register("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateSuccessListener", DoNotGenerateAcw = true)]
	internal class IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker : Java.Lang.Object, IConsentInformationOnConsentInfoUpdateSuccessListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003A7C File Offset: 0x00001C7C
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00003AA7 File Offset: 0x00001CA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00003AAF File Offset: 0x00001CAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003ABB File Offset: 0x00001CBB
		public static IConsentInformationOnConsentInfoUpdateSuccessListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateSuccessListener>(handle, transfer);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003AC4 File Offset: 0x00001CC4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.ConsentInformation.OnConsentInfoUpdateSuccessListener'.");
			}
			return handle;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003AEF File Offset: 0x00001CEF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003B20 File Offset: 0x00001D20
		public IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003B58 File Offset: 0x00001D58
		private static Delegate GetOnConsentInfoUpdateSuccessHandler()
		{
			if (IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.cb_onConsentInfoUpdateSuccess == null)
			{
				IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.cb_onConsentInfoUpdateSuccess = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.n_OnConsentInfoUpdateSuccess));
			}
			return IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker.cb_onConsentInfoUpdateSuccess;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003B7C File Offset: 0x00001D7C
		private static void n_OnConsentInfoUpdateSuccess(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConsentInformationOnConsentInfoUpdateSuccessListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConsentInfoUpdateSuccess();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003B8B File Offset: 0x00001D8B
		public void OnConsentInfoUpdateSuccess()
		{
			if (this.id_onConsentInfoUpdateSuccess == IntPtr.Zero)
			{
				this.id_onConsentInfoUpdateSuccess = JNIEnv.GetMethodID(this.class_ref, "onConsentInfoUpdateSuccess", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConsentInfoUpdateSuccess);
		}

		// Token: 0x0400004B RID: 75
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentInformation$OnConsentInfoUpdateSuccessListener", typeof(IConsentInformationOnConsentInfoUpdateSuccessListenerInvoker));

		// Token: 0x0400004C RID: 76
		private IntPtr class_ref;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_onConsentInfoUpdateSuccess;

		// Token: 0x0400004E RID: 78
		private IntPtr id_onConsentInfoUpdateSuccess;
	}
}
