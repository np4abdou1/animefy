using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000020 RID: 32
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletionHandlerKt", DoNotGenerateAcw = true)]
	public sealed class CompletionHandlerKt : Java.Lang.Object
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002F20 File Offset: 0x00001120
		internal static IntPtr class_ref
		{
			get
			{
				return CompletionHandlerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002F44 File Offset: 0x00001144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletionHandlerKt._members;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002F4C File Offset: 0x0000114C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletionHandlerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002F70 File Offset: 0x00001170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletionHandlerKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002F7C File Offset: 0x0000117C
		internal CompletionHandlerKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002F88 File Offset: 0x00001188
		[Register("getAsHandler", "(Ljava/lang/Object;)Lkotlin/jvm/functions/Function1;", "")]
		public unsafe static IFunction1 GetAsHandler(Java.Lang.Object obj)
		{
			IFunction1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<IFunction1>(CompletionHandlerKt._members.StaticMethods.InvokeObjectMethod("getAsHandler.(Ljava/lang/Object;)Lkotlin/jvm/functions/Function1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x0400000C RID: 12
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletionHandlerKt", typeof(CompletionHandlerKt));
	}
}
