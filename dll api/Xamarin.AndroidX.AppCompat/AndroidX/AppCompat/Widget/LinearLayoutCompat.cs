using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x0200006A RID: 106
	[Register("androidx/appcompat/widget/LinearLayoutCompat", DoNotGenerateAcw = true)]
	public class LinearLayoutCompat : ViewGroup
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00013C4C File Offset: 0x00011E4C
		internal static IntPtr class_ref
		{
			get
			{
				return LinearLayoutCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00013C70 File Offset: 0x00011E70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinearLayoutCompat._members;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00013C78 File Offset: 0x00011E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinearLayoutCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00013C9C File Offset: 0x00011E9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinearLayoutCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000DF8C File Offset: 0x0000C18C
		protected LinearLayoutCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00013CA8 File Offset: 0x00011EA8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LinearLayoutCompat(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(LinearLayoutCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00013D58 File Offset: 0x00011F58
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LinearLayoutCompat(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(LinearLayoutCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00013E34 File Offset: 0x00012034
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LinearLayoutCompat(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(LinearLayoutCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayoutCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00013F24 File Offset: 0x00012124
		private static Delegate GetIsBaselineAlignedHandler()
		{
			if (LinearLayoutCompat.cb_isBaselineAligned == null)
			{
				LinearLayoutCompat.cb_isBaselineAligned = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutCompat.n_IsBaselineAligned));
			}
			return LinearLayoutCompat.cb_isBaselineAligned;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00013F48 File Offset: 0x00012148
		private static bool n_IsBaselineAligned(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BaselineAligned;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00013F57 File Offset: 0x00012157
		private static Delegate GetSetBaselineAligned_ZHandler()
		{
			if (LinearLayoutCompat.cb_setBaselineAligned_Z == null)
			{
				LinearLayoutCompat.cb_setBaselineAligned_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutCompat.n_SetBaselineAligned_Z));
			}
			return LinearLayoutCompat.cb_setBaselineAligned_Z;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00013F7B File Offset: 0x0001217B
		private static void n_SetBaselineAligned_Z(IntPtr jnienv, IntPtr native__this, bool baselineAligned)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BaselineAligned = baselineAligned;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00013F8B File Offset: 0x0001218B
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x00013FA4 File Offset: 0x000121A4
		public unsafe virtual bool BaselineAligned
		{
			[Register("isBaselineAligned", "()Z", "GetIsBaselineAlignedHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isBaselineAligned.()Z", this, null);
			}
			[Register("setBaselineAligned", "(Z)V", "GetSetBaselineAligned_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setBaselineAligned.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00013FDF File Offset: 0x000121DF
		private static Delegate GetGetBaselineAlignedChildIndexHandler()
		{
			if (LinearLayoutCompat.cb_getBaselineAlignedChildIndex == null)
			{
				LinearLayoutCompat.cb_getBaselineAlignedChildIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetBaselineAlignedChildIndex));
			}
			return LinearLayoutCompat.cb_getBaselineAlignedChildIndex;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00014003 File Offset: 0x00012203
		private static int n_GetBaselineAlignedChildIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BaselineAlignedChildIndex;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00014012 File Offset: 0x00012212
		private static Delegate GetSetBaselineAlignedChildIndex_IHandler()
		{
			if (LinearLayoutCompat.cb_setBaselineAlignedChildIndex_I == null)
			{
				LinearLayoutCompat.cb_setBaselineAlignedChildIndex_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetBaselineAlignedChildIndex_I));
			}
			return LinearLayoutCompat.cb_setBaselineAlignedChildIndex_I;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00014036 File Offset: 0x00012236
		private static void n_SetBaselineAlignedChildIndex_I(IntPtr jnienv, IntPtr native__this, int i)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BaselineAlignedChildIndex = i;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00014046 File Offset: 0x00012246
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00014060 File Offset: 0x00012260
		public unsafe virtual int BaselineAlignedChildIndex
		{
			[Register("getBaselineAlignedChildIndex", "()I", "GetGetBaselineAlignedChildIndexHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getBaselineAlignedChildIndex.()I", this, null);
			}
			[Register("setBaselineAlignedChildIndex", "(I)V", "GetSetBaselineAlignedChildIndex_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setBaselineAlignedChildIndex.(I)V", this, ptr);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001409B File Offset: 0x0001229B
		private static Delegate GetGetDividerDrawableHandler()
		{
			if (LinearLayoutCompat.cb_getDividerDrawable == null)
			{
				LinearLayoutCompat.cb_getDividerDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinearLayoutCompat.n_GetDividerDrawable));
			}
			return LinearLayoutCompat.cb_getDividerDrawable;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000140BF File Offset: 0x000122BF
		private static IntPtr n_GetDividerDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerDrawable);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000140D3 File Offset: 0x000122D3
		private static Delegate GetSetDividerDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (LinearLayoutCompat.cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				LinearLayoutCompat.cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LinearLayoutCompat.n_SetDividerDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return LinearLayoutCompat.cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x000140F8 File Offset: 0x000122F8
		private static void n_SetDividerDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_divider)
		{
			LinearLayoutCompat @object = Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_divider, JniHandleOwnership.DoNotTransfer);
			@object.DividerDrawable = object2;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0001411C File Offset: 0x0001231C
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00014150 File Offset: 0x00012350
		public unsafe virtual Drawable DividerDrawable
		{
			[Register("getDividerDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDividerDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(LinearLayoutCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getDividerDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDividerDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setDividerDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000141B4 File Offset: 0x000123B4
		private static Delegate GetGetDividerPaddingHandler()
		{
			if (LinearLayoutCompat.cb_getDividerPadding == null)
			{
				LinearLayoutCompat.cb_getDividerPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetDividerPadding));
			}
			return LinearLayoutCompat.cb_getDividerPadding;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000141D8 File Offset: 0x000123D8
		private static int n_GetDividerPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerPadding;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000141E7 File Offset: 0x000123E7
		private static Delegate GetSetDividerPadding_IHandler()
		{
			if (LinearLayoutCompat.cb_setDividerPadding_I == null)
			{
				LinearLayoutCompat.cb_setDividerPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetDividerPadding_I));
			}
			return LinearLayoutCompat.cb_setDividerPadding_I;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001420B File Offset: 0x0001240B
		private static void n_SetDividerPadding_I(IntPtr jnienv, IntPtr native__this, int padding)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerPadding = padding;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0001421B File Offset: 0x0001241B
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00014234 File Offset: 0x00012434
		public unsafe virtual int DividerPadding
		{
			[Register("getDividerPadding", "()I", "GetGetDividerPaddingHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getDividerPadding.()I", this, null);
			}
			[Register("setDividerPadding", "(I)V", "GetSetDividerPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setDividerPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0001426F File Offset: 0x0001246F
		private static Delegate GetGetDividerWidthHandler()
		{
			if (LinearLayoutCompat.cb_getDividerWidth == null)
			{
				LinearLayoutCompat.cb_getDividerWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetDividerWidth));
			}
			return LinearLayoutCompat.cb_getDividerWidth;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00014293 File Offset: 0x00012493
		private static int n_GetDividerWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DividerWidth;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000142A2 File Offset: 0x000124A2
		public virtual int DividerWidth
		{
			[Register("getDividerWidth", "()I", "GetGetDividerWidthHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getDividerWidth.()I", this, null);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000142BB File Offset: 0x000124BB
		private static Delegate GetGetGravityHandler()
		{
			if (LinearLayoutCompat.cb_getGravity == null)
			{
				LinearLayoutCompat.cb_getGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetGravity));
			}
			return LinearLayoutCompat.cb_getGravity;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000142DF File Offset: 0x000124DF
		private static int n_GetGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Gravity;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000142EE File Offset: 0x000124EE
		private static Delegate GetSetGravity_IHandler()
		{
			if (LinearLayoutCompat.cb_setGravity_I == null)
			{
				LinearLayoutCompat.cb_setGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetGravity_I));
			}
			return LinearLayoutCompat.cb_setGravity_I;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00014312 File Offset: 0x00012512
		private static void n_SetGravity_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Gravity = gravity;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00014322 File Offset: 0x00012522
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0001433C File Offset: 0x0001253C
		public unsafe virtual int Gravity
		{
			[Register("getGravity", "()I", "GetGetGravityHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getGravity.()I", this, null);
			}
			[Register("setGravity", "(I)V", "GetSetGravity_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setGravity.(I)V", this, ptr);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00014377 File Offset: 0x00012577
		private static Delegate GetIsMeasureWithLargestChildEnabledHandler()
		{
			if (LinearLayoutCompat.cb_isMeasureWithLargestChildEnabled == null)
			{
				LinearLayoutCompat.cb_isMeasureWithLargestChildEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LinearLayoutCompat.n_IsMeasureWithLargestChildEnabled));
			}
			return LinearLayoutCompat.cb_isMeasureWithLargestChildEnabled;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001439B File Offset: 0x0001259B
		private static bool n_IsMeasureWithLargestChildEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MeasureWithLargestChildEnabled;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000143AA File Offset: 0x000125AA
		private static Delegate GetSetMeasureWithLargestChildEnabled_ZHandler()
		{
			if (LinearLayoutCompat.cb_setMeasureWithLargestChildEnabled_Z == null)
			{
				LinearLayoutCompat.cb_setMeasureWithLargestChildEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(LinearLayoutCompat.n_SetMeasureWithLargestChildEnabled_Z));
			}
			return LinearLayoutCompat.cb_setMeasureWithLargestChildEnabled_Z;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000143CE File Offset: 0x000125CE
		private static void n_SetMeasureWithLargestChildEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MeasureWithLargestChildEnabled = enabled;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000143DE File Offset: 0x000125DE
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x000143F8 File Offset: 0x000125F8
		public unsafe virtual bool MeasureWithLargestChildEnabled
		{
			[Register("isMeasureWithLargestChildEnabled", "()Z", "GetIsMeasureWithLargestChildEnabledHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isMeasureWithLargestChildEnabled.()Z", this, null);
			}
			[Register("setMeasureWithLargestChildEnabled", "(Z)V", "GetSetMeasureWithLargestChildEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setMeasureWithLargestChildEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00014433 File Offset: 0x00012633
		private static Delegate GetGetOrientationHandler()
		{
			if (LinearLayoutCompat.cb_getOrientation == null)
			{
				LinearLayoutCompat.cb_getOrientation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetOrientation));
			}
			return LinearLayoutCompat.cb_getOrientation;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00014457 File Offset: 0x00012657
		private static int n_GetOrientation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Orientation;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00014466 File Offset: 0x00012666
		private static Delegate GetSetOrientation_IHandler()
		{
			if (LinearLayoutCompat.cb_setOrientation_I == null)
			{
				LinearLayoutCompat.cb_setOrientation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetOrientation_I));
			}
			return LinearLayoutCompat.cb_setOrientation_I;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001448A File Offset: 0x0001268A
		private static void n_SetOrientation_I(IntPtr jnienv, IntPtr native__this, int orientation)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Orientation = orientation;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0001449A File Offset: 0x0001269A
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x000144B4 File Offset: 0x000126B4
		public unsafe virtual int Orientation
		{
			[Register("getOrientation", "()I", "GetGetOrientationHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getOrientation.()I", this, null);
			}
			[Register("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setOrientation.(I)V", this, ptr);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000144EF File Offset: 0x000126EF
		private static Delegate GetGetShowDividersHandler()
		{
			if (LinearLayoutCompat.cb_getShowDividers == null)
			{
				LinearLayoutCompat.cb_getShowDividers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinearLayoutCompat.n_GetShowDividers));
			}
			return LinearLayoutCompat.cb_getShowDividers;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00014513 File Offset: 0x00012713
		private static int n_GetShowDividers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowDividers;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00014522 File Offset: 0x00012722
		private static Delegate GetSetShowDividers_IHandler()
		{
			if (LinearLayoutCompat.cb_setShowDividers_I == null)
			{
				LinearLayoutCompat.cb_setShowDividers_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetShowDividers_I));
			}
			return LinearLayoutCompat.cb_setShowDividers_I;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00014546 File Offset: 0x00012746
		private static void n_SetShowDividers_I(IntPtr jnienv, IntPtr native__this, int showDividers)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowDividers = showDividers;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00014556 File Offset: 0x00012756
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00014570 File Offset: 0x00012770
		public unsafe virtual int ShowDividers
		{
			[Register("getShowDividers", "()I", "GetGetShowDividersHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualInt32Method("getShowDividers.()I", this, null);
			}
			[Register("setShowDividers", "(I)V", "GetSetShowDividers_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setShowDividers.(I)V", this, ptr);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000145AB File Offset: 0x000127AB
		private static Delegate GetGetWeightSumHandler()
		{
			if (LinearLayoutCompat.cb_getWeightSum == null)
			{
				LinearLayoutCompat.cb_getWeightSum = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(LinearLayoutCompat.n_GetWeightSum));
			}
			return LinearLayoutCompat.cb_getWeightSum;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000145CF File Offset: 0x000127CF
		private static float n_GetWeightSum(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WeightSum;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000145DE File Offset: 0x000127DE
		private static Delegate GetSetWeightSum_FHandler()
		{
			if (LinearLayoutCompat.cb_setWeightSum_F == null)
			{
				LinearLayoutCompat.cb_setWeightSum_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(LinearLayoutCompat.n_SetWeightSum_F));
			}
			return LinearLayoutCompat.cb_setWeightSum_F;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00014602 File Offset: 0x00012802
		private static void n_SetWeightSum_F(IntPtr jnienv, IntPtr native__this, float weightSum)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WeightSum = weightSum;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00014612 File Offset: 0x00012812
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0001462C File Offset: 0x0001282C
		public unsafe virtual float WeightSum
		{
			[Register("getWeightSum", "()F", "GetGetWeightSumHandler")]
			get
			{
				return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualSingleMethod("getWeightSum.()F", this, null);
			}
			[Register("setWeightSum", "(F)V", "GetSetWeightSum_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setWeightSum.(F)V", this, ptr);
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00014667 File Offset: 0x00012867
		private static Delegate GetHasDividerBeforeChildAt_IHandler()
		{
			if (LinearLayoutCompat.cb_hasDividerBeforeChildAt_I == null)
			{
				LinearLayoutCompat.cb_hasDividerBeforeChildAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(LinearLayoutCompat.n_HasDividerBeforeChildAt_I));
			}
			return LinearLayoutCompat.cb_hasDividerBeforeChildAt_I;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001468B File Offset: 0x0001288B
		private static bool n_HasDividerBeforeChildAt_I(IntPtr jnienv, IntPtr native__this, int childIndex)
		{
			return Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasDividerBeforeChildAt(childIndex);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001469C File Offset: 0x0001289C
		[Register("hasDividerBeforeChildAt", "(I)Z", "GetHasDividerBeforeChildAt_IHandler")]
		protected unsafe virtual bool HasDividerBeforeChildAt(int childIndex)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(childIndex);
			return LinearLayoutCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasDividerBeforeChildAt.(I)Z", this, ptr);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000146D7 File Offset: 0x000128D7
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (LinearLayoutCompat.cb_onLayout_ZIIII == null)
			{
				LinearLayoutCompat.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(LinearLayoutCompat.n_OnLayout_ZIIII));
			}
			return LinearLayoutCompat.cb_onLayout_ZIIII;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000146FB File Offset: 0x000128FB
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00014714 File Offset: 0x00012914
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000147A6 File Offset: 0x000129A6
		private static Delegate GetSetHorizontalGravity_IHandler()
		{
			if (LinearLayoutCompat.cb_setHorizontalGravity_I == null)
			{
				LinearLayoutCompat.cb_setHorizontalGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetHorizontalGravity_I));
			}
			return LinearLayoutCompat.cb_setHorizontalGravity_I;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000147CA File Offset: 0x000129CA
		private static void n_SetHorizontalGravity_I(IntPtr jnienv, IntPtr native__this, int horizontalGravity)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHorizontalGravity(horizontalGravity);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000147DC File Offset: 0x000129DC
		[Register("setHorizontalGravity", "(I)V", "GetSetHorizontalGravity_IHandler")]
		public unsafe virtual void SetHorizontalGravity(int horizontalGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(horizontalGravity);
			LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setHorizontalGravity.(I)V", this, ptr);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00014817 File Offset: 0x00012A17
		private static Delegate GetSetVerticalGravity_IHandler()
		{
			if (LinearLayoutCompat.cb_setVerticalGravity_I == null)
			{
				LinearLayoutCompat.cb_setVerticalGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LinearLayoutCompat.n_SetVerticalGravity_I));
			}
			return LinearLayoutCompat.cb_setVerticalGravity_I;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001483B File Offset: 0x00012A3B
		private static void n_SetVerticalGravity_I(IntPtr jnienv, IntPtr native__this, int verticalGravity)
		{
			Java.Lang.Object.GetObject<LinearLayoutCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVerticalGravity(verticalGravity);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001484C File Offset: 0x00012A4C
		[Register("setVerticalGravity", "(I)V", "GetSetVerticalGravity_IHandler")]
		public unsafe virtual void SetVerticalGravity(int verticalGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(verticalGravity);
			LinearLayoutCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setVerticalGravity.(I)V", this, ptr);
		}

		// Token: 0x04000225 RID: 549
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/LinearLayoutCompat", typeof(LinearLayoutCompat));

		// Token: 0x04000226 RID: 550
		private static Delegate cb_isBaselineAligned;

		// Token: 0x04000227 RID: 551
		private static Delegate cb_setBaselineAligned_Z;

		// Token: 0x04000228 RID: 552
		private static Delegate cb_getBaselineAlignedChildIndex;

		// Token: 0x04000229 RID: 553
		private static Delegate cb_setBaselineAlignedChildIndex_I;

		// Token: 0x0400022A RID: 554
		private static Delegate cb_getDividerDrawable;

		// Token: 0x0400022B RID: 555
		private static Delegate cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400022C RID: 556
		private static Delegate cb_getDividerPadding;

		// Token: 0x0400022D RID: 557
		private static Delegate cb_setDividerPadding_I;

		// Token: 0x0400022E RID: 558
		private static Delegate cb_getDividerWidth;

		// Token: 0x0400022F RID: 559
		private static Delegate cb_getGravity;

		// Token: 0x04000230 RID: 560
		private static Delegate cb_setGravity_I;

		// Token: 0x04000231 RID: 561
		private static Delegate cb_isMeasureWithLargestChildEnabled;

		// Token: 0x04000232 RID: 562
		private static Delegate cb_setMeasureWithLargestChildEnabled_Z;

		// Token: 0x04000233 RID: 563
		private static Delegate cb_getOrientation;

		// Token: 0x04000234 RID: 564
		private static Delegate cb_setOrientation_I;

		// Token: 0x04000235 RID: 565
		private static Delegate cb_getShowDividers;

		// Token: 0x04000236 RID: 566
		private static Delegate cb_setShowDividers_I;

		// Token: 0x04000237 RID: 567
		private static Delegate cb_getWeightSum;

		// Token: 0x04000238 RID: 568
		private static Delegate cb_setWeightSum_F;

		// Token: 0x04000239 RID: 569
		private static Delegate cb_hasDividerBeforeChildAt_I;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x0400023B RID: 571
		private static Delegate cb_setHorizontalGravity_I;

		// Token: 0x0400023C RID: 572
		private static Delegate cb_setVerticalGravity_I;
	}
}
