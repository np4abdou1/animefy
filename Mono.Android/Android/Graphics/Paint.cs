using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000226 RID: 550
	[Register("android/graphics/Paint", DoNotGenerateAcw = true)]
	public class Paint : Java.Lang.Object
	{
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00032A57 File Offset: 0x00030C57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Paint._members;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00032A60 File Offset: 0x00030C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Paint._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x00032A84 File Offset: 0x00030C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Paint._members.ManagedPeerType;
			}
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Paint(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00032A90 File Offset: 0x00030C90
		public unsafe bool UnderlineText
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Paint._members.InstanceMethods.InvokeVirtualVoidMethod("setUnderlineText.(Z)V", this, ptr);
			}
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Paint", typeof(Paint));
	}
}
