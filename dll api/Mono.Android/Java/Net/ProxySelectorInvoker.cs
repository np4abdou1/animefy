using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Net
{
	// Token: 0x020003B0 RID: 944
	[Register("java/net/ProxySelector", DoNotGenerateAcw = true)]
	internal class ProxySelectorInvoker : ProxySelector
	{
		// Token: 0x0600299C RID: 10652 RVA: 0x00075367 File Offset: 0x00073567
		public ProxySelectorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x00075371 File Offset: 0x00073571
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProxySelectorInvoker._members;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x00075378 File Offset: 0x00073578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProxySelectorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00075384 File Offset: 0x00073584
		public unsafe override IList<Proxy> Select(URI uri)
		{
			IList<Proxy> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = JavaList<Proxy>.FromJniHandle(ProxySelectorInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("select.(Ljava/net/URI;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x04001107 RID: 4359
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/ProxySelector", typeof(ProxySelectorInvoker));
	}
}
