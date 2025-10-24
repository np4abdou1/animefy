using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x0200000A RID: 10
	[Register("com/warkiz/widget/IndicatorSeekBar", DoNotGenerateAcw = true)]
	public class IndicatorSeekBar : View
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004530 File Offset: 0x00002730
		internal static IntPtr class_ref
		{
			get
			{
				return IndicatorSeekBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004554 File Offset: 0x00002754
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IndicatorSeekBar._members;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000455C File Offset: 0x0000275C
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IndicatorSeekBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004580 File Offset: 0x00002780
		protected override Type ThresholdType
		{
			get
			{
				return IndicatorSeekBar._members.ManagedPeerType;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020AC File Offset: 0x000002AC
		protected IndicatorSeekBar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000458C File Offset: 0x0000278C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe IndicatorSeekBar(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			base.SetHandle(IndicatorSeekBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorSeekBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			GC.KeepAlive(context);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004628 File Offset: 0x00002828
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe IndicatorSeekBar(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			base.SetHandle(IndicatorSeekBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorSeekBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000046F0 File Offset: 0x000028F0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe IndicatorSeekBar(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			ptr[2] = new JniArgumentValue(defStyleAttr);
			base.SetHandle(IndicatorSeekBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorSeekBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000047CC File Offset: 0x000029CC
		private static Delegate GetGetIndicatorHandler()
		{
			if (IndicatorSeekBar.cb_getIndicator == null)
			{
				IndicatorSeekBar.cb_getIndicator = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_GetIndicator));
			}
			return IndicatorSeekBar.cb_getIndicator;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000047F0 File Offset: 0x000029F0
		private static IntPtr n_GetIndicator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Indicator);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004804 File Offset: 0x00002A04
		public virtual Indicator Indicator
		{
			[Register("getIndicator", "()Lcom/warkiz/widget/Indicator;", "GetGetIndicatorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Indicator>(IndicatorSeekBar._members.InstanceMethods.InvokeVirtualObjectMethod("getIndicator.()Lcom/warkiz/widget/Indicator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004836 File Offset: 0x00002A36
		private static Delegate GetGetMaxHandler()
		{
			if (IndicatorSeekBar.cb_getMax == null)
			{
				IndicatorSeekBar.cb_getMax = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float>(IndicatorSeekBar.n_GetMax));
			}
			return IndicatorSeekBar.cb_getMax;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000485A File Offset: 0x00002A5A
		private static float n_GetMax(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Max;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004869 File Offset: 0x00002A69
		private static Delegate GetSetMax_FHandler()
		{
			if (IndicatorSeekBar.cb_setMax_F == null)
			{
				IndicatorSeekBar.cb_setMax_F = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, float>(IndicatorSeekBar.n_SetMax_F));
			}
			return IndicatorSeekBar.cb_setMax_F;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000488D File Offset: 0x00002A8D
		private static void n_SetMax_F(IntPtr jnienv, IntPtr native__this, float max)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Max = max;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000489D File Offset: 0x00002A9D
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000048B8 File Offset: 0x00002AB8
		public unsafe virtual float Max
		{
			[Register("getMax", "()F", "GetGetMaxHandler")]
			get
			{
				return IndicatorSeekBar._members.InstanceMethods.InvokeVirtualSingleMethod("getMax.()F", this, null);
			}
			[Register("setMax", "(F)V", "GetSetMax_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setMax.(F)V", this, ptr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000048F3 File Offset: 0x00002AF3
		private static Delegate GetGetMinHandler()
		{
			if (IndicatorSeekBar.cb_getMin == null)
			{
				IndicatorSeekBar.cb_getMin = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float>(IndicatorSeekBar.n_GetMin));
			}
			return IndicatorSeekBar.cb_getMin;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004917 File Offset: 0x00002B17
		private static float n_GetMin(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Min;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004926 File Offset: 0x00002B26
		private static Delegate GetSetMin_FHandler()
		{
			if (IndicatorSeekBar.cb_setMin_F == null)
			{
				IndicatorSeekBar.cb_setMin_F = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, float>(IndicatorSeekBar.n_SetMin_F));
			}
			return IndicatorSeekBar.cb_setMin_F;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000494A File Offset: 0x00002B4A
		private static void n_SetMin_F(IntPtr jnienv, IntPtr native__this, float min)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Min = min;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000495A File Offset: 0x00002B5A
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00004974 File Offset: 0x00002B74
		public unsafe virtual float Min
		{
			[Register("getMin", "()F", "GetGetMinHandler")]
			get
			{
				return IndicatorSeekBar._members.InstanceMethods.InvokeVirtualSingleMethod("getMin.()F", this, null);
			}
			[Register("setMin", "(F)V", "GetSetMin_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setMin.(F)V", this, ptr);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000049AF File Offset: 0x00002BAF
		private static Delegate GetGetOnSeekChangeListenerHandler()
		{
			if (IndicatorSeekBar.cb_getOnSeekChangeListener == null)
			{
				IndicatorSeekBar.cb_getOnSeekChangeListener = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_GetOnSeekChangeListener));
			}
			return IndicatorSeekBar.cb_getOnSeekChangeListener;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000049D3 File Offset: 0x00002BD3
		private static IntPtr n_GetOnSeekChangeListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSeekChangeListener);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000049E7 File Offset: 0x00002BE7
		private static Delegate GetSetOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_Handler()
		{
			if (IndicatorSeekBar.cb_setOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_ == null)
			{
				IndicatorSeekBar.cb_setOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_SetOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_));
			}
			return IndicatorSeekBar.cb_setOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004A0C File Offset: 0x00002C0C
		private static void n_SetOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnSeekChangeListener object2 = Java.Lang.Object.GetObject<IOnSeekChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.OnSeekChangeListener = object2;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00004A30 File Offset: 0x00002C30
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00004A64 File Offset: 0x00002C64
		public unsafe virtual IOnSeekChangeListener OnSeekChangeListener
		{
			[Register("getOnSeekChangeListener", "()Lcom/warkiz/widget/OnSeekChangeListener;", "GetGetOnSeekChangeListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IOnSeekChangeListener>(IndicatorSeekBar._members.InstanceMethods.InvokeVirtualObjectMethod("getOnSeekChangeListener.()Lcom/warkiz/widget/OnSeekChangeListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOnSeekChangeListener", "(Lcom/warkiz/widget/OnSeekChangeListener;)V", "GetSetOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_Handler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setOnSeekChangeListener.(Lcom/warkiz/widget/OnSeekChangeListener;)V", this, ptr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004AB9 File Offset: 0x00002CB9
		private static Delegate GetGetProgressHandler()
		{
			if (IndicatorSeekBar.cb_getProgress == null)
			{
				IndicatorSeekBar.cb_getProgress = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(IndicatorSeekBar.n_GetProgress));
			}
			return IndicatorSeekBar.cb_getProgress;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004ADD File Offset: 0x00002CDD
		private static int n_GetProgress(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Progress;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00004AEC File Offset: 0x00002CEC
		public virtual int Progress
		{
			[Register("getProgress", "()I", "GetGetProgressHandler")]
			get
			{
				return IndicatorSeekBar._members.InstanceMethods.InvokeVirtualInt32Method("getProgress.()I", this, null);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004B05 File Offset: 0x00002D05
		private static Delegate GetGetProgressFloatHandler()
		{
			if (IndicatorSeekBar.cb_getProgressFloat == null)
			{
				IndicatorSeekBar.cb_getProgressFloat = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float>(IndicatorSeekBar.n_GetProgressFloat));
			}
			return IndicatorSeekBar.cb_getProgressFloat;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004B29 File Offset: 0x00002D29
		private static float n_GetProgressFloat(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressFloat;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00004B38 File Offset: 0x00002D38
		public virtual float ProgressFloat
		{
			[Register("getProgressFloat", "()F", "GetGetProgressFloatHandler")]
			get
			{
				return IndicatorSeekBar._members.InstanceMethods.InvokeVirtualSingleMethod("getProgressFloat.()F", this, null);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004B51 File Offset: 0x00002D51
		private static Delegate GetGetTickCountHandler()
		{
			if (IndicatorSeekBar.cb_getTickCount == null)
			{
				IndicatorSeekBar.cb_getTickCount = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(IndicatorSeekBar.n_GetTickCount));
			}
			return IndicatorSeekBar.cb_getTickCount;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004B75 File Offset: 0x00002D75
		private static int n_GetTickCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickCount;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004B84 File Offset: 0x00002D84
		private static Delegate GetSetTickCount_IHandler()
		{
			if (IndicatorSeekBar.cb_setTickCount_I == null)
			{
				IndicatorSeekBar.cb_setTickCount_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IndicatorSeekBar.n_SetTickCount_I));
			}
			return IndicatorSeekBar.cb_setTickCount_I;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004BA8 File Offset: 0x00002DA8
		private static void n_SetTickCount_I(IntPtr jnienv, IntPtr native__this, int tickCount)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickCount = tickCount;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00004BB8 File Offset: 0x00002DB8
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public unsafe virtual int TickCount
		{
			[Register("getTickCount", "()I", "GetGetTickCountHandler")]
			get
			{
				return IndicatorSeekBar._members.InstanceMethods.InvokeVirtualInt32Method("getTickCount.()I", this, null);
			}
			[Register("setTickCount", "(I)V", "GetSetTickCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setTickCount.(I)V", this, ptr);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004C0F File Offset: 0x00002E0F
		private static Delegate GetCustomSectionTrackColor_Lcom_warkiz_widget_ColorCollector_Handler()
		{
			if (IndicatorSeekBar.cb_customSectionTrackColor_Lcom_warkiz_widget_ColorCollector_ == null)
			{
				IndicatorSeekBar.cb_customSectionTrackColor_Lcom_warkiz_widget_ColorCollector_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_CustomSectionTrackColor_Lcom_warkiz_widget_ColorCollector_));
			}
			return IndicatorSeekBar.cb_customSectionTrackColor_Lcom_warkiz_widget_ColorCollector_;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004C34 File Offset: 0x00002E34
		private static void n_CustomSectionTrackColor_Lcom_warkiz_widget_ColorCollector_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IColorCollector object2 = Java.Lang.Object.GetObject<IColorCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			@object.CustomSectionTrackColor(object2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004C58 File Offset: 0x00002E58
		[Register("customSectionTrackColor", "(Lcom/warkiz/widget/ColorCollector;)V", "GetCustomSectionTrackColor_Lcom_warkiz_widget_ColorCollector_Handler")]
		public unsafe virtual void CustomSectionTrackColor(IColorCollector collector)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((collector == null) ? IntPtr.Zero : ((Java.Lang.Object)collector).Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("customSectionTrackColor.(Lcom/warkiz/widget/ColorCollector;)V", this, ptr);
			GC.KeepAlive(collector);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004CAD File Offset: 0x00002EAD
		private static Delegate GetCustomTickTexts_arrayLjava_lang_String_Handler()
		{
			if (IndicatorSeekBar.cb_customTickTexts_arrayLjava_lang_String_ == null)
			{
				IndicatorSeekBar.cb_customTickTexts_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_CustomTickTexts_arrayLjava_lang_String_));
			}
			return IndicatorSeekBar.cb_customTickTexts_arrayLjava_lang_String_;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004CD4 File Offset: 0x00002ED4
		private static void n_CustomTickTexts_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickTextsArr)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_tickTextsArr, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.CustomTickTexts(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_tickTextsArr);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004D10 File Offset: 0x00002F10
		[Register("customTickTexts", "([Ljava/lang/String;)V", "GetCustomTickTexts_arrayLjava_lang_String_Handler")]
		public unsafe virtual void CustomTickTexts(string[] tickTextsArr)
		{
			IntPtr intPtr = JNIEnv.NewArray(tickTextsArr);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("customTickTexts.([Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				if (tickTextsArr != null)
				{
					JNIEnv.CopyArray(intPtr, tickTextsArr);
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(tickTextsArr);
				}
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004D7C File Offset: 0x00002F7C
		private static Delegate GetCustomTickTextsTypeface_Landroid_graphics_Typeface_Handler()
		{
			if (IndicatorSeekBar.cb_customTickTextsTypeface_Landroid_graphics_Typeface_ == null)
			{
				IndicatorSeekBar.cb_customTickTextsTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_CustomTickTextsTypeface_Landroid_graphics_Typeface_));
			}
			return IndicatorSeekBar.cb_customTickTextsTypeface_Landroid_graphics_Typeface_;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004DA0 File Offset: 0x00002FA0
		private static void n_CustomTickTextsTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.CustomTickTextsTypeface(object2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004DC4 File Offset: 0x00002FC4
		[Register("customTickTextsTypeface", "(Landroid/graphics/Typeface;)V", "GetCustomTickTextsTypeface_Landroid_graphics_Typeface_Handler")]
		public unsafe virtual void CustomTickTextsTypeface(Typeface typeface)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((typeface == null) ? IntPtr.Zero : typeface.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("customTickTextsTypeface.(Landroid/graphics/Typeface;)V", this, ptr);
			GC.KeepAlive(typeface);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004E14 File Offset: 0x00003014
		private static Delegate GetHideThumb_ZHandler()
		{
			if (IndicatorSeekBar.cb_hideThumb_Z == null)
			{
				IndicatorSeekBar.cb_hideThumb_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_HideThumb_Z));
			}
			return IndicatorSeekBar.cb_hideThumb_Z;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004E38 File Offset: 0x00003038
		private static void n_HideThumb_Z(IntPtr jnienv, IntPtr native__this, bool hide)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideThumb(hide);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004E48 File Offset: 0x00003048
		[Register("hideThumb", "(Z)V", "GetHideThumb_ZHandler")]
		public unsafe virtual void HideThumb(bool hide)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hide);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("hideThumb.(Z)V", this, ptr);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004E83 File Offset: 0x00003083
		private static Delegate GetHideThumbText_ZHandler()
		{
			if (IndicatorSeekBar.cb_hideThumbText_Z == null)
			{
				IndicatorSeekBar.cb_hideThumbText_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_HideThumbText_Z));
			}
			return IndicatorSeekBar.cb_hideThumbText_Z;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004EA7 File Offset: 0x000030A7
		private static void n_HideThumbText_Z(IntPtr jnienv, IntPtr native__this, bool hide)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideThumbText(hide);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004EB8 File Offset: 0x000030B8
		[Register("hideThumbText", "(Z)V", "GetHideThumbText_ZHandler")]
		public unsafe virtual void HideThumbText(bool hide)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(hide);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("hideThumbText.(Z)V", this, ptr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004EF3 File Offset: 0x000030F3
		private static Delegate GetSetDecimalScale_IHandler()
		{
			if (IndicatorSeekBar.cb_setDecimalScale_I == null)
			{
				IndicatorSeekBar.cb_setDecimalScale_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IndicatorSeekBar.n_SetDecimalScale_I));
			}
			return IndicatorSeekBar.cb_setDecimalScale_I;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004F17 File Offset: 0x00003117
		private static void n_SetDecimalScale_I(IntPtr jnienv, IntPtr native__this, int scale)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDecimalScale(scale);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004F28 File Offset: 0x00003128
		[Register("setDecimalScale", "(I)V", "GetSetDecimalScale_IHandler")]
		public unsafe virtual void SetDecimalScale(int scale)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(scale);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setDecimalScale.(I)V", this, ptr);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004F63 File Offset: 0x00003163
		private static Delegate GetSetIndicatorTextFormat_Ljava_lang_String_Handler()
		{
			if (IndicatorSeekBar.cb_setIndicatorTextFormat_Ljava_lang_String_ == null)
			{
				IndicatorSeekBar.cb_setIndicatorTextFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_SetIndicatorTextFormat_Ljava_lang_String_));
			}
			return IndicatorSeekBar.cb_setIndicatorTextFormat_Ljava_lang_String_;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004F88 File Offset: 0x00003188
		private static void n_SetIndicatorTextFormat_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_format, JniHandleOwnership.DoNotTransfer);
			@object.SetIndicatorTextFormat(@string);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004FAC File Offset: 0x000031AC
		[Register("setIndicatorTextFormat", "(Ljava/lang/String;)V", "GetSetIndicatorTextFormat_Ljava_lang_String_Handler")]
		public unsafe virtual void SetIndicatorTextFormat(string format)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setIndicatorTextFormat.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005008 File Offset: 0x00003208
		private static Delegate GetSetProgress_FHandler()
		{
			if (IndicatorSeekBar.cb_setProgress_F == null)
			{
				IndicatorSeekBar.cb_setProgress_F = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, float>(IndicatorSeekBar.n_SetProgress_F));
			}
			return IndicatorSeekBar.cb_setProgress_F;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000502C File Offset: 0x0000322C
		private static void n_SetProgress_F(IntPtr jnienv, IntPtr native__this, float progress)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgress(progress);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000503C File Offset: 0x0000323C
		[Register("setProgress", "(F)V", "GetSetProgress_FHandler")]
		public unsafe virtual void SetProgress(float progress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(progress);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setProgress.(F)V", this, ptr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005077 File Offset: 0x00003277
		private static Delegate GetSetR2L_ZHandler()
		{
			if (IndicatorSeekBar.cb_setR2L_Z == null)
			{
				IndicatorSeekBar.cb_setR2L_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_SetR2L_Z));
			}
			return IndicatorSeekBar.cb_setR2L_Z;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000509B File Offset: 0x0000329B
		private static void n_SetR2L_Z(IntPtr jnienv, IntPtr native__this, bool isR2L)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetR2L(isR2L);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000050AC File Offset: 0x000032AC
		[Register("setR2L", "(Z)V", "GetSetR2L_ZHandler")]
		public unsafe virtual void SetR2L(bool isR2L)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isR2L);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setR2L.(Z)V", this, ptr);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000050E7 File Offset: 0x000032E7
		private static Delegate GetSetThumbAdjustAuto_ZHandler()
		{
			if (IndicatorSeekBar.cb_setThumbAdjustAuto_Z == null)
			{
				IndicatorSeekBar.cb_setThumbAdjustAuto_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_SetThumbAdjustAuto_Z));
			}
			return IndicatorSeekBar.cb_setThumbAdjustAuto_Z;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000510B File Offset: 0x0000330B
		private static void n_SetThumbAdjustAuto_Z(IntPtr jnienv, IntPtr native__this, bool adjustAuto)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetThumbAdjustAuto(adjustAuto);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000511C File Offset: 0x0000331C
		[Register("setThumbAdjustAuto", "(Z)V", "GetSetThumbAdjustAuto_ZHandler")]
		public unsafe virtual void SetThumbAdjustAuto(bool adjustAuto)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(adjustAuto);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbAdjustAuto.(Z)V", this, ptr);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005157 File Offset: 0x00003357
		private static Delegate GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IndicatorSeekBar.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				IndicatorSeekBar.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return IndicatorSeekBar.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000517C File Offset: 0x0000337C
		private static void n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.SetThumbDrawable(object2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000051A0 File Offset: 0x000033A0
		[Register("setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetThumbDrawable(Drawable drawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			GC.KeepAlive(drawable);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000051F0 File Offset: 0x000033F0
		private static Delegate GetSetTickMarksDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IndicatorSeekBar.cb_setTickMarksDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				IndicatorSeekBar.cb_setTickMarksDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_SetTickMarksDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return IndicatorSeekBar.cb_setTickMarksDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005214 File Offset: 0x00003414
		private static void n_SetTickMarksDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.SetTickMarksDrawable(object2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005238 File Offset: 0x00003438
		[Register("setTickMarksDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetTickMarksDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetTickMarksDrawable(Drawable drawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setTickMarksDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			GC.KeepAlive(drawable);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005288 File Offset: 0x00003488
		private static Delegate GetSetUserSeekAble_ZHandler()
		{
			if (IndicatorSeekBar.cb_setUserSeekAble_Z == null)
			{
				IndicatorSeekBar.cb_setUserSeekAble_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_SetUserSeekAble_Z));
			}
			return IndicatorSeekBar.cb_setUserSeekAble_Z;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000052AC File Offset: 0x000034AC
		private static void n_SetUserSeekAble_Z(IntPtr jnienv, IntPtr native__this, bool seekAble)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUserSeekAble(seekAble);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000052BC File Offset: 0x000034BC
		[Register("setUserSeekAble", "(Z)V", "GetSetUserSeekAble_ZHandler")]
		public unsafe virtual void SetUserSeekAble(bool seekAble)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(seekAble);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("setUserSeekAble.(Z)V", this, ptr);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000052F7 File Offset: 0x000034F7
		private static Delegate GetShowBothEndsTickTextsOnly_ZHandler()
		{
			if (IndicatorSeekBar.cb_showBothEndsTickTextsOnly_Z == null)
			{
				IndicatorSeekBar.cb_showBothEndsTickTextsOnly_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IndicatorSeekBar.n_ShowBothEndsTickTextsOnly_Z));
			}
			return IndicatorSeekBar.cb_showBothEndsTickTextsOnly_Z;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000531B File Offset: 0x0000351B
		private static void n_ShowBothEndsTickTextsOnly_Z(IntPtr jnienv, IntPtr native__this, bool onlyShow)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowBothEndsTickTextsOnly(onlyShow);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000532C File Offset: 0x0000352C
		[Register("showBothEndsTickTextsOnly", "(Z)V", "GetShowBothEndsTickTextsOnly_ZHandler")]
		public unsafe virtual void ShowBothEndsTickTextsOnly(bool onlyShow)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(onlyShow);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("showBothEndsTickTextsOnly.(Z)V", this, ptr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005367 File Offset: 0x00003567
		private static Delegate GetThumbColor_IHandler()
		{
			if (IndicatorSeekBar.cb_thumbColor_I == null)
			{
				IndicatorSeekBar.cb_thumbColor_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IndicatorSeekBar.n_ThumbColor_I));
			}
			return IndicatorSeekBar.cb_thumbColor_I;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000538B File Offset: 0x0000358B
		private static void n_ThumbColor_I(IntPtr jnienv, IntPtr native__this, int thumbColor)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbColor(thumbColor);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000539C File Offset: 0x0000359C
		[Register("thumbColor", "(I)V", "GetThumbColor_IHandler")]
		public unsafe virtual void ThumbColor(int thumbColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thumbColor);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("thumbColor.(I)V", this, ptr);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000053D7 File Offset: 0x000035D7
		private static Delegate GetThumbColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (IndicatorSeekBar.cb_thumbColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				IndicatorSeekBar.cb_thumbColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_ThumbColorStateList_Landroid_content_res_ColorStateList_));
			}
			return IndicatorSeekBar.cb_thumbColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000053FC File Offset: 0x000035FC
		private static void n_ThumbColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbColorStateList)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_thumbColorStateList, JniHandleOwnership.DoNotTransfer);
			@object.ThumbColorStateList(object2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005420 File Offset: 0x00003620
		[Register("thumbColorStateList", "(Landroid/content/res/ColorStateList;)V", "GetThumbColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void ThumbColorStateList(ColorStateList thumbColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((thumbColorStateList == null) ? IntPtr.Zero : thumbColorStateList.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("thumbColorStateList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			GC.KeepAlive(thumbColorStateList);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005470 File Offset: 0x00003670
		private static Delegate GetTickMarksColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (IndicatorSeekBar.cb_tickMarksColor_Landroid_content_res_ColorStateList_ == null)
			{
				IndicatorSeekBar.cb_tickMarksColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_TickMarksColor_Landroid_content_res_ColorStateList_));
			}
			return IndicatorSeekBar.cb_tickMarksColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005494 File Offset: 0x00003694
		private static void n_TickMarksColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickMarksColorStateList)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tickMarksColorStateList, JniHandleOwnership.DoNotTransfer);
			@object.TickMarksColor(object2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000054B8 File Offset: 0x000036B8
		[Register("tickMarksColor", "(Landroid/content/res/ColorStateList;)V", "GetTickMarksColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void TickMarksColor(ColorStateList tickMarksColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickMarksColorStateList == null) ? IntPtr.Zero : tickMarksColorStateList.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("tickMarksColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			GC.KeepAlive(tickMarksColorStateList);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005508 File Offset: 0x00003708
		private static Delegate GetTickMarksColor_IHandler()
		{
			if (IndicatorSeekBar.cb_tickMarksColor_I == null)
			{
				IndicatorSeekBar.cb_tickMarksColor_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IndicatorSeekBar.n_TickMarksColor_I));
			}
			return IndicatorSeekBar.cb_tickMarksColor_I;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000552C File Offset: 0x0000372C
		private static void n_TickMarksColor_I(IntPtr jnienv, IntPtr native__this, int tickMarksColor)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickMarksColor(tickMarksColor);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000553C File Offset: 0x0000373C
		[Register("tickMarksColor", "(I)V", "GetTickMarksColor_IHandler")]
		public unsafe virtual void TickMarksColor(int tickMarksColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickMarksColor);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("tickMarksColor.(I)V", this, ptr);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005577 File Offset: 0x00003777
		private static Delegate GetTickTextsColor_IHandler()
		{
			if (IndicatorSeekBar.cb_tickTextsColor_I == null)
			{
				IndicatorSeekBar.cb_tickTextsColor_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IndicatorSeekBar.n_TickTextsColor_I));
			}
			return IndicatorSeekBar.cb_tickTextsColor_I;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000559B File Offset: 0x0000379B
		private static void n_TickTextsColor_I(IntPtr jnienv, IntPtr native__this, int tickTextsColor)
		{
			Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickTextsColor(tickTextsColor);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000055AC File Offset: 0x000037AC
		[Register("tickTextsColor", "(I)V", "GetTickTextsColor_IHandler")]
		public unsafe virtual void TickTextsColor(int tickTextsColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickTextsColor);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("tickTextsColor.(I)V", this, ptr);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000055E7 File Offset: 0x000037E7
		private static Delegate GetTickTextsColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (IndicatorSeekBar.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				IndicatorSeekBar.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorSeekBar.n_TickTextsColorStateList_Landroid_content_res_ColorStateList_));
			}
			return IndicatorSeekBar.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000560C File Offset: 0x0000380C
		private static void n_TickTextsColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickTextsColorStateList)
		{
			IndicatorSeekBar @object = Java.Lang.Object.GetObject<IndicatorSeekBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tickTextsColorStateList, JniHandleOwnership.DoNotTransfer);
			@object.TickTextsColorStateList(object2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005630 File Offset: 0x00003830
		[Register("tickTextsColorStateList", "(Landroid/content/res/ColorStateList;)V", "GetTickTextsColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void TickTextsColorStateList(ColorStateList tickTextsColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickTextsColorStateList == null) ? IntPtr.Zero : tickTextsColorStateList.Handle);
			IndicatorSeekBar._members.InstanceMethods.InvokeVirtualVoidMethod("tickTextsColorStateList.(Landroid/content/res/ColorStateList;)V", this, ptr);
			GC.KeepAlive(tickTextsColorStateList);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005680 File Offset: 0x00003880
		[Register("with", "(Landroid/content/Context;)Lcom/warkiz/widget/Builder;", "")]
		public unsafe static Builder With(Context context)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(IndicatorSeekBar._members.StaticMethods.InvokeObjectMethod("with.(Landroid/content/Context;)Lcom/warkiz/widget/Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(context);
			return @object;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600012E RID: 302 RVA: 0x000056E0 File Offset: 0x000038E0
		// (remove) Token: 0x0600012F RID: 303 RVA: 0x00005730 File Offset: 0x00003930
		public event EventHandler<SeekingEventArgs> Seeking
		{
			add
			{
				EventHelper.AddEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor>(this.__CreateIOnSeekChangeListenerImplementor), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = __v;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnSeekingHandler = (EventHandler<SeekingEventArgs>)Delegate.Combine(__h.OnSeekingHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor, bool>(IOnSeekChangeListenerImplementor.__IsEmpty), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = null;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnSeekingHandler = (EventHandler<SeekingEventArgs>)Delegate.Remove(__h.OnSeekingHandler, value);
				});
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000130 RID: 304 RVA: 0x00005780 File Offset: 0x00003980
		// (remove) Token: 0x06000131 RID: 305 RVA: 0x000057D0 File Offset: 0x000039D0
		public event EventHandler<StartTrackingTouchEventArgs> StartTrackingTouch
		{
			add
			{
				EventHelper.AddEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor>(this.__CreateIOnSeekChangeListenerImplementor), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = __v;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnStartTrackingTouchHandler = (EventHandler<StartTrackingTouchEventArgs>)Delegate.Combine(__h.OnStartTrackingTouchHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor, bool>(IOnSeekChangeListenerImplementor.__IsEmpty), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = null;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnStartTrackingTouchHandler = (EventHandler<StartTrackingTouchEventArgs>)Delegate.Remove(__h.OnStartTrackingTouchHandler, value);
				});
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000132 RID: 306 RVA: 0x00005820 File Offset: 0x00003A20
		// (remove) Token: 0x06000133 RID: 307 RVA: 0x00005870 File Offset: 0x00003A70
		public event EventHandler<StopTrackingTouchEventArgs> StopTrackingTouch
		{
			add
			{
				EventHelper.AddEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor>(this.__CreateIOnSeekChangeListenerImplementor), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = __v;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnStopTrackingTouchHandler = (EventHandler<StopTrackingTouchEventArgs>)Delegate.Combine(__h.OnStopTrackingTouchHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IOnSeekChangeListener, IOnSeekChangeListenerImplementor>(ref this.weak_implementor___SetOnSeekChangeListener, new Func<IOnSeekChangeListenerImplementor, bool>(IOnSeekChangeListenerImplementor.__IsEmpty), delegate(IOnSeekChangeListener __v)
				{
					this.OnSeekChangeListener = null;
				}, delegate(IOnSeekChangeListenerImplementor __h)
				{
					__h.OnStopTrackingTouchHandler = (EventHandler<StopTrackingTouchEventArgs>)Delegate.Remove(__h.OnStopTrackingTouchHandler, value);
				});
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000058C0 File Offset: 0x00003AC0
		private IOnSeekChangeListenerImplementor __CreateIOnSeekChangeListenerImplementor()
		{
			return new IOnSeekChangeListenerImplementor(this);
		}

		// Token: 0x04000042 RID: 66
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/IndicatorSeekBar", typeof(IndicatorSeekBar));

		// Token: 0x04000043 RID: 67
		private static Delegate cb_getIndicator;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_getMax;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_setMax_F;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_getMin;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_setMin_F;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_getOnSeekChangeListener;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_setOnSeekChangeListener_Lcom_warkiz_widget_OnSeekChangeListener_;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_getProgress;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_getProgressFloat;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_getTickCount;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_setTickCount_I;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_customSectionTrackColor_Lcom_warkiz_widget_ColorCollector_;

		// Token: 0x0400004F RID: 79
		private static Delegate cb_customTickTexts_arrayLjava_lang_String_;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_customTickTextsTypeface_Landroid_graphics_Typeface_;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_hideThumb_Z;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_hideThumbText_Z;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_setDecimalScale_I;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_setIndicatorTextFormat_Ljava_lang_String_;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_setProgress_F;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_setR2L_Z;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_setThumbAdjustAuto_Z;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_setTickMarksDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_setUserSeekAble_Z;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_showBothEndsTickTextsOnly_Z;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_thumbColor_I;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_thumbColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_tickMarksColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_tickMarksColor_I;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_tickTextsColor_I;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000062 RID: 98
		private WeakReference weak_implementor___SetOnSeekChangeListener;
	}
}
