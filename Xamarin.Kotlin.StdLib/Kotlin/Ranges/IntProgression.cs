using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Ranges
{
	// Token: 0x0200029E RID: 670
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/IntProgression", DoNotGenerateAcw = true)]
	public class IntProgression : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00063BD8 File Offset: 0x00061DD8
		[Register("Companion")]
		public static IntProgression.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<IntProgression.CompanionStatic>(IntProgression._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/IntProgression$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x00063C08 File Offset: 0x00061E08
		internal static IntPtr class_ref
		{
			get
			{
				return IntProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00063C2C File Offset: 0x00061E2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntProgression._members;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00063C34 File Offset: 0x00061E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00063C58 File Offset: 0x00061E58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntProgression._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00063C64 File Offset: 0x00061E64
		protected IntProgression(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00063C6E File Offset: 0x00061E6E
		public int First
		{
			[Register("getFirst", "()I", "")]
			get
			{
				return IntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getFirst.()I", this, null);
			}
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00063C87 File Offset: 0x00061E87
		private static Delegate GetIsEmptyHandler()
		{
			if (IntProgression.cb_isEmpty == null)
			{
				IntProgression.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IntProgression.n_IsEmpty));
			}
			return IntProgression.cb_isEmpty;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00063CAB File Offset: 0x00061EAB
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IntProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00063CBA File Offset: 0x00061EBA
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return IntProgression._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00063CD3 File Offset: 0x00061ED3
		public int Last
		{
			[Register("getLast", "()I", "")]
			get
			{
				return IntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getLast.()I", this, null);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00063CEC File Offset: 0x00061EEC
		public int Step
		{
			[Register("getStep", "()I", "")]
			get
			{
				return IntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getStep.()I", this, null);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00063D05 File Offset: 0x00061F05
		private static Delegate GetIteratorHandler()
		{
			if (IntProgression.cb_iterator == null)
			{
				IntProgression.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IntProgression.n_Iterator));
			}
			return IntProgression.cb_iterator;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00063D29 File Offset: 0x00061F29
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IntProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00063D40 File Offset: 0x00061F40
		[Register("iterator", "()Lkotlin/collections/IntIterator;", "GetIteratorHandler")]
		public virtual IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(IntProgression._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Lkotlin/collections/IntIterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400092E RID: 2350
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/IntProgression", typeof(IntProgression));

		// Token: 0x0400092F RID: 2351
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000930 RID: 2352
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x020002FC RID: 764
		[Nullable(0)]
		[Register("kotlin/ranges/IntProgression$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000BA5B8 File Offset: 0x000B87B8
			internal static IntPtr class_ref
			{
				get
				{
					return IntProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x06002A57 RID: 10839 RVA: 0x000BA5DC File Offset: 0x000B87DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return IntProgression.CompanionStatic._members;
				}
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000BA5E4 File Offset: 0x000B87E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return IntProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x06002A59 RID: 10841 RVA: 0x000BA608 File Offset: 0x000B8808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return IntProgression.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A5A RID: 10842 RVA: 0x000BA614 File Offset: 0x000B8814
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A5B RID: 10843 RVA: 0x000BA620 File Offset: 0x000B8820
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
					base.SetHandle(IntProgression.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					IntProgression.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A5C RID: 10844 RVA: 0x000BA6D0 File Offset: 0x000B88D0
			[Register("fromClosedRange", "(III)Lkotlin/ranges/IntProgression;", "")]
			public unsafe IntProgression FromClosedRange(int rangeStart, int rangeEnd, int step)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rangeStart);
				ptr[1] = new JniArgumentValue(rangeEnd);
				ptr[2] = new JniArgumentValue(step);
				return Java.Lang.Object.GetObject<IntProgression>(IntProgression.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromClosedRange.(III)Lkotlin/ranges/IntProgression;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009F3 RID: 2547
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/IntProgression$Companion", typeof(IntProgression.CompanionStatic));
		}
	}
}
