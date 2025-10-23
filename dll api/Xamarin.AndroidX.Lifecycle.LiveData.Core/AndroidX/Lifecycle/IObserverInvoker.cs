using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000B RID: 11
	[Register("androidx/lifecycle/Observer", DoNotGenerateAcw = true)]
	internal class IObserverInvoker : Java.Lang.Object, IObserver, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002080 File Offset: 0x00000280
		private static IntPtr java_class_ref
		{
			get
			{
				return IObserverInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IObserverInvoker._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020AB File Offset: 0x000002AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020B3 File Offset: 0x000002B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IObserverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020BF File Offset: 0x000002BF
		public static IObserver GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IObserver>(handle, transfer);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020C8 File Offset: 0x000002C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IObserverInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.Observer'.");
			}
			return handle;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020F3 File Offset: 0x000002F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002124 File Offset: 0x00000324
		public IObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IObserverInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000215C File Offset: 0x0000035C
		private static Delegate GetOnChanged_Ljava_lang_Object_Handler()
		{
			if (IObserverInvoker.cb_onChanged_Ljava_lang_Object_ == null)
			{
				IObserverInvoker.cb_onChanged_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IObserverInvoker.n_OnChanged_Ljava_lang_Object_));
			}
			return IObserverInvoker.cb_onChanged_Ljava_lang_Object_;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002180 File Offset: 0x00000380
		private static void n_OnChanged_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IObserver @object = Java.Lang.Object.GetObject<IObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.OnChanged(object2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021A4 File Offset: 0x000003A4
		public unsafe void OnChanged(Java.Lang.Object value)
		{
			if (this.id_onChanged_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onChanged_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onChanged", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onChanged_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/Observer", typeof(IObserverInvoker));

		// Token: 0x04000004 RID: 4
		private IntPtr class_ref;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_onChanged_Ljava_lang_Object_;

		// Token: 0x04000006 RID: 6
		private IntPtr id_onChanged_Ljava_lang_Object_;
	}
}
