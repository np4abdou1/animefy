using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x0200029D RID: 669
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ClosedRange", DoNotGenerateAcw = true)]
	internal class IClosedRangeInvoker : Java.Lang.Object, IClosedRange, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x000638A0 File Offset: 0x00061AA0
		private static IntPtr java_class_ref
		{
			get
			{
				return IClosedRangeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x000638C4 File Offset: 0x00061AC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClosedRangeInvoker._members;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x000638CB File Offset: 0x00061ACB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x000638D3 File Offset: 0x00061AD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClosedRangeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x000638DF File Offset: 0x00061ADF
		[NullableContext(2)]
		public static IClosedRange GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClosedRange>(handle, transfer);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000638E8 File Offset: 0x00061AE8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClosedRangeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ranges.ClosedRange'.");
			}
			return handle;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00063913 File Offset: 0x00061B13
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00063944 File Offset: 0x00061B44
		public IClosedRangeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClosedRangeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0006397C File Offset: 0x00061B7C
		private static Delegate GetGetEndInclusiveHandler()
		{
			if (IClosedRangeInvoker.cb_getEndInclusive == null)
			{
				IClosedRangeInvoker.cb_getEndInclusive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClosedRangeInvoker.n_GetEndInclusive));
			}
			return IClosedRangeInvoker.cb_getEndInclusive;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000639A0 File Offset: 0x00061BA0
		private static IntPtr n_GetEndInclusive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClosedRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndInclusive);
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000639B4 File Offset: 0x00061BB4
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

		// Token: 0x06001E22 RID: 7714 RVA: 0x00063A05 File Offset: 0x00061C05
		private static Delegate GetIsEmptyHandler()
		{
			if (IClosedRangeInvoker.cb_isEmpty == null)
			{
				IClosedRangeInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IClosedRangeInvoker.n_IsEmpty));
			}
			return IClosedRangeInvoker.cb_isEmpty;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00063A29 File Offset: 0x00061C29
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IClosedRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00063A38 File Offset: 0x00061C38
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

		// Token: 0x06001E25 RID: 7717 RVA: 0x00063A78 File Offset: 0x00061C78
		private static Delegate GetGetStartHandler()
		{
			if (IClosedRangeInvoker.cb_getStart == null)
			{
				IClosedRangeInvoker.cb_getStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IClosedRangeInvoker.n_GetStart));
			}
			return IClosedRangeInvoker.cb_getStart;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00063A9C File Offset: 0x00061C9C
		private static IntPtr n_GetStart(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IClosedRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start);
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x00063AB0 File Offset: 0x00061CB0
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

		// Token: 0x06001E28 RID: 7720 RVA: 0x00063B01 File Offset: 0x00061D01
		private static Delegate GetContains_Ljava_lang_Comparable_Handler()
		{
			if (IClosedRangeInvoker.cb_contains_Ljava_lang_Comparable_ == null)
			{
				IClosedRangeInvoker.cb_contains_Ljava_lang_Comparable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IClosedRangeInvoker.n_Contains_Ljava_lang_Comparable_));
			}
			return IClosedRangeInvoker.cb_contains_Ljava_lang_Comparable_;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00063B28 File Offset: 0x00061D28
		private static bool n_Contains_Ljava_lang_Comparable_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IClosedRange @object = Java.Lang.Object.GetObject<IClosedRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00063B4C File Offset: 0x00061D4C
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

		// Token: 0x04000924 RID: 2340
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ClosedRange", typeof(IClosedRangeInvoker));

		// Token: 0x04000925 RID: 2341
		private IntPtr class_ref;

		// Token: 0x04000926 RID: 2342
		[Nullable(2)]
		private static Delegate cb_getEndInclusive;

		// Token: 0x04000927 RID: 2343
		private IntPtr id_getEndInclusive;

		// Token: 0x04000928 RID: 2344
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000929 RID: 2345
		private IntPtr id_isEmpty;

		// Token: 0x0400092A RID: 2346
		[Nullable(2)]
		private static Delegate cb_getStart;

		// Token: 0x0400092B RID: 2347
		private IntPtr id_getStart;

		// Token: 0x0400092C RID: 2348
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Comparable_;

		// Token: 0x0400092D RID: 2349
		private IntPtr id_contains_Ljava_lang_Comparable_;
	}
}
