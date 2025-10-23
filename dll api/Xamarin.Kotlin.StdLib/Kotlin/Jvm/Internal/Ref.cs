using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001C8 RID: 456
	[Register("kotlin/jvm/internal/Ref", DoNotGenerateAcw = true)]
	public class Ref : Java.Lang.Object
	{
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00048C54 File Offset: 0x00046E54
		internal static IntPtr class_ref
		{
			get
			{
				return Ref._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00048C78 File Offset: 0x00046E78
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Ref._members;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00048C80 File Offset: 0x00046E80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Ref._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00048CA4 File Offset: 0x00046EA4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Ref._members.ManagedPeerType;
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00048CB0 File Offset: 0x00046EB0
		protected Ref(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000726 RID: 1830
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref", typeof(Ref));

		// Token: 0x020002EC RID: 748
		[Register("kotlin/jvm/internal/Ref$BooleanRef", DoNotGenerateAcw = true)]
		public sealed class BooleanRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x060029CE RID: 10702 RVA: 0x000B9199 File Offset: 0x000B7399
			// (set) Token: 0x060029CF RID: 10703 RVA: 0x000B91B0 File Offset: 0x000B73B0
			[Register("element")]
			public bool Element
			{
				get
				{
					return Ref.BooleanRef._members.InstanceFields.GetBooleanValue("element.Z", this);
				}
				set
				{
					Ref.BooleanRef._members.InstanceFields.SetValue("element.Z", this, value);
				}
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000B91C8 File Offset: 0x000B73C8
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.BooleanRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000B91EC File Offset: 0x000B73EC
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.BooleanRef._members;
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x060029D2 RID: 10706 RVA: 0x000B91F4 File Offset: 0x000B73F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.BooleanRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x060029D3 RID: 10707 RVA: 0x000B9218 File Offset: 0x000B7418
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.BooleanRef._members.ManagedPeerType;
				}
			}

			// Token: 0x060029D4 RID: 10708 RVA: 0x000B9224 File Offset: 0x000B7424
			internal BooleanRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029D5 RID: 10709 RVA: 0x000B9230 File Offset: 0x000B7430
			[Register(".ctor", "()V", "")]
			public BooleanRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.BooleanRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.BooleanRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E3 RID: 2531
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$BooleanRef", typeof(Ref.BooleanRef));
		}

		// Token: 0x020002ED RID: 749
		[Register("kotlin/jvm/internal/Ref$ByteRef", DoNotGenerateAcw = true)]
		public sealed class ByteRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000B92B9 File Offset: 0x000B74B9
			// (set) Token: 0x060029D8 RID: 10712 RVA: 0x000B92D0 File Offset: 0x000B74D0
			[Register("element")]
			public sbyte Element
			{
				get
				{
					return Ref.ByteRef._members.InstanceFields.GetSByteValue("element.B", this);
				}
				set
				{
					Ref.ByteRef._members.InstanceFields.SetValue("element.B", this, value);
				}
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000B92E8 File Offset: 0x000B74E8
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.ByteRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x060029DA RID: 10714 RVA: 0x000B930C File Offset: 0x000B750C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.ByteRef._members;
				}
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x060029DB RID: 10715 RVA: 0x000B9314 File Offset: 0x000B7514
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.ByteRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x060029DC RID: 10716 RVA: 0x000B9338 File Offset: 0x000B7538
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.ByteRef._members.ManagedPeerType;
				}
			}

			// Token: 0x060029DD RID: 10717 RVA: 0x000B9344 File Offset: 0x000B7544
			internal ByteRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029DE RID: 10718 RVA: 0x000B9350 File Offset: 0x000B7550
			[Register(".ctor", "()V", "")]
			public ByteRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.ByteRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.ByteRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E4 RID: 2532
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$ByteRef", typeof(Ref.ByteRef));
		}

		// Token: 0x020002EE RID: 750
		[Register("kotlin/jvm/internal/Ref$CharRef", DoNotGenerateAcw = true)]
		public sealed class CharRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000B93D9 File Offset: 0x000B75D9
			// (set) Token: 0x060029E1 RID: 10721 RVA: 0x000B93F0 File Offset: 0x000B75F0
			[Register("element")]
			public char Element
			{
				get
				{
					return Ref.CharRef._members.InstanceFields.GetCharValue("element.C", this);
				}
				set
				{
					Ref.CharRef._members.InstanceFields.SetValue("element.C", this, value);
				}
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x060029E2 RID: 10722 RVA: 0x000B9408 File Offset: 0x000B7608
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.CharRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000B942C File Offset: 0x000B762C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.CharRef._members;
				}
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x060029E4 RID: 10724 RVA: 0x000B9434 File Offset: 0x000B7634
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.CharRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000B9458 File Offset: 0x000B7658
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.CharRef._members.ManagedPeerType;
				}
			}

			// Token: 0x060029E6 RID: 10726 RVA: 0x000B9464 File Offset: 0x000B7664
			internal CharRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029E7 RID: 10727 RVA: 0x000B9470 File Offset: 0x000B7670
			[Register(".ctor", "()V", "")]
			public CharRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.CharRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.CharRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E5 RID: 2533
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$CharRef", typeof(Ref.CharRef));
		}

		// Token: 0x020002EF RID: 751
		[Register("kotlin/jvm/internal/Ref$DoubleRef", DoNotGenerateAcw = true)]
		public sealed class DoubleRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000B94F9 File Offset: 0x000B76F9
			// (set) Token: 0x060029EA RID: 10730 RVA: 0x000B9510 File Offset: 0x000B7710
			[Register("element")]
			public double Element
			{
				get
				{
					return Ref.DoubleRef._members.InstanceFields.GetDoubleValue("element.D", this);
				}
				set
				{
					Ref.DoubleRef._members.InstanceFields.SetValue("element.D", this, value);
				}
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x060029EB RID: 10731 RVA: 0x000B9528 File Offset: 0x000B7728
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.DoubleRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x060029EC RID: 10732 RVA: 0x000B954C File Offset: 0x000B774C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.DoubleRef._members;
				}
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x060029ED RID: 10733 RVA: 0x000B9554 File Offset: 0x000B7754
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.DoubleRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x060029EE RID: 10734 RVA: 0x000B9578 File Offset: 0x000B7778
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.DoubleRef._members.ManagedPeerType;
				}
			}

			// Token: 0x060029EF RID: 10735 RVA: 0x000B9584 File Offset: 0x000B7784
			internal DoubleRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029F0 RID: 10736 RVA: 0x000B9590 File Offset: 0x000B7790
			[Register(".ctor", "()V", "")]
			public DoubleRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.DoubleRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.DoubleRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E6 RID: 2534
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$DoubleRef", typeof(Ref.DoubleRef));
		}

		// Token: 0x020002F0 RID: 752
		[Register("kotlin/jvm/internal/Ref$FloatRef", DoNotGenerateAcw = true)]
		public sealed class FloatRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x060029F2 RID: 10738 RVA: 0x000B9619 File Offset: 0x000B7819
			// (set) Token: 0x060029F3 RID: 10739 RVA: 0x000B9630 File Offset: 0x000B7830
			[Register("element")]
			public float Element
			{
				get
				{
					return Ref.FloatRef._members.InstanceFields.GetSingleValue("element.F", this);
				}
				set
				{
					Ref.FloatRef._members.InstanceFields.SetValue("element.F", this, value);
				}
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000B9648 File Offset: 0x000B7848
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.FloatRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000B966C File Offset: 0x000B786C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.FloatRef._members;
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000B9674 File Offset: 0x000B7874
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.FloatRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000B9698 File Offset: 0x000B7898
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.FloatRef._members.ManagedPeerType;
				}
			}

			// Token: 0x060029F8 RID: 10744 RVA: 0x000B96A4 File Offset: 0x000B78A4
			internal FloatRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029F9 RID: 10745 RVA: 0x000B96B0 File Offset: 0x000B78B0
			[Register(".ctor", "()V", "")]
			public FloatRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.FloatRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.FloatRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E7 RID: 2535
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$FloatRef", typeof(Ref.FloatRef));
		}

		// Token: 0x020002F1 RID: 753
		[Register("kotlin/jvm/internal/Ref$IntRef", DoNotGenerateAcw = true)]
		public sealed class IntRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x060029FB RID: 10747 RVA: 0x000B9739 File Offset: 0x000B7939
			// (set) Token: 0x060029FC RID: 10748 RVA: 0x000B9750 File Offset: 0x000B7950
			[Register("element")]
			public int Element
			{
				get
				{
					return Ref.IntRef._members.InstanceFields.GetInt32Value("element.I", this);
				}
				set
				{
					Ref.IntRef._members.InstanceFields.SetValue("element.I", this, value);
				}
			}

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x060029FD RID: 10749 RVA: 0x000B9768 File Offset: 0x000B7968
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.IntRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x060029FE RID: 10750 RVA: 0x000B978C File Offset: 0x000B798C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.IntRef._members;
				}
			}

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x060029FF RID: 10751 RVA: 0x000B9794 File Offset: 0x000B7994
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.IntRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000B97B8 File Offset: 0x000B79B8
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.IntRef._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A01 RID: 10753 RVA: 0x000B97C4 File Offset: 0x000B79C4
			internal IntRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A02 RID: 10754 RVA: 0x000B97D0 File Offset: 0x000B79D0
			[Register(".ctor", "()V", "")]
			public IntRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.IntRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.IntRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E8 RID: 2536
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$IntRef", typeof(Ref.IntRef));
		}

		// Token: 0x020002F2 RID: 754
		[Register("kotlin/jvm/internal/Ref$LongRef", DoNotGenerateAcw = true)]
		public sealed class LongRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000B9859 File Offset: 0x000B7A59
			// (set) Token: 0x06002A05 RID: 10757 RVA: 0x000B9870 File Offset: 0x000B7A70
			[Register("element")]
			public long Element
			{
				get
				{
					return Ref.LongRef._members.InstanceFields.GetInt64Value("element.J", this);
				}
				set
				{
					Ref.LongRef._members.InstanceFields.SetValue("element.J", this, value);
				}
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000B9888 File Offset: 0x000B7A88
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.LongRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000B98AC File Offset: 0x000B7AAC
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.LongRef._members;
				}
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000B98B4 File Offset: 0x000B7AB4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.LongRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000B98D8 File Offset: 0x000B7AD8
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.LongRef._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A0A RID: 10762 RVA: 0x000B98E4 File Offset: 0x000B7AE4
			internal LongRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A0B RID: 10763 RVA: 0x000B98F0 File Offset: 0x000B7AF0
			[Register(".ctor", "()V", "")]
			public LongRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.LongRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.LongRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009E9 RID: 2537
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$LongRef", typeof(Ref.LongRef));
		}

		// Token: 0x020002F3 RID: 755
		[Register("kotlin/jvm/internal/Ref$ObjectRef", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public sealed class ObjectRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000B997C File Offset: 0x000B7B7C
			// (set) Token: 0x06002A0E RID: 10766 RVA: 0x000B99AC File Offset: 0x000B7BAC
			[Nullable(2)]
			[Register("element")]
			public Java.Lang.Object Element
			{
				[NullableContext(2)]
				get
				{
					return Java.Lang.Object.GetObject<Java.Lang.Object>(Ref.ObjectRef._members.InstanceFields.GetObjectValue("element.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				[NullableContext(2)]
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						Ref.ObjectRef._members.InstanceFields.SetValue("element.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000B99F8 File Offset: 0x000B7BF8
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.ObjectRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000B9A1C File Offset: 0x000B7C1C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.ObjectRef._members;
				}
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000B9A24 File Offset: 0x000B7C24
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.ObjectRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000B9A48 File Offset: 0x000B7C48
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.ObjectRef._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A13 RID: 10771 RVA: 0x000B9A54 File Offset: 0x000B7C54
			internal ObjectRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A14 RID: 10772 RVA: 0x000B9A60 File Offset: 0x000B7C60
			[Register(".ctor", "()V", "")]
			public ObjectRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.ObjectRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.ObjectRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009EA RID: 2538
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$ObjectRef", typeof(Ref.ObjectRef));
		}

		// Token: 0x020002F4 RID: 756
		[Register("kotlin/jvm/internal/Ref$ShortRef", DoNotGenerateAcw = true)]
		public sealed class ShortRef : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x06002A16 RID: 10774 RVA: 0x000B9AE9 File Offset: 0x000B7CE9
			// (set) Token: 0x06002A17 RID: 10775 RVA: 0x000B9B00 File Offset: 0x000B7D00
			[Register("element")]
			public short Element
			{
				get
				{
					return Ref.ShortRef._members.InstanceFields.GetInt16Value("element.S", this);
				}
				set
				{
					Ref.ShortRef._members.InstanceFields.SetValue("element.S", this, value);
				}
			}

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000B9B18 File Offset: 0x000B7D18
			internal static IntPtr class_ref
			{
				get
				{
					return Ref.ShortRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000B9B3C File Offset: 0x000B7D3C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Ref.ShortRef._members;
				}
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000B9B44 File Offset: 0x000B7D44
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Ref.ShortRef._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000B9B68 File Offset: 0x000B7D68
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Ref.ShortRef._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A1C RID: 10780 RVA: 0x000B9B74 File Offset: 0x000B7D74
			internal ShortRef(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A1D RID: 10781 RVA: 0x000B9B80 File Offset: 0x000B7D80
			[Register(".ctor", "()V", "")]
			public ShortRef() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Ref.ShortRef._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Ref.ShortRef._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040009EB RID: 2539
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Ref$ShortRef", typeof(Ref.ShortRef));
		}
	}
}
