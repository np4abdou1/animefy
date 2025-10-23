using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000AE RID: 174
	[Register("kotlin/ULong", DoNotGenerateAcw = true)]
	public sealed class ULong : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000BDA0 File Offset: 0x00009FA0
		internal static IntPtr class_ref
		{
			get
			{
				return ULong._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ULong._members;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000BDCC File Offset: 0x00009FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULong._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ULong._members.ManagedPeerType;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000BDFC File Offset: 0x00009FFC
		internal ULong(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000BE08 File Offset: 0x0000A008
		[NullableContext(2)]
		[Register("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = ULong._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x0400016B RID: 363
		[Register("MAX_VALUE")]
		public const long MaxValue = -1L;

		// Token: 0x0400016C RID: 364
		[Register("MIN_VALUE")]
		public const long MinValue = 0L;

		// Token: 0x0400016D RID: 365
		[Register("SIZE_BITS")]
		public const int SizeBits = 64;

		// Token: 0x0400016E RID: 366
		[Register("SIZE_BYTES")]
		public const int SizeBytes = 8;

		// Token: 0x0400016F RID: 367
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ULong", typeof(ULong));
	}
}
