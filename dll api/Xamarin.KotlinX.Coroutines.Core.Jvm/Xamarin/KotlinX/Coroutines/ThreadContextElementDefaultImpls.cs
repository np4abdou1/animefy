using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000074 RID: 116
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ThreadContextElement$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ThreadContextElementDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00010958 File Offset: 0x0000EB58
		internal static IntPtr class_ref
		{
			get
			{
				return ThreadContextElementDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001097C File Offset: 0x0000EB7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadContextElementDefaultImpls._members;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00010984 File Offset: 0x0000EB84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadContextElementDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000109A8 File Offset: 0x0000EBA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadContextElementDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000109B4 File Offset: 0x0000EBB4
		internal ThreadContextElementDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000109C0 File Offset: 0x0000EBC0
		[Register("fold", "(Lkotlinx/coroutines/ThreadContextElement;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IThreadContextElement _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/ThreadContextElement;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000500 RID: 1280 RVA: 0x00010A90 File Offset: 0x0000EC90
		[Register("get", "(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IThreadContextElement _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00010B34 File Offset: 0x0000ED34
		[Register("minusKey", "(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"S"
		})]
		public unsafe static ICoroutineContext MinusKey(IThreadContextElement _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Register("plus", "(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"S"
		})]
		public unsafe static ICoroutineContext Plus(IThreadContextElement _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/ThreadContextElement;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040001DD RID: 477
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ThreadContextElement$DefaultImpls", typeof(ThreadContextElementDefaultImpls));
	}
}
