using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x0200009D RID: 157
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/OnTimeoutKt", DoNotGenerateAcw = true)]
	public sealed class OnTimeoutKt : Java.Lang.Object
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000166D8 File Offset: 0x000148D8
		internal static IntPtr class_ref
		{
			get
			{
				return OnTimeoutKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000166FC File Offset: 0x000148FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnTimeoutKt._members;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00016704 File Offset: 0x00014904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OnTimeoutKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00016728 File Offset: 0x00014928
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnTimeoutKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00016734 File Offset: 0x00014934
		internal OnTimeoutKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00016740 File Offset: 0x00014940
		[Register("onTimeout", "(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static void OnTimeout(ISelectBuilder obj, long timeMillis, IFunction1 block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(timeMillis);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				OnTimeoutKt._members.StaticMethods.InvokeVoidMethod("onTimeout.(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000167EC File Offset: 0x000149EC
		[Register("onTimeout-8Mi8wO0", "(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static void OnTimeout2(ISelectBuilder obj, long timeout, IFunction1 block)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				OnTimeoutKt._members.StaticMethods.InvokeVoidMethod("onTimeout-8Mi8wO0.(Lkotlinx/coroutines/selects/SelectBuilder;JLkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
		}

		// Token: 0x0400026C RID: 620
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/OnTimeoutKt", typeof(OnTimeoutKt));
	}
}
