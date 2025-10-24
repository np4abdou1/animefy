using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000081 RID: 129
	[Register("com/bumptech/glide/manager/RequestManagerRetriever", DoNotGenerateAcw = true)]
	public class RequestManagerRetriever : Java.Lang.Object, Handler.ICallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000118C4 File Offset: 0x0000FAC4
		internal static IntPtr class_ref
		{
			get
			{
				return RequestManagerRetriever._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000118E8 File Offset: 0x0000FAE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestManagerRetriever._members;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000118F0 File Offset: 0x0000FAF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestManagerRetriever._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00011914 File Offset: 0x0000FB14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestManagerRetriever._members.ManagedPeerType;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00011920 File Offset: 0x0000FB20
		protected RequestManagerRetriever(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001192C File Offset: 0x0000FB2C
		[Register(".ctor", "(Lcom/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory;Lcom/bumptech/glide/GlideExperiments;)V", "")]
		public unsafe RequestManagerRetriever(RequestManagerRetriever.IRequestManagerFactory factory, GlideExperiments experiments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				ptr[1] = new JniArgumentValue((experiments == null) ? IntPtr.Zero : experiments.Handle);
				base.SetHandle(RequestManagerRetriever._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory;Lcom/bumptech/glide/GlideExperiments;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RequestManagerRetriever._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory;Lcom/bumptech/glide/GlideExperiments;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(factory);
				GC.KeepAlive(experiments);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00011A08 File Offset: 0x0000FC08
		[Obsolete]
		private static Delegate GetGet_Landroid_app_Activity_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroid_app_Activity_ == null)
			{
				RequestManagerRetriever.cb_get_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroid_app_Activity_));
			}
			return RequestManagerRetriever.cb_get_Landroid_app_Activity_;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00011A2C File Offset: 0x0000FC2C
		[Obsolete]
		private static IntPtr n_Get_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00011A54 File Offset: 0x0000FC54
		[Obsolete("deprecated")]
		[Register("get", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_app_Activity_Handler")]
		public unsafe virtual RequestManager Get(Activity activity)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		[Obsolete]
		private static Delegate GetGet_Landroid_app_Fragment_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroid_app_Fragment_ == null)
			{
				RequestManagerRetriever.cb_get_Landroid_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroid_app_Fragment_));
			}
			return RequestManagerRetriever.cb_get_Landroid_app_Fragment_;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00011AEC File Offset: 0x0000FCEC
		[Obsolete]
		private static IntPtr n_Get_Landroid_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.App.Fragment object2 = Java.Lang.Object.GetObject<Android.App.Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00011B14 File Offset: 0x0000FD14
		[Obsolete("deprecated")]
		[Register("get", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_app_Fragment_Handler")]
		public unsafe virtual RequestManager Get(Android.App.Fragment fragment)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00011B88 File Offset: 0x0000FD88
		private static Delegate GetGet_Landroid_content_Context_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroid_content_Context_ == null)
			{
				RequestManagerRetriever.cb_get_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroid_content_Context_));
			}
			return RequestManagerRetriever.cb_get_Landroid_content_Context_;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00011BAC File Offset: 0x0000FDAC
		private static IntPtr n_Get_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00011BD4 File Offset: 0x0000FDD4
		[Register("get", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_content_Context_Handler")]
		public unsafe virtual RequestManager Get(Context context)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00011C48 File Offset: 0x0000FE48
		private static Delegate GetGet_Landroid_view_View_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroid_view_View_ == null)
			{
				RequestManagerRetriever.cb_get_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroid_view_View_));
			}
			return RequestManagerRetriever.cb_get_Landroid_view_View_;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00011C6C File Offset: 0x0000FE6C
		private static IntPtr n_Get_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00011C94 File Offset: 0x0000FE94
		[Register("get", "(Landroid/view/View;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroid_view_View_Handler")]
		public unsafe virtual RequestManager Get(View view)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroid/view/View;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00011D08 File Offset: 0x0000FF08
		private static Delegate GetGet_Landroidx_fragment_app_Fragment_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroidx_fragment_app_Fragment_ == null)
			{
				RequestManagerRetriever.cb_get_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroidx_fragment_app_Fragment_));
			}
			return RequestManagerRetriever.cb_get_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00011D2C File Offset: 0x0000FF2C
		private static IntPtr n_Get_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.Fragment.App.Fragment object2 = Java.Lang.Object.GetObject<AndroidX.Fragment.App.Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00011D54 File Offset: 0x0000FF54
		[Register("get", "(Landroidx/fragment/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual RequestManager Get(AndroidX.Fragment.App.Fragment fragment)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroidx/fragment/app/Fragment;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		private static Delegate GetGet_Landroidx_fragment_app_FragmentActivity_Handler()
		{
			if (RequestManagerRetriever.cb_get_Landroidx_fragment_app_FragmentActivity_ == null)
			{
				RequestManagerRetriever.cb_get_Landroidx_fragment_app_FragmentActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestManagerRetriever.n_Get_Landroidx_fragment_app_FragmentActivity_));
			}
			return RequestManagerRetriever.cb_get_Landroidx_fragment_app_FragmentActivity_;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00011DEC File Offset: 0x0000FFEC
		private static IntPtr n_Get_Landroidx_fragment_app_FragmentActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentActivity object2 = Java.Lang.Object.GetObject<FragmentActivity>(native_activity, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00011E14 File Offset: 0x00010014
		[Register("get", "(Landroidx/fragment/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", "GetGet_Landroidx_fragment_app_FragmentActivity_Handler")]
		public unsafe virtual RequestManager Get(FragmentActivity activity)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(RequestManagerRetriever._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Landroidx/fragment/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00011E88 File Offset: 0x00010088
		private static Delegate GetHandleMessage_Landroid_os_Message_Handler()
		{
			if (RequestManagerRetriever.cb_handleMessage_Landroid_os_Message_ == null)
			{
				RequestManagerRetriever.cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RequestManagerRetriever.n_HandleMessage_Landroid_os_Message_));
			}
			return RequestManagerRetriever.cb_handleMessage_Landroid_os_Message_;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00011EAC File Offset: 0x000100AC
		private static bool n_HandleMessage_Landroid_os_Message_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			RequestManagerRetriever @object = Java.Lang.Object.GetObject<RequestManagerRetriever>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Message object2 = Java.Lang.Object.GetObject<Message>(native_message, JniHandleOwnership.DoNotTransfer);
			return @object.HandleMessage(object2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00011ED0 File Offset: 0x000100D0
		[Register("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public unsafe virtual bool HandleMessage(Message message)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((message == null) ? IntPtr.Zero : message.Handle);
				result = RequestManagerRetriever._members.InstanceMethods.InvokeVirtualBooleanMethod("handleMessage.(Landroid/os/Message;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(message);
			}
			return result;
		}

		// Token: 0x04000139 RID: 313
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/RequestManagerRetriever", typeof(RequestManagerRetriever));

		// Token: 0x0400013A RID: 314
		private static Delegate cb_get_Landroid_app_Activity_;

		// Token: 0x0400013B RID: 315
		private static Delegate cb_get_Landroid_app_Fragment_;

		// Token: 0x0400013C RID: 316
		private static Delegate cb_get_Landroid_content_Context_;

		// Token: 0x0400013D RID: 317
		private static Delegate cb_get_Landroid_view_View_;

		// Token: 0x0400013E RID: 318
		private static Delegate cb_get_Landroidx_fragment_app_Fragment_;

		// Token: 0x0400013F RID: 319
		private static Delegate cb_get_Landroidx_fragment_app_FragmentActivity_;

		// Token: 0x04000140 RID: 320
		private static Delegate cb_handleMessage_Landroid_os_Message_;

		// Token: 0x020001BB RID: 443
		[Register("com/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory", "", "Bumptech.Glide.Manager.RequestManagerRetriever/IRequestManagerFactoryInvoker")]
		public interface IRequestManagerFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060015A2 RID: 5538
			[Register("build", "(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", "GetBuild_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_Handler:Bumptech.Glide.Manager.RequestManagerRetriever/IRequestManagerFactoryInvoker, Xamarin.Android.Glide")]
			RequestManager Build(Glide p0, ILifecycle p1, IRequestManagerTreeNode p2, Context p3);
		}

		// Token: 0x020001BC RID: 444
		[Register("com/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory", DoNotGenerateAcw = true)]
		internal class IRequestManagerFactoryInvoker : Java.Lang.Object, RequestManagerRetriever.IRequestManagerFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x060015A3 RID: 5539 RVA: 0x0004409C File Offset: 0x0004229C
			private static IntPtr java_class_ref
			{
				get
				{
					return RequestManagerRetriever.IRequestManagerFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000440C0 File Offset: 0x000422C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RequestManagerRetriever.IRequestManagerFactoryInvoker._members;
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000440C7 File Offset: 0x000422C7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000440CF File Offset: 0x000422CF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RequestManagerRetriever.IRequestManagerFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060015A7 RID: 5543 RVA: 0x000440DB File Offset: 0x000422DB
			public static RequestManagerRetriever.IRequestManagerFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<RequestManagerRetriever.IRequestManagerFactory>(handle, transfer);
			}

			// Token: 0x060015A8 RID: 5544 RVA: 0x000440E4 File Offset: 0x000422E4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, RequestManagerRetriever.IRequestManagerFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.RequestManagerRetriever.RequestManagerFactory'.");
				}
				return handle;
			}

			// Token: 0x060015A9 RID: 5545 RVA: 0x0004410F File Offset: 0x0004230F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060015AA RID: 5546 RVA: 0x00044140 File Offset: 0x00042340
			public IRequestManagerFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RequestManagerRetriever.IRequestManagerFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060015AB RID: 5547 RVA: 0x00044178 File Offset: 0x00042378
			private static Delegate GetBuild_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_Handler()
			{
				if (RequestManagerRetriever.IRequestManagerFactoryInvoker.cb_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_ == null)
				{
					RequestManagerRetriever.IRequestManagerFactoryInvoker.cb_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(RequestManagerRetriever.IRequestManagerFactoryInvoker.n_Build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_));
				}
				return RequestManagerRetriever.IRequestManagerFactoryInvoker.cb_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_;
			}

			// Token: 0x060015AC RID: 5548 RVA: 0x0004419C File Offset: 0x0004239C
			private static IntPtr n_Build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				RequestManagerRetriever.IRequestManagerFactory @object = Java.Lang.Object.GetObject<RequestManagerRetriever.IRequestManagerFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Glide object2 = Java.Lang.Object.GetObject<Glide>(native_p0, JniHandleOwnership.DoNotTransfer);
				ILifecycle object3 = Java.Lang.Object.GetObject<ILifecycle>(native_p1, JniHandleOwnership.DoNotTransfer);
				IRequestManagerTreeNode object4 = Java.Lang.Object.GetObject<IRequestManagerTreeNode>(native_p2, JniHandleOwnership.DoNotTransfer);
				Context object5 = Java.Lang.Object.GetObject<Context>(native_p3, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2, object3, object4, object5));
			}

			// Token: 0x060015AD RID: 5549 RVA: 0x000441E4 File Offset: 0x000423E4
			public unsafe RequestManager Build(Glide p0, ILifecycle p1, IRequestManagerTreeNode p2, Context p3)
			{
				if (this.id_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_ == IntPtr.Zero)
				{
					this.id_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_ = JNIEnv.GetMethodID(this.class_ref, "build", "(Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/manager/Lifecycle;Lcom/bumptech/glide/manager/RequestManagerTreeNode;Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				return Java.Lang.Object.GetObject<RequestManager>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000528 RID: 1320
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/RequestManagerRetriever$RequestManagerFactory", typeof(RequestManagerRetriever.IRequestManagerFactoryInvoker));

			// Token: 0x04000529 RID: 1321
			private IntPtr class_ref;

			// Token: 0x0400052A RID: 1322
			private static Delegate cb_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_;

			// Token: 0x0400052B RID: 1323
			private IntPtr id_build_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_manager_Lifecycle_Lcom_bumptech_glide_manager_RequestManagerTreeNode_Landroid_content_Context_;
		}
	}
}
