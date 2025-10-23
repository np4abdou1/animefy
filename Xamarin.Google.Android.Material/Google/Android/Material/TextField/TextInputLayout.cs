using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Core.View;
using Google.Android.Material.Shape;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.TextField
{
	// Token: 0x02000066 RID: 102
	[Register("com/google/android/material/textfield/TextInputLayout", DoNotGenerateAcw = true)]
	public class TextInputLayout : LinearLayout
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000F195 File Offset: 0x0000D395
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000F19D File Offset: 0x0000D39D
		public override bool Enabled
		{
			get
			{
				return base.Enabled;
			}
			set
			{
				base.Enabled = value;
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000F1A6 File Offset: 0x0000D3A6
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		internal static IntPtr class_ref
		{
			get
			{
				return TextInputLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextInputLayout._members;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextInputLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000F200 File Offset: 0x0000D400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextInputLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000086B0 File Offset: 0x000068B0
		protected TextInputLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000F20C File Offset: 0x0000D40C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TextInputLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(TextInputLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextInputLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TextInputLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(TextInputLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextInputLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000F398 File Offset: 0x0000D598
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TextInputLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(TextInputLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextInputLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000F488 File Offset: 0x0000D688
		private static Delegate GetGetBoxBackgroundColorHandler()
		{
			if (TextInputLayout.cb_getBoxBackgroundColor == null)
			{
				TextInputLayout.cb_getBoxBackgroundColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxBackgroundColor));
			}
			return TextInputLayout.cb_getBoxBackgroundColor;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		private static int n_GetBoxBackgroundColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxBackgroundColor;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000F4BB File Offset: 0x0000D6BB
		private static Delegate GetSetBoxBackgroundColor_IHandler()
		{
			if (TextInputLayout.cb_setBoxBackgroundColor_I == null)
			{
				TextInputLayout.cb_setBoxBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxBackgroundColor_I));
			}
			return TextInputLayout.cb_setBoxBackgroundColor_I;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000F4DF File Offset: 0x0000D6DF
		private static void n_SetBoxBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int boxBackgroundColor)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxBackgroundColor = boxBackgroundColor;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000F4EF File Offset: 0x0000D6EF
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0000F508 File Offset: 0x0000D708
		public unsafe virtual int BoxBackgroundColor
		{
			[Register("getBoxBackgroundColor", "()I", "GetGetBoxBackgroundColorHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxBackgroundColor.()I", this, null);
			}
			[Register("setBoxBackgroundColor", "(I)V", "GetSetBoxBackgroundColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxBackgroundColor.(I)V", this, ptr);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000F543 File Offset: 0x0000D743
		private static Delegate GetGetBoxBackgroundModeHandler()
		{
			if (TextInputLayout.cb_getBoxBackgroundMode == null)
			{
				TextInputLayout.cb_getBoxBackgroundMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxBackgroundMode));
			}
			return TextInputLayout.cb_getBoxBackgroundMode;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000F567 File Offset: 0x0000D767
		private static int n_GetBoxBackgroundMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxBackgroundMode;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000F576 File Offset: 0x0000D776
		private static Delegate GetSetBoxBackgroundMode_IHandler()
		{
			if (TextInputLayout.cb_setBoxBackgroundMode_I == null)
			{
				TextInputLayout.cb_setBoxBackgroundMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxBackgroundMode_I));
			}
			return TextInputLayout.cb_setBoxBackgroundMode_I;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000F59A File Offset: 0x0000D79A
		private static void n_SetBoxBackgroundMode_I(IntPtr jnienv, IntPtr native__this, int boxBackgroundMode)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxBackgroundMode = boxBackgroundMode;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0000F5AA File Offset: 0x0000D7AA
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public unsafe virtual int BoxBackgroundMode
		{
			[Register("getBoxBackgroundMode", "()I", "GetGetBoxBackgroundModeHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxBackgroundMode.()I", this, null);
			}
			[Register("setBoxBackgroundMode", "(I)V", "GetSetBoxBackgroundMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxBackgroundMode.(I)V", this, ptr);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000F5FF File Offset: 0x0000D7FF
		private static Delegate GetGetBoxCollapsedPaddingTopHandler()
		{
			if (TextInputLayout.cb_getBoxCollapsedPaddingTop == null)
			{
				TextInputLayout.cb_getBoxCollapsedPaddingTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxCollapsedPaddingTop));
			}
			return TextInputLayout.cb_getBoxCollapsedPaddingTop;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000F623 File Offset: 0x0000D823
		private static int n_GetBoxCollapsedPaddingTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCollapsedPaddingTop;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000F632 File Offset: 0x0000D832
		private static Delegate GetSetBoxCollapsedPaddingTop_IHandler()
		{
			if (TextInputLayout.cb_setBoxCollapsedPaddingTop_I == null)
			{
				TextInputLayout.cb_setBoxCollapsedPaddingTop_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxCollapsedPaddingTop_I));
			}
			return TextInputLayout.cb_setBoxCollapsedPaddingTop_I;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000F656 File Offset: 0x0000D856
		private static void n_SetBoxCollapsedPaddingTop_I(IntPtr jnienv, IntPtr native__this, int boxCollapsedPaddingTop)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCollapsedPaddingTop = boxCollapsedPaddingTop;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0000F666 File Offset: 0x0000D866
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0000F680 File Offset: 0x0000D880
		public unsafe virtual int BoxCollapsedPaddingTop
		{
			[Register("getBoxCollapsedPaddingTop", "()I", "GetGetBoxCollapsedPaddingTopHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxCollapsedPaddingTop.()I", this, null);
			}
			[Register("setBoxCollapsedPaddingTop", "(I)V", "GetSetBoxCollapsedPaddingTop_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxCollapsedPaddingTop.(I)V", this, ptr);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		private static Delegate GetGetBoxCornerRadiusBottomEndHandler()
		{
			if (TextInputLayout.cb_getBoxCornerRadiusBottomEnd == null)
			{
				TextInputLayout.cb_getBoxCornerRadiusBottomEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(TextInputLayout.n_GetBoxCornerRadiusBottomEnd));
			}
			return TextInputLayout.cb_getBoxCornerRadiusBottomEnd;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000F6DF File Offset: 0x0000D8DF
		private static float n_GetBoxCornerRadiusBottomEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCornerRadiusBottomEnd;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000F6EE File Offset: 0x0000D8EE
		public virtual float BoxCornerRadiusBottomEnd
		{
			[Register("getBoxCornerRadiusBottomEnd", "()F", "GetGetBoxCornerRadiusBottomEndHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getBoxCornerRadiusBottomEnd.()F", this, null);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000F707 File Offset: 0x0000D907
		private static Delegate GetGetBoxCornerRadiusBottomStartHandler()
		{
			if (TextInputLayout.cb_getBoxCornerRadiusBottomStart == null)
			{
				TextInputLayout.cb_getBoxCornerRadiusBottomStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(TextInputLayout.n_GetBoxCornerRadiusBottomStart));
			}
			return TextInputLayout.cb_getBoxCornerRadiusBottomStart;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000F72B File Offset: 0x0000D92B
		private static float n_GetBoxCornerRadiusBottomStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCornerRadiusBottomStart;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000F73A File Offset: 0x0000D93A
		public virtual float BoxCornerRadiusBottomStart
		{
			[Register("getBoxCornerRadiusBottomStart", "()F", "GetGetBoxCornerRadiusBottomStartHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getBoxCornerRadiusBottomStart.()F", this, null);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000F753 File Offset: 0x0000D953
		private static Delegate GetGetBoxCornerRadiusTopEndHandler()
		{
			if (TextInputLayout.cb_getBoxCornerRadiusTopEnd == null)
			{
				TextInputLayout.cb_getBoxCornerRadiusTopEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(TextInputLayout.n_GetBoxCornerRadiusTopEnd));
			}
			return TextInputLayout.cb_getBoxCornerRadiusTopEnd;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000F777 File Offset: 0x0000D977
		private static float n_GetBoxCornerRadiusTopEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCornerRadiusTopEnd;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000F786 File Offset: 0x0000D986
		public virtual float BoxCornerRadiusTopEnd
		{
			[Register("getBoxCornerRadiusTopEnd", "()F", "GetGetBoxCornerRadiusTopEndHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getBoxCornerRadiusTopEnd.()F", this, null);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000F79F File Offset: 0x0000D99F
		private static Delegate GetGetBoxCornerRadiusTopStartHandler()
		{
			if (TextInputLayout.cb_getBoxCornerRadiusTopStart == null)
			{
				TextInputLayout.cb_getBoxCornerRadiusTopStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(TextInputLayout.n_GetBoxCornerRadiusTopStart));
			}
			return TextInputLayout.cb_getBoxCornerRadiusTopStart;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000F7C3 File Offset: 0x0000D9C3
		private static float n_GetBoxCornerRadiusTopStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxCornerRadiusTopStart;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000F7D2 File Offset: 0x0000D9D2
		public virtual float BoxCornerRadiusTopStart
		{
			[Register("getBoxCornerRadiusTopStart", "()F", "GetGetBoxCornerRadiusTopStartHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getBoxCornerRadiusTopStart.()F", this, null);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000F7EB File Offset: 0x0000D9EB
		private static Delegate GetGetBoxStrokeColorHandler()
		{
			if (TextInputLayout.cb_getBoxStrokeColor == null)
			{
				TextInputLayout.cb_getBoxStrokeColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxStrokeColor));
			}
			return TextInputLayout.cb_getBoxStrokeColor;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000F80F File Offset: 0x0000DA0F
		private static int n_GetBoxStrokeColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeColor;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000F81E File Offset: 0x0000DA1E
		private static Delegate GetSetBoxStrokeColor_IHandler()
		{
			if (TextInputLayout.cb_setBoxStrokeColor_I == null)
			{
				TextInputLayout.cb_setBoxStrokeColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxStrokeColor_I));
			}
			return TextInputLayout.cb_setBoxStrokeColor_I;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000F842 File Offset: 0x0000DA42
		private static void n_SetBoxStrokeColor_I(IntPtr jnienv, IntPtr native__this, int boxStrokeColor)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeColor = boxStrokeColor;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000F852 File Offset: 0x0000DA52
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000F86C File Offset: 0x0000DA6C
		public unsafe virtual int BoxStrokeColor
		{
			[Register("getBoxStrokeColor", "()I", "GetGetBoxStrokeColorHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxStrokeColor.()I", this, null);
			}
			[Register("setBoxStrokeColor", "(I)V", "GetSetBoxStrokeColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeColor.(I)V", this, ptr);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000F8A7 File Offset: 0x0000DAA7
		private static Delegate GetGetBoxStrokeErrorColorHandler()
		{
			if (TextInputLayout.cb_getBoxStrokeErrorColor == null)
			{
				TextInputLayout.cb_getBoxStrokeErrorColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetBoxStrokeErrorColor));
			}
			return TextInputLayout.cb_getBoxStrokeErrorColor;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000F8CB File Offset: 0x0000DACB
		private static IntPtr n_GetBoxStrokeErrorColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeErrorColor);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000F8DF File Offset: 0x0000DADF
		private static Delegate GetSetBoxStrokeErrorColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setBoxStrokeErrorColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setBoxStrokeErrorColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetBoxStrokeErrorColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setBoxStrokeErrorColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000F904 File Offset: 0x0000DB04
		private static void n_SetBoxStrokeErrorColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_strokeErrorColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_strokeErrorColor, JniHandleOwnership.DoNotTransfer);
			@object.BoxStrokeErrorColor = object2;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000F928 File Offset: 0x0000DB28
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000F95C File Offset: 0x0000DB5C
		public unsafe virtual ColorStateList BoxStrokeErrorColor
		{
			[Register("getBoxStrokeErrorColor", "()Landroid/content/res/ColorStateList;", "GetGetBoxStrokeErrorColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getBoxStrokeErrorColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setBoxStrokeErrorColor", "(Landroid/content/res/ColorStateList;)V", "GetSetBoxStrokeErrorColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeErrorColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		private static Delegate GetGetBoxStrokeWidthHandler()
		{
			if (TextInputLayout.cb_getBoxStrokeWidth == null)
			{
				TextInputLayout.cb_getBoxStrokeWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxStrokeWidth));
			}
			return TextInputLayout.cb_getBoxStrokeWidth;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000F9E4 File Offset: 0x0000DBE4
		private static int n_GetBoxStrokeWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeWidth;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000F9F3 File Offset: 0x0000DBF3
		private static Delegate GetSetBoxStrokeWidth_IHandler()
		{
			if (TextInputLayout.cb_setBoxStrokeWidth_I == null)
			{
				TextInputLayout.cb_setBoxStrokeWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxStrokeWidth_I));
			}
			return TextInputLayout.cb_setBoxStrokeWidth_I;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000FA17 File Offset: 0x0000DC17
		private static void n_SetBoxStrokeWidth_I(IntPtr jnienv, IntPtr native__this, int boxStrokeWidth)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeWidth = boxStrokeWidth;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000FA27 File Offset: 0x0000DC27
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000FA40 File Offset: 0x0000DC40
		public unsafe virtual int BoxStrokeWidth
		{
			[Register("getBoxStrokeWidth", "()I", "GetGetBoxStrokeWidthHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxStrokeWidth.()I", this, null);
			}
			[Register("setBoxStrokeWidth", "(I)V", "GetSetBoxStrokeWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000FA7B File Offset: 0x0000DC7B
		private static Delegate GetGetBoxStrokeWidthFocusedHandler()
		{
			if (TextInputLayout.cb_getBoxStrokeWidthFocused == null)
			{
				TextInputLayout.cb_getBoxStrokeWidthFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetBoxStrokeWidthFocused));
			}
			return TextInputLayout.cb_getBoxStrokeWidthFocused;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000FA9F File Offset: 0x0000DC9F
		private static int n_GetBoxStrokeWidthFocused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeWidthFocused;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000FAAE File Offset: 0x0000DCAE
		private static Delegate GetSetBoxStrokeWidthFocused_IHandler()
		{
			if (TextInputLayout.cb_setBoxStrokeWidthFocused_I == null)
			{
				TextInputLayout.cb_setBoxStrokeWidthFocused_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxStrokeWidthFocused_I));
			}
			return TextInputLayout.cb_setBoxStrokeWidthFocused_I;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000FAD2 File Offset: 0x0000DCD2
		private static void n_SetBoxStrokeWidthFocused_I(IntPtr jnienv, IntPtr native__this, int boxStrokeWidthFocused)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoxStrokeWidthFocused = boxStrokeWidthFocused;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000FAE2 File Offset: 0x0000DCE2
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		public unsafe virtual int BoxStrokeWidthFocused
		{
			[Register("getBoxStrokeWidthFocused", "()I", "GetGetBoxStrokeWidthFocusedHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getBoxStrokeWidthFocused.()I", this, null);
			}
			[Register("setBoxStrokeWidthFocused", "(I)V", "GetSetBoxStrokeWidthFocused_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeWidthFocused.(I)V", this, ptr);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000FB37 File Offset: 0x0000DD37
		private static Delegate GetIsCounterEnabledHandler()
		{
			if (TextInputLayout.cb_isCounterEnabled == null)
			{
				TextInputLayout.cb_isCounterEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsCounterEnabled));
			}
			return TextInputLayout.cb_isCounterEnabled;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000FB5B File Offset: 0x0000DD5B
		private static bool n_IsCounterEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterEnabled;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000FB6A File Offset: 0x0000DD6A
		private static Delegate GetSetCounterEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setCounterEnabled_Z == null)
			{
				TextInputLayout.cb_setCounterEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetCounterEnabled_Z));
			}
			return TextInputLayout.cb_setCounterEnabled_Z;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000FB8E File Offset: 0x0000DD8E
		private static void n_SetCounterEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterEnabled = enabled;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		public unsafe virtual bool CounterEnabled
		{
			[Register("isCounterEnabled", "()Z", "GetIsCounterEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isCounterEnabled.()Z", this, null);
			}
			[Register("setCounterEnabled", "(Z)V", "GetSetCounterEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000FBF3 File Offset: 0x0000DDF3
		private static Delegate GetGetCounterMaxLengthHandler()
		{
			if (TextInputLayout.cb_getCounterMaxLength == null)
			{
				TextInputLayout.cb_getCounterMaxLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetCounterMaxLength));
			}
			return TextInputLayout.cb_getCounterMaxLength;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000FC17 File Offset: 0x0000DE17
		private static int n_GetCounterMaxLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterMaxLength;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000FC26 File Offset: 0x0000DE26
		private static Delegate GetSetCounterMaxLength_IHandler()
		{
			if (TextInputLayout.cb_setCounterMaxLength_I == null)
			{
				TextInputLayout.cb_setCounterMaxLength_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetCounterMaxLength_I));
			}
			return TextInputLayout.cb_setCounterMaxLength_I;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000FC4A File Offset: 0x0000DE4A
		private static void n_SetCounterMaxLength_I(IntPtr jnienv, IntPtr native__this, int maxLength)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterMaxLength = maxLength;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0000FC74 File Offset: 0x0000DE74
		public unsafe virtual int CounterMaxLength
		{
			[Register("getCounterMaxLength", "()I", "GetGetCounterMaxLengthHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getCounterMaxLength.()I", this, null);
			}
			[Register("setCounterMaxLength", "(I)V", "GetSetCounterMaxLength_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterMaxLength.(I)V", this, ptr);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		private static Delegate GetGetCounterOverflowTextColorHandler()
		{
			if (TextInputLayout.cb_getCounterOverflowTextColor == null)
			{
				TextInputLayout.cb_getCounterOverflowTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetCounterOverflowTextColor));
			}
			return TextInputLayout.cb_getCounterOverflowTextColor;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000FCD3 File Offset: 0x0000DED3
		private static IntPtr n_GetCounterOverflowTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterOverflowTextColor);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000FCE7 File Offset: 0x0000DEE7
		private static Delegate GetSetCounterOverflowTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setCounterOverflowTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setCounterOverflowTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetCounterOverflowTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setCounterOverflowTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		private static void n_SetCounterOverflowTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_counterOverflowTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_counterOverflowTextColor, JniHandleOwnership.DoNotTransfer);
			@object.CounterOverflowTextColor = object2;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0000FD30 File Offset: 0x0000DF30
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public unsafe virtual ColorStateList CounterOverflowTextColor
		{
			[Register("getCounterOverflowTextColor", "()Landroid/content/res/ColorStateList;", "GetGetCounterOverflowTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getCounterOverflowTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCounterOverflowTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetCounterOverflowTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterOverflowTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		private static Delegate GetGetCounterTextColorHandler()
		{
			if (TextInputLayout.cb_getCounterTextColor == null)
			{
				TextInputLayout.cb_getCounterTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetCounterTextColor));
			}
			return TextInputLayout.cb_getCounterTextColor;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		private static IntPtr n_GetCounterTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CounterTextColor);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000FE00 File Offset: 0x0000E000
		private static Delegate GetSetCounterTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setCounterTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setCounterTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetCounterTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setCounterTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000FE24 File Offset: 0x0000E024
		private static void n_SetCounterTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_counterTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_counterTextColor, JniHandleOwnership.DoNotTransfer);
			@object.CounterTextColor = object2;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0000FE48 File Offset: 0x0000E048
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0000FE7C File Offset: 0x0000E07C
		public unsafe virtual ColorStateList CounterTextColor
		{
			[Register("getCounterTextColor", "()Landroid/content/res/ColorStateList;", "GetGetCounterTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getCounterTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCounterTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetCounterTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000FEE0 File Offset: 0x0000E0E0
		private static Delegate GetGetDefaultHintTextColorHandler()
		{
			if (TextInputLayout.cb_getDefaultHintTextColor == null)
			{
				TextInputLayout.cb_getDefaultHintTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetDefaultHintTextColor));
			}
			return TextInputLayout.cb_getDefaultHintTextColor;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000FF04 File Offset: 0x0000E104
		private static IntPtr n_GetDefaultHintTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultHintTextColor);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000FF18 File Offset: 0x0000E118
		private static Delegate GetSetDefaultHintTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setDefaultHintTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setDefaultHintTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetDefaultHintTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setDefaultHintTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000FF3C File Offset: 0x0000E13C
		private static void n_SetDefaultHintTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_textColor, JniHandleOwnership.DoNotTransfer);
			@object.DefaultHintTextColor = object2;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000FF60 File Offset: 0x0000E160
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0000FF94 File Offset: 0x0000E194
		public unsafe virtual ColorStateList DefaultHintTextColor
		{
			[Register("getDefaultHintTextColor", "()Landroid/content/res/ColorStateList;", "GetGetDefaultHintTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getDefaultHintTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setDefaultHintTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetDefaultHintTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDefaultHintTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		private static Delegate GetGetEditTextHandler()
		{
			if (TextInputLayout.cb_getEditText == null)
			{
				TextInputLayout.cb_getEditText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetEditText));
			}
			return TextInputLayout.cb_getEditText;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0001001C File Offset: 0x0000E21C
		private static IntPtr n_GetEditText(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EditText);
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00010030 File Offset: 0x0000E230
		public virtual EditText EditText
		{
			[Register("getEditText", "()Landroid/widget/EditText;", "GetGetEditTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EditText>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEditText.()Landroid/widget/EditText;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00010062 File Offset: 0x0000E262
		private static Delegate GetIsEndIconCheckableHandler()
		{
			if (TextInputLayout.cb_isEndIconCheckable == null)
			{
				TextInputLayout.cb_isEndIconCheckable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsEndIconCheckable));
			}
			return TextInputLayout.cb_isEndIconCheckable;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00010086 File Offset: 0x0000E286
		private static bool n_IsEndIconCheckable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconCheckable;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00010095 File Offset: 0x0000E295
		private static Delegate GetSetEndIconCheckable_ZHandler()
		{
			if (TextInputLayout.cb_setEndIconCheckable_Z == null)
			{
				TextInputLayout.cb_setEndIconCheckable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetEndIconCheckable_Z));
			}
			return TextInputLayout.cb_setEndIconCheckable_Z;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000100B9 File Offset: 0x0000E2B9
		private static void n_SetEndIconCheckable_Z(IntPtr jnienv, IntPtr native__this, bool endIconCheckable)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconCheckable = endIconCheckable;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x000100C9 File Offset: 0x0000E2C9
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000100E4 File Offset: 0x0000E2E4
		public unsafe virtual bool EndIconCheckable
		{
			[Register("isEndIconCheckable", "()Z", "GetIsEndIconCheckableHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isEndIconCheckable.()Z", this, null);
			}
			[Register("setEndIconCheckable", "(Z)V", "GetSetEndIconCheckable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconCheckable.(Z)V", this, ptr);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001011F File Offset: 0x0000E31F
		private static Delegate GetGetEndIconContentDescriptionHandler()
		{
			if (TextInputLayout.cb_getEndIconContentDescription == null)
			{
				TextInputLayout.cb_getEndIconContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetEndIconContentDescription));
			}
			return TextInputLayout.cb_getEndIconContentDescription;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00010143 File Offset: 0x0000E343
		private static IntPtr n_GetEndIconContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconContentDescriptionFormatted);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00010157 File Offset: 0x0000E357
		private static Delegate GetSetEndIconContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setEndIconContentDescription_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setEndIconContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconContentDescription_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setEndIconContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001017C File Offset: 0x0000E37C
		private static void n_SetEndIconContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconContentDescription)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_endIconContentDescription, JniHandleOwnership.DoNotTransfer);
			@object.EndIconContentDescriptionFormatted = object2;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x000101A0 File Offset: 0x0000E3A0
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x000101D4 File Offset: 0x0000E3D4
		public unsafe virtual ICharSequence EndIconContentDescriptionFormatted
		{
			[Register("getEndIconContentDescription", "()Ljava/lang/CharSequence;", "GetGetEndIconContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEndIconContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setEndIconContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetEndIconContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00010238 File Offset: 0x0000E438
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00010250 File Offset: 0x0000E450
		public string EndIconContentDescription
		{
			get
			{
				if (this.EndIconContentDescriptionFormatted != null)
				{
					return this.EndIconContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.EndIconContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0001027A File Offset: 0x0000E47A
		private static Delegate GetGetEndIconDrawableHandler()
		{
			if (TextInputLayout.cb_getEndIconDrawable == null)
			{
				TextInputLayout.cb_getEndIconDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetEndIconDrawable));
			}
			return TextInputLayout.cb_getEndIconDrawable;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001029E File Offset: 0x0000E49E
		private static IntPtr n_GetEndIconDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconDrawable);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000102B2 File Offset: 0x0000E4B2
		private static Delegate GetSetEndIconDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (TextInputLayout.cb_setEndIconDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				TextInputLayout.cb_setEndIconDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return TextInputLayout.cb_setEndIconDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000102D8 File Offset: 0x0000E4D8
		private static void n_SetEndIconDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconDrawable)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_endIconDrawable, JniHandleOwnership.DoNotTransfer);
			@object.EndIconDrawable = object2;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000102FC File Offset: 0x0000E4FC
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00010330 File Offset: 0x0000E530
		public unsafe virtual Drawable EndIconDrawable
		{
			[Register("getEndIconDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetEndIconDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEndIconDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setEndIconDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetEndIconDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00010394 File Offset: 0x0000E594
		private static Delegate GetGetEndIconMinSizeHandler()
		{
			if (TextInputLayout.cb_getEndIconMinSize == null)
			{
				TextInputLayout.cb_getEndIconMinSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetEndIconMinSize));
			}
			return TextInputLayout.cb_getEndIconMinSize;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000103B8 File Offset: 0x0000E5B8
		private static int n_GetEndIconMinSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconMinSize;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000103C7 File Offset: 0x0000E5C7
		private static Delegate GetSetEndIconMinSize_IHandler()
		{
			if (TextInputLayout.cb_setEndIconMinSize_I == null)
			{
				TextInputLayout.cb_setEndIconMinSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetEndIconMinSize_I));
			}
			return TextInputLayout.cb_setEndIconMinSize_I;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000103EB File Offset: 0x0000E5EB
		private static void n_SetEndIconMinSize_I(IntPtr jnienv, IntPtr native__this, int iconSize)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconMinSize = iconSize;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x000103FB File Offset: 0x0000E5FB
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00010414 File Offset: 0x0000E614
		public unsafe virtual int EndIconMinSize
		{
			[Register("getEndIconMinSize", "()I", "GetGetEndIconMinSizeHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getEndIconMinSize.()I", this, null);
			}
			[Register("setEndIconMinSize", "(I)V", "GetSetEndIconMinSize_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconMinSize.(I)V", this, ptr);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001044F File Offset: 0x0000E64F
		private static Delegate GetGetEndIconModeHandler()
		{
			if (TextInputLayout.cb_getEndIconMode == null)
			{
				TextInputLayout.cb_getEndIconMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetEndIconMode));
			}
			return TextInputLayout.cb_getEndIconMode;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00010473 File Offset: 0x0000E673
		private static int n_GetEndIconMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconMode;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00010482 File Offset: 0x0000E682
		private static Delegate GetSetEndIconMode_IHandler()
		{
			if (TextInputLayout.cb_setEndIconMode_I == null)
			{
				TextInputLayout.cb_setEndIconMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetEndIconMode_I));
			}
			return TextInputLayout.cb_setEndIconMode_I;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000104A6 File Offset: 0x0000E6A6
		private static void n_SetEndIconMode_I(IntPtr jnienv, IntPtr native__this, int endIconMode)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconMode = endIconMode;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000104B6 File Offset: 0x0000E6B6
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x000104D0 File Offset: 0x0000E6D0
		public unsafe virtual int EndIconMode
		{
			[Register("getEndIconMode", "()I", "GetGetEndIconModeHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getEndIconMode.()I", this, null);
			}
			[Register("setEndIconMode", "(I)V", "GetSetEndIconMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconMode.(I)V", this, ptr);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001050B File Offset: 0x0000E70B
		private static Delegate GetGetEndIconScaleTypeHandler()
		{
			if (TextInputLayout.cb_getEndIconScaleType == null)
			{
				TextInputLayout.cb_getEndIconScaleType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetEndIconScaleType));
			}
			return TextInputLayout.cb_getEndIconScaleType;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001052F File Offset: 0x0000E72F
		private static IntPtr n_GetEndIconScaleType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconScaleType);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00010543 File Offset: 0x0000E743
		private static Delegate GetSetEndIconScaleType_Landroid_widget_ImageView_ScaleType_Handler()
		{
			if (TextInputLayout.cb_setEndIconScaleType_Landroid_widget_ImageView_ScaleType_ == null)
			{
				TextInputLayout.cb_setEndIconScaleType_Landroid_widget_ImageView_ScaleType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconScaleType_Landroid_widget_ImageView_ScaleType_));
			}
			return TextInputLayout.cb_setEndIconScaleType_Landroid_widget_ImageView_ScaleType_;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00010568 File Offset: 0x0000E768
		private static void n_SetEndIconScaleType_Landroid_widget_ImageView_ScaleType_(IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ImageView.ScaleType object2 = Java.Lang.Object.GetObject<ImageView.ScaleType>(native_scaleType, JniHandleOwnership.DoNotTransfer);
			@object.EndIconScaleType = object2;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001058C File Offset: 0x0000E78C
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x000105C0 File Offset: 0x0000E7C0
		public unsafe virtual ImageView.ScaleType EndIconScaleType
		{
			[Register("getEndIconScaleType", "()Landroid/widget/ImageView$ScaleType;", "GetGetEndIconScaleTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ImageView.ScaleType>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEndIconScaleType.()Landroid/widget/ImageView$ScaleType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setEndIconScaleType", "(Landroid/widget/ImageView$ScaleType;)V", "GetSetEndIconScaleType_Landroid_widget_ImageView_ScaleType_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconScaleType.(Landroid/widget/ImageView$ScaleType;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00010624 File Offset: 0x0000E824
		private static Delegate GetIsEndIconVisibleHandler()
		{
			if (TextInputLayout.cb_isEndIconVisible == null)
			{
				TextInputLayout.cb_isEndIconVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsEndIconVisible));
			}
			return TextInputLayout.cb_isEndIconVisible;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00010648 File Offset: 0x0000E848
		private static bool n_IsEndIconVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconVisible;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00010657 File Offset: 0x0000E857
		private static Delegate GetSetEndIconVisible_ZHandler()
		{
			if (TextInputLayout.cb_setEndIconVisible_Z == null)
			{
				TextInputLayout.cb_setEndIconVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetEndIconVisible_Z));
			}
			return TextInputLayout.cb_setEndIconVisible_Z;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001067B File Offset: 0x0000E87B
		private static void n_SetEndIconVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndIconVisible = visible;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001068B File Offset: 0x0000E88B
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000106A4 File Offset: 0x0000E8A4
		public unsafe virtual bool EndIconVisible
		{
			[Register("isEndIconVisible", "()Z", "GetIsEndIconVisibleHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isEndIconVisible.()Z", this, null);
			}
			[Register("setEndIconVisible", "(Z)V", "GetSetEndIconVisible_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconVisible.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000106DF File Offset: 0x0000E8DF
		private static Delegate GetGetErrorHandler()
		{
			if (TextInputLayout.cb_getError == null)
			{
				TextInputLayout.cb_getError = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetError));
			}
			return TextInputLayout.cb_getError;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00010703 File Offset: 0x0000E903
		private static IntPtr n_GetError(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorFormatted);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00010717 File Offset: 0x0000E917
		private static Delegate GetSetError_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setError_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setError_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetError_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setError_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001073C File Offset: 0x0000E93C
		private static void n_SetError_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorText)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_errorText, JniHandleOwnership.DoNotTransfer);
			@object.ErrorFormatted = object2;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00010760 File Offset: 0x0000E960
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00010794 File Offset: 0x0000E994
		public unsafe virtual ICharSequence ErrorFormatted
		{
			[Register("getError", "()Ljava/lang/CharSequence;", "GetGetErrorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getError.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setError", "(Ljava/lang/CharSequence;)V", "GetSetError_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setError.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000107F8 File Offset: 0x0000E9F8
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00010810 File Offset: 0x0000EA10
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

		// Token: 0x06000608 RID: 1544 RVA: 0x0001083A File Offset: 0x0000EA3A
		private static Delegate GetGetErrorAccessibilityLiveRegionHandler()
		{
			if (TextInputLayout.cb_getErrorAccessibilityLiveRegion == null)
			{
				TextInputLayout.cb_getErrorAccessibilityLiveRegion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetErrorAccessibilityLiveRegion));
			}
			return TextInputLayout.cb_getErrorAccessibilityLiveRegion;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001085E File Offset: 0x0000EA5E
		private static int n_GetErrorAccessibilityLiveRegion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorAccessibilityLiveRegion;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001086D File Offset: 0x0000EA6D
		private static Delegate GetSetErrorAccessibilityLiveRegion_IHandler()
		{
			if (TextInputLayout.cb_setErrorAccessibilityLiveRegion_I == null)
			{
				TextInputLayout.cb_setErrorAccessibilityLiveRegion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetErrorAccessibilityLiveRegion_I));
			}
			return TextInputLayout.cb_setErrorAccessibilityLiveRegion_I;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00010891 File Offset: 0x0000EA91
		private static void n_SetErrorAccessibilityLiveRegion_I(IntPtr jnienv, IntPtr native__this, int errorAccessibilityLiveRegion)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorAccessibilityLiveRegion = errorAccessibilityLiveRegion;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000108A1 File Offset: 0x0000EAA1
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x000108BC File Offset: 0x0000EABC
		public unsafe virtual int ErrorAccessibilityLiveRegion
		{
			[Register("getErrorAccessibilityLiveRegion", "()I", "GetGetErrorAccessibilityLiveRegionHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getErrorAccessibilityLiveRegion.()I", this, null);
			}
			[Register("setErrorAccessibilityLiveRegion", "(I)V", "GetSetErrorAccessibilityLiveRegion_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorAccessibilityLiveRegion.(I)V", this, ptr);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000108F7 File Offset: 0x0000EAF7
		private static Delegate GetGetErrorContentDescriptionHandler()
		{
			if (TextInputLayout.cb_getErrorContentDescription == null)
			{
				TextInputLayout.cb_getErrorContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetErrorContentDescription));
			}
			return TextInputLayout.cb_getErrorContentDescription;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001091B File Offset: 0x0000EB1B
		private static IntPtr n_GetErrorContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorContentDescriptionFormatted);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001092F File Offset: 0x0000EB2F
		private static Delegate GetSetErrorContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setErrorContentDescription_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setErrorContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorContentDescription_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setErrorContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00010954 File Offset: 0x0000EB54
		private static void n_SetErrorContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorContentDescription)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_errorContentDescription, JniHandleOwnership.DoNotTransfer);
			@object.ErrorContentDescriptionFormatted = object2;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00010978 File Offset: 0x0000EB78
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000109AC File Offset: 0x0000EBAC
		public unsafe virtual ICharSequence ErrorContentDescriptionFormatted
		{
			[Register("getErrorContentDescription", "()Ljava/lang/CharSequence;", "GetGetErrorContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setErrorContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetErrorContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00010A10 File Offset: 0x0000EC10
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00010A28 File Offset: 0x0000EC28
		public string ErrorContentDescription
		{
			get
			{
				if (this.ErrorContentDescriptionFormatted != null)
				{
					return this.ErrorContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.ErrorContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00010A52 File Offset: 0x0000EC52
		private static Delegate GetGetErrorCurrentTextColorsHandler()
		{
			if (TextInputLayout.cb_getErrorCurrentTextColors == null)
			{
				TextInputLayout.cb_getErrorCurrentTextColors = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetErrorCurrentTextColors));
			}
			return TextInputLayout.cb_getErrorCurrentTextColors;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00010A76 File Offset: 0x0000EC76
		private static int n_GetErrorCurrentTextColors(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorCurrentTextColors;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00010A85 File Offset: 0x0000EC85
		public virtual int ErrorCurrentTextColors
		{
			[Register("getErrorCurrentTextColors", "()I", "GetGetErrorCurrentTextColorsHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getErrorCurrentTextColors.()I", this, null);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00010A9E File Offset: 0x0000EC9E
		private static Delegate GetIsErrorEnabledHandler()
		{
			if (TextInputLayout.cb_isErrorEnabled == null)
			{
				TextInputLayout.cb_isErrorEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsErrorEnabled));
			}
			return TextInputLayout.cb_isErrorEnabled;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00010AC2 File Offset: 0x0000ECC2
		private static bool n_IsErrorEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorEnabled;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00010AD1 File Offset: 0x0000ECD1
		private static Delegate GetSetErrorEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setErrorEnabled_Z == null)
			{
				TextInputLayout.cb_setErrorEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetErrorEnabled_Z));
			}
			return TextInputLayout.cb_setErrorEnabled_Z;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00010AF5 File Offset: 0x0000ECF5
		private static void n_SetErrorEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorEnabled = enabled;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00010B05 File Offset: 0x0000ED05
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00010B20 File Offset: 0x0000ED20
		public unsafe virtual bool ErrorEnabled
		{
			[Register("isErrorEnabled", "()Z", "GetIsErrorEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isErrorEnabled.()Z", this, null);
			}
			[Register("setErrorEnabled", "(Z)V", "GetSetErrorEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00010B5B File Offset: 0x0000ED5B
		private static Delegate GetGetErrorIconDrawableHandler()
		{
			if (TextInputLayout.cb_getErrorIconDrawable == null)
			{
				TextInputLayout.cb_getErrorIconDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetErrorIconDrawable));
			}
			return TextInputLayout.cb_getErrorIconDrawable;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00010B7F File Offset: 0x0000ED7F
		private static IntPtr n_GetErrorIconDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorIconDrawable);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00010B93 File Offset: 0x0000ED93
		private static Delegate GetSetErrorIconDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (TextInputLayout.cb_setErrorIconDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				TextInputLayout.cb_setErrorIconDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorIconDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return TextInputLayout.cb_setErrorIconDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00010BB8 File Offset: 0x0000EDB8
		private static void n_SetErrorIconDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorIconDrawable)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_errorIconDrawable, JniHandleOwnership.DoNotTransfer);
			@object.ErrorIconDrawable = object2;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00010BDC File Offset: 0x0000EDDC
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00010C10 File Offset: 0x0000EE10
		public unsafe virtual Drawable ErrorIconDrawable
		{
			[Register("getErrorIconDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetErrorIconDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorIconDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setErrorIconDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetErrorIconDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00010C74 File Offset: 0x0000EE74
		private static Delegate GetIsExpandedHintEnabledHandler()
		{
			if (TextInputLayout.cb_isExpandedHintEnabled == null)
			{
				TextInputLayout.cb_isExpandedHintEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsExpandedHintEnabled));
			}
			return TextInputLayout.cb_isExpandedHintEnabled;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00010C98 File Offset: 0x0000EE98
		private static bool n_IsExpandedHintEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedHintEnabled;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00010CA7 File Offset: 0x0000EEA7
		private static Delegate GetSetExpandedHintEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setExpandedHintEnabled_Z == null)
			{
				TextInputLayout.cb_setExpandedHintEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetExpandedHintEnabled_Z));
			}
			return TextInputLayout.cb_setExpandedHintEnabled_Z;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00010CCB File Offset: 0x0000EECB
		private static void n_SetExpandedHintEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedHintEnabled = enabled;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00010CDB File Offset: 0x0000EEDB
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		public unsafe virtual bool ExpandedHintEnabled
		{
			[Register("isExpandedHintEnabled", "()Z", "GetIsExpandedHintEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isExpandedHintEnabled.()Z", this, null);
			}
			[Register("setExpandedHintEnabled", "(Z)V", "GetSetExpandedHintEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedHintEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00010D2F File Offset: 0x0000EF2F
		private static Delegate GetGetHelperTextHandler()
		{
			if (TextInputLayout.cb_getHelperText == null)
			{
				TextInputLayout.cb_getHelperText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetHelperText));
			}
			return TextInputLayout.cb_getHelperText;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00010D53 File Offset: 0x0000EF53
		private static IntPtr n_GetHelperText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HelperTextFormatted);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00010D67 File Offset: 0x0000EF67
		private static Delegate GetSetHelperText_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setHelperText_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setHelperText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetHelperText_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setHelperText_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00010D8C File Offset: 0x0000EF8C
		private static void n_SetHelperText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_helperText)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_helperText, JniHandleOwnership.DoNotTransfer);
			@object.HelperTextFormatted = object2;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public unsafe virtual ICharSequence HelperTextFormatted
		{
			[Register("getHelperText", "()Ljava/lang/CharSequence;", "GetGetHelperTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getHelperText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setHelperText", "(Ljava/lang/CharSequence;)V", "GetSetHelperText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHelperText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00010E48 File Offset: 0x0000F048
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00010E60 File Offset: 0x0000F060
		public string HelperText
		{
			get
			{
				if (this.HelperTextFormatted != null)
				{
					return this.HelperTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.HelperTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00010E8A File Offset: 0x0000F08A
		private static Delegate GetGetHelperTextCurrentTextColorHandler()
		{
			if (TextInputLayout.cb_getHelperTextCurrentTextColor == null)
			{
				TextInputLayout.cb_getHelperTextCurrentTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetHelperTextCurrentTextColor));
			}
			return TextInputLayout.cb_getHelperTextCurrentTextColor;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00010EAE File Offset: 0x0000F0AE
		private static int n_GetHelperTextCurrentTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HelperTextCurrentTextColor;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00010EBD File Offset: 0x0000F0BD
		public virtual int HelperTextCurrentTextColor
		{
			[Register("getHelperTextCurrentTextColor", "()I", "GetGetHelperTextCurrentTextColorHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getHelperTextCurrentTextColor.()I", this, null);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00010ED6 File Offset: 0x0000F0D6
		private static Delegate GetIsHelperTextEnabledHandler()
		{
			if (TextInputLayout.cb_isHelperTextEnabled == null)
			{
				TextInputLayout.cb_isHelperTextEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsHelperTextEnabled));
			}
			return TextInputLayout.cb_isHelperTextEnabled;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00010EFA File Offset: 0x0000F0FA
		private static bool n_IsHelperTextEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HelperTextEnabled;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00010F09 File Offset: 0x0000F109
		private static Delegate GetSetHelperTextEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setHelperTextEnabled_Z == null)
			{
				TextInputLayout.cb_setHelperTextEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetHelperTextEnabled_Z));
			}
			return TextInputLayout.cb_setHelperTextEnabled_Z;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00010F2D File Offset: 0x0000F12D
		private static void n_SetHelperTextEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HelperTextEnabled = enabled;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00010F3D File Offset: 0x0000F13D
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00010F58 File Offset: 0x0000F158
		public unsafe virtual bool HelperTextEnabled
		{
			[Register("isHelperTextEnabled", "()Z", "GetIsHelperTextEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isHelperTextEnabled.()Z", this, null);
			}
			[Register("setHelperTextEnabled", "(Z)V", "GetSetHelperTextEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHelperTextEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00010F93 File Offset: 0x0000F193
		private static Delegate GetGetHintHandler()
		{
			if (TextInputLayout.cb_getHint == null)
			{
				TextInputLayout.cb_getHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetHint));
			}
			return TextInputLayout.cb_getHint;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00010FB7 File Offset: 0x0000F1B7
		private static IntPtr n_GetHint(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintFormatted);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00010FCB File Offset: 0x0000F1CB
		private static Delegate GetSetHint_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setHint_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setHint_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetHint_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setHint_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		private static void n_SetHint_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_hint)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_hint, JniHandleOwnership.DoNotTransfer);
			@object.HintFormatted = object2;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00011014 File Offset: 0x0000F214
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00011048 File Offset: 0x0000F248
		public unsafe virtual ICharSequence HintFormatted
		{
			[Register("getHint", "()Ljava/lang/CharSequence;", "GetGetHintHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getHint.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setHint", "(Ljava/lang/CharSequence;)V", "GetSetHint_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHint.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000110AC File Offset: 0x0000F2AC
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x000110C4 File Offset: 0x0000F2C4
		public string Hint
		{
			get
			{
				if (this.HintFormatted != null)
				{
					return this.HintFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.HintFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000110EE File Offset: 0x0000F2EE
		private static Delegate GetIsHintAnimationEnabledHandler()
		{
			if (TextInputLayout.cb_isHintAnimationEnabled == null)
			{
				TextInputLayout.cb_isHintAnimationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsHintAnimationEnabled));
			}
			return TextInputLayout.cb_isHintAnimationEnabled;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00011112 File Offset: 0x0000F312
		private static bool n_IsHintAnimationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintAnimationEnabled;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00011121 File Offset: 0x0000F321
		private static Delegate GetSetHintAnimationEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setHintAnimationEnabled_Z == null)
			{
				TextInputLayout.cb_setHintAnimationEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetHintAnimationEnabled_Z));
			}
			return TextInputLayout.cb_setHintAnimationEnabled_Z;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00011145 File Offset: 0x0000F345
		private static void n_SetHintAnimationEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintAnimationEnabled = enabled;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00011155 File Offset: 0x0000F355
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00011170 File Offset: 0x0000F370
		public unsafe virtual bool HintAnimationEnabled
		{
			[Register("isHintAnimationEnabled", "()Z", "GetIsHintAnimationEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isHintAnimationEnabled.()Z", this, null);
			}
			[Register("setHintAnimationEnabled", "(Z)V", "GetSetHintAnimationEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHintAnimationEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000111AB File Offset: 0x0000F3AB
		private static Delegate GetIsHintEnabledHandler()
		{
			if (TextInputLayout.cb_isHintEnabled == null)
			{
				TextInputLayout.cb_isHintEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsHintEnabled));
			}
			return TextInputLayout.cb_isHintEnabled;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000111CF File Offset: 0x0000F3CF
		private static bool n_IsHintEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintEnabled;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000111DE File Offset: 0x0000F3DE
		private static Delegate GetSetHintEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setHintEnabled_Z == null)
			{
				TextInputLayout.cb_setHintEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetHintEnabled_Z));
			}
			return TextInputLayout.cb_setHintEnabled_Z;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00011202 File Offset: 0x0000F402
		private static void n_SetHintEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintEnabled = enabled;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00011212 File Offset: 0x0000F412
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x0001122C File Offset: 0x0000F42C
		public unsafe virtual bool HintEnabled
		{
			[Register("isHintEnabled", "()Z", "GetIsHintEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isHintEnabled.()Z", this, null);
			}
			[Register("setHintEnabled", "(Z)V", "GetSetHintEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHintEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00011267 File Offset: 0x0000F467
		private static Delegate GetGetHintTextColorHandler()
		{
			if (TextInputLayout.cb_getHintTextColor == null)
			{
				TextInputLayout.cb_getHintTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetHintTextColor));
			}
			return TextInputLayout.cb_getHintTextColor;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001128B File Offset: 0x0000F48B
		private static IntPtr n_GetHintTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HintTextColor);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001129F File Offset: 0x0000F49F
		private static Delegate GetSetHintTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setHintTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setHintTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetHintTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setHintTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000112C4 File Offset: 0x0000F4C4
		private static void n_SetHintTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_hintTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_hintTextColor, JniHandleOwnership.DoNotTransfer);
			@object.HintTextColor = object2;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x000112E8 File Offset: 0x0000F4E8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0001131C File Offset: 0x0000F51C
		public unsafe virtual ColorStateList HintTextColor
		{
			[Register("getHintTextColor", "()Landroid/content/res/ColorStateList;", "GetGetHintTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getHintTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setHintTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetHintTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHintTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00011380 File Offset: 0x0000F580
		private static Delegate GetIsProvidingHintHandler()
		{
			if (TextInputLayout.cb_isProvidingHint == null)
			{
				TextInputLayout.cb_isProvidingHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsProvidingHint));
			}
			return TextInputLayout.cb_isProvidingHint;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000113A4 File Offset: 0x0000F5A4
		private static bool n_IsProvidingHint(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsProvidingHint;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000113B3 File Offset: 0x0000F5B3
		public virtual bool IsProvidingHint
		{
			[Register("isProvidingHint", "()Z", "GetIsProvidingHintHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isProvidingHint.()Z", this, null);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000113CC File Offset: 0x0000F5CC
		private static Delegate GetGetLengthCounterHandler()
		{
			if (TextInputLayout.cb_getLengthCounter == null)
			{
				TextInputLayout.cb_getLengthCounter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetLengthCounter));
			}
			return TextInputLayout.cb_getLengthCounter;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000113F0 File Offset: 0x0000F5F0
		private static IntPtr n_GetLengthCounter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LengthCounter);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00011404 File Offset: 0x0000F604
		private static Delegate GetSetLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_Handler()
		{
			if (TextInputLayout.cb_setLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_ == null)
			{
				TextInputLayout.cb_setLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_));
			}
			return TextInputLayout.cb_setLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00011428 File Offset: 0x0000F628
		private static void n_SetLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_(IntPtr jnienv, IntPtr native__this, IntPtr native_lengthCounter)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.ILengthCounter object2 = Java.Lang.Object.GetObject<TextInputLayout.ILengthCounter>(native_lengthCounter, JniHandleOwnership.DoNotTransfer);
			@object.LengthCounter = object2;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001144C File Offset: 0x0000F64C
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00011480 File Offset: 0x0000F680
		public unsafe virtual TextInputLayout.ILengthCounter LengthCounter
		{
			[Register("getLengthCounter", "()Lcom/google/android/material/textfield/TextInputLayout$LengthCounter;", "GetGetLengthCounterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextInputLayout.ILengthCounter>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getLengthCounter.()Lcom/google/android/material/textfield/TextInputLayout$LengthCounter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLengthCounter", "(Lcom/google/android/material/textfield/TextInputLayout$LengthCounter;)V", "GetSetLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setLengthCounter.(Lcom/google/android/material/textfield/TextInputLayout$LengthCounter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000114E8 File Offset: 0x0000F6E8
		private static Delegate GetGetMaxEmsHandler()
		{
			if (TextInputLayout.cb_getMaxEms == null)
			{
				TextInputLayout.cb_getMaxEms = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetMaxEms));
			}
			return TextInputLayout.cb_getMaxEms;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001150C File Offset: 0x0000F70C
		private static int n_GetMaxEms(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxEms;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001151B File Offset: 0x0000F71B
		private static Delegate GetSetMaxEms_IHandler()
		{
			if (TextInputLayout.cb_setMaxEms_I == null)
			{
				TextInputLayout.cb_setMaxEms_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMaxEms_I));
			}
			return TextInputLayout.cb_setMaxEms_I;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001153F File Offset: 0x0000F73F
		private static void n_SetMaxEms_I(IntPtr jnienv, IntPtr native__this, int maxEms)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxEms = maxEms;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001154F File Offset: 0x0000F74F
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00011568 File Offset: 0x0000F768
		public unsafe virtual int MaxEms
		{
			[Register("getMaxEms", "()I", "GetGetMaxEmsHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMaxEms.()I", this, null);
			}
			[Register("setMaxEms", "(I)V", "GetSetMaxEms_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxEms.(I)V", this, ptr);
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000115A3 File Offset: 0x0000F7A3
		private static Delegate GetGetMaxWidthHandler()
		{
			if (TextInputLayout.cb_getMaxWidth == null)
			{
				TextInputLayout.cb_getMaxWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetMaxWidth));
			}
			return TextInputLayout.cb_getMaxWidth;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000115C7 File Offset: 0x0000F7C7
		private static int n_GetMaxWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000115D6 File Offset: 0x0000F7D6
		private static Delegate GetSetMaxWidth_IHandler()
		{
			if (TextInputLayout.cb_setMaxWidth_I == null)
			{
				TextInputLayout.cb_setMaxWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMaxWidth_I));
			}
			return TextInputLayout.cb_setMaxWidth_I;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000115FA File Offset: 0x0000F7FA
		private static void n_SetMaxWidth_I(IntPtr jnienv, IntPtr native__this, int maxWidth)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxWidth = maxWidth;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001160A File Offset: 0x0000F80A
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00011624 File Offset: 0x0000F824
		public unsafe virtual int MaxWidth
		{
			[Register("getMaxWidth", "()I", "GetGetMaxWidthHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMaxWidth.()I", this, null);
			}
			[Register("setMaxWidth", "(I)V", "GetSetMaxWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001165F File Offset: 0x0000F85F
		private static Delegate GetGetMinEmsHandler()
		{
			if (TextInputLayout.cb_getMinEms == null)
			{
				TextInputLayout.cb_getMinEms = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetMinEms));
			}
			return TextInputLayout.cb_getMinEms;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00011683 File Offset: 0x0000F883
		private static int n_GetMinEms(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinEms;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00011692 File Offset: 0x0000F892
		private static Delegate GetSetMinEms_IHandler()
		{
			if (TextInputLayout.cb_setMinEms_I == null)
			{
				TextInputLayout.cb_setMinEms_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMinEms_I));
			}
			return TextInputLayout.cb_setMinEms_I;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000116B6 File Offset: 0x0000F8B6
		private static void n_SetMinEms_I(IntPtr jnienv, IntPtr native__this, int minEms)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinEms = minEms;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x000116C6 File Offset: 0x0000F8C6
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x000116E0 File Offset: 0x0000F8E0
		public unsafe virtual int MinEms
		{
			[Register("getMinEms", "()I", "GetGetMinEmsHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMinEms.()I", this, null);
			}
			[Register("setMinEms", "(I)V", "GetSetMinEms_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMinEms.(I)V", this, ptr);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001171B File Offset: 0x0000F91B
		private static Delegate GetGetMinWidthHandler()
		{
			if (TextInputLayout.cb_getMinWidth == null)
			{
				TextInputLayout.cb_getMinWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetMinWidth));
			}
			return TextInputLayout.cb_getMinWidth;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001173F File Offset: 0x0000F93F
		private static int n_GetMinWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinWidth;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001174E File Offset: 0x0000F94E
		private static Delegate GetSetMinWidth_IHandler()
		{
			if (TextInputLayout.cb_setMinWidth_I == null)
			{
				TextInputLayout.cb_setMinWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMinWidth_I));
			}
			return TextInputLayout.cb_setMinWidth_I;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00011772 File Offset: 0x0000F972
		private static void n_SetMinWidth_I(IntPtr jnienv, IntPtr native__this, int minWidth)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinWidth = minWidth;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00011782 File Offset: 0x0000F982
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0001179C File Offset: 0x0000F99C
		public unsafe virtual int MinWidth
		{
			[Register("getMinWidth", "()I", "GetGetMinWidthHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMinWidth.()I", this, null);
			}
			[Register("setMinWidth", "(I)V", "GetSetMinWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMinWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000117D7 File Offset: 0x0000F9D7
		private static Delegate GetGetPasswordVisibilityToggleContentDescriptionHandler()
		{
			if (TextInputLayout.cb_getPasswordVisibilityToggleContentDescription == null)
			{
				TextInputLayout.cb_getPasswordVisibilityToggleContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPasswordVisibilityToggleContentDescription));
			}
			return TextInputLayout.cb_getPasswordVisibilityToggleContentDescription;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000117FB File Offset: 0x0000F9FB
		private static IntPtr n_GetPasswordVisibilityToggleContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PasswordVisibilityToggleContentDescriptionFormatted);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001180F File Offset: 0x0000FA0F
		private static Delegate GetSetPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00011834 File Offset: 0x0000FA34
		private static void n_SetPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
			@object.PasswordVisibilityToggleContentDescriptionFormatted = object2;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00011858 File Offset: 0x0000FA58
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0001188C File Offset: 0x0000FA8C
		public unsafe virtual ICharSequence PasswordVisibilityToggleContentDescriptionFormatted
		{
			[Register("getPasswordVisibilityToggleContentDescription", "()Ljava/lang/CharSequence;", "GetGetPasswordVisibilityToggleContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPasswordVisibilityToggleContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPasswordVisibilityToggleContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000118F0 File Offset: 0x0000FAF0
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00011908 File Offset: 0x0000FB08
		public string PasswordVisibilityToggleContentDescription
		{
			get
			{
				if (this.PasswordVisibilityToggleContentDescriptionFormatted != null)
				{
					return this.PasswordVisibilityToggleContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.PasswordVisibilityToggleContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00011932 File Offset: 0x0000FB32
		private static Delegate GetGetPasswordVisibilityToggleDrawableHandler()
		{
			if (TextInputLayout.cb_getPasswordVisibilityToggleDrawable == null)
			{
				TextInputLayout.cb_getPasswordVisibilityToggleDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPasswordVisibilityToggleDrawable));
			}
			return TextInputLayout.cb_getPasswordVisibilityToggleDrawable;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00011956 File Offset: 0x0000FB56
		private static IntPtr n_GetPasswordVisibilityToggleDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PasswordVisibilityToggleDrawable);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001196A File Offset: 0x0000FB6A
		private static Delegate GetSetPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00011990 File Offset: 0x0000FB90
		private static void n_SetPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.PasswordVisibilityToggleDrawable = object2;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000119B4 File Offset: 0x0000FBB4
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x000119E8 File Offset: 0x0000FBE8
		public unsafe virtual Drawable PasswordVisibilityToggleDrawable
		{
			[Register("getPasswordVisibilityToggleDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetPasswordVisibilityToggleDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPasswordVisibilityToggleDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPasswordVisibilityToggleDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00011A4C File Offset: 0x0000FC4C
		private static Delegate GetIsPasswordVisibilityToggleEnabledHandler()
		{
			if (TextInputLayout.cb_isPasswordVisibilityToggleEnabled == null)
			{
				TextInputLayout.cb_isPasswordVisibilityToggleEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsPasswordVisibilityToggleEnabled));
			}
			return TextInputLayout.cb_isPasswordVisibilityToggleEnabled;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00011A70 File Offset: 0x0000FC70
		private static bool n_IsPasswordVisibilityToggleEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PasswordVisibilityToggleEnabled;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00011A7F File Offset: 0x0000FC7F
		private static Delegate GetSetPasswordVisibilityToggleEnabled_ZHandler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleEnabled_Z == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetPasswordVisibilityToggleEnabled_Z));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleEnabled_Z;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00011AA3 File Offset: 0x0000FCA3
		private static void n_SetPasswordVisibilityToggleEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PasswordVisibilityToggleEnabled = enabled;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00011AB3 File Offset: 0x0000FCB3
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public unsafe virtual bool PasswordVisibilityToggleEnabled
		{
			[Register("isPasswordVisibilityToggleEnabled", "()Z", "GetIsPasswordVisibilityToggleEnabledHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isPasswordVisibilityToggleEnabled.()Z", this, null);
			}
			[Register("setPasswordVisibilityToggleEnabled", "(Z)V", "GetSetPasswordVisibilityToggleEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00011B07 File Offset: 0x0000FD07
		private static Delegate GetGetPlaceholderTextHandler()
		{
			if (TextInputLayout.cb_getPlaceholderText == null)
			{
				TextInputLayout.cb_getPlaceholderText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPlaceholderText));
			}
			return TextInputLayout.cb_getPlaceholderText;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00011B2B File Offset: 0x0000FD2B
		private static IntPtr n_GetPlaceholderText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlaceholderTextFormatted);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00011B3F File Offset: 0x0000FD3F
		private static Delegate GetSetPlaceholderText_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setPlaceholderText_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setPlaceholderText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPlaceholderText_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setPlaceholderText_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00011B64 File Offset: 0x0000FD64
		private static void n_SetPlaceholderText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderText)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_placeholderText, JniHandleOwnership.DoNotTransfer);
			@object.PlaceholderTextFormatted = object2;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00011B88 File Offset: 0x0000FD88
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00011BBC File Offset: 0x0000FDBC
		public unsafe virtual ICharSequence PlaceholderTextFormatted
		{
			[Register("getPlaceholderText", "()Ljava/lang/CharSequence;", "GetGetPlaceholderTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPlaceholderText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPlaceholderText", "(Ljava/lang/CharSequence;)V", "GetSetPlaceholderText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPlaceholderText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00011C20 File Offset: 0x0000FE20
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00011C38 File Offset: 0x0000FE38
		public string PlaceholderText
		{
			get
			{
				if (this.PlaceholderTextFormatted != null)
				{
					return this.PlaceholderTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.PlaceholderTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00011C62 File Offset: 0x0000FE62
		private static Delegate GetGetPlaceholderTextAppearanceHandler()
		{
			if (TextInputLayout.cb_getPlaceholderTextAppearance == null)
			{
				TextInputLayout.cb_getPlaceholderTextAppearance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetPlaceholderTextAppearance));
			}
			return TextInputLayout.cb_getPlaceholderTextAppearance;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00011C86 File Offset: 0x0000FE86
		private static int n_GetPlaceholderTextAppearance(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlaceholderTextAppearance;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00011C95 File Offset: 0x0000FE95
		private static Delegate GetSetPlaceholderTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setPlaceholderTextAppearance_I == null)
			{
				TextInputLayout.cb_setPlaceholderTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetPlaceholderTextAppearance_I));
			}
			return TextInputLayout.cb_setPlaceholderTextAppearance_I;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00011CB9 File Offset: 0x0000FEB9
		private static void n_SetPlaceholderTextAppearance_I(IntPtr jnienv, IntPtr native__this, int placeholderTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlaceholderTextAppearance = placeholderTextAppearance;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00011CC9 File Offset: 0x0000FEC9
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		public unsafe virtual int PlaceholderTextAppearance
		{
			[Register("getPlaceholderTextAppearance", "()I", "GetGetPlaceholderTextAppearanceHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getPlaceholderTextAppearance.()I", this, null);
			}
			[Register("setPlaceholderTextAppearance", "(I)V", "GetSetPlaceholderTextAppearance_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPlaceholderTextAppearance.(I)V", this, ptr);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00011D1F File Offset: 0x0000FF1F
		private static Delegate GetGetPlaceholderTextColorHandler()
		{
			if (TextInputLayout.cb_getPlaceholderTextColor == null)
			{
				TextInputLayout.cb_getPlaceholderTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPlaceholderTextColor));
			}
			return TextInputLayout.cb_getPlaceholderTextColor;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00011D43 File Offset: 0x0000FF43
		private static IntPtr n_GetPlaceholderTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlaceholderTextColor);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00011D57 File Offset: 0x0000FF57
		private static Delegate GetSetPlaceholderTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setPlaceholderTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setPlaceholderTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPlaceholderTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setPlaceholderTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00011D7C File Offset: 0x0000FF7C
		private static void n_SetPlaceholderTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_placeholderTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_placeholderTextColor, JniHandleOwnership.DoNotTransfer);
			@object.PlaceholderTextColor = object2;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		public unsafe virtual ColorStateList PlaceholderTextColor
		{
			[Register("getPlaceholderTextColor", "()Landroid/content/res/ColorStateList;", "GetGetPlaceholderTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPlaceholderTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPlaceholderTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetPlaceholderTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPlaceholderTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00011E38 File Offset: 0x00010038
		private static Delegate GetGetPrefixTextHandler()
		{
			if (TextInputLayout.cb_getPrefixText == null)
			{
				TextInputLayout.cb_getPrefixText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPrefixText));
			}
			return TextInputLayout.cb_getPrefixText;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00011E5C File Offset: 0x0001005C
		private static IntPtr n_GetPrefixText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrefixTextFormatted);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00011E70 File Offset: 0x00010070
		private static Delegate GetSetPrefixText_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setPrefixText_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setPrefixText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPrefixText_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setPrefixText_Ljava_lang_CharSequence_;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00011E94 File Offset: 0x00010094
		private static void n_SetPrefixText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefixText)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_prefixText, JniHandleOwnership.DoNotTransfer);
			@object.PrefixTextFormatted = object2;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00011EB8 File Offset: 0x000100B8
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00011EEC File Offset: 0x000100EC
		public unsafe virtual ICharSequence PrefixTextFormatted
		{
			[Register("getPrefixText", "()Ljava/lang/CharSequence;", "GetGetPrefixTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPrefixText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPrefixText", "(Ljava/lang/CharSequence;)V", "GetSetPrefixText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPrefixText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00011F50 File Offset: 0x00010150
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00011F68 File Offset: 0x00010168
		public string PrefixText
		{
			get
			{
				if (this.PrefixTextFormatted != null)
				{
					return this.PrefixTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.PrefixTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00011F92 File Offset: 0x00010192
		private static Delegate GetGetPrefixTextColorHandler()
		{
			if (TextInputLayout.cb_getPrefixTextColor == null)
			{
				TextInputLayout.cb_getPrefixTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPrefixTextColor));
			}
			return TextInputLayout.cb_getPrefixTextColor;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00011FB6 File Offset: 0x000101B6
		private static IntPtr n_GetPrefixTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrefixTextColor);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00011FCA File Offset: 0x000101CA
		private static Delegate GetSetPrefixTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setPrefixTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setPrefixTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPrefixTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setPrefixTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00011FF0 File Offset: 0x000101F0
		private static void n_SetPrefixTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefixTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_prefixTextColor, JniHandleOwnership.DoNotTransfer);
			@object.PrefixTextColor = object2;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00012014 File Offset: 0x00010214
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00012048 File Offset: 0x00010248
		public unsafe virtual ColorStateList PrefixTextColor
		{
			[Register("getPrefixTextColor", "()Landroid/content/res/ColorStateList;", "GetGetPrefixTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPrefixTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPrefixTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetPrefixTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPrefixTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000120AC File Offset: 0x000102AC
		private static Delegate GetGetPrefixTextViewHandler()
		{
			if (TextInputLayout.cb_getPrefixTextView == null)
			{
				TextInputLayout.cb_getPrefixTextView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetPrefixTextView));
			}
			return TextInputLayout.cb_getPrefixTextView;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000120D0 File Offset: 0x000102D0
		private static IntPtr n_GetPrefixTextView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrefixTextView);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000120E4 File Offset: 0x000102E4
		public virtual TextView PrefixTextView
		{
			[Register("getPrefixTextView", "()Landroid/widget/TextView;", "GetGetPrefixTextViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextView>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getPrefixTextView.()Landroid/widget/TextView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00012116 File Offset: 0x00010316
		private static Delegate GetGetShapeAppearanceModelHandler()
		{
			if (TextInputLayout.cb_getShapeAppearanceModel == null)
			{
				TextInputLayout.cb_getShapeAppearanceModel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetShapeAppearanceModel));
			}
			return TextInputLayout.cb_getShapeAppearanceModel;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001213A File Offset: 0x0001033A
		private static IntPtr n_GetShapeAppearanceModel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShapeAppearanceModel);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001214E File Offset: 0x0001034E
		private static Delegate GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler()
		{
			if (TextInputLayout.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ == null)
			{
				TextInputLayout.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_));
			}
			return TextInputLayout.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00012174 File Offset: 0x00010374
		private static void n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_(IntPtr jnienv, IntPtr native__this, IntPtr native_shapeAppearanceModel)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapeAppearanceModel object2 = Java.Lang.Object.GetObject<ShapeAppearanceModel>(native_shapeAppearanceModel, JniHandleOwnership.DoNotTransfer);
			@object.ShapeAppearanceModel = object2;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00012198 File Offset: 0x00010398
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x000121CC File Offset: 0x000103CC
		public unsafe virtual ShapeAppearanceModel ShapeAppearanceModel
		{
			[Register("getShapeAppearanceModel", "()Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetGetShapeAppearanceModelHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ShapeAppearanceModel>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getShapeAppearanceModel.()Lcom/google/android/material/shape/ShapeAppearanceModel;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setShapeAppearanceModel", "(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", "GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setShapeAppearanceModel.(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00012230 File Offset: 0x00010430
		private static Delegate GetIsStartIconCheckableHandler()
		{
			if (TextInputLayout.cb_isStartIconCheckable == null)
			{
				TextInputLayout.cb_isStartIconCheckable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsStartIconCheckable));
			}
			return TextInputLayout.cb_isStartIconCheckable;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00012254 File Offset: 0x00010454
		private static bool n_IsStartIconCheckable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconCheckable;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00012263 File Offset: 0x00010463
		private static Delegate GetSetStartIconCheckable_ZHandler()
		{
			if (TextInputLayout.cb_setStartIconCheckable_Z == null)
			{
				TextInputLayout.cb_setStartIconCheckable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetStartIconCheckable_Z));
			}
			return TextInputLayout.cb_setStartIconCheckable_Z;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00012287 File Offset: 0x00010487
		private static void n_SetStartIconCheckable_Z(IntPtr jnienv, IntPtr native__this, bool startIconCheckable)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconCheckable = startIconCheckable;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00012297 File Offset: 0x00010497
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x000122B0 File Offset: 0x000104B0
		public unsafe virtual bool StartIconCheckable
		{
			[Register("isStartIconCheckable", "()Z", "GetIsStartIconCheckableHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isStartIconCheckable.()Z", this, null);
			}
			[Register("setStartIconCheckable", "(Z)V", "GetSetStartIconCheckable_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconCheckable.(Z)V", this, ptr);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000122EB File Offset: 0x000104EB
		private static Delegate GetGetStartIconContentDescriptionHandler()
		{
			if (TextInputLayout.cb_getStartIconContentDescription == null)
			{
				TextInputLayout.cb_getStartIconContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetStartIconContentDescription));
			}
			return TextInputLayout.cb_getStartIconContentDescription;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001230F File Offset: 0x0001050F
		private static IntPtr n_GetStartIconContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconContentDescriptionFormatted);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00012323 File Offset: 0x00010523
		private static Delegate GetSetStartIconContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setStartIconContentDescription_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setStartIconContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconContentDescription_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setStartIconContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00012348 File Offset: 0x00010548
		private static void n_SetStartIconContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconContentDescription)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_startIconContentDescription, JniHandleOwnership.DoNotTransfer);
			@object.StartIconContentDescriptionFormatted = object2;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001236C File Offset: 0x0001056C
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x000123A0 File Offset: 0x000105A0
		public unsafe virtual ICharSequence StartIconContentDescriptionFormatted
		{
			[Register("getStartIconContentDescription", "()Ljava/lang/CharSequence;", "GetGetStartIconContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStartIconContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStartIconContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetStartIconContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00012404 File Offset: 0x00010604
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0001241C File Offset: 0x0001061C
		public string StartIconContentDescription
		{
			get
			{
				if (this.StartIconContentDescriptionFormatted != null)
				{
					return this.StartIconContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.StartIconContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00012446 File Offset: 0x00010646
		private static Delegate GetGetStartIconDrawableHandler()
		{
			if (TextInputLayout.cb_getStartIconDrawable == null)
			{
				TextInputLayout.cb_getStartIconDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetStartIconDrawable));
			}
			return TextInputLayout.cb_getStartIconDrawable;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001246A File Offset: 0x0001066A
		private static IntPtr n_GetStartIconDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconDrawable);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001247E File Offset: 0x0001067E
		private static Delegate GetSetStartIconDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (TextInputLayout.cb_setStartIconDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				TextInputLayout.cb_setStartIconDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return TextInputLayout.cb_setStartIconDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000124A4 File Offset: 0x000106A4
		private static void n_SetStartIconDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconDrawable)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_startIconDrawable, JniHandleOwnership.DoNotTransfer);
			@object.StartIconDrawable = object2;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000124C8 File Offset: 0x000106C8
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x000124FC File Offset: 0x000106FC
		public unsafe virtual Drawable StartIconDrawable
		{
			[Register("getStartIconDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetStartIconDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStartIconDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStartIconDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStartIconDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00012560 File Offset: 0x00010760
		private static Delegate GetGetStartIconMinSizeHandler()
		{
			if (TextInputLayout.cb_getStartIconMinSize == null)
			{
				TextInputLayout.cb_getStartIconMinSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextInputLayout.n_GetStartIconMinSize));
			}
			return TextInputLayout.cb_getStartIconMinSize;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00012584 File Offset: 0x00010784
		private static int n_GetStartIconMinSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconMinSize;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00012593 File Offset: 0x00010793
		private static Delegate GetSetStartIconMinSize_IHandler()
		{
			if (TextInputLayout.cb_setStartIconMinSize_I == null)
			{
				TextInputLayout.cb_setStartIconMinSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetStartIconMinSize_I));
			}
			return TextInputLayout.cb_setStartIconMinSize_I;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000125B7 File Offset: 0x000107B7
		private static void n_SetStartIconMinSize_I(IntPtr jnienv, IntPtr native__this, int iconSize)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconMinSize = iconSize;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000125C7 File Offset: 0x000107C7
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000125E0 File Offset: 0x000107E0
		public unsafe virtual int StartIconMinSize
		{
			[Register("getStartIconMinSize", "()I", "GetGetStartIconMinSizeHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualInt32Method("getStartIconMinSize.()I", this, null);
			}
			[Register("setStartIconMinSize", "(I)V", "GetSetStartIconMinSize_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconMinSize.(I)V", this, ptr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001261B File Offset: 0x0001081B
		private static Delegate GetGetStartIconScaleTypeHandler()
		{
			if (TextInputLayout.cb_getStartIconScaleType == null)
			{
				TextInputLayout.cb_getStartIconScaleType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetStartIconScaleType));
			}
			return TextInputLayout.cb_getStartIconScaleType;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001263F File Offset: 0x0001083F
		private static IntPtr n_GetStartIconScaleType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconScaleType);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00012653 File Offset: 0x00010853
		private static Delegate GetSetStartIconScaleType_Landroid_widget_ImageView_ScaleType_Handler()
		{
			if (TextInputLayout.cb_setStartIconScaleType_Landroid_widget_ImageView_ScaleType_ == null)
			{
				TextInputLayout.cb_setStartIconScaleType_Landroid_widget_ImageView_ScaleType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconScaleType_Landroid_widget_ImageView_ScaleType_));
			}
			return TextInputLayout.cb_setStartIconScaleType_Landroid_widget_ImageView_ScaleType_;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00012678 File Offset: 0x00010878
		private static void n_SetStartIconScaleType_Landroid_widget_ImageView_ScaleType_(IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ImageView.ScaleType object2 = Java.Lang.Object.GetObject<ImageView.ScaleType>(native_scaleType, JniHandleOwnership.DoNotTransfer);
			@object.StartIconScaleType = object2;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001269C File Offset: 0x0001089C
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000126D0 File Offset: 0x000108D0
		public unsafe virtual ImageView.ScaleType StartIconScaleType
		{
			[Register("getStartIconScaleType", "()Landroid/widget/ImageView$ScaleType;", "GetGetStartIconScaleTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ImageView.ScaleType>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStartIconScaleType.()Landroid/widget/ImageView$ScaleType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStartIconScaleType", "(Landroid/widget/ImageView$ScaleType;)V", "GetSetStartIconScaleType_Landroid_widget_ImageView_ScaleType_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconScaleType.(Landroid/widget/ImageView$ScaleType;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00012734 File Offset: 0x00010934
		private static Delegate GetIsStartIconVisibleHandler()
		{
			if (TextInputLayout.cb_isStartIconVisible == null)
			{
				TextInputLayout.cb_isStartIconVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextInputLayout.n_IsStartIconVisible));
			}
			return TextInputLayout.cb_isStartIconVisible;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00012758 File Offset: 0x00010958
		private static bool n_IsStartIconVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconVisible;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00012767 File Offset: 0x00010967
		private static Delegate GetSetStartIconVisible_ZHandler()
		{
			if (TextInputLayout.cb_setStartIconVisible_Z == null)
			{
				TextInputLayout.cb_setStartIconVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetStartIconVisible_Z));
			}
			return TextInputLayout.cb_setStartIconVisible_Z;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001278B File Offset: 0x0001098B
		private static void n_SetStartIconVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartIconVisible = visible;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001279B File Offset: 0x0001099B
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000127B4 File Offset: 0x000109B4
		public unsafe virtual bool StartIconVisible
		{
			[Register("isStartIconVisible", "()Z", "GetIsStartIconVisibleHandler")]
			get
			{
				return TextInputLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isStartIconVisible.()Z", this, null);
			}
			[Register("setStartIconVisible", "(Z)V", "GetSetStartIconVisible_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconVisible.(Z)V", this, ptr);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000127EF File Offset: 0x000109EF
		private static Delegate GetGetSuffixTextHandler()
		{
			if (TextInputLayout.cb_getSuffixText == null)
			{
				TextInputLayout.cb_getSuffixText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetSuffixText));
			}
			return TextInputLayout.cb_getSuffixText;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00012813 File Offset: 0x00010A13
		private static IntPtr n_GetSuffixText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuffixTextFormatted);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00012827 File Offset: 0x00010A27
		private static Delegate GetSetSuffixText_Ljava_lang_CharSequence_Handler()
		{
			if (TextInputLayout.cb_setSuffixText_Ljava_lang_CharSequence_ == null)
			{
				TextInputLayout.cb_setSuffixText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetSuffixText_Ljava_lang_CharSequence_));
			}
			return TextInputLayout.cb_setSuffixText_Ljava_lang_CharSequence_;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001284C File Offset: 0x00010A4C
		private static void n_SetSuffixText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_suffixText)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_suffixText, JniHandleOwnership.DoNotTransfer);
			@object.SuffixTextFormatted = object2;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00012870 File Offset: 0x00010A70
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x000128A4 File Offset: 0x00010AA4
		public unsafe virtual ICharSequence SuffixTextFormatted
		{
			[Register("getSuffixText", "()Ljava/lang/CharSequence;", "GetGetSuffixTextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getSuffixText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSuffixText", "(Ljava/lang/CharSequence;)V", "GetSetSuffixText_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSuffixText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00012908 File Offset: 0x00010B08
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00012920 File Offset: 0x00010B20
		public string SuffixText
		{
			get
			{
				if (this.SuffixTextFormatted != null)
				{
					return this.SuffixTextFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.SuffixTextFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001294A File Offset: 0x00010B4A
		private static Delegate GetGetSuffixTextColorHandler()
		{
			if (TextInputLayout.cb_getSuffixTextColor == null)
			{
				TextInputLayout.cb_getSuffixTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetSuffixTextColor));
			}
			return TextInputLayout.cb_getSuffixTextColor;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001296E File Offset: 0x00010B6E
		private static IntPtr n_GetSuffixTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuffixTextColor);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00012982 File Offset: 0x00010B82
		private static Delegate GetSetSuffixTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setSuffixTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setSuffixTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetSuffixTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setSuffixTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000129A8 File Offset: 0x00010BA8
		private static void n_SetSuffixTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_suffixTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_suffixTextColor, JniHandleOwnership.DoNotTransfer);
			@object.SuffixTextColor = object2;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000129CC File Offset: 0x00010BCC
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00012A00 File Offset: 0x00010C00
		public unsafe virtual ColorStateList SuffixTextColor
		{
			[Register("getSuffixTextColor", "()Landroid/content/res/ColorStateList;", "GetGetSuffixTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getSuffixTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSuffixTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetSuffixTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSuffixTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00012A64 File Offset: 0x00010C64
		private static Delegate GetGetSuffixTextViewHandler()
		{
			if (TextInputLayout.cb_getSuffixTextView == null)
			{
				TextInputLayout.cb_getSuffixTextView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetSuffixTextView));
			}
			return TextInputLayout.cb_getSuffixTextView;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00012A88 File Offset: 0x00010C88
		private static IntPtr n_GetSuffixTextView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuffixTextView);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00012A9C File Offset: 0x00010C9C
		public virtual TextView SuffixTextView
		{
			[Register("getSuffixTextView", "()Landroid/widget/TextView;", "GetGetSuffixTextViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextView>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getSuffixTextView.()Landroid/widget/TextView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00012ACE File Offset: 0x00010CCE
		private static Delegate GetGetTypefaceHandler()
		{
			if (TextInputLayout.cb_getTypeface == null)
			{
				TextInputLayout.cb_getTypeface = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_GetTypeface));
			}
			return TextInputLayout.cb_getTypeface;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00012AF2 File Offset: 0x00010CF2
		private static IntPtr n_GetTypeface(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Typeface);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00012B06 File Offset: 0x00010D06
		private static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler()
		{
			if (TextInputLayout.cb_setTypeface_Landroid_graphics_Typeface_ == null)
			{
				TextInputLayout.cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetTypeface_Landroid_graphics_Typeface_));
			}
			return TextInputLayout.cb_setTypeface_Landroid_graphics_Typeface_;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00012B2C File Offset: 0x00010D2C
		private static void n_SetTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.Typeface = object2;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00012B50 File Offset: 0x00010D50
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00012B84 File Offset: 0x00010D84
		public unsafe virtual Typeface Typeface
		{
			[Register("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Typeface>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTypeface.()Landroid/graphics/Typeface;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTypeface.(Landroid/graphics/Typeface;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00012BE8 File Offset: 0x00010DE8
		private static Delegate GetAddOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_Handler()
		{
			if (TextInputLayout.cb_addOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_ == null)
			{
				TextInputLayout.cb_addOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_AddOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_));
			}
			return TextInputLayout.cb_addOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00012C0C File Offset: 0x00010E0C
		private static void n_AddOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.IOnEditTextAttachedListener object2 = Java.Lang.Object.GetObject<TextInputLayout.IOnEditTextAttachedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnEditTextAttachedListener(object2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00012C30 File Offset: 0x00010E30
		[Register("addOnEditTextAttachedListener", "(Lcom/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener;)V", "GetAddOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_Handler")]
		public unsafe virtual void AddOnEditTextAttachedListener(TextInputLayout.IOnEditTextAttachedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addOnEditTextAttachedListener.(Lcom/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00012C98 File Offset: 0x00010E98
		private static Delegate GetAddOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_Handler()
		{
			if (TextInputLayout.cb_addOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_ == null)
			{
				TextInputLayout.cb_addOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_AddOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_));
			}
			return TextInputLayout.cb_addOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00012CBC File Offset: 0x00010EBC
		private static void n_AddOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.IOnEndIconChangedListener object2 = Java.Lang.Object.GetObject<TextInputLayout.IOnEndIconChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnEndIconChangedListener(object2);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00012CE0 File Offset: 0x00010EE0
		[Register("addOnEndIconChangedListener", "(Lcom/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener;)V", "GetAddOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_Handler")]
		public unsafe virtual void AddOnEndIconChangedListener(TextInputLayout.IOnEndIconChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addOnEndIconChangedListener.(Lcom/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00012D48 File Offset: 0x00010F48
		private static Delegate GetClearOnEditTextAttachedListenersHandler()
		{
			if (TextInputLayout.cb_clearOnEditTextAttachedListeners == null)
			{
				TextInputLayout.cb_clearOnEditTextAttachedListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextInputLayout.n_ClearOnEditTextAttachedListeners));
			}
			return TextInputLayout.cb_clearOnEditTextAttachedListeners;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00012D6C File Offset: 0x00010F6C
		private static void n_ClearOnEditTextAttachedListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnEditTextAttachedListeners();
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00012D7B File Offset: 0x00010F7B
		[Register("clearOnEditTextAttachedListeners", "()V", "GetClearOnEditTextAttachedListenersHandler")]
		public virtual void ClearOnEditTextAttachedListeners()
		{
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnEditTextAttachedListeners.()V", this, null);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00012D94 File Offset: 0x00010F94
		private static Delegate GetClearOnEndIconChangedListenersHandler()
		{
			if (TextInputLayout.cb_clearOnEndIconChangedListeners == null)
			{
				TextInputLayout.cb_clearOnEndIconChangedListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextInputLayout.n_ClearOnEndIconChangedListeners));
			}
			return TextInputLayout.cb_clearOnEndIconChangedListeners;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00012DB8 File Offset: 0x00010FB8
		private static void n_ClearOnEndIconChangedListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnEndIconChangedListeners();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00012DC7 File Offset: 0x00010FC7
		[Register("clearOnEndIconChangedListeners", "()V", "GetClearOnEndIconChangedListenersHandler")]
		public virtual void ClearOnEndIconChangedListeners()
		{
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnEndIconChangedListeners.()V", this, null);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00012DE0 File Offset: 0x00010FE0
		private static Delegate GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler()
		{
			if (TextInputLayout.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ == null)
			{
				TextInputLayout.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_DispatchRestoreInstanceState_Landroid_util_SparseArray_));
			}
			return TextInputLayout.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00012E04 File Offset: 0x00011004
		private static void n_DispatchRestoreInstanceState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			View @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.DispatchRestoreInstanceState(object2);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00012E28 File Offset: 0x00011028
		[Register("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", "GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler")]
		protected unsafe override void DispatchRestoreInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchRestoreInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00012E8C File Offset: 0x0001108C
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (TextInputLayout.cb_onSaveInstanceState == null)
			{
				TextInputLayout.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextInputLayout.n_OnSaveInstanceState));
			}
			return TextInputLayout.cb_onSaveInstanceState;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00012EB0 File Offset: 0x000110B0
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00012EC4 File Offset: 0x000110C4
		[Register("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(TextInputLayout._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00012EF6 File Offset: 0x000110F6
		private static Delegate GetPasswordVisibilityToggleRequested_ZHandler()
		{
			if (TextInputLayout.cb_passwordVisibilityToggleRequested_Z == null)
			{
				TextInputLayout.cb_passwordVisibilityToggleRequested_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_PasswordVisibilityToggleRequested_Z));
			}
			return TextInputLayout.cb_passwordVisibilityToggleRequested_Z;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00012F1A File Offset: 0x0001111A
		private static void n_PasswordVisibilityToggleRequested_Z(IntPtr jnienv, IntPtr native__this, bool shouldSkipAnimations)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PasswordVisibilityToggleRequested(shouldSkipAnimations);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00012F2C File Offset: 0x0001112C
		[Register("passwordVisibilityToggleRequested", "(Z)V", "GetPasswordVisibilityToggleRequested_ZHandler")]
		public unsafe virtual void PasswordVisibilityToggleRequested(bool shouldSkipAnimations)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(shouldSkipAnimations);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("passwordVisibilityToggleRequested.(Z)V", this, ptr);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00012F67 File Offset: 0x00011167
		private static Delegate GetRefreshEndIconDrawableStateHandler()
		{
			if (TextInputLayout.cb_refreshEndIconDrawableState == null)
			{
				TextInputLayout.cb_refreshEndIconDrawableState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextInputLayout.n_RefreshEndIconDrawableState));
			}
			return TextInputLayout.cb_refreshEndIconDrawableState;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00012F8B File Offset: 0x0001118B
		private static void n_RefreshEndIconDrawableState(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RefreshEndIconDrawableState();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00012F9A File Offset: 0x0001119A
		[Register("refreshEndIconDrawableState", "()V", "GetRefreshEndIconDrawableStateHandler")]
		public virtual void RefreshEndIconDrawableState()
		{
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("refreshEndIconDrawableState.()V", this, null);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00012FB3 File Offset: 0x000111B3
		private static Delegate GetRefreshErrorIconDrawableStateHandler()
		{
			if (TextInputLayout.cb_refreshErrorIconDrawableState == null)
			{
				TextInputLayout.cb_refreshErrorIconDrawableState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextInputLayout.n_RefreshErrorIconDrawableState));
			}
			return TextInputLayout.cb_refreshErrorIconDrawableState;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00012FD7 File Offset: 0x000111D7
		private static void n_RefreshErrorIconDrawableState(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RefreshErrorIconDrawableState();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00012FE6 File Offset: 0x000111E6
		[Register("refreshErrorIconDrawableState", "()V", "GetRefreshErrorIconDrawableStateHandler")]
		public virtual void RefreshErrorIconDrawableState()
		{
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("refreshErrorIconDrawableState.()V", this, null);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00012FFF File Offset: 0x000111FF
		private static Delegate GetRefreshStartIconDrawableStateHandler()
		{
			if (TextInputLayout.cb_refreshStartIconDrawableState == null)
			{
				TextInputLayout.cb_refreshStartIconDrawableState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextInputLayout.n_RefreshStartIconDrawableState));
			}
			return TextInputLayout.cb_refreshStartIconDrawableState;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00013023 File Offset: 0x00011223
		private static void n_RefreshStartIconDrawableState(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RefreshStartIconDrawableState();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00013032 File Offset: 0x00011232
		[Register("refreshStartIconDrawableState", "()V", "GetRefreshStartIconDrawableStateHandler")]
		public virtual void RefreshStartIconDrawableState()
		{
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("refreshStartIconDrawableState.()V", this, null);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001304B File Offset: 0x0001124B
		private static Delegate GetRemoveOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_Handler()
		{
			if (TextInputLayout.cb_removeOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_ == null)
			{
				TextInputLayout.cb_removeOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_RemoveOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_));
			}
			return TextInputLayout.cb_removeOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00013070 File Offset: 0x00011270
		private static void n_RemoveOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.IOnEditTextAttachedListener object2 = Java.Lang.Object.GetObject<TextInputLayout.IOnEditTextAttachedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnEditTextAttachedListener(object2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00013094 File Offset: 0x00011294
		[Register("removeOnEditTextAttachedListener", "(Lcom/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener;)V", "GetRemoveOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_Handler")]
		public unsafe virtual void RemoveOnEditTextAttachedListener(TextInputLayout.IOnEditTextAttachedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnEditTextAttachedListener.(Lcom/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000130FC File Offset: 0x000112FC
		private static Delegate GetRemoveOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_Handler()
		{
			if (TextInputLayout.cb_removeOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_ == null)
			{
				TextInputLayout.cb_removeOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_RemoveOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_));
			}
			return TextInputLayout.cb_removeOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00013120 File Offset: 0x00011320
		private static void n_RemoveOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.IOnEndIconChangedListener object2 = Java.Lang.Object.GetObject<TextInputLayout.IOnEndIconChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnEndIconChangedListener(object2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00013144 File Offset: 0x00011344
		[Register("removeOnEndIconChangedListener", "(Lcom/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener;)V", "GetRemoveOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_Handler")]
		public unsafe virtual void RemoveOnEndIconChangedListener(TextInputLayout.IOnEndIconChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnEndIconChangedListener.(Lcom/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000131AC File Offset: 0x000113AC
		private static Delegate GetSetBoxBackgroundColorResource_IHandler()
		{
			if (TextInputLayout.cb_setBoxBackgroundColorResource_I == null)
			{
				TextInputLayout.cb_setBoxBackgroundColorResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxBackgroundColorResource_I));
			}
			return TextInputLayout.cb_setBoxBackgroundColorResource_I;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000131D0 File Offset: 0x000113D0
		private static void n_SetBoxBackgroundColorResource_I(IntPtr jnienv, IntPtr native__this, int boxBackgroundColorId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxBackgroundColorResource(boxBackgroundColorId);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000131E0 File Offset: 0x000113E0
		[Register("setBoxBackgroundColorResource", "(I)V", "GetSetBoxBackgroundColorResource_IHandler")]
		public unsafe virtual void SetBoxBackgroundColorResource(int boxBackgroundColorId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(boxBackgroundColorId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxBackgroundColorResource.(I)V", this, ptr);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001321B File Offset: 0x0001141B
		private static Delegate GetSetBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00013240 File Offset: 0x00011440
		private static void n_SetBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_boxBackgroundColorStateList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_boxBackgroundColorStateList, JniHandleOwnership.DoNotTransfer);
			@object.SetBoxBackgroundColorStateList(object2);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00013264 File Offset: 0x00011464
		[Register("setBoxBackgroundColorStateList", "(Landroid/content/res/ColorStateList;)V", "GetSetBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetBoxBackgroundColorStateList(ColorStateList boxBackgroundColorStateList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((boxBackgroundColorStateList == null) ? IntPtr.Zero : boxBackgroundColorStateList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxBackgroundColorStateList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(boxBackgroundColorStateList);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000132C8 File Offset: 0x000114C8
		private static Delegate GetSetBoxCornerFamily_IHandler()
		{
			if (TextInputLayout.cb_setBoxCornerFamily_I == null)
			{
				TextInputLayout.cb_setBoxCornerFamily_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxCornerFamily_I));
			}
			return TextInputLayout.cb_setBoxCornerFamily_I;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000132EC File Offset: 0x000114EC
		private static void n_SetBoxCornerFamily_I(IntPtr jnienv, IntPtr native__this, int cornerFamily)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxCornerFamily(cornerFamily);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000132FC File Offset: 0x000114FC
		[Register("setBoxCornerFamily", "(I)V", "GetSetBoxCornerFamily_IHandler")]
		public unsafe virtual void SetBoxCornerFamily(int cornerFamily)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(cornerFamily);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxCornerFamily.(I)V", this, ptr);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00013337 File Offset: 0x00011537
		private static Delegate GetSetBoxCornerRadii_FFFFHandler()
		{
			if (TextInputLayout.cb_setBoxCornerRadii_FFFF == null)
			{
				TextInputLayout.cb_setBoxCornerRadii_FFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFF_V(TextInputLayout.n_SetBoxCornerRadii_FFFF));
			}
			return TextInputLayout.cb_setBoxCornerRadii_FFFF;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001335B File Offset: 0x0001155B
		private static void n_SetBoxCornerRadii_FFFF(IntPtr jnienv, IntPtr native__this, float boxCornerRadiusTopStart, float boxCornerRadiusTopEnd, float boxCornerRadiusBottomStart, float boxCornerRadiusBottomEnd)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxCornerRadii(boxCornerRadiusTopStart, boxCornerRadiusTopEnd, boxCornerRadiusBottomStart, boxCornerRadiusBottomEnd);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00013370 File Offset: 0x00011570
		[Register("setBoxCornerRadii", "(FFFF)V", "GetSetBoxCornerRadii_FFFFHandler")]
		public unsafe virtual void SetBoxCornerRadii(float boxCornerRadiusTopStart, float boxCornerRadiusTopEnd, float boxCornerRadiusBottomStart, float boxCornerRadiusBottomEnd)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(boxCornerRadiusTopStart);
			ptr[1] = new JniArgumentValue(boxCornerRadiusTopEnd);
			ptr[2] = new JniArgumentValue(boxCornerRadiusBottomStart);
			ptr[3] = new JniArgumentValue(boxCornerRadiusBottomEnd);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxCornerRadii.(FFFF)V", this, ptr);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000133EB File Offset: 0x000115EB
		private static Delegate GetSetBoxCornerRadiiResources_IIIIHandler()
		{
			if (TextInputLayout.cb_setBoxCornerRadiiResources_IIII == null)
			{
				TextInputLayout.cb_setBoxCornerRadiiResources_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_V(TextInputLayout.n_SetBoxCornerRadiiResources_IIII));
			}
			return TextInputLayout.cb_setBoxCornerRadiiResources_IIII;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0001340F File Offset: 0x0001160F
		private static void n_SetBoxCornerRadiiResources_IIII(IntPtr jnienv, IntPtr native__this, int boxCornerRadiusTopStartId, int boxCornerRadiusTopEndId, int boxCornerRadiusBottomEndId, int boxCornerRadiusBottomStartId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxCornerRadiiResources(boxCornerRadiusTopStartId, boxCornerRadiusTopEndId, boxCornerRadiusBottomEndId, boxCornerRadiusBottomStartId);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00013424 File Offset: 0x00011624
		[Register("setBoxCornerRadiiResources", "(IIII)V", "GetSetBoxCornerRadiiResources_IIIIHandler")]
		public unsafe virtual void SetBoxCornerRadiiResources(int boxCornerRadiusTopStartId, int boxCornerRadiusTopEndId, int boxCornerRadiusBottomEndId, int boxCornerRadiusBottomStartId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(boxCornerRadiusTopStartId);
			ptr[1] = new JniArgumentValue(boxCornerRadiusTopEndId);
			ptr[2] = new JniArgumentValue(boxCornerRadiusBottomEndId);
			ptr[3] = new JniArgumentValue(boxCornerRadiusBottomStartId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxCornerRadiiResources.(IIII)V", this, ptr);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001349F File Offset: 0x0001169F
		private static Delegate GetSetBoxStrokeColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setBoxStrokeColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setBoxStrokeColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetBoxStrokeColorStateList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setBoxStrokeColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000134C4 File Offset: 0x000116C4
		private static void n_SetBoxStrokeColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_boxStrokeColorStateList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_boxStrokeColorStateList, JniHandleOwnership.DoNotTransfer);
			@object.SetBoxStrokeColorStateList(object2);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000134E8 File Offset: 0x000116E8
		[Register("setBoxStrokeColorStateList", "(Landroid/content/res/ColorStateList;)V", "GetSetBoxStrokeColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetBoxStrokeColorStateList(ColorStateList boxStrokeColorStateList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((boxStrokeColorStateList == null) ? IntPtr.Zero : boxStrokeColorStateList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeColorStateList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(boxStrokeColorStateList);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001354C File Offset: 0x0001174C
		private static Delegate GetSetBoxStrokeWidthFocusedResource_IHandler()
		{
			if (TextInputLayout.cb_setBoxStrokeWidthFocusedResource_I == null)
			{
				TextInputLayout.cb_setBoxStrokeWidthFocusedResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxStrokeWidthFocusedResource_I));
			}
			return TextInputLayout.cb_setBoxStrokeWidthFocusedResource_I;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00013570 File Offset: 0x00011770
		private static void n_SetBoxStrokeWidthFocusedResource_I(IntPtr jnienv, IntPtr native__this, int boxStrokeWidthFocusedResId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxStrokeWidthFocusedResource(boxStrokeWidthFocusedResId);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00013580 File Offset: 0x00011780
		[Register("setBoxStrokeWidthFocusedResource", "(I)V", "GetSetBoxStrokeWidthFocusedResource_IHandler")]
		public unsafe virtual void SetBoxStrokeWidthFocusedResource(int boxStrokeWidthFocusedResId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(boxStrokeWidthFocusedResId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeWidthFocusedResource.(I)V", this, ptr);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000135BB File Offset: 0x000117BB
		private static Delegate GetSetBoxStrokeWidthResource_IHandler()
		{
			if (TextInputLayout.cb_setBoxStrokeWidthResource_I == null)
			{
				TextInputLayout.cb_setBoxStrokeWidthResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetBoxStrokeWidthResource_I));
			}
			return TextInputLayout.cb_setBoxStrokeWidthResource_I;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000135DF File Offset: 0x000117DF
		private static void n_SetBoxStrokeWidthResource_I(IntPtr jnienv, IntPtr native__this, int boxStrokeWidthResId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBoxStrokeWidthResource(boxStrokeWidthResId);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000135F0 File Offset: 0x000117F0
		[Register("setBoxStrokeWidthResource", "(I)V", "GetSetBoxStrokeWidthResource_IHandler")]
		public unsafe virtual void SetBoxStrokeWidthResource(int boxStrokeWidthResId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(boxStrokeWidthResId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setBoxStrokeWidthResource.(I)V", this, ptr);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0001362B File Offset: 0x0001182B
		private static Delegate GetSetCounterOverflowTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setCounterOverflowTextAppearance_I == null)
			{
				TextInputLayout.cb_setCounterOverflowTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetCounterOverflowTextAppearance_I));
			}
			return TextInputLayout.cb_setCounterOverflowTextAppearance_I;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001364F File Offset: 0x0001184F
		private static void n_SetCounterOverflowTextAppearance_I(IntPtr jnienv, IntPtr native__this, int counterOverflowTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCounterOverflowTextAppearance(counterOverflowTextAppearance);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00013660 File Offset: 0x00011860
		[Register("setCounterOverflowTextAppearance", "(I)V", "GetSetCounterOverflowTextAppearance_IHandler")]
		public unsafe virtual void SetCounterOverflowTextAppearance(int counterOverflowTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(counterOverflowTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterOverflowTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001369B File Offset: 0x0001189B
		private static Delegate GetSetCounterTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setCounterTextAppearance_I == null)
			{
				TextInputLayout.cb_setCounterTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetCounterTextAppearance_I));
			}
			return TextInputLayout.cb_setCounterTextAppearance_I;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000136BF File Offset: 0x000118BF
		private static void n_SetCounterTextAppearance_I(IntPtr jnienv, IntPtr native__this, int counterTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCounterTextAppearance(counterTextAppearance);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000136D0 File Offset: 0x000118D0
		[Register("setCounterTextAppearance", "(I)V", "GetSetCounterTextAppearance_IHandler")]
		public unsafe virtual void SetCounterTextAppearance(int counterTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(counterTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCounterTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001370B File Offset: 0x0001190B
		private static Delegate GetSetEndIconActivated_ZHandler()
		{
			if (TextInputLayout.cb_setEndIconActivated_Z == null)
			{
				TextInputLayout.cb_setEndIconActivated_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextInputLayout.n_SetEndIconActivated_Z));
			}
			return TextInputLayout.cb_setEndIconActivated_Z;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001372F File Offset: 0x0001192F
		private static void n_SetEndIconActivated_Z(IntPtr jnienv, IntPtr native__this, bool endIconActivated)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEndIconActivated(endIconActivated);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00013740 File Offset: 0x00011940
		[Register("setEndIconActivated", "(Z)V", "GetSetEndIconActivated_ZHandler")]
		public unsafe virtual void SetEndIconActivated(bool endIconActivated)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(endIconActivated);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconActivated.(Z)V", this, ptr);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0001377B File Offset: 0x0001197B
		private static Delegate GetSetEndIconContentDescription_IHandler()
		{
			if (TextInputLayout.cb_setEndIconContentDescription_I == null)
			{
				TextInputLayout.cb_setEndIconContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetEndIconContentDescription_I));
			}
			return TextInputLayout.cb_setEndIconContentDescription_I;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0001379F File Offset: 0x0001199F
		private static void n_SetEndIconContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEndIconContentDescription(resId);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000137B0 File Offset: 0x000119B0
		[Register("setEndIconContentDescription", "(I)V", "GetSetEndIconContentDescription_IHandler")]
		public unsafe virtual void SetEndIconContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconContentDescription.(I)V", this, ptr);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000137EB File Offset: 0x000119EB
		private static Delegate GetSetEndIconDrawable_IHandler()
		{
			if (TextInputLayout.cb_setEndIconDrawable_I == null)
			{
				TextInputLayout.cb_setEndIconDrawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetEndIconDrawable_I));
			}
			return TextInputLayout.cb_setEndIconDrawable_I;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0001380F File Offset: 0x00011A0F
		private static void n_SetEndIconDrawable_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEndIconDrawable(resId);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00013820 File Offset: 0x00011A20
		[Register("setEndIconDrawable", "(I)V", "GetSetEndIconDrawable_IHandler")]
		public unsafe virtual void SetEndIconDrawable(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconDrawable.(I)V", this, ptr);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0001385B File Offset: 0x00011A5B
		private static Delegate GetSetEndIconOnClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (TextInputLayout.cb_setEndIconOnClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				TextInputLayout.cb_setEndIconOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconOnClickListener_Landroid_view_View_OnClickListener_));
			}
			return TextInputLayout.cb_setEndIconOnClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00013880 File Offset: 0x00011A80
		private static void n_SetEndIconOnClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconOnClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_endIconOnClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetEndIconOnClickListener(object2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000138A4 File Offset: 0x00011AA4
		[Register("setEndIconOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetEndIconOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual void SetEndIconOnClickListener(View.IOnClickListener endIconOnClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((endIconOnClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)endIconOnClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconOnClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(endIconOnClickListener);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0001390C File Offset: 0x00011B0C
		private static Delegate GetSetEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler()
		{
			if (TextInputLayout.cb_setEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
			{
				TextInputLayout.cb_setEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_));
			}
			return TextInputLayout.cb_setEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00013930 File Offset: 0x00011B30
		private static void n_SetEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconOnLongClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnLongClickListener object2 = Java.Lang.Object.GetObject<View.IOnLongClickListener>(native_endIconOnLongClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetEndIconOnLongClickListener(object2);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00013954 File Offset: 0x00011B54
		[Register("setEndIconOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", "GetSetEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler")]
		public unsafe virtual void SetEndIconOnLongClickListener(View.IOnLongClickListener endIconOnLongClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((endIconOnLongClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)endIconOnLongClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconOnLongClickListener.(Landroid/view/View$OnLongClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(endIconOnLongClickListener);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000139BC File Offset: 0x00011BBC
		private static Delegate GetSetEndIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setEndIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setEndIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconTintList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setEndIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000139E0 File Offset: 0x00011BE0
		private static void n_SetEndIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconTintList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_endIconTintList, JniHandleOwnership.DoNotTransfer);
			@object.SetEndIconTintList(object2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00013A04 File Offset: 0x00011C04
		[Register("setEndIconTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetEndIconTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetEndIconTintList(ColorStateList endIconTintList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((endIconTintList == null) ? IntPtr.Zero : endIconTintList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(endIconTintList);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00013A68 File Offset: 0x00011C68
		private static Delegate GetSetEndIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (TextInputLayout.cb_setEndIconTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				TextInputLayout.cb_setEndIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetEndIconTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return TextInputLayout.cb_setEndIconTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00013A8C File Offset: 0x00011C8C
		private static void n_SetEndIconTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_endIconTintMode)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_endIconTintMode, JniHandleOwnership.DoNotTransfer);
			@object.SetEndIconTintMode(object2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00013AB0 File Offset: 0x00011CB0
		[Register("setEndIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetEndIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual void SetEndIconTintMode(PorterDuff.Mode endIconTintMode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((endIconTintMode == null) ? IntPtr.Zero : endIconTintMode.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setEndIconTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(endIconTintMode);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00013B14 File Offset: 0x00011D14
		private static Delegate GetSetErrorIconDrawable_IHandler()
		{
			if (TextInputLayout.cb_setErrorIconDrawable_I == null)
			{
				TextInputLayout.cb_setErrorIconDrawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetErrorIconDrawable_I));
			}
			return TextInputLayout.cb_setErrorIconDrawable_I;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00013B38 File Offset: 0x00011D38
		private static void n_SetErrorIconDrawable_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetErrorIconDrawable(resId);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00013B48 File Offset: 0x00011D48
		[Register("setErrorIconDrawable", "(I)V", "GetSetErrorIconDrawable_IHandler")]
		public unsafe virtual void SetErrorIconDrawable(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconDrawable.(I)V", this, ptr);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00013B83 File Offset: 0x00011D83
		private static Delegate GetSetErrorIconOnClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (TextInputLayout.cb_setErrorIconOnClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				TextInputLayout.cb_setErrorIconOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorIconOnClickListener_Landroid_view_View_OnClickListener_));
			}
			return TextInputLayout.cb_setErrorIconOnClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00013BA8 File Offset: 0x00011DA8
		private static void n_SetErrorIconOnClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorIconOnClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_errorIconOnClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetErrorIconOnClickListener(object2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00013BCC File Offset: 0x00011DCC
		[Register("setErrorIconOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetErrorIconOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual void SetErrorIconOnClickListener(View.IOnClickListener errorIconOnClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorIconOnClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)errorIconOnClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconOnClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorIconOnClickListener);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00013C34 File Offset: 0x00011E34
		private static Delegate GetSetErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler()
		{
			if (TextInputLayout.cb_setErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
			{
				TextInputLayout.cb_setErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_));
			}
			return TextInputLayout.cb_setErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00013C58 File Offset: 0x00011E58
		private static void n_SetErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorIconOnLongClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnLongClickListener object2 = Java.Lang.Object.GetObject<View.IOnLongClickListener>(native_errorIconOnLongClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetErrorIconOnLongClickListener(object2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00013C7C File Offset: 0x00011E7C
		[Register("setErrorIconOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", "GetSetErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler")]
		public unsafe virtual void SetErrorIconOnLongClickListener(View.IOnLongClickListener errorIconOnLongClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorIconOnLongClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)errorIconOnLongClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconOnLongClickListener.(Landroid/view/View$OnLongClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorIconOnLongClickListener);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00013CE4 File Offset: 0x00011EE4
		private static Delegate GetSetErrorIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setErrorIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setErrorIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorIconTintList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setErrorIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00013D08 File Offset: 0x00011F08
		private static void n_SetErrorIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorIconTintList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_errorIconTintList, JniHandleOwnership.DoNotTransfer);
			@object.SetErrorIconTintList(object2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00013D2C File Offset: 0x00011F2C
		[Register("setErrorIconTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetErrorIconTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetErrorIconTintList(ColorStateList errorIconTintList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorIconTintList == null) ? IntPtr.Zero : errorIconTintList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorIconTintList);
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00013D90 File Offset: 0x00011F90
		private static Delegate GetSetErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (TextInputLayout.cb_setErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				TextInputLayout.cb_setErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return TextInputLayout.cb_setErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00013DB4 File Offset: 0x00011FB4
		private static void n_SetErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorIconTintMode)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_errorIconTintMode, JniHandleOwnership.DoNotTransfer);
			@object.SetErrorIconTintMode(object2);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00013DD8 File Offset: 0x00011FD8
		[Register("setErrorIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual void SetErrorIconTintMode(PorterDuff.Mode errorIconTintMode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorIconTintMode == null) ? IntPtr.Zero : errorIconTintMode.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorIconTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorIconTintMode);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00013E3C File Offset: 0x0001203C
		private static Delegate GetSetErrorTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setErrorTextAppearance_I == null)
			{
				TextInputLayout.cb_setErrorTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetErrorTextAppearance_I));
			}
			return TextInputLayout.cb_setErrorTextAppearance_I;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00013E60 File Offset: 0x00012060
		private static void n_SetErrorTextAppearance_I(IntPtr jnienv, IntPtr native__this, int errorTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetErrorTextAppearance(errorTextAppearance);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00013E70 File Offset: 0x00012070
		[Register("setErrorTextAppearance", "(I)V", "GetSetErrorTextAppearance_IHandler")]
		public unsafe virtual void SetErrorTextAppearance(int errorTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(errorTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00013EAB File Offset: 0x000120AB
		private static Delegate GetSetErrorTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setErrorTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setErrorTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetErrorTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setErrorTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00013ED0 File Offset: 0x000120D0
		private static void n_SetErrorTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_errorTextColor, JniHandleOwnership.DoNotTransfer);
			@object.SetErrorTextColor(object2);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00013EF4 File Offset: 0x000120F4
		[Register("setErrorTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetErrorTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetErrorTextColor(ColorStateList errorTextColor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorTextColor == null) ? IntPtr.Zero : errorTextColor.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorTextColor);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00013F58 File Offset: 0x00012158
		private static Delegate GetSetHelperTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setHelperTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setHelperTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetHelperTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setHelperTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00013F7C File Offset: 0x0001217C
		private static void n_SetHelperTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_helperTextColor)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_helperTextColor, JniHandleOwnership.DoNotTransfer);
			@object.SetHelperTextColor(object2);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00013FA0 File Offset: 0x000121A0
		[Register("setHelperTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetHelperTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetHelperTextColor(ColorStateList helperTextColor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((helperTextColor == null) ? IntPtr.Zero : helperTextColor.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHelperTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(helperTextColor);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00014004 File Offset: 0x00012204
		private static Delegate GetSetHelperTextTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setHelperTextTextAppearance_I == null)
			{
				TextInputLayout.cb_setHelperTextTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetHelperTextTextAppearance_I));
			}
			return TextInputLayout.cb_setHelperTextTextAppearance_I;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00014028 File Offset: 0x00012228
		private static void n_SetHelperTextTextAppearance_I(IntPtr jnienv, IntPtr native__this, int helperTextTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHelperTextTextAppearance(helperTextTextAppearance);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00014038 File Offset: 0x00012238
		[Register("setHelperTextTextAppearance", "(I)V", "GetSetHelperTextTextAppearance_IHandler")]
		public unsafe virtual void SetHelperTextTextAppearance(int helperTextTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(helperTextTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHelperTextTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00014073 File Offset: 0x00012273
		private static Delegate GetSetHint_IHandler()
		{
			if (TextInputLayout.cb_setHint_I == null)
			{
				TextInputLayout.cb_setHint_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetHint_I));
			}
			return TextInputLayout.cb_setHint_I;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00014097 File Offset: 0x00012297
		private static void n_SetHint_I(IntPtr jnienv, IntPtr native__this, int textHintId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHint(textHintId);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000140A8 File Offset: 0x000122A8
		[Register("setHint", "(I)V", "GetSetHint_IHandler")]
		public unsafe virtual void SetHint(int textHintId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(textHintId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHint.(I)V", this, ptr);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000140E3 File Offset: 0x000122E3
		private static Delegate GetSetHintTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setHintTextAppearance_I == null)
			{
				TextInputLayout.cb_setHintTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetHintTextAppearance_I));
			}
			return TextInputLayout.cb_setHintTextAppearance_I;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00014107 File Offset: 0x00012307
		private static void n_SetHintTextAppearance_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHintTextAppearance(resId);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00014118 File Offset: 0x00012318
		[Register("setHintTextAppearance", "(I)V", "GetSetHintTextAppearance_IHandler")]
		public unsafe virtual void SetHintTextAppearance(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHintTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00014153 File Offset: 0x00012353
		private static Delegate GetSetMaxWidthResource_IHandler()
		{
			if (TextInputLayout.cb_setMaxWidthResource_I == null)
			{
				TextInputLayout.cb_setMaxWidthResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMaxWidthResource_I));
			}
			return TextInputLayout.cb_setMaxWidthResource_I;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00014177 File Offset: 0x00012377
		private static void n_SetMaxWidthResource_I(IntPtr jnienv, IntPtr native__this, int maxWidthId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxWidthResource(maxWidthId);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00014188 File Offset: 0x00012388
		[Register("setMaxWidthResource", "(I)V", "GetSetMaxWidthResource_IHandler")]
		public unsafe virtual void SetMaxWidthResource(int maxWidthId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxWidthId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxWidthResource.(I)V", this, ptr);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000141C3 File Offset: 0x000123C3
		private static Delegate GetSetMinWidthResource_IHandler()
		{
			if (TextInputLayout.cb_setMinWidthResource_I == null)
			{
				TextInputLayout.cb_setMinWidthResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetMinWidthResource_I));
			}
			return TextInputLayout.cb_setMinWidthResource_I;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000141E7 File Offset: 0x000123E7
		private static void n_SetMinWidthResource_I(IntPtr jnienv, IntPtr native__this, int minWidthId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMinWidthResource(minWidthId);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000141F8 File Offset: 0x000123F8
		[Register("setMinWidthResource", "(I)V", "GetSetMinWidthResource_IHandler")]
		public unsafe virtual void SetMinWidthResource(int minWidthId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(minWidthId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMinWidthResource.(I)V", this, ptr);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00014233 File Offset: 0x00012433
		private static Delegate GetSetPasswordVisibilityToggleContentDescription_IHandler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_I == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetPasswordVisibilityToggleContentDescription_I));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleContentDescription_I;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00014257 File Offset: 0x00012457
		private static void n_SetPasswordVisibilityToggleContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPasswordVisibilityToggleContentDescription(resId);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00014268 File Offset: 0x00012468
		[Register("setPasswordVisibilityToggleContentDescription", "(I)V", "GetSetPasswordVisibilityToggleContentDescription_IHandler")]
		public unsafe virtual void SetPasswordVisibilityToggleContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleContentDescription.(I)V", this, ptr);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000142A3 File Offset: 0x000124A3
		private static Delegate GetSetPasswordVisibilityToggleDrawable_IHandler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleDrawable_I == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleDrawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetPasswordVisibilityToggleDrawable_I));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleDrawable_I;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000142C7 File Offset: 0x000124C7
		private static void n_SetPasswordVisibilityToggleDrawable_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPasswordVisibilityToggleDrawable(resId);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000142D8 File Offset: 0x000124D8
		[Register("setPasswordVisibilityToggleDrawable", "(I)V", "GetSetPasswordVisibilityToggleDrawable_IHandler")]
		public unsafe virtual void SetPasswordVisibilityToggleDrawable(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleDrawable.(I)V", this, ptr);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00014313 File Offset: 0x00012513
		private static Delegate GetSetPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00014338 File Offset: 0x00012538
		private static void n_SetPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tintList, JniHandleOwnership.DoNotTransfer);
			@object.SetPasswordVisibilityToggleTintList(object2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001435C File Offset: 0x0001255C
		[Register("setPasswordVisibilityToggleTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetPasswordVisibilityToggleTintList(ColorStateList tintList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tintList == null) ? IntPtr.Zero : tintList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tintList);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000143C0 File Offset: 0x000125C0
		private static Delegate GetSetPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (TextInputLayout.cb_setPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				TextInputLayout.cb_setPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return TextInputLayout.cb_setPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000143E4 File Offset: 0x000125E4
		private static void n_SetPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.SetPasswordVisibilityToggleTintMode(object2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00014408 File Offset: 0x00012608
		[Register("setPasswordVisibilityToggleTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual void SetPasswordVisibilityToggleTintMode(PorterDuff.Mode mode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPasswordVisibilityToggleTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001446C File Offset: 0x0001266C
		private static Delegate GetSetPrefixTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setPrefixTextAppearance_I == null)
			{
				TextInputLayout.cb_setPrefixTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetPrefixTextAppearance_I));
			}
			return TextInputLayout.cb_setPrefixTextAppearance_I;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00014490 File Offset: 0x00012690
		private static void n_SetPrefixTextAppearance_I(IntPtr jnienv, IntPtr native__this, int prefixTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPrefixTextAppearance(prefixTextAppearance);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000144A0 File Offset: 0x000126A0
		[Register("setPrefixTextAppearance", "(I)V", "GetSetPrefixTextAppearance_IHandler")]
		public unsafe virtual void SetPrefixTextAppearance(int prefixTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(prefixTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setPrefixTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000144DB File Offset: 0x000126DB
		private static Delegate GetSetStartIconContentDescription_IHandler()
		{
			if (TextInputLayout.cb_setStartIconContentDescription_I == null)
			{
				TextInputLayout.cb_setStartIconContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetStartIconContentDescription_I));
			}
			return TextInputLayout.cb_setStartIconContentDescription_I;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000144FF File Offset: 0x000126FF
		private static void n_SetStartIconContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStartIconContentDescription(resId);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00014510 File Offset: 0x00012710
		[Register("setStartIconContentDescription", "(I)V", "GetSetStartIconContentDescription_IHandler")]
		public unsafe virtual void SetStartIconContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconContentDescription.(I)V", this, ptr);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001454B File Offset: 0x0001274B
		private static Delegate GetSetStartIconDrawable_IHandler()
		{
			if (TextInputLayout.cb_setStartIconDrawable_I == null)
			{
				TextInputLayout.cb_setStartIconDrawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetStartIconDrawable_I));
			}
			return TextInputLayout.cb_setStartIconDrawable_I;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001456F File Offset: 0x0001276F
		private static void n_SetStartIconDrawable_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStartIconDrawable(resId);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00014580 File Offset: 0x00012780
		[Register("setStartIconDrawable", "(I)V", "GetSetStartIconDrawable_IHandler")]
		public unsafe virtual void SetStartIconDrawable(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconDrawable.(I)V", this, ptr);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000145BB File Offset: 0x000127BB
		private static Delegate GetSetStartIconOnClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (TextInputLayout.cb_setStartIconOnClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				TextInputLayout.cb_setStartIconOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconOnClickListener_Landroid_view_View_OnClickListener_));
			}
			return TextInputLayout.cb_setStartIconOnClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000145E0 File Offset: 0x000127E0
		private static void n_SetStartIconOnClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconOnClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_startIconOnClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetStartIconOnClickListener(object2);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00014604 File Offset: 0x00012804
		[Register("setStartIconOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetStartIconOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual void SetStartIconOnClickListener(View.IOnClickListener startIconOnClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((startIconOnClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)startIconOnClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconOnClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(startIconOnClickListener);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001466C File Offset: 0x0001286C
		private static Delegate GetSetStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler()
		{
			if (TextInputLayout.cb_setStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
			{
				TextInputLayout.cb_setStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_));
			}
			return TextInputLayout.cb_setStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00014690 File Offset: 0x00012890
		private static void n_SetStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconOnLongClickListener)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnLongClickListener object2 = Java.Lang.Object.GetObject<View.IOnLongClickListener>(native_startIconOnLongClickListener, JniHandleOwnership.DoNotTransfer);
			@object.SetStartIconOnLongClickListener(object2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000146B4 File Offset: 0x000128B4
		[Register("setStartIconOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", "GetSetStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler")]
		public unsafe virtual void SetStartIconOnLongClickListener(View.IOnLongClickListener startIconOnLongClickListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((startIconOnLongClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)startIconOnLongClickListener).Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconOnLongClickListener.(Landroid/view/View$OnLongClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(startIconOnLongClickListener);
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001471C File Offset: 0x0001291C
		private static Delegate GetSetStartIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextInputLayout.cb_setStartIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				TextInputLayout.cb_setStartIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconTintList_Landroid_content_res_ColorStateList_));
			}
			return TextInputLayout.cb_setStartIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00014740 File Offset: 0x00012940
		private static void n_SetStartIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconTintList)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_startIconTintList, JniHandleOwnership.DoNotTransfer);
			@object.SetStartIconTintList(object2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00014764 File Offset: 0x00012964
		[Register("setStartIconTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetStartIconTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetStartIconTintList(ColorStateList startIconTintList)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((startIconTintList == null) ? IntPtr.Zero : startIconTintList.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(startIconTintList);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000147C8 File Offset: 0x000129C8
		private static Delegate GetSetStartIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (TextInputLayout.cb_setStartIconTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				TextInputLayout.cb_setStartIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetStartIconTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return TextInputLayout.cb_setStartIconTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000147EC File Offset: 0x000129EC
		private static void n_SetStartIconTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_startIconTintMode)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_startIconTintMode, JniHandleOwnership.DoNotTransfer);
			@object.SetStartIconTintMode(object2);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00014810 File Offset: 0x00012A10
		[Register("setStartIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetStartIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual void SetStartIconTintMode(PorterDuff.Mode startIconTintMode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((startIconTintMode == null) ? IntPtr.Zero : startIconTintMode.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStartIconTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(startIconTintMode);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00014874 File Offset: 0x00012A74
		private static Delegate GetSetSuffixTextAppearance_IHandler()
		{
			if (TextInputLayout.cb_setSuffixTextAppearance_I == null)
			{
				TextInputLayout.cb_setSuffixTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextInputLayout.n_SetSuffixTextAppearance_I));
			}
			return TextInputLayout.cb_setSuffixTextAppearance_I;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00014898 File Offset: 0x00012A98
		private static void n_SetSuffixTextAppearance_I(IntPtr jnienv, IntPtr native__this, int suffixTextAppearance)
		{
			Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSuffixTextAppearance(suffixTextAppearance);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000148A8 File Offset: 0x00012AA8
		[Register("setSuffixTextAppearance", "(I)V", "GetSetSuffixTextAppearance_IHandler")]
		public unsafe virtual void SetSuffixTextAppearance(int suffixTextAppearance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(suffixTextAppearance);
			TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSuffixTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000148E3 File Offset: 0x00012AE3
		private static Delegate GetSetTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_Handler()
		{
			if (TextInputLayout.cb_setTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_ == null)
			{
				TextInputLayout.cb_setTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.n_SetTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_));
			}
			return TextInputLayout.cb_setTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00014908 File Offset: 0x00012B08
		private static void n_SetTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_(IntPtr jnienv, IntPtr native__this, IntPtr native__delegate)
		{
			TextInputLayout @object = Java.Lang.Object.GetObject<TextInputLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextInputLayout.AccessibilityDelegate object2 = Java.Lang.Object.GetObject<TextInputLayout.AccessibilityDelegate>(native__delegate, JniHandleOwnership.DoNotTransfer);
			@object.SetTextInputAccessibilityDelegate(object2);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001492C File Offset: 0x00012B2C
		[Register("setTextInputAccessibilityDelegate", "(Lcom/google/android/material/textfield/TextInputLayout$AccessibilityDelegate;)V", "GetSetTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_Handler")]
		public unsafe virtual void SetTextInputAccessibilityDelegate(TextInputLayout.AccessibilityDelegate @delegate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@delegate == null) ? IntPtr.Zero : @delegate.Handle);
				TextInputLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTextInputAccessibilityDelegate.(Lcom/google/android/material/textfield/TextInputLayout$AccessibilityDelegate;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@delegate);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000798 RID: 1944 RVA: 0x00014990 File Offset: 0x00012B90
		// (remove) Token: 0x06000799 RID: 1945 RVA: 0x000149DC File Offset: 0x00012BDC
		public event EventHandler<TextInputLayout.EditTextAttachedEventArgs> EditTextAttached
		{
			add
			{
				EventHelper.AddEventHandler<TextInputLayout.IOnEditTextAttachedListener, TextInputLayout.IOnEditTextAttachedListenerImplementor>(ref this.weak_implementor_AddOnEditTextAttachedListener, new Func<TextInputLayout.IOnEditTextAttachedListenerImplementor>(this.__CreateIOnEditTextAttachedListenerImplementor), new Action<TextInputLayout.IOnEditTextAttachedListener>(this.AddOnEditTextAttachedListener), delegate(TextInputLayout.IOnEditTextAttachedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextInputLayout.EditTextAttachedEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<TextInputLayout.IOnEditTextAttachedListenerImplementor, bool> empty;
				if ((empty = TextInputLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (TextInputLayout.<>O.<0>____IsEmpty = new Func<TextInputLayout.IOnEditTextAttachedListenerImplementor, bool>(TextInputLayout.IOnEditTextAttachedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TextInputLayout.IOnEditTextAttachedListener, TextInputLayout.IOnEditTextAttachedListenerImplementor>(ref this.weak_implementor_AddOnEditTextAttachedListener, empty, delegate(TextInputLayout.IOnEditTextAttachedListener __v)
				{
					this.RemoveOnEditTextAttachedListener(__v);
				}, delegate(TextInputLayout.IOnEditTextAttachedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextInputLayout.EditTextAttachedEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00014A3B File Offset: 0x00012C3B
		private TextInputLayout.IOnEditTextAttachedListenerImplementor __CreateIOnEditTextAttachedListenerImplementor()
		{
			return new TextInputLayout.IOnEditTextAttachedListenerImplementor(this);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600079B RID: 1947 RVA: 0x00014A44 File Offset: 0x00012C44
		// (remove) Token: 0x0600079C RID: 1948 RVA: 0x00014A90 File Offset: 0x00012C90
		public event EventHandler<TextInputLayout.EndIconChangedEventArgs> EndIconChanged
		{
			add
			{
				EventHelper.AddEventHandler<TextInputLayout.IOnEndIconChangedListener, TextInputLayout.IOnEndIconChangedListenerImplementor>(ref this.weak_implementor_AddOnEndIconChangedListener, new Func<TextInputLayout.IOnEndIconChangedListenerImplementor>(this.__CreateIOnEndIconChangedListenerImplementor), new Action<TextInputLayout.IOnEndIconChangedListener>(this.AddOnEndIconChangedListener), delegate(TextInputLayout.IOnEndIconChangedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextInputLayout.EndIconChangedEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<TextInputLayout.IOnEndIconChangedListenerImplementor, bool> empty;
				if ((empty = TextInputLayout.<>O.<1>____IsEmpty) == null)
				{
					empty = (TextInputLayout.<>O.<1>____IsEmpty = new Func<TextInputLayout.IOnEndIconChangedListenerImplementor, bool>(TextInputLayout.IOnEndIconChangedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TextInputLayout.IOnEndIconChangedListener, TextInputLayout.IOnEndIconChangedListenerImplementor>(ref this.weak_implementor_AddOnEndIconChangedListener, empty, delegate(TextInputLayout.IOnEndIconChangedListener __v)
				{
					this.RemoveOnEndIconChangedListener(__v);
				}, delegate(TextInputLayout.IOnEndIconChangedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextInputLayout.EndIconChangedEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00014AEF File Offset: 0x00012CEF
		private TextInputLayout.IOnEndIconChangedListenerImplementor __CreateIOnEndIconChangedListenerImplementor()
		{
			return new TextInputLayout.IOnEndIconChangedListenerImplementor(this);
		}

		// Token: 0x0400016B RID: 363
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/textfield/TextInputLayout", typeof(TextInputLayout));

		// Token: 0x0400016C RID: 364
		private static Delegate cb_getBoxBackgroundColor;

		// Token: 0x0400016D RID: 365
		private static Delegate cb_setBoxBackgroundColor_I;

		// Token: 0x0400016E RID: 366
		private static Delegate cb_getBoxBackgroundMode;

		// Token: 0x0400016F RID: 367
		private static Delegate cb_setBoxBackgroundMode_I;

		// Token: 0x04000170 RID: 368
		private static Delegate cb_getBoxCollapsedPaddingTop;

		// Token: 0x04000171 RID: 369
		private static Delegate cb_setBoxCollapsedPaddingTop_I;

		// Token: 0x04000172 RID: 370
		private static Delegate cb_getBoxCornerRadiusBottomEnd;

		// Token: 0x04000173 RID: 371
		private static Delegate cb_getBoxCornerRadiusBottomStart;

		// Token: 0x04000174 RID: 372
		private static Delegate cb_getBoxCornerRadiusTopEnd;

		// Token: 0x04000175 RID: 373
		private static Delegate cb_getBoxCornerRadiusTopStart;

		// Token: 0x04000176 RID: 374
		private static Delegate cb_getBoxStrokeColor;

		// Token: 0x04000177 RID: 375
		private static Delegate cb_setBoxStrokeColor_I;

		// Token: 0x04000178 RID: 376
		private static Delegate cb_getBoxStrokeErrorColor;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_setBoxStrokeErrorColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400017A RID: 378
		private static Delegate cb_getBoxStrokeWidth;

		// Token: 0x0400017B RID: 379
		private static Delegate cb_setBoxStrokeWidth_I;

		// Token: 0x0400017C RID: 380
		private static Delegate cb_getBoxStrokeWidthFocused;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_setBoxStrokeWidthFocused_I;

		// Token: 0x0400017E RID: 382
		private static Delegate cb_isCounterEnabled;

		// Token: 0x0400017F RID: 383
		private static Delegate cb_setCounterEnabled_Z;

		// Token: 0x04000180 RID: 384
		private static Delegate cb_getCounterMaxLength;

		// Token: 0x04000181 RID: 385
		private static Delegate cb_setCounterMaxLength_I;

		// Token: 0x04000182 RID: 386
		private static Delegate cb_getCounterOverflowTextColor;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_setCounterOverflowTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000184 RID: 388
		private static Delegate cb_getCounterTextColor;

		// Token: 0x04000185 RID: 389
		private static Delegate cb_setCounterTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000186 RID: 390
		private static Delegate cb_getDefaultHintTextColor;

		// Token: 0x04000187 RID: 391
		private static Delegate cb_setDefaultHintTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000188 RID: 392
		private static Delegate cb_getEditText;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_isEndIconCheckable;

		// Token: 0x0400018A RID: 394
		private static Delegate cb_setEndIconCheckable_Z;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_getEndIconContentDescription;

		// Token: 0x0400018C RID: 396
		private static Delegate cb_setEndIconContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x0400018D RID: 397
		private static Delegate cb_getEndIconDrawable;

		// Token: 0x0400018E RID: 398
		private static Delegate cb_setEndIconDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400018F RID: 399
		private static Delegate cb_getEndIconMinSize;

		// Token: 0x04000190 RID: 400
		private static Delegate cb_setEndIconMinSize_I;

		// Token: 0x04000191 RID: 401
		private static Delegate cb_getEndIconMode;

		// Token: 0x04000192 RID: 402
		private static Delegate cb_setEndIconMode_I;

		// Token: 0x04000193 RID: 403
		private static Delegate cb_getEndIconScaleType;

		// Token: 0x04000194 RID: 404
		private static Delegate cb_setEndIconScaleType_Landroid_widget_ImageView_ScaleType_;

		// Token: 0x04000195 RID: 405
		private static Delegate cb_isEndIconVisible;

		// Token: 0x04000196 RID: 406
		private static Delegate cb_setEndIconVisible_Z;

		// Token: 0x04000197 RID: 407
		private static Delegate cb_getError;

		// Token: 0x04000198 RID: 408
		private static Delegate cb_setError_Ljava_lang_CharSequence_;

		// Token: 0x04000199 RID: 409
		private static Delegate cb_getErrorAccessibilityLiveRegion;

		// Token: 0x0400019A RID: 410
		private static Delegate cb_setErrorAccessibilityLiveRegion_I;

		// Token: 0x0400019B RID: 411
		private static Delegate cb_getErrorContentDescription;

		// Token: 0x0400019C RID: 412
		private static Delegate cb_setErrorContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x0400019D RID: 413
		private static Delegate cb_getErrorCurrentTextColors;

		// Token: 0x0400019E RID: 414
		private static Delegate cb_isErrorEnabled;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_setErrorEnabled_Z;

		// Token: 0x040001A0 RID: 416
		private static Delegate cb_getErrorIconDrawable;

		// Token: 0x040001A1 RID: 417
		private static Delegate cb_setErrorIconDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001A2 RID: 418
		private static Delegate cb_isExpandedHintEnabled;

		// Token: 0x040001A3 RID: 419
		private static Delegate cb_setExpandedHintEnabled_Z;

		// Token: 0x040001A4 RID: 420
		private static Delegate cb_getHelperText;

		// Token: 0x040001A5 RID: 421
		private static Delegate cb_setHelperText_Ljava_lang_CharSequence_;

		// Token: 0x040001A6 RID: 422
		private static Delegate cb_getHelperTextCurrentTextColor;

		// Token: 0x040001A7 RID: 423
		private static Delegate cb_isHelperTextEnabled;

		// Token: 0x040001A8 RID: 424
		private static Delegate cb_setHelperTextEnabled_Z;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_getHint;

		// Token: 0x040001AA RID: 426
		private static Delegate cb_setHint_Ljava_lang_CharSequence_;

		// Token: 0x040001AB RID: 427
		private static Delegate cb_isHintAnimationEnabled;

		// Token: 0x040001AC RID: 428
		private static Delegate cb_setHintAnimationEnabled_Z;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_isHintEnabled;

		// Token: 0x040001AE RID: 430
		private static Delegate cb_setHintEnabled_Z;

		// Token: 0x040001AF RID: 431
		private static Delegate cb_getHintTextColor;

		// Token: 0x040001B0 RID: 432
		private static Delegate cb_setHintTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040001B1 RID: 433
		private static Delegate cb_isProvidingHint;

		// Token: 0x040001B2 RID: 434
		private static Delegate cb_getLengthCounter;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_setLengthCounter_Lcom_google_android_material_textfield_TextInputLayout_LengthCounter_;

		// Token: 0x040001B4 RID: 436
		private static Delegate cb_getMaxEms;

		// Token: 0x040001B5 RID: 437
		private static Delegate cb_setMaxEms_I;

		// Token: 0x040001B6 RID: 438
		private static Delegate cb_getMaxWidth;

		// Token: 0x040001B7 RID: 439
		private static Delegate cb_setMaxWidth_I;

		// Token: 0x040001B8 RID: 440
		private static Delegate cb_getMinEms;

		// Token: 0x040001B9 RID: 441
		private static Delegate cb_setMinEms_I;

		// Token: 0x040001BA RID: 442
		private static Delegate cb_getMinWidth;

		// Token: 0x040001BB RID: 443
		private static Delegate cb_setMinWidth_I;

		// Token: 0x040001BC RID: 444
		private static Delegate cb_getPasswordVisibilityToggleContentDescription;

		// Token: 0x040001BD RID: 445
		private static Delegate cb_setPasswordVisibilityToggleContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x040001BE RID: 446
		private static Delegate cb_getPasswordVisibilityToggleDrawable;

		// Token: 0x040001BF RID: 447
		private static Delegate cb_setPasswordVisibilityToggleDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001C0 RID: 448
		private static Delegate cb_isPasswordVisibilityToggleEnabled;

		// Token: 0x040001C1 RID: 449
		private static Delegate cb_setPasswordVisibilityToggleEnabled_Z;

		// Token: 0x040001C2 RID: 450
		private static Delegate cb_getPlaceholderText;

		// Token: 0x040001C3 RID: 451
		private static Delegate cb_setPlaceholderText_Ljava_lang_CharSequence_;

		// Token: 0x040001C4 RID: 452
		private static Delegate cb_getPlaceholderTextAppearance;

		// Token: 0x040001C5 RID: 453
		private static Delegate cb_setPlaceholderTextAppearance_I;

		// Token: 0x040001C6 RID: 454
		private static Delegate cb_getPlaceholderTextColor;

		// Token: 0x040001C7 RID: 455
		private static Delegate cb_setPlaceholderTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040001C8 RID: 456
		private static Delegate cb_getPrefixText;

		// Token: 0x040001C9 RID: 457
		private static Delegate cb_setPrefixText_Ljava_lang_CharSequence_;

		// Token: 0x040001CA RID: 458
		private static Delegate cb_getPrefixTextColor;

		// Token: 0x040001CB RID: 459
		private static Delegate cb_setPrefixTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040001CC RID: 460
		private static Delegate cb_getPrefixTextView;

		// Token: 0x040001CD RID: 461
		private static Delegate cb_getShapeAppearanceModel;

		// Token: 0x040001CE RID: 462
		private static Delegate cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;

		// Token: 0x040001CF RID: 463
		private static Delegate cb_isStartIconCheckable;

		// Token: 0x040001D0 RID: 464
		private static Delegate cb_setStartIconCheckable_Z;

		// Token: 0x040001D1 RID: 465
		private static Delegate cb_getStartIconContentDescription;

		// Token: 0x040001D2 RID: 466
		private static Delegate cb_setStartIconContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x040001D3 RID: 467
		private static Delegate cb_getStartIconDrawable;

		// Token: 0x040001D4 RID: 468
		private static Delegate cb_setStartIconDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001D5 RID: 469
		private static Delegate cb_getStartIconMinSize;

		// Token: 0x040001D6 RID: 470
		private static Delegate cb_setStartIconMinSize_I;

		// Token: 0x040001D7 RID: 471
		private static Delegate cb_getStartIconScaleType;

		// Token: 0x040001D8 RID: 472
		private static Delegate cb_setStartIconScaleType_Landroid_widget_ImageView_ScaleType_;

		// Token: 0x040001D9 RID: 473
		private static Delegate cb_isStartIconVisible;

		// Token: 0x040001DA RID: 474
		private static Delegate cb_setStartIconVisible_Z;

		// Token: 0x040001DB RID: 475
		private static Delegate cb_getSuffixText;

		// Token: 0x040001DC RID: 476
		private static Delegate cb_setSuffixText_Ljava_lang_CharSequence_;

		// Token: 0x040001DD RID: 477
		private static Delegate cb_getSuffixTextColor;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_setSuffixTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040001DF RID: 479
		private static Delegate cb_getSuffixTextView;

		// Token: 0x040001E0 RID: 480
		private static Delegate cb_getTypeface;

		// Token: 0x040001E1 RID: 481
		private static Delegate cb_setTypeface_Landroid_graphics_Typeface_;

		// Token: 0x040001E2 RID: 482
		private static Delegate cb_addOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_;

		// Token: 0x040001E3 RID: 483
		private static Delegate cb_addOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_;

		// Token: 0x040001E4 RID: 484
		private static Delegate cb_clearOnEditTextAttachedListeners;

		// Token: 0x040001E5 RID: 485
		private static Delegate cb_clearOnEndIconChangedListeners;

		// Token: 0x040001E6 RID: 486
		private static Delegate cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;

		// Token: 0x040001E7 RID: 487
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x040001E8 RID: 488
		private static Delegate cb_passwordVisibilityToggleRequested_Z;

		// Token: 0x040001E9 RID: 489
		private static Delegate cb_refreshEndIconDrawableState;

		// Token: 0x040001EA RID: 490
		private static Delegate cb_refreshErrorIconDrawableState;

		// Token: 0x040001EB RID: 491
		private static Delegate cb_refreshStartIconDrawableState;

		// Token: 0x040001EC RID: 492
		private static Delegate cb_removeOnEditTextAttachedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEditTextAttachedListener_;

		// Token: 0x040001ED RID: 493
		private static Delegate cb_removeOnEndIconChangedListener_Lcom_google_android_material_textfield_TextInputLayout_OnEndIconChangedListener_;

		// Token: 0x040001EE RID: 494
		private static Delegate cb_setBoxBackgroundColorResource_I;

		// Token: 0x040001EF RID: 495
		private static Delegate cb_setBoxBackgroundColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001F0 RID: 496
		private static Delegate cb_setBoxCornerFamily_I;

		// Token: 0x040001F1 RID: 497
		private static Delegate cb_setBoxCornerRadii_FFFF;

		// Token: 0x040001F2 RID: 498
		private static Delegate cb_setBoxCornerRadiiResources_IIII;

		// Token: 0x040001F3 RID: 499
		private static Delegate cb_setBoxStrokeColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001F4 RID: 500
		private static Delegate cb_setBoxStrokeWidthFocusedResource_I;

		// Token: 0x040001F5 RID: 501
		private static Delegate cb_setBoxStrokeWidthResource_I;

		// Token: 0x040001F6 RID: 502
		private static Delegate cb_setCounterOverflowTextAppearance_I;

		// Token: 0x040001F7 RID: 503
		private static Delegate cb_setCounterTextAppearance_I;

		// Token: 0x040001F8 RID: 504
		private static Delegate cb_setEndIconActivated_Z;

		// Token: 0x040001F9 RID: 505
		private static Delegate cb_setEndIconContentDescription_I;

		// Token: 0x040001FA RID: 506
		private static Delegate cb_setEndIconDrawable_I;

		// Token: 0x040001FB RID: 507
		private static Delegate cb_setEndIconOnClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x040001FC RID: 508
		private static Delegate cb_setEndIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;

		// Token: 0x040001FD RID: 509
		private static Delegate cb_setEndIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_setEndIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040001FF RID: 511
		private static Delegate cb_setErrorIconDrawable_I;

		// Token: 0x04000200 RID: 512
		private static Delegate cb_setErrorIconOnClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x04000201 RID: 513
		private static Delegate cb_setErrorIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;

		// Token: 0x04000202 RID: 514
		private static Delegate cb_setErrorIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000203 RID: 515
		private static Delegate cb_setErrorIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000204 RID: 516
		private static Delegate cb_setErrorTextAppearance_I;

		// Token: 0x04000205 RID: 517
		private static Delegate cb_setErrorTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000206 RID: 518
		private static Delegate cb_setHelperTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000207 RID: 519
		private static Delegate cb_setHelperTextTextAppearance_I;

		// Token: 0x04000208 RID: 520
		private static Delegate cb_setHint_I;

		// Token: 0x04000209 RID: 521
		private static Delegate cb_setHintTextAppearance_I;

		// Token: 0x0400020A RID: 522
		private static Delegate cb_setMaxWidthResource_I;

		// Token: 0x0400020B RID: 523
		private static Delegate cb_setMinWidthResource_I;

		// Token: 0x0400020C RID: 524
		private static Delegate cb_setPasswordVisibilityToggleContentDescription_I;

		// Token: 0x0400020D RID: 525
		private static Delegate cb_setPasswordVisibilityToggleDrawable_I;

		// Token: 0x0400020E RID: 526
		private static Delegate cb_setPasswordVisibilityToggleTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x0400020F RID: 527
		private static Delegate cb_setPasswordVisibilityToggleTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000210 RID: 528
		private static Delegate cb_setPrefixTextAppearance_I;

		// Token: 0x04000211 RID: 529
		private static Delegate cb_setStartIconContentDescription_I;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_setStartIconDrawable_I;

		// Token: 0x04000213 RID: 531
		private static Delegate cb_setStartIconOnClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_setStartIconOnLongClickListener_Landroid_view_View_OnLongClickListener_;

		// Token: 0x04000215 RID: 533
		private static Delegate cb_setStartIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_setStartIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000217 RID: 535
		private static Delegate cb_setSuffixTextAppearance_I;

		// Token: 0x04000218 RID: 536
		private static Delegate cb_setTextInputAccessibilityDelegate_Lcom_google_android_material_textfield_TextInputLayout_AccessibilityDelegate_;

		// Token: 0x04000219 RID: 537
		private WeakReference weak_implementor_AddOnEditTextAttachedListener;

		// Token: 0x0400021A RID: 538
		private WeakReference weak_implementor_AddOnEndIconChangedListener;

		// Token: 0x02000067 RID: 103
		[Register("com/google/android/material/textfield/TextInputLayout$AccessibilityDelegate", DoNotGenerateAcw = true)]
		public new class AccessibilityDelegate : AccessibilityDelegateCompat
		{
			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600079F RID: 1951 RVA: 0x00014B14 File Offset: 0x00012D14
			internal static IntPtr class_ref
			{
				get
				{
					return TextInputLayout.AccessibilityDelegate._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00014B38 File Offset: 0x00012D38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextInputLayout.AccessibilityDelegate._members;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00014B40 File Offset: 0x00012D40
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TextInputLayout.AccessibilityDelegate._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00014B64 File Offset: 0x00012D64
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextInputLayout.AccessibilityDelegate._members.ManagedPeerType;
				}
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x00014B70 File Offset: 0x00012D70
			protected AccessibilityDelegate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x00014B7C File Offset: 0x00012D7C
			[Register(".ctor", "(Lcom/google/android/material/textfield/TextInputLayout;)V", "")]
			public unsafe AccessibilityDelegate(TextInputLayout layout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((layout == null) ? IntPtr.Zero : layout.Handle);
					base.SetHandle(TextInputLayout.AccessibilityDelegate._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/material/textfield/TextInputLayout;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					TextInputLayout.AccessibilityDelegate._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/material/textfield/TextInputLayout;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(layout);
				}
			}

			// Token: 0x0400021B RID: 539
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/textfield/TextInputLayout$AccessibilityDelegate", typeof(TextInputLayout.AccessibilityDelegate));
		}

		// Token: 0x02000068 RID: 104
		[Register("com/google/android/material/textfield/TextInputLayout$LengthCounter", "", "Google.Android.Material.TextField.TextInputLayout/ILengthCounterInvoker")]
		public interface ILengthCounter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060007A6 RID: 1958
			[Register("countLength", "(Landroid/text/Editable;)I", "GetCountLength_Landroid_text_Editable_Handler:Google.Android.Material.TextField.TextInputLayout/ILengthCounterInvoker, Xamarin.Google.Android.Material")]
			int CountLength(IEditable p0);
		}

		// Token: 0x02000069 RID: 105
		[Register("com/google/android/material/textfield/TextInputLayout$LengthCounter", DoNotGenerateAcw = true)]
		internal class ILengthCounterInvoker : Java.Lang.Object, TextInputLayout.ILengthCounter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00014C48 File Offset: 0x00012E48
			private static IntPtr java_class_ref
			{
				get
				{
					return TextInputLayout.ILengthCounterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00014C6C File Offset: 0x00012E6C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextInputLayout.ILengthCounterInvoker._members;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00014C73 File Offset: 0x00012E73
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x00014C7B File Offset: 0x00012E7B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextInputLayout.ILengthCounterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x00014C87 File Offset: 0x00012E87
			public static TextInputLayout.ILengthCounter GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TextInputLayout.ILengthCounter>(handle, transfer);
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00014C90 File Offset: 0x00012E90
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TextInputLayout.ILengthCounterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.textfield.TextInputLayout.LengthCounter'.");
				}
				return handle;
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00014CBB File Offset: 0x00012EBB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060007AE RID: 1966 RVA: 0x00014CEC File Offset: 0x00012EEC
			public ILengthCounterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TextInputLayout.ILengthCounterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x00014D24 File Offset: 0x00012F24
			private static Delegate GetCountLength_Landroid_text_Editable_Handler()
			{
				if (TextInputLayout.ILengthCounterInvoker.cb_countLength_Landroid_text_Editable_ == null)
				{
					TextInputLayout.ILengthCounterInvoker.cb_countLength_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(TextInputLayout.ILengthCounterInvoker.n_CountLength_Landroid_text_Editable_));
				}
				return TextInputLayout.ILengthCounterInvoker.cb_countLength_Landroid_text_Editable_;
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x00014D48 File Offset: 0x00012F48
			private static int n_CountLength_Landroid_text_Editable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TextInputLayout.ILengthCounter @object = Java.Lang.Object.GetObject<TextInputLayout.ILengthCounter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IEditable object2 = Java.Lang.Object.GetObject<IEditable>(native_p0, JniHandleOwnership.DoNotTransfer);
				return @object.CountLength(object2);
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x00014D6C File Offset: 0x00012F6C
			public unsafe int CountLength(IEditable p0)
			{
				if (this.id_countLength_Landroid_text_Editable_ == IntPtr.Zero)
				{
					this.id_countLength_Landroid_text_Editable_ = JNIEnv.GetMethodID(this.class_ref, "countLength", "(Landroid/text/Editable;)I");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				return JNIEnv.CallIntMethod(base.Handle, this.id_countLength_Landroid_text_Editable_, ptr);
			}

			// Token: 0x0400021C RID: 540
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/textfield/TextInputLayout$LengthCounter", typeof(TextInputLayout.ILengthCounterInvoker));

			// Token: 0x0400021D RID: 541
			private IntPtr class_ref;

			// Token: 0x0400021E RID: 542
			private static Delegate cb_countLength_Landroid_text_Editable_;

			// Token: 0x0400021F RID: 543
			private IntPtr id_countLength_Landroid_text_Editable_;
		}

		// Token: 0x0200006A RID: 106
		[Register("com/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener", "", "Google.Android.Material.TextField.TextInputLayout/IOnEditTextAttachedListenerInvoker")]
		public interface IOnEditTextAttachedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060007B3 RID: 1971
			[Register("onEditTextAttached", "(Lcom/google/android/material/textfield/TextInputLayout;)V", "GetOnEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_Handler:Google.Android.Material.TextField.TextInputLayout/IOnEditTextAttachedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnEditTextAttached(TextInputLayout p0);
		}

		// Token: 0x0200006B RID: 107
		[Register("com/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener", DoNotGenerateAcw = true)]
		internal class IOnEditTextAttachedListenerInvoker : Java.Lang.Object, TextInputLayout.IOnEditTextAttachedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00014E00 File Offset: 0x00013000
			private static IntPtr java_class_ref
			{
				get
				{
					return TextInputLayout.IOnEditTextAttachedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00014E24 File Offset: 0x00013024
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextInputLayout.IOnEditTextAttachedListenerInvoker._members;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00014E2B File Offset: 0x0001302B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00014E33 File Offset: 0x00013033
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextInputLayout.IOnEditTextAttachedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060007B8 RID: 1976 RVA: 0x00014E3F File Offset: 0x0001303F
			public static TextInputLayout.IOnEditTextAttachedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TextInputLayout.IOnEditTextAttachedListener>(handle, transfer);
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x00014E48 File Offset: 0x00013048
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TextInputLayout.IOnEditTextAttachedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.textfield.TextInputLayout.OnEditTextAttachedListener'.");
				}
				return handle;
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x00014E73 File Offset: 0x00013073
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x00014EA4 File Offset: 0x000130A4
			public IOnEditTextAttachedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TextInputLayout.IOnEditTextAttachedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x00014EDC File Offset: 0x000130DC
			private static Delegate GetOnEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_Handler()
			{
				if (TextInputLayout.IOnEditTextAttachedListenerInvoker.cb_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_ == null)
				{
					TextInputLayout.IOnEditTextAttachedListenerInvoker.cb_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextInputLayout.IOnEditTextAttachedListenerInvoker.n_OnEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_));
				}
				return TextInputLayout.IOnEditTextAttachedListenerInvoker.cb_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_;
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x00014F00 File Offset: 0x00013100
			private static void n_OnEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TextInputLayout.IOnEditTextAttachedListener @object = Java.Lang.Object.GetObject<TextInputLayout.IOnEditTextAttachedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TextInputLayout object2 = Java.Lang.Object.GetObject<TextInputLayout>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnEditTextAttached(object2);
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x00014F24 File Offset: 0x00013124
			public unsafe void OnEditTextAttached(TextInputLayout p0)
			{
				if (this.id_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_ == IntPtr.Zero)
				{
					this.id_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_ = JNIEnv.GetMethodID(this.class_ref, "onEditTextAttached", "(Lcom/google/android/material/textfield/TextInputLayout;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_, ptr);
			}

			// Token: 0x04000220 RID: 544
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/textfield/TextInputLayout$OnEditTextAttachedListener", typeof(TextInputLayout.IOnEditTextAttachedListenerInvoker));

			// Token: 0x04000221 RID: 545
			private IntPtr class_ref;

			// Token: 0x04000222 RID: 546
			private static Delegate cb_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_;

			// Token: 0x04000223 RID: 547
			private IntPtr id_onEditTextAttached_Lcom_google_android_material_textfield_TextInputLayout_;
		}

		// Token: 0x0200006C RID: 108
		public class EditTextAttachedEventArgs : EventArgs
		{
			// Token: 0x060007C0 RID: 1984 RVA: 0x00014FB2 File Offset: 0x000131B2
			public EditTextAttachedEventArgs(TextInputLayout p0)
			{
				this.p0 = p0;
			}

			// Token: 0x04000224 RID: 548
			private TextInputLayout p0;
		}

		// Token: 0x0200006D RID: 109
		[Register("mono/com/google/android/material/textfield/TextInputLayout_OnEditTextAttachedListenerImplementor")]
		internal sealed class IOnEditTextAttachedListenerImplementor : Java.Lang.Object, TextInputLayout.IOnEditTextAttachedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060007C1 RID: 1985 RVA: 0x00014FC1 File Offset: 0x000131C1
			public IOnEditTextAttachedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/textfield/TextInputLayout_OnEditTextAttachedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00014FFC File Offset: 0x000131FC
			public void OnEditTextAttached(TextInputLayout p0)
			{
				EventHandler<TextInputLayout.EditTextAttachedEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new TextInputLayout.EditTextAttachedEventArgs(p0));
				}
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x00015025 File Offset: 0x00013225
			internal static bool __IsEmpty(TextInputLayout.IOnEditTextAttachedListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000225 RID: 549
			private object sender;

			// Token: 0x04000226 RID: 550
			public EventHandler<TextInputLayout.EditTextAttachedEventArgs> Handler;
		}

		// Token: 0x0200006E RID: 110
		[Register("com/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener", "", "Google.Android.Material.TextField.TextInputLayout/IOnEndIconChangedListenerInvoker")]
		public interface IOnEndIconChangedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060007C4 RID: 1988
			[Register("onEndIconChanged", "(Lcom/google/android/material/textfield/TextInputLayout;I)V", "GetOnEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_IHandler:Google.Android.Material.TextField.TextInputLayout/IOnEndIconChangedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnEndIconChanged(TextInputLayout p0, int p1);
		}

		// Token: 0x0200006F RID: 111
		[Register("com/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener", DoNotGenerateAcw = true)]
		internal class IOnEndIconChangedListenerInvoker : Java.Lang.Object, TextInputLayout.IOnEndIconChangedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00015030 File Offset: 0x00013230
			private static IntPtr java_class_ref
			{
				get
				{
					return TextInputLayout.IOnEndIconChangedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00015054 File Offset: 0x00013254
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextInputLayout.IOnEndIconChangedListenerInvoker._members;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060007C7 RID: 1991 RVA: 0x0001505B File Offset: 0x0001325B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00015063 File Offset: 0x00013263
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextInputLayout.IOnEndIconChangedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x0001506F File Offset: 0x0001326F
			public static TextInputLayout.IOnEndIconChangedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TextInputLayout.IOnEndIconChangedListener>(handle, transfer);
			}

			// Token: 0x060007CA RID: 1994 RVA: 0x00015078 File Offset: 0x00013278
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TextInputLayout.IOnEndIconChangedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.textfield.TextInputLayout.OnEndIconChangedListener'.");
				}
				return handle;
			}

			// Token: 0x060007CB RID: 1995 RVA: 0x000150A3 File Offset: 0x000132A3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060007CC RID: 1996 RVA: 0x000150D4 File Offset: 0x000132D4
			public IOnEndIconChangedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TextInputLayout.IOnEndIconChangedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060007CD RID: 1997 RVA: 0x0001510C File Offset: 0x0001330C
			private static Delegate GetOnEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_IHandler()
			{
				if (TextInputLayout.IOnEndIconChangedListenerInvoker.cb_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I == null)
				{
					TextInputLayout.IOnEndIconChangedListenerInvoker.cb_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(TextInputLayout.IOnEndIconChangedListenerInvoker.n_OnEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I));
				}
				return TextInputLayout.IOnEndIconChangedListenerInvoker.cb_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I;
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x00015130 File Offset: 0x00013330
			private static void n_OnEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				TextInputLayout.IOnEndIconChangedListener @object = Java.Lang.Object.GetObject<TextInputLayout.IOnEndIconChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TextInputLayout object2 = Java.Lang.Object.GetObject<TextInputLayout>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnEndIconChanged(object2, p1);
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x00015154 File Offset: 0x00013354
			public unsafe void OnEndIconChanged(TextInputLayout p0, int p1)
			{
				if (this.id_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I == IntPtr.Zero)
				{
					this.id_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I = JNIEnv.GetMethodID(this.class_ref, "onEndIconChanged", "(Lcom/google/android/material/textfield/TextInputLayout;I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue(p1);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I, ptr);
			}

			// Token: 0x04000227 RID: 551
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/textfield/TextInputLayout$OnEndIconChangedListener", typeof(TextInputLayout.IOnEndIconChangedListenerInvoker));

			// Token: 0x04000228 RID: 552
			private IntPtr class_ref;

			// Token: 0x04000229 RID: 553
			private static Delegate cb_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I;

			// Token: 0x0400022A RID: 554
			private IntPtr id_onEndIconChanged_Lcom_google_android_material_textfield_TextInputLayout_I;
		}

		// Token: 0x02000070 RID: 112
		public class EndIconChangedEventArgs : EventArgs
		{
			// Token: 0x060007D1 RID: 2001 RVA: 0x000151F5 File Offset: 0x000133F5
			public EndIconChangedEventArgs(TextInputLayout p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			// Token: 0x0400022B RID: 555
			private TextInputLayout p0;

			// Token: 0x0400022C RID: 556
			private int p1;
		}

		// Token: 0x02000071 RID: 113
		[Register("mono/com/google/android/material/textfield/TextInputLayout_OnEndIconChangedListenerImplementor")]
		internal sealed class IOnEndIconChangedListenerImplementor : Java.Lang.Object, TextInputLayout.IOnEndIconChangedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060007D2 RID: 2002 RVA: 0x0001520B File Offset: 0x0001340B
			public IOnEndIconChangedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/textfield/TextInputLayout_OnEndIconChangedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00015244 File Offset: 0x00013444
			public void OnEndIconChanged(TextInputLayout p0, int p1)
			{
				EventHandler<TextInputLayout.EndIconChangedEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new TextInputLayout.EndIconChangedEventArgs(p0, p1));
				}
			}

			// Token: 0x060007D4 RID: 2004 RVA: 0x0001526E File Offset: 0x0001346E
			internal static bool __IsEmpty(TextInputLayout.IOnEndIconChangedListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x0400022D RID: 557
			private object sender;

			// Token: 0x0400022E RID: 558
			public EventHandler<TextInputLayout.EndIconChangedEventArgs> Handler;
		}

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400022F RID: 559
			public static Func<TextInputLayout.IOnEditTextAttachedListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x04000230 RID: 560
			public static Func<TextInputLayout.IOnEndIconChangedListenerImplementor, bool> <1>____IsEmpty;
		}
	}
}
