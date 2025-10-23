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
	// Token: 0x0200029F RID: 671
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/IntRange", DoNotGenerateAcw = true)]
	public sealed class IntRange : IntProgression, IClosedRange, IJavaObject, IDisposable, IJavaPeerable, IOpenEndRange
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00063D90 File Offset: 0x00061F90
		[Register("Companion")]
		public new static IntRange.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<IntRange.CompanionStatic>(IntRange._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/IntRange$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x00063DC0 File Offset: 0x00061FC0
		internal new static IntPtr class_ref
		{
			get
			{
				return IntRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00063DE4 File Offset: 0x00061FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntRange._members;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x00063DEC File Offset: 0x00061FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00063E10 File Offset: 0x00062010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntRange._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00063E1C File Offset: 0x0006201C
		internal IntRange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00063E28 File Offset: 0x00062028
		[Register(".ctor", "(II)V", "")]
		public unsafe IntRange(int start, int endInclusive) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(endInclusive);
			base.SetHandle(IntRange._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IntRange._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00063EC0 File Offset: 0x000620C0
		[Obsolete("deprecated")]
		public Integer EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Integer;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(IntRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndExclusive.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00063EF4 File Offset: 0x000620F4
		public Integer EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Integer;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(IntRange._members.InstanceMethods.InvokeAbstractObjectMethod("getEndInclusive.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00063F28 File Offset: 0x00062128
		public Integer Start
		{
			[Register("getStart", "()Ljava/lang/Integer;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(IntRange._members.InstanceMethods.InvokeAbstractObjectMethod("getStart.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00063F5C File Offset: 0x0006215C
		[NullableContext(2)]
		[Register("contains", "(I)Z", "")]
		public unsafe bool Contains(Integer value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				result = IntRange._members.InstanceMethods.InvokeAbstractBooleanMethod("contains.(I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00063FB4 File Offset: 0x000621B4
		bool IClosedRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Integer>());
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00063FC2 File Offset: 0x000621C2
		Java.Lang.Object IClosedRange.EndInclusive
		{
			[Register("getEndInclusive", "()Ljava/lang/Comparable;", "GetGetEndInclusiveHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndInclusive;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x00063FCA File Offset: 0x000621CA
		Java.Lang.Object IClosedRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IClosedRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00063FD2 File Offset: 0x000621D2
		bool IOpenEndRange.Contains(Java.Lang.Object value)
		{
			return this.Contains(value.JavaCast<Integer>());
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00063FE0 File Offset: 0x000621E0
		Java.Lang.Object IOpenEndRange.EndExclusive
		{
			[Register("getEndExclusive", "()Ljava/lang/Comparable;", "GetGetEndExclusiveHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.EndExclusive;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00063FE8 File Offset: 0x000621E8
		Java.Lang.Object IOpenEndRange.Start
		{
			[Register("getStart", "()Ljava/lang/Comparable;", "GetGetStartHandler:Kotlin.Ranges.IOpenEndRangeInvoker, Xamarin.Kotlin.StdLib")]
			get
			{
				return this.Start;
			}
		}

		// Token: 0x04000931 RID: 2353
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/IntRange", typeof(IntRange));

		// Token: 0x020002FD RID: 765
		[Nullable(0)]
		[Register("kotlin/ranges/IntRange$Companion", DoNotGenerateAcw = true)]
		public new sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000BA760 File Offset: 0x000B8960
			internal static IntPtr class_ref
			{
				get
				{
					return IntRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x06002A5F RID: 10847 RVA: 0x000BA784 File Offset: 0x000B8984
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return IntRange.CompanionStatic._members;
				}
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000BA78C File Offset: 0x000B898C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return IntRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000BA7B0 File Offset: 0x000B89B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return IntRange.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A62 RID: 10850 RVA: 0x000BA7BC File Offset: 0x000B89BC
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A63 RID: 10851 RVA: 0x000BA7C8 File Offset: 0x000B89C8
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
					base.SetHandle(IntRange.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					IntRange.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000BA878 File Offset: 0x000B8A78
			public IntRange EMPTY
			{
				[Register("getEMPTY", "()Lkotlin/ranges/IntRange;", "")]
				get
				{
					return Java.Lang.Object.GetObject<IntRange>(IntRange.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEMPTY.()Lkotlin/ranges/IntRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009F4 RID: 2548
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/IntRange$Companion", typeof(IntRange.CompanionStatic));
		}
	}
}
