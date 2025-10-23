using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000114 RID: 276
	[Register("android/view/Display", DoNotGenerateAcw = true)]
	public class Display : Java.Lang.Object
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00010145 File Offset: 0x0000E345
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Display._members;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001014C File Offset: 0x0000E34C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Display._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00010170 File Offset: 0x0000E370
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Display._members.ManagedPeerType;
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Display(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001017C File Offset: 0x0000E37C
		private static Delegate GetGetRealMetrics_Landroid_util_DisplayMetrics_Handler()
		{
			if (Display.cb_getRealMetrics_Landroid_util_DisplayMetrics_ == null)
			{
				Display.cb_getRealMetrics_Landroid_util_DisplayMetrics_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Display.n_GetRealMetrics_Landroid_util_DisplayMetrics_));
			}
			return Display.cb_getRealMetrics_Landroid_util_DisplayMetrics_;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000101A0 File Offset: 0x0000E3A0
		private static void n_GetRealMetrics_Landroid_util_DisplayMetrics_(IntPtr jnienv, IntPtr native__this, IntPtr native_outMetrics)
		{
			Display @object = Java.Lang.Object.GetObject<Display>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DisplayMetrics object2 = Java.Lang.Object.GetObject<DisplayMetrics>(native_outMetrics, JniHandleOwnership.DoNotTransfer);
			@object.GetRealMetrics(object2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000101C4 File Offset: 0x0000E3C4
		public unsafe virtual void GetRealMetrics(DisplayMetrics outMetrics)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outMetrics == null) ? IntPtr.Zero : outMetrics.Handle);
				Display._members.InstanceMethods.InvokeVirtualVoidMethod("getRealMetrics.(Landroid/util/DisplayMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outMetrics);
			}
		}

		// Token: 0x040001D5 RID: 469
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Display", typeof(Display));

		// Token: 0x040001D6 RID: 470
		private static Delegate cb_getRealMetrics_Landroid_util_DisplayMetrics_;
	}
}
