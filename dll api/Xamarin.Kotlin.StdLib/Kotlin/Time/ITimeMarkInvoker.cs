using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000CC RID: 204
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimeMark", DoNotGenerateAcw = true)]
	internal class ITimeMarkInvoker : Java.Lang.Object, ITimeMark, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0000F540 File Offset: 0x0000D740
		private static IntPtr java_class_ref
		{
			get
			{
				return ITimeMarkInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0000F564 File Offset: 0x0000D764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITimeMarkInvoker._members;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0000F56B File Offset: 0x0000D76B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0000F573 File Offset: 0x0000D773
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITimeMarkInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000F57F File Offset: 0x0000D77F
		[NullableContext(2)]
		public static ITimeMark GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITimeMark>(handle, transfer);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000F588 File Offset: 0x0000D788
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITimeMarkInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.time.TimeMark'.");
			}
			return handle;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000F5B3 File Offset: 0x0000D7B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public ITimeMarkInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITimeMarkInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000F61C File Offset: 0x0000D81C
		private static Delegate GetHasNotPassedNowHandler()
		{
			if (ITimeMarkInvoker.cb_hasNotPassedNow == null)
			{
				ITimeMarkInvoker.cb_hasNotPassedNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ITimeMarkInvoker.n_HasNotPassedNow));
			}
			return ITimeMarkInvoker.cb_hasNotPassedNow;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000F640 File Offset: 0x0000D840
		private static bool n_HasNotPassedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNotPassedNow;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0000F64F File Offset: 0x0000D84F
		public bool HasNotPassedNow
		{
			get
			{
				if (this.id_hasNotPassedNow == IntPtr.Zero)
				{
					this.id_hasNotPassedNow = JNIEnv.GetMethodID(this.class_ref, "hasNotPassedNow", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasNotPassedNow);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000F68F File Offset: 0x0000D88F
		private static Delegate GetHasPassedNowHandler()
		{
			if (ITimeMarkInvoker.cb_hasPassedNow == null)
			{
				ITimeMarkInvoker.cb_hasPassedNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ITimeMarkInvoker.n_HasPassedNow));
			}
			return ITimeMarkInvoker.cb_hasPassedNow;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000F6B3 File Offset: 0x0000D8B3
		private static bool n_HasPassedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasPassedNow;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
		public bool HasPassedNow
		{
			get
			{
				if (this.id_hasPassedNow == IntPtr.Zero)
				{
					this.id_hasPassedNow = JNIEnv.GetMethodID(this.class_ref, "hasPassedNow", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasPassedNow);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000F702 File Offset: 0x0000D902
		private static Delegate GetElapsedNowHandler()
		{
			if (ITimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc == null)
			{
				ITimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ITimeMarkInvoker.n_ElapsedNow));
			}
			return ITimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000F726 File Offset: 0x0000D926
		private static long n_ElapsedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ITimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ElapsedNow();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000F735 File Offset: 0x0000D935
		public long ElapsedNow()
		{
			if (this.id_elapsedNow_x45_UwyO8pc == IntPtr.Zero)
			{
				this.id_elapsedNow_x45_UwyO8pc = JNIEnv.GetMethodID(this.class_ref, "elapsedNow-UwyO8pc", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_elapsedNow_x45_UwyO8pc);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000F775 File Offset: 0x0000D975
		private static Delegate GetMinus_JHandler()
		{
			if (ITimeMarkInvoker.cb_minus_x45_LRDsOJo_J == null)
			{
				ITimeMarkInvoker.cb_minus_x45_LRDsOJo_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(ITimeMarkInvoker.n_Minus_J));
			}
			return ITimeMarkInvoker.cb_minus_x45_LRDsOJo_J;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000F799 File Offset: 0x0000D999
		private static IntPtr n_Minus_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Minus(p0));
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		public unsafe ITimeMark Minus(long p0)
		{
			if (this.id_minus_x45_LRDsOJo_J == IntPtr.Zero)
			{
				this.id_minus_x45_LRDsOJo_J = JNIEnv.GetMethodID(this.class_ref, "minus-LRDsOJo", "(J)Lkotlin/time/TimeMark;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_minus_x45_LRDsOJo_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000F81A File Offset: 0x0000DA1A
		private static Delegate GetPlus_JHandler()
		{
			if (ITimeMarkInvoker.cb_plus_x45_LRDsOJo_J == null)
			{
				ITimeMarkInvoker.cb_plus_x45_LRDsOJo_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(ITimeMarkInvoker.n_Plus_J));
			}
			return ITimeMarkInvoker.cb_plus_x45_LRDsOJo_J;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000F83E File Offset: 0x0000DA3E
		private static IntPtr n_Plus_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Plus(p0));
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000F854 File Offset: 0x0000DA54
		public unsafe ITimeMark Plus(long p0)
		{
			if (this.id_plus_x45_LRDsOJo_J == IntPtr.Zero)
			{
				this.id_plus_x45_LRDsOJo_J = JNIEnv.GetMethodID(this.class_ref, "plus-LRDsOJo", "(J)Lkotlin/time/TimeMark;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_x45_LRDsOJo_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001AE RID: 430
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeMark", typeof(ITimeMarkInvoker));

		// Token: 0x040001AF RID: 431
		private IntPtr class_ref;

		// Token: 0x040001B0 RID: 432
		[Nullable(2)]
		private static Delegate cb_hasNotPassedNow;

		// Token: 0x040001B1 RID: 433
		private IntPtr id_hasNotPassedNow;

		// Token: 0x040001B2 RID: 434
		[Nullable(2)]
		private static Delegate cb_hasPassedNow;

		// Token: 0x040001B3 RID: 435
		private IntPtr id_hasPassedNow;

		// Token: 0x040001B4 RID: 436
		[Nullable(2)]
		private static Delegate cb_elapsedNow_x45_UwyO8pc;

		// Token: 0x040001B5 RID: 437
		private IntPtr id_elapsedNow_x45_UwyO8pc;

		// Token: 0x040001B6 RID: 438
		[Nullable(2)]
		private static Delegate cb_minus_x45_LRDsOJo_J;

		// Token: 0x040001B7 RID: 439
		private IntPtr id_minus_x45_LRDsOJo_J;

		// Token: 0x040001B8 RID: 440
		[Nullable(2)]
		private static Delegate cb_plus_x45_LRDsOJo_J;

		// Token: 0x040001B9 RID: 441
		private IntPtr id_plus_x45_LRDsOJo_J;
	}
}
