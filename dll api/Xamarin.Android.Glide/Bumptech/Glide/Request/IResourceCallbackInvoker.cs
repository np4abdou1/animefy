using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000096 RID: 150
	[Register("com/bumptech/glide/request/ResourceCallback", DoNotGenerateAcw = true)]
	internal class IResourceCallbackInvoker : Java.Lang.Object, IResourceCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00017838 File Offset: 0x00015A38
		private static IntPtr java_class_ref
		{
			get
			{
				return IResourceCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0001785C File Offset: 0x00015A5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResourceCallbackInvoker._members;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00017863 File Offset: 0x00015A63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001786B File Offset: 0x00015A6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResourceCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00017877 File Offset: 0x00015A77
		public static IResourceCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResourceCallback>(handle, transfer);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00017880 File Offset: 0x00015A80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResourceCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.ResourceCallback'.");
			}
			return handle;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000178AB File Offset: 0x00015AAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000178DC File Offset: 0x00015ADC
		public IResourceCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResourceCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00017914 File Offset: 0x00015B14
		private static Delegate GetGetLockHandler()
		{
			if (IResourceCallbackInvoker.cb_getLock == null)
			{
				IResourceCallbackInvoker.cb_getLock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IResourceCallbackInvoker.n_GetLock));
			}
			return IResourceCallbackInvoker.cb_getLock;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00017938 File Offset: 0x00015B38
		private static IntPtr n_GetLock(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IResourceCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lock);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001794C File Offset: 0x00015B4C
		public Java.Lang.Object Lock
		{
			get
			{
				if (this.id_getLock == IntPtr.Zero)
				{
					this.id_getLock = JNIEnv.GetMethodID(this.class_ref, "getLock", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLock), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001799D File Offset: 0x00015B9D
		private static Delegate GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Handler()
		{
			if (IResourceCallbackInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_ == null)
			{
				IResourceCallbackInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IResourceCallbackInvoker.n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_));
			}
			return IResourceCallbackInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000179C4 File Offset: 0x00015BC4
		private static void n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IResourceCallback @object = Java.Lang.Object.GetObject<IResourceCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideException object2 = Java.Lang.Object.GetObject<GlideException>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000179E8 File Offset: 0x00015BE8
		public unsafe void OnLoadFailed(GlideException p0)
		{
			if (this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_ == IntPtr.Zero)
			{
				this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_ = JNIEnv.GetMethodID(this.class_ref, "onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_, ptr);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00017A5B File Offset: 0x00015C5B
		private static Delegate GetOnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (IResourceCallbackInvoker.cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				IResourceCallbackInvoker.cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_V(IResourceCallbackInvoker.n_OnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return IResourceCallbackInvoker.cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00017A80 File Offset: 0x00015C80
		private static void n_OnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			IResourceCallback @object = Java.Lang.Object.GetObject<IResourceCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_p0, JniHandleOwnership.DoNotTransfer);
			DataSource object3 = Java.Lang.Object.GetObject<DataSource>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3, p2);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00017AB0 File Offset: 0x00015CB0
		public unsafe void OnResourceReady(IResource p0, DataSource p1, bool p2)
		{
			if (this.id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z == IntPtr.Zero)
			{
				this.id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z = JNIEnv.GetMethodID(this.class_ref, "onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/DataSource;Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z, ptr);
		}

		// Token: 0x040001DA RID: 474
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/ResourceCallback", typeof(IResourceCallbackInvoker));

		// Token: 0x040001DB RID: 475
		private IntPtr class_ref;

		// Token: 0x040001DC RID: 476
		private static Delegate cb_getLock;

		// Token: 0x040001DD RID: 477
		private IntPtr id_getLock;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_;

		// Token: 0x040001DF RID: 479
		private IntPtr id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_;

		// Token: 0x040001E0 RID: 480
		private static Delegate cb_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x040001E1 RID: 481
		private IntPtr id_onResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_Z;
	}
}
