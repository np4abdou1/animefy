using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001F1 RID: 497
	[Register("kotlin/jvm/functions/Function13", DoNotGenerateAcw = true)]
	internal class IFunction13Invoker : Java.Lang.Object, IFunction13, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0004E794 File Offset: 0x0004C994
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction13Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0004E7B8 File Offset: 0x0004C9B8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction13Invoker._members;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0004E7BF File Offset: 0x0004C9BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0004E7C7 File Offset: 0x0004C9C7
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction13Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0004E7D3 File Offset: 0x0004C9D3
		[NullableContext(2)]
		public static IFunction13 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction13>(handle, transfer);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0004E7DC File Offset: 0x0004C9DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction13Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function13'.");
			}
			return handle;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0004E807 File Offset: 0x0004CA07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0004E838 File Offset: 0x0004CA38
		public IFunction13Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction13Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0004E870 File Offset: 0x0004CA70
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction13Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction13Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLLLLLLLLLL_L(IFunction13Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction13Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0004E894 File Offset: 0x0004CA94
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11, IntPtr native_p12)
		{
			IFunction13 @object = Java.Lang.Object.GetObject<IFunction13>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4, object5, object6, object7, object8, object9, object10, object11, object12, object13, object14));
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0004E948 File Offset: 0x0004CB48
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
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
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(JValue))];
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
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
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
			return @object;
		}

		// Token: 0x04000771 RID: 1905
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function13", typeof(IFunction13Invoker));

		// Token: 0x04000772 RID: 1906
		private IntPtr class_ref;

		// Token: 0x04000773 RID: 1907
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000774 RID: 1908
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
