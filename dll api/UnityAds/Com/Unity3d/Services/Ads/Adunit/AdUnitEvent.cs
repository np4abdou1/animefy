using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022A RID: 554
	[Register("com/unity3d/services/ads/adunit/AdUnitEvent", DoNotGenerateAcw = true)]
	public sealed class AdUnitEvent : Java.Lang.Enum
	{
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0004D62C File Offset: 0x0004B82C
		[Register("KEY_DOWN")]
		public static AdUnitEvent KeyDown
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("KEY_DOWN.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0004D65C File Offset: 0x0004B85C
		[Register("ON_CREATE")]
		public static AdUnitEvent OnCreate
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_CREATE.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0004D68C File Offset: 0x0004B88C
		[Register("ON_DESTROY")]
		public static AdUnitEvent OnDestroy
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_DESTROY.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0004D6BC File Offset: 0x0004B8BC
		[Register("ON_FOCUS_GAINED")]
		public static AdUnitEvent OnFocusGained
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_FOCUS_GAINED.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		[Register("ON_FOCUS_LOST")]
		public static AdUnitEvent OnFocusLost
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_FOCUS_LOST.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0004D71C File Offset: 0x0004B91C
		[Register("ON_PAUSE")]
		public static AdUnitEvent OnPause
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_PAUSE.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0004D74C File Offset: 0x0004B94C
		[Register("ON_RESTORE")]
		public static AdUnitEvent OnRestore
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_RESTORE.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0004D77C File Offset: 0x0004B97C
		[Register("ON_RESUME")]
		public static AdUnitEvent OnResume
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_RESUME.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0004D7AC File Offset: 0x0004B9AC
		[Register("ON_START")]
		public static AdUnitEvent OnStart
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_START.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0004D7DC File Offset: 0x0004B9DC
		[Register("ON_STOP")]
		public static AdUnitEvent OnStop
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticFields.GetObjectValue("ON_STOP.Lcom/unity3d/services/ads/adunit/AdUnitEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0004D80C File Offset: 0x0004BA0C
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0004D830 File Offset: 0x0004BA30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitEvent._members;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0004D838 File Offset: 0x0004BA38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0004D85C File Offset: 0x0004BA5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0000256C File Offset: 0x0000076C
		internal AdUnitEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0004D868 File Offset: 0x0004BA68
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/AdUnitEvent;", "")]
		public unsafe static AdUnitEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AdUnitEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdUnitEvent>(AdUnitEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/AdUnitEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		[Register("values", "()[Lcom/unity3d/services/ads/adunit/AdUnitEvent;", "")]
		public static AdUnitEvent[] Values()
		{
			return (AdUnitEvent[])JNIEnv.GetArray(AdUnitEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/adunit/AdUnitEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdUnitEvent));
		}

		// Token: 0x04000675 RID: 1653
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitEvent", typeof(AdUnitEvent));
	}
}
