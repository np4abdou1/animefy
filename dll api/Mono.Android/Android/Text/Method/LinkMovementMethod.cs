using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Method
{
	// Token: 0x020001D3 RID: 467
	[Register("android/text/method/LinkMovementMethod", DoNotGenerateAcw = true)]
	public class LinkMovementMethod : ScrollingMovementMethod
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0002C9EE File Offset: 0x0002ABEE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkMovementMethod._members;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0002C9F8 File Offset: 0x0002ABF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkMovementMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0002CA1C File Offset: 0x0002AC1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkMovementMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0002CA28 File Offset: 0x0002AC28
		protected LinkMovementMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0002CA34 File Offset: 0x0002AC34
		public static IMovementMethod Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<IMovementMethod>(LinkMovementMethod._members.StaticMethods.InvokeObjectMethod("getInstance.()Landroid/text/method/MovementMethod;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040007B6 RID: 1974
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/LinkMovementMethod", typeof(LinkMovementMethod));
	}
}
