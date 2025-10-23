using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002A RID: 42
	[Register("com/iab/omid/library/adcolony/adsession/AdSessionContextType", DoNotGenerateAcw = true)]
	public sealed class AdSessionContextType : Java.Lang.Enum
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00004700 File Offset: 0x00002900
		[Register("HTML")]
		public static AdSessionContextType Html
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("HTML.Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00004730 File Offset: 0x00002930
		[Register("JAVASCRIPT")]
		public static AdSessionContextType Javascript
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("JAVASCRIPT.Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00004760 File Offset: 0x00002960
		[Register("NATIVE")]
		public static AdSessionContextType Native
		{
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticFields.GetObjectValue("NATIVE.Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00004790 File Offset: 0x00002990
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionContextType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000047B4 File Offset: 0x000029B4
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
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000047BC File Offset: 0x000029BC
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
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000047E0 File Offset: 0x000029E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionContextType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000047EC File Offset: 0x000029EC
		internal AdSessionContextType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000047F8 File Offset: 0x000029F8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", "")]
		public unsafe static AdSessionContextType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AdSessionContextType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContextType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00004864 File Offset: 0x00002A64
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", "")]
		public static AdSessionContextType[] Values()
		{
			return (AdSessionContextType[])JNIEnv.GetArray(AdSessionContextType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdSessionContextType));
		}

		// Token: 0x04000042 RID: 66
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdSessionContextType", typeof(AdSessionContextType));
	}
}
