using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001FD RID: 509
	[Register("kotlin/jvm/functions/Function19", DoNotGenerateAcw = true)]
	internal class IFunction19Invoker : Java.Lang.Object, IFunction19, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00050378 File Offset: 0x0004E578
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction19Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x0005039C File Offset: 0x0004E59C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction19Invoker._members;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000503A3 File Offset: 0x0004E5A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000503AB File Offset: 0x0004E5AB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction19Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000503B7 File Offset: 0x0004E5B7
		[NullableContext(2)]
		public static IFunction19 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction19>(handle, transfer);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000503C0 File Offset: 0x0004E5C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction19Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function19'.");
			}
			return handle;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000503EB File Offset: 0x0004E5EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0005041C File Offset: 0x0004E61C
		public IFunction19Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction19Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00050454 File Offset: 0x0004E654
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction19Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction19Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLLLLLLLLLLLLLLLL_L(IFunction19Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction19Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00050478 File Offset: 0x0004E678
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10, IntPtr native_p11, IntPtr native_p12, IntPtr native_p13, IntPtr native_p14, IntPtr native_p15, IntPtr native_p16, IntPtr native_p17, IntPtr native_p18)
		{
			IFunction19 @object = Java.Lang.Object.GetObject<IFunction19>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4, object5, object6, object7, object8, object9, object10, object11, object12, object13, object14, object15, object16, object17, object18, object19, object20));
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00050574 File Offset: 0x0004E774
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2, Java.Lang.Object p3, Java.Lang.Object p4, Java.Lang.Object p5, Java.Lang.Object p6, Java.Lang.Object p7, Java.Lang.Object p8, Java.Lang.Object p9, Java.Lang.Object p10, Java.Lang.Object p11, Java.Lang.Object p12, Java.Lang.Object p13, Java.Lang.Object p14, Java.Lang.Object p15, Java.Lang.Object p16, Java.Lang.Object p17, Java.Lang.Object p18)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
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
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(JValue))];
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
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
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
			return @object;
		}

		// Token: 0x04000789 RID: 1929
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function19", typeof(IFunction19Invoker));

		// Token: 0x0400078A RID: 1930
		private IntPtr class_ref;

		// Token: 0x0400078B RID: 1931
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400078C RID: 1932
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
