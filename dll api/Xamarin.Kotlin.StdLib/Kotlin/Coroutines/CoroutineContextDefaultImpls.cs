using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x02000259 RID: 601
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/CoroutineContext$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class CoroutineContextDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineContextDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineContextDefaultImpls._members;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0005C900 File Offset: 0x0005AB00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineContextDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0005C924 File Offset: 0x0005AB24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineContextDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0005C930 File Offset: 0x0005AB30
		internal CoroutineContextDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0005C93C File Offset: 0x0005AB3C
		[Register("plus", "(Lkotlin/coroutines/CoroutineContext;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", "")]
		public unsafe static ICoroutineContext Plus(ICoroutineContext _this, ICoroutineContext context)
		{
			ICoroutineContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineContext>(CoroutineContextDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlin/coroutines/CoroutineContext;Lkotlin/coroutines/CoroutineContext;)Lkotlin/coroutines/CoroutineContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000883 RID: 2179
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/CoroutineContext$DefaultImpls", typeof(CoroutineContextDefaultImpls));
	}
}
