using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Request;
using Bumptech.Glide.Request.Target;
using Bumptech.Glide.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003B RID: 59
	[Register("com/bumptech/glide/GlideContext", DoNotGenerateAcw = true)]
	public class GlideContext : ContextWrapper
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00006344 File Offset: 0x00004544
		internal static IntPtr class_ref
		{
			get
			{
				return GlideContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00006368 File Offset: 0x00004568
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideContext._members;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00006370 File Offset: 0x00004570
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00006394 File Offset: 0x00004594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideContext._members.ManagedPeerType;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000063A0 File Offset: 0x000045A0
		protected GlideContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000063AC File Offset: 0x000045AC
		[Register(".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;Lcom/bumptech/glide/request/target/ImageViewTargetFactory;Lcom/bumptech/glide/Glide$RequestOptionsFactory;Ljava/util/Map;Ljava/util/List;Lcom/bumptech/glide/load/engine/Engine;Lcom/bumptech/glide/GlideExperiments;I)V", "")]
		public unsafe GlideContext(Context context, IArrayPool arrayPool, GlideSuppliers.IGlideSupplier registry, ImageViewTargetFactory imageViewTargetFactory, Glide.IRequestOptionsFactory defaultRequestOptionsFactory, IDictionary<Class, TransitionOptions> defaultTransitionOptions, IList<IRequestListener> defaultRequestListeners, Engine engine, GlideExperiments experiments, int logLevel) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<Class, TransitionOptions>.ToLocalJniHandle(defaultTransitionOptions);
			IntPtr intPtr2 = JavaList<IRequestListener>.ToLocalJniHandle(defaultRequestListeners);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				ptr[2] = new JniArgumentValue((registry == null) ? IntPtr.Zero : ((Java.Lang.Object)registry).Handle);
				ptr[3] = new JniArgumentValue((imageViewTargetFactory == null) ? IntPtr.Zero : imageViewTargetFactory.Handle);
				ptr[4] = new JniArgumentValue((defaultRequestOptionsFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultRequestOptionsFactory).Handle);
				ptr[5] = new JniArgumentValue(intPtr);
				ptr[6] = new JniArgumentValue(intPtr2);
				ptr[7] = new JniArgumentValue((engine == null) ? IntPtr.Zero : engine.Handle);
				ptr[8] = new JniArgumentValue((experiments == null) ? IntPtr.Zero : experiments.Handle);
				ptr[9] = new JniArgumentValue(logLevel);
				base.SetHandle(GlideContext._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;Lcom/bumptech/glide/request/target/ImageViewTargetFactory;Lcom/bumptech/glide/Glide$RequestOptionsFactory;Ljava/util/Map;Ljava/util/List;Lcom/bumptech/glide/load/engine/Engine;Lcom/bumptech/glide/GlideExperiments;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GlideContext._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;Lcom/bumptech/glide/request/target/ImageViewTargetFactory;Lcom/bumptech/glide/Glide$RequestOptionsFactory;Ljava/util/Map;Ljava/util/List;Lcom/bumptech/glide/load/engine/Engine;Lcom/bumptech/glide/GlideExperiments;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(context);
				GC.KeepAlive(arrayPool);
				GC.KeepAlive(registry);
				GC.KeepAlive(imageViewTargetFactory);
				GC.KeepAlive(defaultRequestOptionsFactory);
				GC.KeepAlive(defaultTransitionOptions);
				GC.KeepAlive(defaultRequestListeners);
				GC.KeepAlive(engine);
				GC.KeepAlive(experiments);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000065F0 File Offset: 0x000047F0
		private static Delegate GetGetArrayPoolHandler()
		{
			if (GlideContext.cb_getArrayPool == null)
			{
				GlideContext.cb_getArrayPool = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetArrayPool));
			}
			return GlideContext.cb_getArrayPool;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006614 File Offset: 0x00004814
		private static IntPtr n_GetArrayPool(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrayPool);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00006628 File Offset: 0x00004828
		public virtual IArrayPool ArrayPool
		{
			[Register("getArrayPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;", "GetGetArrayPoolHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IArrayPool>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getArrayPool.()Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000665A File Offset: 0x0000485A
		private static Delegate GetGetDefaultRequestListenersHandler()
		{
			if (GlideContext.cb_getDefaultRequestListeners == null)
			{
				GlideContext.cb_getDefaultRequestListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetDefaultRequestListeners));
			}
			return GlideContext.cb_getDefaultRequestListeners;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000667E File Offset: 0x0000487E
		private static IntPtr n_GetDefaultRequestListeners(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IRequestListener>.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultRequestListeners);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00006694 File Offset: 0x00004894
		public virtual IList<IRequestListener> DefaultRequestListeners
		{
			[Register("getDefaultRequestListeners", "()Ljava/util/List;", "GetGetDefaultRequestListenersHandler")]
			get
			{
				return JavaList<IRequestListener>.FromJniHandle(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultRequestListeners.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000066C6 File Offset: 0x000048C6
		private static Delegate GetGetDefaultRequestOptionsHandler()
		{
			if (GlideContext.cb_getDefaultRequestOptions == null)
			{
				GlideContext.cb_getDefaultRequestOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetDefaultRequestOptions));
			}
			return GlideContext.cb_getDefaultRequestOptions;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000066EA File Offset: 0x000048EA
		private static IntPtr n_GetDefaultRequestOptions(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultRequestOptions);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00006700 File Offset: 0x00004900
		public virtual RequestOptions DefaultRequestOptions
		{
			[Register("getDefaultRequestOptions", "()Lcom/bumptech/glide/request/RequestOptions;", "GetGetDefaultRequestOptionsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestOptions>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultRequestOptions.()Lcom/bumptech/glide/request/RequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00006732 File Offset: 0x00004932
		private static Delegate GetGetEngineHandler()
		{
			if (GlideContext.cb_getEngine == null)
			{
				GlideContext.cb_getEngine = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetEngine));
			}
			return GlideContext.cb_getEngine;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00006756 File Offset: 0x00004956
		private static IntPtr n_GetEngine(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Engine);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000676C File Offset: 0x0000496C
		public virtual Engine Engine
		{
			[Register("getEngine", "()Lcom/bumptech/glide/load/engine/Engine;", "GetGetEngineHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Engine>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getEngine.()Lcom/bumptech/glide/load/engine/Engine;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000679E File Offset: 0x0000499E
		private static Delegate GetGetExperimentsHandler()
		{
			if (GlideContext.cb_getExperiments == null)
			{
				GlideContext.cb_getExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetExperiments));
			}
			return GlideContext.cb_getExperiments;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000067C2 File Offset: 0x000049C2
		private static IntPtr n_GetExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Experiments);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000067D8 File Offset: 0x000049D8
		public virtual GlideExperiments Experiments
		{
			[Register("getExperiments", "()Lcom/bumptech/glide/GlideExperiments;", "GetGetExperimentsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<GlideExperiments>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getExperiments.()Lcom/bumptech/glide/GlideExperiments;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000680A File Offset: 0x00004A0A
		private static Delegate GetGetLogLevelHandler()
		{
			if (GlideContext.cb_getLogLevel == null)
			{
				GlideContext.cb_getLogLevel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GlideContext.n_GetLogLevel));
			}
			return GlideContext.cb_getLogLevel;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000682E File Offset: 0x00004A2E
		private static int n_GetLogLevel(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogLevel;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000683D File Offset: 0x00004A3D
		public virtual int LogLevel
		{
			[Register("getLogLevel", "()I", "GetGetLogLevelHandler")]
			get
			{
				return GlideContext._members.InstanceMethods.InvokeVirtualInt32Method("getLogLevel.()I", this, null);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006856 File Offset: 0x00004A56
		private static Delegate GetGetRegistryHandler()
		{
			if (GlideContext.cb_getRegistry == null)
			{
				GlideContext.cb_getRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideContext.n_GetRegistry));
			}
			return GlideContext.cb_getRegistry;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000687A File Offset: 0x00004A7A
		private static IntPtr n_GetRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Registry);
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006890 File Offset: 0x00004A90
		public virtual Registry Registry
		{
			[Register("getRegistry", "()Lcom/bumptech/glide/Registry;", "GetGetRegistryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Registry>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getRegistry.()Lcom/bumptech/glide/Registry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000068C2 File Offset: 0x00004AC2
		private static Delegate GetBuildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler()
		{
			if (GlideContext.cb_buildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_ == null)
			{
				GlideContext.cb_buildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(GlideContext.n_BuildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_));
			}
			return GlideContext.cb_buildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000068E8 File Offset: 0x00004AE8
		private static IntPtr n_BuildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_imageView, IntPtr native_transcodeClass)
		{
			GlideContext @object = Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ImageView object2 = Java.Lang.Object.GetObject<ImageView>(native_imageView, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildImageViewTarget(object2, object3));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000691C File Offset: 0x00004B1C
		[Register("buildImageViewTarget", "(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/ViewTarget;", "GetBuildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X"
		})]
		public unsafe virtual ViewTarget BuildImageViewTarget(ImageView imageView, Class transcodeClass)
		{
			ViewTarget @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((imageView == null) ? IntPtr.Zero : imageView.Handle);
				ptr[1] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				@object = Java.Lang.Object.GetObject<ViewTarget>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("buildImageViewTarget.(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/ViewTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(imageView);
				GC.KeepAlive(transcodeClass);
			}
			return @object;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000069B8 File Offset: 0x00004BB8
		private static Delegate GetGetDefaultTransitionOptions_Ljava_lang_Class_Handler()
		{
			if (GlideContext.cb_getDefaultTransitionOptions_Ljava_lang_Class_ == null)
			{
				GlideContext.cb_getDefaultTransitionOptions_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GlideContext.n_GetDefaultTransitionOptions_Ljava_lang_Class_));
			}
			return GlideContext.cb_getDefaultTransitionOptions_Ljava_lang_Class_;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000069DC File Offset: 0x00004BDC
		private static IntPtr n_GetDefaultTransitionOptions_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_transcodeClass)
		{
			GlideContext @object = Java.Lang.Object.GetObject<GlideContext>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDefaultTransitionOptions(object2));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00006A04 File Offset: 0x00004C04
		[Register("getDefaultTransitionOptions", "(Ljava/lang/Class;)Lcom/bumptech/glide/TransitionOptions;", "GetGetDefaultTransitionOptions_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual TransitionOptions GetDefaultTransitionOptions(Class transcodeClass)
		{
			TransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				@object = Java.Lang.Object.GetObject<TransitionOptions>(GlideContext._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultTransitionOptions.(Ljava/lang/Class;)Lcom/bumptech/glide/TransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transcodeClass);
			}
			return @object;
		}

		// Token: 0x0400004F RID: 79
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideContext", typeof(GlideContext));

		// Token: 0x04000050 RID: 80
		private static Delegate cb_getArrayPool;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_getDefaultRequestListeners;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_getDefaultRequestOptions;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_getEngine;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getExperiments;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_getLogLevel;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_getRegistry;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_buildImageViewTarget_Landroid_widget_ImageView_Ljava_lang_Class_;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getDefaultTransitionOptions_Ljava_lang_Class_;
	}
}
