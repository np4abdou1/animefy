using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Com.Iab.Omid.Library.Adcolony.Publisher;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000027 RID: 39
	[Register("com/iab/omid/library/adcolony/adsession/AdSession", DoNotGenerateAcw = true)]
	internal class AdSessionInvoker : AdSession
	{
		// Token: 0x0600011A RID: 282 RVA: 0x00003C39 File Offset: 0x00001E39
		public AdSessionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00003C43 File Offset: 0x00001E43
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
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00003C4A File Offset: 0x00001E4A
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
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00003C58 File Offset: 0x00001E58
		public override string AdSessionId
		{
			[Register("getAdSessionId", "()Ljava/lang/String;", "GetGetAdSessionIdHandler")]
			get
			{
				return JNIEnv.GetString(AdSessionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00003C8C File Offset: 0x00001E8C
		public override AdSessionStatePublisher AdSessionStatePublisher
		{
			[Register("getAdSessionStatePublisher", "()Lcom/iab/omid/library/adcolony/publisher/AdSessionStatePublisher;", "GetGetAdSessionStatePublisherHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdSessionStatePublisher>(AdSessionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionStatePublisher.()Lcom/iab/omid/library/adcolony/publisher/AdSessionStatePublisher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Register("addFriendlyObstruction", "(Landroid/view/View;Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", "GetAddFriendlyObstruction_Landroid_view_View_Lcom_iab_omid_library_adcolony_adsession_FriendlyObstructionPurpose_Ljava_lang_String_Handler")]
		public unsafe override void AddFriendlyObstruction(View p0, FriendlyObstructionPurpose p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addFriendlyObstruction.(Landroid/view/View;Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00003D70 File Offset: 0x00001F70
		[Register("error", "(Lcom/iab/omid/library/adcolony/adsession/ErrorType;Ljava/lang/String;)V", "GetError_Lcom_iab_omid_library_adcolony_adsession_ErrorType_Ljava_lang_String_Handler")]
		public unsafe override void Error(ErrorType p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("error.(Lcom/iab/omid/library/adcolony/adsession/ErrorType;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Register("finish", "()V", "GetFinishHandler")]
		public override void Finish()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("finish.()V", this, null);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003E10 File Offset: 0x00002010
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

		// Token: 0x06000123 RID: 291 RVA: 0x00003E74 File Offset: 0x00002074
		[Register("removeAllFriendlyObstructions", "()V", "GetRemoveAllFriendlyObstructionsHandler")]
		public override void RemoveAllFriendlyObstructions()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeAllFriendlyObstructions.()V", this, null);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003E90 File Offset: 0x00002090
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

		// Token: 0x06000125 RID: 293 RVA: 0x00003EF4 File Offset: 0x000020F4
		[Register("setPossibleObstructionListener", "(Lcom/iab/omid/library/adcolony/adsession/PossibleObstructionListener;)V", "GetSetPossibleObstructionListener_Lcom_iab_omid_library_adcolony_adsession_PossibleObstructionListener_Handler")]
		public unsafe override void SetPossibleObstructionListener(IPossibleObstructionListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setPossibleObstructionListener.(Lcom/iab/omid/library/adcolony/adsession/PossibleObstructionListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003F5C File Offset: 0x0000215C
		[Register("start", "()V", "GetStartHandler")]
		public override void Start()
		{
			AdSessionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("start.()V", this, null);
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdSession", typeof(AdSessionInvoker));
	}
}
