using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200003D RID: 61
	[Register("com/adcolony/sdk/AdColonyAdSize", DoNotGenerateAcw = true)]
	public class AdColonyAdSize : Java.Lang.Object
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00007910 File Offset: 0x00005B10
		[Register("BANNER")]
		public static AdColonyAdSize Banner
		{
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdSize>(AdColonyAdSize._members.StaticFields.GetObjectValue("BANNER.Lcom/adcolony/sdk/AdColonyAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00007940 File Offset: 0x00005B40
		[Register("LEADERBOARD")]
		public static AdColonyAdSize Leaderboard
		{
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdSize>(AdColonyAdSize._members.StaticFields.GetObjectValue("LEADERBOARD.Lcom/adcolony/sdk/AdColonyAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00007970 File Offset: 0x00005B70
		[Register("MEDIUM_RECTANGLE")]
		public static AdColonyAdSize MediumRectangle
		{
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdSize>(AdColonyAdSize._members.StaticFields.GetObjectValue("MEDIUM_RECTANGLE.Lcom/adcolony/sdk/AdColonyAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000079A0 File Offset: 0x00005BA0
		[Register("SKYSCRAPER")]
		public static AdColonyAdSize Skyscraper
		{
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAdSize>(AdColonyAdSize._members.StaticFields.GetObjectValue("SKYSCRAPER.Lcom/adcolony/sdk/AdColonyAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000079D0 File Offset: 0x00005BD0
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyAdSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000079F4 File Offset: 0x00005BF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAdSize._members;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000079FC File Offset: 0x00005BFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyAdSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00007A20 File Offset: 0x00005C20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAdSize._members.ManagedPeerType;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyAdSize(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007A2C File Offset: 0x00005C2C
		[Register(".ctor", "(II)V", "")]
		public unsafe AdColonyAdSize(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(AdColonyAdSize._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyAdSize._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007AC3 File Offset: 0x00005CC3
		private static Delegate GetGetHeightHandler()
		{
			if (AdColonyAdSize.cb_getHeight == null)
			{
				AdColonyAdSize.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyAdSize.n_GetHeight));
			}
			return AdColonyAdSize.cb_getHeight;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00007AE7 File Offset: 0x00005CE7
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAdSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00007AF6 File Offset: 0x00005CF6
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return AdColonyAdSize._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007B0F File Offset: 0x00005D0F
		private static Delegate GetGetWidthHandler()
		{
			if (AdColonyAdSize.cb_getWidth == null)
			{
				AdColonyAdSize.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyAdSize.n_GetWidth));
			}
			return AdColonyAdSize.cb_getWidth;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00007B33 File Offset: 0x00005D33
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyAdSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00007B42 File Offset: 0x00005D42
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				return AdColonyAdSize._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAdSize", typeof(AdColonyAdSize));

		// Token: 0x04000064 RID: 100
		private static Delegate cb_getHeight;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_getWidth;
	}
}
