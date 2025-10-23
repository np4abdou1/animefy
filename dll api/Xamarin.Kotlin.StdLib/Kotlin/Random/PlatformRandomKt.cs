using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Random
{
	// Token: 0x0200013E RID: 318
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/random/PlatformRandomKt", DoNotGenerateAcw = true)]
	public sealed class PlatformRandomKt : Java.Lang.Object
	{
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00037ECC File Offset: 0x000360CC
		internal static IntPtr class_ref
		{
			get
			{
				return PlatformRandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00037EF0 File Offset: 0x000360F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PlatformRandomKt._members;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00037EF8 File Offset: 0x000360F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PlatformRandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00037F1C File Offset: 0x0003611C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PlatformRandomKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00037F28 File Offset: 0x00036128
		internal PlatformRandomKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00037F34 File Offset: 0x00036134
		[Register("asJavaRandom", "(Lkotlin/random/Random;)Ljava/util/Random;", "")]
		public unsafe static Java.Util.Random AsJavaRandom(Kotlin.Random.Random obj)
		{
			Java.Util.Random @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<Java.Util.Random>(PlatformRandomKt._members.StaticMethods.InvokeObjectMethod("asJavaRandom.(Lkotlin/random/Random;)Ljava/util/Random;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00037FA8 File Offset: 0x000361A8
		[Register("asKotlinRandom", "(Ljava/util/Random;)Lkotlin/random/Random;", "")]
		public unsafe static Kotlin.Random.Random AsKotlinRandom(Java.Util.Random obj)
		{
			Kotlin.Random.Random @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<Kotlin.Random.Random>(PlatformRandomKt._members.StaticMethods.InvokeObjectMethod("asKotlinRandom.(Ljava/util/Random;)Lkotlin/random/Random;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000572 RID: 1394
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/PlatformRandomKt", typeof(PlatformRandomKt));
	}
}
