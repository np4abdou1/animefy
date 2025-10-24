using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001BB RID: 443
	[Register("android/text/TextUtils", DoNotGenerateAcw = true)]
	public class TextUtils : Java.Lang.Object
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0002A285 File Offset: 0x00028485
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextUtils._members;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0002A28C File Offset: 0x0002848C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0002A2B0 File Offset: 0x000284B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000021E0 File Offset: 0x000003E0
		protected TextUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400075A RID: 1882
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/TextUtils", typeof(TextUtils));

		// Token: 0x020001BC RID: 444
		[Register("android/text/TextUtils$TruncateAt", DoNotGenerateAcw = true)]
		public sealed class TruncateAt : Java.Lang.Enum
		{
			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06001020 RID: 4128 RVA: 0x0002A2D7 File Offset: 0x000284D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextUtils.TruncateAt._members;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06001021 RID: 4129 RVA: 0x0002A2E0 File Offset: 0x000284E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TextUtils.TruncateAt._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06001022 RID: 4130 RVA: 0x0002A304 File Offset: 0x00028504
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextUtils.TruncateAt._members.ManagedPeerType;
				}
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal TruncateAt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400075B RID: 1883
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/TextUtils$TruncateAt", typeof(TextUtils.TruncateAt));
		}
	}
}
