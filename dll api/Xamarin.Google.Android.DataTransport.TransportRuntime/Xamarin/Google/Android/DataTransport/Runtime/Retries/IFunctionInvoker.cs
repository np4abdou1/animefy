using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Retries
{
	// Token: 0x02000062 RID: 98
	[Register("com/google/android/datatransport/runtime/retries/Function", DoNotGenerateAcw = true)]
	internal class IFunctionInvoker : Java.Lang.Object, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000A63C File Offset: 0x0000883C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000A660 File Offset: 0x00008860
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFunctionInvoker._members;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000A667 File Offset: 0x00008867
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000A66F File Offset: 0x0000886F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000A67B File Offset: 0x0000887B
		public static IFunction GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction>(handle, transfer);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000A684 File Offset: 0x00008884
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.retries.Function'.");
			}
			return handle;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000A6AF File Offset: 0x000088AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000A6E0 File Offset: 0x000088E0
		public IFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000A718 File Offset: 0x00008918
		private static Delegate GetApply_Ljava_lang_Object_Handler()
		{
			if (IFunctionInvoker.cb_apply_Ljava_lang_Object_ == null)
			{
				IFunctionInvoker.cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunctionInvoker.n_Apply_Ljava_lang_Object_));
			}
			return IFunctionInvoker.cb_apply_Ljava_lang_Object_;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000A73C File Offset: 0x0000893C
		private static IntPtr n_Apply_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction @object = Java.Lang.Object.GetObject<IFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Apply(object2));
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000A764 File Offset: 0x00008964
		public unsafe Java.Lang.Object Apply(Java.Lang.Object p0)
		{
			if (this.id_apply_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_apply_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x040000B5 RID: 181
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/retries/Function", typeof(IFunctionInvoker));

		// Token: 0x040000B6 RID: 182
		private IntPtr class_ref;

		// Token: 0x040000B7 RID: 183
		private static Delegate cb_apply_Ljava_lang_Object_;

		// Token: 0x040000B8 RID: 184
		private IntPtr id_apply_Ljava_lang_Object_;
	}
}
