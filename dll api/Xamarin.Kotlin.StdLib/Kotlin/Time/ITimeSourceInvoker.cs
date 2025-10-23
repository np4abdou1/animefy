using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000D1 RID: 209
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimeSource", DoNotGenerateAcw = true)]
	internal class ITimeSourceInvoker : Java.Lang.Object, ITimeSource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0000FB28 File Offset: 0x0000DD28
		private static IntPtr java_class_ref
		{
			get
			{
				return ITimeSourceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITimeSourceInvoker._members;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0000FB53 File Offset: 0x0000DD53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0000FB5B File Offset: 0x0000DD5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITimeSourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000FB67 File Offset: 0x0000DD67
		[NullableContext(2)]
		public static ITimeSource GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITimeSource>(handle, transfer);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000FB70 File Offset: 0x0000DD70
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITimeSourceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.time.TimeSource'.");
			}
			return handle;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000FB9B File Offset: 0x0000DD9B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		public ITimeSourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITimeSourceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000FC04 File Offset: 0x0000DE04
		private static Delegate GetMarkNowHandler()
		{
			if (ITimeSourceInvoker.cb_markNow == null)
			{
				ITimeSourceInvoker.cb_markNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITimeSourceInvoker.n_MarkNow));
			}
			return ITimeSourceInvoker.cb_markNow;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000FC28 File Offset: 0x0000DE28
		private static IntPtr n_MarkNow(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITimeSource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkNow());
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public ITimeMark MarkNow()
		{
			if (this.id_markNow == IntPtr.Zero)
			{
				this.id_markNow = JNIEnv.GetMethodID(this.class_ref, "markNow", "()Lkotlin/time/TimeMark;");
			}
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_markNow), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001BF RID: 447
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeSource", typeof(ITimeSourceInvoker));

		// Token: 0x040001C0 RID: 448
		private IntPtr class_ref;

		// Token: 0x040001C1 RID: 449
		[Nullable(2)]
		private static Delegate cb_markNow;

		// Token: 0x040001C2 RID: 450
		private IntPtr id_markNow;
	}
}
