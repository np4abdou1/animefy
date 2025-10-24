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
	// Token: 0x020002A3 RID: 675
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/LongProgression", DoNotGenerateAcw = true)]
	public class LongProgression : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x000644C4 File Offset: 0x000626C4
		[Register("Companion")]
		public static LongProgression.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<LongProgression.CompanionStatic>(LongProgression._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/LongProgression$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x000644F4 File Offset: 0x000626F4
		internal static IntPtr class_ref
		{
			get
			{
				return LongProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00064518 File Offset: 0x00062718
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongProgression._members;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00064520 File Offset: 0x00062720
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LongProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00064544 File Offset: 0x00062744
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongProgression._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00064550 File Offset: 0x00062750
		protected LongProgression(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0006455A File Offset: 0x0006275A
		public long First
		{
			[Register("getFirst", "()J", "")]
			get
			{
				return LongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getFirst.()J", this, null);
			}
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00064573 File Offset: 0x00062773
		private static Delegate GetIsEmptyHandler()
		{
			if (LongProgression.cb_isEmpty == null)
			{
				LongProgression.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LongProgression.n_IsEmpty));
			}
			return LongProgression.cb_isEmpty;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00064597 File Offset: 0x00062797
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LongProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x000645A6 File Offset: 0x000627A6
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return LongProgression._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000645BF File Offset: 0x000627BF
		public long Last
		{
			[Register("getLast", "()J", "")]
			get
			{
				return LongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getLast.()J", this, null);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x000645D8 File Offset: 0x000627D8
		public long Step
		{
			[Register("getStep", "()J", "")]
			get
			{
				return LongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getStep.()J", this, null);
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000645F1 File Offset: 0x000627F1
		private static Delegate GetIteratorHandler()
		{
			if (LongProgression.cb_iterator == null)
			{
				LongProgression.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LongProgression.n_Iterator));
			}
			return LongProgression.cb_iterator;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00064615 File Offset: 0x00062815
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LongProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0006462C File Offset: 0x0006282C
		[Register("iterator", "()Lkotlin/collections/LongIterator;", "GetIteratorHandler")]
		public virtual IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(LongProgression._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Lkotlin/collections/LongIterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400093D RID: 2365
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/LongProgression", typeof(LongProgression));

		// Token: 0x0400093E RID: 2366
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x0400093F RID: 2367
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x020002FE RID: 766
		[Nullable(0)]
		[Register("kotlin/ranges/LongProgression$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x06002A66 RID: 10854 RVA: 0x000BA8C8 File Offset: 0x000B8AC8
			internal static IntPtr class_ref
			{
				get
				{
					return LongProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000BA8EC File Offset: 0x000B8AEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LongProgression.CompanionStatic._members;
				}
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000BA8F4 File Offset: 0x000B8AF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return LongProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000BA918 File Offset: 0x000B8B18
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LongProgression.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A6A RID: 10858 RVA: 0x000BA924 File Offset: 0x000B8B24
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A6B RID: 10859 RVA: 0x000BA930 File Offset: 0x000B8B30
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
					base.SetHandle(LongProgression.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					LongProgression.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A6C RID: 10860 RVA: 0x000BA9E0 File Offset: 0x000B8BE0
			[Register("fromClosedRange", "(JJJ)Lkotlin/ranges/LongProgression;", "")]
			public unsafe LongProgression FromClosedRange(long rangeStart, long rangeEnd, long step)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rangeStart);
				ptr[1] = new JniArgumentValue(rangeEnd);
				ptr[2] = new JniArgumentValue(step);
				return Java.Lang.Object.GetObject<LongProgression>(LongProgression.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromClosedRange.(JJJ)Lkotlin/ranges/LongProgression;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009F5 RID: 2549
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/LongProgression$Companion", typeof(LongProgression.CompanionStatic));
		}
	}
}
