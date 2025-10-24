using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000167 RID: 359
	[Register("com/bumptech/glide/load/engine/cache/DiskCache", DoNotGenerateAcw = true)]
	internal class IDiskCacheInvoker : Java.Lang.Object, IDiskCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00039AE0 File Offset: 0x00037CE0
		private static IntPtr java_class_ref
		{
			get
			{
				return IDiskCacheInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00039B04 File Offset: 0x00037D04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDiskCacheInvoker._members;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00039B0B File Offset: 0x00037D0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00039B13 File Offset: 0x00037D13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDiskCacheInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00039B1F File Offset: 0x00037D1F
		public static IDiskCache GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDiskCache>(handle, transfer);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00039B28 File Offset: 0x00037D28
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDiskCacheInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.DiskCache'.");
			}
			return handle;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00039B53 File Offset: 0x00037D53
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00039B84 File Offset: 0x00037D84
		public IDiskCacheInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDiskCacheInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00039BBC File Offset: 0x00037DBC
		private static Delegate GetClearHandler()
		{
			if (IDiskCacheInvoker.cb_clear == null)
			{
				IDiskCacheInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDiskCacheInvoker.n_Clear));
			}
			return IDiskCacheInvoker.cb_clear;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00039BE0 File Offset: 0x00037DE0
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDiskCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00039BEF File Offset: 0x00037DEF
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00039C2F File Offset: 0x00037E2F
		private static Delegate GetDelete_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (IDiskCacheInvoker.cb_delete_Lcom_bumptech_glide_load_Key_ == null)
			{
				IDiskCacheInvoker.cb_delete_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDiskCacheInvoker.n_Delete_Lcom_bumptech_glide_load_Key_));
			}
			return IDiskCacheInvoker.cb_delete_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00039C54 File Offset: 0x00037E54
		private static void n_Delete_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDiskCache @object = Java.Lang.Object.GetObject<IDiskCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Delete(object2);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00039C78 File Offset: 0x00037E78
		public unsafe void Delete(IKey p0)
		{
			if (this.id_delete_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
			{
				this.id_delete_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID(this.class_ref, "delete", "(Lcom/bumptech/glide/load/Key;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_delete_Lcom_bumptech_glide_load_Key_, ptr);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00039CF0 File Offset: 0x00037EF0
		private static Delegate GetGet_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (IDiskCacheInvoker.cb_get_Lcom_bumptech_glide_load_Key_ == null)
			{
				IDiskCacheInvoker.cb_get_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDiskCacheInvoker.n_Get_Lcom_bumptech_glide_load_Key_));
			}
			return IDiskCacheInvoker.cb_get_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00039D14 File Offset: 0x00037F14
		private static IntPtr n_Get_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDiskCache @object = Java.Lang.Object.GetObject<IDiskCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00039D3C File Offset: 0x00037F3C
		public unsafe File Get(IKey p0)
		{
			if (this.id_get_Lcom_bumptech_glide_load_Key_ == IntPtr.Zero)
			{
				this.id_get_Lcom_bumptech_glide_load_Key_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return Java.Lang.Object.GetObject<File>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Lcom_bumptech_glide_load_Key_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00039DBA File Offset: 0x00037FBA
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler()
		{
			if (IDiskCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == null)
			{
				IDiskCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDiskCacheInvoker.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_));
			}
			return IDiskCacheInvoker.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00039DE0 File Offset: 0x00037FE0
		private static void n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDiskCache @object = Java.Lang.Object.GetObject<IDiskCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDiskCacheWriter object3 = Java.Lang.Object.GetObject<IDiskCacheWriter>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00039E0C File Offset: 0x0003800C
		public unsafe void Put(IKey p0, IDiskCacheWriter p1)
		{
			if (this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == IntPtr.Zero)
			{
				this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_, ptr);
		}

		// Token: 0x0400041A RID: 1050
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskCache", typeof(IDiskCacheInvoker));

		// Token: 0x0400041B RID: 1051
		private IntPtr class_ref;

		// Token: 0x0400041C RID: 1052
		private static Delegate cb_clear;

		// Token: 0x0400041D RID: 1053
		private IntPtr id_clear;

		// Token: 0x0400041E RID: 1054
		private static Delegate cb_delete_Lcom_bumptech_glide_load_Key_;

		// Token: 0x0400041F RID: 1055
		private IntPtr id_delete_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000420 RID: 1056
		private static Delegate cb_get_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000421 RID: 1057
		private IntPtr id_get_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000422 RID: 1058
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;

		// Token: 0x04000423 RID: 1059
		private IntPtr id_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
	}
}
