using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x0200024F RID: 591
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/CoroutineContextImplKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineContextImplKt : Java.Lang.Object
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0005B71C File Offset: 0x0005991C
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineContextImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0005B740 File Offset: 0x00059940
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineContextImplKt._members;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0005B748 File Offset: 0x00059948
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineContextImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0005B76C File Offset: 0x0005996C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineContextImplKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0005B778 File Offset: 0x00059978
		internal CoroutineContextImplKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0005B784 File Offset: 0x00059984
		[Register("getPolymorphicElement", "(Lkotlin/coroutines/CoroutineContext$Element;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", "")]
		[JavaTypeParameters(new string[]
		{
			"E extends kotlin.coroutines.CoroutineContext.Element"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetPolymorphicElement(ICoroutineContextElement obj, ICoroutineContextKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CoroutineContextImplKt._members.StaticMethods.InvokeObjectMethod("getPolymorphicElement.(Lkotlin/coroutines/CoroutineContext$Element;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext$Element;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0005B828 File Offset: 0x00059A28
		[Register("minusPolymorphicKey", "(Lkotlin/coroutines/CoroutineContext$Element;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext MinusPolymorphicKey(ICoroutineContextElement obj, ICoroutineContextKey key)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CoroutineContextImplKt._members.StaticMethods.InvokeObjectMethod("minusPolymorphicKey.(Lkotlin/coroutines/CoroutineContext$Element;Lkotlin/coroutines/CoroutineContext$Key;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x04000868 RID: 2152
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/CoroutineContextImplKt", typeof(CoroutineContextImplKt));
	}
}
