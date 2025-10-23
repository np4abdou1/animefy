using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A1 RID: 161
	[Register("androidx/core/view/DragAndDropPermissionsCompat", DoNotGenerateAcw = true)]
	public sealed class DragAndDropPermissionsCompat : Java.Lang.Object
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00019F88 File Offset: 0x00018188
		internal static IntPtr class_ref
		{
			get
			{
				return DragAndDropPermissionsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00019FAC File Offset: 0x000181AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DragAndDropPermissionsCompat._members;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00019FB4 File Offset: 0x000181B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DragAndDropPermissionsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x00019FD8 File Offset: 0x000181D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DragAndDropPermissionsCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002384 File Offset: 0x00000584
		internal DragAndDropPermissionsCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00019FE4 File Offset: 0x000181E4
		[Register("release", "()V", "")]
		public void Release()
		{
			DragAndDropPermissionsCompat._members.InstanceMethods.InvokeAbstractVoidMethod("release.()V", this, null);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001A000 File Offset: 0x00018200
		[Register("request", "(Landroid/app/Activity;Landroid/view/DragEvent;)Landroidx/core/view/DragAndDropPermissionsCompat;", "")]
		public unsafe static DragAndDropPermissionsCompat Request(Activity activity, DragEvent dragEvent)
		{
			DragAndDropPermissionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((dragEvent == null) ? IntPtr.Zero : dragEvent.Handle);
				@object = Java.Lang.Object.GetObject<DragAndDropPermissionsCompat>(DragAndDropPermissionsCompat._members.StaticMethods.InvokeObjectMethod("request.(Landroid/app/Activity;Landroid/view/DragEvent;)Landroidx/core/view/DragAndDropPermissionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(dragEvent);
			}
			return @object;
		}

		// Token: 0x0400024B RID: 587
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/DragAndDropPermissionsCompat", typeof(DragAndDropPermissionsCompat));
	}
}
