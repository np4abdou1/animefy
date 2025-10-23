using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B7 RID: 183
	[Register("kotlin/UShort", DoNotGenerateAcw = true)]
	public sealed class UShort : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		internal static IntPtr class_ref
		{
			get
			{
				return UShort._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0000CB04 File Offset: 0x0000AD04
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UShort._members;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UShort._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000CB30 File Offset: 0x0000AD30
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UShort._members.ManagedPeerType;
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		internal UShort(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000CB48 File Offset: 0x0000AD48
		[NullableContext(2)]
		[Register("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo(Java.Lang.Object p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = UShort._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x04000177 RID: 375
		[Register("MAX_VALUE")]
		public const short MaxValue = -1;

		// Token: 0x04000178 RID: 376
		[Register("MIN_VALUE")]
		public const short MinValue = 0;

		// Token: 0x04000179 RID: 377
		[Register("SIZE_BITS")]
		public const int SizeBits = 16;

		// Token: 0x0400017A RID: 378
		[Register("SIZE_BYTES")]
		public const int SizeBytes = 2;

		// Token: 0x0400017B RID: 379
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UShort", typeof(UShort));
	}
}
