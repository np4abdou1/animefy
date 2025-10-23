using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Button
{
	// Token: 0x0200004B RID: 75
	[Register("com/google/android/material/button/MaterialButtonToggleGroup", DoNotGenerateAcw = true)]
	public class MaterialButtonToggleGroup : LinearLayout
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00008654 File Offset: 0x00006854
		internal static IntPtr class_ref
		{
			get
			{
				return MaterialButtonToggleGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00008678 File Offset: 0x00006878
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaterialButtonToggleGroup._members;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00008680 File Offset: 0x00006880
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaterialButtonToggleGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000086A4 File Offset: 0x000068A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaterialButtonToggleGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000086B0 File Offset: 0x000068B0
		protected MaterialButtonToggleGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000086BC File Offset: 0x000068BC
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MaterialButtonToggleGroup(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MaterialButtonToggleGroup._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaterialButtonToggleGroup._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000876C File Offset: 0x0000696C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MaterialButtonToggleGroup(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(MaterialButtonToggleGroup._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaterialButtonToggleGroup._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00008848 File Offset: 0x00006A48
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MaterialButtonToggleGroup(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(MaterialButtonToggleGroup._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaterialButtonToggleGroup._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00008938 File Offset: 0x00006B38
		private static Delegate GetGetCheckedButtonIdHandler()
		{
			if (MaterialButtonToggleGroup.cb_getCheckedButtonId == null)
			{
				MaterialButtonToggleGroup.cb_getCheckedButtonId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaterialButtonToggleGroup.n_GetCheckedButtonId));
			}
			return MaterialButtonToggleGroup.cb_getCheckedButtonId;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000895C File Offset: 0x00006B5C
		private static int n_GetCheckedButtonId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CheckedButtonId;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000896B File Offset: 0x00006B6B
		public virtual int CheckedButtonId
		{
			[Register("getCheckedButtonId", "()I", "GetGetCheckedButtonIdHandler")]
			get
			{
				return MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualInt32Method("getCheckedButtonId.()I", this, null);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00008984 File Offset: 0x00006B84
		private static Delegate GetGetCheckedButtonIdsHandler()
		{
			if (MaterialButtonToggleGroup.cb_getCheckedButtonIds == null)
			{
				MaterialButtonToggleGroup.cb_getCheckedButtonIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaterialButtonToggleGroup.n_GetCheckedButtonIds));
			}
			return MaterialButtonToggleGroup.cb_getCheckedButtonIds;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000089A8 File Offset: 0x00006BA8
		private static IntPtr n_GetCheckedButtonIds(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<Integer>.ToLocalJniHandle(Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CheckedButtonIds);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000089BC File Offset: 0x00006BBC
		public virtual IList<Integer> CheckedButtonIds
		{
			[Register("getCheckedButtonIds", "()Ljava/util/List;", "GetGetCheckedButtonIdsHandler")]
			get
			{
				return JavaList<Integer>.FromJniHandle(MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualObjectMethod("getCheckedButtonIds.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000089EE File Offset: 0x00006BEE
		private static Delegate GetIsSelectionRequiredHandler()
		{
			if (MaterialButtonToggleGroup.cb_isSelectionRequired == null)
			{
				MaterialButtonToggleGroup.cb_isSelectionRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaterialButtonToggleGroup.n_IsSelectionRequired));
			}
			return MaterialButtonToggleGroup.cb_isSelectionRequired;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008A12 File Offset: 0x00006C12
		private static bool n_IsSelectionRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectionRequired;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00008A21 File Offset: 0x00006C21
		private static Delegate GetSetSelectionRequired_ZHandler()
		{
			if (MaterialButtonToggleGroup.cb_setSelectionRequired_Z == null)
			{
				MaterialButtonToggleGroup.cb_setSelectionRequired_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MaterialButtonToggleGroup.n_SetSelectionRequired_Z));
			}
			return MaterialButtonToggleGroup.cb_setSelectionRequired_Z;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00008A45 File Offset: 0x00006C45
		private static void n_SetSelectionRequired_Z(IntPtr jnienv, IntPtr native__this, bool selectionRequired)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectionRequired = selectionRequired;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00008A55 File Offset: 0x00006C55
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00008A70 File Offset: 0x00006C70
		public unsafe virtual bool SelectionRequired
		{
			[Register("isSelectionRequired", "()Z", "GetIsSelectionRequiredHandler")]
			get
			{
				return MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("isSelectionRequired.()Z", this, null);
			}
			[Register("setSelectionRequired", "(Z)V", "GetSetSelectionRequired_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectionRequired.(Z)V", this, ptr);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00008AAB File Offset: 0x00006CAB
		private static Delegate GetIsSingleSelectionHandler()
		{
			if (MaterialButtonToggleGroup.cb_isSingleSelection == null)
			{
				MaterialButtonToggleGroup.cb_isSingleSelection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MaterialButtonToggleGroup.n_IsSingleSelection));
			}
			return MaterialButtonToggleGroup.cb_isSingleSelection;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00008ACF File Offset: 0x00006CCF
		private static bool n_IsSingleSelection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SingleSelection;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00008ADE File Offset: 0x00006CDE
		private static Delegate GetSetSingleSelection_ZHandler()
		{
			if (MaterialButtonToggleGroup.cb_setSingleSelection_Z == null)
			{
				MaterialButtonToggleGroup.cb_setSingleSelection_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MaterialButtonToggleGroup.n_SetSingleSelection_Z));
			}
			return MaterialButtonToggleGroup.cb_setSingleSelection_Z;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00008B02 File Offset: 0x00006D02
		private static void n_SetSingleSelection_Z(IntPtr jnienv, IntPtr native__this, bool singleSelection)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SingleSelection = singleSelection;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00008B12 File Offset: 0x00006D12
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00008B2C File Offset: 0x00006D2C
		public unsafe virtual bool SingleSelection
		{
			[Register("isSingleSelection", "()Z", "GetIsSingleSelectionHandler")]
			get
			{
				return MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("isSingleSelection.()Z", this, null);
			}
			[Register("setSingleSelection", "(Z)V", "GetSetSingleSelection_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("setSingleSelection.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00008B67 File Offset: 0x00006D67
		private static Delegate GetAddOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_Handler()
		{
			if (MaterialButtonToggleGroup.cb_addOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_ == null)
			{
				MaterialButtonToggleGroup.cb_addOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaterialButtonToggleGroup.n_AddOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_));
			}
			return MaterialButtonToggleGroup.cb_addOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00008B8C File Offset: 0x00006D8C
		private static void n_AddOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			MaterialButtonToggleGroup @object = Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaterialButtonToggleGroup.IOnButtonCheckedListener object2 = Java.Lang.Object.GetObject<MaterialButtonToggleGroup.IOnButtonCheckedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnButtonCheckedListener(object2);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Register("addOnButtonCheckedListener", "(Lcom/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener;)V", "GetAddOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_Handler")]
		public unsafe virtual void AddOnButtonCheckedListener(MaterialButtonToggleGroup.IOnButtonCheckedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("addOnButtonCheckedListener.(Lcom/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00008C18 File Offset: 0x00006E18
		private static Delegate GetCheck_IHandler()
		{
			if (MaterialButtonToggleGroup.cb_check_I == null)
			{
				MaterialButtonToggleGroup.cb_check_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaterialButtonToggleGroup.n_Check_I));
			}
			return MaterialButtonToggleGroup.cb_check_I;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00008C3C File Offset: 0x00006E3C
		private static void n_Check_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Check(id);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00008C4C File Offset: 0x00006E4C
		[Register("check", "(I)V", "GetCheck_IHandler")]
		public unsafe virtual void Check(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("check.(I)V", this, ptr);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00008C87 File Offset: 0x00006E87
		private static Delegate GetClearCheckedHandler()
		{
			if (MaterialButtonToggleGroup.cb_clearChecked == null)
			{
				MaterialButtonToggleGroup.cb_clearChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaterialButtonToggleGroup.n_ClearChecked));
			}
			return MaterialButtonToggleGroup.cb_clearChecked;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00008CAB File Offset: 0x00006EAB
		private static void n_ClearChecked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearChecked();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00008CBA File Offset: 0x00006EBA
		[Register("clearChecked", "()V", "GetClearCheckedHandler")]
		public virtual void ClearChecked()
		{
			MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("clearChecked.()V", this, null);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00008CD3 File Offset: 0x00006ED3
		private static Delegate GetClearOnButtonCheckedListenersHandler()
		{
			if (MaterialButtonToggleGroup.cb_clearOnButtonCheckedListeners == null)
			{
				MaterialButtonToggleGroup.cb_clearOnButtonCheckedListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MaterialButtonToggleGroup.n_ClearOnButtonCheckedListeners));
			}
			return MaterialButtonToggleGroup.cb_clearOnButtonCheckedListeners;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00008CF7 File Offset: 0x00006EF7
		private static void n_ClearOnButtonCheckedListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnButtonCheckedListeners();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00008D06 File Offset: 0x00006F06
		[Register("clearOnButtonCheckedListeners", "()V", "GetClearOnButtonCheckedListenersHandler")]
		public virtual void ClearOnButtonCheckedListeners()
		{
			MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnButtonCheckedListeners.()V", this, null);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00008D1F File Offset: 0x00006F1F
		private static Delegate GetRemoveOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_Handler()
		{
			if (MaterialButtonToggleGroup.cb_removeOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_ == null)
			{
				MaterialButtonToggleGroup.cb_removeOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaterialButtonToggleGroup.n_RemoveOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_));
			}
			return MaterialButtonToggleGroup.cb_removeOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00008D44 File Offset: 0x00006F44
		private static void n_RemoveOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			MaterialButtonToggleGroup @object = Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaterialButtonToggleGroup.IOnButtonCheckedListener object2 = Java.Lang.Object.GetObject<MaterialButtonToggleGroup.IOnButtonCheckedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnButtonCheckedListener(object2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00008D68 File Offset: 0x00006F68
		[Register("removeOnButtonCheckedListener", "(Lcom/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener;)V", "GetRemoveOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_Handler")]
		public unsafe virtual void RemoveOnButtonCheckedListener(MaterialButtonToggleGroup.IOnButtonCheckedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnButtonCheckedListener.(Lcom/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00008DD0 File Offset: 0x00006FD0
		private static Delegate GetSetSingleSelection_IHandler()
		{
			if (MaterialButtonToggleGroup.cb_setSingleSelection_I == null)
			{
				MaterialButtonToggleGroup.cb_setSingleSelection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaterialButtonToggleGroup.n_SetSingleSelection_I));
			}
			return MaterialButtonToggleGroup.cb_setSingleSelection_I;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00008DF4 File Offset: 0x00006FF4
		private static void n_SetSingleSelection_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSingleSelection(id);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00008E04 File Offset: 0x00007004
		[Register("setSingleSelection", "(I)V", "GetSetSingleSelection_IHandler")]
		public unsafe virtual void SetSingleSelection(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("setSingleSelection.(I)V", this, ptr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00008E3F File Offset: 0x0000703F
		private static Delegate GetUncheck_IHandler()
		{
			if (MaterialButtonToggleGroup.cb_uncheck_I == null)
			{
				MaterialButtonToggleGroup.cb_uncheck_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MaterialButtonToggleGroup.n_Uncheck_I));
			}
			return MaterialButtonToggleGroup.cb_uncheck_I;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00008E63 File Offset: 0x00007063
		private static void n_Uncheck_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Uncheck(id);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00008E74 File Offset: 0x00007074
		[Register("uncheck", "(I)V", "GetUncheck_IHandler")]
		public unsafe virtual void Uncheck(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			MaterialButtonToggleGroup._members.InstanceMethods.InvokeVirtualVoidMethod("uncheck.(I)V", this, ptr);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600031A RID: 794 RVA: 0x00008EB0 File Offset: 0x000070B0
		// (remove) Token: 0x0600031B RID: 795 RVA: 0x00008EFC File Offset: 0x000070FC
		public event EventHandler<MaterialButtonToggleGroup.ButtonCheckedEventArgs> ButtonChecked
		{
			add
			{
				EventHelper.AddEventHandler<MaterialButtonToggleGroup.IOnButtonCheckedListener, MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor>(ref this.weak_implementor_AddOnButtonCheckedListener, new Func<MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor>(this.__CreateIOnButtonCheckedListenerImplementor), new Action<MaterialButtonToggleGroup.IOnButtonCheckedListener>(this.AddOnButtonCheckedListener), delegate(MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaterialButtonToggleGroup.ButtonCheckedEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor, bool> empty;
				if ((empty = MaterialButtonToggleGroup.<>O.<0>____IsEmpty) == null)
				{
					empty = (MaterialButtonToggleGroup.<>O.<0>____IsEmpty = new Func<MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor, bool>(MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<MaterialButtonToggleGroup.IOnButtonCheckedListener, MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor>(ref this.weak_implementor_AddOnButtonCheckedListener, empty, delegate(MaterialButtonToggleGroup.IOnButtonCheckedListener __v)
				{
					this.RemoveOnButtonCheckedListener(__v);
				}, delegate(MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MaterialButtonToggleGroup.ButtonCheckedEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00008F5B File Offset: 0x0000715B
		private MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor __CreateIOnButtonCheckedListenerImplementor()
		{
			return new MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor(this);
		}

		// Token: 0x04000095 RID: 149
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/button/MaterialButtonToggleGroup", typeof(MaterialButtonToggleGroup));

		// Token: 0x04000096 RID: 150
		private static Delegate cb_getCheckedButtonId;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_getCheckedButtonIds;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_isSelectionRequired;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_setSelectionRequired_Z;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_isSingleSelection;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_setSingleSelection_Z;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_addOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_check_I;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_clearChecked;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_clearOnButtonCheckedListeners;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_removeOnButtonCheckedListener_Lcom_google_android_material_button_MaterialButtonToggleGroup_OnButtonCheckedListener_;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_setSingleSelection_I;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_uncheck_I;

		// Token: 0x040000A3 RID: 163
		private WeakReference weak_implementor_AddOnButtonCheckedListener;

		// Token: 0x0200004C RID: 76
		[Register("com/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener", "", "Google.Android.Material.Button.MaterialButtonToggleGroup/IOnButtonCheckedListenerInvoker")]
		public interface IOnButtonCheckedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600031E RID: 798
			[Register("onButtonChecked", "(Lcom/google/android/material/button/MaterialButtonToggleGroup;IZ)V", "GetOnButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZHandler:Google.Android.Material.Button.MaterialButtonToggleGroup/IOnButtonCheckedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnButtonChecked(MaterialButtonToggleGroup p0, int p1, bool p2);
		}

		// Token: 0x0200004D RID: 77
		[Register("com/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener", DoNotGenerateAcw = true)]
		internal class IOnButtonCheckedListenerInvoker : Java.Lang.Object, MaterialButtonToggleGroup.IOnButtonCheckedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000082 RID: 130
			// (get) Token: 0x0600031F RID: 799 RVA: 0x00008F80 File Offset: 0x00007180
			private static IntPtr java_class_ref
			{
				get
				{
					return MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000320 RID: 800 RVA: 0x00008FA4 File Offset: 0x000071A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker._members;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000321 RID: 801 RVA: 0x00008FAB File Offset: 0x000071AB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000322 RID: 802 RVA: 0x00008FB3 File Offset: 0x000071B3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000323 RID: 803 RVA: 0x00008FBF File Offset: 0x000071BF
			public static MaterialButtonToggleGroup.IOnButtonCheckedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<MaterialButtonToggleGroup.IOnButtonCheckedListener>(handle, transfer);
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00008FC8 File Offset: 0x000071C8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.button.MaterialButtonToggleGroup.OnButtonCheckedListener'.");
				}
				return handle;
			}

			// Token: 0x06000325 RID: 805 RVA: 0x00008FF3 File Offset: 0x000071F3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00009024 File Offset: 0x00007224
			public IOnButtonCheckedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000905C File Offset: 0x0000725C
			private static Delegate GetOnButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZHandler()
			{
				if (MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.cb_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ == null)
				{
					MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.cb_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.n_OnButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ));
				}
				return MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker.cb_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00009080 File Offset: 0x00007280
			private static void n_OnButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
			{
				MaterialButtonToggleGroup.IOnButtonCheckedListener @object = Java.Lang.Object.GetObject<MaterialButtonToggleGroup.IOnButtonCheckedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MaterialButtonToggleGroup object2 = Java.Lang.Object.GetObject<MaterialButtonToggleGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnButtonChecked(object2, p1, p2);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x000090A8 File Offset: 0x000072A8
			public unsafe void OnButtonChecked(MaterialButtonToggleGroup p0, int p1, bool p2)
			{
				if (this.id_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ == IntPtr.Zero)
				{
					this.id_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ = JNIEnv.GetMethodID(this.class_ref, "onButtonChecked", "(Lcom/google/android/material/button/MaterialButtonToggleGroup;IZ)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue(p1);
				ptr[2] = new JValue(p2);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ, ptr);
			}

			// Token: 0x040000A4 RID: 164
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/button/MaterialButtonToggleGroup$OnButtonCheckedListener", typeof(MaterialButtonToggleGroup.IOnButtonCheckedListenerInvoker));

			// Token: 0x040000A5 RID: 165
			private IntPtr class_ref;

			// Token: 0x040000A6 RID: 166
			private static Delegate cb_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ;

			// Token: 0x040000A7 RID: 167
			private IntPtr id_onButtonChecked_Lcom_google_android_material_button_MaterialButtonToggleGroup_IZ;
		}

		// Token: 0x0200004E RID: 78
		public class ButtonCheckedEventArgs : EventArgs
		{
			// Token: 0x0600032B RID: 811 RVA: 0x0000915F File Offset: 0x0000735F
			public ButtonCheckedEventArgs(MaterialButtonToggleGroup p0, int p1, bool p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0000917C File Offset: 0x0000737C
			public int P1
			{
				get
				{
					return this.p1;
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00009184 File Offset: 0x00007384
			public bool P2
			{
				get
				{
					return this.p2;
				}
			}

			// Token: 0x040000A8 RID: 168
			private MaterialButtonToggleGroup p0;

			// Token: 0x040000A9 RID: 169
			private int p1;

			// Token: 0x040000AA RID: 170
			private bool p2;
		}

		// Token: 0x0200004F RID: 79
		[Register("mono/com/google/android/material/button/MaterialButtonToggleGroup_OnButtonCheckedListenerImplementor")]
		internal sealed class IOnButtonCheckedListenerImplementor : Java.Lang.Object, MaterialButtonToggleGroup.IOnButtonCheckedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600032E RID: 814 RVA: 0x0000918C File Offset: 0x0000738C
			public IOnButtonCheckedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/button/MaterialButtonToggleGroup_OnButtonCheckedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600032F RID: 815 RVA: 0x000091C8 File Offset: 0x000073C8
			public void OnButtonChecked(MaterialButtonToggleGroup p0, int p1, bool p2)
			{
				EventHandler<MaterialButtonToggleGroup.ButtonCheckedEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new MaterialButtonToggleGroup.ButtonCheckedEventArgs(p0, p1, p2));
				}
			}

			// Token: 0x06000330 RID: 816 RVA: 0x000091F3 File Offset: 0x000073F3
			internal static bool __IsEmpty(MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040000AB RID: 171
			private object sender;

			// Token: 0x040000AC RID: 172
			public EventHandler<MaterialButtonToggleGroup.ButtonCheckedEventArgs> Handler;
		}

		// Token: 0x02000050 RID: 80
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040000AD RID: 173
			public static Func<MaterialButtonToggleGroup.IOnButtonCheckedListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
