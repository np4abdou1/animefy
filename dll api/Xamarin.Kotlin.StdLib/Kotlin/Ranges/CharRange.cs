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
	// Token: 0x02000297 RID: 663
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/CharRange", DoNotGenerateAcw = true)]
	public sealed class CharRange : CharProgression, IClosedRange, IJavaObject, IDisposable, IJavaPeerable, IOpenEndRange
	{
		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00062F04 File Offset: 0x00061104
		[Register("Companion")]
		public new static CharRange.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<CharRange.CompanionStatic>(CharRange._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/CharRange$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00062F34 File Offset: 0x00061134
		internal new static IntPtr class_ref
		{
			get
			{
				return CharRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00062F58 File Offset: 0x00061158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharRange._members;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00062F60 File Offset: 0x00061160
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00062F84 File Offset: 0x00061184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharRange._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00062F90 File Offset: 0x00061190
		internal CharRange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00062F9C File Offset: 0x0006119C
		[Register(".ctor", "(CC)V", "")]
		public unsafe CharRange(char start, char endInclusive) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(endInclusive);
			base.SetHandle(CharRange._members.InstanceMethods.StartCreateInstance("(CC)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			CharRange._members.InstanceMethods.FinishCreateInstance("(CC)V", this, ptr);
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00063034 File Offset: 0x00061234
		[Obsolete("deprecated")]
		public Character EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Character;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Character>(CharRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndExclusive.()Ljava/lang/Character;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00063068 File Offset: 0x00061268
		public Character EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Character;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Character>(CharRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndInclusive.()Ljava/lang/Character;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0006309C File Offset: 0x0006129C
		public Character Start
		{
			[Register("getStart", "()Ljava/lang/Character;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Character>(CharRange._members.InstanceMethods.InvokeAbstractObjectMethod("getStart.()Ljava/lang/Character;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000630D0 File Offset: 0x000612D0
		[NullableContext(2)]
		[Register("contains", "(C)Z", "")]
		public unsafe bool Contains(Character value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				result = CharRange._members.InstanceMethods.InvokeAbstractBooleanMethod("contains.(C)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00063128 File Offset: 0x00061328
		bool IClosedRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Character>());
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00063136 File Offset: 0x00061336
		Java.Lang.Object IClosedRange.EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Comparable;", "GetGetEndInclusiveHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndInclusive;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0006313E File Offset: 0x0006133E
		Java.Lang.Object IClosedRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00063146 File Offset: 0x00061346
		bool IOpenEndRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Character>());
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00063154 File Offset: 0x00061354
		Java.Lang.Object IOpenEndRange.EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Comparable;", "GetGetEndExclusiveHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndExclusive;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0006315C File Offset: 0x0006135C
		Java.Lang.Object IOpenEndRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x04000915 RID: 2325
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/CharRange", typeof(CharRange));

		// Token: 0x020002FB RID: 763
		[Nullable(0)]
		[Register("kotlin/ranges/CharRange$Companion", DoNotGenerateAcw = true)]
		public new sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000BA450 File Offset: 0x000B8650
			internal static IntPtr class_ref
			{
				get
				{
					return CharRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000BA474 File Offset: 0x000B8674
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CharRange.CompanionStatic._members;
				}
			}

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000BA47C File Offset: 0x000B867C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CharRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x06002A51 RID: 10833 RVA: 0x000BA4A0 File Offset: 0x000B86A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CharRange.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A52 RID: 10834 RVA: 0x000BA4AC File Offset: 0x000B86AC
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A53 RID: 10835 RVA: 0x000BA4B8 File Offset: 0x000B86B8
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
					base.SetHandle(CharRange.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CharRange.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000BA568 File Offset: 0x000B8768
			public CharRange EMPTY
			{
				[Register("getEMPTY", "()Lkotlin/ranges/CharRange;", "")]
				get
				{
					return Java.Lang.Object.GetObject<CharRange>(CharRange.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEMPTY.()Lkotlin/ranges/CharRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009F2 RID: 2546
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/CharRange$Companion", typeof(CharRange.CompanionStatic));
		}
	}
}
