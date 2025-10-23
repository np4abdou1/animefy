using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000092 RID: 146
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectBuilder", DoNotGenerateAcw = true)]
	internal class ISelectBuilderInvoker : Java.Lang.Object, ISelectBuilder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000150A8 File Offset: 0x000132A8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectBuilderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000150CC File Offset: 0x000132CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectBuilderInvoker._members;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000150D3 File Offset: 0x000132D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000150DB File Offset: 0x000132DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000150E7 File Offset: 0x000132E7
		[NullableContext(2)]
		public static ISelectBuilder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectBuilder>(handle, transfer);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000150F0 File Offset: 0x000132F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectBuilderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectBuilder'.");
			}
			return handle;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001511B File Offset: 0x0001331B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001514C File Offset: 0x0001334C
		public ISelectBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectBuilderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00015184 File Offset: 0x00013384
		private static Delegate GetInvoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_Handler()
		{
			if (ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_ == null)
			{
				ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISelectBuilderInvoker.n_Invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_));
			}
			return ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000151A8 File Offset: 0x000133A8
		private static void n_Invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_block)
		{
			ISelectBuilder @object = Java.Lang.Object.GetObject<ISelectBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISelectClause0 object2 = Java.Lang.Object.GetObject<ISelectClause0>(native_p0, JniHandleOwnership.DoNotTransfer);
			IFunction1 object3 = Java.Lang.Object.GetObject<IFunction1>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.Invoke(object2, object3);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000151D4 File Offset: 0x000133D4
		public unsafe void Invoke(ISelectClause0 p0, IFunction1 block)
		{
			if (this.id_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Lkotlinx/coroutines/selects/SelectClause0;Lkotlin/jvm/functions/Function1;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_, ptr);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00015273 File Offset: 0x00013473
		private static Delegate GetInvoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_ == null)
			{
				ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISelectBuilderInvoker.n_Invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_));
			}
			return ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00015298 File Offset: 0x00013498
		private static void n_Invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_block)
		{
			ISelectBuilder @object = Java.Lang.Object.GetObject<ISelectBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISelectClause1 object2 = Java.Lang.Object.GetObject<ISelectClause1>(native_p0, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.Invoke(object2, object3);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000152C4 File Offset: 0x000134C4
		public unsafe void Invoke(ISelectClause1 p0, IFunction2 block)
		{
			if (this.id_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Lkotlinx/coroutines/selects/SelectClause1;Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00015363 File Offset: 0x00013563
		private static Delegate GetInvoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_ == null)
			{
				ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ISelectBuilderInvoker.n_Invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_));
			}
			return ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00015388 File Offset: 0x00013588
		private static void n_Invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_block)
		{
			ISelectBuilder @object = Java.Lang.Object.GetObject<ISelectBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISelectClause2 object2 = Java.Lang.Object.GetObject<ISelectClause2>(native_p0, JniHandleOwnership.DoNotTransfer);
			IFunction2 object3 = Java.Lang.Object.GetObject<IFunction2>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.Invoke(object2, object3);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000153B4 File Offset: 0x000135B4
		public unsafe void Invoke(ISelectClause2 p0, IFunction2 block)
		{
			if (this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Lkotlinx/coroutines/selects/SelectClause2;Lkotlin/jvm/functions/Function2;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_, ptr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00015453 File Offset: 0x00013653
		private static Delegate GetInvoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_Handler()
		{
			if (ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == null)
			{
				ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ISelectBuilderInvoker.n_Invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_));
			}
			return ISelectBuilderInvoker.cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00015478 File Offset: 0x00013678
		private static void n_Invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_param, IntPtr native_block)
		{
			ISelectBuilder @object = Java.Lang.Object.GetObject<ISelectBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISelectClause2 object2 = Java.Lang.Object.GetObject<ISelectClause2>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_param, JniHandleOwnership.DoNotTransfer);
			IFunction2 object4 = Java.Lang.Object.GetObject<IFunction2>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.Invoke(object2, object3, object4);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000154B0 File Offset: 0x000136B0
		public unsafe void Invoke(ISelectClause2 p0, [Nullable(2)] Java.Lang.Object param, IFunction2 block)
		{
			if (this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ == IntPtr.Zero)
			{
				this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Lkotlinx/coroutines/selects/SelectClause2;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(param);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00015572 File Offset: 0x00013772
		[Obsolete]
		private static Delegate GetOnTimeout_JLkotlin_jvm_functions_Function1_Handler()
		{
			if (ISelectBuilderInvoker.cb_onTimeout_JLkotlin_jvm_functions_Function1_ == null)
			{
				ISelectBuilderInvoker.cb_onTimeout_JLkotlin_jvm_functions_Function1_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_V(ISelectBuilderInvoker.n_OnTimeout_JLkotlin_jvm_functions_Function1_));
			}
			return ISelectBuilderInvoker.cb_onTimeout_JLkotlin_jvm_functions_Function1_;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00015598 File Offset: 0x00013798
		[Obsolete]
		private static void n_OnTimeout_JLkotlin_jvm_functions_Function1_(IntPtr jnienv, IntPtr native__this, long timeMillis, IntPtr native_block)
		{
			ISelectBuilder @object = Java.Lang.Object.GetObject<ISelectBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction1 object2 = Java.Lang.Object.GetObject<IFunction1>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.OnTimeout(timeMillis, object2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000155BC File Offset: 0x000137BC
		public unsafe void OnTimeout(long timeMillis, IFunction1 block)
		{
			if (this.id_onTimeout_JLkotlin_jvm_functions_Function1_ == IntPtr.Zero)
			{
				this.id_onTimeout_JLkotlin_jvm_functions_Function1_ = JNIEnv.GetMethodID(this.class_ref, "onTimeout", "(JLkotlin/jvm/functions/Function1;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeMillis);
			ptr[1] = new JValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTimeout_JLkotlin_jvm_functions_Function1_, ptr);
		}

		// Token: 0x0400022E RID: 558
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectBuilder", typeof(ISelectBuilderInvoker));

		// Token: 0x0400022F RID: 559
		private IntPtr class_ref;

		// Token: 0x04000230 RID: 560
		[Nullable(2)]
		private static Delegate cb_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000231 RID: 561
		private IntPtr id_invoke_Lkotlinx_coroutines_selects_SelectClause0_Lkotlin_jvm_functions_Function1_;

		// Token: 0x04000232 RID: 562
		[Nullable(2)]
		private static Delegate cb_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000233 RID: 563
		private IntPtr id_invoke_Lkotlinx_coroutines_selects_SelectClause1_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000234 RID: 564
		[Nullable(2)]
		private static Delegate cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000235 RID: 565
		private IntPtr id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000236 RID: 566
		[Nullable(2)]
		private static Delegate cb_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000237 RID: 567
		private IntPtr id_invoke_Lkotlinx_coroutines_selects_SelectClause2_Ljava_lang_Object_Lkotlin_jvm_functions_Function2_;

		// Token: 0x04000238 RID: 568
		[Nullable(2)]
		private static Delegate cb_onTimeout_JLkotlin_jvm_functions_Function1_;

		// Token: 0x04000239 RID: 569
		private IntPtr id_onTimeout_JLkotlin_jvm_functions_Function1_;
	}
}
