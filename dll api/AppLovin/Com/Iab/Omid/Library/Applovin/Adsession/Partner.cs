using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000049 RID: 73
	[Register("com/iab/omid/library/applovin/adsession/Partner", DoNotGenerateAcw = true)]
	public class Partner : Java.Lang.Object
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000055CC File Offset: 0x000037CC
		internal static IntPtr class_ref
		{
			get
			{
				return Partner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000055F0 File Offset: 0x000037F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Partner._members;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000055F8 File Offset: 0x000037F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Partner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000561C File Offset: 0x0000381C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Partner._members.ManagedPeerType;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000021F0 File Offset: 0x000003F0
		protected Partner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00005628 File Offset: 0x00003828
		private static Delegate GetGetNameHandler()
		{
			if (Partner.cb_getName == null)
			{
				Partner.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Partner.n_GetName));
			}
			return Partner.cb_getName;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000564C File Offset: 0x0000384C
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Partner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00005660 File Offset: 0x00003860
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(Partner._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00005692 File Offset: 0x00003892
		private static Delegate GetGetVersionHandler()
		{
			if (Partner.cb_getVersion == null)
			{
				Partner.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Partner.n_GetVersion));
			}
			return Partner.cb_getVersion;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000056B6 File Offset: 0x000038B6
		private static IntPtr n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Partner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Version);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000056CC File Offset: 0x000038CC
		public virtual string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get
			{
				return JNIEnv.GetString(Partner._members.InstanceMethods.InvokeVirtualObjectMethod("getVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00005700 File Offset: 0x00003900
		[Register("createPartner", "(Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/Partner;", "")]
		public unsafe static Partner CreatePartner(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			Partner @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Partner>(Partner._members.StaticMethods.InvokeObjectMethod("createPartner.(Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/Partner;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/Partner", typeof(Partner));

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getName;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_getVersion;
	}
}
