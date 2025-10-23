using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000192 RID: 402
	[Register("com/bumptech/glide/load/data/DataFetcher$DataCallback", DoNotGenerateAcw = true)]
	internal class IDataFetcherDataCallbackInvoker : Java.Lang.Object, IDataFetcherDataCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00040F04 File Offset: 0x0003F104
		private static IntPtr java_class_ref
		{
			get
			{
				return IDataFetcherDataCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00040F28 File Offset: 0x0003F128
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDataFetcherDataCallbackInvoker._members;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00040F2F File Offset: 0x0003F12F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00040F37 File Offset: 0x0003F137
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDataFetcherDataCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00040F43 File Offset: 0x0003F143
		public static IDataFetcherDataCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDataFetcherDataCallback>(handle, transfer);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00040F4C File Offset: 0x0003F14C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDataFetcherDataCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.data.DataFetcher.DataCallback'.");
			}
			return handle;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00040F77 File Offset: 0x0003F177
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00040FA8 File Offset: 0x0003F1A8
		public IDataFetcherDataCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDataFetcherDataCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00040FE0 File Offset: 0x0003F1E0
		private static Delegate GetOnDataReady_Ljava_lang_Object_Handler()
		{
			if (IDataFetcherDataCallbackInvoker.cb_onDataReady_Ljava_lang_Object_ == null)
			{
				IDataFetcherDataCallbackInvoker.cb_onDataReady_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDataFetcherDataCallbackInvoker.n_OnDataReady_Ljava_lang_Object_));
			}
			return IDataFetcherDataCallbackInvoker.cb_onDataReady_Ljava_lang_Object_;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00041004 File Offset: 0x0003F204
		private static void n_OnDataReady_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDataFetcherDataCallback @object = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnDataReady(object2);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00041028 File Offset: 0x0003F228
		public unsafe void OnDataReady(Java.Lang.Object p0)
		{
			if (this.id_onDataReady_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onDataReady_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onDataReady", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDataReady_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00041099 File Offset: 0x0003F299
		private static Delegate GetOnLoadFailed_Ljava_lang_Exception_Handler()
		{
			if (IDataFetcherDataCallbackInvoker.cb_onLoadFailed_Ljava_lang_Exception_ == null)
			{
				IDataFetcherDataCallbackInvoker.cb_onLoadFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDataFetcherDataCallbackInvoker.n_OnLoadFailed_Ljava_lang_Exception_));
			}
			return IDataFetcherDataCallbackInvoker.cb_onLoadFailed_Ljava_lang_Exception_;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000410C0 File Offset: 0x0003F2C0
		private static void n_OnLoadFailed_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDataFetcherDataCallback @object = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000410E4 File Offset: 0x0003F2E4
		public unsafe void OnLoadFailed(Java.Lang.Exception p0)
		{
			if (this.id_onLoadFailed_Ljava_lang_Exception_ == IntPtr.Zero)
			{
				this.id_onLoadFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID(this.class_ref, "onLoadFailed", "(Ljava/lang/Exception;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadFailed_Ljava_lang_Exception_, ptr);
		}

		// Token: 0x040004CB RID: 1227
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/DataFetcher$DataCallback", typeof(IDataFetcherDataCallbackInvoker));

		// Token: 0x040004CC RID: 1228
		private IntPtr class_ref;

		// Token: 0x040004CD RID: 1229
		private static Delegate cb_onDataReady_Ljava_lang_Object_;

		// Token: 0x040004CE RID: 1230
		private IntPtr id_onDataReady_Ljava_lang_Object_;

		// Token: 0x040004CF RID: 1231
		private static Delegate cb_onLoadFailed_Ljava_lang_Exception_;

		// Token: 0x040004D0 RID: 1232
		private IntPtr id_onLoadFailed_Ljava_lang_Exception_;
	}
}
