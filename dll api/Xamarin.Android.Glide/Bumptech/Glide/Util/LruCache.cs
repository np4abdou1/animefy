using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004F RID: 79
	[Register("com/bumptech/glide/util/LruCache", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"Y"
	})]
	public class LruCache : Java.Lang.Object
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		internal static IntPtr class_ref
		{
			get
			{
				return LruCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000B8FC File Offset: 0x00009AFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LruCache._members;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000B904 File Offset: 0x00009B04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LruCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0000B928 File Offset: 0x00009B28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LruCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000B934 File Offset: 0x00009B34
		protected LruCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000B940 File Offset: 0x00009B40
		[Register(".ctor", "(J)V", "")]
		public unsafe LruCache(long size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(LruCache._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LruCache._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		private static Delegate GetGetCountHandler()
		{
			if (LruCache.cb_getCount == null)
			{
				LruCache.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LruCache.n_GetCount));
			}
			return LruCache.cb_getCount;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000B9F7 File Offset: 0x00009BF7
		protected virtual int Count
		{
			[Register("getCount", "()I", "GetGetCountHandler")]
			get
			{
				return LruCache._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000BA10 File Offset: 0x00009C10
		private static Delegate GetGetCurrentSizeHandler()
		{
			if (LruCache.cb_getCurrentSize == null)
			{
				LruCache.cb_getCurrentSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruCache.n_GetCurrentSize));
			}
			return LruCache.cb_getCurrentSize;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000BA34 File Offset: 0x00009C34
		private static long n_GetCurrentSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSize;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000BA43 File Offset: 0x00009C43
		public virtual long CurrentSize
		{
			[Register("getCurrentSize", "()J", "GetGetCurrentSizeHandler")]
			get
			{
				return LruCache._members.InstanceMethods.InvokeVirtualInt64Method("getCurrentSize.()J", this, null);
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000BA5C File Offset: 0x00009C5C
		private static Delegate GetGetMaxSizeHandler()
		{
			if (LruCache.cb_getMaxSize == null)
			{
				LruCache.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruCache.n_GetMaxSize));
			}
			return LruCache.cb_getMaxSize;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000BA80 File Offset: 0x00009C80
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000BA8F File Offset: 0x00009C8F
		public virtual long MaxSize
		{
			[Register("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get
			{
				return LruCache._members.InstanceMethods.InvokeVirtualInt64Method("getMaxSize.()J", this, null);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		private static Delegate GetClearMemoryHandler()
		{
			if (LruCache.cb_clearMemory == null)
			{
				LruCache.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LruCache.n_ClearMemory));
			}
			return LruCache.cb_clearMemory;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000BACC File Offset: 0x00009CCC
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000BADB File Offset: 0x00009CDB
		[Register("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual void ClearMemory()
		{
			LruCache._members.InstanceMethods.InvokeVirtualVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_contains_Ljava_lang_Object_ == null)
			{
				LruCache.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(LruCache.n_Contains_Ljava_lang_Object_));
			}
			return LruCache.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000BB18 File Offset: 0x00009D18
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000BB3C File Offset: 0x00009D3C
		[Register("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Contains(Java.Lang.Object key)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = LruCache._members.InstanceMethods.InvokeVirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
			}
			return result;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_get_Ljava_lang_Object_ == null)
			{
				LruCache.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LruCache.n_Get_Ljava_lang_Object_));
			}
			return LruCache.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000BBEC File Offset: 0x00009DEC
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object key)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LruCache._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000BC60 File Offset: 0x00009E60
		private static Delegate GetGetSize_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_getSize_Ljava_lang_Object_ == null)
			{
				LruCache.cb_getSize_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(LruCache.n_GetSize_Ljava_lang_Object_));
			}
			return LruCache.cb_getSize_Ljava_lang_Object_;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000BC84 File Offset: 0x00009E84
		private static int n_GetSize_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.GetSize(object2);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		[Register("getSize", "(Ljava/lang/Object;)I", "GetGetSize_Ljava_lang_Object_Handler")]
		protected unsafe virtual int GetSize(Java.Lang.Object item)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(item);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = LruCache._members.InstanceMethods.InvokeVirtualInt32Method("getSize.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000BD0C File Offset: 0x00009F0C
		private static Delegate GetOnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				LruCache.cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LruCache.n_OnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return LruCache.cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000BD30 File Offset: 0x00009F30
		private static void n_OnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_item)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
			@object.OnItemEvicted(object2, object3);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000BD5C File Offset: 0x00009F5C
		[Register("onItemEvicted", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetOnItemEvicted_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		protected unsafe virtual void OnItemEvicted(Java.Lang.Object key, Java.Lang.Object item)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(item);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				LruCache._members.InstanceMethods.InvokeVirtualVoidMethod("onItemEvicted.(Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(item);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		private static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				LruCache.cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(LruCache.n_Put_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return LruCache.cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000BE08 File Offset: 0x0000A008
		private static IntPtr n_Put_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_item)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BE3C File Offset: 0x0000A03C
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Put(Java.Lang.Object key, Java.Lang.Object item)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(item);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LruCache._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(item);
			}
			return @object;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000BED8 File Offset: 0x0000A0D8
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (LruCache.cb_remove_Ljava_lang_Object_ == null)
			{
				LruCache.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LruCache.n_Remove_Ljava_lang_Object_));
			}
			return LruCache.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		private static IntPtr n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			LruCache @object = Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000BF24 File Offset: 0x0000A124
		[Register("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetRemove_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Remove(Java.Lang.Object key)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LruCache._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BF98 File Offset: 0x0000A198
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (LruCache.cb_setSizeMultiplier_F == null)
			{
				LruCache.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(LruCache.n_SetSizeMultiplier_F));
			}
			return LruCache.cb_setSizeMultiplier_F;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float multiplier)
		{
			Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(multiplier);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000BFCC File Offset: 0x0000A1CC
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler")]
		public unsafe virtual void SetSizeMultiplier(float multiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(multiplier);
			LruCache._members.InstanceMethods.InvokeVirtualVoidMethod("setSizeMultiplier.(F)V", this, ptr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000C007 File Offset: 0x0000A207
		private static Delegate GetTrimToSize_JHandler()
		{
			if (LruCache.cb_trimToSize_J == null)
			{
				LruCache.cb_trimToSize_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(LruCache.n_TrimToSize_J));
			}
			return LruCache.cb_trimToSize_J;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000C02B File Offset: 0x0000A22B
		private static void n_TrimToSize_J(IntPtr jnienv, IntPtr native__this, long size)
		{
			Java.Lang.Object.GetObject<LruCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimToSize(size);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000C03C File Offset: 0x0000A23C
		[Register("trimToSize", "(J)V", "GetTrimToSize_JHandler")]
		protected unsafe virtual void TrimToSize(long size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			LruCache._members.InstanceMethods.InvokeVirtualVoidMethod("trimToSize.(J)V", this, ptr);
		}

		// Token: 0x040000BB RID: 187
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/LruCache", typeof(LruCache));

		// Token: 0x040000BC RID: 188
		private static Delegate cb_getCount;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_getCurrentSize;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_getMaxSize;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_clearMemory;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x040000C2 RID: 194
		private static Delegate cb_getSize_Ljava_lang_Object_;

		// Token: 0x040000C3 RID: 195
		private static Delegate cb_onItemEvicted_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x040000C7 RID: 199
		private static Delegate cb_trimToSize_J;
	}
}
