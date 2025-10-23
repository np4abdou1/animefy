using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x02000215 RID: 533
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/functions/FunctionN", DoNotGenerateAcw = true)]
	internal class IFunctionNInvoker : Java.Lang.Object, IFunctionN, IFunction, IJavaObject, IDisposable, IJavaPeerable, IFunctionBase
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x00052EEC File Offset: 0x000510EC
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunctionNInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00052F10 File Offset: 0x00051110
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFunctionNInvoker._members;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x00052F17 File Offset: 0x00051117
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00052F1F File Offset: 0x0005111F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFunctionNInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00052F2B File Offset: 0x0005112B
		[NullableContext(2)]
		public static IFunctionN GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunctionN>(handle, transfer);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00052F34 File Offset: 0x00051134
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunctionNInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.FunctionN'.");
			}
			return handle;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00052F5F File Offset: 0x0005115F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00052F90 File Offset: 0x00051190
		public IFunctionNInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunctionNInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00052FC8 File Offset: 0x000511C8
		private static Delegate GetGetArityHandler()
		{
			if (IFunctionNInvoker.cb_getArity == null)
			{
				IFunctionNInvoker.cb_getArity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFunctionNInvoker.n_GetArity));
			}
			return IFunctionNInvoker.cb_getArity;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00052FEC File Offset: 0x000511EC
		private static int n_GetArity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFunctionN>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arity;
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00052FFB File Offset: 0x000511FB
		public int Arity
		{
			get
			{
				if (this.id_getArity == IntPtr.Zero)
				{
					this.id_getArity = JNIEnv.GetMethodID(this.class_ref, "getArity", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getArity);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0005303B File Offset: 0x0005123B
		private static Delegate GetInvoke_arrayLjava_lang_Object_Handler()
		{
			if (IFunctionNInvoker.cb_invoke_arrayLjava_lang_Object_ == null)
			{
				IFunctionNInvoker.cb_invoke_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunctionNInvoker.n_Invoke_arrayLjava_lang_Object_));
			}
			return IFunctionNInvoker.cb_invoke_arrayLjava_lang_Object_;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00053060 File Offset: 0x00051260
		private static IntPtr n_Invoke_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			IFunctionN @object = Java.Lang.Object.GetObject<IFunctionN>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Invoke(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_args);
			}
			return result;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000530A4 File Offset: 0x000512A4
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Invoke(params Java.Lang.Object[] args)
		{
			if (this.id_invoke_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(args);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_arrayLjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			if (args != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, args);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x040007B9 RID: 1977
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/FunctionN", typeof(IFunctionNInvoker));

		// Token: 0x040007BA RID: 1978
		private IntPtr class_ref;

		// Token: 0x040007BB RID: 1979
		[Nullable(2)]
		private static Delegate cb_getArity;

		// Token: 0x040007BC RID: 1980
		private IntPtr id_getArity;

		// Token: 0x040007BD RID: 1981
		[Nullable(2)]
		private static Delegate cb_invoke_arrayLjava_lang_Object_;

		// Token: 0x040007BE RID: 1982
		private IntPtr id_invoke_arrayLjava_lang_Object_;
	}
}
