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
	// Token: 0x02000041 RID: 65
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ChildJob$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ChildJobDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000652C File Offset: 0x0000472C
		internal static IntPtr class_ref
		{
			get
			{
				return ChildJobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00006550 File Offset: 0x00004750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChildJobDefaultImpls._members;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00006558 File Offset: 0x00004758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChildJobDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000657C File Offset: 0x0000477C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChildJobDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00006588 File Offset: 0x00004788
		internal ChildJobDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006594 File Offset: 0x00004794
		[Register("fold", "(Lkotlinx/coroutines/ChildJob;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IChildJob _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChildJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/ChildJob;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060001D3 RID: 467 RVA: 0x00006664 File Offset: 0x00004864
		[Register("get", "(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(IChildJob _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChildJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00006708 File Offset: 0x00004908
		[Register("minusKey", "(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext MinusKey(IChildJob _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ChildJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000067AC File Offset: 0x000049AC
		[Register("plus", "(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext Plus(IChildJob _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(ChildJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/ChildJob;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00006850 File Offset: 0x00004A50
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/ChildJob;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		public unsafe static IJob Plus(IChildJob _this, IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(ChildJobDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/ChildJob;Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x0400005B RID: 91
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ChildJob$DefaultImpls", typeof(ChildJobDefaultImpls));
	}
}
