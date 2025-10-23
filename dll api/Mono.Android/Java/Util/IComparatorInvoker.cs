using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000309 RID: 777
	[Register("java/util/Comparator", DoNotGenerateAcw = true)]
	internal class IComparatorInvoker : Java.Lang.Object, IComparator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00055EE8 File Offset: 0x000540E8
		private static IntPtr java_class_ref
		{
			get
			{
				return IComparatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00055F0C File Offset: 0x0005410C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComparatorInvoker._members;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00055F13 File Offset: 0x00054113
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x00055F1B File Offset: 0x0005411B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComparatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00055F27 File Offset: 0x00054127
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComparatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Comparator'.");
			}
			return handle;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00055F52 File Offset: 0x00054152
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00055F84 File Offset: 0x00054184
		public IComparatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComparatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00055FBC File Offset: 0x000541BC
		private static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IComparatorInvoker.cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IComparatorInvoker.cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(IComparatorInvoker.n_Compare_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IComparatorInvoker.cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00055FE0 File Offset: 0x000541E0
		private static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o1, IntPtr native_o2)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o2, JniHandleOwnership.DoNotTransfer);
			return @object.Compare(object2, object3);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0005600C File Offset: 0x0005420C
		public unsafe int Compare(Java.Lang.Object o1, Java.Lang.Object o2)
		{
			if (this.id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(o1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(o2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_compare_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return result;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0005609D File Offset: 0x0005429D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IComparatorInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IComparatorInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IComparatorInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IComparatorInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000560C4 File Offset: 0x000542C4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IComparator @object = Java.Lang.Object.GetObject<IComparator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x000560E8 File Offset: 0x000542E8
		public new unsafe bool Equals(Java.Lang.Object obj)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x04000CDF RID: 3295
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Comparator", typeof(IComparatorInvoker));

		// Token: 0x04000CE0 RID: 3296
		private IntPtr class_ref;

		// Token: 0x04000CE1 RID: 3297
		private static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CE2 RID: 3298
		private IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000CE3 RID: 3299
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000CE4 RID: 3300
		private IntPtr id_equals_Ljava_lang_Object_;
	}
}
