using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x02000197 RID: 407
	[Register("com/unity3d/services/banners/BannerErrorInfo", DoNotGenerateAcw = true)]
	public class BannerErrorInfo : Java.Lang.Object
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00034FF4 File Offset: 0x000331F4
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00035024 File Offset: 0x00033224
		[Register("errorCode")]
		public BannerErrorCode ErrorCode
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerErrorCode>(BannerErrorInfo._members.InstanceFields.GetObjectValue("errorCode.Lcom/unity3d/services/banners/BannerErrorCode;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					BannerErrorInfo._members.InstanceFields.SetValue("errorCode.Lcom/unity3d/services/banners/BannerErrorCode;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00035070 File Offset: 0x00033270
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x000350A0 File Offset: 0x000332A0
		[Register("errorMessage")]
		public string ErrorMessage
		{
			get
			{
				return JNIEnv.GetString(BannerErrorInfo._members.InstanceFields.GetObjectValue("errorMessage.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					BannerErrorInfo._members.InstanceFields.SetValue("errorMessage.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x000350EC File Offset: 0x000332EC
		internal static IntPtr class_ref
		{
			get
			{
				return BannerErrorInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00035110 File Offset: 0x00033310
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerErrorInfo._members;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00035118 File Offset: 0x00033318
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerErrorInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0003513C File Offset: 0x0003333C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerErrorInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannerErrorInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00035148 File Offset: 0x00033348
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/banners/BannerErrorCode;)V", "")]
		public unsafe BannerErrorInfo(string errorMessage, BannerErrorCode errorCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(errorMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorCode == null) ? IntPtr.Zero : errorCode.Handle);
				base.SetHandle(BannerErrorInfo._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/banners/BannerErrorCode;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BannerErrorInfo._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/banners/BannerErrorCode;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(errorCode);
			}
		}

		// Token: 0x0400045A RID: 1114
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/BannerErrorInfo", typeof(BannerErrorInfo));
	}
}
