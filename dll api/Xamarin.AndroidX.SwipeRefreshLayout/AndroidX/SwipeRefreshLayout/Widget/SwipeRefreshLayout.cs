using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.SwipeRefreshLayout.Widget
{
	// Token: 0x0200001B RID: 27
	[Register("androidx/swiperefreshlayout/widget/SwipeRefreshLayout", DoNotGenerateAcw = true)]
	public class SwipeRefreshLayout : ViewGroup, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable, INestedScrollingChild2, INestedScrollingChild3, INestedScrollingParent, INestedScrollingParent2, INestedScrollingParent3
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00002080 File Offset: 0x00000280
		public virtual void OnNestedScrollAccepted(View child, View target, int axes, int type)
		{
			this.OnNestedScrollAccepted(child, target, (ScrollAxis)axes, type);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000209C File Offset: 0x0000029C
		public virtual bool OnStartNestedScroll(View child, View target, int axes, int type)
		{
			return this.OnStartNestedScroll(child, target, (ScrollAxis)axes, type);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000020B6 File Offset: 0x000002B6
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000020CD File Offset: 0x000002CD
		[Register("mFrom")]
		protected int MFrom
		{
			get
			{
				return SwipeRefreshLayout._members.InstanceFields.GetInt32Value("mFrom.I", this);
			}
			set
			{
				SwipeRefreshLayout._members.InstanceFields.SetValue("mFrom.I", this, value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000020E5 File Offset: 0x000002E5
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000020FC File Offset: 0x000002FC
		[Register("mOriginalOffsetTop")]
		protected int MOriginalOffsetTop
		{
			get
			{
				return SwipeRefreshLayout._members.InstanceFields.GetInt32Value("mOriginalOffsetTop.I", this);
			}
			set
			{
				SwipeRefreshLayout._members.InstanceFields.SetValue("mOriginalOffsetTop.I", this, value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002114 File Offset: 0x00000314
		internal static IntPtr class_ref
		{
			get
			{
				return SwipeRefreshLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002138 File Offset: 0x00000338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SwipeRefreshLayout._members;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002140 File Offset: 0x00000340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SwipeRefreshLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002164 File Offset: 0x00000364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SwipeRefreshLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002170 File Offset: 0x00000370
		protected SwipeRefreshLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000217C File Offset: 0x0000037C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SwipeRefreshLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(SwipeRefreshLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SwipeRefreshLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000222C File Offset: 0x0000042C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SwipeRefreshLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(SwipeRefreshLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SwipeRefreshLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002308 File Offset: 0x00000508
		private static Delegate GetGetProgressCircleDiameterHandler()
		{
			if (SwipeRefreshLayout.cb_getProgressCircleDiameter == null)
			{
				SwipeRefreshLayout.cb_getProgressCircleDiameter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwipeRefreshLayout.n_GetProgressCircleDiameter));
			}
			return SwipeRefreshLayout.cb_getProgressCircleDiameter;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000232C File Offset: 0x0000052C
		private static int n_GetProgressCircleDiameter(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressCircleDiameter;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000233B File Offset: 0x0000053B
		public virtual int ProgressCircleDiameter
		{
			[Register("getProgressCircleDiameter", "()I", "GetGetProgressCircleDiameterHandler")]
			get
			{
				return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualInt32Method("getProgressCircleDiameter.()I", this, null);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002354 File Offset: 0x00000554
		private static Delegate GetGetProgressViewEndOffsetHandler()
		{
			if (SwipeRefreshLayout.cb_getProgressViewEndOffset == null)
			{
				SwipeRefreshLayout.cb_getProgressViewEndOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwipeRefreshLayout.n_GetProgressViewEndOffset));
			}
			return SwipeRefreshLayout.cb_getProgressViewEndOffset;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002378 File Offset: 0x00000578
		private static int n_GetProgressViewEndOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressViewEndOffset;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002387 File Offset: 0x00000587
		public virtual int ProgressViewEndOffset
		{
			[Register("getProgressViewEndOffset", "()I", "GetGetProgressViewEndOffsetHandler")]
			get
			{
				return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualInt32Method("getProgressViewEndOffset.()I", this, null);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023A0 File Offset: 0x000005A0
		private static Delegate GetGetProgressViewStartOffsetHandler()
		{
			if (SwipeRefreshLayout.cb_getProgressViewStartOffset == null)
			{
				SwipeRefreshLayout.cb_getProgressViewStartOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwipeRefreshLayout.n_GetProgressViewStartOffset));
			}
			return SwipeRefreshLayout.cb_getProgressViewStartOffset;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000023C4 File Offset: 0x000005C4
		private static int n_GetProgressViewStartOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressViewStartOffset;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000023D3 File Offset: 0x000005D3
		public virtual int ProgressViewStartOffset
		{
			[Register("getProgressViewStartOffset", "()I", "GetGetProgressViewStartOffsetHandler")]
			get
			{
				return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualInt32Method("getProgressViewStartOffset.()I", this, null);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023EC File Offset: 0x000005EC
		private static Delegate GetIsRefreshingHandler()
		{
			if (SwipeRefreshLayout.cb_isRefreshing == null)
			{
				SwipeRefreshLayout.cb_isRefreshing = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SwipeRefreshLayout.n_IsRefreshing));
			}
			return SwipeRefreshLayout.cb_isRefreshing;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002410 File Offset: 0x00000610
		private static bool n_IsRefreshing(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Refreshing;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000241F File Offset: 0x0000061F
		private static Delegate GetSetRefreshing_ZHandler()
		{
			if (SwipeRefreshLayout.cb_setRefreshing_Z == null)
			{
				SwipeRefreshLayout.cb_setRefreshing_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SwipeRefreshLayout.n_SetRefreshing_Z));
			}
			return SwipeRefreshLayout.cb_setRefreshing_Z;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002443 File Offset: 0x00000643
		private static void n_SetRefreshing_Z(IntPtr jnienv, IntPtr native__this, bool refreshing)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Refreshing = refreshing;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002453 File Offset: 0x00000653
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000246C File Offset: 0x0000066C
		public unsafe virtual bool Refreshing
		{
			[Register("isRefreshing", "()Z", "GetIsRefreshingHandler")]
			get
			{
				return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isRefreshing.()Z", this, null);
			}
			[Register("setRefreshing", "(Z)V", "GetSetRefreshing_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setRefreshing.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000024A7 File Offset: 0x000006A7
		private static Delegate GetCanChildScrollUpHandler()
		{
			if (SwipeRefreshLayout.cb_canChildScrollUp == null)
			{
				SwipeRefreshLayout.cb_canChildScrollUp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SwipeRefreshLayout.n_CanChildScrollUp));
			}
			return SwipeRefreshLayout.cb_canChildScrollUp;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000024CB File Offset: 0x000006CB
		private static bool n_CanChildScrollUp(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanChildScrollUp();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000024DA File Offset: 0x000006DA
		[Register("canChildScrollUp", "()Z", "GetCanChildScrollUpHandler")]
		public virtual bool CanChildScrollUp()
		{
			return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("canChildScrollUp.()Z", this, null);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000024F3 File Offset: 0x000006F3
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIIHandler()
		{
			if (SwipeRefreshLayout.cb_dispatchNestedPreScroll_IIarrayIarrayII == null)
			{
				SwipeRefreshLayout.cb_dispatchNestedPreScroll_IIarrayIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILLI_Z(SwipeRefreshLayout.n_DispatchNestedPreScroll_IIarrayIarrayII));
			}
			return SwipeRefreshLayout.cb_dispatchNestedPreScroll_IIarrayIarrayII;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002518 File Offset: 0x00000718
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayII(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedPreScroll(dx, dy, array, array2, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002580 File Offset: 0x00000780
		[Register("dispatchNestedPreScroll", "(II[I[II)Z", "GetDispatchNestedPreScroll_IIarrayIarrayIIHandler")]
		public unsafe virtual bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow, int type)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			IntPtr intPtr2 = JNIEnv.NewArray(offsetInWindow);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dx);
				ptr[1] = new JniArgumentValue(dy);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(type);
				result = SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedPreScroll.(II[I[II)Z", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (offsetInWindow != null)
				{
					JNIEnv.CopyArray(intPtr2, offsetInWindow);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(consumed);
				GC.KeepAlive(offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002664 File Offset: 0x00000864
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIHandler()
		{
			if (SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayII == null)
			{
				SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILI_Z(SwipeRefreshLayout.n_DispatchNestedScroll_IIIIarrayII));
			}
			return SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayII;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002688 File Offset: 0x00000888
		private static bool n_DispatchNestedScroll_IIIIarrayII(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000026D0 File Offset: 0x000008D0
		[Register("dispatchNestedScroll", "(IIII[II)Z", "GetDispatchNestedScroll_IIIIarrayIIHandler")]
		public unsafe virtual bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type)
		{
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dxConsumed);
				ptr[1] = new JniArgumentValue(dyConsumed);
				ptr[2] = new JniArgumentValue(dxUnconsumed);
				ptr[3] = new JniArgumentValue(dyUnconsumed);
				ptr[4] = new JniArgumentValue(intPtr);
				ptr[5] = new JniArgumentValue(type);
				result = SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedScroll.(IIII[II)Z", this, ptr);
			}
			finally
			{
				if (offsetInWindow != null)
				{
					JNIEnv.CopyArray(intPtr, offsetInWindow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000027B0 File Offset: 0x000009B0
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIarrayIHandler()
		{
			if (SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayIIarrayI == null)
			{
				SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILIL_V(SwipeRefreshLayout.n_DispatchNestedScroll_IIIIarrayIIarrayI));
			}
			return SwipeRefreshLayout.cb_dispatchNestedScroll_IIIIarrayIIarrayI;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000027D4 File Offset: 0x000009D4
		private static void n_DispatchNestedScroll_IIIIarrayIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type, IntPtr native_consumed)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_consumed);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002840 File Offset: 0x00000A40
		[Register("dispatchNestedScroll", "(IIII[II[I)V", "GetDispatchNestedScroll_IIIIarrayIIarrayIHandler")]
		public unsafe virtual void DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed)
		{
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			IntPtr intPtr2 = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dxConsumed);
				ptr[1] = new JniArgumentValue(dyConsumed);
				ptr[2] = new JniArgumentValue(dxUnconsumed);
				ptr[3] = new JniArgumentValue(dyUnconsumed);
				ptr[4] = new JniArgumentValue(intPtr);
				ptr[5] = new JniArgumentValue(type);
				ptr[6] = new JniArgumentValue(intPtr2);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchNestedScroll.(IIII[II[I)V", this, ptr);
			}
			finally
			{
				if (offsetInWindow != null)
				{
					JNIEnv.CopyArray(intPtr, offsetInWindow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr2, consumed);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(offsetInWindow);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002954 File Offset: 0x00000B54
		private static Delegate GetInvokeHasNestedScrollingParent_IHandler()
		{
			if (SwipeRefreshLayout.cb_hasNestedScrollingParent_I == null)
			{
				SwipeRefreshLayout.cb_hasNestedScrollingParent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(SwipeRefreshLayout.n_InvokeHasNestedScrollingParent_I));
			}
			return SwipeRefreshLayout.cb_hasNestedScrollingParent_I;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002978 File Offset: 0x00000B78
		private static bool n_InvokeHasNestedScrollingParent_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvokeHasNestedScrollingParent(type);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002988 File Offset: 0x00000B88
		[Register("hasNestedScrollingParent", "(I)Z", "GetInvokeHasNestedScrollingParent_IHandler")]
		public unsafe virtual bool InvokeHasNestedScrollingParent(int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(type);
			return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("hasNestedScrollingParent.(I)Z", this, ptr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000029C3 File Offset: 0x00000BC3
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (SwipeRefreshLayout.cb_onLayout_ZIIII == null)
			{
				SwipeRefreshLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(SwipeRefreshLayout.n_OnLayout_ZIIII));
			}
			return SwipeRefreshLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000029E7 File Offset: 0x00000BE7
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, left, top, right, bottom);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A00 File Offset: 0x00000C00
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(left);
			ptr[2] = new JniArgumentValue(top);
			ptr[3] = new JniArgumentValue(right);
			ptr[4] = new JniArgumentValue(bottom);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002A92 File Offset: 0x00000C92
		private static Delegate GetOnMeasure_IIHandler()
		{
			if (SwipeRefreshLayout.cb_onMeasure_II == null)
			{
				SwipeRefreshLayout.cb_onMeasure_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(SwipeRefreshLayout.n_OnMeasure_II));
			}
			return SwipeRefreshLayout.cb_onMeasure_II;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002AB6 File Offset: 0x00000CB6
		private static void n_OnMeasure_II(IntPtr jnienv, IntPtr native__this, int widthMeasureSpec, int heightMeasureSpec)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002AC8 File Offset: 0x00000CC8
		[Register("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
		public new unsafe virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(widthMeasureSpec);
			ptr[1] = new JniArgumentValue(heightMeasureSpec);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasure.(II)V", this, ptr);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002B16 File Offset: 0x00000D16
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler()
		{
			if (SwipeRefreshLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
			{
				SwipeRefreshLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_V(SwipeRefreshLayout.n_OnNestedPreScroll_Landroid_view_View_IIarrayII));
			}
			return SwipeRefreshLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002B3C File Offset: 0x00000D3C
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002B88 File Offset: 0x00000D88
		[Register("onNestedPreScroll", "(Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler")]
		public unsafe virtual void OnNestedPreScroll(View target, int dx, int dy, int[] consumed, int type)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dx);
				ptr[2] = new JniArgumentValue(dy);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue(type);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroid/view/View;II[II)V", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002C64 File Offset: 0x00000E64
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler()
		{
			if (SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIII == null)
			{
				SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIII_V(SwipeRefreshLayout.n_OnNestedScroll_Landroid_view_View_IIIII));
			}
			return SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002C88 File Offset: 0x00000E88
		private static void n_OnNestedScroll_Landroid_view_View_IIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Register("onNestedScroll", "(Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIIHandler")]
		public unsafe virtual void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dxConsumed);
				ptr[2] = new JniArgumentValue(dyConsumed);
				ptr[3] = new JniArgumentValue(dxUnconsumed);
				ptr[4] = new JniArgumentValue(dyUnconsumed);
				ptr[5] = new JniArgumentValue(type);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroid/view/View;IIIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002D88 File Offset: 0x00000F88
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler()
		{
			if (SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI == null)
			{
				SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIIIL_V(SwipeRefreshLayout.n_OnNestedScroll_Landroid_view_View_IIIIIarrayI));
			}
			return SwipeRefreshLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002DAC File Offset: 0x00000FAC
		private static void n_OnNestedScroll_Landroid_view_View_IIIIIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002DFC File Offset: 0x00000FFC
		[Register("onNestedScroll", "(Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler")]
		public unsafe virtual void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dxConsumed);
				ptr[2] = new JniArgumentValue(dyConsumed);
				ptr[3] = new JniArgumentValue(dxUnconsumed);
				ptr[4] = new JniArgumentValue(dyUnconsumed);
				ptr[5] = new JniArgumentValue(type);
				ptr[6] = new JniArgumentValue(intPtr);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroid/view/View;IIIII[I)V", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002F04 File Offset: 0x00001104
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (SwipeRefreshLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
			{
				SwipeRefreshLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(SwipeRefreshLayout.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II));
			}
			return SwipeRefreshLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002F28 File Offset: 0x00001128
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002F5C File Offset: 0x0000115C
		[Register("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe virtual void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)axes);
				ptr[3] = new JniArgumentValue(type);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScrollAccepted.(Landroid/view/View;Landroid/view/View;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003014 File Offset: 0x00001214
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (SwipeRefreshLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
			{
				SwipeRefreshLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_Z(SwipeRefreshLayout.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II));
			}
			return SwipeRefreshLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003038 File Offset: 0x00001238
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000306C File Offset: 0x0000126C
		[Register("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe virtual bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)axes);
				ptr[3] = new JniArgumentValue(type);
				result = SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroid/view/View;Landroid/view/View;II)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003128 File Offset: 0x00001328
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler()
		{
			if (SwipeRefreshLayout.cb_onStopNestedScroll_Landroid_view_View_I == null)
			{
				SwipeRefreshLayout.cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(SwipeRefreshLayout.n_OnStopNestedScroll_Landroid_view_View_I));
			}
			return SwipeRefreshLayout.cb_onStopNestedScroll_Landroid_view_View_I;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000314C File Offset: 0x0000134C
		private static void n_OnStopNestedScroll_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2, type);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003170 File Offset: 0x00001370
		[Register("onStopNestedScroll", "(Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroid_view_View_IHandler")]
		public unsafe virtual void OnStopNestedScroll(View target, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(type);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000031E8 File Offset: 0x000013E8
		private static Delegate GetSetColorScheme_arrayIHandler()
		{
			if (SwipeRefreshLayout.cb_setColorScheme_arrayI == null)
			{
				SwipeRefreshLayout.cb_setColorScheme_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeRefreshLayout.n_SetColorScheme_arrayI));
			}
			return SwipeRefreshLayout.cb_setColorScheme_arrayI;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000320C File Offset: 0x0000140C
		private static void n_SetColorScheme_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_colors, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.SetColorScheme(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_colors);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003248 File Offset: 0x00001448
		[Register("setColorScheme", "([I)V", "GetSetColorScheme_arrayIHandler")]
		public unsafe virtual void SetColorScheme(params int[] colors)
		{
			IntPtr intPtr = JNIEnv.NewArray(colors);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setColorScheme.([I)V", this, ptr);
			}
			finally
			{
				if (colors != null)
				{
					JNIEnv.CopyArray(intPtr, colors);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(colors);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000032B4 File Offset: 0x000014B4
		private static Delegate GetSetColorSchemeColors_arrayIHandler()
		{
			if (SwipeRefreshLayout.cb_setColorSchemeColors_arrayI == null)
			{
				SwipeRefreshLayout.cb_setColorSchemeColors_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeRefreshLayout.n_SetColorSchemeColors_arrayI));
			}
			return SwipeRefreshLayout.cb_setColorSchemeColors_arrayI;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000032D8 File Offset: 0x000014D8
		private static void n_SetColorSchemeColors_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_colors, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.SetColorSchemeColors(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_colors);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003314 File Offset: 0x00001514
		[Register("setColorSchemeColors", "([I)V", "GetSetColorSchemeColors_arrayIHandler")]
		public unsafe virtual void SetColorSchemeColors(params int[] colors)
		{
			IntPtr intPtr = JNIEnv.NewArray(colors);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setColorSchemeColors.([I)V", this, ptr);
			}
			finally
			{
				if (colors != null)
				{
					JNIEnv.CopyArray(intPtr, colors);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(colors);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003380 File Offset: 0x00001580
		private static Delegate GetSetColorSchemeResources_arrayIHandler()
		{
			if (SwipeRefreshLayout.cb_setColorSchemeResources_arrayI == null)
			{
				SwipeRefreshLayout.cb_setColorSchemeResources_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeRefreshLayout.n_SetColorSchemeResources_arrayI));
			}
			return SwipeRefreshLayout.cb_setColorSchemeResources_arrayI;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000033A4 File Offset: 0x000015A4
		private static void n_SetColorSchemeResources_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_colorResIds)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_colorResIds, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.SetColorSchemeResources(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_colorResIds);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000033E0 File Offset: 0x000015E0
		[Register("setColorSchemeResources", "([I)V", "GetSetColorSchemeResources_arrayIHandler")]
		public unsafe virtual void SetColorSchemeResources(params int[] colorResIds)
		{
			IntPtr intPtr = JNIEnv.NewArray(colorResIds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setColorSchemeResources.([I)V", this, ptr);
			}
			finally
			{
				if (colorResIds != null)
				{
					JNIEnv.CopyArray(intPtr, colorResIds);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(colorResIds);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000344C File Offset: 0x0000164C
		private static Delegate GetSetDistanceToTriggerSync_IHandler()
		{
			if (SwipeRefreshLayout.cb_setDistanceToTriggerSync_I == null)
			{
				SwipeRefreshLayout.cb_setDistanceToTriggerSync_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetDistanceToTriggerSync_I));
			}
			return SwipeRefreshLayout.cb_setDistanceToTriggerSync_I;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003470 File Offset: 0x00001670
		private static void n_SetDistanceToTriggerSync_I(IntPtr jnienv, IntPtr native__this, int distance)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDistanceToTriggerSync(distance);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003480 File Offset: 0x00001680
		[Register("setDistanceToTriggerSync", "(I)V", "GetSetDistanceToTriggerSync_IHandler")]
		public unsafe virtual void SetDistanceToTriggerSync(int distance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(distance);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDistanceToTriggerSync.(I)V", this, ptr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000034BB File Offset: 0x000016BB
		private static Delegate GetSetLegacyRequestDisallowInterceptTouchEventEnabled_ZHandler()
		{
			if (SwipeRefreshLayout.cb_setLegacyRequestDisallowInterceptTouchEventEnabled_Z == null)
			{
				SwipeRefreshLayout.cb_setLegacyRequestDisallowInterceptTouchEventEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SwipeRefreshLayout.n_SetLegacyRequestDisallowInterceptTouchEventEnabled_Z));
			}
			return SwipeRefreshLayout.cb_setLegacyRequestDisallowInterceptTouchEventEnabled_Z;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000034DF File Offset: 0x000016DF
		private static void n_SetLegacyRequestDisallowInterceptTouchEventEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLegacyRequestDisallowInterceptTouchEventEnabled(enabled);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000034F0 File Offset: 0x000016F0
		[Register("setLegacyRequestDisallowInterceptTouchEventEnabled", "(Z)V", "GetSetLegacyRequestDisallowInterceptTouchEventEnabled_ZHandler")]
		public unsafe virtual void SetLegacyRequestDisallowInterceptTouchEventEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setLegacyRequestDisallowInterceptTouchEventEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000352B File Offset: 0x0000172B
		private static Delegate GetSetOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_Handler()
		{
			if (SwipeRefreshLayout.cb_setOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_ == null)
			{
				SwipeRefreshLayout.cb_setOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeRefreshLayout.n_SetOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_));
			}
			return SwipeRefreshLayout.cb_setOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003550 File Offset: 0x00001750
		private static void n_SetOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SwipeRefreshLayout.IOnChildScrollUpCallback object2 = Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnChildScrollUpCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.SetOnChildScrollUpCallback(object2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003574 File Offset: 0x00001774
		[Register("setOnChildScrollUpCallback", "(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnChildScrollUpCallback;)V", "GetSetOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_Handler")]
		public unsafe virtual void SetOnChildScrollUpCallback(SwipeRefreshLayout.IOnChildScrollUpCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setOnChildScrollUpCallback.(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnChildScrollUpCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000035DC File Offset: 0x000017DC
		private static Delegate GetSetOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_Handler()
		{
			if (SwipeRefreshLayout.cb_setOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_ == null)
			{
				SwipeRefreshLayout.cb_setOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeRefreshLayout.n_SetOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_));
			}
			return SwipeRefreshLayout.cb_setOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003600 File Offset: 0x00001800
		private static void n_SetOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SwipeRefreshLayout @object = Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SwipeRefreshLayout.IOnRefreshListener object2 = Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnRefreshListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnRefreshListener(object2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003624 File Offset: 0x00001824
		[Register("setOnRefreshListener", "(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnRefreshListener;)V", "GetSetOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_Handler")]
		public unsafe virtual void SetOnRefreshListener(SwipeRefreshLayout.IOnRefreshListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setOnRefreshListener.(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnRefreshListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000368C File Offset: 0x0000188C
		private static Delegate GetSetProgressBackgroundColor_IHandler()
		{
			if (SwipeRefreshLayout.cb_setProgressBackgroundColor_I == null)
			{
				SwipeRefreshLayout.cb_setProgressBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetProgressBackgroundColor_I));
			}
			return SwipeRefreshLayout.cb_setProgressBackgroundColor_I;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000036B0 File Offset: 0x000018B0
		private static void n_SetProgressBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int colorRes)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgressBackgroundColor(colorRes);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000036C0 File Offset: 0x000018C0
		[Register("setProgressBackgroundColor", "(I)V", "GetSetProgressBackgroundColor_IHandler")]
		public unsafe virtual void SetProgressBackgroundColor(int colorRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(colorRes);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressBackgroundColor.(I)V", this, ptr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000036FB File Offset: 0x000018FB
		private static Delegate GetSetProgressBackgroundColorSchemeColor_IHandler()
		{
			if (SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeColor_I == null)
			{
				SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetProgressBackgroundColorSchemeColor_I));
			}
			return SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeColor_I;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000371F File Offset: 0x0000191F
		private static void n_SetProgressBackgroundColorSchemeColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgressBackgroundColorSchemeColor(color);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003730 File Offset: 0x00001930
		[Register("setProgressBackgroundColorSchemeColor", "(I)V", "GetSetProgressBackgroundColorSchemeColor_IHandler")]
		public unsafe virtual void SetProgressBackgroundColorSchemeColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressBackgroundColorSchemeColor.(I)V", this, ptr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000376B File Offset: 0x0000196B
		private static Delegate GetSetProgressBackgroundColorSchemeResource_IHandler()
		{
			if (SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeResource_I == null)
			{
				SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetProgressBackgroundColorSchemeResource_I));
			}
			return SwipeRefreshLayout.cb_setProgressBackgroundColorSchemeResource_I;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000378F File Offset: 0x0000198F
		private static void n_SetProgressBackgroundColorSchemeResource_I(IntPtr jnienv, IntPtr native__this, int colorRes)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgressBackgroundColorSchemeResource(colorRes);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000037A0 File Offset: 0x000019A0
		[Register("setProgressBackgroundColorSchemeResource", "(I)V", "GetSetProgressBackgroundColorSchemeResource_IHandler")]
		public unsafe virtual void SetProgressBackgroundColorSchemeResource(int colorRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(colorRes);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressBackgroundColorSchemeResource.(I)V", this, ptr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000037DB File Offset: 0x000019DB
		private static Delegate GetSetProgressViewEndTarget_ZIHandler()
		{
			if (SwipeRefreshLayout.cb_setProgressViewEndTarget_ZI == null)
			{
				SwipeRefreshLayout.cb_setProgressViewEndTarget_ZI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZI_V(SwipeRefreshLayout.n_SetProgressViewEndTarget_ZI));
			}
			return SwipeRefreshLayout.cb_setProgressViewEndTarget_ZI;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000037FF File Offset: 0x000019FF
		private static void n_SetProgressViewEndTarget_ZI(IntPtr jnienv, IntPtr native__this, bool scale, int end)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgressViewEndTarget(scale, end);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003810 File Offset: 0x00001A10
		[Register("setProgressViewEndTarget", "(ZI)V", "GetSetProgressViewEndTarget_ZIHandler")]
		public unsafe virtual void SetProgressViewEndTarget(bool scale, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(scale);
			ptr[1] = new JniArgumentValue(end);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressViewEndTarget.(ZI)V", this, ptr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000385E File Offset: 0x00001A5E
		private static Delegate GetSetProgressViewOffset_ZIIHandler()
		{
			if (SwipeRefreshLayout.cb_setProgressViewOffset_ZII == null)
			{
				SwipeRefreshLayout.cb_setProgressViewOffset_ZII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZII_V(SwipeRefreshLayout.n_SetProgressViewOffset_ZII));
			}
			return SwipeRefreshLayout.cb_setProgressViewOffset_ZII;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003882 File Offset: 0x00001A82
		private static void n_SetProgressViewOffset_ZII(IntPtr jnienv, IntPtr native__this, bool scale, int start, int end)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgressViewOffset(scale, start, end);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003898 File Offset: 0x00001A98
		[Register("setProgressViewOffset", "(ZII)V", "GetSetProgressViewOffset_ZIIHandler")]
		public unsafe virtual void SetProgressViewOffset(bool scale, int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(scale);
			ptr[1] = new JniArgumentValue(start);
			ptr[2] = new JniArgumentValue(end);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressViewOffset.(ZII)V", this, ptr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000038FC File Offset: 0x00001AFC
		private static Delegate GetSetSize_IHandler()
		{
			if (SwipeRefreshLayout.cb_setSize_I == null)
			{
				SwipeRefreshLayout.cb_setSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetSize_I));
			}
			return SwipeRefreshLayout.cb_setSize_I;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003920 File Offset: 0x00001B20
		private static void n_SetSize_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSize(size);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003930 File Offset: 0x00001B30
		[Register("setSize", "(I)V", "GetSetSize_IHandler")]
		public unsafe virtual void SetSize(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSize.(I)V", this, ptr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000396B File Offset: 0x00001B6B
		private static Delegate GetSetSlingshotDistance_IHandler()
		{
			if (SwipeRefreshLayout.cb_setSlingshotDistance_I == null)
			{
				SwipeRefreshLayout.cb_setSlingshotDistance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_SetSlingshotDistance_I));
			}
			return SwipeRefreshLayout.cb_setSlingshotDistance_I;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000398F File Offset: 0x00001B8F
		private static void n_SetSlingshotDistance_I(IntPtr jnienv, IntPtr native__this, int slingshotDistance)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSlingshotDistance(slingshotDistance);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000039A0 File Offset: 0x00001BA0
		[Register("setSlingshotDistance", "(I)V", "GetSetSlingshotDistance_IHandler")]
		public unsafe virtual void SetSlingshotDistance(int slingshotDistance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(slingshotDistance);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSlingshotDistance.(I)V", this, ptr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000039DB File Offset: 0x00001BDB
		private static Delegate GetStartNestedScroll_IIHandler()
		{
			if (SwipeRefreshLayout.cb_startNestedScroll_II == null)
			{
				SwipeRefreshLayout.cb_startNestedScroll_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(SwipeRefreshLayout.n_StartNestedScroll_II));
			}
			return SwipeRefreshLayout.cb_startNestedScroll_II;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003A00 File Offset: 0x00001C00
		private static bool n_StartNestedScroll_II(IntPtr jnienv, IntPtr native__this, int native_axes, int type)
		{
			return Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes, type);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003A20 File Offset: 0x00001C20
		[Register("startNestedScroll", "(II)Z", "GetStartNestedScroll_IIHandler")]
		public unsafe virtual bool StartNestedScroll([GeneratedEnum] ScrollAxis axes, int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)axes);
			ptr[1] = new JniArgumentValue(type);
			return SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("startNestedScroll.(II)Z", this, ptr);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003A6E File Offset: 0x00001C6E
		private static Delegate GetStopNestedScroll_IHandler()
		{
			if (SwipeRefreshLayout.cb_stopNestedScroll_I == null)
			{
				SwipeRefreshLayout.cb_stopNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeRefreshLayout.n_StopNestedScroll_I));
			}
			return SwipeRefreshLayout.cb_stopNestedScroll_I;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003A92 File Offset: 0x00001C92
		private static void n_StopNestedScroll_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			Java.Lang.Object.GetObject<SwipeRefreshLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll(type);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[Register("stopNestedScroll", "(I)V", "GetStopNestedScroll_IHandler")]
		public unsafe virtual void StopNestedScroll(int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(type);
			SwipeRefreshLayout._members.InstanceMethods.InvokeVirtualVoidMethod("stopNestedScroll.(I)V", this, ptr);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000CF RID: 207 RVA: 0x00003AE0 File Offset: 0x00001CE0
		// (remove) Token: 0x060000D0 RID: 208 RVA: 0x00003B2C File Offset: 0x00001D2C
		public event EventHandler Refresh
		{
			add
			{
				EventHelper.AddEventHandler<SwipeRefreshLayout.IOnRefreshListener, SwipeRefreshLayout.IOnRefreshListenerImplementor>(ref this.weak_implementor_SetOnRefreshListener, new Func<SwipeRefreshLayout.IOnRefreshListenerImplementor>(this.__CreateIOnRefreshListenerImplementor), new Action<SwipeRefreshLayout.IOnRefreshListener>(this.SetOnRefreshListener), delegate(SwipeRefreshLayout.IOnRefreshListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<SwipeRefreshLayout.IOnRefreshListenerImplementor, bool> empty;
				if ((empty = SwipeRefreshLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (SwipeRefreshLayout.<>O.<0>____IsEmpty = new Func<SwipeRefreshLayout.IOnRefreshListenerImplementor, bool>(SwipeRefreshLayout.IOnRefreshListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<SwipeRefreshLayout.IOnRefreshListener, SwipeRefreshLayout.IOnRefreshListenerImplementor>(ref this.weak_implementor_SetOnRefreshListener, empty, delegate(SwipeRefreshLayout.IOnRefreshListener __v)
				{
					this.SetOnRefreshListener(null);
				}, delegate(SwipeRefreshLayout.IOnRefreshListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003B8B File Offset: 0x00001D8B
		private SwipeRefreshLayout.IOnRefreshListenerImplementor __CreateIOnRefreshListenerImplementor()
		{
			return new SwipeRefreshLayout.IOnRefreshListenerImplementor(this);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/swiperefreshlayout/widget/SwipeRefreshLayout", typeof(SwipeRefreshLayout));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getProgressCircleDiameter;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getProgressViewEndOffset;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getProgressViewStartOffset;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_isRefreshing;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_setRefreshing_Z;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_canChildScrollUp;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_dispatchNestedScroll_IIIIarrayIIarrayI;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_hasNestedScrollingParent_I;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_onMeasure_II;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_setColorScheme_arrayI;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_setColorSchemeColors_arrayI;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_setColorSchemeResources_arrayI;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_setDistanceToTriggerSync_I;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_setLegacyRequestDisallowInterceptTouchEventEnabled_Z;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_setOnChildScrollUpCallback_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnChildScrollUpCallback_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_setOnRefreshListener_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_OnRefreshListener_;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_setProgressBackgroundColor_I;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_setProgressBackgroundColorSchemeColor_I;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_setProgressBackgroundColorSchemeResource_I;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_setProgressViewEndTarget_ZI;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_setProgressViewOffset_ZII;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_setSize_I;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_setSlingshotDistance_I;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_startNestedScroll_II;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_stopNestedScroll_I;

		// Token: 0x04000026 RID: 38
		private WeakReference weak_implementor_SetOnRefreshListener;

		// Token: 0x0200001C RID: 28
		[Register("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnChildScrollUpCallback", "", "AndroidX.SwipeRefreshLayout.Widget.SwipeRefreshLayout/IOnChildScrollUpCallbackInvoker")]
		public interface IOnChildScrollUpCallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000D3 RID: 211
			[Register("canChildScrollUp", "(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout;Landroid/view/View;)Z", "GetCanChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_Handler:AndroidX.SwipeRefreshLayout.Widget.SwipeRefreshLayout/IOnChildScrollUpCallbackInvoker, Xamarin.AndroidX.SwipeRefreshLayout")]
			bool CanChildScrollUp(SwipeRefreshLayout parent, View child);
		}

		// Token: 0x0200001D RID: 29
		[Register("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnChildScrollUpCallback", DoNotGenerateAcw = true)]
		internal class IOnChildScrollUpCallbackInvoker : Java.Lang.Object, SwipeRefreshLayout.IOnChildScrollUpCallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003BB0 File Offset: 0x00001DB0
			private static IntPtr java_class_ref
			{
				get
				{
					return SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003BD4 File Offset: 0x00001DD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker._members;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003BDB File Offset: 0x00001DDB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003BE3 File Offset: 0x00001DE3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00003BEF File Offset: 0x00001DEF
			public static SwipeRefreshLayout.IOnChildScrollUpCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnChildScrollUpCallback>(handle, transfer);
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00003BF8 File Offset: 0x00001DF8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.swiperefreshlayout.widget.SwipeRefreshLayout.OnChildScrollUpCallback'.");
				}
				return handle;
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00003C23 File Offset: 0x00001E23
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00003C54 File Offset: 0x00001E54
			public IOnChildScrollUpCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00003C8C File Offset: 0x00001E8C
			private static Delegate GetCanChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_Handler()
			{
				if (SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.cb_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_ == null)
				{
					SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.cb_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.n_CanChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_));
				}
				return SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker.cb_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00003CB0 File Offset: 0x00001EB0
			private static bool n_CanChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				SwipeRefreshLayout.IOnChildScrollUpCallback @object = Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnChildScrollUpCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				SwipeRefreshLayout object2 = Java.Lang.Object.GetObject<SwipeRefreshLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.CanChildScrollUp(object2, object3);
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00003CDC File Offset: 0x00001EDC
			public unsafe bool CanChildScrollUp(SwipeRefreshLayout parent, View child)
			{
				if (this.id_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "canChildScrollUp", "(Landroidx/swiperefreshlayout/widget/SwipeRefreshLayout;Landroid/view/View;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JValue((child == null) ? IntPtr.Zero : child.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_, ptr);
			}

			// Token: 0x04000027 RID: 39
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnChildScrollUpCallback", typeof(SwipeRefreshLayout.IOnChildScrollUpCallbackInvoker));

			// Token: 0x04000028 RID: 40
			private IntPtr class_ref;

			// Token: 0x04000029 RID: 41
			private static Delegate cb_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_;

			// Token: 0x0400002A RID: 42
			private IntPtr id_canChildScrollUp_Landroidx_swiperefreshlayout_widget_SwipeRefreshLayout_Landroid_view_View_;
		}

		// Token: 0x0200001E RID: 30
		[Register("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnRefreshListener", "", "AndroidX.SwipeRefreshLayout.Widget.SwipeRefreshLayout/IOnRefreshListenerInvoker")]
		public interface IOnRefreshListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000E0 RID: 224
			[Register("onRefresh", "()V", "GetOnRefreshHandler:AndroidX.SwipeRefreshLayout.Widget.SwipeRefreshLayout/IOnRefreshListenerInvoker, Xamarin.AndroidX.SwipeRefreshLayout")]
			void OnRefresh();
		}

		// Token: 0x0200001F RID: 31
		[Register("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnRefreshListener", DoNotGenerateAcw = true)]
		internal class IOnRefreshListenerInvoker : Java.Lang.Object, SwipeRefreshLayout.IOnRefreshListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003D8C File Offset: 0x00001F8C
			private static IntPtr java_class_ref
			{
				get
				{
					return SwipeRefreshLayout.IOnRefreshListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003DB0 File Offset: 0x00001FB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SwipeRefreshLayout.IOnRefreshListenerInvoker._members;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003DB7 File Offset: 0x00001FB7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003DBF File Offset: 0x00001FBF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SwipeRefreshLayout.IOnRefreshListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00003DCB File Offset: 0x00001FCB
			public static SwipeRefreshLayout.IOnRefreshListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnRefreshListener>(handle, transfer);
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00003DD4 File Offset: 0x00001FD4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SwipeRefreshLayout.IOnRefreshListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.swiperefreshlayout.widget.SwipeRefreshLayout.OnRefreshListener'.");
				}
				return handle;
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00003DFF File Offset: 0x00001FFF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00003E30 File Offset: 0x00002030
			public IOnRefreshListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SwipeRefreshLayout.IOnRefreshListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00003E68 File Offset: 0x00002068
			private static Delegate GetOnRefreshHandler()
			{
				if (SwipeRefreshLayout.IOnRefreshListenerInvoker.cb_onRefresh == null)
				{
					SwipeRefreshLayout.IOnRefreshListenerInvoker.cb_onRefresh = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SwipeRefreshLayout.IOnRefreshListenerInvoker.n_OnRefresh));
				}
				return SwipeRefreshLayout.IOnRefreshListenerInvoker.cb_onRefresh;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00003E8C File Offset: 0x0000208C
			private static void n_OnRefresh(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<SwipeRefreshLayout.IOnRefreshListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRefresh();
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00003E9B File Offset: 0x0000209B
			public void OnRefresh()
			{
				if (this.id_onRefresh == IntPtr.Zero)
				{
					this.id_onRefresh = JNIEnv.GetMethodID(this.class_ref, "onRefresh", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onRefresh);
			}

			// Token: 0x0400002B RID: 43
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/swiperefreshlayout/widget/SwipeRefreshLayout$OnRefreshListener", typeof(SwipeRefreshLayout.IOnRefreshListenerInvoker));

			// Token: 0x0400002C RID: 44
			private IntPtr class_ref;

			// Token: 0x0400002D RID: 45
			private static Delegate cb_onRefresh;

			// Token: 0x0400002E RID: 46
			private IntPtr id_onRefresh;
		}

		// Token: 0x02000020 RID: 32
		[Register("mono/androidx/swiperefreshlayout/widget/SwipeRefreshLayout_OnRefreshListenerImplementor")]
		internal sealed class IOnRefreshListenerImplementor : Java.Lang.Object, SwipeRefreshLayout.IOnRefreshListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000ED RID: 237 RVA: 0x00003EF6 File Offset: 0x000020F6
			public IOnRefreshListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/swiperefreshlayout/widget/SwipeRefreshLayout_OnRefreshListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00003F30 File Offset: 0x00002130
			public void OnRefresh()
			{
				EventHandler handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new EventArgs());
				}
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00003F58 File Offset: 0x00002158
			internal static bool __IsEmpty(SwipeRefreshLayout.IOnRefreshListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x0400002F RID: 47
			private object sender;

			// Token: 0x04000030 RID: 48
			public EventHandler Handler;
		}

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000031 RID: 49
			public static Func<SwipeRefreshLayout.IOnRefreshListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
