using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.Charset
{
	// Token: 0x02000396 RID: 918
	[Register("java/nio/charset/Charset", DoNotGenerateAcw = true)]
	internal class CharsetInvoker : Charset, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060028AC RID: 10412 RVA: 0x000730FF File Offset: 0x000712FF
		public CharsetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x00073109 File Offset: 0x00071309
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharsetInvoker._members;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x00073110 File Offset: 0x00071310
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharsetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040010B4 RID: 4276
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/charset/Charset", typeof(CharsetInvoker));
	}
}
