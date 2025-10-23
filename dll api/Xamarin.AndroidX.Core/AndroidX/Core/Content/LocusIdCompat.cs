using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Content
{
	// Token: 0x0200005C RID: 92
	[Register("androidx/core/content/LocusIdCompat", DoNotGenerateAcw = true)]
	public sealed class LocusIdCompat : Java.Lang.Object
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000091F4 File Offset: 0x000073F4
		internal static IntPtr class_ref
		{
			get
			{
				return LocusIdCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00009218 File Offset: 0x00007418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocusIdCompat._members;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00009220 File Offset: 0x00007420
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocusIdCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00009244 File Offset: 0x00007444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocusIdCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002384 File Offset: 0x00000584
		internal LocusIdCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00009250 File Offset: 0x00007450
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LocusIdCompat(string id) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(id);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(LocusIdCompat._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LocusIdCompat._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000333 RID: 819 RVA: 0x000092F4 File Offset: 0x000074F4
		public string Id
		{
			[Register("getId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(LocusIdCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00009328 File Offset: 0x00007528
		[Register("toLocusId", "()Landroid/content/LocusId;", "")]
		public LocusId ToLocusId()
		{
			return Java.Lang.Object.GetObject<LocusId>(LocusIdCompat._members.InstanceMethods.InvokeAbstractObjectMethod("toLocusId.()Landroid/content/LocusId;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000935C File Offset: 0x0000755C
		[Register("toLocusIdCompat", "(Landroid/content/LocusId;)Landroidx/core/content/LocusIdCompat;", "")]
		public unsafe static LocusIdCompat ToLocusIdCompat(LocusId locusId)
		{
			LocusIdCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((locusId == null) ? IntPtr.Zero : locusId.Handle);
				@object = Java.Lang.Object.GetObject<LocusIdCompat>(LocusIdCompat._members.StaticMethods.InvokeObjectMethod("toLocusIdCompat.(Landroid/content/LocusId;)Landroidx/core/content/LocusIdCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(locusId);
			}
			return @object;
		}

		// Token: 0x040000D8 RID: 216
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/content/LocusIdCompat", typeof(LocusIdCompat));
	}
}
