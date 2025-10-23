using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D5 RID: 213
	[Register("com/bumptech/glide/load/Key", DoNotGenerateAcw = true)]
	internal class IKeyInvoker : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00021624 File Offset: 0x0001F824
		private static IntPtr java_class_ref
		{
			get
			{
				return IKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00021648 File Offset: 0x0001F848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKeyInvoker._members;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002164F File Offset: 0x0001F84F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00021657 File Offset: 0x0001F857
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00021663 File Offset: 0x0001F863
		public static IKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKey>(handle, transfer);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002166C File Offset: 0x0001F86C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.Key'.");
			}
			return handle;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00021697 File Offset: 0x0001F897
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000216C8 File Offset: 0x0001F8C8
		public IKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00021700 File Offset: 0x0001F900
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IKeyInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IKeyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IKeyInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IKeyInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00021724 File Offset: 0x0001F924
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IKey @object = Java.Lang.Object.GetObject<IKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00021748 File Offset: 0x0001F948
		public new unsafe bool Equals(Java.Lang.Object p0)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000217BB File Offset: 0x0001F9BB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IKeyInvoker.cb_hashCode == null)
			{
				IKeyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IKeyInvoker.n_GetHashCode));
			}
			return IKeyInvoker.cb_hashCode;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000217DF File Offset: 0x0001F9DF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000217EE File Offset: 0x0001F9EE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0002182E File Offset: 0x0001FA2E
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (IKeyInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				IKeyInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IKeyInvoker.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return IKeyInvoker.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00021854 File Offset: 0x0001FA54
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IKey @object = Java.Lang.Object.GetObject<IKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00021878 File Offset: 0x0001FA78
		public unsafe void UpdateDiskCacheKey(MessageDigest p0)
		{
			if (this.id_updateDiskCacheKey_Ljava_security_MessageDigest_ == IntPtr.Zero)
			{
				this.id_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNIEnv.GetMethodID(this.class_ref, "updateDiskCacheKey", "(Ljava/security/MessageDigest;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_updateDiskCacheKey_Ljava_security_MessageDigest_, ptr);
		}

		// Token: 0x040002A6 RID: 678
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Key", typeof(IKeyInvoker));

		// Token: 0x040002A7 RID: 679
		private IntPtr class_ref;

		// Token: 0x040002A8 RID: 680
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040002A9 RID: 681
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040002AA RID: 682
		private static Delegate cb_hashCode;

		// Token: 0x040002AB RID: 683
		private IntPtr id_hashCode;

		// Token: 0x040002AC RID: 684
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;

		// Token: 0x040002AD RID: 685
		private IntPtr id_updateDiskCacheKey_Ljava_security_MessageDigest_;
	}
}
