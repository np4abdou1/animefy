using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Iab.Omid.Library.Adcolony.Adsession.Media
{
	// Token: 0x0200003A RID: 58
	[Register("com/iab/omid/library/adcolony/adsession/media/VastProperties", DoNotGenerateAcw = true)]
	public sealed class VastProperties : Java.Lang.Object
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000061C0 File Offset: 0x000043C0
		internal static IntPtr class_ref
		{
			get
			{
				return VastProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000061E4 File Offset: 0x000043E4
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
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000061EC File Offset: 0x000043EC
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
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00006210 File Offset: 0x00004410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VastProperties._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002128 File Offset: 0x00000328
		internal VastProperties(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000621C File Offset: 0x0000441C
		public bool IsAutoPlay
		{
			[Register("isAutoPlay", "()Z", "")]
			get
			{
				return VastProperties._members.InstanceMethods.InvokeAbstractBooleanMethod("isAutoPlay.()Z", this, null);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00006235 File Offset: 0x00004435
		public bool IsSkippable
		{
			[Register("isSkippable", "()Z", "")]
			get
			{
				return VastProperties._members.InstanceMethods.InvokeAbstractBooleanMethod("isSkippable.()Z", this, null);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00006250 File Offset: 0x00004450
		public Position Position
		{
			[Register("getPosition", "()Lcom/iab/omid/library/adcolony/adsession/media/Position;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Position>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("getPosition.()Lcom/iab/omid/library/adcolony/adsession/media/Position;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00006284 File Offset: 0x00004484
		public Float SkipOffset
		{
			[Register("getSkipOffset", "()Ljava/lang/Float;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Float>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("getSkipOffset.()Ljava/lang/Float;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000062B8 File Offset: 0x000044B8
		[Register("a", "()Lorg/json/JSONObject;", "")]
		public JSONObject A()
		{
			return Java.Lang.Object.GetObject<JSONObject>(VastProperties._members.InstanceMethods.InvokeAbstractObjectMethod("a.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000062EC File Offset: 0x000044EC
		[Register("createVastPropertiesForNonSkippableMedia", "(ZLcom/iab/omid/library/adcolony/adsession/media/Position;)Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;", "")]
		public unsafe static VastProperties CreateVastPropertiesForNonSkippableMedia(bool p0, Position p1)
		{
			VastProperties @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<VastProperties>(VastProperties._members.StaticMethods.InvokeObjectMethod("createVastPropertiesForNonSkippableMedia.(ZLcom/iab/omid/library/adcolony/adsession/media/Position;)Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006374 File Offset: 0x00004574
		[Register("createVastPropertiesForSkippableMedia", "(FZLcom/iab/omid/library/adcolony/adsession/media/Position;)Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;", "")]
		public unsafe static VastProperties CreateVastPropertiesForSkippableMedia(float p0, bool p1, Position p2)
		{
			VastProperties @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<VastProperties>(VastProperties._members.StaticMethods.InvokeObjectMethod("createVastPropertiesForSkippableMedia.(FZLcom/iab/omid/library/adcolony/adsession/media/Position;)Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x04000058 RID: 88
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/media/VastProperties", typeof(VastProperties));
	}
}
