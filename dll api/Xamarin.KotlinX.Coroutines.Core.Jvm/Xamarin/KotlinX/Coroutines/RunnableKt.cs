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
	// Token: 0x0200007F RID: 127
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/RunnableKt", DoNotGenerateAcw = true)]
	public sealed class RunnableKt : Java.Lang.Object
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001364C File Offset: 0x0001184C
		internal static IntPtr class_ref
		{
			get
			{
				return RunnableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00013670 File Offset: 0x00011870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RunnableKt._members;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00013678 File Offset: 0x00011878
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RunnableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001369C File Offset: 0x0001189C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RunnableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000136A8 File Offset: 0x000118A8
		internal RunnableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000136B4 File Offset: 0x000118B4
		[Register("Runnable", "(Lkotlin/jvm/functions/Function0;)Ljava/lang/Runnable;", "")]
		public unsafe static IRunnable Runnable(IFunction0 block)
		{
			IRunnable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IRunnable>(RunnableKt._members.StaticMethods.InvokeObjectMethod("Runnable.(Lkotlin/jvm/functions/Function0;)Ljava/lang/Runnable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x04000208 RID: 520
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/RunnableKt", typeof(RunnableKt));
	}
}
