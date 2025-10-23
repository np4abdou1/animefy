using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x02000061 RID: 97
	[Register("com/bumptech/glide/provider/LoadPathCache", DoNotGenerateAcw = true)]
	public class LoadPathCache : Java.Lang.Object
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		internal static IntPtr class_ref
		{
			get
			{
				return LoadPathCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadPathCache._members;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadPathCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000E910 File Offset: 0x0000CB10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadPathCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000E91C File Offset: 0x0000CB1C
		protected LoadPathCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Register(".ctor", "()V", "")]
		public LoadPathCache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LoadPathCache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LoadPathCache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000E996 File Offset: 0x0000CB96
		private static Delegate GetGet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (LoadPathCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				LoadPathCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(LoadPathCache.n_Get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return LoadPathCache.cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		private static IntPtr n_Get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_transcodeClass)
		{
			LoadPathCache @object = Java.Lang.Object.GetObject<LoadPathCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3, object4));
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		[Register("get", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/engine/LoadPath;", "GetGet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource",
			"Transcode"
		})]
		public unsafe virtual LoadPath Get(Class dataClass, Class resourceClass, Class transcodeClass)
		{
			LoadPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				@object = Java.Lang.Object.GetObject<LoadPath>(LoadPathCache._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/engine/LoadPath;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
			}
			return @object;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		private static Delegate GetIsEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_Handler()
		{
			if (LoadPathCache.cb_isEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_ == null)
			{
				LoadPathCache.cb_isEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(LoadPathCache.n_IsEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_));
			}
			return LoadPathCache.cb_isEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		private static bool n_IsEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_(IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			LoadPathCache @object = Java.Lang.Object.GetObject<LoadPathCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LoadPath object2 = Java.Lang.Object.GetObject<LoadPath>(native_path, JniHandleOwnership.DoNotTransfer);
			return @object.IsEmptyLoadPath(object2);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Register("isEmptyLoadPath", "(Lcom/bumptech/glide/load/engine/LoadPath;)Z", "GetIsEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_Handler")]
		public unsafe virtual bool IsEmptyLoadPath(LoadPath path)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((path == null) ? IntPtr.Zero : path.Handle);
				result = LoadPathCache._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmptyLoadPath.(Lcom/bumptech/glide/load/engine/LoadPath;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(path);
			}
			return result;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000EB70 File Offset: 0x0000CD70
		private static Delegate GetPut_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_Handler()
		{
			if (LoadPathCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_ == null)
			{
				LoadPathCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(LoadPathCache.n_Put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_));
			}
			return LoadPathCache.cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000EB94 File Offset: 0x0000CD94
		private static void n_Put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_transcodeClass, IntPtr native_loadPath)
		{
			LoadPathCache @object = Java.Lang.Object.GetObject<LoadPathCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			LoadPath object5 = Java.Lang.Object.GetObject<LoadPath>(native_loadPath, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3, object4, object5);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		[Register("put", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/engine/LoadPath;)V", "GetPut_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_Handler")]
		public unsafe virtual void Put(Class dataClass, Class resourceClass, Class transcodeClass, LoadPath loadPath)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[3] = new JniArgumentValue((loadPath == null) ? IntPtr.Zero : loadPath.Handle);
				LoadPathCache._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/engine/LoadPath;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(loadPath);
			}
		}

		// Token: 0x040000E2 RID: 226
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/LoadPathCache", typeof(LoadPathCache));

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_get_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_isEmptyLoadPath_Lcom_bumptech_glide_load_engine_LoadPath_;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_put_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_engine_LoadPath_;
	}
}
