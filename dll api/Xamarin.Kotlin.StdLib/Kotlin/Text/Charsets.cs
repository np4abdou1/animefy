using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;

namespace Kotlin.Text
{
	// Token: 0x020000DA RID: 218
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/Charsets", DoNotGenerateAcw = true)]
	public sealed class Charsets : Java.Lang.Object
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001130C File Offset: 0x0000F50C
		[Register("INSTANCE")]
		public static Charsets Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<Charsets>(Charsets._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/text/Charsets;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001133C File Offset: 0x0000F53C
		[Register("ISO_8859_1")]
		public static Charset Iso88591
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("ISO_8859_1.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001136C File Offset: 0x0000F56C
		[Register("US_ASCII")]
		public static Charset UsAscii
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("US_ASCII.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001139C File Offset: 0x0000F59C
		[Register("UTF_16")]
		public static Charset Utf16
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("UTF_16.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000113CC File Offset: 0x0000F5CC
		[Register("UTF_16BE")]
		public static Charset Utf16be
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("UTF_16BE.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000113FC File Offset: 0x0000F5FC
		[Register("UTF_16LE")]
		public static Charset Utf16le
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("UTF_16LE.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001142C File Offset: 0x0000F62C
		[Register("UTF_8")]
		public static Charset Utf8
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Charsets._members.StaticFields.GetObjectValue("UTF_8.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001145C File Offset: 0x0000F65C
		internal static IntPtr class_ref
		{
			get
			{
				return Charsets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00011480 File Offset: 0x0000F680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Charsets._members;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00011488 File Offset: 0x0000F688
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Charsets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x000114AC File Offset: 0x0000F6AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Charsets._members.ManagedPeerType;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000114B8 File Offset: 0x0000F6B8
		internal Charsets(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000114C4 File Offset: 0x0000F6C4
		[Register("UTF32", "()Ljava/nio/charset/Charset;", "")]
		public Charset UTF32()
		{
			return Java.Lang.Object.GetObject<Charset>(Charsets._members.InstanceMethods.InvokeNonvirtualObjectMethod("UTF32.()Ljava/nio/charset/Charset;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000114F8 File Offset: 0x0000F6F8
		[Register("UTF32_BE", "()Ljava/nio/charset/Charset;", "")]
		public Charset UTF32_BE()
		{
			return Java.Lang.Object.GetObject<Charset>(Charsets._members.InstanceMethods.InvokeNonvirtualObjectMethod("UTF32_BE.()Ljava/nio/charset/Charset;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001152C File Offset: 0x0000F72C
		[Register("UTF32_LE", "()Ljava/nio/charset/Charset;", "")]
		public Charset UTF32_LE()
		{
			return Java.Lang.Object.GetObject<Charset>(Charsets._members.InstanceMethods.InvokeNonvirtualObjectMethod("UTF32_LE.()Ljava/nio/charset/Charset;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001CB RID: 459
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/Charsets", typeof(Charsets));
	}
}
