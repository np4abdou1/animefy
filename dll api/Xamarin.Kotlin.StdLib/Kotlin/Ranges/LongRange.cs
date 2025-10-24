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
	// Token: 0x020002A4 RID: 676
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/LongRange", DoNotGenerateAcw = true)]
	public sealed class LongRange : LongProgression, IClosedRange, IJavaObject, IDisposable, IJavaPeerable, IOpenEndRange
	{
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0006467C File Offset: 0x0006287C
		[Register("Companion")]
		public new static LongRange.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<LongRange.CompanionStatic>(LongRange._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/LongRange$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x000646AC File Offset: 0x000628AC
		internal new static IntPtr class_ref
		{
			get
			{
				return LongRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x000646D0 File Offset: 0x000628D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongRange._members;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x000646D8 File Offset: 0x000628D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LongRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x000646FC File Offset: 0x000628FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongRange._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00064708 File Offset: 0x00062908
		internal LongRange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00064714 File Offset: 0x00062914
		[Register(".ctor", "(JJ)V", "")]
		public unsafe LongRange(long start, long endInclusive) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(endInclusive);
			base.SetHandle(LongRange._members.InstanceMethods.StartCreateInstance("(JJ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LongRange._members.InstanceMethods.FinishCreateInstance("(JJ)V", this, ptr);
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000647AC File Offset: 0x000629AC
		[Obsolete("deprecated")]
		public Long EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Long;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Long>(LongRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndExclusive.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000647E0 File Offset: 0x000629E0
		public Long EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Long;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Long>(LongRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndInclusive.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00064814 File Offset: 0x00062A14
		public Long Start
		{
			[Register("getStart", "()Ljava/lang/Long;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Long>(LongRange._members.InstanceMethods.InvokeAbstractObjectMethod("getStart.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00064848 File Offset: 0x00062A48
		[NullableContext(2)]
		[Register("contains", "(J)Z", "")]
		public unsafe bool Contains(Long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				result = LongRange._members.InstanceMethods.InvokeAbstractBooleanMethod("contains.(J)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x000648A0 File Offset: 0x00062AA0
		bool IClosedRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Long>());
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x000648AE File Offset: 0x00062AAE
		Java.Lang.Object IClosedRange.EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Comparable;", "GetGetEndInclusiveHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndInclusive;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000648B6 File Offset: 0x00062AB6
		Java.Lang.Object IClosedRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000648BE File Offset: 0x00062ABE
		bool IOpenEndRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Long>());
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000648CC File Offset: 0x00062ACC
		Java.Lang.Object IOpenEndRange.EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Comparable;", "GetGetEndExclusiveHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndExclusive;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000648D4 File Offset: 0x00062AD4
		Java.Lang.Object IOpenEndRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x04000940 RID: 2368
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/LongRange", typeof(LongRange));

		// Token: 0x020002FF RID: 767
		[Nullable(0)]
		[Register("kotlin/ranges/LongRange$Companion", DoNotGenerateAcw = true)]
		public new sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000BAA70 File Offset: 0x000B8C70
			internal static IntPtr class_ref
			{
				get
				{
					return LongRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000BAA94 File Offset: 0x000B8C94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LongRange.CompanionStatic._members;
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000BAA9C File Offset: 0x000B8C9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LongRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000BAAC0 File Offset: 0x000B8CC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LongRange.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A72 RID: 10866 RVA: 0x000BAACC File Offset: 0x000B8CCC
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A73 RID: 10867 RVA: 0x000BAAD8 File Offset: 0x000B8CD8
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
					base.SetHandle(LongRange.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					LongRange.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000BAB88 File Offset: 0x000B8D88
			public LongRange EMPTY
			{
				[Register("getEMPTY", "()Lkotlin/ranges/LongRange;", "")]
				get
				{
					return Java.Lang.Object.GetObject<LongRange>(LongRange.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEMPTY.()Lkotlin/ranges/LongRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009F6 RID: 2550
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/LongRange$Companion", typeof(LongRange.CompanionStatic));
		}
	}
}
