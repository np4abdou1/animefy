using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000155 RID: 341
	[Register("com/applovin/impl/mediation/MaxErrorImpl", DoNotGenerateAcw = true)]
	public class MaxErrorImpl : Java.Lang.Object, IMaxError, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00030368 File Offset: 0x0002E568
		internal static IntPtr class_ref
		{
			get
			{
				return MaxErrorImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0003038C File Offset: 0x0002E58C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxErrorImpl._members;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00030394 File Offset: 0x0002E594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxErrorImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x000303B8 File Offset: 0x0002E5B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxErrorImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxErrorImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x000303C4 File Offset: 0x0002E5C4
		[Register(".ctor", "(I)V", "")]
		public unsafe MaxErrorImpl(int p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			base.SetHandle(MaxErrorImpl._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			MaxErrorImpl._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00030448 File Offset: 0x0002E648
		[Register(".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe MaxErrorImpl(int p0, string p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(MaxErrorImpl._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxErrorImpl._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00030500 File Offset: 0x0002E700
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MaxErrorImpl(string p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MaxErrorImpl._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxErrorImpl._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x000305A4 File Offset: 0x0002E7A4
		private static Delegate GetGetAdLoadFailureInfoHandler()
		{
			if (MaxErrorImpl.cb_getAdLoadFailureInfo == null)
			{
				MaxErrorImpl.cb_getAdLoadFailureInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxErrorImpl.n_GetAdLoadFailureInfo));
			}
			return MaxErrorImpl.cb_getAdLoadFailureInfo;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x000305C8 File Offset: 0x0002E7C8
		private static IntPtr n_GetAdLoadFailureInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdLoadFailureInfo);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000305DC File Offset: 0x0002E7DC
		private static Delegate GetSetAdLoadFailureInfo_Ljava_lang_String_Handler()
		{
			if (MaxErrorImpl.cb_setAdLoadFailureInfo_Ljava_lang_String_ == null)
			{
				MaxErrorImpl.cb_setAdLoadFailureInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxErrorImpl.n_SetAdLoadFailureInfo_Ljava_lang_String_));
			}
			return MaxErrorImpl.cb_setAdLoadFailureInfo_Ljava_lang_String_;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00030600 File Offset: 0x0002E800
		private static void n_SetAdLoadFailureInfo_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxErrorImpl @object = Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AdLoadFailureInfo = @string;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00030624 File Offset: 0x0002E824
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00030658 File Offset: 0x0002E858
		public unsafe virtual string AdLoadFailureInfo
		{
			[Register("getAdLoadFailureInfo", "()Ljava/lang/String;", "GetGetAdLoadFailureInfoHandler")]
			get
			{
				return JNIEnv.GetString(MaxErrorImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdLoadFailureInfo.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setAdLoadFailureInfo", "(Ljava/lang/String;)V", "GetSetAdLoadFailureInfo_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MaxErrorImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setAdLoadFailureInfo.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000306B4 File Offset: 0x0002E8B4
		private static Delegate GetGetCodeHandler()
		{
			if (MaxErrorImpl.cb_getCode == null)
			{
				MaxErrorImpl.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxErrorImpl.n_GetCode));
			}
			return MaxErrorImpl.cb_getCode;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000306D8 File Offset: 0x0002E8D8
		private static int n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x000306E7 File Offset: 0x0002E8E7
		public virtual int Code
		{
			[Register("getCode", "()I", "GetGetCodeHandler")]
			get
			{
				return MaxErrorImpl._members.InstanceMethods.InvokeVirtualInt32Method("getCode.()I", this, null);
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00030700 File Offset: 0x0002E900
		private static Delegate GetGetErrorCodeHandler()
		{
			if (MaxErrorImpl.cb_getErrorCode == null)
			{
				MaxErrorImpl.cb_getErrorCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MaxErrorImpl.n_GetErrorCode));
			}
			return MaxErrorImpl.cb_getErrorCode;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00030724 File Offset: 0x0002E924
		private static int n_GetErrorCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorCode;
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00030733 File Offset: 0x0002E933
		public virtual int ErrorCode
		{
			[Register("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get
			{
				return MaxErrorImpl._members.InstanceMethods.InvokeVirtualInt32Method("getErrorCode.()I", this, null);
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0003074C File Offset: 0x0002E94C
		private static Delegate GetGetErrorMessageHandler()
		{
			if (MaxErrorImpl.cb_getErrorMessage == null)
			{
				MaxErrorImpl.cb_getErrorMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxErrorImpl.n_GetErrorMessage));
			}
			return MaxErrorImpl.cb_getErrorMessage;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00030770 File Offset: 0x0002E970
		private static IntPtr n_GetErrorMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorMessage);
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00030784 File Offset: 0x0002E984
		public virtual string ErrorMessage
		{
			[Register("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get
			{
				return JNIEnv.GetString(MaxErrorImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000307B6 File Offset: 0x0002E9B6
		private static Delegate GetGetLoadTagHandler()
		{
			if (MaxErrorImpl.cb_getLoadTag == null)
			{
				MaxErrorImpl.cb_getLoadTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxErrorImpl.n_GetLoadTag));
			}
			return MaxErrorImpl.cb_getLoadTag;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000307DA File Offset: 0x0002E9DA
		private static IntPtr n_GetLoadTag(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadTag);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000307EE File Offset: 0x0002E9EE
		private static Delegate GetSetLoadTag_Ljava_lang_String_Handler()
		{
			if (MaxErrorImpl.cb_setLoadTag_Ljava_lang_String_ == null)
			{
				MaxErrorImpl.cb_setLoadTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxErrorImpl.n_SetLoadTag_Ljava_lang_String_));
			}
			return MaxErrorImpl.cb_setLoadTag_Ljava_lang_String_;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00030814 File Offset: 0x0002EA14
		private static void n_SetLoadTag_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxErrorImpl @object = Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.LoadTag = @string;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00030838 File Offset: 0x0002EA38
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x0003086C File Offset: 0x0002EA6C
		public unsafe virtual string LoadTag
		{
			[Register("getLoadTag", "()Ljava/lang/String;", "GetGetLoadTagHandler")]
			get
			{
				return JNIEnv.GetString(MaxErrorImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getLoadTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLoadTag", "(Ljava/lang/String;)V", "GetSetLoadTag_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					MaxErrorImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setLoadTag.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000308C8 File Offset: 0x0002EAC8
		private static Delegate GetGetMessageHandler()
		{
			if (MaxErrorImpl.cb_getMessage == null)
			{
				MaxErrorImpl.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxErrorImpl.n_GetMessage));
			}
			return MaxErrorImpl.cb_getMessage;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000308EC File Offset: 0x0002EAEC
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00030900 File Offset: 0x0002EB00
		public virtual string Message
		{
			[Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get
			{
				return JNIEnv.GetString(MaxErrorImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00030932 File Offset: 0x0002EB32
		private static Delegate GetGetWaterfallHandler()
		{
			if (MaxErrorImpl.cb_getWaterfall == null)
			{
				MaxErrorImpl.cb_getWaterfall = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxErrorImpl.n_GetWaterfall));
			}
			return MaxErrorImpl.cb_getWaterfall;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00030956 File Offset: 0x0002EB56
		private static IntPtr n_GetWaterfall(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Waterfall);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003096A File Offset: 0x0002EB6A
		private static Delegate GetSetWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_Handler()
		{
			if (MaxErrorImpl.cb_setWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_ == null)
			{
				MaxErrorImpl.cb_setWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MaxErrorImpl.n_SetWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_));
			}
			return MaxErrorImpl.cb_setWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00030990 File Offset: 0x0002EB90
		private static void n_SetWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MaxErrorImpl @object = Java.Lang.Object.GetObject<MaxErrorImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdWaterfallInfo object2 = Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Waterfall = object2;
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x000309B4 File Offset: 0x0002EBB4
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x000309E8 File Offset: 0x0002EBE8
		public unsafe virtual IMaxAdWaterfallInfo Waterfall
		{
			[Register("getWaterfall", "()Lcom/applovin/mediation/MaxAdWaterfallInfo;", "GetGetWaterfallHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(MaxErrorImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getWaterfall.()Lcom/applovin/mediation/MaxAdWaterfallInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setWaterfall", "(Lcom/applovin/mediation/MaxAdWaterfallInfo;)V", "GetSetWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					MaxErrorImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setWaterfall.(Lcom/applovin/mediation/MaxAdWaterfallInfo;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x04000583 RID: 1411
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxErrorImpl", typeof(MaxErrorImpl));

		// Token: 0x04000584 RID: 1412
		private static Delegate cb_getAdLoadFailureInfo;

		// Token: 0x04000585 RID: 1413
		private static Delegate cb_setAdLoadFailureInfo_Ljava_lang_String_;

		// Token: 0x04000586 RID: 1414
		private static Delegate cb_getCode;

		// Token: 0x04000587 RID: 1415
		private static Delegate cb_getErrorCode;

		// Token: 0x04000588 RID: 1416
		private static Delegate cb_getErrorMessage;

		// Token: 0x04000589 RID: 1417
		private static Delegate cb_getLoadTag;

		// Token: 0x0400058A RID: 1418
		private static Delegate cb_setLoadTag_Ljava_lang_String_;

		// Token: 0x0400058B RID: 1419
		private static Delegate cb_getMessage;

		// Token: 0x0400058C RID: 1420
		private static Delegate cb_getWaterfall;

		// Token: 0x0400058D RID: 1421
		private static Delegate cb_setWaterfall_Lcom_applovin_mediation_MaxAdWaterfallInfo_;
	}
}
