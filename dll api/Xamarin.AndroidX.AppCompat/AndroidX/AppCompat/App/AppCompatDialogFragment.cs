using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Fragment.App;
using Java.Interop;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000058 RID: 88
	[Register("androidx/appcompat/app/AppCompatDialogFragment", DoNotGenerateAcw = true)]
	public class AppCompatDialogFragment : DialogFragment
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		internal static IntPtr class_ref
		{
			get
			{
				return AppCompatDialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000DA18 File Offset: 0x0000BC18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatDialogFragment._members;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000DA20 File Offset: 0x0000BC20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppCompatDialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000DA44 File Offset: 0x0000BC44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatDialogFragment._members.ManagedPeerType;
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000DA50 File Offset: 0x0000BC50
		protected AppCompatDialogFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		[Register(".ctor", "()V", "")]
		public AppCompatDialogFragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppCompatDialogFragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppCompatDialogFragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000DACC File Offset: 0x0000BCCC
		[Register(".ctor", "(I)V", "")]
		public unsafe AppCompatDialogFragment(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(AppCompatDialogFragment._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			AppCompatDialogFragment._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x04000130 RID: 304
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatDialogFragment", typeof(AppCompatDialogFragment));
	}
}
