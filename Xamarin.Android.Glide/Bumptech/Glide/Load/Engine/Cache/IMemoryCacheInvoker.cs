using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016D RID: 365
	[Register("com/bumptech/glide/load/engine/cache/MemoryCache", DoNotGenerateAcw = true)]
	internal class IMemoryCacheInvoker : Java.Lang.Object, IMemoryCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0003A104 File Offset: 0x00038304
		private static IntPtr java_class_ref
		{
			get
			{
				return IMemoryCacheInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x0003A128 File Offset: 0x00038328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMemoryCacheInvoker._members;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0003A12F File Offset: 0x0003832F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x0003A137 File Offset: 0x00038337
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMemoryCacheInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0003A143 File Offset: 0x00038343
		public static IMemoryCache GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMemoryCache>(handle, transfer);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0003A14C File Offset: 0x0003834C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMemoryCacheInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.MemoryCache'.");
			}
			return handle;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0003A177 File Offset: 0x00038377
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0003A1A8 File Offset: 0x000383A8
		public IMemoryCacheInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMemoryCacheInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0003A1E0 File Offset: 0x000383E0
		private static Delegate GetGetCurrentSizeHandler()
		{
			if (IMemoryCacheInvoker.cb_getCurrentSize == null)
			{
				IMemoryCacheInvoker.cb_getCurrentSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IMemoryCacheInvoker.n_GetCurrentSize));
			}
			return IMemoryCacheInvoker.cb_getCurrentSize;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0003A204 File Offset: 0x00038404
		private static long n_GetCurrentSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSize;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0003A213 File Offset: 0x00038413
		public long CurrentSize
		{
			get
			{
				if (this.id_getCurrentSize == IntPtr.Zero)
				{
					this.id_getCurrentSize = JNIEnv.GetMethodID(this.class_ref, "getCurrentSize", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getCurrentSize);
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0003A253 File Offset: 0x00038453
		private static Delegate GetGetMaxSizeHandler()
		{
			if (IMemoryCacheInvoker.cb_getMaxSize == null)
			{
				IMemoryCacheInvoker.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IMemoryCacheInvoker.n_GetMaxSize));
			}
			return IMemoryCacheInvoker.cb_getMaxSize;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0003A277 File Offset: 0x00038477
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0003A286 File Offset: 0x00038486
		public long MaxSize
		{
			get
			{
				if (this.id_getMaxSize == IntPtr.Zero)
				{
					this.id_getMaxSize = JNIEnv.GetMethodID(this.class_ref, "getMaxSize", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getMaxSize);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0003A2C6 File Offset: 0x000384C6
		private static Delegate GetClearMemoryHandler()
		{
			if (IMemoryCacheInvoker.cb_clearMemory == null)
			{
				IMemoryCacheInvoker.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMemoryCacheInvoker.n_ClearMemory));
			}
			return IMemoryCacheInvoker.cb_clearMemory;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0003A2EA File Offset: 0x000384EA
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0003A2F9 File Offset: 0x000384F9
		public void ClearMemory()
		{
			if (this.id_clearMemory == IntPtr.Zero)
			{
				this.id_clearMemory = JNIEnv.GetMethodID(this.class_ref, "clearMemory", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearMemory);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0003A339 File Offset: 0x00038539
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (IMemoryCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				IMemoryCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMemoryCacheInvoker.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return IMemoryCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0003A360 File Offset: 0x00038560
		private static IntPtr n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMemoryCache @object = Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0003A394 File Offset: 0x00038594
		public unsafe IResource Put(IKey p0, IResource p1)
		{
			if (this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == IntPtr.Zero)
			{
				this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<IResource>(JNIEnv.CallObjectMethod(base.Handle, this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0003A439 File Offset: 0x00038639
		private static Delegate GetRemove_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (IMemoryCacheInvoker.cb_remove_Lcom_bumptech_glide_load_Key_ == null)
			{
				IMemoryCacheInvoker.cb_remove_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMemoryCacheInvoker.n_Remove_Lcom_bumptech_glide_load_Key_));
			}
			return IMemoryCacheInvoker.cb_remove_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0003A460 File Offset: 0x00038660
		private static IntPtr n_Remove_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMemoryCache @object = Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0003A488 File Offset: 0x00038688
		public unsafe IResource Remove(IKey p0)
		{
			if (this.id_remove_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
			{
				this.id_remove_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<IResource>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove_Lcom_bumptech_glide_load_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0003A506 File Offset: 0x00038706
		private static Delegate GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler()
		{
			if (IMemoryCacheInvoker.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == null)
			{
				IMemoryCacheInvoker.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMemoryCacheInvoker.n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_));
			}
			return IMemoryCacheInvoker.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0003A52C File Offset: 0x0003872C
		private static void n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMemoryCache @object = Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMemoryCacheResourceRemovedListener object2 = Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetResourceRemovedListener(object2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0003A550 File Offset: 0x00038750
		public unsafe void SetResourceRemovedListener(IMemoryCacheResourceRemovedListener p0)
		{
			if (this.id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == IntPtr.Zero)
			{
				this.id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNIEnv.GetMethodID(this.class_ref, "setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_, ptr);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0003A5C8 File Offset: 0x000387C8
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (IMemoryCacheInvoker.cb_setSizeMultiplier_F == null)
			{
				IMemoryCacheInvoker.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(IMemoryCacheInvoker.n_SetSizeMultiplier_F));
			}
			return IMemoryCacheInvoker.cb_setSizeMultiplier_F;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0003A5EC File Offset: 0x000387EC
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float p0)
		{
			Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(p0);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0003A5FC File Offset: 0x000387FC
		public unsafe void SetSizeMultiplier(float p0)
		{
			if (this.id_setSizeMultiplier_F == IntPtr.Zero)
			{
				this.id_setSizeMultiplier_F = JNIEnv.GetMethodID(this.class_ref, "setSizeMultiplier", "(F)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setSizeMultiplier_F, ptr);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0003A660 File Offset: 0x00038860
		private static Delegate GetTrimMemory_IHandler()
		{
			if (IMemoryCacheInvoker.cb_trimMemory_I == null)
			{
				IMemoryCacheInvoker.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IMemoryCacheInvoker.n_TrimMemory_I));
			}
			return IMemoryCacheInvoker.cb_trimMemory_I;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0003A684 File Offset: 0x00038884
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IMemoryCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(p0);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0003A694 File Offset: 0x00038894
		public unsafe void TrimMemory(int p0)
		{
			if (this.id_trimMemory_I == IntPtr.Zero)
			{
				this.id_trimMemory_I = JNIEnv.GetMethodID(this.class_ref, "trimMemory", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trimMemory_I, ptr);
		}

		// Token: 0x0400042B RID: 1067
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/MemoryCache", typeof(IMemoryCacheInvoker));

		// Token: 0x0400042C RID: 1068
		private IntPtr class_ref;

		// Token: 0x0400042D RID: 1069
		private static Delegate cb_getCurrentSize;

		// Token: 0x0400042E RID: 1070
		private IntPtr id_getCurrentSize;

		// Token: 0x0400042F RID: 1071
		private static Delegate cb_getMaxSize;

		// Token: 0x04000430 RID: 1072
		private IntPtr id_getMaxSize;

		// Token: 0x04000431 RID: 1073
		private static Delegate cb_clearMemory;

		// Token: 0x04000432 RID: 1074
		private IntPtr id_clearMemory;

		// Token: 0x04000433 RID: 1075
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000434 RID: 1076
		private IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000435 RID: 1077
		private static Delegate cb_remove_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000436 RID: 1078
		private IntPtr id_remove_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000437 RID: 1079
		private static Delegate cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;

		// Token: 0x04000438 RID: 1080
		private IntPtr id_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;

		// Token: 0x04000439 RID: 1081
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x0400043A RID: 1082
		private IntPtr id_setSizeMultiplier_F;

		// Token: 0x0400043B RID: 1083
		private static Delegate cb_trimMemory_I;

		// Token: 0x0400043C RID: 1084
		private IntPtr id_trimMemory_I;
	}
}
