using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200012F RID: 303
	[Register("android/view/KeyEvent", DoNotGenerateAcw = true)]
	public class KeyEvent : InputEvent, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000195DF File Offset: 0x000177DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KeyEvent._members;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000195E8 File Offset: 0x000177E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KeyEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0001960C File Offset: 0x0001780C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KeyEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000150C1 File Offset: 0x000132C1
		protected KeyEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00019618 File Offset: 0x00017818
		public KeyEventActions Action
		{
			get
			{
				return (KeyEventActions)KeyEvent._members.InstanceMethods.InvokeNonvirtualInt32Method("getAction.()I", this, null);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00019631 File Offset: 0x00017831
		public Keycode KeyCode
		{
			get
			{
				return (Keycode)KeyEvent._members.InstanceMethods.InvokeNonvirtualInt32Method("getKeyCode.()I", this, null);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001964A File Offset: 0x0001784A
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (KeyEvent.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				KeyEvent.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(KeyEvent.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return KeyEvent.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00019670 File Offset: 0x00017870
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			InputEvent @object = Java.Lang.Object.GetObject<KeyEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00019698 File Offset: 0x00017898
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				KeyEvent._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x0400034D RID: 845
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/KeyEvent", typeof(KeyEvent));

		// Token: 0x0400034E RID: 846
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x02000130 RID: 304
		[Register("android/view/KeyEvent$Callback", "", "Android.Views.KeyEvent/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A34 RID: 2612
			[Register("onKeyDown", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Handler:Android.Views.KeyEvent/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e);

			// Token: 0x06000A35 RID: 2613
			[Register("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyLongPress_ILandroid_view_KeyEvent_Handler:Android.Views.KeyEvent/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e);

			// Token: 0x06000A36 RID: 2614
			[Register("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", "GetOnKeyMultiple_IILandroid_view_KeyEvent_Handler:Android.Views.KeyEvent/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int count, KeyEvent e);

			// Token: 0x06000A37 RID: 2615
			[Register("onKeyUp", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyUp_ILandroid_view_KeyEvent_Handler:Android.Views.KeyEvent/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e);
		}

		// Token: 0x02000131 RID: 305
		[Register("android/view/KeyEvent$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, KeyEvent.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0001972C File Offset: 0x0001792C
			private static IntPtr java_class_ref
			{
				get
				{
					return KeyEvent.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00019750 File Offset: 0x00017950
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KeyEvent.ICallbackInvoker._members;
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00019757 File Offset: 0x00017957
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0001975F File Offset: 0x0001795F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KeyEvent.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x0001976B File Offset: 0x0001796B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, KeyEvent.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.KeyEvent.Callback'.");
				}
				return handle;
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x00019796 File Offset: 0x00017996
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x000197C8 File Offset: 0x000179C8
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(KeyEvent.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x00019800 File Offset: 0x00017A00
			private static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler()
			{
				if (KeyEvent.ICallbackInvoker.cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
				{
					KeyEvent.ICallbackInvoker.cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(KeyEvent.ICallbackInvoker.n_OnKeyDown_ILandroid_view_KeyEvent_));
				}
				return KeyEvent.ICallbackInvoker.cb_onKeyDown_ILandroid_view_KeyEvent_;
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x00019824 File Offset: 0x00017A24
			private static bool n_OnKeyDown_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
			{
				KeyEvent.ICallback @object = Java.Lang.Object.GetObject<KeyEvent.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnKeyDown((Keycode)native_keyCode, object2);
			}

			// Token: 0x06000A41 RID: 2625 RVA: 0x0001984C File Offset: 0x00017A4C
			public unsafe bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
			{
				if (this.id_onKeyDown_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_onKeyDown_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((int)keyCode);
				ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyDown_ILandroid_view_KeyEvent_, ptr);
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x000198D2 File Offset: 0x00017AD2
			private static Delegate GetOnKeyLongPress_ILandroid_view_KeyEvent_Handler()
			{
				if (KeyEvent.ICallbackInvoker.cb_onKeyLongPress_ILandroid_view_KeyEvent_ == null)
				{
					KeyEvent.ICallbackInvoker.cb_onKeyLongPress_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(KeyEvent.ICallbackInvoker.n_OnKeyLongPress_ILandroid_view_KeyEvent_));
				}
				return KeyEvent.ICallbackInvoker.cb_onKeyLongPress_ILandroid_view_KeyEvent_;
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x000198F8 File Offset: 0x00017AF8
			private static bool n_OnKeyLongPress_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
			{
				KeyEvent.ICallback @object = Java.Lang.Object.GetObject<KeyEvent.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnKeyLongPress((Keycode)native_keyCode, object2);
			}

			// Token: 0x06000A44 RID: 2628 RVA: 0x00019920 File Offset: 0x00017B20
			public unsafe bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e)
			{
				if (this.id_onKeyLongPress_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_onKeyLongPress_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((int)keyCode);
				ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyLongPress_ILandroid_view_KeyEvent_, ptr);
			}

			// Token: 0x06000A45 RID: 2629 RVA: 0x000199A6 File Offset: 0x00017BA6
			private static Delegate GetOnKeyMultiple_IILandroid_view_KeyEvent_Handler()
			{
				if (KeyEvent.ICallbackInvoker.cb_onKeyMultiple_IILandroid_view_KeyEvent_ == null)
				{
					KeyEvent.ICallbackInvoker.cb_onKeyMultiple_IILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_Z(KeyEvent.ICallbackInvoker.n_OnKeyMultiple_IILandroid_view_KeyEvent_));
				}
				return KeyEvent.ICallbackInvoker.cb_onKeyMultiple_IILandroid_view_KeyEvent_;
			}

			// Token: 0x06000A46 RID: 2630 RVA: 0x000199CC File Offset: 0x00017BCC
			private static bool n_OnKeyMultiple_IILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, int count, IntPtr native_e)
			{
				KeyEvent.ICallback @object = Java.Lang.Object.GetObject<KeyEvent.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnKeyMultiple((Keycode)native_keyCode, count, object2);
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x000199F4 File Offset: 0x00017BF4
			public unsafe bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int count, KeyEvent e)
			{
				if (this.id_onKeyMultiple_IILandroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_onKeyMultiple_IILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((int)keyCode);
				ptr[1] = new JValue(count);
				ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyMultiple_IILandroid_view_KeyEvent_, ptr);
			}

			// Token: 0x06000A48 RID: 2632 RVA: 0x00019A90 File Offset: 0x00017C90
			private static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler()
			{
				if (KeyEvent.ICallbackInvoker.cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
				{
					KeyEvent.ICallbackInvoker.cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(KeyEvent.ICallbackInvoker.n_OnKeyUp_ILandroid_view_KeyEvent_));
				}
				return KeyEvent.ICallbackInvoker.cb_onKeyUp_ILandroid_view_KeyEvent_;
			}

			// Token: 0x06000A49 RID: 2633 RVA: 0x00019AB4 File Offset: 0x00017CB4
			private static bool n_OnKeyUp_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
			{
				KeyEvent.ICallback @object = Java.Lang.Object.GetObject<KeyEvent.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnKeyUp((Keycode)native_keyCode, object2);
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x00019ADC File Offset: 0x00017CDC
			public unsafe bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
			{
				if (this.id_onKeyUp_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_onKeyUp_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((int)keyCode);
				ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKeyUp_ILandroid_view_KeyEvent_, ptr);
			}

			// Token: 0x0400034F RID: 847
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/KeyEvent$Callback", typeof(KeyEvent.ICallbackInvoker));

			// Token: 0x04000350 RID: 848
			private IntPtr class_ref;

			// Token: 0x04000351 RID: 849
			private static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;

			// Token: 0x04000352 RID: 850
			private IntPtr id_onKeyDown_ILandroid_view_KeyEvent_;

			// Token: 0x04000353 RID: 851
			private static Delegate cb_onKeyLongPress_ILandroid_view_KeyEvent_;

			// Token: 0x04000354 RID: 852
			private IntPtr id_onKeyLongPress_ILandroid_view_KeyEvent_;

			// Token: 0x04000355 RID: 853
			private static Delegate cb_onKeyMultiple_IILandroid_view_KeyEvent_;

			// Token: 0x04000356 RID: 854
			private IntPtr id_onKeyMultiple_IILandroid_view_KeyEvent_;

			// Token: 0x04000357 RID: 855
			private static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;

			// Token: 0x04000358 RID: 856
			private IntPtr id_onKeyUp_ILandroid_view_KeyEvent_;
		}
	}
}
