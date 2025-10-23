using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.CoordinatorLayout.Widget;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.BottomSheet
{
	// Token: 0x02000053 RID: 83
	[Register("com/google/android/material/bottomsheet/BottomSheetBehavior", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"V extends android.view.View"
	})]
	public class BottomSheetBehavior : CoordinatorLayout.Behavior
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00009250 File Offset: 0x00007450
		internal static IntPtr class_ref
		{
			get
			{
				return BottomSheetBehavior._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00009274 File Offset: 0x00007474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BottomSheetBehavior._members;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000927C File Offset: 0x0000747C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BottomSheetBehavior._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000092A0 File Offset: 0x000074A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BottomSheetBehavior._members.ManagedPeerType;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000092AC File Offset: 0x000074AC
		protected BottomSheetBehavior(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000092B8 File Offset: 0x000074B8
		[Register(".ctor", "()V", "")]
		public BottomSheetBehavior() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BottomSheetBehavior._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BottomSheetBehavior._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00009328 File Offset: 0x00007528
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BottomSheetBehavior(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(BottomSheetBehavior._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BottomSheetBehavior._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00009404 File Offset: 0x00007604
		private static Delegate GetIsDraggableHandler()
		{
			if (BottomSheetBehavior.cb_isDraggable == null)
			{
				BottomSheetBehavior.cb_isDraggable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsDraggable));
			}
			return BottomSheetBehavior.cb_isDraggable;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00009428 File Offset: 0x00007628
		private static bool n_IsDraggable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Draggable;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00009437 File Offset: 0x00007637
		private static Delegate GetSetDraggable_ZHandler()
		{
			if (BottomSheetBehavior.cb_setDraggable_Z == null)
			{
				BottomSheetBehavior.cb_setDraggable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetDraggable_Z));
			}
			return BottomSheetBehavior.cb_setDraggable_Z;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000945B File Offset: 0x0000765B
		private static void n_SetDraggable_Z(IntPtr jnienv, IntPtr native__this, bool draggable)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Draggable = draggable;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000946B File Offset: 0x0000766B
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00009484 File Offset: 0x00007684
		public unsafe virtual bool Draggable
		{
			[Register("isDraggable", "()Z", "GetIsDraggableHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isDraggable.()Z", this, null);
			}
			[Register("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setDraggable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000094BF File Offset: 0x000076BF
		private static Delegate GetGetExpandedOffsetHandler()
		{
			if (BottomSheetBehavior.cb_getExpandedOffset == null)
			{
				BottomSheetBehavior.cb_getExpandedOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetExpandedOffset));
			}
			return BottomSheetBehavior.cb_getExpandedOffset;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000094E3 File Offset: 0x000076E3
		private static int n_GetExpandedOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedOffset;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000094F2 File Offset: 0x000076F2
		private static Delegate GetSetExpandedOffset_IHandler()
		{
			if (BottomSheetBehavior.cb_setExpandedOffset_I == null)
			{
				BottomSheetBehavior.cb_setExpandedOffset_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetExpandedOffset_I));
			}
			return BottomSheetBehavior.cb_setExpandedOffset_I;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00009516 File Offset: 0x00007716
		private static void n_SetExpandedOffset_I(IntPtr jnienv, IntPtr native__this, int offset)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedOffset = offset;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00009526 File Offset: 0x00007726
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00009540 File Offset: 0x00007740
		public unsafe virtual int ExpandedOffset
		{
			[Register("getExpandedOffset", "()I", "GetGetExpandedOffsetHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedOffset.()I", this, null);
			}
			[Register("setExpandedOffset", "(I)V", "GetSetExpandedOffset_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedOffset.(I)V", this, ptr);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000957B File Offset: 0x0000777B
		private static Delegate GetIsFitToContentsHandler()
		{
			if (BottomSheetBehavior.cb_isFitToContents == null)
			{
				BottomSheetBehavior.cb_isFitToContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsFitToContents));
			}
			return BottomSheetBehavior.cb_isFitToContents;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000959F File Offset: 0x0000779F
		private static bool n_IsFitToContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FitToContents;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000095AE File Offset: 0x000077AE
		private static Delegate GetSetFitToContents_ZHandler()
		{
			if (BottomSheetBehavior.cb_setFitToContents_Z == null)
			{
				BottomSheetBehavior.cb_setFitToContents_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetFitToContents_Z));
			}
			return BottomSheetBehavior.cb_setFitToContents_Z;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000095D2 File Offset: 0x000077D2
		private static void n_SetFitToContents_Z(IntPtr jnienv, IntPtr native__this, bool fitToContents)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FitToContents = fitToContents;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000095E2 File Offset: 0x000077E2
		// (set) Token: 0x0600034E RID: 846 RVA: 0x000095FC File Offset: 0x000077FC
		public unsafe virtual bool FitToContents
		{
			[Register("isFitToContents", "()Z", "GetIsFitToContentsHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isFitToContents.()Z", this, null);
			}
			[Register("setFitToContents", "(Z)V", "GetSetFitToContents_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setFitToContents.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00009637 File Offset: 0x00007837
		private static Delegate GetIsGestureInsetBottomIgnoredHandler()
		{
			if (BottomSheetBehavior.cb_isGestureInsetBottomIgnored == null)
			{
				BottomSheetBehavior.cb_isGestureInsetBottomIgnored = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsGestureInsetBottomIgnored));
			}
			return BottomSheetBehavior.cb_isGestureInsetBottomIgnored;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000965B File Offset: 0x0000785B
		private static bool n_IsGestureInsetBottomIgnored(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GestureInsetBottomIgnored;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000966A File Offset: 0x0000786A
		private static Delegate GetSetGestureInsetBottomIgnored_ZHandler()
		{
			if (BottomSheetBehavior.cb_setGestureInsetBottomIgnored_Z == null)
			{
				BottomSheetBehavior.cb_setGestureInsetBottomIgnored_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetGestureInsetBottomIgnored_Z));
			}
			return BottomSheetBehavior.cb_setGestureInsetBottomIgnored_Z;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000968E File Offset: 0x0000788E
		private static void n_SetGestureInsetBottomIgnored_Z(IntPtr jnienv, IntPtr native__this, bool gestureInsetBottomIgnored)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GestureInsetBottomIgnored = gestureInsetBottomIgnored;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000969E File Offset: 0x0000789E
		// (set) Token: 0x06000354 RID: 852 RVA: 0x000096B8 File Offset: 0x000078B8
		public unsafe virtual bool GestureInsetBottomIgnored
		{
			[Register("isGestureInsetBottomIgnored", "()Z", "GetIsGestureInsetBottomIgnoredHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isGestureInsetBottomIgnored.()Z", this, null);
			}
			[Register("setGestureInsetBottomIgnored", "(Z)V", "GetSetGestureInsetBottomIgnored_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setGestureInsetBottomIgnored.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000096F3 File Offset: 0x000078F3
		private static Delegate GetGetHalfExpandedRatioHandler()
		{
			if (BottomSheetBehavior.cb_getHalfExpandedRatio == null)
			{
				BottomSheetBehavior.cb_getHalfExpandedRatio = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(BottomSheetBehavior.n_GetHalfExpandedRatio));
			}
			return BottomSheetBehavior.cb_getHalfExpandedRatio;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00009717 File Offset: 0x00007917
		private static float n_GetHalfExpandedRatio(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HalfExpandedRatio;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00009726 File Offset: 0x00007926
		private static Delegate GetSetHalfExpandedRatio_FHandler()
		{
			if (BottomSheetBehavior.cb_setHalfExpandedRatio_F == null)
			{
				BottomSheetBehavior.cb_setHalfExpandedRatio_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(BottomSheetBehavior.n_SetHalfExpandedRatio_F));
			}
			return BottomSheetBehavior.cb_setHalfExpandedRatio_F;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000974A File Offset: 0x0000794A
		private static void n_SetHalfExpandedRatio_F(IntPtr jnienv, IntPtr native__this, float ratio)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HalfExpandedRatio = ratio;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000975A File Offset: 0x0000795A
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00009774 File Offset: 0x00007974
		public unsafe virtual float HalfExpandedRatio
		{
			[Register("getHalfExpandedRatio", "()F", "GetGetHalfExpandedRatioHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualSingleMethod("getHalfExpandedRatio.()F", this, null);
			}
			[Register("setHalfExpandedRatio", "(F)V", "GetSetHalfExpandedRatio_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setHalfExpandedRatio.(F)V", this, ptr);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000097AF File Offset: 0x000079AF
		private static Delegate GetGetHideFrictionHandler()
		{
			if (BottomSheetBehavior.cb_getHideFriction == null)
			{
				BottomSheetBehavior.cb_getHideFriction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(BottomSheetBehavior.n_GetHideFriction));
			}
			return BottomSheetBehavior.cb_getHideFriction;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000097D3 File Offset: 0x000079D3
		private static float n_GetHideFriction(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideFriction;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000097E2 File Offset: 0x000079E2
		private static Delegate GetSetHideFriction_FHandler()
		{
			if (BottomSheetBehavior.cb_setHideFriction_F == null)
			{
				BottomSheetBehavior.cb_setHideFriction_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(BottomSheetBehavior.n_SetHideFriction_F));
			}
			return BottomSheetBehavior.cb_setHideFriction_F;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00009806 File Offset: 0x00007A06
		private static void n_SetHideFriction_F(IntPtr jnienv, IntPtr native__this, float hideFriction)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideFriction = hideFriction;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00009816 File Offset: 0x00007A16
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00009830 File Offset: 0x00007A30
		public unsafe virtual float HideFriction
		{
			[Register("getHideFriction", "()F", "GetGetHideFrictionHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualSingleMethod("getHideFriction.()F", this, null);
			}
			[Register("setHideFriction", "(F)V", "GetSetHideFriction_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setHideFriction.(F)V", this, ptr);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000986B File Offset: 0x00007A6B
		private static Delegate GetIsHideableHandler()
		{
			if (BottomSheetBehavior.cb_isHideable == null)
			{
				BottomSheetBehavior.cb_isHideable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsHideable));
			}
			return BottomSheetBehavior.cb_isHideable;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000988F File Offset: 0x00007A8F
		private static bool n_IsHideable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Hideable;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000989E File Offset: 0x00007A9E
		private static Delegate GetSetHideable_ZHandler()
		{
			if (BottomSheetBehavior.cb_setHideable_Z == null)
			{
				BottomSheetBehavior.cb_setHideable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetHideable_Z));
			}
			return BottomSheetBehavior.cb_setHideable_Z;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000098C2 File Offset: 0x00007AC2
		private static void n_SetHideable_Z(IntPtr jnienv, IntPtr native__this, bool hideable)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Hideable = hideable;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000098D2 File Offset: 0x00007AD2
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000098EC File Offset: 0x00007AEC
		public unsafe virtual bool Hideable
		{
			[Register("isHideable", "()Z", "GetIsHideableHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isHideable.()Z", this, null);
			}
			[Register("setHideable", "(Z)V", "GetSetHideable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setHideable.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00009927 File Offset: 0x00007B27
		private static Delegate GetIsHideableWhenDraggingHandler()
		{
			if (BottomSheetBehavior.cb_isHideableWhenDragging == null)
			{
				BottomSheetBehavior.cb_isHideableWhenDragging = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsHideableWhenDragging));
			}
			return BottomSheetBehavior.cb_isHideableWhenDragging;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000994B File Offset: 0x00007B4B
		private static bool n_IsHideableWhenDragging(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsHideableWhenDragging;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000995A File Offset: 0x00007B5A
		public virtual bool IsHideableWhenDragging
		{
			[Register("isHideableWhenDragging", "()Z", "GetIsHideableWhenDraggingHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isHideableWhenDragging.()Z", this, null);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00009973 File Offset: 0x00007B73
		private static Delegate GetIsNestedScrollingCheckEnabledHandler()
		{
			if (BottomSheetBehavior.cb_isNestedScrollingCheckEnabled == null)
			{
				BottomSheetBehavior.cb_isNestedScrollingCheckEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_IsNestedScrollingCheckEnabled));
			}
			return BottomSheetBehavior.cb_isNestedScrollingCheckEnabled;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00009997 File Offset: 0x00007B97
		private static bool n_IsNestedScrollingCheckEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNestedScrollingCheckEnabled;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000099A6 File Offset: 0x00007BA6
		public virtual bool IsNestedScrollingCheckEnabled
		{
			[Register("isNestedScrollingCheckEnabled", "()Z", "GetIsNestedScrollingCheckEnabledHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("isNestedScrollingCheckEnabled.()Z", this, null);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000099BF File Offset: 0x00007BBF
		private static Delegate GetGetLastStableStateHandler()
		{
			if (BottomSheetBehavior.cb_getLastStableState == null)
			{
				BottomSheetBehavior.cb_getLastStableState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetLastStableState));
			}
			return BottomSheetBehavior.cb_getLastStableState;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000099E3 File Offset: 0x00007BE3
		private static int n_GetLastStableState(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastStableState;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000099F2 File Offset: 0x00007BF2
		public virtual int LastStableState
		{
			[Register("getLastStableState", "()I", "GetGetLastStableStateHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getLastStableState.()I", this, null);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00009A0B File Offset: 0x00007C0B
		private static Delegate GetGetMaxHeightHandler()
		{
			if (BottomSheetBehavior.cb_getMaxHeight == null)
			{
				BottomSheetBehavior.cb_getMaxHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetMaxHeight));
			}
			return BottomSheetBehavior.cb_getMaxHeight;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00009A2F File Offset: 0x00007C2F
		private static int n_GetMaxHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxHeight;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00009A3E File Offset: 0x00007C3E
		private static Delegate GetSetMaxHeight_IHandler()
		{
			if (BottomSheetBehavior.cb_setMaxHeight_I == null)
			{
				BottomSheetBehavior.cb_setMaxHeight_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetMaxHeight_I));
			}
			return BottomSheetBehavior.cb_setMaxHeight_I;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00009A62 File Offset: 0x00007C62
		private static void n_SetMaxHeight_I(IntPtr jnienv, IntPtr native__this, int maxHeight)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxHeight = maxHeight;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00009A72 File Offset: 0x00007C72
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00009A8C File Offset: 0x00007C8C
		public unsafe virtual int MaxHeight
		{
			[Register("getMaxHeight", "()I", "GetGetMaxHeightHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getMaxHeight.()I", this, null);
			}
			[Register("setMaxHeight", "(I)V", "GetSetMaxHeight_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxHeight.(I)V", this, ptr);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00009AC7 File Offset: 0x00007CC7
		private static Delegate GetGetMaxWidthHandler()
		{
			if (BottomSheetBehavior.cb_getMaxWidth == null)
			{
				BottomSheetBehavior.cb_getMaxWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetMaxWidth));
			}
			return BottomSheetBehavior.cb_getMaxWidth;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00009AEB File Offset: 0x00007CEB
		private static int n_GetMaxWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00009AFA File Offset: 0x00007CFA
		private static Delegate GetSetMaxWidth_IHandler()
		{
			if (BottomSheetBehavior.cb_setMaxWidth_I == null)
			{
				BottomSheetBehavior.cb_setMaxWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetMaxWidth_I));
			}
			return BottomSheetBehavior.cb_setMaxWidth_I;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00009B1E File Offset: 0x00007D1E
		private static void n_SetMaxWidth_I(IntPtr jnienv, IntPtr native__this, int maxWidth)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth = maxWidth;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00009B2E File Offset: 0x00007D2E
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00009B48 File Offset: 0x00007D48
		public unsafe virtual int MaxWidth
		{
			[Register("getMaxWidth", "()I", "GetGetMaxWidthHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getMaxWidth.()I", this, null);
			}
			[Register("setMaxWidth", "(I)V", "GetSetMaxWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00009B83 File Offset: 0x00007D83
		private static Delegate GetGetPeekHeightHandler()
		{
			if (BottomSheetBehavior.cb_getPeekHeight == null)
			{
				BottomSheetBehavior.cb_getPeekHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetPeekHeight));
			}
			return BottomSheetBehavior.cb_getPeekHeight;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00009BA7 File Offset: 0x00007DA7
		private static int n_GetPeekHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PeekHeight;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00009BB6 File Offset: 0x00007DB6
		private static Delegate GetSetPeekHeight_IHandler()
		{
			if (BottomSheetBehavior.cb_setPeekHeight_I == null)
			{
				BottomSheetBehavior.cb_setPeekHeight_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetPeekHeight_I));
			}
			return BottomSheetBehavior.cb_setPeekHeight_I;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00009BDA File Offset: 0x00007DDA
		private static void n_SetPeekHeight_I(IntPtr jnienv, IntPtr native__this, int peekHeight)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PeekHeight = peekHeight;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00009BEA File Offset: 0x00007DEA
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00009C04 File Offset: 0x00007E04
		public unsafe virtual int PeekHeight
		{
			[Register("getPeekHeight", "()I", "GetGetPeekHeightHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getPeekHeight.()I", this, null);
			}
			[Register("setPeekHeight", "(I)V", "GetSetPeekHeight_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setPeekHeight.(I)V", this, ptr);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00009C3F File Offset: 0x00007E3F
		private static Delegate GetGetSaveFlagsHandler()
		{
			if (BottomSheetBehavior.cb_getSaveFlags == null)
			{
				BottomSheetBehavior.cb_getSaveFlags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetSaveFlags));
			}
			return BottomSheetBehavior.cb_getSaveFlags;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00009C63 File Offset: 0x00007E63
		private static int n_GetSaveFlags(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveFlags;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00009C72 File Offset: 0x00007E72
		private static Delegate GetSetSaveFlags_IHandler()
		{
			if (BottomSheetBehavior.cb_setSaveFlags_I == null)
			{
				BottomSheetBehavior.cb_setSaveFlags_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetSaveFlags_I));
			}
			return BottomSheetBehavior.cb_setSaveFlags_I;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00009C96 File Offset: 0x00007E96
		private static void n_SetSaveFlags_I(IntPtr jnienv, IntPtr native__this, int flags)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveFlags = flags;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00009CA6 File Offset: 0x00007EA6
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00009CC0 File Offset: 0x00007EC0
		public unsafe virtual int SaveFlags
		{
			[Register("getSaveFlags", "()I", "GetGetSaveFlagsHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getSaveFlags.()I", this, null);
			}
			[Register("setSaveFlags", "(I)V", "GetSetSaveFlags_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setSaveFlags.(I)V", this, ptr);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00009CFB File Offset: 0x00007EFB
		private static Delegate GetGetSignificantVelocityThresholdHandler()
		{
			if (BottomSheetBehavior.cb_getSignificantVelocityThreshold == null)
			{
				BottomSheetBehavior.cb_getSignificantVelocityThreshold = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetSignificantVelocityThreshold));
			}
			return BottomSheetBehavior.cb_getSignificantVelocityThreshold;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00009D1F File Offset: 0x00007F1F
		private static int n_GetSignificantVelocityThreshold(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignificantVelocityThreshold;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00009D2E File Offset: 0x00007F2E
		private static Delegate GetSetSignificantVelocityThreshold_IHandler()
		{
			if (BottomSheetBehavior.cb_setSignificantVelocityThreshold_I == null)
			{
				BottomSheetBehavior.cb_setSignificantVelocityThreshold_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetSignificantVelocityThreshold_I));
			}
			return BottomSheetBehavior.cb_setSignificantVelocityThreshold_I;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00009D52 File Offset: 0x00007F52
		private static void n_SetSignificantVelocityThreshold_I(IntPtr jnienv, IntPtr native__this, int significantVelocityThreshold)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignificantVelocityThreshold = significantVelocityThreshold;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00009D62 File Offset: 0x00007F62
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00009D7C File Offset: 0x00007F7C
		public unsafe virtual int SignificantVelocityThreshold
		{
			[Register("getSignificantVelocityThreshold", "()I", "GetGetSignificantVelocityThresholdHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getSignificantVelocityThreshold.()I", this, null);
			}
			[Register("setSignificantVelocityThreshold", "(I)V", "GetSetSignificantVelocityThreshold_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setSignificantVelocityThreshold.(I)V", this, ptr);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00009DB7 File Offset: 0x00007FB7
		private static Delegate GetGetSkipCollapsedHandler()
		{
			if (BottomSheetBehavior.cb_getSkipCollapsed == null)
			{
				BottomSheetBehavior.cb_getSkipCollapsed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_GetSkipCollapsed));
			}
			return BottomSheetBehavior.cb_getSkipCollapsed;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00009DDB File Offset: 0x00007FDB
		private static bool n_GetSkipCollapsed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SkipCollapsed;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00009DEA File Offset: 0x00007FEA
		private static Delegate GetSetSkipCollapsed_ZHandler()
		{
			if (BottomSheetBehavior.cb_setSkipCollapsed_Z == null)
			{
				BottomSheetBehavior.cb_setSkipCollapsed_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetSkipCollapsed_Z));
			}
			return BottomSheetBehavior.cb_setSkipCollapsed_Z;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00009E0E File Offset: 0x0000800E
		private static void n_SetSkipCollapsed_Z(IntPtr jnienv, IntPtr native__this, bool skipCollapsed)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SkipCollapsed = skipCollapsed;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00009E1E File Offset: 0x0000801E
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00009E38 File Offset: 0x00008038
		public unsafe virtual bool SkipCollapsed
		{
			[Register("getSkipCollapsed", "()Z", "GetGetSkipCollapsedHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("getSkipCollapsed.()Z", this, null);
			}
			[Register("setSkipCollapsed", "(Z)V", "GetSetSkipCollapsed_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setSkipCollapsed.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00009E73 File Offset: 0x00008073
		private static Delegate GetGetStateHandler()
		{
			if (BottomSheetBehavior.cb_getState == null)
			{
				BottomSheetBehavior.cb_getState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BottomSheetBehavior.n_GetState));
			}
			return BottomSheetBehavior.cb_getState;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00009E97 File Offset: 0x00008097
		private static int n_GetState(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).State;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00009EA6 File Offset: 0x000080A6
		private static Delegate GetSetState_IHandler()
		{
			if (BottomSheetBehavior.cb_setState_I == null)
			{
				BottomSheetBehavior.cb_setState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BottomSheetBehavior.n_SetState_I));
			}
			return BottomSheetBehavior.cb_setState_I;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00009ECA File Offset: 0x000080CA
		private static void n_SetState_I(IntPtr jnienv, IntPtr native__this, int state)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).State = state;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00009EDA File Offset: 0x000080DA
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00009EF4 File Offset: 0x000080F4
		public unsafe virtual int State
		{
			[Register("getState", "()I", "GetGetStateHandler")]
			get
			{
				return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getState.()I", this, null);
			}
			[Register("setState", "(I)V", "GetSetState_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setState.(I)V", this, ptr);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00009F2F File Offset: 0x0000812F
		private static Delegate GetAddBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler()
		{
			if (BottomSheetBehavior.cb_addBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ == null)
			{
				BottomSheetBehavior.cb_addBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BottomSheetBehavior.n_AddBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_));
			}
			return BottomSheetBehavior.cb_addBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00009F54 File Offset: 0x00008154
		private static void n_AddBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			BottomSheetBehavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BottomSheetBehavior.BottomSheetCallback object2 = Java.Lang.Object.GetObject<BottomSheetBehavior.BottomSheetCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.AddBottomSheetCallback(object2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00009F78 File Offset: 0x00008178
		[Register("addBottomSheetCallback", "(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", "GetAddBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler")]
		public unsafe virtual void AddBottomSheetCallback(BottomSheetBehavior.BottomSheetCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("addBottomSheetCallback.(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00009FDC File Offset: 0x000081DC
		private static Delegate GetCalculateSlideOffsetHandler()
		{
			if (BottomSheetBehavior.cb_calculateSlideOffset == null)
			{
				BottomSheetBehavior.cb_calculateSlideOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(BottomSheetBehavior.n_CalculateSlideOffset));
			}
			return BottomSheetBehavior.cb_calculateSlideOffset;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000A000 File Offset: 0x00008200
		private static float n_CalculateSlideOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CalculateSlideOffset();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000A00F File Offset: 0x0000820F
		[Register("calculateSlideOffset", "()F", "GetCalculateSlideOffsetHandler")]
		public virtual float CalculateSlideOffset()
		{
			return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualSingleMethod("calculateSlideOffset.()F", this, null);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000A028 File Offset: 0x00008228
		private static Delegate GetDisableShapeAnimationsHandler()
		{
			if (BottomSheetBehavior.cb_disableShapeAnimations == null)
			{
				BottomSheetBehavior.cb_disableShapeAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BottomSheetBehavior.n_DisableShapeAnimations));
			}
			return BottomSheetBehavior.cb_disableShapeAnimations;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000A04C File Offset: 0x0000824C
		private static void n_DisableShapeAnimations(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisableShapeAnimations();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000A05B File Offset: 0x0000825B
		[Register("disableShapeAnimations", "()V", "GetDisableShapeAnimationsHandler")]
		public virtual void DisableShapeAnimations()
		{
			BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("disableShapeAnimations.()V", this, null);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A074 File Offset: 0x00008274
		[Register("from", "(Landroid/view/View;)Lcom/google/android/material/bottomsheet/BottomSheetBehavior;", "")]
		[JavaTypeParameters(new string[]
		{
			"V extends android.view.View"
		})]
		public unsafe static BottomSheetBehavior From(Java.Lang.Object view)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(view);
			BottomSheetBehavior @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BottomSheetBehavior>(BottomSheetBehavior._members.StaticMethods.InvokeObjectMethod("from.(Landroid/view/View;)Lcom/google/android/material/bottomsheet/BottomSheetBehavior;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A0E4 File Offset: 0x000082E4
		private static Delegate GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
		{
			if (BottomSheetBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
			{
				BottomSheetBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BottomSheetBehavior.n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
			}
			return BottomSheetBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A108 File Offset: 0x00008308
		private static bool n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnInterceptTouchEvent(object2, object3, object4);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A140 File Offset: 0x00008340
		[Register("onInterceptTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public unsafe override bool OnInterceptTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onInterceptTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A1F8 File Offset: 0x000083F8
		private static Delegate GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler()
		{
			if (BottomSheetBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I == null)
			{
				BottomSheetBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(BottomSheetBehavior.n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I));
			}
			return BottomSheetBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A21C File Offset: 0x0000841C
		private static bool n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int layoutDirection)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.OnLayoutChild(object2, object3, layoutDirection);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000A24C File Offset: 0x0000844C
		[Register("onLayoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", "GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		public unsafe override bool OnLayoutChild(CoordinatorLayout parent, Java.Lang.Object child, int layoutDirection)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(layoutDirection);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onLayoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000A2F0 File Offset: 0x000084F0
		private static Delegate GetOnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIIIHandler()
		{
			if (BottomSheetBehavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII == null)
			{
				BottomSheetBehavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIIII_Z(BottomSheetBehavior.n_OnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII));
			}
			return BottomSheetBehavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000A314 File Offset: 0x00008514
		private static bool n_OnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.OnMeasureChild(object2, object3, parentWidthMeasureSpec, widthUsed, parentHeightMeasureSpec, heightUsed);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000A348 File Offset: 0x00008548
		[Register("onMeasureChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;IIII)Z", "GetOnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIIIHandler")]
		public unsafe override bool OnMeasureChild(CoordinatorLayout parent, Java.Lang.Object child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(parentWidthMeasureSpec);
				ptr[3] = new JniArgumentValue(widthUsed);
				ptr[4] = new JniArgumentValue(parentHeightMeasureSpec);
				ptr[5] = new JniArgumentValue(heightUsed);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onMeasureChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;IIII)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000A430 File Offset: 0x00008630
		private static Delegate GetOnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFHandler()
		{
			if (BottomSheetBehavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF == null)
			{
				BottomSheetBehavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFF_Z(BottomSheetBehavior.n_OnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF));
			}
			return BottomSheetBehavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000A454 File Offset: 0x00008654
		private static bool n_OnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, float velocityX, float velocityY)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, object3, object4, velocityX, velocityY);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000A490 File Offset: 0x00008690
		[Register("onNestedPreFling", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FF)Z", "GetOnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFHandler")]
		public unsafe override bool OnNestedPreFling(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, float velocityX, float velocityY)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[3] = new JniArgumentValue(velocityX);
				ptr[4] = new JniArgumentValue(velocityY);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedPreFling.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FF)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(coordinatorLayout);
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000A574 File Offset: 0x00008774
		private static Delegate GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIIHandler()
		{
			if (BottomSheetBehavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII == null)
			{
				BottomSheetBehavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIILI_V(BottomSheetBehavior.n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII));
			}
			return BottomSheetBehavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000A598 File Offset: 0x00008798
		private static void n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, object3, object4, dx, dy, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000A5F8 File Offset: 0x000087F8
		[Register("onNestedPreScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIIHandler")]
		public unsafe override void OnNestedPreScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dx, int dy, int[] consumed, int type)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			IntPtr intPtr2 = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[3] = new JniArgumentValue(dx);
				ptr[4] = new JniArgumentValue(dy);
				ptr[5] = new JniArgumentValue(intPtr2);
				ptr[6] = new JniArgumentValue(type);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[II)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr2, consumed);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(coordinatorLayout);
				GC.KeepAlive(child);
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000A728 File Offset: 0x00008928
		private static Delegate GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayIHandler()
		{
			if (BottomSheetBehavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI == null)
			{
				BottomSheetBehavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIIIIIL_V(BottomSheetBehavior.n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI));
			}
			return BottomSheetBehavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000A74C File Offset: 0x0000894C
		private static void n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedScroll(object2, object3, object4, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000A7B0 File Offset: 0x000089B0
		[Register("onNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayIHandler")]
		public unsafe override void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			IntPtr intPtr2 = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[3] = new JniArgumentValue(dxConsumed);
				ptr[4] = new JniArgumentValue(dyConsumed);
				ptr[5] = new JniArgumentValue(dxUnconsumed);
				ptr[6] = new JniArgumentValue(dyUnconsumed);
				ptr[7] = new JniArgumentValue(type);
				ptr[8] = new JniArgumentValue(intPtr2);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII[I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr2, consumed);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(coordinatorLayout);
				GC.KeepAlive(child);
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000A91C File Offset: 0x00008B1C
		private static Delegate GetOnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_Handler()
		{
			if (BottomSheetBehavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_ == null)
			{
				BottomSheetBehavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(BottomSheetBehavior.n_OnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_));
			}
			return BottomSheetBehavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000A940 File Offset: 0x00008B40
		private static void n_OnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_state)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			IParcelable object4 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2, object3, object4);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000A978 File Offset: 0x00008B78
		[Register("onRestoreInstanceState", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_Handler")]
		public unsafe override void OnRestoreInstanceState(CoordinatorLayout parent, Java.Lang.Object child, IParcelable state)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000AA34 File Offset: 0x00008C34
		private static Delegate GetOnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler()
		{
			if (BottomSheetBehavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ == null)
			{
				BottomSheetBehavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BottomSheetBehavior.n_OnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_));
			}
			return BottomSheetBehavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000AA58 File Offset: 0x00008C58
		private static IntPtr n_OnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnSaveInstanceState(object2, object3));
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000AA8C File Offset: 0x00008C8C
		[Register("onSaveInstanceState", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Landroid/os/Parcelable;", "GetOnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler")]
		public unsafe override IParcelable OnSaveInstanceState(CoordinatorLayout parent, Java.Lang.Object child)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			IParcelable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IParcelable>(BottomSheetBehavior._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Landroid/os/Parcelable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
			}
			return @object;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000AB28 File Offset: 0x00008D28
		private static Delegate GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (BottomSheetBehavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II == null)
			{
				BottomSheetBehavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLII_Z(BottomSheetBehavior.n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II));
			}
			return BottomSheetBehavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000AB4C File Offset: 0x00008D4C
		private static bool n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes, int type)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_directTargetChild, JniHandleOwnership.DoNotTransfer);
			View object5 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, object4, object5, axes, type);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Register("onStartNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe override bool OnStartNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View directTargetChild, View target, int axes, int type)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((directTargetChild == null) ? IntPtr.Zero : directTargetChild.Handle);
				ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[4] = new JniArgumentValue(axes);
				ptr[5] = new JniArgumentValue(type);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(coordinatorLayout);
				GC.KeepAlive(child);
				GC.KeepAlive(directTargetChild);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		private static Delegate GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (BottomSheetBehavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I == null)
			{
				BottomSheetBehavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLI_V(BottomSheetBehavior.n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I));
			}
			return BottomSheetBehavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		private static void n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int type)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2, object3, object4, type);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000AD00 File Offset: 0x00008F00
		[Register("onStopNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IHandler")]
		public unsafe override void OnStopNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int type)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[3] = new JniArgumentValue(type);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(coordinatorLayout);
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000ADCC File Offset: 0x00008FCC
		private static Delegate GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
		{
			if (BottomSheetBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
			{
				BottomSheetBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BottomSheetBehavior.n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
			}
			return BottomSheetBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		private static bool n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouchEvent(object2, object3, object4);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000AE28 File Offset: 0x00009028
		[Register("onTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public unsafe override bool OnTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000AEE0 File Offset: 0x000090E0
		private static Delegate GetRemoveBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler()
		{
			if (BottomSheetBehavior.cb_removeBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ == null)
			{
				BottomSheetBehavior.cb_removeBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BottomSheetBehavior.n_RemoveBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_));
			}
			return BottomSheetBehavior.cb_removeBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000AF04 File Offset: 0x00009104
		private static void n_RemoveBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			BottomSheetBehavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BottomSheetBehavior.BottomSheetCallback object2 = Java.Lang.Object.GetObject<BottomSheetBehavior.BottomSheetCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.RemoveBottomSheetCallback(object2);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000AF28 File Offset: 0x00009128
		[Register("removeBottomSheetCallback", "(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", "GetRemoveBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler")]
		public unsafe virtual void RemoveBottomSheetCallback(BottomSheetBehavior.BottomSheetCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("removeBottomSheetCallback.(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000AF8C File Offset: 0x0000918C
		private static Delegate GetSetBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler()
		{
			if (BottomSheetBehavior.cb_setBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ == null)
			{
				BottomSheetBehavior.cb_setBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BottomSheetBehavior.n_SetBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_));
			}
			return BottomSheetBehavior.cb_setBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000AFB0 File Offset: 0x000091B0
		private static void n_SetBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			BottomSheetBehavior @object = Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BottomSheetBehavior.BottomSheetCallback object2 = Java.Lang.Object.GetObject<BottomSheetBehavior.BottomSheetCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.SetBottomSheetCallback(object2);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000AFD4 File Offset: 0x000091D4
		[Register("setBottomSheetCallback", "(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", "GetSetBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_Handler")]
		public unsafe virtual void SetBottomSheetCallback(BottomSheetBehavior.BottomSheetCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setBottomSheetCallback.(Lcom/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000B038 File Offset: 0x00009238
		private static Delegate GetSetHideableInternal_ZHandler()
		{
			if (BottomSheetBehavior.cb_setHideableInternal_Z == null)
			{
				BottomSheetBehavior.cb_setHideableInternal_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetHideableInternal_Z));
			}
			return BottomSheetBehavior.cb_setHideableInternal_Z;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000B05C File Offset: 0x0000925C
		private static void n_SetHideableInternal_Z(IntPtr jnienv, IntPtr native__this, bool hideable)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHideableInternal(hideable);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000B06C File Offset: 0x0000926C
		[Register("setHideableInternal", "(Z)V", "GetSetHideableInternal_ZHandler")]
		public unsafe virtual void SetHideableInternal(bool hideable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hideable);
			BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setHideableInternal.(Z)V", this, ptr);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000B0A8 File Offset: 0x000092A8
		[Register("setPeekHeight", "(IZ)V", "")]
		public unsafe void SetPeekHeight(int peekHeight, bool animate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(peekHeight);
			ptr[1] = new JniArgumentValue(animate);
			BottomSheetBehavior._members.InstanceMethods.InvokeNonvirtualVoidMethod("setPeekHeight.(IZ)V", this, ptr);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000B0F6 File Offset: 0x000092F6
		private static Delegate GetSetUpdateImportantForAccessibilityOnSiblings_ZHandler()
		{
			if (BottomSheetBehavior.cb_setUpdateImportantForAccessibilityOnSiblings_Z == null)
			{
				BottomSheetBehavior.cb_setUpdateImportantForAccessibilityOnSiblings_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BottomSheetBehavior.n_SetUpdateImportantForAccessibilityOnSiblings_Z));
			}
			return BottomSheetBehavior.cb_setUpdateImportantForAccessibilityOnSiblings_Z;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000B11A File Offset: 0x0000931A
		private static void n_SetUpdateImportantForAccessibilityOnSiblings_Z(IntPtr jnienv, IntPtr native__this, bool updateImportantForAccessibilityOnSiblings)
		{
			Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUpdateImportantForAccessibilityOnSiblings(updateImportantForAccessibilityOnSiblings);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000B12C File Offset: 0x0000932C
		[Register("setUpdateImportantForAccessibilityOnSiblings", "(Z)V", "GetSetUpdateImportantForAccessibilityOnSiblings_ZHandler")]
		public unsafe virtual void SetUpdateImportantForAccessibilityOnSiblings(bool updateImportantForAccessibilityOnSiblings)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(updateImportantForAccessibilityOnSiblings);
			BottomSheetBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setUpdateImportantForAccessibilityOnSiblings.(Z)V", this, ptr);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000B167 File Offset: 0x00009367
		private static Delegate GetShouldExpandOnUpwardDrag_JFHandler()
		{
			if (BottomSheetBehavior.cb_shouldExpandOnUpwardDrag_JF == null)
			{
				BottomSheetBehavior.cb_shouldExpandOnUpwardDrag_JF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJF_Z(BottomSheetBehavior.n_ShouldExpandOnUpwardDrag_JF));
			}
			return BottomSheetBehavior.cb_shouldExpandOnUpwardDrag_JF;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000B18B File Offset: 0x0000938B
		private static bool n_ShouldExpandOnUpwardDrag_JF(IntPtr jnienv, IntPtr native__this, long dragDurationMillis, float yPositionPercentage)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldExpandOnUpwardDrag(dragDurationMillis, yPositionPercentage);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000B19C File Offset: 0x0000939C
		[Register("shouldExpandOnUpwardDrag", "(JF)Z", "GetShouldExpandOnUpwardDrag_JFHandler")]
		public unsafe virtual bool ShouldExpandOnUpwardDrag(long dragDurationMillis, float yPositionPercentage)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dragDurationMillis);
			ptr[1] = new JniArgumentValue(yPositionPercentage);
			return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldExpandOnUpwardDrag.(JF)Z", this, ptr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000B1EA File Offset: 0x000093EA
		private static Delegate GetShouldSkipHalfExpandedStateWhenDraggingHandler()
		{
			if (BottomSheetBehavior.cb_shouldSkipHalfExpandedStateWhenDragging == null)
			{
				BottomSheetBehavior.cb_shouldSkipHalfExpandedStateWhenDragging = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_ShouldSkipHalfExpandedStateWhenDragging));
			}
			return BottomSheetBehavior.cb_shouldSkipHalfExpandedStateWhenDragging;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000B20E File Offset: 0x0000940E
		private static bool n_ShouldSkipHalfExpandedStateWhenDragging(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldSkipHalfExpandedStateWhenDragging();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000B21D File Offset: 0x0000941D
		[Register("shouldSkipHalfExpandedStateWhenDragging", "()Z", "GetShouldSkipHalfExpandedStateWhenDraggingHandler")]
		public virtual bool ShouldSkipHalfExpandedStateWhenDragging()
		{
			return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldSkipHalfExpandedStateWhenDragging.()Z", this, null);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000B236 File Offset: 0x00009436
		private static Delegate GetShouldSkipSmoothAnimationHandler()
		{
			if (BottomSheetBehavior.cb_shouldSkipSmoothAnimation == null)
			{
				BottomSheetBehavior.cb_shouldSkipSmoothAnimation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BottomSheetBehavior.n_ShouldSkipSmoothAnimation));
			}
			return BottomSheetBehavior.cb_shouldSkipSmoothAnimation;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000B25A File Offset: 0x0000945A
		private static bool n_ShouldSkipSmoothAnimation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BottomSheetBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldSkipSmoothAnimation();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000B269 File Offset: 0x00009469
		[Register("shouldSkipSmoothAnimation", "()Z", "GetShouldSkipSmoothAnimationHandler")]
		public virtual bool ShouldSkipSmoothAnimation()
		{
			return BottomSheetBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldSkipSmoothAnimation.()Z", this, null);
		}

		// Token: 0x040000B1 RID: 177
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/bottomsheet/BottomSheetBehavior", typeof(BottomSheetBehavior));

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_isDraggable;

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_setDraggable_Z;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_getExpandedOffset;

		// Token: 0x040000B5 RID: 181
		private static Delegate cb_setExpandedOffset_I;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_isFitToContents;

		// Token: 0x040000B7 RID: 183
		private static Delegate cb_setFitToContents_Z;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_isGestureInsetBottomIgnored;

		// Token: 0x040000B9 RID: 185
		private static Delegate cb_setGestureInsetBottomIgnored_Z;

		// Token: 0x040000BA RID: 186
		private static Delegate cb_getHalfExpandedRatio;

		// Token: 0x040000BB RID: 187
		private static Delegate cb_setHalfExpandedRatio_F;

		// Token: 0x040000BC RID: 188
		private static Delegate cb_getHideFriction;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_setHideFriction_F;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_isHideable;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_setHideable_Z;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_isHideableWhenDragging;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_isNestedScrollingCheckEnabled;

		// Token: 0x040000C2 RID: 194
		private static Delegate cb_getLastStableState;

		// Token: 0x040000C3 RID: 195
		private static Delegate cb_getMaxHeight;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_setMaxHeight_I;

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_getMaxWidth;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_setMaxWidth_I;

		// Token: 0x040000C7 RID: 199
		private static Delegate cb_getPeekHeight;

		// Token: 0x040000C8 RID: 200
		private static Delegate cb_setPeekHeight_I;

		// Token: 0x040000C9 RID: 201
		private static Delegate cb_getSaveFlags;

		// Token: 0x040000CA RID: 202
		private static Delegate cb_setSaveFlags_I;

		// Token: 0x040000CB RID: 203
		private static Delegate cb_getSignificantVelocityThreshold;

		// Token: 0x040000CC RID: 204
		private static Delegate cb_setSignificantVelocityThreshold_I;

		// Token: 0x040000CD RID: 205
		private static Delegate cb_getSkipCollapsed;

		// Token: 0x040000CE RID: 206
		private static Delegate cb_setSkipCollapsed_Z;

		// Token: 0x040000CF RID: 207
		private static Delegate cb_getState;

		// Token: 0x040000D0 RID: 208
		private static Delegate cb_setState_I;

		// Token: 0x040000D1 RID: 209
		private static Delegate cb_addBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;

		// Token: 0x040000D2 RID: 210
		private static Delegate cb_calculateSlideOffset;

		// Token: 0x040000D3 RID: 211
		private static Delegate cb_disableShapeAnimations;

		// Token: 0x040000D4 RID: 212
		private static Delegate cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;

		// Token: 0x040000D5 RID: 213
		private static Delegate cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII;

		// Token: 0x040000D7 RID: 215
		private static Delegate cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF;

		// Token: 0x040000D8 RID: 216
		private static Delegate cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII;

		// Token: 0x040000D9 RID: 217
		private static Delegate cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI;

		// Token: 0x040000DA RID: 218
		private static Delegate cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;

		// Token: 0x040000DC RID: 220
		private static Delegate cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040000DE RID: 222
		private static Delegate cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_removeBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;

		// Token: 0x040000E0 RID: 224
		private static Delegate cb_setBottomSheetCallback_Lcom_google_android_material_bottomsheet_BottomSheetBehavior_BottomSheetCallback_;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_setHideableInternal_Z;

		// Token: 0x040000E2 RID: 226
		private static Delegate cb_setUpdateImportantForAccessibilityOnSiblings_Z;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_shouldExpandOnUpwardDrag_JF;

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_shouldSkipHalfExpandedStateWhenDragging;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_shouldSkipSmoothAnimation;

		// Token: 0x02000054 RID: 84
		[Register("com/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback", DoNotGenerateAcw = true)]
		public abstract class BottomSheetCallback : Java.Lang.Object
		{
			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060003DC RID: 988 RVA: 0x0000B2A0 File Offset: 0x000094A0
			internal static IntPtr class_ref
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060003DD RID: 989 RVA: 0x0000B2C4 File Offset: 0x000094C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallback._members;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060003DE RID: 990 RVA: 0x0000B2CC File Offset: 0x000094CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060003DF RID: 991 RVA: 0x0000B2F0 File Offset: 0x000094F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallback._members.ManagedPeerType;
				}
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x000020DC File Offset: 0x000002DC
			protected BottomSheetCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0000B2FC File Offset: 0x000094FC
			[Register(".ctor", "()V", "")]
			public BottomSheetCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BottomSheetBehavior.BottomSheetCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BottomSheetBehavior.BottomSheetCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0000B36A File Offset: 0x0000956A
			private static Delegate GetOnSlide_Landroid_view_View_FHandler()
			{
				if (BottomSheetBehavior.BottomSheetCallback.cb_onSlide_Landroid_view_View_F == null)
				{
					BottomSheetBehavior.BottomSheetCallback.cb_onSlide_Landroid_view_View_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_V(BottomSheetBehavior.BottomSheetCallback.n_OnSlide_Landroid_view_View_F));
				}
				return BottomSheetBehavior.BottomSheetCallback.cb_onSlide_Landroid_view_View_F;
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0000B390 File Offset: 0x00009590
			private static void n_OnSlide_Landroid_view_View_F(IntPtr jnienv, IntPtr native__this, IntPtr native_bottomSheet, float newState)
			{
				BottomSheetBehavior.BottomSheetCallback @object = Java.Lang.Object.GetObject<BottomSheetBehavior.BottomSheetCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_bottomSheet, JniHandleOwnership.DoNotTransfer);
				@object.OnSlide(object2, newState);
			}

			// Token: 0x060003E4 RID: 996
			[Register("onSlide", "(Landroid/view/View;F)V", "GetOnSlide_Landroid_view_View_FHandler")]
			public abstract void OnSlide(View bottomSheet, float newState);

			// Token: 0x060003E5 RID: 997 RVA: 0x0000B3B4 File Offset: 0x000095B4
			private static Delegate GetOnStateChanged_Landroid_view_View_IHandler()
			{
				if (BottomSheetBehavior.BottomSheetCallback.cb_onStateChanged_Landroid_view_View_I == null)
				{
					BottomSheetBehavior.BottomSheetCallback.cb_onStateChanged_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(BottomSheetBehavior.BottomSheetCallback.n_OnStateChanged_Landroid_view_View_I));
				}
				return BottomSheetBehavior.BottomSheetCallback.cb_onStateChanged_Landroid_view_View_I;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0000B3D8 File Offset: 0x000095D8
			private static void n_OnStateChanged_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				BottomSheetBehavior.BottomSheetCallback @object = Java.Lang.Object.GetObject<BottomSheetBehavior.BottomSheetCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnStateChanged(object2, p1);
			}

			// Token: 0x060003E7 RID: 999
			[Register("onStateChanged", "(Landroid/view/View;I)V", "GetOnStateChanged_Landroid_view_View_IHandler")]
			public abstract void OnStateChanged(View p0, int p1);

			// Token: 0x040000E6 RID: 230
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback", typeof(BottomSheetBehavior.BottomSheetCallback));

			// Token: 0x040000E7 RID: 231
			private static Delegate cb_onSlide_Landroid_view_View_F;

			// Token: 0x040000E8 RID: 232
			private static Delegate cb_onStateChanged_Landroid_view_View_I;
		}

		// Token: 0x02000055 RID: 85
		[Register("com/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback", DoNotGenerateAcw = true)]
		internal class BottomSheetCallbackInvoker : BottomSheetBehavior.BottomSheetCallback
		{
			// Token: 0x060003E9 RID: 1001 RVA: 0x0000B417 File Offset: 0x00009617
			public BottomSheetCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000B421 File Offset: 0x00009621
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallbackInvoker._members;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000B428 File Offset: 0x00009628
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BottomSheetBehavior.BottomSheetCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x0000B434 File Offset: 0x00009634
			[Register("onSlide", "(Landroid/view/View;F)V", "GetOnSlide_Landroid_view_View_FHandler")]
			public unsafe override void OnSlide(View bottomSheet, float newState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bottomSheet == null) ? IntPtr.Zero : bottomSheet.Handle);
					ptr[1] = new JniArgumentValue(newState);
					BottomSheetBehavior.BottomSheetCallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSlide.(Landroid/view/View;F)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(bottomSheet);
				}
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0000B4AC File Offset: 0x000096AC
			[Register("onStateChanged", "(Landroid/view/View;I)V", "GetOnStateChanged_Landroid_view_View_IHandler")]
			public unsafe override void OnStateChanged(View p0, int p1)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					ptr[1] = new JniArgumentValue(p1);
					BottomSheetBehavior.BottomSheetCallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onStateChanged.(Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x040000E9 RID: 233
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/bottomsheet/BottomSheetBehavior$BottomSheetCallback", typeof(BottomSheetBehavior.BottomSheetCallbackInvoker));
		}
	}
}
