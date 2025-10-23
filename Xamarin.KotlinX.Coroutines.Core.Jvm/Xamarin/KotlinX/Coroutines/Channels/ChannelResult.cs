using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C5 RID: 197
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ChannelResult", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class ChannelResult : Java.Lang.Object
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00020348 File Offset: 0x0001E548
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002036C File Offset: 0x0001E56C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelResult._members;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00020374 File Offset: 0x0001E574
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00020398 File Offset: 0x0001E598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelResult._members.ManagedPeerType;
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000203A4 File Offset: 0x0001E5A4
		internal ChannelResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040002C3 RID: 707
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelResult", typeof(ChannelResult));

		// Token: 0x020000E8 RID: 232
		[Nullable(0)]
		[Register("kotlinx/coroutines/channels/ChannelResult$Companion", DoNotGenerateAcw = true)]
		public sealed class Companion : Java.Lang.Object
		{
			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00026974 File Offset: 0x00024B74
			internal static IntPtr class_ref
			{
				get
				{
					return ChannelResult.Companion._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00026998 File Offset: 0x00024B98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ChannelResult.Companion._members;
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000269A0 File Offset: 0x00024BA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ChannelResult.Companion._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x000269C4 File Offset: 0x00024BC4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ChannelResult.Companion._members.ManagedPeerType;
				}
			}

			// Token: 0x06000AC4 RID: 2756 RVA: 0x000269D0 File Offset: 0x00024BD0
			internal Companion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000AC5 RID: 2757 RVA: 0x000269DC File Offset: 0x00024BDC
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(ChannelResult.Companion._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ChannelResult.Companion._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x00026A8C File Offset: 0x00024C8C
			[Register("closed-JP2dKIU", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "")]
			[JavaTypeParameters(new string[]
			{
				"E"
			})]
			public unsafe Java.Lang.Object Closed_JP2dKIU([Nullable(2)] Throwable cause)
			{
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelResult.Companion._members.InstanceMethods.InvokeNonvirtualObjectMethod("closed-JP2dKIU.(Ljava/lang/Throwable;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cause);
				}
				return @object;
			}

			// Token: 0x06000AC7 RID: 2759 RVA: 0x00026B00 File Offset: 0x00024D00
			[Register("failure-PtdJZtk", "()Ljava/lang/Object;", "")]
			[JavaTypeParameters(new string[]
			{
				"E"
			})]
			public Java.Lang.Object Failure_PtdJZtk()
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelResult.Companion._members.InstanceMethods.InvokeNonvirtualObjectMethod("failure-PtdJZtk.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000AC8 RID: 2760 RVA: 0x00026B34 File Offset: 0x00024D34
			[Register("success-JP2dKIU", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
			[JavaTypeParameters(new string[]
			{
				"E"
			})]
			public unsafe Java.Lang.Object Success_JP2dKIU([Nullable(2)] Java.Lang.Object value)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelResult.Companion._members.InstanceMethods.InvokeNonvirtualObjectMethod("success-JP2dKIU.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
				return @object;
			}

			// Token: 0x0400038B RID: 907
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelResult$Companion", typeof(ChannelResult.Companion));
		}
	}
}
