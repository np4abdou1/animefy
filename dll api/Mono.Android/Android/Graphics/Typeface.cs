using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200022F RID: 559
	[Register("android/graphics/Typeface", DoNotGenerateAcw = true)]
	public class Typeface : Java.Lang.Object
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0003328B File Offset: 0x0003148B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Typeface._members;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00033294 File Offset: 0x00031494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Typeface._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000332B8 File Offset: 0x000314B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Typeface._members.ManagedPeerType;
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Typeface(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008B1 RID: 2225
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Typeface", typeof(Typeface));
	}
}
