using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000CC RID: 204
	[Register("android/widget/Checkable", DoNotGenerateAcw = true)]
	internal class ICheckableInvoker : Java.Lang.Object, ICheckable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00007ABC File Offset: 0x00005CBC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICheckableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00007AE0 File Offset: 0x00005CE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICheckableInvoker._members;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00007AE7 File Offset: 0x00005CE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00007AEF File Offset: 0x00005CEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICheckableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00007AFB File Offset: 0x00005CFB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICheckableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.Checkable'.");
			}
			return handle;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00007B26 File Offset: 0x00005D26
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00007B58 File Offset: 0x00005D58
		public ICheckableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICheckableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00007B90 File Offset: 0x00005D90
		private static Delegate GetIsCheckedHandler()
		{
			if (ICheckableInvoker.cb_isChecked == null)
			{
				ICheckableInvoker.cb_isChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ICheckableInvoker.n_IsChecked));
			}
			return ICheckableInvoker.cb_isChecked;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00007BB4 File Offset: 0x00005DB4
		private static bool n_IsChecked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ICheckable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00007BC3 File Offset: 0x00005DC3
		private static Delegate GetSetChecked_ZHandler()
		{
			if (ICheckableInvoker.cb_setChecked_Z == null)
			{
				ICheckableInvoker.cb_setChecked_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ICheckableInvoker.n_SetChecked_Z));
			}
			return ICheckableInvoker.cb_setChecked_Z;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00007BE7 File Offset: 0x00005DE7
		private static void n_SetChecked_Z(IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			Java.Lang.Object.GetObject<ICheckable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Checked = @checked;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00007BF7 File Offset: 0x00005DF7
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00007C38 File Offset: 0x00005E38
		public unsafe bool Checked
		{
			get
			{
				if (this.id_isChecked == IntPtr.Zero)
				{
					this.id_isChecked = JNIEnv.GetMethodID(this.class_ref, "isChecked", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isChecked);
			}
			set
			{
				if (this.id_setChecked_Z == IntPtr.Zero)
				{
					this.id_setChecked_Z = JNIEnv.GetMethodID(this.class_ref, "setChecked", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setChecked_Z, ptr);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00007C9C File Offset: 0x00005E9C
		private static Delegate GetToggleHandler()
		{
			if (ICheckableInvoker.cb_toggle == null)
			{
				ICheckableInvoker.cb_toggle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICheckableInvoker.n_Toggle));
			}
			return ICheckableInvoker.cb_toggle;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00007CC0 File Offset: 0x00005EC0
		private static void n_Toggle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICheckable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Toggle();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00007CCF File Offset: 0x00005ECF
		public void Toggle()
		{
			if (this.id_toggle == IntPtr.Zero)
			{
				this.id_toggle = JNIEnv.GetMethodID(this.class_ref, "toggle", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_toggle);
		}

		// Token: 0x040000C2 RID: 194
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Checkable", typeof(ICheckableInvoker));

		// Token: 0x040000C3 RID: 195
		private IntPtr class_ref;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_isChecked;

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_setChecked_Z;

		// Token: 0x040000C6 RID: 198
		private IntPtr id_isChecked;

		// Token: 0x040000C7 RID: 199
		private IntPtr id_setChecked_Z;

		// Token: 0x040000C8 RID: 200
		private static Delegate cb_toggle;

		// Token: 0x040000C9 RID: 201
		private IntPtr id_toggle;
	}
}
