using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x0200009C RID: 156
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectInstance", DoNotGenerateAcw = true)]
	internal class ISelectInstanceInvoker : Java.Lang.Object, ISelectInstance, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000162F4 File Offset: 0x000144F4
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectInstanceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00016318 File Offset: 0x00014518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectInstanceInvoker._members;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001631F File Offset: 0x0001451F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00016327 File Offset: 0x00014527
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectInstanceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00016333 File Offset: 0x00014533
		[NullableContext(2)]
		public static ISelectInstance GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectInstance>(handle, transfer);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001633C File Offset: 0x0001453C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectInstanceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectInstance'.");
			}
			return handle;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00016367 File Offset: 0x00014567
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00016398 File Offset: 0x00014598
		public ISelectInstanceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectInstanceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000163D0 File Offset: 0x000145D0
		private static Delegate GetGetContextHandler()
		{
			if (ISelectInstanceInvoker.cb_getContext == null)
			{
				ISelectInstanceInvoker.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectInstanceInvoker.n_GetContext));
			}
			return ISelectInstanceInvoker.cb_getContext;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000163F4 File Offset: 0x000145F4
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00016408 File Offset: 0x00014608
		public ICoroutineContext Context
		{
			get
			{
				if (this.id_getContext == IntPtr.Zero)
				{
					this.id_getContext = JNIEnv.GetMethodID(this.class_ref, "getContext", "()Lkotlin/coroutines/CoroutineContext;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00016459 File Offset: 0x00014659
		private static Delegate GetDisposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_Handler()
		{
			if (ISelectInstanceInvoker.cb_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_ == null)
			{
				ISelectInstanceInvoker.cb_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISelectInstanceInvoker.n_DisposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_));
			}
			return ISelectInstanceInvoker.cb_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00016480 File Offset: 0x00014680
		private static void n_DisposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_(IntPtr jnienv, IntPtr native__this, IntPtr native_disposableHandle)
		{
			ISelectInstance @object = Java.Lang.Object.GetObject<ISelectInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDisposableHandle object2 = Java.Lang.Object.GetObject<IDisposableHandle>(native_disposableHandle, JniHandleOwnership.DoNotTransfer);
			@object.DisposeOnCompletion(object2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000164A4 File Offset: 0x000146A4
		public unsafe void DisposeOnCompletion(IDisposableHandle disposableHandle)
		{
			if (this.id_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_ == IntPtr.Zero)
			{
				this.id_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_ = JNIEnv.GetMethodID(this.class_ref, "disposeOnCompletion", "(Lkotlinx/coroutines/DisposableHandle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((disposableHandle == null) ? IntPtr.Zero : ((Java.Lang.Object)disposableHandle).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_, ptr);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001651C File Offset: 0x0001471C
		private static Delegate GetSelectInRegistrationPhase_Ljava_lang_Object_Handler()
		{
			if (ISelectInstanceInvoker.cb_selectInRegistrationPhase_Ljava_lang_Object_ == null)
			{
				ISelectInstanceInvoker.cb_selectInRegistrationPhase_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISelectInstanceInvoker.n_SelectInRegistrationPhase_Ljava_lang_Object_));
			}
			return ISelectInstanceInvoker.cb_selectInRegistrationPhase_Ljava_lang_Object_;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00016540 File Offset: 0x00014740
		private static void n_SelectInRegistrationPhase_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_internalResult)
		{
			ISelectInstance @object = Java.Lang.Object.GetObject<ISelectInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_internalResult, JniHandleOwnership.DoNotTransfer);
			@object.SelectInRegistrationPhase(object2);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00016564 File Offset: 0x00014764
		[NullableContext(2)]
		public unsafe void SelectInRegistrationPhase(Java.Lang.Object internalResult)
		{
			if (this.id_selectInRegistrationPhase_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_selectInRegistrationPhase_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "selectInRegistrationPhase", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((internalResult == null) ? IntPtr.Zero : internalResult.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_selectInRegistrationPhase_Ljava_lang_Object_, ptr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000165D7 File Offset: 0x000147D7
		private static Delegate GetTrySelect_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (ISelectInstanceInvoker.cb_trySelect_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				ISelectInstanceInvoker.cb_trySelect_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ISelectInstanceInvoker.n_TrySelect_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return ISelectInstanceInvoker.cb_trySelect_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000165FC File Offset: 0x000147FC
		private static bool n_TrySelect_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_clauseObject, IntPtr native_result)
		{
			ISelectInstance @object = Java.Lang.Object.GetObject<ISelectInstance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_clauseObject, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			return @object.TrySelect(object2, object3);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00016628 File Offset: 0x00014828
		public unsafe bool TrySelect(Java.Lang.Object clauseObject, [Nullable(2)] Java.Lang.Object result)
		{
			if (this.id_trySelect_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_trySelect_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "trySelect", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((clauseObject == null) ? IntPtr.Zero : clauseObject.Handle);
			ptr[1] = new JValue((result == null) ? IntPtr.Zero : result.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_trySelect_Ljava_lang_Object_Ljava_lang_Object_, ptr);
		}

		// Token: 0x04000262 RID: 610
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectInstance", typeof(ISelectInstanceInvoker));

		// Token: 0x04000263 RID: 611
		private IntPtr class_ref;

		// Token: 0x04000264 RID: 612
		[Nullable(2)]
		private static Delegate cb_getContext;

		// Token: 0x04000265 RID: 613
		private IntPtr id_getContext;

		// Token: 0x04000266 RID: 614
		[Nullable(2)]
		private static Delegate cb_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_;

		// Token: 0x04000267 RID: 615
		private IntPtr id_disposeOnCompletion_Lkotlinx_coroutines_DisposableHandle_;

		// Token: 0x04000268 RID: 616
		[Nullable(2)]
		private static Delegate cb_selectInRegistrationPhase_Ljava_lang_Object_;

		// Token: 0x04000269 RID: 617
		private IntPtr id_selectInRegistrationPhase_Ljava_lang_Object_;

		// Token: 0x0400026A RID: 618
		[Nullable(2)]
		private static Delegate cb_trySelect_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x0400026B RID: 619
		private IntPtr id_trySelect_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
