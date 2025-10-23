using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000111 RID: 273
	[Register("com/bumptech/glide/load/resource/bitmap/HardwareConfigState", DoNotGenerateAcw = true)]
	public sealed class HardwareConfigState : Java.Lang.Object
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0002B817 File Offset: 0x00029A17
		[Register("BLOCK_HARDWARE_BITMAPS_WHEN_GL_CONTEXT_MIGHT_NOT_BE_INITIALIZED")]
		public static bool BlockHardwareBitmapsWhenGlContextMightNotBeInitialized
		{
			get
			{
				return HardwareConfigState._members.StaticFields.GetBooleanValue("BLOCK_HARDWARE_BITMAPS_WHEN_GL_CONTEXT_MIGHT_NOT_BE_INITIALIZED.Z");
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0002B82D File Offset: 0x00029A2D
		[Register("HARDWARE_BITMAPS_SUPPORTED")]
		public static bool HardwareBitmapsSupported
		{
			get
			{
				return HardwareConfigState._members.StaticFields.GetBooleanValue("HARDWARE_BITMAPS_SUPPORTED.Z");
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0002B844 File Offset: 0x00029A44
		internal static IntPtr class_ref
		{
			get
			{
				return HardwareConfigState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0002B868 File Offset: 0x00029A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HardwareConfigState._members;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0002B870 File Offset: 0x00029A70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HardwareConfigState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0002B894 File Offset: 0x00029A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HardwareConfigState._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		internal HardwareConfigState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0002B8AC File Offset: 0x00029AAC
		public static HardwareConfigState Instance
		{
			[Register("getInstance", "()Lcom/bumptech/glide/load/resource/bitmap/HardwareConfigState;", "")]
			get
			{
				return Java.Lang.Object.GetObject<HardwareConfigState>(HardwareConfigState._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/bumptech/glide/load/resource/bitmap/HardwareConfigState;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0002B8DD File Offset: 0x00029ADD
		[Register("areHardwareBitmapsBlocked", "()Z", "")]
		public bool AreHardwareBitmapsBlocked()
		{
			return HardwareConfigState._members.InstanceMethods.InvokeAbstractBooleanMethod("areHardwareBitmapsBlocked.()Z", this, null);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002B8F6 File Offset: 0x00029AF6
		[Register("blockHardwareBitmaps", "()V", "")]
		public void BlockHardwareBitmaps()
		{
			HardwareConfigState._members.InstanceMethods.InvokeAbstractVoidMethod("blockHardwareBitmaps.()V", this, null);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002B910 File Offset: 0x00029B10
		[Register("isHardwareConfigAllowed", "(IIZZ)Z", "")]
		public unsafe bool IsHardwareConfigAllowed(int targetWidth, int targetHeight, bool isHardwareConfigAllowed, bool isExifOrientationRequired)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(targetWidth);
			ptr[1] = new JniArgumentValue(targetHeight);
			ptr[2] = new JniArgumentValue(isHardwareConfigAllowed);
			ptr[3] = new JniArgumentValue(isExifOrientationRequired);
			return HardwareConfigState._members.InstanceMethods.InvokeAbstractBooleanMethod("isHardwareConfigAllowed.(IIZZ)Z", this, ptr);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002B98B File Offset: 0x00029B8B
		[Register("unblockHardwareBitmaps", "()V", "")]
		public void UnblockHardwareBitmaps()
		{
			HardwareConfigState._members.InstanceMethods.InvokeAbstractVoidMethod("unblockHardwareBitmaps.()V", this, null);
		}

		// Token: 0x04000338 RID: 824
		[Register("NO_MAX_FD_COUNT")]
		public const int NoMaxFdCount = -1;

		// Token: 0x04000339 RID: 825
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/HardwareConfigState", typeof(HardwareConfigState));
	}
}
