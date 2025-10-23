using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Ranges
{
	// Token: 0x020002A2 RID: 674
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/OpenEndRange", DoNotGenerateAcw = true)]
	internal class IOpenEndRangeInvoker : Java.Lang.Object, IOpenEndRange, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0006418C File Offset: 0x0006238C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOpenEndRangeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x000641B0 File Offset: 0x000623B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOpenEndRangeInvoker._members;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x000641B7 File Offset: 0x000623B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x000641BF File Offset: 0x000623BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOpenEndRangeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000641CB File Offset: 0x000623CB
		[NullableContext(2)]
		public static IOpenEndRange GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOpenEndRange>(handle, transfer);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000641D4 File Offset: 0x000623D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOpenEndRangeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ranges.OpenEndRange'.");
			}
			return handle;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000641FF File Offset: 0x000623FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00064230 File Offset: 0x00062430
		public IOpenEndRangeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOpenEndRangeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00064268 File Offset: 0x00062468
		private static Delegate GetGetEndExclusiveHandler()
		{
			if (IOpenEndRangeInvoker.cb_getEndExclusive == null)
			{
				IOpenEndRangeInvoker.cb_getEndExclusive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOpenEndRangeInvoker.n_GetEndExclusive));
			}
			return IOpenEndRangeInvoker.cb_getEndExclusive;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0006428C File Offset: 0x0006248C
		private static IntPtr n_GetEndExclusive(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOpenEndRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndExclusive);
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x000642A0 File Offset: 0x000624A0
		public Java.Lang.Object EndExclusive
		{
			get
			{
				if (this.id_getEndExclusive == IntPtr.Zero)
				{
					this.id_getEndExclusive = JNIEnv.GetMethodID(this.class_ref, "getEndExclusive", "()Ljava/lang/Comparable;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getEndExclusive), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000642F1 File Offset: 0x000624F1
		private static Delegate GetIsEmptyHandler()
		{
			if (IOpenEndRangeInvoker.cb_isEmpty == null)
			{
				IOpenEndRangeInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IOpenEndRangeInvoker.n_IsEmpty));
			}
			return IOpenEndRangeInvoker.cb_isEmpty;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00064315 File Offset: 0x00062515
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOpenEndRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00064324 File Offset: 0x00062524
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

		// Token: 0x06001E68 RID: 7784 RVA: 0x00064364 File Offset: 0x00062564
		private static Delegate GetGetStartHandler()
		{
			if (IOpenEndRangeInvoker.cb_getStart == null)
			{
				IOpenEndRangeInvoker.cb_getStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOpenEndRangeInvoker.n_GetStart));
			}
			return IOpenEndRangeInvoker.cb_getStart;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00064388 File Offset: 0x00062588
		private static IntPtr n_GetStart(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOpenEndRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0006439C File Offset: 0x0006259C
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

		// Token: 0x06001E6B RID: 7787 RVA: 0x000643ED File Offset: 0x000625ED
		private static Delegate GetContains_Ljava_lang_Comparable_Handler()
		{
			if (IOpenEndRangeInvoker.cb_contains_Ljava_lang_Comparable_ == null)
			{
				IOpenEndRangeInvoker.cb_contains_Ljava_lang_Comparable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IOpenEndRangeInvoker.n_Contains_Ljava_lang_Comparable_));
			}
			return IOpenEndRangeInvoker.cb_contains_Ljava_lang_Comparable_;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00064414 File Offset: 0x00062614
		private static bool n_Contains_Ljava_lang_Comparable_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IOpenEndRange @object = Java.Lang.Object.GetObject<IOpenEndRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00064438 File Offset: 0x00062638
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

		// Token: 0x04000933 RID: 2355
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/OpenEndRange", typeof(IOpenEndRangeInvoker));

		// Token: 0x04000934 RID: 2356
		private IntPtr class_ref;

		// Token: 0x04000935 RID: 2357
		[Nullable(2)]
		private static Delegate cb_getEndExclusive;

		// Token: 0x04000936 RID: 2358
		private IntPtr id_getEndExclusive;

		// Token: 0x04000937 RID: 2359
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000938 RID: 2360
		private IntPtr id_isEmpty;

		// Token: 0x04000939 RID: 2361
		[Nullable(2)]
		private static Delegate cb_getStart;

		// Token: 0x0400093A RID: 2362
		private IntPtr id_getStart;

		// Token: 0x0400093B RID: 2363
		[Nullable(2)]
		private static Delegate cb_contains_Ljava_lang_Comparable_;

		// Token: 0x0400093C RID: 2364
		private IntPtr id_contains_Ljava_lang_Comparable_;
	}
}
