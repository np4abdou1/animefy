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
	// Token: 0x02000295 RID: 661
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/UIntRange", DoNotGenerateAcw = true)]
	public sealed class UIntRange : UIntProgression, IClosedRange, IJavaObject, IDisposable, IJavaPeerable, IOpenEndRange
	{
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00062BBE File Offset: 0x00060DBE
		Java.Lang.Object IClosedRange.EndInclusive
		{
			get
			{
				return (int)this.EndInclusive;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00062BCB File Offset: 0x00060DCB
		Java.Lang.Object IClosedRange.Start
		{
			get
			{
				return (int)this.Start;
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00062BD8 File Offset: 0x00060DD8
		bool IClosedRange.Contains(Java.Lang.Object value)
		{
			return this.Contains((uint)((int)value));
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00062BE6 File Offset: 0x00060DE6
		Java.Lang.Object IOpenEndRange.EndExclusive
		{
			get
			{
				return (int)this.EndInclusive;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00062BF3 File Offset: 0x00060DF3
		Java.Lang.Object IOpenEndRange.Start
		{
			get
			{
				return (int)this.Start;
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00062C00 File Offset: 0x00060E00
		bool IOpenEndRange.Contains(Java.Lang.Object value)
		{
			return this.Contains((uint)((int)value));
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00062C10 File Offset: 0x00060E10
		[Register("Companion")]
		public new static UIntRange.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<UIntRange.CompanionStatic>(UIntRange._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/UIntRange$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00062C40 File Offset: 0x00060E40
		internal new static IntPtr class_ref
		{
			get
			{
				return UIntRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00062C64 File Offset: 0x00060E64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UIntRange._members;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00062C6C File Offset: 0x00060E6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UIntRange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00062C90 File Offset: 0x00060E90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UIntRange._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00062C9C File Offset: 0x00060E9C
		internal UIntRange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00062CA6 File Offset: 0x00060EA6
		[Obsolete("deprecated")]
		public uint EndExclusive
		{
			[Register("getEndExclusive-pVg5ArA", "()I", "")]
			get
			{
				return (uint)UIntRange._members.InstanceMethods.InvokeNonvirtualInt32Method("getEndExclusive-pVg5ArA.()I", this, null);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00062CBF File Offset: 0x00060EBF
		public uint EndInclusive
		{
			[Register("getEndInclusive-pVg5ArA", "()I", "")]
			get
			{
				return (uint)UIntRange._members.InstanceMethods.InvokeNonvirtualInt32Method("getEndInclusive-pVg5ArA.()I", this, null);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00062CD8 File Offset: 0x00060ED8
		public uint Start
		{
			[Register("getStart-pVg5ArA", "()I", "")]
			get
			{
				return (uint)UIntRange._members.InstanceMethods.InvokeNonvirtualInt32Method("getStart-pVg5ArA.()I", this, null);
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00062CF4 File Offset: 0x00060EF4
		[Register("contains-WZ4Q5Ns", "(I)Z", "")]
		public unsafe bool Contains(uint value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return UIntRange._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-WZ4Q5Ns.(I)Z", this, ptr);
		}

		// Token: 0x04000911 RID: 2321
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/UIntRange", typeof(UIntRange));

		// Token: 0x020002F9 RID: 761
		[Nullable(0)]
		[Register("kotlin/ranges/UIntRange$Companion", DoNotGenerateAcw = true)]
		public new sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000BA140 File Offset: 0x000B8340
			internal static IntPtr class_ref
			{
				get
				{
					return UIntRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x06002A3F RID: 10815 RVA: 0x000BA164 File Offset: 0x000B8364
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UIntRange.CompanionStatic._members;
				}
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000BA16C File Offset: 0x000B836C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UIntRange.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x06002A41 RID: 10817 RVA: 0x000BA190 File Offset: 0x000B8390
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UIntRange.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A42 RID: 10818 RVA: 0x000BA19C File Offset: 0x000B839C
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A43 RID: 10819 RVA: 0x000BA1A8 File Offset: 0x000B83A8
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
					base.SetHandle(UIntRange.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					UIntRange.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000BA258 File Offset: 0x000B8458
			public UIntRange EMPTY
			{
				[Register("getEMPTY", "()Lkotlin/ranges/UIntRange;", "")]
				get
				{
					return Java.Lang.Object.GetObject<UIntRange>(UIntRange.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEMPTY.()Lkotlin/ranges/UIntRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009F0 RID: 2544
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/UIntRange$Companion", typeof(UIntRange.CompanionStatic));
		}
	}
}
