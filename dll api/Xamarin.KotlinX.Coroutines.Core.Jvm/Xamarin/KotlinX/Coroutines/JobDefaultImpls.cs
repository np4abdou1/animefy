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
	// Token: 0x02000067 RID: 103
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/Job$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class JobDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000E038 File Offset: 0x0000C238
		internal static IntPtr class_ref
		{
			get
			{
				return JobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000E05C File Offset: 0x0000C25C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobDefaultImpls._members;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000E064 File Offset: 0x0000C264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000E088 File Offset: 0x0000C288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000E094 File Offset: 0x0000C294
		internal JobDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Register("fold", "(Lkotlinx/coroutines/Job;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IJob _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/Job;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600042E RID: 1070 RVA: 0x0000E170 File Offset: 0x0000C370
		[Register("get", "(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IJob _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(JobDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000E214 File Offset: 0x0000C414
		[Register("minusKey", "(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext MinusKey(IJob _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(JobDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		[Register("plus", "(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext Plus(IJob _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(JobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/Job;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000E35C File Offset: 0x0000C55C
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/Job;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		public unsafe static IJob Plus(IJob _this, IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(JobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/Job;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x0400017C RID: 380
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Job$DefaultImpls", typeof(JobDefaultImpls));
	}
}
