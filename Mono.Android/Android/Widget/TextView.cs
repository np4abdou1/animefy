using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Text.Method;
using Android.Util;
using Android.Views;
using Android.Views.InputMethods;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000F4 RID: 244
	[Register("android/widget/TextView", DoNotGenerateAcw = true)]
	public class TextView : View, ViewTreeObserver.IOnPreDrawListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		internal static IntPtr class_ref
		{
			get
			{
				return TextView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0000C320 File Offset: 0x0000A520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextView._members;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0000C328 File Offset: 0x0000A528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000C34C File Offset: 0x0000A54C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextView._members.ManagedPeerType;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00008888 File Offset: 0x00006A88
		protected TextView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000C358 File Offset: 0x0000A558
		public unsafe TextView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(TextView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000C434 File Offset: 0x0000A634
		public unsafe TextView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(TextView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000C524 File Offset: 0x0000A724
		private static Delegate GetSetError_Ljava_lang_CharSequence_Handler()
		{
			if (TextView.cb_setError_Ljava_lang_CharSequence_ == null)
			{
				TextView.cb_setError_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextView.n_SetError_Ljava_lang_CharSequence_));
			}
			return TextView.cb_setError_Ljava_lang_CharSequence_;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000C548 File Offset: 0x0000A748
		private static void n_SetError_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_error)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_error, JniHandleOwnership.DoNotTransfer);
			@object.ErrorFormatted = object2;
		}

		// Token: 0x17000100 RID: 256
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0000C56C File Offset: 0x0000A76C
		public unsafe virtual ICharSequence ErrorFormatted
		{
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setError.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		public string Error
		{
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		public Layout Layout
		{
			get
			{
				return Java.Lang.Object.GetObject<Layout>(TextView._members.InstanceMethods.InvokeNonvirtualObjectMethod("getLayout.()Landroid/text/Layout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000C62E File Offset: 0x0000A82E
		private static Delegate GetGetLineCountHandler()
		{
			if (TextView.cb_getLineCount == null)
			{
				TextView.cb_getLineCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextView.n_GetLineCount));
			}
			return TextView.cb_getLineCount;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000C652 File Offset: 0x0000A852
		private static int n_GetLineCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineCount;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0000C661 File Offset: 0x0000A861
		public virtual int LineCount
		{
			get
			{
				return TextView._members.InstanceMethods.InvokeVirtualInt32Method("getLineCount.()I", this, null);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000C67A File Offset: 0x0000A87A
		private static Delegate GetGetMaxLinesHandler()
		{
			if (TextView.cb_getMaxLines == null)
			{
				TextView.cb_getMaxLines = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextView.n_GetMaxLines));
			}
			return TextView.cb_getMaxLines;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000C69E File Offset: 0x0000A89E
		private static int n_GetMaxLines(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxLines;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000C6AD File Offset: 0x0000A8AD
		public virtual int MaxLines
		{
			get
			{
				return TextView._members.InstanceMethods.InvokeVirtualInt32Method("getMaxLines.()I", this, null);
			}
		}

		// Token: 0x17000105 RID: 261
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public unsafe IMovementMethod MovementMethod
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					TextView._members.InstanceMethods.InvokeNonvirtualVoidMethod("setMovementMethod.(Landroid/text/method/MovementMethod;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0000C730 File Offset: 0x0000A930
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000C764 File Offset: 0x0000A964
		public unsafe ICharSequence TextFormatted
		{
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(TextView._members.InstanceMethods.InvokeVirtualObjectMethod("getText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					TextView._members.InstanceMethods.InvokeNonvirtualVoidMethod("setText.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
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

		// Token: 0x17000108 RID: 264
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public unsafe ITransformationMethod TransformationMethod
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					TextView._members.InstanceMethods.InvokeNonvirtualVoidMethod("setTransformationMethod.(Landroid/text/method/TransformationMethod;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000C874 File Offset: 0x0000AA74
		private static Delegate GetGetTypefaceHandler()
		{
			if (TextView.cb_getTypeface == null)
			{
				TextView.cb_getTypeface = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextView.n_GetTypeface));
			}
			return TextView.cb_getTypeface;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000C898 File Offset: 0x0000AA98
		private static IntPtr n_GetTypeface(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Typeface);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		public virtual Typeface Typeface
		{
			get
			{
				return Java.Lang.Object.GetObject<Typeface>(TextView._members.InstanceMethods.InvokeVirtualObjectMethod("getTypeface.()Landroid/graphics/Typeface;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000C8DE File Offset: 0x0000AADE
		private static Delegate GetLengthHandler()
		{
			if (TextView.cb_length == null)
			{
				TextView.cb_length = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TextView.n_Length));
			}
			return TextView.cb_length;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000C902 File Offset: 0x0000AB02
		private static int n_Length(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Length();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000C911 File Offset: 0x0000AB11
		public virtual int Length()
		{
			return TextView._members.InstanceMethods.InvokeVirtualInt32Method("length.()I", this, null);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000C92A File Offset: 0x0000AB2A
		private static Delegate GetOnPreDrawHandler()
		{
			if (TextView.cb_onPreDraw == null)
			{
				TextView.cb_onPreDraw = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextView.n_OnPreDraw));
			}
			return TextView.cb_onPreDraw;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000C94E File Offset: 0x0000AB4E
		private static bool n_OnPreDraw(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPreDraw();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000C95D File Offset: 0x0000AB5D
		public virtual bool OnPreDraw()
		{
			return TextView._members.InstanceMethods.InvokeVirtualBooleanMethod("onPreDraw.()Z", this, null);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000C976 File Offset: 0x0000AB76
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (TextView.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				TextView.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextView.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return TextView.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000C99C File Offset: 0x0000AB9C
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		public new unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				TextView._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000CA28 File Offset: 0x0000AC28
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (TextView.cb_onSaveInstanceState == null)
			{
				TextView.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextView.n_OnSaveInstanceState));
			}
			return TextView.cb_onSaveInstanceState;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000CA60 File Offset: 0x0000AC60
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(TextView._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000CA92 File Offset: 0x0000AC92
		private static Delegate GetSetFilters_arrayLandroid_text_InputFilter_Handler()
		{
			if (TextView.cb_setFilters_arrayLandroid_text_InputFilter_ == null)
			{
				TextView.cb_setFilters_arrayLandroid_text_InputFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextView.n_SetFilters_arrayLandroid_text_InputFilter_));
			}
			return TextView.cb_setFilters_arrayLandroid_text_InputFilter_;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		private static void n_SetFilters_arrayLandroid_text_InputFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_filters)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInputFilter[] array = (IInputFilter[])JNIEnv.GetArray(native_filters, JniHandleOwnership.DoNotTransfer, typeof(IInputFilter));
			@object.SetFilters(array);
			if (array != null)
			{
				JNIEnv.CopyArray<IInputFilter>(array, native_filters);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		public unsafe virtual void SetFilters(IInputFilter[] filters)
		{
			IntPtr intPtr = JNIEnv.NewArray<IInputFilter>(filters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setFilters.([Landroid/text/InputFilter;)V", this, ptr);
			}
			finally
			{
				if (filters != null)
				{
					JNIEnv.CopyArray<IInputFilter>(intPtr, filters);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(filters);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000CB60 File Offset: 0x0000AD60
		private static Delegate GetSetMaxLines_IHandler()
		{
			if (TextView.cb_setMaxLines_I == null)
			{
				TextView.cb_setMaxLines_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextView.n_SetMaxLines_I));
			}
			return TextView.cb_setMaxLines_I;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000CB84 File Offset: 0x0000AD84
		private static void n_SetMaxLines_I(IntPtr jnienv, IntPtr native__this, int maxLines)
		{
			Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxLines(maxLines);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000CB94 File Offset: 0x0000AD94
		public unsafe virtual void SetMaxLines(int maxLines)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxLines);
			TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxLines.(I)V", this, ptr);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		private static Delegate GetSetOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_Handler()
		{
			if (TextView.cb_setOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_ == null)
			{
				TextView.cb_setOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextView.n_SetOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_));
			}
			return TextView.cb_setOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		private static void n_SetOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextView.IOnEditorActionListener object2 = Java.Lang.Object.GetObject<TextView.IOnEditorActionListener>(native_l, JniHandleOwnership.DoNotTransfer);
			@object.SetOnEditorActionListener(object2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000CC18 File Offset: 0x0000AE18
		public unsafe virtual void SetOnEditorActionListener(TextView.IOnEditorActionListener l)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((l == null) ? IntPtr.Zero : ((Java.Lang.Object)l).Handle);
				TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setOnEditorActionListener.(Landroid/widget/TextView$OnEditorActionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(l);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000CC80 File Offset: 0x0000AE80
		private static Delegate GetSetText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_Handler()
		{
			if (TextView.cb_setText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_ == null)
			{
				TextView.cb_setText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(TextView.n_SetText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_));
			}
			return TextView.cb_setText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		private static void n_SetText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_type)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			TextView.BufferType object3 = Java.Lang.Object.GetObject<TextView.BufferType>(native_type, JniHandleOwnership.DoNotTransfer);
			@object.SetText(object2, object3);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		public unsafe virtual void SetText(ICharSequence text, TextView.BufferType type)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setText.(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(type);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		private static Delegate GetSetTextColor_IHandler()
		{
			if (TextView.cb_setTextColor_I == null)
			{
				TextView.cb_setTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextView.n_SetTextColor_I));
			}
			return TextView.cb_setTextColor_I;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000CD80 File Offset: 0x0000AF80
		private static void n_SetTextColor_I(IntPtr jnienv, IntPtr native__this, int native_color)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Color textColor = new Color(native_color);
			@object.SetTextColor(textColor);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		public unsafe virtual void SetTextColor(Color color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color.ToArgb());
			TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setTextColor.(I)V", this, ptr);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000CDE5 File Offset: 0x0000AFE5
		private static Delegate GetSetTypeface_Landroid_graphics_Typeface_IHandler()
		{
			if (TextView.cb_setTypeface_Landroid_graphics_Typeface_I == null)
			{
				TextView.cb_setTypeface_Landroid_graphics_Typeface_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(TextView.n_SetTypeface_Landroid_graphics_Typeface_I));
			}
			return TextView.cb_setTypeface_Landroid_graphics_Typeface_I;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000CE0C File Offset: 0x0000B00C
		private static void n_SetTypeface_Landroid_graphics_Typeface_I(IntPtr jnienv, IntPtr native__this, IntPtr native_tf, int native_style)
		{
			TextView @object = Java.Lang.Object.GetObject<TextView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_tf, JniHandleOwnership.DoNotTransfer);
			@object.SetTypeface(object2, (TypefaceStyle)native_style);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000CE34 File Offset: 0x0000B034
		public unsafe virtual void SetTypeface(Typeface tf, [GeneratedEnum] TypefaceStyle style)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tf == null) ? IntPtr.Zero : tf.Handle);
				ptr[1] = new JniArgumentValue((int)style);
				TextView._members.InstanceMethods.InvokeVirtualVoidMethod("setTypeface.(Landroid/graphics/Typeface;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tf);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060005D3 RID: 1491 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		// (remove) Token: 0x060005D4 RID: 1492 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		public event EventHandler<TextView.EditorActionEventArgs> EditorAction
		{
			add
			{
				EventHelper.AddEventHandler<TextView.IOnEditorActionListener, TextView.IOnEditorActionListenerImplementor>(ref this.weak_implementor_SetOnEditorActionListener, new Func<TextView.IOnEditorActionListenerImplementor>(this.__CreateIOnEditorActionListenerImplementor), new Action<TextView.IOnEditorActionListener>(this.SetOnEditorActionListener), delegate(TextView.IOnEditorActionListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextView.EditorActionEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<TextView.IOnEditorActionListenerImplementor, bool> empty;
				if ((empty = TextView.<>O.<0>____IsEmpty) == null)
				{
					empty = (TextView.<>O.<0>____IsEmpty = new Func<TextView.IOnEditorActionListenerImplementor, bool>(TextView.IOnEditorActionListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TextView.IOnEditorActionListener, TextView.IOnEditorActionListenerImplementor>(ref this.weak_implementor_SetOnEditorActionListener, empty, delegate(TextView.IOnEditorActionListener __v)
				{
					this.SetOnEditorActionListener(null);
				}, delegate(TextView.IOnEditorActionListenerImplementor __h)
				{
					__h.Handler = (EventHandler<TextView.EditorActionEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000CF57 File Offset: 0x0000B157
		private TextView.IOnEditorActionListenerImplementor __CreateIOnEditorActionListenerImplementor()
		{
			return new TextView.IOnEditorActionListenerImplementor();
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000CF60 File Offset: 0x0000B160
		private void AddTextChangedListener(TextWatcherImplementor watcher)
		{
			if (TextView.id_addTextChangedListener == IntPtr.Zero)
			{
				TextView.id_addTextChangedListener = JNIEnv.GetMethodID(TextView.class_ref, "addTextChangedListener", "(Landroid/text/TextWatcher;)V");
			}
			JNIEnv.CallVoidMethod(base.Handle, TextView.id_addTextChangedListener, new JValue[]
			{
				new JValue(watcher)
			});
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060005D7 RID: 1495 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		// (remove) Token: 0x060005D8 RID: 1496 RVA: 0x0000D030 File Offset: 0x0000B230
		public event EventHandler<TextChangedEventArgs> TextChanged
		{
			add
			{
				if (this.implementor_TextWatcher == null || !this.implementor_TextWatcher.IsAlive)
				{
					this.implementor_TextWatcher = new WeakReference(new TextWatcherImplementor(this, value, null, null));
					this.AddTextChangedListener((TextWatcherImplementor)this.implementor_TextWatcher.Target);
					return;
				}
				TextWatcherImplementor textWatcherImplementor = (TextWatcherImplementor)this.implementor_TextWatcher.Target;
				textWatcherImplementor.TextChanged = (EventHandler<TextChangedEventArgs>)Delegate.Combine(textWatcherImplementor.TextChanged, value);
			}
			remove
			{
				TextWatcherImplementor textWatcherImplementor = (this.implementor_TextWatcher != null) ? ((TextWatcherImplementor)this.implementor_TextWatcher.Target) : null;
				if (textWatcherImplementor != null)
				{
					textWatcherImplementor.TextChanged = (EventHandler<TextChangedEventArgs>)Delegate.Remove(textWatcherImplementor.TextChanged, value);
				}
			}
		}

		// Token: 0x04000153 RID: 339
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/TextView", typeof(TextView));

		// Token: 0x04000154 RID: 340
		private static Delegate cb_setError_Ljava_lang_CharSequence_;

		// Token: 0x04000155 RID: 341
		private static Delegate cb_getLineCount;

		// Token: 0x04000156 RID: 342
		private static Delegate cb_getMaxLines;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_getTypeface;

		// Token: 0x04000158 RID: 344
		private static Delegate cb_length;

		// Token: 0x04000159 RID: 345
		private static Delegate cb_onPreDraw;

		// Token: 0x0400015A RID: 346
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x0400015B RID: 347
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x0400015C RID: 348
		private static Delegate cb_setFilters_arrayLandroid_text_InputFilter_;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_setMaxLines_I;

		// Token: 0x0400015E RID: 350
		private static Delegate cb_setOnEditorActionListener_Landroid_widget_TextView_OnEditorActionListener_;

		// Token: 0x0400015F RID: 351
		private static Delegate cb_setText_Ljava_lang_CharSequence_Landroid_widget_TextView_BufferType_;

		// Token: 0x04000160 RID: 352
		private static Delegate cb_setTextColor_I;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_setTypeface_Landroid_graphics_Typeface_I;

		// Token: 0x04000162 RID: 354
		private WeakReference weak_implementor_SetOnEditorActionListener;

		// Token: 0x04000163 RID: 355
		private static IntPtr id_addTextChangedListener;

		// Token: 0x04000164 RID: 356
		private WeakReference implementor_TextWatcher;

		// Token: 0x020000F5 RID: 245
		[Register("android/widget/TextView$BufferType", DoNotGenerateAcw = true)]
		public sealed class BufferType : Java.Lang.Enum
		{
			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060005DA RID: 1498 RVA: 0x0000D090 File Offset: 0x0000B290
			[Register("SPANNABLE")]
			public static TextView.BufferType Spannable
			{
				get
				{
					return Java.Lang.Object.GetObject<TextView.BufferType>(TextView.BufferType._members.StaticFields.GetObjectValue("SPANNABLE.Landroid/widget/TextView$BufferType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060005DB RID: 1499 RVA: 0x0000D0BF File Offset: 0x0000B2BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextView.BufferType._members;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060005DC RID: 1500 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TextView.BufferType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x0000D0EC File Offset: 0x0000B2EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextView.BufferType._members.ManagedPeerType;
				}
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal BufferType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000165 RID: 357
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/TextView$BufferType", typeof(TextView.BufferType));
		}

		// Token: 0x020000F6 RID: 246
		[Register("android/widget/TextView$OnEditorActionListener", "", "Android.Widget.TextView/IOnEditorActionListenerInvoker")]
		public interface IOnEditorActionListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060005E0 RID: 1504
			[Register("onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", "GetOnEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_Handler:Android.Widget.TextView/IOnEditorActionListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnEditorAction(TextView v, [GeneratedEnum] ImeAction actionId, KeyEvent e);
		}

		// Token: 0x020000F7 RID: 247
		[Register("android/widget/TextView$OnEditorActionListener", DoNotGenerateAcw = true)]
		internal class IOnEditorActionListenerInvoker : Java.Lang.Object, TextView.IOnEditorActionListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0000D114 File Offset: 0x0000B314
			private static IntPtr java_class_ref
			{
				get
				{
					return TextView.IOnEditorActionListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0000D138 File Offset: 0x0000B338
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextView.IOnEditorActionListenerInvoker._members;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0000D13F File Offset: 0x0000B33F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0000D147 File Offset: 0x0000B347
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextView.IOnEditorActionListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x0000D153 File Offset: 0x0000B353
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TextView.IOnEditorActionListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.TextView.OnEditorActionListener'.");
				}
				return handle;
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x0000D17E File Offset: 0x0000B37E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
			public IOnEditorActionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TextView.IOnEditorActionListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
			private static Delegate GetOnEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_Handler()
			{
				if (TextView.IOnEditorActionListenerInvoker.cb_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_ == null)
				{
					TextView.IOnEditorActionListenerInvoker.cb_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_Z(TextView.IOnEditorActionListenerInvoker.n_OnEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_));
				}
				return TextView.IOnEditorActionListenerInvoker.cb_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_;
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x0000D20C File Offset: 0x0000B40C
			private static bool n_OnEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_v, int native_actionId, IntPtr native_e)
			{
				TextView.IOnEditorActionListener @object = Java.Lang.Object.GetObject<TextView.IOnEditorActionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TextView object2 = Java.Lang.Object.GetObject<TextView>(native_v, JniHandleOwnership.DoNotTransfer);
				KeyEvent object3 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnEditorAction(object2, (ImeAction)native_actionId, object3);
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x0000D23C File Offset: 0x0000B43C
			public unsafe bool OnEditorAction(TextView v, [GeneratedEnum] ImeAction actionId, KeyEvent e)
			{
				if (this.id_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JValue((int)actionId);
				ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_, ptr);
			}

			// Token: 0x04000166 RID: 358
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/TextView$OnEditorActionListener", typeof(TextView.IOnEditorActionListenerInvoker));

			// Token: 0x04000167 RID: 359
			private IntPtr class_ref;

			// Token: 0x04000168 RID: 360
			private static Delegate cb_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_;

			// Token: 0x04000169 RID: 361
			private IntPtr id_onEditorAction_Landroid_widget_TextView_ILandroid_view_KeyEvent_;
		}

		// Token: 0x020000F8 RID: 248
		public class EditorActionEventArgs : EventArgs
		{
			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000D302 File Offset: 0x0000B502
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x0000D30A File Offset: 0x0000B50A
			public EditorActionEventArgs(bool handled, ImeAction actionId, KeyEvent e)
			{
				this.handled = handled;
				this.actionId = actionId;
				this.e = e;
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000D327 File Offset: 0x0000B527
			public ImeAction ActionId
			{
				get
				{
					return this.actionId;
				}
			}

			// Token: 0x0400016A RID: 362
			private bool handled;

			// Token: 0x0400016B RID: 363
			private ImeAction actionId;

			// Token: 0x0400016C RID: 364
			private KeyEvent e;
		}

		// Token: 0x020000F9 RID: 249
		[Register("mono/android/widget/TextView_OnEditorActionListenerImplementor")]
		internal sealed class IOnEditorActionListenerImplementor : Java.Lang.Object, TextView.IOnEditorActionListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060005EF RID: 1519 RVA: 0x0000D32F File Offset: 0x0000B52F
			public IOnEditorActionListenerImplementor() : base(JNIEnv.StartCreateInstance("mono/android/widget/TextView_OnEditorActionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x0000D364 File Offset: 0x0000B564
			public bool OnEditorAction(TextView v, [GeneratedEnum] ImeAction actionId, KeyEvent e)
			{
				EventHandler<TextView.EditorActionEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				TextView.EditorActionEventArgs editorActionEventArgs = new TextView.EditorActionEventArgs(true, actionId, e);
				handler(v, editorActionEventArgs);
				return editorActionEventArgs.Handled;
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x0000D394 File Offset: 0x0000B594
			internal static bool __IsEmpty(TextView.IOnEditorActionListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x0400016D RID: 365
			public EventHandler<TextView.EditorActionEventArgs> Handler;
		}

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400016E RID: 366
			public static Func<TextView.IOnEditorActionListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
