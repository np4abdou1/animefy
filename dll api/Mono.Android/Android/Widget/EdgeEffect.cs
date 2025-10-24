using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000C0 RID: 192
	[Register("android/widget/EdgeEffect", DoNotGenerateAcw = true)]
	public class EdgeEffect : Java.Lang.Object
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00006577 File Offset: 0x00004777
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EdgeEffect._members;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00006580 File Offset: 0x00004780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EdgeEffect._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000065A4 File Offset: 0x000047A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EdgeEffect._members.ManagedPeerType;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000021E0 File Offset: 0x000003E0
		protected EdgeEffect(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000065B0 File Offset: 0x000047B0
		public unsafe EdgeEffect(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(EdgeEffect._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EdgeEffect._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0400009D RID: 157
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/EdgeEffect", typeof(EdgeEffect));
	}
}
