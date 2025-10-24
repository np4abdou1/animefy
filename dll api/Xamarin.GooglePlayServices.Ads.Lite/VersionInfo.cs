using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000023 RID: 35
	[Register("com/google/android/gms/ads/VersionInfo", DoNotGenerateAcw = true)]
	public class VersionInfo : Java.Lang.Object
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00005349 File Offset: 0x00003549
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00005360 File Offset: 0x00003560
		[Register("zza")]
		protected int Zza
		{
			get
			{
				return VersionInfo._members.InstanceFields.GetInt32Value("zza.I", this);
			}
			set
			{
				VersionInfo._members.InstanceFields.SetValue("zza.I", this, value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00005378 File Offset: 0x00003578
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000538F File Offset: 0x0000358F
		[Register("zzb")]
		protected int Zzb
		{
			get
			{
				return VersionInfo._members.InstanceFields.GetInt32Value("zzb.I", this);
			}
			set
			{
				VersionInfo._members.InstanceFields.SetValue("zzb.I", this, value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000053A7 File Offset: 0x000035A7
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000053BE File Offset: 0x000035BE
		[Register("zzc")]
		protected int Zzc
		{
			get
			{
				return VersionInfo._members.InstanceFields.GetInt32Value("zzc.I", this);
			}
			set
			{
				VersionInfo._members.InstanceFields.SetValue("zzc.I", this, value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000053D8 File Offset: 0x000035D8
		internal static IntPtr class_ref
		{
			get
			{
				return VersionInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000053FC File Offset: 0x000035FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VersionInfo._members;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005404 File Offset: 0x00003604
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VersionInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005428 File Offset: 0x00003628
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VersionInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000020AC File Offset: 0x000002AC
		protected VersionInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005434 File Offset: 0x00003634
		[Register(".ctor", "(III)V", "")]
		public unsafe VersionInfo(int majorVersion, int minorVersion, int microVersion) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(majorVersion);
			ptr[1] = new JniArgumentValue(minorVersion);
			ptr[2] = new JniArgumentValue(microVersion);
			base.SetHandle(VersionInfo._members.InstanceMethods.StartCreateInstance("(III)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			VersionInfo._members.InstanceMethods.FinishCreateInstance("(III)V", this, ptr);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000054E1 File Offset: 0x000036E1
		private static Delegate GetGetMajorVersionHandler()
		{
			if (VersionInfo.cb_getMajorVersion == null)
			{
				VersionInfo.cb_getMajorVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VersionInfo.n_GetMajorVersion));
			}
			return VersionInfo.cb_getMajorVersion;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005505 File Offset: 0x00003705
		private static int n_GetMajorVersion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VersionInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MajorVersion;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00005514 File Offset: 0x00003714
		public virtual int MajorVersion
		{
			[Register("getMajorVersion", "()I", "GetGetMajorVersionHandler")]
			get
			{
				return VersionInfo._members.InstanceMethods.InvokeVirtualInt32Method("getMajorVersion.()I", this, null);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000552D File Offset: 0x0000372D
		private static Delegate GetGetMicroVersionHandler()
		{
			if (VersionInfo.cb_getMicroVersion == null)
			{
				VersionInfo.cb_getMicroVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VersionInfo.n_GetMicroVersion));
			}
			return VersionInfo.cb_getMicroVersion;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005551 File Offset: 0x00003751
		private static int n_GetMicroVersion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VersionInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MicroVersion;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005560 File Offset: 0x00003760
		public virtual int MicroVersion
		{
			[Register("getMicroVersion", "()I", "GetGetMicroVersionHandler")]
			get
			{
				return VersionInfo._members.InstanceMethods.InvokeVirtualInt32Method("getMicroVersion.()I", this, null);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005579 File Offset: 0x00003779
		private static Delegate GetGetMinorVersionHandler()
		{
			if (VersionInfo.cb_getMinorVersion == null)
			{
				VersionInfo.cb_getMinorVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(VersionInfo.n_GetMinorVersion));
			}
			return VersionInfo.cb_getMinorVersion;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000559D File Offset: 0x0000379D
		private static int n_GetMinorVersion(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<VersionInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinorVersion;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000055AC File Offset: 0x000037AC
		public virtual int MinorVersion
		{
			[Register("getMinorVersion", "()I", "GetGetMinorVersionHandler")]
			get
			{
				return VersionInfo._members.InstanceMethods.InvokeVirtualInt32Method("getMinorVersion.()I", this, null);
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/VersionInfo", typeof(VersionInfo));

		// Token: 0x04000048 RID: 72
		private static Delegate cb_getMajorVersion;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_getMicroVersion;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_getMinorVersion;
	}
}
