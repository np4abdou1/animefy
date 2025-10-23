using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000091 RID: 145
	[Register("com/bumptech/glide/request/RequestListener", DoNotGenerateAcw = true)]
	internal class IRequestListenerInvoker : Java.Lang.Object, IRequestListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001731C File Offset: 0x0001551C
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequestListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00017340 File Offset: 0x00015540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRequestListenerInvoker._members;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00017347 File Offset: 0x00015547
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0001734F File Offset: 0x0001554F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRequestListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001735B File Offset: 0x0001555B
		public static IRequestListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequestListener>(handle, transfer);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00017364 File Offset: 0x00015564
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequestListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.RequestListener'.");
			}
			return handle;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001738F File Offset: 0x0001558F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000173C0 File Offset: 0x000155C0
		public IRequestListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequestListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000173F8 File Offset: 0x000155F8
		private static Delegate GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler()
		{
			if (IRequestListenerInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z == null)
			{
				IRequestListenerInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZ_Z(IRequestListenerInvoker.n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z));
			}
			return IRequestListenerInvoker.cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001741C File Offset: 0x0001561C
		private static bool n_OnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			IRequestListener @object = Java.Lang.Object.GetObject<IRequestListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideException object2 = Java.Lang.Object.GetObject<GlideException>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			ITarget object4 = Java.Lang.Object.GetObject<ITarget>(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.OnLoadFailed(object2, object3, object4, p3);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00017454 File Offset: 0x00015654
		public unsafe bool OnLoadFailed(GlideException p0, Java.Lang.Object p1, ITarget p2, bool p3)
		{
			if (this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z == IntPtr.Zero)
			{
				this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z = JNIEnv.GetMethodID(this.class_ref, "onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			ptr[3] = new JValue(p3);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z, ptr);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001752A File Offset: 0x0001572A
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (IRequestListenerInvoker.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				IRequestListenerInvoker.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLZ_Z(IRequestListenerInvoker.n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return IRequestListenerInvoker.cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00017550 File Offset: 0x00015750
		private static bool n_OnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			IRequestListener @object = Java.Lang.Object.GetObject<IRequestListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			ITarget object4 = Java.Lang.Object.GetObject<ITarget>(native_p2, JniHandleOwnership.DoNotTransfer);
			DataSource object5 = Java.Lang.Object.GetObject<DataSource>(native_p3, JniHandleOwnership.DoNotTransfer);
			return @object.OnResourceReady(object2, object3, object4, object5, p4);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00017594 File Offset: 0x00015794
		public unsafe bool OnResourceReady(Java.Lang.Object p0, Java.Lang.Object p1, ITarget p2, DataSource p3, bool p4)
		{
			if (this.id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z == IntPtr.Zero)
			{
				this.id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z = JNIEnv.GetMethodID(this.class_ref, "onResourceReady", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/load/DataSource;Z)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : p3.Handle);
			ptr[4] = new JValue(p4);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x040001C6 RID: 454
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/RequestListener", typeof(IRequestListenerInvoker));

		// Token: 0x040001C7 RID: 455
		private IntPtr class_ref;

		// Token: 0x040001C8 RID: 456
		private static Delegate cb_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;

		// Token: 0x040001C9 RID: 457
		private IntPtr id_onLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Z;

		// Token: 0x040001CA RID: 458
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x040001CB RID: 459
		private IntPtr id_onResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_Z;
	}
}
