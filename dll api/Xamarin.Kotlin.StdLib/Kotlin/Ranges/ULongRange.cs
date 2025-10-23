using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Ranges
{
	// Token: 0x02000294 RID: 660
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ULongRange", DoNotGenerateAcw = true)]
	public sealed class ULongRange : ULongProgression, IClosedRange, IJavaObject, IDisposable, IJavaPeerable, IOpenEndRange
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00062958 File Offset: 0x00060B58
		Java.Lang.Object IClosedRange.EndInclusive
		{
			get
			{
				return (long)this.EndInclusive;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00062965 File Offset: 0x00060B65
		Java.Lang.Object IClosedRange.Start
		{
			get
			{
				return (long)this.Start;
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00062972 File Offset: 0x00060B72
		bool IClosedRange.Contains(Java.Lang.Object value)
		{
			return this.Contains((ulong)((long)value));
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00062980 File Offset: 0x00060B80
		Java.Lang.Object IOpenEndRange.EndExclusive
		{
			get
			{
				return (int)this.EndInclusive;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0006298E File Offset: 0x00060B8E
		Java.Lang.Object IOpenEndRange.Start
		{
			get
			{
				return (int)this.Start;
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0006299C File Offset: 0x00060B9C
		bool IOpenEndRange.Contains(Java.Lang.Object value)
		{
			return this.Contains((ulong)((int)value));
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000629AC File Offset: 0x00060BAC
		[Register("Companion")]
		public new static ULongRange.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<ULongRange.CompanionStatic>(ULongRange._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/ULongRange$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x000629DC File Offset: 0x00060BDC
		internal new static IntPtr class_ref
		{
			get
			{
				return ULongRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00062A00 File Offset: 0x00060C00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ULongRange._members;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x00062A08 File Offset: 0x00060C08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULongRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00062A2C File Offset: 0x00060C2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ULongRange._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00062A38 File Offset: 0x00060C38
		internal ULongRange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00062A44 File Offset: 0x00060C44
		[NullableContext(2)]
		[Register(".ctor", "(JJLkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe ULongRange(long start, long endInclusive, DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(endInclusive);
				ptr[2] = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(ULongRange._members.InstanceMethods.StartCreateInstance("(JJLkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ULongRange._members.InstanceMethods.FinishCreateInstance("(JJLkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00062B1C File Offset: 0x00060D1C
		[Obsolete("deprecated")]
		public ulong EndExclusive
		{
			[Register("getEndExclusive-s-VKNKU", "()J", "")]
			get
			{
				return (ulong)ULongRange._members.InstanceMethods.InvokeNonvirtualInt64Method("getEndExclusive-s-VKNKU.()J", this, null);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00062B35 File Offset: 0x00060D35
		public ulong EndInclusive
		{
			[Register("getEndInclusive-s-VKNKU", "()J", "")]
			get
			{
				return (ulong)ULongRange._members.InstanceMethods.InvokeNonvirtualInt64Method("getEndInclusive-s-VKNKU.()J", this, null);
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00062B4E File Offset: 0x00060D4E
		public ulong Start
		{
			[Register("getStart-s-VKNKU", "()J", "")]
			get
			{
				return (ulong)ULongRange._members.InstanceMethods.InvokeNonvirtualInt64Method("getStart-s-VKNKU.()J", this, null);
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00062B68 File Offset: 0x00060D68
		[Register("contains-VKZWuLQ", "(J)Z", "")]
		public unsafe bool Contains(ulong value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return ULongRange._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-VKZWuLQ.(J)Z", this, ptr);
		}

		// Token: 0x04000910 RID: 2320
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ULongRange", typeof(ULongRange));

		// Token: 0x020002F8 RID: 760
		[Nullable(0)]
		[Register("kotlin/ranges/ULongRange$Companion", DoNotGenerateAcw = true)]
		public new sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x06002A36 RID: 10806 RVA: 0x000B9FD8 File Offset: 0x000B81D8
			internal static IntPtr class_ref
			{
				get
				{
					return ULongRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000B9FFC File Offset: 0x000B81FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ULongRange.CompanionStatic._members;
				}
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000BA004 File Offset: 0x000B8204
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ULongRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x06002A39 RID: 10809 RVA: 0x000BA028 File Offset: 0x000B8228
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ULongRange.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A3A RID: 10810 RVA: 0x000BA034 File Offset: 0x000B8234
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A3B RID: 10811 RVA: 0x000BA040 File Offset: 0x000B8240
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe CompanionStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(ULongRange.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ULongRange.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000BA0F0 File Offset: 0x000B82F0
			public ULongRange EMPTY
			{
				[Register("getEMPTY", "()Lkotlin/ranges/ULongRange;", "")]
				get
				{
					return Java.Lang.Object.GetObject<ULongRange>(ULongRange.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEMPTY.()Lkotlin/ranges/ULongRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009EF RID: 2543
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ULongRange$Companion", typeof(ULongRange.CompanionStatic));
		}
	}
}
