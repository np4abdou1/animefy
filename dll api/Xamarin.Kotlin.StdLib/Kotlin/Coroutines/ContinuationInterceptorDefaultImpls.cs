using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Coroutines
{
	// Token: 0x02000253 RID: 595
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/ContinuationInterceptor$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ContinuationInterceptorDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0005BDE4 File Offset: 0x00059FE4
		internal static IntPtr class_ref
		{
			get
			{
				return ContinuationInterceptorDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0005BE08 File Offset: 0x0005A008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContinuationInterceptorDefaultImpls._members;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0005BE10 File Offset: 0x0005A010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContinuationInterceptorDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0005BE34 File Offset: 0x0005A034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContinuationInterceptorDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0005BE40 File Offset: 0x0005A040
		internal ContinuationInterceptorDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0005BE4C File Offset: 0x0005A04C
		[Register("fold", "(Lkotlin/coroutines/ContinuationInterceptor;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IContinuationInterceptor _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ContinuationInterceptorDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlin/coroutines/ContinuationInterceptor;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0005BF1C File Offset: 0x0005A11C
		[Register("get", "(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IContinuationInterceptor _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ContinuationInterceptorDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0005BFC0 File Offset: 0x0005A1C0
		[Register("minusKey", "(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext MinusKey(IContinuationInterceptor _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ContinuationInterceptorDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0005C064 File Offset: 0x0005A264
		[Register("plus", "(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext Plus(IContinuationInterceptor _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ContinuationInterceptorDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0005C108 File Offset: 0x0005A308
		[Register("releaseInterceptedContinuation", "(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/Continuation;)V", "")]
		public unsafe static void ReleaseInterceptedContinuation(IContinuationInterceptor _this, IContinuation continuation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((continuation == null) ? IntPtr.Zero : ((Java.Lang.Object)continuation).Handle);
				ContinuationInterceptorDefaultImpls._members.StaticMethods.InvokeVoidMethod("releaseInterceptedContinuation.(Lkotlin/coroutines/ContinuationInterceptor;Lkotlin/coroutines/Continuation;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(continuation);
			}
		}

		// Token: 0x04000870 RID: 2160
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/ContinuationInterceptor$DefaultImpls", typeof(ContinuationInterceptorDefaultImpls));
	}
}
