using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x02000201 RID: 513
	[Register("kotlin/jvm/functions/Function20", DoNotGenerateAcw = true)]
	internal class IFunction20Invoker : Java.Lang.Object, IFunction20, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction20Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00050AE4 File Offset: 0x0004ECE4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction20Invoker._members;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00050AEB File Offset: 0x0004ECEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00050AF3 File Offset: 0x0004ECF3
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction20Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00050AFF File Offset: 0x0004ECFF
		[NullableContext(2)]
		public static IFunction20 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction20>(handle, transfer);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00050B08 File Offset: 0x0004ED08
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction20Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function20'.");
			}
			return handle;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00050B33 File Offset: 0x0004ED33
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00050B64 File Offset: 0x0004ED64
		public IFunction20Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction20Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00050B9C File Offset: 0x0004ED9C
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction20Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction20Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLLLLLLLLLLLLLLLLL_L(IFunction20Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction20Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00050BC0 File Offset: 0x0004EDC0
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11, IntPtr native_p12, IntPtr native_p13, IntPtr native_p14, IntPtr native_p15, IntPtr native_p16, IntPtr native_p17, IntPtr native_p18, IntPtr native_p19)
		{
			IFunction20 @object = Java.Lang.Object.GetObject<IFunction20>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			Java.Lang.Object object18 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p16, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object19 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p17, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object20 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p18, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object21 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p19, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4, object5, object6, object7, object8, object9, object10, object11, object12, object13, object14, object15, object16, object17, object18, object19, object20, object21));
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00050CC8 File Offset: 0x0004EEC8
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12, Java.Lang.Object p13, Java.Lang.Object p14, Java.Lang.Object p15, Java.Lang.Object p16, Java.Lang.Object p17, Java.Lang.Object p18, Java.Lang.Object p19)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
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
			IntPtr intPtr17 = JNIEnv.ToLocalJniHandle(p16);
			IntPtr intPtr18 = JNIEnv.ToLocalJniHandle(p17);
			IntPtr intPtr19 = JNIEnv.ToLocalJniHandle(p18);
			IntPtr intPtr20 = JNIEnv.ToLocalJniHandle(p19);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(JValue))];
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
			ptr[16] = new JValue(intPtr17);
			ptr[17] = new JValue(intPtr18);
			ptr[18] = new JValue(intPtr19);
			ptr[19] = new JValue(intPtr20);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
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
			JNIEnv.DeleteLocalRef(intPtr17);
			JNIEnv.DeleteLocalRef(intPtr18);
			JNIEnv.DeleteLocalRef(intPtr19);
			JNIEnv.DeleteLocalRef(intPtr20);
			return @object;
		}

		// Token: 0x04000791 RID: 1937
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function20", typeof(IFunction20Invoker));

		// Token: 0x04000792 RID: 1938
		private IntPtr class_ref;

		// Token: 0x04000793 RID: 1939
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000794 RID: 1940
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
