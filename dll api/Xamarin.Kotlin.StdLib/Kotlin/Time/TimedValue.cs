using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Time
{
	// Token: 0x020000D6 RID: 214
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimedValue", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class TimedValue : Java.Lang.Object
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000102D0 File Offset: 0x0000E4D0
		internal static IntPtr class_ref
		{
			get
			{
				return TimedValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000102F4 File Offset: 0x0000E4F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimedValue._members;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000102FC File Offset: 0x0000E4FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimedValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00010320 File Offset: 0x0000E520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimedValue._members.ManagedPeerType;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001032C File Offset: 0x0000E52C
		internal TimedValue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00010338 File Offset: 0x0000E538
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe TimedValue(Java.Lang.Object value, long duration, DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(duration);
				ptr[2] = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(TimedValue._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TimedValue._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;JLkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00010424 File Offset: 0x0000E624
		public long Duration
		{
			[Register("getDuration-UwyO8pc", "()J", "")]
			get
			{
				return TimedValue._members.InstanceMethods.InvokeNonvirtualInt64Method("getDuration-UwyO8pc.()J", this, null);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00010440 File Offset: 0x0000E640
		[Nullable(2)]
		public Java.Lang.Object Value
		{
			[NullableContext(2)]
			[Register("getValue", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(TimedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00010474 File Offset: 0x0000E674
		[NullableContext(2)]
		[Register("component1", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Component1()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TimedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000104A6 File Offset: 0x0000E6A6
		[Register("component2-UwyO8pc", "()J", "")]
		public long Component2()
		{
			return TimedValue._members.InstanceMethods.InvokeNonvirtualInt64Method("component2-UwyO8pc.()J", this, null);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000104C0 File Offset: 0x0000E6C0
		[Register("copy-RFiDyg4", "(Ljava/lang/Object;J)Lkotlin/time/TimedValue;", "")]
		public unsafe TimedValue Copy([Nullable(2)] Java.Lang.Object value, long duration)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			TimedValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<TimedValue>(TimedValue._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy-RFiDyg4.(Ljava/lang/Object;J)Lkotlin/time/TimedValue;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x040001C7 RID: 455
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimedValue", typeof(TimedValue));
	}
}
