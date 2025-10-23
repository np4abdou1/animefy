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
	// Token: 0x02000057 RID: 87
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Deferred$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class DeferredDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000B7D8 File Offset: 0x000099D8
		internal static IntPtr class_ref
		{
			get
			{
				return DeferredDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000B7FC File Offset: 0x000099FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeferredDefaultImpls._members;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000B804 File Offset: 0x00009A04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeferredDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000B828 File Offset: 0x00009A28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeferredDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000B834 File Offset: 0x00009A34
		internal DeferredDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000B840 File Offset: 0x00009A40
		[Register("fold", "(Lkotlinx/coroutines/Deferred;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IDeferred _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/Deferred;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06000353 RID: 851 RVA: 0x0000B910 File Offset: 0x00009B10
		[Register("get", "(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IDeferred _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		[Register("minusKey", "(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICoroutineContext MinusKey(IDeferred _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(DeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000BA58 File Offset: 0x00009C58
		[Register("plus", "(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICoroutineContext Plus(IDeferred _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(DeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000BAFC File Offset: 0x00009CFC
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/Deferred;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IJob Plus(IDeferred _this, IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(DeferredDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/Deferred;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x04000116 RID: 278
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Deferred$DefaultImpls", typeof(DeferredDefaultImpls));
	}
}
