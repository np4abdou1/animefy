using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C4 RID: 196
	[Register("androidx/core/view/accessibility/AccessibilityNodeProviderCompat", DoNotGenerateAcw = true)]
	public class AccessibilityNodeProviderCompat : Java.Lang.Object
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000289AC File Offset: 0x00026BAC
		internal static IntPtr class_ref
		{
			get
			{
				return AccessibilityNodeProviderCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000289D0 File Offset: 0x00026BD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityNodeProviderCompat._members;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000289D8 File Offset: 0x00026BD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityNodeProviderCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x000289FC File Offset: 0x00026BFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityNodeProviderCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002384 File Offset: 0x00000584
		protected AccessibilityNodeProviderCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00028A08 File Offset: 0x00026C08
		[Register(".ctor", "()V", "")]
		public AccessibilityNodeProviderCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AccessibilityNodeProviderCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AccessibilityNodeProviderCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00028A78 File Offset: 0x00026C78
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe AccessibilityNodeProviderCompat(Java.Lang.Object provider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : provider.Handle);
				base.SetHandle(AccessibilityNodeProviderCompat._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AccessibilityNodeProviderCompat._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00028B28 File Offset: 0x00026D28
		private static Delegate GetGetProviderHandler()
		{
			if (AccessibilityNodeProviderCompat.cb_getProvider == null)
			{
				AccessibilityNodeProviderCompat.cb_getProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeProviderCompat.n_GetProvider));
			}
			return AccessibilityNodeProviderCompat.cb_getProvider;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00028B4C File Offset: 0x00026D4C
		private static IntPtr n_GetProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Provider);
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00028B60 File Offset: 0x00026D60
		public virtual Java.Lang.Object Provider
		{
			[Register("getProvider", "()Ljava/lang/Object;", "GetGetProviderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getProvider.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00028B92 File Offset: 0x00026D92
		private static Delegate GetAddExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_Handler()
		{
			if (AccessibilityNodeProviderCompat.cb_addExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_ == null)
			{
				AccessibilityNodeProviderCompat.cb_addExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILLL_V(AccessibilityNodeProviderCompat.n_AddExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_));
			}
			return AccessibilityNodeProviderCompat.cb_addExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00028BB8 File Offset: 0x00026DB8
		private static void n_AddExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, int virtualViewId, IntPtr native_info, IntPtr native_extraDataKey, IntPtr native_arguments)
		{
			AccessibilityNodeProviderCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat object2 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(native_info, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_extraDataKey, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
			@object.AddExtraDataToAccessibilityNodeInfo(virtualViewId, object2, @string, object3);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00028BF0 File Offset: 0x00026DF0
		[Register("addExtraDataToAccessibilityNodeInfo", "(ILandroidx/core/view/accessibility/AccessibilityNodeInfoCompat;Ljava/lang/String;Landroid/os/Bundle;)V", "GetAddExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public unsafe virtual void AddExtraDataToAccessibilityNodeInfo(int virtualViewId, AccessibilityNodeInfoCompat info, string extraDataKey, Bundle arguments)
		{
			IntPtr intPtr = JNIEnv.NewString(extraDataKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(virtualViewId);
				ptr[1] = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
				AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addExtraDataToAccessibilityNodeInfo.(ILandroidx/core/view/accessibility/AccessibilityNodeInfoCompat;Ljava/lang/String;Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(info);
				GC.KeepAlive(arguments);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00028CB8 File Offset: 0x00026EB8
		private static Delegate GetCreateAccessibilityNodeInfo_IHandler()
		{
			if (AccessibilityNodeProviderCompat.cb_createAccessibilityNodeInfo_I == null)
			{
				AccessibilityNodeProviderCompat.cb_createAccessibilityNodeInfo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeProviderCompat.n_CreateAccessibilityNodeInfo_I));
			}
			return AccessibilityNodeProviderCompat.cb_createAccessibilityNodeInfo_I;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00028CDC File Offset: 0x00026EDC
		private static IntPtr n_CreateAccessibilityNodeInfo_I(IntPtr jnienv, IntPtr native__this, int virtualViewId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateAccessibilityNodeInfo(virtualViewId));
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00028CF4 File Offset: 0x00026EF4
		[Register("createAccessibilityNodeInfo", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetCreateAccessibilityNodeInfo_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat CreateAccessibilityNodeInfo(int virtualViewId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(virtualViewId);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualObjectMethod("createAccessibilityNodeInfo.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00028D3D File Offset: 0x00026F3D
		private static Delegate GetFindAccessibilityNodeInfosByText_Ljava_lang_String_IHandler()
		{
			if (AccessibilityNodeProviderCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_I == null)
			{
				AccessibilityNodeProviderCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(AccessibilityNodeProviderCompat.n_FindAccessibilityNodeInfosByText_Ljava_lang_String_I));
			}
			return AccessibilityNodeProviderCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_I;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00028D64 File Offset: 0x00026F64
		private static IntPtr n_FindAccessibilityNodeInfosByText_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_text, int virtualViewId)
		{
			AccessibilityNodeProviderCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_text, JniHandleOwnership.DoNotTransfer);
			return JavaList<AccessibilityNodeInfoCompat>.ToLocalJniHandle(@object.FindAccessibilityNodeInfosByText(@string, virtualViewId));
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00028D90 File Offset: 0x00026F90
		[Register("findAccessibilityNodeInfosByText", "(Ljava/lang/String;I)Ljava/util/List;", "GetFindAccessibilityNodeInfosByText_Ljava_lang_String_IHandler")]
		public unsafe virtual IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText(string text, int virtualViewId)
		{
			IntPtr intPtr = JNIEnv.NewString(text);
			IList<AccessibilityNodeInfoCompat> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(virtualViewId);
				result = JavaList<AccessibilityNodeInfoCompat>.FromJniHandle(AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualObjectMethod("findAccessibilityNodeInfosByText.(Ljava/lang/String;I)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00028E10 File Offset: 0x00027010
		private static Delegate GetFindFocus_IHandler()
		{
			if (AccessibilityNodeProviderCompat.cb_findFocus_I == null)
			{
				AccessibilityNodeProviderCompat.cb_findFocus_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeProviderCompat.n_FindFocus_I));
			}
			return AccessibilityNodeProviderCompat.cb_findFocus_I;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00028E34 File Offset: 0x00027034
		private static IntPtr n_FindFocus_I(IntPtr jnienv, IntPtr native__this, int focus)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindFocus(focus));
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00028E4C File Offset: 0x0002704C
		[Register("findFocus", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetFindFocus_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat FindFocus(int focus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(focus);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualObjectMethod("findFocus.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00028E95 File Offset: 0x00027095
		private static Delegate GetPerformAction_IILandroid_os_Bundle_Handler()
		{
			if (AccessibilityNodeProviderCompat.cb_performAction_IILandroid_os_Bundle_ == null)
			{
				AccessibilityNodeProviderCompat.cb_performAction_IILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_Z(AccessibilityNodeProviderCompat.n_PerformAction_IILandroid_os_Bundle_));
			}
			return AccessibilityNodeProviderCompat.cb_performAction_IILandroid_os_Bundle_;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00028EBC File Offset: 0x000270BC
		private static bool n_PerformAction_IILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, int virtualViewId, int action, IntPtr native_arguments)
		{
			AccessibilityNodeProviderCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
			return @object.PerformAction(virtualViewId, action, object2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00028EE4 File Offset: 0x000270E4
		[Register("performAction", "(IILandroid/os/Bundle;)Z", "GetPerformAction_IILandroid_os_Bundle_Handler")]
		public unsafe virtual bool PerformAction(int virtualViewId, int action, Bundle arguments)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(virtualViewId);
				ptr[1] = new JniArgumentValue(action);
				ptr[2] = new JniArgumentValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
				result = AccessibilityNodeProviderCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("performAction.(IILandroid/os/Bundle;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(arguments);
			}
			return result;
		}

		// Token: 0x040003FF RID: 1023
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeProviderCompat", typeof(AccessibilityNodeProviderCompat));

		// Token: 0x04000400 RID: 1024
		private static Delegate cb_getProvider;

		// Token: 0x04000401 RID: 1025
		private static Delegate cb_addExtraDataToAccessibilityNodeInfo_ILandroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Ljava_lang_String_Landroid_os_Bundle_;

		// Token: 0x04000402 RID: 1026
		private static Delegate cb_createAccessibilityNodeInfo_I;

		// Token: 0x04000403 RID: 1027
		private static Delegate cb_findAccessibilityNodeInfosByText_Ljava_lang_String_I;

		// Token: 0x04000404 RID: 1028
		private static Delegate cb_findFocus_I;

		// Token: 0x04000405 RID: 1029
		private static Delegate cb_performAction_IILandroid_os_Bundle_;
	}
}
