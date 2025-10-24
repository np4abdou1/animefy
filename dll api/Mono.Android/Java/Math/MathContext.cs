using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Math
{
	// Token: 0x020003B9 RID: 953
	[Register("java/math/MathContext", DoNotGenerateAcw = true)]
	public sealed class MathContext : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x00075E35 File Offset: 0x00074035
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MathContext._members;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x00075E3C File Offset: 0x0007403C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MathContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x00075E60 File Offset: 0x00074060
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MathContext._members.ManagedPeerType;
			}
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000021E0 File Offset: 0x000003E0
		internal MathContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400111D RID: 4381
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/math/MathContext", typeof(MathContext));
	}
}
