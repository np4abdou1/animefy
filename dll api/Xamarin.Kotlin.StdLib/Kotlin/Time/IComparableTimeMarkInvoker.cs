using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000C7 RID: 199
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/ComparableTimeMark", DoNotGenerateAcw = true)]
	internal class IComparableTimeMarkInvoker : Java.Lang.Object, IComparableTimeMark, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable, ITimeMark
	{
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0000E888 File Offset: 0x0000CA88
		private static IntPtr java_class_ref
		{
			get
			{
				return IComparableTimeMarkInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComparableTimeMarkInvoker._members;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000E8B3 File Offset: 0x0000CAB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0000E8BB File Offset: 0x0000CABB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComparableTimeMarkInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000E8C7 File Offset: 0x0000CAC7
		[NullableContext(2)]
		public static IComparableTimeMark GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IComparableTimeMark>(handle, transfer);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComparableTimeMarkInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.time.ComparableTimeMark'.");
			}
			return handle;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000E8FB File Offset: 0x0000CAFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000E92C File Offset: 0x0000CB2C
		public IComparableTimeMarkInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComparableTimeMarkInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000E964 File Offset: 0x0000CB64
		private static Delegate GetCompareTo_Lkotlin_time_ComparableTimeMark_Handler()
		{
			if (IComparableTimeMarkInvoker.cb_compareTo_Lkotlin_time_ComparableTimeMark_ == null)
			{
				IComparableTimeMarkInvoker.cb_compareTo_Lkotlin_time_ComparableTimeMark_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IComparableTimeMarkInvoker.n_CompareTo_Lkotlin_time_ComparableTimeMark_));
			}
			return IComparableTimeMarkInvoker.cb_compareTo_Lkotlin_time_ComparableTimeMark_;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000E988 File Offset: 0x0000CB88
		private static int n_CompareTo_Lkotlin_time_ComparableTimeMark_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IComparableTimeMark @object = Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IComparableTimeMark object2 = Java.Lang.Object.GetObject<IComparableTimeMark>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		public unsafe int CompareTo(IComparableTimeMark other)
		{
			if (this.id_compareTo_Lkotlin_time_ComparableTimeMark_ == IntPtr.Zero)
			{
				this.id_compareTo_Lkotlin_time_ComparableTimeMark_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Lkotlin/time/ComparableTimeMark;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Lkotlin_time_ComparableTimeMark_, ptr);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000EA24 File Offset: 0x0000CC24
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComparableTimeMarkInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComparableTimeMarkInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComparableTimeMarkInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComparableTimeMarkInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000EA48 File Offset: 0x0000CC48
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IComparableTimeMark @object = Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		[NullableContext(2)]
		public new unsafe bool Equals(Java.Lang.Object other)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : other.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000EADF File Offset: 0x0000CCDF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IComparableTimeMarkInvoker.cb_hashCode == null)
			{
				IComparableTimeMarkInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IComparableTimeMarkInvoker.n_GetHashCode));
			}
			return IComparableTimeMarkInvoker.cb_hashCode;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000EB03 File Offset: 0x0000CD03
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000EB12 File Offset: 0x0000CD12
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000EB52 File Offset: 0x0000CD52
		private static Delegate GetMinus_JHandler()
		{
			if (IComparableTimeMarkInvoker.cb_minus_x45_LRDsOJo_J == null)
			{
				IComparableTimeMarkInvoker.cb_minus_x45_LRDsOJo_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(IComparableTimeMarkInvoker.n_Minus_J));
			}
			return IComparableTimeMarkInvoker.cb_minus_x45_LRDsOJo_J;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000EB76 File Offset: 0x0000CD76
		private static IntPtr n_Minus_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Minus(p0));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		public unsafe ITimeMark Minus(long p0)
		{
			if (this.id_minus_x45_LRDsOJo_J == IntPtr.Zero)
			{
				this.id_minus_x45_LRDsOJo_J = JNIEnv.GetMethodID(this.class_ref, "minus-LRDsOJo", "(J)Lkotlin/time/ComparableTimeMark;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_minus_x45_LRDsOJo_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000EBF6 File Offset: 0x0000CDF6
		private static Delegate GetMinus_Lkotlin_time_ComparableTimeMark_Handler()
		{
			if (IComparableTimeMarkInvoker.cb_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_ == null)
			{
				IComparableTimeMarkInvoker.cb_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(IComparableTimeMarkInvoker.n_Minus_Lkotlin_time_ComparableTimeMark_));
			}
			return IComparableTimeMarkInvoker.cb_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		private static long n_Minus_Lkotlin_time_ComparableTimeMark_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IComparableTimeMark @object = Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IComparableTimeMark object2 = Java.Lang.Object.GetObject<IComparableTimeMark>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.Minus(object2);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public unsafe long Minus(IComparableTimeMark other)
		{
			if (this.id_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_ == IntPtr.Zero)
			{
				this.id_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_ = JNIEnv.GetMethodID(this.class_ref, "minus-UwyO8pc", "(Lkotlin/time/ComparableTimeMark;)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
			return JNIEnv.CallLongMethod(base.Handle, this.id_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_, ptr);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		private static Delegate GetPlus_JHandler()
		{
			if (IComparableTimeMarkInvoker.cb_plus_x45_LRDsOJo_J == null)
			{
				IComparableTimeMarkInvoker.cb_plus_x45_LRDsOJo_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(IComparableTimeMarkInvoker.n_Plus_J));
			}
			return IComparableTimeMarkInvoker.cb_plus_x45_LRDsOJo_J;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		private static IntPtr n_Plus_J(IntPtr jnienv, IntPtr native__this, long p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Plus(p0));
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		public unsafe ITimeMark Plus(long p0)
		{
			if (this.id_plus_x45_LRDsOJo_J == IntPtr.Zero)
			{
				this.id_plus_x45_LRDsOJo_J = JNIEnv.GetMethodID(this.class_ref, "plus-LRDsOJo", "(J)Lkotlin/time/ComparableTimeMark;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return Java.Lang.Object.GetObject<ITimeMark>(JNIEnv.CallObjectMethod(base.Handle, this.id_plus_x45_LRDsOJo_J, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000ED5E File Offset: 0x0000CF5E
		private static Delegate GetCompareTo_Ljava_lang_Object_Handler()
		{
			if (IComparableTimeMarkInvoker.cb_compareTo_Ljava_lang_Object_ == null)
			{
				IComparableTimeMarkInvoker.cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IComparableTimeMarkInvoker.n_CompareTo_Ljava_lang_Object_));
			}
			return IComparableTimeMarkInvoker.cb_compareTo_Ljava_lang_Object_;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000ED84 File Offset: 0x0000CF84
		private static int n_CompareTo_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			Java.Lang.IComparable @object = Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public unsafe int CompareTo(Java.Lang.Object o)
		{
			if (this.id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Ljava/lang/Object;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Ljava_lang_Object_, ptr);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000EE1B File Offset: 0x0000D01B
		private static Delegate GetHasNotPassedNowHandler()
		{
			if (IComparableTimeMarkInvoker.cb_hasNotPassedNow == null)
			{
				IComparableTimeMarkInvoker.cb_hasNotPassedNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IComparableTimeMarkInvoker.n_HasNotPassedNow));
			}
			return IComparableTimeMarkInvoker.cb_hasNotPassedNow;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000EE3F File Offset: 0x0000D03F
		private static bool n_HasNotPassedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNotPassedNow;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000EE4E File Offset: 0x0000D04E
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

		// Token: 0x060005ED RID: 1517 RVA: 0x0000EE8E File Offset: 0x0000D08E
		private static Delegate GetHasPassedNowHandler()
		{
			if (IComparableTimeMarkInvoker.cb_hasPassedNow == null)
			{
				IComparableTimeMarkInvoker.cb_hasPassedNow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IComparableTimeMarkInvoker.n_HasPassedNow));
			}
			return IComparableTimeMarkInvoker.cb_hasPassedNow;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000EEB2 File Offset: 0x0000D0B2
		private static bool n_HasPassedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasPassedNow;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0000EEC1 File Offset: 0x0000D0C1
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

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000EF01 File Offset: 0x0000D101
		private static Delegate GetElapsedNowHandler()
		{
			if (IComparableTimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc == null)
			{
				IComparableTimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IComparableTimeMarkInvoker.n_ElapsedNow));
			}
			return IComparableTimeMarkInvoker.cb_elapsedNow_x45_UwyO8pc;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000EF25 File Offset: 0x0000D125
		private static long n_ElapsedNow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IComparableTimeMark>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ElapsedNow();
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000EF34 File Offset: 0x0000D134
		public long ElapsedNow()
		{
			if (this.id_elapsedNow_x45_UwyO8pc == IntPtr.Zero)
			{
				this.id_elapsedNow_x45_UwyO8pc = JNIEnv.GetMethodID(this.class_ref, "elapsedNow-UwyO8pc", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_elapsedNow_x45_UwyO8pc);
		}

		// Token: 0x0400018D RID: 397
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/ComparableTimeMark", typeof(IComparableTimeMarkInvoker));

		// Token: 0x0400018E RID: 398
		private IntPtr class_ref;

		// Token: 0x0400018F RID: 399
		[Nullable(2)]
		private static Delegate cb_compareTo_Lkotlin_time_ComparableTimeMark_;

		// Token: 0x04000190 RID: 400
		private IntPtr id_compareTo_Lkotlin_time_ComparableTimeMark_;

		// Token: 0x04000191 RID: 401
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000192 RID: 402
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000193 RID: 403
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000194 RID: 404
		private IntPtr id_hashCode;

		// Token: 0x04000195 RID: 405
		[Nullable(2)]
		private static Delegate cb_minus_x45_LRDsOJo_J;

		// Token: 0x04000196 RID: 406
		private IntPtr id_minus_x45_LRDsOJo_J;

		// Token: 0x04000197 RID: 407
		[Nullable(2)]
		private static Delegate cb_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_;

		// Token: 0x04000198 RID: 408
		private IntPtr id_minus_x45_UwyO8pc_Lkotlin_time_ComparableTimeMark_;

		// Token: 0x04000199 RID: 409
		[Nullable(2)]
		private static Delegate cb_plus_x45_LRDsOJo_J;

		// Token: 0x0400019A RID: 410
		private IntPtr id_plus_x45_LRDsOJo_J;

		// Token: 0x0400019B RID: 411
		[Nullable(2)]
		private static Delegate cb_compareTo_Ljava_lang_Object_;

		// Token: 0x0400019C RID: 412
		private IntPtr id_compareTo_Ljava_lang_Object_;

		// Token: 0x0400019D RID: 413
		[Nullable(2)]
		private static Delegate cb_hasNotPassedNow;

		// Token: 0x0400019E RID: 414
		private IntPtr id_hasNotPassedNow;

		// Token: 0x0400019F RID: 415
		[Nullable(2)]
		private static Delegate cb_hasPassedNow;

		// Token: 0x040001A0 RID: 416
		private IntPtr id_hasPassedNow;

		// Token: 0x040001A1 RID: 417
		[Nullable(2)]
		private static Delegate cb_elapsedNow_x45_UwyO8pc;

		// Token: 0x040001A2 RID: 418
		private IntPtr id_elapsedNow_x45_UwyO8pc;
	}
}
