using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004E RID: 78
	[Register("com/bumptech/glide/util/LogTime", DoNotGenerateAcw = true)]
	public sealed class LogTime : Java.Lang.Object
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000B800 File Offset: 0x00009A00
		internal static IntPtr class_ref
		{
			get
			{
				return LogTime._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000B824 File Offset: 0x00009A24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogTime._members;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000B82C File Offset: 0x00009A2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogTime._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000B850 File Offset: 0x00009A50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogTime._members.ManagedPeerType;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B85C File Offset: 0x00009A5C
		internal LogTime(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000B868 File Offset: 0x00009A68
		[Register("getElapsedMillis", "(J)D", "")]
		public unsafe static double GetElapsedMillis(long logTime)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(logTime);
			return LogTime._members.StaticMethods.InvokeDoubleMethod("getElapsedMillis.(J)D", ptr);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000B8A2 File Offset: 0x00009AA2
		[Register("getLogTime", "()J", "")]
		public static long GetLogTime()
		{
			return LogTime._members.StaticMethods.InvokeInt64Method("getLogTime.()J", null);
		}

		// Token: 0x040000BA RID: 186
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/LogTime", typeof(LogTime));
	}
}
