using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;

namespace Com.Unity3d.Services.Core.Reflection
{
	// Token: 0x020000C8 RID: 200
	[Register("com/unity3d/services/core/reflection/GenericListenerProxy", DoNotGenerateAcw = true)]
	public abstract class GenericListenerProxy : Java.Lang.Object, IInvocationHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x000165F4 File Offset: 0x000147F4
		internal static IntPtr class_ref
		{
			get
			{
				return GenericListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00016618 File Offset: 0x00014818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GenericListenerProxy._members;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00016620 File Offset: 0x00014820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GenericListenerProxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00016644 File Offset: 0x00014844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GenericListenerProxy._members.ManagedPeerType;
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GenericListenerProxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00016650 File Offset: 0x00014850
		[Register(".ctor", "()V", "")]
		public GenericListenerProxy() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GenericListenerProxy._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GenericListenerProxy._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000166BE File Offset: 0x000148BE
		private static Delegate GetGetProxyClassHandler()
		{
			if (GenericListenerProxy.cb_getProxyClass == null)
			{
				GenericListenerProxy.cb_getProxyClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GenericListenerProxy.n_GetProxyClass));
			}
			return GenericListenerProxy.cb_getProxyClass;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000166E2 File Offset: 0x000148E2
		private static IntPtr n_GetProxyClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GenericListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyClass);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007D2 RID: 2002
		public abstract Class ProxyClass { [Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")] get; }

		// Token: 0x060007D3 RID: 2003 RVA: 0x000166F6 File Offset: 0x000148F6
		private static Delegate GetGetProxyInstanceHandler()
		{
			if (GenericListenerProxy.cb_getProxyInstance == null)
			{
				GenericListenerProxy.cb_getProxyInstance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GenericListenerProxy.n_GetProxyInstance));
			}
			return GenericListenerProxy.cb_getProxyInstance;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001671A File Offset: 0x0001491A
		private static IntPtr n_GetProxyInstance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GenericListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProxyInstance);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00016730 File Offset: 0x00014930
		public virtual Java.Lang.Object ProxyInstance
		{
			[Register("getProxyInstance", "()Ljava/lang/Object;", "GetGetProxyInstanceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(GenericListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("getProxyInstance.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00016762 File Offset: 0x00014962
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler()
		{
			if (GenericListenerProxy.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
			{
				GenericListenerProxy.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(GenericListenerProxy.n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_));
			}
			return GenericListenerProxy.cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00016788 File Offset: 0x00014988
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_proxy, IntPtr native_m, IntPtr native_args)
		{
			GenericListenerProxy @object = Java.Lang.Object.GetObject<GenericListenerProxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_proxy, JniHandleOwnership.DoNotTransfer);
			Method object3 = Java.Lang.Object.GetObject<Method>(native_m, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3, array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000167E0 File Offset: 0x000149E0
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Invoke(Java.Lang.Object proxy, Method m, Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(args);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((proxy == null) ? IntPtr.Zero : proxy.Handle);
				ptr[1] = new JniArgumentValue((m == null) ? IntPtr.Zero : m.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(GenericListenerProxy._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, args);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(proxy);
				GC.KeepAlive(m);
				GC.KeepAlive(args);
			}
			return @object;
		}

		// Token: 0x040001E1 RID: 481
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/reflection/GenericListenerProxy", typeof(GenericListenerProxy));

		// Token: 0x040001E2 RID: 482
		private static Delegate cb_getProxyClass;

		// Token: 0x040001E3 RID: 483
		private static Delegate cb_getProxyInstance;

		// Token: 0x040001E4 RID: 484
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
	}
}
