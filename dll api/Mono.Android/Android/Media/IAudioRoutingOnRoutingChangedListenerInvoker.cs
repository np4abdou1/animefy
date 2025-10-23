using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000200 RID: 512
	[Register("android/media/AudioRouting$OnRoutingChangedListener", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IAudioRoutingOnRoutingChangedListenerInvoker : Java.Lang.Object, IAudioRoutingOnRoutingChangedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x0003089C File Offset: 0x0002EA9C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAudioRoutingOnRoutingChangedListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x000308C0 File Offset: 0x0002EAC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAudioRoutingOnRoutingChangedListenerInvoker._members;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000308C7 File Offset: 0x0002EAC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000308CF File Offset: 0x0002EACF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAudioRoutingOnRoutingChangedListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000308DB File Offset: 0x0002EADB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAudioRoutingOnRoutingChangedListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.media.AudioRouting.OnRoutingChangedListener'.");
			}
			return handle;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00030906 File Offset: 0x0002EB06
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00030938 File Offset: 0x0002EB38
		public IAudioRoutingOnRoutingChangedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAudioRoutingOnRoutingChangedListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00030970 File Offset: 0x0002EB70
		private static Delegate GetOnRoutingChanged_Landroid_media_AudioRouting_Handler()
		{
			if (IAudioRoutingOnRoutingChangedListenerInvoker.cb_onRoutingChanged_Landroid_media_AudioRouting_ == null)
			{
				IAudioRoutingOnRoutingChangedListenerInvoker.cb_onRoutingChanged_Landroid_media_AudioRouting_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAudioRoutingOnRoutingChangedListenerInvoker.n_OnRoutingChanged_Landroid_media_AudioRouting_));
			}
			return IAudioRoutingOnRoutingChangedListenerInvoker.cb_onRoutingChanged_Landroid_media_AudioRouting_;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00030994 File Offset: 0x0002EB94
		private static void n_OnRoutingChanged_Landroid_media_AudioRouting_(IntPtr jnienv, IntPtr native__this, IntPtr native_router)
		{
			IAudioRoutingOnRoutingChangedListener @object = Java.Lang.Object.GetObject<IAudioRoutingOnRoutingChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAudioRouting object2 = Java.Lang.Object.GetObject<IAudioRouting>(native_router, JniHandleOwnership.DoNotTransfer);
			@object.OnRoutingChanged(object2);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000309B8 File Offset: 0x0002EBB8
		public unsafe void OnRoutingChanged(IAudioRouting router)
		{
			if (this.id_onRoutingChanged_Landroid_media_AudioRouting_ == IntPtr.Zero)
			{
				this.id_onRoutingChanged_Landroid_media_AudioRouting_ = JNIEnv.GetMethodID(this.class_ref, "onRoutingChanged", "(Landroid/media/AudioRouting;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((router == null) ? IntPtr.Zero : ((Java.Lang.Object)router).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRoutingChanged_Landroid_media_AudioRouting_, ptr);
		}

		// Token: 0x04000847 RID: 2119
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/AudioRouting$OnRoutingChangedListener", typeof(IAudioRoutingOnRoutingChangedListenerInvoker));

		// Token: 0x04000848 RID: 2120
		private IntPtr class_ref;

		// Token: 0x04000849 RID: 2121
		private static Delegate cb_onRoutingChanged_Landroid_media_AudioRouting_;

		// Token: 0x0400084A RID: 2122
		private IntPtr id_onRoutingChanged_Landroid_media_AudioRouting_;
	}
}
