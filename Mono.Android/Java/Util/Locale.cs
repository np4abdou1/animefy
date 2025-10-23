using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000322 RID: 802
	[Register("java/util/Locale", DoNotGenerateAcw = true)]
	public sealed class Locale : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable
	{
		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x000606C1 File Offset: 0x0005E8C1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Locale._members;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000606C8 File Offset: 0x0005E8C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Locale._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000606EC File Offset: 0x0005E8EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Locale._members.ManagedPeerType;
			}
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Locale(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000606F8 File Offset: 0x0005E8F8
		public unsafe Locale(string language) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(language);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(Locale._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Locale._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x0006079C File Offset: 0x0005E99C
		public unsafe static Locale Default
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Locale._members.StaticMethods.InvokeVoidMethod("setDefault.(Ljava/util/Locale;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00060800 File Offset: 0x0005EA00
		public sealed override string ToString()
		{
			return JNIEnv.GetString(Locale._members.InstanceMethods.InvokeNonvirtualObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000E19 RID: 3609
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Locale", typeof(Locale));
	}
}
