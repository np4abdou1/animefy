using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001C9 RID: 457
	[Register("android/text/style/UpdateLayout", DoNotGenerateAcw = true)]
	internal class IUpdateLayoutInvoker : Java.Lang.Object, IUpdateLayout, IUpdateAppearance, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IUpdateLayoutInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0002ABCC File Offset: 0x00028DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUpdateLayoutInvoker._members;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0002ABD3 File Offset: 0x00028DD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0002ABDB File Offset: 0x00028DDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUpdateLayoutInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002ABE7 File Offset: 0x00028DE7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUpdateLayoutInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.style.UpdateLayout'.");
			}
			return handle;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002AC12 File Offset: 0x00028E12
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002AC44 File Offset: 0x00028E44
		public IUpdateLayoutInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUpdateLayoutInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000784 RID: 1924
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/UpdateLayout", typeof(IUpdateLayoutInvoker));

		// Token: 0x04000785 RID: 1925
		private IntPtr class_ref;
	}
}
