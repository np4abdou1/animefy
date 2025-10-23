using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000026 RID: 38
	[Register("androidx/activity/result/ActivityResultCallback", DoNotGenerateAcw = true)]
	internal class IActivityResultCallbackInvoker : Java.Lang.Object, IActivityResultCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004D70 File Offset: 0x00002F70
		private static IntPtr java_class_ref
		{
			get
			{
				return IActivityResultCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004D94 File Offset: 0x00002F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IActivityResultCallbackInvoker._members;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004D9B File Offset: 0x00002F9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004DA3 File Offset: 0x00002FA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IActivityResultCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004DAF File Offset: 0x00002FAF
		public static IActivityResultCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IActivityResultCallback>(handle, transfer);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004DB8 File Offset: 0x00002FB8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IActivityResultCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.result.ActivityResultCallback'.");
			}
			return handle;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004DE3 File Offset: 0x00002FE3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004E14 File Offset: 0x00003014
		public IActivityResultCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IActivityResultCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004E4C File Offset: 0x0000304C
		private static Delegate GetOnActivityResult_Ljava_lang_Object_Handler()
		{
			if (IActivityResultCallbackInvoker.cb_onActivityResult_Ljava_lang_Object_ == null)
			{
				IActivityResultCallbackInvoker.cb_onActivityResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IActivityResultCallbackInvoker.n_OnActivityResult_Ljava_lang_Object_));
			}
			return IActivityResultCallbackInvoker.cb_onActivityResult_Ljava_lang_Object_;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004E70 File Offset: 0x00003070
		private static void n_OnActivityResult_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			IActivityResultCallback @object = Java.Lang.Object.GetObject<IActivityResultCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResult(object2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004E94 File Offset: 0x00003094
		public unsafe void OnActivityResult(Java.Lang.Object result)
		{
			if (this.id_onActivityResult_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onActivityResult_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onActivityResult", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onActivityResult_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultCallback", typeof(IActivityResultCallbackInvoker));

		// Token: 0x04000041 RID: 65
		private IntPtr class_ref;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onActivityResult_Ljava_lang_Object_;

		// Token: 0x04000043 RID: 67
		private IntPtr id_onActivityResult_Ljava_lang_Object_;
	}
}
