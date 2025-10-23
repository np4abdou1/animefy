using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000069 RID: 105
	[Register("androidx/appcompat/widget/EmojiCompatConfigurationView", DoNotGenerateAcw = true)]
	internal class IEmojiCompatConfigurationViewInvoker : Java.Lang.Object, IEmojiCompatConfigurationView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00013A48 File Offset: 0x00011C48
		private static IntPtr java_class_ref
		{
			get
			{
				return IEmojiCompatConfigurationViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00013A6C File Offset: 0x00011C6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEmojiCompatConfigurationViewInvoker._members;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00013A73 File Offset: 0x00011C73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00013A7B File Offset: 0x00011C7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEmojiCompatConfigurationViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00013A87 File Offset: 0x00011C87
		public static IEmojiCompatConfigurationView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEmojiCompatConfigurationView>(handle, transfer);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00013A90 File Offset: 0x00011C90
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEmojiCompatConfigurationViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.EmojiCompatConfigurationView'.");
			}
			return handle;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00013ABB File Offset: 0x00011CBB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00013AEC File Offset: 0x00011CEC
		public IEmojiCompatConfigurationViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEmojiCompatConfigurationViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00013B24 File Offset: 0x00011D24
		private static Delegate GetIsEmojiCompatEnabledHandler()
		{
			if (IEmojiCompatConfigurationViewInvoker.cb_isEmojiCompatEnabled == null)
			{
				IEmojiCompatConfigurationViewInvoker.cb_isEmojiCompatEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IEmojiCompatConfigurationViewInvoker.n_IsEmojiCompatEnabled));
			}
			return IEmojiCompatConfigurationViewInvoker.cb_isEmojiCompatEnabled;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00013B48 File Offset: 0x00011D48
		private static bool n_IsEmojiCompatEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IEmojiCompatConfigurationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00013B57 File Offset: 0x00011D57
		private static Delegate GetSetEmojiCompatEnabled_ZHandler()
		{
			if (IEmojiCompatConfigurationViewInvoker.cb_setEmojiCompatEnabled_Z == null)
			{
				IEmojiCompatConfigurationViewInvoker.cb_setEmojiCompatEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IEmojiCompatConfigurationViewInvoker.n_SetEmojiCompatEnabled_Z));
			}
			return IEmojiCompatConfigurationViewInvoker.cb_setEmojiCompatEnabled_Z;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00013B7B File Offset: 0x00011D7B
		private static void n_SetEmojiCompatEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IEmojiCompatConfigurationView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled = p0;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00013B8B File Offset: 0x00011D8B
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00013BCC File Offset: 0x00011DCC
		public unsafe bool EmojiCompatEnabled
		{
			get
			{
				if (this.id_isEmojiCompatEnabled == IntPtr.Zero)
				{
					this.id_isEmojiCompatEnabled = JNIEnv.GetMethodID(this.class_ref, "isEmojiCompatEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmojiCompatEnabled);
			}
			set
			{
				if (this.id_setEmojiCompatEnabled_Z == IntPtr.Zero)
				{
					this.id_setEmojiCompatEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setEmojiCompatEnabled", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setEmojiCompatEnabled_Z, ptr);
			}
		}

		// Token: 0x0400021F RID: 543
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/EmojiCompatConfigurationView", typeof(IEmojiCompatConfigurationViewInvoker));

		// Token: 0x04000220 RID: 544
		private IntPtr class_ref;

		// Token: 0x04000221 RID: 545
		private static Delegate cb_isEmojiCompatEnabled;

		// Token: 0x04000222 RID: 546
		private static Delegate cb_setEmojiCompatEnabled_Z;

		// Token: 0x04000223 RID: 547
		private IntPtr id_isEmojiCompatEnabled;

		// Token: 0x04000224 RID: 548
		private IntPtr id_setEmojiCompatEnabled_Z;
	}
}
