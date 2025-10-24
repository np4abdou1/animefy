using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000024 RID: 36
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineDispatcher", DoNotGenerateAcw = true)]
	public abstract class CoroutineDispatcher : AbstractCoroutineContextElement, IContinuationInterceptor, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003364 File Offset: 0x00001564
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003388 File Offset: 0x00001588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineDispatcher._members;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003390 File Offset: 0x00001590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000033B4 File Offset: 0x000015B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000033C0 File Offset: 0x000015C0
		protected CoroutineDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000033CC File Offset: 0x000015CC
		[Register(".ctor", "()V", "")]
		public CoroutineDispatcher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CoroutineDispatcher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CoroutineDispatcher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000343A File Offset: 0x0000163A
		private static Delegate GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler()
		{
			if (CoroutineDispatcher.cb_dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_ == null)
			{
				CoroutineDispatcher.cb_dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(CoroutineDispatcher.n_Dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_));
			}
			return CoroutineDispatcher.cb_dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003460 File Offset: 0x00001660
		private static void n_Dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_block)
		{
			CoroutineDispatcher @object = Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.Dispatch(object2, object3);
		}

		// Token: 0x060000AE RID: 174
		[Register("dispatch", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public abstract void Dispatch(ICoroutineContext context, IRunnable block);

		// Token: 0x060000AF RID: 175 RVA: 0x0000348C File Offset: 0x0000168C
		private static Delegate GetDispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler()
		{
			if (CoroutineDispatcher.cb_dispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_ == null)
			{
				CoroutineDispatcher.cb_dispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(CoroutineDispatcher.n_DispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_));
			}
			return CoroutineDispatcher.cb_dispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000034B0 File Offset: 0x000016B0
		private static void n_DispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_block)
		{
			CoroutineDispatcher @object = Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_block, JniHandleOwnership.DoNotTransfer);
			@object.DispatchYield(object2, object3);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000034DC File Offset: 0x000016DC
		[Register("dispatchYield", "(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", "GetDispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_Handler")]
		public unsafe virtual void DispatchYield(ICoroutineContext context, IRunnable block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				CoroutineDispatcher._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchYield.(Lkotlin/coroutines/CoroutineContext;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003574 File Offset: 0x00001774
		private static Delegate GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (CoroutineDispatcher.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				CoroutineDispatcher.cb_get_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CoroutineDispatcher.n_Get_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return CoroutineDispatcher.cb_get_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003598 File Offset: 0x00001798
		private static IntPtr n_Get_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000035C0 File Offset: 0x000017C0
		[Register("get", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "GetGet_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe override Java.Lang.Object Get(ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CoroutineDispatcher._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003638 File Offset: 0x00001838
		[Register("interceptContinuation", "(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe IContinuation InterceptContinuation(IContinuation continuation)
		{
			IContinuation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
				@object = Java.Lang.Object.GetObject<IContinuation>(CoroutineDispatcher._members.InstanceMethods.InvokeNonvirtualObjectMethod("interceptContinuation.(Lkotlin/coroutines/Continuation;)Lkotlin/coroutines/Continuation;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(continuation);
			}
			return @object;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000036B0 File Offset: 0x000018B0
		private static Delegate GetIsDispatchNeeded_Lkotlin_coroutines_CoroutineContext_Handler()
		{
			if (CoroutineDispatcher.cb_isDispatchNeeded_Lkotlin_coroutines_CoroutineContext_ == null)
			{
				CoroutineDispatcher.cb_isDispatchNeeded_Lkotlin_coroutines_CoroutineContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(CoroutineDispatcher.n_IsDispatchNeeded_Lkotlin_coroutines_CoroutineContext_));
			}
			return CoroutineDispatcher.cb_isDispatchNeeded_Lkotlin_coroutines_CoroutineContext_;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000036D4 File Offset: 0x000018D4
		private static bool n_IsDispatchNeeded_Lkotlin_coroutines_CoroutineContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			CoroutineDispatcher @object = Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContext object2 = Java.Lang.Object.GetObject<ICoroutineContext>(native_context, JniHandleOwnership.DoNotTransfer);
			return @object.IsDispatchNeeded(object2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000036F8 File Offset: 0x000018F8
		[Register("isDispatchNeeded", "(Lkotlin/coroutines/CoroutineContext;)Z", "GetIsDispatchNeeded_Lkotlin_coroutines_CoroutineContext_Handler")]
		public unsafe virtual bool IsDispatchNeeded(ICoroutineContext context)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				result = CoroutineDispatcher._members.InstanceMethods.InvokeVirtualBooleanMethod("isDispatchNeeded.(Lkotlin/coroutines/CoroutineContext;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003764 File Offset: 0x00001964
		private static Delegate GetLimitedParallelism_IHandler()
		{
			if (CoroutineDispatcher.cb_limitedParallelism_I == null)
			{
				CoroutineDispatcher.cb_limitedParallelism_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(CoroutineDispatcher.n_LimitedParallelism_I));
			}
			return CoroutineDispatcher.cb_limitedParallelism_I;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003788 File Offset: 0x00001988
		private static IntPtr n_LimitedParallelism_I(IntPtr jnienv, IntPtr native__this, int parallelism)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LimitedParallelism(parallelism));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000037A0 File Offset: 0x000019A0
		[Register("limitedParallelism", "(I)Lkotlinx/coroutines/CoroutineDispatcher;", "GetLimitedParallelism_IHandler")]
		public unsafe virtual CoroutineDispatcher LimitedParallelism(int parallelism)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(parallelism);
			return Java.Lang.Object.GetObject<CoroutineDispatcher>(CoroutineDispatcher._members.InstanceMethods.InvokeVirtualObjectMethod("limitedParallelism.(I)Lkotlinx/coroutines/CoroutineDispatcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000037E9 File Offset: 0x000019E9
		private static Delegate GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler()
		{
			if (CoroutineDispatcher.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ == null)
			{
				CoroutineDispatcher.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CoroutineDispatcher.n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_));
			}
			return CoroutineDispatcher.cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003810 File Offset: 0x00001A10
		private static IntPtr n_MinusKey_Lkotlin_coroutines_CoroutineContext_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AbstractCoroutineContextElement @object = Java.Lang.Object.GetObject<CoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICoroutineContextKey object2 = Java.Lang.Object.GetObject<ICoroutineContextKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.MinusKey(object2));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003838 File Offset: 0x00001A38
		[Register("minusKey", "(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "GetMinusKey_Lkotlin_coroutines_CoroutineContext_Key_Handler")]
		public unsafe override ICoroutineContext MinusKey(ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CoroutineDispatcher._members.InstanceMethods.InvokeVirtualObjectMethod("minusKey.(Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000038B0 File Offset: 0x00001AB0
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/CoroutineDispatcher;)Lkotlinx/coroutines/CoroutineDispatcher;", "")]
		public unsafe CoroutineDispatcher Plus(CoroutineDispatcher other)
		{
			CoroutineDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				@object = Java.Lang.Object.GetObject<CoroutineDispatcher>(CoroutineDispatcher._members.InstanceMethods.InvokeNonvirtualObjectMethod("plus.(Lkotlinx/coroutines/CoroutineDispatcher;)Lkotlinx/coroutines/CoroutineDispatcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003924 File Offset: 0x00001B24
		[Register("releaseInterceptedContinuation", "(Lkotlin/coroutines/Continuation;)V", "")]
		public unsafe void ReleaseInterceptedContinuation(IContinuation continuation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
				CoroutineDispatcher._members.InstanceMethods.InvokeNonvirtualVoidMethod("releaseInterceptedContinuation.(Lkotlin/coroutines/Continuation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(continuation);
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineDispatcher", typeof(CoroutineDispatcher));

		// Token: 0x04000011 RID: 17
		[Nullable(2)]
		private static Delegate cb_dispatch_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_;

		// Token: 0x04000012 RID: 18
		[Nullable(2)]
		private static Delegate cb_dispatchYield_Lkotlin_coroutines_CoroutineContext_Ljava_lang_Runnable_;

		// Token: 0x04000013 RID: 19
		[Nullable(2)]
		private static Delegate cb_get_Lkotlin_coroutines_CoroutineContext_Key_;

		// Token: 0x04000014 RID: 20
		[Nullable(2)]
		private static Delegate cb_isDispatchNeeded_Lkotlin_coroutines_CoroutineContext_;

		// Token: 0x04000015 RID: 21
		[Nullable(2)]
		private static Delegate cb_limitedParallelism_I;

		// Token: 0x04000016 RID: 22
		[Nullable(2)]
		private static Delegate cb_minusKey_Lkotlin_coroutines_CoroutineContext_Key_;
	}
}
