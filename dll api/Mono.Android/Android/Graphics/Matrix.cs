using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000225 RID: 549
	[Register("android/graphics/Matrix", DoNotGenerateAcw = true)]
	public class Matrix : Java.Lang.Object
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x00032A03 File Offset: 0x00030C03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Matrix._members;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00032A0C File Offset: 0x00030C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Matrix._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x00032A30 File Offset: 0x00030C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Matrix._members.ManagedPeerType;
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Matrix(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400089F RID: 2207
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Matrix", typeof(Matrix));
	}
}
