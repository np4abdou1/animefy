using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Ranges;

namespace Kotlin.Random
{
	// Token: 0x02000141 RID: 321
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/random/RandomKt", DoNotGenerateAcw = true)]
	public sealed class RandomKt : Java.Lang.Object
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00038900 File Offset: 0x00036B00
		internal static IntPtr class_ref
		{
			get
			{
				return RandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00038924 File Offset: 0x00036B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RandomKt._members;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0003892C File Offset: 0x00036B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RandomKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00038950 File Offset: 0x00036B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RandomKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0003895C File Offset: 0x00036B5C
		internal RandomKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00038968 File Offset: 0x00036B68
		[Register("Random", "(I)Lkotlin/random/Random;", "")]
		public unsafe static Random Random(int seed)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(seed);
			return Java.Lang.Object.GetObject<Random>(RandomKt._members.StaticMethods.InvokeObjectMethod("Random.(I)Lkotlin/random/Random;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000389B0 File Offset: 0x00036BB0
		[Register("Random", "(J)Lkotlin/random/Random;", "")]
		public unsafe static Random Random(long seed)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(seed);
			return Java.Lang.Object.GetObject<Random>(RandomKt._members.StaticMethods.InvokeObjectMethod("Random.(J)Lkotlin/random/Random;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000389F8 File Offset: 0x00036BF8
		[Register("nextInt", "(Lkotlin/random/Random;Lkotlin/ranges/IntRange;)I", "")]
		public unsafe static int NextInt(Random obj, IntRange range)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				result = RandomKt._members.StaticMethods.InvokeInt32Method("nextInt.(Lkotlin/random/Random;Lkotlin/ranges/IntRange;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00038A84 File Offset: 0x00036C84
		[Register("nextLong", "(Lkotlin/random/Random;Lkotlin/ranges/LongRange;)J", "")]
		public unsafe static long NextLong(Random obj, LongRange range)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				result = RandomKt._members.StaticMethods.InvokeInt64Method("nextLong.(Lkotlin/random/Random;Lkotlin/ranges/LongRange;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x04000584 RID: 1412
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/RandomKt", typeof(RandomKt));
	}
}
