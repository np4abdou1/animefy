using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000034 RID: 52
	[Register("com/iab/omid/library/adcolony/adsession/Partner", DoNotGenerateAcw = true)]
	public class Partner : Java.Lang.Object
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005504 File Offset: 0x00003704
		internal static IntPtr class_ref
		{
			get
			{
				return Partner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00005528 File Offset: 0x00003728
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
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00005530 File Offset: 0x00003730
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
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00005554 File Offset: 0x00003754
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Partner._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002128 File Offset: 0x00000328
		protected Partner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005560 File Offset: 0x00003760
		private static Delegate GetGetNameHandler()
		{
			if (Partner.cb_getName == null)
			{
				Partner.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Partner.n_GetName));
			}
			return Partner.cb_getName;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005584 File Offset: 0x00003784
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Partner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00005598 File Offset: 0x00003798
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(Partner._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000055CA File Offset: 0x000037CA
		private static Delegate GetGetVersionHandler()
		{
			if (Partner.cb_getVersion == null)
			{
				Partner.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Partner.n_GetVersion));
			}
			return Partner.cb_getVersion;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000055EE File Offset: 0x000037EE
		private static IntPtr n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Partner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Version);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00005604 File Offset: 0x00003804
		public virtual string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get
			{
				return JNIEnv.GetString(Partner._members.InstanceMethods.InvokeVirtualObjectMethod("getVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005638 File Offset: 0x00003838
		[Register("createPartner", "(Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/Partner;", "")]
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
				@object = Java.Lang.Object.GetObject<Partner>(Partner._members.StaticMethods.InvokeObjectMethod("createPartner.(Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/Partner;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x04000050 RID: 80
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/Partner", typeof(Partner));

		// Token: 0x04000051 RID: 81
		private static Delegate cb_getName;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_getVersion;
	}
}
