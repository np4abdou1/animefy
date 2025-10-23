using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Collections
{
	// Token: 0x020002B0 RID: 688
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public abstract class AbstractMap : Java.Lang.Object, IMap, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0006AD80 File Offset: 0x00068F80
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0006ADA4 File Offset: 0x00068FA4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractMap._members;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0006ADAC File Offset: 0x00068FAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0006ADD0 File Offset: 0x00068FD0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractMap._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0006ADDC File Offset: 0x00068FDC
		protected AbstractMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0006ADE8 File Offset: 0x00068FE8
		[Register(".ctor", "()V", "")]
		protected AbstractMap() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractMap._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractMap._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0006AE56 File Offset: 0x00069056
		[NullableContext(1)]
		private static Delegate GetGetEntriesHandler()
		{
			if (AbstractMap.cb_getEntries == null)
			{
				AbstractMap.cb_getEntries = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMap.n_GetEntries));
			}
			return AbstractMap.cb_getEntries;
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0006AE7A File Offset: 0x0006907A
		private static IntPtr n_GetEntries(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Entries);
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001FFB RID: 8187
		public abstract System.Collections.ICollection Entries { [Register("getEntries", "()Ljava/util/Set;", "GetGetEntriesHandler")] get; }

		// Token: 0x06001FFC RID: 8188 RVA: 0x0006AE8E File Offset: 0x0006908E
		[NullableContext(1)]
		private static Delegate GetIsEmptyHandler()
		{
			if (AbstractMap.cb_isEmpty == null)
			{
				AbstractMap.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractMap.n_IsEmpty));
			}
			return AbstractMap.cb_isEmpty;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0006AEB2 File Offset: 0x000690B2
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0006AEC1 File Offset: 0x000690C1
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0006AEDA File Offset: 0x000690DA
		[NullableContext(1)]
		private static Delegate GetGetKeysHandler()
		{
			if (AbstractMap.cb_getKeys == null)
			{
				AbstractMap.cb_getKeys = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractMap.n_GetKeys));
			}
			return AbstractMap.cb_getKeys;
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0006AEFE File Offset: 0x000690FE
		private static IntPtr n_GetKeys(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Keys);
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0006AF14 File Offset: 0x00069114
		[Nullable(1)]
		public virtual System.Collections.ICollection Keys
		{
			[NullableContext(1)]
			[Register("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get
			{
				return JavaSet.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("getKeys.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0006AF46 File Offset: 0x00069146
		[NullableContext(1)]
		private static Delegate GetClearHandler()
		{
			if (AbstractMap.cb_clear == null)
			{
				AbstractMap.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractMap.n_Clear));
			}
			return AbstractMap.cb_clear;
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0006AF6A File Offset: 0x0006916A
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0006AF79 File Offset: 0x00069179
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			AbstractMap._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0006AF92 File Offset: 0x00069192
		[NullableContext(1)]
		private static Delegate GetContainsKey_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_containsKey_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMap.n_ContainsKey_Ljava_lang_Object_));
			}
			return AbstractMap.cb_containsKey_Ljava_lang_Object_;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0006AFB8 File Offset: 0x000691B8
		private static bool n_ContainsKey_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsKey(object2);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0006AFDC File Offset: 0x000691DC
		[Register("containsKey", "(Ljava/lang/Object;)Z", "GetContainsKey_Ljava_lang_Object_Handler")]
		public unsafe virtual bool ContainsKey(Java.Lang.Object key)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				result = AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsKey.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0006B044 File Offset: 0x00069244
		[NullableContext(1)]
		private static Delegate GetContainsValue_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_containsValue_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractMap.n_ContainsValue_Ljava_lang_Object_));
			}
			return AbstractMap.cb_containsValue_Ljava_lang_Object_;
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0006B068 File Offset: 0x00069268
		private static bool n_ContainsValue_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsValue(object2);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0006B08C File Offset: 0x0006928C
		[Register("containsValue", "(Ljava/lang/Object;)Z", "GetContainsValue_Ljava_lang_Object_Handler")]
		public unsafe virtual bool ContainsValue(Java.Lang.Object value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = AbstractMap._members.InstanceMethods.InvokeVirtualBooleanMethod("containsValue.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0006B0F4 File Offset: 0x000692F4
		[Register("entrySet", "()Ljava/util/Set;", "")]
		public System.Collections.ICollection EntrySet()
		{
			return JavaSet.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("entrySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0006B126 File Offset: 0x00069326
		[NullableContext(1)]
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_get_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractMap.n_Get_Ljava_lang_Object_));
			}
			return AbstractMap.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0006B14C File Offset: 0x0006934C
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0006B174 File Offset: 0x00069374
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0006B1E8 File Offset: 0x000693E8
		[Register("keySet", "()Ljava/util/Set;", "")]
		public System.Collections.ICollection KeySet()
		{
			return JavaSet.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("keySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0006B21A File Offset: 0x0006941A
		[NullableContext(1)]
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AbstractMap.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return AbstractMap.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0006B240 File Offset: 0x00069440
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0006B274 File Offset: 0x00069474
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0006B310 File Offset: 0x00069510
		[NullableContext(1)]
		private static Delegate GetPutAll_Ljava_util_Map_Handler()
		{
			if (AbstractMap.cb_putAll_Ljava_util_Map_ == null)
			{
				AbstractMap.cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbstractMap.n_PutAll_Ljava_util_Map_));
			}
			return AbstractMap.cb_putAll_Ljava_util_Map_;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0006B334 File Offset: 0x00069534
		private static void n_PutAll_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_from)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary from = JavaDictionary.FromJniHandle(native_from, JniHandleOwnership.DoNotTransfer);
			@object.PutAll(from);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0006B358 File Offset: 0x00069558
		[Register("putAll", "(Ljava/util/Map;)V", "GetPutAll_Ljava_util_Map_Handler")]
		public unsafe virtual void PutAll(IDictionary from)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(from);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AbstractMap._members.InstanceMethods.InvokeVirtualVoidMethod("putAll.(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(from);
			}
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0006B3BC File Offset: 0x000695BC
		[NullableContext(1)]
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (AbstractMap.cb_remove_Ljava_lang_Object_ == null)
			{
				AbstractMap.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AbstractMap.n_Remove_Ljava_lang_Object_));
			}
			return AbstractMap.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0006B3E0 File Offset: 0x000695E0
		private static IntPtr n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractMap @object = Java.Lang.Object.GetObject<AbstractMap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0006B408 File Offset: 0x00069608
		[Register("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Remove(Java.Lang.Object key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractMap._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0006B47C File Offset: 0x0006967C
		[Register("size", "()I", "")]
		public int Size()
		{
			return AbstractMap._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0006B498 File Offset: 0x00069698
		[Register("values", "()Ljava/util/Collection;", "")]
		public System.Collections.ICollection Values()
		{
			return JavaCollection.FromJniHandle(AbstractMap._members.InstanceMethods.InvokeNonvirtualObjectMethod("values.()Ljava/util/Collection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400096A RID: 2410
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMap", typeof(AbstractMap));

		// Token: 0x0400096B RID: 2411
		private static Delegate cb_getEntries;

		// Token: 0x0400096C RID: 2412
		private static Delegate cb_isEmpty;

		// Token: 0x0400096D RID: 2413
		private static Delegate cb_getKeys;

		// Token: 0x0400096E RID: 2414
		private static Delegate cb_clear;

		// Token: 0x0400096F RID: 2415
		private static Delegate cb_containsKey_Ljava_lang_Object_;

		// Token: 0x04000970 RID: 2416
		private static Delegate cb_containsValue_Ljava_lang_Object_;

		// Token: 0x04000971 RID: 2417
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x04000972 RID: 2418
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000973 RID: 2419
		private static Delegate cb_putAll_Ljava_util_Map_;

		// Token: 0x04000974 RID: 2420
		private static Delegate cb_remove_Ljava_lang_Object_;
	}
}
