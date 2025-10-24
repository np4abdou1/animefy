using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Applovin.Adsession.Media
{
	// Token: 0x0200004F RID: 79
	[Register("com/iab/omid/library/applovin/adsession/media/VastProperties", DoNotGenerateAcw = true)]
	public sealed class VastProperties : Java.Lang.Object
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00006288 File Offset: 0x00004488
		internal static IntPtr class_ref
		{
			get
			{
				return VastProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000062AC File Offset: 0x000044AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VastProperties._members;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000062B4 File Offset: 0x000044B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VastProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000062D8 File Offset: 0x000044D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VastProperties._members.ManagedPeerType;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000021F0 File Offset: 0x000003F0
		internal VastProperties(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000062E4 File Offset: 0x000044E4
		public bool IsAutoPlay
		{
			[Register("isAutoPlay", "()Z", "")]
			get
			{
				return VastProperties._members.InstanceMethods.InvokeAbstractBooleanMethod("isAutoPlay.()Z", this, null);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000062FD File Offset: 0x000044FD
		public bool IsSkippable
		{
			[Register("isSkippable", "()Z", "")]
			get
			{
				return VastProperties._members.InstanceMethods.InvokeAbstractBooleanMethod("isSkippable.()Z", this, null);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00006318 File Offset: 0x00004518
		public Position Position
		{
			[Register("getPosition", "()Lcom/iab/omid/library/applovin/adsession/media/Position;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Position>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("getPosition.()Lcom/iab/omid/library/applovin/adsession/media/Position;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000634C File Offset: 0x0000454C
		public Float SkipOffset
		{
			[Register("getSkipOffset", "()Ljava/lang/Float;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Float>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("getSkipOffset.()Ljava/lang/Float;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00006380 File Offset: 0x00004580
		[Register("a", "()Lorg/json/JSONObject;", "")]
		public JSONObject A()
		{
			return Java.Lang.Object.GetObject<JSONObject>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("a.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000063B4 File Offset: 0x000045B4
		[Register("createVastPropertiesForNonSkippableMedia", "(ZLcom/iab/omid/library/applovin/adsession/media/Position;)Lcom/iab/omid/library/applovin/adsession/media/VastProperties;", "")]
		public unsafe static VastProperties CreateVastPropertiesForNonSkippableMedia(bool p0, Position p1)
		{
			VastProperties @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<VastProperties>(VastProperties._members.StaticMethods.InvokeObjectMethod("createVastPropertiesForNonSkippableMedia.(ZLcom/iab/omid/library/applovin/adsession/media/Position;)Lcom/iab/omid/library/applovin/adsession/media/VastProperties;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000643C File Offset: 0x0000463C
		[Register("createVastPropertiesForSkippableMedia", "(FZLcom/iab/omid/library/applovin/adsession/media/Position;)Lcom/iab/omid/library/applovin/adsession/media/VastProperties;", "")]
		public unsafe static VastProperties CreateVastPropertiesForSkippableMedia(float p0, bool p1, Position p2)
		{
			VastProperties @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<VastProperties>(VastProperties._members.StaticMethods.InvokeObjectMethod("createVastPropertiesForSkippableMedia.(FZLcom/iab/omid/library/applovin/adsession/media/Position;)Lcom/iab/omid/library/applovin/adsession/media/VastProperties;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x0400005B RID: 91
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/media/VastProperties", typeof(VastProperties));
	}
}
