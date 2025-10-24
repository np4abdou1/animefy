using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003D RID: 61
	[Register("com/bumptech/glide/ListPreloader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class ListPreloader : Java.Lang.Object, AbsListView.IOnScrollListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006BC8 File Offset: 0x00004DC8
		internal static IntPtr class_ref
		{
			get
			{
				return ListPreloader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00006BEC File Offset: 0x00004DEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ListPreloader._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00006BF4 File Offset: 0x00004DF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ListPreloader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00006C18 File Offset: 0x00004E18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ListPreloader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00006C24 File Offset: 0x00004E24
		protected ListPreloader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006C30 File Offset: 0x00004E30
		[Register(".ctor", "(Lcom/bumptech/glide/RequestManager;Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", "")]
		public unsafe ListPreloader(RequestManager requestManager, ListPreloader.IPreloadModelProvider preloadModelProvider, ListPreloader.IPreloadSizeProvider preloadDimensionProvider, int maxPreload) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestManager == null) ? IntPtr.Zero : requestManager.Handle);
				ptr[1] = new JniArgumentValue((preloadModelProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)preloadModelProvider).Handle);
				ptr[2] = new JniArgumentValue((preloadDimensionProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)preloadDimensionProvider).Handle);
				ptr[3] = new JniArgumentValue(maxPreload);
				base.SetHandle(ListPreloader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/RequestManager;Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ListPreloader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/RequestManager;Lcom/bumptech/glide/ListPreloader$PreloadModelProvider;Lcom/bumptech/glide/ListPreloader$PreloadSizeProvider;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(requestManager);
				GC.KeepAlive(preloadModelProvider);
				GC.KeepAlive(preloadDimensionProvider);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006D54 File Offset: 0x00004F54
		private static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler()
		{
			if (ListPreloader.cb_onScroll_Landroid_widget_AbsListView_III == null)
			{
				ListPreloader.cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(ListPreloader.n_OnScroll_Landroid_widget_AbsListView_III));
			}
			return ListPreloader.cb_onScroll_Landroid_widget_AbsListView_III;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006D78 File Offset: 0x00004F78
		private static void n_OnScroll_Landroid_widget_AbsListView_III(IntPtr jnienv, IntPtr native__this, IntPtr native_absListView, int firstVisible, int visibleCount, int totalCount)
		{
			ListPreloader @object = Java.Lang.Object.GetObject<ListPreloader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AbsListView object2 = Java.Lang.Object.GetObject<AbsListView>(native_absListView, JniHandleOwnership.DoNotTransfer);
			@object.OnScroll(object2, firstVisible, visibleCount, totalCount);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006DA0 File Offset: 0x00004FA0
		[Register("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
		public unsafe virtual void OnScroll(AbsListView absListView, int firstVisible, int visibleCount, int totalCount)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((absListView == null) ? IntPtr.Zero : absListView.Handle);
				ptr[1] = new JniArgumentValue(firstVisible);
				ptr[2] = new JniArgumentValue(visibleCount);
				ptr[3] = new JniArgumentValue(totalCount);
				ListPreloader._members.InstanceMethods.InvokeVirtualVoidMethod("onScroll.(Landroid/widget/AbsListView;III)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(absListView);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006E44 File Offset: 0x00005044
		private static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler()
		{
			if (ListPreloader.cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
			{
				ListPreloader.cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ListPreloader.n_OnScrollStateChanged_Landroid_widget_AbsListView_I));
			}
			return ListPreloader.cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006E68 File Offset: 0x00005068
		private static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I(IntPtr jnienv, IntPtr native__this, IntPtr native_absListView, int native_scrollState)
		{
			ListPreloader @object = Java.Lang.Object.GetObject<ListPreloader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AbsListView object2 = Java.Lang.Object.GetObject<AbsListView>(native_absListView, JniHandleOwnership.DoNotTransfer);
			@object.OnScrollStateChanged(object2, (ScrollState)native_scrollState);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006E90 File Offset: 0x00005090
		[Register("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
		public unsafe virtual void OnScrollStateChanged(AbsListView absListView, [GeneratedEnum] ScrollState scrollState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((absListView == null) ? IntPtr.Zero : absListView.Handle);
				ptr[1] = new JniArgumentValue((int)scrollState);
				ListPreloader._members.InstanceMethods.InvokeVirtualVoidMethod("onScrollStateChanged.(Landroid/widget/AbsListView;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(absListView);
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/ListPreloader", typeof(ListPreloader));

		// Token: 0x0400005C RID: 92
		private static Delegate cb_onScroll_Landroid_widget_AbsListView_III;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;

		// Token: 0x020001A6 RID: 422
		[Register("com/bumptech/glide/ListPreloader$PreloadModelProvider", "", "Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker")]
		[JavaTypeParameters(new string[]
		{
			"U"
		})]
		public interface IPreloadModelProvider : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001527 RID: 5415
			[Register("getPreloadItems", "(I)Ljava/util/List;", "GetGetPreloadItems_IHandler:Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker, Xamarin.Android.Glide")]
			IList GetPreloadItems(int p0);

			// Token: 0x06001528 RID: 5416
			[Register("getPreloadRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;", "GetGetPreloadRequestBuilder_Ljava_lang_Object_Handler:Bumptech.Glide.ListPreloader/IPreloadModelProviderInvoker, Xamarin.Android.Glide")]
			RequestBuilder GetPreloadRequestBuilder(Java.Lang.Object p0);
		}

		// Token: 0x020001A7 RID: 423
		[Register("com/bumptech/glide/ListPreloader$PreloadModelProvider", DoNotGenerateAcw = true)]
		internal class IPreloadModelProviderInvoker : Java.Lang.Object, ListPreloader.IPreloadModelProvider, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06001529 RID: 5417 RVA: 0x00042DF0 File Offset: 0x00040FF0
			private static IntPtr java_class_ref
			{
				get
				{
					return ListPreloader.IPreloadModelProviderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x0600152A RID: 5418 RVA: 0x00042E14 File Offset: 0x00041014
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ListPreloader.IPreloadModelProviderInvoker._members;
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x0600152B RID: 5419 RVA: 0x00042E1B File Offset: 0x0004101B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x0600152C RID: 5420 RVA: 0x00042E23 File Offset: 0x00041023
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ListPreloader.IPreloadModelProviderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600152D RID: 5421 RVA: 0x00042E2F File Offset: 0x0004102F
			public static ListPreloader.IPreloadModelProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ListPreloader.IPreloadModelProvider>(handle, transfer);
			}

			// Token: 0x0600152E RID: 5422 RVA: 0x00042E38 File Offset: 0x00041038
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ListPreloader.IPreloadModelProviderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.ListPreloader.PreloadModelProvider'.");
				}
				return handle;
			}

			// Token: 0x0600152F RID: 5423 RVA: 0x00042E63 File Offset: 0x00041063
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001530 RID: 5424 RVA: 0x00042E94 File Offset: 0x00041094
			public IPreloadModelProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ListPreloader.IPreloadModelProviderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001531 RID: 5425 RVA: 0x00042ECC File Offset: 0x000410CC
			private static Delegate GetGetPreloadItems_IHandler()
			{
				if (ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadItems_I == null)
				{
					ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadItems_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ListPreloader.IPreloadModelProviderInvoker.n_GetPreloadItems_I));
				}
				return ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadItems_I;
			}

			// Token: 0x06001532 RID: 5426 RVA: 0x00042EF0 File Offset: 0x000410F0
			private static IntPtr n_GetPreloadItems_I(IntPtr jnienv, IntPtr native__this, int p0)
			{
				return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<ListPreloader.IPreloadModelProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetPreloadItems(p0));
			}

			// Token: 0x06001533 RID: 5427 RVA: 0x00042F08 File Offset: 0x00041108
			public unsafe IList GetPreloadItems(int p0)
			{
				if (this.id_getPreloadItems_I == IntPtr.Zero)
				{
					this.id_getPreloadItems_I = JNIEnv.GetMethodID(this.class_ref, "getPreloadItems", "(I)Ljava/util/List;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				return JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getPreloadItems_I, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06001534 RID: 5428 RVA: 0x00042F72 File Offset: 0x00041172
			private static Delegate GetGetPreloadRequestBuilder_Ljava_lang_Object_Handler()
			{
				if (ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadRequestBuilder_Ljava_lang_Object_ == null)
				{
					ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadRequestBuilder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ListPreloader.IPreloadModelProviderInvoker.n_GetPreloadRequestBuilder_Ljava_lang_Object_));
				}
				return ListPreloader.IPreloadModelProviderInvoker.cb_getPreloadRequestBuilder_Ljava_lang_Object_;
			}

			// Token: 0x06001535 RID: 5429 RVA: 0x00042F98 File Offset: 0x00041198
			private static IntPtr n_GetPreloadRequestBuilder_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ListPreloader.IPreloadModelProvider @object = Java.Lang.Object.GetObject<ListPreloader.IPreloadModelProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.GetPreloadRequestBuilder(object2));
			}

			// Token: 0x06001536 RID: 5430 RVA: 0x00042FC0 File Offset: 0x000411C0
			public unsafe RequestBuilder GetPreloadRequestBuilder(Java.Lang.Object p0)
			{
				if (this.id_getPreloadRequestBuilder_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_getPreloadRequestBuilder_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "getPreloadRequestBuilder", "(Ljava/lang/Object;)Lcom/bumptech/glide/RequestBuilder;");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				RequestBuilder @object = Java.Lang.Object.GetObject<RequestBuilder>(JNIEnv.CallObjectMethod(base.Handle, this.id_getPreloadRequestBuilder_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x04000505 RID: 1285
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/ListPreloader$PreloadModelProvider", typeof(ListPreloader.IPreloadModelProviderInvoker));

			// Token: 0x04000506 RID: 1286
			private IntPtr class_ref;

			// Token: 0x04000507 RID: 1287
			private static Delegate cb_getPreloadItems_I;

			// Token: 0x04000508 RID: 1288
			private IntPtr id_getPreloadItems_I;

			// Token: 0x04000509 RID: 1289
			private static Delegate cb_getPreloadRequestBuilder_Ljava_lang_Object_;

			// Token: 0x0400050A RID: 1290
			private IntPtr id_getPreloadRequestBuilder_Ljava_lang_Object_;
		}

		// Token: 0x020001A8 RID: 424
		[Register("com/bumptech/glide/ListPreloader$PreloadSizeProvider", "", "Bumptech.Glide.ListPreloader/IPreloadSizeProviderInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IPreloadSizeProvider : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001538 RID: 5432
			[Register("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler:Bumptech.Glide.ListPreloader/IPreloadSizeProviderInvoker, Xamarin.Android.Glide")]
			int[] GetPreloadSize(Java.Lang.Object p0, int p1, int p2);
		}

		// Token: 0x020001A9 RID: 425
		[Register("com/bumptech/glide/ListPreloader$PreloadSizeProvider", DoNotGenerateAcw = true)]
		internal class IPreloadSizeProviderInvoker : Java.Lang.Object, ListPreloader.IPreloadSizeProvider, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06001539 RID: 5433 RVA: 0x00043054 File Offset: 0x00041254
			private static IntPtr java_class_ref
			{
				get
				{
					return ListPreloader.IPreloadSizeProviderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x0600153A RID: 5434 RVA: 0x00043078 File Offset: 0x00041278
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ListPreloader.IPreloadSizeProviderInvoker._members;
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x0600153B RID: 5435 RVA: 0x0004307F File Offset: 0x0004127F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x0600153C RID: 5436 RVA: 0x00043087 File Offset: 0x00041287
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ListPreloader.IPreloadSizeProviderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600153D RID: 5437 RVA: 0x00043093 File Offset: 0x00041293
			public static ListPreloader.IPreloadSizeProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ListPreloader.IPreloadSizeProvider>(handle, transfer);
			}

			// Token: 0x0600153E RID: 5438 RVA: 0x0004309C File Offset: 0x0004129C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ListPreloader.IPreloadSizeProviderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.ListPreloader.PreloadSizeProvider'.");
				}
				return handle;
			}

			// Token: 0x0600153F RID: 5439 RVA: 0x000430C7 File Offset: 0x000412C7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001540 RID: 5440 RVA: 0x000430F8 File Offset: 0x000412F8
			public IPreloadSizeProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ListPreloader.IPreloadSizeProviderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001541 RID: 5441 RVA: 0x00043130 File Offset: 0x00041330
			private static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler()
			{
				if (ListPreloader.IPreloadSizeProviderInvoker.cb_getPreloadSize_Ljava_lang_Object_II == null)
				{
					ListPreloader.IPreloadSizeProviderInvoker.cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(ListPreloader.IPreloadSizeProviderInvoker.n_GetPreloadSize_Ljava_lang_Object_II));
				}
				return ListPreloader.IPreloadSizeProviderInvoker.cb_getPreloadSize_Ljava_lang_Object_II;
			}

			// Token: 0x06001542 RID: 5442 RVA: 0x00043154 File Offset: 0x00041354
			private static IntPtr n_GetPreloadSize_Ljava_lang_Object_II(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				ListPreloader.IPreloadSizeProvider @object = Java.Lang.Object.GetObject<ListPreloader.IPreloadSizeProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray(@object.GetPreloadSize(object2, p1, p2));
			}

			// Token: 0x06001543 RID: 5443 RVA: 0x00043180 File Offset: 0x00041380
			public unsafe int[] GetPreloadSize(Java.Lang.Object p0, int p1, int p2)
			{
				if (this.id_getPreloadSize_Ljava_lang_Object_II == IntPtr.Zero)
				{
					this.id_getPreloadSize_Ljava_lang_Object_II = JNIEnv.GetMethodID(this.class_ref, "getPreloadSize", "(Ljava/lang/Object;II)[I");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				ptr[1] = new JValue(p1);
				ptr[2] = new JValue(p2);
				int[] result = (int[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getPreloadSize_Ljava_lang_Object_II, ptr), JniHandleOwnership.TransferLocalRef, typeof(int));
				JNIEnv.DeleteLocalRef(intPtr);
				return result;
			}

			// Token: 0x0400050B RID: 1291
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/ListPreloader$PreloadSizeProvider", typeof(ListPreloader.IPreloadSizeProviderInvoker));

			// Token: 0x0400050C RID: 1292
			private IntPtr class_ref;

			// Token: 0x0400050D RID: 1293
			private static Delegate cb_getPreloadSize_Ljava_lang_Object_II;

			// Token: 0x0400050E RID: 1294
			private IntPtr id_getPreloadSize_Ljava_lang_Object_II;
		}
	}
}
