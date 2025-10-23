using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Java.Interop;

namespace Google.Android.Material.BottomSheet
{
	// Token: 0x02000056 RID: 86
	[Register("com/google/android/material/bottomsheet/BottomSheetDialogFragment", DoNotGenerateAcw = true)]
	public class BottomSheetDialogFragment : AppCompatDialogFragment
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000B540 File Offset: 0x00009740
		internal static IntPtr class_ref
		{
			get
			{
				return BottomSheetDialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000B564 File Offset: 0x00009764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BottomSheetDialogFragment._members;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000B56C File Offset: 0x0000976C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BottomSheetDialogFragment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000B590 File Offset: 0x00009790
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BottomSheetDialogFragment._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000B59C File Offset: 0x0000979C
		protected BottomSheetDialogFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000B5A8 File Offset: 0x000097A8
		[Register(".ctor", "()V", "")]
		public BottomSheetDialogFragment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BottomSheetDialogFragment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BottomSheetDialogFragment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000B618 File Offset: 0x00009818
		[Register(".ctor", "(I)V", "")]
		public unsafe BottomSheetDialogFragment(int contentLayoutId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentLayoutId);
			base.SetHandle(BottomSheetDialogFragment._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			BottomSheetDialogFragment._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x040000EA RID: 234
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/bottomsheet/BottomSheetDialogFragment", typeof(BottomSheetDialogFragment));
	}
}
