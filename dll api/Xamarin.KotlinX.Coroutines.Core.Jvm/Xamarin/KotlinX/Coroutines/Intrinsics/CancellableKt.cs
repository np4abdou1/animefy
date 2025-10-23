using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Intrinsics
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/intrinsics/CancellableKt", DoNotGenerateAcw = true)]
	public sealed class CancellableKt : Java.Lang.Object
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00016F04 File Offset: 0x00015104
		internal static IntPtr class_ref
		{
			get
			{
				return CancellableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00016F28 File Offset: 0x00015128
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellableKt._members;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00016F30 File Offset: 0x00015130
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00016F54 File Offset: 0x00015154
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00016F60 File Offset: 0x00015160
		internal CancellableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00016F6C File Offset: 0x0001516C
		[Register("startCoroutineCancellable", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void StartCoroutineCancellable(IFunction1 obj, IContinuation completion)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((completion == null) ? IntPtr.Zero : ((Java.Lang.Object)completion).Handle);
				CancellableKt._members.StaticMethods.InvokeVoidMethod("startCoroutineCancellable.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(completion);
			}
		}

		// Token: 0x04000274 RID: 628
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/intrinsics/CancellableKt", typeof(CancellableKt));
	}
}
