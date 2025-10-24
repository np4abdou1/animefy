using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003B5 RID: 949
	[Register("java/net/URLConnection", DoNotGenerateAcw = true)]
	public abstract class URLConnection : Java.Lang.Object
	{
		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x00075801 File Offset: 0x00073A01
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URLConnection._members;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x00075808 File Offset: 0x00073A08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return URLConnection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0007582C File Offset: 0x00073A2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URLConnection._members.ManagedPeerType;
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000021E0 File Offset: 0x000003E0
		protected URLConnection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00075838 File Offset: 0x00073A38
		private static Delegate GetSetDoInput_ZHandler()
		{
			if (URLConnection.cb_setDoInput_Z == null)
			{
				URLConnection.cb_setDoInput_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(URLConnection.n_SetDoInput_Z));
			}
			return URLConnection.cb_setDoInput_Z;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0007585C File Offset: 0x00073A5C
		private static void n_SetDoInput_Z(IntPtr jnienv, IntPtr native__this, bool doinput)
		{
			Java.Lang.Object.GetObject<URLConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DoInput = doinput;
		}

		// Token: 0x17000822 RID: 2082
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x0007586C File Offset: 0x00073A6C
		public unsafe virtual bool DoInput
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				URLConnection._members.InstanceMethods.InvokeVirtualVoidMethod("setDoInput.(Z)V", this, ptr);
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000758A7 File Offset: 0x00073AA7
		private static Delegate GetGetInputStreamHandler()
		{
			if (URLConnection.cb_getInputStream == null)
			{
				URLConnection.cb_getInputStream = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(URLConnection.n_GetInputStream));
			}
			return URLConnection.cb_getInputStream;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000758CB File Offset: 0x00073ACB
		private static IntPtr n_GetInputStream(IntPtr jnienv, IntPtr native__this)
		{
			return InputStreamAdapter.ToLocalJniHandle(Java.Lang.Object.GetObject<URLConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InputStream);
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000758E0 File Offset: 0x00073AE0
		public virtual Stream InputStream
		{
			get
			{
				return InputStreamInvoker.FromJniHandle(URLConnection._members.InstanceMethods.InvokeVirtualObjectMethod("getInputStream.()Ljava/io/InputStream;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00075912 File Offset: 0x00073B12
		private static Delegate GetConnectHandler()
		{
			if (URLConnection.cb_connect == null)
			{
				URLConnection.cb_connect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(URLConnection.n_Connect));
			}
			return URLConnection.cb_connect;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00075936 File Offset: 0x00073B36
		private static void n_Connect(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<URLConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Connect();
		}

		// Token: 0x060029C5 RID: 10693
		public abstract void Connect();

		// Token: 0x0400110C RID: 4364
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/URLConnection", typeof(URLConnection));

		// Token: 0x0400110D RID: 4365
		private static Delegate cb_setDoInput_Z;

		// Token: 0x0400110E RID: 4366
		private static Delegate cb_getInputStream;

		// Token: 0x0400110F RID: 4367
		private static Delegate cb_connect;
	}
}
