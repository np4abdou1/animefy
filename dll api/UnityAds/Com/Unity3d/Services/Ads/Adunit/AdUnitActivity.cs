using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000228 RID: 552
	[Register("com/unity3d/services/ads/adunit/AdUnitActivity", DoNotGenerateAcw = true)]
	public class AdUnitActivity : Activity
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0004C988 File Offset: 0x0004AB88
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0004C9AC File Offset: 0x0004ABAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitActivity._members;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0004C9B4 File Offset: 0x0004ABB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0004C9D8 File Offset: 0x0004ABD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		protected AdUnitActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0004C9F0 File Offset: 0x0004ABF0
		[Register(".ctor", "()V", "")]
		public AdUnitActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdUnitActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0004CA5E File Offset: 0x0004AC5E
		private static Delegate GetGetLayoutHandler()
		{
			if (AdUnitActivity.cb_getLayout == null)
			{
				AdUnitActivity.cb_getLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdUnitActivity.n_GetLayout));
			}
			return AdUnitActivity.cb_getLayout;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0004CA82 File Offset: 0x0004AC82
		private static IntPtr n_GetLayout(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Layout);
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0004CA98 File Offset: 0x0004AC98
		public virtual AdUnitRelativeLayout Layout
		{
			[Register("getLayout", "()Lcom/unity3d/services/ads/adunit/AdUnitRelativeLayout;", "GetGetLayoutHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdUnitRelativeLayout>(AdUnitActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getLayout.()Lcom/unity3d/services/ads/adunit/AdUnitRelativeLayout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0004CACA File Offset: 0x0004ACCA
		private static Delegate GetCreateLayoutHandler()
		{
			if (AdUnitActivity.cb_createLayout == null)
			{
				AdUnitActivity.cb_createLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdUnitActivity.n_CreateLayout));
			}
			return AdUnitActivity.cb_createLayout;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0004CAEE File Offset: 0x0004ACEE
		private static void n_CreateLayout(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateLayout();
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0004CAFD File Offset: 0x0004ACFD
		[Register("createLayout", "()V", "GetCreateLayoutHandler")]
		protected virtual void CreateLayout()
		{
			AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("createLayout.()V", this, null);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0004CB16 File Offset: 0x0004AD16
		private static Delegate GetGetViewFrame_Ljava_lang_String_Handler()
		{
			if (AdUnitActivity.cb_getViewFrame_Ljava_lang_String_ == null)
			{
				AdUnitActivity.cb_getViewFrame_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdUnitActivity.n_GetViewFrame_Ljava_lang_String_));
			}
			return AdUnitActivity.cb_getViewFrame_Ljava_lang_String_;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0004CB3C File Offset: 0x0004AD3C
		private static IntPtr n_GetViewFrame_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_view, JniHandleOwnership.DoNotTransfer);
			return JavaDictionary<string, Integer>.ToLocalJniHandle(@object.GetViewFrame(@string));
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0004CB64 File Offset: 0x0004AD64
		[Register("getViewFrame", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetViewFrame_Ljava_lang_String_Handler")]
		public unsafe virtual IDictionary<string, Integer> GetViewFrame(string view)
		{
			IntPtr intPtr = JNIEnv.NewString(view);
			IDictionary<string, Integer> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary<string, Integer>.FromJniHandle(AdUnitActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getViewFrame.(Ljava/lang/String;)Ljava/util/Map;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004CBD0 File Offset: 0x0004ADD0
		private static Delegate GetGetViewHandler_Ljava_lang_String_Handler()
		{
			if (AdUnitActivity.cb_getViewHandler_Ljava_lang_String_ == null)
			{
				AdUnitActivity.cb_getViewHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdUnitActivity.n_GetViewHandler_Ljava_lang_String_));
			}
			return AdUnitActivity.cb_getViewHandler_Ljava_lang_String_;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0004CBF4 File Offset: 0x0004ADF4
		private static IntPtr n_GetViewHandler_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetViewHandler(@string));
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0004CC1C File Offset: 0x0004AE1C
		[Register("getViewHandler", "(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/IAdUnitViewHandler;", "GetGetViewHandler_Ljava_lang_String_Handler")]
		public unsafe virtual IAdUnitViewHandler GetViewHandler(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IAdUnitViewHandler @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(AdUnitActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getViewHandler.(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/IAdUnitViewHandler;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0004CC88 File Offset: 0x0004AE88
		private static Delegate GetGetViewsHandler()
		{
			if (AdUnitActivity.cb_getViews == null)
			{
				AdUnitActivity.cb_getViews = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdUnitActivity.n_GetViews));
			}
			return AdUnitActivity.cb_getViews;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0004CCAC File Offset: 0x0004AEAC
		private static IntPtr n_GetViews(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetViews());
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0004CCC0 File Offset: 0x0004AEC0
		[Register("getViews", "()[Ljava/lang/String;", "GetGetViewsHandler")]
		public virtual string[] GetViews()
		{
			return (string[])JNIEnv.GetArray(AdUnitActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getViews.()[Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0004CD01 File Offset: 0x0004AF01
		private static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler()
		{
			if (AdUnitActivity.cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
			{
				AdUnitActivity.cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdUnitActivity.n_OnSaveInstanceState_Landroid_os_Bundle_));
			}
			return AdUnitActivity.cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0004CD28 File Offset: 0x0004AF28
		private static void n_OnSaveInstanceState_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.OnSaveInstanceState(object2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0004CD4C File Offset: 0x0004AF4C
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public new unsafe virtual void OnSaveInstanceState(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		private static Delegate GetSetKeepScreenOn_ZHandler()
		{
			if (AdUnitActivity.cb_setKeepScreenOn_Z == null)
			{
				AdUnitActivity.cb_setKeepScreenOn_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(AdUnitActivity.n_SetKeepScreenOn_Z));
			}
			return AdUnitActivity.cb_setKeepScreenOn_Z;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		private static bool n_SetKeepScreenOn_Z(IntPtr jnienv, IntPtr native__this, bool keepScreenOn)
		{
			return Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetKeepScreenOn(keepScreenOn);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0004CDE4 File Offset: 0x0004AFE4
		[Register("setKeepScreenOn", "(Z)Z", "GetSetKeepScreenOn_ZHandler")]
		public unsafe virtual bool SetKeepScreenOn(bool keepScreenOn)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(keepScreenOn);
			return AdUnitActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("setKeepScreenOn.(Z)Z", this, ptr);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0004CE1F File Offset: 0x0004B01F
		private static Delegate GetSetKeyEventList_Ljava_util_ArrayList_Handler()
		{
			if (AdUnitActivity.cb_setKeyEventList_Ljava_util_ArrayList_ == null)
			{
				AdUnitActivity.cb_setKeyEventList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdUnitActivity.n_SetKeyEventList_Ljava_util_ArrayList_));
			}
			return AdUnitActivity.cb_setKeyEventList_Ljava_util_ArrayList_;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0004CE44 File Offset: 0x0004B044
		private static void n_SetKeyEventList_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_keyevents)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<Integer> keyEventList = JavaList<Integer>.FromJniHandle(native_keyevents, JniHandleOwnership.DoNotTransfer);
			@object.SetKeyEventList(keyEventList);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0004CE68 File Offset: 0x0004B068
		[Register("setKeyEventList", "(Ljava/util/ArrayList;)V", "GetSetKeyEventList_Ljava_util_ArrayList_Handler")]
		public unsafe virtual void SetKeyEventList(IList<Integer> keyevents)
		{
			IntPtr intPtr = JavaList<Integer>.ToLocalJniHandle(keyevents);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setKeyEventList.(Ljava/util/ArrayList;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(keyevents);
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0004CECC File Offset: 0x0004B0CC
		private static Delegate GetSetLayoutInDisplayCutoutMode_IHandler()
		{
			if (AdUnitActivity.cb_setLayoutInDisplayCutoutMode_I == null)
			{
				AdUnitActivity.cb_setLayoutInDisplayCutoutMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AdUnitActivity.n_SetLayoutInDisplayCutoutMode_I));
			}
			return AdUnitActivity.cb_setLayoutInDisplayCutoutMode_I;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		private static void n_SetLayoutInDisplayCutoutMode_I(IntPtr jnienv, IntPtr native__this, int flags)
		{
			Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLayoutInDisplayCutoutMode(flags);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0004CF00 File Offset: 0x0004B100
		[Register("setLayoutInDisplayCutoutMode", "(I)V", "GetSetLayoutInDisplayCutoutMode_IHandler")]
		public unsafe virtual void SetLayoutInDisplayCutoutMode(int flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flags);
			AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setLayoutInDisplayCutoutMode.(I)V", this, ptr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0004CF3B File Offset: 0x0004B13B
		private static Delegate GetSetOrientation_IHandler()
		{
			if (AdUnitActivity.cb_setOrientation_I == null)
			{
				AdUnitActivity.cb_setOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AdUnitActivity.n_SetOrientation_I));
			}
			return AdUnitActivity.cb_setOrientation_I;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0004CF5F File Offset: 0x0004B15F
		private static void n_SetOrientation_I(IntPtr jnienv, IntPtr native__this, int orientation)
		{
			Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOrientation(orientation);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0004CF70 File Offset: 0x0004B170
		[Register("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
		public unsafe virtual void SetOrientation(int orientation)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(orientation);
			AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setOrientation.(I)V", this, ptr);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0004CFAB File Offset: 0x0004B1AB
		private static Delegate GetSetSystemUiVisibility_IHandler()
		{
			if (AdUnitActivity.cb_setSystemUiVisibility_I == null)
			{
				AdUnitActivity.cb_setSystemUiVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AdUnitActivity.n_SetSystemUiVisibility_I));
			}
			return AdUnitActivity.cb_setSystemUiVisibility_I;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004CFCF File Offset: 0x0004B1CF
		private static bool n_SetSystemUiVisibility_I(IntPtr jnienv, IntPtr native__this, int flags)
		{
			return Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSystemUiVisibility(flags);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
		[Register("setSystemUiVisibility", "(I)Z", "GetSetSystemUiVisibility_IHandler")]
		public unsafe virtual bool SetSystemUiVisibility(int flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flags);
			return AdUnitActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("setSystemUiVisibility.(I)Z", this, ptr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0004D01B File Offset: 0x0004B21B
		private static Delegate GetSetViewFrame_Ljava_lang_String_IIIIHandler()
		{
			if (AdUnitActivity.cb_setViewFrame_Ljava_lang_String_IIII == null)
			{
				AdUnitActivity.cb_setViewFrame_Ljava_lang_String_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(AdUnitActivity.n_SetViewFrame_Ljava_lang_String_IIII));
			}
			return AdUnitActivity.cb_setViewFrame_Ljava_lang_String_IIII;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0004D040 File Offset: 0x0004B240
		private static void n_SetViewFrame_Ljava_lang_String_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int x, int y, int width, int height)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetViewFrame(@string, x, y, width, height);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0004D06C File Offset: 0x0004B26C
		[Register("setViewFrame", "(Ljava/lang/String;IIII)V", "GetSetViewFrame_Ljava_lang_String_IIIIHandler")]
		public unsafe virtual void SetViewFrame(string view, int x, int y, int width, int height)
		{
			IntPtr intPtr = JNIEnv.NewString(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(x);
				ptr[2] = new JniArgumentValue(y);
				ptr[3] = new JniArgumentValue(width);
				ptr[4] = new JniArgumentValue(height);
				AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setViewFrame.(Ljava/lang/String;IIII)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0004D120 File Offset: 0x0004B320
		private static Delegate GetSetViews_arrayLjava_lang_String_Handler()
		{
			if (AdUnitActivity.cb_setViews_arrayLjava_lang_String_ == null)
			{
				AdUnitActivity.cb_setViews_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdUnitActivity.n_SetViews_arrayLjava_lang_String_));
			}
			return AdUnitActivity.cb_setViews_arrayLjava_lang_String_;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0004D144 File Offset: 0x0004B344
		private static void n_SetViews_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_views)
		{
			AdUnitActivity @object = Java.Lang.Object.GetObject<AdUnitActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_views, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.SetViews(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_views);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0004D180 File Offset: 0x0004B380
		[Register("setViews", "([Ljava/lang/String;)V", "GetSetViews_arrayLjava_lang_String_Handler")]
		public unsafe virtual void SetViews(string[] views)
		{
			IntPtr intPtr = JNIEnv.NewArray(views);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdUnitActivity._members.InstanceMethods.InvokeVirtualVoidMethod("setViews.([Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				if (views != null)
				{
					JNIEnv.CopyArray(intPtr, views);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(views);
			}
		}

		// Token: 0x0400065F RID: 1631
		[Register("EXTRA_ACTIVITY_ID")]
		public const string ExtraActivityId = "activityId";

		// Token: 0x04000660 RID: 1632
		[Register("EXTRA_DISPLAY_CUTOUT_MODE")]
		public const string ExtraDisplayCutoutMode = "displayCutoutMode";

		// Token: 0x04000661 RID: 1633
		[Register("EXTRA_KEEP_SCREEN_ON")]
		public const string ExtraKeepScreenOn = "keepScreenOn";

		// Token: 0x04000662 RID: 1634
		[Register("EXTRA_KEY_EVENT_LIST")]
		public const string ExtraKeyEventList = "keyEvents";

		// Token: 0x04000663 RID: 1635
		[Register("EXTRA_ORIENTATION")]
		public const string ExtraOrientation = "orientation";

		// Token: 0x04000664 RID: 1636
		[Register("EXTRA_SYSTEM_UI_VISIBILITY")]
		public const string ExtraSystemUiVisibility = "systemUiVisibility";

		// Token: 0x04000665 RID: 1637
		[Register("EXTRA_VIEWS")]
		public const string ExtraViews = "views";

		// Token: 0x04000666 RID: 1638
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitActivity", typeof(AdUnitActivity));

		// Token: 0x04000667 RID: 1639
		private static Delegate cb_getLayout;

		// Token: 0x04000668 RID: 1640
		private static Delegate cb_createLayout;

		// Token: 0x04000669 RID: 1641
		private static Delegate cb_getViewFrame_Ljava_lang_String_;

		// Token: 0x0400066A RID: 1642
		private static Delegate cb_getViewHandler_Ljava_lang_String_;

		// Token: 0x0400066B RID: 1643
		private static Delegate cb_getViews;

		// Token: 0x0400066C RID: 1644
		private static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;

		// Token: 0x0400066D RID: 1645
		private static Delegate cb_setKeepScreenOn_Z;

		// Token: 0x0400066E RID: 1646
		private static Delegate cb_setKeyEventList_Ljava_util_ArrayList_;

		// Token: 0x0400066F RID: 1647
		private static Delegate cb_setLayoutInDisplayCutoutMode_I;

		// Token: 0x04000670 RID: 1648
		private static Delegate cb_setOrientation_I;

		// Token: 0x04000671 RID: 1649
		private static Delegate cb_setSystemUiVisibility_I;

		// Token: 0x04000672 RID: 1650
		private static Delegate cb_setViewFrame_Ljava_lang_String_IIII;

		// Token: 0x04000673 RID: 1651
		private static Delegate cb_setViews_arrayLjava_lang_String_;
	}
}
