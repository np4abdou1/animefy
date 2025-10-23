using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000013 RID: 19
	[Register("com/warkiz/widget/OnSeekChangeListener", DoNotGenerateAcw = true)]
	internal class IOnSeekChangeListenerInvoker : Java.Lang.Object, IOnSeekChangeListener, IJavaObject, IDisposable
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00005DFC File Offset: 0x00003FFC
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnSeekChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00005E20 File Offset: 0x00004020
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnSeekChangeListenerInvoker._members;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005E27 File Offset: 0x00004027
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005E2F File Offset: 0x0000402F
		protected override Type ThresholdType
		{
			get
			{
				return IOnSeekChangeListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005E3B File Offset: 0x0000403B
		public static IOnSeekChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnSeekChangeListener>(handle, transfer);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005E44 File Offset: 0x00004044
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnSeekChangeListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance(handle), "com.warkiz.widget.OnSeekChangeListener"));
			}
			return handle;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005E6F File Offset: 0x0000406F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005EA0 File Offset: 0x000040A0
		public IOnSeekChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnSeekChangeListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005ED8 File Offset: 0x000040D8
		private static Delegate GetOnSeeking_Lcom_warkiz_widget_SeekParams_Handler()
		{
			if (IOnSeekChangeListenerInvoker.cb_onSeeking_Lcom_warkiz_widget_SeekParams_ == null)
			{
				IOnSeekChangeListenerInvoker.cb_onSeeking_Lcom_warkiz_widget_SeekParams_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IOnSeekChangeListenerInvoker.n_OnSeeking_Lcom_warkiz_widget_SeekParams_));
			}
			return IOnSeekChangeListenerInvoker.cb_onSeeking_Lcom_warkiz_widget_SeekParams_;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005EFC File Offset: 0x000040FC
		private static void n_OnSeeking_Lcom_warkiz_widget_SeekParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_seekParams)
		{
			IOnSeekChangeListener @object = Java.Lang.Object.GetObject<IOnSeekChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SeekParams object2 = Java.Lang.Object.GetObject<SeekParams>(native_seekParams, JniHandleOwnership.DoNotTransfer);
			@object.OnSeeking(object2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005F20 File Offset: 0x00004120
		public unsafe void OnSeeking(SeekParams seekParams)
		{
			if (this.id_onSeeking_Lcom_warkiz_widget_SeekParams_ == IntPtr.Zero)
			{
				this.id_onSeeking_Lcom_warkiz_widget_SeekParams_ = JNIEnv.GetMethodID(this.class_ref, "onSeeking", "(Lcom/warkiz/widget/SeekParams;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((seekParams == null) ? IntPtr.Zero : seekParams.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSeeking_Lcom_warkiz_widget_SeekParams_, ptr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005F93 File Offset: 0x00004193
		private static Delegate GetOnStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_Handler()
		{
			if (IOnSeekChangeListenerInvoker.cb_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ == null)
			{
				IOnSeekChangeListenerInvoker.cb_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IOnSeekChangeListenerInvoker.n_OnStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_));
			}
			return IOnSeekChangeListenerInvoker.cb_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005FB8 File Offset: 0x000041B8
		private static void n_OnStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_(IntPtr jnienv, IntPtr native__this, IntPtr native_seekBar)
		{
			IOnSeekChangeListener @object = Java.Lang.Object.GetObject<IOnSeekChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IndicatorSeekBar object2 = Java.Lang.Object.GetObject<IndicatorSeekBar>(native_seekBar, JniHandleOwnership.DoNotTransfer);
			@object.OnStartTrackingTouch(object2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005FDC File Offset: 0x000041DC
		public unsafe void OnStartTrackingTouch(IndicatorSeekBar seekBar)
		{
			if (this.id_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ == IntPtr.Zero)
			{
				this.id_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ = JNIEnv.GetMethodID(this.class_ref, "onStartTrackingTouch", "(Lcom/warkiz/widget/IndicatorSeekBar;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((seekBar == null) ? IntPtr.Zero : seekBar.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_, ptr);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000604F File Offset: 0x0000424F
		private static Delegate GetOnStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_Handler()
		{
			if (IOnSeekChangeListenerInvoker.cb_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ == null)
			{
				IOnSeekChangeListenerInvoker.cb_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IOnSeekChangeListenerInvoker.n_OnStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_));
			}
			return IOnSeekChangeListenerInvoker.cb_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006074 File Offset: 0x00004274
		private static void n_OnStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_(IntPtr jnienv, IntPtr native__this, IntPtr native_seekBar)
		{
			IOnSeekChangeListener @object = Java.Lang.Object.GetObject<IOnSeekChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IndicatorSeekBar object2 = Java.Lang.Object.GetObject<IndicatorSeekBar>(native_seekBar, JniHandleOwnership.DoNotTransfer);
			@object.OnStopTrackingTouch(object2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006098 File Offset: 0x00004298
		public unsafe void OnStopTrackingTouch(IndicatorSeekBar seekBar)
		{
			if (this.id_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ == IntPtr.Zero)
			{
				this.id_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_ = JNIEnv.GetMethodID(this.class_ref, "onStopTrackingTouch", "(Lcom/warkiz/widget/IndicatorSeekBar;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((seekBar == null) ? IntPtr.Zero : seekBar.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_, ptr);
		}

		// Token: 0x04000072 RID: 114
		internal static readonly JniPeerMembers _members = new JniPeerMembers("com/warkiz/widget/OnSeekChangeListener", typeof(IOnSeekChangeListenerInvoker));

		// Token: 0x04000073 RID: 115
		private IntPtr class_ref;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_onSeeking_Lcom_warkiz_widget_SeekParams_;

		// Token: 0x04000075 RID: 117
		private IntPtr id_onSeeking_Lcom_warkiz_widget_SeekParams_;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;

		// Token: 0x04000077 RID: 119
		private IntPtr id_onStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;

		// Token: 0x04000079 RID: 121
		private IntPtr id_onStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_;
	}
}
