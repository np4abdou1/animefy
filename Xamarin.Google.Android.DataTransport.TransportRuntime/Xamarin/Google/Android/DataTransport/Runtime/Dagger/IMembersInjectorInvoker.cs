using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AC RID: 172
	[Register("com/google/android/datatransport/runtime/dagger/MembersInjector", DoNotGenerateAcw = true)]
	internal class IMembersInjectorInvoker : Java.Lang.Object, IMembersInjector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00012450 File Offset: 0x00010650
		private static IntPtr java_class_ref
		{
			get
			{
				return IMembersInjectorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00012474 File Offset: 0x00010674
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMembersInjectorInvoker._members;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001247B File Offset: 0x0001067B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00012483 File Offset: 0x00010683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMembersInjectorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001248F File Offset: 0x0001068F
		public static IMembersInjector GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMembersInjector>(handle, transfer);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00012498 File Offset: 0x00010698
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMembersInjectorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.MembersInjector'.");
			}
			return handle;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000124C3 File Offset: 0x000106C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000124F4 File Offset: 0x000106F4
		public IMembersInjectorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMembersInjectorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001252C File Offset: 0x0001072C
		private static Delegate GetInjectMembers_Ljava_lang_Object_Handler()
		{
			if (IMembersInjectorInvoker.cb_injectMembers_Ljava_lang_Object_ == null)
			{
				IMembersInjectorInvoker.cb_injectMembers_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMembersInjectorInvoker.n_InjectMembers_Ljava_lang_Object_));
			}
			return IMembersInjectorInvoker.cb_injectMembers_Ljava_lang_Object_;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00012550 File Offset: 0x00010750
		private static void n_InjectMembers_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMembersInjector @object = Java.Lang.Object.GetObject<IMembersInjector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.InjectMembers(object2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00012574 File Offset: 0x00010774
		public unsafe void InjectMembers(Java.Lang.Object p0)
		{
			if (this.id_injectMembers_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_injectMembers_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "injectMembers", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_injectMembers_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000181 RID: 385
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/MembersInjector", typeof(IMembersInjectorInvoker));

		// Token: 0x04000182 RID: 386
		private IntPtr class_ref;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_injectMembers_Ljava_lang_Object_;

		// Token: 0x04000184 RID: 388
		private IntPtr id_injectMembers_Ljava_lang_Object_;
	}
}
