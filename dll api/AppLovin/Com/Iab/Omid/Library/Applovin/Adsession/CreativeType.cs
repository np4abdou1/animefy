using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000040 RID: 64
	[Register("com/iab/omid/library/applovin/adsession/CreativeType", DoNotGenerateAcw = true)]
	public sealed class CreativeType : Java.Lang.Enum
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00004988 File Offset: 0x00002B88
		[Register("AUDIO")]
		public static CreativeType Audio
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("AUDIO.Lcom/iab/omid/library/applovin/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000049B8 File Offset: 0x00002BB8
		[Register("DEFINED_BY_JAVASCRIPT")]
		public static CreativeType DefinedByJavascript
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("DEFINED_BY_JAVASCRIPT.Lcom/iab/omid/library/applovin/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000049E8 File Offset: 0x00002BE8
		[Register("HTML_DISPLAY")]
		public static CreativeType HtmlDisplay
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("HTML_DISPLAY.Lcom/iab/omid/library/applovin/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00004A18 File Offset: 0x00002C18
		[Register("NATIVE_DISPLAY")]
		public static CreativeType NativeDisplay
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("NATIVE_DISPLAY.Lcom/iab/omid/library/applovin/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00004A48 File Offset: 0x00002C48
		[Register("VIDEO")]
		public static CreativeType Video
		{
			get
			{
				return Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticFields.GetObjectValue("VIDEO.Lcom/iab/omid/library/applovin/adsession/CreativeType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00004A78 File Offset: 0x00002C78
		internal static IntPtr class_ref
		{
			get
			{
				return CreativeType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00004A9C File Offset: 0x00002C9C
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
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00004AA4 File Offset: 0x00002CA4
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
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00004AC8 File Offset: 0x00002CC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreativeType._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal CreativeType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00004AD4 File Offset: 0x00002CD4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/CreativeType;", "")]
		public unsafe static CreativeType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			CreativeType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CreativeType>(CreativeType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/CreativeType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00004B40 File Offset: 0x00002D40
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/CreativeType;", "")]
		public static CreativeType[] Values()
		{
			return (CreativeType[])JNIEnv.GetArray(CreativeType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/CreativeType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CreativeType));
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/CreativeType", typeof(CreativeType));
	}
}
