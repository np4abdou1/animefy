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
	// Token: 0x0200004A RID: 74
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CopyableThreadContextElement$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class CopyableThreadContextElementDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00009FF0 File Offset: 0x000081F0
		internal static IntPtr class_ref
		{
			get
			{
				return CopyableThreadContextElementDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000A014 File Offset: 0x00008214
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CopyableThreadContextElementDefaultImpls._members;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000A01C File Offset: 0x0000821C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CopyableThreadContextElementDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000A040 File Offset: 0x00008240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CopyableThreadContextElementDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000A04C File Offset: 0x0000824C
		internal CopyableThreadContextElementDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000A058 File Offset: 0x00008258
		[Register("fold", "(Lkotlinx/coroutines/CopyableThreadContextElement;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(ICopyableThreadContextElement _this, [Nullable(2)] Java.Lang.Object initial, IFunction2 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CopyableThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/CopyableThreadContextElement;Ljava/lang/Object;Lkotlin/jvm/functions/Function2;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060002DA RID: 730 RVA: 0x0000A128 File Offset: 0x00008328
		[Register("get", "(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Get(ICopyableThreadContextElement _this, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CopyableThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("get.(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Register("minusKey", "(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"S"
		})]
		public unsafe static ICoroutineContext MinusKey(ICopyableThreadContextElement _this, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CopyableThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("minusKey.(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000A270 File Offset: 0x00008470
		[Register("plus", "(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		[JavaTypeParameters(new string[]
		{
			"S"
		})]
		public unsafe static ICoroutineContext Plus(ICopyableThreadContextElement _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CopyableThreadContextElementDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/CopyableThreadContextElement;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040000E8 RID: 232
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CopyableThreadContextElement$DefaultImpls", typeof(CopyableThreadContextElementDefaultImpls));
	}
}
