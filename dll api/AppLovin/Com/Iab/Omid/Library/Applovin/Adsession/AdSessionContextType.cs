using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x0200003F RID: 63
	[Register("com/iab/omid/library/applovin/adsession/AdSessionContextType", DoNotGenerateAcw = true)]
	public sealed class AdSessionContextType : Java.Lang.Enum
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000047C8 File Offset: 0x000029C8
		[Register("HTML")]
		public static AdSessionContextType Html
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("HTML.Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000047F8 File Offset: 0x000029F8
		[Register("JAVASCRIPT")]
		public static AdSessionContextType Javascript
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("JAVASCRIPT.Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00004828 File Offset: 0x00002A28
		[Register("NATIVE")]
		public static AdSessionContextType Native
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("NATIVE.Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00004858 File Offset: 0x00002A58
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionContextType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000487C File Offset: 0x00002A7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionContextType._members;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00004884 File Offset: 0x00002A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdSessionContextType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000048A8 File Offset: 0x00002AA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionContextType._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal AdSessionContextType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", "")]
		public unsafe static AdSessionContextType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AdSessionContextType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000492C File Offset: 0x00002B2C
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", "")]
		public static AdSessionContextType[] Values()
		{
			return (AdSessionContextType[])JNIEnv.GetArray(AdSessionContextType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdSessionContextType));
		}

		// Token: 0x04000045 RID: 69
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdSessionContextType", typeof(AdSessionContextType));
	}
}
