using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.CardView.Widget
{
	// Token: 0x0200000D RID: 13
	[Register("androidx/cardview/widget/CardView", DoNotGenerateAcw = true)]
	public class CardView : FrameLayout
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002068 File Offset: 0x00000268
		internal static IntPtr class_ref
		{
			get
			{
				return CardView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000208C File Offset: 0x0000028C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CardView._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002094 File Offset: 0x00000294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CardView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000020B8 File Offset: 0x000002B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CardView._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020C4 File Offset: 0x000002C4
		protected CardView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020D0 File Offset: 0x000002D0
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CardView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(CardView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CardView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002180 File Offset: 0x00000380
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CardView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CardView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CardView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000225C File Offset: 0x0000045C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CardView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CardView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CardView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000234C File Offset: 0x0000054C
		private static Delegate GetGetCardBackgroundColorHandler()
		{
			if (CardView.cb_getCardBackgroundColor == null)
			{
				CardView.cb_getCardBackgroundColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CardView.n_GetCardBackgroundColor));
			}
			return CardView.cb_getCardBackgroundColor;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002370 File Offset: 0x00000570
		private static IntPtr n_GetCardBackgroundColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CardBackgroundColor);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002384 File Offset: 0x00000584
		private static Delegate GetSetCardBackgroundColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (CardView.cb_setCardBackgroundColor_Landroid_content_res_ColorStateList_ == null)
			{
				CardView.cb_setCardBackgroundColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CardView.n_SetCardBackgroundColor_Landroid_content_res_ColorStateList_));
			}
			return CardView.cb_setCardBackgroundColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000023A8 File Offset: 0x000005A8
		private static void n_SetCardBackgroundColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			CardView @object = Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_color, JniHandleOwnership.DoNotTransfer);
			@object.CardBackgroundColor = object2;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002400 File Offset: 0x00000600
		public unsafe virtual ColorStateList CardBackgroundColor
		{
			[Register("getCardBackgroundColor", "()Landroid/content/res/ColorStateList;", "GetGetCardBackgroundColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(CardView._members.InstanceMethods.InvokeVirtualObjectMethod("getCardBackgroundColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCardBackgroundColor", "(Landroid/content/res/ColorStateList;)V", "GetSetCardBackgroundColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setCardBackgroundColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002464 File Offset: 0x00000664
		private static Delegate GetGetCardElevationHandler()
		{
			if (CardView.cb_getCardElevation == null)
			{
				CardView.cb_getCardElevation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CardView.n_GetCardElevation));
			}
			return CardView.cb_getCardElevation;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002488 File Offset: 0x00000688
		private static float n_GetCardElevation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CardElevation;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002497 File Offset: 0x00000697
		private static Delegate GetSetCardElevation_FHandler()
		{
			if (CardView.cb_setCardElevation_F == null)
			{
				CardView.cb_setCardElevation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CardView.n_SetCardElevation_F));
			}
			return CardView.cb_setCardElevation_F;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024BB File Offset: 0x000006BB
		private static void n_SetCardElevation_F(IntPtr jnienv, IntPtr native__this, float elevation)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CardElevation = elevation;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000024CB File Offset: 0x000006CB
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000024E4 File Offset: 0x000006E4
		public unsafe virtual float CardElevation
		{
			[Register("getCardElevation", "()F", "GetGetCardElevationHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualSingleMethod("getCardElevation.()F", this, null);
			}
			[Register("setCardElevation", "(F)V", "GetSetCardElevation_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setCardElevation.(F)V", this, ptr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000251F File Offset: 0x0000071F
		private static Delegate GetGetContentPaddingBottomHandler()
		{
			if (CardView.cb_getContentPaddingBottom == null)
			{
				CardView.cb_getContentPaddingBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CardView.n_GetContentPaddingBottom));
			}
			return CardView.cb_getContentPaddingBottom;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002543 File Offset: 0x00000743
		private static int n_GetContentPaddingBottom(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentPaddingBottom;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002552 File Offset: 0x00000752
		public virtual int ContentPaddingBottom
		{
			[Register("getContentPaddingBottom", "()I", "GetGetContentPaddingBottomHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualInt32Method("getContentPaddingBottom.()I", this, null);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000256B File Offset: 0x0000076B
		private static Delegate GetGetContentPaddingLeftHandler()
		{
			if (CardView.cb_getContentPaddingLeft == null)
			{
				CardView.cb_getContentPaddingLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CardView.n_GetContentPaddingLeft));
			}
			return CardView.cb_getContentPaddingLeft;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000258F File Offset: 0x0000078F
		private static int n_GetContentPaddingLeft(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentPaddingLeft;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000259E File Offset: 0x0000079E
		public virtual int ContentPaddingLeft
		{
			[Register("getContentPaddingLeft", "()I", "GetGetContentPaddingLeftHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualInt32Method("getContentPaddingLeft.()I", this, null);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000025B7 File Offset: 0x000007B7
		private static Delegate GetGetContentPaddingRightHandler()
		{
			if (CardView.cb_getContentPaddingRight == null)
			{
				CardView.cb_getContentPaddingRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CardView.n_GetContentPaddingRight));
			}
			return CardView.cb_getContentPaddingRight;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000025DB File Offset: 0x000007DB
		private static int n_GetContentPaddingRight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentPaddingRight;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000025EA File Offset: 0x000007EA
		public virtual int ContentPaddingRight
		{
			[Register("getContentPaddingRight", "()I", "GetGetContentPaddingRightHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualInt32Method("getContentPaddingRight.()I", this, null);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002603 File Offset: 0x00000803
		private static Delegate GetGetContentPaddingTopHandler()
		{
			if (CardView.cb_getContentPaddingTop == null)
			{
				CardView.cb_getContentPaddingTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CardView.n_GetContentPaddingTop));
			}
			return CardView.cb_getContentPaddingTop;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002627 File Offset: 0x00000827
		private static int n_GetContentPaddingTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentPaddingTop;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002636 File Offset: 0x00000836
		public virtual int ContentPaddingTop
		{
			[Register("getContentPaddingTop", "()I", "GetGetContentPaddingTopHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualInt32Method("getContentPaddingTop.()I", this, null);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000264F File Offset: 0x0000084F
		private static Delegate GetGetMaxCardElevationHandler()
		{
			if (CardView.cb_getMaxCardElevation == null)
			{
				CardView.cb_getMaxCardElevation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CardView.n_GetMaxCardElevation));
			}
			return CardView.cb_getMaxCardElevation;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002673 File Offset: 0x00000873
		private static float n_GetMaxCardElevation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxCardElevation;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002682 File Offset: 0x00000882
		private static Delegate GetSetMaxCardElevation_FHandler()
		{
			if (CardView.cb_setMaxCardElevation_F == null)
			{
				CardView.cb_setMaxCardElevation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CardView.n_SetMaxCardElevation_F));
			}
			return CardView.cb_setMaxCardElevation_F;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000026A6 File Offset: 0x000008A6
		private static void n_SetMaxCardElevation_F(IntPtr jnienv, IntPtr native__this, float maxElevation)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxCardElevation = maxElevation;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000026B6 File Offset: 0x000008B6
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000026D0 File Offset: 0x000008D0
		public unsafe virtual float MaxCardElevation
		{
			[Register("getMaxCardElevation", "()F", "GetGetMaxCardElevationHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualSingleMethod("getMaxCardElevation.()F", this, null);
			}
			[Register("setMaxCardElevation", "(F)V", "GetSetMaxCardElevation_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxCardElevation.(F)V", this, ptr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000270B File Offset: 0x0000090B
		private static Delegate GetGetPreventCornerOverlapHandler()
		{
			if (CardView.cb_getPreventCornerOverlap == null)
			{
				CardView.cb_getPreventCornerOverlap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CardView.n_GetPreventCornerOverlap));
			}
			return CardView.cb_getPreventCornerOverlap;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000272F File Offset: 0x0000092F
		private static bool n_GetPreventCornerOverlap(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreventCornerOverlap;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000273E File Offset: 0x0000093E
		private static Delegate GetSetPreventCornerOverlap_ZHandler()
		{
			if (CardView.cb_setPreventCornerOverlap_Z == null)
			{
				CardView.cb_setPreventCornerOverlap_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CardView.n_SetPreventCornerOverlap_Z));
			}
			return CardView.cb_setPreventCornerOverlap_Z;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002762 File Offset: 0x00000962
		private static void n_SetPreventCornerOverlap_Z(IntPtr jnienv, IntPtr native__this, bool preventCornerOverlap)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PreventCornerOverlap = preventCornerOverlap;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002772 File Offset: 0x00000972
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000278C File Offset: 0x0000098C
		public unsafe virtual bool PreventCornerOverlap
		{
			[Register("getPreventCornerOverlap", "()Z", "GetGetPreventCornerOverlapHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualBooleanMethod("getPreventCornerOverlap.()Z", this, null);
			}
			[Register("setPreventCornerOverlap", "(Z)V", "GetSetPreventCornerOverlap_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setPreventCornerOverlap.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000027C7 File Offset: 0x000009C7
		private static Delegate GetGetRadiusHandler()
		{
			if (CardView.cb_getRadius == null)
			{
				CardView.cb_getRadius = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CardView.n_GetRadius));
			}
			return CardView.cb_getRadius;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000027EB File Offset: 0x000009EB
		private static float n_GetRadius(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Radius;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000027FA File Offset: 0x000009FA
		private static Delegate GetSetRadius_FHandler()
		{
			if (CardView.cb_setRadius_F == null)
			{
				CardView.cb_setRadius_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CardView.n_SetRadius_F));
			}
			return CardView.cb_setRadius_F;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000281E File Offset: 0x00000A1E
		private static void n_SetRadius_F(IntPtr jnienv, IntPtr native__this, float radius)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Radius = radius;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000282E File Offset: 0x00000A2E
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002848 File Offset: 0x00000A48
		public unsafe virtual float Radius
		{
			[Register("getRadius", "()F", "GetGetRadiusHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualSingleMethod("getRadius.()F", this, null);
			}
			[Register("setRadius", "(F)V", "GetSetRadius_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setRadius.(F)V", this, ptr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002883 File Offset: 0x00000A83
		private static Delegate GetGetUseCompatPaddingHandler()
		{
			if (CardView.cb_getUseCompatPadding == null)
			{
				CardView.cb_getUseCompatPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CardView.n_GetUseCompatPadding));
			}
			return CardView.cb_getUseCompatPadding;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000028A7 File Offset: 0x00000AA7
		private static bool n_GetUseCompatPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseCompatPadding;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000028B6 File Offset: 0x00000AB6
		private static Delegate GetSetUseCompatPadding_ZHandler()
		{
			if (CardView.cb_setUseCompatPadding_Z == null)
			{
				CardView.cb_setUseCompatPadding_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CardView.n_SetUseCompatPadding_Z));
			}
			return CardView.cb_setUseCompatPadding_Z;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000028DA File Offset: 0x00000ADA
		private static void n_SetUseCompatPadding_Z(IntPtr jnienv, IntPtr native__this, bool useCompatPadding)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseCompatPadding = useCompatPadding;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000028EA File Offset: 0x00000AEA
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002904 File Offset: 0x00000B04
		public unsafe virtual bool UseCompatPadding
		{
			[Register("getUseCompatPadding", "()Z", "GetGetUseCompatPaddingHandler")]
			get
			{
				return CardView._members.InstanceMethods.InvokeVirtualBooleanMethod("getUseCompatPadding.()Z", this, null);
			}
			[Register("setUseCompatPadding", "(Z)V", "GetSetUseCompatPadding_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setUseCompatPadding.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000293F File Offset: 0x00000B3F
		private static Delegate GetSetCardBackgroundColor_IHandler()
		{
			if (CardView.cb_setCardBackgroundColor_I == null)
			{
				CardView.cb_setCardBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CardView.n_SetCardBackgroundColor_I));
			}
			return CardView.cb_setCardBackgroundColor_I;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002963 File Offset: 0x00000B63
		private static void n_SetCardBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCardBackgroundColor(color);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002974 File Offset: 0x00000B74
		[Register("setCardBackgroundColor", "(I)V", "GetSetCardBackgroundColor_IHandler")]
		public unsafe virtual void SetCardBackgroundColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setCardBackgroundColor.(I)V", this, ptr);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000029AF File Offset: 0x00000BAF
		private static Delegate GetSetContentPadding_IIIIHandler()
		{
			if (CardView.cb_setContentPadding_IIII == null)
			{
				CardView.cb_setContentPadding_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_V(CardView.n_SetContentPadding_IIII));
			}
			return CardView.cb_setContentPadding_IIII;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000029D3 File Offset: 0x00000BD3
		private static void n_SetContentPadding_IIII(IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			Java.Lang.Object.GetObject<CardView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentPadding(left, top, right, bottom);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Register("setContentPadding", "(IIII)V", "GetSetContentPadding_IIIIHandler")]
		public unsafe virtual void SetContentPadding(int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(left);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(right);
			ptr[3] = new JniArgumentValue(bottom);
			CardView._members.InstanceMethods.InvokeVirtualVoidMethod("setContentPadding.(IIII)V", this, ptr);
		}

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/cardview/widget/CardView", typeof(CardView));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_getCardBackgroundColor;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_setCardBackgroundColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getCardElevation;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_setCardElevation_F;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getContentPaddingBottom;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getContentPaddingLeft;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getContentPaddingRight;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getContentPaddingTop;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getMaxCardElevation;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_setMaxCardElevation_F;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_getPreventCornerOverlap;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_setPreventCornerOverlap_Z;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_getRadius;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_setRadius_F;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_getUseCompatPadding;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_setUseCompatPadding_Z;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_setCardBackgroundColor_I;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_setContentPadding_IIII;
	}
}
