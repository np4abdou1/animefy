using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002E RID: 46
	[Register("com/iab/omid/library/adcolony/adsession/ImpressionType", DoNotGenerateAcw = true)]
	public sealed class ImpressionType : Java.Lang.Enum
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00004E3C File Offset: 0x0000303C
		[Register("AUDIBLE")]
		public static ImpressionType Audible
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("AUDIBLE.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00004E6C File Offset: 0x0000306C
		[Register("BEGIN_TO_RENDER")]
		public static ImpressionType BeginToRender
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("BEGIN_TO_RENDER.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00004E9C File Offset: 0x0000309C
		[Register("DEFINED_BY_JAVASCRIPT")]
		public static ImpressionType DefinedByJavascript
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("DEFINED_BY_JAVASCRIPT.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00004ECC File Offset: 0x000030CC
		[Register("LOADED")]
		public static ImpressionType Loaded
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("LOADED.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00004EFC File Offset: 0x000030FC
		[Register("ONE_PIXEL")]
		public static ImpressionType OnePixel
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("ONE_PIXEL.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00004F2C File Offset: 0x0000312C
		[Register("OTHER")]
		public static ImpressionType Other
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("OTHER.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00004F5C File Offset: 0x0000315C
		[Register("UNSPECIFIED")]
		public static ImpressionType Unspecified
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("UNSPECIFIED.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00004F8C File Offset: 0x0000318C
		[Register("VIEWABLE")]
		public static ImpressionType Viewable
		{
			get
			{
				return Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticFields.GetObjectValue("VIEWABLE.Lcom/iab/omid/library/adcolony/adsession/ImpressionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00004FBC File Offset: 0x000031BC
		internal static IntPtr class_ref
		{
			get
			{
				return ImpressionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00004FE0 File Offset: 0x000031E0
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
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00004FE8 File Offset: 0x000031E8
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
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000500C File Offset: 0x0000320C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImpressionType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000047EC File Offset: 0x000029EC
		internal ImpressionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005018 File Offset: 0x00003218
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/ImpressionType;", "")]
		public unsafe static ImpressionType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			ImpressionType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ImpressionType>(ImpressionType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/ImpressionType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005084 File Offset: 0x00003284
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/ImpressionType;", "")]
		public static ImpressionType[] Values()
		{
			return (ImpressionType[])JNIEnv.GetArray(ImpressionType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/ImpressionType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ImpressionType));
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/ImpressionType", typeof(ImpressionType));
	}
}
