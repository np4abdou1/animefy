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
	// Token: 0x020002A6 RID: 678
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/UIntProgression", DoNotGenerateAcw = true)]
	public class UIntProgression : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x00067F90 File Offset: 0x00066190
		[Register("Companion")]
		public static UIntProgression.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<UIntProgression.CompanionStatic>(UIntProgression._members.StaticFields.GetObjectValue("Companion.Lkotlin/ranges/UIntProgression$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00067FC0 File Offset: 0x000661C0
		internal static IntPtr class_ref
		{
			get
			{
				return UIntProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00067FE4 File Offset: 0x000661E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UIntProgression._members;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00067FEC File Offset: 0x000661EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UIntProgression._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00068010 File Offset: 0x00066210
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UIntProgression._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0006801C File Offset: 0x0006621C
		protected UIntProgression(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x00068026 File Offset: 0x00066226
		public uint First
		{
			[Register("getFirst-pVg5ArA", "()I", "")]
			get
			{
				return (uint)UIntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getFirst-pVg5ArA.()I", this, null);
			}
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0006803F File Offset: 0x0006623F
		private static Delegate GetIsEmptyHandler()
		{
			if (UIntProgression.cb_isEmpty == null)
			{
				UIntProgression.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(UIntProgression.n_IsEmpty));
			}
			return UIntProgression.cb_isEmpty;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00068063 File Offset: 0x00066263
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UIntProgression>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00068072 File Offset: 0x00066272
		public virtual bool IsEmpty
		{
			[Register("isEmpty", "()Z", "GetIsEmptyHandler")]
			get
			{
				return UIntProgression._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0006808B File Offset: 0x0006628B
		public uint Last
		{
			[Register("getLast-pVg5ArA", "()I", "")]
			get
			{
				return (uint)UIntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getLast-pVg5ArA.()I", this, null);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000680A4 File Offset: 0x000662A4
		public int Step
		{
			[Register("getStep", "()I", "")]
			get
			{
				return UIntProgression._members.InstanceMethods.InvokeNonvirtualInt32Method("getStep.()I", this, null);
			}
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000680C0 File Offset: 0x000662C0
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(UIntProgression._members.InstanceMethods.InvokeNonvirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000942 RID: 2370
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/UIntProgression", typeof(UIntProgression));

		// Token: 0x04000943 RID: 2371
		[Nullable(2)]
		private static Delegate cb_isEmpty;

		// Token: 0x02000300 RID: 768
		[Nullable(0)]
		[Register("kotlin/ranges/UIntProgression$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000BABD8 File Offset: 0x000B8DD8
			internal static IntPtr class_ref
			{
				get
				{
					return UIntProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x06002A77 RID: 10871 RVA: 0x000BABFC File Offset: 0x000B8DFC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UIntProgression.CompanionStatic._members;
				}
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000BAC04 File Offset: 0x000B8E04
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UIntProgression.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000BAC28 File Offset: 0x000B8E28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UIntProgression.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A7A RID: 10874 RVA: 0x000BAC34 File Offset: 0x000B8E34
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002A7B RID: 10875 RVA: 0x000BAC40 File Offset: 0x000B8E40
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
					base.SetHandle(UIntProgression.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					UIntProgression.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002A7C RID: 10876 RVA: 0x000BACF0 File Offset: 0x000B8EF0
			[Register("fromClosedRange-Nkh28Cs", "(III)Lkotlin/ranges/UIntProgression;", "")]
			public unsafe UIntProgression FromClosedRange_Nkh28Cs(uint rangeStart, uint rangeEnd, int step)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(rangeStart);
				ptr[1] = new JniArgumentValue(rangeEnd);
				ptr[2] = new JniArgumentValue(step);
				return Java.Lang.Object.GetObject<UIntProgression>(UIntProgression.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("fromClosedRange-Nkh28Cs.(III)Lkotlin/ranges/UIntProgression;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009F7 RID: 2551
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/UIntProgression$Companion", typeof(UIntProgression.CompanionStatic));
		}
	}
}
