using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Adview
{
	// Token: 0x0200016A RID: 362
	[Register("com/applovin/impl/adview/AppLovinTouchToClickListener", DoNotGenerateAcw = true)]
	public class AppLovinTouchToClickListener : Java.Lang.Object, View.IOnTouchListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00032A84 File Offset: 0x00030C84
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinTouchToClickListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00032AA8 File Offset: 0x00030CA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinTouchToClickListener._members;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00032AB0 File Offset: 0x00030CB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinTouchToClickListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00032AD4 File Offset: 0x00030CD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinTouchToClickListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinTouchToClickListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00032AE0 File Offset: 0x00030CE0
		private static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler()
		{
			if (AppLovinTouchToClickListener.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
			{
				AppLovinTouchToClickListener.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AppLovinTouchToClickListener.n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_));
			}
			return AppLovinTouchToClickListener.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00032B04 File Offset: 0x00030D04
		private static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinTouchToClickListener @object = Java.Lang.Object.GetObject<AppLovinTouchToClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			MotionEvent object3 = Java.Lang.Object.GetObject<MotionEvent>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouch(object2, object3);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00032B30 File Offset: 0x00030D30
		[Register("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public unsafe virtual bool OnTouch(View p0, MotionEvent p1)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = AppLovinTouchToClickListener._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouch.(Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x040005C4 RID: 1476
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/AppLovinTouchToClickListener", typeof(AppLovinTouchToClickListener));

		// Token: 0x040005C5 RID: 1477
		private static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;

		// Token: 0x0200016B RID: 363
		[Register("com/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState", DoNotGenerateAcw = true)]
		public sealed class ClickRecognitionState : Java.Lang.Enum
		{
			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x0600119B RID: 4507 RVA: 0x00032BDC File Offset: 0x00030DDC
			[Register("ACTION_DOWN")]
			public static AppLovinTouchToClickListener.ClickRecognitionState ActionDown
			{
				get
				{
					return Java.Lang.Object.GetObject<AppLovinTouchToClickListener.ClickRecognitionState>(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticFields.GetObjectValue("ACTION_DOWN.Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x0600119C RID: 4508 RVA: 0x00032C0C File Offset: 0x00030E0C
			[Register("ACTION_POINTER_UP")]
			public static AppLovinTouchToClickListener.ClickRecognitionState ActionPointerUp
			{
				get
				{
					return Java.Lang.Object.GetObject<AppLovinTouchToClickListener.ClickRecognitionState>(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticFields.GetObjectValue("ACTION_POINTER_UP.Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x0600119D RID: 4509 RVA: 0x00032C3C File Offset: 0x00030E3C
			[Register("ACTION_UP")]
			public static AppLovinTouchToClickListener.ClickRecognitionState ActionUp
			{
				get
				{
					return Java.Lang.Object.GetObject<AppLovinTouchToClickListener.ClickRecognitionState>(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticFields.GetObjectValue("ACTION_UP.Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x0600119E RID: 4510 RVA: 0x00032C6C File Offset: 0x00030E6C
			[Register("DISABLED")]
			public static AppLovinTouchToClickListener.ClickRecognitionState Disabled
			{
				get
				{
					return Java.Lang.Object.GetObject<AppLovinTouchToClickListener.ClickRecognitionState>(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticFields.GetObjectValue("DISABLED.Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000492 RID: 1170
			// (get) Token: 0x0600119F RID: 4511 RVA: 0x00032C9C File Offset: 0x00030E9C
			internal static IntPtr class_ref
			{
				get
				{
					return AppLovinTouchToClickListener.ClickRecognitionState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000493 RID: 1171
			// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00032CC0 File Offset: 0x00030EC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinTouchToClickListener.ClickRecognitionState._members;
				}
			}

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00032CC8 File Offset: 0x00030EC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AppLovinTouchToClickListener.ClickRecognitionState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00032CEC File Offset: 0x00030EEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinTouchToClickListener.ClickRecognitionState._members.ManagedPeerType;
				}
			}

			// Token: 0x060011A3 RID: 4515 RVA: 0x000048B4 File Offset: 0x00002AB4
			internal ClickRecognitionState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060011A4 RID: 4516 RVA: 0x00032CF8 File Offset: 0x00030EF8
			[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;", "")]
			public unsafe static AppLovinTouchToClickListener.ClickRecognitionState ValueOf(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AppLovinTouchToClickListener.ClickRecognitionState @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AppLovinTouchToClickListener.ClickRecognitionState>(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060011A5 RID: 4517 RVA: 0x00032D64 File Offset: 0x00030F64
			[Register("values", "()[Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;", "")]
			public static AppLovinTouchToClickListener.ClickRecognitionState[] Values()
			{
				return (AppLovinTouchToClickListener.ClickRecognitionState[])JNIEnv.GetArray(AppLovinTouchToClickListener.ClickRecognitionState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AppLovinTouchToClickListener.ClickRecognitionState));
			}

			// Token: 0x040005C6 RID: 1478
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/AppLovinTouchToClickListener$ClickRecognitionState", typeof(AppLovinTouchToClickListener.ClickRecognitionState));
		}

		// Token: 0x0200016C RID: 364
		[Register("com/applovin/impl/adview/AppLovinTouchToClickListener$OnClickListener", "", "Com.Applovin.Impl.Adview.AppLovinTouchToClickListener/IOnClickListenerInvoker")]
		public interface IOnClickListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060011A7 RID: 4519
			[Register("onClick", "(Landroid/view/View;Landroid/graphics/PointF;)V", "GetOnClick_Landroid_view_View_Landroid_graphics_PointF_Handler:Com.Applovin.Impl.Adview.AppLovinTouchToClickListener/IOnClickListenerInvoker, AppLovin")]
			void OnClick(View p0, PointF p1);
		}

		// Token: 0x0200016D RID: 365
		[Register("com/applovin/impl/adview/AppLovinTouchToClickListener$OnClickListener", DoNotGenerateAcw = true)]
		internal class IOnClickListenerInvoker : Java.Lang.Object, AppLovinTouchToClickListener.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00032DC0 File Offset: 0x00030FC0
			private static IntPtr java_class_ref
			{
				get
				{
					return AppLovinTouchToClickListener.IOnClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00032DE4 File Offset: 0x00030FE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinTouchToClickListener.IOnClickListenerInvoker._members;
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x060011AA RID: 4522 RVA: 0x00032DEB File Offset: 0x00030FEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x00032DF3 File Offset: 0x00030FF3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinTouchToClickListener.IOnClickListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060011AC RID: 4524 RVA: 0x00032DFF File Offset: 0x00030FFF
			public static AppLovinTouchToClickListener.IOnClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<AppLovinTouchToClickListener.IOnClickListener>(handle, transfer);
			}

			// Token: 0x060011AD RID: 4525 RVA: 0x00032E08 File Offset: 0x00031008
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AppLovinTouchToClickListener.IOnClickListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.impl.adview.AppLovinTouchToClickListener.OnClickListener'.");
				}
				return handle;
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x00032E33 File Offset: 0x00031033
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x00032E64 File Offset: 0x00031064
			public IOnClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AppLovinTouchToClickListener.IOnClickListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060011B0 RID: 4528 RVA: 0x00032E9C File Offset: 0x0003109C
			private static Delegate GetOnClick_Landroid_view_View_Landroid_graphics_PointF_Handler()
			{
				if (AppLovinTouchToClickListener.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_Landroid_graphics_PointF_ == null)
				{
					AppLovinTouchToClickListener.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinTouchToClickListener.IOnClickListenerInvoker.n_OnClick_Landroid_view_View_Landroid_graphics_PointF_));
				}
				return AppLovinTouchToClickListener.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_Landroid_graphics_PointF_;
			}

			// Token: 0x060011B1 RID: 4529 RVA: 0x00032EC0 File Offset: 0x000310C0
			private static void n_OnClick_Landroid_view_View_Landroid_graphics_PointF_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				AppLovinTouchToClickListener.IOnClickListener @object = Java.Lang.Object.GetObject<AppLovinTouchToClickListener.IOnClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				PointF object3 = Java.Lang.Object.GetObject<PointF>(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.OnClick(object2, object3);
			}

			// Token: 0x060011B2 RID: 4530 RVA: 0x00032EEC File Offset: 0x000310EC
			public unsafe void OnClick(View p0, PointF p1)
			{
				if (this.id_onClick_Landroid_view_View_Landroid_graphics_PointF_ == IntPtr.Zero)
				{
					this.id_onClick_Landroid_view_View_Landroid_graphics_PointF_ = JNIEnv.GetMethodID(this.class_ref, "onClick", "(Landroid/view/View;Landroid/graphics/PointF;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onClick_Landroid_view_View_Landroid_graphics_PointF_, ptr);
			}

			// Token: 0x040005C7 RID: 1479
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/AppLovinTouchToClickListener$OnClickListener", typeof(AppLovinTouchToClickListener.IOnClickListenerInvoker));

			// Token: 0x040005C8 RID: 1480
			private IntPtr class_ref;

			// Token: 0x040005C9 RID: 1481
			private static Delegate cb_onClick_Landroid_view_View_Landroid_graphics_PointF_;

			// Token: 0x040005CA RID: 1482
			private IntPtr id_onClick_Landroid_view_View_Landroid_graphics_PointF_;
		}

		// Token: 0x0200016E RID: 366
		public class ClickEventArgs : EventArgs
		{
			// Token: 0x060011B4 RID: 4532 RVA: 0x00032F9C File Offset: 0x0003119C
			public ClickEventArgs(View p0, PointF p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00032FB2 File Offset: 0x000311B2
			public View P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00032FBA File Offset: 0x000311BA
			public PointF P1
			{
				get
				{
					return this.p1;
				}
			}

			// Token: 0x040005CB RID: 1483
			private View p0;

			// Token: 0x040005CC RID: 1484
			private PointF p1;
		}

		// Token: 0x0200016F RID: 367
		[Register("mono/com/applovin/impl/adview/AppLovinTouchToClickListener_OnClickListenerImplementor")]
		internal sealed class IOnClickListenerImplementor : Java.Lang.Object, AppLovinTouchToClickListener.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060011B7 RID: 4535 RVA: 0x00032FC2 File Offset: 0x000311C2
			public IOnClickListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/impl/adview/AppLovinTouchToClickListener_OnClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x00032FFC File Offset: 0x000311FC
			public void OnClick(View p0, PointF p1)
			{
				EventHandler<AppLovinTouchToClickListener.ClickEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new AppLovinTouchToClickListener.ClickEventArgs(p0, p1));
				}
			}

			// Token: 0x060011B9 RID: 4537 RVA: 0x00033026 File Offset: 0x00031226
			internal static bool __IsEmpty(AppLovinTouchToClickListener.IOnClickListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040005CD RID: 1485
			private object sender;

			// Token: 0x040005CE RID: 1486
			public EventHandler<AppLovinTouchToClickListener.ClickEventArgs> Handler;
		}
	}
}
