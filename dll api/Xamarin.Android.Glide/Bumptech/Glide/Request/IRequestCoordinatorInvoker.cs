using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008F RID: 143
	[Register("com/bumptech/glide/request/RequestCoordinator", DoNotGenerateAcw = true)]
	internal class IRequestCoordinatorInvoker : Java.Lang.Object, IRequestCoordinator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00016D64 File Offset: 0x00014F64
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequestCoordinatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00016D88 File Offset: 0x00014F88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRequestCoordinatorInvoker._members;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00016D8F File Offset: 0x00014F8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00016D97 File Offset: 0x00014F97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRequestCoordinatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00016DA3 File Offset: 0x00014FA3
		public static IRequestCoordinator GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequestCoordinator>(handle, transfer);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00016DAC File Offset: 0x00014FAC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequestCoordinatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.RequestCoordinator'.");
			}
			return handle;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00016DD7 File Offset: 0x00014FD7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00016E08 File Offset: 0x00015008
		public IRequestCoordinatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequestCoordinatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00016E40 File Offset: 0x00015040
		private static Delegate GetIsAnyResourceSetHandler()
		{
			if (IRequestCoordinatorInvoker.cb_isAnyResourceSet == null)
			{
				IRequestCoordinatorInvoker.cb_isAnyResourceSet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IRequestCoordinatorInvoker.n_IsAnyResourceSet));
			}
			return IRequestCoordinatorInvoker.cb_isAnyResourceSet;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00016E64 File Offset: 0x00015064
		private static bool n_IsAnyResourceSet(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAnyResourceSet;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00016E73 File Offset: 0x00015073
		public bool IsAnyResourceSet
		{
			get
			{
				if (this.id_isAnyResourceSet == IntPtr.Zero)
				{
					this.id_isAnyResourceSet = JNIEnv.GetMethodID(this.class_ref, "isAnyResourceSet", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAnyResourceSet);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00016EB3 File Offset: 0x000150B3
		private static Delegate GetGetRootHandler()
		{
			if (IRequestCoordinatorInvoker.cb_getRoot == null)
			{
				IRequestCoordinatorInvoker.cb_getRoot = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequestCoordinatorInvoker.n_GetRoot));
			}
			return IRequestCoordinatorInvoker.cb_getRoot;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00016ED7 File Offset: 0x000150D7
		private static IntPtr n_GetRoot(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Root);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00016EEC File Offset: 0x000150EC
		public IRequestCoordinator Root
		{
			get
			{
				if (this.id_getRoot == IntPtr.Zero)
				{
					this.id_getRoot = JNIEnv.GetMethodID(this.class_ref, "getRoot", "()Lcom/bumptech/glide/request/RequestCoordinator;");
				}
				return Java.Lang.Object.GetObject<IRequestCoordinator>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRoot), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00016F3D File Offset: 0x0001513D
		private static Delegate GetCanNotifyCleared_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestCoordinatorInvoker.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestCoordinatorInvoker.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequestCoordinatorInvoker.n_CanNotifyCleared_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestCoordinatorInvoker.cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00016F64 File Offset: 0x00015164
		private static bool n_CanNotifyCleared_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequestCoordinator @object = Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.CanNotifyCleared(object2);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00016F88 File Offset: 0x00015188
		public unsafe bool CanNotifyCleared(IRequest p0)
		{
			if (this.id_canNotifyCleared_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_canNotifyCleared_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "canNotifyCleared", "(Lcom/bumptech/glide/request/Request;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canNotifyCleared_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00017000 File Offset: 0x00015200
		private static Delegate GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestCoordinatorInvoker.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestCoordinatorInvoker.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequestCoordinatorInvoker.n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestCoordinatorInvoker.cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00017024 File Offset: 0x00015224
		private static bool n_CanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequestCoordinator @object = Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.CanNotifyStatusChanged(object2);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00017048 File Offset: 0x00015248
		public unsafe bool CanNotifyStatusChanged(IRequest p0)
		{
			if (this.id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000170C0 File Offset: 0x000152C0
		private static Delegate GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestCoordinatorInvoker.cb_canSetImage_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestCoordinatorInvoker.cb_canSetImage_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequestCoordinatorInvoker.n_CanSetImage_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestCoordinatorInvoker.cb_canSetImage_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000170E4 File Offset: 0x000152E4
		private static bool n_CanSetImage_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequestCoordinator @object = Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.CanSetImage(object2);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00017108 File Offset: 0x00015308
		public unsafe bool CanSetImage(IRequest p0)
		{
			if (this.id_canSetImage_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_canSetImage_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "canSetImage", "(Lcom/bumptech/glide/request/Request;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canSetImage_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00017180 File Offset: 0x00015380
		private static Delegate GetOnRequestFailed_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestCoordinatorInvoker.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestCoordinatorInvoker.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IRequestCoordinatorInvoker.n_OnRequestFailed_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestCoordinatorInvoker.cb_onRequestFailed_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000171A4 File Offset: 0x000153A4
		private static void n_OnRequestFailed_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequestCoordinator @object = Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestFailed(object2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000171C8 File Offset: 0x000153C8
		public unsafe void OnRequestFailed(IRequest p0)
		{
			if (this.id_onRequestFailed_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_onRequestFailed_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "onRequestFailed", "(Lcom/bumptech/glide/request/Request;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestFailed_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00017240 File Offset: 0x00015440
		private static Delegate GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestCoordinatorInvoker.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestCoordinatorInvoker.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IRequestCoordinatorInvoker.n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestCoordinatorInvoker.cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00017264 File Offset: 0x00015464
		private static void n_OnRequestSuccess_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequestCoordinator @object = Java.Lang.Object.GetObject<IRequestCoordinator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestSuccess(object2);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00017288 File Offset: 0x00015488
		public unsafe void OnRequestSuccess(IRequest p0)
		{
			if (this.id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_onRequestSuccess_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestSuccess_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x040001B6 RID: 438
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/RequestCoordinator", typeof(IRequestCoordinatorInvoker));

		// Token: 0x040001B7 RID: 439
		private IntPtr class_ref;

		// Token: 0x040001B8 RID: 440
		private static Delegate cb_isAnyResourceSet;

		// Token: 0x040001B9 RID: 441
		private IntPtr id_isAnyResourceSet;

		// Token: 0x040001BA RID: 442
		private static Delegate cb_getRoot;

		// Token: 0x040001BB RID: 443
		private IntPtr id_getRoot;

		// Token: 0x040001BC RID: 444
		private static Delegate cb_canNotifyCleared_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001BD RID: 445
		private IntPtr id_canNotifyCleared_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001BE RID: 446
		private static Delegate cb_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001BF RID: 447
		private IntPtr id_canNotifyStatusChanged_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C0 RID: 448
		private static Delegate cb_canSetImage_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C1 RID: 449
		private IntPtr id_canSetImage_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C2 RID: 450
		private static Delegate cb_onRequestFailed_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C3 RID: 451
		private IntPtr id_onRequestFailed_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C4 RID: 452
		private static Delegate cb_onRequestSuccess_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001C5 RID: 453
		private IntPtr id_onRequestSuccess_Lcom_bumptech_glide_request_Request_;
	}
}
