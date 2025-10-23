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
	// Token: 0x02000044 RID: 68
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletableDeferred$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class CompletableDeferredDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00007790 File Offset: 0x00005990
		internal static IntPtr class_ref
		{
			get
			{
				return CompletableDeferredDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000077B4 File Offset: 0x000059B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletableDeferredDefaultImpls._members;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000077BC File Offset: 0x000059BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletableDeferredDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000077E0 File Offset: 0x000059E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletableDeferredDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000077EC File Offset: 0x000059EC
		internal CompletableDeferredDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000077F8 File Offset: 0x000059F8
		[Register("fold", "(Lkotlinx/coroutines/CompletableDeferred;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(ICompletableDeferred _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CompletableDeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/CompletableDeferred;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000224 RID: 548 RVA: 0x000078C8 File Offset: 0x00005AC8
		[Register("get", "(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(ICompletableDeferred _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CompletableDeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000796C File Offset: 0x00005B6C
		[Register("minusKey", "(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICoroutineContext MinusKey(ICompletableDeferred _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CompletableDeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007A10 File Offset: 0x00005C10
		[Register("plus", "(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICoroutineContext Plus(ICompletableDeferred _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CompletableDeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/CompletableDeferred;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/CompletableDeferred;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IJob Plus(ICompletableDeferred _this, IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(CompletableDeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/CompletableDeferred;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x04000086 RID: 134
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletableDeferred$DefaultImpls", typeof(CompletableDeferredDefaultImpls));
	}
}
