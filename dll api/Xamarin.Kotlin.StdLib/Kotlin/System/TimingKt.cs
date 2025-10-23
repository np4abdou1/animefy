using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.System
{
	// Token: 0x020000F4 RID: 244
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/system/TimingKt", DoNotGenerateAcw = true)]
	public sealed class TimingKt : Java.Lang.Object
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000219E8 File Offset: 0x0001FBE8
		internal static IntPtr class_ref
		{
			get
			{
				return TimingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00021A0C File Offset: 0x0001FC0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimingKt._members;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00021A14 File Offset: 0x0001FC14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00021A38 File Offset: 0x0001FC38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00021A44 File Offset: 0x0001FC44
		internal TimingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00021A50 File Offset: 0x0001FC50
		[Register("measureNanoTime", "(Lkotlin/jvm/functions/Function0;)J", "")]
		public unsafe static long MeasureNanoTime(IFunction0 block)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				result = TimingKt._members.StaticMethods.InvokeInt64Method("measureNanoTime.(Lkotlin/jvm/functions/Function0;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return result;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00021ABC File Offset: 0x0001FCBC
		[Register("measureTimeMillis", "(Lkotlin/jvm/functions/Function0;)J", "")]
		public unsafe static long MeasureTimeMillis(IFunction0 block)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				result = TimingKt._members.StaticMethods.InvokeInt64Method("measureTimeMillis.(Lkotlin/jvm/functions/Function0;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return result;
		}

		// Token: 0x0400025C RID: 604
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/system/TimingKt", typeof(TimingKt));
	}
}
