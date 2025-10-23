using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x02000054 RID: 84
	[Register("androidx/recyclerview/widget/LinearLayoutManager", DoNotGenerateAcw = true)]
	public class LinearLayoutManager : RecyclerView.LayoutManager, ItemTouchHelper.IViewDropHandler, IJavaObject, IDisposable, IJavaPeerable, RecyclerView.SmoothScroller.IScrollVectorProvider
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000049E8 File Offset: 0x00002BE8
		internal new static IntPtr class_ref
		{
			get
			{
				return LinearLayoutManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00004A0C File Offset: 0x00002C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinearLayoutManager._members;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00004A14 File Offset: 0x00002C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinearLayoutManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00004A38 File Offset: 0x00002C38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinearLayoutManager._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004A44 File Offset: 0x00002C44
		protected LinearLayoutManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004A50 File Offset: 0x00002C50
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LinearLayoutManager(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(LinearLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004B00 File Offset: 0x00002D00
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe LinearLayoutManager(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				base.SetHandle(LinearLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00004C08 File Offset: 0x00002E08
		[Register(".ctor", "(Landroid/content/Context;IZ)V", "")]
		public unsafe LinearLayoutManager(Context context, int orientation, bool reverseLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(orientation);
				ptr[2] = new JniArgumentValue(reverseLayout);
				base.SetHandle(LinearLayoutManager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;IZ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutManager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004CE0 File Offset: 0x00002EE0
		private static Delegate GetGetInitialPrefetchItemCountHandler()
		{
			if (LinearLayoutManager.cb_getInitialPrefetchItemCount == null)
			{
				LinearLayoutManager.cb_getInitialPrefetchItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_GetInitialPrefetchItemCount));
			}
			return LinearLayoutManager.cb_getInitialPrefetchItemCount;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004D04 File Offset: 0x00002F04
		private static int n_GetInitialPrefetchItemCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitialPrefetchItemCount;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004D13 File Offset: 0x00002F13
		private static Delegate GetSetInitialPrefetchItemCount_IHandler()
		{
			if (LinearLayoutManager.cb_setInitialPrefetchItemCount_I == null)
			{
				LinearLayoutManager.cb_setInitialPrefetchItemCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutManager.n_SetInitialPrefetchItemCount_I));
			}
			return LinearLayoutManager.cb_setInitialPrefetchItemCount_I;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00004D37 File Offset: 0x00002F37
		private static void n_SetInitialPrefetchItemCount_I(IntPtr jnienv, IntPtr native__this, int itemCount)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitialPrefetchItemCount = itemCount;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00004D47 File Offset: 0x00002F47
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00004D60 File Offset: 0x00002F60
		public unsafe virtual int InitialPrefetchItemCount
		{
			[Register("getInitialPrefetchItemCount", "()I", "GetGetInitialPrefetchItemCountHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getInitialPrefetchItemCount.()I", this, null);
			}
			[Register("setInitialPrefetchItemCount", "(I)V", "GetSetInitialPrefetchItemCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setInitialPrefetchItemCount.(I)V", this, ptr);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00004D9B File Offset: 0x00002F9B
		private static Delegate GetIsLayoutRTLHandler()
		{
			if (LinearLayoutManager.cb_isLayoutRTL == null)
			{
				LinearLayoutManager.cb_isLayoutRTL = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutManager.n_IsLayoutRTL));
			}
			return LinearLayoutManager.cb_isLayoutRTL;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00004DBF File Offset: 0x00002FBF
		private static bool n_IsLayoutRTL(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutRTL;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00004DCE File Offset: 0x00002FCE
		protected virtual bool IsLayoutRTL
		{
			[Register("isLayoutRTL", "()Z", "GetIsLayoutRTLHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutRTL.()Z", this, null);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004DE7 File Offset: 0x00002FE7
		private static Delegate GetGetOrientationHandler()
		{
			if (LinearLayoutManager.cb_getOrientation == null)
			{
				LinearLayoutManager.cb_getOrientation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_GetOrientation));
			}
			return LinearLayoutManager.cb_getOrientation;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00004E0B File Offset: 0x0000300B
		private static int n_GetOrientation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Orientation;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00004E1A File Offset: 0x0000301A
		private static Delegate GetSetOrientation_IHandler()
		{
			if (LinearLayoutManager.cb_setOrientation_I == null)
			{
				LinearLayoutManager.cb_setOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutManager.n_SetOrientation_I));
			}
			return LinearLayoutManager.cb_setOrientation_I;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00004E3E File Offset: 0x0000303E
		private static void n_SetOrientation_I(IntPtr jnienv, IntPtr native__this, int orientation)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Orientation = orientation;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00004E4E File Offset: 0x0000304E
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00004E68 File Offset: 0x00003068
		public unsafe virtual int Orientation
		{
			[Register("getOrientation", "()I", "GetGetOrientationHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getOrientation.()I", this, null);
			}
			[Register("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setOrientation.(I)V", this, ptr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00004EA3 File Offset: 0x000030A3
		private static Delegate GetGetRecycleChildrenOnDetachHandler()
		{
			if (LinearLayoutManager.cb_getRecycleChildrenOnDetach == null)
			{
				LinearLayoutManager.cb_getRecycleChildrenOnDetach = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutManager.n_GetRecycleChildrenOnDetach));
			}
			return LinearLayoutManager.cb_getRecycleChildrenOnDetach;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004EC7 File Offset: 0x000030C7
		private static bool n_GetRecycleChildrenOnDetach(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RecycleChildrenOnDetach;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00004ED6 File Offset: 0x000030D6
		private static Delegate GetSetRecycleChildrenOnDetach_ZHandler()
		{
			if (LinearLayoutManager.cb_setRecycleChildrenOnDetach_Z == null)
			{
				LinearLayoutManager.cb_setRecycleChildrenOnDetach_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutManager.n_SetRecycleChildrenOnDetach_Z));
			}
			return LinearLayoutManager.cb_setRecycleChildrenOnDetach_Z;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00004EFA File Offset: 0x000030FA
		private static void n_SetRecycleChildrenOnDetach_Z(IntPtr jnienv, IntPtr native__this, bool recycleChildrenOnDetach)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RecycleChildrenOnDetach = recycleChildrenOnDetach;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00004F0A File Offset: 0x0000310A
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00004F24 File Offset: 0x00003124
		public unsafe virtual bool RecycleChildrenOnDetach
		{
			[Register("getRecycleChildrenOnDetach", "()Z", "GetGetRecycleChildrenOnDetachHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("getRecycleChildrenOnDetach.()Z", this, null);
			}
			[Register("setRecycleChildrenOnDetach", "(Z)V", "GetSetRecycleChildrenOnDetach_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setRecycleChildrenOnDetach.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004F5F File Offset: 0x0000315F
		private static Delegate GetGetReverseLayoutHandler()
		{
			if (LinearLayoutManager.cb_getReverseLayout == null)
			{
				LinearLayoutManager.cb_getReverseLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutManager.n_GetReverseLayout));
			}
			return LinearLayoutManager.cb_getReverseLayout;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00004F83 File Offset: 0x00003183
		private static bool n_GetReverseLayout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReverseLayout;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00004F92 File Offset: 0x00003192
		private static Delegate GetSetReverseLayout_ZHandler()
		{
			if (LinearLayoutManager.cb_setReverseLayout_Z == null)
			{
				LinearLayoutManager.cb_setReverseLayout_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutManager.n_SetReverseLayout_Z));
			}
			return LinearLayoutManager.cb_setReverseLayout_Z;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004FB6 File Offset: 0x000031B6
		private static void n_SetReverseLayout_Z(IntPtr jnienv, IntPtr native__this, bool reverseLayout)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReverseLayout = reverseLayout;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00004FC6 File Offset: 0x000031C6
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00004FE0 File Offset: 0x000031E0
		public unsafe virtual bool ReverseLayout
		{
			[Register("getReverseLayout", "()Z", "GetGetReverseLayoutHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("getReverseLayout.()Z", this, null);
			}
			[Register("setReverseLayout", "(Z)V", "GetSetReverseLayout_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setReverseLayout.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000501B File Offset: 0x0000321B
		private static Delegate GetIsSmoothScrollbarEnabledHandler()
		{
			if (LinearLayoutManager.cb_isSmoothScrollbarEnabled == null)
			{
				LinearLayoutManager.cb_isSmoothScrollbarEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutManager.n_IsSmoothScrollbarEnabled));
			}
			return LinearLayoutManager.cb_isSmoothScrollbarEnabled;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000503F File Offset: 0x0000323F
		private static bool n_IsSmoothScrollbarEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SmoothScrollbarEnabled;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000504E File Offset: 0x0000324E
		private static Delegate GetSetSmoothScrollbarEnabled_ZHandler()
		{
			if (LinearLayoutManager.cb_setSmoothScrollbarEnabled_Z == null)
			{
				LinearLayoutManager.cb_setSmoothScrollbarEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutManager.n_SetSmoothScrollbarEnabled_Z));
			}
			return LinearLayoutManager.cb_setSmoothScrollbarEnabled_Z;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005072 File Offset: 0x00003272
		private static void n_SetSmoothScrollbarEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SmoothScrollbarEnabled = enabled;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00005082 File Offset: 0x00003282
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000509C File Offset: 0x0000329C
		public unsafe virtual bool SmoothScrollbarEnabled
		{
			[Register("isSmoothScrollbarEnabled", "()Z", "GetIsSmoothScrollbarEnabledHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isSmoothScrollbarEnabled.()Z", this, null);
			}
			[Register("setSmoothScrollbarEnabled", "(Z)V", "GetSetSmoothScrollbarEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setSmoothScrollbarEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000050D7 File Offset: 0x000032D7
		private static Delegate GetGetStackFromEndHandler()
		{
			if (LinearLayoutManager.cb_getStackFromEnd == null)
			{
				LinearLayoutManager.cb_getStackFromEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutManager.n_GetStackFromEnd));
			}
			return LinearLayoutManager.cb_getStackFromEnd;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000050FB File Offset: 0x000032FB
		private static bool n_GetStackFromEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StackFromEnd;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000510A File Offset: 0x0000330A
		private static Delegate GetSetStackFromEnd_ZHandler()
		{
			if (LinearLayoutManager.cb_setStackFromEnd_Z == null)
			{
				LinearLayoutManager.cb_setStackFromEnd_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutManager.n_SetStackFromEnd_Z));
			}
			return LinearLayoutManager.cb_setStackFromEnd_Z;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000512E File Offset: 0x0000332E
		private static void n_SetStackFromEnd_Z(IntPtr jnienv, IntPtr native__this, bool stackFromEnd)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StackFromEnd = stackFromEnd;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000513E File Offset: 0x0000333E
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00005158 File Offset: 0x00003358
		public unsafe virtual bool StackFromEnd
		{
			[Register("getStackFromEnd", "()Z", "GetGetStackFromEndHandler")]
			get
			{
				return LinearLayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("getStackFromEnd.()Z", this, null);
			}
			[Register("setStackFromEnd", "(Z)V", "GetSetStackFromEnd_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setStackFromEnd.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00005193 File Offset: 0x00003393
		private static Delegate GetCalculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayIHandler()
		{
			if (LinearLayoutManager.cb_calculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI == null)
			{
				LinearLayoutManager.cb_calculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LinearLayoutManager.n_CalculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI));
			}
			return LinearLayoutManager.cb_calculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000051B8 File Offset: 0x000033B8
		private static void n_CalculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_extraLayoutSpace)
		{
			LinearLayoutManager @object = Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_extraLayoutSpace, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.CalculateExtraLayoutSpace(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_extraLayoutSpace);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00005200 File Offset: 0x00003400
		[Register("calculateExtraLayoutSpace", "(Landroidx/recyclerview/widget/RecyclerView$State;[I)V", "GetCalculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayIHandler")]
		protected unsafe virtual void CalculateExtraLayoutSpace(RecyclerView.State state, int[] extraLayoutSpace)
		{
			IntPtr intPtr = JNIEnv.NewArray(extraLayoutSpace);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("calculateExtraLayoutSpace.(Landroidx/recyclerview/widget/RecyclerView$State;[I)V", this, ptr);
			}
			finally
			{
				if (extraLayoutSpace != null)
				{
					JNIEnv.CopyArray(intPtr, extraLayoutSpace);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(state);
				GC.KeepAlive(extraLayoutSpace);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00005294 File Offset: 0x00003494
		private static Delegate GetComputeScrollVectorForPosition_IHandler()
		{
			if (LinearLayoutManager.cb_computeScrollVectorForPosition_I == null)
			{
				LinearLayoutManager.cb_computeScrollVectorForPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(LinearLayoutManager.n_ComputeScrollVectorForPosition_I));
			}
			return LinearLayoutManager.cb_computeScrollVectorForPosition_I;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000052B8 File Offset: 0x000034B8
		private static IntPtr n_ComputeScrollVectorForPosition_I(IntPtr jnienv, IntPtr native__this, int targetPosition)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeScrollVectorForPosition(targetPosition));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000052D0 File Offset: 0x000034D0
		[Register("computeScrollVectorForPosition", "(I)Landroid/graphics/PointF;", "GetComputeScrollVectorForPosition_IHandler")]
		public unsafe virtual PointF ComputeScrollVectorForPosition(int targetPosition)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(targetPosition);
			return Java.Lang.Object.GetObject<PointF>(LinearLayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("computeScrollVectorForPosition.(I)Landroid/graphics/PointF;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00005319 File Offset: 0x00003519
		private static Delegate GetFindFirstCompletelyVisibleItemPositionHandler()
		{
			if (LinearLayoutManager.cb_findFirstCompletelyVisibleItemPosition == null)
			{
				LinearLayoutManager.cb_findFirstCompletelyVisibleItemPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_FindFirstCompletelyVisibleItemPosition));
			}
			return LinearLayoutManager.cb_findFirstCompletelyVisibleItemPosition;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000533D File Offset: 0x0000353D
		private static int n_FindFirstCompletelyVisibleItemPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindFirstCompletelyVisibleItemPosition();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000534C File Offset: 0x0000354C
		[Register("findFirstCompletelyVisibleItemPosition", "()I", "GetFindFirstCompletelyVisibleItemPositionHandler")]
		public virtual int FindFirstCompletelyVisibleItemPosition()
		{
			return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("findFirstCompletelyVisibleItemPosition.()I", this, null);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005365 File Offset: 0x00003565
		private static Delegate GetFindFirstVisibleItemPositionHandler()
		{
			if (LinearLayoutManager.cb_findFirstVisibleItemPosition == null)
			{
				LinearLayoutManager.cb_findFirstVisibleItemPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_FindFirstVisibleItemPosition));
			}
			return LinearLayoutManager.cb_findFirstVisibleItemPosition;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005389 File Offset: 0x00003589
		private static int n_FindFirstVisibleItemPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindFirstVisibleItemPosition();
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005398 File Offset: 0x00003598
		[Register("findFirstVisibleItemPosition", "()I", "GetFindFirstVisibleItemPositionHandler")]
		public virtual int FindFirstVisibleItemPosition()
		{
			return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("findFirstVisibleItemPosition.()I", this, null);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000053B1 File Offset: 0x000035B1
		private static Delegate GetFindLastCompletelyVisibleItemPositionHandler()
		{
			if (LinearLayoutManager.cb_findLastCompletelyVisibleItemPosition == null)
			{
				LinearLayoutManager.cb_findLastCompletelyVisibleItemPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_FindLastCompletelyVisibleItemPosition));
			}
			return LinearLayoutManager.cb_findLastCompletelyVisibleItemPosition;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000053D5 File Offset: 0x000035D5
		private static int n_FindLastCompletelyVisibleItemPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindLastCompletelyVisibleItemPosition();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000053E4 File Offset: 0x000035E4
		[Register("findLastCompletelyVisibleItemPosition", "()I", "GetFindLastCompletelyVisibleItemPositionHandler")]
		public virtual int FindLastCompletelyVisibleItemPosition()
		{
			return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("findLastCompletelyVisibleItemPosition.()I", this, null);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000053FD File Offset: 0x000035FD
		private static Delegate GetFindLastVisibleItemPositionHandler()
		{
			if (LinearLayoutManager.cb_findLastVisibleItemPosition == null)
			{
				LinearLayoutManager.cb_findLastVisibleItemPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutManager.n_FindLastVisibleItemPosition));
			}
			return LinearLayoutManager.cb_findLastVisibleItemPosition;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00005421 File Offset: 0x00003621
		private static int n_FindLastVisibleItemPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindLastVisibleItemPosition();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005430 File Offset: 0x00003630
		[Register("findLastVisibleItemPosition", "()I", "GetFindLastVisibleItemPositionHandler")]
		public virtual int FindLastVisibleItemPosition()
		{
			return LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("findLastVisibleItemPosition.()I", this, null);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005449 File Offset: 0x00003649
		private static Delegate GetGenerateDefaultLayoutParamsHandler()
		{
			if (LinearLayoutManager.cb_generateDefaultLayoutParams == null)
			{
				LinearLayoutManager.cb_generateDefaultLayoutParams = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinearLayoutManager.n_GenerateDefaultLayoutParams));
			}
			return LinearLayoutManager.cb_generateDefaultLayoutParams;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000546D File Offset: 0x0000366D
		private static IntPtr n_GenerateDefaultLayoutParams(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GenerateDefaultLayoutParams());
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00005484 File Offset: 0x00003684
		[Register("generateDefaultLayoutParams", "()Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", "GetGenerateDefaultLayoutParamsHandler")]
		public override RecyclerView.LayoutParams GenerateDefaultLayoutParams()
		{
			return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(LinearLayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("generateDefaultLayoutParams.()Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000054B6 File Offset: 0x000036B6
		private static Delegate GetGetExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
		{
			if (LinearLayoutManager.cb_getExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
			{
				LinearLayoutManager.cb_getExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(LinearLayoutManager.n_GetExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_));
			}
			return LinearLayoutManager.cb_getExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000054DC File Offset: 0x000036DC
		private static int n_GetExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			LinearLayoutManager @object = Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
			return @object.GetExtraLayoutSpace(object2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00005500 File Offset: 0x00003700
		[Register("getExtraLayoutSpace", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetGetExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
		protected unsafe virtual int GetExtraLayoutSpace(RecyclerView.State state)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				result = LinearLayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getExtraLayoutSpace.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005568 File Offset: 0x00003768
		private static Delegate GetPrepareForDrop_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (LinearLayoutManager.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II == null)
			{
				LinearLayoutManager.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(LinearLayoutManager.n_PrepareForDrop_Landroid_view_View_Landroid_view_View_II));
			}
			return LinearLayoutManager.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000558C File Offset: 0x0000378C
		private static void n_PrepareForDrop_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_target, int x, int y)
		{
			LinearLayoutManager @object = Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.PrepareForDrop(object2, object3, x, y);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000055BC File Offset: 0x000037BC
		[Register("prepareForDrop", "(Landroid/view/View;Landroid/view/View;II)V", "GetPrepareForDrop_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe virtual void PrepareForDrop(View view, View target, int x, int y)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue(x);
				ptr[3] = new JniArgumentValue(y);
				LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("prepareForDrop.(Landroid/view/View;Landroid/view/View;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00005674 File Offset: 0x00003874
		private static Delegate GetScrollToPositionWithOffset_IIHandler()
		{
			if (LinearLayoutManager.cb_scrollToPositionWithOffset_II == null)
			{
				LinearLayoutManager.cb_scrollToPositionWithOffset_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(LinearLayoutManager.n_ScrollToPositionWithOffset_II));
			}
			return LinearLayoutManager.cb_scrollToPositionWithOffset_II;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00005698 File Offset: 0x00003898
		private static void n_ScrollToPositionWithOffset_II(IntPtr jnienv, IntPtr native__this, int position, int offset)
		{
			Java.Lang.Object.GetObject<LinearLayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrollToPositionWithOffset(position, offset);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000056AC File Offset: 0x000038AC
		[Register("scrollToPositionWithOffset", "(II)V", "GetScrollToPositionWithOffset_IIHandler")]
		public unsafe virtual void ScrollToPositionWithOffset(int position, int offset)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ptr[1] = new JniArgumentValue(offset);
			LinearLayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("scrollToPositionWithOffset.(II)V", this, ptr);
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/LinearLayoutManager", typeof(LinearLayoutManager));

		// Token: 0x04000040 RID: 64
		private static Delegate cb_getInitialPrefetchItemCount;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_setInitialPrefetchItemCount_I;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_isLayoutRTL;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_getOrientation;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_setOrientation_I;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_getRecycleChildrenOnDetach;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_setRecycleChildrenOnDetach_Z;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_getReverseLayout;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_setReverseLayout_Z;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_isSmoothScrollbarEnabled;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_setSmoothScrollbarEnabled_Z;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_getStackFromEnd;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_setStackFromEnd_Z;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_calculateExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_arrayI;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_computeScrollVectorForPosition_I;

		// Token: 0x0400004F RID: 79
		private static Delegate cb_findFirstCompletelyVisibleItemPosition;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_findFirstVisibleItemPosition;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_findLastCompletelyVisibleItemPosition;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_findLastVisibleItemPosition;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_generateDefaultLayoutParams;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getExtraLayoutSpace_Landroidx_recyclerview_widget_RecyclerView_State_;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_scrollToPositionWithOffset_II;
	}
}
