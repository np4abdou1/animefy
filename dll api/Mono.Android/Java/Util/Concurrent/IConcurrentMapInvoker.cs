using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x0200034C RID: 844
	[Register("java/util/concurrent/ConcurrentMap", DoNotGenerateAcw = true)]
	internal class IConcurrentMapInvoker : Java.Lang.Object, IConcurrentMap, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0006A360 File Offset: 0x00068560
		private static IntPtr java_class_ref
		{
			get
			{
				return IConcurrentMapInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0006A384 File Offset: 0x00068584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConcurrentMapInvoker._members;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x0006A38B File Offset: 0x0006858B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0006A393 File Offset: 0x00068593
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConcurrentMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0006A39F File Offset: 0x0006859F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConcurrentMapInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.ConcurrentMap'.");
			}
			return handle;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0006A3CA File Offset: 0x000685CA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0006A3FC File Offset: 0x000685FC
		public IConcurrentMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConcurrentMapInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0006A434 File Offset: 0x00068634
		private static Delegate GetPutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IConcurrentMapInvoker.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IConcurrentMapInvoker.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMapInvoker.n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IConcurrentMapInvoker.cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0006A458 File Offset: 0x00068658
		private static IntPtr n_PutIfAbsent_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IConcurrentMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.PutIfAbsent(object2, object3));
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0006A48C File Offset: 0x0006868C
		public unsafe Java.Lang.Object PutIfAbsent(Java.Lang.Object key, Java.Lang.Object value)
		{
			if (this.id_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0006A523 File Offset: 0x00068723
		private static Delegate GetRemove_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IConcurrentMapInvoker.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IConcurrentMapInvoker.cb_remove_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IConcurrentMapInvoker.n_Remove_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IConcurrentMapInvoker.cb_remove_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0006A548 File Offset: 0x00068748
		private static bool n_Remove_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IConcurrentMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2, object3);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0006A574 File Offset: 0x00068774
		public unsafe bool Remove(Java.Lang.Object key, Java.Lang.Object value)
		{
			if (this.id_remove_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : key.Handle);
			ptr[1] = new JValue((value == null) ? IntPtr.Zero : value.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_remove_Ljava_lang_Object_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0006A609 File Offset: 0x00068809
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConcurrentMapInvoker.n_Replace_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0006A630 File Offset: 0x00068830
		private static IntPtr n_Replace_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			IConcurrentMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(object2, object3));
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x0006A664 File Offset: 0x00068864
		public unsafe Java.Lang.Object Replace(Java.Lang.Object key, Java.Lang.Object value)
		{
			if (this.id_replace_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_replace_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_replace_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0006A6FB File Offset: 0x000688FB
		private static Delegate GetReplace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IConcurrentMapInvoker.n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IConcurrentMapInvoker.cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0006A720 File Offset: 0x00068920
		private static bool n_Replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_oldValue, IntPtr native_newValue)
		{
			IConcurrentMap @object = Java.Lang.Object.GetObject<IConcurrentMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_oldValue, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_newValue, JniHandleOwnership.DoNotTransfer);
			return @object.Replace(object2, object3, object4);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0006A758 File Offset: 0x00068958
		public unsafe bool Replace(Java.Lang.Object key, Java.Lang.Object oldValue, Java.Lang.Object newValue)
		{
			if (this.id_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(oldValue);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(newValue);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
			return result;
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0006A80C File Offset: 0x00068A0C
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0006A84C File Offset: 0x00068A4C
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0006A88C File Offset: 0x00068A8C
		public unsafe bool ContainsKey(Java.Lang.Object key)
		{
			if (this.id_containsKey_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_containsKey_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "containsKey", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsKey_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x0006A900 File Offset: 0x00068B00
		public unsafe bool ContainsValue(Java.Lang.Object value)
		{
			if (this.id_containsValue_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_containsValue_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "containsValue", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsValue_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0006A974 File Offset: 0x00068B74
		public ICollection EntrySet()
		{
			if (this.id_entrySet == IntPtr.Zero)
			{
				this.id_entrySet = JNIEnv.GetMethodID(this.class_ref, "entrySet", "()Ljava/util/Set;");
			}
			return JavaSet.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_entrySet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0006A9C8 File Offset: 0x00068BC8
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

		// Token: 0x06002534 RID: 9524 RVA: 0x0006AA3C File Offset: 0x00068C3C
		public unsafe Java.Lang.Object Get(Java.Lang.Object key)
		{
			if (this.id_get_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0006AAB3 File Offset: 0x00068CB3
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0006AAF4 File Offset: 0x00068CF4
		public ICollection KeySet()
		{
			if (this.id_keySet == IntPtr.Zero)
			{
				this.id_keySet = JNIEnv.GetMethodID(this.class_ref, "keySet", "()Ljava/util/Set;");
			}
			return JavaSet.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_keySet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0006AB48 File Offset: 0x00068D48
		public unsafe Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			if (this.id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_put_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x0006ABE0 File Offset: 0x00068DE0
		public unsafe void PutAll(IDictionary m)
		{
			if (this.id_putAll_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_putAll_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "putAll", "(Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(m);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_putAll_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0006AC54 File Offset: 0x00068E54
		public unsafe Java.Lang.Object Remove(Java.Lang.Object key)
		{
			if (this.id_remove_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0006ACCB File Offset: 0x00068ECB
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0006AD0C File Offset: 0x00068F0C
		public ICollection Values()
		{
			if (this.id_values == IntPtr.Zero)
			{
				this.id_values = JNIEnv.GetMethodID(this.class_ref, "values", "()Ljava/util/Collection;");
			}
			return JavaCollection.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_values), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000F4A RID: 3914
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/ConcurrentMap", typeof(IConcurrentMapInvoker));

		// Token: 0x04000F4B RID: 3915
		private IntPtr class_ref;

		// Token: 0x04000F4C RID: 3916
		private static Delegate cb_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F4D RID: 3917
		private IntPtr id_putIfAbsent_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F4E RID: 3918
		private static Delegate cb_remove_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F4F RID: 3919
		private IntPtr id_remove_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F50 RID: 3920
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F51 RID: 3921
		private IntPtr id_replace_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F52 RID: 3922
		private static Delegate cb_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F53 RID: 3923
		private IntPtr id_replace_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F54 RID: 3924
		private IntPtr id_isEmpty;

		// Token: 0x04000F55 RID: 3925
		private IntPtr id_clear;

		// Token: 0x04000F56 RID: 3926
		private IntPtr id_containsKey_Ljava_lang_Object_;

		// Token: 0x04000F57 RID: 3927
		private IntPtr id_containsValue_Ljava_lang_Object_;

		// Token: 0x04000F58 RID: 3928
		private IntPtr id_entrySet;

		// Token: 0x04000F59 RID: 3929
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000F5A RID: 3930
		private IntPtr id_get_Ljava_lang_Object_;

		// Token: 0x04000F5B RID: 3931
		private IntPtr id_hashCode;

		// Token: 0x04000F5C RID: 3932
		private IntPtr id_keySet;

		// Token: 0x04000F5D RID: 3933
		private IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000F5E RID: 3934
		private IntPtr id_putAll_Ljava_util_Map_;

		// Token: 0x04000F5F RID: 3935
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000F60 RID: 3936
		private IntPtr id_size;

		// Token: 0x04000F61 RID: 3937
		private IntPtr id_values;
	}
}
