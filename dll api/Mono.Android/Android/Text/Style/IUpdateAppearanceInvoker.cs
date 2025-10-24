using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001C7 RID: 455
	[Register("android/text/style/UpdateAppearance", DoNotGenerateAcw = true)]
	internal class IUpdateAppearanceInvoker : Java.Lang.Object, IUpdateAppearance, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		private static IntPtr java_class_ref
		{
			get
			{
				return IUpdateAppearanceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0002AADC File Offset: 0x00028CDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUpdateAppearanceInvoker._members;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0002AAE3 File Offset: 0x00028CE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0002AAEB File Offset: 0x00028CEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUpdateAppearanceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002AAF7 File Offset: 0x00028CF7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUpdateAppearanceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.style.UpdateAppearance'.");
			}
			return handle;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002AB22 File Offset: 0x00028D22
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002AB54 File Offset: 0x00028D54
		public IUpdateAppearanceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUpdateAppearanceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000782 RID: 1922
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/UpdateAppearance", typeof(IUpdateAppearanceInvoker));

		// Token: 0x04000783 RID: 1923
		private IntPtr class_ref;
	}
}
