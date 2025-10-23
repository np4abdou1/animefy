using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000191 RID: 401
	[Register("android/util/DisplayMetrics", DoNotGenerateAcw = true)]
	public class DisplayMetrics : Java.Lang.Object
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x0002361E File Offset: 0x0002181E
		[Register("density")]
		public float Density
		{
			get
			{
				return DisplayMetrics._members.InstanceFields.GetSingleValue("density.F", this);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00023635 File Offset: 0x00021835
		[Register("heightPixels")]
		public int HeightPixels
		{
			get
			{
				return DisplayMetrics._members.InstanceFields.GetInt32Value("heightPixels.I", this);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0002364C File Offset: 0x0002184C
		[Register("widthPixels")]
		public int WidthPixels
		{
			get
			{
				return DisplayMetrics._members.InstanceFields.GetInt32Value("widthPixels.I", this);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00023663 File Offset: 0x00021863
		[Register("xdpi")]
		public float Xdpi
		{
			get
			{
				return DisplayMetrics._members.InstanceFields.GetSingleValue("xdpi.F", this);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0002367A File Offset: 0x0002187A
		[Register("ydpi")]
		public float Ydpi
		{
			get
			{
				return DisplayMetrics._members.InstanceFields.GetSingleValue("ydpi.F", this);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00023691 File Offset: 0x00021891
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DisplayMetrics._members;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00023698 File Offset: 0x00021898
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DisplayMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000236BC File Offset: 0x000218BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DisplayMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000021E0 File Offset: 0x000003E0
		protected DisplayMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000236C8 File Offset: 0x000218C8
		public DisplayMetrics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DisplayMetrics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DisplayMetrics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000672 RID: 1650
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/DisplayMetrics", typeof(DisplayMetrics));
	}
}
