using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text.Style;
using Android.Views;
using Android.Views.Accessibility;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000BE RID: 190
	[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat", DoNotGenerateAcw = true)]
	public class AccessibilityNodeInfoCompat : Java.Lang.Object
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00021BCF File Offset: 0x0001FDCF
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00021BE6 File Offset: 0x0001FDE6
		[Register("mParentVirtualDescendantId")]
		public int MParentVirtualDescendantId
		{
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceFields.GetInt32Value("mParentVirtualDescendantId.I", this);
			}
			set
			{
				AccessibilityNodeInfoCompat._members.InstanceFields.SetValue("mParentVirtualDescendantId.I", this, value);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00021C00 File Offset: 0x0001FE00
		internal static IntPtr class_ref
		{
			get
			{
				return AccessibilityNodeInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00021C24 File Offset: 0x0001FE24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityNodeInfoCompat._members;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00021C2C File Offset: 0x0001FE2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityNodeInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00021C50 File Offset: 0x0001FE50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityNodeInfoCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002384 File Offset: 0x00000584
		protected AccessibilityNodeInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00021C5C File Offset: 0x0001FE5C
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe AccessibilityNodeInfoCompat(Java.Lang.Object info) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				base.SetHandle(AccessibilityNodeInfoCompat._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AccessibilityNodeInfoCompat._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(info);
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00021D0C File Offset: 0x0001FF0C
		private static Delegate GetIsAccessibilityDataSensitiveHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isAccessibilityDataSensitive == null)
			{
				AccessibilityNodeInfoCompat.cb_isAccessibilityDataSensitive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsAccessibilityDataSensitive));
			}
			return AccessibilityNodeInfoCompat.cb_isAccessibilityDataSensitive;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00021D30 File Offset: 0x0001FF30
		private static bool n_IsAccessibilityDataSensitive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AccessibilityDataSensitive;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00021D3F File Offset: 0x0001FF3F
		private static Delegate GetSetAccessibilityDataSensitive_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setAccessibilityDataSensitive_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setAccessibilityDataSensitive_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetAccessibilityDataSensitive_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setAccessibilityDataSensitive_Z;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00021D63 File Offset: 0x0001FF63
		private static void n_SetAccessibilityDataSensitive_Z(IntPtr jnienv, IntPtr native__this, bool accessibilityDataSensitive)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AccessibilityDataSensitive = accessibilityDataSensitive;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00021D73 File Offset: 0x0001FF73
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00021D8C File Offset: 0x0001FF8C
		public unsafe virtual bool AccessibilityDataSensitive
		{
			[Register("isAccessibilityDataSensitive", "()Z", "GetIsAccessibilityDataSensitiveHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isAccessibilityDataSensitive.()Z", this, null);
			}
			[Register("setAccessibilityDataSensitive", "(Z)V", "GetSetAccessibilityDataSensitive_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessibilityDataSensitive.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00021DC7 File Offset: 0x0001FFC7
		private static Delegate GetIsAccessibilityFocusedHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isAccessibilityFocused == null)
			{
				AccessibilityNodeInfoCompat.cb_isAccessibilityFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsAccessibilityFocused));
			}
			return AccessibilityNodeInfoCompat.cb_isAccessibilityFocused;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00021DEB File Offset: 0x0001FFEB
		private static bool n_IsAccessibilityFocused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AccessibilityFocused;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00021DFA File Offset: 0x0001FFFA
		private static Delegate GetSetAccessibilityFocused_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setAccessibilityFocused_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setAccessibilityFocused_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetAccessibilityFocused_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setAccessibilityFocused_Z;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00021E1E File Offset: 0x0002001E
		private static void n_SetAccessibilityFocused_Z(IntPtr jnienv, IntPtr native__this, bool focused)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AccessibilityFocused = focused;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00021E2E File Offset: 0x0002002E
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00021E48 File Offset: 0x00020048
		public unsafe virtual bool AccessibilityFocused
		{
			[Register("isAccessibilityFocused", "()Z", "GetIsAccessibilityFocusedHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isAccessibilityFocused.()Z", this, null);
			}
			[Register("setAccessibilityFocused", "(Z)V", "GetSetAccessibilityFocused_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessibilityFocused.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00021E83 File Offset: 0x00020083
		private static Delegate GetGetActionListHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getActionList == null)
			{
				AccessibilityNodeInfoCompat.cb_getActionList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetActionList));
			}
			return AccessibilityNodeInfoCompat.cb_getActionList;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00021EA7 File Offset: 0x000200A7
		private static IntPtr n_GetActionList(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<AccessibilityNodeInfoCompat.AccessibilityActionCompat>.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionList);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00021EBC File Offset: 0x000200BC
		public virtual IList<AccessibilityNodeInfoCompat.AccessibilityActionCompat> ActionList
		{
			[Register("getActionList", "()Ljava/util/List;", "GetGetActionListHandler")]
			get
			{
				return JavaList<AccessibilityNodeInfoCompat.AccessibilityActionCompat>.FromJniHandle(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getActionList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00021EEE File Offset: 0x000200EE
		private static Delegate GetGetActionsHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getActions == null)
			{
				AccessibilityNodeInfoCompat.cb_getActions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetActions));
			}
			return AccessibilityNodeInfoCompat.cb_getActions;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00021F12 File Offset: 0x00020112
		private static int n_GetActions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Actions;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00021F21 File Offset: 0x00020121
		public virtual int Actions
		{
			[Register("getActions", "()I", "GetGetActionsHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getActions.()I", this, null);
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00021F3A File Offset: 0x0002013A
		private static Delegate GetGetAvailableExtraDataHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getAvailableExtraData == null)
			{
				AccessibilityNodeInfoCompat.cb_getAvailableExtraData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetAvailableExtraData));
			}
			return AccessibilityNodeInfoCompat.cb_getAvailableExtraData;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00021F5E File Offset: 0x0002015E
		private static IntPtr n_GetAvailableExtraData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AvailableExtraData);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00021F72 File Offset: 0x00020172
		private static Delegate GetSetAvailableExtraData_Ljava_util_List_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setAvailableExtraData_Ljava_util_List_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setAvailableExtraData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetAvailableExtraData_Ljava_util_List_));
			}
			return AccessibilityNodeInfoCompat.cb_setAvailableExtraData_Ljava_util_List_;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00021F98 File Offset: 0x00020198
		private static void n_SetAvailableExtraData_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_extraDataKeys)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> availableExtraData = JavaList<string>.FromJniHandle(native_extraDataKeys, JniHandleOwnership.DoNotTransfer);
			@object.AvailableExtraData = availableExtraData;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00021FBC File Offset: 0x000201BC
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00021FF0 File Offset: 0x000201F0
		public unsafe virtual IList<string> AvailableExtraData
		{
			[Register("getAvailableExtraData", "()Ljava/util/List;", "GetGetAvailableExtraDataHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getAvailableExtraData.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setAvailableExtraData", "(Ljava/util/List;)V", "GetSetAvailableExtraData_Ljava_util_List_Handler")]
			set
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setAvailableExtraData.(Ljava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00022054 File Offset: 0x00020254
		private static Delegate GetIsCheckableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isCheckable == null)
			{
				AccessibilityNodeInfoCompat.cb_isCheckable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsCheckable));
			}
			return AccessibilityNodeInfoCompat.cb_isCheckable;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00022078 File Offset: 0x00020278
		private static bool n_IsCheckable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checkable;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00022087 File Offset: 0x00020287
		private static Delegate GetSetCheckable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setCheckable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setCheckable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetCheckable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setCheckable_Z;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000220AB File Offset: 0x000202AB
		private static void n_SetCheckable_Z(IntPtr jnienv, IntPtr native__this, bool checkable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checkable = checkable;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x000220BB File Offset: 0x000202BB
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x000220D4 File Offset: 0x000202D4
		public unsafe virtual bool Checkable
		{
			[Register("isCheckable", "()Z", "GetIsCheckableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isCheckable.()Z", this, null);
			}
			[Register("setCheckable", "(Z)V", "GetSetCheckable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setCheckable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002210F File Offset: 0x0002030F
		private static Delegate GetIsCheckedHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isChecked == null)
			{
				AccessibilityNodeInfoCompat.cb_isChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsChecked));
			}
			return AccessibilityNodeInfoCompat.cb_isChecked;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00022133 File Offset: 0x00020333
		private static bool n_IsChecked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00022142 File Offset: 0x00020342
		private static Delegate GetSetChecked_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setChecked_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setChecked_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetChecked_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setChecked_Z;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00022166 File Offset: 0x00020366
		private static void n_SetChecked_Z(IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked = @checked;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00022176 File Offset: 0x00020376
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00022190 File Offset: 0x00020390
		public unsafe virtual bool Checked
		{
			[Register("isChecked", "()Z", "GetIsCheckedHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isChecked.()Z", this, null);
			}
			[Register("setChecked", "(Z)V", "GetSetChecked_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setChecked.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000221CB File Offset: 0x000203CB
		private static Delegate GetGetChildCountHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getChildCount == null)
			{
				AccessibilityNodeInfoCompat.cb_getChildCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetChildCount));
			}
			return AccessibilityNodeInfoCompat.cb_getChildCount;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000221EF File Offset: 0x000203EF
		private static int n_GetChildCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildCount;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000221FE File Offset: 0x000203FE
		public virtual int ChildCount
		{
			[Register("getChildCount", "()I", "GetGetChildCountHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getChildCount.()I", this, null);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00022217 File Offset: 0x00020417
		private static Delegate GetGetClassNameHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getClassName == null)
			{
				AccessibilityNodeInfoCompat.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetClassName));
			}
			return AccessibilityNodeInfoCompat.cb_getClassName;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0002223B File Offset: 0x0002043B
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassNameFormatted);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0002224F File Offset: 0x0002044F
		private static Delegate GetSetClassName_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setClassName_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setClassName_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetClassName_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setClassName_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00022274 File Offset: 0x00020474
		private static void n_SetClassName_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_className)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_className, JniHandleOwnership.DoNotTransfer);
			@object.ClassNameFormatted = object2;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00022298 File Offset: 0x00020498
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x000222CC File Offset: 0x000204CC
		public unsafe virtual ICharSequence ClassNameFormatted
		{
			[Register("getClassName", "()Ljava/lang/CharSequence;", "GetGetClassNameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setClassName", "(Ljava/lang/CharSequence;)V", "GetSetClassName_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setClassName.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00022330 File Offset: 0x00020530
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00022348 File Offset: 0x00020548
		public string ClassName
		{
			get
			{
				if (this.ClassNameFormatted != null)
				{
					return this.ClassNameFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.ClassNameFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00022372 File Offset: 0x00020572
		private static Delegate GetIsClickableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isClickable == null)
			{
				AccessibilityNodeInfoCompat.cb_isClickable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsClickable));
			}
			return AccessibilityNodeInfoCompat.cb_isClickable;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00022396 File Offset: 0x00020596
		private static bool n_IsClickable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clickable;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000223A5 File Offset: 0x000205A5
		private static Delegate GetSetClickable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setClickable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setClickable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetClickable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setClickable_Z;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000223C9 File Offset: 0x000205C9
		private static void n_SetClickable_Z(IntPtr jnienv, IntPtr native__this, bool clickable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clickable = clickable;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000223D9 File Offset: 0x000205D9
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x000223F4 File Offset: 0x000205F4
		public unsafe virtual bool Clickable
		{
			[Register("isClickable", "()Z", "GetIsClickableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isClickable.()Z", this, null);
			}
			[Register("setClickable", "(Z)V", "GetSetClickable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setClickable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002242F File Offset: 0x0002062F
		private static Delegate GetGetCollectionInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getCollectionInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getCollectionInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetCollectionInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getCollectionInfo;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00022453 File Offset: 0x00020653
		private static IntPtr n_GetCollectionInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollectionInfo);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00022468 File Offset: 0x00020668
		public virtual AccessibilityNodeInfoCompat.CollectionInfoCompat CollectionInfo
		{
			[Register("getCollectionInfo", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", "GetGetCollectionInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getCollectionInfo.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002249A File Offset: 0x0002069A
		private static Delegate GetGetCollectionItemInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getCollectionItemInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getCollectionItemInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetCollectionItemInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getCollectionItemInfo;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000224BE File Offset: 0x000206BE
		private static IntPtr n_GetCollectionItemInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollectionItemInfo);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000224D4 File Offset: 0x000206D4
		public virtual AccessibilityNodeInfoCompat.CollectionItemInfoCompat CollectionItemInfo
		{
			[Register("getCollectionItemInfo", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", "GetGetCollectionItemInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getCollectionItemInfo.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00022506 File Offset: 0x00020706
		private static Delegate GetGetContainerTitleHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getContainerTitle == null)
			{
				AccessibilityNodeInfoCompat.cb_getContainerTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetContainerTitle));
			}
			return AccessibilityNodeInfoCompat.cb_getContainerTitle;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0002252A File Offset: 0x0002072A
		private static IntPtr n_GetContainerTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContainerTitleFormatted);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002253E File Offset: 0x0002073E
		private static Delegate GetSetContainerTitle_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setContainerTitle_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setContainerTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetContainerTitle_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setContainerTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00022564 File Offset: 0x00020764
		private static void n_SetContainerTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_containerTitle)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_containerTitle, JniHandleOwnership.DoNotTransfer);
			@object.ContainerTitleFormatted = object2;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00022588 File Offset: 0x00020788
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000225BC File Offset: 0x000207BC
		public unsafe virtual ICharSequence ContainerTitleFormatted
		{
			[Register("getContainerTitle", "()Ljava/lang/CharSequence;", "GetGetContainerTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getContainerTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setContainerTitle", "(Ljava/lang/CharSequence;)V", "GetSetContainerTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setContainerTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00022620 File Offset: 0x00020820
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00022638 File Offset: 0x00020838
		public string ContainerTitle
		{
			get
			{
				if (this.ContainerTitleFormatted != null)
				{
					return this.ContainerTitleFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.ContainerTitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00022662 File Offset: 0x00020862
		private static Delegate GetGetContentDescriptionHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getContentDescription == null)
			{
				AccessibilityNodeInfoCompat.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetContentDescription));
			}
			return AccessibilityNodeInfoCompat.cb_getContentDescription;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00022686 File Offset: 0x00020886
		private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002269A File Offset: 0x0002089A
		private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetContentDescription_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000226C0 File Offset: 0x000208C0
		private static void n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDescription, JniHandleOwnership.DoNotTransfer);
			@object.ContentDescriptionFormatted = object2;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000226E4 File Offset: 0x000208E4
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00022718 File Offset: 0x00020918
		public unsafe virtual ICharSequence ContentDescriptionFormatted
		{
			[Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0002277C File Offset: 0x0002097C
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00022794 File Offset: 0x00020994
		public string ContentDescription
		{
			get
			{
				if (this.ContentDescriptionFormatted != null)
				{
					return this.ContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.ContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000227BE File Offset: 0x000209BE
		private static Delegate GetIsContentInvalidHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isContentInvalid == null)
			{
				AccessibilityNodeInfoCompat.cb_isContentInvalid = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsContentInvalid));
			}
			return AccessibilityNodeInfoCompat.cb_isContentInvalid;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000227E2 File Offset: 0x000209E2
		private static bool n_IsContentInvalid(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInvalid;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000227F1 File Offset: 0x000209F1
		private static Delegate GetSetContentInvalid_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setContentInvalid_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setContentInvalid_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetContentInvalid_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setContentInvalid_Z;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00022815 File Offset: 0x00020A15
		private static void n_SetContentInvalid_Z(IntPtr jnienv, IntPtr native__this, bool contentInvalid)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInvalid = contentInvalid;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00022825 File Offset: 0x00020A25
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00022840 File Offset: 0x00020A40
		public unsafe virtual bool ContentInvalid
		{
			[Register("isContentInvalid", "()Z", "GetIsContentInvalidHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isContentInvalid.()Z", this, null);
			}
			[Register("setContentInvalid", "(Z)V", "GetSetContentInvalid_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setContentInvalid.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002287B File Offset: 0x00020A7B
		private static Delegate GetIsContextClickableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isContextClickable == null)
			{
				AccessibilityNodeInfoCompat.cb_isContextClickable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsContextClickable));
			}
			return AccessibilityNodeInfoCompat.cb_isContextClickable;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002289F File Offset: 0x00020A9F
		private static bool n_IsContextClickable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContextClickable;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000228AE File Offset: 0x00020AAE
		private static Delegate GetSetContextClickable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setContextClickable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setContextClickable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetContextClickable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setContextClickable_Z;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000228D2 File Offset: 0x00020AD2
		private static void n_SetContextClickable_Z(IntPtr jnienv, IntPtr native__this, bool contextClickable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContextClickable = contextClickable;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000228E2 File Offset: 0x00020AE2
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000228FC File Offset: 0x00020AFC
		public unsafe virtual bool ContextClickable
		{
			[Register("isContextClickable", "()Z", "GetIsContextClickableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isContextClickable.()Z", this, null);
			}
			[Register("setContextClickable", "(Z)V", "GetSetContextClickable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setContextClickable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00022937 File Offset: 0x00020B37
		private static Delegate GetIsDismissableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isDismissable == null)
			{
				AccessibilityNodeInfoCompat.cb_isDismissable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsDismissable));
			}
			return AccessibilityNodeInfoCompat.cb_isDismissable;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0002295B File Offset: 0x00020B5B
		private static bool n_IsDismissable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismissable;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0002296A File Offset: 0x00020B6A
		private static Delegate GetSetDismissable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setDismissable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setDismissable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetDismissable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setDismissable_Z;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0002298E File Offset: 0x00020B8E
		private static void n_SetDismissable_Z(IntPtr jnienv, IntPtr native__this, bool dismissable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismissable = dismissable;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002299E File Offset: 0x00020B9E
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x000229B8 File Offset: 0x00020BB8
		public unsafe virtual bool Dismissable
		{
			[Register("isDismissable", "()Z", "GetIsDismissableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isDismissable.()Z", this, null);
			}
			[Register("setDismissable", "(Z)V", "GetSetDismissable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setDismissable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000229F3 File Offset: 0x00020BF3
		private static Delegate GetGetDrawingOrderHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getDrawingOrder == null)
			{
				AccessibilityNodeInfoCompat.cb_getDrawingOrder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetDrawingOrder));
			}
			return AccessibilityNodeInfoCompat.cb_getDrawingOrder;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00022A17 File Offset: 0x00020C17
		private static int n_GetDrawingOrder(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawingOrder;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00022A26 File Offset: 0x00020C26
		private static Delegate GetSetDrawingOrder_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setDrawingOrder_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setDrawingOrder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_SetDrawingOrder_I));
			}
			return AccessibilityNodeInfoCompat.cb_setDrawingOrder_I;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00022A4A File Offset: 0x00020C4A
		private static void n_SetDrawingOrder_I(IntPtr jnienv, IntPtr native__this, int drawingOrderInParent)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawingOrder = drawingOrderInParent;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00022A5A File Offset: 0x00020C5A
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00022A74 File Offset: 0x00020C74
		public unsafe virtual int DrawingOrder
		{
			[Register("getDrawingOrder", "()I", "GetGetDrawingOrderHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getDrawingOrder.()I", this, null);
			}
			[Register("setDrawingOrder", "(I)V", "GetSetDrawingOrder_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawingOrder.(I)V", this, ptr);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00022AAF File Offset: 0x00020CAF
		private static Delegate GetIsEditableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isEditable == null)
			{
				AccessibilityNodeInfoCompat.cb_isEditable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsEditable));
			}
			return AccessibilityNodeInfoCompat.cb_isEditable;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00022AD3 File Offset: 0x00020CD3
		private static bool n_IsEditable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Editable;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00022AE2 File Offset: 0x00020CE2
		private static Delegate GetSetEditable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setEditable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setEditable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetEditable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setEditable_Z;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00022B06 File Offset: 0x00020D06
		private static void n_SetEditable_Z(IntPtr jnienv, IntPtr native__this, bool editable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Editable = editable;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00022B16 File Offset: 0x00020D16
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00022B30 File Offset: 0x00020D30
		public unsafe virtual bool Editable
		{
			[Register("isEditable", "()Z", "GetIsEditableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isEditable.()Z", this, null);
			}
			[Register("setEditable", "(Z)V", "GetSetEditable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setEditable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00022B6B File Offset: 0x00020D6B
		private static Delegate GetIsEnabledHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isEnabled == null)
			{
				AccessibilityNodeInfoCompat.cb_isEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsEnabled));
			}
			return AccessibilityNodeInfoCompat.cb_isEnabled;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00022B8F File Offset: 0x00020D8F
		private static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enabled;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00022B9E File Offset: 0x00020D9E
		private static Delegate GetSetEnabled_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setEnabled_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetEnabled_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setEnabled_Z;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00022BC2 File Offset: 0x00020DC2
		private static void n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enabled = enabled;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00022BD2 File Offset: 0x00020DD2
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00022BEC File Offset: 0x00020DEC
		public unsafe virtual bool Enabled
		{
			[Register("isEnabled", "()Z", "GetIsEnabledHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnabled.()Z", this, null);
			}
			[Register("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00022C27 File Offset: 0x00020E27
		private static Delegate GetGetErrorHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getError == null)
			{
				AccessibilityNodeInfoCompat.cb_getError = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetError));
			}
			return AccessibilityNodeInfoCompat.cb_getError;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00022C4B File Offset: 0x00020E4B
		private static IntPtr n_GetError(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorFormatted);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00022C5F File Offset: 0x00020E5F
		private static Delegate GetSetError_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setError_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setError_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetError_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setError_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00022C84 File Offset: 0x00020E84
		private static void n_SetError_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_error, JniHandleOwnership.DoNotTransfer);
			@object.ErrorFormatted = object2;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00022CA8 File Offset: 0x00020EA8
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00022CDC File Offset: 0x00020EDC
		public unsafe virtual ICharSequence ErrorFormatted
		{
			[Register("getError", "()Ljava/lang/CharSequence;", "GetGetErrorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getError.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setError", "(Ljava/lang/CharSequence;)V", "GetSetError_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setError.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00022D40 File Offset: 0x00020F40
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00022D58 File Offset: 0x00020F58
		public string Error
		{
			get
			{
				if (this.ErrorFormatted != null)
				{
					return this.ErrorFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.ErrorFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00022D82 File Offset: 0x00020F82
		private static Delegate GetGetExtraRenderingInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getExtraRenderingInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getExtraRenderingInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetExtraRenderingInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getExtraRenderingInfo;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00022DA6 File Offset: 0x00020FA6
		private static IntPtr n_GetExtraRenderingInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExtraRenderingInfo);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00022DBC File Offset: 0x00020FBC
		public virtual AccessibilityNodeInfo.ExtraRenderingInfo ExtraRenderingInfo
		{
			[Register("getExtraRenderingInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo$ExtraRenderingInfo;", "GetGetExtraRenderingInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfo.ExtraRenderingInfo>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getExtraRenderingInfo.()Landroid/view/accessibility/AccessibilityNodeInfo$ExtraRenderingInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00022DEE File Offset: 0x00020FEE
		private static Delegate GetGetExtrasHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getExtras == null)
			{
				AccessibilityNodeInfoCompat.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetExtras));
			}
			return AccessibilityNodeInfoCompat.cb_getExtras;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00022E12 File Offset: 0x00021012
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00022E28 File Offset: 0x00021028
		public virtual Bundle Extras
		{
			[Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00022E5A File Offset: 0x0002105A
		private static Delegate GetIsFocusableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isFocusable == null)
			{
				AccessibilityNodeInfoCompat.cb_isFocusable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsFocusable));
			}
			return AccessibilityNodeInfoCompat.cb_isFocusable;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00022E7E File Offset: 0x0002107E
		private static bool n_IsFocusable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Focusable;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00022E8D File Offset: 0x0002108D
		private static Delegate GetSetFocusable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setFocusable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setFocusable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetFocusable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setFocusable_Z;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00022EB1 File Offset: 0x000210B1
		private static void n_SetFocusable_Z(IntPtr jnienv, IntPtr native__this, bool focusable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Focusable = focusable;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00022EC1 File Offset: 0x000210C1
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00022EDC File Offset: 0x000210DC
		public unsafe virtual bool Focusable
		{
			[Register("isFocusable", "()Z", "GetIsFocusableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isFocusable.()Z", this, null);
			}
			[Register("setFocusable", "(Z)V", "GetSetFocusable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setFocusable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00022F17 File Offset: 0x00021117
		private static Delegate GetIsFocusedHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isFocused == null)
			{
				AccessibilityNodeInfoCompat.cb_isFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsFocused));
			}
			return AccessibilityNodeInfoCompat.cb_isFocused;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00022F3B File Offset: 0x0002113B
		private static bool n_IsFocused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Focused;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00022F4A File Offset: 0x0002114A
		private static Delegate GetSetFocused_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setFocused_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setFocused_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetFocused_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setFocused_Z;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00022F6E File Offset: 0x0002116E
		private static void n_SetFocused_Z(IntPtr jnienv, IntPtr native__this, bool focused)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Focused = focused;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00022F7E File Offset: 0x0002117E
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00022F98 File Offset: 0x00021198
		public unsafe virtual bool Focused
		{
			[Register("isFocused", "()Z", "GetIsFocusedHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isFocused.()Z", this, null);
			}
			[Register("setFocused", "(Z)V", "GetSetFocused_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setFocused.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00022FD3 File Offset: 0x000211D3
		private static Delegate GetIsGranularScrollingSupportedHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isGranularScrollingSupported == null)
			{
				AccessibilityNodeInfoCompat.cb_isGranularScrollingSupported = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsGranularScrollingSupported));
			}
			return AccessibilityNodeInfoCompat.cb_isGranularScrollingSupported;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00022FF7 File Offset: 0x000211F7
		private static bool n_IsGranularScrollingSupported(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GranularScrollingSupported;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00023006 File Offset: 0x00021206
		private static Delegate GetSetGranularScrollingSupported_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setGranularScrollingSupported_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setGranularScrollingSupported_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetGranularScrollingSupported_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setGranularScrollingSupported_Z;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0002302A File Offset: 0x0002122A
		private static void n_SetGranularScrollingSupported_Z(IntPtr jnienv, IntPtr native__this, bool granularScrollingSupported)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GranularScrollingSupported = granularScrollingSupported;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002303A File Offset: 0x0002123A
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00023054 File Offset: 0x00021254
		public unsafe virtual bool GranularScrollingSupported
		{
			[Register("isGranularScrollingSupported", "()Z", "GetIsGranularScrollingSupportedHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isGranularScrollingSupported.()Z", this, null);
			}
			[Register("setGranularScrollingSupported", "(Z)V", "GetSetGranularScrollingSupported_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setGranularScrollingSupported.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0002308F File Offset: 0x0002128F
		private static Delegate GetHasRequestInitialAccessibilityFocusHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_hasRequestInitialAccessibilityFocus == null)
			{
				AccessibilityNodeInfoCompat.cb_hasRequestInitialAccessibilityFocus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_HasRequestInitialAccessibilityFocus));
			}
			return AccessibilityNodeInfoCompat.cb_hasRequestInitialAccessibilityFocus;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000230B3 File Offset: 0x000212B3
		private static bool n_HasRequestInitialAccessibilityFocus(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasRequestInitialAccessibilityFocus;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000230C2 File Offset: 0x000212C2
		public virtual bool HasRequestInitialAccessibilityFocus
		{
			[Register("hasRequestInitialAccessibilityFocus", "()Z", "GetHasRequestInitialAccessibilityFocusHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasRequestInitialAccessibilityFocus.()Z", this, null);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000230DB File Offset: 0x000212DB
		private static Delegate GetIsHeadingHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isHeading == null)
			{
				AccessibilityNodeInfoCompat.cb_isHeading = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsHeading));
			}
			return AccessibilityNodeInfoCompat.cb_isHeading;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000230FF File Offset: 0x000212FF
		private static bool n_IsHeading(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Heading;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0002310E File Offset: 0x0002130E
		private static Delegate GetSetHeading_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setHeading_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setHeading_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetHeading_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setHeading_Z;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00023132 File Offset: 0x00021332
		private static void n_SetHeading_Z(IntPtr jnienv, IntPtr native__this, bool isHeading)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Heading = isHeading;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00023142 File Offset: 0x00021342
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0002315C File Offset: 0x0002135C
		public unsafe virtual bool Heading
		{
			[Register("isHeading", "()Z", "GetIsHeadingHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isHeading.()Z", this, null);
			}
			[Register("setHeading", "(Z)V", "GetSetHeading_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setHeading.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00023197 File Offset: 0x00021397
		private static Delegate GetGetHintTextHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getHintText == null)
			{
				AccessibilityNodeInfoCompat.cb_getHintText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetHintText));
			}
			return AccessibilityNodeInfoCompat.cb_getHintText;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000231BB File Offset: 0x000213BB
		private static IntPtr n_GetHintText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintTextFormatted);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000231CF File Offset: 0x000213CF
		private static Delegate GetSetHintText_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setHintText_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setHintText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetHintText_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setHintText_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000231F4 File Offset: 0x000213F4
		private static void n_SetHintText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_hintText)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_hintText, JniHandleOwnership.DoNotTransfer);
			@object.HintTextFormatted = object2;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00023218 File Offset: 0x00021418
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0002324C File Offset: 0x0002144C
		public unsafe virtual ICharSequence HintTextFormatted
		{
			[Register("getHintText", "()Ljava/lang/CharSequence;", "GetGetHintTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getHintText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setHintText", "(Ljava/lang/CharSequence;)V", "GetSetHintText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setHintText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000232B0 File Offset: 0x000214B0
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x000232C8 File Offset: 0x000214C8
		public string HintText
		{
			get
			{
				if (this.HintTextFormatted != null)
				{
					return this.HintTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.HintTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000232F2 File Offset: 0x000214F2
		private static Delegate GetIsImportantForAccessibilityHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isImportantForAccessibility == null)
			{
				AccessibilityNodeInfoCompat.cb_isImportantForAccessibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsImportantForAccessibility));
			}
			return AccessibilityNodeInfoCompat.cb_isImportantForAccessibility;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00023316 File Offset: 0x00021516
		private static bool n_IsImportantForAccessibility(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImportantForAccessibility;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00023325 File Offset: 0x00021525
		private static Delegate GetSetImportantForAccessibility_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setImportantForAccessibility_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setImportantForAccessibility_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetImportantForAccessibility_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setImportantForAccessibility_Z;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00023349 File Offset: 0x00021549
		private static void n_SetImportantForAccessibility_Z(IntPtr jnienv, IntPtr native__this, bool important)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImportantForAccessibility = important;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00023359 File Offset: 0x00021559
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00023374 File Offset: 0x00021574
		public unsafe virtual bool ImportantForAccessibility
		{
			[Register("isImportantForAccessibility", "()Z", "GetIsImportantForAccessibilityHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isImportantForAccessibility.()Z", this, null);
			}
			[Register("setImportantForAccessibility", "(Z)V", "GetSetImportantForAccessibility_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setImportantForAccessibility.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000233AF File Offset: 0x000215AF
		private static Delegate GetGetInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getInfo;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000233D3 File Offset: 0x000215D3
		private static IntPtr n_GetInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Info);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x000233E8 File Offset: 0x000215E8
		public virtual Java.Lang.Object Info
		{
			[Register("getInfo", "()Ljava/lang/Object;", "GetGetInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getInfo.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0002341A File Offset: 0x0002161A
		private static Delegate GetGetInputTypeHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getInputType == null)
			{
				AccessibilityNodeInfoCompat.cb_getInputType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetInputType));
			}
			return AccessibilityNodeInfoCompat.cb_getInputType;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0002343E File Offset: 0x0002163E
		private static int n_GetInputType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InputType;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002344D File Offset: 0x0002164D
		private static Delegate GetSetInputType_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setInputType_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setInputType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_SetInputType_I));
			}
			return AccessibilityNodeInfoCompat.cb_setInputType_I;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00023471 File Offset: 0x00021671
		private static void n_SetInputType_I(IntPtr jnienv, IntPtr native__this, int inputType)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InputType = inputType;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00023481 File Offset: 0x00021681
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0002349C File Offset: 0x0002169C
		public unsafe virtual int InputType
		{
			[Register("getInputType", "()I", "GetGetInputTypeHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getInputType.()I", this, null);
			}
			[Register("setInputType", "(I)V", "GetSetInputType_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setInputType.(I)V", this, ptr);
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000234D7 File Offset: 0x000216D7
		private static Delegate GetGetLabelForHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getLabelFor == null)
			{
				AccessibilityNodeInfoCompat.cb_getLabelFor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetLabelFor));
			}
			return AccessibilityNodeInfoCompat.cb_getLabelFor;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000234FB File Offset: 0x000216FB
		private static IntPtr n_GetLabelFor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LabelFor);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00023510 File Offset: 0x00021710
		public virtual AccessibilityNodeInfoCompat LabelFor
		{
			[Register("getLabelFor", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetLabelForHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLabelFor.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00023542 File Offset: 0x00021742
		private static Delegate GetGetLabeledByHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getLabeledBy == null)
			{
				AccessibilityNodeInfoCompat.cb_getLabeledBy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetLabeledBy));
			}
			return AccessibilityNodeInfoCompat.cb_getLabeledBy;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00023566 File Offset: 0x00021766
		private static IntPtr n_GetLabeledBy(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LabeledBy);
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0002357C File Offset: 0x0002177C
		public virtual AccessibilityNodeInfoCompat LabeledBy
		{
			[Register("getLabeledBy", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetLabeledByHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLabeledBy.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000235AE File Offset: 0x000217AE
		private static Delegate GetGetLiveRegionHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getLiveRegion == null)
			{
				AccessibilityNodeInfoCompat.cb_getLiveRegion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetLiveRegion));
			}
			return AccessibilityNodeInfoCompat.cb_getLiveRegion;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000235D2 File Offset: 0x000217D2
		private static int n_GetLiveRegion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LiveRegion;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000235E1 File Offset: 0x000217E1
		private static Delegate GetSetLiveRegion_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLiveRegion_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setLiveRegion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_SetLiveRegion_I));
			}
			return AccessibilityNodeInfoCompat.cb_setLiveRegion_I;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00023605 File Offset: 0x00021805
		private static void n_SetLiveRegion_I(IntPtr jnienv, IntPtr native__this, int mode)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LiveRegion = mode;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00023615 File Offset: 0x00021815
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00023630 File Offset: 0x00021830
		public unsafe virtual int LiveRegion
		{
			[Register("getLiveRegion", "()I", "GetGetLiveRegionHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getLiveRegion.()I", this, null);
			}
			[Register("setLiveRegion", "(I)V", "GetSetLiveRegion_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLiveRegion.(I)V", this, ptr);
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002366B File Offset: 0x0002186B
		private static Delegate GetIsLongClickableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isLongClickable == null)
			{
				AccessibilityNodeInfoCompat.cb_isLongClickable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsLongClickable));
			}
			return AccessibilityNodeInfoCompat.cb_isLongClickable;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0002368F File Offset: 0x0002188F
		private static bool n_IsLongClickable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongClickable;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002369E File Offset: 0x0002189E
		private static Delegate GetSetLongClickable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLongClickable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setLongClickable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetLongClickable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setLongClickable_Z;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000236C2 File Offset: 0x000218C2
		private static void n_SetLongClickable_Z(IntPtr jnienv, IntPtr native__this, bool longClickable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LongClickable = longClickable;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000236D2 File Offset: 0x000218D2
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x000236EC File Offset: 0x000218EC
		public unsafe virtual bool LongClickable
		{
			[Register("isLongClickable", "()Z", "GetIsLongClickableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isLongClickable.()Z", this, null);
			}
			[Register("setLongClickable", "(Z)V", "GetSetLongClickable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLongClickable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00023727 File Offset: 0x00021927
		private static Delegate GetGetMaxTextLengthHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getMaxTextLength == null)
			{
				AccessibilityNodeInfoCompat.cb_getMaxTextLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetMaxTextLength));
			}
			return AccessibilityNodeInfoCompat.cb_getMaxTextLength;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002374B File Offset: 0x0002194B
		private static int n_GetMaxTextLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxTextLength;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002375A File Offset: 0x0002195A
		private static Delegate GetSetMaxTextLength_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setMaxTextLength_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setMaxTextLength_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_SetMaxTextLength_I));
			}
			return AccessibilityNodeInfoCompat.cb_setMaxTextLength_I;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002377E File Offset: 0x0002197E
		private static void n_SetMaxTextLength_I(IntPtr jnienv, IntPtr native__this, int max)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxTextLength = max;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002378E File Offset: 0x0002198E
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000237A8 File Offset: 0x000219A8
		public unsafe virtual int MaxTextLength
		{
			[Register("getMaxTextLength", "()I", "GetGetMaxTextLengthHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getMaxTextLength.()I", this, null);
			}
			[Register("setMaxTextLength", "(I)V", "GetSetMaxTextLength_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxTextLength.(I)V", this, ptr);
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000237E3 File Offset: 0x000219E3
		private static Delegate GetGetMinDurationBetweenContentChangesMillisHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getMinDurationBetweenContentChangesMillis == null)
			{
				AccessibilityNodeInfoCompat.cb_getMinDurationBetweenContentChangesMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AccessibilityNodeInfoCompat.n_GetMinDurationBetweenContentChangesMillis));
			}
			return AccessibilityNodeInfoCompat.cb_getMinDurationBetweenContentChangesMillis;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00023807 File Offset: 0x00021A07
		private static long n_GetMinDurationBetweenContentChangesMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinDurationBetweenContentChangesMillis;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00023816 File Offset: 0x00021A16
		private static Delegate GetSetMinDurationBetweenContentChangesMillis_JHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setMinDurationBetweenContentChangesMillis_J == null)
			{
				AccessibilityNodeInfoCompat.cb_setMinDurationBetweenContentChangesMillis_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(AccessibilityNodeInfoCompat.n_SetMinDurationBetweenContentChangesMillis_J));
			}
			return AccessibilityNodeInfoCompat.cb_setMinDurationBetweenContentChangesMillis_J;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002383A File Offset: 0x00021A3A
		private static void n_SetMinDurationBetweenContentChangesMillis_J(IntPtr jnienv, IntPtr native__this, long duration)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinDurationBetweenContentChangesMillis = duration;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002384A File Offset: 0x00021A4A
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00023864 File Offset: 0x00021A64
		public unsafe virtual long MinDurationBetweenContentChangesMillis
		{
			[Register("getMinDurationBetweenContentChangesMillis", "()J", "GetGetMinDurationBetweenContentChangesMillisHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt64Method("getMinDurationBetweenContentChangesMillis.()J", this, null);
			}
			[Register("setMinDurationBetweenContentChangesMillis", "(J)V", "GetSetMinDurationBetweenContentChangesMillis_JHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setMinDurationBetweenContentChangesMillis.(J)V", this, ptr);
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002389F File Offset: 0x00021A9F
		private static Delegate GetGetMovementGranularitiesHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getMovementGranularities == null)
			{
				AccessibilityNodeInfoCompat.cb_getMovementGranularities = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetMovementGranularities));
			}
			return AccessibilityNodeInfoCompat.cb_getMovementGranularities;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000238C3 File Offset: 0x00021AC3
		private static int n_GetMovementGranularities(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MovementGranularities;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000238D2 File Offset: 0x00021AD2
		private static Delegate GetSetMovementGranularities_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setMovementGranularities_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setMovementGranularities_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_SetMovementGranularities_I));
			}
			return AccessibilityNodeInfoCompat.cb_setMovementGranularities_I;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000238F6 File Offset: 0x00021AF6
		private static void n_SetMovementGranularities_I(IntPtr jnienv, IntPtr native__this, int granularities)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MovementGranularities = granularities;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00023906 File Offset: 0x00021B06
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x00023920 File Offset: 0x00021B20
		public unsafe virtual int MovementGranularities
		{
			[Register("getMovementGranularities", "()I", "GetGetMovementGranularitiesHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getMovementGranularities.()I", this, null);
			}
			[Register("setMovementGranularities", "(I)V", "GetSetMovementGranularities_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setMovementGranularities.(I)V", this, ptr);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002395B File Offset: 0x00021B5B
		private static Delegate GetIsMultiLineHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isMultiLine == null)
			{
				AccessibilityNodeInfoCompat.cb_isMultiLine = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsMultiLine));
			}
			return AccessibilityNodeInfoCompat.cb_isMultiLine;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002397F File Offset: 0x00021B7F
		private static bool n_IsMultiLine(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MultiLine;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0002398E File Offset: 0x00021B8E
		private static Delegate GetSetMultiLine_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setMultiLine_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setMultiLine_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetMultiLine_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setMultiLine_Z;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000239B2 File Offset: 0x00021BB2
		private static void n_SetMultiLine_Z(IntPtr jnienv, IntPtr native__this, bool multiLine)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MultiLine = multiLine;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000239C2 File Offset: 0x00021BC2
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000239DC File Offset: 0x00021BDC
		public unsafe virtual bool MultiLine
		{
			[Register("isMultiLine", "()Z", "GetIsMultiLineHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isMultiLine.()Z", this, null);
			}
			[Register("setMultiLine", "(Z)V", "GetSetMultiLine_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setMultiLine.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00023A17 File Offset: 0x00021C17
		private static Delegate GetGetPackageNameHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getPackageName == null)
			{
				AccessibilityNodeInfoCompat.cb_getPackageName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetPackageName));
			}
			return AccessibilityNodeInfoCompat.cb_getPackageName;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00023A3B File Offset: 0x00021C3B
		private static IntPtr n_GetPackageName(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PackageNameFormatted);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00023A4F File Offset: 0x00021C4F
		private static Delegate GetSetPackageName_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setPackageName_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setPackageName_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetPackageName_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setPackageName_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00023A74 File Offset: 0x00021C74
		private static void n_SetPackageName_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_packageName, JniHandleOwnership.DoNotTransfer);
			@object.PackageNameFormatted = object2;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00023A98 File Offset: 0x00021C98
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00023ACC File Offset: 0x00021CCC
		public unsafe virtual ICharSequence PackageNameFormatted
		{
			[Register("getPackageName", "()Ljava/lang/CharSequence;", "GetGetPackageNameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getPackageName.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPackageName", "(Ljava/lang/CharSequence;)V", "GetSetPackageName_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setPackageName.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00023B30 File Offset: 0x00021D30
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00023B48 File Offset: 0x00021D48
		public string PackageName
		{
			get
			{
				if (this.PackageNameFormatted != null)
				{
					return this.PackageNameFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.PackageNameFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00023B72 File Offset: 0x00021D72
		private static Delegate GetGetPaneTitleHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getPaneTitle == null)
			{
				AccessibilityNodeInfoCompat.cb_getPaneTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetPaneTitle));
			}
			return AccessibilityNodeInfoCompat.cb_getPaneTitle;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00023B96 File Offset: 0x00021D96
		private static IntPtr n_GetPaneTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaneTitleFormatted);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00023BAA File Offset: 0x00021DAA
		private static Delegate GetSetPaneTitle_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setPaneTitle_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setPaneTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetPaneTitle_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setPaneTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00023BD0 File Offset: 0x00021DD0
		private static void n_SetPaneTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_paneTitle)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_paneTitle, JniHandleOwnership.DoNotTransfer);
			@object.PaneTitleFormatted = object2;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00023BF4 File Offset: 0x00021DF4
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00023C28 File Offset: 0x00021E28
		public unsafe virtual ICharSequence PaneTitleFormatted
		{
			[Register("getPaneTitle", "()Ljava/lang/CharSequence;", "GetGetPaneTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getPaneTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPaneTitle", "(Ljava/lang/CharSequence;)V", "GetSetPaneTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setPaneTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00023C8C File Offset: 0x00021E8C
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00023CA4 File Offset: 0x00021EA4
		public string PaneTitle
		{
			get
			{
				if (this.PaneTitleFormatted != null)
				{
					return this.PaneTitleFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.PaneTitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00023CCE File Offset: 0x00021ECE
		private static Delegate GetGetParentHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getParent == null)
			{
				AccessibilityNodeInfoCompat.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetParent));
			}
			return AccessibilityNodeInfoCompat.cb_getParent;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00023CF2 File Offset: 0x00021EF2
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00023D08 File Offset: 0x00021F08
		public virtual AccessibilityNodeInfoCompat Parent
		{
			[Register("getParent", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetParentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getParent.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00023D3A File Offset: 0x00021F3A
		private static Delegate GetIsPasswordHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isPassword == null)
			{
				AccessibilityNodeInfoCompat.cb_isPassword = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsPassword));
			}
			return AccessibilityNodeInfoCompat.cb_isPassword;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00023D5E File Offset: 0x00021F5E
		private static bool n_IsPassword(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Password;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00023D6D File Offset: 0x00021F6D
		private static Delegate GetSetPassword_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setPassword_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setPassword_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetPassword_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setPassword_Z;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00023D91 File Offset: 0x00021F91
		private static void n_SetPassword_Z(IntPtr jnienv, IntPtr native__this, bool password)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Password = password;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00023DA1 File Offset: 0x00021FA1
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00023DBC File Offset: 0x00021FBC
		public unsafe virtual bool Password
		{
			[Register("isPassword", "()Z", "GetIsPasswordHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isPassword.()Z", this, null);
			}
			[Register("setPassword", "(Z)V", "GetSetPassword_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setPassword.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00023DF7 File Offset: 0x00021FF7
		private static Delegate GetGetRangeInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getRangeInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getRangeInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetRangeInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getRangeInfo;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00023E1B File Offset: 0x0002201B
		private static IntPtr n_GetRangeInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RangeInfo);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00023E2F File Offset: 0x0002202F
		private static Delegate GetSetRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_));
			}
			return AccessibilityNodeInfoCompat.cb_setRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00023E54 File Offset: 0x00022054
		private static void n_SetRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_rangeInfo)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat.RangeInfoCompat object2 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(native_rangeInfo, JniHandleOwnership.DoNotTransfer);
			@object.RangeInfo = object2;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00023E78 File Offset: 0x00022078
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x00023EAC File Offset: 0x000220AC
		public unsafe virtual AccessibilityNodeInfoCompat.RangeInfoCompat RangeInfo
		{
			[Register("getRangeInfo", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;", "GetGetRangeInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getRangeInfo.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRangeInfo", "(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;)V", "GetSetRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setRangeInfo.(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00023F10 File Offset: 0x00022110
		private static Delegate GetGetRoleDescriptionHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getRoleDescription == null)
			{
				AccessibilityNodeInfoCompat.cb_getRoleDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetRoleDescription));
			}
			return AccessibilityNodeInfoCompat.cb_getRoleDescription;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00023F34 File Offset: 0x00022134
		private static IntPtr n_GetRoleDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RoleDescriptionFormatted);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00023F48 File Offset: 0x00022148
		private static Delegate GetSetRoleDescription_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setRoleDescription_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setRoleDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetRoleDescription_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setRoleDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00023F6C File Offset: 0x0002216C
		private static void n_SetRoleDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_roleDescription)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_roleDescription, JniHandleOwnership.DoNotTransfer);
			@object.RoleDescriptionFormatted = object2;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00023F90 File Offset: 0x00022190
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00023FC4 File Offset: 0x000221C4
		public unsafe virtual ICharSequence RoleDescriptionFormatted
		{
			[Register("getRoleDescription", "()Ljava/lang/CharSequence;", "GetGetRoleDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getRoleDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setRoleDescription", "(Ljava/lang/CharSequence;)V", "GetSetRoleDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setRoleDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00024028 File Offset: 0x00022228
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00024040 File Offset: 0x00022240
		public string RoleDescription
		{
			get
			{
				if (this.RoleDescriptionFormatted != null)
				{
					return this.RoleDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.RoleDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002406A File Offset: 0x0002226A
		private static Delegate GetIsScreenReaderFocusableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isScreenReaderFocusable == null)
			{
				AccessibilityNodeInfoCompat.cb_isScreenReaderFocusable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsScreenReaderFocusable));
			}
			return AccessibilityNodeInfoCompat.cb_isScreenReaderFocusable;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002408E File Offset: 0x0002228E
		private static bool n_IsScreenReaderFocusable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScreenReaderFocusable;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002409D File Offset: 0x0002229D
		private static Delegate GetSetScreenReaderFocusable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setScreenReaderFocusable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setScreenReaderFocusable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetScreenReaderFocusable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setScreenReaderFocusable_Z;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000240C1 File Offset: 0x000222C1
		private static void n_SetScreenReaderFocusable_Z(IntPtr jnienv, IntPtr native__this, bool screenReaderFocusable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScreenReaderFocusable = screenReaderFocusable;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000240D1 File Offset: 0x000222D1
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x000240EC File Offset: 0x000222EC
		public unsafe virtual bool ScreenReaderFocusable
		{
			[Register("isScreenReaderFocusable", "()Z", "GetIsScreenReaderFocusableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isScreenReaderFocusable.()Z", this, null);
			}
			[Register("setScreenReaderFocusable", "(Z)V", "GetSetScreenReaderFocusable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setScreenReaderFocusable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00024127 File Offset: 0x00022327
		private static Delegate GetIsScrollableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isScrollable == null)
			{
				AccessibilityNodeInfoCompat.cb_isScrollable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsScrollable));
			}
			return AccessibilityNodeInfoCompat.cb_isScrollable;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0002414B File Offset: 0x0002234B
		private static bool n_IsScrollable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Scrollable;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002415A File Offset: 0x0002235A
		private static Delegate GetSetScrollable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setScrollable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setScrollable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetScrollable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setScrollable_Z;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002417E File Offset: 0x0002237E
		private static void n_SetScrollable_Z(IntPtr jnienv, IntPtr native__this, bool scrollable)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Scrollable = scrollable;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0002418E File Offset: 0x0002238E
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000241A8 File Offset: 0x000223A8
		public unsafe virtual bool Scrollable
		{
			[Register("isScrollable", "()Z", "GetIsScrollableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isScrollable.()Z", this, null);
			}
			[Register("setScrollable", "(Z)V", "GetSetScrollable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setScrollable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000241E3 File Offset: 0x000223E3
		private static Delegate GetIsSelectedHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isSelected == null)
			{
				AccessibilityNodeInfoCompat.cb_isSelected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsSelected));
			}
			return AccessibilityNodeInfoCompat.cb_isSelected;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00024207 File Offset: 0x00022407
		private static bool n_IsSelected(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Selected;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00024216 File Offset: 0x00022416
		private static Delegate GetSetSelected_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setSelected_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setSelected_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetSelected_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setSelected_Z;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002423A File Offset: 0x0002243A
		private static void n_SetSelected_Z(IntPtr jnienv, IntPtr native__this, bool selected)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Selected = selected;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0002424A File Offset: 0x0002244A
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00024264 File Offset: 0x00022464
		public unsafe virtual bool Selected
		{
			[Register("isSelected", "()Z", "GetIsSelectedHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isSelected.()Z", this, null);
			}
			[Register("setSelected", "(Z)V", "GetSetSelected_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSelected.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002429F File Offset: 0x0002249F
		private static Delegate GetIsShowingHintTextHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isShowingHintText == null)
			{
				AccessibilityNodeInfoCompat.cb_isShowingHintText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsShowingHintText));
			}
			return AccessibilityNodeInfoCompat.cb_isShowingHintText;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000242C3 File Offset: 0x000224C3
		private static bool n_IsShowingHintText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowingHintText;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000242D2 File Offset: 0x000224D2
		private static Delegate GetSetShowingHintText_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setShowingHintText_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setShowingHintText_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetShowingHintText_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setShowingHintText_Z;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000242F6 File Offset: 0x000224F6
		private static void n_SetShowingHintText_Z(IntPtr jnienv, IntPtr native__this, bool showingHintText)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowingHintText = showingHintText;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00024306 File Offset: 0x00022506
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00024320 File Offset: 0x00022520
		public unsafe virtual bool ShowingHintText
		{
			[Register("isShowingHintText", "()Z", "GetIsShowingHintTextHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isShowingHintText.()Z", this, null);
			}
			[Register("setShowingHintText", "(Z)V", "GetSetShowingHintText_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setShowingHintText.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002435B File Offset: 0x0002255B
		private static Delegate GetGetStateDescriptionHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getStateDescription == null)
			{
				AccessibilityNodeInfoCompat.cb_getStateDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetStateDescription));
			}
			return AccessibilityNodeInfoCompat.cb_getStateDescription;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0002437F File Offset: 0x0002257F
		private static IntPtr n_GetStateDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StateDescriptionFormatted);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00024393 File Offset: 0x00022593
		private static Delegate GetSetStateDescription_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setStateDescription_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setStateDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetStateDescription_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setStateDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000243B8 File Offset: 0x000225B8
		private static void n_SetStateDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_stateDescription)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_stateDescription, JniHandleOwnership.DoNotTransfer);
			@object.StateDescriptionFormatted = object2;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000243DC File Offset: 0x000225DC
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x00024410 File Offset: 0x00022610
		public unsafe virtual ICharSequence StateDescriptionFormatted
		{
			[Register("getStateDescription", "()Ljava/lang/CharSequence;", "GetGetStateDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getStateDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStateDescription", "(Ljava/lang/CharSequence;)V", "GetSetStateDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setStateDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00024474 File Offset: 0x00022674
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0002448C File Offset: 0x0002268C
		public string StateDescription
		{
			get
			{
				if (this.StateDescriptionFormatted != null)
				{
					return this.StateDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.StateDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000244B6 File Offset: 0x000226B6
		private static Delegate GetGetTextHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getText == null)
			{
				AccessibilityNodeInfoCompat.cb_getText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetText));
			}
			return AccessibilityNodeInfoCompat.cb_getText;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000244DA File Offset: 0x000226DA
		private static IntPtr n_GetText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextFormatted);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000244EE File Offset: 0x000226EE
		private static Delegate GetSetText_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setText_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetText_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setText_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00024514 File Offset: 0x00022714
		private static void n_SetText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			@object.TextFormatted = object2;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x00024538 File Offset: 0x00022738
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0002456C File Offset: 0x0002276C
		public unsafe virtual ICharSequence TextFormatted
		{
			[Register("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setText", "(Ljava/lang/CharSequence;)V", "GetSetText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x000245D0 File Offset: 0x000227D0
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x000245E8 File Offset: 0x000227E8
		public string Text
		{
			get
			{
				if (this.TextFormatted != null)
				{
					return this.TextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00024612 File Offset: 0x00022812
		private static Delegate GetIsTextEntryKeyHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isTextEntryKey == null)
			{
				AccessibilityNodeInfoCompat.cb_isTextEntryKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsTextEntryKey));
			}
			return AccessibilityNodeInfoCompat.cb_isTextEntryKey;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00024636 File Offset: 0x00022836
		private static bool n_IsTextEntryKey(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextEntryKey;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00024645 File Offset: 0x00022845
		private static Delegate GetSetTextEntryKey_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTextEntryKey_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setTextEntryKey_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetTextEntryKey_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setTextEntryKey_Z;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00024669 File Offset: 0x00022869
		private static void n_SetTextEntryKey_Z(IntPtr jnienv, IntPtr native__this, bool isTextEntryKey)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextEntryKey = isTextEntryKey;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00024679 File Offset: 0x00022879
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00024694 File Offset: 0x00022894
		public unsafe virtual bool TextEntryKey
		{
			[Register("isTextEntryKey", "()Z", "GetIsTextEntryKeyHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isTextEntryKey.()Z", this, null);
			}
			[Register("setTextEntryKey", "(Z)V", "GetSetTextEntryKey_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTextEntryKey.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000246CF File Offset: 0x000228CF
		private static Delegate GetIsTextSelectableHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isTextSelectable == null)
			{
				AccessibilityNodeInfoCompat.cb_isTextSelectable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsTextSelectable));
			}
			return AccessibilityNodeInfoCompat.cb_isTextSelectable;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000246F3 File Offset: 0x000228F3
		private static bool n_IsTextSelectable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSelectable;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00024702 File Offset: 0x00022902
		private static Delegate GetSetTextSelectable_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTextSelectable_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setTextSelectable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetTextSelectable_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setTextSelectable_Z;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00024726 File Offset: 0x00022926
		private static void n_SetTextSelectable_Z(IntPtr jnienv, IntPtr native__this, bool selectableText)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSelectable = selectableText;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00024736 File Offset: 0x00022936
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00024750 File Offset: 0x00022950
		public unsafe virtual bool TextSelectable
		{
			[Register("isTextSelectable", "()Z", "GetIsTextSelectableHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isTextSelectable.()Z", this, null);
			}
			[Register("setTextSelectable", "(Z)V", "GetSetTextSelectable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTextSelectable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002478B File Offset: 0x0002298B
		private static Delegate GetGetTextSelectionEndHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTextSelectionEnd == null)
			{
				AccessibilityNodeInfoCompat.cb_getTextSelectionEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetTextSelectionEnd));
			}
			return AccessibilityNodeInfoCompat.cb_getTextSelectionEnd;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000247AF File Offset: 0x000229AF
		private static int n_GetTextSelectionEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSelectionEnd;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000247BE File Offset: 0x000229BE
		public virtual int TextSelectionEnd
		{
			[Register("getTextSelectionEnd", "()I", "GetGetTextSelectionEndHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getTextSelectionEnd.()I", this, null);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000247D7 File Offset: 0x000229D7
		private static Delegate GetGetTextSelectionStartHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTextSelectionStart == null)
			{
				AccessibilityNodeInfoCompat.cb_getTextSelectionStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetTextSelectionStart));
			}
			return AccessibilityNodeInfoCompat.cb_getTextSelectionStart;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000247FB File Offset: 0x000229FB
		private static int n_GetTextSelectionStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSelectionStart;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0002480A File Offset: 0x00022A0A
		public virtual int TextSelectionStart
		{
			[Register("getTextSelectionStart", "()I", "GetGetTextSelectionStartHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getTextSelectionStart.()I", this, null);
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00024823 File Offset: 0x00022A23
		private static Delegate GetGetTooltipTextHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTooltipText == null)
			{
				AccessibilityNodeInfoCompat.cb_getTooltipText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetTooltipText));
			}
			return AccessibilityNodeInfoCompat.cb_getTooltipText;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00024847 File Offset: 0x00022A47
		private static IntPtr n_GetTooltipText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TooltipTextFormatted);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0002485B File Offset: 0x00022A5B
		private static Delegate GetSetTooltipText_Ljava_lang_CharSequence_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTooltipText_Ljava_lang_CharSequence_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setTooltipText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetTooltipText_Ljava_lang_CharSequence_));
			}
			return AccessibilityNodeInfoCompat.cb_setTooltipText_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00024880 File Offset: 0x00022A80
		private static void n_SetTooltipText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_tooltipText)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tooltipText, JniHandleOwnership.DoNotTransfer);
			@object.TooltipTextFormatted = object2;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x000248A4 File Offset: 0x00022AA4
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x000248D8 File Offset: 0x00022AD8
		public unsafe virtual ICharSequence TooltipTextFormatted
		{
			[Register("getTooltipText", "()Ljava/lang/CharSequence;", "GetGetTooltipTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTooltipText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTooltipText", "(Ljava/lang/CharSequence;)V", "GetSetTooltipText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTooltipText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002493C File Offset: 0x00022B3C
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00024954 File Offset: 0x00022B54
		public string TooltipText
		{
			get
			{
				if (this.TooltipTextFormatted != null)
				{
					return this.TooltipTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TooltipTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002497E File Offset: 0x00022B7E
		private static Delegate GetGetTouchDelegateInfoHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTouchDelegateInfo == null)
			{
				AccessibilityNodeInfoCompat.cb_getTouchDelegateInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetTouchDelegateInfo));
			}
			return AccessibilityNodeInfoCompat.cb_getTouchDelegateInfo;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000249A2 File Offset: 0x00022BA2
		private static IntPtr n_GetTouchDelegateInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TouchDelegateInfo);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000249B6 File Offset: 0x00022BB6
		private static Delegate GetSetTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_));
			}
			return AccessibilityNodeInfoCompat.cb_setTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000249DC File Offset: 0x00022BDC
		private static void n_SetTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_delegatedInfo)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat.TouchDelegateInfoCompat object2 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.TouchDelegateInfoCompat>(native_delegatedInfo, JniHandleOwnership.DoNotTransfer);
			@object.TouchDelegateInfo = object2;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00024A00 File Offset: 0x00022C00
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x00024A34 File Offset: 0x00022C34
		public unsafe virtual AccessibilityNodeInfoCompat.TouchDelegateInfoCompat TouchDelegateInfo
		{
			[Register("getTouchDelegateInfo", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat;", "GetGetTouchDelegateInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.TouchDelegateInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTouchDelegateInfo.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTouchDelegateInfo", "(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat;)V", "GetSetTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTouchDelegateInfo.(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00024A98 File Offset: 0x00022C98
		private static Delegate GetGetTraversalAfterHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTraversalAfter == null)
			{
				AccessibilityNodeInfoCompat.cb_getTraversalAfter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetTraversalAfter));
			}
			return AccessibilityNodeInfoCompat.cb_getTraversalAfter;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00024ABC File Offset: 0x00022CBC
		private static IntPtr n_GetTraversalAfter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TraversalAfter);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00024AD0 File Offset: 0x00022CD0
		public virtual AccessibilityNodeInfoCompat TraversalAfter
		{
			[Register("getTraversalAfter", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetTraversalAfterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTraversalAfter.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00024B02 File Offset: 0x00022D02
		private static Delegate GetGetTraversalBeforeHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getTraversalBefore == null)
			{
				AccessibilityNodeInfoCompat.cb_getTraversalBefore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetTraversalBefore));
			}
			return AccessibilityNodeInfoCompat.cb_getTraversalBefore;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00024B26 File Offset: 0x00022D26
		private static IntPtr n_GetTraversalBefore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TraversalBefore);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00024B3C File Offset: 0x00022D3C
		public virtual AccessibilityNodeInfoCompat TraversalBefore
		{
			[Register("getTraversalBefore", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetTraversalBeforeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTraversalBefore.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00024B6E File Offset: 0x00022D6E
		private static Delegate GetGetUniqueIdHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getUniqueId == null)
			{
				AccessibilityNodeInfoCompat.cb_getUniqueId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetUniqueId));
			}
			return AccessibilityNodeInfoCompat.cb_getUniqueId;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00024B92 File Offset: 0x00022D92
		private static IntPtr n_GetUniqueId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UniqueId);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00024BA6 File Offset: 0x00022DA6
		private static Delegate GetSetUniqueId_Ljava_lang_String_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setUniqueId_Ljava_lang_String_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setUniqueId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetUniqueId_Ljava_lang_String_));
			}
			return AccessibilityNodeInfoCompat.cb_setUniqueId_Ljava_lang_String_;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00024BCC File Offset: 0x00022DCC
		private static void n_SetUniqueId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uniqueId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_uniqueId, JniHandleOwnership.DoNotTransfer);
			@object.UniqueId = @string;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00024BF0 File Offset: 0x00022DF0
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00024C24 File Offset: 0x00022E24
		public unsafe virtual string UniqueId
		{
			[Register("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler")]
			get
			{
				return JNIEnv.GetString(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getUniqueId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setUniqueId", "(Ljava/lang/String;)V", "GetSetUniqueId_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setUniqueId.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00024C80 File Offset: 0x00022E80
		private static Delegate GetGetViewIdResourceNameHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getViewIdResourceName == null)
			{
				AccessibilityNodeInfoCompat.cb_getViewIdResourceName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetViewIdResourceName));
			}
			return AccessibilityNodeInfoCompat.cb_getViewIdResourceName;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00024CA4 File Offset: 0x00022EA4
		private static IntPtr n_GetViewIdResourceName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewIdResourceName);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00024CB8 File Offset: 0x00022EB8
		private static Delegate GetSetViewIdResourceName_Ljava_lang_String_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setViewIdResourceName_Ljava_lang_String_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setViewIdResourceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetViewIdResourceName_Ljava_lang_String_));
			}
			return AccessibilityNodeInfoCompat.cb_setViewIdResourceName_Ljava_lang_String_;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00024CDC File Offset: 0x00022EDC
		private static void n_SetViewIdResourceName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			@object.ViewIdResourceName = @string;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00024D00 File Offset: 0x00022F00
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00024D34 File Offset: 0x00022F34
		public unsafe virtual string ViewIdResourceName
		{
			[Register("getViewIdResourceName", "()Ljava/lang/String;", "GetGetViewIdResourceNameHandler")]
			get
			{
				return JNIEnv.GetString(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getViewIdResourceName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setViewIdResourceName", "(Ljava/lang/String;)V", "GetSetViewIdResourceName_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setViewIdResourceName.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00024D90 File Offset: 0x00022F90
		private static Delegate GetIsVisibleToUserHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_isVisibleToUser == null)
			{
				AccessibilityNodeInfoCompat.cb_isVisibleToUser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_IsVisibleToUser));
			}
			return AccessibilityNodeInfoCompat.cb_isVisibleToUser;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00024DB4 File Offset: 0x00022FB4
		private static bool n_IsVisibleToUser(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VisibleToUser;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00024DC3 File Offset: 0x00022FC3
		private static Delegate GetSetVisibleToUser_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setVisibleToUser_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setVisibleToUser_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetVisibleToUser_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setVisibleToUser_Z;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00024DE7 File Offset: 0x00022FE7
		private static void n_SetVisibleToUser_Z(IntPtr jnienv, IntPtr native__this, bool visibleToUser)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VisibleToUser = visibleToUser;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00024DF7 File Offset: 0x00022FF7
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00024E10 File Offset: 0x00023010
		public unsafe virtual bool VisibleToUser
		{
			[Register("isVisibleToUser", "()Z", "GetIsVisibleToUserHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isVisibleToUser.()Z", this, null);
			}
			[Register("setVisibleToUser", "(Z)V", "GetSetVisibleToUser_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setVisibleToUser.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00024E4B File Offset: 0x0002304B
		private static Delegate GetGetWindowHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getWindow == null)
			{
				AccessibilityNodeInfoCompat.cb_getWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_GetWindow));
			}
			return AccessibilityNodeInfoCompat.cb_getWindow;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00024E6F File Offset: 0x0002306F
		private static IntPtr n_GetWindow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Window);
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00024E84 File Offset: 0x00023084
		public virtual AccessibilityWindowInfoCompat Window
		{
			[Register("getWindow", "()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", "GetGetWindowHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getWindow.()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00024EB6 File Offset: 0x000230B6
		private static Delegate GetGetWindowIdHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getWindowId == null)
			{
				AccessibilityNodeInfoCompat.cb_getWindowId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.n_GetWindowId));
			}
			return AccessibilityNodeInfoCompat.cb_getWindowId;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00024EDA File Offset: 0x000230DA
		private static int n_GetWindowId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WindowId;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00024EE9 File Offset: 0x000230E9
		public virtual int WindowId
		{
			[Register("getWindowId", "()I", "GetGetWindowIdHandler")]
			get
			{
				return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getWindowId.()I", this, null);
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00024F02 File Offset: 0x00023102
		private static Delegate GetAddAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_addAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_ == null)
			{
				AccessibilityNodeInfoCompat.cb_addAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_AddAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_));
			}
			return AccessibilityNodeInfoCompat.cb_addAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00024F28 File Offset: 0x00023128
		private static void n_AddAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat.AccessibilityActionCompat object2 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.AddAction(object2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00024F4C File Offset: 0x0002314C
		[Register("addAction", "(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;)V", "GetAddAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_Handler")]
		public unsafe virtual void AddAction(AccessibilityNodeInfoCompat.AccessibilityActionCompat action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : action.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addAction.(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00024FB0 File Offset: 0x000231B0
		private static Delegate GetAddAction_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_addAction_I == null)
			{
				AccessibilityNodeInfoCompat.cb_addAction_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AccessibilityNodeInfoCompat.n_AddAction_I));
			}
			return AccessibilityNodeInfoCompat.cb_addAction_I;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00024FD4 File Offset: 0x000231D4
		private static void n_AddAction_I(IntPtr jnienv, IntPtr native__this, int action)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddAction(action);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00024FE4 File Offset: 0x000231E4
		[Register("addAction", "(I)V", "GetAddAction_IHandler")]
		public unsafe virtual void AddAction(int action)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(action);
			AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addAction.(I)V", this, ptr);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0002501F File Offset: 0x0002321F
		private static Delegate GetAddChild_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_AddChild_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00025044 File Offset: 0x00023244
		private static void n_AddChild_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.AddChild(object2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00025068 File Offset: 0x00023268
		[Register("addChild", "(Landroid/view/View;)V", "GetAddChild_Landroid_view_View_Handler")]
		public unsafe virtual void AddChild(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addChild.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000250CC File Offset: 0x000232CC
		private static Delegate GetAddChild_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_AddChild_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_addChild_Landroid_view_View_I;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000250F0 File Offset: 0x000232F0
		private static void n_AddChild_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.AddChild(object2, virtualDescendantId);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00025114 File Offset: 0x00023314
		[Register("addChild", "(Landroid/view/View;I)V", "GetAddChild_Landroid_view_View_IHandler")]
		public unsafe virtual void AddChild(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addChild.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002518C File Offset: 0x0002338C
		private static Delegate GetAddSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_addSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_addSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AccessibilityNodeInfoCompat.n_AddSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_addSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000251B0 File Offset: 0x000233B0
		private static void n_AddSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_view)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.AddSpansToExtras(object2, object3);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000251DC File Offset: 0x000233DC
		[Register("addSpansToExtras", "(Ljava/lang/CharSequence;Landroid/view/View;)V", "GetAddSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_Handler")]
		public unsafe virtual void AddSpansToExtras(ICharSequence text, View view)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("addSpansToExtras.(Ljava/lang/CharSequence;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00025268 File Offset: 0x00023468
		public void AddSpansToExtras(string text, View view)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			this.AddSpansToExtras(@string, view);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00025293 File Offset: 0x00023493
		private static Delegate GetCanOpenPopupHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_canOpenPopup == null)
			{
				AccessibilityNodeInfoCompat.cb_canOpenPopup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_CanOpenPopup));
			}
			return AccessibilityNodeInfoCompat.cb_canOpenPopup;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000252B7 File Offset: 0x000234B7
		private static bool n_CanOpenPopup(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanOpenPopup();
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000252C6 File Offset: 0x000234C6
		[Register("canOpenPopup", "()Z", "GetCanOpenPopupHandler")]
		public virtual bool CanOpenPopup()
		{
			return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("canOpenPopup.()Z", this, null);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000252DF File Offset: 0x000234DF
		private static Delegate GetFindAccessibilityNodeInfosByText_Ljava_lang_String_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_ == null)
			{
				AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibilityNodeInfoCompat.n_FindAccessibilityNodeInfosByText_Ljava_lang_String_));
			}
			return AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByText_Ljava_lang_String_;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00025304 File Offset: 0x00023504
		private static IntPtr n_FindAccessibilityNodeInfosByText_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_text, JniHandleOwnership.DoNotTransfer);
			return JavaList<AccessibilityNodeInfoCompat>.ToLocalJniHandle(@object.FindAccessibilityNodeInfosByText(@string));
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0002532C File Offset: 0x0002352C
		[Register("findAccessibilityNodeInfosByText", "(Ljava/lang/String;)Ljava/util/List;", "GetFindAccessibilityNodeInfosByText_Ljava_lang_String_Handler")]
		public unsafe virtual IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByText(string text)
		{
			IntPtr intPtr = JNIEnv.NewString(text);
			IList<AccessibilityNodeInfoCompat> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<AccessibilityNodeInfoCompat>.FromJniHandle(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("findAccessibilityNodeInfosByText.(Ljava/lang/String;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00025398 File Offset: 0x00023598
		private static Delegate GetFindAccessibilityNodeInfosByViewId_Ljava_lang_String_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByViewId_Ljava_lang_String_ == null)
			{
				AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByViewId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibilityNodeInfoCompat.n_FindAccessibilityNodeInfosByViewId_Ljava_lang_String_));
			}
			return AccessibilityNodeInfoCompat.cb_findAccessibilityNodeInfosByViewId_Ljava_lang_String_;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000253BC File Offset: 0x000235BC
		private static IntPtr n_FindAccessibilityNodeInfosByViewId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_viewId, JniHandleOwnership.DoNotTransfer);
			return JavaList<AccessibilityNodeInfoCompat>.ToLocalJniHandle(@object.FindAccessibilityNodeInfosByViewId(@string));
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000253E4 File Offset: 0x000235E4
		[Register("findAccessibilityNodeInfosByViewId", "(Ljava/lang/String;)Ljava/util/List;", "GetFindAccessibilityNodeInfosByViewId_Ljava_lang_String_Handler")]
		public unsafe virtual IList<AccessibilityNodeInfoCompat> FindAccessibilityNodeInfosByViewId(string viewId)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			IList<AccessibilityNodeInfoCompat> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList<AccessibilityNodeInfoCompat>.FromJniHandle(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("findAccessibilityNodeInfosByViewId.(Ljava/lang/String;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00025450 File Offset: 0x00023650
		private static Delegate GetFindFocus_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_findFocus_I == null)
			{
				AccessibilityNodeInfoCompat.cb_findFocus_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeInfoCompat.n_FindFocus_I));
			}
			return AccessibilityNodeInfoCompat.cb_findFocus_I;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00025474 File Offset: 0x00023674
		private static IntPtr n_FindFocus_I(IntPtr jnienv, IntPtr native__this, int focus)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindFocus(focus));
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0002548C File Offset: 0x0002368C
		[Register("findFocus", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetFindFocus_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat FindFocus(int focus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(focus);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("findFocus.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000254D5 File Offset: 0x000236D5
		private static Delegate GetFocusSearch_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_focusSearch_I == null)
			{
				AccessibilityNodeInfoCompat.cb_focusSearch_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeInfoCompat.n_FocusSearch_I));
			}
			return AccessibilityNodeInfoCompat.cb_focusSearch_I;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000254F9 File Offset: 0x000236F9
		private static IntPtr n_FocusSearch_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FocusSearch(direction));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00025510 File Offset: 0x00023710
		[Register("focusSearch", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetFocusSearch_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat FocusSearch(int direction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(direction);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("focusSearch.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00025559 File Offset: 0x00023759
		private static Delegate GetGetBoundsInParent_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_getBoundsInParent_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_getBoundsInParent_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_GetBoundsInParent_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_getBoundsInParent_Landroid_graphics_Rect_;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00025580 File Offset: 0x00023780
		private static void n_GetBoundsInParent_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
			@object.GetBoundsInParent(object2);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000255A4 File Offset: 0x000237A4
		[Register("getBoundsInParent", "(Landroid/graphics/Rect;)V", "GetGetBoundsInParent_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetBoundsInParent(Rect outBounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("getBoundsInParent.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outBounds);
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00025608 File Offset: 0x00023808
		private static Delegate GetGetBoundsInScreen_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_GetBoundsInScreen_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0002562C File Offset: 0x0002382C
		private static void n_GetBoundsInScreen_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
			@object.GetBoundsInScreen(object2);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00025650 File Offset: 0x00023850
		[Register("getBoundsInScreen", "(Landroid/graphics/Rect;)V", "GetGetBoundsInScreen_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetBoundsInScreen(Rect outBounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("getBoundsInScreen.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outBounds);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000256B4 File Offset: 0x000238B4
		private static Delegate GetGetBoundsInWindow_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_getBoundsInWindow_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_getBoundsInWindow_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_GetBoundsInWindow_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_getBoundsInWindow_Landroid_graphics_Rect_;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000256D8 File Offset: 0x000238D8
		private static void n_GetBoundsInWindow_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
			@object.GetBoundsInWindow(object2);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000256FC File Offset: 0x000238FC
		[Register("getBoundsInWindow", "(Landroid/graphics/Rect;)V", "GetGetBoundsInWindow_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetBoundsInWindow(Rect outBounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("getBoundsInWindow.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outBounds);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00025760 File Offset: 0x00023960
		private static Delegate GetGetChild_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getChild_I == null)
			{
				AccessibilityNodeInfoCompat.cb_getChild_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeInfoCompat.n_GetChild_I));
			}
			return AccessibilityNodeInfoCompat.cb_getChild_I;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00025784 File Offset: 0x00023984
		private static IntPtr n_GetChild_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetChild(index));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0002579C File Offset: 0x0002399C
		[Register("getChild", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetChild_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat GetChild(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getChild.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000257E5 File Offset: 0x000239E5
		private static Delegate GetGetChild_IIHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getChild_II == null)
			{
				AccessibilityNodeInfoCompat.cb_getChild_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(AccessibilityNodeInfoCompat.n_GetChild_II));
			}
			return AccessibilityNodeInfoCompat.cb_getChild_II;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00025809 File Offset: 0x00023A09
		private static IntPtr n_GetChild_II(IntPtr jnienv, IntPtr native__this, int index, int prefetchingStrategy)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetChild(index, prefetchingStrategy));
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00025820 File Offset: 0x00023A20
		[Register("getChild", "(II)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetChild_IIHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat GetChild(int index, int prefetchingStrategy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			ptr[1] = new JniArgumentValue(prefetchingStrategy);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getChild.(II)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0002587C File Offset: 0x00023A7C
		[Register("getClickableSpans", "(Ljava/lang/CharSequence;)[Landroid/text/style/ClickableSpan;", "")]
		public unsafe static ClickableSpan[] GetClickableSpans(ICharSequence text)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			ClickableSpan[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (ClickableSpan[])JNIEnv.GetArray(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("getClickableSpans.(Ljava/lang/CharSequence;)[Landroid/text/style/ClickableSpan;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(ClickableSpan));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
			}
			return result;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000258FC File Offset: 0x00023AFC
		public static ClickableSpan[] GetClickableSpans(string text)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			ClickableSpan[] clickableSpans = AccessibilityNodeInfoCompat.GetClickableSpans(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return clickableSpans;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00025925 File Offset: 0x00023B25
		private static Delegate GetGetParent_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_getParent_I == null)
			{
				AccessibilityNodeInfoCompat.cb_getParent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityNodeInfoCompat.n_GetParent_I));
			}
			return AccessibilityNodeInfoCompat.cb_getParent_I;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00025949 File Offset: 0x00023B49
		private static IntPtr n_GetParent_I(IntPtr jnienv, IntPtr native__this, int prefetchingStrategy)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetParent(prefetchingStrategy));
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00025960 File Offset: 0x00023B60
		[Register("getParent", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetParent_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat GetParent(int prefetchingStrategy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(prefetchingStrategy);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getParent.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000259AC File Offset: 0x00023BAC
		[Register("obtain", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
		public static AccessibilityNodeInfoCompat Obtain()
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000259E0 File Offset: 0x00023BE0
		[Register("obtain", "(Landroid/view/View;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
		public unsafe static AccessibilityNodeInfoCompat Obtain(View source)
		{
			AccessibilityNodeInfoCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/view/View;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
			}
			return @object;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00025A54 File Offset: 0x00023C54
		[Register("obtain", "(Landroid/view/View;I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
		public unsafe static AccessibilityNodeInfoCompat Obtain(View root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/view/View;I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(root);
			}
			return @object;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00025ADC File Offset: 0x00023CDC
		[Register("obtain", "(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
		public unsafe static AccessibilityNodeInfoCompat Obtain(AccessibilityNodeInfoCompat info)
		{
			AccessibilityNodeInfoCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(info);
			}
			return @object;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00025B50 File Offset: 0x00023D50
		private static Delegate GetPerformAction_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_performAction_I == null)
			{
				AccessibilityNodeInfoCompat.cb_performAction_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(AccessibilityNodeInfoCompat.n_PerformAction_I));
			}
			return AccessibilityNodeInfoCompat.cb_performAction_I;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00025B74 File Offset: 0x00023D74
		private static bool n_PerformAction_I(IntPtr jnienv, IntPtr native__this, int action)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PerformAction(action);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00025B84 File Offset: 0x00023D84
		[Register("performAction", "(I)Z", "GetPerformAction_IHandler")]
		public unsafe virtual bool PerformAction(int action)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(action);
			return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("performAction.(I)Z", this, ptr);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00025BBF File Offset: 0x00023DBF
		private static Delegate GetPerformAction_ILandroid_os_Bundle_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_performAction_ILandroid_os_Bundle_ == null)
			{
				AccessibilityNodeInfoCompat.cb_performAction_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(AccessibilityNodeInfoCompat.n_PerformAction_ILandroid_os_Bundle_));
			}
			return AccessibilityNodeInfoCompat.cb_performAction_ILandroid_os_Bundle_;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00025BE4 File Offset: 0x00023DE4
		private static bool n_PerformAction_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, int action, IntPtr native_arguments)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
			return @object.PerformAction(action, object2);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00025C08 File Offset: 0x00023E08
		[Register("performAction", "(ILandroid/os/Bundle;)Z", "GetPerformAction_ILandroid_os_Bundle_Handler")]
		public unsafe virtual bool PerformAction(int action, Bundle arguments)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(action);
				ptr[1] = new JniArgumentValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
				result = AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("performAction.(ILandroid/os/Bundle;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(arguments);
			}
			return result;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00025C80 File Offset: 0x00023E80
		private static Delegate GetRecycleHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_recycle == null)
			{
				AccessibilityNodeInfoCompat.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AccessibilityNodeInfoCompat.n_Recycle));
			}
			return AccessibilityNodeInfoCompat.cb_recycle;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00025CA4 File Offset: 0x00023EA4
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00025CB3 File Offset: 0x00023EB3
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00025CCC File Offset: 0x00023ECC
		private static Delegate GetRefreshHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_refresh == null)
			{
				AccessibilityNodeInfoCompat.cb_refresh = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.n_Refresh));
			}
			return AccessibilityNodeInfoCompat.cb_refresh;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00025CF0 File Offset: 0x00023EF0
		private static bool n_Refresh(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Refresh();
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00025CFF File Offset: 0x00023EFF
		[Register("refresh", "()Z", "GetRefreshHandler")]
		public virtual bool Refresh()
		{
			return AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("refresh.()Z", this, null);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00025D18 File Offset: 0x00023F18
		private static Delegate GetRemoveAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_removeAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_ == null)
			{
				AccessibilityNodeInfoCompat.cb_removeAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AccessibilityNodeInfoCompat.n_RemoveAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_));
			}
			return AccessibilityNodeInfoCompat.cb_removeAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00025D3C File Offset: 0x00023F3C
		private static bool n_RemoveAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat.AccessibilityActionCompat object2 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(native_action, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveAction(object2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00025D60 File Offset: 0x00023F60
		[Register("removeAction", "(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;)Z", "GetRemoveAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_Handler")]
		public unsafe virtual bool RemoveAction(AccessibilityNodeInfoCompat.AccessibilityActionCompat action)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : action.Handle);
				result = AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("removeAction.(Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return result;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00025DC8 File Offset: 0x00023FC8
		private static Delegate GetRemoveChild_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AccessibilityNodeInfoCompat.n_RemoveChild_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00025DEC File Offset: 0x00023FEC
		private static bool n_RemoveChild_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveChild(object2);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00025E10 File Offset: 0x00024010
		[Register("removeChild", "(Landroid/view/View;)Z", "GetRemoveChild_Landroid_view_View_Handler")]
		public unsafe virtual bool RemoveChild(View child)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("removeChild.(Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00025E78 File Offset: 0x00024078
		private static Delegate GetRemoveChild_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_Z(AccessibilityNodeInfoCompat.n_RemoveChild_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_removeChild_Landroid_view_View_I;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00025E9C File Offset: 0x0002409C
		private static bool n_RemoveChild_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveChild(object2, virtualDescendantId);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00025EC0 File Offset: 0x000240C0
		[Register("removeChild", "(Landroid/view/View;I)Z", "GetRemoveChild_Landroid_view_View_IHandler")]
		public unsafe virtual bool RemoveChild(View root, int virtualDescendantId)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				result = AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("removeChild.(Landroid/view/View;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
			return result;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00025F38 File Offset: 0x00024138
		private static Delegate GetSetBoundsInParent_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setBoundsInParent_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setBoundsInParent_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetBoundsInParent_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_setBoundsInParent_Landroid_graphics_Rect_;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00025F5C File Offset: 0x0002415C
		private static void n_SetBoundsInParent_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_bounds, JniHandleOwnership.DoNotTransfer);
			@object.SetBoundsInParent(object2);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00025F80 File Offset: 0x00024180
		[Register("setBoundsInParent", "(Landroid/graphics/Rect;)V", "GetSetBoundsInParent_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void SetBoundsInParent(Rect bounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bounds == null) ? IntPtr.Zero : bounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setBoundsInParent.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bounds);
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00025FE4 File Offset: 0x000241E4
		private static Delegate GetSetBoundsInScreen_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setBoundsInScreen_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setBoundsInScreen_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetBoundsInScreen_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_setBoundsInScreen_Landroid_graphics_Rect_;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00026008 File Offset: 0x00024208
		private static void n_SetBoundsInScreen_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_bounds, JniHandleOwnership.DoNotTransfer);
			@object.SetBoundsInScreen(object2);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0002602C File Offset: 0x0002422C
		[Register("setBoundsInScreen", "(Landroid/graphics/Rect;)V", "GetSetBoundsInScreen_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void SetBoundsInScreen(Rect bounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bounds == null) ? IntPtr.Zero : bounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setBoundsInScreen.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bounds);
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00026090 File Offset: 0x00024290
		private static Delegate GetSetBoundsInWindow_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setBoundsInWindow_Landroid_graphics_Rect_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setBoundsInWindow_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetBoundsInWindow_Landroid_graphics_Rect_));
			}
			return AccessibilityNodeInfoCompat.cb_setBoundsInWindow_Landroid_graphics_Rect_;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000260B4 File Offset: 0x000242B4
		private static void n_SetBoundsInWindow_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_bounds, JniHandleOwnership.DoNotTransfer);
			@object.SetBoundsInWindow(object2);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000260D8 File Offset: 0x000242D8
		[Register("setBoundsInWindow", "(Landroid/graphics/Rect;)V", "GetSetBoundsInWindow_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void SetBoundsInWindow(Rect bounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bounds == null) ? IntPtr.Zero : bounds.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setBoundsInWindow.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bounds);
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0002613C File Offset: 0x0002433C
		private static Delegate GetSetCanOpenPopup_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setCanOpenPopup_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setCanOpenPopup_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetCanOpenPopup_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setCanOpenPopup_Z;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00026160 File Offset: 0x00024360
		private static void n_SetCanOpenPopup_Z(IntPtr jnienv, IntPtr native__this, bool opensPopup)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCanOpenPopup(opensPopup);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00026170 File Offset: 0x00024370
		[Register("setCanOpenPopup", "(Z)V", "GetSetCanOpenPopup_ZHandler")]
		public unsafe virtual void SetCanOpenPopup(bool opensPopup)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(opensPopup);
			AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setCanOpenPopup.(Z)V", this, ptr);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000261AB File Offset: 0x000243AB
		private static Delegate GetSetCollectionInfo_Ljava_lang_Object_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setCollectionInfo_Ljava_lang_Object_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setCollectionInfo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetCollectionInfo_Ljava_lang_Object_));
			}
			return AccessibilityNodeInfoCompat.cb_setCollectionInfo_Ljava_lang_Object_;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000261D0 File Offset: 0x000243D0
		private static void n_SetCollectionInfo_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_collectionInfo)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_collectionInfo, JniHandleOwnership.DoNotTransfer);
			@object.SetCollectionInfo(object2);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000261F4 File Offset: 0x000243F4
		[Register("setCollectionInfo", "(Ljava/lang/Object;)V", "GetSetCollectionInfo_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetCollectionInfo(Java.Lang.Object collectionInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((collectionInfo == null) ? IntPtr.Zero : collectionInfo.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setCollectionInfo.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(collectionInfo);
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00026258 File Offset: 0x00024458
		private static Delegate GetSetCollectionItemInfo_Ljava_lang_Object_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setCollectionItemInfo_Ljava_lang_Object_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setCollectionItemInfo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetCollectionItemInfo_Ljava_lang_Object_));
			}
			return AccessibilityNodeInfoCompat.cb_setCollectionItemInfo_Ljava_lang_Object_;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0002627C File Offset: 0x0002447C
		private static void n_SetCollectionItemInfo_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_collectionItemInfo)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_collectionItemInfo, JniHandleOwnership.DoNotTransfer);
			@object.SetCollectionItemInfo(object2);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000262A0 File Offset: 0x000244A0
		[Register("setCollectionItemInfo", "(Ljava/lang/Object;)V", "GetSetCollectionItemInfo_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetCollectionItemInfo(Java.Lang.Object collectionItemInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((collectionItemInfo == null) ? IntPtr.Zero : collectionItemInfo.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setCollectionItemInfo.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(collectionItemInfo);
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00026304 File Offset: 0x00024504
		private static Delegate GetSetLabelFor_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetLabelFor_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00026328 File Offset: 0x00024528
		private static void n_SetLabelFor_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_labeled)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_labeled, JniHandleOwnership.DoNotTransfer);
			@object.SetLabelFor(object2);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0002634C File Offset: 0x0002454C
		[Register("setLabelFor", "(Landroid/view/View;)V", "GetSetLabelFor_Landroid_view_View_Handler")]
		public unsafe virtual void SetLabelFor(View labeled)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((labeled == null) ? IntPtr.Zero : labeled.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLabelFor.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(labeled);
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000263B0 File Offset: 0x000245B0
		private static Delegate GetSetLabelFor_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetLabelFor_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setLabelFor_Landroid_view_View_I;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000263D4 File Offset: 0x000245D4
		private static void n_SetLabelFor_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetLabelFor(object2, virtualDescendantId);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000263F8 File Offset: 0x000245F8
		[Register("setLabelFor", "(Landroid/view/View;I)V", "GetSetLabelFor_Landroid_view_View_IHandler")]
		public unsafe virtual void SetLabelFor(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLabelFor.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00026470 File Offset: 0x00024670
		private static Delegate GetSetLabeledBy_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetLabeledBy_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00026494 File Offset: 0x00024694
		private static void n_SetLabeledBy_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_label, JniHandleOwnership.DoNotTransfer);
			@object.SetLabeledBy(object2);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000264B8 File Offset: 0x000246B8
		[Register("setLabeledBy", "(Landroid/view/View;)V", "GetSetLabeledBy_Landroid_view_View_Handler")]
		public unsafe virtual void SetLabeledBy(View label)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((label == null) ? IntPtr.Zero : label.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLabeledBy.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(label);
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0002651C File Offset: 0x0002471C
		private static Delegate GetSetLabeledBy_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetLabeledBy_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setLabeledBy_Landroid_view_View_I;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00026540 File Offset: 0x00024740
		private static void n_SetLabeledBy_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetLabeledBy(object2, virtualDescendantId);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00026564 File Offset: 0x00024764
		[Register("setLabeledBy", "(Landroid/view/View;I)V", "GetSetLabeledBy_Landroid_view_View_IHandler")]
		public unsafe virtual void SetLabeledBy(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setLabeledBy.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000265DC File Offset: 0x000247DC
		private static Delegate GetSetParent_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetParent_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00026600 File Offset: 0x00024800
		private static void n_SetParent_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
			@object.SetParent(object2);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00026624 File Offset: 0x00024824
		[Register("setParent", "(Landroid/view/View;)V", "GetSetParent_Landroid_view_View_Handler")]
		public unsafe virtual void SetParent(View parent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setParent.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00026688 File Offset: 0x00024888
		private static Delegate GetSetParent_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetParent_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setParent_Landroid_view_View_I;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000266AC File Offset: 0x000248AC
		private static void n_SetParent_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetParent(object2, virtualDescendantId);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000266D0 File Offset: 0x000248D0
		[Register("setParent", "(Landroid/view/View;I)V", "GetSetParent_Landroid_view_View_IHandler")]
		public unsafe virtual void SetParent(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setParent.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00026748 File Offset: 0x00024948
		private static Delegate GetSetQueryFromAppProcessEnabled_Landroid_view_View_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setQueryFromAppProcessEnabled_Landroid_view_View_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setQueryFromAppProcessEnabled_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(AccessibilityNodeInfoCompat.n_SetQueryFromAppProcessEnabled_Landroid_view_View_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setQueryFromAppProcessEnabled_Landroid_view_View_Z;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0002676C File Offset: 0x0002496C
		private static void n_SetQueryFromAppProcessEnabled_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_view, bool enabled)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetQueryFromAppProcessEnabled(object2, enabled);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00026790 File Offset: 0x00024990
		[Register("setQueryFromAppProcessEnabled", "(Landroid/view/View;Z)V", "GetSetQueryFromAppProcessEnabled_Landroid_view_View_ZHandler")]
		public unsafe virtual void SetQueryFromAppProcessEnabled(View view, bool enabled)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(enabled);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setQueryFromAppProcessEnabled.(Landroid/view/View;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00026808 File Offset: 0x00024A08
		private static Delegate GetSetRequestInitialAccessibilityFocus_ZHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setRequestInitialAccessibilityFocus_Z == null)
			{
				AccessibilityNodeInfoCompat.cb_setRequestInitialAccessibilityFocus_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AccessibilityNodeInfoCompat.n_SetRequestInitialAccessibilityFocus_Z));
			}
			return AccessibilityNodeInfoCompat.cb_setRequestInitialAccessibilityFocus_Z;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0002682C File Offset: 0x00024A2C
		private static void n_SetRequestInitialAccessibilityFocus_Z(IntPtr jnienv, IntPtr native__this, bool requestInitialAccessibilityFocus)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetRequestInitialAccessibilityFocus(requestInitialAccessibilityFocus);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0002683C File Offset: 0x00024A3C
		[Register("setRequestInitialAccessibilityFocus", "(Z)V", "GetSetRequestInitialAccessibilityFocus_ZHandler")]
		public unsafe virtual void SetRequestInitialAccessibilityFocus(bool requestInitialAccessibilityFocus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(requestInitialAccessibilityFocus);
			AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setRequestInitialAccessibilityFocus.(Z)V", this, ptr);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00026877 File Offset: 0x00024A77
		private static Delegate GetSetSource_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetSource_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0002689C File Offset: 0x00024A9C
		private static void n_SetSource_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_source, JniHandleOwnership.DoNotTransfer);
			@object.SetSource(object2);
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000268C0 File Offset: 0x00024AC0
		[Register("setSource", "(Landroid/view/View;)V", "GetSetSource_Landroid_view_View_Handler")]
		public unsafe virtual void SetSource(View source)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSource.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00026924 File Offset: 0x00024B24
		private static Delegate GetSetSource_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetSource_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setSource_Landroid_view_View_I;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00026948 File Offset: 0x00024B48
		private static void n_SetSource_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetSource(object2, virtualDescendantId);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0002696C File Offset: 0x00024B6C
		[Register("setSource", "(Landroid/view/View;I)V", "GetSetSource_Landroid_view_View_IHandler")]
		public unsafe virtual void SetSource(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSource.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000269E4 File Offset: 0x00024BE4
		private static Delegate GetSetTextSelection_IIHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTextSelection_II == null)
			{
				AccessibilityNodeInfoCompat.cb_setTextSelection_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(AccessibilityNodeInfoCompat.n_SetTextSelection_II));
			}
			return AccessibilityNodeInfoCompat.cb_setTextSelection_II;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00026A08 File Offset: 0x00024C08
		private static void n_SetTextSelection_II(IntPtr jnienv, IntPtr native__this, int start, int end)
		{
			Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTextSelection(start, end);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00026A1C File Offset: 0x00024C1C
		[Register("setTextSelection", "(II)V", "GetSetTextSelection_IIHandler")]
		public unsafe virtual void SetTextSelection(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTextSelection.(II)V", this, ptr);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00026A6A File Offset: 0x00024C6A
		private static Delegate GetSetTraversalAfter_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetTraversalAfter_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00026A90 File Offset: 0x00024C90
		private static void n_SetTraversalAfter_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetTraversalAfter(object2);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00026AB4 File Offset: 0x00024CB4
		[Register("setTraversalAfter", "(Landroid/view/View;)V", "GetSetTraversalAfter_Landroid_view_View_Handler")]
		public unsafe virtual void SetTraversalAfter(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTraversalAfter.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00026B18 File Offset: 0x00024D18
		private static Delegate GetSetTraversalAfter_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetTraversalAfter_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setTraversalAfter_Landroid_view_View_I;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00026B3C File Offset: 0x00024D3C
		private static void n_SetTraversalAfter_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetTraversalAfter(object2, virtualDescendantId);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00026B60 File Offset: 0x00024D60
		[Register("setTraversalAfter", "(Landroid/view/View;I)V", "GetSetTraversalAfter_Landroid_view_View_IHandler")]
		public unsafe virtual void SetTraversalAfter(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTraversalAfter.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00026BD8 File Offset: 0x00024DD8
		private static Delegate GetSetTraversalBefore_Landroid_view_View_Handler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_ == null)
			{
				AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityNodeInfoCompat.n_SetTraversalBefore_Landroid_view_View_));
			}
			return AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00026BFC File Offset: 0x00024DFC
		private static void n_SetTraversalBefore_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetTraversalBefore(object2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00026C20 File Offset: 0x00024E20
		[Register("setTraversalBefore", "(Landroid/view/View;)V", "GetSetTraversalBefore_Landroid_view_View_Handler")]
		public unsafe virtual void SetTraversalBefore(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTraversalBefore.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00026C84 File Offset: 0x00024E84
		private static Delegate GetSetTraversalBefore_Landroid_view_View_IHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_I == null)
			{
				AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfoCompat.n_SetTraversalBefore_Landroid_view_View_I));
			}
			return AccessibilityNodeInfoCompat.cb_setTraversalBefore_Landroid_view_View_I;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00026CA8 File Offset: 0x00024EA8
		private static void n_SetTraversalBefore_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_root, int virtualDescendantId)
		{
			AccessibilityNodeInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_root, JniHandleOwnership.DoNotTransfer);
			@object.SetTraversalBefore(object2, virtualDescendantId);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00026CCC File Offset: 0x00024ECC
		[Register("setTraversalBefore", "(Landroid/view/View;I)V", "GetSetTraversalBefore_Landroid_view_View_IHandler")]
		public unsafe virtual void SetTraversalBefore(View root, int virtualDescendantId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue(virtualDescendantId);
				AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTraversalBefore.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(root);
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00026D44 File Offset: 0x00024F44
		private static Delegate GetUnwrapHandler()
		{
			if (AccessibilityNodeInfoCompat.cb_unwrap == null)
			{
				AccessibilityNodeInfoCompat.cb_unwrap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.n_Unwrap));
			}
			return AccessibilityNodeInfoCompat.cb_unwrap;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00026D68 File Offset: 0x00024F68
		private static IntPtr n_Unwrap(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Unwrap());
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00026D7C File Offset: 0x00024F7C
		[Register("unwrap", "()Landroid/view/accessibility/AccessibilityNodeInfo;", "GetUnwrapHandler")]
		public virtual AccessibilityNodeInfo Unwrap()
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfo>(AccessibilityNodeInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("unwrap.()Landroid/view/accessibility/AccessibilityNodeInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00026DB0 File Offset: 0x00024FB0
		[Register("wrap", "(Landroid/view/accessibility/AccessibilityNodeInfo;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
		public unsafe static AccessibilityNodeInfoCompat Wrap(AccessibilityNodeInfo info)
		{
			AccessibilityNodeInfoCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat._members.StaticMethods.InvokeObjectMethod("wrap.(Landroid/view/accessibility/AccessibilityNodeInfo;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(info);
			}
			return @object;
		}

		// Token: 0x04000348 RID: 840
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat", typeof(AccessibilityNodeInfoCompat));

		// Token: 0x04000349 RID: 841
		private static Delegate cb_isAccessibilityDataSensitive;

		// Token: 0x0400034A RID: 842
		private static Delegate cb_setAccessibilityDataSensitive_Z;

		// Token: 0x0400034B RID: 843
		private static Delegate cb_isAccessibilityFocused;

		// Token: 0x0400034C RID: 844
		private static Delegate cb_setAccessibilityFocused_Z;

		// Token: 0x0400034D RID: 845
		private static Delegate cb_getActionList;

		// Token: 0x0400034E RID: 846
		private static Delegate cb_getActions;

		// Token: 0x0400034F RID: 847
		private static Delegate cb_getAvailableExtraData;

		// Token: 0x04000350 RID: 848
		private static Delegate cb_setAvailableExtraData_Ljava_util_List_;

		// Token: 0x04000351 RID: 849
		private static Delegate cb_isCheckable;

		// Token: 0x04000352 RID: 850
		private static Delegate cb_setCheckable_Z;

		// Token: 0x04000353 RID: 851
		private static Delegate cb_isChecked;

		// Token: 0x04000354 RID: 852
		private static Delegate cb_setChecked_Z;

		// Token: 0x04000355 RID: 853
		private static Delegate cb_getChildCount;

		// Token: 0x04000356 RID: 854
		private static Delegate cb_getClassName;

		// Token: 0x04000357 RID: 855
		private static Delegate cb_setClassName_Ljava_lang_CharSequence_;

		// Token: 0x04000358 RID: 856
		private static Delegate cb_isClickable;

		// Token: 0x04000359 RID: 857
		private static Delegate cb_setClickable_Z;

		// Token: 0x0400035A RID: 858
		private static Delegate cb_getCollectionInfo;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_getCollectionItemInfo;

		// Token: 0x0400035C RID: 860
		private static Delegate cb_getContainerTitle;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_setContainerTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400035E RID: 862
		private static Delegate cb_getContentDescription;

		// Token: 0x0400035F RID: 863
		private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000360 RID: 864
		private static Delegate cb_isContentInvalid;

		// Token: 0x04000361 RID: 865
		private static Delegate cb_setContentInvalid_Z;

		// Token: 0x04000362 RID: 866
		private static Delegate cb_isContextClickable;

		// Token: 0x04000363 RID: 867
		private static Delegate cb_setContextClickable_Z;

		// Token: 0x04000364 RID: 868
		private static Delegate cb_isDismissable;

		// Token: 0x04000365 RID: 869
		private static Delegate cb_setDismissable_Z;

		// Token: 0x04000366 RID: 870
		private static Delegate cb_getDrawingOrder;

		// Token: 0x04000367 RID: 871
		private static Delegate cb_setDrawingOrder_I;

		// Token: 0x04000368 RID: 872
		private static Delegate cb_isEditable;

		// Token: 0x04000369 RID: 873
		private static Delegate cb_setEditable_Z;

		// Token: 0x0400036A RID: 874
		private static Delegate cb_isEnabled;

		// Token: 0x0400036B RID: 875
		private static Delegate cb_setEnabled_Z;

		// Token: 0x0400036C RID: 876
		private static Delegate cb_getError;

		// Token: 0x0400036D RID: 877
		private static Delegate cb_setError_Ljava_lang_CharSequence_;

		// Token: 0x0400036E RID: 878
		private static Delegate cb_getExtraRenderingInfo;

		// Token: 0x0400036F RID: 879
		private static Delegate cb_getExtras;

		// Token: 0x04000370 RID: 880
		private static Delegate cb_isFocusable;

		// Token: 0x04000371 RID: 881
		private static Delegate cb_setFocusable_Z;

		// Token: 0x04000372 RID: 882
		private static Delegate cb_isFocused;

		// Token: 0x04000373 RID: 883
		private static Delegate cb_setFocused_Z;

		// Token: 0x04000374 RID: 884
		private static Delegate cb_isGranularScrollingSupported;

		// Token: 0x04000375 RID: 885
		private static Delegate cb_setGranularScrollingSupported_Z;

		// Token: 0x04000376 RID: 886
		private static Delegate cb_hasRequestInitialAccessibilityFocus;

		// Token: 0x04000377 RID: 887
		private static Delegate cb_isHeading;

		// Token: 0x04000378 RID: 888
		private static Delegate cb_setHeading_Z;

		// Token: 0x04000379 RID: 889
		private static Delegate cb_getHintText;

		// Token: 0x0400037A RID: 890
		private static Delegate cb_setHintText_Ljava_lang_CharSequence_;

		// Token: 0x0400037B RID: 891
		private static Delegate cb_isImportantForAccessibility;

		// Token: 0x0400037C RID: 892
		private static Delegate cb_setImportantForAccessibility_Z;

		// Token: 0x0400037D RID: 893
		private static Delegate cb_getInfo;

		// Token: 0x0400037E RID: 894
		private static Delegate cb_getInputType;

		// Token: 0x0400037F RID: 895
		private static Delegate cb_setInputType_I;

		// Token: 0x04000380 RID: 896
		private static Delegate cb_getLabelFor;

		// Token: 0x04000381 RID: 897
		private static Delegate cb_getLabeledBy;

		// Token: 0x04000382 RID: 898
		private static Delegate cb_getLiveRegion;

		// Token: 0x04000383 RID: 899
		private static Delegate cb_setLiveRegion_I;

		// Token: 0x04000384 RID: 900
		private static Delegate cb_isLongClickable;

		// Token: 0x04000385 RID: 901
		private static Delegate cb_setLongClickable_Z;

		// Token: 0x04000386 RID: 902
		private static Delegate cb_getMaxTextLength;

		// Token: 0x04000387 RID: 903
		private static Delegate cb_setMaxTextLength_I;

		// Token: 0x04000388 RID: 904
		private static Delegate cb_getMinDurationBetweenContentChangesMillis;

		// Token: 0x04000389 RID: 905
		private static Delegate cb_setMinDurationBetweenContentChangesMillis_J;

		// Token: 0x0400038A RID: 906
		private static Delegate cb_getMovementGranularities;

		// Token: 0x0400038B RID: 907
		private static Delegate cb_setMovementGranularities_I;

		// Token: 0x0400038C RID: 908
		private static Delegate cb_isMultiLine;

		// Token: 0x0400038D RID: 909
		private static Delegate cb_setMultiLine_Z;

		// Token: 0x0400038E RID: 910
		private static Delegate cb_getPackageName;

		// Token: 0x0400038F RID: 911
		private static Delegate cb_setPackageName_Ljava_lang_CharSequence_;

		// Token: 0x04000390 RID: 912
		private static Delegate cb_getPaneTitle;

		// Token: 0x04000391 RID: 913
		private static Delegate cb_setPaneTitle_Ljava_lang_CharSequence_;

		// Token: 0x04000392 RID: 914
		private static Delegate cb_getParent;

		// Token: 0x04000393 RID: 915
		private static Delegate cb_isPassword;

		// Token: 0x04000394 RID: 916
		private static Delegate cb_setPassword_Z;

		// Token: 0x04000395 RID: 917
		private static Delegate cb_getRangeInfo;

		// Token: 0x04000396 RID: 918
		private static Delegate cb_setRangeInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_RangeInfoCompat_;

		// Token: 0x04000397 RID: 919
		private static Delegate cb_getRoleDescription;

		// Token: 0x04000398 RID: 920
		private static Delegate cb_setRoleDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000399 RID: 921
		private static Delegate cb_isScreenReaderFocusable;

		// Token: 0x0400039A RID: 922
		private static Delegate cb_setScreenReaderFocusable_Z;

		// Token: 0x0400039B RID: 923
		private static Delegate cb_isScrollable;

		// Token: 0x0400039C RID: 924
		private static Delegate cb_setScrollable_Z;

		// Token: 0x0400039D RID: 925
		private static Delegate cb_isSelected;

		// Token: 0x0400039E RID: 926
		private static Delegate cb_setSelected_Z;

		// Token: 0x0400039F RID: 927
		private static Delegate cb_isShowingHintText;

		// Token: 0x040003A0 RID: 928
		private static Delegate cb_setShowingHintText_Z;

		// Token: 0x040003A1 RID: 929
		private static Delegate cb_getStateDescription;

		// Token: 0x040003A2 RID: 930
		private static Delegate cb_setStateDescription_Ljava_lang_CharSequence_;

		// Token: 0x040003A3 RID: 931
		private static Delegate cb_getText;

		// Token: 0x040003A4 RID: 932
		private static Delegate cb_setText_Ljava_lang_CharSequence_;

		// Token: 0x040003A5 RID: 933
		private static Delegate cb_isTextEntryKey;

		// Token: 0x040003A6 RID: 934
		private static Delegate cb_setTextEntryKey_Z;

		// Token: 0x040003A7 RID: 935
		private static Delegate cb_isTextSelectable;

		// Token: 0x040003A8 RID: 936
		private static Delegate cb_setTextSelectable_Z;

		// Token: 0x040003A9 RID: 937
		private static Delegate cb_getTextSelectionEnd;

		// Token: 0x040003AA RID: 938
		private static Delegate cb_getTextSelectionStart;

		// Token: 0x040003AB RID: 939
		private static Delegate cb_getTooltipText;

		// Token: 0x040003AC RID: 940
		private static Delegate cb_setTooltipText_Ljava_lang_CharSequence_;

		// Token: 0x040003AD RID: 941
		private static Delegate cb_getTouchDelegateInfo;

		// Token: 0x040003AE RID: 942
		private static Delegate cb_setTouchDelegateInfo_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_TouchDelegateInfoCompat_;

		// Token: 0x040003AF RID: 943
		private static Delegate cb_getTraversalAfter;

		// Token: 0x040003B0 RID: 944
		private static Delegate cb_getTraversalBefore;

		// Token: 0x040003B1 RID: 945
		private static Delegate cb_getUniqueId;

		// Token: 0x040003B2 RID: 946
		private static Delegate cb_setUniqueId_Ljava_lang_String_;

		// Token: 0x040003B3 RID: 947
		private static Delegate cb_getViewIdResourceName;

		// Token: 0x040003B4 RID: 948
		private static Delegate cb_setViewIdResourceName_Ljava_lang_String_;

		// Token: 0x040003B5 RID: 949
		private static Delegate cb_isVisibleToUser;

		// Token: 0x040003B6 RID: 950
		private static Delegate cb_setVisibleToUser_Z;

		// Token: 0x040003B7 RID: 951
		private static Delegate cb_getWindow;

		// Token: 0x040003B8 RID: 952
		private static Delegate cb_getWindowId;

		// Token: 0x040003B9 RID: 953
		private static Delegate cb_addAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_;

		// Token: 0x040003BA RID: 954
		private static Delegate cb_addAction_I;

		// Token: 0x040003BB RID: 955
		private static Delegate cb_addChild_Landroid_view_View_;

		// Token: 0x040003BC RID: 956
		private static Delegate cb_addChild_Landroid_view_View_I;

		// Token: 0x040003BD RID: 957
		private static Delegate cb_addSpansToExtras_Ljava_lang_CharSequence_Landroid_view_View_;

		// Token: 0x040003BE RID: 958
		private static Delegate cb_canOpenPopup;

		// Token: 0x040003BF RID: 959
		private static Delegate cb_findAccessibilityNodeInfosByText_Ljava_lang_String_;

		// Token: 0x040003C0 RID: 960
		private static Delegate cb_findAccessibilityNodeInfosByViewId_Ljava_lang_String_;

		// Token: 0x040003C1 RID: 961
		private static Delegate cb_findFocus_I;

		// Token: 0x040003C2 RID: 962
		private static Delegate cb_focusSearch_I;

		// Token: 0x040003C3 RID: 963
		private static Delegate cb_getBoundsInParent_Landroid_graphics_Rect_;

		// Token: 0x040003C4 RID: 964
		private static Delegate cb_getBoundsInScreen_Landroid_graphics_Rect_;

		// Token: 0x040003C5 RID: 965
		private static Delegate cb_getBoundsInWindow_Landroid_graphics_Rect_;

		// Token: 0x040003C6 RID: 966
		private static Delegate cb_getChild_I;

		// Token: 0x040003C7 RID: 967
		private static Delegate cb_getChild_II;

		// Token: 0x040003C8 RID: 968
		private static Delegate cb_getParent_I;

		// Token: 0x040003C9 RID: 969
		private static Delegate cb_performAction_I;

		// Token: 0x040003CA RID: 970
		private static Delegate cb_performAction_ILandroid_os_Bundle_;

		// Token: 0x040003CB RID: 971
		private static Delegate cb_recycle;

		// Token: 0x040003CC RID: 972
		private static Delegate cb_refresh;

		// Token: 0x040003CD RID: 973
		private static Delegate cb_removeAction_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_AccessibilityActionCompat_;

		// Token: 0x040003CE RID: 974
		private static Delegate cb_removeChild_Landroid_view_View_;

		// Token: 0x040003CF RID: 975
		private static Delegate cb_removeChild_Landroid_view_View_I;

		// Token: 0x040003D0 RID: 976
		private static Delegate cb_setBoundsInParent_Landroid_graphics_Rect_;

		// Token: 0x040003D1 RID: 977
		private static Delegate cb_setBoundsInScreen_Landroid_graphics_Rect_;

		// Token: 0x040003D2 RID: 978
		private static Delegate cb_setBoundsInWindow_Landroid_graphics_Rect_;

		// Token: 0x040003D3 RID: 979
		private static Delegate cb_setCanOpenPopup_Z;

		// Token: 0x040003D4 RID: 980
		private static Delegate cb_setCollectionInfo_Ljava_lang_Object_;

		// Token: 0x040003D5 RID: 981
		private static Delegate cb_setCollectionItemInfo_Ljava_lang_Object_;

		// Token: 0x040003D6 RID: 982
		private static Delegate cb_setLabelFor_Landroid_view_View_;

		// Token: 0x040003D7 RID: 983
		private static Delegate cb_setLabelFor_Landroid_view_View_I;

		// Token: 0x040003D8 RID: 984
		private static Delegate cb_setLabeledBy_Landroid_view_View_;

		// Token: 0x040003D9 RID: 985
		private static Delegate cb_setLabeledBy_Landroid_view_View_I;

		// Token: 0x040003DA RID: 986
		private static Delegate cb_setParent_Landroid_view_View_;

		// Token: 0x040003DB RID: 987
		private static Delegate cb_setParent_Landroid_view_View_I;

		// Token: 0x040003DC RID: 988
		private static Delegate cb_setQueryFromAppProcessEnabled_Landroid_view_View_Z;

		// Token: 0x040003DD RID: 989
		private static Delegate cb_setRequestInitialAccessibilityFocus_Z;

		// Token: 0x040003DE RID: 990
		private static Delegate cb_setSource_Landroid_view_View_;

		// Token: 0x040003DF RID: 991
		private static Delegate cb_setSource_Landroid_view_View_I;

		// Token: 0x040003E0 RID: 992
		private static Delegate cb_setTextSelection_II;

		// Token: 0x040003E1 RID: 993
		private static Delegate cb_setTraversalAfter_Landroid_view_View_;

		// Token: 0x040003E2 RID: 994
		private static Delegate cb_setTraversalAfter_Landroid_view_View_I;

		// Token: 0x040003E3 RID: 995
		private static Delegate cb_setTraversalBefore_Landroid_view_View_;

		// Token: 0x040003E4 RID: 996
		private static Delegate cb_setTraversalBefore_Landroid_view_View_I;

		// Token: 0x040003E5 RID: 997
		private static Delegate cb_unwrap;

		// Token: 0x020000BF RID: 191
		[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat", DoNotGenerateAcw = true)]
		public class AccessibilityActionCompat : Java.Lang.Object
		{
			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00026E40 File Offset: 0x00025040
			[Register("ACTION_ACCESSIBILITY_FOCUS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionAccessibilityFocus
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_ACCESSIBILITY_FOCUS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00026E70 File Offset: 0x00025070
			[Register("ACTION_CLEAR_ACCESSIBILITY_FOCUS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionClearAccessibilityFocus
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CLEAR_ACCESSIBILITY_FOCUS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00026EA0 File Offset: 0x000250A0
			[Register("ACTION_CLEAR_FOCUS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionClearFocus
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CLEAR_FOCUS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00026ED0 File Offset: 0x000250D0
			[Register("ACTION_CLEAR_SELECTION")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionClearSelection
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CLEAR_SELECTION.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00026F00 File Offset: 0x00025100
			[Register("ACTION_CLICK")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionClick
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CLICK.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00026F30 File Offset: 0x00025130
			[Register("ACTION_COLLAPSE")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionCollapse
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_COLLAPSE.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00026F60 File Offset: 0x00025160
			[Register("ACTION_CONTEXT_CLICK")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionContextClick
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CONTEXT_CLICK.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00026F90 File Offset: 0x00025190
			[Register("ACTION_COPY")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionCopy
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_COPY.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00026FC0 File Offset: 0x000251C0
			[Register("ACTION_CUT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionCut
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_CUT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00026FF0 File Offset: 0x000251F0
			[Register("ACTION_DISMISS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionDismiss
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_DISMISS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00027020 File Offset: 0x00025220
			[Register("ACTION_DRAG_CANCEL")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionDragCancel
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_DRAG_CANCEL.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00027050 File Offset: 0x00025250
			[Register("ACTION_DRAG_DROP")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionDragDrop
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_DRAG_DROP.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00027080 File Offset: 0x00025280
			[Register("ACTION_DRAG_START")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionDragStart
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_DRAG_START.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000270B0 File Offset: 0x000252B0
			[Register("ACTION_EXPAND")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionExpand
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_EXPAND.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000270E0 File Offset: 0x000252E0
			[Register("ACTION_FOCUS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionFocus
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_FOCUS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00027110 File Offset: 0x00025310
			[Register("ACTION_HIDE_TOOLTIP")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionHideTooltip
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_HIDE_TOOLTIP.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00027140 File Offset: 0x00025340
			[Register("ACTION_IME_ENTER")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionImeEnter
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_IME_ENTER.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00027170 File Offset: 0x00025370
			[Register("ACTION_LONG_CLICK")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionLongClick
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_LONG_CLICK.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000271A0 File Offset: 0x000253A0
			[Register("ACTION_MOVE_WINDOW")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionMoveWindow
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_MOVE_WINDOW.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000271D0 File Offset: 0x000253D0
			[Register("ACTION_NEXT_AT_MOVEMENT_GRANULARITY")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionNextAtMovementGranularity
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_NEXT_AT_MOVEMENT_GRANULARITY.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00027200 File Offset: 0x00025400
			[Register("ACTION_NEXT_HTML_ELEMENT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionNextHtmlElement
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_NEXT_HTML_ELEMENT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00027230 File Offset: 0x00025430
			[Register("ACTION_PAGE_DOWN")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPageDown
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PAGE_DOWN.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00027260 File Offset: 0x00025460
			[Register("ACTION_PAGE_LEFT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPageLeft
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PAGE_LEFT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00027290 File Offset: 0x00025490
			[Register("ACTION_PAGE_RIGHT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPageRight
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PAGE_RIGHT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000272C0 File Offset: 0x000254C0
			[Register("ACTION_PAGE_UP")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPageUp
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PAGE_UP.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000D19 RID: 3353 RVA: 0x000272F0 File Offset: 0x000254F0
			[Register("ACTION_PASTE")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPaste
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PASTE.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00027320 File Offset: 0x00025520
			[Register("ACTION_PRESS_AND_HOLD")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPressAndHold
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PRESS_AND_HOLD.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00027350 File Offset: 0x00025550
			[Register("ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPreviousAtMovementGranularity
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00027380 File Offset: 0x00025580
			[Register("ACTION_PREVIOUS_HTML_ELEMENT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionPreviousHtmlElement
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_PREVIOUS_HTML_ELEMENT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000273B0 File Offset: 0x000255B0
			[Register("ACTION_SCROLL_BACKWARD")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollBackward
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_BACKWARD.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x000273E0 File Offset: 0x000255E0
			[Register("ACTION_SCROLL_DOWN")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollDown
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_DOWN.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00027410 File Offset: 0x00025610
			[Register("ACTION_SCROLL_FORWARD")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollForward
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_FORWARD.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00027440 File Offset: 0x00025640
			[Register("ACTION_SCROLL_IN_DIRECTION")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollInDirection
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_IN_DIRECTION.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00027470 File Offset: 0x00025670
			[Register("ACTION_SCROLL_LEFT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollLeft
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_LEFT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000D22 RID: 3362 RVA: 0x000274A0 File Offset: 0x000256A0
			[Register("ACTION_SCROLL_RIGHT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollRight
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_RIGHT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000D23 RID: 3363 RVA: 0x000274D0 File Offset: 0x000256D0
			[Register("ACTION_SCROLL_TO_POSITION")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollToPosition
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_TO_POSITION.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00027500 File Offset: 0x00025700
			[Register("ACTION_SCROLL_UP")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionScrollUp
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SCROLL_UP.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00027530 File Offset: 0x00025730
			[Register("ACTION_SELECT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionSelect
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SELECT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00027560 File Offset: 0x00025760
			[Register("ACTION_SET_PROGRESS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionSetProgress
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SET_PROGRESS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00027590 File Offset: 0x00025790
			[Register("ACTION_SET_SELECTION")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionSetSelection
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SET_SELECTION.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000275C0 File Offset: 0x000257C0
			[Register("ACTION_SET_TEXT")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionSetText
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SET_TEXT.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000275F0 File Offset: 0x000257F0
			[Register("ACTION_SHOW_ON_SCREEN")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionShowOnScreen
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SHOW_ON_SCREEN.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00027620 File Offset: 0x00025820
			[Register("ACTION_SHOW_TEXT_SUGGESTIONS")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionShowTextSuggestions
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SHOW_TEXT_SUGGESTIONS.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00027650 File Offset: 0x00025850
			[Register("ACTION_SHOW_TOOLTIP")]
			public static AccessibilityNodeInfoCompat.AccessibilityActionCompat ActionShowTooltip
			{
				get
				{
					return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.StaticFields.GetObjectValue("ACTION_SHOW_TOOLTIP.Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00027680 File Offset: 0x00025880
			// (set) Token: 0x06000D2D RID: 3373 RVA: 0x000276B0 File Offset: 0x000258B0
			[Register("mCommand")]
			protected IAccessibilityViewCommand MCommand
			{
				get
				{
					return Java.Lang.Object.GetObject<IAccessibilityViewCommand>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceFields.GetObjectValue("mCommand.Landroidx/core/view/accessibility/AccessibilityViewCommand;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceFields.SetValue("mCommand.Landroidx/core/view/accessibility/AccessibilityViewCommand;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000276FC File Offset: 0x000258FC
			internal static IntPtr class_ref
			{
				get
				{
					return AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00027720 File Offset: 0x00025920
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfoCompat.AccessibilityActionCompat._members;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00027728 File Offset: 0x00025928
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0002774C File Offset: 0x0002594C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x00002384 File Offset: 0x00000584
			protected AccessibilityActionCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00027758 File Offset: 0x00025958
			[Register(".ctor", "(ILjava/lang/CharSequence;)V", "")]
			public unsafe AccessibilityActionCompat(int actionId, ICharSequence label) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(actionId);
					ptr[1] = new JniArgumentValue(intPtr);
					base.SetHandle(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(label);
				}
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x00027818 File Offset: 0x00025A18
			[Register(".ctor", "(ILjava/lang/CharSequence;)V", "")]
			public unsafe AccessibilityActionCompat(int actionId, string label) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(actionId);
					ptr[1] = new JniArgumentValue(intPtr);
					base.SetHandle(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(label);
				}
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x000278D8 File Offset: 0x00025AD8
			[Register(".ctor", "(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", "")]
			public unsafe AccessibilityActionCompat(int actionId, ICharSequence label, IAccessibilityViewCommand command) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(actionId);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
					base.SetHandle(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(label);
					GC.KeepAlive(command);
				}
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x000279C8 File Offset: 0x00025BC8
			[Register(".ctor", "(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", "")]
			public unsafe AccessibilityActionCompat(int actionId, string label, IAccessibilityViewCommand command) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(actionId);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
					base.SetHandle(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(label);
					GC.KeepAlive(command);
				}
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x00027AB8 File Offset: 0x00025CB8
			private static Delegate GetGetIdHandler()
			{
				if (AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getId == null)
				{
					AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.AccessibilityActionCompat.n_GetId));
				}
				return AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getId;
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x00027ADC File Offset: 0x00025CDC
			private static int n_GetId(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00027AEB File Offset: 0x00025CEB
			public virtual int Id
			{
				[Register("getId", "()I", "GetGetIdHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.InvokeVirtualInt32Method("getId.()I", this, null);
				}
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x00027B04 File Offset: 0x00025D04
			private static Delegate GetGetLabelHandler()
			{
				if (AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getLabel == null)
				{
					AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.AccessibilityActionCompat.n_GetLabel));
				}
				return AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_getLabel;
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x00027B28 File Offset: 0x00025D28
			private static IntPtr n_GetLabel(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LabelFormatted);
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00027B3C File Offset: 0x00025D3C
			public virtual ICharSequence LabelFormatted
			{
				[Register("getLabel", "()Ljava/lang/CharSequence;", "GetGetLabelHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLabel.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00027B6E File Offset: 0x00025D6E
			public string Label
			{
				get
				{
					if (this.LabelFormatted != null)
					{
						return this.LabelFormatted.ToString();
					}
					return null;
				}
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00027B85 File Offset: 0x00025D85
			private static Delegate GetCreateReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_Handler()
			{
				if (AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_createReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_ == null)
				{
					AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_createReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AccessibilityNodeInfoCompat.AccessibilityActionCompat.n_CreateReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_));
				}
				return AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_createReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_;
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x00027BAC File Offset: 0x00025DAC
			private static IntPtr n_CreateReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_(IntPtr jnienv, IntPtr native__this, IntPtr native_label, IntPtr native_command)
			{
				AccessibilityNodeInfoCompat.AccessibilityActionCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_label, JniHandleOwnership.DoNotTransfer);
				IAccessibilityViewCommand object3 = Java.Lang.Object.GetObject<IAccessibilityViewCommand>(native_command, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.CreateReplacementAction(object2, object3));
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00027BE0 File Offset: 0x00025DE0
			[Register("createReplacementAction", "(Ljava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;", "GetCreateReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_Handler")]
			public unsafe virtual AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction(ICharSequence label, IAccessibilityViewCommand command)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
				AccessibilityNodeInfoCompat.AccessibilityActionCompat @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((command == null) ? IntPtr.Zero : ((Java.Lang.Object)command).Handle);
					@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.InvokeVirtualObjectMethod("createReplacementAction.(Ljava/lang/CharSequence;Landroidx/core/view/accessibility/AccessibilityViewCommand;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(label);
					GC.KeepAlive(command);
				}
				return @object;
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x00027C80 File Offset: 0x00025E80
			public AccessibilityNodeInfoCompat.AccessibilityActionCompat CreateReplacementAction(string label, IAccessibilityViewCommand command)
			{
				Java.Lang.String @string = (label == null) ? null : new Java.Lang.String(label);
				AccessibilityNodeInfoCompat.AccessibilityActionCompat result = this.CreateReplacementAction(@string, command);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x00027CAB File Offset: 0x00025EAB
			private static Delegate GetPerform_Landroid_view_View_Landroid_os_Bundle_Handler()
			{
				if (AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_perform_Landroid_view_View_Landroid_os_Bundle_ == null)
				{
					AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_perform_Landroid_view_View_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AccessibilityNodeInfoCompat.AccessibilityActionCompat.n_Perform_Landroid_view_View_Landroid_os_Bundle_));
				}
				return AccessibilityNodeInfoCompat.AccessibilityActionCompat.cb_perform_Landroid_view_View_Landroid_os_Bundle_;
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x00027CD0 File Offset: 0x00025ED0
			private static bool n_Perform_Landroid_view_View_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_arguments)
			{
				AccessibilityNodeInfoCompat.AccessibilityActionCompat @object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.AccessibilityActionCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
				return @object.Perform(object2, object3);
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x00027CFC File Offset: 0x00025EFC
			[Register("perform", "(Landroid/view/View;Landroid/os/Bundle;)Z", "GetPerform_Landroid_view_View_Landroid_os_Bundle_Handler")]
			public unsafe virtual bool Perform(View view, Bundle arguments)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
					result = AccessibilityNodeInfoCompat.AccessibilityActionCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("perform.(Landroid/view/View;Landroid/os/Bundle;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
					GC.KeepAlive(arguments);
				}
				return result;
			}

			// Token: 0x040003E6 RID: 998
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$AccessibilityActionCompat", typeof(AccessibilityNodeInfoCompat.AccessibilityActionCompat));

			// Token: 0x040003E7 RID: 999
			private static Delegate cb_getId;

			// Token: 0x040003E8 RID: 1000
			private static Delegate cb_getLabel;

			// Token: 0x040003E9 RID: 1001
			private static Delegate cb_createReplacementAction_Ljava_lang_CharSequence_Landroidx_core_view_accessibility_AccessibilityViewCommand_;

			// Token: 0x040003EA RID: 1002
			private static Delegate cb_perform_Landroid_view_View_Landroid_os_Bundle_;
		}

		// Token: 0x020000C0 RID: 192
		[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat", DoNotGenerateAcw = true)]
		public class CollectionInfoCompat : Java.Lang.Object
		{
			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00027DA8 File Offset: 0x00025FA8
			internal static IntPtr class_ref
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00027DCC File Offset: 0x00025FCC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00027DD4 File Offset: 0x00025FD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00027DF8 File Offset: 0x00025FF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x00002384 File Offset: 0x00000584
			protected CollectionInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x00027E04 File Offset: 0x00026004
			private static Delegate GetGetColumnCountHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getColumnCount == null)
				{
					AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getColumnCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionInfoCompat.n_GetColumnCount));
				}
				return AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getColumnCount;
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x00027E28 File Offset: 0x00026028
			private static int n_GetColumnCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ColumnCount;
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00027E37 File Offset: 0x00026037
			public virtual int ColumnCount
			{
				[Register("getColumnCount", "()I", "GetGetColumnCountHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getColumnCount.()I", this, null);
				}
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x00027E50 File Offset: 0x00026050
			private static Delegate GetIsHierarchicalHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_isHierarchical == null)
				{
					AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_isHierarchical = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.CollectionInfoCompat.n_IsHierarchical));
				}
				return AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_isHierarchical;
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x00027E74 File Offset: 0x00026074
			private static bool n_IsHierarchical(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsHierarchical;
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00027E83 File Offset: 0x00026083
			public virtual bool IsHierarchical
			{
				[Register("isHierarchical", "()Z", "GetIsHierarchicalHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isHierarchical.()Z", this, null);
				}
			}

			// Token: 0x06000D51 RID: 3409 RVA: 0x00027E9C File Offset: 0x0002609C
			private static Delegate GetGetRowCountHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getRowCount == null)
				{
					AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getRowCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionInfoCompat.n_GetRowCount));
				}
				return AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getRowCount;
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x00027EC0 File Offset: 0x000260C0
			private static int n_GetRowCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RowCount;
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00027ECF File Offset: 0x000260CF
			public virtual int RowCount
			{
				[Register("getRowCount", "()I", "GetGetRowCountHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getRowCount.()I", this, null);
				}
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x00027EE8 File Offset: 0x000260E8
			private static Delegate GetGetSelectionModeHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getSelectionMode == null)
				{
					AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getSelectionMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionInfoCompat.n_GetSelectionMode));
				}
				return AccessibilityNodeInfoCompat.CollectionInfoCompat.cb_getSelectionMode;
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x00027F0C File Offset: 0x0002610C
			private static int n_GetSelectionMode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectionMode;
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00027F1B File Offset: 0x0002611B
			public virtual int SelectionMode
			{
				[Register("getSelectionMode", "()I", "GetGetSelectionModeHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSelectionMode.()I", this, null);
				}
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x00027F34 File Offset: 0x00026134
			[Register("obtain", "(IIZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", "")]
			public unsafe static AccessibilityNodeInfoCompat.CollectionInfoCompat Obtain(int rowCount, int columnCount, bool hierarchical)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rowCount);
				ptr[1] = new JniArgumentValue(columnCount);
				ptr[2] = new JniArgumentValue(hierarchical);
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(AccessibilityNodeInfoCompat.CollectionInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(IIZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x00027FA8 File Offset: 0x000261A8
			[Register("obtain", "(IIZI)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", "")]
			public unsafe static AccessibilityNodeInfoCompat.CollectionInfoCompat Obtain(int rowCount, int columnCount, bool hierarchical, int selectionMode)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rowCount);
				ptr[1] = new JniArgumentValue(columnCount);
				ptr[2] = new JniArgumentValue(hierarchical);
				ptr[3] = new JniArgumentValue(selectionMode);
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionInfoCompat>(AccessibilityNodeInfoCompat.CollectionInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(IIZI)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040003EB RID: 1003
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionInfoCompat", typeof(AccessibilityNodeInfoCompat.CollectionInfoCompat));

			// Token: 0x040003EC RID: 1004
			private static Delegate cb_getColumnCount;

			// Token: 0x040003ED RID: 1005
			private static Delegate cb_isHierarchical;

			// Token: 0x040003EE RID: 1006
			private static Delegate cb_getRowCount;

			// Token: 0x040003EF RID: 1007
			private static Delegate cb_getSelectionMode;
		}

		// Token: 0x020000C1 RID: 193
		[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat", DoNotGenerateAcw = true)]
		public class CollectionItemInfoCompat : Java.Lang.Object
		{
			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0002804C File Offset: 0x0002624C
			internal static IntPtr class_ref
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00028070 File Offset: 0x00026270
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00028078 File Offset: 0x00026278
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002809C File Offset: 0x0002629C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D5E RID: 3422 RVA: 0x00002384 File Offset: 0x00000584
			protected CollectionItemInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000D5F RID: 3423 RVA: 0x000280A8 File Offset: 0x000262A8
			private static Delegate GetGetColumnIndexHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnIndex == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetColumnIndex));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnIndex;
			}

			// Token: 0x06000D60 RID: 3424 RVA: 0x000280CC File Offset: 0x000262CC
			private static int n_GetColumnIndex(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ColumnIndex;
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000280DB File Offset: 0x000262DB
			public virtual int ColumnIndex
			{
				[Register("getColumnIndex", "()I", "GetGetColumnIndexHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getColumnIndex.()I", this, null);
				}
			}

			// Token: 0x06000D62 RID: 3426 RVA: 0x000280F4 File Offset: 0x000262F4
			private static Delegate GetGetColumnSpanHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnSpan == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnSpan = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetColumnSpan));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnSpan;
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x00028118 File Offset: 0x00026318
			private static int n_GetColumnSpan(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ColumnSpan;
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00028127 File Offset: 0x00026327
			public virtual int ColumnSpan
			{
				[Register("getColumnSpan", "()I", "GetGetColumnSpanHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getColumnSpan.()I", this, null);
				}
			}

			// Token: 0x06000D65 RID: 3429 RVA: 0x00028140 File Offset: 0x00026340
			private static Delegate GetGetColumnTitleHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnTitle == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetColumnTitle));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getColumnTitle;
			}

			// Token: 0x06000D66 RID: 3430 RVA: 0x00028164 File Offset: 0x00026364
			private static IntPtr n_GetColumnTitle(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ColumnTitle);
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00028178 File Offset: 0x00026378
			public virtual string ColumnTitle
			{
				[Register("getColumnTitle", "()Ljava/lang/String;", "GetGetColumnTitleHandler")]
				get
				{
					return JNIEnv.GetString(AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getColumnTitle.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000D68 RID: 3432 RVA: 0x000281AA File Offset: 0x000263AA
			private static Delegate GetIsHeadingHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isHeading == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isHeading = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_IsHeading));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isHeading;
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x000281CE File Offset: 0x000263CE
			private static bool n_IsHeading(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsHeading;
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000281DD File Offset: 0x000263DD
			public virtual bool IsHeading
			{
				[Register("isHeading", "()Z", "GetIsHeadingHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isHeading.()Z", this, null);
				}
			}

			// Token: 0x06000D6B RID: 3435 RVA: 0x000281F6 File Offset: 0x000263F6
			private static Delegate GetIsSelectedHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isSelected == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isSelected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_IsSelected));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_isSelected;
			}

			// Token: 0x06000D6C RID: 3436 RVA: 0x0002821A File Offset: 0x0002641A
			private static bool n_IsSelected(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSelected;
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00028229 File Offset: 0x00026429
			public virtual bool IsSelected
			{
				[Register("isSelected", "()Z", "GetIsSelectedHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isSelected.()Z", this, null);
				}
			}

			// Token: 0x06000D6E RID: 3438 RVA: 0x00028242 File Offset: 0x00026442
			private static Delegate GetGetRowIndexHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowIndex == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetRowIndex));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowIndex;
			}

			// Token: 0x06000D6F RID: 3439 RVA: 0x00028266 File Offset: 0x00026466
			private static int n_GetRowIndex(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RowIndex;
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00028275 File Offset: 0x00026475
			public virtual int RowIndex
			{
				[Register("getRowIndex", "()I", "GetGetRowIndexHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getRowIndex.()I", this, null);
				}
			}

			// Token: 0x06000D71 RID: 3441 RVA: 0x0002828E File Offset: 0x0002648E
			private static Delegate GetGetRowSpanHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowSpan == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowSpan = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetRowSpan));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowSpan;
			}

			// Token: 0x06000D72 RID: 3442 RVA: 0x000282B2 File Offset: 0x000264B2
			private static int n_GetRowSpan(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RowSpan;
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000282C1 File Offset: 0x000264C1
			public virtual int RowSpan
			{
				[Register("getRowSpan", "()I", "GetGetRowSpanHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getRowSpan.()I", this, null);
				}
			}

			// Token: 0x06000D74 RID: 3444 RVA: 0x000282DA File Offset: 0x000264DA
			private static Delegate GetGetRowTitleHandler()
			{
				if (AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowTitle == null)
				{
					AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityNodeInfoCompat.CollectionItemInfoCompat.n_GetRowTitle));
				}
				return AccessibilityNodeInfoCompat.CollectionItemInfoCompat.cb_getRowTitle;
			}

			// Token: 0x06000D75 RID: 3445 RVA: 0x000282FE File Offset: 0x000264FE
			private static IntPtr n_GetRowTitle(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RowTitle);
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00028314 File Offset: 0x00026514
			public virtual string RowTitle
			{
				[Register("getRowTitle", "()Ljava/lang/String;", "GetGetRowTitleHandler")]
				get
				{
					return JNIEnv.GetString(AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getRowTitle.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00028348 File Offset: 0x00026548
			[Register("obtain", "(IIIIZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", "")]
			public unsafe static AccessibilityNodeInfoCompat.CollectionItemInfoCompat Obtain(int rowIndex, int rowSpan, int columnIndex, int columnSpan, bool heading)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rowIndex);
				ptr[1] = new JniArgumentValue(rowSpan);
				ptr[2] = new JniArgumentValue(columnIndex);
				ptr[3] = new JniArgumentValue(columnSpan);
				ptr[4] = new JniArgumentValue(heading);
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(IIIIZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x000283E8 File Offset: 0x000265E8
			[Register("obtain", "(IIIIZZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", "")]
			public unsafe static AccessibilityNodeInfoCompat.CollectionItemInfoCompat Obtain(int rowIndex, int rowSpan, int columnIndex, int columnSpan, bool heading, bool selected)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rowIndex);
				ptr[1] = new JniArgumentValue(rowSpan);
				ptr[2] = new JniArgumentValue(columnIndex);
				ptr[3] = new JniArgumentValue(columnSpan);
				ptr[4] = new JniArgumentValue(heading);
				ptr[5] = new JniArgumentValue(selected);
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.CollectionItemInfoCompat>(AccessibilityNodeInfoCompat.CollectionItemInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(IIIIZZ)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040003F0 RID: 1008
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$CollectionItemInfoCompat", typeof(AccessibilityNodeInfoCompat.CollectionItemInfoCompat));

			// Token: 0x040003F1 RID: 1009
			private static Delegate cb_getColumnIndex;

			// Token: 0x040003F2 RID: 1010
			private static Delegate cb_getColumnSpan;

			// Token: 0x040003F3 RID: 1011
			private static Delegate cb_getColumnTitle;

			// Token: 0x040003F4 RID: 1012
			private static Delegate cb_isHeading;

			// Token: 0x040003F5 RID: 1013
			private static Delegate cb_isSelected;

			// Token: 0x040003F6 RID: 1014
			private static Delegate cb_getRowIndex;

			// Token: 0x040003F7 RID: 1015
			private static Delegate cb_getRowSpan;

			// Token: 0x040003F8 RID: 1016
			private static Delegate cb_getRowTitle;
		}

		// Token: 0x020000C2 RID: 194
		[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat", DoNotGenerateAcw = true)]
		public class RangeInfoCompat : Java.Lang.Object
		{
			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000284B8 File Offset: 0x000266B8
			internal static IntPtr class_ref
			{
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000284DC File Offset: 0x000266DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000284E4 File Offset: 0x000266E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00028508 File Offset: 0x00026708
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D7E RID: 3454 RVA: 0x00002384 File Offset: 0x00000584
			protected RangeInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000D7F RID: 3455 RVA: 0x00028514 File Offset: 0x00026714
			[Register(".ctor", "(IFFF)V", "")]
			public unsafe RangeInfoCompat(int type, float min, float max, float current) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(type);
				ptr[1] = new JniArgumentValue(min);
				ptr[2] = new JniArgumentValue(max);
				ptr[3] = new JniArgumentValue(current);
				base.SetHandle(AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.StartCreateInstance("(IFFF)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.FinishCreateInstance("(IFFF)V", this, ptr);
			}

			// Token: 0x06000D80 RID: 3456 RVA: 0x000285D8 File Offset: 0x000267D8
			private static Delegate GetGetCurrentHandler()
			{
				if (AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getCurrent == null)
				{
					AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getCurrent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AccessibilityNodeInfoCompat.RangeInfoCompat.n_GetCurrent));
				}
				return AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getCurrent;
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x000285FC File Offset: 0x000267FC
			private static float n_GetCurrent(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Current;
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0002860B File Offset: 0x0002680B
			public virtual float Current
			{
				[Register("getCurrent", "()F", "GetGetCurrentHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.InvokeVirtualSingleMethod("getCurrent.()F", this, null);
				}
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x00028624 File Offset: 0x00026824
			private static Delegate GetGetMaxHandler()
			{
				if (AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMax == null)
				{
					AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMax = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AccessibilityNodeInfoCompat.RangeInfoCompat.n_GetMax));
				}
				return AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMax;
			}

			// Token: 0x06000D84 RID: 3460 RVA: 0x00028648 File Offset: 0x00026848
			private static float n_GetMax(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Max;
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000D85 RID: 3461 RVA: 0x00028657 File Offset: 0x00026857
			public virtual float Max
			{
				[Register("getMax", "()F", "GetGetMaxHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.InvokeVirtualSingleMethod("getMax.()F", this, null);
				}
			}

			// Token: 0x06000D86 RID: 3462 RVA: 0x00028670 File Offset: 0x00026870
			private static Delegate GetGetMinHandler()
			{
				if (AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMin == null)
				{
					AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AccessibilityNodeInfoCompat.RangeInfoCompat.n_GetMin));
				}
				return AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getMin;
			}

			// Token: 0x06000D87 RID: 3463 RVA: 0x00028694 File Offset: 0x00026894
			private static float n_GetMin(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Min;
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000286A3 File Offset: 0x000268A3
			public virtual float Min
			{
				[Register("getMin", "()F", "GetGetMinHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.InvokeVirtualSingleMethod("getMin.()F", this, null);
				}
			}

			// Token: 0x06000D89 RID: 3465 RVA: 0x000286BC File Offset: 0x000268BC
			private static Delegate GetGetTypeHandler()
			{
				if (AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getType == null)
				{
					AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfoCompat.RangeInfoCompat.n_GetType));
				}
				return AccessibilityNodeInfoCompat.RangeInfoCompat.cb_getType;
			}

			// Token: 0x06000D8A RID: 3466 RVA: 0x000286E0 File Offset: 0x000268E0
			private static int n_GetType(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type;
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000D8B RID: 3467 RVA: 0x000286EF File Offset: 0x000268EF
			public virtual int Type
			{
				[Register("getType", "()I", "GetGetTypeHandler")]
				get
				{
					return AccessibilityNodeInfoCompat.RangeInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getType.()I", this, null);
				}
			}

			// Token: 0x06000D8C RID: 3468 RVA: 0x00028708 File Offset: 0x00026908
			[Register("obtain", "(IFFF)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;", "")]
			public unsafe static AccessibilityNodeInfoCompat.RangeInfoCompat Obtain(int type, float min, float max, float current)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(type);
				ptr[1] = new JniArgumentValue(min);
				ptr[2] = new JniArgumentValue(max);
				ptr[3] = new JniArgumentValue(current);
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat.RangeInfoCompat>(AccessibilityNodeInfoCompat.RangeInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(IFFF)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040003F9 RID: 1017
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$RangeInfoCompat", typeof(AccessibilityNodeInfoCompat.RangeInfoCompat));

			// Token: 0x040003FA RID: 1018
			private static Delegate cb_getCurrent;

			// Token: 0x040003FB RID: 1019
			private static Delegate cb_getMax;

			// Token: 0x040003FC RID: 1020
			private static Delegate cb_getMin;

			// Token: 0x040003FD RID: 1021
			private static Delegate cb_getType;
		}

		// Token: 0x020000C3 RID: 195
		[Register("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat", DoNotGenerateAcw = true)]
		public sealed class TouchDelegateInfoCompat : Java.Lang.Object
		{
			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000287AC File Offset: 0x000269AC
			internal static IntPtr class_ref
			{
				get
				{
					return AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000287D0 File Offset: 0x000269D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000287D8 File Offset: 0x000269D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000D91 RID: 3473 RVA: 0x000287FC File Offset: 0x000269FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.ManagedPeerType;
				}
			}

			// Token: 0x06000D92 RID: 3474 RVA: 0x00002384 File Offset: 0x00000584
			internal TouchDelegateInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000D93 RID: 3475 RVA: 0x00028808 File Offset: 0x00026A08
			[Register(".ctor", "(Ljava/util/Map;)V", "")]
			public unsafe TouchDelegateInfoCompat(IDictionary<Region, View> targetMap) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JavaDictionary<Region, View>.ToLocalJniHandle(targetMap);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					base.SetHandle(AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.InstanceMethods.StartCreateInstance("(Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Map;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(targetMap);
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000D94 RID: 3476 RVA: 0x000288B4 File Offset: 0x00026AB4
			public int RegionCount
			{
				[Register("getRegionCount", "()I", "")]
				get
				{
					return AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.InstanceMethods.InvokeAbstractInt32Method("getRegionCount.()I", this, null);
				}
			}

			// Token: 0x06000D95 RID: 3477 RVA: 0x000288D0 File Offset: 0x00026AD0
			[Register("getRegionAt", "(I)Landroid/graphics/Region;", "")]
			public unsafe Region GetRegionAt(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return Java.Lang.Object.GetObject<Region>(AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getRegionAt.(I)Landroid/graphics/Region;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000D96 RID: 3478 RVA: 0x0002891C File Offset: 0x00026B1C
			[Register("getTargetForRegion", "(Landroid/graphics/Region;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "")]
			public unsafe AccessibilityNodeInfoCompat GetTargetForRegion(Region region)
			{
				AccessibilityNodeInfoCompat @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((region == null) ? IntPtr.Zero : region.Handle);
					@object = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityNodeInfoCompat.TouchDelegateInfoCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getTargetForRegion.(Landroid/graphics/Region;)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(region);
				}
				return @object;
			}

			// Token: 0x040003FE RID: 1022
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityNodeInfoCompat$TouchDelegateInfoCompat", typeof(AccessibilityNodeInfoCompat.TouchDelegateInfoCompat));
		}
	}
}
