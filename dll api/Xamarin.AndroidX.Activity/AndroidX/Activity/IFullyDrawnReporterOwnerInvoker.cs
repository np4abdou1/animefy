using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x02000015 RID: 21
	[Register("androidx/activity/FullyDrawnReporterOwner", DoNotGenerateAcw = true)]
	internal class IFullyDrawnReporterOwnerInvoker : Java.Lang.Object, IFullyDrawnReporterOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000036C4 File Offset: 0x000018C4
		private static IntPtr java_class_ref
		{
			get
			{
				return IFullyDrawnReporterOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000036E8 File Offset: 0x000018E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFullyDrawnReporterOwnerInvoker._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000036EF File Offset: 0x000018EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000036F7 File Offset: 0x000018F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFullyDrawnReporterOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003703 File Offset: 0x00001903
		public static IFullyDrawnReporterOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFullyDrawnReporterOwner>(handle, transfer);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000370C File Offset: 0x0000190C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFullyDrawnReporterOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.FullyDrawnReporterOwner'.");
			}
			return handle;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003737 File Offset: 0x00001937
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003768 File Offset: 0x00001968
		public IFullyDrawnReporterOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFullyDrawnReporterOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000037A0 File Offset: 0x000019A0
		private static Delegate GetGetFullyDrawnReporterHandler()
		{
			if (IFullyDrawnReporterOwnerInvoker.cb_getFullyDrawnReporter == null)
			{
				IFullyDrawnReporterOwnerInvoker.cb_getFullyDrawnReporter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFullyDrawnReporterOwnerInvoker.n_GetFullyDrawnReporter));
			}
			return IFullyDrawnReporterOwnerInvoker.cb_getFullyDrawnReporter;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000037C4 File Offset: 0x000019C4
		private static IntPtr n_GetFullyDrawnReporter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFullyDrawnReporterOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FullyDrawnReporter);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000037D8 File Offset: 0x000019D8
		public FullyDrawnReporter FullyDrawnReporter
		{
			get
			{
				if (this.id_getFullyDrawnReporter == IntPtr.Zero)
				{
					this.id_getFullyDrawnReporter = JNIEnv.GetMethodID(this.class_ref, "getFullyDrawnReporter", "()Landroidx/activity/FullyDrawnReporter;");
				}
				return Java.Lang.Object.GetObject<FullyDrawnReporter>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFullyDrawnReporter), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/FullyDrawnReporterOwner", typeof(IFullyDrawnReporterOwnerInvoker));

		// Token: 0x0400001B RID: 27
		private IntPtr class_ref;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getFullyDrawnReporter;

		// Token: 0x0400001D RID: 29
		private IntPtr id_getFullyDrawnReporter;
	}
}
