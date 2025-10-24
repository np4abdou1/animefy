using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000028 RID: 40
	[Register("com/iab/omid/library/adcolony/adsession/AdSessionConfiguration", DoNotGenerateAcw = true)]
	public class AdSessionConfiguration : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00003F90 File Offset: 0x00002190
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00003FB4 File Offset: 0x000021B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionConfiguration._members;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00003FBC File Offset: 0x000021BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdSessionConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00003FE0 File Offset: 0x000021E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002128 File Offset: 0x00000328
		protected AdSessionConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003FEC File Offset: 0x000021EC
		private static Delegate GetIsNativeImpressionOwnerHandler()
		{
			if (AdSessionConfiguration.cb_isNativeImpressionOwner == null)
			{
				AdSessionConfiguration.cb_isNativeImpressionOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionConfiguration.n_IsNativeImpressionOwner));
			}
			return AdSessionConfiguration.cb_isNativeImpressionOwner;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004010 File Offset: 0x00002210
		private static bool n_IsNativeImpressionOwner(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeImpressionOwner;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000401F File Offset: 0x0000221F
		public virtual bool IsNativeImpressionOwner
		{
			[Register("isNativeImpressionOwner", "()Z", "GetIsNativeImpressionOwnerHandler")]
			get
			{
				return AdSessionConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeImpressionOwner.()Z", this, null);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004038 File Offset: 0x00002238
		private static Delegate GetIsNativeMediaEventsOwnerHandler()
		{
			if (AdSessionConfiguration.cb_isNativeMediaEventsOwner == null)
			{
				AdSessionConfiguration.cb_isNativeMediaEventsOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionConfiguration.n_IsNativeMediaEventsOwner));
			}
			return AdSessionConfiguration.cb_isNativeMediaEventsOwner;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000405C File Offset: 0x0000225C
		private static bool n_IsNativeMediaEventsOwner(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeMediaEventsOwner;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000406B File Offset: 0x0000226B
		public virtual bool IsNativeMediaEventsOwner
		{
			[Register("isNativeMediaEventsOwner", "()Z", "GetIsNativeMediaEventsOwnerHandler")]
			get
			{
				return AdSessionConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeMediaEventsOwner.()Z", this, null);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004084 File Offset: 0x00002284
		[Register("createAdSessionConfiguration", "(Lcom/iab/omid/library/adcolony/adsession/CreativeType;Lcom/iab/omid/library/adcolony/adsession/ImpressionType;Lcom/iab/omid/library/adcolony/adsession/Owner;Lcom/iab/omid/library/adcolony/adsession/Owner;Z)Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;", "")]
		public unsafe static AdSessionConfiguration CreateAdSessionConfiguration(CreativeType p0, ImpressionType p1, Owner p2, Owner p3, bool p4)
		{
			AdSessionConfiguration @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				ptr[4] = new JniArgumentValue(p4);
				@object = Java.Lang.Object.GetObject<AdSessionConfiguration>(AdSessionConfiguration._members.StaticMethods.InvokeObjectMethod("createAdSessionConfiguration.(Lcom/iab/omid/library/adcolony/adsession/CreativeType;Lcom/iab/omid/library/adcolony/adsession/ImpressionType;Lcom/iab/omid/library/adcolony/adsession/Owner;Lcom/iab/omid/library/adcolony/adsession/Owner;Z)Lcom/iab/omid/library/adcolony/adsession/AdSessionConfiguration;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
			return @object;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000418C File Offset: 0x0000238C
		private static Delegate GetToJsonObjectHandler()
		{
			if (AdSessionConfiguration.cb_toJsonObject == null)
			{
				AdSessionConfiguration.cb_toJsonObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionConfiguration.n_ToJsonObject));
			}
			return AdSessionConfiguration.cb_toJsonObject;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000041B0 File Offset: 0x000023B0
		private static IntPtr n_ToJsonObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToJsonObject());
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000041C4 File Offset: 0x000023C4
		[Register("toJsonObject", "()Lorg/json/JSONObject;", "GetToJsonObjectHandler")]
		public virtual JSONObject ToJsonObject()
		{
			return Java.Lang.Object.GetObject<JSONObject>(AdSessionConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("toJsonObject.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400003D RID: 61
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdSessionConfiguration", typeof(AdSessionConfiguration));

		// Token: 0x0400003E RID: 62
		private static Delegate cb_isNativeImpressionOwner;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_isNativeMediaEventsOwner;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_toJsonObject;
	}
}
