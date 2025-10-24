using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200027C RID: 636
	[Register("android/content/ClipboardManager", DoNotGenerateAcw = true)]
	public class ClipboardManager : ClipboardManager
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0003E53F File Offset: 0x0003C73F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClipboardManager._members;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x0003E548 File Offset: 0x0003C748
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClipboardManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0003E56C File Offset: 0x0003C76C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClipboardManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00024B03 File Offset: 0x00022D03
		protected ClipboardManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0003E578 File Offset: 0x0003C778
		private static Delegate GetSetPrimaryClip_Landroid_content_ClipData_Handler()
		{
			if (ClipboardManager.cb_setPrimaryClip_Landroid_content_ClipData_ == null)
			{
				ClipboardManager.cb_setPrimaryClip_Landroid_content_ClipData_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ClipboardManager.n_SetPrimaryClip_Landroid_content_ClipData_));
			}
			return ClipboardManager.cb_setPrimaryClip_Landroid_content_ClipData_;
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0003E59C File Offset: 0x0003C79C
		private static void n_SetPrimaryClip_Landroid_content_ClipData_(IntPtr jnienv, IntPtr native__this, IntPtr native_clip)
		{
			ClipboardManager @object = Java.Lang.Object.GetObject<ClipboardManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ClipData object2 = Java.Lang.Object.GetObject<ClipData>(native_clip, JniHandleOwnership.DoNotTransfer);
			@object.PrimaryClip = object2;
		}

		// Token: 0x1700052C RID: 1324
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
		public unsafe virtual ClipData PrimaryClip
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ClipboardManager._members.InstanceMethods.InvokeVirtualVoidMethod("setPrimaryClip.(Landroid/content/ClipData;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x04000A43 RID: 2627
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ClipboardManager", typeof(ClipboardManager));

		// Token: 0x04000A44 RID: 2628
		private static Delegate cb_setPrimaryClip_Landroid_content_ClipData_;
	}
}
