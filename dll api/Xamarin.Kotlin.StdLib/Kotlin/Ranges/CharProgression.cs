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
	// Token: 0x02000296 RID: 662
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/CharProgression", DoNotGenerateAcw = true)]
	public class CharProgression : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00062D4C File Offset: 0x00060F4C
		[Register("Companion")]
		public static CharProgression.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<CharProgression.CompanionStatic>(CharProgression._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/CharProgression$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00062D7C File Offset: 0x00060F7C
		internal static IntPtr class_ref
		{
			get
			{
				return CharProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00062DA0 File Offset: 0x00060FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharProgression._members;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00062DA8 File Offset: 0x00060FA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00062DCC File Offset: 0x00060FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharProgression._members.ManagedPeerType;
			}
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00062DD8 File Offset: 0x00060FD8
		protected CharProgression(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00062DE2 File Offset: 0x00060FE2
		public char First
		{
			[Register("getFirst", "()C", "")]
			get
			{
				return CharProgression._members.InstanceMethods.InvokeNonvirtualCharMethod("getFirst.()C", this, null);
			}
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00062DFB File Offset: 0x00060FFB
		private static Delegate GetIsEmptyHandler()
		{
			if (CharProgression.cb_isEmpty == null)
			{
				CharProgression.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CharProgression.n_IsEmpty));
			}
			return CharProgression.cb_isEmpty;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00062E1F File Offset: 0x0006101F
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CharProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x00062E2E File Offset: 0x0006102E
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return CharProgression._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00062E47 File Offset: 0x00061047
		public char Last
		{
			[Register("getLast", "()C", "")]
			get
			{
				return CharProgression._members.InstanceMethods.InvokeNonvirtualCharMethod("getLast.()C", this, null);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00062E60 File Offset: 0x00061060
		public int Step
		{
			[Register("getStep", "()I", "")]
			get
			{
				return CharProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getStep.()I", this, null);
			}
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00062E79 File Offset: 0x00061079
		private static Delegate GetIteratorHandler()
		{
			if (CharProgression.cb_iterator == null)
			{
				CharProgression.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CharProgression.n_Iterator));
			}
			return CharProgression.cb_iterator;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00062E9D File Offset: 0x0006109D
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CharProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00062EB4 File Offset: 0x000610B4
		[Register("iterator", "()Lkotlin/collections/CharIterator;", "GetIteratorHandler")]
		public virtual IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(CharProgression._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Lkotlin/collections/CharIterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000912 RID: 2322
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/CharProgression", typeof(CharProgression));

		// Token: 0x04000913 RID: 2323
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x04000914 RID: 2324
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x020002FA RID: 762
		[Nullable(0)]
		[Register("kotlin/ranges/CharProgression$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000BA2A8 File Offset: 0x000B84A8
			internal static IntPtr class_ref
			{
				get
				{
					return CharProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x06002A47 RID: 10823 RVA: 0x000BA2CC File Offset: 0x000B84CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CharProgression.CompanionStatic._members;
				}
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000BA2D4 File Offset: 0x000B84D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CharProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x06002A49 RID: 10825 RVA: 0x000BA2F8 File Offset: 0x000B84F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CharProgression.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A4A RID: 10826 RVA: 0x000BA304 File Offset: 0x000B8504
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A4B RID: 10827 RVA: 0x000BA310 File Offset: 0x000B8510
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
					base.SetHandle(CharProgression.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CharProgression.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A4C RID: 10828 RVA: 0x000BA3C0 File Offset: 0x000B85C0
			[Register("fromClosedRange", "(CCI)Lkotlin/ranges/CharProgression;", "")]
			public unsafe CharProgression FromClosedRange(char rangeStart, char rangeEnd, int step)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rangeStart);
				ptr[1] = new JniArgumentValue(rangeEnd);
				ptr[2] = new JniArgumentValue(step);
				return Java.Lang.Object.GetObject<CharProgression>(CharProgression.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromClosedRange.(CCI)Lkotlin/ranges/CharProgression;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009F1 RID: 2545
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/CharProgression$Companion", typeof(CharProgression.CompanionStatic));
		}
	}
}
