using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000043 RID: 67
	[Register("com/iab/omid/library/applovin/adsession/ImpressionType", DoNotGenerateAcw = true)]
	public sealed class ImpressionType : Java.Lang.Enum
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00004F04 File Offset: 0x00003104
		[Register("AUDIBLE")]
		public static ImpressionType Audible
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("AUDIBLE.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00004F34 File Offset: 0x00003134
		[Register("BEGIN_TO_RENDER")]
		public static ImpressionType BeginToRender
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("BEGIN_TO_RENDER.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00004F64 File Offset: 0x00003164
		[Register("DEFINED_BY_JAVASCRIPT")]
		public static ImpressionType DefinedByJavascript
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("DEFINED_BY_JAVASCRIPT.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00004F94 File Offset: 0x00003194
		[Register("LOADED")]
		public static ImpressionType Loaded
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("LOADED.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Register("ONE_PIXEL")]
		public static ImpressionType OnePixel
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("ONE_PIXEL.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Register("OTHER")]
		public static ImpressionType Other
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("OTHER.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00005024 File Offset: 0x00003224
		[Register("UNSPECIFIED")]
		public static ImpressionType Unspecified
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("UNSPECIFIED.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00005054 File Offset: 0x00003254
		[Register("VIEWABLE")]
		public static ImpressionType Viewable
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("VIEWABLE.Lcom/iab/omid/library/applovin/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00005084 File Offset: 0x00003284
		internal static IntPtr class_ref
		{
			get
			{
				return ImpressionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000050A8 File Offset: 0x000032A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImpressionType._members;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000050B0 File Offset: 0x000032B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImpressionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000050D4 File Offset: 0x000032D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImpressionType._members.ManagedPeerType;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal ImpressionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000050E0 File Offset: 0x000032E0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/ImpressionType;", "")]
		public unsafe static ImpressionType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			ImpressionType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/ImpressionType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000514C File Offset: 0x0000334C
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/ImpressionType;", "")]
		public static ImpressionType[] Values()
		{
			return (ImpressionType[])JNIEnv.GetArray(ImpressionType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/ImpressionType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ImpressionType));
		}

		// Token: 0x04000049 RID: 73
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/ImpressionType", typeof(ImpressionType));
	}
}
