using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/datatransport/Transformer", DoNotGenerateAcw = true)]
	internal class ITransformerInvoker : Java.Lang.Object, ITransformer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000027A4 File Offset: 0x000009A4
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransformerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000027C8 File Offset: 0x000009C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransformerInvoker._members;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000027CF File Offset: 0x000009CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000027D7 File Offset: 0x000009D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransformerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000027E3 File Offset: 0x000009E3
		public static ITransformer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransformer>(handle, transfer);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000027EC File Offset: 0x000009EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransformerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.Transformer'.");
			}
			return handle;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002817 File Offset: 0x00000A17
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002848 File Offset: 0x00000A48
		public ITransformerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransformerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002880 File Offset: 0x00000A80
		private static Delegate GetApply_Ljava_lang_Object_Handler()
		{
			if (ITransformerInvoker.cb_apply_Ljava_lang_Object_ == null)
			{
				ITransformerInvoker.cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ITransformerInvoker.n_Apply_Ljava_lang_Object_));
			}
			return ITransformerInvoker.cb_apply_Ljava_lang_Object_;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000028A4 File Offset: 0x00000AA4
		private static IntPtr n_Apply_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransformer @object = Java.Lang.Object.GetObject<ITransformer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Apply(object2));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000028CC File Offset: 0x00000ACC
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

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Transformer", typeof(ITransformerInvoker));

		// Token: 0x0400000F RID: 15
		private IntPtr class_ref;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_apply_Ljava_lang_Object_;

		// Token: 0x04000011 RID: 17
		private IntPtr id_apply_Ljava_lang_Object_;
	}
}
