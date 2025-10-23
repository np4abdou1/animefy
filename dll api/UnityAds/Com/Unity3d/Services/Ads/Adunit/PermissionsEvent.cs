using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000233 RID: 563
	[Register("com/unity3d/services/ads/adunit/PermissionsEvent", DoNotGenerateAcw = true)]
	public sealed class PermissionsEvent : Java.Lang.Enum
	{
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0004EE84 File Offset: 0x0004D084
		[Register("PERMISSIONS_ERROR")]
		public static PermissionsEvent PermissionsError
		{
			get
			{
				return Java.Lang.Object.GetObject<PermissionsEvent>(PermissionsEvent._members.StaticFields.GetObjectValue("PERMISSIONS_ERROR.Lcom/unity3d/services/ads/adunit/PermissionsEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0004EEB4 File Offset: 0x0004D0B4
		[Register("PERMISSIONS_RESULT")]
		public static PermissionsEvent PermissionsResult
		{
			get
			{
				return Java.Lang.Object.GetObject<PermissionsEvent>(PermissionsEvent._members.StaticFields.GetObjectValue("PERMISSIONS_RESULT.Lcom/unity3d/services/ads/adunit/PermissionsEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
		internal static IntPtr class_ref
		{
			get
			{
				return PermissionsEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0004EF08 File Offset: 0x0004D108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PermissionsEvent._members;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0004EF10 File Offset: 0x0004D110
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PermissionsEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0004EF34 File Offset: 0x0004D134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PermissionsEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000256C File Offset: 0x0000076C
		internal PermissionsEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0004EF40 File Offset: 0x0004D140
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/PermissionsEvent;", "")]
		public unsafe static PermissionsEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PermissionsEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PermissionsEvent>(PermissionsEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/PermissionsEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		[Register("values", "()[Lcom/unity3d/services/ads/adunit/PermissionsEvent;", "")]
		public static PermissionsEvent[] Values()
		{
			return (PermissionsEvent[])JNIEnv.GetArray(PermissionsEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/adunit/PermissionsEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PermissionsEvent));
		}

		// Token: 0x040006A1 RID: 1697
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/PermissionsEvent", typeof(PermissionsEvent));
	}
}
