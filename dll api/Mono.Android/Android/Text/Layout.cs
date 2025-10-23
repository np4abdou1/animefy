using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001AE RID: 430
	[Register("android/text/Layout", DoNotGenerateAcw = true)]
	public abstract class Layout : Java.Lang.Object
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x0002785C File Offset: 0x00025A5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Layout._members;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00027864 File Offset: 0x00025A64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Layout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00027888 File Offset: 0x00025A88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Layout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Layout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00027894 File Offset: 0x00025A94
		private static Delegate GetGetLineVisibleEnd_IHandler()
		{
			if (Layout.cb_getLineVisibleEnd_I == null)
			{
				Layout.cb_getLineVisibleEnd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(Layout.n_GetLineVisibleEnd_I));
			}
			return Layout.cb_getLineVisibleEnd_I;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000278B8 File Offset: 0x00025AB8
		private static int n_GetLineVisibleEnd_I(IntPtr jnienv, IntPtr native__this, int line)
		{
			return Java.Lang.Object.GetObject<Layout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetLineVisibleEnd(line);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000278C8 File Offset: 0x00025AC8
		public unsafe virtual int GetLineVisibleEnd(int line)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(line);
			return Layout._members.InstanceMethods.InvokeVirtualInt32Method("getLineVisibleEnd.(I)I", this, ptr);
		}

		// Token: 0x0400071A RID: 1818
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/Layout", typeof(Layout));

		// Token: 0x0400071B RID: 1819
		private static Delegate cb_getLineVisibleEnd_I;
	}
}
