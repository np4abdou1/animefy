using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Kotlin.Time
{
	// Token: 0x020000D3 RID: 211
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/MeasureTimeKt", DoNotGenerateAcw = true)]
	public sealed class MeasureTimeKt : Java.Lang.Object
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		internal static IntPtr class_ref
		{
			get
			{
				return MeasureTimeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MeasureTimeKt._members;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0000FD58 File Offset: 0x0000DF58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MeasureTimeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MeasureTimeKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000FD88 File Offset: 0x0000DF88
		internal MeasureTimeKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000FD94 File Offset: 0x0000DF94
		[Register("measureTime", "(Lkotlin/jvm/functions/Function0;)J", "")]
		public unsafe static long MeasureTime(IFunction0 block)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				result = MeasureTimeKt._members.StaticMethods.InvokeInt64Method("measureTime.(Lkotlin/jvm/functions/Function0;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return result;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000FE00 File Offset: 0x0000E000
		[Register("measureTime", "(Lkotlin/time/TimeSource;Lkotlin/jvm/functions/Function0;)J", "")]
		public unsafe static long MeasureTime(ITimeSource obj, IFunction0 block)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				result = MeasureTimeKt._members.StaticMethods.InvokeInt64Method("measureTime.(Lkotlin/time/TimeSource;Lkotlin/jvm/functions/Function0;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
			return result;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000FE98 File Offset: 0x0000E098
		[Register("measureTime", "(Lkotlin/time/TimeSource$Monotonic;Lkotlin/jvm/functions/Function0;)J", "")]
		public unsafe static long MeasureTime(TimeSourceMonotonic obj, IFunction0 block)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				result = MeasureTimeKt._members.StaticMethods.InvokeInt64Method("measureTime.(Lkotlin/time/TimeSource$Monotonic;Lkotlin/jvm/functions/Function0;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
			return result;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000FF2C File Offset: 0x0000E12C
		[Register("measureTimedValue", "(Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static TimedValue MeasureTimedValue(IFunction0 block)
		{
			TimedValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<TimedValue>(MeasureTimeKt._members.StaticMethods.InvokeObjectMethod("measureTimedValue.(Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		[Register("measureTimedValue", "(Lkotlin/time/TimeSource;Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static TimedValue MeasureTimedValue(ITimeSource obj, IFunction0 block)
		{
			TimedValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<TimedValue>(MeasureTimeKt._members.StaticMethods.InvokeObjectMethod("measureTimedValue.(Lkotlin/time/TimeSource;Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00010048 File Offset: 0x0000E248
		[Register("measureTimedValue", "(Lkotlin/time/TimeSource$Monotonic;Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static TimedValue MeasureTimedValue(TimeSourceMonotonic obj, IFunction0 block)
		{
			TimedValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<TimedValue>(MeasureTimeKt._members.StaticMethods.InvokeObjectMethod("measureTimedValue.(Lkotlin/time/TimeSource$Monotonic;Lkotlin/jvm/functions/Function0;)Lkotlin/time/TimedValue;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x040001C4 RID: 452
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/MeasureTimeKt", typeof(MeasureTimeKt));
	}
}
