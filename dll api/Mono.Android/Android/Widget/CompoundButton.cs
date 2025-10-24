using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000B7 RID: 183
	[Register("android/widget/CompoundButton", DoNotGenerateAcw = true)]
	public abstract class CompoundButton : Button, ICheckable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00005E2F File Offset: 0x0000402F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompoundButton._members;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00005E38 File Offset: 0x00004038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompoundButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00005E5C File Offset: 0x0000405C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompoundButton._members.ManagedPeerType;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00005E68 File Offset: 0x00004068
		protected CompoundButton(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00005E74 File Offset: 0x00004074
		public unsafe CompoundButton(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CompoundButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CompoundButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00005F50 File Offset: 0x00004150
		public unsafe CompoundButton(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CompoundButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CompoundButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00006040 File Offset: 0x00004240
		private static Delegate GetIsCheckedHandler()
		{
			if (CompoundButton.cb_isChecked == null)
			{
				CompoundButton.cb_isChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CompoundButton.n_IsChecked));
			}
			return CompoundButton.cb_isChecked;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00006064 File Offset: 0x00004264
		private static bool n_IsChecked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00006073 File Offset: 0x00004273
		private static Delegate GetSetChecked_ZHandler()
		{
			if (CompoundButton.cb_setChecked_Z == null)
			{
				CompoundButton.cb_setChecked_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CompoundButton.n_SetChecked_Z));
			}
			return CompoundButton.cb_setChecked_Z;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00006097 File Offset: 0x00004297
		private static void n_SetChecked_Z(IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			Java.Lang.Object.GetObject<CompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked = @checked;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000060A7 File Offset: 0x000042A7
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000060C0 File Offset: 0x000042C0
		public unsafe virtual bool Checked
		{
			get
			{
				return CompoundButton._members.InstanceMethods.InvokeVirtualBooleanMethod("isChecked.()Z", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CompoundButton._members.InstanceMethods.InvokeVirtualVoidMethod("setChecked.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000060FB File Offset: 0x000042FB
		private static Delegate GetSetOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_Handler()
		{
			if (CompoundButton.cb_setOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_ == null)
			{
				CompoundButton.cb_setOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CompoundButton.n_SetOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_));
			}
			return CompoundButton.cb_setOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00006120 File Offset: 0x00004320
		private static void n_SetOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			CompoundButton @object = Java.Lang.Object.GetObject<CompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CompoundButton.IOnCheckedChangeListener object2 = Java.Lang.Object.GetObject<CompoundButton.IOnCheckedChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnCheckedChangeListener(object2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00006144 File Offset: 0x00004344
		public unsafe virtual void SetOnCheckedChangeListener(CompoundButton.IOnCheckedChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				CompoundButton._members.InstanceMethods.InvokeVirtualVoidMethod("setOnCheckedChangeListener.(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000061AC File Offset: 0x000043AC
		private static Delegate GetToggleHandler()
		{
			if (CompoundButton.cb_toggle == null)
			{
				CompoundButton.cb_toggle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CompoundButton.n_Toggle));
			}
			return CompoundButton.cb_toggle;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000061D0 File Offset: 0x000043D0
		private static void n_Toggle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CompoundButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Toggle();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000061DF File Offset: 0x000043DF
		public virtual void Toggle()
		{
			CompoundButton._members.InstanceMethods.InvokeVirtualVoidMethod("toggle.()V", this, null);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000394 RID: 916 RVA: 0x000061F8 File Offset: 0x000043F8
		// (remove) Token: 0x06000395 RID: 917 RVA: 0x00006244 File Offset: 0x00004444
		public event EventHandler<CompoundButton.CheckedChangeEventArgs> CheckedChange
		{
			add
			{
				EventHelper.AddEventHandler<CompoundButton.IOnCheckedChangeListener, CompoundButton.IOnCheckedChangeListenerImplementor>(ref this.weak_implementor_SetOnCheckedChangeListener, new Func<CompoundButton.IOnCheckedChangeListenerImplementor>(this.__CreateIOnCheckedChangeListenerImplementor), new Action<CompoundButton.IOnCheckedChangeListener>(this.SetOnCheckedChangeListener), delegate(CompoundButton.IOnCheckedChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<CompoundButton.CheckedChangeEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<CompoundButton.IOnCheckedChangeListenerImplementor, bool> empty;
				if ((empty = CompoundButton.<>O.<0>____IsEmpty) == null)
				{
					empty = (CompoundButton.<>O.<0>____IsEmpty = new Func<CompoundButton.IOnCheckedChangeListenerImplementor, bool>(CompoundButton.IOnCheckedChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<CompoundButton.IOnCheckedChangeListener, CompoundButton.IOnCheckedChangeListenerImplementor>(ref this.weak_implementor_SetOnCheckedChangeListener, empty, delegate(CompoundButton.IOnCheckedChangeListener __v)
				{
					this.SetOnCheckedChangeListener(null);
				}, delegate(CompoundButton.IOnCheckedChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<CompoundButton.CheckedChangeEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000062A3 File Offset: 0x000044A3
		private CompoundButton.IOnCheckedChangeListenerImplementor __CreateIOnCheckedChangeListenerImplementor()
		{
			return new CompoundButton.IOnCheckedChangeListenerImplementor();
		}

		// Token: 0x0400008C RID: 140
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/CompoundButton", typeof(CompoundButton));

		// Token: 0x0400008D RID: 141
		private static Delegate cb_isChecked;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_setChecked_Z;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_setOnCheckedChangeListener_Landroid_widget_CompoundButton_OnCheckedChangeListener_;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_toggle;

		// Token: 0x04000091 RID: 145
		private WeakReference weak_implementor_SetOnCheckedChangeListener;

		// Token: 0x020000B8 RID: 184
		[Register("android/widget/CompoundButton$OnCheckedChangeListener", "", "Android.Widget.CompoundButton/IOnCheckedChangeListenerInvoker")]
		public interface IOnCheckedChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000398 RID: 920
			[Register("onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", "GetOnCheckedChanged_Landroid_widget_CompoundButton_ZHandler:Android.Widget.CompoundButton/IOnCheckedChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnCheckedChanged(CompoundButton buttonView, bool isChecked);
		}

		// Token: 0x020000B9 RID: 185
		[Register("android/widget/CompoundButton$OnCheckedChangeListener", DoNotGenerateAcw = true)]
		internal class IOnCheckedChangeListenerInvoker : Java.Lang.Object, CompoundButton.IOnCheckedChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000399 RID: 921 RVA: 0x000062C8 File Offset: 0x000044C8
			private static IntPtr java_class_ref
			{
				get
				{
					return CompoundButton.IOnCheckedChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600039A RID: 922 RVA: 0x000062EC File Offset: 0x000044EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CompoundButton.IOnCheckedChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600039B RID: 923 RVA: 0x000062F3 File Offset: 0x000044F3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600039C RID: 924 RVA: 0x000062FB File Offset: 0x000044FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CompoundButton.IOnCheckedChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00006307 File Offset: 0x00004507
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, CompoundButton.IOnCheckedChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.CompoundButton.OnCheckedChangeListener'.");
				}
				return handle;
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00006332 File Offset: 0x00004532
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00006364 File Offset: 0x00004564
			public IOnCheckedChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(CompoundButton.IOnCheckedChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x0000639C File Offset: 0x0000459C
			private static Delegate GetOnCheckedChanged_Landroid_widget_CompoundButton_ZHandler()
			{
				if (CompoundButton.IOnCheckedChangeListenerInvoker.cb_onCheckedChanged_Landroid_widget_CompoundButton_Z == null)
				{
					CompoundButton.IOnCheckedChangeListenerInvoker.cb_onCheckedChanged_Landroid_widget_CompoundButton_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(CompoundButton.IOnCheckedChangeListenerInvoker.n_OnCheckedChanged_Landroid_widget_CompoundButton_Z));
				}
				return CompoundButton.IOnCheckedChangeListenerInvoker.cb_onCheckedChanged_Landroid_widget_CompoundButton_Z;
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x000063C0 File Offset: 0x000045C0
			private static void n_OnCheckedChanged_Landroid_widget_CompoundButton_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_buttonView, bool isChecked)
			{
				CompoundButton.IOnCheckedChangeListener @object = Java.Lang.Object.GetObject<CompoundButton.IOnCheckedChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CompoundButton object2 = Java.Lang.Object.GetObject<CompoundButton>(native_buttonView, JniHandleOwnership.DoNotTransfer);
				@object.OnCheckedChanged(object2, isChecked);
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x000063E4 File Offset: 0x000045E4
			public unsafe void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
			{
				if (this.id_onCheckedChanged_Landroid_widget_CompoundButton_Z == IntPtr.Zero)
				{
					this.id_onCheckedChanged_Landroid_widget_CompoundButton_Z = JNIEnv.GetMethodID(this.class_ref, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((buttonView == null) ? IntPtr.Zero : buttonView.Handle);
				ptr[1] = new JValue(isChecked);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onCheckedChanged_Landroid_widget_CompoundButton_Z, ptr);
			}

			// Token: 0x04000092 RID: 146
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/CompoundButton$OnCheckedChangeListener", typeof(CompoundButton.IOnCheckedChangeListenerInvoker));

			// Token: 0x04000093 RID: 147
			private IntPtr class_ref;

			// Token: 0x04000094 RID: 148
			private static Delegate cb_onCheckedChanged_Landroid_widget_CompoundButton_Z;

			// Token: 0x04000095 RID: 149
			private IntPtr id_onCheckedChanged_Landroid_widget_CompoundButton_Z;
		}

		// Token: 0x020000BA RID: 186
		public class CheckedChangeEventArgs : EventArgs
		{
			// Token: 0x060003A4 RID: 932 RVA: 0x00006485 File Offset: 0x00004685
			public CheckedChangeEventArgs(bool isChecked)
			{
				this.isChecked = isChecked;
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060003A5 RID: 933 RVA: 0x00006494 File Offset: 0x00004694
			public bool IsChecked
			{
				get
				{
					return this.isChecked;
				}
			}

			// Token: 0x04000096 RID: 150
			private bool isChecked;
		}

		// Token: 0x020000BB RID: 187
		[Register("mono/android/widget/CompoundButton_OnCheckedChangeListenerImplementor")]
		internal sealed class IOnCheckedChangeListenerImplementor : Java.Lang.Object, CompoundButton.IOnCheckedChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003A6 RID: 934 RVA: 0x0000649C File Offset: 0x0000469C
			public IOnCheckedChangeListenerImplementor() : base(JNIEnv.StartCreateInstance("mono/android/widget/CompoundButton_OnCheckedChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x000064D0 File Offset: 0x000046D0
			public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
			{
				EventHandler<CompoundButton.CheckedChangeEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(buttonView, new CompoundButton.CheckedChangeEventArgs(isChecked));
				}
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x000064F4 File Offset: 0x000046F4
			internal static bool __IsEmpty(CompoundButton.IOnCheckedChangeListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000097 RID: 151
			public EventHandler<CompoundButton.CheckedChangeEventArgs> Handler;
		}

		// Token: 0x020000BC RID: 188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000098 RID: 152
			public static Func<CompoundButton.IOnCheckedChangeListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
