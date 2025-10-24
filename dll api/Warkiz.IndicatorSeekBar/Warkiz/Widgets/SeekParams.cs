using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x0200001A RID: 26
	[Register("com/warkiz/widget/SeekParams", DoNotGenerateAcw = true)]
	public class SeekParams : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000624A File Offset: 0x0000444A
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00006261 File Offset: 0x00004461
		[Register("fromUser")]
		public bool FromUser
		{
			get
			{
				return SeekParams._members.InstanceFields.GetBooleanValue("fromUser.Z", this);
			}
			set
			{
				SeekParams._members.InstanceFields.SetValue("fromUser.Z", this, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00006279 File Offset: 0x00004479
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00006290 File Offset: 0x00004490
		[Register("progress")]
		public int Progress
		{
			get
			{
				return SeekParams._members.InstanceFields.GetInt32Value("progress.I", this);
			}
			set
			{
				SeekParams._members.InstanceFields.SetValue("progress.I", this, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000062A8 File Offset: 0x000044A8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000062BF File Offset: 0x000044BF
		[Register("progressFloat")]
		public float ProgressFloat
		{
			get
			{
				return SeekParams._members.InstanceFields.GetSingleValue("progressFloat.F", this);
			}
			set
			{
				SeekParams._members.InstanceFields.SetValue("progressFloat.F", this, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000062D8 File Offset: 0x000044D8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00006308 File Offset: 0x00004508
		[Register("seekBar")]
		public IndicatorSeekBar SeekBar
		{
			get
			{
				return Java.Lang.Object.GetObject<IndicatorSeekBar>(SeekParams._members.InstanceFields.GetObjectValue("seekBar.Lcom/warkiz/widget/IndicatorSeekBar;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					SeekParams._members.InstanceFields.SetValue("seekBar.Lcom/warkiz/widget/IndicatorSeekBar;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000636B File Offset: 0x0000456B
		[Register("thumbPosition")]
		public int ThumbPosition
		{
			get
			{
				return SeekParams._members.InstanceFields.GetInt32Value("thumbPosition.I", this);
			}
			set
			{
				SeekParams._members.InstanceFields.SetValue("thumbPosition.I", this, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00006384 File Offset: 0x00004584
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000063B4 File Offset: 0x000045B4
		[Register("tickText")]
		public string TickText
		{
			get
			{
				return JNIEnv.GetString(SeekParams._members.InstanceFields.GetObjectValue("tickText.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					SeekParams._members.InstanceFields.SetValue("tickText.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00006400 File Offset: 0x00004600
		internal static IntPtr class_ref
		{
			get
			{
				return SeekParams._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00006424 File Offset: 0x00004624
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SeekParams._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000642C File Offset: 0x0000462C
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SeekParams._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00006450 File Offset: 0x00004650
		protected override Type ThresholdType
		{
			get
			{
				return SeekParams._members.ManagedPeerType;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002370 File Offset: 0x00000570
		protected SeekParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000085 RID: 133
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/SeekParams", typeof(SeekParams));
	}
}
