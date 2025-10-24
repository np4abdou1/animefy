using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Net;

namespace Bumptech.Glide
{
	// Token: 0x02000041 RID: 65
	[Register("com/bumptech/glide/RequestManager", DoNotGenerateAcw = true)]
	public class RequestManager : Java.Lang.Object, IComponentCallbacks2, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, ILifecycleListener
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00008BE8 File Offset: 0x00006DE8
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00008C18 File Offset: 0x00006E18
		[Register("context")]
		protected Context Context
		{
			get
			{
				return Java.Lang.Object.GetObject<Context>(RequestManager._members.InstanceFields.GetObjectValue("context.Landroid/content/Context;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					RequestManager._members.InstanceFields.SetValue("context.Landroid/content/Context;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00008C64 File Offset: 0x00006E64
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00008C94 File Offset: 0x00006E94
		[Register("glide")]
		protected Glide Glide
		{
			get
			{
				return Java.Lang.Object.GetObject<Glide>(RequestManager._members.InstanceFields.GetObjectValue("glide.Lcom/bumptech/glide/Glide;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					RequestManager._members.InstanceFields.SetValue("glide.Lcom/bumptech/glide/Glide;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00008CE0 File Offset: 0x00006EE0
		internal static IntPtr class_ref
		{
			get
			{
				return RequestManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00008D04 File Offset: 0x00006F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestManager._members;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00008D0C File Offset: 0x00006F0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00008D30 File Offset: 0x00006F30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008D3C File Offset: 0x00006F3C
		protected RequestManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00008D48 File Offset: 0x00006F48
		[Register(".ctor", "(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;Landroid/content/Context;)V", "")]
		public unsafe RequestManager(Glide glide, ILifecycle lifecycle, IRequestManagerTreeNode treeNode, Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glide == null) ? IntPtr.Zero : glide.Handle);
				ptr[1] = new JniArgumentValue((lifecycle == null) ? IntPtr.Zero : ((Java.Lang.Object)lifecycle).Handle);
				ptr[2] = new JniArgumentValue((treeNode == null) ? IntPtr.Zero : ((Java.Lang.Object)treeNode).Handle);
				ptr[3] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(RequestManager._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RequestManager._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(glide);
				GC.KeepAlive(lifecycle);
				GC.KeepAlive(treeNode);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008E80 File Offset: 0x00007080
		private static Delegate GetIsPausedHandler()
		{
			if (RequestManager.cb_isPaused == null)
			{
				RequestManager.cb_isPaused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RequestManager.n_IsPaused));
			}
			return RequestManager.cb_isPaused;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00008EA4 File Offset: 0x000070A4
		private static bool n_IsPaused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPaused;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00008EB3 File Offset: 0x000070B3
		public virtual bool IsPaused
		{
			[Register("isPaused", "()Z", "GetIsPausedHandler")]
			get
			{
				return RequestManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isPaused.()Z", this, null);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00008ECC File Offset: 0x000070CC
		private static Delegate GetAddDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_Handler()
		{
			if (RequestManager.cb_addDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_ == null)
			{
				RequestManager.cb_addDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_AddDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_));
			}
			return RequestManager.cb_addDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00008EF0 File Offset: 0x000070F0
		private static IntPtr n_AddDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestListener)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequestListener object2 = Java.Lang.Object.GetObject<IRequestListener>(native_requestListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddDefaultRequestListener(object2));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00008F18 File Offset: 0x00007118
		[Register("addDefaultRequestListener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestManager;", "GetAddDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_Handler")]
		public unsafe virtual RequestManager AddDefaultRequestListener(IRequestListener requestListener)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestListener == null) ? IntPtr.Zero : ((Java.Lang.Object)requestListener).Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("addDefaultRequestListener.(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestListener);
			}
			return @object;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008F90 File Offset: 0x00007190
		private static Delegate GetApplyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler()
		{
			if (RequestManager.cb_applyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ == null)
			{
				RequestManager.cb_applyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_ApplyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_));
			}
			return RequestManager.cb_applyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00008FB4 File Offset: 0x000071B4
		private static IntPtr n_ApplyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestOptions)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestOptions object2 = Java.Lang.Object.GetObject<RequestOptions>(native_requestOptions, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ApplyDefaultRequestOptions(object2));
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00008FDC File Offset: 0x000071DC
		[Register("applyDefaultRequestOptions", "(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/RequestManager;", "GetApplyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler")]
		public unsafe virtual RequestManager ApplyDefaultRequestOptions(RequestOptions requestOptions)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestOptions == null) ? IntPtr.Zero : requestOptions.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("applyDefaultRequestOptions.(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestOptions);
			}
			return @object;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00009050 File Offset: 0x00007250
		private static Delegate GetAs_Ljava_lang_Class_Handler()
		{
			if (RequestManager.cb_as_Ljava_lang_Class_ == null)
			{
				RequestManager.cb_as_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_As_Ljava_lang_Class_));
			}
			return RequestManager.cb_as_Ljava_lang_Class_;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00009074 File Offset: 0x00007274
		private static IntPtr n_As_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.As(object2));
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000909C File Offset: 0x0000729C
		[Register("as", "(Ljava/lang/Class;)Lcom/bumptech/glide/RequestBuilder;", "GetAs_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"ResourceType"
		})]
		public unsafe virtual RequestBuilder As(Class resourceClass)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("as.(Ljava/lang/Class;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
			}
			return @object;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00009110 File Offset: 0x00007310
		private static Delegate GetAsBitmapHandler()
		{
			if (RequestManager.cb_asBitmap == null)
			{
				RequestManager.cb_asBitmap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManager.n_AsBitmap));
			}
			return RequestManager.cb_asBitmap;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00009134 File Offset: 0x00007334
		private static IntPtr n_AsBitmap(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsBitmap());
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00009148 File Offset: 0x00007348
		[Register("asBitmap", "()Lcom/bumptech/glide/RequestBuilder;", "GetAsBitmapHandler")]
		public virtual RequestBuilder AsBitmap()
		{
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("asBitmap.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000917A File Offset: 0x0000737A
		private static Delegate GetAsDrawableHandler()
		{
			if (RequestManager.cb_asDrawable == null)
			{
				RequestManager.cb_asDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManager.n_AsDrawable));
			}
			return RequestManager.cb_asDrawable;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000919E File Offset: 0x0000739E
		private static IntPtr n_AsDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsDrawable());
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000091B4 File Offset: 0x000073B4
		[Register("asDrawable", "()Lcom/bumptech/glide/RequestBuilder;", "GetAsDrawableHandler")]
		public virtual RequestBuilder AsDrawable()
		{
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("asDrawable.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000091E6 File Offset: 0x000073E6
		private static Delegate GetAsFileHandler()
		{
			if (RequestManager.cb_asFile == null)
			{
				RequestManager.cb_asFile = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManager.n_AsFile));
			}
			return RequestManager.cb_asFile;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000920A File Offset: 0x0000740A
		private static IntPtr n_AsFile(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsFile());
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00009220 File Offset: 0x00007420
		[Register("asFile", "()Lcom/bumptech/glide/RequestBuilder;", "GetAsFileHandler")]
		public virtual RequestBuilder AsFile()
		{
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("asFile.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009252 File Offset: 0x00007452
		private static Delegate GetAsGifHandler()
		{
			if (RequestManager.cb_asGif == null)
			{
				RequestManager.cb_asGif = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManager.n_AsGif));
			}
			return RequestManager.cb_asGif;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00009276 File Offset: 0x00007476
		private static IntPtr n_AsGif(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsGif());
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000928C File Offset: 0x0000748C
		[Register("asGif", "()Lcom/bumptech/glide/RequestBuilder;", "GetAsGifHandler")]
		public virtual RequestBuilder AsGif()
		{
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("asGif.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000092BE File Offset: 0x000074BE
		private static Delegate GetClear_Landroid_view_View_Handler()
		{
			if (RequestManager.cb_clear_Landroid_view_View_ == null)
			{
				RequestManager.cb_clear_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestManager.n_Clear_Landroid_view_View_));
			}
			return RequestManager.cb_clear_Landroid_view_View_;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000092E4 File Offset: 0x000074E4
		private static void n_Clear_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.Clear(object2);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009308 File Offset: 0x00007508
		[Register("clear", "(Landroid/view/View;)V", "GetClear_Landroid_view_View_Handler")]
		public unsafe virtual void Clear(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("clear.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000936C File Offset: 0x0000756C
		private static Delegate GetClear_Lcom_bumptech_glide_request_target_Target_Handler()
		{
			if (RequestManager.cb_clear_Lcom_bumptech_glide_request_target_Target_ == null)
			{
				RequestManager.cb_clear_Lcom_bumptech_glide_request_target_Target_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestManager.n_Clear_Lcom_bumptech_glide_request_target_Target_));
			}
			return RequestManager.cb_clear_Lcom_bumptech_glide_request_target_Target_;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00009390 File Offset: 0x00007590
		private static void n_Clear_Lcom_bumptech_glide_request_target_Target_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITarget object2 = Java.Lang.Object.GetObject<ITarget>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.Clear(object2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000093B4 File Offset: 0x000075B4
		[Register("clear", "(Lcom/bumptech/glide/request/target/Target;)V", "GetClear_Lcom_bumptech_glide_request_target_Target_Handler")]
		public unsafe virtual void Clear(ITarget target)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("clear.(Lcom/bumptech/glide/request/target/Target;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000941C File Offset: 0x0000761C
		private static Delegate GetDownload_Ljava_lang_Object_Handler()
		{
			if (RequestManager.cb_download_Ljava_lang_Object_ == null)
			{
				RequestManager.cb_download_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Download_Ljava_lang_Object_));
			}
			return RequestManager.cb_download_Ljava_lang_Object_;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00009440 File Offset: 0x00007640
		private static IntPtr n_Download_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Download(object2));
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00009468 File Offset: 0x00007668
		[Register("download", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", "GetDownload_Ljava_lang_Object_Handler")]
		public unsafe virtual RequestBuilder Download(Java.Lang.Object model)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("download.(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000094DC File Offset: 0x000076DC
		private static Delegate GetDownloadOnlyHandler()
		{
			if (RequestManager.cb_downloadOnly == null)
			{
				RequestManager.cb_downloadOnly = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestManager.n_DownloadOnly));
			}
			return RequestManager.cb_downloadOnly;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009500 File Offset: 0x00007700
		private static IntPtr n_DownloadOnly(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DownloadOnly());
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009514 File Offset: 0x00007714
		[Register("downloadOnly", "()Lcom/bumptech/glide/RequestBuilder;", "GetDownloadOnlyHandler")]
		public virtual RequestBuilder DownloadOnly()
		{
			return Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("downloadOnly.()Lcom/bumptech/glide/RequestBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009546 File Offset: 0x00007746
		private static Delegate GetLoad_Landroid_graphics_Bitmap_Handler()
		{
			if (RequestManager.cb_load_Landroid_graphics_Bitmap_ == null)
			{
				RequestManager.cb_load_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Landroid_graphics_Bitmap_));
			}
			return RequestManager.cb_load_Landroid_graphics_Bitmap_;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000956C File Offset: 0x0000776C
		private static IntPtr n_Load_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009594 File Offset: 0x00007794
		[Register("load", "(Landroid/graphics/Bitmap;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual RequestBuilder Load(Bitmap bitmap)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/graphics/Bitmap;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return @object;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00009608 File Offset: 0x00007808
		private static Delegate GetLoad_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (RequestManager.cb_load_Landroid_graphics_drawable_Drawable_ == null)
			{
				RequestManager.cb_load_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Landroid_graphics_drawable_Drawable_));
			}
			return RequestManager.cb_load_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000962C File Offset: 0x0000782C
		private static IntPtr n_Load_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00009654 File Offset: 0x00007854
		[Register("load", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual RequestBuilder Load(Drawable drawable)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
			return @object;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000096C8 File Offset: 0x000078C8
		private static Delegate GetLoad_Landroid_net_Uri_Handler()
		{
			if (RequestManager.cb_load_Landroid_net_Uri_ == null)
			{
				RequestManager.cb_load_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Landroid_net_Uri_));
			}
			return RequestManager.cb_load_Landroid_net_Uri_;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000096EC File Offset: 0x000078EC
		private static IntPtr n_Load_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00009714 File Offset: 0x00007914
		[Register("load", "(Landroid/net/Uri;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Landroid_net_Uri_Handler")]
		public unsafe virtual RequestBuilder Load(Android.Net.Uri uri)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Landroid/net/Uri;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00009788 File Offset: 0x00007988
		private static Delegate GetLoad_arrayBHandler()
		{
			if (RequestManager.cb_load_arrayB == null)
			{
				RequestManager.cb_load_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_arrayB));
			}
			return RequestManager.cb_load_arrayB;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000097AC File Offset: 0x000079AC
		private static IntPtr n_Load_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_model, JniHandleOwnership.DoNotTransfer, typeof(byte));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Load(array));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_model);
			}
			return result;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000097F0 File Offset: 0x000079F0
		[Register("load", "([B)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_arrayBHandler")]
		public unsafe virtual RequestBuilder Load(byte[] model)
		{
			IntPtr intPtr = JNIEnv.NewArray(model);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.([B)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (model != null)
				{
					JNIEnv.CopyArray(intPtr, model);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000986C File Offset: 0x00007A6C
		private static Delegate GetLoad_Ljava_io_File_Handler()
		{
			if (RequestManager.cb_load_Ljava_io_File_ == null)
			{
				RequestManager.cb_load_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Ljava_io_File_));
			}
			return RequestManager.cb_load_Ljava_io_File_;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009890 File Offset: 0x00007A90
		private static IntPtr n_Load_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Register("load", "(Ljava/io/File;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_io_File_Handler")]
		public unsafe virtual RequestBuilder Load(File file)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/io/File;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return @object;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000992C File Offset: 0x00007B2C
		private static Delegate GetLoad_Ljava_lang_Integer_Handler()
		{
			if (RequestManager.cb_load_Ljava_lang_Integer_ == null)
			{
				RequestManager.cb_load_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Ljava_lang_Integer_));
			}
			return RequestManager.cb_load_Ljava_lang_Integer_;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009950 File Offset: 0x00007B50
		private static IntPtr n_Load_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceId)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_resourceId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00009978 File Offset: 0x00007B78
		[Register("load", "(Ljava/lang/Integer;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_Integer_Handler")]
		public unsafe virtual RequestBuilder Load(Integer resourceId)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceId == null) ? IntPtr.Zero : resourceId.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/Integer;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceId);
			}
			return @object;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000099EC File Offset: 0x00007BEC
		private static Delegate GetLoad_Ljava_lang_Object_Handler()
		{
			if (RequestManager.cb_load_Ljava_lang_Object_ == null)
			{
				RequestManager.cb_load_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Ljava_lang_Object_));
			}
			return RequestManager.cb_load_Ljava_lang_Object_;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00009A10 File Offset: 0x00007C10
		private static IntPtr n_Load_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009A38 File Offset: 0x00007C38
		[Register("load", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_Object_Handler")]
		public unsafe virtual RequestBuilder Load(Java.Lang.Object model)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return @object;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009AAC File Offset: 0x00007CAC
		private static Delegate GetLoad_Ljava_lang_String_Handler()
		{
			if (RequestManager.cb_load_Ljava_lang_String_ == null)
			{
				RequestManager.cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Ljava_lang_String_));
			}
			return RequestManager.cb_load_Ljava_lang_String_;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009AD0 File Offset: 0x00007CD0
		private static IntPtr n_Load_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native__string)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native__string, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(@string));
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Register("load", "(Ljava/lang/String;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_lang_String_Handler")]
		public unsafe virtual RequestBuilder Load(string @string)
		{
			IntPtr intPtr = JNIEnv.NewString(@string);
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/lang/String;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009B64 File Offset: 0x00007D64
		[Obsolete]
		private static Delegate GetLoad_Ljava_net_URL_Handler()
		{
			if (RequestManager.cb_load_Ljava_net_URL_ == null)
			{
				RequestManager.cb_load_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_Load_Ljava_net_URL_));
			}
			return RequestManager.cb_load_Ljava_net_URL_;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009B88 File Offset: 0x00007D88
		[Obsolete]
		private static IntPtr n_Load_Ljava_net_URL_(IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			URL object2 = Java.Lang.Object.GetObject<URL>(native_url, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2));
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009BB0 File Offset: 0x00007DB0
		[Obsolete("deprecated")]
		[Register("load", "(Ljava/net/URL;)Lcom/bumptech/glide/RequestBuilder;", "GetLoad_Ljava_net_URL_Handler")]
		public unsafe virtual RequestBuilder Load(URL url)
		{
			RequestBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((url == null) ? IntPtr.Zero : url.Handle);
				@object = Java.Lang.Object.GetObject<RequestBuilder>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Ljava/net/URL;)Lcom/bumptech/glide/RequestBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(url);
			}
			return @object;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009C24 File Offset: 0x00007E24
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (RequestManager.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				RequestManager.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestManager.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return RequestManager.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009C48 File Offset: 0x00007E48
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00009C6C File Offset: 0x00007E6C
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009CD0 File Offset: 0x00007ED0
		private static Delegate GetOnDestroyHandler()
		{
			if (RequestManager.cb_onDestroy == null)
			{
				RequestManager.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_OnDestroy));
			}
			return RequestManager.cb_onDestroy;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009CF4 File Offset: 0x00007EF4
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009D03 File Offset: 0x00007F03
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009D1C File Offset: 0x00007F1C
		private static Delegate GetOnLowMemoryHandler()
		{
			if (RequestManager.cb_onLowMemory == null)
			{
				RequestManager.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_OnLowMemory));
			}
			return RequestManager.cb_onLowMemory;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009D40 File Offset: 0x00007F40
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00009D4F File Offset: 0x00007F4F
		[Register("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual void OnLowMemory()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009D68 File Offset: 0x00007F68
		private static Delegate GetOnStartHandler()
		{
			if (RequestManager.cb_onStart == null)
			{
				RequestManager.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_OnStart));
			}
			return RequestManager.cb_onStart;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00009D8C File Offset: 0x00007F8C
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00009D9B File Offset: 0x00007F9B
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00009DB4 File Offset: 0x00007FB4
		private static Delegate GetOnStopHandler()
		{
			if (RequestManager.cb_onStop == null)
			{
				RequestManager.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_OnStop));
			}
			return RequestManager.cb_onStop;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00009DD8 File Offset: 0x00007FD8
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009DE7 File Offset: 0x00007FE7
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00009E00 File Offset: 0x00008000
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (RequestManager.cb_onTrimMemory_I == null)
			{
				RequestManager.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RequestManager.n_OnTrimMemory_I));
			}
			return RequestManager.cb_onTrimMemory_I;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00009E24 File Offset: 0x00008024
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00009E44 File Offset: 0x00008044
		[Register("onTrimMemory", "(I)V", "GetOnTrimMemory_IHandler")]
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00009E7F File Offset: 0x0000807F
		private static Delegate GetPauseAllRequestsHandler()
		{
			if (RequestManager.cb_pauseAllRequests == null)
			{
				RequestManager.cb_pauseAllRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_PauseAllRequests));
			}
			return RequestManager.cb_pauseAllRequests;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00009EA3 File Offset: 0x000080A3
		private static void n_PauseAllRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseAllRequests();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00009EB2 File Offset: 0x000080B2
		[Register("pauseAllRequests", "()V", "GetPauseAllRequestsHandler")]
		public virtual void PauseAllRequests()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("pauseAllRequests.()V", this, null);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00009ECB File Offset: 0x000080CB
		private static Delegate GetPauseAllRequestsRecursiveHandler()
		{
			if (RequestManager.cb_pauseAllRequestsRecursive == null)
			{
				RequestManager.cb_pauseAllRequestsRecursive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_PauseAllRequestsRecursive));
			}
			return RequestManager.cb_pauseAllRequestsRecursive;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00009EEF File Offset: 0x000080EF
		private static void n_PauseAllRequestsRecursive(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseAllRequestsRecursive();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00009EFE File Offset: 0x000080FE
		[Register("pauseAllRequestsRecursive", "()V", "GetPauseAllRequestsRecursiveHandler")]
		public virtual void PauseAllRequestsRecursive()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("pauseAllRequestsRecursive.()V", this, null);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00009F17 File Offset: 0x00008117
		private static Delegate GetPauseRequestsHandler()
		{
			if (RequestManager.cb_pauseRequests == null)
			{
				RequestManager.cb_pauseRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_PauseRequests));
			}
			return RequestManager.cb_pauseRequests;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00009F3B File Offset: 0x0000813B
		private static void n_PauseRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseRequests();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00009F4A File Offset: 0x0000814A
		[Register("pauseRequests", "()V", "GetPauseRequestsHandler")]
		public virtual void PauseRequests()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("pauseRequests.()V", this, null);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00009F63 File Offset: 0x00008163
		private static Delegate GetPauseRequestsRecursiveHandler()
		{
			if (RequestManager.cb_pauseRequestsRecursive == null)
			{
				RequestManager.cb_pauseRequestsRecursive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_PauseRequestsRecursive));
			}
			return RequestManager.cb_pauseRequestsRecursive;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00009F87 File Offset: 0x00008187
		private static void n_PauseRequestsRecursive(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseRequestsRecursive();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00009F96 File Offset: 0x00008196
		[Register("pauseRequestsRecursive", "()V", "GetPauseRequestsRecursiveHandler")]
		public virtual void PauseRequestsRecursive()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("pauseRequestsRecursive.()V", this, null);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00009FAF File Offset: 0x000081AF
		private static Delegate GetResumeRequestsHandler()
		{
			if (RequestManager.cb_resumeRequests == null)
			{
				RequestManager.cb_resumeRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_ResumeRequests));
			}
			return RequestManager.cb_resumeRequests;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00009FD3 File Offset: 0x000081D3
		private static void n_ResumeRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResumeRequests();
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00009FE2 File Offset: 0x000081E2
		[Register("resumeRequests", "()V", "GetResumeRequestsHandler")]
		public virtual void ResumeRequests()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("resumeRequests.()V", this, null);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00009FFB File Offset: 0x000081FB
		private static Delegate GetResumeRequestsRecursiveHandler()
		{
			if (RequestManager.cb_resumeRequestsRecursive == null)
			{
				RequestManager.cb_resumeRequestsRecursive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestManager.n_ResumeRequestsRecursive));
			}
			return RequestManager.cb_resumeRequestsRecursive;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000A01F File Offset: 0x0000821F
		private static void n_ResumeRequestsRecursive(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResumeRequestsRecursive();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000A02E File Offset: 0x0000822E
		[Register("resumeRequestsRecursive", "()V", "GetResumeRequestsRecursiveHandler")]
		public virtual void ResumeRequestsRecursive()
		{
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("resumeRequestsRecursive.()V", this, null);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000A047 File Offset: 0x00008247
		private static Delegate GetSetDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler()
		{
			if (RequestManager.cb_setDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ == null)
			{
				RequestManager.cb_setDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManager.n_SetDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_));
			}
			return RequestManager.cb_setDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000A06C File Offset: 0x0000826C
		private static IntPtr n_SetDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestOptions)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestOptions object2 = Java.Lang.Object.GetObject<RequestOptions>(native_requestOptions, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetDefaultRequestOptions(object2));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000A094 File Offset: 0x00008294
		[Register("setDefaultRequestOptions", "(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/RequestManager;", "GetSetDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler")]
		public unsafe virtual RequestManager SetDefaultRequestOptions(RequestOptions requestOptions)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestOptions == null) ? IntPtr.Zero : requestOptions.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManager._members.InstanceMethods.InvokeVirtualObjectMethod("setDefaultRequestOptions.(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestOptions);
			}
			return @object;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000A108 File Offset: 0x00008308
		private static Delegate GetSetPauseAllRequestsOnTrimMemoryModerate_ZHandler()
		{
			if (RequestManager.cb_setPauseAllRequestsOnTrimMemoryModerate_Z == null)
			{
				RequestManager.cb_setPauseAllRequestsOnTrimMemoryModerate_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RequestManager.n_SetPauseAllRequestsOnTrimMemoryModerate_Z));
			}
			return RequestManager.cb_setPauseAllRequestsOnTrimMemoryModerate_Z;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000A12C File Offset: 0x0000832C
		private static void n_SetPauseAllRequestsOnTrimMemoryModerate_Z(IntPtr jnienv, IntPtr native__this, bool pauseAllOnTrim)
		{
			Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPauseAllRequestsOnTrimMemoryModerate(pauseAllOnTrim);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000A13C File Offset: 0x0000833C
		[Register("setPauseAllRequestsOnTrimMemoryModerate", "(Z)V", "GetSetPauseAllRequestsOnTrimMemoryModerate_ZHandler")]
		public unsafe virtual void SetPauseAllRequestsOnTrimMemoryModerate(bool pauseAllOnTrim)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(pauseAllOnTrim);
			RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("setPauseAllRequestsOnTrimMemoryModerate.(Z)V", this, ptr);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000A177 File Offset: 0x00008377
		private static Delegate GetSetRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler()
		{
			if (RequestManager.cb_setRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ == null)
			{
				RequestManager.cb_setRequestOptions_Lcom_bumptech_glide_request_RequestOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestManager.n_SetRequestOptions_Lcom_bumptech_glide_request_RequestOptions_));
			}
			return RequestManager.cb_setRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000A19C File Offset: 0x0000839C
		private static void n_SetRequestOptions_Lcom_bumptech_glide_request_RequestOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_toSet)
		{
			RequestManager @object = Java.Lang.Object.GetObject<RequestManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RequestOptions object2 = Java.Lang.Object.GetObject<RequestOptions>(native_toSet, JniHandleOwnership.DoNotTransfer);
			@object.SetRequestOptions(object2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000A1C0 File Offset: 0x000083C0
		[Register("setRequestOptions", "(Lcom/bumptech/glide/request/RequestOptions;)V", "GetSetRequestOptions_Lcom_bumptech_glide_request_RequestOptions_Handler")]
		protected unsafe virtual void SetRequestOptions(RequestOptions toSet)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toSet == null) ? IntPtr.Zero : toSet.Handle);
				RequestManager._members.InstanceMethods.InvokeVirtualVoidMethod("setRequestOptions.(Lcom/bumptech/glide/request/RequestOptions;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(toSet);
			}
		}

		// Token: 0x0400007D RID: 125
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/RequestManager", typeof(RequestManager));

		// Token: 0x0400007E RID: 126
		private static Delegate cb_isPaused;

		// Token: 0x0400007F RID: 127
		private static Delegate cb_addDefaultRequestListener_Lcom_bumptech_glide_request_RequestListener_;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_applyDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_as_Ljava_lang_Class_;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_asBitmap;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_asDrawable;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_asFile;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_asGif;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_clear_Landroid_view_View_;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_clear_Lcom_bumptech_glide_request_target_Target_;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_download_Ljava_lang_Object_;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_downloadOnly;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_load_Landroid_graphics_Bitmap_;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_load_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_load_Landroid_net_Uri_;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_load_arrayB;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_load_Ljava_io_File_;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_load_Ljava_lang_Integer_;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_load_Ljava_lang_Object_;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_load_Ljava_lang_String_;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_load_Ljava_net_URL_;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_onDestroy;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_onLowMemory;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_onStart;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_onStop;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_pauseAllRequests;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_pauseAllRequestsRecursive;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_pauseRequests;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_pauseRequestsRecursive;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_resumeRequests;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_resumeRequestsRecursive;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_setDefaultRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_setPauseAllRequestsOnTrimMemoryModerate_Z;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_setRequestOptions_Lcom_bumptech_glide_request_RequestOptions_;
	}
}
