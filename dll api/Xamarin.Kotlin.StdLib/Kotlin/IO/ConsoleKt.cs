using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x0200021D RID: 541
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/ConsoleKt", DoNotGenerateAcw = true)]
	public sealed class ConsoleKt : Java.Lang.Object
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x000539B4 File Offset: 0x00051BB4
		internal static IntPtr class_ref
		{
			get
			{
				return ConsoleKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x000539D8 File Offset: 0x00051BD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConsoleKt._members;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x000539E0 File Offset: 0x00051BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConsoleKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00053A04 File Offset: 0x00051C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConsoleKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00053A10 File Offset: 0x00051C10
		internal ConsoleKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00053A1C File Offset: 0x00051C1C
		[NullableContext(2)]
		[Register("readLine", "()Ljava/lang/String;", "")]
		public static string ReadLine()
		{
			return JNIEnv.GetString(ConsoleKt._members.StaticMethods.InvokeObjectMethod("readLine.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00053A50 File Offset: 0x00051C50
		[Register("readln", "()Ljava/lang/String;", "")]
		public static string Readln()
		{
			return JNIEnv.GetString(ConsoleKt._members.StaticMethods.InvokeObjectMethod("readln.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00053A84 File Offset: 0x00051C84
		[NullableContext(2)]
		[Register("readlnOrNull", "()Ljava/lang/String;", "")]
		public static string ReadlnOrNull()
		{
			return JNIEnv.GetString(ConsoleKt._members.StaticMethods.InvokeObjectMethod("readlnOrNull.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007CD RID: 1997
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/ConsoleKt", typeof(ConsoleKt));
	}
}
