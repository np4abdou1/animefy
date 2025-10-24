using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x0200003D RID: 61
	[Register("com/iab/omid/library/applovin/adsession/AdSessionConfiguration", DoNotGenerateAcw = true)]
	public class AdSessionConfiguration : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00004058 File Offset: 0x00002258
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000407C File Offset: 0x0000227C
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
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00004084 File Offset: 0x00002284
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
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000040A8 File Offset: 0x000022A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AdSessionConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000040B4 File Offset: 0x000022B4
		private static Delegate GetIsNativeImpressionOwnerHandler()
		{
			if (AdSessionConfiguration.cb_isNativeImpressionOwner == null)
			{
				AdSessionConfiguration.cb_isNativeImpressionOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionConfiguration.n_IsNativeImpressionOwner));
			}
			return AdSessionConfiguration.cb_isNativeImpressionOwner;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000040D8 File Offset: 0x000022D8
		private static bool n_IsNativeImpressionOwner(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeImpressionOwner;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000040E7 File Offset: 0x000022E7
		public virtual bool IsNativeImpressionOwner
		{
			[Register("isNativeImpressionOwner", "()Z", "GetIsNativeImpressionOwnerHandler")]
			get
			{
				return AdSessionConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeImpressionOwner.()Z", this, null);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004100 File Offset: 0x00002300
		private static Delegate GetIsNativeMediaEventsOwnerHandler()
		{
			if (AdSessionConfiguration.cb_isNativeMediaEventsOwner == null)
			{
				AdSessionConfiguration.cb_isNativeMediaEventsOwner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdSessionConfiguration.n_IsNativeMediaEventsOwner));
			}
			return AdSessionConfiguration.cb_isNativeMediaEventsOwner;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004124 File Offset: 0x00002324
		private static bool n_IsNativeMediaEventsOwner(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeMediaEventsOwner;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00004133 File Offset: 0x00002333
		public virtual bool IsNativeMediaEventsOwner
		{
			[Register("isNativeMediaEventsOwner", "()Z", "GetIsNativeMediaEventsOwnerHandler")]
			get
			{
				return AdSessionConfiguration._members.InstanceMethods.InvokeVirtualBooleanMethod("isNativeMediaEventsOwner.()Z", this, null);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000414C File Offset: 0x0000234C
		[Register("createAdSessionConfiguration", "(Lcom/iab/omid/library/applovin/adsession/CreativeType;Lcom/iab/omid/library/applovin/adsession/ImpressionType;Lcom/iab/omid/library/applovin/adsession/Owner;Lcom/iab/omid/library/applovin/adsession/Owner;Z)Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;", "")]
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
				@object = Java.Lang.Object.GetObject<AdSessionConfiguration>(AdSessionConfiguration._members.StaticMethods.InvokeObjectMethod("createAdSessionConfiguration.(Lcom/iab/omid/library/applovin/adsession/CreativeType;Lcom/iab/omid/library/applovin/adsession/ImpressionType;Lcom/iab/omid/library/applovin/adsession/Owner;Lcom/iab/omid/library/applovin/adsession/Owner;Z)Lcom/iab/omid/library/applovin/adsession/AdSessionConfiguration;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600018B RID: 395 RVA: 0x00004254 File Offset: 0x00002454
		private static Delegate GetToJsonObjectHandler()
		{
			if (AdSessionConfiguration.cb_toJsonObject == null)
			{
				AdSessionConfiguration.cb_toJsonObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdSessionConfiguration.n_ToJsonObject));
			}
			return AdSessionConfiguration.cb_toJsonObject;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004278 File Offset: 0x00002478
		private static IntPtr n_ToJsonObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdSessionConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToJsonObject());
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000428C File Offset: 0x0000248C
		[Register("toJsonObject", "()Lorg/json/JSONObject;", "GetToJsonObjectHandler")]
		public virtual JSONObject ToJsonObject()
		{
			return Java.Lang.Object.GetObject<JSONObject>(AdSessionConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("toJsonObject.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdSessionConfiguration", typeof(AdSessionConfiguration));

		// Token: 0x04000041 RID: 65
		private static Delegate cb_isNativeImpressionOwner;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_isNativeMediaEventsOwner;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_toJsonObject;
	}
}
