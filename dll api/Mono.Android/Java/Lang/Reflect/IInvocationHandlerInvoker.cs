using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000404 RID: 1028
	[Register("java/lang/reflect/InvocationHandler", DoNotGenerateAcw = true)]
	internal class IInvocationHandlerInvoker : Object, IInvocationHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0007C99C File Offset: 0x0007AB9C
		private static IntPtr java_class_ref
		{
			get
			{
				return IInvocationHandlerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x0007C9C0 File Offset: 0x0007ABC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInvocationHandlerInvoker._members;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0007C9C7 File Offset: 0x0007ABC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x0007C9CF File Offset: 0x0007ABCF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInvocationHandlerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x0007C9DB File Offset: 0x0007ABDB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInvocationHandlerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.reflect.InvocationHandler'.");
			}
			return handle;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x0007CA06 File Offset: 0x0007AC06
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x0007CA38 File Offset: 0x0007AC38
		public IInvocationHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInvocationHandlerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x0007CA70 File Offset: 0x0007AC70
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler()
		{
			if (IInvocationHandlerInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
			{
				IInvocationHandlerInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IInvocationHandlerInvoker.n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_));
			}
			return IInvocationHandlerInvoker.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0007CA94 File Offset: 0x0007AC94
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_proxy, IntPtr native_method, IntPtr native_args)
		{
			IInvocationHandler @object = Object.GetObject<IInvocationHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Object object2 = Object.GetObject<Object>(native_proxy, JniHandleOwnership.DoNotTransfer);
			Method object3 = Object.GetObject<Method>(native_method, JniHandleOwnership.DoNotTransfer);
			Object[] array = (Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, array));
			if (array != null)
			{
				JNIEnv.CopyArray<Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		public unsafe Object Invoke(Object proxy, Method method, Object[] args)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewArray<Object>(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((proxy == null) ? IntPtr.Zero : proxy.Handle);
			ptr[1] = new JValue((method == null) ? IntPtr.Zero : method.Handle);
			ptr[2] = new JValue(intPtr);
			Object @object = Object.GetObject<Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			if (args != null)
			{
				JNIEnv.CopyArray<Object>(intPtr, args);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x040011DA RID: 4570
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/InvocationHandler", typeof(IInvocationHandlerInvoker));

		// Token: 0x040011DB RID: 4571
		private IntPtr class_ref;

		// Token: 0x040011DC RID: 4572
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;

		// Token: 0x040011DD RID: 4573
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
	}
}
