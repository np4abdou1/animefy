using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000BC RID: 188
	[Register("com/applovin/mediation/MaxErrorCode", DoNotGenerateAcw = true)]
	internal class IMaxErrorCodeInvoker : Java.Lang.Object, IMaxErrorCode, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000105D8 File Offset: 0x0000E7D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxErrorCodeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000105FC File Offset: 0x0000E7FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxErrorCodeInvoker._members;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00010603 File Offset: 0x0000E803
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001060B File Offset: 0x0000E80B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxErrorCodeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00010617 File Offset: 0x0000E817
		public static IMaxErrorCode GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxErrorCode>(handle, transfer);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00010620 File Offset: 0x0000E820
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxErrorCodeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxErrorCode'.");
			}
			return handle;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001064B File Offset: 0x0000E84B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001067C File Offset: 0x0000E87C
		public IMaxErrorCodeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxErrorCodeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000222 RID: 546
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxErrorCode", typeof(IMaxErrorCodeInvoker));

		// Token: 0x04000223 RID: 547
		private IntPtr class_ref;
	}
}
