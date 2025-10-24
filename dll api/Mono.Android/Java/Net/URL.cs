using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003B4 RID: 948
	[Register("java/net/URL", DoNotGenerateAcw = true)]
	public sealed class URL : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000756D9 File Offset: 0x000738D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URL._members;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000756E0 File Offset: 0x000738E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return URL._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x00075704 File Offset: 0x00073904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URL._members.ManagedPeerType;
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000021E0 File Offset: 0x000003E0
		internal URL(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00075710 File Offset: 0x00073910
		public unsafe URL(string spec) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(spec);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(URL._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				URL._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000757B4 File Offset: 0x000739B4
		public URLConnection OpenConnection()
		{
			return Java.Lang.Object.GetObject<URLConnection>(URL._members.InstanceMethods.InvokeAbstractObjectMethod("openConnection.()Ljava/net/URLConnection;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400110B RID: 4363
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/URL", typeof(URL));
	}
}
