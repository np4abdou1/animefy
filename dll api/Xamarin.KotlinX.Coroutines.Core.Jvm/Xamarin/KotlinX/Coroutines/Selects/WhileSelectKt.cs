using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/WhileSelectKt", DoNotGenerateAcw = true)]
	public sealed class WhileSelectKt : Java.Lang.Object
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00016B88 File Offset: 0x00014D88
		internal static IntPtr class_ref
		{
			get
			{
				return WhileSelectKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00016BAC File Offset: 0x00014DAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WhileSelectKt._members;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00016BB4 File Offset: 0x00014DB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WhileSelectKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00016BD8 File Offset: 0x00014DD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WhileSelectKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00016BE4 File Offset: 0x00014DE4
		internal WhileSelectKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00016BF0 File Offset: 0x00014DF0
		[Register("whileSelect", "(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WhileSelect(IFunction1 builder, IContinuation p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(WhileSelectKt._members.StaticMethods.InvokeObjectMethod("whileSelect.(Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000270 RID: 624
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/WhileSelectKt", typeof(WhileSelectKt));
	}
}
