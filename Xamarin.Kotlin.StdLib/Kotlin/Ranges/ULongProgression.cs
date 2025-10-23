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
	// Token: 0x020002A7 RID: 679
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/ULongProgression", DoNotGenerateAcw = true)]
	public class ULongProgression : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00068110 File Offset: 0x00066310
		[Register("Companion")]
		public static ULongProgression.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<ULongProgression.CompanionStatic>(ULongProgression._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/ULongProgression$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00068140 File Offset: 0x00066340
		internal static IntPtr class_ref
		{
			get
			{
				return ULongProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00068164 File Offset: 0x00066364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ULongProgression._members;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0006816C File Offset: 0x0006636C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULongProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00068190 File Offset: 0x00066390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ULongProgression._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0006819C File Offset: 0x0006639C
		protected ULongProgression(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000681A8 File Offset: 0x000663A8
		[NullableContext(2)]
		[Register(".ctor", "(JJJLkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe ULongProgression(long start, long endInclusive, long step, DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(start);
				ptr[1] = new JniArgumentValue(endInclusive);
				ptr[2] = new JniArgumentValue(step);
				ptr[3] = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
				base.SetHandle(ULongProgression._members.InstanceMethods.StartCreateInstance("(JJJLkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ULongProgression._members.InstanceMethods.FinishCreateInstance("(JJJLkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(_constructor_marker);
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00068298 File Offset: 0x00066498
		public ulong First
		{
			[Register("getFirst-s-VKNKU", "()J", "")]
			get
			{
				return (ulong)ULongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getFirst-s-VKNKU.()J", this, null);
			}
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000682B1 File Offset: 0x000664B1
		private static Delegate GetIsEmptyHandler()
		{
			if (ULongProgression.cb_isEmpty == null)
			{
				ULongProgression.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ULongProgression.n_IsEmpty));
			}
			return ULongProgression.cb_isEmpty;
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000682D5 File Offset: 0x000664D5
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ULongProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x000682E4 File Offset: 0x000664E4
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return ULongProgression._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000682FD File Offset: 0x000664FD
		public ulong Last
		{
			[Register("getLast-s-VKNKU", "()J", "")]
			get
			{
				return (ulong)ULongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getLast-s-VKNKU.()J", this, null);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00068316 File Offset: 0x00066516
		public long Step
		{
			[Register("getStep", "()J", "")]
			get
			{
				return ULongProgression._members.InstanceMethods.InvokeNonvirtualInt64Method("getStep.()J", this, null);
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00068330 File Offset: 0x00066530
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(ULongProgression._members.InstanceMethods.InvokeNonvirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000944 RID: 2372
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ULongProgression", typeof(ULongProgression));

		// Token: 0x04000945 RID: 2373
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x02000301 RID: 769
		[Nullable(0)]
		[Register("kotlin/ranges/ULongProgression$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06002A7E RID: 10878 RVA: 0x000BAD80 File Offset: 0x000B8F80
			internal static IntPtr class_ref
			{
				get
				{
					return ULongProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000BADA4 File Offset: 0x000B8FA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ULongProgression.CompanionStatic._members;
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x06002A80 RID: 10880 RVA: 0x000BADAC File Offset: 0x000B8FAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ULongProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000BADD0 File Offset: 0x000B8FD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ULongProgression.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A82 RID: 10882 RVA: 0x000BADDC File Offset: 0x000B8FDC
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A83 RID: 10883 RVA: 0x000BADE8 File Offset: 0x000B8FE8
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
					base.SetHandle(ULongProgression.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ULongProgression.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A84 RID: 10884 RVA: 0x000BAE98 File Offset: 0x000B9098
			[Register("fromClosedRange-7ftBX0g", "(JJJ)Lkotlin/ranges/ULongProgression;", "")]
			public unsafe ULongProgression FromClosedRange_7ftBX0g(ulong rangeStart, ulong rangeEnd, long step)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rangeStart);
				ptr[1] = new JniArgumentValue(rangeEnd);
				ptr[2] = new JniArgumentValue(step);
				return Java.Lang.Object.GetObject<ULongProgression>(ULongProgression.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromClosedRange-7ftBX0g.(JJJ)Lkotlin/ranges/ULongProgression;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009F8 RID: 2552
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/ULongProgression$Companion", typeof(ULongProgression.CompanionStatic));
		}
	}
}
