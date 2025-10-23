using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000AA RID: 170
	[Register("kotlin/UInt", DoNotGenerateAcw = true)]
	public sealed class UInt : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000B538 File Offset: 0x00009738
		internal static IntPtr class_ref
		{
			get
			{
				return UInt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000B55C File Offset: 0x0000975C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UInt._members;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000B564 File Offset: 0x00009764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UInt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000B588 File Offset: 0x00009788
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UInt._members.ManagedPeerType;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000B594 File Offset: 0x00009794
		internal UInt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000B5A0 File Offset: 0x000097A0
		[NullableContext(2)]
		[Register("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = UInt._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x04000163 RID: 355
		[Register("MAX_VALUE")]
		public const int MaxValue = -1;

		// Token: 0x04000164 RID: 356
		[Register("MIN_VALUE")]
		public const int MinValue = 0;

		// Token: 0x04000165 RID: 357
		[Register("SIZE_BITS")]
		public const int SizeBits = 32;

		// Token: 0x04000166 RID: 358
		[Register("SIZE_BYTES")]
		public const int SizeBytes = 4;

		// Token: 0x04000167 RID: 359
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UInt", typeof(UInt));
	}
}
