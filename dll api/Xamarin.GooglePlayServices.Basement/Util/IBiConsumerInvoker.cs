using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Util
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/android/gms/common/util/BiConsumer", DoNotGenerateAcw = true)]
	internal class IBiConsumerInvoker : Java.Lang.Object, IBiConsumer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002918 File Offset: 0x00000B18
		private static IntPtr java_class_ref
		{
			get
			{
				return IBiConsumerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000293C File Offset: 0x00000B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBiConsumerInvoker._members;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002943 File Offset: 0x00000B43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000294B File Offset: 0x00000B4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBiConsumerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002957 File Offset: 0x00000B57
		public static IBiConsumer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBiConsumer>(handle, transfer);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002960 File Offset: 0x00000B60
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBiConsumerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.util.BiConsumer'.");
			}
			return handle;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000298B File Offset: 0x00000B8B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000029BC File Offset: 0x00000BBC
		public IBiConsumerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBiConsumerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000029F4 File Offset: 0x00000BF4
		private static Delegate GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBiConsumerInvoker.n_Accept_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002A18 File Offset: 0x00000C18
		private static void n_Accept_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IBiConsumer @object = Java.Lang.Object.GetObject<IBiConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Accept(object2, object3);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002A44 File Offset: 0x00000C44
		public unsafe void Accept(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			if (this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "accept", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_accept_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/util/BiConsumer", typeof(IBiConsumerInvoker));

		// Token: 0x04000006 RID: 6
		private IntPtr class_ref;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_accept_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000008 RID: 8
		private IntPtr id_accept_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
