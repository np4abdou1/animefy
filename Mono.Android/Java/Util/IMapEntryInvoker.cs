using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000313 RID: 787
	[Register("java/util/Map$Entry", DoNotGenerateAcw = true)]
	internal class IMapEntryInvoker : Java.Lang.Object, IMapEntry, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00058F7C File Offset: 0x0005717C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMapEntryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00058FA0 File Offset: 0x000571A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMapEntryInvoker._members;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00058FA7 File Offset: 0x000571A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x00058FAF File Offset: 0x000571AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMapEntryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00058FBB File Offset: 0x000571BB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMapEntryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Map.Entry'.");
			}
			return handle;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00058FE6 File Offset: 0x000571E6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00059018 File Offset: 0x00057218
		public IMapEntryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMapEntryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00059050 File Offset: 0x00057250
		private static Delegate GetGetKeyHandler()
		{
			if (IMapEntryInvoker.cb_getKey == null)
			{
				IMapEntryInvoker.cb_getKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapEntryInvoker.n_GetKey));
			}
			return IMapEntryInvoker.cb_getKey;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00059074 File Offset: 0x00057274
		private static IntPtr n_GetKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMapEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Key);
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00059088 File Offset: 0x00057288
		public Java.Lang.Object Key
		{
			get
			{
				if (this.id_getKey == IntPtr.Zero)
				{
					this.id_getKey = JNIEnv.GetMethodID(this.class_ref, "getKey", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000590D9 File Offset: 0x000572D9
		private static Delegate GetGetValueHandler()
		{
			if (IMapEntryInvoker.cb_getValue == null)
			{
				IMapEntryInvoker.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMapEntryInvoker.n_GetValue));
			}
			return IMapEntryInvoker.cb_getValue;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000590FD File Offset: 0x000572FD
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMapEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x00059114 File Offset: 0x00057314
		public Java.Lang.Object Value
		{
			get
			{
				if (this.id_getValue == IntPtr.Zero)
				{
					this.id_getValue = JNIEnv.GetMethodID(this.class_ref, "getValue", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00059165 File Offset: 0x00057365
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMapEntryInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMapEntryInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMapEntryInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMapEntryInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x0005918C File Offset: 0x0005738C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IMapEntry @object = Java.Lang.Object.GetObject<IMapEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000591B0 File Offset: 0x000573B0
		public new unsafe bool Equals(Java.Lang.Object o)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00059223 File Offset: 0x00057423
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMapEntryInvoker.cb_hashCode == null)
			{
				IMapEntryInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMapEntryInvoker.n_GetHashCode));
			}
			return IMapEntryInvoker.cb_hashCode;
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00059247 File Offset: 0x00057447
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMapEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00059256 File Offset: 0x00057456
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00059296 File Offset: 0x00057496
		private static Delegate GetSetValue_Ljava_lang_Object_Handler()
		{
			if (IMapEntryInvoker.cb_setValue_Ljava_lang_Object_ == null)
			{
				IMapEntryInvoker.cb_setValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMapEntryInvoker.n_SetValue_Ljava_lang_Object_));
			}
			return IMapEntryInvoker.cb_setValue_Ljava_lang_Object_;
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000592BC File Offset: 0x000574BC
		private static IntPtr n_SetValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IMapEntry @object = Java.Lang.Object.GetObject<IMapEntry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetValue(object2));
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000592E4 File Offset: 0x000574E4
		public unsafe Java.Lang.Object SetValue(Java.Lang.Object value)
		{
			if (this.id_setValue_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_setValue_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "setValue", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_setValue_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000D44 RID: 3396
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Map$Entry", typeof(IMapEntryInvoker));

		// Token: 0x04000D45 RID: 3397
		private IntPtr class_ref;

		// Token: 0x04000D46 RID: 3398
		private static Delegate cb_getKey;

		// Token: 0x04000D47 RID: 3399
		private IntPtr id_getKey;

		// Token: 0x04000D48 RID: 3400
		private static Delegate cb_getValue;

		// Token: 0x04000D49 RID: 3401
		private IntPtr id_getValue;

		// Token: 0x04000D4A RID: 3402
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000D4B RID: 3403
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000D4C RID: 3404
		private static Delegate cb_hashCode;

		// Token: 0x04000D4D RID: 3405
		private IntPtr id_hashCode;

		// Token: 0x04000D4E RID: 3406
		private static Delegate cb_setValue_Ljava_lang_Object_;

		// Token: 0x04000D4F RID: 3407
		private IntPtr id_setValue_Ljava_lang_Object_;
	}
}
