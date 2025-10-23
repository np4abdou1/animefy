using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000117 RID: 279
	[Register("android/view/ContextMenu$ContextMenuInfo", DoNotGenerateAcw = true)]
	internal class IContextMenuContextMenuInfoInvoker : Java.Lang.Object, IContextMenuContextMenuInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000103A8 File Offset: 0x0000E5A8
		private static IntPtr java_class_ref
		{
			get
			{
				return IContextMenuContextMenuInfoInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000103CC File Offset: 0x0000E5CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContextMenuContextMenuInfoInvoker._members;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000103D3 File Offset: 0x0000E5D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000103DB File Offset: 0x0000E5DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContextMenuContextMenuInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000103E7 File Offset: 0x0000E5E7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContextMenuContextMenuInfoInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ContextMenu.ContextMenuInfo'.");
			}
			return handle;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00010412 File Offset: 0x0000E612
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00010444 File Offset: 0x0000E644
		public IContextMenuContextMenuInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContextMenuContextMenuInfoInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040001DA RID: 474
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ContextMenu$ContextMenuInfo", typeof(IContextMenuContextMenuInfoInvoker));

		// Token: 0x040001DB RID: 475
		private IntPtr class_ref;
	}
}
