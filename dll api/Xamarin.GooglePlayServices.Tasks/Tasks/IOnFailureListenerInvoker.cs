using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/android/gms/tasks/OnFailureListener", DoNotGenerateAcw = true)]
	internal class IOnFailureListenerInvoker : Java.Lang.Object, IOnFailureListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003B2C File Offset: 0x00001D2C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnFailureListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003B50 File Offset: 0x00001D50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnFailureListenerInvoker._members;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003B57 File Offset: 0x00001D57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003B5F File Offset: 0x00001D5F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnFailureListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003B6B File Offset: 0x00001D6B
		public static IOnFailureListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnFailureListener>(handle, transfer);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003B74 File Offset: 0x00001D74
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnFailureListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.OnFailureListener'.");
			}
			return handle;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003B9F File Offset: 0x00001D9F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public IOnFailureListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnFailureListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003C08 File Offset: 0x00001E08
		private static Delegate GetOnFailure_Ljava_lang_Exception_Handler()
		{
			if (IOnFailureListenerInvoker.cb_onFailure_Ljava_lang_Exception_ == null)
			{
				IOnFailureListenerInvoker.cb_onFailure_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnFailureListenerInvoker.n_OnFailure_Ljava_lang_Exception_));
			}
			return IOnFailureListenerInvoker.cb_onFailure_Ljava_lang_Exception_;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003C2C File Offset: 0x00001E2C
		private static void n_OnFailure_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IOnFailureListener @object = Java.Lang.Object.GetObject<IOnFailureListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.OnFailure(object2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003C50 File Offset: 0x00001E50
		public unsafe void OnFailure(Java.Lang.Exception e)
		{
			if (this.id_onFailure_Ljava_lang_Exception_ == IntPtr.Zero)
			{
				this.id_onFailure_Ljava_lang_Exception_ = JNIEnv.GetMethodID(this.class_ref, "onFailure", "(Ljava/lang/Exception;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFailure_Ljava_lang_Exception_, ptr);
		}

		// Token: 0x04000030 RID: 48
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/OnFailureListener", typeof(IOnFailureListenerInvoker));

		// Token: 0x04000031 RID: 49
		private IntPtr class_ref;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_onFailure_Ljava_lang_Exception_;

		// Token: 0x04000033 RID: 51
		private IntPtr id_onFailure_Ljava_lang_Exception_;
	}
}
