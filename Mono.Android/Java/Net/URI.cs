using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003B3 RID: 947
	[Register("java/net/URI", DoNotGenerateAcw = true)]
	public sealed class URI : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x00075495 File Offset: 0x00073695
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URI._members;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0007549C File Offset: 0x0007369C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return URI._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000754C0 File Offset: 0x000736C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URI._members.ManagedPeerType;
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000021E0 File Offset: 0x000003E0
		internal URI(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000754CC File Offset: 0x000736CC
		public unsafe URI(string scheme, string userInfo, string host, int port, string path, string query, string fragment) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(scheme);
			IntPtr intPtr2 = JNIEnv.NewString(userInfo);
			IntPtr intPtr3 = JNIEnv.NewString(host);
			IntPtr intPtr4 = JNIEnv.NewString(path);
			IntPtr intPtr5 = JNIEnv.NewString(query);
			IntPtr intPtr6 = JNIEnv.NewString(fragment);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(port);
				ptr[4] = new JniArgumentValue(intPtr4);
				ptr[5] = new JniArgumentValue(intPtr5);
				ptr[6] = new JniArgumentValue(intPtr6);
				base.SetHandle(URI._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				URI._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00075648 File Offset: 0x00073848
		public unsafe int CompareTo(URI that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = URI._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/net/URI;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000756B0 File Offset: 0x000738B0
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<URI>());
		}

		// Token: 0x0400110A RID: 4362
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/URI", typeof(URI));
	}
}
