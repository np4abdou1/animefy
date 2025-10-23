using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A6 RID: 166
	[Register("kotlin/UByte", DoNotGenerateAcw = true)]
	public sealed class UByte : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		internal static IntPtr class_ref
		{
			get
			{
				return UByte._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UByte._members;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000ACFC File Offset: 0x00008EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UByte._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000AD20 File Offset: 0x00008F20
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UByte._members.ManagedPeerType;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000AD2C File Offset: 0x00008F2C
		internal UByte(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000AD38 File Offset: 0x00008F38
		[NullableContext(2)]
		[Register("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = UByte._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x0400015B RID: 347
		[Register("MAX_VALUE")]
		public const sbyte MaxValue = -1;

		// Token: 0x0400015C RID: 348
		[Register("MIN_VALUE")]
		public const sbyte MinValue = 0;

		// Token: 0x0400015D RID: 349
		[Register("SIZE_BITS")]
		public const int SizeBits = 8;

		// Token: 0x0400015E RID: 350
		[Register("SIZE_BYTES")]
		public const int SizeBytes = 1;

		// Token: 0x0400015F RID: 351
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UByte", typeof(UByte));
	}
}
