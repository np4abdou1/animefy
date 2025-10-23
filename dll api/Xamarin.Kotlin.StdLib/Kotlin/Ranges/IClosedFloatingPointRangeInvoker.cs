using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x0200029A RID: 666
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ClosedFloatingPointRange", DoNotGenerateAcw = true)]
	internal class IClosedFloatingPointRangeInvoker : Java.Lang.Object, IClosedFloatingPointRange, IClosedRange, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00063300 File Offset: 0x00061500
		private static IntPtr java_class_ref
		{
			get
			{
				return IClosedFloatingPointRangeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00063324 File Offset: 0x00061524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClosedFloatingPointRangeInvoker._members;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0006332B File Offset: 0x0006152B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00063333 File Offset: 0x00061533
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClosedFloatingPointRangeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0006333F File Offset: 0x0006153F
		[NullableContext(2)]
		public static IClosedFloatingPointRange GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClosedFloatingPointRange>(handle, transfer);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00063348 File Offset: 0x00061548
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClosedFloatingPointRangeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ranges.ClosedFloatingPointRange'.");
			}
			return handle;
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00063373 File Offset: 0x00061573
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000633A4 File Offset: 0x000615A4
		public IClosedFloatingPointRangeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClosedFloatingPointRangeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x000633DC File Offset: 0x000615DC
		private static Delegate GetIsEmptyHandler()
		{
			if (IClosedFloatingPointRangeInvoker.cb_isEmpty == null)
			{
				IClosedFloatingPointRangeInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IClosedFloatingPointRangeInvoker.n_IsEmpty));
			}
			return IClosedFloatingPointRangeInvoker.cb_isEmpty;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00063400 File Offset: 0x00061600
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IClosedFloatingPointRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0006340F File Offset: 0x0006160F
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0006344F File Offset: 0x0006164F
		private static Delegate GetContains_Ljava_lang_Comparable_Handler()
		{
			if (IClosedFloatingPointRangeInvoker.cb_contains_Ljava_lang_Comparable_ == null)
			{
				IClosedFloatingPointRangeInvoker.cb_contains_Ljava_lang_Comparable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IClosedFloatingPointRangeInvoker.n_Contains_Ljava_lang_Comparable_));
			}
			return IClosedFloatingPointRangeInvoker.cb_contains_Ljava_lang_Comparable_;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00063474 File Offset: 0x00061674
		private static bool n_Contains_Ljava_lang_Comparable_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IClosedFloatingPointRange @object = Java.Lang.Object.GetObject<IClosedFloatingPointRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00063498 File Offset: 0x00061698
		public unsafe bool Contains(Java.Lang.Object value)
		{
			if (this.id_contains_Ljava_lang_Comparable_ == IntPtr.Zero)
			{
				this.id_contains_Ljava_lang_Comparable_ = JNIEnv.GetMethodID(this.class_ref, "contains", "(Ljava/lang/Comparable;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_contains_Ljava_lang_Comparable_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00063509 File Offset: 0x00061709
		private static Delegate GetLessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_Handler()
		{
			if (IClosedFloatingPointRangeInvoker.cb_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_ == null)
			{
				IClosedFloatingPointRangeInvoker.cb_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IClosedFloatingPointRangeInvoker.n_LessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_));
			}
			return IClosedFloatingPointRangeInvoker.cb_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00063530 File Offset: 0x00061730
		private static bool n_LessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_(IntPtr jnienv, IntPtr native__this, IntPtr native_a, IntPtr native_b)
		{
			IClosedFloatingPointRange @object = Java.Lang.Object.GetObject<IClosedFloatingPointRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_a, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_b, JniHandleOwnership.DoNotTransfer);
			return @object.LessThanOrEquals(object2, object3);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0006355C File Offset: 0x0006175C
		public unsafe bool LessThanOrEquals(Java.Lang.Object a, Java.Lang.Object b)
		{
			if (this.id_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_ == IntPtr.Zero)
			{
				this.id_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_ = JNIEnv.GetMethodID(this.class_ref, "lessThanOrEquals", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(a);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(b);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000635ED File Offset: 0x000617ED
		private static Delegate GetGetEndInclusiveHandler()
		{
			if (IClosedFloatingPointRangeInvoker.cb_getEndInclusive == null)
			{
				IClosedFloatingPointRangeInvoker.cb_getEndInclusive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClosedFloatingPointRangeInvoker.n_GetEndInclusive));
			}
			return IClosedFloatingPointRangeInvoker.cb_getEndInclusive;
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00063611 File Offset: 0x00061811
		private static IntPtr n_GetEndInclusive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClosedFloatingPointRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndInclusive);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00063628 File Offset: 0x00061828
		public Java.Lang.Object EndInclusive
		{
			get
			{
				if (this.id_getEndInclusive == IntPtr.Zero)
				{
					this.id_getEndInclusive = JNIEnv.GetMethodID(this.class_ref, "getEndInclusive", "()Ljava/lang/Comparable;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getEndInclusive), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00063679 File Offset: 0x00061879
		private static Delegate GetGetStartHandler()
		{
			if (IClosedFloatingPointRangeInvoker.cb_getStart == null)
			{
				IClosedFloatingPointRangeInvoker.cb_getStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClosedFloatingPointRangeInvoker.n_GetStart));
			}
			return IClosedFloatingPointRangeInvoker.cb_getStart;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0006369D File Offset: 0x0006189D
		private static IntPtr n_GetStart(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClosedFloatingPointRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start);
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000636B4 File Offset: 0x000618B4
		public Java.Lang.Object Start
		{
			get
			{
				if (this.id_getStart == IntPtr.Zero)
				{
					this.id_getStart = JNIEnv.GetMethodID(this.class_ref, "getStart", "()Ljava/lang/Comparable;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getStart), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000917 RID: 2327
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ClosedFloatingPointRange", typeof(IClosedFloatingPointRangeInvoker));

		// Token: 0x04000918 RID: 2328
		private IntPtr class_ref;

		// Token: 0x04000919 RID: 2329
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x0400091A RID: 2330
		private IntPtr id_isEmpty;

		// Token: 0x0400091B RID: 2331
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Comparable_;

		// Token: 0x0400091C RID: 2332
		private IntPtr id_contains_Ljava_lang_Comparable_;

		// Token: 0x0400091D RID: 2333
		[Nullable(2)]
		private static Delegate cb_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_;

		// Token: 0x0400091E RID: 2334
		private IntPtr id_lessThanOrEquals_Ljava_lang_Comparable_Ljava_lang_Comparable_;

		// Token: 0x0400091F RID: 2335
		[Nullable(2)]
		private static Delegate cb_getEndInclusive;

		// Token: 0x04000920 RID: 2336
		private IntPtr id_getEndInclusive;

		// Token: 0x04000921 RID: 2337
		[Nullable(2)]
		private static Delegate cb_getStart;

		// Token: 0x04000922 RID: 2338
		private IntPtr id_getStart;
	}
}
