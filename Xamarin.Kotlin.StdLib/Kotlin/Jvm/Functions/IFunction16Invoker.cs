using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001F7 RID: 503
	[Register("kotlin/jvm/functions/Function16", DoNotGenerateAcw = true)]
	internal class IFunction16Invoker : Java.Lang.Object, IFunction16, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x0004F498 File Offset: 0x0004D698
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction16Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0004F4BC File Offset: 0x0004D6BC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction16Invoker._members;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0004F4C3 File Offset: 0x0004D6C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0004F4CB File Offset: 0x0004D6CB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction16Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0004F4D7 File Offset: 0x0004D6D7
		[NullableContext(2)]
		public static IFunction16 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction16>(handle, transfer);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0004F4E0 File Offset: 0x0004D6E0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction16Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function16'.");
			}
			return handle;
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0004F50B File Offset: 0x0004D70B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0004F53C File Offset: 0x0004D73C
		public IFunction16Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction16Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0004F574 File Offset: 0x0004D774
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction16Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction16Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLLLLLLLLLLLLL_L(IFunction16Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction16Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0004F598 File Offset: 0x0004D798
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11, IntPtr native_p12, IntPtr native_p13, IntPtr native_p14, IntPtr native_p15)
		{
			IFunction16 @object = Java.Lang.Object.GetObject<IFunction16>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object5 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p3, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object6 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p4, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object7 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p5, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object8 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p6, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object9 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p7, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object10 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p8, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object11 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p9, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object12 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p10, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object13 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p11, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object14 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p12, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object15 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p13, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object16 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p14, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object17 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p15, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4, object5, object6, object7, object8, object9, object10, object11, object12, object13, object14, object15, object16, object17));
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0004F670 File Offset: 0x0004D870
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12, Java.Lang.Object p13, Java.Lang.Object p14, Java.Lang.Object p15)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(p2);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(p3);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(p4);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(p5);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(p6);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(p7);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(p8);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(p9);
			IntPtr intPtr11 = JNIEnv.ToLocalJniHandle(p10);
			IntPtr intPtr12 = JNIEnv.ToLocalJniHandle(p11);
			IntPtr intPtr13 = JNIEnv.ToLocalJniHandle(p12);
			IntPtr intPtr14 = JNIEnv.ToLocalJniHandle(p13);
			IntPtr intPtr15 = JNIEnv.ToLocalJniHandle(p14);
			IntPtr intPtr16 = JNIEnv.ToLocalJniHandle(p15);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			ptr[3] = new JValue(intPtr4);
			ptr[4] = new JValue(intPtr5);
			ptr[5] = new JValue(intPtr6);
			ptr[6] = new JValue(intPtr7);
			ptr[7] = new JValue(intPtr8);
			ptr[8] = new JValue(intPtr9);
			ptr[9] = new JValue(intPtr10);
			ptr[10] = new JValue(intPtr11);
			ptr[11] = new JValue(intPtr12);
			ptr[12] = new JValue(intPtr13);
			ptr[13] = new JValue(intPtr14);
			ptr[14] = new JValue(intPtr15);
			ptr[15] = new JValue(intPtr16);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
			JNIEnv.DeleteLocalRef(intPtr4);
			JNIEnv.DeleteLocalRef(intPtr5);
			JNIEnv.DeleteLocalRef(intPtr6);
			JNIEnv.DeleteLocalRef(intPtr7);
			JNIEnv.DeleteLocalRef(intPtr8);
			JNIEnv.DeleteLocalRef(intPtr9);
			JNIEnv.DeleteLocalRef(intPtr10);
			JNIEnv.DeleteLocalRef(intPtr11);
			JNIEnv.DeleteLocalRef(intPtr12);
			JNIEnv.DeleteLocalRef(intPtr13);
			JNIEnv.DeleteLocalRef(intPtr14);
			JNIEnv.DeleteLocalRef(intPtr15);
			JNIEnv.DeleteLocalRef(intPtr16);
			return @object;
		}

		// Token: 0x0400077D RID: 1917
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function16", typeof(IFunction16Invoker));

		// Token: 0x0400077E RID: 1918
		private IntPtr class_ref;

		// Token: 0x0400077F RID: 1919
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000780 RID: 1920
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
