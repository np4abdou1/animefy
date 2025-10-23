using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000416 RID: 1046
	[Register("java/io/FilterInputStream", DoNotGenerateAcw = true)]
	public class FilterInputStream : InputStream
	{
		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x0007DC4D File Offset: 0x0007BE4D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FilterInputStream._members;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x0007DC54 File Offset: 0x0007BE54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FilterInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002DE0 RID: 11744 RVA: 0x0007DC78 File Offset: 0x0007BE78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FilterInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0007DB70 File Offset: 0x0007BD70
		protected FilterInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0007DC84 File Offset: 0x0007BE84
		private static Delegate GetReadHandler()
		{
			if (FilterInputStream.cb_read == null)
			{
				FilterInputStream.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FilterInputStream.n_Read));
			}
			return FilterInputStream.cb_read;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
		private static int n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FilterInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0007DCB7 File Offset: 0x0007BEB7
		public override int Read()
		{
			return FilterInputStream._members.InstanceMethods.InvokeVirtualInt32Method("read.()I", this, null);
		}

		// Token: 0x0400120C RID: 4620
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/FilterInputStream", typeof(FilterInputStream));

		// Token: 0x0400120D RID: 4621
		private static Delegate cb_read;
	}
}
