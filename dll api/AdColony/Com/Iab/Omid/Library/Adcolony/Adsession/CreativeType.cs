using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002B RID: 43
	[Register("com/iab/omid/library/adcolony/adsession/CreativeType", DoNotGenerateAcw = true)]
	public sealed class CreativeType : Java.Lang.Enum
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Register("AUDIO")]
		public static CreativeType Audio
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("AUDIO.Lcom/iab/omid/library/adcolony/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Register("DEFINED_BY_JAVASCRIPT")]
		public static CreativeType DefinedByJavascript
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("DEFINED_BY_JAVASCRIPT.Lcom/iab/omid/library/adcolony/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004920 File Offset: 0x00002B20
		[Register("HTML_DISPLAY")]
		public static CreativeType HtmlDisplay
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("HTML_DISPLAY.Lcom/iab/omid/library/adcolony/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00004950 File Offset: 0x00002B50
		[Register("NATIVE_DISPLAY")]
		public static CreativeType NativeDisplay
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("NATIVE_DISPLAY.Lcom/iab/omid/library/adcolony/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00004980 File Offset: 0x00002B80
		[Register("VIDEO")]
		public static CreativeType Video
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("VIDEO.Lcom/iab/omid/library/adcolony/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000049B0 File Offset: 0x00002BB0
		internal static IntPtr class_ref
		{
			get
			{
				return CreativeType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000049D4 File Offset: 0x00002BD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreativeType._members;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000049DC File Offset: 0x00002BDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CreativeType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004A00 File Offset: 0x00002C00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreativeType._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000047EC File Offset: 0x000029EC
		internal CreativeType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/CreativeType;", "")]
		public unsafe static CreativeType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			CreativeType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/CreativeType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00004A78 File Offset: 0x00002C78
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/CreativeType;", "")]
		public static CreativeType[] Values()
		{
			return (CreativeType[])JNIEnv.GetArray(CreativeType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/CreativeType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CreativeType));
		}

		// Token: 0x04000043 RID: 67
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/CreativeType", typeof(CreativeType));
	}
}
