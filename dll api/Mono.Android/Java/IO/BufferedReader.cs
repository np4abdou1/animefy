using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000412 RID: 1042
	[Register("java/io/BufferedReader", DoNotGenerateAcw = true)]
	public class BufferedReader : Reader
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x0007D8E1 File Offset: 0x0007BAE1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BufferedReader._members;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x0007D8E8 File Offset: 0x0007BAE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BufferedReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x0007D90C File Offset: 0x0007BB0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BufferedReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x0007D918 File Offset: 0x0007BB18
		protected BufferedReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x0007D922 File Offset: 0x0007BB22
		private static Delegate GetCloseHandler()
		{
			if (BufferedReader.cb_close == null)
			{
				BufferedReader.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BufferedReader.n_Close));
			}
			return BufferedReader.cb_close;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x0007D946 File Offset: 0x0007BB46
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BufferedReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0007D955 File Offset: 0x0007BB55
		public override void Close()
		{
			BufferedReader._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x04001203 RID: 4611
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/BufferedReader", typeof(BufferedReader));

		// Token: 0x04001204 RID: 4612
		private static Delegate cb_close;
	}
}
