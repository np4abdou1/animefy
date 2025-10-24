using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/android/gms/common/api/internal/LifecycleActivity", DoNotGenerateAcw = true)]
	public class LifecycleActivity : Java.Lang.Object
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00004978 File Offset: 0x00002B78
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000499C File Offset: 0x00002B9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleActivity._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000049A4 File Offset: 0x00002BA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000049C8 File Offset: 0x00002BC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002EC0 File Offset: 0x000010C0
		protected LifecycleActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000049D4 File Offset: 0x00002BD4
		[Register(".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe LifecycleActivity(Activity p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(LifecycleActivity._members.InstanceMethods.StartCreateInstance("(Landroid/app/Activity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LifecycleActivity._members.InstanceMethods.FinishCreateInstance("(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004A84 File Offset: 0x00002C84
		[Register(".ctor", "(Landroid/content/ContextWrapper;)V", "")]
		public unsafe LifecycleActivity(ContextWrapper p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(LifecycleActivity._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContextWrapper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LifecycleActivity._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContextWrapper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/LifecycleActivity", typeof(LifecycleActivity));
	}
}
