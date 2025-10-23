using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using AndroidX.Activity.Result;
using AndroidX.Activity.Result.Contract;
using AndroidX.Core.App;
using AndroidX.Lifecycle;
using AndroidX.Lifecycle.ViewModels;
using AndroidX.Loader.App;
using AndroidX.SavedState;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000029 RID: 41
	[Register("androidx/fragment/app/Fragment", DoNotGenerateAcw = true)]
	public class Fragment : Java.Lang.Object, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, View.IOnCreateContextMenuListener, IActivityResultCaller, IHasDefaultViewModelProviderFactory, ILifecycleOwner, IViewModelStoreOwner, ISavedStateRegistryOwner
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000354C File Offset: 0x0000174C
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000357C File Offset: 0x0000177C
		[Register("mPreviousWho")]
		public string MPreviousWho
		{
			get
			{
				return JNIEnv.GetString(Fragment._members.InstanceFields.GetObjectValue("mPreviousWho.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					Fragment._members.InstanceFields.SetValue("mPreviousWho.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000035C8 File Offset: 0x000017C8
		internal static IntPtr class_ref
		{
			get
			{
				return Fragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000035EC File Offset: 0x000017EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Fragment._members;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000035F4 File Offset: 0x000017F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Fragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003618 File Offset: 0x00001818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Fragment._members.ManagedPeerType;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003624 File Offset: 0x00001824
		protected Fragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003630 File Offset: 0x00001830
		[Register(".ctor", "()V", "")]
		public Fragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Fragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Fragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000036A0 File Offset: 0x000018A0
		[Register(".ctor", "(I)V", "")]
		public unsafe Fragment(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(Fragment._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Fragment._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003724 File Offset: 0x00001924
		public FragmentActivity Activity
		{
			[Register("getActivity", "()Landroidx/fragment/app/FragmentActivity;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentActivity>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getActivity.()Landroidx/fragment/app/FragmentActivity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003756 File Offset: 0x00001956
		private static Delegate GetGetAllowEnterTransitionOverlapHandler()
		{
			if (Fragment.cb_getAllowEnterTransitionOverlap == null)
			{
				Fragment.cb_getAllowEnterTransitionOverlap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Fragment.n_GetAllowEnterTransitionOverlap));
			}
			return Fragment.cb_getAllowEnterTransitionOverlap;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000377A File Offset: 0x0000197A
		private static bool n_GetAllowEnterTransitionOverlap(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowEnterTransitionOverlap;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003789 File Offset: 0x00001989
		private static Delegate GetSetAllowEnterTransitionOverlap_ZHandler()
		{
			if (Fragment.cb_setAllowEnterTransitionOverlap_Z == null)
			{
				Fragment.cb_setAllowEnterTransitionOverlap_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_SetAllowEnterTransitionOverlap_Z));
			}
			return Fragment.cb_setAllowEnterTransitionOverlap_Z;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000037AD File Offset: 0x000019AD
		private static void n_SetAllowEnterTransitionOverlap_Z(IntPtr jnienv, IntPtr native__this, bool allow)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowEnterTransitionOverlap = allow;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000037BD File Offset: 0x000019BD
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000037D8 File Offset: 0x000019D8
		public unsafe virtual bool AllowEnterTransitionOverlap
		{
			[Register("getAllowEnterTransitionOverlap", "()Z", "GetGetAllowEnterTransitionOverlapHandler")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("getAllowEnterTransitionOverlap.()Z", this, null);
			}
			[Register("setAllowEnterTransitionOverlap", "(Z)V", "GetSetAllowEnterTransitionOverlap_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setAllowEnterTransitionOverlap.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003813 File Offset: 0x00001A13
		private static Delegate GetGetAllowReturnTransitionOverlapHandler()
		{
			if (Fragment.cb_getAllowReturnTransitionOverlap == null)
			{
				Fragment.cb_getAllowReturnTransitionOverlap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Fragment.n_GetAllowReturnTransitionOverlap));
			}
			return Fragment.cb_getAllowReturnTransitionOverlap;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003837 File Offset: 0x00001A37
		private static bool n_GetAllowReturnTransitionOverlap(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowReturnTransitionOverlap;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003846 File Offset: 0x00001A46
		private static Delegate GetSetAllowReturnTransitionOverlap_ZHandler()
		{
			if (Fragment.cb_setAllowReturnTransitionOverlap_Z == null)
			{
				Fragment.cb_setAllowReturnTransitionOverlap_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_SetAllowReturnTransitionOverlap_Z));
			}
			return Fragment.cb_setAllowReturnTransitionOverlap_Z;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000386A File Offset: 0x00001A6A
		private static void n_SetAllowReturnTransitionOverlap_Z(IntPtr jnienv, IntPtr native__this, bool allow)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowReturnTransitionOverlap = allow;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000387A File Offset: 0x00001A7A
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00003894 File Offset: 0x00001A94
		public unsafe virtual bool AllowReturnTransitionOverlap
		{
			[Register("getAllowReturnTransitionOverlap", "()Z", "GetGetAllowReturnTransitionOverlapHandler")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("getAllowReturnTransitionOverlap.()Z", this, null);
			}
			[Register("setAllowReturnTransitionOverlap", "(Z)V", "GetSetAllowReturnTransitionOverlap_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setAllowReturnTransitionOverlap.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00003904 File Offset: 0x00001B04
		public unsafe Bundle Arguments
		{
			[Register("getArguments", "()Landroid/os/Bundle;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getArguments.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setArguments", "(Landroid/os/Bundle;)V", "GetSetArguments_Landroid_os_Bundle_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setArguments.(Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00003968 File Offset: 0x00001B68
		public FragmentManager ChildFragmentManager
		{
			[Register("getChildFragmentManager", "()Landroidx/fragment/app/FragmentManager;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentManager>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getChildFragmentManager.()Landroidx/fragment/app/FragmentManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000399A File Offset: 0x00001B9A
		private static Delegate GetGetContextHandler()
		{
			if (Fragment.cb_getContext == null)
			{
				Fragment.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetContext));
			}
			return Fragment.cb_getContext;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000039BE File Offset: 0x00001BBE
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000039D4 File Offset: 0x00001BD4
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003A06 File Offset: 0x00001C06
		private static Delegate GetGetDefaultViewModelCreationExtrasHandler()
		{
			if (Fragment.cb_getDefaultViewModelCreationExtras == null)
			{
				Fragment.cb_getDefaultViewModelCreationExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetDefaultViewModelCreationExtras));
			}
			return Fragment.cb_getDefaultViewModelCreationExtras;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003A2A File Offset: 0x00001C2A
		private static IntPtr n_GetDefaultViewModelCreationExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelCreationExtras);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00003A40 File Offset: 0x00001C40
		public virtual CreationExtras DefaultViewModelCreationExtras
		{
			[Register("getDefaultViewModelCreationExtras", "()Landroidx/lifecycle/viewmodel/CreationExtras;", "GetGetDefaultViewModelCreationExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CreationExtras>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultViewModelCreationExtras.()Landroidx/lifecycle/viewmodel/CreationExtras;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00003A72 File Offset: 0x00001C72
		private static Delegate GetGetDefaultViewModelProviderFactoryHandler()
		{
			if (Fragment.cb_getDefaultViewModelProviderFactory == null)
			{
				Fragment.cb_getDefaultViewModelProviderFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetDefaultViewModelProviderFactory));
			}
			return Fragment.cb_getDefaultViewModelProviderFactory;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00003A96 File Offset: 0x00001C96
		private static IntPtr n_GetDefaultViewModelProviderFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultViewModelProviderFactory);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00003AAC File Offset: 0x00001CAC
		public virtual ViewModelProvider.IFactory DefaultViewModelProviderFactory
		{
			[Register("getDefaultViewModelProviderFactory", "()Landroidx/lifecycle/ViewModelProvider$Factory;", "GetGetDefaultViewModelProviderFactoryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultViewModelProviderFactory.()Landroidx/lifecycle/ViewModelProvider$Factory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003ADE File Offset: 0x00001CDE
		private static Delegate GetGetEnterTransitionHandler()
		{
			if (Fragment.cb_getEnterTransition == null)
			{
				Fragment.cb_getEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetEnterTransition));
			}
			return Fragment.cb_getEnterTransition;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003B02 File Offset: 0x00001D02
		private static IntPtr n_GetEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnterTransition);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003B16 File Offset: 0x00001D16
		private static Delegate GetSetEnterTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setEnterTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setEnterTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetEnterTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setEnterTransition_Ljava_lang_Object_;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003B3C File Offset: 0x00001D3C
		private static void n_SetEnterTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.EnterTransition = object2;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00003B60 File Offset: 0x00001D60
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00003B94 File Offset: 0x00001D94
		public unsafe virtual Java.Lang.Object EnterTransition
		{
			[Register("getEnterTransition", "()Ljava/lang/Object;", "GetGetEnterTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getEnterTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setEnterTransition", "(Ljava/lang/Object;)V", "GetSetEnterTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setEnterTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003BF8 File Offset: 0x00001DF8
		private static Delegate GetGetExitTransitionHandler()
		{
			if (Fragment.cb_getExitTransition == null)
			{
				Fragment.cb_getExitTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetExitTransition));
			}
			return Fragment.cb_getExitTransition;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003C1C File Offset: 0x00001E1C
		private static IntPtr n_GetExitTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExitTransition);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003C30 File Offset: 0x00001E30
		private static Delegate GetSetExitTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setExitTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setExitTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetExitTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setExitTransition_Ljava_lang_Object_;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003C54 File Offset: 0x00001E54
		private static void n_SetExitTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.ExitTransition = object2;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00003CAC File Offset: 0x00001EAC
		public unsafe virtual Java.Lang.Object ExitTransition
		{
			[Register("getExitTransition", "()Ljava/lang/Object;", "GetGetExitTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getExitTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setExitTransition", "(Ljava/lang/Object;)V", "GetSetExitTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setExitTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00003D10 File Offset: 0x00001F10
		public FragmentManager FragmentManager
		{
			[Register("getFragmentManager", "()Landroidx/fragment/app/FragmentManager;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentManager>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFragmentManager.()Landroidx/fragment/app/FragmentManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00003D42 File Offset: 0x00001F42
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00003D5C File Offset: 0x00001F5C
		public unsafe bool HasOptionsMenu
		{
			[Register("hasOptionsMenu", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("hasOptionsMenu.()Z", this, null);
			}
			[Register("setHasOptionsMenu", "(Z)V", "GetSetHasOptionsMenu_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setHasOptionsMenu.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00003D98 File Offset: 0x00001F98
		public Java.Lang.Object Host
		{
			[Register("getHost", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getHost.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00003DCA File Offset: 0x00001FCA
		public int Id
		{
			[Register("getId", "()I", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualInt32Method("getId.()I", this, null);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public bool IsAdded
		{
			[Register("isAdded", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isAdded.()Z", this, null);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00003DFC File Offset: 0x00001FFC
		public bool IsDetached
		{
			[Register("isDetached", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isDetached.()Z", this, null);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00003E15 File Offset: 0x00002015
		public bool IsHidden
		{
			[Register("isHidden", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isHidden.()Z", this, null);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00003E2E File Offset: 0x0000202E
		public bool IsInLayout
		{
			[Register("isInLayout", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isInLayout.()Z", this, null);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00003E47 File Offset: 0x00002047
		public bool IsMenuVisible
		{
			[Register("isMenuVisible", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isMenuVisible.()Z", this, null);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00003E60 File Offset: 0x00002060
		public bool IsRemoving
		{
			[Register("isRemoving", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isRemoving.()Z", this, null);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00003E79 File Offset: 0x00002079
		public bool IsResumed
		{
			[Register("isResumed", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isResumed.()Z", this, null);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00003E92 File Offset: 0x00002092
		public bool IsStateSaved
		{
			[Register("isStateSaved", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isStateSaved.()Z", this, null);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00003EAB File Offset: 0x000020AB
		public bool IsVisible
		{
			[Register("isVisible", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isVisible.()Z", this, null);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00003EC4 File Offset: 0x000020C4
		public LayoutInflater LayoutInflater
		{
			[Register("getLayoutInflater", "()Landroid/view/LayoutInflater;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LayoutInflater>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getLayoutInflater.()Landroid/view/LayoutInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003EF6 File Offset: 0x000020F6
		private static Delegate GetGetLifecycleHandler()
		{
			if (Fragment.cb_getLifecycle == null)
			{
				Fragment.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetLifecycle));
			}
			return Fragment.cb_getLifecycle;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003F1A File Offset: 0x0000211A
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00003F30 File Offset: 0x00002130
		public virtual Lifecycle Lifecycle
		{
			[Register("getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "GetGetLifecycleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Lifecycle>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getLifecycle.()Landroidx/lifecycle/Lifecycle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003F62 File Offset: 0x00002162
		private static Delegate GetGetLoaderManagerHandler()
		{
			if (Fragment.cb_getLoaderManager == null)
			{
				Fragment.cb_getLoaderManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetLoaderManager));
			}
			return Fragment.cb_getLoaderManager;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003F86 File Offset: 0x00002186
		private static IntPtr n_GetLoaderManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoaderManager);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00003F9C File Offset: 0x0000219C
		public virtual LoaderManager LoaderManager
		{
			[Register("getLoaderManager", "()Landroidx/loader/app/LoaderManager;", "GetGetLoaderManagerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LoaderManager>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getLoaderManager.()Landroidx/loader/app/LoaderManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00003FD0 File Offset: 0x000021D0
		public Fragment ParentFragment
		{
			[Register("getParentFragment", "()Landroidx/fragment/app/Fragment;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Fragment>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getParentFragment.()Landroidx/fragment/app/Fragment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00004004 File Offset: 0x00002204
		public FragmentManager ParentFragmentManager
		{
			[Register("getParentFragmentManager", "()Landroidx/fragment/app/FragmentManager;", "")]
			get
			{
				return Java.Lang.Object.GetObject<FragmentManager>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getParentFragmentManager.()Landroidx/fragment/app/FragmentManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004036 File Offset: 0x00002236
		private static Delegate GetGetReenterTransitionHandler()
		{
			if (Fragment.cb_getReenterTransition == null)
			{
				Fragment.cb_getReenterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetReenterTransition));
			}
			return Fragment.cb_getReenterTransition;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000405A File Offset: 0x0000225A
		private static IntPtr n_GetReenterTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReenterTransition);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000406E File Offset: 0x0000226E
		private static Delegate GetSetReenterTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setReenterTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setReenterTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetReenterTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setReenterTransition_Ljava_lang_Object_;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004094 File Offset: 0x00002294
		private static void n_SetReenterTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.ReenterTransition = object2;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000040B8 File Offset: 0x000022B8
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000040EC File Offset: 0x000022EC
		public unsafe virtual Java.Lang.Object ReenterTransition
		{
			[Register("getReenterTransition", "()Ljava/lang/Object;", "GetGetReenterTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getReenterTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setReenterTransition", "(Ljava/lang/Object;)V", "GetSetReenterTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setReenterTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00004150 File Offset: 0x00002350
		public Resources Resources
		{
			[Register("getResources", "()Landroid/content/res/Resources;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Resources>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getResources.()Landroid/content/res/Resources;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00004182 File Offset: 0x00002382
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000419C File Offset: 0x0000239C
		public unsafe bool RetainInstance
		{
			[Register("getRetainInstance", "()Z", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getRetainInstance.()Z", this, null);
			}
			[Register("setRetainInstance", "(Z)V", "GetSetRetainInstance_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setRetainInstance.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000041D7 File Offset: 0x000023D7
		private static Delegate GetGetReturnTransitionHandler()
		{
			if (Fragment.cb_getReturnTransition == null)
			{
				Fragment.cb_getReturnTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetReturnTransition));
			}
			return Fragment.cb_getReturnTransition;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000041FB File Offset: 0x000023FB
		private static IntPtr n_GetReturnTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnTransition);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000420F File Offset: 0x0000240F
		private static Delegate GetSetReturnTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setReturnTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setReturnTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetReturnTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setReturnTransition_Ljava_lang_Object_;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004234 File Offset: 0x00002434
		private static void n_SetReturnTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.ReturnTransition = object2;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00004258 File Offset: 0x00002458
		// (set) Token: 0x0600014D RID: 333 RVA: 0x0000428C File Offset: 0x0000248C
		public unsafe virtual Java.Lang.Object ReturnTransition
		{
			[Register("getReturnTransition", "()Ljava/lang/Object;", "GetGetReturnTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getReturnTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setReturnTransition", "(Ljava/lang/Object;)V", "GetSetReturnTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setReturnTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000042F0 File Offset: 0x000024F0
		public SavedStateRegistry SavedStateRegistry
		{
			[Register("getSavedStateRegistry", "()Landroidx/savedstate/SavedStateRegistry;", "")]
			get
			{
				return Java.Lang.Object.GetObject<SavedStateRegistry>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSavedStateRegistry.()Landroidx/savedstate/SavedStateRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00004322 File Offset: 0x00002522
		private static Delegate GetGetSharedElementEnterTransitionHandler()
		{
			if (Fragment.cb_getSharedElementEnterTransition == null)
			{
				Fragment.cb_getSharedElementEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetSharedElementEnterTransition));
			}
			return Fragment.cb_getSharedElementEnterTransition;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00004346 File Offset: 0x00002546
		private static IntPtr n_GetSharedElementEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SharedElementEnterTransition);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000435A File Offset: 0x0000255A
		private static Delegate GetSetSharedElementEnterTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setSharedElementEnterTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setSharedElementEnterTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetSharedElementEnterTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setSharedElementEnterTransition_Ljava_lang_Object_;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00004380 File Offset: 0x00002580
		private static void n_SetSharedElementEnterTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.SharedElementEnterTransition = object2;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000043A4 File Offset: 0x000025A4
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000043D8 File Offset: 0x000025D8
		public unsafe virtual Java.Lang.Object SharedElementEnterTransition
		{
			[Register("getSharedElementEnterTransition", "()Ljava/lang/Object;", "GetGetSharedElementEnterTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getSharedElementEnterTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSharedElementEnterTransition", "(Ljava/lang/Object;)V", "GetSetSharedElementEnterTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setSharedElementEnterTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000443C File Offset: 0x0000263C
		private static Delegate GetGetSharedElementReturnTransitionHandler()
		{
			if (Fragment.cb_getSharedElementReturnTransition == null)
			{
				Fragment.cb_getSharedElementReturnTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetSharedElementReturnTransition));
			}
			return Fragment.cb_getSharedElementReturnTransition;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004460 File Offset: 0x00002660
		private static IntPtr n_GetSharedElementReturnTransition(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SharedElementReturnTransition);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004474 File Offset: 0x00002674
		private static Delegate GetSetSharedElementReturnTransition_Ljava_lang_Object_Handler()
		{
			if (Fragment.cb_setSharedElementReturnTransition_Ljava_lang_Object_ == null)
			{
				Fragment.cb_setSharedElementReturnTransition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetSharedElementReturnTransition_Ljava_lang_Object_));
			}
			return Fragment.cb_setSharedElementReturnTransition_Ljava_lang_Object_;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00004498 File Offset: 0x00002698
		private static void n_SetSharedElementReturnTransition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transition)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transition, JniHandleOwnership.DoNotTransfer);
			@object.SharedElementReturnTransition = object2;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000044BC File Offset: 0x000026BC
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000044F0 File Offset: 0x000026F0
		public unsafe virtual Java.Lang.Object SharedElementReturnTransition
		{
			[Register("getSharedElementReturnTransition", "()Ljava/lang/Object;", "GetGetSharedElementReturnTransitionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getSharedElementReturnTransition.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSharedElementReturnTransition", "(Ljava/lang/Object;)V", "GetSetSharedElementReturnTransition_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setSharedElementReturnTransition.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00004554 File Offset: 0x00002754
		public string Tag
		{
			[Register("getTag", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004588 File Offset: 0x00002788
		public Fragment TargetFragment
		{
			[Register("getTargetFragment", "()Landroidx/fragment/app/Fragment;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Fragment>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTargetFragment.()Landroidx/fragment/app/Fragment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000045BA File Offset: 0x000027BA
		public int TargetRequestCode
		{
			[Register("getTargetRequestCode", "()I", "")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeNonvirtualInt32Method("getTargetRequestCode.()I", this, null);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000045D3 File Offset: 0x000027D3
		private static Delegate GetGetUserVisibleHintHandler()
		{
			if (Fragment.cb_getUserVisibleHint == null)
			{
				Fragment.cb_getUserVisibleHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Fragment.n_GetUserVisibleHint));
			}
			return Fragment.cb_getUserVisibleHint;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000045F7 File Offset: 0x000027F7
		private static bool n_GetUserVisibleHint(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserVisibleHint;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004606 File Offset: 0x00002806
		private static Delegate GetSetUserVisibleHint_ZHandler()
		{
			if (Fragment.cb_setUserVisibleHint_Z == null)
			{
				Fragment.cb_setUserVisibleHint_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_SetUserVisibleHint_Z));
			}
			return Fragment.cb_setUserVisibleHint_Z;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000462A File Offset: 0x0000282A
		private static void n_SetUserVisibleHint_Z(IntPtr jnienv, IntPtr native__this, bool isVisibleToUser)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserVisibleHint = isVisibleToUser;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000463A File Offset: 0x0000283A
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00004654 File Offset: 0x00002854
		public unsafe virtual bool UserVisibleHint
		{
			[Register("getUserVisibleHint", "()Z", "GetGetUserVisibleHintHandler")]
			get
			{
				return Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("getUserVisibleHint.()Z", this, null);
			}
			[Register("setUserVisibleHint", "(Z)V", "GetSetUserVisibleHint_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setUserVisibleHint.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000468F File Offset: 0x0000288F
		private static Delegate GetGetViewHandler()
		{
			if (Fragment.cb_getView == null)
			{
				Fragment.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetView));
			}
			return Fragment.cb_getView;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000046B3 File Offset: 0x000028B3
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000046C8 File Offset: 0x000028C8
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000046FA File Offset: 0x000028FA
		private static Delegate GetGetViewLifecycleOwnerHandler()
		{
			if (Fragment.cb_getViewLifecycleOwner == null)
			{
				Fragment.cb_getViewLifecycleOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetViewLifecycleOwner));
			}
			return Fragment.cb_getViewLifecycleOwner;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000471E File Offset: 0x0000291E
		private static IntPtr n_GetViewLifecycleOwner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewLifecycleOwner);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00004734 File Offset: 0x00002934
		public virtual ILifecycleOwner ViewLifecycleOwner
		{
			[Register("getViewLifecycleOwner", "()Landroidx/lifecycle/LifecycleOwner;", "GetGetViewLifecycleOwnerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ILifecycleOwner>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getViewLifecycleOwner.()Landroidx/lifecycle/LifecycleOwner;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004766 File Offset: 0x00002966
		private static Delegate GetGetViewLifecycleOwnerLiveDataHandler()
		{
			if (Fragment.cb_getViewLifecycleOwnerLiveData == null)
			{
				Fragment.cb_getViewLifecycleOwnerLiveData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetViewLifecycleOwnerLiveData));
			}
			return Fragment.cb_getViewLifecycleOwnerLiveData;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000478A File Offset: 0x0000298A
		private static IntPtr n_GetViewLifecycleOwnerLiveData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewLifecycleOwnerLiveData);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000047A0 File Offset: 0x000029A0
		public virtual LiveData ViewLifecycleOwnerLiveData
		{
			[Register("getViewLifecycleOwnerLiveData", "()Landroidx/lifecycle/LiveData;", "GetGetViewLifecycleOwnerLiveDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LiveData>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getViewLifecycleOwnerLiveData.()Landroidx/lifecycle/LiveData;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000047D2 File Offset: 0x000029D2
		private static Delegate GetGetViewModelStoreHandler()
		{
			if (Fragment.cb_getViewModelStore == null)
			{
				Fragment.cb_getViewModelStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Fragment.n_GetViewModelStore));
			}
			return Fragment.cb_getViewModelStore;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000047F6 File Offset: 0x000029F6
		private static IntPtr n_GetViewModelStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewModelStore);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000480C File Offset: 0x00002A0C
		public virtual ViewModelStore ViewModelStore
		{
			[Register("getViewModelStore", "()Landroidx/lifecycle/ViewModelStore;", "GetGetViewModelStoreHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ViewModelStore>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getViewModelStore.()Landroidx/lifecycle/ViewModelStore;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000483E File Offset: 0x00002A3E
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (Fragment.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				Fragment.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(Fragment.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return Fragment.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00004864 File Offset: 0x00002A64
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefix, IntPtr native_fd, IntPtr native_writer, IntPtr native_args)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_prefix, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe virtual void Dump(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewArray(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((fd == null) ? IntPtr.Zero : fd.Handle);
				ptr[2] = new JniArgumentValue((writer == null) ? IntPtr.Zero : writer.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(fd);
				GC.KeepAlive(writer);
				GC.KeepAlive(args);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000049A8 File Offset: 0x00002BA8
		[Register("equals", "(Ljava/lang/Object;)Z", "")]
		public unsafe sealed override bool Equals(Java.Lang.Object o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				result = Fragment._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004A10 File Offset: 0x00002C10
		private static Delegate GetGetLayoutInflater_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_getLayoutInflater_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_getLayoutInflater_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Fragment.n_GetLayoutInflater_Landroid_os_Bundle_));
			}
			return Fragment.cb_getLayoutInflater_Landroid_os_Bundle_;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004A34 File Offset: 0x00002C34
		private static IntPtr n_GetLayoutInflater_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedFragmentState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedFragmentState, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetLayoutInflater(object2));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004A5C File Offset: 0x00002C5C
		[Register("getLayoutInflater", "(Landroid/os/Bundle;)Landroid/view/LayoutInflater;", "GetGetLayoutInflater_Landroid_os_Bundle_Handler")]
		public unsafe virtual LayoutInflater GetLayoutInflater(Bundle savedFragmentState)
		{
			LayoutInflater @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedFragmentState == null) ? IntPtr.Zero : savedFragmentState.Handle);
				@object = Java.Lang.Object.GetObject<LayoutInflater>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("getLayoutInflater.(Landroid/os/Bundle;)Landroid/view/LayoutInflater;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(savedFragmentState);
			}
			return @object;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Register("getString", "(I)Ljava/lang/String;", "")]
		public unsafe string GetString(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			return JNIEnv.GetString(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getString.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00004B1C File Offset: 0x00002D1C
		[Register("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string GetString(int resId, params Java.Lang.Object[] formatArgs)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(formatArgs);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				ptr[1] = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getString.(I[Ljava/lang/Object;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (formatArgs != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, formatArgs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(formatArgs);
			}
			return @string;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004BAC File Offset: 0x00002DAC
		[Register("getText", "(I)Ljava/lang/CharSequence;", "")]
		public unsafe ICharSequence GetTextFormatted(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			return Java.Lang.Object.GetObject<ICharSequence>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("getText.(I)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004BF5 File Offset: 0x00002DF5
		public string GetText(int resId)
		{
			ICharSequence textFormatted = this.GetTextFormatted(resId);
			if (textFormatted == null)
			{
				return null;
			}
			return textFormatted.ToString();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004C09 File Offset: 0x00002E09
		[Register("hashCode", "()I", "")]
		public sealed override int GetHashCode()
		{
			return Fragment._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004C24 File Offset: 0x00002E24
		[Register("instantiate", "(Landroid/content/Context;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", "")]
		public unsafe static Fragment Instantiate(Context context, string fname)
		{
			IntPtr intPtr = JNIEnv.NewString(fname);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Fragment>(Fragment._members.StaticMethods.InvokeObjectMethod("instantiate.(Landroid/content/Context;Ljava/lang/String;)Landroidx/fragment/app/Fragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004CB8 File Offset: 0x00002EB8
		[Register("instantiate", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroidx/fragment/app/Fragment;", "")]
		public unsafe static Fragment Instantiate(Context context, string fname, Bundle args)
		{
			IntPtr intPtr = JNIEnv.NewString(fname);
			Fragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				@object = Java.Lang.Object.GetObject<Fragment>(Fragment._members.StaticMethods.InvokeObjectMethod("instantiate.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Landroidx/fragment/app/Fragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004D78 File Offset: 0x00002F78
		private static Delegate GetOnActivityCreated_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onActivityCreated_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onActivityCreated_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnActivityCreated_Landroid_os_Bundle_));
			}
			return Fragment.cb_onActivityCreated_Landroid_os_Bundle_;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004D9C File Offset: 0x00002F9C
		private static void n_OnActivityCreated_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityCreated(object2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00004DC0 File Offset: 0x00002FC0
		[Register("onActivityCreated", "(Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnActivityCreated(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityCreated.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004E24 File Offset: 0x00003024
		private static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler()
		{
			if (Fragment.cb_onActivityResult_IILandroid_content_Intent_ == null)
			{
				Fragment.cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_V(Fragment.n_OnActivityResult_IILandroid_content_Intent_));
			}
			return Fragment.cb_onActivityResult_IILandroid_content_Intent_;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004E48 File Offset: 0x00003048
		private static void n_OnActivityResult_IILandroid_content_Intent_(IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResult(requestCode, resultCode, object2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004E70 File Offset: 0x00003070
		[Register("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public unsafe virtual void OnActivityResult(int requestCode, int resultCode, Intent data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(resultCode);
				ptr[2] = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResult.(IILandroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004EFC File Offset: 0x000030FC
		private static Delegate GetOnAttach_Landroid_app_Activity_Handler()
		{
			if (Fragment.cb_onAttach_Landroid_app_Activity_ == null)
			{
				Fragment.cb_onAttach_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnAttach_Landroid_app_Activity_));
			}
			return Fragment.cb_onAttach_Landroid_app_Activity_;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004F20 File Offset: 0x00003120
		private static void n_OnAttach_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.OnAttach(object2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00004F44 File Offset: 0x00003144
		[Register("onAttach", "(Landroid/app/Activity;)V", "GetOnAttach_Landroid_app_Activity_Handler")]
		public unsafe virtual void OnAttach(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onAttach.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004FA8 File Offset: 0x000031A8
		private static Delegate GetOnAttach_Landroid_content_Context_Handler()
		{
			if (Fragment.cb_onAttach_Landroid_content_Context_ == null)
			{
				Fragment.cb_onAttach_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnAttach_Landroid_content_Context_));
			}
			return Fragment.cb_onAttach_Landroid_content_Context_;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004FCC File Offset: 0x000031CC
		private static void n_OnAttach_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.OnAttach(object2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004FF0 File Offset: 0x000031F0
		[Register("onAttach", "(Landroid/content/Context;)V", "GetOnAttach_Landroid_content_Context_Handler")]
		public unsafe virtual void OnAttach(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onAttach.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005054 File Offset: 0x00003254
		private static Delegate GetOnAttachFragment_Landroidx_fragment_app_Fragment_Handler()
		{
			if (Fragment.cb_onAttachFragment_Landroidx_fragment_app_Fragment_ == null)
			{
				Fragment.cb_onAttachFragment_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnAttachFragment_Landroidx_fragment_app_Fragment_));
			}
			return Fragment.cb_onAttachFragment_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005078 File Offset: 0x00003278
		private static void n_OnAttachFragment_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_childFragment)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_childFragment, JniHandleOwnership.DoNotTransfer);
			@object.OnAttachFragment(object2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000509C File Offset: 0x0000329C
		[Register("onAttachFragment", "(Landroidx/fragment/app/Fragment;)V", "GetOnAttachFragment_Landroidx_fragment_app_Fragment_Handler")]
		public unsafe virtual void OnAttachFragment(Fragment childFragment)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((childFragment == null) ? IntPtr.Zero : childFragment.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachFragment.(Landroidx/fragment/app/Fragment;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(childFragment);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005100 File Offset: 0x00003300
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Fragment.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005124 File Offset: 0x00003324
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005148 File Offset: 0x00003348
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000051AC File Offset: 0x000033AC
		private static Delegate GetOnContextItemSelected_Landroid_view_MenuItem_Handler()
		{
			if (Fragment.cb_onContextItemSelected_Landroid_view_MenuItem_ == null)
			{
				Fragment.cb_onContextItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Fragment.n_OnContextItemSelected_Landroid_view_MenuItem_));
			}
			return Fragment.cb_onContextItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000051D0 File Offset: 0x000033D0
		private static bool n_OnContextItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnContextItemSelected(object2);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000051F4 File Offset: 0x000033F4
		[Register("onContextItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnContextItemSelected_Landroid_view_MenuItem_Handler")]
		public unsafe virtual bool OnContextItemSelected(IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("onContextItemSelected.(Landroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005260 File Offset: 0x00003460
		private static Delegate GetOnCreate_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onCreate_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnCreate_Landroid_os_Bundle_));
			}
			return Fragment.cb_onCreate_Landroid_os_Bundle_;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005284 File Offset: 0x00003484
		private static void n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000052A8 File Offset: 0x000034A8
		[Register("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnCreate(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000530C File Offset: 0x0000350C
		private static Delegate GetOnCreateAnimation_IZIHandler()
		{
			if (Fragment.cb_onCreateAnimation_IZI == null)
			{
				Fragment.cb_onCreateAnimation_IZI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZI_L(Fragment.n_OnCreateAnimation_IZI));
			}
			return Fragment.cb_onCreateAnimation_IZI;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00005330 File Offset: 0x00003530
		private static IntPtr n_OnCreateAnimation_IZI(IntPtr jnienv, IntPtr native__this, int transit, bool enter, int nextAnim)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreateAnimation(transit, enter, nextAnim));
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005348 File Offset: 0x00003548
		[Register("onCreateAnimation", "(IZI)Landroid/view/animation/Animation;", "GetOnCreateAnimation_IZIHandler")]
		public unsafe virtual Animation OnCreateAnimation(int transit, bool enter, int nextAnim)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(transit);
			ptr[1] = new JniArgumentValue(enter);
			ptr[2] = new JniArgumentValue(nextAnim);
			return Java.Lang.Object.GetObject<Animation>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateAnimation.(IZI)Landroid/view/animation/Animation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000053BA File Offset: 0x000035BA
		private static Delegate GetOnCreateAnimator_IZIHandler()
		{
			if (Fragment.cb_onCreateAnimator_IZI == null)
			{
				Fragment.cb_onCreateAnimator_IZI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZI_L(Fragment.n_OnCreateAnimator_IZI));
			}
			return Fragment.cb_onCreateAnimator_IZI;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000053DE File Offset: 0x000035DE
		private static IntPtr n_OnCreateAnimator_IZI(IntPtr jnienv, IntPtr native__this, int transit, bool enter, int nextAnim)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreateAnimator(transit, enter, nextAnim));
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000053F8 File Offset: 0x000035F8
		[Register("onCreateAnimator", "(IZI)Landroid/animation/Animator;", "GetOnCreateAnimator_IZIHandler")]
		public unsafe virtual Animator OnCreateAnimator(int transit, bool enter, int nextAnim)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(transit);
			ptr[1] = new JniArgumentValue(enter);
			ptr[2] = new JniArgumentValue(nextAnim);
			return Java.Lang.Object.GetObject<Animator>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateAnimator.(IZI)Landroid/animation/Animator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000546A File Offset: 0x0000366A
		private static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
		{
			if (Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
			{
				Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Fragment.n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_));
			}
			return Fragment.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00005490 File Offset: 0x00003690
		private static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_v, IntPtr native_menuInfo)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			IContextMenuContextMenuInfo object4 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateContextMenu(object2, object3, object4);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000054C8 File Offset: 0x000036C8
		[Register("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", "GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler")]
		public unsafe virtual void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[2] = new JniArgumentValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateContextMenu.(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
				GC.KeepAlive(v);
				GC.KeepAlive(menuInfo);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005588 File Offset: 0x00003788
		private static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_Handler()
		{
			if (Fragment.cb_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ == null)
			{
				Fragment.cb_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Fragment.n_OnCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_));
			}
			return Fragment.cb_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000055AC File Offset: 0x000037AC
		private static void n_OnCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_inflater)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			MenuInflater object3 = Java.Lang.Object.GetObject<MenuInflater>(native_inflater, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateOptionsMenu(object2, object3);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000055D8 File Offset: 0x000037D8
		[Register("onCreateOptionsMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V", "GetOnCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_Handler")]
		public unsafe virtual void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JniArgumentValue((inflater == null) ? IntPtr.Zero : inflater.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onCreateOptionsMenu.(Landroid/view/Menu;Landroid/view/MenuInflater;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
				GC.KeepAlive(inflater);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00005668 File Offset: 0x00003868
		private static Delegate GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Fragment.n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_));
			}
			return Fragment.cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000568C File Offset: 0x0000388C
		private static IntPtr n_OnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_inflater, IntPtr native_container, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LayoutInflater object2 = Java.Lang.Object.GetObject<LayoutInflater>(native_inflater, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateView(object2, object3, object4));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000056C8 File Offset: 0x000038C8
		[Register("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;", "GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler")]
		public unsafe virtual View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((inflater == null) ? IntPtr.Zero : inflater.Handle);
				ptr[1] = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				@object = Java.Lang.Object.GetObject<View>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateView.(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(inflater);
				GC.KeepAlive(container);
				GC.KeepAlive(savedInstanceState);
			}
			return @object;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005790 File Offset: 0x00003990
		private static Delegate GetOnDestroyHandler()
		{
			if (Fragment.cb_onDestroy == null)
			{
				Fragment.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnDestroy));
			}
			return Fragment.cb_onDestroy;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000057B4 File Offset: 0x000039B4
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000057C3 File Offset: 0x000039C3
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000057DC File Offset: 0x000039DC
		private static Delegate GetOnDestroyOptionsMenuHandler()
		{
			if (Fragment.cb_onDestroyOptionsMenu == null)
			{
				Fragment.cb_onDestroyOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnDestroyOptionsMenu));
			}
			return Fragment.cb_onDestroyOptionsMenu;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005800 File Offset: 0x00003A00
		private static void n_OnDestroyOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroyOptionsMenu();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000580F File Offset: 0x00003A0F
		[Register("onDestroyOptionsMenu", "()V", "GetOnDestroyOptionsMenuHandler")]
		public virtual void OnDestroyOptionsMenu()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroyOptionsMenu.()V", this, null);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005828 File Offset: 0x00003A28
		private static Delegate GetOnDestroyViewHandler()
		{
			if (Fragment.cb_onDestroyView == null)
			{
				Fragment.cb_onDestroyView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnDestroyView));
			}
			return Fragment.cb_onDestroyView;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000584C File Offset: 0x00003A4C
		private static void n_OnDestroyView(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroyView();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000585B File Offset: 0x00003A5B
		[Register("onDestroyView", "()V", "GetOnDestroyViewHandler")]
		public virtual void OnDestroyView()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroyView.()V", this, null);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005874 File Offset: 0x00003A74
		private static Delegate GetOnDetachHandler()
		{
			if (Fragment.cb_onDetach == null)
			{
				Fragment.cb_onDetach = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnDetach));
			}
			return Fragment.cb_onDetach;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005898 File Offset: 0x00003A98
		private static void n_OnDetach(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetach();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000058A7 File Offset: 0x00003AA7
		[Register("onDetach", "()V", "GetOnDetachHandler")]
		public virtual void OnDetach()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onDetach.()V", this, null);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000058C0 File Offset: 0x00003AC0
		private static Delegate GetOnGetLayoutInflater_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onGetLayoutInflater_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onGetLayoutInflater_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Fragment.n_OnGetLayoutInflater_Landroid_os_Bundle_));
			}
			return Fragment.cb_onGetLayoutInflater_Landroid_os_Bundle_;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000058E4 File Offset: 0x00003AE4
		private static IntPtr n_OnGetLayoutInflater_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnGetLayoutInflater(object2));
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000590C File Offset: 0x00003B0C
		[Register("onGetLayoutInflater", "(Landroid/os/Bundle;)Landroid/view/LayoutInflater;", "GetOnGetLayoutInflater_Landroid_os_Bundle_Handler")]
		public unsafe virtual LayoutInflater OnGetLayoutInflater(Bundle savedInstanceState)
		{
			LayoutInflater @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				@object = Java.Lang.Object.GetObject<LayoutInflater>(Fragment._members.InstanceMethods.InvokeVirtualObjectMethod("onGetLayoutInflater.(Landroid/os/Bundle;)Landroid/view/LayoutInflater;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
			return @object;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00005980 File Offset: 0x00003B80
		private static Delegate GetOnHiddenChanged_ZHandler()
		{
			if (Fragment.cb_onHiddenChanged_Z == null)
			{
				Fragment.cb_onHiddenChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_OnHiddenChanged_Z));
			}
			return Fragment.cb_onHiddenChanged_Z;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000059A4 File Offset: 0x00003BA4
		private static void n_OnHiddenChanged_Z(IntPtr jnienv, IntPtr native__this, bool hidden)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnHiddenChanged(hidden);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Register("onHiddenChanged", "(Z)V", "GetOnHiddenChanged_ZHandler")]
		public unsafe virtual void OnHiddenChanged(bool hidden)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hidden);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onHiddenChanged.(Z)V", this, ptr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000059EF File Offset: 0x00003BEF
		private static Delegate GetOnInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Fragment.n_OnInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_));
			}
			return Fragment.cb_onInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00005A14 File Offset: 0x00003C14
		private static void n_OnInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_attrs, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			IAttributeSet object3 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnInflate(object2, object3, object4);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00005A4C File Offset: 0x00003C4C
		[Register("onInflate", "(Landroid/app/Activity;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", "GetOnInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnInflate(Activity activity, IAttributeSet attrs, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onInflate.(Landroid/app/Activity;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(attrs);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005B08 File Offset: 0x00003D08
		private static Delegate GetOnInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Fragment.n_OnInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_));
			}
			return Fragment.cb_onInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005B2C File Offset: 0x00003D2C
		private static void n_OnInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IAttributeSet object3 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnInflate(object2, object3, object4);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00005B64 File Offset: 0x00003D64
		[Register("onInflate", "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", "GetOnInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnInflate(Context context, IAttributeSet attrs, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onInflate.(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00005C20 File Offset: 0x00003E20
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Fragment.cb_onLowMemory == null)
			{
				Fragment.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnLowMemory));
			}
			return Fragment.cb_onLowMemory;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00005C44 File Offset: 0x00003E44
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005C53 File Offset: 0x00003E53
		[Register("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual void OnLowMemory()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00005C6C File Offset: 0x00003E6C
		private static Delegate GetOnMultiWindowModeChanged_ZHandler()
		{
			if (Fragment.cb_onMultiWindowModeChanged_Z == null)
			{
				Fragment.cb_onMultiWindowModeChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_OnMultiWindowModeChanged_Z));
			}
			return Fragment.cb_onMultiWindowModeChanged_Z;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005C90 File Offset: 0x00003E90
		private static void n_OnMultiWindowModeChanged_Z(IntPtr jnienv, IntPtr native__this, bool isInMultiWindowMode)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMultiWindowModeChanged(isInMultiWindowMode);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Register("onMultiWindowModeChanged", "(Z)V", "GetOnMultiWindowModeChanged_ZHandler")]
		public unsafe virtual void OnMultiWindowModeChanged(bool isInMultiWindowMode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isInMultiWindowMode);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onMultiWindowModeChanged.(Z)V", this, ptr);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005CDB File Offset: 0x00003EDB
		private static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler()
		{
			if (Fragment.cb_onOptionsItemSelected_Landroid_view_MenuItem_ == null)
			{
				Fragment.cb_onOptionsItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Fragment.n_OnOptionsItemSelected_Landroid_view_MenuItem_));
			}
			return Fragment.cb_onOptionsItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005D00 File Offset: 0x00003F00
		private static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnOptionsItemSelected(object2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005D24 File Offset: 0x00003F24
		[Register("onOptionsItemSelected", "(Landroid/view/MenuItem;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler")]
		public unsafe virtual bool OnOptionsItemSelected(IMenuItem item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("onOptionsItemSelected.(Landroid/view/MenuItem;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00005D90 File Offset: 0x00003F90
		private static Delegate GetOnOptionsMenuClosed_Landroid_view_Menu_Handler()
		{
			if (Fragment.cb_onOptionsMenuClosed_Landroid_view_Menu_ == null)
			{
				Fragment.cb_onOptionsMenuClosed_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnOptionsMenuClosed_Landroid_view_Menu_));
			}
			return Fragment.cb_onOptionsMenuClosed_Landroid_view_Menu_;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005DB4 File Offset: 0x00003FB4
		private static void n_OnOptionsMenuClosed_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnOptionsMenuClosed(object2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Register("onOptionsMenuClosed", "(Landroid/view/Menu;)V", "GetOnOptionsMenuClosed_Landroid_view_Menu_Handler")]
		public unsafe virtual void OnOptionsMenuClosed(IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onOptionsMenuClosed.(Landroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005E40 File Offset: 0x00004040
		private static Delegate GetOnPauseHandler()
		{
			if (Fragment.cb_onPause == null)
			{
				Fragment.cb_onPause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnPause));
			}
			return Fragment.cb_onPause;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005E64 File Offset: 0x00004064
		private static void n_OnPause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPause();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005E73 File Offset: 0x00004073
		[Register("onPause", "()V", "GetOnPauseHandler")]
		public virtual void OnPause()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onPause.()V", this, null);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005E8C File Offset: 0x0000408C
		private static Delegate GetOnPictureInPictureModeChanged_ZHandler()
		{
			if (Fragment.cb_onPictureInPictureModeChanged_Z == null)
			{
				Fragment.cb_onPictureInPictureModeChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_OnPictureInPictureModeChanged_Z));
			}
			return Fragment.cb_onPictureInPictureModeChanged_Z;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00005EB0 File Offset: 0x000040B0
		private static void n_OnPictureInPictureModeChanged_Z(IntPtr jnienv, IntPtr native__this, bool isInPictureInPictureMode)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPictureInPictureModeChanged(isInPictureInPictureMode);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00005EC0 File Offset: 0x000040C0
		[Register("onPictureInPictureModeChanged", "(Z)V", "GetOnPictureInPictureModeChanged_ZHandler")]
		public unsafe virtual void OnPictureInPictureModeChanged(bool isInPictureInPictureMode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isInPictureInPictureMode);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onPictureInPictureModeChanged.(Z)V", this, ptr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00005EFB File Offset: 0x000040FB
		private static Delegate GetOnPrepareOptionsMenu_Landroid_view_Menu_Handler()
		{
			if (Fragment.cb_onPrepareOptionsMenu_Landroid_view_Menu_ == null)
			{
				Fragment.cb_onPrepareOptionsMenu_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnPrepareOptionsMenu_Landroid_view_Menu_));
			}
			return Fragment.cb_onPrepareOptionsMenu_Landroid_view_Menu_;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00005F20 File Offset: 0x00004120
		private static void n_OnPrepareOptionsMenu_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.OnPrepareOptionsMenu(object2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00005F44 File Offset: 0x00004144
		[Register("onPrepareOptionsMenu", "(Landroid/view/Menu;)V", "GetOnPrepareOptionsMenu_Landroid_view_Menu_Handler")]
		public unsafe virtual void OnPrepareOptionsMenu(IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onPrepareOptionsMenu.(Landroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00005FAC File Offset: 0x000041AC
		private static Delegate GetOnPrimaryNavigationFragmentChanged_ZHandler()
		{
			if (Fragment.cb_onPrimaryNavigationFragmentChanged_Z == null)
			{
				Fragment.cb_onPrimaryNavigationFragmentChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_OnPrimaryNavigationFragmentChanged_Z));
			}
			return Fragment.cb_onPrimaryNavigationFragmentChanged_Z;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00005FD0 File Offset: 0x000041D0
		private static void n_OnPrimaryNavigationFragmentChanged_Z(IntPtr jnienv, IntPtr native__this, bool isPrimaryNavigationFragment)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPrimaryNavigationFragmentChanged(isPrimaryNavigationFragment);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00005FE0 File Offset: 0x000041E0
		[Register("onPrimaryNavigationFragmentChanged", "(Z)V", "GetOnPrimaryNavigationFragmentChanged_ZHandler")]
		public unsafe virtual void OnPrimaryNavigationFragmentChanged(bool isPrimaryNavigationFragment)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isPrimaryNavigationFragment);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onPrimaryNavigationFragmentChanged.(Z)V", this, ptr);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000601B File Offset: 0x0000421B
		private static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler()
		{
			if (Fragment.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
			{
				Fragment.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_V(Fragment.n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI));
			}
			return Fragment.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00006040 File Offset: 0x00004240
		private static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI(IntPtr jnienv, IntPtr native__this, int requestCode, IntPtr native_permissions, IntPtr native_grantResults)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_permissions, JniHandleOwnership.DoNotTransfer, typeof(string));
			Permission[] array2 = (Permission[])JNIEnv.GetArray(native_grantResults, JniHandleOwnership.DoNotTransfer, typeof(Permission));
			@object.OnRequestPermissionsResult(requestCode, array, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_permissions);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<Permission>(array2, native_grantResults);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000060A4 File Offset: 0x000042A4
		[Register("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public unsafe virtual void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			IntPtr intPtr2 = JNIEnv.NewArray<Permission>(grantResults);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onRequestPermissionsResult.(I[Ljava/lang/String;[I)V", this, ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (grantResults != null)
				{
					JNIEnv.CopyArray<Permission>(intPtr2, grantResults);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(permissions);
				GC.KeepAlive(grantResults);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006158 File Offset: 0x00004358
		private static Delegate GetOnResumeHandler()
		{
			if (Fragment.cb_onResume == null)
			{
				Fragment.cb_onResume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnResume));
			}
			return Fragment.cb_onResume;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000617C File Offset: 0x0000437C
		private static void n_OnResume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnResume();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000618B File Offset: 0x0000438B
		[Register("onResume", "()V", "GetOnResumeHandler")]
		public virtual void OnResume()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.()V", this, null);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000061A4 File Offset: 0x000043A4
		private static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnSaveInstanceState_Landroid_os_Bundle_));
			}
			return Fragment.cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000061C8 File Offset: 0x000043C8
		private static void n_OnSaveInstanceState_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.OnSaveInstanceState(object2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000061EC File Offset: 0x000043EC
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnSaveInstanceState(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006250 File Offset: 0x00004450
		private static Delegate GetOnStartHandler()
		{
			if (Fragment.cb_onStart == null)
			{
				Fragment.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnStart));
			}
			return Fragment.cb_onStart;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006274 File Offset: 0x00004474
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006283 File Offset: 0x00004483
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000629C File Offset: 0x0000449C
		private static Delegate GetOnStopHandler()
		{
			if (Fragment.cb_onStop == null)
			{
				Fragment.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_OnStop));
			}
			return Fragment.cb_onStop;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000062C0 File Offset: 0x000044C0
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000062CF File Offset: 0x000044CF
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000062E8 File Offset: 0x000044E8
		private static Delegate GetOnViewCreated_Landroid_view_View_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onViewCreated_Landroid_view_View_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onViewCreated_Landroid_view_View_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Fragment.n_OnViewCreated_Landroid_view_View_Landroid_os_Bundle_));
			}
			return Fragment.cb_onViewCreated_Landroid_view_View_Landroid_os_Bundle_;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000630C File Offset: 0x0000450C
		private static void n_OnViewCreated_Landroid_view_View_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnViewCreated(object2, object3);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00006338 File Offset: 0x00004538
		[Register("onViewCreated", "(Landroid/view/View;Landroid/os/Bundle;)V", "GetOnViewCreated_Landroid_view_View_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnViewCreated(View view, Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onViewCreated.(Landroid/view/View;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000063C4 File Offset: 0x000045C4
		private static Delegate GetOnViewStateRestored_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_onViewStateRestored_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_onViewStateRestored_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_OnViewStateRestored_Landroid_os_Bundle_));
			}
			return Fragment.cb_onViewStateRestored_Landroid_os_Bundle_;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000063E8 File Offset: 0x000045E8
		private static void n_OnViewStateRestored_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			@object.OnViewStateRestored(object2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000640C File Offset: 0x0000460C
		[Register("onViewStateRestored", "(Landroid/os/Bundle;)V", "GetOnViewStateRestored_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnViewStateRestored(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("onViewStateRestored.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006470 File Offset: 0x00004670
		private static Delegate GetPostponeEnterTransitionHandler()
		{
			if (Fragment.cb_postponeEnterTransition == null)
			{
				Fragment.cb_postponeEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_PostponeEnterTransition));
			}
			return Fragment.cb_postponeEnterTransition;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006494 File Offset: 0x00004694
		private static void n_PostponeEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PostponeEnterTransition();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000064A3 File Offset: 0x000046A3
		[Register("postponeEnterTransition", "()V", "GetPostponeEnterTransitionHandler")]
		public virtual void PostponeEnterTransition()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("postponeEnterTransition.()V", this, null);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000064BC File Offset: 0x000046BC
		[Register("postponeEnterTransition", "(JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe void PostponeEnterTransition(long duration, TimeUnit timeUnit)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(duration);
				ptr[1] = new JniArgumentValue((timeUnit == null) ? IntPtr.Zero : timeUnit.Handle);
				Fragment._members.InstanceMethods.InvokeNonvirtualVoidMethod("postponeEnterTransition.(JLjava/util/concurrent/TimeUnit;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(timeUnit);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00006534 File Offset: 0x00004734
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract contract, IActivityResultCallback callback)
		{
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("registerForActivityResult.(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contract);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000065D4 File Offset: 0x000047D4
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract contract, ActivityResultRegistry registry, IActivityResultCallback callback)
		{
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[1] = new JniArgumentValue((registry == null) ? IntPtr.Zero : registry.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("registerForActivityResult.(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contract);
				GC.KeepAlive(registry);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000066A0 File Offset: 0x000048A0
		private static Delegate GetRegisterForContextMenu_Landroid_view_View_Handler()
		{
			if (Fragment.cb_registerForContextMenu_Landroid_view_View_ == null)
			{
				Fragment.cb_registerForContextMenu_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_RegisterForContextMenu_Landroid_view_View_));
			}
			return Fragment.cb_registerForContextMenu_Landroid_view_View_;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000066C4 File Offset: 0x000048C4
		private static void n_RegisterForContextMenu_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.RegisterForContextMenu(object2);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000066E8 File Offset: 0x000048E8
		[Register("registerForContextMenu", "(Landroid/view/View;)V", "GetRegisterForContextMenu_Landroid_view_View_Handler")]
		public unsafe virtual void RegisterForContextMenu(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("registerForContextMenu.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000674C File Offset: 0x0000494C
		[Register("requestPermissions", "([Ljava/lang/String;I)V", "")]
		public unsafe void RequestPermissions(string[] permissions, int requestCode)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(requestCode);
				Fragment._members.InstanceMethods.InvokeNonvirtualVoidMethod("requestPermissions.([Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(permissions);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000067CC File Offset: 0x000049CC
		[Register("requireActivity", "()Landroidx/fragment/app/FragmentActivity;", "")]
		public FragmentActivity RequireActivity()
		{
			return Java.Lang.Object.GetObject<FragmentActivity>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireActivity.()Landroidx/fragment/app/FragmentActivity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00006800 File Offset: 0x00004A00
		[Register("requireArguments", "()Landroid/os/Bundle;", "")]
		public Bundle RequireArguments()
		{
			return Java.Lang.Object.GetObject<Bundle>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireArguments.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00006834 File Offset: 0x00004A34
		[Register("requireContext", "()Landroid/content/Context;", "")]
		public Context RequireContext()
		{
			return Java.Lang.Object.GetObject<Context>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00006868 File Offset: 0x00004A68
		[Register("requireFragmentManager", "()Landroidx/fragment/app/FragmentManager;", "")]
		public FragmentManager RequireFragmentManager()
		{
			return Java.Lang.Object.GetObject<FragmentManager>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireFragmentManager.()Landroidx/fragment/app/FragmentManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000689C File Offset: 0x00004A9C
		[Register("requireHost", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object RequireHost()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireHost.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Register("requireParentFragment", "()Landroidx/fragment/app/Fragment;", "")]
		public Fragment RequireParentFragment()
		{
			return Java.Lang.Object.GetObject<Fragment>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireParentFragment.()Landroidx/fragment/app/Fragment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00006904 File Offset: 0x00004B04
		[Register("requireView", "()Landroid/view/View;", "")]
		public View RequireView()
		{
			return Java.Lang.Object.GetObject<View>(Fragment._members.InstanceMethods.InvokeNonvirtualObjectMethod("requireView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006936 File Offset: 0x00004B36
		private static Delegate GetSetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler()
		{
			if (Fragment.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_ == null)
			{
				Fragment.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_));
			}
			return Fragment.cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000695C File Offset: 0x00004B5C
		private static void n_SetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SharedElementCallback object2 = Java.Lang.Object.GetObject<SharedElementCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.SetEnterSharedElementCallback(object2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006980 File Offset: 0x00004B80
		[Register("setEnterSharedElementCallback", "(Landroidx/core/app/SharedElementCallback;)V", "GetSetEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler")]
		public unsafe virtual void SetEnterSharedElementCallback(SharedElementCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setEnterSharedElementCallback.(Landroidx/core/app/SharedElementCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000069E4 File Offset: 0x00004BE4
		private static Delegate GetSetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler()
		{
			if (Fragment.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_ == null)
			{
				Fragment.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_));
			}
			return Fragment.cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006A08 File Offset: 0x00004C08
		private static void n_SetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SharedElementCallback object2 = Java.Lang.Object.GetObject<SharedElementCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.SetExitSharedElementCallback(object2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00006A2C File Offset: 0x00004C2C
		[Register("setExitSharedElementCallback", "(Landroidx/core/app/SharedElementCallback;)V", "GetSetExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_Handler")]
		public unsafe virtual void SetExitSharedElementCallback(SharedElementCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setExitSharedElementCallback.(Landroidx/core/app/SharedElementCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006A90 File Offset: 0x00004C90
		private static Delegate GetSetInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_Handler()
		{
			if (Fragment.cb_setInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_ == null)
			{
				Fragment.cb_setInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_SetInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_));
			}
			return Fragment.cb_setInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00006AB4 File Offset: 0x00004CB4
		private static void n_SetInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment.SavedState object2 = Java.Lang.Object.GetObject<Fragment.SavedState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.SetInitialSavedState(object2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00006AD8 File Offset: 0x00004CD8
		[Register("setInitialSavedState", "(Landroidx/fragment/app/Fragment$SavedState;)V", "GetSetInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_Handler")]
		public unsafe virtual void SetInitialSavedState(Fragment.SavedState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setInitialSavedState.(Landroidx/fragment/app/Fragment$SavedState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00006B3C File Offset: 0x00004D3C
		private static Delegate GetSetMenuVisibility_ZHandler()
		{
			if (Fragment.cb_setMenuVisibility_Z == null)
			{
				Fragment.cb_setMenuVisibility_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Fragment.n_SetMenuVisibility_Z));
			}
			return Fragment.cb_setMenuVisibility_Z;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006B60 File Offset: 0x00004D60
		private static void n_SetMenuVisibility_Z(IntPtr jnienv, IntPtr native__this, bool menuVisible)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMenuVisibility(menuVisible);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00006B70 File Offset: 0x00004D70
		[Register("setMenuVisibility", "(Z)V", "GetSetMenuVisibility_ZHandler")]
		public unsafe virtual void SetMenuVisibility(bool menuVisible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(menuVisible);
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setMenuVisibility.(Z)V", this, ptr);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00006BAB File Offset: 0x00004DAB
		private static Delegate GetSetTargetFragment_Landroidx_fragment_app_Fragment_IHandler()
		{
			if (Fragment.cb_setTargetFragment_Landroidx_fragment_app_Fragment_I == null)
			{
				Fragment.cb_setTargetFragment_Landroidx_fragment_app_Fragment_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Fragment.n_SetTargetFragment_Landroidx_fragment_app_Fragment_I));
			}
			return Fragment.cb_setTargetFragment_Landroidx_fragment_app_Fragment_I;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006BD0 File Offset: 0x00004DD0
		private static void n_SetTargetFragment_Landroidx_fragment_app_Fragment_I(IntPtr jnienv, IntPtr native__this, IntPtr native_fragment, int requestCode)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Fragment object2 = Java.Lang.Object.GetObject<Fragment>(native_fragment, JniHandleOwnership.DoNotTransfer);
			@object.SetTargetFragment(object2, requestCode);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006BF4 File Offset: 0x00004DF4
		[Register("setTargetFragment", "(Landroidx/fragment/app/Fragment;I)V", "GetSetTargetFragment_Landroidx_fragment_app_Fragment_IHandler")]
		public unsafe virtual void SetTargetFragment(Fragment fragment, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("setTargetFragment.(Landroidx/fragment/app/Fragment;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006C6C File Offset: 0x00004E6C
		private static Delegate GetShouldShowRequestPermissionRationale_Ljava_lang_String_Handler()
		{
			if (Fragment.cb_shouldShowRequestPermissionRationale_Ljava_lang_String_ == null)
			{
				Fragment.cb_shouldShowRequestPermissionRationale_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Fragment.n_ShouldShowRequestPermissionRationale_Ljava_lang_String_));
			}
			return Fragment.cb_shouldShowRequestPermissionRationale_Ljava_lang_String_;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006C90 File Offset: 0x00004E90
		private static bool n_ShouldShowRequestPermissionRationale_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_permission, JniHandleOwnership.DoNotTransfer);
			return @object.ShouldShowRequestPermissionRationale(@string);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006CB4 File Offset: 0x00004EB4
		[Register("shouldShowRequestPermissionRationale", "(Ljava/lang/String;)Z", "GetShouldShowRequestPermissionRationale_Ljava_lang_String_Handler")]
		public unsafe virtual bool ShouldShowRequestPermissionRationale(string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Fragment._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldShowRequestPermissionRationale.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006D14 File Offset: 0x00004F14
		private static Delegate GetStartActivity_Landroid_content_Intent_Handler()
		{
			if (Fragment.cb_startActivity_Landroid_content_Intent_ == null)
			{
				Fragment.cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_StartActivity_Landroid_content_Intent_));
			}
			return Fragment.cb_startActivity_Landroid_content_Intent_;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006D38 File Offset: 0x00004F38
		private static void n_StartActivity_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006D5C File Offset: 0x00004F5C
		[Register("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public unsafe virtual void StartActivity(Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startActivity.(Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006DC0 File Offset: 0x00004FC0
		private static Delegate GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler()
		{
			if (Fragment.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ == null)
			{
				Fragment.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Fragment.n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_));
			}
			return Fragment.cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00006DE4 File Offset: 0x00004FE4
		private static void n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivity(object2, object3);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006E10 File Offset: 0x00005010
		[Register("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler")]
		public unsafe virtual void StartActivity(Intent intent, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startActivity.(Landroid/content/Intent;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00006E9C File Offset: 0x0000509C
		private static Delegate GetStartActivityForResult_Landroid_content_Intent_IHandler()
		{
			if (Fragment.cb_startActivityForResult_Landroid_content_Intent_I == null)
			{
				Fragment.cb_startActivityForResult_Landroid_content_Intent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Fragment.n_StartActivityForResult_Landroid_content_Intent_I));
			}
			return Fragment.cb_startActivityForResult_Landroid_content_Intent_I;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006EC0 File Offset: 0x000050C0
		private static void n_StartActivityForResult_Landroid_content_Intent_I(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityForResult(object2, requestCode);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006EE4 File Offset: 0x000050E4
		[Register("startActivityForResult", "(Landroid/content/Intent;I)V", "GetStartActivityForResult_Landroid_content_Intent_IHandler")]
		public unsafe virtual void StartActivityForResult(Intent intent, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityForResult.(Landroid/content/Intent;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006F5C File Offset: 0x0000515C
		private static Delegate GetStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_Handler()
		{
			if (Fragment.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
			{
				Fragment.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(Fragment.n_StartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_));
			}
			return Fragment.cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006F80 File Offset: 0x00005180
		private static void n_StartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartActivityForResult(object2, requestCode, object3);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00006FB0 File Offset: 0x000051B0
		[Register("startActivityForResult", "(Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetStartActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public unsafe virtual void StartActivityForResult(Intent intent, int requestCode, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startActivityForResult.(Landroid/content/Intent;ILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007054 File Offset: 0x00005254
		private static Delegate GetStartIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler()
		{
			if (Fragment.cb_startIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ == null)
			{
				Fragment.cb_startIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILIIIL_V(Fragment.n_StartIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_));
			}
			return Fragment.cb_startIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00007078 File Offset: 0x00005278
		private static void n_StartIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, int requestCode, IntPtr native_fillInIntent, int flagsMask, int flagsValues, int extraFlags, IntPtr native_options)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IntentSender object2 = Java.Lang.Object.GetObject<IntentSender>(native_intent, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_fillInIntent, JniHandleOwnership.DoNotTransfer);
			Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_options, JniHandleOwnership.DoNotTransfer);
			@object.StartIntentSenderForResult(object2, requestCode, object3, flagsMask, flagsValues, extraFlags, object4);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000070B8 File Offset: 0x000052B8
		[Register("startIntentSenderForResult", "(Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", "GetStartIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public unsafe virtual void StartIntentSenderForResult(IntentSender intent, int requestCode, Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ptr[2] = new JniArgumentValue((fillInIntent == null) ? IntPtr.Zero : fillInIntent.Handle);
				ptr[3] = new JniArgumentValue(flagsMask);
				ptr[4] = new JniArgumentValue(flagsValues);
				ptr[5] = new JniArgumentValue(extraFlags);
				ptr[6] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startIntentSenderForResult.(Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(intent);
				GC.KeepAlive(fillInIntent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000071CC File Offset: 0x000053CC
		private static Delegate GetStartPostponedEnterTransitionHandler()
		{
			if (Fragment.cb_startPostponedEnterTransition == null)
			{
				Fragment.cb_startPostponedEnterTransition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Fragment.n_StartPostponedEnterTransition));
			}
			return Fragment.cb_startPostponedEnterTransition;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000071F0 File Offset: 0x000053F0
		private static void n_StartPostponedEnterTransition(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartPostponedEnterTransition();
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000071FF File Offset: 0x000053FF
		[Register("startPostponedEnterTransition", "()V", "GetStartPostponedEnterTransitionHandler")]
		public virtual void StartPostponedEnterTransition()
		{
			Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("startPostponedEnterTransition.()V", this, null);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007218 File Offset: 0x00005418
		private static Delegate GetUnregisterForContextMenu_Landroid_view_View_Handler()
		{
			if (Fragment.cb_unregisterForContextMenu_Landroid_view_View_ == null)
			{
				Fragment.cb_unregisterForContextMenu_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Fragment.n_UnregisterForContextMenu_Landroid_view_View_));
			}
			return Fragment.cb_unregisterForContextMenu_Landroid_view_View_;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000723C File Offset: 0x0000543C
		private static void n_UnregisterForContextMenu_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			Fragment @object = Java.Lang.Object.GetObject<Fragment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterForContextMenu(object2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007260 File Offset: 0x00005460
		[Register("unregisterForContextMenu", "(Landroid/view/View;)V", "GetUnregisterForContextMenu_Landroid_view_View_Handler")]
		public unsafe virtual void UnregisterForContextMenu(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				Fragment._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterForContextMenu.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/Fragment", typeof(Fragment));

		// Token: 0x04000024 RID: 36
		private static Delegate cb_getAllowEnterTransitionOverlap;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_setAllowEnterTransitionOverlap_Z;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_getAllowReturnTransitionOverlap;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_setAllowReturnTransitionOverlap_Z;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_getContext;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_getDefaultViewModelCreationExtras;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_getDefaultViewModelProviderFactory;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_getEnterTransition;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_setEnterTransition_Ljava_lang_Object_;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_getExitTransition;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_setExitTransition_Ljava_lang_Object_;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_getLifecycle;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_getLoaderManager;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_getReenterTransition;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_setReenterTransition_Ljava_lang_Object_;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_getReturnTransition;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_setReturnTransition_Ljava_lang_Object_;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_getSharedElementEnterTransition;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_setSharedElementEnterTransition_Ljava_lang_Object_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_getSharedElementReturnTransition;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_setSharedElementReturnTransition_Ljava_lang_Object_;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_getUserVisibleHint;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_setUserVisibleHint_Z;

		// Token: 0x0400003B RID: 59
		private static Delegate cb_getView;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getViewLifecycleOwner;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_getViewLifecycleOwnerLiveData;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_getViewModelStore;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_getLayoutInflater_Landroid_os_Bundle_;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_onActivityCreated_Landroid_os_Bundle_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onActivityResult_IILandroid_content_Intent_;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_onAttach_Landroid_app_Activity_;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_onAttach_Landroid_content_Context_;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_onAttachFragment_Landroidx_fragment_app_Fragment_;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_onContextItemSelected_Landroid_view_MenuItem_;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_onCreate_Landroid_os_Bundle_;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_onCreateAnimation_IZI;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_onCreateAnimator_IZI;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_onCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_onDestroy;

		// Token: 0x0400004F RID: 79
		private static Delegate cb_onDestroyOptionsMenu;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_onDestroyView;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_onDetach;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_onGetLayoutInflater_Landroid_os_Bundle_;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_onHiddenChanged_Z;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_onInflate_Landroid_app_Activity_Landroid_util_AttributeSet_Landroid_os_Bundle_;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_onInflate_Landroid_content_Context_Landroid_util_AttributeSet_Landroid_os_Bundle_;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_onLowMemory;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_onMultiWindowModeChanged_Z;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_onOptionsMenuClosed_Landroid_view_Menu_;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_onPause;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_onPictureInPictureModeChanged_Z;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_onPrepareOptionsMenu_Landroid_view_Menu_;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_onPrimaryNavigationFragmentChanged_Z;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_onResume;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_onStart;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_onStop;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_onViewCreated_Landroid_view_View_Landroid_os_Bundle_;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_onViewStateRestored_Landroid_os_Bundle_;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_postponeEnterTransition;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_registerForContextMenu_Landroid_view_View_;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_setEnterSharedElementCallback_Landroidx_core_app_SharedElementCallback_;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_setExitSharedElementCallback_Landroidx_core_app_SharedElementCallback_;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_setInitialSavedState_Landroidx_fragment_app_Fragment_SavedState_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_setMenuVisibility_Z;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_setTargetFragment_Landroidx_fragment_app_Fragment_I;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_shouldShowRequestPermissionRationale_Ljava_lang_String_;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_startActivity_Landroid_content_Intent_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_startActivityForResult_Landroid_content_Intent_I;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_startActivityForResult_Landroid_content_Intent_ILandroid_os_Bundle_;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_startIntentSenderForResult_Landroid_content_IntentSender_ILandroid_content_Intent_IIILandroid_os_Bundle_;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_startPostponedEnterTransition;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_unregisterForContextMenu_Landroid_view_View_;

		// Token: 0x0200002A RID: 42
		[Register("androidx/fragment/app/Fragment$SavedState", DoNotGenerateAcw = true)]
		public class SavedState : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000223 RID: 547 RVA: 0x000072E0 File Offset: 0x000054E0
			[Register("CREATOR")]
			public static IParcelableCreator Creator
			{
				get
				{
					return Java.Lang.Object.GetObject<IParcelableCreator>(Fragment.SavedState._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000224 RID: 548 RVA: 0x00007310 File Offset: 0x00005510
			internal static IntPtr class_ref
			{
				get
				{
					return Fragment.SavedState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000225 RID: 549 RVA: 0x00007334 File Offset: 0x00005534
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Fragment.SavedState._members;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000226 RID: 550 RVA: 0x0000733C File Offset: 0x0000553C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Fragment.SavedState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000227 RID: 551 RVA: 0x00007360 File Offset: 0x00005560
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Fragment.SavedState._members.ManagedPeerType;
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x00003624 File Offset: 0x00001824
			protected SavedState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000736C File Offset: 0x0000556C
			private static Delegate GetDescribeContentsHandler()
			{
				if (Fragment.SavedState.cb_describeContents == null)
				{
					Fragment.SavedState.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Fragment.SavedState.n_DescribeContents));
				}
				return Fragment.SavedState.cb_describeContents;
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00007390 File Offset: 0x00005590
			private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Fragment.SavedState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000739F File Offset: 0x0000559F
			[Register("describeContents", "()I", "GetDescribeContentsHandler")]
			public virtual int DescribeContents()
			{
				return Fragment.SavedState._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x000073B8 File Offset: 0x000055B8
			private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
			{
				if (Fragment.SavedState.cb_writeToParcel_Landroid_os_Parcel_I == null)
				{
					Fragment.SavedState.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Fragment.SavedState.n_WriteToParcel_Landroid_os_Parcel_I));
				}
				return Fragment.SavedState.cb_writeToParcel_Landroid_os_Parcel_I;
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000073DC File Offset: 0x000055DC
			private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
			{
				Fragment.SavedState @object = Java.Lang.Object.GetObject<Fragment.SavedState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
				@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00007404 File Offset: 0x00005604
			[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
					ptr[1] = new JniArgumentValue((int)flags);
					Fragment.SavedState._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(dest);
				}
			}

			// Token: 0x04000074 RID: 116
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/Fragment$SavedState", typeof(Fragment.SavedState));

			// Token: 0x04000075 RID: 117
			private static Delegate cb_describeContents;

			// Token: 0x04000076 RID: 118
			private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
		}
	}
}
