using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002C0 RID: 704
	[Register("com/unity3d/scar/adapter/common/scarads/ScarAdMetadata", DoNotGenerateAcw = true)]
	public class ScarAdMetadata : Java.Lang.Object
	{
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x00066728 File Offset: 0x00064928
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdMetadata._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x0006674C File Offset: 0x0006494C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdMetadata._members;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00066754 File Offset: 0x00064954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdMetadata._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00066778 File Offset: 0x00064978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdMetadata._members.ManagedPeerType;
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdMetadata(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00066784 File Offset: 0x00064984
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ScarAdMetadata(string placementId, string queryId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(ScarAdMetadata._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdMetadata._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00066848 File Offset: 0x00064A48
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe ScarAdMetadata(string placementId, string queryId, string adUnitId, string adString, Integer videoLengthMs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			IntPtr intPtr3 = JNIEnv.NewString(adUnitId);
			IntPtr intPtr4 = JNIEnv.NewString(adString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue((videoLengthMs == null) ? IntPtr.Zero : videoLengthMs.Handle);
				base.SetHandle(ScarAdMetadata._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdMetadata._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(videoLengthMs);
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0006698C File Offset: 0x00064B8C
		private static Delegate GetGetAdStringHandler()
		{
			if (ScarAdMetadata.cb_getAdString == null)
			{
				ScarAdMetadata.cb_getAdString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ScarAdMetadata.n_GetAdString));
			}
			return ScarAdMetadata.cb_getAdString;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000669B0 File Offset: 0x00064BB0
		private static IntPtr n_GetAdString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ScarAdMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdString);
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000669C4 File Offset: 0x00064BC4
		public virtual string AdString
		{
			[Register("getAdString", "()Ljava/lang/String;", "GetGetAdStringHandler")]
			get
			{
				return JNIEnv.GetString(ScarAdMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getAdString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000669F6 File Offset: 0x00064BF6
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (ScarAdMetadata.cb_getAdUnitId == null)
			{
				ScarAdMetadata.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ScarAdMetadata.n_GetAdUnitId));
			}
			return ScarAdMetadata.cb_getAdUnitId;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00066A1A File Offset: 0x00064C1A
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ScarAdMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00066A30 File Offset: 0x00064C30
		public virtual string AdUnitId
		{
			[Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get
			{
				return JNIEnv.GetString(ScarAdMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getAdUnitId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00066A62 File Offset: 0x00064C62
		private static Delegate GetGetPlacementIdHandler()
		{
			if (ScarAdMetadata.cb_getPlacementId == null)
			{
				ScarAdMetadata.cb_getPlacementId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ScarAdMetadata.n_GetPlacementId));
			}
			return ScarAdMetadata.cb_getPlacementId;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00066A86 File Offset: 0x00064C86
		private static IntPtr n_GetPlacementId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ScarAdMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlacementId);
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x00066A9C File Offset: 0x00064C9C
		public virtual string PlacementId
		{
			[Register("getPlacementId", "()Ljava/lang/String;", "GetGetPlacementIdHandler")]
			get
			{
				return JNIEnv.GetString(ScarAdMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getPlacementId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00066ACE File Offset: 0x00064CCE
		private static Delegate GetGetQueryIdHandler()
		{
			if (ScarAdMetadata.cb_getQueryId == null)
			{
				ScarAdMetadata.cb_getQueryId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ScarAdMetadata.n_GetQueryId));
			}
			return ScarAdMetadata.cb_getQueryId;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00066AF2 File Offset: 0x00064CF2
		private static IntPtr n_GetQueryId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ScarAdMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QueryId);
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x00066B08 File Offset: 0x00064D08
		public virtual string QueryId
		{
			[Register("getQueryId", "()Ljava/lang/String;", "GetGetQueryIdHandler")]
			get
			{
				return JNIEnv.GetString(ScarAdMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getQueryId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00066B3A File Offset: 0x00064D3A
		private static Delegate GetGetVideoLengthMsHandler()
		{
			if (ScarAdMetadata.cb_getVideoLengthMs == null)
			{
				ScarAdMetadata.cb_getVideoLengthMs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ScarAdMetadata.n_GetVideoLengthMs));
			}
			return ScarAdMetadata.cb_getVideoLengthMs;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00066B5E File Offset: 0x00064D5E
		private static IntPtr n_GetVideoLengthMs(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ScarAdMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VideoLengthMs);
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00066B74 File Offset: 0x00064D74
		public virtual Integer VideoLengthMs
		{
			[Register("getVideoLengthMs", "()Ljava/lang/Integer;", "GetGetVideoLengthMsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(ScarAdMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getVideoLengthMs.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/scarads/ScarAdMetadata", typeof(ScarAdMetadata));

		// Token: 0x040007F6 RID: 2038
		private static Delegate cb_getAdString;

		// Token: 0x040007F7 RID: 2039
		private static Delegate cb_getAdUnitId;

		// Token: 0x040007F8 RID: 2040
		private static Delegate cb_getPlacementId;

		// Token: 0x040007F9 RID: 2041
		private static Delegate cb_getQueryId;

		// Token: 0x040007FA RID: 2042
		private static Delegate cb_getVideoLengthMs;
	}
}
