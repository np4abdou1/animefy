using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200013A RID: 314
	[Register("android/view/MenuInflater", DoNotGenerateAcw = true)]
	public class MenuInflater : Java.Lang.Object
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0001A50A File Offset: 0x0001870A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MenuInflater._members;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0001A514 File Offset: 0x00018714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MenuInflater._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0001A538 File Offset: 0x00018738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MenuInflater._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000021E0 File Offset: 0x000003E0
		protected MenuInflater(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001A544 File Offset: 0x00018744
		private static Delegate GetInflate_ILandroid_view_Menu_Handler()
		{
			if (MenuInflater.cb_inflate_ILandroid_view_Menu_ == null)
			{
				MenuInflater.cb_inflate_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(MenuInflater.n_Inflate_ILandroid_view_Menu_));
			}
			return MenuInflater.cb_inflate_ILandroid_view_Menu_;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001A568 File Offset: 0x00018768
		private static void n_Inflate_ILandroid_view_Menu_(IntPtr jnienv, IntPtr native__this, int menuRes, IntPtr native_menu)
		{
			MenuInflater @object = Java.Lang.Object.GetObject<MenuInflater>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.Inflate(menuRes, object2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001A58C File Offset: 0x0001878C
		public unsafe virtual void Inflate(int menuRes, IMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(menuRes);
				ptr[1] = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				MenuInflater._members.InstanceMethods.InvokeVirtualVoidMethod("inflate.(ILandroid/view/Menu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x0400036A RID: 874
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MenuInflater", typeof(MenuInflater));

		// Token: 0x0400036B RID: 875
		private static Delegate cb_inflate_ILandroid_view_Menu_;
	}
}
