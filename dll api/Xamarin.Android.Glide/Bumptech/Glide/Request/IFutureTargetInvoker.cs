using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request.Target;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008A RID: 138
	[Register("com/bumptech/glide/request/FutureTarget", DoNotGenerateAcw = true)]
	internal class IFutureTargetInvoker : Java.Lang.Object, IFutureTarget, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable, IFuture
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00015B44 File Offset: 0x00013D44
		private static IntPtr java_class_ref
		{
			get
			{
				return IFutureTargetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00015B68 File Offset: 0x00013D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFutureTargetInvoker._members;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00015B6F File Offset: 0x00013D6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00015B77 File Offset: 0x00013D77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFutureTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00015B83 File Offset: 0x00013D83
		public static IFutureTarget GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFutureTarget>(handle, transfer);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00015B8C File Offset: 0x00013D8C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFutureTargetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.FutureTarget'.");
			}
			return handle;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00015BB7 File Offset: 0x00013DB7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00015BE8 File Offset: 0x00013DE8
		public IFutureTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFutureTargetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00015C20 File Offset: 0x00013E20
		private static Delegate GetGetRequestHandler()
		{
			if (IFutureTargetInvoker.cb_getRequest == null)
			{
				IFutureTargetInvoker.cb_getRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFutureTargetInvoker.n_GetRequest));
			}
			return IFutureTargetInvoker.cb_getRequest;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00015C44 File Offset: 0x00013E44
		private static IntPtr n_GetRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Request);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00015C58 File Offset: 0x00013E58
		private static Delegate GetSetRequest_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IFutureTargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_ == null)
			{
				IFutureTargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_SetRequest_Lcom_bumptech_glide_request_Request_));
			}
			return IFutureTargetInvoker.cb_setRequest_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00015C7C File Offset: 0x00013E7C
		private static void n_SetRequest_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Request = object2;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00015CA0 File Offset: 0x00013EA0
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00015CF4 File Offset: 0x00013EF4
		public unsafe IRequest Request
		{
			get
			{
				if (this.id_getRequest == IntPtr.Zero)
				{
					this.id_getRequest = JNIEnv.GetMethodID(this.class_ref, "getRequest", "()Lcom/bumptech/glide/request/Request;");
				}
				return Java.Lang.Object.GetObject<IRequest>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRequest), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setRequest_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
				{
					this.id_setRequest_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "setRequest", "(Lcom/bumptech/glide/request/Request;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setRequest_Lcom_bumptech_glide_request_Request_, ptr);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00015D6C File Offset: 0x00013F6C
		private static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (IFutureTargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				IFutureTargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return IFutureTargetInvoker.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00015D90 File Offset: 0x00013F90
		private static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.GetSize(object2);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00015DB4 File Offset: 0x00013FB4
		public unsafe void GetSize(ISizeReadyCallback p0)
		{
			if (this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
			{
				this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID(this.class_ref, "getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_, ptr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00015E2C File Offset: 0x0001402C
		private static Delegate GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IFutureTargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ == null)
			{
				IFutureTargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_OnLoadCleared_Landroid_graphics_drawable_Drawable_));
			}
			return IFutureTargetInvoker.cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00015E50 File Offset: 0x00014050
		private static void n_OnLoadCleared_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadCleared(object2);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00015E74 File Offset: 0x00014074
		public unsafe void OnLoadCleared(Drawable p0)
		{
			if (this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadCleared_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00015EE7 File Offset: 0x000140E7
		private static Delegate GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IFutureTargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ == null)
			{
				IFutureTargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_OnLoadFailed_Landroid_graphics_drawable_Drawable_));
			}
			return IFutureTargetInvoker.cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00015F0C File Offset: 0x0001410C
		private static void n_OnLoadFailed_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadFailed(object2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00015F30 File Offset: 0x00014130
		public unsafe void OnLoadFailed(Drawable p0)
		{
			if (this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadFailed_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00015FA3 File Offset: 0x000141A3
		private static Delegate GetOnLoadStarted_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IFutureTargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ == null)
			{
				IFutureTargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_OnLoadStarted_Landroid_graphics_drawable_Drawable_));
			}
			return IFutureTargetInvoker.cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00015FC8 File Offset: 0x000141C8
		private static void n_OnLoadStarted_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLoadStarted(object2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00015FEC File Offset: 0x000141EC
		public unsafe void OnLoadStarted(Drawable p0)
		{
			if (this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "onLoadStarted", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadStarted_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001605F File Offset: 0x0001425F
		private static Delegate GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler()
		{
			if (IFutureTargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == null)
			{
				IFutureTargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IFutureTargetInvoker.n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_));
			}
			return IFutureTargetInvoker.cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00016084 File Offset: 0x00014284
		private static void n_OnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			ITransition object3 = Java.Lang.Object.GetObject<ITransition>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceReady(object2, object3);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000160B0 File Offset: 0x000142B0
		public unsafe void OnResourceReady(Java.Lang.Object p0, ITransition p1)
		{
			if (this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ == IntPtr.Zero)
			{
				this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ = JNIEnv.GetMethodID(this.class_ref, "onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00016148 File Offset: 0x00014348
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (IFutureTargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				IFutureTargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IFutureTargetInvoker.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return IFutureTargetInvoker.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001616C File Offset: 0x0001436C
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITarget @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00016190 File Offset: 0x00014390
		public unsafe void RemoveCallback(ISizeReadyCallback p0)
		{
			if (this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == IntPtr.Zero)
			{
				this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNIEnv.GetMethodID(this.class_ref, "removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_, ptr);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00016208 File Offset: 0x00014408
		private static Delegate GetOnDestroyHandler()
		{
			if (IFutureTargetInvoker.cb_onDestroy == null)
			{
				IFutureTargetInvoker.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IFutureTargetInvoker.n_OnDestroy));
			}
			return IFutureTargetInvoker.cb_onDestroy;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001622C File Offset: 0x0001442C
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001623B File Offset: 0x0001443B
		public void OnDestroy()
		{
			if (this.id_onDestroy == IntPtr.Zero)
			{
				this.id_onDestroy = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001627B File Offset: 0x0001447B
		private static Delegate GetOnStartHandler()
		{
			if (IFutureTargetInvoker.cb_onStart == null)
			{
				IFutureTargetInvoker.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IFutureTargetInvoker.n_OnStart));
			}
			return IFutureTargetInvoker.cb_onStart;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001629F File Offset: 0x0001449F
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000162AE File Offset: 0x000144AE
		public void OnStart()
		{
			if (this.id_onStart == IntPtr.Zero)
			{
				this.id_onStart = JNIEnv.GetMethodID(this.class_ref, "onStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStart);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000162EE File Offset: 0x000144EE
		private static Delegate GetOnStopHandler()
		{
			if (IFutureTargetInvoker.cb_onStop == null)
			{
				IFutureTargetInvoker.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IFutureTargetInvoker.n_OnStop));
			}
			return IFutureTargetInvoker.cb_onStop;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00016312 File Offset: 0x00014512
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00016321 File Offset: 0x00014521
		public void OnStop()
		{
			if (this.id_onStop == IntPtr.Zero)
			{
				this.id_onStop = JNIEnv.GetMethodID(this.class_ref, "onStop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStop);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00016361 File Offset: 0x00014561
		private static Delegate GetIsCancelledHandler()
		{
			if (IFutureTargetInvoker.cb_isCancelled == null)
			{
				IFutureTargetInvoker.cb_isCancelled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFutureTargetInvoker.n_IsCancelled));
			}
			return IFutureTargetInvoker.cb_isCancelled;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00016385 File Offset: 0x00014585
		private static bool n_IsCancelled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancelled;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00016394 File Offset: 0x00014594
		public bool IsCancelled
		{
			get
			{
				if (this.id_isCancelled == IntPtr.Zero)
				{
					this.id_isCancelled = JNIEnv.GetMethodID(this.class_ref, "isCancelled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCancelled);
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000163D4 File Offset: 0x000145D4
		private static Delegate GetIsDoneHandler()
		{
			if (IFutureTargetInvoker.cb_isDone == null)
			{
				IFutureTargetInvoker.cb_isDone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFutureTargetInvoker.n_IsDone));
			}
			return IFutureTargetInvoker.cb_isDone;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000163F8 File Offset: 0x000145F8
		private static bool n_IsDone(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDone;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00016407 File Offset: 0x00014607
		public bool IsDone
		{
			get
			{
				if (this.id_isDone == IntPtr.Zero)
				{
					this.id_isDone = JNIEnv.GetMethodID(this.class_ref, "isDone", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isDone);
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00016447 File Offset: 0x00014647
		private static Delegate GetCancel_ZHandler()
		{
			if (IFutureTargetInvoker.cb_cancel_Z == null)
			{
				IFutureTargetInvoker.cb_cancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(IFutureTargetInvoker.n_Cancel_Z));
			}
			return IFutureTargetInvoker.cb_cancel_Z;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001646B File Offset: 0x0001466B
		private static bool n_Cancel_Z(IntPtr jnienv, IntPtr native__this, bool mayInterruptIfRunning)
		{
			return Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel(mayInterruptIfRunning);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001647C File Offset: 0x0001467C
		public unsafe bool Cancel(bool mayInterruptIfRunning)
		{
			if (this.id_cancel_Z == IntPtr.Zero)
			{
				this.id_cancel_Z = JNIEnv.GetMethodID(this.class_ref, "cancel", "(Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(mayInterruptIfRunning);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_cancel_Z, ptr);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000164E0 File Offset: 0x000146E0
		private static Delegate GetGetHandler()
		{
			if (IFutureTargetInvoker.cb_get == null)
			{
				IFutureTargetInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFutureTargetInvoker.n_Get));
			}
			return IFutureTargetInvoker.cb_get;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00016504 File Offset: 0x00014704
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00016518 File Offset: 0x00014718
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00016569 File Offset: 0x00014769
		private static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IFutureTargetInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IFutureTargetInvoker.cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IFutureTargetInvoker.n_Get_JLjava_util_concurrent_TimeUnit_));
			}
			return IFutureTargetInvoker.cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00016590 File Offset: 0x00014790
		private static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IFuture @object = Java.Lang.Object.GetObject<IFutureTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(timeout, object2));
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000165BC File Offset: 0x000147BC
		public unsafe Java.Lang.Object Get(long timeout, TimeUnit unit)
		{
			if (this.id_get_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_get_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000181 RID: 385
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/FutureTarget", typeof(IFutureTargetInvoker));

		// Token: 0x04000182 RID: 386
		private IntPtr class_ref;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_getRequest;

		// Token: 0x04000184 RID: 388
		private static Delegate cb_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000185 RID: 389
		private IntPtr id_getRequest;

		// Token: 0x04000186 RID: 390
		private IntPtr id_setRequest_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000187 RID: 391
		private static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000188 RID: 392
		private IntPtr id_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018A RID: 394
		private IntPtr id_onLoadCleared_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018C RID: 396
		private IntPtr id_onLoadFailed_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018D RID: 397
		private static Delegate cb_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018E RID: 398
		private IntPtr id_onLoadStarted_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018F RID: 399
		private static Delegate cb_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000190 RID: 400
		private IntPtr id_onResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_;

		// Token: 0x04000191 RID: 401
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000192 RID: 402
		private IntPtr id_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x04000193 RID: 403
		private static Delegate cb_onDestroy;

		// Token: 0x04000194 RID: 404
		private IntPtr id_onDestroy;

		// Token: 0x04000195 RID: 405
		private static Delegate cb_onStart;

		// Token: 0x04000196 RID: 406
		private IntPtr id_onStart;

		// Token: 0x04000197 RID: 407
		private static Delegate cb_onStop;

		// Token: 0x04000198 RID: 408
		private IntPtr id_onStop;

		// Token: 0x04000199 RID: 409
		private static Delegate cb_isCancelled;

		// Token: 0x0400019A RID: 410
		private IntPtr id_isCancelled;

		// Token: 0x0400019B RID: 411
		private static Delegate cb_isDone;

		// Token: 0x0400019C RID: 412
		private IntPtr id_isDone;

		// Token: 0x0400019D RID: 413
		private static Delegate cb_cancel_Z;

		// Token: 0x0400019E RID: 414
		private IntPtr id_cancel_Z;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_get;

		// Token: 0x040001A0 RID: 416
		private IntPtr id_get;

		// Token: 0x040001A1 RID: 417
		private static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x040001A2 RID: 418
		private IntPtr id_get_JLjava_util_concurrent_TimeUnit_;
	}
}
