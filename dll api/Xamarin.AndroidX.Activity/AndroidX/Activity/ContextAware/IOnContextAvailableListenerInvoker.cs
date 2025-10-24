using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x0200001E RID: 30
	[Register("androidx/activity/contextaware/OnContextAvailableListener", DoNotGenerateAcw = true)]
	internal class IOnContextAvailableListenerInvoker : Java.Lang.Object, IOnContextAvailableListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00004208 File Offset: 0x00002408
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnContextAvailableListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000422C File Offset: 0x0000242C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnContextAvailableListenerInvoker._members;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00004233 File Offset: 0x00002433
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000423B File Offset: 0x0000243B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnContextAvailableListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004247 File Offset: 0x00002447
		public static IOnContextAvailableListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnContextAvailableListener>(handle, transfer);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004250 File Offset: 0x00002450
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnContextAvailableListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.contextaware.OnContextAvailableListener'.");
			}
			return handle;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000427B File Offset: 0x0000247B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000042AC File Offset: 0x000024AC
		public IOnContextAvailableListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnContextAvailableListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000042E4 File Offset: 0x000024E4
		private static Delegate GetOnContextAvailable_Landroid_content_Context_Handler()
		{
			if (IOnContextAvailableListenerInvoker.cb_onContextAvailable_Landroid_content_Context_ == null)
			{
				IOnContextAvailableListenerInvoker.cb_onContextAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnContextAvailableListenerInvoker.n_OnContextAvailable_Landroid_content_Context_));
			}
			return IOnContextAvailableListenerInvoker.cb_onContextAvailable_Landroid_content_Context_;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004308 File Offset: 0x00002508
		private static void n_OnContextAvailable_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			IOnContextAvailableListener @object = Java.Lang.Object.GetObject<IOnContextAvailableListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.OnContextAvailable(object2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000432C File Offset: 0x0000252C
		public unsafe void OnContextAvailable(Context context)
		{
			if (this.id_onContextAvailable_Landroid_content_Context_ == IntPtr.Zero)
			{
				this.id_onContextAvailable_Landroid_content_Context_ = JNIEnv.GetMethodID(this.class_ref, "onContextAvailable", "(Landroid/content/Context;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((context == null) ? IntPtr.Zero : context.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onContextAvailable_Landroid_content_Context_, ptr);
		}

		// Token: 0x04000030 RID: 48
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/contextaware/OnContextAvailableListener", typeof(IOnContextAvailableListenerInvoker));

		// Token: 0x04000031 RID: 49
		private IntPtr class_ref;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_onContextAvailable_Landroid_content_Context_;

		// Token: 0x04000033 RID: 51
		private IntPtr id_onContextAvailable_Landroid_content_Context_;
	}
}
