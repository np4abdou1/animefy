using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x02000207 RID: 519
	[Register("kotlin/jvm/functions/Function3", DoNotGenerateAcw = true)]
	internal class IFunction3Invoker : Java.Lang.Object, IFunction3, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00051C1C File Offset: 0x0004FE1C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction3Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00051C40 File Offset: 0x0004FE40
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction3Invoker._members;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00051C47 File Offset: 0x0004FE47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00051C4F File Offset: 0x0004FE4F
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction3Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00051C5B File Offset: 0x0004FE5B
		[NullableContext(2)]
		public static IFunction3 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction3>(handle, transfer);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00051C64 File Offset: 0x0004FE64
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction3Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function3'.");
			}
			return handle;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00051C8F File Offset: 0x0004FE8F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		public IFunction3Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction3Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00051CF8 File Offset: 0x0004FEF8
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction3Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction3Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IFunction3Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction3Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00051D1C File Offset: 0x0004FF1C
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IFunction3 @object = Java.Lang.Object.GetObject<IFunction3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, object4));
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00051D58 File Offset: 0x0004FF58
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
			return @object;
		}

		// Token: 0x0400079D RID: 1949
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function3", typeof(IFunction3Invoker));

		// Token: 0x0400079E RID: 1950
		private IntPtr class_ref;

		// Token: 0x0400079F RID: 1951
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040007A0 RID: 1952
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
