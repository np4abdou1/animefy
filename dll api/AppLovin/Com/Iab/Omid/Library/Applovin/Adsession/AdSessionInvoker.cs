using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Com.Iab.Omid.Library.Applovin.Publisher;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x0200003C RID: 60
	[Register("com/iab/omid/library/applovin/adsession/AdSession", DoNotGenerateAcw = true)]
	internal class AdSessionInvoker : AdSession
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00003D01 File Offset: 0x00001F01
		public AdSessionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00003D0B File Offset: 0x00001F0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionInvoker._members;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003D12 File Offset: 0x00001F12
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00003D20 File Offset: 0x00001F20
		public override string AdSessionId
		{
			[Register("getAdSessionId", "()Ljava/lang/String;", "GetGetAdSessionIdHandler")]
			get
			{
				return JNIEnv.GetString(AdSessionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003D54 File Offset: 0x00001F54
		public override AdSessionStatePublisher AdSessionStatePublisher
		{
			[Register("getAdSessionStatePublisher", "()Lcom/iab/omid/library/applovin/publisher/AdSessionStatePublisher;", "GetGetAdSessionStatePublisherHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdSessionStatePublisher>(AdSessionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionStatePublisher.()Lcom/iab/omid/library/applovin/publisher/AdSessionStatePublisher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00003D88 File Offset: 0x00001F88
		[Register("addFriendlyObstruction", "(Landroid/view/View;Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", "GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_applovin_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler")]
		public unsafe override void AddFriendlyObstruction(View p0, FriendlyObstructionPurpose p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addFriendlyObstruction.(Landroid/view/View;Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003E38 File Offset: 0x00002038
		[Register("error", "(Lcom/iab/omid/library/applovin/adsession/ErrorType;Ljava/lang/String;)V", "GetError_Lcom_iab_omid_library_applovin_adsession_ErrorType_Ljava_lang_String_Handler")]
		public unsafe override void Error(ErrorType p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("error.(Lcom/iab/omid/library/applovin/adsession/ErrorType;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003EBC File Offset: 0x000020BC
		[Register("finish", "()V", "GetFinishHandler")]
		public override void Finish()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("finish.()V", this, null);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00003ED8 File Offset: 0x000020D8
		[Register("registerAdView", "(Landroid/view/View;)V", "GetRegisterAdView_Landroid_view_View_Handler")]
		public unsafe override void RegisterAdView(View p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("registerAdView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003F3C File Offset: 0x0000213C
		[Register("removeAllFriendlyObstructions", "()V", "GetRemoveAllFriendlyObstructionsHandler")]
		public override void RemoveAllFriendlyObstructions()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeAllFriendlyObstructions.()V", this, null);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003F58 File Offset: 0x00002158
		[Register("removeFriendlyObstruction", "(Landroid/view/View;)V", "GetRemoveFriendlyObstruction_Landroid_view_View_Handler")]
		public unsafe override void RemoveFriendlyObstruction(View p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeFriendlyObstruction.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00003FBC File Offset: 0x000021BC
		[Register("setPossibleObstructionListener", "(Lcom/iab/omid/library/applovin/adsession/PossibleObstructionListener;)V", "GetSetPossibleObstructionListener_Lcom_iab_omid_library_applovin_adsession_PossibleObstructionListener_Handler")]
		public unsafe override void SetPossibleObstructionListener(IPossibleObstructionListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setPossibleObstructionListener.(Lcom/iab/omid/library/applovin/adsession/PossibleObstructionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004024 File Offset: 0x00002224
		[Register("start", "()V", "GetStartHandler")]
		public override void Start()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("start.()V", this, null);
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdSession", typeof(AdSessionInvoker));
	}
}
