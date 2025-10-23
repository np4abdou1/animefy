using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Accessibility;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.Core.View;
using AndroidX.Core.View.Accessibility;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x02000055 RID: 85
	[Register("androidx/recyclerview/widget/RecyclerView", DoNotGenerateAcw = true)]
	public class RecyclerView : ViewGroup, INestedScrollingChild2, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable, INestedScrollingChild3, IScrollingView
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00005718 File Offset: 0x00003918
		internal static IntPtr class_ref
		{
			get
			{
				return RecyclerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000573C File Offset: 0x0000393C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RecyclerView._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00005744 File Offset: 0x00003944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RecyclerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00005768 File Offset: 0x00003968
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RecyclerView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00005774 File Offset: 0x00003974
		protected RecyclerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00005780 File Offset: 0x00003980
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RecyclerView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(RecyclerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00005830 File Offset: 0x00003A30
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe RecyclerView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(RecyclerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000590C File Offset: 0x00003B0C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe RecyclerView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(RecyclerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000059FC File Offset: 0x00003BFC
		private static Delegate GetGetCompatAccessibilityDelegateHandler()
		{
			if (RecyclerView.cb_getCompatAccessibilityDelegate == null)
			{
				RecyclerView.cb_getCompatAccessibilityDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetCompatAccessibilityDelegate));
			}
			return RecyclerView.cb_getCompatAccessibilityDelegate;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00005A20 File Offset: 0x00003C20
		private static IntPtr n_GetCompatAccessibilityDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatAccessibilityDelegate);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00005A34 File Offset: 0x00003C34
		public virtual RecyclerViewAccessibilityDelegate CompatAccessibilityDelegate
		{
			[Register("getCompatAccessibilityDelegate", "()Landroidx/recyclerview/widget/RecyclerViewAccessibilityDelegate;", "GetGetCompatAccessibilityDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RecyclerViewAccessibilityDelegate>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getCompatAccessibilityDelegate.()Landroidx/recyclerview/widget/RecyclerViewAccessibilityDelegate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00005A66 File Offset: 0x00003C66
		private static Delegate GetHasFixedSizeHandler()
		{
			if (RecyclerView.cb_hasFixedSize == null)
			{
				RecyclerView.cb_hasFixedSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_HasFixedSize));
			}
			return RecyclerView.cb_hasFixedSize;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00005A8A File Offset: 0x00003C8A
		private static bool n_HasFixedSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasFixedSize;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00005A99 File Offset: 0x00003C99
		private static Delegate GetSetHasFixedSize_ZHandler()
		{
			if (RecyclerView.cb_setHasFixedSize_Z == null)
			{
				RecyclerView.cb_setHasFixedSize_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.n_SetHasFixedSize_Z));
			}
			return RecyclerView.cb_setHasFixedSize_Z;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00005ABD File Offset: 0x00003CBD
		private static void n_SetHasFixedSize_Z(IntPtr jnienv, IntPtr native__this, bool hasFixedSize)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasFixedSize = hasFixedSize;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00005ACD File Offset: 0x00003CCD
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public unsafe virtual bool HasFixedSize
		{
			[Register("hasFixedSize", "()Z", "GetHasFixedSizeHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("hasFixedSize.()Z", this, null);
			}
			[Register("setHasFixedSize", "(Z)V", "GetSetHasFixedSize_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setHasFixedSize.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00005B23 File Offset: 0x00003D23
		private static Delegate GetHasPendingAdapterUpdatesHandler()
		{
			if (RecyclerView.cb_hasPendingAdapterUpdates == null)
			{
				RecyclerView.cb_hasPendingAdapterUpdates = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_HasPendingAdapterUpdates));
			}
			return RecyclerView.cb_hasPendingAdapterUpdates;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00005B47 File Offset: 0x00003D47
		private static bool n_HasPendingAdapterUpdates(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasPendingAdapterUpdates;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00005B56 File Offset: 0x00003D56
		public virtual bool HasPendingAdapterUpdates
		{
			[Register("hasPendingAdapterUpdates", "()Z", "GetHasPendingAdapterUpdatesHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("hasPendingAdapterUpdates.()Z", this, null);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00005B6F File Offset: 0x00003D6F
		private static Delegate GetIsAnimatingHandler()
		{
			if (RecyclerView.cb_isAnimating == null)
			{
				RecyclerView.cb_isAnimating = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_IsAnimating));
			}
			return RecyclerView.cb_isAnimating;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00005B93 File Offset: 0x00003D93
		private static bool n_IsAnimating(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAnimating;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public virtual bool IsAnimating
		{
			[Register("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnimating.()Z", this, null);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00005BBB File Offset: 0x00003DBB
		private static Delegate GetIsComputingLayoutHandler()
		{
			if (RecyclerView.cb_isComputingLayout == null)
			{
				RecyclerView.cb_isComputingLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_IsComputingLayout));
			}
			return RecyclerView.cb_isComputingLayout;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00005BDF File Offset: 0x00003DDF
		private static bool n_IsComputingLayout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsComputingLayout;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00005BEE File Offset: 0x00003DEE
		public virtual bool IsComputingLayout
		{
			[Register("isComputingLayout", "()Z", "GetIsComputingLayoutHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("isComputingLayout.()Z", this, null);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00005C07 File Offset: 0x00003E07
		public override bool IsLayoutSuppressed
		{
			[Register("isLayoutSuppressed", "()Z", "")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isLayoutSuppressed.()Z", this, null);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00005C20 File Offset: 0x00003E20
		private static Delegate GetGetItemDecorationCountHandler()
		{
			if (RecyclerView.cb_getItemDecorationCount == null)
			{
				RecyclerView.cb_getItemDecorationCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_GetItemDecorationCount));
			}
			return RecyclerView.cb_getItemDecorationCount;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00005C44 File Offset: 0x00003E44
		private static int n_GetItemDecorationCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemDecorationCount;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00005C53 File Offset: 0x00003E53
		public virtual int ItemDecorationCount
		{
			[Register("getItemDecorationCount", "()I", "GetGetItemDecorationCountHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getItemDecorationCount.()I", this, null);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00005C6C File Offset: 0x00003E6C
		private static Delegate GetIsLayoutFrozenHandler()
		{
			if (RecyclerView.cb_isLayoutFrozen == null)
			{
				RecyclerView.cb_isLayoutFrozen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_IsLayoutFrozen));
			}
			return RecyclerView.cb_isLayoutFrozen;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00005C90 File Offset: 0x00003E90
		private static bool n_IsLayoutFrozen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutFrozen;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00005C9F File Offset: 0x00003E9F
		private static Delegate GetSetLayoutFrozen_ZHandler()
		{
			if (RecyclerView.cb_setLayoutFrozen_Z == null)
			{
				RecyclerView.cb_setLayoutFrozen_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.n_SetLayoutFrozen_Z));
			}
			return RecyclerView.cb_setLayoutFrozen_Z;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005CC3 File Offset: 0x00003EC3
		private static void n_SetLayoutFrozen_Z(IntPtr jnienv, IntPtr native__this, bool frozen)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutFrozen = frozen;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00005CD3 File Offset: 0x00003ED3
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00005CEC File Offset: 0x00003EEC
		public unsafe virtual bool LayoutFrozen
		{
			[Register("isLayoutFrozen", "()Z", "GetIsLayoutFrozenHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutFrozen.()Z", this, null);
			}
			[Register("setLayoutFrozen", "(Z)V", "GetSetLayoutFrozen_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setLayoutFrozen.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00005D27 File Offset: 0x00003F27
		private static Delegate GetGetMaxFlingVelocityHandler()
		{
			if (RecyclerView.cb_getMaxFlingVelocity == null)
			{
				RecyclerView.cb_getMaxFlingVelocity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_GetMaxFlingVelocity));
			}
			return RecyclerView.cb_getMaxFlingVelocity;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00005D4B File Offset: 0x00003F4B
		private static int n_GetMaxFlingVelocity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxFlingVelocity;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00005D5A File Offset: 0x00003F5A
		public virtual int MaxFlingVelocity
		{
			[Register("getMaxFlingVelocity", "()I", "GetGetMaxFlingVelocityHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getMaxFlingVelocity.()I", this, null);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00005D73 File Offset: 0x00003F73
		private static Delegate GetGetMinFlingVelocityHandler()
		{
			if (RecyclerView.cb_getMinFlingVelocity == null)
			{
				RecyclerView.cb_getMinFlingVelocity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_GetMinFlingVelocity));
			}
			return RecyclerView.cb_getMinFlingVelocity;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00005D97 File Offset: 0x00003F97
		private static int n_GetMinFlingVelocity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinFlingVelocity;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00005DA6 File Offset: 0x00003FA6
		public virtual int MinFlingVelocity
		{
			[Register("getMinFlingVelocity", "()I", "GetGetMinFlingVelocityHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getMinFlingVelocity.()I", this, null);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00005DBF File Offset: 0x00003FBF
		private static Delegate GetGetPreserveFocusAfterLayoutHandler()
		{
			if (RecyclerView.cb_getPreserveFocusAfterLayout == null)
			{
				RecyclerView.cb_getPreserveFocusAfterLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.n_GetPreserveFocusAfterLayout));
			}
			return RecyclerView.cb_getPreserveFocusAfterLayout;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00005DE3 File Offset: 0x00003FE3
		private static bool n_GetPreserveFocusAfterLayout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreserveFocusAfterLayout;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00005DF2 File Offset: 0x00003FF2
		private static Delegate GetSetPreserveFocusAfterLayout_ZHandler()
		{
			if (RecyclerView.cb_setPreserveFocusAfterLayout_Z == null)
			{
				RecyclerView.cb_setPreserveFocusAfterLayout_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.n_SetPreserveFocusAfterLayout_Z));
			}
			return RecyclerView.cb_setPreserveFocusAfterLayout_Z;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00005E16 File Offset: 0x00004016
		private static void n_SetPreserveFocusAfterLayout_Z(IntPtr jnienv, IntPtr native__this, bool preserveFocusAfterLayout)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreserveFocusAfterLayout = preserveFocusAfterLayout;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00005E26 File Offset: 0x00004026
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00005E40 File Offset: 0x00004040
		public unsafe virtual bool PreserveFocusAfterLayout
		{
			[Register("getPreserveFocusAfterLayout", "()Z", "GetGetPreserveFocusAfterLayoutHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("getPreserveFocusAfterLayout.()Z", this, null);
			}
			[Register("setPreserveFocusAfterLayout", "(Z)V", "GetSetPreserveFocusAfterLayout_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setPreserveFocusAfterLayout.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00005E7B File Offset: 0x0000407B
		private static Delegate GetGetScrollStateHandler()
		{
			if (RecyclerView.cb_getScrollState == null)
			{
				RecyclerView.cb_getScrollState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_GetScrollState));
			}
			return RecyclerView.cb_getScrollState;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00005E9F File Offset: 0x0000409F
		private static int n_GetScrollState(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrollState;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00005EAE File Offset: 0x000040AE
		public virtual int ScrollState
		{
			[Register("getScrollState", "()I", "GetGetScrollStateHandler")]
			get
			{
				return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getScrollState.()I", this, null);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00005EC7 File Offset: 0x000040C7
		private static Delegate GetAddFocusables_Ljava_util_ArrayList_IIHandler()
		{
			if (RecyclerView.cb_addFocusables_Ljava_util_ArrayList_II == null)
			{
				RecyclerView.cb_addFocusables_Ljava_util_ArrayList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.n_AddFocusables_Ljava_util_ArrayList_II));
			}
			return RecyclerView.cb_addFocusables_Ljava_util_ArrayList_II;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00005EEC File Offset: 0x000040EC
		private static void n_AddFocusables_Ljava_util_ArrayList_II(IntPtr jnienv, IntPtr native__this, IntPtr native_views, int direction, int focusableMode)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
			@object.AddFocusables(views, direction, focusableMode);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00005F14 File Offset: 0x00004114
		[Register("addFocusables", "(Ljava/util/ArrayList;II)V", "GetAddFocusables_Ljava_util_ArrayList_IIHandler")]
		public unsafe virtual void AddFocusables(IList<View> views, int direction, int focusableMode)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(views);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(direction);
				ptr[2] = new JniArgumentValue(focusableMode);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addFocusables.(Ljava/util/ArrayList;II)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(views);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00005FA0 File Offset: 0x000041A0
		private static Delegate GetAddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_Handler()
		{
			if (RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_ == null)
			{
				RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_AddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_));
			}
			return RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00005FC4 File Offset: 0x000041C4
		private static void n_AddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_(IntPtr jnienv, IntPtr native__this, IntPtr native_decor)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ItemDecoration object2 = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(native_decor, JniHandleOwnership.DoNotTransfer);
			@object.AddItemDecoration(object2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Register("addItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", "GetAddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_Handler")]
		public unsafe virtual void AddItemDecoration(RecyclerView.ItemDecoration decor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000604C File Offset: 0x0000424C
		private static Delegate GetAddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_IHandler()
		{
			if (RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I == null)
			{
				RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.n_AddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I));
			}
			return RecyclerView.cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00006070 File Offset: 0x00004270
		private static void n_AddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I(IntPtr jnienv, IntPtr native__this, IntPtr native_decor, int index)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ItemDecoration object2 = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(native_decor, JniHandleOwnership.DoNotTransfer);
			@object.AddItemDecoration(object2, index);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00006094 File Offset: 0x00004294
		[Register("addItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;I)V", "GetAddItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_IHandler")]
		public unsafe virtual void AddItemDecoration(RecyclerView.ItemDecoration decor, int index)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				ptr[1] = new JniArgumentValue(index);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000610C File Offset: 0x0000430C
		private static Delegate GetAddOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_Handler()
		{
			if (RecyclerView.cb_addOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_ == null)
			{
				RecyclerView.cb_addOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_AddOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_));
			}
			return RecyclerView.cb_addOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00006130 File Offset: 0x00004330
		private static void n_AddOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IOnChildAttachStateChangeListener object2 = Java.Lang.Object.GetObject<RecyclerView.IOnChildAttachStateChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnChildAttachStateChangeListener(object2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00006154 File Offset: 0x00004354
		[Register("addOnChildAttachStateChangeListener", "(Landroidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener;)V", "GetAddOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_Handler")]
		public unsafe virtual void AddOnChildAttachStateChangeListener(RecyclerView.IOnChildAttachStateChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addOnChildAttachStateChangeListener.(Landroidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000061BC File Offset: 0x000043BC
		private static Delegate GetAddOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_Handler()
		{
			if (RecyclerView.cb_addOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_ == null)
			{
				RecyclerView.cb_addOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_AddOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_));
			}
			return RecyclerView.cb_addOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000061E0 File Offset: 0x000043E0
		private static void n_AddOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IOnItemTouchListener object2 = Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnItemTouchListener(object2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00006204 File Offset: 0x00004404
		[Register("addOnItemTouchListener", "(Landroidx/recyclerview/widget/RecyclerView$OnItemTouchListener;)V", "GetAddOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_Handler")]
		public unsafe virtual void AddOnItemTouchListener(RecyclerView.IOnItemTouchListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addOnItemTouchListener.(Landroidx/recyclerview/widget/RecyclerView$OnItemTouchListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000626C File Offset: 0x0000446C
		private static Delegate GetAddOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler()
		{
			if (RecyclerView.cb_addOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ == null)
			{
				RecyclerView.cb_addOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_AddOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_));
			}
			return RecyclerView.cb_addOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00006290 File Offset: 0x00004490
		private static void n_AddOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.OnScrollListener object2 = Java.Lang.Object.GetObject<RecyclerView.OnScrollListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnScrollListener(object2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000062B4 File Offset: 0x000044B4
		[Register("addOnScrollListener", "(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", "GetAddOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler")]
		public unsafe virtual void AddOnScrollListener(RecyclerView.OnScrollListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addOnScrollListener.(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00006318 File Offset: 0x00004518
		private static Delegate GetAddRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler()
		{
			if (RecyclerView.cb_addRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ == null)
			{
				RecyclerView.cb_addRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_AddRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_));
			}
			return RecyclerView.cb_addRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000633C File Offset: 0x0000453C
		private static void n_AddRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IRecyclerListener object2 = Java.Lang.Object.GetObject<RecyclerView.IRecyclerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddRecyclerListener(object2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00006360 File Offset: 0x00004560
		[Register("addRecyclerListener", "(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", "GetAddRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler")]
		public unsafe virtual void AddRecyclerListener(RecyclerView.IRecyclerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("addRecyclerListener.(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000063C8 File Offset: 0x000045C8
		private static Delegate GetClearOnChildAttachStateChangeListenersHandler()
		{
			if (RecyclerView.cb_clearOnChildAttachStateChangeListeners == null)
			{
				RecyclerView.cb_clearOnChildAttachStateChangeListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.n_ClearOnChildAttachStateChangeListeners));
			}
			return RecyclerView.cb_clearOnChildAttachStateChangeListeners;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000063EC File Offset: 0x000045EC
		private static void n_ClearOnChildAttachStateChangeListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnChildAttachStateChangeListeners();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000063FB File Offset: 0x000045FB
		[Register("clearOnChildAttachStateChangeListeners", "()V", "GetClearOnChildAttachStateChangeListenersHandler")]
		public virtual void ClearOnChildAttachStateChangeListeners()
		{
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnChildAttachStateChangeListeners.()V", this, null);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00006414 File Offset: 0x00004614
		private static Delegate GetClearOnScrollListenersHandler()
		{
			if (RecyclerView.cb_clearOnScrollListeners == null)
			{
				RecyclerView.cb_clearOnScrollListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.n_ClearOnScrollListeners));
			}
			return RecyclerView.cb_clearOnScrollListeners;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00006438 File Offset: 0x00004638
		private static void n_ClearOnScrollListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnScrollListeners();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00006447 File Offset: 0x00004647
		[Register("clearOnScrollListeners", "()V", "GetClearOnScrollListenersHandler")]
		public virtual void ClearOnScrollListeners()
		{
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnScrollListeners.()V", this, null);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00006460 File Offset: 0x00004660
		private static Delegate GetComputeHorizontalScrollExtentHandler()
		{
			if (RecyclerView.cb_computeHorizontalScrollExtent == null)
			{
				RecyclerView.cb_computeHorizontalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeHorizontalScrollExtent));
			}
			return RecyclerView.cb_computeHorizontalScrollExtent;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00006484 File Offset: 0x00004684
		private static int n_ComputeHorizontalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollExtent();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00006493 File Offset: 0x00004693
		[Register("computeHorizontalScrollExtent", "()I", "GetComputeHorizontalScrollExtentHandler")]
		public new virtual int ComputeHorizontalScrollExtent()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollExtent.()I", this, null);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000064AC File Offset: 0x000046AC
		private static Delegate GetComputeHorizontalScrollOffsetHandler()
		{
			if (RecyclerView.cb_computeHorizontalScrollOffset == null)
			{
				RecyclerView.cb_computeHorizontalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeHorizontalScrollOffset));
			}
			return RecyclerView.cb_computeHorizontalScrollOffset;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000064D0 File Offset: 0x000046D0
		private static int n_ComputeHorizontalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollOffset();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000064DF File Offset: 0x000046DF
		[Register("computeHorizontalScrollOffset", "()I", "GetComputeHorizontalScrollOffsetHandler")]
		public new virtual int ComputeHorizontalScrollOffset()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollOffset.()I", this, null);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000064F8 File Offset: 0x000046F8
		private static Delegate GetComputeHorizontalScrollRangeHandler()
		{
			if (RecyclerView.cb_computeHorizontalScrollRange == null)
			{
				RecyclerView.cb_computeHorizontalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeHorizontalScrollRange));
			}
			return RecyclerView.cb_computeHorizontalScrollRange;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000651C File Offset: 0x0000471C
		private static int n_ComputeHorizontalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollRange();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000652B File Offset: 0x0000472B
		[Register("computeHorizontalScrollRange", "()I", "GetComputeHorizontalScrollRangeHandler")]
		public new virtual int ComputeHorizontalScrollRange()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollRange.()I", this, null);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00006544 File Offset: 0x00004744
		private static Delegate GetComputeVerticalScrollExtentHandler()
		{
			if (RecyclerView.cb_computeVerticalScrollExtent == null)
			{
				RecyclerView.cb_computeVerticalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeVerticalScrollExtent));
			}
			return RecyclerView.cb_computeVerticalScrollExtent;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00006568 File Offset: 0x00004768
		private static int n_ComputeVerticalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollExtent();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00006577 File Offset: 0x00004777
		[Register("computeVerticalScrollExtent", "()I", "GetComputeVerticalScrollExtentHandler")]
		public new virtual int ComputeVerticalScrollExtent()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollExtent.()I", this, null);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00006590 File Offset: 0x00004790
		private static Delegate GetComputeVerticalScrollOffsetHandler()
		{
			if (RecyclerView.cb_computeVerticalScrollOffset == null)
			{
				RecyclerView.cb_computeVerticalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeVerticalScrollOffset));
			}
			return RecyclerView.cb_computeVerticalScrollOffset;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000065B4 File Offset: 0x000047B4
		private static int n_ComputeVerticalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollOffset();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000065C3 File Offset: 0x000047C3
		[Register("computeVerticalScrollOffset", "()I", "GetComputeVerticalScrollOffsetHandler")]
		public new virtual int ComputeVerticalScrollOffset()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollOffset.()I", this, null);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000065DC File Offset: 0x000047DC
		private static Delegate GetComputeVerticalScrollRangeHandler()
		{
			if (RecyclerView.cb_computeVerticalScrollRange == null)
			{
				RecyclerView.cb_computeVerticalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.n_ComputeVerticalScrollRange));
			}
			return RecyclerView.cb_computeVerticalScrollRange;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00006600 File Offset: 0x00004800
		private static int n_ComputeVerticalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollRange();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000660F File Offset: 0x0000480F
		[Register("computeVerticalScrollRange", "()I", "GetComputeVerticalScrollRangeHandler")]
		public new virtual int ComputeVerticalScrollRange()
		{
			return RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollRange.()I", this, null);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00006628 File Offset: 0x00004828
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIIHandler()
		{
			if (RecyclerView.cb_dispatchNestedPreScroll_IIarrayIarrayII == null)
			{
				RecyclerView.cb_dispatchNestedPreScroll_IIarrayIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILLI_Z(RecyclerView.n_DispatchNestedPreScroll_IIarrayIarrayII));
			}
			return RecyclerView.cb_dispatchNestedPreScroll_IIarrayIarrayII;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000664C File Offset: 0x0000484C
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayII(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow, int type)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x06000294 RID: 660 RVA: 0x000066B4 File Offset: 0x000048B4
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
				result = RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedPreScroll.(II[I[II)Z", this, ptr);
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

		// Token: 0x06000295 RID: 661 RVA: 0x00006798 File Offset: 0x00004998
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIHandler()
		{
			if (RecyclerView.cb_dispatchNestedScroll_IIIIarrayII == null)
			{
				RecyclerView.cb_dispatchNestedScroll_IIIIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILI_Z(RecyclerView.n_DispatchNestedScroll_IIIIarrayII));
			}
			return RecyclerView.cb_dispatchNestedScroll_IIIIarrayII;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000067BC File Offset: 0x000049BC
		private static bool n_DispatchNestedScroll_IIIIarrayII(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00006804 File Offset: 0x00004A04
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
				result = RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedScroll.(IIII[II)Z", this, ptr);
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

		// Token: 0x06000298 RID: 664 RVA: 0x000068E4 File Offset: 0x00004AE4
		[Register("dispatchNestedScroll", "(IIII[II[I)V", "")]
		public unsafe void DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed)
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
				RecyclerView._members.InstanceMethods.InvokeNonvirtualVoidMethod("dispatchNestedScroll.(IIII[II[I)V", this, ptr);
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

		// Token: 0x06000299 RID: 665 RVA: 0x000069F8 File Offset: 0x00004BF8
		private static Delegate GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler()
		{
			if (RecyclerView.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ == null)
			{
				RecyclerView.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_DispatchRestoreInstanceState_Landroid_util_SparseArray_));
			}
			return RecyclerView.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00006A1C File Offset: 0x00004C1C
		private static void n_DispatchRestoreInstanceState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			View @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.DispatchRestoreInstanceState(object2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00006A40 File Offset: 0x00004C40
		[Register("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", "GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler")]
		protected unsafe override void DispatchRestoreInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchRestoreInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00006AA4 File Offset: 0x00004CA4
		private static Delegate GetDispatchSaveInstanceState_Landroid_util_SparseArray_Handler()
		{
			if (RecyclerView.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_ == null)
			{
				RecyclerView.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_DispatchSaveInstanceState_Landroid_util_SparseArray_));
			}
			return RecyclerView.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private static void n_DispatchSaveInstanceState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			View @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.DispatchSaveInstanceState(object2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00006AEC File Offset: 0x00004CEC
		[Register("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", "GetDispatchSaveInstanceState_Landroid_util_SparseArray_Handler")]
		protected unsafe override void DispatchSaveInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchSaveInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006B50 File Offset: 0x00004D50
		private static Delegate GetDrawChild_Landroid_graphics_Canvas_Landroid_view_View_JHandler()
		{
			if (RecyclerView.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J == null)
			{
				RecyclerView.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJ_Z(RecyclerView.n_DrawChild_Landroid_graphics_Canvas_Landroid_view_View_J));
			}
			return RecyclerView.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00006B74 File Offset: 0x00004D74
		private static bool n_DrawChild_Landroid_graphics_Canvas_Landroid_view_View_J(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_child, long drawingTime)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.DrawChild(object2, object3, drawingTime);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00006BA4 File Offset: 0x00004DA4
		[Register("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", "GetDrawChild_Landroid_graphics_Canvas_Landroid_view_View_JHandler")]
		public new unsafe virtual bool DrawChild(Canvas canvas, View child, long drawingTime)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[2] = new JniArgumentValue(drawingTime);
				result = RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("drawChild.(Landroid/graphics/Canvas;Landroid/view/View;J)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00006C48 File Offset: 0x00004E48
		private static Delegate GetFindChildViewUnder_FFHandler()
		{
			if (RecyclerView.cb_findChildViewUnder_FF == null)
			{
				RecyclerView.cb_findChildViewUnder_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_L(RecyclerView.n_FindChildViewUnder_FF));
			}
			return RecyclerView.cb_findChildViewUnder_FF;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00006C6C File Offset: 0x00004E6C
		private static IntPtr n_FindChildViewUnder_FF(IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindChildViewUnder(x, y));
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00006C84 File Offset: 0x00004E84
		[Register("findChildViewUnder", "(FF)Landroid/view/View;", "GetFindChildViewUnder_FFHandler")]
		public unsafe virtual View FindChildViewUnder(float x, float y)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(y);
			return Java.Lang.Object.GetObject<View>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findChildViewUnder.(FF)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00006CE0 File Offset: 0x00004EE0
		private static Delegate GetFindContainingItemView_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_findContainingItemView_Landroid_view_View_ == null)
			{
				RecyclerView.cb_findContainingItemView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.n_FindContainingItemView_Landroid_view_View_));
			}
			return RecyclerView.cb_findContainingItemView_Landroid_view_View_;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00006D04 File Offset: 0x00004F04
		private static IntPtr n_FindContainingItemView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FindContainingItemView(object2));
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00006D2C File Offset: 0x00004F2C
		[Register("findContainingItemView", "(Landroid/view/View;)Landroid/view/View;", "GetFindContainingItemView_Landroid_view_View_Handler")]
		public unsafe virtual View FindContainingItemView(View view)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<View>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findContainingItemView.(Landroid/view/View;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00006DA0 File Offset: 0x00004FA0
		private static Delegate GetFindContainingViewHolder_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_findContainingViewHolder_Landroid_view_View_ == null)
			{
				RecyclerView.cb_findContainingViewHolder_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.n_FindContainingViewHolder_Landroid_view_View_));
			}
			return RecyclerView.cb_findContainingViewHolder_Landroid_view_View_;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00006DC4 File Offset: 0x00004FC4
		private static IntPtr n_FindContainingViewHolder_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FindContainingViewHolder(object2));
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00006DEC File Offset: 0x00004FEC
		[Register("findContainingViewHolder", "(Landroid/view/View;)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindContainingViewHolder_Landroid_view_View_Handler")]
		public unsafe virtual RecyclerView.ViewHolder FindContainingViewHolder(View view)
		{
			RecyclerView.ViewHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findContainingViewHolder.(Landroid/view/View;)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00006E60 File Offset: 0x00005060
		private static Delegate GetFindViewHolderForAdapterPosition_IHandler()
		{
			if (RecyclerView.cb_findViewHolderForAdapterPosition_I == null)
			{
				RecyclerView.cb_findViewHolderForAdapterPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.n_FindViewHolderForAdapterPosition_I));
			}
			return RecyclerView.cb_findViewHolderForAdapterPosition_I;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00006E84 File Offset: 0x00005084
		private static IntPtr n_FindViewHolderForAdapterPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewHolderForAdapterPosition(position));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00006E9C File Offset: 0x0000509C
		[Register("findViewHolderForAdapterPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForAdapterPosition_IHandler")]
		public unsafe virtual RecyclerView.ViewHolder FindViewHolderForAdapterPosition(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findViewHolderForAdapterPosition.(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00006EE5 File Offset: 0x000050E5
		private static Delegate GetFindViewHolderForItemId_JHandler()
		{
			if (RecyclerView.cb_findViewHolderForItemId_J == null)
			{
				RecyclerView.cb_findViewHolderForItemId_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(RecyclerView.n_FindViewHolderForItemId_J));
			}
			return RecyclerView.cb_findViewHolderForItemId_J;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00006F09 File Offset: 0x00005109
		private static IntPtr n_FindViewHolderForItemId_J(IntPtr jnienv, IntPtr native__this, long id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewHolderForItemId(id));
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00006F20 File Offset: 0x00005120
		[Register("findViewHolderForItemId", "(J)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForItemId_JHandler")]
		public unsafe virtual RecyclerView.ViewHolder FindViewHolderForItemId(long id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findViewHolderForItemId.(J)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00006F69 File Offset: 0x00005169
		private static Delegate GetFindViewHolderForLayoutPosition_IHandler()
		{
			if (RecyclerView.cb_findViewHolderForLayoutPosition_I == null)
			{
				RecyclerView.cb_findViewHolderForLayoutPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.n_FindViewHolderForLayoutPosition_I));
			}
			return RecyclerView.cb_findViewHolderForLayoutPosition_I;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00006F8D File Offset: 0x0000518D
		private static IntPtr n_FindViewHolderForLayoutPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewHolderForLayoutPosition(position));
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Register("findViewHolderForLayoutPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForLayoutPosition_IHandler")]
		public unsafe virtual RecyclerView.ViewHolder FindViewHolderForLayoutPosition(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findViewHolderForLayoutPosition.(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006FED File Offset: 0x000051ED
		private static Delegate GetFindViewHolderForPosition_IHandler()
		{
			if (RecyclerView.cb_findViewHolderForPosition_I == null)
			{
				RecyclerView.cb_findViewHolderForPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.n_FindViewHolderForPosition_I));
			}
			return RecyclerView.cb_findViewHolderForPosition_I;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00007011 File Offset: 0x00005211
		private static IntPtr n_FindViewHolderForPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewHolderForPosition(position));
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00007028 File Offset: 0x00005228
		[Register("findViewHolderForPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForPosition_IHandler")]
		public unsafe virtual RecyclerView.ViewHolder FindViewHolderForPosition(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("findViewHolderForPosition.(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00007071 File Offset: 0x00005271
		private static Delegate GetFling_IIHandler()
		{
			if (RecyclerView.cb_fling_II == null)
			{
				RecyclerView.cb_fling_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(RecyclerView.n_Fling_II));
			}
			return RecyclerView.cb_fling_II;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00007095 File Offset: 0x00005295
		private static bool n_Fling_II(IntPtr jnienv, IntPtr native__this, int velocityX, int velocityY)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Fling(velocityX, velocityY);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000070A8 File Offset: 0x000052A8
		[Register("fling", "(II)Z", "GetFling_IIHandler")]
		public unsafe virtual bool Fling(int velocityX, int velocityY)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(velocityX);
			ptr[1] = new JniArgumentValue(velocityY);
			return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("fling.(II)Z", this, ptr);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000070F6 File Offset: 0x000052F6
		private static Delegate GetGetAdapterHandler()
		{
			if (RecyclerView.cb_getAdapter == null)
			{
				RecyclerView.cb_getAdapter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetAdapter));
			}
			return RecyclerView.cb_getAdapter;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000711A File Offset: 0x0000531A
		private static IntPtr n_GetAdapter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapter());
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00007130 File Offset: 0x00005330
		[Register("getAdapter", "()Landroidx/recyclerview/widget/RecyclerView$Adapter;", "GetGetAdapterHandler")]
		public virtual RecyclerView.Adapter GetAdapter()
		{
			return Java.Lang.Object.GetObject<RecyclerView.Adapter>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapter.()Landroidx/recyclerview/widget/RecyclerView$Adapter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00007162 File Offset: 0x00005362
		private static Delegate GetGetChildAdapterPosition_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_getChildAdapterPosition_Landroid_view_View_ == null)
			{
				RecyclerView.cb_getChildAdapterPosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.n_GetChildAdapterPosition_Landroid_view_View_));
			}
			return RecyclerView.cb_getChildAdapterPosition_Landroid_view_View_;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00007188 File Offset: 0x00005388
		private static int n_GetChildAdapterPosition_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildAdapterPosition(object2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000071AC File Offset: 0x000053AC
		[Register("getChildAdapterPosition", "(Landroid/view/View;)I", "GetGetChildAdapterPosition_Landroid_view_View_Handler")]
		public unsafe virtual int GetChildAdapterPosition(View child)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getChildAdapterPosition.(Landroid/view/View;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00007214 File Offset: 0x00005414
		private static Delegate GetGetChildItemId_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_getChildItemId_Landroid_view_View_ == null)
			{
				RecyclerView.cb_getChildItemId_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(RecyclerView.n_GetChildItemId_Landroid_view_View_));
			}
			return RecyclerView.cb_getChildItemId_Landroid_view_View_;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00007238 File Offset: 0x00005438
		private static long n_GetChildItemId_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildItemId(object2);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000725C File Offset: 0x0000545C
		[Register("getChildItemId", "(Landroid/view/View;)J", "GetGetChildItemId_Landroid_view_View_Handler")]
		public unsafe virtual long GetChildItemId(View child)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = RecyclerView._members.InstanceMethods.InvokeVirtualInt64Method("getChildItemId.(Landroid/view/View;)J", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000072C4 File Offset: 0x000054C4
		private static Delegate GetGetChildLayoutPosition_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_getChildLayoutPosition_Landroid_view_View_ == null)
			{
				RecyclerView.cb_getChildLayoutPosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.n_GetChildLayoutPosition_Landroid_view_View_));
			}
			return RecyclerView.cb_getChildLayoutPosition_Landroid_view_View_;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000072E8 File Offset: 0x000054E8
		private static int n_GetChildLayoutPosition_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildLayoutPosition(object2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000730C File Offset: 0x0000550C
		[Register("getChildLayoutPosition", "(Landroid/view/View;)I", "GetGetChildLayoutPosition_Landroid_view_View_Handler")]
		public unsafe virtual int GetChildLayoutPosition(View child)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getChildLayoutPosition.(Landroid/view/View;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00007374 File Offset: 0x00005574
		private static Delegate GetGetChildPosition_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_getChildPosition_Landroid_view_View_ == null)
			{
				RecyclerView.cb_getChildPosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.n_GetChildPosition_Landroid_view_View_));
			}
			return RecyclerView.cb_getChildPosition_Landroid_view_View_;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00007398 File Offset: 0x00005598
		private static int n_GetChildPosition_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildPosition(object2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000073BC File Offset: 0x000055BC
		[Register("getChildPosition", "(Landroid/view/View;)I", "GetGetChildPosition_Landroid_view_View_Handler")]
		public unsafe virtual int GetChildPosition(View child)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = RecyclerView._members.InstanceMethods.InvokeVirtualInt32Method("getChildPosition.(Landroid/view/View;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00007424 File Offset: 0x00005624
		private static Delegate GetGetChildViewHolder_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_getChildViewHolder_Landroid_view_View_ == null)
			{
				RecyclerView.cb_getChildViewHolder_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.n_GetChildViewHolder_Landroid_view_View_));
			}
			return RecyclerView.cb_getChildViewHolder_Landroid_view_View_;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00007448 File Offset: 0x00005648
		private static IntPtr n_GetChildViewHolder_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetChildViewHolder(object2));
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00007470 File Offset: 0x00005670
		[Register("getChildViewHolder", "(Landroid/view/View;)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetGetChildViewHolder_Landroid_view_View_Handler")]
		public unsafe virtual RecyclerView.ViewHolder GetChildViewHolder(View child)
		{
			RecyclerView.ViewHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getChildViewHolder.(Landroid/view/View;)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return @object;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000074E4 File Offset: 0x000056E4
		private static Delegate GetGetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_Handler()
		{
			if (RecyclerView.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_ == null)
			{
				RecyclerView.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.n_GetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_));
			}
			return RecyclerView.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00007508 File Offset: 0x00005708
		private static void n_GetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_outBounds)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
			@object.GetDecoratedBoundsWithMargins(object2, object3);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00007534 File Offset: 0x00005734
		[Register("getDecoratedBoundsWithMargins", "(Landroid/view/View;Landroid/graphics/Rect;)V", "GetGetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetDecoratedBoundsWithMargins(View view, Rect outBounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("getDecoratedBoundsWithMargins.(Landroid/view/View;Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(outBounds);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000075C0 File Offset: 0x000057C0
		private static Delegate GetGetEdgeEffectFactoryHandler()
		{
			if (RecyclerView.cb_getEdgeEffectFactory == null)
			{
				RecyclerView.cb_getEdgeEffectFactory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetEdgeEffectFactory));
			}
			return RecyclerView.cb_getEdgeEffectFactory;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000075E4 File Offset: 0x000057E4
		private static IntPtr n_GetEdgeEffectFactory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetEdgeEffectFactory());
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000075F8 File Offset: 0x000057F8
		[Register("getEdgeEffectFactory", "()Landroidx/recyclerview/widget/RecyclerView$EdgeEffectFactory;", "GetGetEdgeEffectFactoryHandler")]
		public virtual RecyclerView.EdgeEffectFactory GetEdgeEffectFactory()
		{
			return Java.Lang.Object.GetObject<RecyclerView.EdgeEffectFactory>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getEdgeEffectFactory.()Landroidx/recyclerview/widget/RecyclerView$EdgeEffectFactory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000762A File Offset: 0x0000582A
		private static Delegate GetGetItemAnimatorHandler()
		{
			if (RecyclerView.cb_getItemAnimator == null)
			{
				RecyclerView.cb_getItemAnimator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetItemAnimator));
			}
			return RecyclerView.cb_getItemAnimator;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000764E File Offset: 0x0000584E
		private static IntPtr n_GetItemAnimator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemAnimator());
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00007664 File Offset: 0x00005864
		[Register("getItemAnimator", "()Landroidx/recyclerview/widget/RecyclerView$ItemAnimator;", "GetGetItemAnimatorHandler")]
		public virtual RecyclerView.ItemAnimator GetItemAnimator()
		{
			return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getItemAnimator.()Landroidx/recyclerview/widget/RecyclerView$ItemAnimator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00007696 File Offset: 0x00005896
		private static Delegate GetGetItemDecorationAt_IHandler()
		{
			if (RecyclerView.cb_getItemDecorationAt_I == null)
			{
				RecyclerView.cb_getItemDecorationAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.n_GetItemDecorationAt_I));
			}
			return RecyclerView.cb_getItemDecorationAt_I;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000076BA File Offset: 0x000058BA
		private static IntPtr n_GetItemDecorationAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemDecorationAt(index));
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000076D0 File Offset: 0x000058D0
		[Register("getItemDecorationAt", "(I)Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;", "GetGetItemDecorationAt_IHandler")]
		public unsafe virtual RecyclerView.ItemDecoration GetItemDecorationAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getItemDecorationAt.(I)Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00007719 File Offset: 0x00005919
		private static Delegate GetGetLayoutManagerHandler()
		{
			if (RecyclerView.cb_getLayoutManager == null)
			{
				RecyclerView.cb_getLayoutManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetLayoutManager));
			}
			return RecyclerView.cb_getLayoutManager;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000773D File Offset: 0x0000593D
		private static IntPtr n_GetLayoutManager(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetLayoutManager());
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00007754 File Offset: 0x00005954
		[Register("getLayoutManager", "()Landroidx/recyclerview/widget/RecyclerView$LayoutManager;", "GetGetLayoutManagerHandler")]
		public virtual RecyclerView.LayoutManager GetLayoutManager()
		{
			return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getLayoutManager.()Landroidx/recyclerview/widget/RecyclerView$LayoutManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00007786 File Offset: 0x00005986
		private static Delegate GetGetOnFlingListenerHandler()
		{
			if (RecyclerView.cb_getOnFlingListener == null)
			{
				RecyclerView.cb_getOnFlingListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetOnFlingListener));
			}
			return RecyclerView.cb_getOnFlingListener;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000077AA File Offset: 0x000059AA
		private static IntPtr n_GetOnFlingListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetOnFlingListener());
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000077C0 File Offset: 0x000059C0
		[Register("getOnFlingListener", "()Landroidx/recyclerview/widget/RecyclerView$OnFlingListener;", "GetGetOnFlingListenerHandler")]
		public virtual RecyclerView.OnFlingListener GetOnFlingListener()
		{
			return Java.Lang.Object.GetObject<RecyclerView.OnFlingListener>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getOnFlingListener.()Landroidx/recyclerview/widget/RecyclerView$OnFlingListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000077F2 File Offset: 0x000059F2
		private static Delegate GetGetRecycledViewPoolHandler()
		{
			if (RecyclerView.cb_getRecycledViewPool == null)
			{
				RecyclerView.cb_getRecycledViewPool = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.n_GetRecycledViewPool));
			}
			return RecyclerView.cb_getRecycledViewPool;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00007816 File Offset: 0x00005A16
		private static IntPtr n_GetRecycledViewPool(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRecycledViewPool());
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000782C File Offset: 0x00005A2C
		[Register("getRecycledViewPool", "()Landroidx/recyclerview/widget/RecyclerView$RecycledViewPool;", "GetGetRecycledViewPoolHandler")]
		public virtual RecyclerView.RecycledViewPool GetRecycledViewPool()
		{
			return Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(RecyclerView._members.InstanceMethods.InvokeVirtualObjectMethod("getRecycledViewPool.()Landroidx/recyclerview/widget/RecyclerView$RecycledViewPool;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000785E File Offset: 0x00005A5E
		private static Delegate GetInvokeHasNestedScrollingParent_IHandler()
		{
			if (RecyclerView.cb_hasNestedScrollingParent_I == null)
			{
				RecyclerView.cb_hasNestedScrollingParent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(RecyclerView.n_InvokeHasNestedScrollingParent_I));
			}
			return RecyclerView.cb_hasNestedScrollingParent_I;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00007882 File Offset: 0x00005A82
		private static bool n_InvokeHasNestedScrollingParent_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvokeHasNestedScrollingParent(type);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00007894 File Offset: 0x00005A94
		[Register("hasNestedScrollingParent", "(I)Z", "GetInvokeHasNestedScrollingParent_IHandler")]
		public unsafe virtual bool InvokeHasNestedScrollingParent(int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(type);
			return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("hasNestedScrollingParent.(I)Z", this, ptr);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000078CF File Offset: 0x00005ACF
		private static Delegate GetInvalidateItemDecorationsHandler()
		{
			if (RecyclerView.cb_invalidateItemDecorations == null)
			{
				RecyclerView.cb_invalidateItemDecorations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.n_InvalidateItemDecorations));
			}
			return RecyclerView.cb_invalidateItemDecorations;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000078F3 File Offset: 0x00005AF3
		private static void n_InvalidateItemDecorations(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateItemDecorations();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00007902 File Offset: 0x00005B02
		[Register("invalidateItemDecorations", "()V", "GetInvalidateItemDecorationsHandler")]
		public virtual void InvalidateItemDecorations()
		{
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateItemDecorations.()V", this, null);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000791B File Offset: 0x00005B1B
		private static Delegate GetNestedScrollBy_IIHandler()
		{
			if (RecyclerView.cb_nestedScrollBy_II == null)
			{
				RecyclerView.cb_nestedScrollBy_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.n_NestedScrollBy_II));
			}
			return RecyclerView.cb_nestedScrollBy_II;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000793F File Offset: 0x00005B3F
		private static void n_NestedScrollBy_II(IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollBy(x, y);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00007950 File Offset: 0x00005B50
		[Register("nestedScrollBy", "(II)V", "GetNestedScrollBy_IIHandler")]
		public unsafe virtual void NestedScrollBy(int x, int y)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(y);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("nestedScrollBy.(II)V", this, ptr);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000799E File Offset: 0x00005B9E
		private static Delegate GetOffsetChildrenHorizontal_IHandler()
		{
			if (RecyclerView.cb_offsetChildrenHorizontal_I == null)
			{
				RecyclerView.cb_offsetChildrenHorizontal_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_OffsetChildrenHorizontal_I));
			}
			return RecyclerView.cb_offsetChildrenHorizontal_I;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000079C2 File Offset: 0x00005BC2
		private static void n_OffsetChildrenHorizontal_I(IntPtr jnienv, IntPtr native__this, int dx)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffsetChildrenHorizontal(dx);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000079D4 File Offset: 0x00005BD4
		[Register("offsetChildrenHorizontal", "(I)V", "GetOffsetChildrenHorizontal_IHandler")]
		public unsafe virtual void OffsetChildrenHorizontal(int dx)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dx);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("offsetChildrenHorizontal.(I)V", this, ptr);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00007A0F File Offset: 0x00005C0F
		private static Delegate GetOffsetChildrenVertical_IHandler()
		{
			if (RecyclerView.cb_offsetChildrenVertical_I == null)
			{
				RecyclerView.cb_offsetChildrenVertical_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_OffsetChildrenVertical_I));
			}
			return RecyclerView.cb_offsetChildrenVertical_I;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00007A33 File Offset: 0x00005C33
		private static void n_OffsetChildrenVertical_I(IntPtr jnienv, IntPtr native__this, int dy)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffsetChildrenVertical(dy);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00007A44 File Offset: 0x00005C44
		[Register("offsetChildrenVertical", "(I)V", "GetOffsetChildrenVertical_IHandler")]
		public unsafe virtual void OffsetChildrenVertical(int dy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dy);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("offsetChildrenVertical.(I)V", this, ptr);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00007A7F File Offset: 0x00005C7F
		private static Delegate GetOnChildAttachedToWindow_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_onChildAttachedToWindow_Landroid_view_View_ == null)
			{
				RecyclerView.cb_onChildAttachedToWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_OnChildAttachedToWindow_Landroid_view_View_));
			}
			return RecyclerView.cb_onChildAttachedToWindow_Landroid_view_View_;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00007AA4 File Offset: 0x00005CA4
		private static void n_OnChildAttachedToWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnChildAttachedToWindow(object2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00007AC8 File Offset: 0x00005CC8
		[Register("onChildAttachedToWindow", "(Landroid/view/View;)V", "GetOnChildAttachedToWindow_Landroid_view_View_Handler")]
		public unsafe virtual void OnChildAttachedToWindow(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onChildAttachedToWindow.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00007B2C File Offset: 0x00005D2C
		private static Delegate GetOnChildDetachedFromWindow_Landroid_view_View_Handler()
		{
			if (RecyclerView.cb_onChildDetachedFromWindow_Landroid_view_View_ == null)
			{
				RecyclerView.cb_onChildDetachedFromWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_OnChildDetachedFromWindow_Landroid_view_View_));
			}
			return RecyclerView.cb_onChildDetachedFromWindow_Landroid_view_View_;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00007B50 File Offset: 0x00005D50
		private static void n_OnChildDetachedFromWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnChildDetachedFromWindow(object2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00007B74 File Offset: 0x00005D74
		[Register("onChildDetachedFromWindow", "(Landroid/view/View;)V", "GetOnChildDetachedFromWindow_Landroid_view_View_Handler")]
		public unsafe virtual void OnChildDetachedFromWindow(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onChildDetachedFromWindow.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00007BD8 File Offset: 0x00005DD8
		private static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler()
		{
			if (RecyclerView.cb_onDraw_Landroid_graphics_Canvas_ == null)
			{
				RecyclerView.cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_OnDraw_Landroid_graphics_Canvas_));
			}
			return RecyclerView.cb_onDraw_Landroid_graphics_Canvas_;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00007BFC File Offset: 0x00005DFC
		private static void n_OnDraw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.OnDraw(object2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00007C20 File Offset: 0x00005E20
		[Register("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public new unsafe virtual void OnDraw(Canvas c)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(c);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00007C84 File Offset: 0x00005E84
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (RecyclerView.cb_onLayout_ZIIII == null)
			{
				RecyclerView.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(RecyclerView.n_OnLayout_ZIIII));
			}
			return RecyclerView.cb_onLayout_ZIIII;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00007CA8 File Offset: 0x00005EA8
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00007CC0 File Offset: 0x00005EC0
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00007D52 File Offset: 0x00005F52
		private static Delegate GetOnScrollStateChanged_IHandler()
		{
			if (RecyclerView.cb_onScrollStateChanged_I == null)
			{
				RecyclerView.cb_onScrollStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_OnScrollStateChanged_I));
			}
			return RecyclerView.cb_onScrollStateChanged_I;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00007D76 File Offset: 0x00005F76
		private static void n_OnScrollStateChanged_I(IntPtr jnienv, IntPtr native__this, int state)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnScrollStateChanged(state);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00007D88 File Offset: 0x00005F88
		[Register("onScrollStateChanged", "(I)V", "GetOnScrollStateChanged_IHandler")]
		public unsafe virtual void OnScrollStateChanged(int state)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(state);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onScrollStateChanged.(I)V", this, ptr);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00007DC3 File Offset: 0x00005FC3
		private static Delegate GetOnScrolled_IIHandler()
		{
			if (RecyclerView.cb_onScrolled_II == null)
			{
				RecyclerView.cb_onScrolled_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.n_OnScrolled_II));
			}
			return RecyclerView.cb_onScrolled_II;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00007DE7 File Offset: 0x00005FE7
		private static void n_OnScrolled_II(IntPtr jnienv, IntPtr native__this, int dx, int dy)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnScrolled(dx, dy);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[Register("onScrolled", "(II)V", "GetOnScrolled_IIHandler")]
		public unsafe virtual void OnScrolled(int dx, int dy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dx);
			ptr[1] = new JniArgumentValue(dy);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("onScrolled.(II)V", this, ptr);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00007E46 File Offset: 0x00006046
		private static Delegate GetRemoveItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_Handler()
		{
			if (RecyclerView.cb_removeItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_ == null)
			{
				RecyclerView.cb_removeItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_RemoveItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_));
			}
			return RecyclerView.cb_removeItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00007E6C File Offset: 0x0000606C
		private static void n_RemoveItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_(IntPtr jnienv, IntPtr native__this, IntPtr native_decor)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ItemDecoration object2 = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(native_decor, JniHandleOwnership.DoNotTransfer);
			@object.RemoveItemDecoration(object2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00007E90 File Offset: 0x00006090
		[Register("removeItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", "GetRemoveItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_Handler")]
		public unsafe virtual void RemoveItemDecoration(RecyclerView.ItemDecoration decor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00007EF4 File Offset: 0x000060F4
		private static Delegate GetRemoveItemDecorationAt_IHandler()
		{
			if (RecyclerView.cb_removeItemDecorationAt_I == null)
			{
				RecyclerView.cb_removeItemDecorationAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_RemoveItemDecorationAt_I));
			}
			return RecyclerView.cb_removeItemDecorationAt_I;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00007F18 File Offset: 0x00006118
		private static void n_RemoveItemDecorationAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItemDecorationAt(index);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00007F28 File Offset: 0x00006128
		[Register("removeItemDecorationAt", "(I)V", "GetRemoveItemDecorationAt_IHandler")]
		public unsafe virtual void RemoveItemDecorationAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeItemDecorationAt.(I)V", this, ptr);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00007F63 File Offset: 0x00006163
		private static Delegate GetRemoveOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_Handler()
		{
			if (RecyclerView.cb_removeOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_ == null)
			{
				RecyclerView.cb_removeOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_RemoveOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_));
			}
			return RecyclerView.cb_removeOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00007F88 File Offset: 0x00006188
		private static void n_RemoveOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IOnChildAttachStateChangeListener object2 = Java.Lang.Object.GetObject<RecyclerView.IOnChildAttachStateChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnChildAttachStateChangeListener(object2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00007FAC File Offset: 0x000061AC
		[Register("removeOnChildAttachStateChangeListener", "(Landroidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener;)V", "GetRemoveOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_Handler")]
		public unsafe virtual void RemoveOnChildAttachStateChangeListener(RecyclerView.IOnChildAttachStateChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnChildAttachStateChangeListener.(Landroidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00008014 File Offset: 0x00006214
		private static Delegate GetRemoveOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_Handler()
		{
			if (RecyclerView.cb_removeOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_ == null)
			{
				RecyclerView.cb_removeOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_RemoveOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_));
			}
			return RecyclerView.cb_removeOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00008038 File Offset: 0x00006238
		private static void n_RemoveOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IOnItemTouchListener object2 = Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnItemTouchListener(object2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000805C File Offset: 0x0000625C
		[Register("removeOnItemTouchListener", "(Landroidx/recyclerview/widget/RecyclerView$OnItemTouchListener;)V", "GetRemoveOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_Handler")]
		public unsafe virtual void RemoveOnItemTouchListener(RecyclerView.IOnItemTouchListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnItemTouchListener.(Landroidx/recyclerview/widget/RecyclerView$OnItemTouchListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000080C4 File Offset: 0x000062C4
		private static Delegate GetRemoveOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler()
		{
			if (RecyclerView.cb_removeOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ == null)
			{
				RecyclerView.cb_removeOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_RemoveOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_));
			}
			return RecyclerView.cb_removeOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000080E8 File Offset: 0x000062E8
		private static void n_RemoveOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.OnScrollListener object2 = Java.Lang.Object.GetObject<RecyclerView.OnScrollListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnScrollListener(object2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000810C File Offset: 0x0000630C
		[Register("removeOnScrollListener", "(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", "GetRemoveOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler")]
		public unsafe virtual void RemoveOnScrollListener(RecyclerView.OnScrollListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnScrollListener.(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00008170 File Offset: 0x00006370
		private static Delegate GetRemoveRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler()
		{
			if (RecyclerView.cb_removeRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ == null)
			{
				RecyclerView.cb_removeRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_RemoveRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_));
			}
			return RecyclerView.cb_removeRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00008194 File Offset: 0x00006394
		private static void n_RemoveRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IRecyclerListener object2 = Java.Lang.Object.GetObject<RecyclerView.IRecyclerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveRecyclerListener(object2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000081B8 File Offset: 0x000063B8
		[Register("removeRecyclerListener", "(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", "GetRemoveRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler")]
		public unsafe virtual void RemoveRecyclerListener(RecyclerView.IRecyclerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeRecyclerListener.(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00008220 File Offset: 0x00006420
		private static Delegate GetScrollToPosition_IHandler()
		{
			if (RecyclerView.cb_scrollToPosition_I == null)
			{
				RecyclerView.cb_scrollToPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_ScrollToPosition_I));
			}
			return RecyclerView.cb_scrollToPosition_I;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00008244 File Offset: 0x00006444
		private static void n_ScrollToPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrollToPosition(position);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00008254 File Offset: 0x00006454
		[Register("scrollToPosition", "(I)V", "GetScrollToPosition_IHandler")]
		public unsafe virtual void ScrollToPosition(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("scrollToPosition.(I)V", this, ptr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000828F File Offset: 0x0000648F
		private static Delegate GetSetAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_Handler()
		{
			if (RecyclerView.cb_setAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_ == null)
			{
				RecyclerView.cb_setAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_));
			}
			return RecyclerView.cb_setAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000082B4 File Offset: 0x000064B4
		private static void n_SetAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_(IntPtr jnienv, IntPtr native__this, IntPtr native_accessibilityDelegate)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerViewAccessibilityDelegate object2 = Java.Lang.Object.GetObject<RecyclerViewAccessibilityDelegate>(native_accessibilityDelegate, JniHandleOwnership.DoNotTransfer);
			@object.SetAccessibilityDelegateCompat(object2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000082D8 File Offset: 0x000064D8
		[Register("setAccessibilityDelegateCompat", "(Landroidx/recyclerview/widget/RecyclerViewAccessibilityDelegate;)V", "GetSetAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_Handler")]
		public unsafe virtual void SetAccessibilityDelegateCompat(RecyclerViewAccessibilityDelegate accessibilityDelegate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((accessibilityDelegate == null) ? IntPtr.Zero : accessibilityDelegate.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setAccessibilityDelegateCompat.(Landroidx/recyclerview/widget/RecyclerViewAccessibilityDelegate;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(accessibilityDelegate);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000833C File Offset: 0x0000653C
		private static Delegate GetSetAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Handler()
		{
			if (RecyclerView.cb_setAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ == null)
			{
				RecyclerView.cb_setAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_));
			}
			return RecyclerView.cb_setAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00008360 File Offset: 0x00006560
		private static void n_SetAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.Adapter object2 = Java.Lang.Object.GetObject<RecyclerView.Adapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.SetAdapter(object2);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00008384 File Offset: 0x00006584
		[Register("setAdapter", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", "GetSetAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Handler")]
		public unsafe virtual void SetAdapter(RecyclerView.Adapter adapter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : adapter.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setAdapter.(Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapter);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000083E8 File Offset: 0x000065E8
		private static Delegate GetSetChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_Handler()
		{
			if (RecyclerView.cb_setChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_ == null)
			{
				RecyclerView.cb_setChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_));
			}
			return RecyclerView.cb_setChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000840C File Offset: 0x0000660C
		private static void n_SetChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_childDrawingOrderCallback)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IChildDrawingOrderCallback object2 = Java.Lang.Object.GetObject<RecyclerView.IChildDrawingOrderCallback>(native_childDrawingOrderCallback, JniHandleOwnership.DoNotTransfer);
			@object.SetChildDrawingOrderCallback(object2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00008430 File Offset: 0x00006630
		[Register("setChildDrawingOrderCallback", "(Landroidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback;)V", "GetSetChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_Handler")]
		public unsafe virtual void SetChildDrawingOrderCallback(RecyclerView.IChildDrawingOrderCallback childDrawingOrderCallback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((childDrawingOrderCallback == null) ? IntPtr.Zero : ((Java.Lang.Object)childDrawingOrderCallback).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setChildDrawingOrderCallback.(Landroidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(childDrawingOrderCallback);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00008498 File Offset: 0x00006698
		[Register("setDebugAssertionsEnabled", "(Z)V", "")]
		public unsafe static void SetDebugAssertionsEnabled(bool debugAssertionsEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(debugAssertionsEnabled);
			RecyclerView._members.StaticMethods.InvokeVoidMethod("setDebugAssertionsEnabled.(Z)V", ptr);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000084D2 File Offset: 0x000066D2
		private static Delegate GetSetEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_Handler()
		{
			if (RecyclerView.cb_setEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_ == null)
			{
				RecyclerView.cb_setEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_));
			}
			return RecyclerView.cb_setEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000084F8 File Offset: 0x000066F8
		private static void n_SetEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_edgeEffectFactory)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.EdgeEffectFactory object2 = Java.Lang.Object.GetObject<RecyclerView.EdgeEffectFactory>(native_edgeEffectFactory, JniHandleOwnership.DoNotTransfer);
			@object.SetEdgeEffectFactory(object2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000851C File Offset: 0x0000671C
		[Register("setEdgeEffectFactory", "(Landroidx/recyclerview/widget/RecyclerView$EdgeEffectFactory;)V", "GetSetEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_Handler")]
		public unsafe virtual void SetEdgeEffectFactory(RecyclerView.EdgeEffectFactory edgeEffectFactory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((edgeEffectFactory == null) ? IntPtr.Zero : edgeEffectFactory.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setEdgeEffectFactory.(Landroidx/recyclerview/widget/RecyclerView$EdgeEffectFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(edgeEffectFactory);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00008580 File Offset: 0x00006780
		private static Delegate GetSetItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_Handler()
		{
			if (RecyclerView.cb_setItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ == null)
			{
				RecyclerView.cb_setItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_));
			}
			return RecyclerView.cb_setItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000085A4 File Offset: 0x000067A4
		private static void n_SetItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animator)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ItemAnimator object2 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(native_animator, JniHandleOwnership.DoNotTransfer);
			@object.SetItemAnimator(object2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000085C8 File Offset: 0x000067C8
		[Register("setItemAnimator", "(Landroidx/recyclerview/widget/RecyclerView$ItemAnimator;)V", "GetSetItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_Handler")]
		public unsafe virtual void SetItemAnimator(RecyclerView.ItemAnimator animator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : animator.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemAnimator.(Landroidx/recyclerview/widget/RecyclerView$ItemAnimator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000862C File Offset: 0x0000682C
		private static Delegate GetSetItemViewCacheSize_IHandler()
		{
			if (RecyclerView.cb_setItemViewCacheSize_I == null)
			{
				RecyclerView.cb_setItemViewCacheSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_SetItemViewCacheSize_I));
			}
			return RecyclerView.cb_setItemViewCacheSize_I;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00008650 File Offset: 0x00006850
		private static void n_SetItemViewCacheSize_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetItemViewCacheSize(size);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00008660 File Offset: 0x00006860
		[Register("setItemViewCacheSize", "(I)V", "GetSetItemViewCacheSize_IHandler")]
		public unsafe virtual void SetItemViewCacheSize(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setItemViewCacheSize.(I)V", this, ptr);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000869B File Offset: 0x0000689B
		private static Delegate GetSetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_Handler()
		{
			if (RecyclerView.cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_ == null)
			{
				RecyclerView.cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_));
			}
			return RecyclerView.cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000086C0 File Offset: 0x000068C0
		private static void n_SetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_(IntPtr jnienv, IntPtr native__this, IntPtr native_layout)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.LayoutManager object2 = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(native_layout, JniHandleOwnership.DoNotTransfer);
			@object.SetLayoutManager(object2);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000086E4 File Offset: 0x000068E4
		[Register("setLayoutManager", "(Landroidx/recyclerview/widget/RecyclerView$LayoutManager;)V", "GetSetLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_Handler")]
		public unsafe virtual void SetLayoutManager(RecyclerView.LayoutManager layout)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((layout == null) ? IntPtr.Zero : layout.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setLayoutManager.(Landroidx/recyclerview/widget/RecyclerView$LayoutManager;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(layout);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00008748 File Offset: 0x00006948
		private static Delegate GetSetOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_Handler()
		{
			if (RecyclerView.cb_setOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_ == null)
			{
				RecyclerView.cb_setOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_));
			}
			return RecyclerView.cb_setOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000876C File Offset: 0x0000696C
		private static void n_SetOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onFlingListener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.OnFlingListener object2 = Java.Lang.Object.GetObject<RecyclerView.OnFlingListener>(native_onFlingListener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnFlingListener(object2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00008790 File Offset: 0x00006990
		[Register("setOnFlingListener", "(Landroidx/recyclerview/widget/RecyclerView$OnFlingListener;)V", "GetSetOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_Handler")]
		public unsafe virtual void SetOnFlingListener(RecyclerView.OnFlingListener onFlingListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((onFlingListener == null) ? IntPtr.Zero : onFlingListener.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnFlingListener.(Landroidx/recyclerview/widget/RecyclerView$OnFlingListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(onFlingListener);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000087F4 File Offset: 0x000069F4
		private static Delegate GetSetOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler()
		{
			if (RecyclerView.cb_setOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ == null)
			{
				RecyclerView.cb_setOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_));
			}
			return RecyclerView.cb_setOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00008818 File Offset: 0x00006A18
		private static void n_SetOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.OnScrollListener object2 = Java.Lang.Object.GetObject<RecyclerView.OnScrollListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnScrollListener(object2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000883C File Offset: 0x00006A3C
		[Register("setOnScrollListener", "(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", "GetSetOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_Handler")]
		public unsafe virtual void SetOnScrollListener(RecyclerView.OnScrollListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnScrollListener.(Landroidx/recyclerview/widget/RecyclerView$OnScrollListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000088A0 File Offset: 0x00006AA0
		private static Delegate GetSetRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_Handler()
		{
			if (RecyclerView.cb_setRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_ == null)
			{
				RecyclerView.cb_setRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_));
			}
			return RecyclerView.cb_setRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000088C4 File Offset: 0x00006AC4
		private static void n_SetRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_(IntPtr jnienv, IntPtr native__this, IntPtr native_pool)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.RecycledViewPool object2 = Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(native_pool, JniHandleOwnership.DoNotTransfer);
			@object.SetRecycledViewPool(object2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000088E8 File Offset: 0x00006AE8
		[Register("setRecycledViewPool", "(Landroidx/recyclerview/widget/RecyclerView$RecycledViewPool;)V", "GetSetRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_Handler")]
		public unsafe virtual void SetRecycledViewPool(RecyclerView.RecycledViewPool pool)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : pool.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setRecycledViewPool.(Landroidx/recyclerview/widget/RecyclerView$RecycledViewPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(pool);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000894C File Offset: 0x00006B4C
		private static Delegate GetSetRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler()
		{
			if (RecyclerView.cb_setRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ == null)
			{
				RecyclerView.cb_setRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_));
			}
			return RecyclerView.cb_setRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00008970 File Offset: 0x00006B70
		private static void n_SetRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.IRecyclerListener object2 = Java.Lang.Object.GetObject<RecyclerView.IRecyclerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetRecyclerListener(object2);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00008994 File Offset: 0x00006B94
		[Register("setRecyclerListener", "(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", "GetSetRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_Handler")]
		public unsafe virtual void SetRecyclerListener(RecyclerView.IRecyclerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setRecyclerListener.(Landroidx/recyclerview/widget/RecyclerView$RecyclerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000089FC File Offset: 0x00006BFC
		private static Delegate GetSetScrollingTouchSlop_IHandler()
		{
			if (RecyclerView.cb_setScrollingTouchSlop_I == null)
			{
				RecyclerView.cb_setScrollingTouchSlop_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_SetScrollingTouchSlop_I));
			}
			return RecyclerView.cb_setScrollingTouchSlop_I;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00008A20 File Offset: 0x00006C20
		private static void n_SetScrollingTouchSlop_I(IntPtr jnienv, IntPtr native__this, int slopConstant)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrollingTouchSlop(slopConstant);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00008A30 File Offset: 0x00006C30
		[Register("setScrollingTouchSlop", "(I)V", "GetSetScrollingTouchSlop_IHandler")]
		public unsafe virtual void SetScrollingTouchSlop(int slopConstant)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(slopConstant);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setScrollingTouchSlop.(I)V", this, ptr);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00008A6C File Offset: 0x00006C6C
		[Register("setVerboseLoggingEnabled", "(Z)V", "")]
		public unsafe static void SetVerboseLoggingEnabled(bool verboseLoggingEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(verboseLoggingEnabled);
			RecyclerView._members.StaticMethods.InvokeVoidMethod("setVerboseLoggingEnabled.(Z)V", ptr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00008AA6 File Offset: 0x00006CA6
		private static Delegate GetSetViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_Handler()
		{
			if (RecyclerView.cb_setViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_ == null)
			{
				RecyclerView.cb_setViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.n_SetViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_));
			}
			return RecyclerView.cb_setViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00008ACC File Offset: 0x00006CCC
		private static void n_SetViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_(IntPtr jnienv, IntPtr native__this, IntPtr native_extension)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ViewCacheExtension object2 = Java.Lang.Object.GetObject<RecyclerView.ViewCacheExtension>(native_extension, JniHandleOwnership.DoNotTransfer);
			@object.SetViewCacheExtension(object2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Register("setViewCacheExtension", "(Landroidx/recyclerview/widget/RecyclerView$ViewCacheExtension;)V", "GetSetViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_Handler")]
		public unsafe virtual void SetViewCacheExtension(RecyclerView.ViewCacheExtension extension)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((extension == null) ? IntPtr.Zero : extension.Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("setViewCacheExtension.(Landroidx/recyclerview/widget/RecyclerView$ViewCacheExtension;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(extension);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00008B54 File Offset: 0x00006D54
		private static Delegate GetSmoothScrollBy_IIHandler()
		{
			if (RecyclerView.cb_smoothScrollBy_II == null)
			{
				RecyclerView.cb_smoothScrollBy_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.n_SmoothScrollBy_II));
			}
			return RecyclerView.cb_smoothScrollBy_II;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00008B78 File Offset: 0x00006D78
		private static void n_SmoothScrollBy_II(IntPtr jnienv, IntPtr native__this, int dx, int dy)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SmoothScrollBy(dx, dy);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00008B8C File Offset: 0x00006D8C
		[Register("smoothScrollBy", "(II)V", "GetSmoothScrollBy_IIHandler")]
		public unsafe virtual void SmoothScrollBy(int dx, int dy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(dx);
			ptr[1] = new JniArgumentValue(dy);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("smoothScrollBy.(II)V", this, ptr);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00008BDA File Offset: 0x00006DDA
		private static Delegate GetSmoothScrollBy_IILandroid_view_animation_Interpolator_Handler()
		{
			if (RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_ == null)
			{
				RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_V(RecyclerView.n_SmoothScrollBy_IILandroid_view_animation_Interpolator_));
			}
			return RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00008C00 File Offset: 0x00006E00
		private static void n_SmoothScrollBy_IILandroid_view_animation_Interpolator_(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_interpolator)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInterpolator object2 = Java.Lang.Object.GetObject<IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
			@object.SmoothScrollBy(dx, dy, object2);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00008C28 File Offset: 0x00006E28
		[Register("smoothScrollBy", "(IILandroid/view/animation/Interpolator;)V", "GetSmoothScrollBy_IILandroid_view_animation_Interpolator_Handler")]
		public unsafe virtual void SmoothScrollBy(int dx, int dy, IInterpolator interpolator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dx);
				ptr[1] = new JniArgumentValue(dy);
				ptr[2] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((Java.Lang.Object)interpolator).Handle);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("smoothScrollBy.(IILandroid/view/animation/Interpolator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(interpolator);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00008CBC File Offset: 0x00006EBC
		private static Delegate GetSmoothScrollBy_IILandroid_view_animation_Interpolator_IHandler()
		{
			if (RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_I == null)
			{
				RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILI_V(RecyclerView.n_SmoothScrollBy_IILandroid_view_animation_Interpolator_I));
			}
			return RecyclerView.cb_smoothScrollBy_IILandroid_view_animation_Interpolator_I;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00008CE0 File Offset: 0x00006EE0
		private static void n_SmoothScrollBy_IILandroid_view_animation_Interpolator_I(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_interpolator, int duration)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInterpolator object2 = Java.Lang.Object.GetObject<IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
			@object.SmoothScrollBy(dx, dy, object2, duration);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00008D08 File Offset: 0x00006F08
		[Register("smoothScrollBy", "(IILandroid/view/animation/Interpolator;I)V", "GetSmoothScrollBy_IILandroid_view_animation_Interpolator_IHandler")]
		public unsafe virtual void SmoothScrollBy(int dx, int dy, IInterpolator interpolator, int duration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dx);
				ptr[1] = new JniArgumentValue(dy);
				ptr[2] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((Java.Lang.Object)interpolator).Handle);
				ptr[3] = new JniArgumentValue(duration);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("smoothScrollBy.(IILandroid/view/animation/Interpolator;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(interpolator);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00008DB0 File Offset: 0x00006FB0
		private static Delegate GetSmoothScrollToPosition_IHandler()
		{
			if (RecyclerView.cb_smoothScrollToPosition_I == null)
			{
				RecyclerView.cb_smoothScrollToPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_SmoothScrollToPosition_I));
			}
			return RecyclerView.cb_smoothScrollToPosition_I;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00008DD4 File Offset: 0x00006FD4
		private static void n_SmoothScrollToPosition_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SmoothScrollToPosition(position);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00008DE4 File Offset: 0x00006FE4
		[Register("smoothScrollToPosition", "(I)V", "GetSmoothScrollToPosition_IHandler")]
		public unsafe virtual void SmoothScrollToPosition(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("smoothScrollToPosition.(I)V", this, ptr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00008E1F File Offset: 0x0000701F
		private static Delegate GetStartNestedScroll_IIHandler()
		{
			if (RecyclerView.cb_startNestedScroll_II == null)
			{
				RecyclerView.cb_startNestedScroll_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(RecyclerView.n_StartNestedScroll_II));
			}
			return RecyclerView.cb_startNestedScroll_II;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00008E44 File Offset: 0x00007044
		private static bool n_StartNestedScroll_II(IntPtr jnienv, IntPtr native__this, int native_axes, int type)
		{
			return Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes, type);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00008E64 File Offset: 0x00007064
		[Register("startNestedScroll", "(II)Z", "GetStartNestedScroll_IIHandler")]
		public unsafe virtual bool StartNestedScroll([GeneratedEnum] ScrollAxis axes, int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)axes);
			ptr[1] = new JniArgumentValue(type);
			return RecyclerView._members.InstanceMethods.InvokeVirtualBooleanMethod("startNestedScroll.(II)Z", this, ptr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00008EB2 File Offset: 0x000070B2
		private static Delegate GetStopNestedScroll_IHandler()
		{
			if (RecyclerView.cb_stopNestedScroll_I == null)
			{
				RecyclerView.cb_stopNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.n_StopNestedScroll_I));
			}
			return RecyclerView.cb_stopNestedScroll_I;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00008ED6 File Offset: 0x000070D6
		private static void n_StopNestedScroll_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll(type);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00008EE8 File Offset: 0x000070E8
		[Register("stopNestedScroll", "(I)V", "GetStopNestedScroll_IHandler")]
		public unsafe virtual void StopNestedScroll(int type)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(type);
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("stopNestedScroll.(I)V", this, ptr);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00008F23 File Offset: 0x00007123
		private static Delegate GetStopScrollHandler()
		{
			if (RecyclerView.cb_stopScroll == null)
			{
				RecyclerView.cb_stopScroll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.n_StopScroll));
			}
			return RecyclerView.cb_stopScroll;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00008F47 File Offset: 0x00007147
		private static void n_StopScroll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopScroll();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00008F56 File Offset: 0x00007156
		[Register("stopScroll", "()V", "GetStopScrollHandler")]
		public virtual void StopScroll()
		{
			RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("stopScroll.()V", this, null);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00008F70 File Offset: 0x00007170
		[Register("suppressLayout", "(Z)V", "")]
		public unsafe sealed override void SuppressLayout(bool suppress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(suppress);
			RecyclerView._members.InstanceMethods.InvokeNonvirtualVoidMethod("suppressLayout.(Z)V", this, ptr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00008FAB File Offset: 0x000071AB
		private static Delegate GetSwapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ZHandler()
		{
			if (RecyclerView.cb_swapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z == null)
			{
				RecyclerView.cb_swapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(RecyclerView.n_SwapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z));
			}
			return RecyclerView.cb_swapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00008FD0 File Offset: 0x000071D0
		private static void n_SwapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, bool removeAndRecycleExistingViews)
		{
			RecyclerView @object = Java.Lang.Object.GetObject<RecyclerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.Adapter object2 = Java.Lang.Object.GetObject<RecyclerView.Adapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.SwapAdapter(object2, removeAndRecycleExistingViews);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00008FF4 File Offset: 0x000071F4
		[Register("swapAdapter", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;Z)V", "GetSwapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ZHandler")]
		public unsafe virtual void SwapAdapter(RecyclerView.Adapter adapter, bool removeAndRecycleExistingViews)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : adapter.Handle);
				ptr[1] = new JniArgumentValue(removeAndRecycleExistingViews);
				RecyclerView._members.InstanceMethods.InvokeVirtualVoidMethod("swapAdapter.(Landroidx/recyclerview/widget/RecyclerView$Adapter;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapter);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000359 RID: 857 RVA: 0x0000906C File Offset: 0x0000726C
		// (remove) Token: 0x0600035A RID: 858 RVA: 0x000090B8 File Offset: 0x000072B8
		public event EventHandler<RecyclerView.ChildViewAttachedToWindowEventArgs> ChildViewAttachedToWindow
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IOnChildAttachStateChangeListener, RecyclerView.IOnChildAttachStateChangeListenerImplementor>(ref this.weak_implementor_AddOnChildAttachStateChangeListener, new Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor>(this.__CreateIOnChildAttachStateChangeListenerImplementor), new Action<RecyclerView.IOnChildAttachStateChangeListener>(this.AddOnChildAttachStateChangeListener), delegate(RecyclerView.IOnChildAttachStateChangeListenerImplementor __h)
				{
					__h.OnChildViewAttachedToWindowHandler = (EventHandler<RecyclerView.ChildViewAttachedToWindowEventArgs>)Delegate.Combine(__h.OnChildViewAttachedToWindowHandler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<0>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<0>____IsEmpty = new Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor, bool>(RecyclerView.IOnChildAttachStateChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IOnChildAttachStateChangeListener, RecyclerView.IOnChildAttachStateChangeListenerImplementor>(ref this.weak_implementor_AddOnChildAttachStateChangeListener, empty, delegate(RecyclerView.IOnChildAttachStateChangeListener __v)
				{
					this.RemoveOnChildAttachStateChangeListener(__v);
				}, delegate(RecyclerView.IOnChildAttachStateChangeListenerImplementor __h)
				{
					__h.OnChildViewAttachedToWindowHandler = (EventHandler<RecyclerView.ChildViewAttachedToWindowEventArgs>)Delegate.Remove(__h.OnChildViewAttachedToWindowHandler, value);
				});
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600035B RID: 859 RVA: 0x00009118 File Offset: 0x00007318
		// (remove) Token: 0x0600035C RID: 860 RVA: 0x00009164 File Offset: 0x00007364
		public event EventHandler<RecyclerView.ChildViewDetachedFromWindowEventArgs> ChildViewDetachedFromWindow
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IOnChildAttachStateChangeListener, RecyclerView.IOnChildAttachStateChangeListenerImplementor>(ref this.weak_implementor_AddOnChildAttachStateChangeListener, new Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor>(this.__CreateIOnChildAttachStateChangeListenerImplementor), new Action<RecyclerView.IOnChildAttachStateChangeListener>(this.AddOnChildAttachStateChangeListener), delegate(RecyclerView.IOnChildAttachStateChangeListenerImplementor __h)
				{
					__h.OnChildViewDetachedFromWindowHandler = (EventHandler<RecyclerView.ChildViewDetachedFromWindowEventArgs>)Delegate.Combine(__h.OnChildViewDetachedFromWindowHandler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<0>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<0>____IsEmpty = new Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor, bool>(RecyclerView.IOnChildAttachStateChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IOnChildAttachStateChangeListener, RecyclerView.IOnChildAttachStateChangeListenerImplementor>(ref this.weak_implementor_AddOnChildAttachStateChangeListener, empty, delegate(RecyclerView.IOnChildAttachStateChangeListener __v)
				{
					this.RemoveOnChildAttachStateChangeListener(__v);
				}, delegate(RecyclerView.IOnChildAttachStateChangeListenerImplementor __h)
				{
					__h.OnChildViewDetachedFromWindowHandler = (EventHandler<RecyclerView.ChildViewDetachedFromWindowEventArgs>)Delegate.Remove(__h.OnChildViewDetachedFromWindowHandler, value);
				});
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000091C3 File Offset: 0x000073C3
		private RecyclerView.IOnChildAttachStateChangeListenerImplementor __CreateIOnChildAttachStateChangeListenerImplementor()
		{
			return new RecyclerView.IOnChildAttachStateChangeListenerImplementor(this);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600035E RID: 862 RVA: 0x000091CC File Offset: 0x000073CC
		// (remove) Token: 0x0600035F RID: 863 RVA: 0x00009218 File Offset: 0x00007418
		public event EventHandler<RecyclerView.InterceptTouchEventEventArgs> InterceptTouchEvent
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, new Func<RecyclerView.IOnItemTouchListenerImplementor>(this.__CreateIOnItemTouchListenerImplementor), new Action<RecyclerView.IOnItemTouchListener>(this.AddOnItemTouchListener), delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnInterceptTouchEventHandler = (EventHandler<RecyclerView.InterceptTouchEventEventArgs>)Delegate.Combine(__h.OnInterceptTouchEventHandler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IOnItemTouchListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<1>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<1>____IsEmpty = new Func<RecyclerView.IOnItemTouchListenerImplementor, bool>(RecyclerView.IOnItemTouchListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, empty, delegate(RecyclerView.IOnItemTouchListener __v)
				{
					this.RemoveOnItemTouchListener(__v);
				}, delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnInterceptTouchEventHandler = (EventHandler<RecyclerView.InterceptTouchEventEventArgs>)Delegate.Remove(__h.OnInterceptTouchEventHandler, value);
				});
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000360 RID: 864 RVA: 0x00009278 File Offset: 0x00007478
		// (remove) Token: 0x06000361 RID: 865 RVA: 0x000092C4 File Offset: 0x000074C4
		public new event EventHandler<RecyclerView.RequestDisallowInterceptTouchEventEventArgs> RequestDisallowInterceptTouchEvent
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, new Func<RecyclerView.IOnItemTouchListenerImplementor>(this.__CreateIOnItemTouchListenerImplementor), new Action<RecyclerView.IOnItemTouchListener>(this.AddOnItemTouchListener), delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnRequestDisallowInterceptTouchEventHandler = (EventHandler<RecyclerView.RequestDisallowInterceptTouchEventEventArgs>)Delegate.Combine(__h.OnRequestDisallowInterceptTouchEventHandler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IOnItemTouchListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<1>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<1>____IsEmpty = new Func<RecyclerView.IOnItemTouchListenerImplementor, bool>(RecyclerView.IOnItemTouchListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, empty, delegate(RecyclerView.IOnItemTouchListener __v)
				{
					this.RemoveOnItemTouchListener(__v);
				}, delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnRequestDisallowInterceptTouchEventHandler = (EventHandler<RecyclerView.RequestDisallowInterceptTouchEventEventArgs>)Delegate.Remove(__h.OnRequestDisallowInterceptTouchEventHandler, value);
				});
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000362 RID: 866 RVA: 0x00009324 File Offset: 0x00007524
		// (remove) Token: 0x06000363 RID: 867 RVA: 0x00009370 File Offset: 0x00007570
		public event EventHandler<RecyclerView.TouchEventEventArgs> TouchEvent
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, new Func<RecyclerView.IOnItemTouchListenerImplementor>(this.__CreateIOnItemTouchListenerImplementor), new Action<RecyclerView.IOnItemTouchListener>(this.AddOnItemTouchListener), delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnTouchEventHandler = (EventHandler<RecyclerView.TouchEventEventArgs>)Delegate.Combine(__h.OnTouchEventHandler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IOnItemTouchListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<1>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<1>____IsEmpty = new Func<RecyclerView.IOnItemTouchListenerImplementor, bool>(RecyclerView.IOnItemTouchListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IOnItemTouchListener, RecyclerView.IOnItemTouchListenerImplementor>(ref this.weak_implementor_AddOnItemTouchListener, empty, delegate(RecyclerView.IOnItemTouchListener __v)
				{
					this.RemoveOnItemTouchListener(__v);
				}, delegate(RecyclerView.IOnItemTouchListenerImplementor __h)
				{
					__h.OnTouchEventHandler = (EventHandler<RecyclerView.TouchEventEventArgs>)Delegate.Remove(__h.OnTouchEventHandler, value);
				});
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000093CF File Offset: 0x000075CF
		private RecyclerView.IOnItemTouchListenerImplementor __CreateIOnItemTouchListenerImplementor()
		{
			return new RecyclerView.IOnItemTouchListenerImplementor(this);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000365 RID: 869 RVA: 0x000093D8 File Offset: 0x000075D8
		// (remove) Token: 0x06000366 RID: 870 RVA: 0x00009424 File Offset: 0x00007624
		public event EventHandler<RecyclerView.RecyclerEventArgs> RecyclerEvent
		{
			add
			{
				EventHelper.AddEventHandler<RecyclerView.IRecyclerListener, RecyclerView.IRecyclerListenerImplementor>(ref this.weak_implementor_SetRecyclerListener, new Func<RecyclerView.IRecyclerListenerImplementor>(this.__CreateIRecyclerListenerImplementor), new Action<RecyclerView.IRecyclerListener>(this.SetRecyclerListener), delegate(RecyclerView.IRecyclerListenerImplementor __h)
				{
					__h.Handler = (EventHandler<RecyclerView.RecyclerEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<RecyclerView.IRecyclerListenerImplementor, bool> empty;
				if ((empty = RecyclerView.<>O.<2>____IsEmpty) == null)
				{
					empty = (RecyclerView.<>O.<2>____IsEmpty = new Func<RecyclerView.IRecyclerListenerImplementor, bool>(RecyclerView.IRecyclerListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<RecyclerView.IRecyclerListener, RecyclerView.IRecyclerListenerImplementor>(ref this.weak_implementor_SetRecyclerListener, empty, delegate(RecyclerView.IRecyclerListener __v)
				{
					this.SetRecyclerListener(null);
				}, delegate(RecyclerView.IRecyclerListenerImplementor __h)
				{
					__h.Handler = (EventHandler<RecyclerView.RecyclerEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00009483 File Offset: 0x00007683
		private RecyclerView.IRecyclerListenerImplementor __CreateIRecyclerListenerImplementor()
		{
			return new RecyclerView.IRecyclerListenerImplementor(this);
		}

		// Token: 0x04000057 RID: 87
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView", typeof(RecyclerView));

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getCompatAccessibilityDelegate;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_hasFixedSize;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_setHasFixedSize_Z;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_hasPendingAdapterUpdates;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_isAnimating;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_isComputingLayout;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_getItemDecorationCount;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_isLayoutFrozen;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_setLayoutFrozen_Z;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_getMaxFlingVelocity;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_getMinFlingVelocity;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_getPreserveFocusAfterLayout;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_setPreserveFocusAfterLayout_Z;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_getScrollState;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_addFocusables_Ljava_util_ArrayList_II;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_addItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_I;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_addOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_addOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_addOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_addRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_clearOnChildAttachStateChangeListeners;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_clearOnScrollListeners;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_computeHorizontalScrollExtent;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_computeHorizontalScrollOffset;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_computeHorizontalScrollRange;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_computeVerticalScrollExtent;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_computeVerticalScrollOffset;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_computeVerticalScrollRange;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_dispatchSaveInstanceState_Landroid_util_SparseArray_;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_findChildViewUnder_FF;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_findContainingItemView_Landroid_view_View_;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_findContainingViewHolder_Landroid_view_View_;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_findViewHolderForAdapterPosition_I;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_findViewHolderForItemId_J;

		// Token: 0x0400007F RID: 127
		private static Delegate cb_findViewHolderForLayoutPosition_I;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_findViewHolderForPosition_I;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_fling_II;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_getAdapter;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_getChildAdapterPosition_Landroid_view_View_;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_getChildItemId_Landroid_view_View_;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_getChildLayoutPosition_Landroid_view_View_;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_getChildPosition_Landroid_view_View_;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_getChildViewHolder_Landroid_view_View_;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_getEdgeEffectFactory;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_getItemAnimator;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_getItemDecorationAt_I;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_getLayoutManager;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_getOnFlingListener;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_getRecycledViewPool;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_hasNestedScrollingParent_I;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_invalidateItemDecorations;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_nestedScrollBy_II;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_offsetChildrenHorizontal_I;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_offsetChildrenVertical_I;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_onChildAttachedToWindow_Landroid_view_View_;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_onChildDetachedFromWindow_Landroid_view_View_;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_onDraw_Landroid_graphics_Canvas_;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_onScrollStateChanged_I;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_onScrolled_II;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_removeItemDecoration_Landroidx_recyclerview_widget_RecyclerView_ItemDecoration_;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_removeItemDecorationAt_I;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_removeOnChildAttachStateChangeListener_Landroidx_recyclerview_widget_RecyclerView_OnChildAttachStateChangeListener_;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_removeOnItemTouchListener_Landroidx_recyclerview_widget_RecyclerView_OnItemTouchListener_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_removeOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_removeRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_scrollToPosition_I;

		// Token: 0x040000A1 RID: 161
		private static Delegate cb_setAccessibilityDelegateCompat_Landroidx_recyclerview_widget_RecyclerViewAccessibilityDelegate_;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_setAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_;

		// Token: 0x040000A3 RID: 163
		private static Delegate cb_setChildDrawingOrderCallback_Landroidx_recyclerview_widget_RecyclerView_ChildDrawingOrderCallback_;

		// Token: 0x040000A4 RID: 164
		private static Delegate cb_setEdgeEffectFactory_Landroidx_recyclerview_widget_RecyclerView_EdgeEffectFactory_;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_setItemAnimator_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_;

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_setItemViewCacheSize_I;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_setLayoutManager_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_setOnFlingListener_Landroidx_recyclerview_widget_RecyclerView_OnFlingListener_;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_setOnScrollListener_Landroidx_recyclerview_widget_RecyclerView_OnScrollListener_;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_setRecycledViewPool_Landroidx_recyclerview_widget_RecyclerView_RecycledViewPool_;

		// Token: 0x040000AB RID: 171
		private static Delegate cb_setRecyclerListener_Landroidx_recyclerview_widget_RecyclerView_RecyclerListener_;

		// Token: 0x040000AC RID: 172
		private static Delegate cb_setScrollingTouchSlop_I;

		// Token: 0x040000AD RID: 173
		private static Delegate cb_setViewCacheExtension_Landroidx_recyclerview_widget_RecyclerView_ViewCacheExtension_;

		// Token: 0x040000AE RID: 174
		private static Delegate cb_smoothScrollBy_II;

		// Token: 0x040000AF RID: 175
		private static Delegate cb_smoothScrollBy_IILandroid_view_animation_Interpolator_;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_smoothScrollBy_IILandroid_view_animation_Interpolator_I;

		// Token: 0x040000B1 RID: 177
		private static Delegate cb_smoothScrollToPosition_I;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_startNestedScroll_II;

		// Token: 0x040000B3 RID: 179
		private static Delegate cb_stopNestedScroll_I;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_stopScroll;

		// Token: 0x040000B5 RID: 181
		private static Delegate cb_swapAdapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Z;

		// Token: 0x040000B6 RID: 182
		private WeakReference weak_implementor_AddOnChildAttachStateChangeListener;

		// Token: 0x040000B7 RID: 183
		private WeakReference weak_implementor_AddOnItemTouchListener;

		// Token: 0x040000B8 RID: 184
		private WeakReference weak_implementor_SetRecyclerListener;

		// Token: 0x02000056 RID: 86
		[Register("androidx/recyclerview/widget/RecyclerView$Adapter", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"VH extends androidx.recyclerview.widget.RecyclerView.ViewHolder"
		})]
		public abstract class Adapter : Java.Lang.Object
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000369 RID: 873 RVA: 0x000094A8 File Offset: 0x000076A8
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.Adapter._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600036A RID: 874 RVA: 0x000094CC File Offset: 0x000076CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.Adapter._members;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600036B RID: 875 RVA: 0x000094D4 File Offset: 0x000076D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.Adapter._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600036C RID: 876 RVA: 0x000094F8 File Offset: 0x000076F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.Adapter._members.ManagedPeerType;
				}
			}

			// Token: 0x0600036D RID: 877 RVA: 0x000026A8 File Offset: 0x000008A8
			protected Adapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00009504 File Offset: 0x00007704
			[Register(".ctor", "()V", "")]
			public Adapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.Adapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.Adapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00009572 File Offset: 0x00007772
			public bool HasObservers
			{
				[Register("hasObservers", "()Z", "")]
				get
				{
					return RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualBooleanMethod("hasObservers.()Z", this, null);
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000370 RID: 880 RVA: 0x0000958B File Offset: 0x0000778B
			// (set) Token: 0x06000371 RID: 881 RVA: 0x000095A4 File Offset: 0x000077A4
			public unsafe bool HasStableIds
			{
				[Register("hasStableIds", "()Z", "")]
				get
				{
					return RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualBooleanMethod("hasStableIds.()Z", this, null);
				}
				[Register("setHasStableIds", "(Z)V", "GetSetHasStableIds_ZHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("setHasStableIds.(Z)V", this, ptr);
				}
			}

			// Token: 0x06000372 RID: 882 RVA: 0x000095DF File Offset: 0x000077DF
			private static Delegate GetGetItemCountHandler()
			{
				if (RecyclerView.Adapter.cb_getItemCount == null)
				{
					RecyclerView.Adapter.cb_getItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.Adapter.n_GetItemCount));
				}
				return RecyclerView.Adapter.cb_getItemCount;
			}

			// Token: 0x06000373 RID: 883 RVA: 0x00009603 File Offset: 0x00007803
			private static int n_GetItemCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemCount;
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000374 RID: 884
			public abstract int ItemCount { [Register("getItemCount", "()I", "GetGetItemCountHandler")] get; }

			// Token: 0x06000375 RID: 885 RVA: 0x00009614 File Offset: 0x00007814
			[Register("bindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "")]
			public unsafe void BindViewHolder(RecyclerView.ViewHolder holder, int position)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
					ptr[1] = new JniArgumentValue(position);
					RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("bindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(holder);
				}
			}

			// Token: 0x06000376 RID: 886 RVA: 0x0000968C File Offset: 0x0000788C
			[Register("createViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "")]
			public unsafe Java.Lang.Object CreateViewHolder(ViewGroup parent, int viewType)
			{
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(viewType);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualObjectMethod("createViewHolder.(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(parent);
				}
				return @object;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00009714 File Offset: 0x00007914
			private static Delegate GetFindRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler()
			{
				if (RecyclerView.Adapter.cb_findRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
				{
					RecyclerView.Adapter.cb_findRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_I(RecyclerView.Adapter.n_FindRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I));
				}
				return RecyclerView.Adapter.cb_findRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			// Token: 0x06000378 RID: 888 RVA: 0x00009738 File Offset: 0x00007938
			private static int n_FindRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, IntPtr native_viewHolder, int localPosition)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Adapter object2 = Java.Lang.Object.GetObject<RecyclerView.Adapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				return @object.FindRelativeAdapterPositionIn(object2, object3, localPosition);
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00009768 File Offset: 0x00007968
			[Register("findRelativeAdapterPositionIn", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)I", "GetFindRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public unsafe virtual int FindRelativeAdapterPositionIn(RecyclerView.Adapter adapter, RecyclerView.ViewHolder viewHolder, int localPosition)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : adapter.Handle);
					ptr[1] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[2] = new JniArgumentValue(localPosition);
					result = RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualInt32Method("findRelativeAdapterPositionIn.(Landroidx/recyclerview/widget/RecyclerView$Adapter;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(adapter);
					GC.KeepAlive(viewHolder);
				}
				return result;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000980C File Offset: 0x00007A0C
			private static Delegate GetGetItemId_IHandler()
			{
				if (RecyclerView.Adapter.cb_getItemId_I == null)
				{
					RecyclerView.Adapter.cb_getItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(RecyclerView.Adapter.n_GetItemId_I));
				}
				return RecyclerView.Adapter.cb_getItemId_I;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00009830 File Offset: 0x00007A30
			private static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemId(position);
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00009840 File Offset: 0x00007A40
			[Register("getItemId", "(I)J", "GetGetItemId_IHandler")]
			public unsafe virtual long GetItemId(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualInt64Method("getItemId.(I)J", this, ptr);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x0000987B File Offset: 0x00007A7B
			private static Delegate GetGetItemViewType_IHandler()
			{
				if (RecyclerView.Adapter.cb_getItemViewType_I == null)
				{
					RecyclerView.Adapter.cb_getItemViewType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(RecyclerView.Adapter.n_GetItemViewType_I));
				}
				return RecyclerView.Adapter.cb_getItemViewType_I;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x0000989F File Offset: 0x00007A9F
			private static int n_GetItemViewType_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemViewType(position);
			}

			// Token: 0x0600037F RID: 895 RVA: 0x000098B0 File Offset: 0x00007AB0
			[Register("getItemViewType", "(I)I", "GetGetItemViewType_IHandler")]
			public unsafe virtual int GetItemViewType(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualInt32Method("getItemViewType.(I)I", this, ptr);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x000098EC File Offset: 0x00007AEC
			[Register("getStateRestorationPolicy", "()Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", "")]
			public RecyclerView.Adapter.StateRestorationPolicy GetStateRestorationPolicy()
			{
				return Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualObjectMethod("getStateRestorationPolicy.()Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x0000991E File Offset: 0x00007B1E
			[Register("notifyDataSetChanged", "()V", "")]
			public void NotifyDataSetChanged()
			{
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyDataSetChanged.()V", this, null);
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00009938 File Offset: 0x00007B38
			[Register("notifyItemChanged", "(I)V", "")]
			public unsafe void NotifyItemChanged(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemChanged.(I)V", this, ptr);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00009974 File Offset: 0x00007B74
			[Register("notifyItemChanged", "(ILjava/lang/Object;)V", "")]
			public unsafe void NotifyItemChanged(int position, Java.Lang.Object payload)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(position);
					ptr[1] = new JniArgumentValue((payload == null) ? IntPtr.Zero : payload.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemChanged.(ILjava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(payload);
				}
			}

			// Token: 0x06000384 RID: 900 RVA: 0x000099EC File Offset: 0x00007BEC
			[Register("notifyItemInserted", "(I)V", "")]
			public unsafe void NotifyItemInserted(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemInserted.(I)V", this, ptr);
			}

			// Token: 0x06000385 RID: 901 RVA: 0x00009A28 File Offset: 0x00007C28
			[Register("notifyItemMoved", "(II)V", "")]
			public unsafe void NotifyItemMoved(int fromPosition, int toPosition)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(fromPosition);
				ptr[1] = new JniArgumentValue(toPosition);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemMoved.(II)V", this, ptr);
			}

			// Token: 0x06000386 RID: 902 RVA: 0x00009A78 File Offset: 0x00007C78
			[Register("notifyItemRangeChanged", "(II)V", "")]
			public unsafe void NotifyItemRangeChanged(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemRangeChanged.(II)V", this, ptr);
			}

			// Token: 0x06000387 RID: 903 RVA: 0x00009AC8 File Offset: 0x00007CC8
			[Register("notifyItemRangeChanged", "(IILjava/lang/Object;)V", "")]
			public unsafe void NotifyItemRangeChanged(int positionStart, int itemCount, Java.Lang.Object payload)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(positionStart);
					ptr[1] = new JniArgumentValue(itemCount);
					ptr[2] = new JniArgumentValue((payload == null) ? IntPtr.Zero : payload.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemRangeChanged.(IILjava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(payload);
				}
			}

			// Token: 0x06000388 RID: 904 RVA: 0x00009B54 File Offset: 0x00007D54
			[Register("notifyItemRangeInserted", "(II)V", "")]
			public unsafe void NotifyItemRangeInserted(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemRangeInserted.(II)V", this, ptr);
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00009BA4 File Offset: 0x00007DA4
			[Register("notifyItemRangeRemoved", "(II)V", "")]
			public unsafe void NotifyItemRangeRemoved(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemRangeRemoved.(II)V", this, ptr);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00009BF4 File Offset: 0x00007DF4
			[Register("notifyItemRemoved", "(I)V", "")]
			public unsafe void NotifyItemRemoved(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				RecyclerView.Adapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("notifyItemRemoved.(I)V", this, ptr);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00009C2F File Offset: 0x00007E2F
			private static Delegate GetOnAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.Adapter.cb_onAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.Adapter.cb_onAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_OnAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.Adapter.cb_onAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00009C54 File Offset: 0x00007E54
			private static void n_OnAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnAttachedToRecyclerView(object2);
			}

			// Token: 0x0600038D RID: 909 RVA: 0x00009C78 File Offset: 0x00007E78
			[Register("onAttachedToRecyclerView", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnAttachedToRecyclerView(RecyclerView recyclerView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToRecyclerView.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00009CDC File Offset: 0x00007EDC
			private static Delegate GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler()
			{
				if (RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
				{
					RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.Adapter.n_OnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I));
				}
				return RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00009D00 File Offset: 0x00007F00
			private static void n_OnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
				@object.OnBindViewHolder(object2, position);
			}

			// Token: 0x06000390 RID: 912
			[Register("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public abstract void OnBindViewHolder(RecyclerView.ViewHolder holder, int position);

			// Token: 0x06000391 RID: 913 RVA: 0x00009D24 File Offset: 0x00007F24
			private static Delegate GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_Handler()
			{
				if (RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_ == null)
				{
					RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(RecyclerView.Adapter.n_OnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_));
				}
				return RecyclerView.Adapter.cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_;
			}

			// Token: 0x06000392 RID: 914 RVA: 0x00009D48 File Offset: 0x00007F48
			private static void n_OnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position, IntPtr native_payloads)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
				IList<Java.Lang.Object> payloads = JavaList<Java.Lang.Object>.FromJniHandle(native_payloads, JniHandleOwnership.DoNotTransfer);
				@object.OnBindViewHolder(object2, position, payloads);
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00009D78 File Offset: 0x00007F78
			[Register("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILjava/util/List;)V", "GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_Handler")]
			public unsafe virtual void OnBindViewHolder(RecyclerView.ViewHolder holder, int position, IList<Java.Lang.Object> payloads)
			{
				IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(payloads);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
					ptr[1] = new JniArgumentValue(position);
					ptr[2] = new JniArgumentValue(intPtr);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onBindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILjava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(holder);
					GC.KeepAlive(payloads);
				}
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00009E18 File Offset: 0x00008018
			private static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler()
			{
				if (RecyclerView.Adapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
				{
					RecyclerView.Adapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(RecyclerView.Adapter.n_OnCreateViewHolder_Landroid_view_ViewGroup_I));
				}
				return RecyclerView.Adapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00009E3C File Offset: 0x0000803C
			private static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int viewType)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnCreateViewHolder(object2, viewType));
			}

			// Token: 0x06000396 RID: 918
			[Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
			public abstract RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType);

			// Token: 0x06000397 RID: 919 RVA: 0x00009E65 File Offset: 0x00008065
			private static Delegate GetOnDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.Adapter.cb_onDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.Adapter.cb_onDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_OnDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.Adapter.cb_onDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x06000398 RID: 920 RVA: 0x00009E8C File Offset: 0x0000808C
			private static void n_OnDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnDetachedFromRecyclerView(object2);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00009EB0 File Offset: 0x000080B0
			[Register("onDetachedFromRecyclerView", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnDetachedFromRecyclerView(RecyclerView recyclerView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromRecyclerView.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x0600039A RID: 922 RVA: 0x00009F14 File Offset: 0x00008114
			private static Delegate GetOnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.Adapter.cb_onFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.Adapter.cb_onFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RecyclerView.Adapter.n_OnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.Adapter.cb_onFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00009F38 File Offset: 0x00008138
			private static bool n_OnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
				return @object.OnFailedToRecycleView(object2);
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00009F5C File Offset: 0x0000815C
			[Register("onFailedToRecycleView", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", "GetOnFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual bool OnFailedToRecycleView(Java.Lang.Object holder)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(holder);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					result = RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualBooleanMethod("onFailedToRecycleView.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(holder);
				}
				return result;
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00009FC0 File Offset: 0x000081C0
			private static Delegate GetOnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.Adapter.cb_onViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.Adapter.cb_onViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_OnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.Adapter.cb_onViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00009FE4 File Offset: 0x000081E4
			private static void n_OnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
				@object.OnViewAttachedToWindow(object2);
			}

			// Token: 0x0600039F RID: 927 RVA: 0x0000A008 File Offset: 0x00008208
			[Register("onViewAttachedToWindow", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void OnViewAttachedToWindow(Java.Lang.Object holder)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(holder);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onViewAttachedToWindow.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(holder);
				}
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x0000A06C File Offset: 0x0000826C
			private static Delegate GetOnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.Adapter.cb_onViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.Adapter.cb_onViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_OnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.Adapter.cb_onViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x0000A090 File Offset: 0x00008290
			private static void n_OnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
				@object.OnViewDetachedFromWindow(object2);
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x0000A0B4 File Offset: 0x000082B4
			[Register("onViewDetachedFromWindow", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void OnViewDetachedFromWindow(Java.Lang.Object holder)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(holder);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onViewDetachedFromWindow.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(holder);
				}
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x0000A118 File Offset: 0x00008318
			private static Delegate GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.Adapter.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.Adapter.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_OnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.Adapter.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x0000A13C File Offset: 0x0000833C
			private static void n_OnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
				@object.OnViewRecycled(object2);
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x0000A160 File Offset: 0x00008360
			[Register("onViewRecycled", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void OnViewRecycled(Java.Lang.Object holder)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(holder);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("onViewRecycled.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(holder);
				}
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x0000A1C4 File Offset: 0x000083C4
			private static Delegate GetRegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler()
			{
				if (RecyclerView.Adapter.cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ == null)
				{
					RecyclerView.Adapter.cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_RegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_));
				}
				return RecyclerView.Adapter.cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x0000A1E8 File Offset: 0x000083E8
			private static void n_RegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.AdapterDataObserver object2 = Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
				@object.RegisterAdapterDataObserver(object2);
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x0000A20C File Offset: 0x0000840C
			[Register("registerAdapterDataObserver", "(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V", "GetRegisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler")]
			public unsafe virtual void RegisterAdapterDataObserver(RecyclerView.AdapterDataObserver observer)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("registerAdapterDataObserver.(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(observer);
				}
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x0000A270 File Offset: 0x00008470
			private static Delegate GetSetStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_Handler()
			{
				if (RecyclerView.Adapter.cb_setStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_ == null)
				{
					RecyclerView.Adapter.cb_setStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_SetStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_));
				}
				return RecyclerView.Adapter.cb_setStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_;
			}

			// Token: 0x060003AA RID: 938 RVA: 0x0000A294 File Offset: 0x00008494
			private static void n_SetStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_(IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Adapter.StateRestorationPolicy object2 = Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(native_strategy, JniHandleOwnership.DoNotTransfer);
				@object.SetStateRestorationPolicy(object2);
			}

			// Token: 0x060003AB RID: 939 RVA: 0x0000A2B8 File Offset: 0x000084B8
			[Register("setStateRestorationPolicy", "(Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;)V", "GetSetStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_Handler")]
			public unsafe virtual void SetStateRestorationPolicy(RecyclerView.Adapter.StateRestorationPolicy strategy)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((strategy == null) ? IntPtr.Zero : strategy.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("setStateRestorationPolicy.(Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(strategy);
				}
			}

			// Token: 0x060003AC RID: 940 RVA: 0x0000A31C File Offset: 0x0000851C
			private static Delegate GetUnregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler()
			{
				if (RecyclerView.Adapter.cb_unregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ == null)
				{
					RecyclerView.Adapter.cb_unregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.Adapter.n_UnregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_));
				}
				return RecyclerView.Adapter.cb_unregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;
			}

			// Token: 0x060003AD RID: 941 RVA: 0x0000A340 File Offset: 0x00008540
			private static void n_UnregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
			{
				RecyclerView.Adapter @object = Java.Lang.Object.GetObject<RecyclerView.Adapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.AdapterDataObserver object2 = Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
				@object.UnregisterAdapterDataObserver(object2);
			}

			// Token: 0x060003AE RID: 942 RVA: 0x0000A364 File Offset: 0x00008564
			[Register("unregisterAdapterDataObserver", "(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V", "GetUnregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_Handler")]
			public unsafe virtual void UnregisterAdapterDataObserver(RecyclerView.AdapterDataObserver observer)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
					RecyclerView.Adapter._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterAdapterDataObserver.(Landroidx/recyclerview/widget/RecyclerView$AdapterDataObserver;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(observer);
				}
			}

			// Token: 0x040000B9 RID: 185
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$Adapter", typeof(RecyclerView.Adapter));

			// Token: 0x040000BA RID: 186
			private static Delegate cb_getItemCount;

			// Token: 0x040000BB RID: 187
			private static Delegate cb_findRelativeAdapterPositionIn_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;

			// Token: 0x040000BC RID: 188
			private static Delegate cb_getItemId_I;

			// Token: 0x040000BD RID: 189
			private static Delegate cb_getItemViewType_I;

			// Token: 0x040000BE RID: 190
			private static Delegate cb_onAttachedToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x040000BF RID: 191
			private static Delegate cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;

			// Token: 0x040000C0 RID: 192
			private static Delegate cb_onBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_;

			// Token: 0x040000C1 RID: 193
			private static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;

			// Token: 0x040000C2 RID: 194
			private static Delegate cb_onDetachedFromRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x040000C3 RID: 195
			private static Delegate cb_onFailedToRecycleView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000C4 RID: 196
			private static Delegate cb_onViewAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000C5 RID: 197
			private static Delegate cb_onViewDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000C6 RID: 198
			private static Delegate cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000C7 RID: 199
			private static Delegate cb_registerAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;

			// Token: 0x040000C8 RID: 200
			private static Delegate cb_setStateRestorationPolicy_Landroidx_recyclerview_widget_RecyclerView_Adapter_StateRestorationPolicy_;

			// Token: 0x040000C9 RID: 201
			private static Delegate cb_unregisterAdapterDataObserver_Landroidx_recyclerview_widget_RecyclerView_AdapterDataObserver_;

			// Token: 0x02000057 RID: 87
			[Register("androidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy", DoNotGenerateAcw = true)]
			public sealed class StateRestorationPolicy : Java.Lang.Enum
			{
				// Token: 0x17000047 RID: 71
				// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000A3E4 File Offset: 0x000085E4
				[Register("ALLOW")]
				public static RecyclerView.Adapter.StateRestorationPolicy Allow
				{
					get
					{
						return Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(RecyclerView.Adapter.StateRestorationPolicy._members.StaticFields.GetObjectValue("ALLOW.Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;").Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				// Token: 0x17000048 RID: 72
				// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000A414 File Offset: 0x00008614
				[Register("PREVENT")]
				public static RecyclerView.Adapter.StateRestorationPolicy Prevent
				{
					get
					{
						return Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(RecyclerView.Adapter.StateRestorationPolicy._members.StaticFields.GetObjectValue("PREVENT.Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;").Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				// Token: 0x17000049 RID: 73
				// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000A444 File Offset: 0x00008644
				[Register("PREVENT_WHEN_EMPTY")]
				public static RecyclerView.Adapter.StateRestorationPolicy PreventWhenEmpty
				{
					get
					{
						return Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(RecyclerView.Adapter.StateRestorationPolicy._members.StaticFields.GetObjectValue("PREVENT_WHEN_EMPTY.Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;").Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				// Token: 0x1700004A RID: 74
				// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000A474 File Offset: 0x00008674
				internal static IntPtr class_ref
				{
					get
					{
						return RecyclerView.Adapter.StateRestorationPolicy._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x1700004B RID: 75
				// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000A498 File Offset: 0x00008698
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.Adapter.StateRestorationPolicy._members;
					}
				}

				// Token: 0x1700004C RID: 76
				// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000A4A0 File Offset: 0x000086A0
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return RecyclerView.Adapter.StateRestorationPolicy._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x1700004D RID: 77
				// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000A4C4 File Offset: 0x000086C4
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.Adapter.StateRestorationPolicy._members.ManagedPeerType;
					}
				}

				// Token: 0x060003B7 RID: 951 RVA: 0x0000A4D0 File Offset: 0x000086D0
				internal StateRestorationPolicy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x060003B8 RID: 952 RVA: 0x0000A4DC File Offset: 0x000086DC
				[Register("valueOf", "(Ljava/lang/String;)Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", "")]
				public unsafe static RecyclerView.Adapter.StateRestorationPolicy ValueOf(string name)
				{
					IntPtr intPtr = JNIEnv.NewString(name);
					RecyclerView.Adapter.StateRestorationPolicy @object;
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(intPtr);
						@object = Java.Lang.Object.GetObject<RecyclerView.Adapter.StateRestorationPolicy>(RecyclerView.Adapter.StateRestorationPolicy._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
					return @object;
				}

				// Token: 0x060003B9 RID: 953 RVA: 0x0000A548 File Offset: 0x00008748
				[Register("values", "()[Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", "")]
				public static RecyclerView.Adapter.StateRestorationPolicy[] Values()
				{
					return (RecyclerView.Adapter.StateRestorationPolicy[])JNIEnv.GetArray(RecyclerView.Adapter.StateRestorationPolicy._members.StaticMethods.InvokeObjectMethod("values.()[Landroidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RecyclerView.Adapter.StateRestorationPolicy));
				}

				// Token: 0x040000CA RID: 202
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$Adapter$StateRestorationPolicy", typeof(RecyclerView.Adapter.StateRestorationPolicy));
			}
		}

		// Token: 0x02000058 RID: 88
		[Register("androidx/recyclerview/widget/RecyclerView$Adapter", DoNotGenerateAcw = true)]
		internal class AdapterInvoker : RecyclerView.Adapter
		{
			// Token: 0x060003BB RID: 955 RVA: 0x0000A5A3 File Offset: 0x000087A3
			public AdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060003BC RID: 956 RVA: 0x0000A5AD File Offset: 0x000087AD
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.AdapterInvoker._members;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060003BD RID: 957 RVA: 0x0000A5B4 File Offset: 0x000087B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.AdapterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060003BE RID: 958 RVA: 0x0000A5C0 File Offset: 0x000087C0
			public override int ItemCount
			{
				[Register("getItemCount", "()I", "GetGetItemCountHandler")]
				get
				{
					return RecyclerView.AdapterInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getItemCount.()I", this, null);
				}
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000A5DC File Offset: 0x000087DC
			[Register("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public unsafe override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
					ptr[1] = new JniArgumentValue(position);
					RecyclerView.AdapterInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onBindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(holder);
				}
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x0000A654 File Offset: 0x00008854
			[Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
			public unsafe override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
			{
				RecyclerView.ViewHolder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(viewType);
					@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView.AdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onCreateViewHolder.(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(parent);
				}
				return @object;
			}

			// Token: 0x040000CB RID: 203
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$Adapter", typeof(RecyclerView.AdapterInvoker));
		}

		// Token: 0x02000059 RID: 89
		[Register("androidx/recyclerview/widget/RecyclerView$AdapterDataObserver", DoNotGenerateAcw = true)]
		public abstract class AdapterDataObserver : Java.Lang.Object
		{
			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000A6F8 File Offset: 0x000088F8
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.AdapterDataObserver._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000A71C File Offset: 0x0000891C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.AdapterDataObserver._members;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000A724 File Offset: 0x00008924
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.AdapterDataObserver._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060003C5 RID: 965 RVA: 0x0000A748 File Offset: 0x00008948
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.AdapterDataObserver._members.ManagedPeerType;
				}
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x000026A8 File Offset: 0x000008A8
			protected AdapterDataObserver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000A754 File Offset: 0x00008954
			[Register(".ctor", "()V", "")]
			public AdapterDataObserver() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.AdapterDataObserver._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.AdapterDataObserver._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000A7C2 File Offset: 0x000089C2
			private static Delegate GetOnChangedHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onChanged == null)
				{
					RecyclerView.AdapterDataObserver.cb_onChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.AdapterDataObserver.n_OnChanged));
				}
				return RecyclerView.AdapterDataObserver.cb_onChanged;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x0000A7E6 File Offset: 0x000089E6
			private static void n_OnChanged(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnChanged();
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000A7F5 File Offset: 0x000089F5
			[Register("onChanged", "()V", "GetOnChangedHandler")]
			public virtual void OnChanged()
			{
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onChanged.()V", this, null);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0000A80E File Offset: 0x00008A0E
			private static Delegate GetOnItemRangeChanged_IIHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_II == null)
				{
					RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.AdapterDataObserver.n_OnItemRangeChanged_II));
				}
				return RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_II;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0000A832 File Offset: 0x00008A32
			private static void n_OnItemRangeChanged_II(IntPtr jnienv, IntPtr native__this, int positionStart, int itemCount)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnItemRangeChanged(positionStart, itemCount);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0000A844 File Offset: 0x00008A44
			[Register("onItemRangeChanged", "(II)V", "GetOnItemRangeChanged_IIHandler")]
			public unsafe virtual void OnItemRangeChanged(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onItemRangeChanged.(II)V", this, ptr);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x0000A892 File Offset: 0x00008A92
			private static Delegate GetOnItemRangeChanged_IILjava_lang_Object_Handler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_IILjava_lang_Object_ == null)
				{
					RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_V(RecyclerView.AdapterDataObserver.n_OnItemRangeChanged_IILjava_lang_Object_));
				}
				return RecyclerView.AdapterDataObserver.cb_onItemRangeChanged_IILjava_lang_Object_;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000A8B8 File Offset: 0x00008AB8
			private static void n_OnItemRangeChanged_IILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int positionStart, int itemCount, IntPtr native_payload)
			{
				RecyclerView.AdapterDataObserver @object = Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_payload, JniHandleOwnership.DoNotTransfer);
				@object.OnItemRangeChanged(positionStart, itemCount, object2);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000A8E0 File Offset: 0x00008AE0
			[Register("onItemRangeChanged", "(IILjava/lang/Object;)V", "GetOnItemRangeChanged_IILjava_lang_Object_Handler")]
			public unsafe virtual void OnItemRangeChanged(int positionStart, int itemCount, Java.Lang.Object payload)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(positionStart);
					ptr[1] = new JniArgumentValue(itemCount);
					ptr[2] = new JniArgumentValue((payload == null) ? IntPtr.Zero : payload.Handle);
					RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onItemRangeChanged.(IILjava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(payload);
				}
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000A96C File Offset: 0x00008B6C
			private static Delegate GetOnItemRangeInserted_IIHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onItemRangeInserted_II == null)
				{
					RecyclerView.AdapterDataObserver.cb_onItemRangeInserted_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.AdapterDataObserver.n_OnItemRangeInserted_II));
				}
				return RecyclerView.AdapterDataObserver.cb_onItemRangeInserted_II;
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0000A990 File Offset: 0x00008B90
			private static void n_OnItemRangeInserted_II(IntPtr jnienv, IntPtr native__this, int positionStart, int itemCount)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnItemRangeInserted(positionStart, itemCount);
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0000A9A4 File Offset: 0x00008BA4
			[Register("onItemRangeInserted", "(II)V", "GetOnItemRangeInserted_IIHandler")]
			public unsafe virtual void OnItemRangeInserted(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onItemRangeInserted.(II)V", this, ptr);
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0000A9F2 File Offset: 0x00008BF2
			private static Delegate GetOnItemRangeMoved_IIIHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onItemRangeMoved_III == null)
				{
					RecyclerView.AdapterDataObserver.cb_onItemRangeMoved_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIII_V(RecyclerView.AdapterDataObserver.n_OnItemRangeMoved_III));
				}
				return RecyclerView.AdapterDataObserver.cb_onItemRangeMoved_III;
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x0000AA16 File Offset: 0x00008C16
			private static void n_OnItemRangeMoved_III(IntPtr jnienv, IntPtr native__this, int fromPosition, int toPosition, int itemCount)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnItemRangeMoved(fromPosition, toPosition, itemCount);
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0000AA2C File Offset: 0x00008C2C
			[Register("onItemRangeMoved", "(III)V", "GetOnItemRangeMoved_IIIHandler")]
			public unsafe virtual void OnItemRangeMoved(int fromPosition, int toPosition, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(fromPosition);
				ptr[1] = new JniArgumentValue(toPosition);
				ptr[2] = new JniArgumentValue(itemCount);
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onItemRangeMoved.(III)V", this, ptr);
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x0000AA90 File Offset: 0x00008C90
			private static Delegate GetOnItemRangeRemoved_IIHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onItemRangeRemoved_II == null)
				{
					RecyclerView.AdapterDataObserver.cb_onItemRangeRemoved_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.AdapterDataObserver.n_OnItemRangeRemoved_II));
				}
				return RecyclerView.AdapterDataObserver.cb_onItemRangeRemoved_II;
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x0000AAB4 File Offset: 0x00008CB4
			private static void n_OnItemRangeRemoved_II(IntPtr jnienv, IntPtr native__this, int positionStart, int itemCount)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnItemRangeRemoved(positionStart, itemCount);
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x0000AAC8 File Offset: 0x00008CC8
			[Register("onItemRangeRemoved", "(II)V", "GetOnItemRangeRemoved_IIHandler")]
			public unsafe virtual void OnItemRangeRemoved(int positionStart, int itemCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(positionStart);
				ptr[1] = new JniArgumentValue(itemCount);
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onItemRangeRemoved.(II)V", this, ptr);
			}

			// Token: 0x060003DA RID: 986 RVA: 0x0000AB16 File Offset: 0x00008D16
			private static Delegate GetOnStateRestorationPolicyChangedHandler()
			{
				if (RecyclerView.AdapterDataObserver.cb_onStateRestorationPolicyChanged == null)
				{
					RecyclerView.AdapterDataObserver.cb_onStateRestorationPolicyChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.AdapterDataObserver.n_OnStateRestorationPolicyChanged));
				}
				return RecyclerView.AdapterDataObserver.cb_onStateRestorationPolicyChanged;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000AB3A File Offset: 0x00008D3A
			private static void n_OnStateRestorationPolicyChanged(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.AdapterDataObserver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStateRestorationPolicyChanged();
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0000AB49 File Offset: 0x00008D49
			[Register("onStateRestorationPolicyChanged", "()V", "GetOnStateRestorationPolicyChangedHandler")]
			public virtual void OnStateRestorationPolicyChanged()
			{
				RecyclerView.AdapterDataObserver._members.InstanceMethods.InvokeVirtualVoidMethod("onStateRestorationPolicyChanged.()V", this, null);
			}

			// Token: 0x040000CC RID: 204
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$AdapterDataObserver", typeof(RecyclerView.AdapterDataObserver));

			// Token: 0x040000CD RID: 205
			private static Delegate cb_onChanged;

			// Token: 0x040000CE RID: 206
			private static Delegate cb_onItemRangeChanged_II;

			// Token: 0x040000CF RID: 207
			private static Delegate cb_onItemRangeChanged_IILjava_lang_Object_;

			// Token: 0x040000D0 RID: 208
			private static Delegate cb_onItemRangeInserted_II;

			// Token: 0x040000D1 RID: 209
			private static Delegate cb_onItemRangeMoved_III;

			// Token: 0x040000D2 RID: 210
			private static Delegate cb_onItemRangeRemoved_II;

			// Token: 0x040000D3 RID: 211
			private static Delegate cb_onStateRestorationPolicyChanged;
		}

		// Token: 0x0200005A RID: 90
		[Register("androidx/recyclerview/widget/RecyclerView$AdapterDataObserver", DoNotGenerateAcw = true)]
		internal class AdapterDataObserverInvoker : RecyclerView.AdapterDataObserver
		{
			// Token: 0x060003DE RID: 990 RVA: 0x0000AB7D File Offset: 0x00008D7D
			public AdapterDataObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060003DF RID: 991 RVA: 0x0000AB87 File Offset: 0x00008D87
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.AdapterDataObserverInvoker._members;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000AB8E File Offset: 0x00008D8E
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.AdapterDataObserverInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040000D4 RID: 212
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$AdapterDataObserver", typeof(RecyclerView.AdapterDataObserverInvoker));
		}

		// Token: 0x0200005B RID: 91
		[Register("androidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback", "", "AndroidX.RecyclerView.Widget.RecyclerView/IChildDrawingOrderCallbackInvoker")]
		public interface IChildDrawingOrderCallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003E2 RID: 994
			[Register("onGetChildDrawingOrder", "(II)I", "GetOnGetChildDrawingOrder_IIHandler:AndroidX.RecyclerView.Widget.RecyclerView/IChildDrawingOrderCallbackInvoker, Xamarin.AndroidX.RecyclerView")]
			int OnGetChildDrawingOrder(int childCount, int i);
		}

		// Token: 0x0200005C RID: 92
		[Register("androidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback", DoNotGenerateAcw = true)]
		internal class IChildDrawingOrderCallbackInvoker : Java.Lang.Object, RecyclerView.IChildDrawingOrderCallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000ABB8 File Offset: 0x00008DB8
			private static IntPtr java_class_ref
			{
				get
				{
					return RecyclerView.IChildDrawingOrderCallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000ABDC File Offset: 0x00008DDC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.IChildDrawingOrderCallbackInvoker._members;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000ABE3 File Offset: 0x00008DE3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000ABEB File Offset: 0x00008DEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.IChildDrawingOrderCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0000ABF7 File Offset: 0x00008DF7
			public static RecyclerView.IChildDrawingOrderCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<RecyclerView.IChildDrawingOrderCallback>(handle, transfer);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0000AC00 File Offset: 0x00008E00
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, RecyclerView.IChildDrawingOrderCallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.ChildDrawingOrderCallback'.");
				}
				return handle;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x0000AC2B File Offset: 0x00008E2B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x0000AC5C File Offset: 0x00008E5C
			public IChildDrawingOrderCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.IChildDrawingOrderCallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x0000AC94 File Offset: 0x00008E94
			private static Delegate GetOnGetChildDrawingOrder_IIHandler()
			{
				if (RecyclerView.IChildDrawingOrderCallbackInvoker.cb_onGetChildDrawingOrder_II == null)
				{
					RecyclerView.IChildDrawingOrderCallbackInvoker.cb_onGetChildDrawingOrder_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(RecyclerView.IChildDrawingOrderCallbackInvoker.n_OnGetChildDrawingOrder_II));
				}
				return RecyclerView.IChildDrawingOrderCallbackInvoker.cb_onGetChildDrawingOrder_II;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x0000ACB8 File Offset: 0x00008EB8
			private static int n_OnGetChildDrawingOrder_II(IntPtr jnienv, IntPtr native__this, int childCount, int i)
			{
				return Java.Lang.Object.GetObject<RecyclerView.IChildDrawingOrderCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGetChildDrawingOrder(childCount, i);
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0000ACCC File Offset: 0x00008ECC
			public unsafe int OnGetChildDrawingOrder(int childCount, int i)
			{
				if (this.id_onGetChildDrawingOrder_II == IntPtr.Zero)
				{
					this.id_onGetChildDrawingOrder_II = JNIEnv.GetMethodID(this.class_ref, "onGetChildDrawingOrder", "(II)I");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(childCount);
				ptr[1] = new JValue(i);
				return JNIEnv.CallIntMethod(base.Handle, this.id_onGetChildDrawingOrder_II, ptr);
			}

			// Token: 0x040000D5 RID: 213
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ChildDrawingOrderCallback", typeof(RecyclerView.IChildDrawingOrderCallbackInvoker));

			// Token: 0x040000D6 RID: 214
			private IntPtr class_ref;

			// Token: 0x040000D7 RID: 215
			private static Delegate cb_onGetChildDrawingOrder_II;

			// Token: 0x040000D8 RID: 216
			private IntPtr id_onGetChildDrawingOrder_II;
		}

		// Token: 0x0200005D RID: 93
		[Register("androidx/recyclerview/widget/RecyclerView$EdgeEffectFactory", DoNotGenerateAcw = true)]
		public class EdgeEffectFactory : Java.Lang.Object
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000AD60 File Offset: 0x00008F60
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.EdgeEffectFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000AD84 File Offset: 0x00008F84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.EdgeEffectFactory._members;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000AD8C File Offset: 0x00008F8C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.EdgeEffectFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000ADB0 File Offset: 0x00008FB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.EdgeEffectFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x000026A8 File Offset: 0x000008A8
			protected EdgeEffectFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x0000ADBC File Offset: 0x00008FBC
			[Register(".ctor", "()V", "")]
			public EdgeEffectFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.EdgeEffectFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.EdgeEffectFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0000AE2A File Offset: 0x0000902A
			private static Delegate GetCreateEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_IHandler()
			{
				if (RecyclerView.EdgeEffectFactory.cb_createEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I == null)
				{
					RecyclerView.EdgeEffectFactory.cb_createEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(RecyclerView.EdgeEffectFactory.n_CreateEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I));
				}
				return RecyclerView.EdgeEffectFactory.cb_createEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x0000AE50 File Offset: 0x00009050
			private static IntPtr n_CreateEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int direction)
			{
				RecyclerView.EdgeEffectFactory @object = Java.Lang.Object.GetObject<RecyclerView.EdgeEffectFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.CreateEdgeEffect(object2, direction));
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x0000AE7C File Offset: 0x0000907C
			[Register("createEdgeEffect", "(Landroidx/recyclerview/widget/RecyclerView;I)Landroid/widget/EdgeEffect;", "GetCreateEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_IHandler")]
			protected unsafe virtual EdgeEffect CreateEdgeEffect(RecyclerView view, int direction)
			{
				EdgeEffect @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue(direction);
					@object = Java.Lang.Object.GetObject<EdgeEffect>(RecyclerView.EdgeEffectFactory._members.InstanceMethods.InvokeVirtualObjectMethod("createEdgeEffect.(Landroidx/recyclerview/widget/RecyclerView;I)Landroid/widget/EdgeEffect;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x040000D9 RID: 217
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$EdgeEffectFactory", typeof(RecyclerView.EdgeEffectFactory));

			// Token: 0x040000DA RID: 218
			private static Delegate cb_createEdgeEffect_Landroidx_recyclerview_widget_RecyclerView_I;
		}

		// Token: 0x0200005E RID: 94
		[Register("androidx/recyclerview/widget/RecyclerView$ItemAnimator", DoNotGenerateAcw = true)]
		public abstract class ItemAnimator : Java.Lang.Object
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000AF20 File Offset: 0x00009120
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.ItemAnimator._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000AF44 File Offset: 0x00009144
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ItemAnimator._members;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000AF4C File Offset: 0x0000914C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.ItemAnimator._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000AF70 File Offset: 0x00009170
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ItemAnimator._members.ManagedPeerType;
				}
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x000026A8 File Offset: 0x000008A8
			protected ItemAnimator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x0000AF7C File Offset: 0x0000917C
			[Register(".ctor", "()V", "")]
			public ItemAnimator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.ItemAnimator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.ItemAnimator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0000AFEA File Offset: 0x000091EA
			private static Delegate GetGetAddDurationHandler()
			{
				if (RecyclerView.ItemAnimator.cb_getAddDuration == null)
				{
					RecyclerView.ItemAnimator.cb_getAddDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(RecyclerView.ItemAnimator.n_GetAddDuration));
				}
				return RecyclerView.ItemAnimator.cb_getAddDuration;
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x0000B00E File Offset: 0x0000920E
			private static long n_GetAddDuration(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddDuration;
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x0000B01D File Offset: 0x0000921D
			private static Delegate GetSetAddDuration_JHandler()
			{
				if (RecyclerView.ItemAnimator.cb_setAddDuration_J == null)
				{
					RecyclerView.ItemAnimator.cb_setAddDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(RecyclerView.ItemAnimator.n_SetAddDuration_J));
				}
				return RecyclerView.ItemAnimator.cb_setAddDuration_J;
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0000B041 File Offset: 0x00009241
			private static void n_SetAddDuration_J(IntPtr jnienv, IntPtr native__this, long addDuration)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddDuration = addDuration;
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000B051 File Offset: 0x00009251
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x0000B06C File Offset: 0x0000926C
			public unsafe virtual long AddDuration
			{
				[Register("getAddDuration", "()J", "GetGetAddDurationHandler")]
				get
				{
					return RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualInt64Method("getAddDuration.()J", this, null);
				}
				[Register("setAddDuration", "(J)V", "GetSetAddDuration_JHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("setAddDuration.(J)V", this, ptr);
				}
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0000B0A7 File Offset: 0x000092A7
			private static Delegate GetGetChangeDurationHandler()
			{
				if (RecyclerView.ItemAnimator.cb_getChangeDuration == null)
				{
					RecyclerView.ItemAnimator.cb_getChangeDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(RecyclerView.ItemAnimator.n_GetChangeDuration));
				}
				return RecyclerView.ItemAnimator.cb_getChangeDuration;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x0000B0CB File Offset: 0x000092CB
			private static long n_GetChangeDuration(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChangeDuration;
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x0000B0DA File Offset: 0x000092DA
			private static Delegate GetSetChangeDuration_JHandler()
			{
				if (RecyclerView.ItemAnimator.cb_setChangeDuration_J == null)
				{
					RecyclerView.ItemAnimator.cb_setChangeDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(RecyclerView.ItemAnimator.n_SetChangeDuration_J));
				}
				return RecyclerView.ItemAnimator.cb_setChangeDuration_J;
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x0000B0FE File Offset: 0x000092FE
			private static void n_SetChangeDuration_J(IntPtr jnienv, IntPtr native__this, long changeDuration)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChangeDuration = changeDuration;
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000B10E File Offset: 0x0000930E
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000B128 File Offset: 0x00009328
			public unsafe virtual long ChangeDuration
			{
				[Register("getChangeDuration", "()J", "GetGetChangeDurationHandler")]
				get
				{
					return RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualInt64Method("getChangeDuration.()J", this, null);
				}
				[Register("setChangeDuration", "(J)V", "GetSetChangeDuration_JHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("setChangeDuration.(J)V", this, ptr);
				}
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0000B163 File Offset: 0x00009363
			private static Delegate GetIsRunningHandler()
			{
				if (RecyclerView.ItemAnimator.cb_isRunning == null)
				{
					RecyclerView.ItemAnimator.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.ItemAnimator.n_IsRunning));
				}
				return RecyclerView.ItemAnimator.cb_isRunning;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0000B187 File Offset: 0x00009387
			private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600040D RID: 1037
			public abstract bool IsRunning { [Register("isRunning", "()Z", "GetIsRunningHandler")] get; }

			// Token: 0x0600040E RID: 1038 RVA: 0x0000B196 File Offset: 0x00009396
			private static Delegate GetGetMoveDurationHandler()
			{
				if (RecyclerView.ItemAnimator.cb_getMoveDuration == null)
				{
					RecyclerView.ItemAnimator.cb_getMoveDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(RecyclerView.ItemAnimator.n_GetMoveDuration));
				}
				return RecyclerView.ItemAnimator.cb_getMoveDuration;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x0000B1BA File Offset: 0x000093BA
			private static long n_GetMoveDuration(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveDuration;
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000B1C9 File Offset: 0x000093C9
			private static Delegate GetSetMoveDuration_JHandler()
			{
				if (RecyclerView.ItemAnimator.cb_setMoveDuration_J == null)
				{
					RecyclerView.ItemAnimator.cb_setMoveDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(RecyclerView.ItemAnimator.n_SetMoveDuration_J));
				}
				return RecyclerView.ItemAnimator.cb_setMoveDuration_J;
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0000B1ED File Offset: 0x000093ED
			private static void n_SetMoveDuration_J(IntPtr jnienv, IntPtr native__this, long moveDuration)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveDuration = moveDuration;
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000B1FD File Offset: 0x000093FD
			// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000B218 File Offset: 0x00009418
			public unsafe virtual long MoveDuration
			{
				[Register("getMoveDuration", "()J", "GetGetMoveDurationHandler")]
				get
				{
					return RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualInt64Method("getMoveDuration.()J", this, null);
				}
				[Register("setMoveDuration", "(J)V", "GetSetMoveDuration_JHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("setMoveDuration.(J)V", this, ptr);
				}
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x0000B253 File Offset: 0x00009453
			private static Delegate GetGetRemoveDurationHandler()
			{
				if (RecyclerView.ItemAnimator.cb_getRemoveDuration == null)
				{
					RecyclerView.ItemAnimator.cb_getRemoveDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(RecyclerView.ItemAnimator.n_GetRemoveDuration));
				}
				return RecyclerView.ItemAnimator.cb_getRemoveDuration;
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x0000B277 File Offset: 0x00009477
			private static long n_GetRemoveDuration(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveDuration;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x0000B286 File Offset: 0x00009486
			private static Delegate GetSetRemoveDuration_JHandler()
			{
				if (RecyclerView.ItemAnimator.cb_setRemoveDuration_J == null)
				{
					RecyclerView.ItemAnimator.cb_setRemoveDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(RecyclerView.ItemAnimator.n_SetRemoveDuration_J));
				}
				return RecyclerView.ItemAnimator.cb_setRemoveDuration_J;
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x0000B2AA File Offset: 0x000094AA
			private static void n_SetRemoveDuration_J(IntPtr jnienv, IntPtr native__this, long removeDuration)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveDuration = removeDuration;
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000B2BA File Offset: 0x000094BA
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x0000B2D4 File Offset: 0x000094D4
			public unsafe virtual long RemoveDuration
			{
				[Register("getRemoveDuration", "()J", "GetGetRemoveDurationHandler")]
				get
				{
					return RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualInt64Method("getRemoveDuration.()J", this, null);
				}
				[Register("setRemoveDuration", "(J)V", "GetSetRemoveDuration_JHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("setRemoveDuration.(J)V", this, ptr);
				}
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0000B30F File Offset: 0x0000950F
			private static Delegate GetAnimateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_animateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ == null)
				{
					RecyclerView.ItemAnimator.cb_animateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(RecyclerView.ItemAnimator.n_AnimateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_));
				}
				return RecyclerView.ItemAnimator.cb_animateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000B334 File Offset: 0x00009534
			private static bool n_AnimateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, IntPtr native_preLayoutInfo, IntPtr native_postLayoutInfo)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object3 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_preLayoutInfo, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object4 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_postLayoutInfo, JniHandleOwnership.DoNotTransfer);
				return @object.AnimateAppearance(object2, object3, object4);
			}

			// Token: 0x0600041C RID: 1052
			[Register("animateAppearance", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public abstract bool AnimateAppearance(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo);

			// Token: 0x0600041D RID: 1053 RVA: 0x0000B36A File Offset: 0x0000956A
			private static Delegate GetAnimateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_animateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ == null)
				{
					RecyclerView.ItemAnimator.cb_animateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_Z(RecyclerView.ItemAnimator.n_AnimateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_));
				}
				return RecyclerView.ItemAnimator.cb_animateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0000B390 File Offset: 0x00009590
			private static bool n_AnimateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_oldHolder, IntPtr native_newHolder, IntPtr native_preLayoutInfo, IntPtr native_postLayoutInfo)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_oldHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_newHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object4 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_preLayoutInfo, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object5 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_postLayoutInfo, JniHandleOwnership.DoNotTransfer);
				return @object.AnimateChange(object2, object3, object4, object5);
			}

			// Token: 0x0600041F RID: 1055
			[Register("animateChange", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public abstract bool AnimateChange(RecyclerView.ViewHolder oldHolder, RecyclerView.ViewHolder newHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo);

			// Token: 0x06000420 RID: 1056 RVA: 0x0000B3D0 File Offset: 0x000095D0
			private static Delegate GetAnimateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_animateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ == null)
				{
					RecyclerView.ItemAnimator.cb_animateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(RecyclerView.ItemAnimator.n_AnimateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_));
				}
				return RecyclerView.ItemAnimator.cb_animateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x0000B3F4 File Offset: 0x000095F4
			private static bool n_AnimateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, IntPtr native_preLayoutInfo, IntPtr native_postLayoutInfo)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object3 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_preLayoutInfo, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object4 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_postLayoutInfo, JniHandleOwnership.DoNotTransfer);
				return @object.AnimateDisappearance(object2, object3, object4);
			}

			// Token: 0x06000422 RID: 1058
			[Register("animateDisappearance", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public abstract bool AnimateDisappearance(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo);

			// Token: 0x06000423 RID: 1059 RVA: 0x0000B42A File Offset: 0x0000962A
			private static Delegate GetAnimatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_animatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ == null)
				{
					RecyclerView.ItemAnimator.cb_animatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(RecyclerView.ItemAnimator.n_AnimatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_));
				}
				return RecyclerView.ItemAnimator.cb_animatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x0000B450 File Offset: 0x00009650
			private static bool n_AnimatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, IntPtr native_preLayoutInfo, IntPtr native_postLayoutInfo)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object3 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_preLayoutInfo, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ItemAnimator.ItemHolderInfo object4 = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(native_postLayoutInfo, JniHandleOwnership.DoNotTransfer);
				return @object.AnimatePersistence(object2, object3, object4);
			}

			// Token: 0x06000425 RID: 1061
			[Register("animatePersistence", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public abstract bool AnimatePersistence(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo);

			// Token: 0x06000426 RID: 1062 RVA: 0x0000B486 File Offset: 0x00009686
			private static Delegate GetCanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RecyclerView.ItemAnimator.n_CanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x0000B4AC File Offset: 0x000096AC
			private static bool n_CanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				return @object.CanReuseUpdatedViewHolder(object2);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x0000B4D0 File Offset: 0x000096D0
			[Register("canReuseUpdatedViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", "GetCanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual bool CanReuseUpdatedViewHolder(RecyclerView.ViewHolder viewHolder)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					result = RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualBooleanMethod("canReuseUpdatedViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
				return result;
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x0000B538 File Offset: 0x00009738
			private static Delegate GetCanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_ == null)
				{
					RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(RecyclerView.ItemAnimator.n_CanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_));
				}
				return RecyclerView.ItemAnimator.cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0000B55C File Offset: 0x0000975C
			private static bool n_CanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, IntPtr native_payloads)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				IList<Java.Lang.Object> payloads = JavaList<Java.Lang.Object>.FromJniHandle(native_payloads, JniHandleOwnership.DoNotTransfer);
				return @object.CanReuseUpdatedViewHolder(object2, payloads);
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0000B588 File Offset: 0x00009788
			[Register("canReuseUpdatedViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Ljava/util/List;)Z", "GetCanReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_Handler")]
			public unsafe virtual bool CanReuseUpdatedViewHolder(RecyclerView.ViewHolder viewHolder, IList<Java.Lang.Object> payloads)
			{
				IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(payloads);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					result = RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualBooleanMethod("canReuseUpdatedViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Ljava/util/List;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(payloads);
				}
				return result;
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x0000B614 File Offset: 0x00009814
			[Register("dispatchAnimationFinished", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "")]
			public unsafe void DispatchAnimationFinished(RecyclerView.ViewHolder viewHolder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeNonvirtualVoidMethod("dispatchAnimationFinished.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0000B678 File Offset: 0x00009878
			[Register("dispatchAnimationStarted", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "")]
			public unsafe void DispatchAnimationStarted(RecyclerView.ViewHolder viewHolder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeNonvirtualVoidMethod("dispatchAnimationStarted.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x0000B6DC File Offset: 0x000098DC
			[Register("dispatchAnimationsFinished", "()V", "")]
			public void DispatchAnimationsFinished()
			{
				RecyclerView.ItemAnimator._members.InstanceMethods.InvokeNonvirtualVoidMethod("dispatchAnimationsFinished.()V", this, null);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x0000B6F5 File Offset: 0x000098F5
			private static Delegate GetEndAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_endAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.ItemAnimator.cb_endAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.ItemAnimator.n_EndAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.ItemAnimator.cb_endAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x0000B71C File Offset: 0x0000991C
			private static void n_EndAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_item, JniHandleOwnership.DoNotTransfer);
				@object.EndAnimation(object2);
			}

			// Token: 0x06000431 RID: 1073
			[Register("endAnimation", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetEndAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public abstract void EndAnimation(RecyclerView.ViewHolder item);

			// Token: 0x06000432 RID: 1074 RVA: 0x0000B73F File Offset: 0x0000993F
			private static Delegate GetEndAnimationsHandler()
			{
				if (RecyclerView.ItemAnimator.cb_endAnimations == null)
				{
					RecyclerView.ItemAnimator.cb_endAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.ItemAnimator.n_EndAnimations));
				}
				return RecyclerView.ItemAnimator.cb_endAnimations;
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0000B763 File Offset: 0x00009963
			private static void n_EndAnimations(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndAnimations();
			}

			// Token: 0x06000434 RID: 1076
			[Register("endAnimations", "()V", "GetEndAnimationsHandler")]
			public abstract void EndAnimations();

			// Token: 0x06000435 RID: 1077 RVA: 0x0000B774 File Offset: 0x00009974
			[Register("isRunning", "(Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener;)Z", "")]
			public unsafe bool InvokeIsRunning(RecyclerView.ItemAnimator.IItemAnimatorFinishedListener listener)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					result = RecyclerView.ItemAnimator._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isRunning.(Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return result;
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x0000B7E0 File Offset: 0x000099E0
			private static Delegate GetObtainHolderInfoHandler()
			{
				if (RecyclerView.ItemAnimator.cb_obtainHolderInfo == null)
				{
					RecyclerView.ItemAnimator.cb_obtainHolderInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.ItemAnimator.n_ObtainHolderInfo));
				}
				return RecyclerView.ItemAnimator.cb_obtainHolderInfo;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0000B804 File Offset: 0x00009A04
			private static IntPtr n_ObtainHolderInfo(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ObtainHolderInfo());
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x0000B818 File Offset: 0x00009A18
			[Register("obtainHolderInfo", "()Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", "GetObtainHolderInfoHandler")]
			public virtual RecyclerView.ItemAnimator.ItemHolderInfo ObtainHolderInfo()
			{
				return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualObjectMethod("obtainHolderInfo.()Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x0000B84A File Offset: 0x00009A4A
			private static Delegate GetOnAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_onAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.ItemAnimator.cb_onAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.ItemAnimator.n_OnAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.ItemAnimator.cb_onAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0000B870 File Offset: 0x00009A70
			private static void n_OnAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationFinished(object2);
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x0000B894 File Offset: 0x00009A94
			[Register("onAnimationFinished", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void OnAnimationFinished(RecyclerView.ViewHolder viewHolder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationFinished.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x0000B8F8 File Offset: 0x00009AF8
			private static Delegate GetOnAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_onAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.ItemAnimator.cb_onAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.ItemAnimator.n_OnAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.ItemAnimator.cb_onAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0000B91C File Offset: 0x00009B1C
			private static void n_OnAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationStarted(object2);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0000B940 File Offset: 0x00009B40
			[Register("onAnimationStarted", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void OnAnimationStarted(RecyclerView.ViewHolder viewHolder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationStarted.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0000B9A4 File Offset: 0x00009BA4
			private static Delegate GetRecordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_recordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.ItemAnimator.cb_recordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(RecyclerView.ItemAnimator.n_RecordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.ItemAnimator.cb_recordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x0000B9C8 File Offset: 0x00009BC8
			private static IntPtr n_RecordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_viewHolder)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.RecordPostLayoutInformation(object2, object3));
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x0000B9FC File Offset: 0x00009BFC
			[Register("recordPostLayoutInformation", "(Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", "GetRecordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual RecyclerView.ItemAnimator.ItemHolderInfo RecordPostLayoutInformation(RecyclerView.State state, RecyclerView.ViewHolder viewHolder)
			{
				RecyclerView.ItemAnimator.ItemHolderInfo @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[1] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					@object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualObjectMethod("recordPostLayoutInformation.(Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(state);
					GC.KeepAlive(viewHolder);
				}
				return @object;
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x0000BA98 File Offset: 0x00009C98
			private static Delegate GetRecordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_Handler()
			{
				if (RecyclerView.ItemAnimator.cb_recordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_ == null)
				{
					RecyclerView.ItemAnimator.cb_recordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_L(RecyclerView.ItemAnimator.n_RecordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_));
				}
				return RecyclerView.ItemAnimator.cb_recordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_;
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x0000BABC File Offset: 0x00009CBC
			private static IntPtr n_RecordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_viewHolder, int changeFlags, IntPtr native_payloads)
			{
				RecyclerView.ItemAnimator @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				IList<Java.Lang.Object> payloads = JavaList<Java.Lang.Object>.FromJniHandle(native_payloads, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.RecordPreLayoutInformation(object2, object3, changeFlags, payloads));
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x0000BAFC File Offset: 0x00009CFC
			[Register("recordPreLayoutInformation", "(Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILjava/util/List;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", "GetRecordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_Handler")]
			public unsafe virtual RecyclerView.ItemAnimator.ItemHolderInfo RecordPreLayoutInformation(RecyclerView.State state, RecyclerView.ViewHolder viewHolder, int changeFlags, IList<Java.Lang.Object> payloads)
			{
				IntPtr intPtr = JavaList<Java.Lang.Object>.ToLocalJniHandle(payloads);
				RecyclerView.ItemAnimator.ItemHolderInfo @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[1] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[2] = new JniArgumentValue(changeFlags);
					ptr[3] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(RecyclerView.ItemAnimator._members.InstanceMethods.InvokeVirtualObjectMethod("recordPreLayoutInformation.(Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILjava/util/List;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(state);
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(payloads);
				}
				return @object;
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x0000BBD8 File Offset: 0x00009DD8
			private static Delegate GetRunPendingAnimationsHandler()
			{
				if (RecyclerView.ItemAnimator.cb_runPendingAnimations == null)
				{
					RecyclerView.ItemAnimator.cb_runPendingAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.ItemAnimator.n_RunPendingAnimations));
				}
				return RecyclerView.ItemAnimator.cb_runPendingAnimations;
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x0000BBFC File Offset: 0x00009DFC
			private static void n_RunPendingAnimations(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.ItemAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RunPendingAnimations();
			}

			// Token: 0x06000447 RID: 1095
			[Register("runPendingAnimations", "()V", "GetRunPendingAnimationsHandler")]
			public abstract void RunPendingAnimations();

			// Token: 0x040000DB RID: 219
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemAnimator", typeof(RecyclerView.ItemAnimator));

			// Token: 0x040000DC RID: 220
			private static Delegate cb_getAddDuration;

			// Token: 0x040000DD RID: 221
			private static Delegate cb_setAddDuration_J;

			// Token: 0x040000DE RID: 222
			private static Delegate cb_getChangeDuration;

			// Token: 0x040000DF RID: 223
			private static Delegate cb_setChangeDuration_J;

			// Token: 0x040000E0 RID: 224
			private static Delegate cb_isRunning;

			// Token: 0x040000E1 RID: 225
			private static Delegate cb_getMoveDuration;

			// Token: 0x040000E2 RID: 226
			private static Delegate cb_setMoveDuration_J;

			// Token: 0x040000E3 RID: 227
			private static Delegate cb_getRemoveDuration;

			// Token: 0x040000E4 RID: 228
			private static Delegate cb_setRemoveDuration_J;

			// Token: 0x040000E5 RID: 229
			private static Delegate cb_animateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;

			// Token: 0x040000E6 RID: 230
			private static Delegate cb_animateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;

			// Token: 0x040000E7 RID: 231
			private static Delegate cb_animateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;

			// Token: 0x040000E8 RID: 232
			private static Delegate cb_animatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_;

			// Token: 0x040000E9 RID: 233
			private static Delegate cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000EA RID: 234
			private static Delegate cb_canReuseUpdatedViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_;

			// Token: 0x040000EB RID: 235
			private static Delegate cb_endAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000EC RID: 236
			private static Delegate cb_endAnimations;

			// Token: 0x040000ED RID: 237
			private static Delegate cb_obtainHolderInfo;

			// Token: 0x040000EE RID: 238
			private static Delegate cb_onAnimationFinished_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000EF RID: 239
			private static Delegate cb_onAnimationStarted_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000F0 RID: 240
			private static Delegate cb_recordPostLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040000F1 RID: 241
			private static Delegate cb_recordPreLayoutInformation_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILjava_util_List_;

			// Token: 0x040000F2 RID: 242
			private static Delegate cb_runPendingAnimations;

			// Token: 0x0200005F RID: 95
			[Register("androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener", "", "AndroidX.RecyclerView.Widget.RecyclerView/ItemAnimator/IItemAnimatorFinishedListenerInvoker")]
			public interface IItemAnimatorFinishedListener : IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x06000449 RID: 1097
				[Register("onAnimationsFinished", "()V", "GetOnAnimationsFinishedHandler:AndroidX.RecyclerView.Widget.RecyclerView/ItemAnimator/IItemAnimatorFinishedListenerInvoker, Xamarin.AndroidX.RecyclerView")]
				void OnAnimationsFinished();
			}

			// Token: 0x02000060 RID: 96
			[Register("androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener", DoNotGenerateAcw = true)]
			internal class IItemAnimatorFinishedListenerInvoker : Java.Lang.Object, RecyclerView.ItemAnimator.IItemAnimatorFinishedListener, IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x17000068 RID: 104
				// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000BC28 File Offset: 0x00009E28
				private static IntPtr java_class_ref
				{
					get
					{
						return RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000069 RID: 105
				// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000BC4C File Offset: 0x00009E4C
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker._members;
					}
				}

				// Token: 0x1700006A RID: 106
				// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000BC53 File Offset: 0x00009E53
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return this.class_ref;
					}
				}

				// Token: 0x1700006B RID: 107
				// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000BC5B File Offset: 0x00009E5B
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker._members.ManagedPeerType;
					}
				}

				// Token: 0x0600044E RID: 1102 RVA: 0x0000BC67 File Offset: 0x00009E67
				public static RecyclerView.ItemAnimator.IItemAnimatorFinishedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
				{
					return Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.IItemAnimatorFinishedListener>(handle, transfer);
				}

				// Token: 0x0600044F RID: 1103 RVA: 0x0000BC70 File Offset: 0x00009E70
				private static IntPtr Validate(IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf(handle, RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.java_class_ref))
					{
						throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.ItemAnimator.ItemAnimatorFinishedListener'.");
					}
					return handle;
				}

				// Token: 0x06000450 RID: 1104 RVA: 0x0000BC9B File Offset: 0x00009E9B
				protected override void Dispose(bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
					{
						JNIEnv.DeleteGlobalRef(this.class_ref);
					}
					this.class_ref = IntPtr.Zero;
					base.Dispose(disposing);
				}

				// Token: 0x06000451 RID: 1105 RVA: 0x0000BCCC File Offset: 0x00009ECC
				public IItemAnimatorFinishedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.Validate(handle), transfer)
				{
					IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
					this.class_ref = JNIEnv.NewGlobalRef(objectClass);
					JNIEnv.DeleteLocalRef(objectClass);
				}

				// Token: 0x06000452 RID: 1106 RVA: 0x0000BD04 File Offset: 0x00009F04
				private static Delegate GetOnAnimationsFinishedHandler()
				{
					if (RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.cb_onAnimationsFinished == null)
					{
						RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.cb_onAnimationsFinished = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.n_OnAnimationsFinished));
					}
					return RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker.cb_onAnimationsFinished;
				}

				// Token: 0x06000453 RID: 1107 RVA: 0x0000BD28 File Offset: 0x00009F28
				private static void n_OnAnimationsFinished(IntPtr jnienv, IntPtr native__this)
				{
					Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.IItemAnimatorFinishedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAnimationsFinished();
				}

				// Token: 0x06000454 RID: 1108 RVA: 0x0000BD37 File Offset: 0x00009F37
				public void OnAnimationsFinished()
				{
					if (this.id_onAnimationsFinished == IntPtr.Zero)
					{
						this.id_onAnimationsFinished = JNIEnv.GetMethodID(this.class_ref, "onAnimationsFinished", "()V");
					}
					JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationsFinished);
				}

				// Token: 0x040000F3 RID: 243
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemAnimatorFinishedListener", typeof(RecyclerView.ItemAnimator.IItemAnimatorFinishedListenerInvoker));

				// Token: 0x040000F4 RID: 244
				private IntPtr class_ref;

				// Token: 0x040000F5 RID: 245
				private static Delegate cb_onAnimationsFinished;

				// Token: 0x040000F6 RID: 246
				private IntPtr id_onAnimationsFinished;
			}

			// Token: 0x02000061 RID: 97
			[Register("androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo", DoNotGenerateAcw = true)]
			public class ItemHolderInfo : Java.Lang.Object
			{
				// Token: 0x1700006C RID: 108
				// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000BD92 File Offset: 0x00009F92
				// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000BDA9 File Offset: 0x00009FA9
				[Register("bottom")]
				public int Bottom
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.GetInt32Value("bottom.I", this);
					}
					set
					{
						RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.SetValue("bottom.I", this, value);
					}
				}

				// Token: 0x1700006D RID: 109
				// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000BDC1 File Offset: 0x00009FC1
				// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000BDD8 File Offset: 0x00009FD8
				[Register("changeFlags")]
				public int ChangeFlags
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.GetInt32Value("changeFlags.I", this);
					}
					set
					{
						RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.SetValue("changeFlags.I", this, value);
					}
				}

				// Token: 0x1700006E RID: 110
				// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000BDF0 File Offset: 0x00009FF0
				// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000BE07 File Offset: 0x0000A007
				[Register("left")]
				public int Left
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.GetInt32Value("left.I", this);
					}
					set
					{
						RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.SetValue("left.I", this, value);
					}
				}

				// Token: 0x1700006F RID: 111
				// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000BE1F File Offset: 0x0000A01F
				// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000BE36 File Offset: 0x0000A036
				[Register("right")]
				public int Right
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.GetInt32Value("right.I", this);
					}
					set
					{
						RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.SetValue("right.I", this, value);
					}
				}

				// Token: 0x17000070 RID: 112
				// (get) Token: 0x0600045E RID: 1118 RVA: 0x0000BE4E File Offset: 0x0000A04E
				// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000BE65 File Offset: 0x0000A065
				[Register("top")]
				public int Top
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.GetInt32Value("top.I", this);
					}
					set
					{
						RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceFields.SetValue("top.I", this, value);
					}
				}

				// Token: 0x17000071 RID: 113
				// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000BE80 File Offset: 0x0000A080
				internal static IntPtr class_ref
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000072 RID: 114
				// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members;
					}
				}

				// Token: 0x17000073 RID: 115
				// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000BEAC File Offset: 0x0000A0AC
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000074 RID: 116
				// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000BED0 File Offset: 0x0000A0D0
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.ItemAnimator.ItemHolderInfo._members.ManagedPeerType;
					}
				}

				// Token: 0x06000464 RID: 1124 RVA: 0x000026A8 File Offset: 0x000008A8
				protected ItemHolderInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x06000465 RID: 1125 RVA: 0x0000BEDC File Offset: 0x0000A0DC
				[Register(".ctor", "()V", "")]
				public ItemHolderInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					base.SetHandle(RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
				}

				// Token: 0x06000466 RID: 1126 RVA: 0x0000BF4A File Offset: 0x0000A14A
				private static Delegate GetSetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
				{
					if (RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
					{
						RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.ItemAnimator.ItemHolderInfo.n_SetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
					}
					return RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
				}

				// Token: 0x06000467 RID: 1127 RVA: 0x0000BF70 File Offset: 0x0000A170
				private static IntPtr n_SetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
				{
					RecyclerView.ItemAnimator.ItemHolderInfo @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle(@object.SetFrom(object2));
				}

				// Token: 0x06000468 RID: 1128 RVA: 0x0000BF98 File Offset: 0x0000A198
				[Register("setFrom", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", "GetSetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
				public unsafe virtual RecyclerView.ItemAnimator.ItemHolderInfo SetFrom(RecyclerView.ViewHolder holder)
				{
					RecyclerView.ItemAnimator.ItemHolderInfo @object;
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
						@object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("setFrom.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
						GC.KeepAlive(holder);
					}
					return @object;
				}

				// Token: 0x06000469 RID: 1129 RVA: 0x0000C00C File Offset: 0x0000A20C
				private static Delegate GetSetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler()
				{
					if (RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
					{
						RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(RecyclerView.ItemAnimator.ItemHolderInfo.n_SetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I));
					}
					return RecyclerView.ItemAnimator.ItemHolderInfo.cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
				}

				// Token: 0x0600046A RID: 1130 RVA: 0x0000C030 File Offset: 0x0000A230
				private static IntPtr n_SetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int flags)
				{
					RecyclerView.ItemAnimator.ItemHolderInfo @object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle(@object.SetFrom(object2, flags));
				}

				// Token: 0x0600046B RID: 1131 RVA: 0x0000C05C File Offset: 0x0000A25C
				[Register("setFrom", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", "GetSetFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
				public unsafe virtual RecyclerView.ItemAnimator.ItemHolderInfo SetFrom(RecyclerView.ViewHolder holder, int flags)
				{
					RecyclerView.ItemAnimator.ItemHolderInfo @object;
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
						ptr[1] = new JniArgumentValue(flags);
						@object = Java.Lang.Object.GetObject<RecyclerView.ItemAnimator.ItemHolderInfo>(RecyclerView.ItemAnimator.ItemHolderInfo._members.InstanceMethods.InvokeVirtualObjectMethod("setFrom.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
						GC.KeepAlive(holder);
					}
					return @object;
				}

				// Token: 0x040000F7 RID: 247
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo", typeof(RecyclerView.ItemAnimator.ItemHolderInfo));

				// Token: 0x040000F8 RID: 248
				private static Delegate cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

				// Token: 0x040000F9 RID: 249
				private static Delegate cb_setFrom_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}
		}

		// Token: 0x02000062 RID: 98
		[Register("androidx/recyclerview/widget/RecyclerView$ItemAnimator", DoNotGenerateAcw = true)]
		internal class ItemAnimatorInvoker : RecyclerView.ItemAnimator
		{
			// Token: 0x0600046D RID: 1133 RVA: 0x0000C0FF File Offset: 0x0000A2FF
			public ItemAnimatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000C109 File Offset: 0x0000A309
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ItemAnimatorInvoker._members;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000C110 File Offset: 0x0000A310
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ItemAnimatorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000C11C File Offset: 0x0000A31C
			public override bool IsRunning
			{
				[Register("isRunning", "()Z", "GetIsRunningHandler")]
				get
				{
					return RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isRunning.()Z", this, null);
				}
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x0000C138 File Offset: 0x0000A338
			[Register("animateAppearance", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateAppearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public unsafe override bool AnimateAppearance(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[1] = new JniArgumentValue((preLayoutInfo == null) ? IntPtr.Zero : preLayoutInfo.Handle);
					ptr[2] = new JniArgumentValue((postLayoutInfo == null) ? IntPtr.Zero : postLayoutInfo.Handle);
					result = RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("animateAppearance.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(preLayoutInfo);
					GC.KeepAlive(postLayoutInfo);
				}
				return result;
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
			[Register("animateChange", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateChange_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public unsafe override bool AnimateChange(RecyclerView.ViewHolder oldHolder, RecyclerView.ViewHolder newHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((oldHolder == null) ? IntPtr.Zero : oldHolder.Handle);
					ptr[1] = new JniArgumentValue((newHolder == null) ? IntPtr.Zero : newHolder.Handle);
					ptr[2] = new JniArgumentValue((preLayoutInfo == null) ? IntPtr.Zero : preLayoutInfo.Handle);
					ptr[3] = new JniArgumentValue((postLayoutInfo == null) ? IntPtr.Zero : postLayoutInfo.Handle);
					result = RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("animateChange.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(oldHolder);
					GC.KeepAlive(newHolder);
					GC.KeepAlive(preLayoutInfo);
					GC.KeepAlive(postLayoutInfo);
				}
				return result;
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
			[Register("animateDisappearance", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimateDisappearance_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public unsafe override bool AnimateDisappearance(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[1] = new JniArgumentValue((preLayoutInfo == null) ? IntPtr.Zero : preLayoutInfo.Handle);
					ptr[2] = new JniArgumentValue((postLayoutInfo == null) ? IntPtr.Zero : postLayoutInfo.Handle);
					result = RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("animateDisappearance.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(preLayoutInfo);
					GC.KeepAlive(postLayoutInfo);
				}
				return result;
			}

			// Token: 0x06000474 RID: 1140 RVA: 0x0000C390 File Offset: 0x0000A590
			[Register("animatePersistence", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", "GetAnimatePersistence_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Landroidx_recyclerview_widget_RecyclerView_ItemAnimator_ItemHolderInfo_Handler")]
			public unsafe override bool AnimatePersistence(RecyclerView.ViewHolder viewHolder, RecyclerView.ItemAnimator.ItemHolderInfo preLayoutInfo, RecyclerView.ItemAnimator.ItemHolderInfo postLayoutInfo)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[1] = new JniArgumentValue((preLayoutInfo == null) ? IntPtr.Zero : preLayoutInfo.Handle);
					ptr[2] = new JniArgumentValue((postLayoutInfo == null) ? IntPtr.Zero : postLayoutInfo.Handle);
					result = RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("animatePersistence.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;Landroidx/recyclerview/widget/RecyclerView$ItemAnimator$ItemHolderInfo;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(preLayoutInfo);
					GC.KeepAlive(postLayoutInfo);
				}
				return result;
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x0000C448 File Offset: 0x0000A648
			[Register("endAnimation", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetEndAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe override void EndAnimation(RecyclerView.ViewHolder item)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : item.Handle);
					RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("endAnimation.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(item);
				}
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x0000C4AC File Offset: 0x0000A6AC
			[Register("endAnimations", "()V", "GetEndAnimationsHandler")]
			public override void EndAnimations()
			{
				RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("endAnimations.()V", this, null);
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
			[Register("runPendingAnimations", "()V", "GetRunPendingAnimationsHandler")]
			public override void RunPendingAnimations()
			{
				RecyclerView.ItemAnimatorInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("runPendingAnimations.()V", this, null);
			}

			// Token: 0x040000FA RID: 250
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemAnimator", typeof(RecyclerView.ItemAnimatorInvoker));
		}

		// Token: 0x02000063 RID: 99
		[Register("androidx/recyclerview/widget/RecyclerView$ItemDecoration", DoNotGenerateAcw = true)]
		public abstract class ItemDecoration : Java.Lang.Object
		{
			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000479 RID: 1145 RVA: 0x0000C4FC File Offset: 0x0000A6FC
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.ItemDecoration._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x0000C520 File Offset: 0x0000A720
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ItemDecoration._members;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600047B RID: 1147 RVA: 0x0000C528 File Offset: 0x0000A728
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.ItemDecoration._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x0000C54C File Offset: 0x0000A74C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ItemDecoration._members.ManagedPeerType;
				}
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x000026A8 File Offset: 0x000008A8
			protected ItemDecoration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x0000C558 File Offset: 0x0000A758
			[Register(".ctor", "()V", "")]
			public ItemDecoration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.ItemDecoration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.ItemDecoration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x0000C5C6 File Offset: 0x0000A7C6
			private static Delegate GetGetItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(RecyclerView.ItemDecoration.n_GetItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x0000C5EC File Offset: 0x0000A7EC
			private static void n_GetItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_outRect, IntPtr native_view, IntPtr native_parent, IntPtr native_state)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outRect, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				RecyclerView object4 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object5 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.GetItemOffsets(object2, object3, object4, object5);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x0000C62C File Offset: 0x0000A82C
			[Register("getItemOffsets", "(Landroid/graphics/Rect;Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", "GetGetItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual void GetItemOffsets(Rect outRect, View view, RecyclerView parent, RecyclerView.State state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((outRect == null) ? IntPtr.Zero : outRect.Handle);
					ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[3] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("getItemOffsets.(Landroid/graphics/Rect;Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(outRect);
					GC.KeepAlive(view);
					GC.KeepAlive(parent);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x0000C710 File Offset: 0x0000A910
			private static Delegate GetGetItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(RecyclerView.ItemDecoration.n_GetItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.ItemDecoration.cb_getItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x0000C734 File Offset: 0x0000A934
			private static void n_GetItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_outRect, int itemPosition, IntPtr native_parent)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outRect, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				@object.GetItemOffsets(object2, itemPosition, object3);
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x0000C764 File Offset: 0x0000A964
			[Register("getItemOffsets", "(Landroid/graphics/Rect;ILandroidx/recyclerview/widget/RecyclerView;)V", "GetGetItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void GetItemOffsets(Rect outRect, int itemPosition, RecyclerView parent)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((outRect == null) ? IntPtr.Zero : outRect.Handle);
					ptr[1] = new JniArgumentValue(itemPosition);
					ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("getItemOffsets.(Landroid/graphics/Rect;ILandroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(outRect);
					GC.KeepAlive(parent);
				}
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x0000C808 File Offset: 0x0000AA08
			private static Delegate GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.ItemDecoration.n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x0000C82C File Offset: 0x0000AA2C
			private static void n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				@object.OnDraw(object2, object3);
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x0000C858 File Offset: 0x0000AA58
			[Register("onDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnDraw(Canvas c, RecyclerView parent)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(parent);
				}
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
			private static Delegate GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(RecyclerView.ItemDecoration.n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.ItemDecoration.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x0000C908 File Offset: 0x0000AB08
			private static void n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent, IntPtr native_state)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object4 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnDraw(object2, object3, object4);
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x0000C940 File Offset: 0x0000AB40
			[Register("onDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", "GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual void OnDraw(Canvas c, RecyclerView parent, RecyclerView.State state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(parent);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
			private static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.ItemDecoration.n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x0000CA1C File Offset: 0x0000AC1C
			private static void n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				@object.OnDrawOver(object2, object3);
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x0000CA48 File Offset: 0x0000AC48
			[Register("onDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnDrawOver(Canvas c, RecyclerView parent)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawOver.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(parent);
				}
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
			private static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(RecyclerView.ItemDecoration.n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.ItemDecoration.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			private static void n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_parent, IntPtr native_state)
			{
				RecyclerView.ItemDecoration @object = Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object4 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnDrawOver(object2, object3, object4);
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x0000CB30 File Offset: 0x0000AD30
			[Register("onDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", "GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual void OnDrawOver(Canvas c, RecyclerView parent, RecyclerView.State state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					RecyclerView.ItemDecoration._members.InstanceMethods.InvokeVirtualVoidMethod("onDrawOver.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(parent);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x040000FB RID: 251
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemDecoration", typeof(RecyclerView.ItemDecoration));

			// Token: 0x040000FC RID: 252
			private static Delegate cb_getItemOffsets_Landroid_graphics_Rect_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x040000FD RID: 253
			private static Delegate cb_getItemOffsets_Landroid_graphics_Rect_ILandroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x040000FE RID: 254
			private static Delegate cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x040000FF RID: 255
			private static Delegate cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000100 RID: 256
			private static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x04000101 RID: 257
			private static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_;
		}

		// Token: 0x02000064 RID: 100
		[Register("androidx/recyclerview/widget/RecyclerView$ItemDecoration", DoNotGenerateAcw = true)]
		internal class ItemDecorationInvoker : RecyclerView.ItemDecoration
		{
			// Token: 0x06000492 RID: 1170 RVA: 0x000030C4 File Offset: 0x000012C4
			public ItemDecorationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000CC03 File Offset: 0x0000AE03
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ItemDecorationInvoker._members;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000CC0A File Offset: 0x0000AE0A
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ItemDecorationInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x04000102 RID: 258
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ItemDecoration", typeof(RecyclerView.ItemDecorationInvoker));
		}

		// Token: 0x02000065 RID: 101
		[Register("androidx/recyclerview/widget/RecyclerView$LayoutManager", DoNotGenerateAcw = true)]
		public abstract class LayoutManager : Java.Lang.Object
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000CC34 File Offset: 0x0000AE34
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.LayoutManager._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000CC58 File Offset: 0x0000AE58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.LayoutManager._members;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000CC60 File Offset: 0x0000AE60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.LayoutManager._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000CC84 File Offset: 0x0000AE84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.LayoutManager._members.ManagedPeerType;
				}
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x000026A8 File Offset: 0x000008A8
			protected LayoutManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0000CC90 File Offset: 0x0000AE90
			[Register(".ctor", "()V", "")]
			public LayoutManager() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.LayoutManager._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.LayoutManager._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x0000CCFE File Offset: 0x0000AEFE
			private static Delegate GetIsAutoMeasureEnabledHandler()
			{
				if (RecyclerView.LayoutManager.cb_isAutoMeasureEnabled == null)
				{
					RecyclerView.LayoutManager.cb_isAutoMeasureEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_IsAutoMeasureEnabled));
				}
				return RecyclerView.LayoutManager.cb_isAutoMeasureEnabled;
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x0000CD22 File Offset: 0x0000AF22
			private static bool n_IsAutoMeasureEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoMeasureEnabled;
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x0000CD31 File Offset: 0x0000AF31
			private static Delegate GetSetAutoMeasureEnabled_ZHandler()
			{
				if (RecyclerView.LayoutManager.cb_setAutoMeasureEnabled_Z == null)
				{
					RecyclerView.LayoutManager.cb_setAutoMeasureEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.LayoutManager.n_SetAutoMeasureEnabled_Z));
				}
				return RecyclerView.LayoutManager.cb_setAutoMeasureEnabled_Z;
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x0000CD55 File Offset: 0x0000AF55
			private static void n_SetAutoMeasureEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoMeasureEnabled = enabled;
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000CD65 File Offset: 0x0000AF65
			// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0000CD80 File Offset: 0x0000AF80
			public unsafe virtual bool AutoMeasureEnabled
			{
				[Register("isAutoMeasureEnabled", "()Z", "GetIsAutoMeasureEnabledHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isAutoMeasureEnabled.()Z", this, null);
				}
				[Register("setAutoMeasureEnabled", "(Z)V", "GetSetAutoMeasureEnabled_ZHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setAutoMeasureEnabled.(Z)V", this, ptr);
				}
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x0000CDBB File Offset: 0x0000AFBB
			private static Delegate GetGetBaselineHandler()
			{
				if (RecyclerView.LayoutManager.cb_getBaseline == null)
				{
					RecyclerView.LayoutManager.cb_getBaseline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetBaseline));
				}
				return RecyclerView.LayoutManager.cb_getBaseline;
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x0000CDDF File Offset: 0x0000AFDF
			private static int n_GetBaseline(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Baseline;
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000CDEE File Offset: 0x0000AFEE
			public virtual int Baseline
			{
				[Register("getBaseline", "()I", "GetGetBaselineHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getBaseline.()I", this, null);
				}
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x0000CE07 File Offset: 0x0000B007
			private static Delegate GetGetChildCountHandler()
			{
				if (RecyclerView.LayoutManager.cb_getChildCount == null)
				{
					RecyclerView.LayoutManager.cb_getChildCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetChildCount));
				}
				return RecyclerView.LayoutManager.cb_getChildCount;
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x0000CE2B File Offset: 0x0000B02B
			private static int n_GetChildCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildCount;
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000CE3A File Offset: 0x0000B03A
			public virtual int ChildCount
			{
				[Register("getChildCount", "()I", "GetGetChildCountHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getChildCount.()I", this, null);
				}
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x0000CE53 File Offset: 0x0000B053
			private static Delegate GetGetClipToPaddingHandler()
			{
				if (RecyclerView.LayoutManager.cb_getClipToPadding == null)
				{
					RecyclerView.LayoutManager.cb_getClipToPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_GetClipToPadding));
				}
				return RecyclerView.LayoutManager.cb_getClipToPadding;
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x0000CE77 File Offset: 0x0000B077
			private static bool n_GetClipToPadding(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClipToPadding;
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000CE86 File Offset: 0x0000B086
			public virtual bool ClipToPadding
			{
				[Register("getClipToPadding", "()Z", "GetGetClipToPaddingHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("getClipToPadding.()Z", this, null);
				}
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x0000CE9F File Offset: 0x0000B09F
			private static Delegate GetGetFocusedChildHandler()
			{
				if (RecyclerView.LayoutManager.cb_getFocusedChild == null)
				{
					RecyclerView.LayoutManager.cb_getFocusedChild = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.LayoutManager.n_GetFocusedChild));
				}
				return RecyclerView.LayoutManager.cb_getFocusedChild;
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x0000CEC3 File Offset: 0x0000B0C3
			private static IntPtr n_GetFocusedChild(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FocusedChild);
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000CED8 File Offset: 0x0000B0D8
			public virtual View FocusedChild
			{
				[Register("getFocusedChild", "()Landroid/view/View;", "GetGetFocusedChildHandler")]
				get
				{
					return Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("getFocusedChild.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x0000CF0A File Offset: 0x0000B10A
			private static Delegate GetHasFocusHandler()
			{
				if (RecyclerView.LayoutManager.cb_hasFocus == null)
				{
					RecyclerView.LayoutManager.cb_hasFocus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_HasFocus));
				}
				return RecyclerView.LayoutManager.cb_hasFocus;
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x0000CF2E File Offset: 0x0000B12E
			private static bool n_HasFocus(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasFocus;
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0000CF3D File Offset: 0x0000B13D
			public virtual bool HasFocus
			{
				[Register("hasFocus", "()Z", "GetHasFocusHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("hasFocus.()Z", this, null);
				}
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x0000CF56 File Offset: 0x0000B156
			private static Delegate GetGetHeightHandler()
			{
				if (RecyclerView.LayoutManager.cb_getHeight == null)
				{
					RecyclerView.LayoutManager.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetHeight));
				}
				return RecyclerView.LayoutManager.cb_getHeight;
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x0000CF7A File Offset: 0x0000B17A
			private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000CF89 File Offset: 0x0000B189
			public virtual int Height
			{
				[Register("getHeight", "()I", "GetGetHeightHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
				}
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x0000CFA2 File Offset: 0x0000B1A2
			private static Delegate GetGetHeightModeHandler()
			{
				if (RecyclerView.LayoutManager.cb_getHeightMode == null)
				{
					RecyclerView.LayoutManager.cb_getHeightMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetHeightMode));
				}
				return RecyclerView.LayoutManager.cb_getHeightMode;
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x0000CFC6 File Offset: 0x0000B1C6
			private static int n_GetHeightMode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeightMode;
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000CFD5 File Offset: 0x0000B1D5
			public virtual int HeightMode
			{
				[Register("getHeightMode", "()I", "GetGetHeightModeHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getHeightMode.()I", this, null);
				}
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x0000CFEE File Offset: 0x0000B1EE
			private static Delegate GetIsAttachedToWindowHandler()
			{
				if (RecyclerView.LayoutManager.cb_isAttachedToWindow == null)
				{
					RecyclerView.LayoutManager.cb_isAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_IsAttachedToWindow));
				}
				return RecyclerView.LayoutManager.cb_isAttachedToWindow;
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0000D012 File Offset: 0x0000B212
			private static bool n_IsAttachedToWindow(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAttachedToWindow;
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000D021 File Offset: 0x0000B221
			public virtual bool IsAttachedToWindow
			{
				[Register("isAttachedToWindow", "()Z", "GetIsAttachedToWindowHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isAttachedToWindow.()Z", this, null);
				}
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x0000D03A File Offset: 0x0000B23A
			private static Delegate GetIsFocusedHandler()
			{
				if (RecyclerView.LayoutManager.cb_isFocused == null)
				{
					RecyclerView.LayoutManager.cb_isFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_IsFocused));
				}
				return RecyclerView.LayoutManager.cb_isFocused;
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x0000D05E File Offset: 0x0000B25E
			private static bool n_IsFocused(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFocused;
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000D06D File Offset: 0x0000B26D
			public virtual bool IsFocused
			{
				[Register("isFocused", "()Z", "GetIsFocusedHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isFocused.()Z", this, null);
				}
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x0000D086 File Offset: 0x0000B286
			private static Delegate GetIsSmoothScrollingHandler()
			{
				if (RecyclerView.LayoutManager.cb_isSmoothScrolling == null)
				{
					RecyclerView.LayoutManager.cb_isSmoothScrolling = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_IsSmoothScrolling));
				}
				return RecyclerView.LayoutManager.cb_isSmoothScrolling;
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x0000D0AA File Offset: 0x0000B2AA
			private static bool n_IsSmoothScrolling(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSmoothScrolling;
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000D0B9 File Offset: 0x0000B2B9
			public virtual bool IsSmoothScrolling
			{
				[Register("isSmoothScrolling", "()Z", "GetIsSmoothScrollingHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isSmoothScrolling.()Z", this, null);
				}
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x0000D0D2 File Offset: 0x0000B2D2
			private static Delegate GetGetItemCountHandler()
			{
				if (RecyclerView.LayoutManager.cb_getItemCount == null)
				{
					RecyclerView.LayoutManager.cb_getItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetItemCount));
				}
				return RecyclerView.LayoutManager.cb_getItemCount;
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x0000D0F6 File Offset: 0x0000B2F6
			private static int n_GetItemCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemCount;
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000D105 File Offset: 0x0000B305
			public virtual int ItemCount
			{
				[Register("getItemCount", "()I", "GetGetItemCountHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getItemCount.()I", this, null);
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0000D11E File Offset: 0x0000B31E
			// (set) Token: 0x060004C4 RID: 1220 RVA: 0x0000D138 File Offset: 0x0000B338
			public unsafe bool ItemPrefetchEnabled
			{
				[Register("isItemPrefetchEnabled", "()Z", "")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isItemPrefetchEnabled.()Z", this, null);
				}
				[Register("setItemPrefetchEnabled", "(Z)V", "")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeNonvirtualVoidMethod("setItemPrefetchEnabled.(Z)V", this, ptr);
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x0000D173 File Offset: 0x0000B373
			private static Delegate GetGetLayoutDirectionHandler()
			{
				if (RecyclerView.LayoutManager.cb_getLayoutDirection == null)
				{
					RecyclerView.LayoutManager.cb_getLayoutDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetLayoutDirection));
				}
				return RecyclerView.LayoutManager.cb_getLayoutDirection;
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x0000D197 File Offset: 0x0000B397
			private static int n_GetLayoutDirection(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutDirection;
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000D1A6 File Offset: 0x0000B3A6
			public virtual int LayoutDirection
			{
				[Register("getLayoutDirection", "()I", "GetGetLayoutDirectionHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getLayoutDirection.()I", this, null);
				}
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x0000D1BF File Offset: 0x0000B3BF
			private static Delegate GetIsMeasurementCacheEnabledHandler()
			{
				if (RecyclerView.LayoutManager.cb_isMeasurementCacheEnabled == null)
				{
					RecyclerView.LayoutManager.cb_isMeasurementCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_IsMeasurementCacheEnabled));
				}
				return RecyclerView.LayoutManager.cb_isMeasurementCacheEnabled;
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x0000D1E3 File Offset: 0x0000B3E3
			private static bool n_IsMeasurementCacheEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MeasurementCacheEnabled;
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x0000D1F2 File Offset: 0x0000B3F2
			private static Delegate GetSetMeasurementCacheEnabled_ZHandler()
			{
				if (RecyclerView.LayoutManager.cb_setMeasurementCacheEnabled_Z == null)
				{
					RecyclerView.LayoutManager.cb_setMeasurementCacheEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.LayoutManager.n_SetMeasurementCacheEnabled_Z));
				}
				return RecyclerView.LayoutManager.cb_setMeasurementCacheEnabled_Z;
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x0000D216 File Offset: 0x0000B416
			private static void n_SetMeasurementCacheEnabled_Z(IntPtr jnienv, IntPtr native__this, bool measurementCacheEnabled)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MeasurementCacheEnabled = measurementCacheEnabled;
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000D226 File Offset: 0x0000B426
			// (set) Token: 0x060004CD RID: 1229 RVA: 0x0000D240 File Offset: 0x0000B440
			public unsafe virtual bool MeasurementCacheEnabled
			{
				[Register("isMeasurementCacheEnabled", "()Z", "GetIsMeasurementCacheEnabledHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isMeasurementCacheEnabled.()Z", this, null);
				}
				[Register("setMeasurementCacheEnabled", "(Z)V", "GetSetMeasurementCacheEnabled_ZHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setMeasurementCacheEnabled.(Z)V", this, ptr);
				}
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x0000D27B File Offset: 0x0000B47B
			private static Delegate GetGetMinimumHeightHandler()
			{
				if (RecyclerView.LayoutManager.cb_getMinimumHeight == null)
				{
					RecyclerView.LayoutManager.cb_getMinimumHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetMinimumHeight));
				}
				return RecyclerView.LayoutManager.cb_getMinimumHeight;
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x0000D29F File Offset: 0x0000B49F
			private static int n_GetMinimumHeight(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinimumHeight;
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000D2AE File Offset: 0x0000B4AE
			public virtual int MinimumHeight
			{
				[Register("getMinimumHeight", "()I", "GetGetMinimumHeightHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getMinimumHeight.()I", this, null);
				}
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x0000D2C7 File Offset: 0x0000B4C7
			private static Delegate GetGetMinimumWidthHandler()
			{
				if (RecyclerView.LayoutManager.cb_getMinimumWidth == null)
				{
					RecyclerView.LayoutManager.cb_getMinimumWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetMinimumWidth));
				}
				return RecyclerView.LayoutManager.cb_getMinimumWidth;
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x0000D2EB File Offset: 0x0000B4EB
			private static int n_GetMinimumWidth(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinimumWidth;
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0000D2FA File Offset: 0x0000B4FA
			public virtual int MinimumWidth
			{
				[Register("getMinimumWidth", "()I", "GetGetMinimumWidthHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getMinimumWidth.()I", this, null);
				}
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x0000D313 File Offset: 0x0000B513
			private static Delegate GetGetPaddingBottomHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingBottom == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingBottom));
				}
				return RecyclerView.LayoutManager.cb_getPaddingBottom;
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x0000D337 File Offset: 0x0000B537
			private static int n_GetPaddingBottom(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingBottom;
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000D346 File Offset: 0x0000B546
			public virtual int PaddingBottom
			{
				[Register("getPaddingBottom", "()I", "GetGetPaddingBottomHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingBottom.()I", this, null);
				}
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x0000D35F File Offset: 0x0000B55F
			private static Delegate GetGetPaddingEndHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingEnd == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingEnd));
				}
				return RecyclerView.LayoutManager.cb_getPaddingEnd;
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x0000D383 File Offset: 0x0000B583
			private static int n_GetPaddingEnd(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingEnd;
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0000D392 File Offset: 0x0000B592
			public virtual int PaddingEnd
			{
				[Register("getPaddingEnd", "()I", "GetGetPaddingEndHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingEnd.()I", this, null);
				}
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x0000D3AB File Offset: 0x0000B5AB
			private static Delegate GetGetPaddingLeftHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingLeft == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingLeft));
				}
				return RecyclerView.LayoutManager.cb_getPaddingLeft;
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0000D3CF File Offset: 0x0000B5CF
			private static int n_GetPaddingLeft(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingLeft;
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000D3DE File Offset: 0x0000B5DE
			public virtual int PaddingLeft
			{
				[Register("getPaddingLeft", "()I", "GetGetPaddingLeftHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingLeft.()I", this, null);
				}
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
			private static Delegate GetGetPaddingRightHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingRight == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingRight));
				}
				return RecyclerView.LayoutManager.cb_getPaddingRight;
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x0000D41B File Offset: 0x0000B61B
			private static int n_GetPaddingRight(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingRight;
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000D42A File Offset: 0x0000B62A
			public virtual int PaddingRight
			{
				[Register("getPaddingRight", "()I", "GetGetPaddingRightHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingRight.()I", this, null);
				}
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x0000D443 File Offset: 0x0000B643
			private static Delegate GetGetPaddingStartHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingStart == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingStart));
				}
				return RecyclerView.LayoutManager.cb_getPaddingStart;
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x0000D467 File Offset: 0x0000B667
			private static int n_GetPaddingStart(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingStart;
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000D476 File Offset: 0x0000B676
			public virtual int PaddingStart
			{
				[Register("getPaddingStart", "()I", "GetGetPaddingStartHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingStart.()I", this, null);
				}
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x0000D48F File Offset: 0x0000B68F
			private static Delegate GetGetPaddingTopHandler()
			{
				if (RecyclerView.LayoutManager.cb_getPaddingTop == null)
				{
					RecyclerView.LayoutManager.cb_getPaddingTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetPaddingTop));
				}
				return RecyclerView.LayoutManager.cb_getPaddingTop;
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x0000D4B3 File Offset: 0x0000B6B3
			private static int n_GetPaddingTop(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PaddingTop;
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0000D4C2 File Offset: 0x0000B6C2
			public virtual int PaddingTop
			{
				[Register("getPaddingTop", "()I", "GetGetPaddingTopHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPaddingTop.()I", this, null);
				}
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0000D4DB File Offset: 0x0000B6DB
			private static Delegate GetGetWidthHandler()
			{
				if (RecyclerView.LayoutManager.cb_getWidth == null)
				{
					RecyclerView.LayoutManager.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetWidth));
				}
				return RecyclerView.LayoutManager.cb_getWidth;
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x0000D4FF File Offset: 0x0000B6FF
			private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000D50E File Offset: 0x0000B70E
			public virtual int Width
			{
				[Register("getWidth", "()I", "GetGetWidthHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
				}
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0000D527 File Offset: 0x0000B727
			private static Delegate GetGetWidthModeHandler()
			{
				if (RecyclerView.LayoutManager.cb_getWidthMode == null)
				{
					RecyclerView.LayoutManager.cb_getWidthMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutManager.n_GetWidthMode));
				}
				return RecyclerView.LayoutManager.cb_getWidthMode;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x0000D54B File Offset: 0x0000B74B
			private static int n_GetWidthMode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WidthMode;
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x0000D55A File Offset: 0x0000B75A
			public virtual int WidthMode
			{
				[Register("getWidthMode", "()I", "GetGetWidthModeHandler")]
				get
				{
					return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getWidthMode.()I", this, null);
				}
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0000D573 File Offset: 0x0000B773
			private static Delegate GetAddDisappearingView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_AddDisappearingView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_;
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0000D598 File Offset: 0x0000B798
			private static void n_AddDisappearingView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AddDisappearingView(object2);
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x0000D5BC File Offset: 0x0000B7BC
			[Register("addDisappearingView", "(Landroid/view/View;)V", "GetAddDisappearingView_Landroid_view_View_Handler")]
			public unsafe virtual void AddDisappearingView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("addDisappearingView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x0000D620 File Offset: 0x0000B820
			private static Delegate GetAddDisappearingView_Landroid_view_View_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_I == null)
				{
					RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.LayoutManager.n_AddDisappearingView_Landroid_view_View_I));
				}
				return RecyclerView.LayoutManager.cb_addDisappearingView_Landroid_view_View_I;
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x0000D644 File Offset: 0x0000B844
			private static void n_AddDisappearingView_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int index)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AddDisappearingView(object2, index);
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x0000D668 File Offset: 0x0000B868
			[Register("addDisappearingView", "(Landroid/view/View;I)V", "GetAddDisappearingView_Landroid_view_View_IHandler")]
			public unsafe virtual void AddDisappearingView(View child, int index)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(index);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("addDisappearingView.(Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
			private static Delegate GetAddView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_addView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_addView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_AddView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_addView_Landroid_view_View_;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0000D704 File Offset: 0x0000B904
			private static void n_AddView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AddView(object2);
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x0000D728 File Offset: 0x0000B928
			[Register("addView", "(Landroid/view/View;)V", "GetAddView_Landroid_view_View_Handler")]
			public unsafe virtual void AddView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("addView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x0000D78C File Offset: 0x0000B98C
			private static Delegate GetAddView_Landroid_view_View_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_addView_Landroid_view_View_I == null)
				{
					RecyclerView.LayoutManager.cb_addView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.LayoutManager.n_AddView_Landroid_view_View_I));
				}
				return RecyclerView.LayoutManager.cb_addView_Landroid_view_View_I;
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
			private static void n_AddView_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int index)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AddView(object2, index);
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
			[Register("addView", "(Landroid/view/View;I)V", "GetAddView_Landroid_view_View_IHandler")]
			public unsafe virtual void AddView(View child, int index)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(index);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("addView.(Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x0000D84C File Offset: 0x0000BA4C
			private static Delegate GetAssertInLayoutOrScroll_Ljava_lang_String_Handler()
			{
				if (RecyclerView.LayoutManager.cb_assertInLayoutOrScroll_Ljava_lang_String_ == null)
				{
					RecyclerView.LayoutManager.cb_assertInLayoutOrScroll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_AssertInLayoutOrScroll_Ljava_lang_String_));
				}
				return RecyclerView.LayoutManager.cb_assertInLayoutOrScroll_Ljava_lang_String_;
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x0000D870 File Offset: 0x0000BA70
			private static void n_AssertInLayoutOrScroll_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
				@object.AssertInLayoutOrScroll(@string);
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0000D894 File Offset: 0x0000BA94
			[Register("assertInLayoutOrScroll", "(Ljava/lang/String;)V", "GetAssertInLayoutOrScroll_Ljava_lang_String_Handler")]
			public unsafe virtual void AssertInLayoutOrScroll(string message)
			{
				IntPtr intPtr = JNIEnv.NewString(message);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("assertInLayoutOrScroll.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			private static Delegate GetAssertNotInLayoutOrScroll_Ljava_lang_String_Handler()
			{
				if (RecyclerView.LayoutManager.cb_assertNotInLayoutOrScroll_Ljava_lang_String_ == null)
				{
					RecyclerView.LayoutManager.cb_assertNotInLayoutOrScroll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_AssertNotInLayoutOrScroll_Ljava_lang_String_));
				}
				return RecyclerView.LayoutManager.cb_assertNotInLayoutOrScroll_Ljava_lang_String_;
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x0000D914 File Offset: 0x0000BB14
			private static void n_AssertNotInLayoutOrScroll_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
				@object.AssertNotInLayoutOrScroll(@string);
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x0000D938 File Offset: 0x0000BB38
			[Register("assertNotInLayoutOrScroll", "(Ljava/lang/String;)V", "GetAssertNotInLayoutOrScroll_Ljava_lang_String_Handler")]
			public unsafe virtual void AssertNotInLayoutOrScroll(string message)
			{
				IntPtr intPtr = JNIEnv.NewString(message);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("assertNotInLayoutOrScroll.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x0000D994 File Offset: 0x0000BB94
			private static Delegate GetAttachView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_AttachView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_;
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
			private static void n_AttachView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AttachView(object2);
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x0000D9DC File Offset: 0x0000BBDC
			[Register("attachView", "(Landroid/view/View;)V", "GetAttachView_Landroid_view_View_Handler")]
			public unsafe virtual void AttachView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("attachView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0000DA40 File Offset: 0x0000BC40
			private static Delegate GetAttachView_Landroid_view_View_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_I == null)
				{
					RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.LayoutManager.n_AttachView_Landroid_view_View_I));
				}
				return RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_I;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0000DA64 File Offset: 0x0000BC64
			private static void n_AttachView_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int index)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.AttachView(object2, index);
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x0000DA88 File Offset: 0x0000BC88
			[Register("attachView", "(Landroid/view/View;I)V", "GetAttachView_Landroid_view_View_IHandler")]
			public unsafe virtual void AttachView(View child, int index)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(index);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("attachView.(Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x0000DB00 File Offset: 0x0000BD00
			private static Delegate GetAttachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_Handler()
			{
				if (RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_ == null)
				{
					RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(RecyclerView.LayoutManager.n_AttachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_));
				}
				return RecyclerView.LayoutManager.cb_attachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_;
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0000DB24 File Offset: 0x0000BD24
			private static void n_AttachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int index, IntPtr native_lp)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				RecyclerView.LayoutParams object3 = Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(native_lp, JniHandleOwnership.DoNotTransfer);
				@object.AttachView(object2, index, object3);
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x0000DB54 File Offset: 0x0000BD54
			[Register("attachView", "(Landroid/view/View;ILandroidx/recyclerview/widget/RecyclerView$LayoutParams;)V", "GetAttachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_Handler")]
			public unsafe virtual void AttachView(View child, int index, RecyclerView.LayoutParams lp)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(index);
					ptr[2] = new JniArgumentValue((lp == null) ? IntPtr.Zero : lp.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("attachView.(Landroid/view/View;ILandroidx/recyclerview/widget/RecyclerView$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(lp);
				}
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
			private static Delegate GetCalculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_Handler()
			{
				if (RecyclerView.LayoutManager.cb_calculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_ == null)
				{
					RecyclerView.LayoutManager.cb_calculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_CalculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_));
				}
				return RecyclerView.LayoutManager.cb_calculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_;
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x0000DC1C File Offset: 0x0000BE1C
			private static void n_CalculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_outRect)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object3 = Java.Lang.Object.GetObject<Rect>(native_outRect, JniHandleOwnership.DoNotTransfer);
				@object.CalculateItemDecorationsForChild(object2, object3);
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x0000DC48 File Offset: 0x0000BE48
			[Register("calculateItemDecorationsForChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", "GetCalculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_Handler")]
			public unsafe virtual void CalculateItemDecorationsForChild(View child, Rect outRect)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue((outRect == null) ? IntPtr.Zero : outRect.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("calculateItemDecorationsForChild.(Landroid/view/View;Landroid/graphics/Rect;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(outRect);
				}
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x0000DCD4 File Offset: 0x0000BED4
			private static Delegate GetCanScrollHorizontallyHandler()
			{
				if (RecyclerView.LayoutManager.cb_canScrollHorizontally == null)
				{
					RecyclerView.LayoutManager.cb_canScrollHorizontally = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_CanScrollHorizontally));
				}
				return RecyclerView.LayoutManager.cb_canScrollHorizontally;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
			private static bool n_CanScrollHorizontally(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanScrollHorizontally();
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x0000DD07 File Offset: 0x0000BF07
			[Register("canScrollHorizontally", "()Z", "GetCanScrollHorizontallyHandler")]
			public virtual bool CanScrollHorizontally()
			{
				return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("canScrollHorizontally.()Z", this, null);
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x0000DD20 File Offset: 0x0000BF20
			private static Delegate GetCanScrollVerticallyHandler()
			{
				if (RecyclerView.LayoutManager.cb_canScrollVertically == null)
				{
					RecyclerView.LayoutManager.cb_canScrollVertically = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_CanScrollVertically));
				}
				return RecyclerView.LayoutManager.cb_canScrollVertically;
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x0000DD44 File Offset: 0x0000BF44
			private static bool n_CanScrollVertically(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanScrollVertically();
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x0000DD53 File Offset: 0x0000BF53
			[Register("canScrollVertically", "()Z", "GetCanScrollVerticallyHandler")]
			public virtual bool CanScrollVertically()
			{
				return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("canScrollVertically.()Z", this, null);
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x0000DD6C File Offset: 0x0000BF6C
			private static Delegate GetCheckLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_Handler()
			{
				if (RecyclerView.LayoutManager.cb_checkLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_ == null)
				{
					RecyclerView.LayoutManager.cb_checkLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RecyclerView.LayoutManager.n_CheckLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_));
				}
				return RecyclerView.LayoutManager.cb_checkLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_;
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x0000DD90 File Offset: 0x0000BF90
			private static bool n_CheckLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_lp)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.LayoutParams object2 = Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(native_lp, JniHandleOwnership.DoNotTransfer);
				return @object.CheckLayoutParams(object2);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
			[Register("checkLayoutParams", "(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)Z", "GetCheckLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_Handler")]
			public unsafe virtual bool CheckLayoutParams(RecyclerView.LayoutParams lp)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((lp == null) ? IntPtr.Zero : lp.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("checkLayoutParams.(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(lp);
				}
				return result;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x0000DE1C File Offset: 0x0000C01C
			[Register("chooseSize", "(III)I", "")]
			public unsafe static int ChooseSize(int spec, int desired, int min)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(spec);
				ptr[1] = new JniArgumentValue(desired);
				ptr[2] = new JniArgumentValue(min);
				return RecyclerView.LayoutManager._members.StaticMethods.InvokeInt32Method("chooseSize.(III)I", ptr);
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x0000DE7F File Offset: 0x0000C07F
			private static Delegate GetCollectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_Handler()
			{
				if (RecyclerView.LayoutManager.cb_collectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_ == null)
				{
					RecyclerView.LayoutManager.cb_collectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_V(RecyclerView.LayoutManager.n_CollectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_));
				}
				return RecyclerView.LayoutManager.cb_collectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_;
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
			private static void n_CollectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_state, IntPtr native_layoutPrefetchRegistry)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				RecyclerView.LayoutManager.ILayoutPrefetchRegistry object3 = Java.Lang.Object.GetObject<RecyclerView.LayoutManager.ILayoutPrefetchRegistry>(native_layoutPrefetchRegistry, JniHandleOwnership.DoNotTransfer);
				@object.CollectAdjacentPrefetchPositions(dx, dy, object2, object3);
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x0000DED4 File Offset: 0x0000C0D4
			[Register("collectAdjacentPrefetchPositions", "(IILandroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry;)V", "GetCollectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_Handler")]
			public unsafe virtual void CollectAdjacentPrefetchPositions(int dx, int dy, RecyclerView.State state, RecyclerView.LayoutManager.ILayoutPrefetchRegistry layoutPrefetchRegistry)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(dx);
					ptr[1] = new JniArgumentValue(dy);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[3] = new JniArgumentValue((layoutPrefetchRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)layoutPrefetchRegistry).Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("collectAdjacentPrefetchPositions.(IILandroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
					GC.KeepAlive(layoutPrefetchRegistry);
				}
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x0000DF94 File Offset: 0x0000C194
			private static Delegate GetCollectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_Handler()
			{
				if (RecyclerView.LayoutManager.cb_collectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_ == null)
				{
					RecyclerView.LayoutManager.cb_collectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(RecyclerView.LayoutManager.n_CollectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_));
				}
				return RecyclerView.LayoutManager.cb_collectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_;
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
			private static void n_CollectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_(IntPtr jnienv, IntPtr native__this, int adapterItemCount, IntPtr native_layoutPrefetchRegistry)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.LayoutManager.ILayoutPrefetchRegistry object2 = Java.Lang.Object.GetObject<RecyclerView.LayoutManager.ILayoutPrefetchRegistry>(native_layoutPrefetchRegistry, JniHandleOwnership.DoNotTransfer);
				@object.CollectInitialPrefetchPositions(adapterItemCount, object2);
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x0000DFDC File Offset: 0x0000C1DC
			[Register("collectInitialPrefetchPositions", "(ILandroidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry;)V", "GetCollectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_Handler")]
			public unsafe virtual void CollectInitialPrefetchPositions(int adapterItemCount, RecyclerView.LayoutManager.ILayoutPrefetchRegistry layoutPrefetchRegistry)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(adapterItemCount);
					ptr[1] = new JniArgumentValue((layoutPrefetchRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)layoutPrefetchRegistry).Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("collectInitialPrefetchPositions.(ILandroidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(layoutPrefetchRegistry);
				}
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x0000E058 File Offset: 0x0000C258
			private static Delegate GetComputeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x0000E07C File Offset: 0x0000C27C
			private static int n_ComputeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeHorizontalScrollExtent(object2);
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
			[Register("computeHorizontalScrollExtent", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeHorizontalScrollExtent(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollExtent.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x0000E108 File Offset: 0x0000C308
			private static Delegate GetComputeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x0000E12C File Offset: 0x0000C32C
			private static int n_ComputeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeHorizontalScrollOffset(object2);
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x0000E150 File Offset: 0x0000C350
			[Register("computeHorizontalScrollOffset", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeHorizontalScrollOffset(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollOffset.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
			private static Delegate GetComputeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x0000E1DC File Offset: 0x0000C3DC
			private static int n_ComputeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeHorizontalScrollRange(object2);
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x0000E200 File Offset: 0x0000C400
			[Register("computeHorizontalScrollRange", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeHorizontalScrollRange(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollRange.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x0000E268 File Offset: 0x0000C468
			private static Delegate GetComputeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x0000E28C File Offset: 0x0000C48C
			private static int n_ComputeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeVerticalScrollExtent(object2);
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
			[Register("computeVerticalScrollExtent", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeVerticalScrollExtent(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollExtent.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x0000E318 File Offset: 0x0000C518
			private static Delegate GetComputeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x0000E33C File Offset: 0x0000C53C
			private static int n_ComputeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeVerticalScrollOffset(object2);
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x0000E360 File Offset: 0x0000C560
			[Register("computeVerticalScrollOffset", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeVerticalScrollOffset(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollOffset.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
			private static Delegate GetComputeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_computeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_computeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_ComputeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_computeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x0000E3EC File Offset: 0x0000C5EC
			private static int n_ComputeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ComputeVerticalScrollRange(object2);
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x0000E410 File Offset: 0x0000C610
			[Register("computeVerticalScrollRange", "(Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetComputeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ComputeVerticalScrollRange(RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollRange.(Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x0000E478 File Offset: 0x0000C678
			private static Delegate GetDetachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_detachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_detachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_DetachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_detachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x0000E49C File Offset: 0x0000C69C
			private static void n_DetachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.DetachAndScrapAttachedViews(object2);
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
			[Register("detachAndScrapAttachedViews", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetDetachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void DetachAndScrapAttachedViews(RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("detachAndScrapAttachedViews.(Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000E524 File Offset: 0x0000C724
			private static Delegate GetDetachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_detachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_detachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_DetachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_detachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x0000E548 File Offset: 0x0000C748
			private static void n_DetachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object3 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.DetachAndScrapView(object2, object3);
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x0000E574 File Offset: 0x0000C774
			[Register("detachAndScrapView", "(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetDetachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void DetachAndScrapView(View child, RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("detachAndScrapView.(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x0000E600 File Offset: 0x0000C800
			private static Delegate GetDetachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_detachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_detachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(RecyclerView.LayoutManager.n_DetachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_detachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x0000E624 File Offset: 0x0000C824
			private static void n_DetachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.DetachAndScrapViewAt(index, object2);
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x0000E648 File Offset: 0x0000C848
			[Register("detachAndScrapViewAt", "(ILandroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetDetachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void DetachAndScrapViewAt(int index, RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(index);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("detachAndScrapViewAt.(ILandroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
			private static Delegate GetDetachView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_detachView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_detachView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_DetachView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_detachView_Landroid_view_View_;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
			private static void n_DetachView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.DetachView(object2);
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x0000E708 File Offset: 0x0000C908
			[Register("detachView", "(Landroid/view/View;)V", "GetDetachView_Landroid_view_View_Handler")]
			public unsafe virtual void DetachView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("detachView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x0000E76C File Offset: 0x0000C96C
			private static Delegate GetDetachViewAt_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_detachViewAt_I == null)
				{
					RecyclerView.LayoutManager.cb_detachViewAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_DetachViewAt_I));
				}
				return RecyclerView.LayoutManager.cb_detachViewAt_I;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x0000E790 File Offset: 0x0000C990
			private static void n_DetachViewAt_I(IntPtr jnienv, IntPtr native__this, int index)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DetachViewAt(index);
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
			[Register("detachViewAt", "(I)V", "GetDetachViewAt_IHandler")]
			public unsafe virtual void DetachViewAt(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("detachViewAt.(I)V", this, ptr);
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x0000E7DB File Offset: 0x0000C9DB
			private static Delegate GetEndAnimation_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_endAnimation_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_endAnimation_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_EndAnimation_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_endAnimation_Landroid_view_View_;
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x0000E800 File Offset: 0x0000CA00
			private static void n_EndAnimation_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.EndAnimation(object2);
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x0000E824 File Offset: 0x0000CA24
			[Register("endAnimation", "(Landroid/view/View;)V", "GetEndAnimation_Landroid_view_View_Handler")]
			public unsafe virtual void EndAnimation(View view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("endAnimation.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x0000E888 File Offset: 0x0000CA88
			private static Delegate GetFindContainingItemView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_findContainingItemView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_findContainingItemView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.LayoutManager.n_FindContainingItemView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_findContainingItemView_Landroid_view_View_;
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x0000E8AC File Offset: 0x0000CAAC
			private static IntPtr n_FindContainingItemView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.FindContainingItemView(object2));
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
			[Register("findContainingItemView", "(Landroid/view/View;)Landroid/view/View;", "GetFindContainingItemView_Landroid_view_View_Handler")]
			public unsafe virtual View FindContainingItemView(View view)
			{
				View @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					@object = Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("findContainingItemView.(Landroid/view/View;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0000E948 File Offset: 0x0000CB48
			private static Delegate GetFindViewByPosition_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_findViewByPosition_I == null)
				{
					RecyclerView.LayoutManager.cb_findViewByPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.LayoutManager.n_FindViewByPosition_I));
				}
				return RecyclerView.LayoutManager.cb_findViewByPosition_I;
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x0000E96C File Offset: 0x0000CB6C
			private static IntPtr n_FindViewByPosition_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewByPosition(position));
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0000E984 File Offset: 0x0000CB84
			[Register("findViewByPosition", "(I)Landroid/view/View;", "GetFindViewByPosition_IHandler")]
			public unsafe virtual View FindViewByPosition(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("findViewByPosition.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x0000E9CD File Offset: 0x0000CBCD
			private static Delegate GetGenerateDefaultLayoutParamsHandler()
			{
				if (RecyclerView.LayoutManager.cb_generateDefaultLayoutParams == null)
				{
					RecyclerView.LayoutManager.cb_generateDefaultLayoutParams = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.LayoutManager.n_GenerateDefaultLayoutParams));
				}
				return RecyclerView.LayoutManager.cb_generateDefaultLayoutParams;
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x0000E9F1 File Offset: 0x0000CBF1
			private static IntPtr n_GenerateDefaultLayoutParams(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GenerateDefaultLayoutParams());
			}

			// Token: 0x06000546 RID: 1350
			[Register("generateDefaultLayoutParams", "()Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", "GetGenerateDefaultLayoutParamsHandler")]
			public abstract RecyclerView.LayoutParams GenerateDefaultLayoutParams();

			// Token: 0x06000547 RID: 1351 RVA: 0x0000EA05 File Offset: 0x0000CC05
			private static Delegate GetGenerateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
			{
				if (RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				{
					RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(RecyclerView.LayoutManager.n_GenerateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_));
				}
				return RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_;
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x0000EA2C File Offset: 0x0000CC2C
			private static IntPtr n_GenerateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_attrs)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Context object2 = Java.Lang.Object.GetObject<Context>(native_c, JniHandleOwnership.DoNotTransfer);
				IAttributeSet object3 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.GenerateLayoutParams(object2, object3));
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x0000EA60 File Offset: 0x0000CC60
			[Register("generateLayoutParams", "(Landroid/content/Context;Landroid/util/AttributeSet;)Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", "GetGenerateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
			public unsafe virtual RecyclerView.LayoutParams GenerateLayoutParams(Context c, IAttributeSet attrs)
			{
				RecyclerView.LayoutParams @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					@object = Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("generateLayoutParams.(Landroid/content/Context;Landroid/util/AttributeSet;)Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
				return @object;
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x0000EB00 File Offset: 0x0000CD00
			private static Delegate GetGenerateLayoutParams_Landroid_view_ViewGroup_LayoutParams_Handler()
			{
				if (RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_view_ViewGroup_LayoutParams_ == null)
				{
					RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RecyclerView.LayoutManager.n_GenerateLayoutParams_Landroid_view_ViewGroup_LayoutParams_));
				}
				return RecyclerView.LayoutManager.cb_generateLayoutParams_Landroid_view_ViewGroup_LayoutParams_;
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0000EB24 File Offset: 0x0000CD24
			private static IntPtr n_GenerateLayoutParams_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_lp)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ViewGroup.LayoutParams object2 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native_lp, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.GenerateLayoutParams(object2));
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x0000EB4C File Offset: 0x0000CD4C
			[Register("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", "GetGenerateLayoutParams_Landroid_view_ViewGroup_LayoutParams_Handler")]
			public unsafe virtual RecyclerView.LayoutParams GenerateLayoutParams(ViewGroup.LayoutParams lp)
			{
				RecyclerView.LayoutParams @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((lp == null) ? IntPtr.Zero : lp.Handle);
					@object = Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("generateLayoutParams.(Landroid/view/ViewGroup$LayoutParams;)Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(lp);
				}
				return @object;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
			private static Delegate GetGetBottomDecorationHeight_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getBottomDecorationHeight_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getBottomDecorationHeight_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetBottomDecorationHeight_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getBottomDecorationHeight_Landroid_view_View_;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
			private static int n_GetBottomDecorationHeight_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetBottomDecorationHeight(object2);
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x0000EC08 File Offset: 0x0000CE08
			[Register("getBottomDecorationHeight", "(Landroid/view/View;)I", "GetGetBottomDecorationHeight_Landroid_view_View_Handler")]
			public unsafe virtual int GetBottomDecorationHeight(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getBottomDecorationHeight.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x0000EC70 File Offset: 0x0000CE70
			private static Delegate GetGetChildAt_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_getChildAt_I == null)
				{
					RecyclerView.LayoutManager.cb_getChildAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.LayoutManager.n_GetChildAt_I));
				}
				return RecyclerView.LayoutManager.cb_getChildAt_I;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x0000EC94 File Offset: 0x0000CE94
			private static IntPtr n_GetChildAt_I(IntPtr jnienv, IntPtr native__this, int index)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetChildAt(index));
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x0000ECAC File Offset: 0x0000CEAC
			[Register("getChildAt", "(I)Landroid/view/View;", "GetGetChildAt_IHandler")]
			public unsafe virtual View GetChildAt(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("getChildAt.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
			[Register("getChildMeasureSpec", "(IIIZ)I", "")]
			public unsafe static int GetChildMeasureSpec(int parentSize, int padding, int childDimension, bool canScroll)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(parentSize);
				ptr[1] = new JniArgumentValue(padding);
				ptr[2] = new JniArgumentValue(childDimension);
				ptr[3] = new JniArgumentValue(canScroll);
				return RecyclerView.LayoutManager._members.StaticMethods.InvokeInt32Method("getChildMeasureSpec.(IIIZ)I", ptr);
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x0000ED74 File Offset: 0x0000CF74
			[Register("getChildMeasureSpec", "(IIIIZ)I", "")]
			public unsafe static int GetChildMeasureSpec(int parentSize, int parentMode, int padding, int childDimension, bool canScroll)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(parentSize);
				ptr[1] = new JniArgumentValue(parentMode);
				ptr[2] = new JniArgumentValue(padding);
				ptr[3] = new JniArgumentValue(childDimension);
				ptr[4] = new JniArgumentValue(canScroll);
				return RecyclerView.LayoutManager._members.StaticMethods.InvokeInt32Method("getChildMeasureSpec.(IIIIZ)I", ptr);
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x0000EE04 File Offset: 0x0000D004
			private static Delegate GetGetColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_getColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(RecyclerView.LayoutManager.n_GetColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_getColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0000EE28 File Offset: 0x0000D028
			private static int n_GetColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.GetColumnCountForAccessibility(object2, object3);
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x0000EE54 File Offset: 0x0000D054
			[Register("getColumnCountForAccessibility", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetGetColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int GetColumnCountForAccessibility(RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getColumnCountForAccessibility.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
			private static Delegate GetGetDecoratedBottom_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedBottom_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedBottom_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedBottom_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedBottom_Landroid_view_View_;
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0000EF08 File Offset: 0x0000D108
			private static int n_GetDecoratedBottom_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedBottom(object2);
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x0000EF2C File Offset: 0x0000D12C
			[Register("getDecoratedBottom", "(Landroid/view/View;)I", "GetGetDecoratedBottom_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedBottom(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedBottom.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x0000EF94 File Offset: 0x0000D194
			private static Delegate GetGetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_GetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_;
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
			private static void n_GetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_outBounds)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				Rect object3 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
				@object.GetDecoratedBoundsWithMargins(object2, object3);
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x0000EFE4 File Offset: 0x0000D1E4
			[Register("getDecoratedBoundsWithMargins", "(Landroid/view/View;Landroid/graphics/Rect;)V", "GetGetDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_Handler")]
			public unsafe virtual void GetDecoratedBoundsWithMargins(View view, Rect outBounds)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("getDecoratedBoundsWithMargins.(Landroid/view/View;Landroid/graphics/Rect;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
					GC.KeepAlive(outBounds);
				}
			}

			// Token: 0x0600055E RID: 1374 RVA: 0x0000F070 File Offset: 0x0000D270
			private static Delegate GetGetDecoratedLeft_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedLeft_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedLeft_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedLeft_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedLeft_Landroid_view_View_;
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x0000F094 File Offset: 0x0000D294
			private static int n_GetDecoratedLeft_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedLeft(object2);
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
			[Register("getDecoratedLeft", "(Landroid/view/View;)I", "GetGetDecoratedLeft_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedLeft(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedLeft.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x0000F120 File Offset: 0x0000D320
			private static Delegate GetGetDecoratedMeasuredHeight_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedMeasuredHeight_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedMeasuredHeight_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedMeasuredHeight_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedMeasuredHeight_Landroid_view_View_;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0000F144 File Offset: 0x0000D344
			private static int n_GetDecoratedMeasuredHeight_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedMeasuredHeight(object2);
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0000F168 File Offset: 0x0000D368
			[Register("getDecoratedMeasuredHeight", "(Landroid/view/View;)I", "GetGetDecoratedMeasuredHeight_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedMeasuredHeight(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedMeasuredHeight.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
			private static Delegate GetGetDecoratedMeasuredWidth_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedMeasuredWidth_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedMeasuredWidth_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedMeasuredWidth_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedMeasuredWidth_Landroid_view_View_;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
			private static int n_GetDecoratedMeasuredWidth_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedMeasuredWidth(object2);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0000F218 File Offset: 0x0000D418
			[Register("getDecoratedMeasuredWidth", "(Landroid/view/View;)I", "GetGetDecoratedMeasuredWidth_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedMeasuredWidth(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedMeasuredWidth.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x0000F280 File Offset: 0x0000D480
			private static Delegate GetGetDecoratedRight_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedRight_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedRight_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedRight_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedRight_Landroid_view_View_;
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
			private static int n_GetDecoratedRight_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedRight(object2);
			}

			// Token: 0x06000569 RID: 1385 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
			[Register("getDecoratedRight", "(Landroid/view/View;)I", "GetGetDecoratedRight_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedRight(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedRight.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x0000F330 File Offset: 0x0000D530
			private static Delegate GetGetDecoratedTop_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getDecoratedTop_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getDecoratedTop_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetDecoratedTop_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getDecoratedTop_Landroid_view_View_;
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x0000F354 File Offset: 0x0000D554
			private static int n_GetDecoratedTop_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetDecoratedTop(object2);
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x0000F378 File Offset: 0x0000D578
			[Register("getDecoratedTop", "(Landroid/view/View;)I", "GetGetDecoratedTop_Landroid_view_View_Handler")]
			public unsafe virtual int GetDecoratedTop(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getDecoratedTop.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
			private static Delegate GetGetItemViewType_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getItemViewType_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getItemViewType_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetItemViewType_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getItemViewType_Landroid_view_View_;
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x0000F404 File Offset: 0x0000D604
			private static int n_GetItemViewType_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return @object.GetItemViewType(object2);
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x0000F428 File Offset: 0x0000D628
			[Register("getItemViewType", "(Landroid/view/View;)I", "GetGetItemViewType_Landroid_view_View_Handler")]
			public unsafe virtual int GetItemViewType(View view)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getItemViewType.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return result;
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x0000F490 File Offset: 0x0000D690
			private static Delegate GetGetLeftDecorationWidth_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getLeftDecorationWidth_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getLeftDecorationWidth_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetLeftDecorationWidth_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getLeftDecorationWidth_Landroid_view_View_;
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
			private static int n_GetLeftDecorationWidth_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetLeftDecorationWidth(object2);
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
			[Register("getLeftDecorationWidth", "(Landroid/view/View;)I", "GetGetLeftDecorationWidth_Landroid_view_View_Handler")]
			public unsafe virtual int GetLeftDecorationWidth(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getLeftDecorationWidth.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x0000F540 File Offset: 0x0000D740
			private static Delegate GetGetPosition_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getPosition_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getPosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetPosition_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getPosition_Landroid_view_View_;
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x0000F564 File Offset: 0x0000D764
			private static int n_GetPosition_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return @object.GetPosition(object2);
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x0000F588 File Offset: 0x0000D788
			[Register("getPosition", "(Landroid/view/View;)I", "GetGetPosition_Landroid_view_View_Handler")]
			public unsafe virtual int GetPosition(View view)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getPosition.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return result;
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
			[Register("getProperties", "(Landroid/content/Context;Landroid/util/AttributeSet;II)Landroidx/recyclerview/widget/RecyclerView$LayoutManager$Properties;", "")]
			public unsafe static RecyclerView.LayoutManager.Properties GetProperties(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			{
				RecyclerView.LayoutManager.Properties @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					ptr[2] = new JniArgumentValue(defStyleAttr);
					ptr[3] = new JniArgumentValue(defStyleRes);
					@object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager.Properties>(RecyclerView.LayoutManager._members.StaticMethods.InvokeObjectMethod("getProperties.(Landroid/content/Context;Landroid/util/AttributeSet;II)Landroidx/recyclerview/widget/RecyclerView$LayoutManager$Properties;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(context);
					GC.KeepAlive(attrs);
				}
				return @object;
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x0000F6BC File Offset: 0x0000D8BC
			private static Delegate GetGetRightDecorationWidth_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getRightDecorationWidth_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getRightDecorationWidth_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetRightDecorationWidth_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getRightDecorationWidth_Landroid_view_View_;
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
			private static int n_GetRightDecorationWidth_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetRightDecorationWidth(object2);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x0000F704 File Offset: 0x0000D904
			[Register("getRightDecorationWidth", "(Landroid/view/View;)I", "GetGetRightDecorationWidth_Landroid_view_View_Handler")]
			public unsafe virtual int GetRightDecorationWidth(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getRightDecorationWidth.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x0000F76C File Offset: 0x0000D96C
			private static Delegate GetGetRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_getRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(RecyclerView.LayoutManager.n_GetRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_getRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x0000F790 File Offset: 0x0000D990
			private static int n_GetRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.GetRowCountForAccessibility(object2, object3);
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0000F7BC File Offset: 0x0000D9BC
			[Register("getRowCountForAccessibility", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetGetRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int GetRowCountForAccessibility(RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getRowCountForAccessibility.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x0000F84C File Offset: 0x0000DA4C
			private static Delegate GetGetSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_getSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(RecyclerView.LayoutManager.n_GetSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_getSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x0000F870 File Offset: 0x0000DA70
			private static int n_GetSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.GetSelectionModeForAccessibility(object2, object3);
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x0000F89C File Offset: 0x0000DA9C
			[Register("getSelectionModeForAccessibility", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetGetSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int GetSelectionModeForAccessibility(RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getSelectionModeForAccessibility.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x0000F92C File Offset: 0x0000DB2C
			private static Delegate GetGetTopDecorationHeight_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getTopDecorationHeight_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_getTopDecorationHeight_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.LayoutManager.n_GetTopDecorationHeight_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_getTopDecorationHeight_Landroid_view_View_;
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x0000F950 File Offset: 0x0000DB50
			private static int n_GetTopDecorationHeight_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetTopDecorationHeight(object2);
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x0000F974 File Offset: 0x0000DB74
			[Register("getTopDecorationHeight", "(Landroid/view/View;)I", "GetGetTopDecorationHeight_Landroid_view_View_Handler")]
			public unsafe virtual int GetTopDecorationHeight(View child)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("getTopDecorationHeight.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x0000F9DC File Offset: 0x0000DBDC
			private static Delegate GetGetTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_Handler()
			{
				if (RecyclerView.LayoutManager.cb_getTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_ == null)
				{
					RecyclerView.LayoutManager.cb_getTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZL_V(RecyclerView.LayoutManager.n_GetTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_));
				}
				return RecyclerView.LayoutManager.cb_getTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_;
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x0000FA00 File Offset: 0x0000DC00
			private static void n_GetTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, bool includeDecorInsets, IntPtr native__out)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object3 = Java.Lang.Object.GetObject<Rect>(native__out, JniHandleOwnership.DoNotTransfer);
				@object.GetTransformedBoundingBox(object2, includeDecorInsets, object3);
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x0000FA30 File Offset: 0x0000DC30
			[Register("getTransformedBoundingBox", "(Landroid/view/View;ZLandroid/graphics/Rect;)V", "GetGetTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_Handler")]
			public unsafe virtual void GetTransformedBoundingBox(View child, bool includeDecorInsets, Rect @out)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(includeDecorInsets);
					ptr[2] = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("getTransformedBoundingBox.(Landroid/view/View;ZLandroid/graphics/Rect;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(@out);
				}
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
			private static Delegate GetIgnoreView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_ignoreView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_ignoreView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_IgnoreView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_ignoreView_Landroid_view_View_;
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
			private static void n_IgnoreView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.IgnoreView(object2);
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x0000FB1C File Offset: 0x0000DD1C
			[Register("ignoreView", "(Landroid/view/View;)V", "GetIgnoreView_Landroid_view_View_Handler")]
			public unsafe virtual void IgnoreView(View view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("ignoreView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x0000FB80 File Offset: 0x0000DD80
			private static Delegate GetIsLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_isLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_isLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(RecyclerView.LayoutManager.n_IsLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_isLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
			private static bool n_IsLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.IsLayoutHierarchical(object2, object3);
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
			[Register("isLayoutHierarchical", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)Z", "GetIsLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual bool IsLayoutHierarchical(RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutHierarchical.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x0000FC60 File Offset: 0x0000DE60
			private static Delegate GetIsViewPartiallyVisible_Landroid_view_View_ZZHandler()
			{
				if (RecyclerView.LayoutManager.cb_isViewPartiallyVisible_Landroid_view_View_ZZ == null)
				{
					RecyclerView.LayoutManager.cb_isViewPartiallyVisible_Landroid_view_View_ZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZZ_Z(RecyclerView.LayoutManager.n_IsViewPartiallyVisible_Landroid_view_View_ZZ));
				}
				return RecyclerView.LayoutManager.cb_isViewPartiallyVisible_Landroid_view_View_ZZ;
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x0000FC84 File Offset: 0x0000DE84
			private static bool n_IsViewPartiallyVisible_Landroid_view_View_ZZ(IntPtr jnienv, IntPtr native__this, IntPtr native_child, bool completelyVisible, bool acceptEndPointInclusion)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.IsViewPartiallyVisible(object2, completelyVisible, acceptEndPointInclusion);
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x0000FCAC File Offset: 0x0000DEAC
			[Register("isViewPartiallyVisible", "(Landroid/view/View;ZZ)Z", "GetIsViewPartiallyVisible_Landroid_view_View_ZZHandler")]
			public unsafe virtual bool IsViewPartiallyVisible(View child, bool completelyVisible, bool acceptEndPointInclusion)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(completelyVisible);
					ptr[2] = new JniArgumentValue(acceptEndPointInclusion);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isViewPartiallyVisible.(Landroid/view/View;ZZ)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x0000FD3C File Offset: 0x0000DF3C
			private static Delegate GetLayoutDecorated_Landroid_view_View_IIIIHandler()
			{
				if (RecyclerView.LayoutManager.cb_layoutDecorated_Landroid_view_View_IIII == null)
				{
					RecyclerView.LayoutManager.cb_layoutDecorated_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(RecyclerView.LayoutManager.n_LayoutDecorated_Landroid_view_View_IIII));
				}
				return RecyclerView.LayoutManager.cb_layoutDecorated_Landroid_view_View_IIII;
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x0000FD60 File Offset: 0x0000DF60
			private static void n_LayoutDecorated_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int left, int top, int right, int bottom)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.LayoutDecorated(object2, left, top, right, bottom);
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x0000FD8C File Offset: 0x0000DF8C
			[Register("layoutDecorated", "(Landroid/view/View;IIII)V", "GetLayoutDecorated_Landroid_view_View_IIIIHandler")]
			public unsafe virtual void LayoutDecorated(View child, int left, int top, int right, int bottom)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(left);
					ptr[2] = new JniArgumentValue(top);
					ptr[3] = new JniArgumentValue(right);
					ptr[4] = new JniArgumentValue(bottom);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("layoutDecorated.(Landroid/view/View;IIII)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x0000FE48 File Offset: 0x0000E048
			private static Delegate GetLayoutDecoratedWithMargins_Landroid_view_View_IIIIHandler()
			{
				if (RecyclerView.LayoutManager.cb_layoutDecoratedWithMargins_Landroid_view_View_IIII == null)
				{
					RecyclerView.LayoutManager.cb_layoutDecoratedWithMargins_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(RecyclerView.LayoutManager.n_LayoutDecoratedWithMargins_Landroid_view_View_IIII));
				}
				return RecyclerView.LayoutManager.cb_layoutDecoratedWithMargins_Landroid_view_View_IIII;
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x0000FE6C File Offset: 0x0000E06C
			private static void n_LayoutDecoratedWithMargins_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int left, int top, int right, int bottom)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.LayoutDecoratedWithMargins(object2, left, top, right, bottom);
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x0000FE98 File Offset: 0x0000E098
			[Register("layoutDecoratedWithMargins", "(Landroid/view/View;IIII)V", "GetLayoutDecoratedWithMargins_Landroid_view_View_IIIIHandler")]
			public unsafe virtual void LayoutDecoratedWithMargins(View child, int left, int top, int right, int bottom)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(left);
					ptr[2] = new JniArgumentValue(top);
					ptr[3] = new JniArgumentValue(right);
					ptr[4] = new JniArgumentValue(bottom);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("layoutDecoratedWithMargins.(Landroid/view/View;IIII)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x0000FF54 File Offset: 0x0000E154
			private static Delegate GetMeasureChild_Landroid_view_View_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_measureChild_Landroid_view_View_II == null)
				{
					RecyclerView.LayoutManager.cb_measureChild_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_MeasureChild_Landroid_view_View_II));
				}
				return RecyclerView.LayoutManager.cb_measureChild_Landroid_view_View_II;
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x0000FF78 File Offset: 0x0000E178
			private static void n_MeasureChild_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int widthUsed, int heightUsed)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.MeasureChild(object2, widthUsed, heightUsed);
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
			[Register("measureChild", "(Landroid/view/View;II)V", "GetMeasureChild_Landroid_view_View_IIHandler")]
			public unsafe virtual void MeasureChild(View child, int widthUsed, int heightUsed)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(widthUsed);
					ptr[2] = new JniArgumentValue(heightUsed);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("measureChild.(Landroid/view/View;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x0001002C File Offset: 0x0000E22C
			private static Delegate GetMeasureChildWithMargins_Landroid_view_View_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_measureChildWithMargins_Landroid_view_View_II == null)
				{
					RecyclerView.LayoutManager.cb_measureChildWithMargins_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_MeasureChildWithMargins_Landroid_view_View_II));
				}
				return RecyclerView.LayoutManager.cb_measureChildWithMargins_Landroid_view_View_II;
			}

			// Token: 0x06000599 RID: 1433 RVA: 0x00010050 File Offset: 0x0000E250
			private static void n_MeasureChildWithMargins_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int widthUsed, int heightUsed)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.MeasureChildWithMargins(object2, widthUsed, heightUsed);
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x00010078 File Offset: 0x0000E278
			[Register("measureChildWithMargins", "(Landroid/view/View;II)V", "GetMeasureChildWithMargins_Landroid_view_View_IIHandler")]
			public unsafe virtual void MeasureChildWithMargins(View child, int widthUsed, int heightUsed)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue(widthUsed);
					ptr[2] = new JniArgumentValue(heightUsed);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("measureChildWithMargins.(Landroid/view/View;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x00010104 File Offset: 0x0000E304
			private static Delegate GetMoveView_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_moveView_II == null)
				{
					RecyclerView.LayoutManager.cb_moveView_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.LayoutManager.n_MoveView_II));
				}
				return RecyclerView.LayoutManager.cb_moveView_II;
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x00010128 File Offset: 0x0000E328
			private static void n_MoveView_II(IntPtr jnienv, IntPtr native__this, int fromIndex, int toIndex)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MoveView(fromIndex, toIndex);
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x0001013C File Offset: 0x0000E33C
			[Register("moveView", "(II)V", "GetMoveView_IIHandler")]
			public unsafe virtual void MoveView(int fromIndex, int toIndex)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(fromIndex);
				ptr[1] = new JniArgumentValue(toIndex);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("moveView.(II)V", this, ptr);
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x0001018A File Offset: 0x0000E38A
			private static Delegate GetOffsetChildrenHorizontal_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_offsetChildrenHorizontal_I == null)
				{
					RecyclerView.LayoutManager.cb_offsetChildrenHorizontal_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_OffsetChildrenHorizontal_I));
				}
				return RecyclerView.LayoutManager.cb_offsetChildrenHorizontal_I;
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x000101AE File Offset: 0x0000E3AE
			private static void n_OffsetChildrenHorizontal_I(IntPtr jnienv, IntPtr native__this, int dx)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffsetChildrenHorizontal(dx);
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x000101C0 File Offset: 0x0000E3C0
			[Register("offsetChildrenHorizontal", "(I)V", "GetOffsetChildrenHorizontal_IHandler")]
			public unsafe virtual void OffsetChildrenHorizontal(int dx)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dx);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("offsetChildrenHorizontal.(I)V", this, ptr);
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x000101FB File Offset: 0x0000E3FB
			private static Delegate GetOffsetChildrenVertical_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_offsetChildrenVertical_I == null)
				{
					RecyclerView.LayoutManager.cb_offsetChildrenVertical_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_OffsetChildrenVertical_I));
				}
				return RecyclerView.LayoutManager.cb_offsetChildrenVertical_I;
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x0001021F File Offset: 0x0000E41F
			private static void n_OffsetChildrenVertical_I(IntPtr jnienv, IntPtr native__this, int dy)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffsetChildrenVertical(dy);
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x00010230 File Offset: 0x0000E430
			[Register("offsetChildrenVertical", "(I)V", "GetOffsetChildrenVertical_IHandler")]
			public unsafe virtual void OffsetChildrenVertical(int dy)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dy);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("offsetChildrenVertical.(I)V", this, ptr);
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x0001026B File Offset: 0x0000E46B
			private static Delegate GetOnAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ == null)
				{
					RecyclerView.LayoutManager.cb_onAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_OnAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_));
				}
				return RecyclerView.LayoutManager.cb_onAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_;
			}

			// Token: 0x060005A5 RID: 1445 RVA: 0x00010290 File Offset: 0x0000E490
			private static void n_OnAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_oldAdapter, IntPtr native_newAdapter)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Adapter object2 = Java.Lang.Object.GetObject<RecyclerView.Adapter>(native_oldAdapter, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Adapter object3 = Java.Lang.Object.GetObject<RecyclerView.Adapter>(native_newAdapter, JniHandleOwnership.DoNotTransfer);
				@object.OnAdapterChanged(object2, object3);
			}

			// Token: 0x060005A6 RID: 1446 RVA: 0x000102BC File Offset: 0x0000E4BC
			[Register("onAdapterChanged", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", "GetOnAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_Handler")]
			public unsafe virtual void OnAdapterChanged(RecyclerView.Adapter oldAdapter, RecyclerView.Adapter newAdapter)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((oldAdapter == null) ? IntPtr.Zero : oldAdapter.Handle);
					ptr[1] = new JniArgumentValue((newAdapter == null) ? IntPtr.Zero : newAdapter.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onAdapterChanged.(Landroidx/recyclerview/widget/RecyclerView$Adapter;Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(oldAdapter);
					GC.KeepAlive(newAdapter);
				}
			}

			// Token: 0x060005A7 RID: 1447 RVA: 0x00010348 File Offset: 0x0000E548
			private static Delegate GetOnAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II == null)
				{
					RecyclerView.LayoutManager.cb_onAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_Z(RecyclerView.LayoutManager.n_OnAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II));
				}
				return RecyclerView.LayoutManager.cb_onAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II;
			}

			// Token: 0x060005A8 RID: 1448 RVA: 0x0001036C File Offset: 0x0000E56C
			private static bool n_OnAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_views, int direction, int focusableMode)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
				return @object.OnAddFocusables(object2, views, direction, focusableMode);
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x0001039C File Offset: 0x0000E59C
			[Register("onAddFocusables", "(Landroidx/recyclerview/widget/RecyclerView;Ljava/util/ArrayList;II)Z", "GetOnAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_IIHandler")]
			public unsafe virtual bool OnAddFocusables(RecyclerView recyclerView, IList<View> views, int direction, int focusableMode)
			{
				IntPtr intPtr = JavaList<View>.ToLocalJniHandle(views);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue(direction);
					ptr[3] = new JniArgumentValue(focusableMode);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("onAddFocusables.(Landroidx/recyclerview/widget/RecyclerView;Ljava/util/ArrayList;II)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(views);
				}
				return result;
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x00010454 File Offset: 0x0000E654
			private static Delegate GetOnAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.LayoutManager.cb_onAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.LayoutManager.cb_onAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00010478 File Offset: 0x0000E678
			private static void n_OnAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnAttachedToWindow(object2);
			}

			// Token: 0x060005AC RID: 1452 RVA: 0x0001049C File Offset: 0x0000E69C
			[Register("onAttachedToWindow", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnAttachedToWindow(RecyclerView view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x060005AD RID: 1453 RVA: 0x00010500 File Offset: 0x0000E700
			private static Delegate GetOnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x060005AE RID: 1454 RVA: 0x00010524 File Offset: 0x0000E724
			private static void n_OnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnDetachedFromWindow(object2);
			}

			// Token: 0x060005AF RID: 1455 RVA: 0x00010548 File Offset: 0x0000E748
			[Register("onDetachedFromWindow", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnDetachedFromWindow(RecyclerView view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x060005B0 RID: 1456 RVA: 0x000105AC File Offset: 0x0000E7AC
			private static Delegate GetOnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_OnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x000105D0 File Offset: 0x0000E7D0
			private static void n_OnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_view, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object3 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.OnDetachedFromWindow(object2, object3);
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x000105FC File Offset: 0x0000E7FC
			[Register("onDetachedFromWindow", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetOnDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void OnDetachedFromWindow(RecyclerView view, RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x00010688 File Offset: 0x0000E888
			private static Delegate GetOnFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_onFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILL_L(RecyclerView.LayoutManager.n_OnFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_onFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x000106AC File Offset: 0x0000E8AC
			private static IntPtr n_OnFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_focused, int direction, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object3 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object4 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnFocusSearchFailed(object2, direction, object3, object4));
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x000106EC File Offset: 0x0000E8EC
			[Register("onFocusSearchFailed", "(Landroid/view/View;ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)Landroid/view/View;", "GetOnFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual View OnFocusSearchFailed(View focused, int direction, RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				View @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
					ptr[1] = new JniArgumentValue(direction);
					ptr[2] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[3] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					@object = Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("onFocusSearchFailed.(Landroid/view/View;ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(focused);
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return @object;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x000107CC File Offset: 0x0000E9CC
			private static Delegate GetOnInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
				{
					RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_));
				}
				return RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x000107F0 File Offset: 0x0000E9F0
			private static void n_OnInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				@object.OnInitializeAccessibilityEvent(object2);
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x00010814 File Offset: 0x0000EA14
			[Register("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", "GetOnInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler")]
			public unsafe virtual void OnInitializeAccessibilityEvent(AccessibilityEvent e)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityEvent.(Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(e);
				}
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00010878 File Offset: 0x0000EA78
			private static Delegate GetOnInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_ == null)
				{
					RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(RecyclerView.LayoutManager.n_OnInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_));
				}
				return RecyclerView.LayoutManager.cb_onInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_;
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x0001089C File Offset: 0x0000EA9C
			private static void n_OnInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, IntPtr native_e)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				AccessibilityEvent object4 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				@object.OnInitializeAccessibilityEvent(object2, object3, object4);
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x000108D4 File Offset: 0x0000EAD4
			[Register("onInitializeAccessibilityEvent", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/accessibility/AccessibilityEvent;)V", "GetOnInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_Handler")]
			public unsafe virtual void OnInitializeAccessibilityEvent(RecyclerView.Recycler recycler, RecyclerView.State state, AccessibilityEvent e)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityEvent.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
					GC.KeepAlive(e);
				}
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x0001098C File Offset: 0x0000EB8C
			private static Delegate GetOnInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ == null)
				{
					RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(RecyclerView.LayoutManager.n_OnInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_));
				}
				return RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x000109B0 File Offset: 0x0000EBB0
			private static void n_OnInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, IntPtr native_info)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				AccessibilityNodeInfoCompat object4 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(native_info, JniHandleOwnership.DoNotTransfer);
				@object.OnInitializeAccessibilityNodeInfo(object2, object3, object4);
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x000109E8 File Offset: 0x0000EBE8
			[Register("onInitializeAccessibilityNodeInfo", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", "GetOnInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler")]
			public unsafe virtual void OnInitializeAccessibilityNodeInfo(RecyclerView.Recycler recycler, RecyclerView.State state, AccessibilityNodeInfoCompat info)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityNodeInfo.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
					GC.KeepAlive(info);
				}
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x00010AA0 File Offset: 0x0000ECA0
			private static Delegate GetOnInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ == null)
				{
					RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(RecyclerView.LayoutManager.n_OnInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_));
				}
				return RecyclerView.LayoutManager.cb_onInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x00010AC4 File Offset: 0x0000ECC4
			private static void n_OnInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, IntPtr native_host, IntPtr native_info)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
				AccessibilityNodeInfoCompat object5 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(native_info, JniHandleOwnership.DoNotTransfer);
				@object.OnInitializeAccessibilityNodeInfoForItem(object2, object3, object4, object5);
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x00010B04 File Offset: 0x0000ED04
			[Register("onInitializeAccessibilityNodeInfoForItem", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", "GetOnInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler")]
			public unsafe virtual void OnInitializeAccessibilityNodeInfoForItem(RecyclerView.Recycler recycler, RecyclerView.State state, View host, AccessibilityNodeInfoCompat info)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
					ptr[3] = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityNodeInfoForItem.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
					GC.KeepAlive(host);
					GC.KeepAlive(info);
				}
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00010BE8 File Offset: 0x0000EDE8
			private static Delegate GetOnInterceptFocusSearch_Landroid_view_View_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_onInterceptFocusSearch_Landroid_view_View_I == null)
				{
					RecyclerView.LayoutManager.cb_onInterceptFocusSearch_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(RecyclerView.LayoutManager.n_OnInterceptFocusSearch_Landroid_view_View_I));
				}
				return RecyclerView.LayoutManager.cb_onInterceptFocusSearch_Landroid_view_View_I;
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x00010C0C File Offset: 0x0000EE0C
			private static IntPtr n_OnInterceptFocusSearch_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_focused, int direction)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnInterceptFocusSearch(object2, direction));
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x00010C38 File Offset: 0x0000EE38
			[Register("onInterceptFocusSearch", "(Landroid/view/View;I)Landroid/view/View;", "GetOnInterceptFocusSearch_Landroid_view_View_IHandler")]
			public unsafe virtual View OnInterceptFocusSearch(View focused, int direction)
			{
				View @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
					ptr[1] = new JniArgumentValue(direction);
					@object = Java.Lang.Object.GetObject<View>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("onInterceptFocusSearch.(Landroid/view/View;I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(focused);
				}
				return @object;
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x00010CC0 File Offset: 0x0000EEC0
			private static Delegate GetOnItemsAdded_Landroidx_recyclerview_widget_RecyclerView_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II == null)
				{
					RecyclerView.LayoutManager.cb_onItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_OnItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II));
				}
				return RecyclerView.LayoutManager.cb_onItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II;
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x00010CE4 File Offset: 0x0000EEE4
			private static void n_OnItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int positionStart, int itemCount)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsAdded(object2, positionStart, itemCount);
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x00010D0C File Offset: 0x0000EF0C
			[Register("onItemsAdded", "(Landroidx/recyclerview/widget/RecyclerView;II)V", "GetOnItemsAdded_Landroidx_recyclerview_widget_RecyclerView_IIHandler")]
			public unsafe virtual void OnItemsAdded(RecyclerView recyclerView, int positionStart, int itemCount)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(positionStart);
					ptr[2] = new JniArgumentValue(itemCount);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsAdded.(Landroidx/recyclerview/widget/RecyclerView;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x00010D98 File Offset: 0x0000EF98
			private static Delegate GetOnItemsChanged_Landroidx_recyclerview_widget_RecyclerView_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsChanged_Landroidx_recyclerview_widget_RecyclerView_ == null)
				{
					RecyclerView.LayoutManager.cb_onItemsChanged_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnItemsChanged_Landroidx_recyclerview_widget_RecyclerView_));
				}
				return RecyclerView.LayoutManager.cb_onItemsChanged_Landroidx_recyclerview_widget_RecyclerView_;
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x00010DBC File Offset: 0x0000EFBC
			private static void n_OnItemsChanged_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsChanged(object2);
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x00010DE0 File Offset: 0x0000EFE0
			[Register("onItemsChanged", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetOnItemsChanged_Landroidx_recyclerview_widget_RecyclerView_Handler")]
			public unsafe virtual void OnItemsChanged(RecyclerView recyclerView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsChanged.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00010E44 File Offset: 0x0000F044
			private static Delegate GetOnItemsMoved_Landroidx_recyclerview_widget_RecyclerView_IIIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III == null)
				{
					RecyclerView.LayoutManager.cb_onItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(RecyclerView.LayoutManager.n_OnItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III));
				}
				return RecyclerView.LayoutManager.cb_onItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x00010E68 File Offset: 0x0000F068
			private static void n_OnItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int from, int to, int itemCount)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsMoved(object2, from, to, itemCount);
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x00010E90 File Offset: 0x0000F090
			[Register("onItemsMoved", "(Landroidx/recyclerview/widget/RecyclerView;III)V", "GetOnItemsMoved_Landroidx_recyclerview_widget_RecyclerView_IIIHandler")]
			public unsafe virtual void OnItemsMoved(RecyclerView recyclerView, int from, int to, int itemCount)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(from);
					ptr[2] = new JniArgumentValue(to);
					ptr[3] = new JniArgumentValue(itemCount);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsMoved.(Landroidx/recyclerview/widget/RecyclerView;III)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x00010F34 File Offset: 0x0000F134
			private static Delegate GetOnItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II == null)
				{
					RecyclerView.LayoutManager.cb_onItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_OnItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II));
				}
				return RecyclerView.LayoutManager.cb_onItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II;
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x00010F58 File Offset: 0x0000F158
			private static void n_OnItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int positionStart, int itemCount)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsRemoved(object2, positionStart, itemCount);
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00010F80 File Offset: 0x0000F180
			[Register("onItemsRemoved", "(Landroidx/recyclerview/widget/RecyclerView;II)V", "GetOnItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_IIHandler")]
			public unsafe virtual void OnItemsRemoved(RecyclerView recyclerView, int positionStart, int itemCount)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(positionStart);
					ptr[2] = new JniArgumentValue(itemCount);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsRemoved.(Landroidx/recyclerview/widget/RecyclerView;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x0001100C File Offset: 0x0000F20C
			private static Delegate GetOnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II == null)
				{
					RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_OnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II));
				}
				return RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II;
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x00011030 File Offset: 0x0000F230
			private static void n_OnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int positionStart, int itemCount)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsUpdated(object2, positionStart, itemCount);
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00011058 File Offset: 0x0000F258
			[Register("onItemsUpdated", "(Landroidx/recyclerview/widget/RecyclerView;II)V", "GetOnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IIHandler")]
			public unsafe virtual void OnItemsUpdated(RecyclerView recyclerView, int positionStart, int itemCount)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(positionStart);
					ptr[2] = new JniArgumentValue(itemCount);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsUpdated.(Landroidx/recyclerview/widget/RecyclerView;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x000110E4 File Offset: 0x0000F2E4
			private static Delegate GetOnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_ == null)
				{
					RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(RecyclerView.LayoutManager.n_OnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_));
				}
				return RecyclerView.LayoutManager.cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_;
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00011108 File Offset: 0x0000F308
			private static void n_OnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int positionStart, int itemCount, IntPtr native_payload)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_payload, JniHandleOwnership.DoNotTransfer);
				@object.OnItemsUpdated(object2, positionStart, itemCount, object3);
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00011138 File Offset: 0x0000F338
			[Register("onItemsUpdated", "(Landroidx/recyclerview/widget/RecyclerView;IILjava/lang/Object;)V", "GetOnItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_Handler")]
			public unsafe virtual void OnItemsUpdated(RecyclerView recyclerView, int positionStart, int itemCount, Java.Lang.Object payload)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(positionStart);
					ptr[2] = new JniArgumentValue(itemCount);
					ptr[3] = new JniArgumentValue((payload == null) ? IntPtr.Zero : payload.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsUpdated.(Landroidx/recyclerview/widget/RecyclerView;IILjava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(payload);
				}
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x000111F4 File Offset: 0x0000F3F4
			private static Delegate GetOnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_onLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_OnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_onLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x00011218 File Offset: 0x0000F418
			private static void n_OnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnLayoutChildren(object2, object3);
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x00011244 File Offset: 0x0000F444
			[Register("onLayoutChildren", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)V", "GetOnLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual void OnLayoutChildren(RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onLayoutChildren.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x000112D0 File Offset: 0x0000F4D0
			private static Delegate GetOnLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_onLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_onLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x000112F4 File Offset: 0x0000F4F4
			private static void n_OnLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnLayoutCompleted(object2);
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x00011318 File Offset: 0x0000F518
			[Register("onLayoutCompleted", "(Landroidx/recyclerview/widget/RecyclerView$State;)V", "GetOnLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual void OnLayoutCompleted(RecyclerView.State state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onLayoutCompleted.(Landroidx/recyclerview/widget/RecyclerView$State;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x0001137C File Offset: 0x0000F57C
			private static Delegate GetOnMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_onMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II == null)
				{
					RecyclerView.LayoutManager.cb_onMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(RecyclerView.LayoutManager.n_OnMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II));
				}
				return RecyclerView.LayoutManager.cb_onMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II;
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x000113A0 File Offset: 0x0000F5A0
			private static void n_OnMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, int widthSpec, int heightSpec)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnMeasure(object2, object3, widthSpec, heightSpec);
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x000113D0 File Offset: 0x0000F5D0
			[Register("onMeasure", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;II)V", "GetOnMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_IIHandler")]
			public unsafe virtual void OnMeasure(RecyclerView.Recycler recycler, RecyclerView.State state, int widthSpec, int heightSpec)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue(widthSpec);
					ptr[3] = new JniArgumentValue(heightSpec);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasure.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00011488 File Offset: 0x0000F688
			private static Delegate GetOnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(RecyclerView.LayoutManager.n_OnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x000114AC File Offset: 0x0000F6AC
			private static bool n_OnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_focused)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
				return @object.OnRequestChildFocus(object2, object3, object4);
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x000114E4 File Offset: 0x0000F6E4
			[Register("onRequestChildFocus", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/view/View;)Z", "GetOnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual bool OnRequestChildFocus(RecyclerView parent, View child, View focused)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[2] = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("onRequestChildFocus.(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/view/View;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(focused);
				}
				return result;
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x0001159C File Offset: 0x0000F79C
			private static Delegate GetOnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_Z(RecyclerView.LayoutManager.n_OnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x000115C0 File Offset: 0x0000F7C0
			private static bool n_OnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_state, IntPtr native_child, IntPtr native_focused)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				View object5 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
				return @object.OnRequestChildFocus(object2, object3, object4, object5);
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x00011600 File Offset: 0x0000F800
			[Register("onRequestChildFocus", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;Landroid/view/View;)Z", "GetOnRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual bool OnRequestChildFocus(RecyclerView parent, RecyclerView.State state, View child, View focused)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[3] = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("onRequestChildFocus.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;Landroid/view/View;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(parent);
					GC.KeepAlive(state);
					GC.KeepAlive(child);
					GC.KeepAlive(focused);
				}
				return result;
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x000116E8 File Offset: 0x0000F8E8
			private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
			{
				if (RecyclerView.LayoutManager.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				{
					RecyclerView.LayoutManager.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
				}
				return RecyclerView.LayoutManager.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0001170C File Offset: 0x0000F90C
			private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnRestoreInstanceState(object2);
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00011730 File Offset: 0x0000F930
			[Register("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
			public unsafe virtual void OnRestoreInstanceState(IParcelable state)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00011798 File Offset: 0x0000F998
			private static Delegate GetOnSaveInstanceStateHandler()
			{
				if (RecyclerView.LayoutManager.cb_onSaveInstanceState == null)
				{
					RecyclerView.LayoutManager.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.LayoutManager.n_OnSaveInstanceState));
				}
				return RecyclerView.LayoutManager.cb_onSaveInstanceState;
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x000117BC File Offset: 0x0000F9BC
			private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x000117D0 File Offset: 0x0000F9D0
			[Register("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
			public virtual IParcelable OnSaveInstanceState()
			{
				return Java.Lang.Object.GetObject<IParcelable>(RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x00011802 File Offset: 0x0000FA02
			private static Delegate GetOnScrollStateChanged_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_onScrollStateChanged_I == null)
				{
					RecyclerView.LayoutManager.cb_onScrollStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_OnScrollStateChanged_I));
				}
				return RecyclerView.LayoutManager.cb_onScrollStateChanged_I;
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x00011826 File Offset: 0x0000FA26
			private static void n_OnScrollStateChanged_I(IntPtr jnienv, IntPtr native__this, int state)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnScrollStateChanged(state);
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x00011838 File Offset: 0x0000FA38
			[Register("onScrollStateChanged", "(I)V", "GetOnScrollStateChanged_IHandler")]
			public unsafe virtual void OnScrollStateChanged(int state)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(state);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("onScrollStateChanged.(I)V", this, ptr);
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00011873 File Offset: 0x0000FA73
			private static Delegate GetPerformAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_Handler()
			{
				if (RecyclerView.LayoutManager.cb_performAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_ == null)
				{
					RecyclerView.LayoutManager.cb_performAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_Z(RecyclerView.LayoutManager.n_PerformAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_));
				}
				return RecyclerView.LayoutManager.cb_performAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_;
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00011898 File Offset: 0x0000FA98
			private static bool n_PerformAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, int action, IntPtr native_args)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				Bundle object4 = Java.Lang.Object.GetObject<Bundle>(native_args, JniHandleOwnership.DoNotTransfer);
				return @object.PerformAccessibilityAction(object2, object3, action, object4);
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x000118D0 File Offset: 0x0000FAD0
			[Register("performAccessibilityAction", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;ILandroid/os/Bundle;)Z", "GetPerformAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_Handler")]
			public unsafe virtual bool PerformAccessibilityAction(RecyclerView.Recycler recycler, RecyclerView.State state, int action, Bundle args)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue(action);
					ptr[3] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("performAccessibilityAction.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;ILandroid/os/Bundle;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
					GC.KeepAlive(args);
				}
				return result;
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x000119A4 File Offset: 0x0000FBA4
			private static Delegate GetPerformAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_Handler()
			{
				if (RecyclerView.LayoutManager.cb_performAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_ == null)
				{
					RecyclerView.LayoutManager.cb_performAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIL_Z(RecyclerView.LayoutManager.n_PerformAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_));
				}
				return RecyclerView.LayoutManager.cb_performAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_;
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x000119C8 File Offset: 0x0000FBC8
			private static bool n_PerformAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, IntPtr native_state, IntPtr native_view, int action, IntPtr native_args)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				Bundle object5 = Java.Lang.Object.GetObject<Bundle>(native_args, JniHandleOwnership.DoNotTransfer);
				return @object.PerformAccessibilityActionForItem(object2, object3, object4, action, object5);
			}

			// Token: 0x060005F4 RID: 1524 RVA: 0x00011A0C File Offset: 0x0000FC0C
			[Register("performAccessibilityActionForItem", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;ILandroid/os/Bundle;)Z", "GetPerformAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_Handler")]
			public unsafe virtual bool PerformAccessibilityActionForItem(RecyclerView.Recycler recycler, RecyclerView.State state, View view, int action, Bundle args)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[3] = new JniArgumentValue(action);
					ptr[4] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("performAccessibilityActionForItem.(Landroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;Landroid/view/View;ILandroid/os/Bundle;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
					GC.KeepAlive(view);
					GC.KeepAlive(args);
				}
				return result;
			}

			// Token: 0x060005F5 RID: 1525 RVA: 0x00011B0C File Offset: 0x0000FD0C
			private static Delegate GetPostOnAnimation_Ljava_lang_Runnable_Handler()
			{
				if (RecyclerView.LayoutManager.cb_postOnAnimation_Ljava_lang_Runnable_ == null)
				{
					RecyclerView.LayoutManager.cb_postOnAnimation_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_PostOnAnimation_Ljava_lang_Runnable_));
				}
				return RecyclerView.LayoutManager.cb_postOnAnimation_Ljava_lang_Runnable_;
			}

			// Token: 0x060005F6 RID: 1526 RVA: 0x00011B30 File Offset: 0x0000FD30
			private static void n_PostOnAnimation_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
				@object.PostOnAnimation(object2);
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x00011B54 File Offset: 0x0000FD54
			[Register("postOnAnimation", "(Ljava/lang/Runnable;)V", "GetPostOnAnimation_Ljava_lang_Runnable_Handler")]
			public unsafe virtual void PostOnAnimation(IRunnable action)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("postOnAnimation.(Ljava/lang/Runnable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(action);
				}
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x00011BBC File Offset: 0x0000FDBC
			private static Delegate GetRemoveAllViewsHandler()
			{
				if (RecyclerView.LayoutManager.cb_removeAllViews == null)
				{
					RecyclerView.LayoutManager.cb_removeAllViews = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.LayoutManager.n_RemoveAllViews));
				}
				return RecyclerView.LayoutManager.cb_removeAllViews;
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x00011BE0 File Offset: 0x0000FDE0
			private static void n_RemoveAllViews(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllViews();
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x00011BEF File Offset: 0x0000FDEF
			[Register("removeAllViews", "()V", "GetRemoveAllViewsHandler")]
			public virtual void RemoveAllViews()
			{
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeAllViews.()V", this, null);
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x00011C08 File Offset: 0x0000FE08
			private static Delegate GetRemoveAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_removeAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_RemoveAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_removeAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00011C2C File Offset: 0x0000FE2C
			private static void n_RemoveAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.RemoveAndRecycleAllViews(object2);
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x00011C50 File Offset: 0x0000FE50
			[Register("removeAndRecycleAllViews", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetRemoveAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void RemoveAndRecycleAllViews(RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeAndRecycleAllViews.(Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x00011CB4 File Offset: 0x0000FEB4
			private static Delegate GetRemoveAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_removeAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.LayoutManager.n_RemoveAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_removeAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x00011CD8 File Offset: 0x0000FED8
			private static void n_RemoveAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object3 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.RemoveAndRecycleView(object2, object3);
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x00011D04 File Offset: 0x0000FF04
			[Register("removeAndRecycleView", "(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetRemoveAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void RemoveAndRecycleView(View child, RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeAndRecycleView.(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00011D90 File Offset: 0x0000FF90
			private static Delegate GetRemoveAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_ == null)
				{
					RecyclerView.LayoutManager.cb_removeAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(RecyclerView.LayoutManager.n_RemoveAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_));
				}
				return RecyclerView.LayoutManager.cb_removeAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_;
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x00011DB4 File Offset: 0x0000FFB4
			private static void n_RemoveAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_(IntPtr jnienv, IntPtr native__this, int index, IntPtr native_recycler)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				@object.RemoveAndRecycleViewAt(index, object2);
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x00011DD8 File Offset: 0x0000FFD8
			[Register("removeAndRecycleViewAt", "(ILandroidx/recyclerview/widget/RecyclerView$Recycler;)V", "GetRemoveAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Handler")]
			public unsafe virtual void RemoveAndRecycleViewAt(int index, RecyclerView.Recycler recycler)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(index);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeAndRecycleViewAt.(ILandroidx/recyclerview/widget/RecyclerView$Recycler;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
				}
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00011E50 File Offset: 0x00010050
			private static Delegate GetRemoveCallbacks_Ljava_lang_Runnable_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeCallbacks_Ljava_lang_Runnable_ == null)
				{
					RecyclerView.LayoutManager.cb_removeCallbacks_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RecyclerView.LayoutManager.n_RemoveCallbacks_Ljava_lang_Runnable_));
				}
				return RecyclerView.LayoutManager.cb_removeCallbacks_Ljava_lang_Runnable_;
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00011E74 File Offset: 0x00010074
			private static bool n_RemoveCallbacks_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
				return @object.RemoveCallbacks(object2);
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00011E98 File Offset: 0x00010098
			[Register("removeCallbacks", "(Ljava/lang/Runnable;)Z", "GetRemoveCallbacks_Ljava_lang_Runnable_Handler")]
			public unsafe virtual bool RemoveCallbacks(IRunnable action)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("removeCallbacks.(Ljava/lang/Runnable;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(action);
				}
				return result;
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x00011F04 File Offset: 0x00010104
			private static Delegate GetRemoveDetachedView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeDetachedView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_removeDetachedView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_RemoveDetachedView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_removeDetachedView_Landroid_view_View_;
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00011F28 File Offset: 0x00010128
			private static void n_RemoveDetachedView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.RemoveDetachedView(object2);
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x00011F4C File Offset: 0x0001014C
			[Register("removeDetachedView", "(Landroid/view/View;)V", "GetRemoveDetachedView_Landroid_view_View_Handler")]
			public unsafe virtual void RemoveDetachedView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeDetachedView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x00011FB0 File Offset: 0x000101B0
			private static Delegate GetRemoveView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_removeView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_removeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_RemoveView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_removeView_Landroid_view_View_;
			}

			// Token: 0x0600060B RID: 1547 RVA: 0x00011FD4 File Offset: 0x000101D4
			private static void n_RemoveView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.RemoveView(object2);
			}

			// Token: 0x0600060C RID: 1548 RVA: 0x00011FF8 File Offset: 0x000101F8
			[Register("removeView", "(Landroid/view/View;)V", "GetRemoveView_Landroid_view_View_Handler")]
			public unsafe virtual void RemoveView(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x0001205C File Offset: 0x0001025C
			private static Delegate GetRemoveViewAt_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_removeViewAt_I == null)
				{
					RecyclerView.LayoutManager.cb_removeViewAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_RemoveViewAt_I));
				}
				return RecyclerView.LayoutManager.cb_removeViewAt_I;
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x00012080 File Offset: 0x00010280
			private static void n_RemoveViewAt_I(IntPtr jnienv, IntPtr native__this, int index)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveViewAt(index);
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x00012090 File Offset: 0x00010290
			[Register("removeViewAt", "(I)V", "GetRemoveViewAt_IHandler")]
			public unsafe virtual void RemoveViewAt(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeViewAt.(I)V", this, ptr);
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x000120CB File Offset: 0x000102CB
			private static Delegate GetRequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZHandler()
			{
				if (RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z == null)
				{
					RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZ_Z(RecyclerView.LayoutManager.n_RequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z));
				}
				return RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z;
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x000120F0 File Offset: 0x000102F0
			private static bool n_RequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_rect, bool immediate)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object4 = Java.Lang.Object.GetObject<Rect>(native_rect, JniHandleOwnership.DoNotTransfer);
				return @object.RequestChildRectangleOnScreen(object2, object3, object4, immediate);
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00012128 File Offset: 0x00010328
			[Register("requestChildRectangleOnScreen", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/graphics/Rect;Z)Z", "GetRequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZHandler")]
			public unsafe virtual bool RequestChildRectangleOnScreen(RecyclerView parent, View child, Rect rect, bool immediate)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[2] = new JniArgumentValue((rect == null) ? IntPtr.Zero : rect.Handle);
					ptr[3] = new JniArgumentValue(immediate);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("requestChildRectangleOnScreen.(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/graphics/Rect;Z)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(rect);
				}
				return result;
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x000121F8 File Offset: 0x000103F8
			private static Delegate GetRequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZHandler()
			{
				if (RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ == null)
				{
					RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZZ_Z(RecyclerView.LayoutManager.n_RequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ));
				}
				return RecyclerView.LayoutManager.cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ;
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x0001221C File Offset: 0x0001041C
			private static bool n_RequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_rect, bool immediate, bool focusedChildVisible)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object4 = Java.Lang.Object.GetObject<Rect>(native_rect, JniHandleOwnership.DoNotTransfer);
				return @object.RequestChildRectangleOnScreen(object2, object3, object4, immediate, focusedChildVisible);
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x00012258 File Offset: 0x00010458
			[Register("requestChildRectangleOnScreen", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/graphics/Rect;ZZ)Z", "GetRequestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZHandler")]
			public unsafe virtual bool RequestChildRectangleOnScreen(RecyclerView parent, View child, Rect rect, bool immediate, bool focusedChildVisible)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[2] = new JniArgumentValue((rect == null) ? IntPtr.Zero : rect.Handle);
					ptr[3] = new JniArgumentValue(immediate);
					ptr[4] = new JniArgumentValue(focusedChildVisible);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("requestChildRectangleOnScreen.(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;Landroid/graphics/Rect;ZZ)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(rect);
				}
				return result;
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x00012340 File Offset: 0x00010540
			private static Delegate GetRequestLayoutHandler()
			{
				if (RecyclerView.LayoutManager.cb_requestLayout == null)
				{
					RecyclerView.LayoutManager.cb_requestLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.LayoutManager.n_RequestLayout));
				}
				return RecyclerView.LayoutManager.cb_requestLayout;
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00012364 File Offset: 0x00010564
			private static void n_RequestLayout(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestLayout();
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00012373 File Offset: 0x00010573
			[Register("requestLayout", "()V", "GetRequestLayoutHandler")]
			public virtual void RequestLayout()
			{
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("requestLayout.()V", this, null);
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x0001238C File Offset: 0x0001058C
			private static Delegate GetRequestSimpleAnimationsInNextLayoutHandler()
			{
				if (RecyclerView.LayoutManager.cb_requestSimpleAnimationsInNextLayout == null)
				{
					RecyclerView.LayoutManager.cb_requestSimpleAnimationsInNextLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.LayoutManager.n_RequestSimpleAnimationsInNextLayout));
				}
				return RecyclerView.LayoutManager.cb_requestSimpleAnimationsInNextLayout;
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x000123B0 File Offset: 0x000105B0
			private static void n_RequestSimpleAnimationsInNextLayout(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestSimpleAnimationsInNextLayout();
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x000123BF File Offset: 0x000105BF
			[Register("requestSimpleAnimationsInNextLayout", "()V", "GetRequestSimpleAnimationsInNextLayoutHandler")]
			public virtual void RequestSimpleAnimationsInNextLayout()
			{
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("requestSimpleAnimationsInNextLayout.()V", this, null);
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x000123D8 File Offset: 0x000105D8
			private static Delegate GetScrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_scrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_scrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_I(RecyclerView.LayoutManager.n_ScrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_scrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x000123FC File Offset: 0x000105FC
			private static int n_ScrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, int dx, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ScrollHorizontallyBy(dx, object2, object3);
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x0001242C File Offset: 0x0001062C
			[Register("scrollHorizontallyBy", "(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetScrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ScrollHorizontallyBy(int dx, RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(dx);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("scrollHorizontallyBy.(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x000124D0 File Offset: 0x000106D0
			private static Delegate GetScrollToPosition_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_scrollToPosition_I == null)
				{
					RecyclerView.LayoutManager.cb_scrollToPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.LayoutManager.n_ScrollToPosition_I));
				}
				return RecyclerView.LayoutManager.cb_scrollToPosition_I;
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x000124F4 File Offset: 0x000106F4
			private static void n_ScrollToPosition_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrollToPosition(position);
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x00012504 File Offset: 0x00010704
			[Register("scrollToPosition", "(I)V", "GetScrollToPosition_IHandler")]
			public unsafe virtual void ScrollToPosition(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("scrollToPosition.(I)V", this, ptr);
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x0001253F File Offset: 0x0001073F
			private static Delegate GetScrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler()
			{
				if (RecyclerView.LayoutManager.cb_scrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ == null)
				{
					RecyclerView.LayoutManager.cb_scrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_I(RecyclerView.LayoutManager.n_ScrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_));
				}
				return RecyclerView.LayoutManager.cb_scrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;
			}

			// Token: 0x06000623 RID: 1571 RVA: 0x00012564 File Offset: 0x00010764
			private static int n_ScrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_(IntPtr jnienv, IntPtr native__this, int dy, IntPtr native_recycler, IntPtr native_state)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				return @object.ScrollVerticallyBy(dy, object2, object3);
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00012594 File Offset: 0x00010794
			[Register("scrollVerticallyBy", "(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", "GetScrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Handler")]
			public unsafe virtual int ScrollVerticallyBy(int dy, RecyclerView.Recycler recycler, RecyclerView.State state)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(dy);
					ptr[1] = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualInt32Method("scrollVerticallyBy.(ILandroidx/recyclerview/widget/RecyclerView$Recycler;Landroidx/recyclerview/widget/RecyclerView$State;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recycler);
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x00012638 File Offset: 0x00010838
			private static Delegate GetSetMeasuredDimension_Landroid_graphics_Rect_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_setMeasuredDimension_Landroid_graphics_Rect_II == null)
				{
					RecyclerView.LayoutManager.cb_setMeasuredDimension_Landroid_graphics_Rect_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.LayoutManager.n_SetMeasuredDimension_Landroid_graphics_Rect_II));
				}
				return RecyclerView.LayoutManager.cb_setMeasuredDimension_Landroid_graphics_Rect_II;
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x0001265C File Offset: 0x0001085C
			private static void n_SetMeasuredDimension_Landroid_graphics_Rect_II(IntPtr jnienv, IntPtr native__this, IntPtr native_childrenBounds, int wSpec, int hSpec)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Rect object2 = Java.Lang.Object.GetObject<Rect>(native_childrenBounds, JniHandleOwnership.DoNotTransfer);
				@object.SetMeasuredDimension(object2, wSpec, hSpec);
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x00012684 File Offset: 0x00010884
			[Register("setMeasuredDimension", "(Landroid/graphics/Rect;II)V", "GetSetMeasuredDimension_Landroid_graphics_Rect_IIHandler")]
			public unsafe virtual void SetMeasuredDimension(Rect childrenBounds, int wSpec, int hSpec)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((childrenBounds == null) ? IntPtr.Zero : childrenBounds.Handle);
					ptr[1] = new JniArgumentValue(wSpec);
					ptr[2] = new JniArgumentValue(hSpec);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setMeasuredDimension.(Landroid/graphics/Rect;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(childrenBounds);
				}
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x00012710 File Offset: 0x00010910
			private static Delegate GetSetMeasuredDimension_IIHandler()
			{
				if (RecyclerView.LayoutManager.cb_setMeasuredDimension_II == null)
				{
					RecyclerView.LayoutManager.cb_setMeasuredDimension_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.LayoutManager.n_SetMeasuredDimension_II));
				}
				return RecyclerView.LayoutManager.cb_setMeasuredDimension_II;
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x00012734 File Offset: 0x00010934
			private static void n_SetMeasuredDimension_II(IntPtr jnienv, IntPtr native__this, int widthSize, int heightSize)
			{
				Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMeasuredDimension(widthSize, heightSize);
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x00012748 File Offset: 0x00010948
			[Register("setMeasuredDimension", "(II)V", "GetSetMeasuredDimension_IIHandler")]
			public unsafe virtual void SetMeasuredDimension(int widthSize, int heightSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(widthSize);
				ptr[1] = new JniArgumentValue(heightSize);
				RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("setMeasuredDimension.(II)V", this, ptr);
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x00012796 File Offset: 0x00010996
			private static Delegate GetSmoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_IHandler()
			{
				if (RecyclerView.LayoutManager.cb_smoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I == null)
				{
					RecyclerView.LayoutManager.cb_smoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(RecyclerView.LayoutManager.n_SmoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I));
				}
				return RecyclerView.LayoutManager.cb_smoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I;
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x000127BC File Offset: 0x000109BC
			private static void n_SmoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_state, int position)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.SmoothScrollToPosition(object2, object3, position);
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x000127EC File Offset: 0x000109EC
			[Register("smoothScrollToPosition", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;I)V", "GetSmoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_IHandler")]
			public unsafe virtual void SmoothScrollToPosition(RecyclerView recyclerView, RecyclerView.State state, int position)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					ptr[2] = new JniArgumentValue(position);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("smoothScrollToPosition.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$State;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x00012890 File Offset: 0x00010A90
			private static Delegate GetStartSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Handler()
			{
				if (RecyclerView.LayoutManager.cb_startSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_ == null)
				{
					RecyclerView.LayoutManager.cb_startSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_StartSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_));
				}
				return RecyclerView.LayoutManager.cb_startSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_;
			}

			// Token: 0x0600062F RID: 1583 RVA: 0x000128B4 File Offset: 0x00010AB4
			private static void n_StartSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_(IntPtr jnienv, IntPtr native__this, IntPtr native_smoothScroller)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.SmoothScroller object2 = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(native_smoothScroller, JniHandleOwnership.DoNotTransfer);
				@object.StartSmoothScroll(object2);
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x000128D8 File Offset: 0x00010AD8
			[Register("startSmoothScroll", "(Landroidx/recyclerview/widget/RecyclerView$SmoothScroller;)V", "GetStartSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Handler")]
			public unsafe virtual void StartSmoothScroll(RecyclerView.SmoothScroller smoothScroller)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((smoothScroller == null) ? IntPtr.Zero : smoothScroller.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("startSmoothScroll.(Landroidx/recyclerview/widget/RecyclerView$SmoothScroller;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(smoothScroller);
				}
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x0001293C File Offset: 0x00010B3C
			private static Delegate GetStopIgnoringView_Landroid_view_View_Handler()
			{
				if (RecyclerView.LayoutManager.cb_stopIgnoringView_Landroid_view_View_ == null)
				{
					RecyclerView.LayoutManager.cb_stopIgnoringView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.LayoutManager.n_StopIgnoringView_Landroid_view_View_));
				}
				return RecyclerView.LayoutManager.cb_stopIgnoringView_Landroid_view_View_;
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x00012960 File Offset: 0x00010B60
			private static void n_StopIgnoringView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.LayoutManager @object = Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.StopIgnoringView(object2);
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x00012984 File Offset: 0x00010B84
			[Register("stopIgnoringView", "(Landroid/view/View;)V", "GetStopIgnoringView_Landroid_view_View_Handler")]
			public unsafe virtual void StopIgnoringView(View view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualVoidMethod("stopIgnoringView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x000129E8 File Offset: 0x00010BE8
			private static Delegate GetSupportsPredictiveItemAnimationsHandler()
			{
				if (RecyclerView.LayoutManager.cb_supportsPredictiveItemAnimations == null)
				{
					RecyclerView.LayoutManager.cb_supportsPredictiveItemAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutManager.n_SupportsPredictiveItemAnimations));
				}
				return RecyclerView.LayoutManager.cb_supportsPredictiveItemAnimations;
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x00012A0C File Offset: 0x00010C0C
			private static bool n_SupportsPredictiveItemAnimations(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportsPredictiveItemAnimations();
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x00012A1B File Offset: 0x00010C1B
			[Register("supportsPredictiveItemAnimations", "()Z", "GetSupportsPredictiveItemAnimationsHandler")]
			public virtual bool SupportsPredictiveItemAnimations()
			{
				return RecyclerView.LayoutManager._members.InstanceMethods.InvokeVirtualBooleanMethod("supportsPredictiveItemAnimations.()Z", this, null);
			}

			// Token: 0x04000103 RID: 259
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$LayoutManager", typeof(RecyclerView.LayoutManager));

			// Token: 0x04000104 RID: 260
			private static Delegate cb_isAutoMeasureEnabled;

			// Token: 0x04000105 RID: 261
			private static Delegate cb_setAutoMeasureEnabled_Z;

			// Token: 0x04000106 RID: 262
			private static Delegate cb_getBaseline;

			// Token: 0x04000107 RID: 263
			private static Delegate cb_getChildCount;

			// Token: 0x04000108 RID: 264
			private static Delegate cb_getClipToPadding;

			// Token: 0x04000109 RID: 265
			private static Delegate cb_getFocusedChild;

			// Token: 0x0400010A RID: 266
			private static Delegate cb_hasFocus;

			// Token: 0x0400010B RID: 267
			private static Delegate cb_getHeight;

			// Token: 0x0400010C RID: 268
			private static Delegate cb_getHeightMode;

			// Token: 0x0400010D RID: 269
			private static Delegate cb_isAttachedToWindow;

			// Token: 0x0400010E RID: 270
			private static Delegate cb_isFocused;

			// Token: 0x0400010F RID: 271
			private static Delegate cb_isSmoothScrolling;

			// Token: 0x04000110 RID: 272
			private static Delegate cb_getItemCount;

			// Token: 0x04000111 RID: 273
			private static Delegate cb_getLayoutDirection;

			// Token: 0x04000112 RID: 274
			private static Delegate cb_isMeasurementCacheEnabled;

			// Token: 0x04000113 RID: 275
			private static Delegate cb_setMeasurementCacheEnabled_Z;

			// Token: 0x04000114 RID: 276
			private static Delegate cb_getMinimumHeight;

			// Token: 0x04000115 RID: 277
			private static Delegate cb_getMinimumWidth;

			// Token: 0x04000116 RID: 278
			private static Delegate cb_getPaddingBottom;

			// Token: 0x04000117 RID: 279
			private static Delegate cb_getPaddingEnd;

			// Token: 0x04000118 RID: 280
			private static Delegate cb_getPaddingLeft;

			// Token: 0x04000119 RID: 281
			private static Delegate cb_getPaddingRight;

			// Token: 0x0400011A RID: 282
			private static Delegate cb_getPaddingStart;

			// Token: 0x0400011B RID: 283
			private static Delegate cb_getPaddingTop;

			// Token: 0x0400011C RID: 284
			private static Delegate cb_getWidth;

			// Token: 0x0400011D RID: 285
			private static Delegate cb_getWidthMode;

			// Token: 0x0400011E RID: 286
			private static Delegate cb_addDisappearingView_Landroid_view_View_;

			// Token: 0x0400011F RID: 287
			private static Delegate cb_addDisappearingView_Landroid_view_View_I;

			// Token: 0x04000120 RID: 288
			private static Delegate cb_addView_Landroid_view_View_;

			// Token: 0x04000121 RID: 289
			private static Delegate cb_addView_Landroid_view_View_I;

			// Token: 0x04000122 RID: 290
			private static Delegate cb_assertInLayoutOrScroll_Ljava_lang_String_;

			// Token: 0x04000123 RID: 291
			private static Delegate cb_assertNotInLayoutOrScroll_Ljava_lang_String_;

			// Token: 0x04000124 RID: 292
			private static Delegate cb_attachView_Landroid_view_View_;

			// Token: 0x04000125 RID: 293
			private static Delegate cb_attachView_Landroid_view_View_I;

			// Token: 0x04000126 RID: 294
			private static Delegate cb_attachView_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_LayoutParams_;

			// Token: 0x04000127 RID: 295
			private static Delegate cb_calculateItemDecorationsForChild_Landroid_view_View_Landroid_graphics_Rect_;

			// Token: 0x04000128 RID: 296
			private static Delegate cb_canScrollHorizontally;

			// Token: 0x04000129 RID: 297
			private static Delegate cb_canScrollVertically;

			// Token: 0x0400012A RID: 298
			private static Delegate cb_checkLayoutParams_Landroidx_recyclerview_widget_RecyclerView_LayoutParams_;

			// Token: 0x0400012B RID: 299
			private static Delegate cb_collectAdjacentPrefetchPositions_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_;

			// Token: 0x0400012C RID: 300
			private static Delegate cb_collectInitialPrefetchPositions_ILandroidx_recyclerview_widget_RecyclerView_LayoutManager_LayoutPrefetchRegistry_;

			// Token: 0x0400012D RID: 301
			private static Delegate cb_computeHorizontalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400012E RID: 302
			private static Delegate cb_computeHorizontalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400012F RID: 303
			private static Delegate cb_computeHorizontalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000130 RID: 304
			private static Delegate cb_computeVerticalScrollExtent_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000131 RID: 305
			private static Delegate cb_computeVerticalScrollOffset_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000132 RID: 306
			private static Delegate cb_computeVerticalScrollRange_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000133 RID: 307
			private static Delegate cb_detachAndScrapAttachedViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x04000134 RID: 308
			private static Delegate cb_detachAndScrapView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x04000135 RID: 309
			private static Delegate cb_detachAndScrapViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x04000136 RID: 310
			private static Delegate cb_detachView_Landroid_view_View_;

			// Token: 0x04000137 RID: 311
			private static Delegate cb_detachViewAt_I;

			// Token: 0x04000138 RID: 312
			private static Delegate cb_endAnimation_Landroid_view_View_;

			// Token: 0x04000139 RID: 313
			private static Delegate cb_findContainingItemView_Landroid_view_View_;

			// Token: 0x0400013A RID: 314
			private static Delegate cb_findViewByPosition_I;

			// Token: 0x0400013B RID: 315
			private static Delegate cb_generateDefaultLayoutParams;

			// Token: 0x0400013C RID: 316
			private static Delegate cb_generateLayoutParams_Landroid_content_Context_Landroid_util_AttributeSet_;

			// Token: 0x0400013D RID: 317
			private static Delegate cb_generateLayoutParams_Landroid_view_ViewGroup_LayoutParams_;

			// Token: 0x0400013E RID: 318
			private static Delegate cb_getBottomDecorationHeight_Landroid_view_View_;

			// Token: 0x0400013F RID: 319
			private static Delegate cb_getChildAt_I;

			// Token: 0x04000140 RID: 320
			private static Delegate cb_getColumnCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000141 RID: 321
			private static Delegate cb_getDecoratedBottom_Landroid_view_View_;

			// Token: 0x04000142 RID: 322
			private static Delegate cb_getDecoratedBoundsWithMargins_Landroid_view_View_Landroid_graphics_Rect_;

			// Token: 0x04000143 RID: 323
			private static Delegate cb_getDecoratedLeft_Landroid_view_View_;

			// Token: 0x04000144 RID: 324
			private static Delegate cb_getDecoratedMeasuredHeight_Landroid_view_View_;

			// Token: 0x04000145 RID: 325
			private static Delegate cb_getDecoratedMeasuredWidth_Landroid_view_View_;

			// Token: 0x04000146 RID: 326
			private static Delegate cb_getDecoratedRight_Landroid_view_View_;

			// Token: 0x04000147 RID: 327
			private static Delegate cb_getDecoratedTop_Landroid_view_View_;

			// Token: 0x04000148 RID: 328
			private static Delegate cb_getItemViewType_Landroid_view_View_;

			// Token: 0x04000149 RID: 329
			private static Delegate cb_getLeftDecorationWidth_Landroid_view_View_;

			// Token: 0x0400014A RID: 330
			private static Delegate cb_getPosition_Landroid_view_View_;

			// Token: 0x0400014B RID: 331
			private static Delegate cb_getRightDecorationWidth_Landroid_view_View_;

			// Token: 0x0400014C RID: 332
			private static Delegate cb_getRowCountForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400014D RID: 333
			private static Delegate cb_getSelectionModeForAccessibility_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400014E RID: 334
			private static Delegate cb_getTopDecorationHeight_Landroid_view_View_;

			// Token: 0x0400014F RID: 335
			private static Delegate cb_getTransformedBoundingBox_Landroid_view_View_ZLandroid_graphics_Rect_;

			// Token: 0x04000150 RID: 336
			private static Delegate cb_ignoreView_Landroid_view_View_;

			// Token: 0x04000151 RID: 337
			private static Delegate cb_isLayoutHierarchical_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000152 RID: 338
			private static Delegate cb_isViewPartiallyVisible_Landroid_view_View_ZZ;

			// Token: 0x04000153 RID: 339
			private static Delegate cb_layoutDecorated_Landroid_view_View_IIII;

			// Token: 0x04000154 RID: 340
			private static Delegate cb_layoutDecoratedWithMargins_Landroid_view_View_IIII;

			// Token: 0x04000155 RID: 341
			private static Delegate cb_measureChild_Landroid_view_View_II;

			// Token: 0x04000156 RID: 342
			private static Delegate cb_measureChildWithMargins_Landroid_view_View_II;

			// Token: 0x04000157 RID: 343
			private static Delegate cb_moveView_II;

			// Token: 0x04000158 RID: 344
			private static Delegate cb_offsetChildrenHorizontal_I;

			// Token: 0x04000159 RID: 345
			private static Delegate cb_offsetChildrenVertical_I;

			// Token: 0x0400015A RID: 346
			private static Delegate cb_onAdapterChanged_Landroidx_recyclerview_widget_RecyclerView_Adapter_Landroidx_recyclerview_widget_RecyclerView_Adapter_;

			// Token: 0x0400015B RID: 347
			private static Delegate cb_onAddFocusables_Landroidx_recyclerview_widget_RecyclerView_Ljava_util_ArrayList_II;

			// Token: 0x0400015C RID: 348
			private static Delegate cb_onAttachedToWindow_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x0400015D RID: 349
			private static Delegate cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x0400015E RID: 350
			private static Delegate cb_onDetachedFromWindow_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x0400015F RID: 351
			private static Delegate cb_onFocusSearchFailed_Landroid_view_View_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000160 RID: 352
			private static Delegate cb_onInitializeAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;

			// Token: 0x04000161 RID: 353
			private static Delegate cb_onInitializeAccessibilityEvent_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_accessibility_AccessibilityEvent_;

			// Token: 0x04000162 RID: 354
			private static Delegate cb_onInitializeAccessibilityNodeInfo_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;

			// Token: 0x04000163 RID: 355
			private static Delegate cb_onInitializeAccessibilityNodeInfoForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;

			// Token: 0x04000164 RID: 356
			private static Delegate cb_onInterceptFocusSearch_Landroid_view_View_I;

			// Token: 0x04000165 RID: 357
			private static Delegate cb_onItemsAdded_Landroidx_recyclerview_widget_RecyclerView_II;

			// Token: 0x04000166 RID: 358
			private static Delegate cb_onItemsChanged_Landroidx_recyclerview_widget_RecyclerView_;

			// Token: 0x04000167 RID: 359
			private static Delegate cb_onItemsMoved_Landroidx_recyclerview_widget_RecyclerView_III;

			// Token: 0x04000168 RID: 360
			private static Delegate cb_onItemsRemoved_Landroidx_recyclerview_widget_RecyclerView_II;

			// Token: 0x04000169 RID: 361
			private static Delegate cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_II;

			// Token: 0x0400016A RID: 362
			private static Delegate cb_onItemsUpdated_Landroidx_recyclerview_widget_RecyclerView_IILjava_lang_Object_;

			// Token: 0x0400016B RID: 363
			private static Delegate cb_onLayoutChildren_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400016C RID: 364
			private static Delegate cb_onLayoutCompleted_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x0400016D RID: 365
			private static Delegate cb_onMeasure_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_II;

			// Token: 0x0400016E RID: 366
			private static Delegate cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_view_View_;

			// Token: 0x0400016F RID: 367
			private static Delegate cb_onRequestChildFocus_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_Landroid_view_View_;

			// Token: 0x04000170 RID: 368
			private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

			// Token: 0x04000171 RID: 369
			private static Delegate cb_onSaveInstanceState;

			// Token: 0x04000172 RID: 370
			private static Delegate cb_onScrollStateChanged_I;

			// Token: 0x04000173 RID: 371
			private static Delegate cb_performAccessibilityAction_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_ILandroid_os_Bundle_;

			// Token: 0x04000174 RID: 372
			private static Delegate cb_performAccessibilityActionForItem_Landroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_Landroid_view_View_ILandroid_os_Bundle_;

			// Token: 0x04000175 RID: 373
			private static Delegate cb_postOnAnimation_Ljava_lang_Runnable_;

			// Token: 0x04000176 RID: 374
			private static Delegate cb_removeAllViews;

			// Token: 0x04000177 RID: 375
			private static Delegate cb_removeAndRecycleAllViews_Landroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x04000178 RID: 376
			private static Delegate cb_removeAndRecycleView_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x04000179 RID: 377
			private static Delegate cb_removeAndRecycleViewAt_ILandroidx_recyclerview_widget_RecyclerView_Recycler_;

			// Token: 0x0400017A RID: 378
			private static Delegate cb_removeCallbacks_Ljava_lang_Runnable_;

			// Token: 0x0400017B RID: 379
			private static Delegate cb_removeDetachedView_Landroid_view_View_;

			// Token: 0x0400017C RID: 380
			private static Delegate cb_removeView_Landroid_view_View_;

			// Token: 0x0400017D RID: 381
			private static Delegate cb_removeViewAt_I;

			// Token: 0x0400017E RID: 382
			private static Delegate cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_Z;

			// Token: 0x0400017F RID: 383
			private static Delegate cb_requestChildRectangleOnScreen_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_Landroid_graphics_Rect_ZZ;

			// Token: 0x04000180 RID: 384
			private static Delegate cb_requestLayout;

			// Token: 0x04000181 RID: 385
			private static Delegate cb_requestSimpleAnimationsInNextLayout;

			// Token: 0x04000182 RID: 386
			private static Delegate cb_scrollHorizontallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000183 RID: 387
			private static Delegate cb_scrollToPosition_I;

			// Token: 0x04000184 RID: 388
			private static Delegate cb_scrollVerticallyBy_ILandroidx_recyclerview_widget_RecyclerView_Recycler_Landroidx_recyclerview_widget_RecyclerView_State_;

			// Token: 0x04000185 RID: 389
			private static Delegate cb_setMeasuredDimension_Landroid_graphics_Rect_II;

			// Token: 0x04000186 RID: 390
			private static Delegate cb_setMeasuredDimension_II;

			// Token: 0x04000187 RID: 391
			private static Delegate cb_smoothScrollToPosition_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_State_I;

			// Token: 0x04000188 RID: 392
			private static Delegate cb_startSmoothScroll_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_;

			// Token: 0x04000189 RID: 393
			private static Delegate cb_stopIgnoringView_Landroid_view_View_;

			// Token: 0x0400018A RID: 394
			private static Delegate cb_supportsPredictiveItemAnimations;

			// Token: 0x02000066 RID: 102
			[Register("androidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry", "", "AndroidX.RecyclerView.Widget.RecyclerView/LayoutManager/ILayoutPrefetchRegistryInvoker")]
			public interface ILayoutPrefetchRegistry : IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x06000638 RID: 1592
				[Register("addPosition", "(II)V", "GetAddPosition_IIHandler:AndroidX.RecyclerView.Widget.RecyclerView/LayoutManager/ILayoutPrefetchRegistryInvoker, Xamarin.AndroidX.RecyclerView")]
				void AddPosition(int layoutPosition, int pixelDistance);
			}

			// Token: 0x02000067 RID: 103
			[Register("androidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry", DoNotGenerateAcw = true)]
			internal class ILayoutPrefetchRegistryInvoker : Java.Lang.Object, RecyclerView.LayoutManager.ILayoutPrefetchRegistry, IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x1700009B RID: 155
				// (get) Token: 0x06000639 RID: 1593 RVA: 0x00012A50 File Offset: 0x00010C50
				private static IntPtr java_class_ref
				{
					get
					{
						return RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x1700009C RID: 156
				// (get) Token: 0x0600063A RID: 1594 RVA: 0x00012A74 File Offset: 0x00010C74
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker._members;
					}
				}

				// Token: 0x1700009D RID: 157
				// (get) Token: 0x0600063B RID: 1595 RVA: 0x00012A7B File Offset: 0x00010C7B
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return this.class_ref;
					}
				}

				// Token: 0x1700009E RID: 158
				// (get) Token: 0x0600063C RID: 1596 RVA: 0x00012A83 File Offset: 0x00010C83
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker._members.ManagedPeerType;
					}
				}

				// Token: 0x0600063D RID: 1597 RVA: 0x00012A8F File Offset: 0x00010C8F
				public static RecyclerView.LayoutManager.ILayoutPrefetchRegistry GetObject(IntPtr handle, JniHandleOwnership transfer)
				{
					return Java.Lang.Object.GetObject<RecyclerView.LayoutManager.ILayoutPrefetchRegistry>(handle, transfer);
				}

				// Token: 0x0600063E RID: 1598 RVA: 0x00012A98 File Offset: 0x00010C98
				private static IntPtr Validate(IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf(handle, RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.java_class_ref))
					{
						throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.LayoutManager.LayoutPrefetchRegistry'.");
					}
					return handle;
				}

				// Token: 0x0600063F RID: 1599 RVA: 0x00012AC3 File Offset: 0x00010CC3
				protected override void Dispose(bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
					{
						JNIEnv.DeleteGlobalRef(this.class_ref);
					}
					this.class_ref = IntPtr.Zero;
					base.Dispose(disposing);
				}

				// Token: 0x06000640 RID: 1600 RVA: 0x00012AF4 File Offset: 0x00010CF4
				public ILayoutPrefetchRegistryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.Validate(handle), transfer)
				{
					IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
					this.class_ref = JNIEnv.NewGlobalRef(objectClass);
					JNIEnv.DeleteLocalRef(objectClass);
				}

				// Token: 0x06000641 RID: 1601 RVA: 0x00012B2C File Offset: 0x00010D2C
				private static Delegate GetAddPosition_IIHandler()
				{
					if (RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.cb_addPosition_II == null)
					{
						RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.cb_addPosition_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.n_AddPosition_II));
					}
					return RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker.cb_addPosition_II;
				}

				// Token: 0x06000642 RID: 1602 RVA: 0x00012B50 File Offset: 0x00010D50
				private static void n_AddPosition_II(IntPtr jnienv, IntPtr native__this, int layoutPosition, int pixelDistance)
				{
					Java.Lang.Object.GetObject<RecyclerView.LayoutManager.ILayoutPrefetchRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddPosition(layoutPosition, pixelDistance);
				}

				// Token: 0x06000643 RID: 1603 RVA: 0x00012B64 File Offset: 0x00010D64
				public unsafe void AddPosition(int layoutPosition, int pixelDistance)
				{
					if (this.id_addPosition_II == IntPtr.Zero)
					{
						this.id_addPosition_II = JNIEnv.GetMethodID(this.class_ref, "addPosition", "(II)V");
					}
					JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
					*ptr = new JValue(layoutPosition);
					ptr[1] = new JValue(pixelDistance);
					JNIEnv.CallVoidMethod(base.Handle, this.id_addPosition_II, ptr);
				}

				// Token: 0x0400018B RID: 395
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$LayoutManager$LayoutPrefetchRegistry", typeof(RecyclerView.LayoutManager.ILayoutPrefetchRegistryInvoker));

				// Token: 0x0400018C RID: 396
				private IntPtr class_ref;

				// Token: 0x0400018D RID: 397
				private static Delegate cb_addPosition_II;

				// Token: 0x0400018E RID: 398
				private IntPtr id_addPosition_II;
			}

			// Token: 0x02000068 RID: 104
			[Register("androidx/recyclerview/widget/RecyclerView$LayoutManager$Properties", DoNotGenerateAcw = true)]
			public class Properties : Java.Lang.Object
			{
				// Token: 0x1700009F RID: 159
				// (get) Token: 0x06000645 RID: 1605 RVA: 0x00012BF6 File Offset: 0x00010DF6
				// (set) Token: 0x06000646 RID: 1606 RVA: 0x00012C0D File Offset: 0x00010E0D
				[Register("orientation")]
				public int Orientation
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.InstanceFields.GetInt32Value("orientation.I", this);
					}
					set
					{
						RecyclerView.LayoutManager.Properties._members.InstanceFields.SetValue("orientation.I", this, value);
					}
				}

				// Token: 0x170000A0 RID: 160
				// (get) Token: 0x06000647 RID: 1607 RVA: 0x00012C25 File Offset: 0x00010E25
				// (set) Token: 0x06000648 RID: 1608 RVA: 0x00012C3C File Offset: 0x00010E3C
				[Register("reverseLayout")]
				public bool ReverseLayout
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.InstanceFields.GetBooleanValue("reverseLayout.Z", this);
					}
					set
					{
						RecyclerView.LayoutManager.Properties._members.InstanceFields.SetValue("reverseLayout.Z", this, value);
					}
				}

				// Token: 0x170000A1 RID: 161
				// (get) Token: 0x06000649 RID: 1609 RVA: 0x00012C54 File Offset: 0x00010E54
				// (set) Token: 0x0600064A RID: 1610 RVA: 0x00012C6B File Offset: 0x00010E6B
				[Register("spanCount")]
				public int SpanCount
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.InstanceFields.GetInt32Value("spanCount.I", this);
					}
					set
					{
						RecyclerView.LayoutManager.Properties._members.InstanceFields.SetValue("spanCount.I", this, value);
					}
				}

				// Token: 0x170000A2 RID: 162
				// (get) Token: 0x0600064B RID: 1611 RVA: 0x00012C83 File Offset: 0x00010E83
				// (set) Token: 0x0600064C RID: 1612 RVA: 0x00012C9A File Offset: 0x00010E9A
				[Register("stackFromEnd")]
				public bool StackFromEnd
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.InstanceFields.GetBooleanValue("stackFromEnd.Z", this);
					}
					set
					{
						RecyclerView.LayoutManager.Properties._members.InstanceFields.SetValue("stackFromEnd.Z", this, value);
					}
				}

				// Token: 0x170000A3 RID: 163
				// (get) Token: 0x0600064D RID: 1613 RVA: 0x00012CB4 File Offset: 0x00010EB4
				internal static IntPtr class_ref
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000A4 RID: 164
				// (get) Token: 0x0600064E RID: 1614 RVA: 0x00012CD8 File Offset: 0x00010ED8
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members;
					}
				}

				// Token: 0x170000A5 RID: 165
				// (get) Token: 0x0600064F RID: 1615 RVA: 0x00012CE0 File Offset: 0x00010EE0
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000A6 RID: 166
				// (get) Token: 0x06000650 RID: 1616 RVA: 0x00012D04 File Offset: 0x00010F04
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.LayoutManager.Properties._members.ManagedPeerType;
					}
				}

				// Token: 0x06000651 RID: 1617 RVA: 0x000026A8 File Offset: 0x000008A8
				protected Properties(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x06000652 RID: 1618 RVA: 0x00012D10 File Offset: 0x00010F10
				[Register(".ctor", "()V", "")]
				public Properties() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					base.SetHandle(RecyclerView.LayoutManager.Properties._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.LayoutManager.Properties._members.InstanceMethods.FinishCreateInstance("()V", this, null);
				}

				// Token: 0x0400018F RID: 399
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$LayoutManager$Properties", typeof(RecyclerView.LayoutManager.Properties));
			}
		}

		// Token: 0x02000069 RID: 105
		[Register("androidx/recyclerview/widget/RecyclerView$LayoutManager", DoNotGenerateAcw = true)]
		internal class LayoutManagerInvoker : RecyclerView.LayoutManager
		{
			// Token: 0x06000654 RID: 1620 RVA: 0x00004A44 File Offset: 0x00002C44
			public LayoutManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x00012D99 File Offset: 0x00010F99
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.LayoutManagerInvoker._members;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000656 RID: 1622 RVA: 0x00012DA0 File Offset: 0x00010FA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.LayoutManagerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00012DAC File Offset: 0x00010FAC
			[Register("generateDefaultLayoutParams", "()Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", "GetGenerateDefaultLayoutParamsHandler")]
			public override RecyclerView.LayoutParams GenerateDefaultLayoutParams()
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(RecyclerView.LayoutManagerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("generateDefaultLayoutParams.()Landroidx/recyclerview/widget/RecyclerView$LayoutParams;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000190 RID: 400
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$LayoutManager", typeof(RecyclerView.LayoutManagerInvoker));
		}

		// Token: 0x0200006A RID: 106
		[Register("androidx/recyclerview/widget/RecyclerView$LayoutParams", DoNotGenerateAcw = true)]
		public new class LayoutParams : ViewGroup.MarginLayoutParams
		{
			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000659 RID: 1625 RVA: 0x00012DFC File Offset: 0x00010FFC
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600065A RID: 1626 RVA: 0x00012E20 File Offset: 0x00011020
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.LayoutParams._members;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600065B RID: 1627 RVA: 0x00012E28 File Offset: 0x00011028
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600065C RID: 1628 RVA: 0x00012E4C File Offset: 0x0001104C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x00012E58 File Offset: 0x00011058
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x00012E64 File Offset: 0x00011064
			[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams(Context c, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					base.SetHandle(RecyclerView.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x00012F40 File Offset: 0x00011140
			[Register(".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams(ViewGroup.LayoutParams source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
					base.SetHandle(RecyclerView.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(source);
				}
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00012FF0 File Offset: 0x000111F0
			[Register(".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams(ViewGroup.MarginLayoutParams source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
					base.SetHandle(RecyclerView.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup$MarginLayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup$MarginLayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(source);
				}
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x000130A0 File Offset: 0x000112A0
			[Register(".ctor", "(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)V", "")]
			public unsafe LayoutParams(RecyclerView.LayoutParams source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
					base.SetHandle(RecyclerView.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroidx/recyclerview/widget/RecyclerView$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(source);
				}
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00013150 File Offset: 0x00011350
			[Register(".ctor", "(II)V", "")]
			public unsafe LayoutParams(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				base.SetHandle(RecyclerView.LayoutParams._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.LayoutParams._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x000131E7 File Offset: 0x000113E7
			private static Delegate GetGetAbsoluteAdapterPositionHandler()
			{
				if (RecyclerView.LayoutParams.cb_getAbsoluteAdapterPosition == null)
				{
					RecyclerView.LayoutParams.cb_getAbsoluteAdapterPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutParams.n_GetAbsoluteAdapterPosition));
				}
				return RecyclerView.LayoutParams.cb_getAbsoluteAdapterPosition;
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x0001320B File Offset: 0x0001140B
			private static int n_GetAbsoluteAdapterPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AbsoluteAdapterPosition;
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001321A File Offset: 0x0001141A
			public virtual int AbsoluteAdapterPosition
			{
				[Register("getAbsoluteAdapterPosition", "()I", "GetGetAbsoluteAdapterPositionHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getAbsoluteAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x00013233 File Offset: 0x00011433
			private static Delegate GetGetBindingAdapterPositionHandler()
			{
				if (RecyclerView.LayoutParams.cb_getBindingAdapterPosition == null)
				{
					RecyclerView.LayoutParams.cb_getBindingAdapterPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutParams.n_GetBindingAdapterPosition));
				}
				return RecyclerView.LayoutParams.cb_getBindingAdapterPosition;
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x00013257 File Offset: 0x00011457
			private static int n_GetBindingAdapterPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BindingAdapterPosition;
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000668 RID: 1640 RVA: 0x00013266 File Offset: 0x00011466
			public virtual int BindingAdapterPosition
			{
				[Register("getBindingAdapterPosition", "()I", "GetGetBindingAdapterPositionHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getBindingAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x0001327F File Offset: 0x0001147F
			private static Delegate GetIsItemChangedHandler()
			{
				if (RecyclerView.LayoutParams.cb_isItemChanged == null)
				{
					RecyclerView.LayoutParams.cb_isItemChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutParams.n_IsItemChanged));
				}
				return RecyclerView.LayoutParams.cb_isItemChanged;
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x000132A3 File Offset: 0x000114A3
			private static bool n_IsItemChanged(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsItemChanged;
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600066B RID: 1643 RVA: 0x000132B2 File Offset: 0x000114B2
			public virtual bool IsItemChanged
			{
				[Register("isItemChanged", "()Z", "GetIsItemChangedHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualBooleanMethod("isItemChanged.()Z", this, null);
				}
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x000132CB File Offset: 0x000114CB
			private static Delegate GetIsItemRemovedHandler()
			{
				if (RecyclerView.LayoutParams.cb_isItemRemoved == null)
				{
					RecyclerView.LayoutParams.cb_isItemRemoved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutParams.n_IsItemRemoved));
				}
				return RecyclerView.LayoutParams.cb_isItemRemoved;
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x000132EF File Offset: 0x000114EF
			private static bool n_IsItemRemoved(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsItemRemoved;
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x000132FE File Offset: 0x000114FE
			public virtual bool IsItemRemoved
			{
				[Register("isItemRemoved", "()Z", "GetIsItemRemovedHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualBooleanMethod("isItemRemoved.()Z", this, null);
				}
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00013317 File Offset: 0x00011517
			private static Delegate GetIsViewInvalidHandler()
			{
				if (RecyclerView.LayoutParams.cb_isViewInvalid == null)
				{
					RecyclerView.LayoutParams.cb_isViewInvalid = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutParams.n_IsViewInvalid));
				}
				return RecyclerView.LayoutParams.cb_isViewInvalid;
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x0001333B File Offset: 0x0001153B
			private static bool n_IsViewInvalid(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsViewInvalid;
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001334A File Offset: 0x0001154A
			public virtual bool IsViewInvalid
			{
				[Register("isViewInvalid", "()Z", "GetIsViewInvalidHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualBooleanMethod("isViewInvalid.()Z", this, null);
				}
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00013363 File Offset: 0x00011563
			private static Delegate GetGetViewAdapterPositionHandler()
			{
				if (RecyclerView.LayoutParams.cb_getViewAdapterPosition == null)
				{
					RecyclerView.LayoutParams.cb_getViewAdapterPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutParams.n_GetViewAdapterPosition));
				}
				return RecyclerView.LayoutParams.cb_getViewAdapterPosition;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00013387 File Offset: 0x00011587
			private static int n_GetViewAdapterPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewAdapterPosition;
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000674 RID: 1652 RVA: 0x00013396 File Offset: 0x00011596
			public virtual int ViewAdapterPosition
			{
				[Register("getViewAdapterPosition", "()I", "GetGetViewAdapterPositionHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getViewAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x000133AF File Offset: 0x000115AF
			private static Delegate GetGetViewLayoutPositionHandler()
			{
				if (RecyclerView.LayoutParams.cb_getViewLayoutPosition == null)
				{
					RecyclerView.LayoutParams.cb_getViewLayoutPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutParams.n_GetViewLayoutPosition));
				}
				return RecyclerView.LayoutParams.cb_getViewLayoutPosition;
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x000133D3 File Offset: 0x000115D3
			private static int n_GetViewLayoutPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewLayoutPosition;
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000677 RID: 1655 RVA: 0x000133E2 File Offset: 0x000115E2
			public virtual int ViewLayoutPosition
			{
				[Register("getViewLayoutPosition", "()I", "GetGetViewLayoutPositionHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getViewLayoutPosition.()I", this, null);
				}
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x000133FB File Offset: 0x000115FB
			private static Delegate GetGetViewPositionHandler()
			{
				if (RecyclerView.LayoutParams.cb_getViewPosition == null)
				{
					RecyclerView.LayoutParams.cb_getViewPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.LayoutParams.n_GetViewPosition));
				}
				return RecyclerView.LayoutParams.cb_getViewPosition;
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x0001341F File Offset: 0x0001161F
			private static int n_GetViewPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewPosition;
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001342E File Offset: 0x0001162E
			public virtual int ViewPosition
			{
				[Register("getViewPosition", "()I", "GetGetViewPositionHandler")]
				get
				{
					return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getViewPosition.()I", this, null);
				}
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00013447 File Offset: 0x00011647
			private static Delegate GetViewNeedsUpdateHandler()
			{
				if (RecyclerView.LayoutParams.cb_viewNeedsUpdate == null)
				{
					RecyclerView.LayoutParams.cb_viewNeedsUpdate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.LayoutParams.n_ViewNeedsUpdate));
				}
				return RecyclerView.LayoutParams.cb_viewNeedsUpdate;
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x0001346B File Offset: 0x0001166B
			private static bool n_ViewNeedsUpdate(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewNeedsUpdate();
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x0001347A File Offset: 0x0001167A
			[Register("viewNeedsUpdate", "()Z", "GetViewNeedsUpdateHandler")]
			public virtual bool ViewNeedsUpdate()
			{
				return RecyclerView.LayoutParams._members.InstanceMethods.InvokeVirtualBooleanMethod("viewNeedsUpdate.()Z", this, null);
			}

			// Token: 0x04000191 RID: 401
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$LayoutParams", typeof(RecyclerView.LayoutParams));

			// Token: 0x04000192 RID: 402
			private static Delegate cb_getAbsoluteAdapterPosition;

			// Token: 0x04000193 RID: 403
			private static Delegate cb_getBindingAdapterPosition;

			// Token: 0x04000194 RID: 404
			private static Delegate cb_isItemChanged;

			// Token: 0x04000195 RID: 405
			private static Delegate cb_isItemRemoved;

			// Token: 0x04000196 RID: 406
			private static Delegate cb_isViewInvalid;

			// Token: 0x04000197 RID: 407
			private static Delegate cb_getViewAdapterPosition;

			// Token: 0x04000198 RID: 408
			private static Delegate cb_getViewLayoutPosition;

			// Token: 0x04000199 RID: 409
			private static Delegate cb_getViewPosition;

			// Token: 0x0400019A RID: 410
			private static Delegate cb_viewNeedsUpdate;
		}

		// Token: 0x0200006B RID: 107
		[Register("androidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener", "", "AndroidX.RecyclerView.Widget.RecyclerView/IOnChildAttachStateChangeListenerInvoker")]
		public interface IOnChildAttachStateChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600067F RID: 1663
			[Register("onChildViewAttachedToWindow", "(Landroid/view/View;)V", "GetOnChildViewAttachedToWindow_Landroid_view_View_Handler:AndroidX.RecyclerView.Widget.RecyclerView/IOnChildAttachStateChangeListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			void OnChildViewAttachedToWindow(View view);

			// Token: 0x06000680 RID: 1664
			[Register("onChildViewDetachedFromWindow", "(Landroid/view/View;)V", "GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler:AndroidX.RecyclerView.Widget.RecyclerView/IOnChildAttachStateChangeListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			void OnChildViewDetachedFromWindow(View view);
		}

		// Token: 0x0200006C RID: 108
		[Register("androidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener", DoNotGenerateAcw = true)]
		internal class IOnChildAttachStateChangeListenerInvoker : Java.Lang.Object, RecyclerView.IOnChildAttachStateChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x000134B0 File Offset: 0x000116B0
			private static IntPtr java_class_ref
			{
				get
				{
					return RecyclerView.IOnChildAttachStateChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x000134D4 File Offset: 0x000116D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.IOnChildAttachStateChangeListenerInvoker._members;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x000134DB File Offset: 0x000116DB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000684 RID: 1668 RVA: 0x000134E3 File Offset: 0x000116E3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.IOnChildAttachStateChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x000134EF File Offset: 0x000116EF
			public static RecyclerView.IOnChildAttachStateChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<RecyclerView.IOnChildAttachStateChangeListener>(handle, transfer);
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x000134F8 File Offset: 0x000116F8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, RecyclerView.IOnChildAttachStateChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.OnChildAttachStateChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00013523 File Offset: 0x00011723
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x00013554 File Offset: 0x00011754
			public IOnChildAttachStateChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.IOnChildAttachStateChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x0001358C File Offset: 0x0001178C
			private static Delegate GetOnChildViewAttachedToWindow_Landroid_view_View_Handler()
			{
				if (RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewAttachedToWindow_Landroid_view_View_ == null)
				{
					RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewAttachedToWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.IOnChildAttachStateChangeListenerInvoker.n_OnChildViewAttachedToWindow_Landroid_view_View_));
				}
				return RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewAttachedToWindow_Landroid_view_View_;
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x000135B0 File Offset: 0x000117B0
			private static void n_OnChildViewAttachedToWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.IOnChildAttachStateChangeListener @object = Java.Lang.Object.GetObject<RecyclerView.IOnChildAttachStateChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnChildViewAttachedToWindow(object2);
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x000135D4 File Offset: 0x000117D4
			public unsafe void OnChildViewAttachedToWindow(View view)
			{
				if (this.id_onChildViewAttachedToWindow_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onChildViewAttachedToWindow_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onChildViewAttachedToWindow", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onChildViewAttachedToWindow_Landroid_view_View_, ptr);
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x00013647 File Offset: 0x00011847
			private static Delegate GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler()
			{
				if (RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewDetachedFromWindow_Landroid_view_View_ == null)
				{
					RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewDetachedFromWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.IOnChildAttachStateChangeListenerInvoker.n_OnChildViewDetachedFromWindow_Landroid_view_View_));
				}
				return RecyclerView.IOnChildAttachStateChangeListenerInvoker.cb_onChildViewDetachedFromWindow_Landroid_view_View_;
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x0001366C File Offset: 0x0001186C
			private static void n_OnChildViewDetachedFromWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.IOnChildAttachStateChangeListener @object = Java.Lang.Object.GetObject<RecyclerView.IOnChildAttachStateChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnChildViewDetachedFromWindow(object2);
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00013690 File Offset: 0x00011890
			public unsafe void OnChildViewDetachedFromWindow(View view)
			{
				if (this.id_onChildViewDetachedFromWindow_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onChildViewDetachedFromWindow_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onChildViewDetachedFromWindow", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onChildViewDetachedFromWindow_Landroid_view_View_, ptr);
			}

			// Token: 0x0400019B RID: 411
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnChildAttachStateChangeListener", typeof(RecyclerView.IOnChildAttachStateChangeListenerInvoker));

			// Token: 0x0400019C RID: 412
			private IntPtr class_ref;

			// Token: 0x0400019D RID: 413
			private static Delegate cb_onChildViewAttachedToWindow_Landroid_view_View_;

			// Token: 0x0400019E RID: 414
			private IntPtr id_onChildViewAttachedToWindow_Landroid_view_View_;

			// Token: 0x0400019F RID: 415
			private static Delegate cb_onChildViewDetachedFromWindow_Landroid_view_View_;

			// Token: 0x040001A0 RID: 416
			private IntPtr id_onChildViewDetachedFromWindow_Landroid_view_View_;
		}

		// Token: 0x0200006D RID: 109
		public class ChildViewAttachedToWindowEventArgs : EventArgs
		{
			// Token: 0x06000690 RID: 1680 RVA: 0x0001371E File Offset: 0x0001191E
			public ChildViewAttachedToWindowEventArgs(View view)
			{
				this.view = view;
			}

			// Token: 0x040001A1 RID: 417
			private View view;
		}

		// Token: 0x0200006E RID: 110
		public class ChildViewDetachedFromWindowEventArgs : EventArgs
		{
			// Token: 0x06000691 RID: 1681 RVA: 0x0001372D File Offset: 0x0001192D
			public ChildViewDetachedFromWindowEventArgs(View view)
			{
				this.view = view;
			}

			// Token: 0x040001A2 RID: 418
			private View view;
		}

		// Token: 0x0200006F RID: 111
		[Register("mono/androidx/recyclerview/widget/RecyclerView_OnChildAttachStateChangeListenerImplementor")]
		internal sealed class IOnChildAttachStateChangeListenerImplementor : Java.Lang.Object, RecyclerView.IOnChildAttachStateChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000692 RID: 1682 RVA: 0x0001373C File Offset: 0x0001193C
			public IOnChildAttachStateChangeListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/recyclerview/widget/RecyclerView_OnChildAttachStateChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000693 RID: 1683 RVA: 0x00013778 File Offset: 0x00011978
			public void OnChildViewAttachedToWindow(View view)
			{
				EventHandler<RecyclerView.ChildViewAttachedToWindowEventArgs> onChildViewAttachedToWindowHandler = this.OnChildViewAttachedToWindowHandler;
				if (onChildViewAttachedToWindowHandler != null)
				{
					onChildViewAttachedToWindowHandler(this.sender, new RecyclerView.ChildViewAttachedToWindowEventArgs(view));
				}
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x000137A4 File Offset: 0x000119A4
			public void OnChildViewDetachedFromWindow(View view)
			{
				EventHandler<RecyclerView.ChildViewDetachedFromWindowEventArgs> onChildViewDetachedFromWindowHandler = this.OnChildViewDetachedFromWindowHandler;
				if (onChildViewDetachedFromWindowHandler != null)
				{
					onChildViewDetachedFromWindowHandler(this.sender, new RecyclerView.ChildViewDetachedFromWindowEventArgs(view));
				}
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x000137CD File Offset: 0x000119CD
			internal static bool __IsEmpty(RecyclerView.IOnChildAttachStateChangeListenerImplementor value)
			{
				return value.OnChildViewAttachedToWindowHandler == null && value.OnChildViewDetachedFromWindowHandler == null;
			}

			// Token: 0x040001A3 RID: 419
			private object sender;

			// Token: 0x040001A4 RID: 420
			public EventHandler<RecyclerView.ChildViewAttachedToWindowEventArgs> OnChildViewAttachedToWindowHandler;

			// Token: 0x040001A5 RID: 421
			public EventHandler<RecyclerView.ChildViewDetachedFromWindowEventArgs> OnChildViewDetachedFromWindowHandler;
		}

		// Token: 0x02000070 RID: 112
		[Register("androidx/recyclerview/widget/RecyclerView$OnFlingListener", DoNotGenerateAcw = true)]
		public abstract class OnFlingListener : Java.Lang.Object
		{
			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000696 RID: 1686 RVA: 0x000137E4 File Offset: 0x000119E4
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.OnFlingListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000697 RID: 1687 RVA: 0x00013808 File Offset: 0x00011A08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.OnFlingListener._members;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000698 RID: 1688 RVA: 0x00013810 File Offset: 0x00011A10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.OnFlingListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x00013834 File Offset: 0x00011A34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.OnFlingListener._members.ManagedPeerType;
				}
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x000026A8 File Offset: 0x000008A8
			protected OnFlingListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x00013840 File Offset: 0x00011A40
			[Register(".ctor", "()V", "")]
			public OnFlingListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.OnFlingListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.OnFlingListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x000138AE File Offset: 0x00011AAE
			private static Delegate GetOnFling_IIHandler()
			{
				if (RecyclerView.OnFlingListener.cb_onFling_II == null)
				{
					RecyclerView.OnFlingListener.cb_onFling_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(RecyclerView.OnFlingListener.n_OnFling_II));
				}
				return RecyclerView.OnFlingListener.cb_onFling_II;
			}

			// Token: 0x0600069D RID: 1693 RVA: 0x000138D2 File Offset: 0x00011AD2
			private static bool n_OnFling_II(IntPtr jnienv, IntPtr native__this, int velocityX, int velocityY)
			{
				return Java.Lang.Object.GetObject<RecyclerView.OnFlingListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFling(velocityX, velocityY);
			}

			// Token: 0x0600069E RID: 1694
			[Register("onFling", "(II)Z", "GetOnFling_IIHandler")]
			public abstract bool OnFling(int velocityX, int velocityY);

			// Token: 0x040001A6 RID: 422
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnFlingListener", typeof(RecyclerView.OnFlingListener));

			// Token: 0x040001A7 RID: 423
			private static Delegate cb_onFling_II;
		}

		// Token: 0x02000071 RID: 113
		[Register("androidx/recyclerview/widget/RecyclerView$OnFlingListener", DoNotGenerateAcw = true)]
		internal class OnFlingListenerInvoker : RecyclerView.OnFlingListener
		{
			// Token: 0x060006A0 RID: 1696 RVA: 0x000138FE File Offset: 0x00011AFE
			public OnFlingListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00013908 File Offset: 0x00011B08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.OnFlingListenerInvoker._members;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001390F File Offset: 0x00011B0F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.OnFlingListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x0001391C File Offset: 0x00011B1C
			[Register("onFling", "(II)Z", "GetOnFling_IIHandler")]
			public unsafe override bool OnFling(int velocityX, int velocityY)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(velocityX);
				ptr[1] = new JniArgumentValue(velocityY);
				return RecyclerView.OnFlingListenerInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onFling.(II)Z", this, ptr);
			}

			// Token: 0x040001A8 RID: 424
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnFlingListener", typeof(RecyclerView.OnFlingListenerInvoker));
		}

		// Token: 0x02000072 RID: 114
		[Register("androidx/recyclerview/widget/RecyclerView$OnItemTouchListener", "", "AndroidX.RecyclerView.Widget.RecyclerView/IOnItemTouchListenerInvoker")]
		public interface IOnItemTouchListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060006A5 RID: 1701
			[Register("onInterceptTouchEvent", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_Handler:AndroidX.RecyclerView.Widget.RecyclerView/IOnItemTouchListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			bool OnInterceptTouchEvent(RecyclerView recyclerView, MotionEvent @event);

			// Token: 0x060006A6 RID: 1702
			[Register("onRequestDisallowInterceptTouchEvent", "(Z)V", "GetOnRequestDisallowInterceptTouchEvent_ZHandler:AndroidX.RecyclerView.Widget.RecyclerView/IOnItemTouchListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			void OnRequestDisallowInterceptTouchEvent(bool disallow);

			// Token: 0x060006A7 RID: 1703
			[Register("onTouchEvent", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/MotionEvent;)V", "GetOnTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_Handler:AndroidX.RecyclerView.Widget.RecyclerView/IOnItemTouchListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			void OnTouchEvent(RecyclerView recyclerView, MotionEvent @event);
		}

		// Token: 0x02000073 RID: 115
		[Register("androidx/recyclerview/widget/RecyclerView$OnItemTouchListener", DoNotGenerateAcw = true)]
		internal class IOnItemTouchListenerInvoker : Java.Lang.Object, RecyclerView.IOnItemTouchListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00013988 File Offset: 0x00011B88
			private static IntPtr java_class_ref
			{
				get
				{
					return RecyclerView.IOnItemTouchListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000139AC File Offset: 0x00011BAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.IOnItemTouchListenerInvoker._members;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060006AA RID: 1706 RVA: 0x000139B3 File Offset: 0x00011BB3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060006AB RID: 1707 RVA: 0x000139BB File Offset: 0x00011BBB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.IOnItemTouchListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x000139C7 File Offset: 0x00011BC7
			public static RecyclerView.IOnItemTouchListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(handle, transfer);
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x000139D0 File Offset: 0x00011BD0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, RecyclerView.IOnItemTouchListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.OnItemTouchListener'.");
				}
				return handle;
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x000139FB File Offset: 0x00011BFB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x00013A2C File Offset: 0x00011C2C
			public IOnItemTouchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.IOnItemTouchListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x00013A64 File Offset: 0x00011C64
			private static Delegate GetOnInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_Handler()
			{
				if (RecyclerView.IOnItemTouchListenerInvoker.cb_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ == null)
				{
					RecyclerView.IOnItemTouchListenerInvoker.cb_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(RecyclerView.IOnItemTouchListenerInvoker.n_OnInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_));
				}
				return RecyclerView.IOnItemTouchListenerInvoker.cb_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;
			}

			// Token: 0x060006B1 RID: 1713 RVA: 0x00013A88 File Offset: 0x00011C88
			private static bool n_OnInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native__event)
			{
				RecyclerView.IOnItemTouchListener @object = Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				MotionEvent object3 = Java.Lang.Object.GetObject<MotionEvent>(native__event, JniHandleOwnership.DoNotTransfer);
				return @object.OnInterceptTouchEvent(object2, object3);
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x00013AB4 File Offset: 0x00011CB4
			public unsafe bool OnInterceptTouchEvent(RecyclerView recyclerView, MotionEvent @event)
			{
				if (this.id_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onInterceptTouchEvent", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/MotionEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
				ptr[1] = new JValue((@event == null) ? IntPtr.Zero : @event.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x00013B49 File Offset: 0x00011D49
			private static Delegate GetOnRequestDisallowInterceptTouchEvent_ZHandler()
			{
				if (RecyclerView.IOnItemTouchListenerInvoker.cb_onRequestDisallowInterceptTouchEvent_Z == null)
				{
					RecyclerView.IOnItemTouchListenerInvoker.cb_onRequestDisallowInterceptTouchEvent_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(RecyclerView.IOnItemTouchListenerInvoker.n_OnRequestDisallowInterceptTouchEvent_Z));
				}
				return RecyclerView.IOnItemTouchListenerInvoker.cb_onRequestDisallowInterceptTouchEvent_Z;
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x00013B6D File Offset: 0x00011D6D
			private static void n_OnRequestDisallowInterceptTouchEvent_Z(IntPtr jnienv, IntPtr native__this, bool disallow)
			{
				Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRequestDisallowInterceptTouchEvent(disallow);
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x00013B80 File Offset: 0x00011D80
			public unsafe void OnRequestDisallowInterceptTouchEvent(bool disallow)
			{
				if (this.id_onRequestDisallowInterceptTouchEvent_Z == IntPtr.Zero)
				{
					this.id_onRequestDisallowInterceptTouchEvent_Z = JNIEnv.GetMethodID(this.class_ref, "onRequestDisallowInterceptTouchEvent", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(disallow);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestDisallowInterceptTouchEvent_Z, ptr);
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x00013BE4 File Offset: 0x00011DE4
			private static Delegate GetOnTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_Handler()
			{
				if (RecyclerView.IOnItemTouchListenerInvoker.cb_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ == null)
				{
					RecyclerView.IOnItemTouchListenerInvoker.cb_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(RecyclerView.IOnItemTouchListenerInvoker.n_OnTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_));
				}
				return RecyclerView.IOnItemTouchListenerInvoker.cb_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x00013C08 File Offset: 0x00011E08
			private static void n_OnTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native__event)
			{
				RecyclerView.IOnItemTouchListener @object = Java.Lang.Object.GetObject<RecyclerView.IOnItemTouchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				MotionEvent object3 = Java.Lang.Object.GetObject<MotionEvent>(native__event, JniHandleOwnership.DoNotTransfer);
				@object.OnTouchEvent(object2, object3);
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x00013C34 File Offset: 0x00011E34
			public unsafe void OnTouchEvent(RecyclerView recyclerView, MotionEvent @event)
			{
				if (this.id_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onTouchEvent", "(Landroidx/recyclerview/widget/RecyclerView;Landroid/view/MotionEvent;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
				ptr[1] = new JValue((@event == null) ? IntPtr.Zero : @event.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x040001A9 RID: 425
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnItemTouchListener", typeof(RecyclerView.IOnItemTouchListenerInvoker));

			// Token: 0x040001AA RID: 426
			private IntPtr class_ref;

			// Token: 0x040001AB RID: 427
			private static Delegate cb_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;

			// Token: 0x040001AC RID: 428
			private IntPtr id_onInterceptTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;

			// Token: 0x040001AD RID: 429
			private static Delegate cb_onRequestDisallowInterceptTouchEvent_Z;

			// Token: 0x040001AE RID: 430
			private IntPtr id_onRequestDisallowInterceptTouchEvent_Z;

			// Token: 0x040001AF RID: 431
			private static Delegate cb_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;

			// Token: 0x040001B0 RID: 432
			private IntPtr id_onTouchEvent_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_MotionEvent_;
		}

		// Token: 0x02000074 RID: 116
		public class InterceptTouchEventEventArgs : EventArgs
		{
			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x00013CE4 File Offset: 0x00011EE4
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x00013CEC File Offset: 0x00011EEC
			public InterceptTouchEventEventArgs(bool handled, RecyclerView recyclerView, MotionEvent @event)
			{
				this.handled = handled;
				this.recyclerView = recyclerView;
				this.@event = @event;
			}

			// Token: 0x040001B1 RID: 433
			private bool handled;

			// Token: 0x040001B2 RID: 434
			private RecyclerView recyclerView;

			// Token: 0x040001B3 RID: 435
			private MotionEvent @event;
		}

		// Token: 0x02000075 RID: 117
		public class RequestDisallowInterceptTouchEventEventArgs : EventArgs
		{
			// Token: 0x060006BC RID: 1724 RVA: 0x00013D09 File Offset: 0x00011F09
			public RequestDisallowInterceptTouchEventEventArgs(bool disallow)
			{
				this.disallow = disallow;
			}

			// Token: 0x040001B4 RID: 436
			private bool disallow;
		}

		// Token: 0x02000076 RID: 118
		public class TouchEventEventArgs : EventArgs
		{
			// Token: 0x060006BD RID: 1725 RVA: 0x00013D18 File Offset: 0x00011F18
			public TouchEventEventArgs(RecyclerView recyclerView, MotionEvent @event)
			{
				this.recyclerView = recyclerView;
				this.@event = @event;
			}

			// Token: 0x040001B5 RID: 437
			private RecyclerView recyclerView;

			// Token: 0x040001B6 RID: 438
			private MotionEvent @event;
		}

		// Token: 0x02000077 RID: 119
		[Register("mono/androidx/recyclerview/widget/RecyclerView_OnItemTouchListenerImplementor")]
		internal sealed class IOnItemTouchListenerImplementor : Java.Lang.Object, RecyclerView.IOnItemTouchListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060006BE RID: 1726 RVA: 0x00013D2E File Offset: 0x00011F2E
			public IOnItemTouchListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/recyclerview/widget/RecyclerView_OnItemTouchListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00013D68 File Offset: 0x00011F68
			public bool OnInterceptTouchEvent(RecyclerView recyclerView, MotionEvent @event)
			{
				EventHandler<RecyclerView.InterceptTouchEventEventArgs> onInterceptTouchEventHandler = this.OnInterceptTouchEventHandler;
				if (onInterceptTouchEventHandler == null)
				{
					return false;
				}
				RecyclerView.InterceptTouchEventEventArgs interceptTouchEventEventArgs = new RecyclerView.InterceptTouchEventEventArgs(true, recyclerView, @event);
				onInterceptTouchEventHandler(this.sender, interceptTouchEventEventArgs);
				return interceptTouchEventEventArgs.Handled;
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00013DA0 File Offset: 0x00011FA0
			public void OnRequestDisallowInterceptTouchEvent(bool disallow)
			{
				EventHandler<RecyclerView.RequestDisallowInterceptTouchEventEventArgs> onRequestDisallowInterceptTouchEventHandler = this.OnRequestDisallowInterceptTouchEventHandler;
				if (onRequestDisallowInterceptTouchEventHandler != null)
				{
					onRequestDisallowInterceptTouchEventHandler(this.sender, new RecyclerView.RequestDisallowInterceptTouchEventEventArgs(disallow));
				}
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x00013DCC File Offset: 0x00011FCC
			public void OnTouchEvent(RecyclerView recyclerView, MotionEvent @event)
			{
				EventHandler<RecyclerView.TouchEventEventArgs> onTouchEventHandler = this.OnTouchEventHandler;
				if (onTouchEventHandler != null)
				{
					onTouchEventHandler(this.sender, new RecyclerView.TouchEventEventArgs(recyclerView, @event));
				}
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x00013DF6 File Offset: 0x00011FF6
			internal static bool __IsEmpty(RecyclerView.IOnItemTouchListenerImplementor value)
			{
				return value.OnInterceptTouchEventHandler == null && value.OnRequestDisallowInterceptTouchEventHandler == null && value.OnTouchEventHandler == null;
			}

			// Token: 0x040001B7 RID: 439
			private object sender;

			// Token: 0x040001B8 RID: 440
			public EventHandler<RecyclerView.InterceptTouchEventEventArgs> OnInterceptTouchEventHandler;

			// Token: 0x040001B9 RID: 441
			public EventHandler<RecyclerView.RequestDisallowInterceptTouchEventEventArgs> OnRequestDisallowInterceptTouchEventHandler;

			// Token: 0x040001BA RID: 442
			public EventHandler<RecyclerView.TouchEventEventArgs> OnTouchEventHandler;
		}

		// Token: 0x02000078 RID: 120
		[Register("androidx/recyclerview/widget/RecyclerView$OnScrollListener", DoNotGenerateAcw = true)]
		public abstract class OnScrollListener : Java.Lang.Object
		{
			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00013E14 File Offset: 0x00012014
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.OnScrollListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00013E38 File Offset: 0x00012038
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.OnScrollListener._members;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00013E40 File Offset: 0x00012040
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.OnScrollListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00013E64 File Offset: 0x00012064
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.OnScrollListener._members.ManagedPeerType;
				}
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x000026A8 File Offset: 0x000008A8
			protected OnScrollListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x00013E70 File Offset: 0x00012070
			[Register(".ctor", "()V", "")]
			public OnScrollListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.OnScrollListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.OnScrollListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00013EDE File Offset: 0x000120DE
			private static Delegate GetOnScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_IHandler()
			{
				if (RecyclerView.OnScrollListener.cb_onScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I == null)
				{
					RecyclerView.OnScrollListener.cb_onScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RecyclerView.OnScrollListener.n_OnScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I));
				}
				return RecyclerView.OnScrollListener.cb_onScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I;
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x00013F04 File Offset: 0x00012104
			private static void n_OnScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int newState)
			{
				RecyclerView.OnScrollListener @object = Java.Lang.Object.GetObject<RecyclerView.OnScrollListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnScrollStateChanged(object2, newState);
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00013F28 File Offset: 0x00012128
			[Register("onScrollStateChanged", "(Landroidx/recyclerview/widget/RecyclerView;I)V", "GetOnScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_IHandler")]
			public unsafe virtual void OnScrollStateChanged(RecyclerView recyclerView, int newState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(newState);
					RecyclerView.OnScrollListener._members.InstanceMethods.InvokeVirtualVoidMethod("onScrollStateChanged.(Landroidx/recyclerview/widget/RecyclerView;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x00013FA0 File Offset: 0x000121A0
			private static Delegate GetOnScrolled_Landroidx_recyclerview_widget_RecyclerView_IIHandler()
			{
				if (RecyclerView.OnScrollListener.cb_onScrolled_Landroidx_recyclerview_widget_RecyclerView_II == null)
				{
					RecyclerView.OnScrollListener.cb_onScrolled_Landroidx_recyclerview_widget_RecyclerView_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(RecyclerView.OnScrollListener.n_OnScrolled_Landroidx_recyclerview_widget_RecyclerView_II));
				}
				return RecyclerView.OnScrollListener.cb_onScrolled_Landroidx_recyclerview_widget_RecyclerView_II;
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00013FC4 File Offset: 0x000121C4
			private static void n_OnScrolled_Landroidx_recyclerview_widget_RecyclerView_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int dx, int dy)
			{
				RecyclerView.OnScrollListener @object = Java.Lang.Object.GetObject<RecyclerView.OnScrollListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				@object.OnScrolled(object2, dx, dy);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00013FEC File Offset: 0x000121EC
			[Register("onScrolled", "(Landroidx/recyclerview/widget/RecyclerView;II)V", "GetOnScrolled_Landroidx_recyclerview_widget_RecyclerView_IIHandler")]
			public unsafe virtual void OnScrolled(RecyclerView recyclerView, int dx, int dy)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(dx);
					ptr[2] = new JniArgumentValue(dy);
					RecyclerView.OnScrollListener._members.InstanceMethods.InvokeVirtualVoidMethod("onScrolled.(Landroidx/recyclerview/widget/RecyclerView;II)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
			}

			// Token: 0x040001BB RID: 443
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnScrollListener", typeof(RecyclerView.OnScrollListener));

			// Token: 0x040001BC RID: 444
			private static Delegate cb_onScrollStateChanged_Landroidx_recyclerview_widget_RecyclerView_I;

			// Token: 0x040001BD RID: 445
			private static Delegate cb_onScrolled_Landroidx_recyclerview_widget_RecyclerView_II;
		}

		// Token: 0x02000079 RID: 121
		[Register("androidx/recyclerview/widget/RecyclerView$OnScrollListener", DoNotGenerateAcw = true)]
		internal class OnScrollListenerInvoker : RecyclerView.OnScrollListener
		{
			// Token: 0x060006D0 RID: 1744 RVA: 0x00014093 File Offset: 0x00012293
			public OnScrollListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001409D File Offset: 0x0001229D
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.OnScrollListenerInvoker._members;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000140A4 File Offset: 0x000122A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.OnScrollListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040001BE RID: 446
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$OnScrollListener", typeof(RecyclerView.OnScrollListenerInvoker));
		}

		// Token: 0x0200007A RID: 122
		[Register("androidx/recyclerview/widget/RecyclerView$RecycledViewPool", DoNotGenerateAcw = true)]
		public class RecycledViewPool : Java.Lang.Object
		{
			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000140CC File Offset: 0x000122CC
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.RecycledViewPool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060006D5 RID: 1749 RVA: 0x000140F0 File Offset: 0x000122F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.RecycledViewPool._members;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000140F8 File Offset: 0x000122F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.RecycledViewPool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001411C File Offset: 0x0001231C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.RecycledViewPool._members.ManagedPeerType;
				}
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x000026A8 File Offset: 0x000008A8
			protected RecycledViewPool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x00014128 File Offset: 0x00012328
			[Register(".ctor", "()V", "")]
			public RecycledViewPool() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.RecycledViewPool._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.RecycledViewPool._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00014196 File Offset: 0x00012396
			private static Delegate GetClearHandler()
			{
				if (RecyclerView.RecycledViewPool.cb_clear == null)
				{
					RecyclerView.RecycledViewPool.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.RecycledViewPool.n_Clear));
				}
				return RecyclerView.RecycledViewPool.cb_clear;
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x000141BA File Offset: 0x000123BA
			private static void n_Clear(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x000141C9 File Offset: 0x000123C9
			[Register("clear", "()V", "GetClearHandler")]
			public virtual void Clear()
			{
				RecyclerView.RecycledViewPool._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x000141E2 File Offset: 0x000123E2
			private static Delegate GetGetRecycledView_IHandler()
			{
				if (RecyclerView.RecycledViewPool.cb_getRecycledView_I == null)
				{
					RecyclerView.RecycledViewPool.cb_getRecycledView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.RecycledViewPool.n_GetRecycledView_I));
				}
				return RecyclerView.RecycledViewPool.cb_getRecycledView_I;
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00014206 File Offset: 0x00012406
			private static IntPtr n_GetRecycledView_I(IntPtr jnienv, IntPtr native__this, int viewType)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRecycledView(viewType));
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x0001421C File Offset: 0x0001241C
			[Register("getRecycledView", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetGetRecycledView_IHandler")]
			public unsafe virtual RecyclerView.ViewHolder GetRecycledView(int viewType)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(viewType);
				return Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(RecyclerView.RecycledViewPool._members.InstanceMethods.InvokeVirtualObjectMethod("getRecycledView.(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00014265 File Offset: 0x00012465
			private static Delegate GetGetRecycledViewCount_IHandler()
			{
				if (RecyclerView.RecycledViewPool.cb_getRecycledViewCount_I == null)
				{
					RecyclerView.RecycledViewPool.cb_getRecycledViewCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(RecyclerView.RecycledViewPool.n_GetRecycledViewCount_I));
				}
				return RecyclerView.RecycledViewPool.cb_getRecycledViewCount_I;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x00014289 File Offset: 0x00012489
			private static int n_GetRecycledViewCount_I(IntPtr jnienv, IntPtr native__this, int viewType)
			{
				return Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRecycledViewCount(viewType);
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x0001429C File Offset: 0x0001249C
			[Register("getRecycledViewCount", "(I)I", "GetGetRecycledViewCount_IHandler")]
			public unsafe virtual int GetRecycledViewCount(int viewType)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(viewType);
				return RecyclerView.RecycledViewPool._members.InstanceMethods.InvokeVirtualInt32Method("getRecycledViewCount.(I)I", this, ptr);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x000142D7 File Offset: 0x000124D7
			private static Delegate GetPutRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.RecycledViewPool.cb_putRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.RecycledViewPool.cb_putRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.RecycledViewPool.n_PutRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.RecycledViewPool.cb_putRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x000142FC File Offset: 0x000124FC
			private static void n_PutRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_scrap)
			{
				RecyclerView.RecycledViewPool @object = Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_scrap, JniHandleOwnership.DoNotTransfer);
				@object.PutRecycledView(object2);
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x00014320 File Offset: 0x00012520
			[Register("putRecycledView", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetPutRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void PutRecycledView(RecyclerView.ViewHolder scrap)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((scrap == null) ? IntPtr.Zero : scrap.Handle);
					RecyclerView.RecycledViewPool._members.InstanceMethods.InvokeVirtualVoidMethod("putRecycledView.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(scrap);
				}
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x00014384 File Offset: 0x00012584
			private static Delegate GetSetMaxRecycledViews_IIHandler()
			{
				if (RecyclerView.RecycledViewPool.cb_setMaxRecycledViews_II == null)
				{
					RecyclerView.RecycledViewPool.cb_setMaxRecycledViews_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(RecyclerView.RecycledViewPool.n_SetMaxRecycledViews_II));
				}
				return RecyclerView.RecycledViewPool.cb_setMaxRecycledViews_II;
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x000143A8 File Offset: 0x000125A8
			private static void n_SetMaxRecycledViews_II(IntPtr jnienv, IntPtr native__this, int viewType, int max)
			{
				Java.Lang.Object.GetObject<RecyclerView.RecycledViewPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxRecycledViews(viewType, max);
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x000143BC File Offset: 0x000125BC
			[Register("setMaxRecycledViews", "(II)V", "GetSetMaxRecycledViews_IIHandler")]
			public unsafe virtual void SetMaxRecycledViews(int viewType, int max)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(viewType);
				ptr[1] = new JniArgumentValue(max);
				RecyclerView.RecycledViewPool._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxRecycledViews.(II)V", this, ptr);
			}

			// Token: 0x040001BF RID: 447
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$RecycledViewPool", typeof(RecyclerView.RecycledViewPool));

			// Token: 0x040001C0 RID: 448
			private static Delegate cb_clear;

			// Token: 0x040001C1 RID: 449
			private static Delegate cb_getRecycledView_I;

			// Token: 0x040001C2 RID: 450
			private static Delegate cb_getRecycledViewCount_I;

			// Token: 0x040001C3 RID: 451
			private static Delegate cb_putRecycledView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040001C4 RID: 452
			private static Delegate cb_setMaxRecycledViews_II;
		}

		// Token: 0x0200007B RID: 123
		[Register("androidx/recyclerview/widget/RecyclerView$Recycler", DoNotGenerateAcw = true)]
		public sealed class Recycler : Java.Lang.Object
		{
			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x00014428 File Offset: 0x00012628
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.Recycler._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001444C File Offset: 0x0001264C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.Recycler._members;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x00014454 File Offset: 0x00012654
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.Recycler._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x00014478 File Offset: 0x00012678
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.Recycler._members.ManagedPeerType;
				}
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x000026A8 File Offset: 0x000008A8
			internal Recycler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x00014484 File Offset: 0x00012684
			[Register(".ctor", "(Landroidx/recyclerview/widget/RecyclerView;)V", "")]
			public unsafe Recycler(RecyclerView __self) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string constructorSignature = "(L" + JNIEnv.GetJniName(base.GetType().DeclaringType) + ";)V";
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((__self == null) ? IntPtr.Zero : __self.Handle);
					base.SetHandle(RecyclerView.Recycler._members.InstanceMethods.StartCreateInstance(constructorSignature, base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.Recycler._members.InstanceMethods.FinishCreateInstance(constructorSignature, this, ptr);
				}
				finally
				{
					GC.KeepAlive(__self);
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0001454C File Offset: 0x0001274C
			public IList<RecyclerView.ViewHolder> ScrapList
			{
				[Register("getScrapList", "()Ljava/util/List;", "")]
				get
				{
					return JavaList<RecyclerView.ViewHolder>.FromJniHandle(RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractObjectMethod("getScrapList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x00014580 File Offset: 0x00012780
			[Register("bindViewToPosition", "(Landroid/view/View;I)V", "")]
			public unsafe void BindViewToPosition(View view, int position)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue(position);
					RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractVoidMethod("bindViewToPosition.(Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x000145F8 File Offset: 0x000127F8
			[Register("clear", "()V", "")]
			public void Clear()
			{
				RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x00014614 File Offset: 0x00012814
			[Register("convertPreLayoutPositionToPostLayout", "(I)I", "")]
			public unsafe int ConvertPreLayoutPositionToPostLayout(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractInt32Method("convertPreLayoutPositionToPostLayout.(I)I", this, ptr);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00014650 File Offset: 0x00012850
			[Register("getViewForPosition", "(I)Landroid/view/View;", "")]
			public unsafe View GetViewForPosition(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return Java.Lang.Object.GetObject<View>(RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractObjectMethod("getViewForPosition.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x0001469C File Offset: 0x0001289C
			[Register("recycleView", "(Landroid/view/View;)V", "")]
			public unsafe void RecycleView(View view)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractVoidMethod("recycleView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x00014700 File Offset: 0x00012900
			[Register("setViewCacheSize", "(I)V", "")]
			public unsafe void SetViewCacheSize(int viewCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(viewCount);
				RecyclerView.Recycler._members.InstanceMethods.InvokeAbstractVoidMethod("setViewCacheSize.(I)V", this, ptr);
			}

			// Token: 0x040001C5 RID: 453
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$Recycler", typeof(RecyclerView.Recycler));
		}

		// Token: 0x0200007C RID: 124
		[Register("androidx/recyclerview/widget/RecyclerView$RecyclerListener", "", "AndroidX.RecyclerView.Widget.RecyclerView/IRecyclerListenerInvoker")]
		public interface IRecyclerListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060006F8 RID: 1784
			[Register("onViewRecycled", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler:AndroidX.RecyclerView.Widget.RecyclerView/IRecyclerListenerInvoker, Xamarin.AndroidX.RecyclerView")]
			void OnViewRecycled(RecyclerView.ViewHolder holder);
		}

		// Token: 0x0200007D RID: 125
		[Register("androidx/recyclerview/widget/RecyclerView$RecyclerListener", DoNotGenerateAcw = true)]
		internal class IRecyclerListenerInvoker : Java.Lang.Object, RecyclerView.IRecyclerListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00014758 File Offset: 0x00012958
			private static IntPtr java_class_ref
			{
				get
				{
					return RecyclerView.IRecyclerListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060006FA RID: 1786 RVA: 0x0001477C File Offset: 0x0001297C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.IRecyclerListenerInvoker._members;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060006FB RID: 1787 RVA: 0x00014783 File Offset: 0x00012983
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060006FC RID: 1788 RVA: 0x0001478B File Offset: 0x0001298B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.IRecyclerListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060006FD RID: 1789 RVA: 0x00014797 File Offset: 0x00012997
			public static RecyclerView.IRecyclerListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<RecyclerView.IRecyclerListener>(handle, transfer);
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x000147A0 File Offset: 0x000129A0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, RecyclerView.IRecyclerListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.RecyclerListener'.");
				}
				return handle;
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x000147CB File Offset: 0x000129CB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000700 RID: 1792 RVA: 0x000147FC File Offset: 0x000129FC
			public IRecyclerListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.IRecyclerListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x00014834 File Offset: 0x00012A34
			private static Delegate GetOnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (RecyclerView.IRecyclerListenerInvoker.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					RecyclerView.IRecyclerListenerInvoker.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.IRecyclerListenerInvoker.n_OnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return RecyclerView.IRecyclerListenerInvoker.cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00014858 File Offset: 0x00012A58
			private static void n_OnViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RecyclerView.IRecyclerListener @object = Java.Lang.Object.GetObject<RecyclerView.IRecyclerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
				@object.OnViewRecycled(object2);
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x0001487C File Offset: 0x00012A7C
			public unsafe void OnViewRecycled(RecyclerView.ViewHolder holder)
			{
				if (this.id_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				{
					this.id_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID(this.class_ref, "onViewRecycled", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((holder == null) ? IntPtr.Zero : holder.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_, ptr);
			}

			// Token: 0x040001C6 RID: 454
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$RecyclerListener", typeof(RecyclerView.IRecyclerListenerInvoker));

			// Token: 0x040001C7 RID: 455
			private IntPtr class_ref;

			// Token: 0x040001C8 RID: 456
			private static Delegate cb_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x040001C9 RID: 457
			private IntPtr id_onViewRecycled_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
		}

		// Token: 0x0200007E RID: 126
		public class RecyclerEventArgs : EventArgs
		{
			// Token: 0x06000705 RID: 1797 RVA: 0x0001490A File Offset: 0x00012B0A
			public RecyclerEventArgs(RecyclerView.ViewHolder holder)
			{
				this.holder = holder;
			}

			// Token: 0x040001CA RID: 458
			private RecyclerView.ViewHolder holder;
		}

		// Token: 0x0200007F RID: 127
		[Register("mono/androidx/recyclerview/widget/RecyclerView_RecyclerListenerImplementor")]
		internal sealed class IRecyclerListenerImplementor : Java.Lang.Object, RecyclerView.IRecyclerListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000706 RID: 1798 RVA: 0x00014919 File Offset: 0x00012B19
			public IRecyclerListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/recyclerview/widget/RecyclerView_RecyclerListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000707 RID: 1799 RVA: 0x00014954 File Offset: 0x00012B54
			public void OnViewRecycled(RecyclerView.ViewHolder holder)
			{
				EventHandler<RecyclerView.RecyclerEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new RecyclerView.RecyclerEventArgs(holder));
				}
			}

			// Token: 0x06000708 RID: 1800 RVA: 0x0001497D File Offset: 0x00012B7D
			internal static bool __IsEmpty(RecyclerView.IRecyclerListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040001CB RID: 459
			private object sender;

			// Token: 0x040001CC RID: 460
			public EventHandler<RecyclerView.RecyclerEventArgs> Handler;
		}

		// Token: 0x02000080 RID: 128
		[Register("androidx/recyclerview/widget/RecyclerView$SmoothScroller", DoNotGenerateAcw = true)]
		public abstract class SmoothScroller : Java.Lang.Object
		{
			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x00014988 File Offset: 0x00012B88
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.SmoothScroller._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x000149AC File Offset: 0x00012BAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.SmoothScroller._members;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x0600070B RID: 1803 RVA: 0x000149B4 File Offset: 0x00012BB4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.SmoothScroller._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600070C RID: 1804 RVA: 0x000149D8 File Offset: 0x00012BD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.SmoothScroller._members.ManagedPeerType;
				}
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x000026A8 File Offset: 0x000008A8
			protected SmoothScroller(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x000149E4 File Offset: 0x00012BE4
			[Register(".ctor", "()V", "")]
			public SmoothScroller() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.SmoothScroller._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.SmoothScroller._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x00014A52 File Offset: 0x00012C52
			private static Delegate GetGetChildCountHandler()
			{
				if (RecyclerView.SmoothScroller.cb_getChildCount == null)
				{
					RecyclerView.SmoothScroller.cb_getChildCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.SmoothScroller.n_GetChildCount));
				}
				return RecyclerView.SmoothScroller.cb_getChildCount;
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x00014A76 File Offset: 0x00012C76
			private static int n_GetChildCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildCount;
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x00014A85 File Offset: 0x00012C85
			public virtual int ChildCount
			{
				[Register("getChildCount", "()I", "GetGetChildCountHandler")]
				get
				{
					return RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualInt32Method("getChildCount.()I", this, null);
				}
			}

			// Token: 0x06000712 RID: 1810 RVA: 0x00014A9E File Offset: 0x00012C9E
			private static Delegate GetIsPendingInitialRunHandler()
			{
				if (RecyclerView.SmoothScroller.cb_isPendingInitialRun == null)
				{
					RecyclerView.SmoothScroller.cb_isPendingInitialRun = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.SmoothScroller.n_IsPendingInitialRun));
				}
				return RecyclerView.SmoothScroller.cb_isPendingInitialRun;
			}

			// Token: 0x06000713 RID: 1811 RVA: 0x00014AC2 File Offset: 0x00012CC2
			private static bool n_IsPendingInitialRun(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPendingInitialRun;
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000714 RID: 1812 RVA: 0x00014AD1 File Offset: 0x00012CD1
			public virtual bool IsPendingInitialRun
			{
				[Register("isPendingInitialRun", "()Z", "GetIsPendingInitialRunHandler")]
				get
				{
					return RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualBooleanMethod("isPendingInitialRun.()Z", this, null);
				}
			}

			// Token: 0x06000715 RID: 1813 RVA: 0x00014AEA File Offset: 0x00012CEA
			private static Delegate GetIsRunningHandler()
			{
				if (RecyclerView.SmoothScroller.cb_isRunning == null)
				{
					RecyclerView.SmoothScroller.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.SmoothScroller.n_IsRunning));
				}
				return RecyclerView.SmoothScroller.cb_isRunning;
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x00014B0E File Offset: 0x00012D0E
			private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x06000717 RID: 1815 RVA: 0x00014B1D File Offset: 0x00012D1D
			public virtual bool IsRunning
			{
				[Register("isRunning", "()Z", "GetIsRunningHandler")]
				get
				{
					return RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualBooleanMethod("isRunning.()Z", this, null);
				}
			}

			// Token: 0x06000718 RID: 1816 RVA: 0x00014B36 File Offset: 0x00012D36
			private static Delegate GetGetLayoutManagerHandler()
			{
				if (RecyclerView.SmoothScroller.cb_getLayoutManager == null)
				{
					RecyclerView.SmoothScroller.cb_getLayoutManager = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.SmoothScroller.n_GetLayoutManager));
				}
				return RecyclerView.SmoothScroller.cb_getLayoutManager;
			}

			// Token: 0x06000719 RID: 1817 RVA: 0x00014B5A File Offset: 0x00012D5A
			private static IntPtr n_GetLayoutManager(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutManager);
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x0600071A RID: 1818 RVA: 0x00014B70 File Offset: 0x00012D70
			public virtual RecyclerView.LayoutManager LayoutManager
			{
				[Register("getLayoutManager", "()Landroidx/recyclerview/widget/RecyclerView$LayoutManager;", "GetGetLayoutManagerHandler")]
				get
				{
					return Java.Lang.Object.GetObject<RecyclerView.LayoutManager>(RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualObjectMethod("getLayoutManager.()Landroidx/recyclerview/widget/RecyclerView$LayoutManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600071B RID: 1819 RVA: 0x00014BA2 File Offset: 0x00012DA2
			private static Delegate GetGetTargetPositionHandler()
			{
				if (RecyclerView.SmoothScroller.cb_getTargetPosition == null)
				{
					RecyclerView.SmoothScroller.cb_getTargetPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.SmoothScroller.n_GetTargetPosition));
				}
				return RecyclerView.SmoothScroller.cb_getTargetPosition;
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x00014BC6 File Offset: 0x00012DC6
			private static int n_GetTargetPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TargetPosition;
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x00014BD5 File Offset: 0x00012DD5
			private static Delegate GetSetTargetPosition_IHandler()
			{
				if (RecyclerView.SmoothScroller.cb_setTargetPosition_I == null)
				{
					RecyclerView.SmoothScroller.cb_setTargetPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.n_SetTargetPosition_I));
				}
				return RecyclerView.SmoothScroller.cb_setTargetPosition_I;
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x00014BF9 File Offset: 0x00012DF9
			private static void n_SetTargetPosition_I(IntPtr jnienv, IntPtr native__this, int targetPosition)
			{
				Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TargetPosition = targetPosition;
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x0600071F RID: 1823 RVA: 0x00014C09 File Offset: 0x00012E09
			// (set) Token: 0x06000720 RID: 1824 RVA: 0x00014C24 File Offset: 0x00012E24
			public unsafe virtual int TargetPosition
			{
				[Register("getTargetPosition", "()I", "GetGetTargetPositionHandler")]
				get
				{
					return RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualInt32Method("getTargetPosition.()I", this, null);
				}
				[Register("setTargetPosition", "(I)V", "GetSetTargetPosition_IHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualVoidMethod("setTargetPosition.(I)V", this, ptr);
				}
			}

			// Token: 0x06000721 RID: 1825 RVA: 0x00014C5F File Offset: 0x00012E5F
			private static Delegate GetComputeScrollVectorForPosition_IHandler()
			{
				if (RecyclerView.SmoothScroller.cb_computeScrollVectorForPosition_I == null)
				{
					RecyclerView.SmoothScroller.cb_computeScrollVectorForPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.SmoothScroller.n_ComputeScrollVectorForPosition_I));
				}
				return RecyclerView.SmoothScroller.cb_computeScrollVectorForPosition_I;
			}

			// Token: 0x06000722 RID: 1826 RVA: 0x00014C83 File Offset: 0x00012E83
			private static IntPtr n_ComputeScrollVectorForPosition_I(IntPtr jnienv, IntPtr native__this, int targetPosition)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeScrollVectorForPosition(targetPosition));
			}

			// Token: 0x06000723 RID: 1827 RVA: 0x00014C98 File Offset: 0x00012E98
			[Register("computeScrollVectorForPosition", "(I)Landroid/graphics/PointF;", "GetComputeScrollVectorForPosition_IHandler")]
			public unsafe virtual PointF ComputeScrollVectorForPosition(int targetPosition)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(targetPosition);
				return Java.Lang.Object.GetObject<PointF>(RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualObjectMethod("computeScrollVectorForPosition.(I)Landroid/graphics/PointF;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x00014CE1 File Offset: 0x00012EE1
			private static Delegate GetFindViewByPosition_IHandler()
			{
				if (RecyclerView.SmoothScroller.cb_findViewByPosition_I == null)
				{
					RecyclerView.SmoothScroller.cb_findViewByPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.SmoothScroller.n_FindViewByPosition_I));
				}
				return RecyclerView.SmoothScroller.cb_findViewByPosition_I;
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x00014D05 File Offset: 0x00012F05
			private static IntPtr n_FindViewByPosition_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindViewByPosition(position));
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00014D1C File Offset: 0x00012F1C
			[Register("findViewByPosition", "(I)Landroid/view/View;", "GetFindViewByPosition_IHandler")]
			public unsafe virtual View FindViewByPosition(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				return Java.Lang.Object.GetObject<View>(RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualObjectMethod("findViewByPosition.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x00014D65 File Offset: 0x00012F65
			private static Delegate GetGetChildPosition_Landroid_view_View_Handler()
			{
				if (RecyclerView.SmoothScroller.cb_getChildPosition_Landroid_view_View_ == null)
				{
					RecyclerView.SmoothScroller.cb_getChildPosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(RecyclerView.SmoothScroller.n_GetChildPosition_Landroid_view_View_));
				}
				return RecyclerView.SmoothScroller.cb_getChildPosition_Landroid_view_View_;
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x00014D8C File Offset: 0x00012F8C
			private static int n_GetChildPosition_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				RecyclerView.SmoothScroller @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return @object.GetChildPosition(object2);
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x00014DB0 File Offset: 0x00012FB0
			[Register("getChildPosition", "(Landroid/view/View;)I", "GetGetChildPosition_Landroid_view_View_Handler")]
			public unsafe virtual int GetChildPosition(View view)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					result = RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualInt32Method("getChildPosition.(Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return result;
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x00014E18 File Offset: 0x00013018
			private static Delegate GetInstantScrollToPosition_IHandler()
			{
				if (RecyclerView.SmoothScroller.cb_instantScrollToPosition_I == null)
				{
					RecyclerView.SmoothScroller.cb_instantScrollToPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.n_InstantScrollToPosition_I));
				}
				return RecyclerView.SmoothScroller.cb_instantScrollToPosition_I;
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x00014E3C File Offset: 0x0001303C
			private static void n_InstantScrollToPosition_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InstantScrollToPosition(position);
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x00014E4C File Offset: 0x0001304C
			[Register("instantScrollToPosition", "(I)V", "GetInstantScrollToPosition_IHandler")]
			public unsafe virtual void InstantScrollToPosition(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualVoidMethod("instantScrollToPosition.(I)V", this, ptr);
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x00014E87 File Offset: 0x00013087
			private static Delegate GetNormalize_Landroid_graphics_PointF_Handler()
			{
				if (RecyclerView.SmoothScroller.cb_normalize_Landroid_graphics_PointF_ == null)
				{
					RecyclerView.SmoothScroller.cb_normalize_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.SmoothScroller.n_Normalize_Landroid_graphics_PointF_));
				}
				return RecyclerView.SmoothScroller.cb_normalize_Landroid_graphics_PointF_;
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x00014EAC File Offset: 0x000130AC
			private static void n_Normalize_Landroid_graphics_PointF_(IntPtr jnienv, IntPtr native__this, IntPtr native_scrollVector)
			{
				RecyclerView.SmoothScroller @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				PointF object2 = Java.Lang.Object.GetObject<PointF>(native_scrollVector, JniHandleOwnership.DoNotTransfer);
				@object.Normalize(object2);
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x00014ED0 File Offset: 0x000130D0
			[Register("normalize", "(Landroid/graphics/PointF;)V", "GetNormalize_Landroid_graphics_PointF_Handler")]
			protected unsafe virtual void Normalize(PointF scrollVector)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((scrollVector == null) ? IntPtr.Zero : scrollVector.Handle);
					RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualVoidMethod("normalize.(Landroid/graphics/PointF;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(scrollVector);
				}
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x00014F34 File Offset: 0x00013134
			private static Delegate GetOnChildAttachedToWindow_Landroid_view_View_Handler()
			{
				if (RecyclerView.SmoothScroller.cb_onChildAttachedToWindow_Landroid_view_View_ == null)
				{
					RecyclerView.SmoothScroller.cb_onChildAttachedToWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.SmoothScroller.n_OnChildAttachedToWindow_Landroid_view_View_));
				}
				return RecyclerView.SmoothScroller.cb_onChildAttachedToWindow_Landroid_view_View_;
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x00014F58 File Offset: 0x00013158
			private static void n_OnChildAttachedToWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
			{
				RecyclerView.SmoothScroller @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.OnChildAttachedToWindow(object2);
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x00014F7C File Offset: 0x0001317C
			[Register("onChildAttachedToWindow", "(Landroid/view/View;)V", "GetOnChildAttachedToWindow_Landroid_view_View_Handler")]
			protected unsafe virtual void OnChildAttachedToWindow(View child)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					RecyclerView.SmoothScroller._members.InstanceMethods.InvokeVirtualVoidMethod("onChildAttachedToWindow.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(child);
				}
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x00014FE0 File Offset: 0x000131E0
			private static Delegate GetOnSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler()
			{
				if (RecyclerView.SmoothScroller.cb_onSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_ == null)
				{
					RecyclerView.SmoothScroller.cb_onSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_V(RecyclerView.SmoothScroller.n_OnSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_));
				}
				return RecyclerView.SmoothScroller.cb_onSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_;
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x00015004 File Offset: 0x00013204
			private static void n_OnSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
			{
				RecyclerView.SmoothScroller @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object2 = Java.Lang.Object.GetObject<RecyclerView.State>(native_p2, JniHandleOwnership.DoNotTransfer);
				RecyclerView.SmoothScroller.Action object3 = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(native_p3, JniHandleOwnership.DoNotTransfer);
				@object.OnSeekTargetStep(p0, p1, object2, object3);
			}

			// Token: 0x06000735 RID: 1845
			[Register("onSeekTargetStep", "(IILandroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", "GetOnSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler")]
			protected abstract void OnSeekTargetStep(int p0, int p1, RecyclerView.State p2, RecyclerView.SmoothScroller.Action p3);

			// Token: 0x06000736 RID: 1846 RVA: 0x00015034 File Offset: 0x00013234
			private static Delegate GetOnStartHandler()
			{
				if (RecyclerView.SmoothScroller.cb_onStart == null)
				{
					RecyclerView.SmoothScroller.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.SmoothScroller.n_OnStart));
				}
				return RecyclerView.SmoothScroller.cb_onStart;
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x00015058 File Offset: 0x00013258
			private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
			}

			// Token: 0x06000738 RID: 1848
			[Register("onStart", "()V", "GetOnStartHandler")]
			protected abstract void OnStart();

			// Token: 0x06000739 RID: 1849 RVA: 0x00015067 File Offset: 0x00013267
			private static Delegate GetOnStopHandler()
			{
				if (RecyclerView.SmoothScroller.cb_onStop == null)
				{
					RecyclerView.SmoothScroller.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclerView.SmoothScroller.n_OnStop));
				}
				return RecyclerView.SmoothScroller.cb_onStop;
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x0001508B File Offset: 0x0001328B
			private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
			}

			// Token: 0x0600073B RID: 1851
			[Register("onStop", "()V", "GetOnStopHandler")]
			protected abstract void OnStop();

			// Token: 0x0600073C RID: 1852 RVA: 0x0001509A File Offset: 0x0001329A
			private static Delegate GetOnTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler()
			{
				if (RecyclerView.SmoothScroller.cb_onTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_ == null)
				{
					RecyclerView.SmoothScroller.cb_onTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(RecyclerView.SmoothScroller.n_OnTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_));
				}
				return RecyclerView.SmoothScroller.cb_onTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_;
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x000150C0 File Offset: 0x000132C0
			private static void n_OnTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				RecyclerView.SmoothScroller @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				RecyclerView.State object3 = Java.Lang.Object.GetObject<RecyclerView.State>(native_p1, JniHandleOwnership.DoNotTransfer);
				RecyclerView.SmoothScroller.Action object4 = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(native_p2, JniHandleOwnership.DoNotTransfer);
				@object.OnTargetFound(object2, object3, object4);
			}

			// Token: 0x0600073E RID: 1854
			[Register("onTargetFound", "(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", "GetOnTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler")]
			protected abstract void OnTargetFound(View p0, RecyclerView.State p1, RecyclerView.SmoothScroller.Action p2);

			// Token: 0x0600073F RID: 1855 RVA: 0x000150F6 File Offset: 0x000132F6
			[Register("stop", "()V", "")]
			protected void Stop()
			{
				RecyclerView.SmoothScroller._members.InstanceMethods.InvokeNonvirtualVoidMethod("stop.()V", this, null);
			}

			// Token: 0x040001CD RID: 461
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$SmoothScroller", typeof(RecyclerView.SmoothScroller));

			// Token: 0x040001CE RID: 462
			private static Delegate cb_getChildCount;

			// Token: 0x040001CF RID: 463
			private static Delegate cb_isPendingInitialRun;

			// Token: 0x040001D0 RID: 464
			private static Delegate cb_isRunning;

			// Token: 0x040001D1 RID: 465
			private static Delegate cb_getLayoutManager;

			// Token: 0x040001D2 RID: 466
			private static Delegate cb_getTargetPosition;

			// Token: 0x040001D3 RID: 467
			private static Delegate cb_setTargetPosition_I;

			// Token: 0x040001D4 RID: 468
			private static Delegate cb_computeScrollVectorForPosition_I;

			// Token: 0x040001D5 RID: 469
			private static Delegate cb_findViewByPosition_I;

			// Token: 0x040001D6 RID: 470
			private static Delegate cb_getChildPosition_Landroid_view_View_;

			// Token: 0x040001D7 RID: 471
			private static Delegate cb_instantScrollToPosition_I;

			// Token: 0x040001D8 RID: 472
			private static Delegate cb_normalize_Landroid_graphics_PointF_;

			// Token: 0x040001D9 RID: 473
			private static Delegate cb_onChildAttachedToWindow_Landroid_view_View_;

			// Token: 0x040001DA RID: 474
			private static Delegate cb_onSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_;

			// Token: 0x040001DB RID: 475
			private static Delegate cb_onStart;

			// Token: 0x040001DC RID: 476
			private static Delegate cb_onStop;

			// Token: 0x040001DD RID: 477
			private static Delegate cb_onTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_;

			// Token: 0x02000081 RID: 129
			[Register("androidx/recyclerview/widget/RecyclerView$SmoothScroller$Action", DoNotGenerateAcw = true)]
			public class Action : Java.Lang.Object
			{
				// Token: 0x170000E0 RID: 224
				// (get) Token: 0x06000741 RID: 1857 RVA: 0x0001512C File Offset: 0x0001332C
				internal static IntPtr class_ref
				{
					get
					{
						return RecyclerView.SmoothScroller.Action._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000E1 RID: 225
				// (get) Token: 0x06000742 RID: 1858 RVA: 0x00015150 File Offset: 0x00013350
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.SmoothScroller.Action._members;
					}
				}

				// Token: 0x170000E2 RID: 226
				// (get) Token: 0x06000743 RID: 1859 RVA: 0x00015158 File Offset: 0x00013358
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return RecyclerView.SmoothScroller.Action._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000E3 RID: 227
				// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001517C File Offset: 0x0001337C
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.SmoothScroller.Action._members.ManagedPeerType;
					}
				}

				// Token: 0x06000745 RID: 1861 RVA: 0x000026A8 File Offset: 0x000008A8
				protected Action(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x06000746 RID: 1862 RVA: 0x00015188 File Offset: 0x00013388
				[Register(".ctor", "(II)V", "")]
				public unsafe Action(int dx, int dy) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(dx);
					ptr[1] = new JniArgumentValue(dy);
					base.SetHandle(RecyclerView.SmoothScroller.Action._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.SmoothScroller.Action._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
				}

				// Token: 0x06000747 RID: 1863 RVA: 0x00015220 File Offset: 0x00013420
				[Register(".ctor", "(III)V", "")]
				public unsafe Action(int dx, int dy, int duration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(dx);
					ptr[1] = new JniArgumentValue(dy);
					ptr[2] = new JniArgumentValue(duration);
					base.SetHandle(RecyclerView.SmoothScroller.Action._members.InstanceMethods.StartCreateInstance("(III)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.SmoothScroller.Action._members.InstanceMethods.FinishCreateInstance("(III)V", this, ptr);
				}

				// Token: 0x06000748 RID: 1864 RVA: 0x000152D0 File Offset: 0x000134D0
				[Register(".ctor", "(IIILandroid/view/animation/Interpolator;)V", "")]
				public unsafe Action(int dx, int dy, int duration, IInterpolator interpolator) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(dx);
						ptr[1] = new JniArgumentValue(dy);
						ptr[2] = new JniArgumentValue(duration);
						ptr[3] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((Java.Lang.Object)interpolator).Handle);
						base.SetHandle(RecyclerView.SmoothScroller.Action._members.InstanceMethods.StartCreateInstance("(IIILandroid/view/animation/Interpolator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
						RecyclerView.SmoothScroller.Action._members.InstanceMethods.FinishCreateInstance("(IIILandroid/view/animation/Interpolator;)V", this, ptr);
					}
					finally
					{
						GC.KeepAlive(interpolator);
					}
				}

				// Token: 0x06000749 RID: 1865 RVA: 0x000153C4 File Offset: 0x000135C4
				private static Delegate GetGetDurationHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_getDuration == null)
					{
						RecyclerView.SmoothScroller.Action.cb_getDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.SmoothScroller.Action.n_GetDuration));
					}
					return RecyclerView.SmoothScroller.Action.cb_getDuration;
				}

				// Token: 0x0600074A RID: 1866 RVA: 0x000153E8 File Offset: 0x000135E8
				private static int n_GetDuration(IntPtr jnienv, IntPtr native__this)
				{
					return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration;
				}

				// Token: 0x0600074B RID: 1867 RVA: 0x000153F7 File Offset: 0x000135F7
				private static Delegate GetSetDuration_IHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_setDuration_I == null)
					{
						RecyclerView.SmoothScroller.Action.cb_setDuration_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.Action.n_SetDuration_I));
					}
					return RecyclerView.SmoothScroller.Action.cb_setDuration_I;
				}

				// Token: 0x0600074C RID: 1868 RVA: 0x0001541B File Offset: 0x0001361B
				private static void n_SetDuration_I(IntPtr jnienv, IntPtr native__this, int duration)
				{
					Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration = duration;
				}

				// Token: 0x170000E4 RID: 228
				// (get) Token: 0x0600074D RID: 1869 RVA: 0x0001542B File Offset: 0x0001362B
				// (set) Token: 0x0600074E RID: 1870 RVA: 0x00015444 File Offset: 0x00013644
				public unsafe virtual int Duration
				{
					[Register("getDuration", "()I", "GetGetDurationHandler")]
					get
					{
						return RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualInt32Method("getDuration.()I", this, null);
					}
					[Register("setDuration", "(I)V", "GetSetDuration_IHandler")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("setDuration.(I)V", this, ptr);
					}
				}

				// Token: 0x0600074F RID: 1871 RVA: 0x0001547F File Offset: 0x0001367F
				private static Delegate GetGetDxHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_getDx == null)
					{
						RecyclerView.SmoothScroller.Action.cb_getDx = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.SmoothScroller.Action.n_GetDx));
					}
					return RecyclerView.SmoothScroller.Action.cb_getDx;
				}

				// Token: 0x06000750 RID: 1872 RVA: 0x000154A3 File Offset: 0x000136A3
				private static int n_GetDx(IntPtr jnienv, IntPtr native__this)
				{
					return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dx;
				}

				// Token: 0x06000751 RID: 1873 RVA: 0x000154B2 File Offset: 0x000136B2
				private static Delegate GetSetDx_IHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_setDx_I == null)
					{
						RecyclerView.SmoothScroller.Action.cb_setDx_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.Action.n_SetDx_I));
					}
					return RecyclerView.SmoothScroller.Action.cb_setDx_I;
				}

				// Token: 0x06000752 RID: 1874 RVA: 0x000154D6 File Offset: 0x000136D6
				private static void n_SetDx_I(IntPtr jnienv, IntPtr native__this, int dx)
				{
					Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dx = dx;
				}

				// Token: 0x170000E5 RID: 229
				// (get) Token: 0x06000753 RID: 1875 RVA: 0x000154E6 File Offset: 0x000136E6
				// (set) Token: 0x06000754 RID: 1876 RVA: 0x00015500 File Offset: 0x00013700
				public unsafe virtual int Dx
				{
					[Register("getDx", "()I", "GetGetDxHandler")]
					get
					{
						return RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualInt32Method("getDx.()I", this, null);
					}
					[Register("setDx", "(I)V", "GetSetDx_IHandler")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("setDx.(I)V", this, ptr);
					}
				}

				// Token: 0x06000755 RID: 1877 RVA: 0x0001553B File Offset: 0x0001373B
				private static Delegate GetGetDyHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_getDy == null)
					{
						RecyclerView.SmoothScroller.Action.cb_getDy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.SmoothScroller.Action.n_GetDy));
					}
					return RecyclerView.SmoothScroller.Action.cb_getDy;
				}

				// Token: 0x06000756 RID: 1878 RVA: 0x0001555F File Offset: 0x0001375F
				private static int n_GetDy(IntPtr jnienv, IntPtr native__this)
				{
					return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dy;
				}

				// Token: 0x06000757 RID: 1879 RVA: 0x0001556E File Offset: 0x0001376E
				private static Delegate GetSetDy_IHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_setDy_I == null)
					{
						RecyclerView.SmoothScroller.Action.cb_setDy_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.Action.n_SetDy_I));
					}
					return RecyclerView.SmoothScroller.Action.cb_setDy_I;
				}

				// Token: 0x06000758 RID: 1880 RVA: 0x00015592 File Offset: 0x00013792
				private static void n_SetDy_I(IntPtr jnienv, IntPtr native__this, int dy)
				{
					Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dy = dy;
				}

				// Token: 0x170000E6 RID: 230
				// (get) Token: 0x06000759 RID: 1881 RVA: 0x000155A2 File Offset: 0x000137A2
				// (set) Token: 0x0600075A RID: 1882 RVA: 0x000155BC File Offset: 0x000137BC
				public unsafe virtual int Dy
				{
					[Register("getDy", "()I", "GetGetDyHandler")]
					get
					{
						return RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualInt32Method("getDy.()I", this, null);
					}
					[Register("setDy", "(I)V", "GetSetDy_IHandler")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("setDy.(I)V", this, ptr);
					}
				}

				// Token: 0x0600075B RID: 1883 RVA: 0x000155F7 File Offset: 0x000137F7
				private static Delegate GetGetInterpolatorHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_getInterpolator == null)
					{
						RecyclerView.SmoothScroller.Action.cb_getInterpolator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RecyclerView.SmoothScroller.Action.n_GetInterpolator));
					}
					return RecyclerView.SmoothScroller.Action.cb_getInterpolator;
				}

				// Token: 0x0600075C RID: 1884 RVA: 0x0001561B File Offset: 0x0001381B
				private static IntPtr n_GetInterpolator(IntPtr jnienv, IntPtr native__this)
				{
					return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Interpolator);
				}

				// Token: 0x0600075D RID: 1885 RVA: 0x0001562F File Offset: 0x0001382F
				private static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
					{
						RecyclerView.SmoothScroller.Action.cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RecyclerView.SmoothScroller.Action.n_SetInterpolator_Landroid_view_animation_Interpolator_));
					}
					return RecyclerView.SmoothScroller.Action.cb_setInterpolator_Landroid_view_animation_Interpolator_;
				}

				// Token: 0x0600075E RID: 1886 RVA: 0x00015654 File Offset: 0x00013854
				private static void n_SetInterpolator_Landroid_view_animation_Interpolator_(IntPtr jnienv, IntPtr native__this, IntPtr native_interpolator)
				{
					RecyclerView.SmoothScroller.Action @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					IInterpolator object2 = Java.Lang.Object.GetObject<IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
					@object.Interpolator = object2;
				}

				// Token: 0x170000E7 RID: 231
				// (get) Token: 0x0600075F RID: 1887 RVA: 0x00015678 File Offset: 0x00013878
				// (set) Token: 0x06000760 RID: 1888 RVA: 0x000156AC File Offset: 0x000138AC
				public unsafe virtual IInterpolator Interpolator
				{
					[Register("getInterpolator", "()Landroid/view/animation/Interpolator;", "GetGetInterpolatorHandler")]
					get
					{
						return Java.Lang.Object.GetObject<IInterpolator>(RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getInterpolator.()Landroid/view/animation/Interpolator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
					set
					{
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
							RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("setInterpolator.(Landroid/view/animation/Interpolator;)V", this, ptr);
						}
						finally
						{
							GC.KeepAlive(value);
						}
					}
				}

				// Token: 0x06000761 RID: 1889 RVA: 0x00015714 File Offset: 0x00013914
				private static Delegate GetJumpTo_IHandler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_jumpTo_I == null)
					{
						RecyclerView.SmoothScroller.Action.cb_jumpTo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.SmoothScroller.Action.n_JumpTo_I));
					}
					return RecyclerView.SmoothScroller.Action.cb_jumpTo_I;
				}

				// Token: 0x06000762 RID: 1890 RVA: 0x00015738 File Offset: 0x00013938
				private static void n_JumpTo_I(IntPtr jnienv, IntPtr native__this, int targetPosition)
				{
					Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).JumpTo(targetPosition);
				}

				// Token: 0x06000763 RID: 1891 RVA: 0x00015748 File Offset: 0x00013948
				[Register("jumpTo", "(I)V", "GetJumpTo_IHandler")]
				public unsafe virtual void JumpTo(int targetPosition)
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(targetPosition);
					RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("jumpTo.(I)V", this, ptr);
				}

				// Token: 0x06000764 RID: 1892 RVA: 0x00015783 File Offset: 0x00013983
				private static Delegate GetUpdate_IIILandroid_view_animation_Interpolator_Handler()
				{
					if (RecyclerView.SmoothScroller.Action.cb_update_IIILandroid_view_animation_Interpolator_ == null)
					{
						RecyclerView.SmoothScroller.Action.cb_update_IIILandroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_V(RecyclerView.SmoothScroller.Action.n_Update_IIILandroid_view_animation_Interpolator_));
					}
					return RecyclerView.SmoothScroller.Action.cb_update_IIILandroid_view_animation_Interpolator_;
				}

				// Token: 0x06000765 RID: 1893 RVA: 0x000157A8 File Offset: 0x000139A8
				private static void n_Update_IIILandroid_view_animation_Interpolator_(IntPtr jnienv, IntPtr native__this, int dx, int dy, int duration, IntPtr native_interpolator)
				{
					RecyclerView.SmoothScroller.Action @object = Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					IInterpolator object2 = Java.Lang.Object.GetObject<IInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
					@object.Update(dx, dy, duration, object2);
				}

				// Token: 0x06000766 RID: 1894 RVA: 0x000157D0 File Offset: 0x000139D0
				[Register("update", "(IIILandroid/view/animation/Interpolator;)V", "GetUpdate_IIILandroid_view_animation_Interpolator_Handler")]
				public unsafe virtual void Update(int dx, int dy, int duration, IInterpolator interpolator)
				{
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(dx);
						ptr[1] = new JniArgumentValue(dy);
						ptr[2] = new JniArgumentValue(duration);
						ptr[3] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((Java.Lang.Object)interpolator).Handle);
						RecyclerView.SmoothScroller.Action._members.InstanceMethods.InvokeVirtualVoidMethod("update.(IIILandroid/view/animation/Interpolator;)V", this, ptr);
					}
					finally
					{
						GC.KeepAlive(interpolator);
					}
				}

				// Token: 0x040001DE RID: 478
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$SmoothScroller$Action", typeof(RecyclerView.SmoothScroller.Action));

				// Token: 0x040001DF RID: 479
				private static Delegate cb_getDuration;

				// Token: 0x040001E0 RID: 480
				private static Delegate cb_setDuration_I;

				// Token: 0x040001E1 RID: 481
				private static Delegate cb_getDx;

				// Token: 0x040001E2 RID: 482
				private static Delegate cb_setDx_I;

				// Token: 0x040001E3 RID: 483
				private static Delegate cb_getDy;

				// Token: 0x040001E4 RID: 484
				private static Delegate cb_setDy_I;

				// Token: 0x040001E5 RID: 485
				private static Delegate cb_getInterpolator;

				// Token: 0x040001E6 RID: 486
				private static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;

				// Token: 0x040001E7 RID: 487
				private static Delegate cb_jumpTo_I;

				// Token: 0x040001E8 RID: 488
				private static Delegate cb_update_IIILandroid_view_animation_Interpolator_;
			}

			// Token: 0x02000082 RID: 130
			[Register("androidx/recyclerview/widget/RecyclerView$SmoothScroller$ScrollVectorProvider", "", "AndroidX.RecyclerView.Widget.RecyclerView/SmoothScroller/IScrollVectorProviderInvoker")]
			public interface IScrollVectorProvider : IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x06000768 RID: 1896
				[Register("computeScrollVectorForPosition", "(I)Landroid/graphics/PointF;", "GetComputeScrollVectorForPosition_IHandler:AndroidX.RecyclerView.Widget.RecyclerView/SmoothScroller/IScrollVectorProviderInvoker, Xamarin.AndroidX.RecyclerView")]
				PointF ComputeScrollVectorForPosition(int targetPosition);
			}

			// Token: 0x02000083 RID: 131
			[Register("androidx/recyclerview/widget/RecyclerView$SmoothScroller$ScrollVectorProvider", DoNotGenerateAcw = true)]
			internal class IScrollVectorProviderInvoker : Java.Lang.Object, RecyclerView.SmoothScroller.IScrollVectorProvider, IJavaObject, IDisposable, IJavaPeerable
			{
				// Token: 0x170000E8 RID: 232
				// (get) Token: 0x06000769 RID: 1897 RVA: 0x00015898 File Offset: 0x00013A98
				private static IntPtr java_class_ref
				{
					get
					{
						return RecyclerView.SmoothScroller.IScrollVectorProviderInvoker._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000E9 RID: 233
				// (get) Token: 0x0600076A RID: 1898 RVA: 0x000158BC File Offset: 0x00013ABC
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return RecyclerView.SmoothScroller.IScrollVectorProviderInvoker._members;
					}
				}

				// Token: 0x170000EA RID: 234
				// (get) Token: 0x0600076B RID: 1899 RVA: 0x000158C3 File Offset: 0x00013AC3
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return this.class_ref;
					}
				}

				// Token: 0x170000EB RID: 235
				// (get) Token: 0x0600076C RID: 1900 RVA: 0x000158CB File Offset: 0x00013ACB
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return RecyclerView.SmoothScroller.IScrollVectorProviderInvoker._members.ManagedPeerType;
					}
				}

				// Token: 0x0600076D RID: 1901 RVA: 0x000158D7 File Offset: 0x00013AD7
				public static RecyclerView.SmoothScroller.IScrollVectorProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
				{
					return Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.IScrollVectorProvider>(handle, transfer);
				}

				// Token: 0x0600076E RID: 1902 RVA: 0x000158E0 File Offset: 0x00013AE0
				private static IntPtr Validate(IntPtr handle)
				{
					if (!JNIEnv.IsInstanceOf(handle, RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.java_class_ref))
					{
						throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.RecyclerView.SmoothScroller.ScrollVectorProvider'.");
					}
					return handle;
				}

				// Token: 0x0600076F RID: 1903 RVA: 0x0001590B File Offset: 0x00013B0B
				protected override void Dispose(bool disposing)
				{
					if (this.class_ref != IntPtr.Zero)
					{
						JNIEnv.DeleteGlobalRef(this.class_ref);
					}
					this.class_ref = IntPtr.Zero;
					base.Dispose(disposing);
				}

				// Token: 0x06000770 RID: 1904 RVA: 0x0001593C File Offset: 0x00013B3C
				public IScrollVectorProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.Validate(handle), transfer)
				{
					IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
					this.class_ref = JNIEnv.NewGlobalRef(objectClass);
					JNIEnv.DeleteLocalRef(objectClass);
				}

				// Token: 0x06000771 RID: 1905 RVA: 0x00015974 File Offset: 0x00013B74
				private static Delegate GetComputeScrollVectorForPosition_IHandler()
				{
					if (RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.cb_computeScrollVectorForPosition_I == null)
					{
						RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.cb_computeScrollVectorForPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.n_ComputeScrollVectorForPosition_I));
					}
					return RecyclerView.SmoothScroller.IScrollVectorProviderInvoker.cb_computeScrollVectorForPosition_I;
				}

				// Token: 0x06000772 RID: 1906 RVA: 0x00015998 File Offset: 0x00013B98
				private static IntPtr n_ComputeScrollVectorForPosition_I(IntPtr jnienv, IntPtr native__this, int targetPosition)
				{
					return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.SmoothScroller.IScrollVectorProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeScrollVectorForPosition(targetPosition));
				}

				// Token: 0x06000773 RID: 1907 RVA: 0x000159B0 File Offset: 0x00013BB0
				public unsafe PointF ComputeScrollVectorForPosition(int targetPosition)
				{
					if (this.id_computeScrollVectorForPosition_I == IntPtr.Zero)
					{
						this.id_computeScrollVectorForPosition_I = JNIEnv.GetMethodID(this.class_ref, "computeScrollVectorForPosition", "(I)Landroid/graphics/PointF;");
					}
					JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
					*ptr = new JValue(targetPosition);
					return Java.Lang.Object.GetObject<PointF>(JNIEnv.CallObjectMethod(base.Handle, this.id_computeScrollVectorForPosition_I, ptr), JniHandleOwnership.TransferLocalRef);
				}

				// Token: 0x040001E9 RID: 489
				private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$SmoothScroller$ScrollVectorProvider", typeof(RecyclerView.SmoothScroller.IScrollVectorProviderInvoker));

				// Token: 0x040001EA RID: 490
				private IntPtr class_ref;

				// Token: 0x040001EB RID: 491
				private static Delegate cb_computeScrollVectorForPosition_I;

				// Token: 0x040001EC RID: 492
				private IntPtr id_computeScrollVectorForPosition_I;
			}
		}

		// Token: 0x02000084 RID: 132
		[Register("androidx/recyclerview/widget/RecyclerView$SmoothScroller", DoNotGenerateAcw = true)]
		internal class SmoothScrollerInvoker : RecyclerView.SmoothScroller
		{
			// Token: 0x06000775 RID: 1909 RVA: 0x00015A35 File Offset: 0x00013C35
			public SmoothScrollerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000776 RID: 1910 RVA: 0x00015A3F File Offset: 0x00013C3F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.SmoothScrollerInvoker._members;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000777 RID: 1911 RVA: 0x00015A46 File Offset: 0x00013C46
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.SmoothScrollerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x00015A54 File Offset: 0x00013C54
			[Register("onSeekTargetStep", "(IILandroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", "GetOnSeekTargetStep_IILandroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler")]
			protected unsafe override void OnSeekTargetStep(int p0, int p1, RecyclerView.State p2, RecyclerView.SmoothScroller.Action p3)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(p0);
					ptr[1] = new JniArgumentValue(p1);
					ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
					ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
					RecyclerView.SmoothScrollerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSeekTargetStep.(IILandroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p2);
					GC.KeepAlive(p3);
				}
			}

			// Token: 0x06000779 RID: 1913 RVA: 0x00015B10 File Offset: 0x00013D10
			[Register("onStart", "()V", "GetOnStartHandler")]
			protected override void OnStart()
			{
				RecyclerView.SmoothScrollerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onStart.()V", this, null);
			}

			// Token: 0x0600077A RID: 1914 RVA: 0x00015B29 File Offset: 0x00013D29
			[Register("onStop", "()V", "GetOnStopHandler")]
			protected override void OnStop()
			{
				RecyclerView.SmoothScrollerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onStop.()V", this, null);
			}

			// Token: 0x0600077B RID: 1915 RVA: 0x00015B44 File Offset: 0x00013D44
			[Register("onTargetFound", "(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", "GetOnTargetFound_Landroid_view_View_Landroidx_recyclerview_widget_RecyclerView_State_Landroidx_recyclerview_widget_RecyclerView_SmoothScroller_Action_Handler")]
			protected unsafe override void OnTargetFound(View p0, RecyclerView.State p1, RecyclerView.SmoothScroller.Action p2)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
					ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
					RecyclerView.SmoothScrollerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onTargetFound.(Landroid/view/View;Landroidx/recyclerview/widget/RecyclerView$State;Landroidx/recyclerview/widget/RecyclerView$SmoothScroller$Action;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
					GC.KeepAlive(p1);
					GC.KeepAlive(p2);
				}
			}

			// Token: 0x040001ED RID: 493
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$SmoothScroller", typeof(RecyclerView.SmoothScrollerInvoker));
		}

		// Token: 0x02000085 RID: 133
		[Register("androidx/recyclerview/widget/RecyclerView$State", DoNotGenerateAcw = true)]
		public class State : Java.Lang.Object
		{
			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600077D RID: 1917 RVA: 0x00015C18 File Offset: 0x00013E18
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.State._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600077E RID: 1918 RVA: 0x00015C3C File Offset: 0x00013E3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.State._members;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600077F RID: 1919 RVA: 0x00015C44 File Offset: 0x00013E44
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.State._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000780 RID: 1920 RVA: 0x00015C68 File Offset: 0x00013E68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.State._members.ManagedPeerType;
				}
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x000026A8 File Offset: 0x000008A8
			protected State(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x00015C74 File Offset: 0x00013E74
			[Register(".ctor", "()V", "")]
			public State() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.State._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.State._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000783 RID: 1923 RVA: 0x00015CE2 File Offset: 0x00013EE2
			private static Delegate GetHasTargetScrollPositionHandler()
			{
				if (RecyclerView.State.cb_hasTargetScrollPosition == null)
				{
					RecyclerView.State.cb_hasTargetScrollPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_HasTargetScrollPosition));
				}
				return RecyclerView.State.cb_hasTargetScrollPosition;
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x00015D06 File Offset: 0x00013F06
			private static bool n_HasTargetScrollPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasTargetScrollPosition;
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000785 RID: 1925 RVA: 0x00015D15 File Offset: 0x00013F15
			public virtual bool HasTargetScrollPosition
			{
				[Register("hasTargetScrollPosition", "()Z", "GetHasTargetScrollPositionHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("hasTargetScrollPosition.()Z", this, null);
				}
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x00015D2E File Offset: 0x00013F2E
			private static Delegate GetIsMeasuringHandler()
			{
				if (RecyclerView.State.cb_isMeasuring == null)
				{
					RecyclerView.State.cb_isMeasuring = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_IsMeasuring));
				}
				return RecyclerView.State.cb_isMeasuring;
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x00015D52 File Offset: 0x00013F52
			private static bool n_IsMeasuring(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsMeasuring;
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000788 RID: 1928 RVA: 0x00015D61 File Offset: 0x00013F61
			public virtual bool IsMeasuring
			{
				[Register("isMeasuring", "()Z", "GetIsMeasuringHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("isMeasuring.()Z", this, null);
				}
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x00015D7A File Offset: 0x00013F7A
			private static Delegate GetIsPreLayoutHandler()
			{
				if (RecyclerView.State.cb_isPreLayout == null)
				{
					RecyclerView.State.cb_isPreLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_IsPreLayout));
				}
				return RecyclerView.State.cb_isPreLayout;
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x00015D9E File Offset: 0x00013F9E
			private static bool n_IsPreLayout(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPreLayout;
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600078B RID: 1931 RVA: 0x00015DAD File Offset: 0x00013FAD
			public virtual bool IsPreLayout
			{
				[Register("isPreLayout", "()Z", "GetIsPreLayoutHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("isPreLayout.()Z", this, null);
				}
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x00015DC6 File Offset: 0x00013FC6
			private static Delegate GetGetItemCountHandler()
			{
				if (RecyclerView.State.cb_getItemCount == null)
				{
					RecyclerView.State.cb_getItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.State.n_GetItemCount));
				}
				return RecyclerView.State.cb_getItemCount;
			}

			// Token: 0x0600078D RID: 1933 RVA: 0x00015DEA File Offset: 0x00013FEA
			private static int n_GetItemCount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemCount;
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x0600078E RID: 1934 RVA: 0x00015DF9 File Offset: 0x00013FF9
			public virtual int ItemCount
			{
				[Register("getItemCount", "()I", "GetGetItemCountHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualInt32Method("getItemCount.()I", this, null);
				}
			}

			// Token: 0x0600078F RID: 1935 RVA: 0x00015E12 File Offset: 0x00014012
			private static Delegate GetGetRemainingScrollHorizontalHandler()
			{
				if (RecyclerView.State.cb_getRemainingScrollHorizontal == null)
				{
					RecyclerView.State.cb_getRemainingScrollHorizontal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.State.n_GetRemainingScrollHorizontal));
				}
				return RecyclerView.State.cb_getRemainingScrollHorizontal;
			}

			// Token: 0x06000790 RID: 1936 RVA: 0x00015E36 File Offset: 0x00014036
			private static int n_GetRemainingScrollHorizontal(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemainingScrollHorizontal;
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000791 RID: 1937 RVA: 0x00015E45 File Offset: 0x00014045
			public virtual int RemainingScrollHorizontal
			{
				[Register("getRemainingScrollHorizontal", "()I", "GetGetRemainingScrollHorizontalHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualInt32Method("getRemainingScrollHorizontal.()I", this, null);
				}
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x00015E5E File Offset: 0x0001405E
			private static Delegate GetGetRemainingScrollVerticalHandler()
			{
				if (RecyclerView.State.cb_getRemainingScrollVertical == null)
				{
					RecyclerView.State.cb_getRemainingScrollVertical = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.State.n_GetRemainingScrollVertical));
				}
				return RecyclerView.State.cb_getRemainingScrollVertical;
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x00015E82 File Offset: 0x00014082
			private static int n_GetRemainingScrollVertical(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemainingScrollVertical;
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000794 RID: 1940 RVA: 0x00015E91 File Offset: 0x00014091
			public virtual int RemainingScrollVertical
			{
				[Register("getRemainingScrollVertical", "()I", "GetGetRemainingScrollVerticalHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualInt32Method("getRemainingScrollVertical.()I", this, null);
				}
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x00015EAA File Offset: 0x000140AA
			private static Delegate GetGetTargetScrollPositionHandler()
			{
				if (RecyclerView.State.cb_getTargetScrollPosition == null)
				{
					RecyclerView.State.cb_getTargetScrollPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RecyclerView.State.n_GetTargetScrollPosition));
				}
				return RecyclerView.State.cb_getTargetScrollPosition;
			}

			// Token: 0x06000796 RID: 1942 RVA: 0x00015ECE File Offset: 0x000140CE
			private static int n_GetTargetScrollPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TargetScrollPosition;
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000797 RID: 1943 RVA: 0x00015EDD File Offset: 0x000140DD
			public virtual int TargetScrollPosition
			{
				[Register("getTargetScrollPosition", "()I", "GetGetTargetScrollPositionHandler")]
				get
				{
					return RecyclerView.State._members.InstanceMethods.InvokeVirtualInt32Method("getTargetScrollPosition.()I", this, null);
				}
			}

			// Token: 0x06000798 RID: 1944 RVA: 0x00015EF6 File Offset: 0x000140F6
			private static Delegate GetDidStructureChangeHandler()
			{
				if (RecyclerView.State.cb_didStructureChange == null)
				{
					RecyclerView.State.cb_didStructureChange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_DidStructureChange));
				}
				return RecyclerView.State.cb_didStructureChange;
			}

			// Token: 0x06000799 RID: 1945 RVA: 0x00015F1A File Offset: 0x0001411A
			private static bool n_DidStructureChange(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidStructureChange();
			}

			// Token: 0x0600079A RID: 1946 RVA: 0x00015F29 File Offset: 0x00014129
			[Register("didStructureChange", "()Z", "GetDidStructureChangeHandler")]
			public virtual bool DidStructureChange()
			{
				return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("didStructureChange.()Z", this, null);
			}

			// Token: 0x0600079B RID: 1947 RVA: 0x00015F42 File Offset: 0x00014142
			private static Delegate GetGet_IHandler()
			{
				if (RecyclerView.State.cb_get_I == null)
				{
					RecyclerView.State.cb_get_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RecyclerView.State.n_Get_I));
				}
				return RecyclerView.State.cb_get_I;
			}

			// Token: 0x0600079C RID: 1948 RVA: 0x00015F66 File Offset: 0x00014166
			private static IntPtr n_Get_I(IntPtr jnienv, IntPtr native__this, int resourceId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get(resourceId));
			}

			// Token: 0x0600079D RID: 1949 RVA: 0x00015F7C File Offset: 0x0001417C
			[Register("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
			[JavaTypeParameters(new string[]
			{
				"T"
			})]
			public unsafe virtual Java.Lang.Object Get(int resourceId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resourceId);
				return Java.Lang.Object.GetObject<Java.Lang.Object>(RecyclerView.State._members.InstanceMethods.InvokeVirtualObjectMethod("get.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x00015FC5 File Offset: 0x000141C5
			private static Delegate GetPut_ILjava_lang_Object_Handler()
			{
				if (RecyclerView.State.cb_put_ILjava_lang_Object_ == null)
				{
					RecyclerView.State.cb_put_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(RecyclerView.State.n_Put_ILjava_lang_Object_));
				}
				return RecyclerView.State.cb_put_ILjava_lang_Object_;
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x00015FEC File Offset: 0x000141EC
			private static void n_Put_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int resourceId, IntPtr native_data)
			{
				RecyclerView.State @object = Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
				@object.Put(resourceId, object2);
			}

			// Token: 0x060007A0 RID: 1952 RVA: 0x00016010 File Offset: 0x00014210
			[Register("put", "(ILjava/lang/Object;)V", "GetPut_ILjava_lang_Object_Handler")]
			public unsafe virtual void Put(int resourceId, Java.Lang.Object data)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(resourceId);
					ptr[1] = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
					RecyclerView.State._members.InstanceMethods.InvokeVirtualVoidMethod("put.(ILjava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(data);
				}
			}

			// Token: 0x060007A1 RID: 1953 RVA: 0x00016088 File Offset: 0x00014288
			private static Delegate GetRemove_IHandler()
			{
				if (RecyclerView.State.cb_remove_I == null)
				{
					RecyclerView.State.cb_remove_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(RecyclerView.State.n_Remove_I));
				}
				return RecyclerView.State.cb_remove_I;
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x000160AC File Offset: 0x000142AC
			private static void n_Remove_I(IntPtr jnienv, IntPtr native__this, int resourceId)
			{
				Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove(resourceId);
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x000160BC File Offset: 0x000142BC
			[Register("remove", "(I)V", "GetRemove_IHandler")]
			public unsafe virtual void Remove(int resourceId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resourceId);
				RecyclerView.State._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(I)V", this, ptr);
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x000160F7 File Offset: 0x000142F7
			private static Delegate GetWillRunPredictiveAnimationsHandler()
			{
				if (RecyclerView.State.cb_willRunPredictiveAnimations == null)
				{
					RecyclerView.State.cb_willRunPredictiveAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_WillRunPredictiveAnimations));
				}
				return RecyclerView.State.cb_willRunPredictiveAnimations;
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x0001611B File Offset: 0x0001431B
			private static bool n_WillRunPredictiveAnimations(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WillRunPredictiveAnimations();
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x0001612A File Offset: 0x0001432A
			[Register("willRunPredictiveAnimations", "()Z", "GetWillRunPredictiveAnimationsHandler")]
			public virtual bool WillRunPredictiveAnimations()
			{
				return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("willRunPredictiveAnimations.()Z", this, null);
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x00016143 File Offset: 0x00014343
			private static Delegate GetWillRunSimpleAnimationsHandler()
			{
				if (RecyclerView.State.cb_willRunSimpleAnimations == null)
				{
					RecyclerView.State.cb_willRunSimpleAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RecyclerView.State.n_WillRunSimpleAnimations));
				}
				return RecyclerView.State.cb_willRunSimpleAnimations;
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x00016167 File Offset: 0x00014367
			private static bool n_WillRunSimpleAnimations(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RecyclerView.State>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WillRunSimpleAnimations();
			}

			// Token: 0x060007A9 RID: 1961 RVA: 0x00016176 File Offset: 0x00014376
			[Register("willRunSimpleAnimations", "()Z", "GetWillRunSimpleAnimationsHandler")]
			public virtual bool WillRunSimpleAnimations()
			{
				return RecyclerView.State._members.InstanceMethods.InvokeVirtualBooleanMethod("willRunSimpleAnimations.()Z", this, null);
			}

			// Token: 0x040001EE RID: 494
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$State", typeof(RecyclerView.State));

			// Token: 0x040001EF RID: 495
			private static Delegate cb_hasTargetScrollPosition;

			// Token: 0x040001F0 RID: 496
			private static Delegate cb_isMeasuring;

			// Token: 0x040001F1 RID: 497
			private static Delegate cb_isPreLayout;

			// Token: 0x040001F2 RID: 498
			private static Delegate cb_getItemCount;

			// Token: 0x040001F3 RID: 499
			private static Delegate cb_getRemainingScrollHorizontal;

			// Token: 0x040001F4 RID: 500
			private static Delegate cb_getRemainingScrollVertical;

			// Token: 0x040001F5 RID: 501
			private static Delegate cb_getTargetScrollPosition;

			// Token: 0x040001F6 RID: 502
			private static Delegate cb_didStructureChange;

			// Token: 0x040001F7 RID: 503
			private static Delegate cb_get_I;

			// Token: 0x040001F8 RID: 504
			private static Delegate cb_put_ILjava_lang_Object_;

			// Token: 0x040001F9 RID: 505
			private static Delegate cb_remove_I;

			// Token: 0x040001FA RID: 506
			private static Delegate cb_willRunPredictiveAnimations;

			// Token: 0x040001FB RID: 507
			private static Delegate cb_willRunSimpleAnimations;
		}

		// Token: 0x02000086 RID: 134
		[Register("androidx/recyclerview/widget/RecyclerView$ViewCacheExtension", DoNotGenerateAcw = true)]
		public abstract class ViewCacheExtension : Java.Lang.Object
		{
			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060007AB RID: 1963 RVA: 0x000161AC File Offset: 0x000143AC
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.ViewCacheExtension._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x000161D0 File Offset: 0x000143D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ViewCacheExtension._members;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060007AD RID: 1965 RVA: 0x000161D8 File Offset: 0x000143D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.ViewCacheExtension._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x000161FC File Offset: 0x000143FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ViewCacheExtension._members.ManagedPeerType;
				}
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x000026A8 File Offset: 0x000008A8
			protected ViewCacheExtension(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x00016208 File Offset: 0x00014408
			[Register(".ctor", "()V", "")]
			public ViewCacheExtension() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RecyclerView.ViewCacheExtension._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclerView.ViewCacheExtension._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00016276 File Offset: 0x00014476
			private static Delegate GetGetViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_IIHandler()
			{
				if (RecyclerView.ViewCacheExtension.cb_getViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II == null)
				{
					RecyclerView.ViewCacheExtension.cb_getViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(RecyclerView.ViewCacheExtension.n_GetViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II));
				}
				return RecyclerView.ViewCacheExtension.cb_getViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II;
			}

			// Token: 0x060007B2 RID: 1970 RVA: 0x0001629C File Offset: 0x0001449C
			private static IntPtr n_GetViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II(IntPtr jnienv, IntPtr native__this, IntPtr native_recycler, int position, int type)
			{
				RecyclerView.ViewCacheExtension @object = Java.Lang.Object.GetObject<RecyclerView.ViewCacheExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.Recycler object2 = Java.Lang.Object.GetObject<RecyclerView.Recycler>(native_recycler, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.GetViewForPositionAndType(object2, position, type));
			}

			// Token: 0x060007B3 RID: 1971
			[Register("getViewForPositionAndType", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;II)Landroid/view/View;", "GetGetViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_IIHandler")]
			public abstract View GetViewForPositionAndType(RecyclerView.Recycler recycler, int position, int type);

			// Token: 0x040001FC RID: 508
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ViewCacheExtension", typeof(RecyclerView.ViewCacheExtension));

			// Token: 0x040001FD RID: 509
			private static Delegate cb_getViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_II;
		}

		// Token: 0x02000087 RID: 135
		[Register("androidx/recyclerview/widget/RecyclerView$ViewCacheExtension", DoNotGenerateAcw = true)]
		internal class ViewCacheExtensionInvoker : RecyclerView.ViewCacheExtension
		{
			// Token: 0x060007B5 RID: 1973 RVA: 0x000162E2 File Offset: 0x000144E2
			public ViewCacheExtensionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000162EC File Offset: 0x000144EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ViewCacheExtensionInvoker._members;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x000162F3 File Offset: 0x000144F3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ViewCacheExtensionInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x00016300 File Offset: 0x00014500
			[Register("getViewForPositionAndType", "(Landroidx/recyclerview/widget/RecyclerView$Recycler;II)Landroid/view/View;", "GetGetViewForPositionAndType_Landroidx_recyclerview_widget_RecyclerView_Recycler_IIHandler")]
			public unsafe override View GetViewForPositionAndType(RecyclerView.Recycler recycler, int position, int type)
			{
				View @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recycler == null) ? IntPtr.Zero : recycler.Handle);
					ptr[1] = new JniArgumentValue(position);
					ptr[2] = new JniArgumentValue(type);
					@object = Java.Lang.Object.GetObject<View>(RecyclerView.ViewCacheExtensionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getViewForPositionAndType.(Landroidx/recyclerview/widget/RecyclerView$Recycler;II)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(recycler);
				}
				return @object;
			}

			// Token: 0x040001FE RID: 510
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ViewCacheExtension", typeof(RecyclerView.ViewCacheExtensionInvoker));
		}

		// Token: 0x02000088 RID: 136
		[Register("androidx/recyclerview/widget/RecyclerView$ViewHolder", DoNotGenerateAcw = true)]
		public abstract class ViewHolder : Java.Lang.Object
		{
			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060007BA RID: 1978 RVA: 0x000163B8 File Offset: 0x000145B8
			// (set) Token: 0x060007BB RID: 1979 RVA: 0x000163E8 File Offset: 0x000145E8
			[Register("itemView")]
			public View ItemView
			{
				get
				{
					return Java.Lang.Object.GetObject<View>(RecyclerView.ViewHolder._members.InstanceFields.GetObjectValue("itemView.Landroid/view/View;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						RecyclerView.ViewHolder._members.InstanceFields.SetValue("itemView.Landroid/view/View;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060007BC RID: 1980 RVA: 0x00016434 File Offset: 0x00014634
			internal static IntPtr class_ref
			{
				get
				{
					return RecyclerView.ViewHolder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060007BD RID: 1981 RVA: 0x00016458 File Offset: 0x00014658
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ViewHolder._members;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060007BE RID: 1982 RVA: 0x00016460 File Offset: 0x00014660
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RecyclerView.ViewHolder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060007BF RID: 1983 RVA: 0x00016484 File Offset: 0x00014684
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ViewHolder._members.ManagedPeerType;
				}
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x000026A8 File Offset: 0x000008A8
			protected ViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00016490 File Offset: 0x00014690
			[Register(".ctor", "(Landroid/view/View;)V", "")]
			public unsafe ViewHolder(View itemView) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((itemView == null) ? IntPtr.Zero : itemView.Handle);
					base.SetHandle(RecyclerView.ViewHolder._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RecyclerView.ViewHolder._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(itemView);
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00016540 File Offset: 0x00014740
			public int AbsoluteAdapterPosition
			{
				[Register("getAbsoluteAdapterPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getAbsoluteAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00016559 File Offset: 0x00014759
			public int AdapterPosition
			{
				[Register("getAdapterPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00016574 File Offset: 0x00014774
			public RecyclerView.Adapter BindingAdapter
			{
				[Register("getBindingAdapter", "()Landroidx/recyclerview/widget/RecyclerView$Adapter;", "")]
				get
				{
					return Java.Lang.Object.GetObject<RecyclerView.Adapter>(RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBindingAdapter.()Landroidx/recyclerview/widget/RecyclerView$Adapter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060007C5 RID: 1989 RVA: 0x000165A6 File Offset: 0x000147A6
			public int BindingAdapterPosition
			{
				[Register("getBindingAdapterPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getBindingAdapterPosition.()I", this, null);
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000165BF File Offset: 0x000147BF
			// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000165D8 File Offset: 0x000147D8
			public unsafe bool IsRecyclable
			{
				[Register("isRecyclable", "()Z", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isRecyclable.()Z", this, null);
				}
				[Register("setIsRecyclable", "(Z)V", "")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setIsRecyclable.(Z)V", this, ptr);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00016613 File Offset: 0x00014813
			public long ItemId
			{
				[Register("getItemId", "()J", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt64Method("getItemId.()J", this, null);
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0001662C File Offset: 0x0001482C
			public int ItemViewType
			{
				[Register("getItemViewType", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getItemViewType.()I", this, null);
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060007CA RID: 1994 RVA: 0x00016645 File Offset: 0x00014845
			public int LayoutPosition
			{
				[Register("getLayoutPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getLayoutPosition.()I", this, null);
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001665E File Offset: 0x0001485E
			public int OldPosition
			{
				[Register("getOldPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getOldPosition.()I", this, null);
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x00016677 File Offset: 0x00014877
			public int Position
			{
				[Register("getPosition", "()I", "")]
				get
				{
					return RecyclerView.ViewHolder._members.InstanceMethods.InvokeNonvirtualInt32Method("getPosition.()I", this, null);
				}
			}

			// Token: 0x040001FF RID: 511
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ViewHolder", typeof(RecyclerView.ViewHolder));
		}

		// Token: 0x02000089 RID: 137
		[Register("androidx/recyclerview/widget/RecyclerView$ViewHolder", DoNotGenerateAcw = true)]
		internal class ViewHolderInvoker : RecyclerView.ViewHolder
		{
			// Token: 0x060007CE RID: 1998 RVA: 0x000166AB File Offset: 0x000148AB
			public ViewHolderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060007CF RID: 1999 RVA: 0x000166B5 File Offset: 0x000148B5
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RecyclerView.ViewHolderInvoker._members;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000166BC File Offset: 0x000148BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RecyclerView.ViewHolderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x04000200 RID: 512
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/RecyclerView$ViewHolder", typeof(RecyclerView.ViewHolderInvoker));
		}

		// Token: 0x0200008A RID: 138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000201 RID: 513
			public static Func<RecyclerView.IOnChildAttachStateChangeListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x04000202 RID: 514
			public static Func<RecyclerView.IOnItemTouchListenerImplementor, bool> <1>____IsEmpty;

			// Token: 0x04000203 RID: 515
			public static Func<RecyclerView.IRecyclerListenerImplementor, bool> <2>____IsEmpty;
		}
	}
}
