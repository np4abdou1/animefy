using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003F RID: 63
	[Register("com/bumptech/glide/Priority", DoNotGenerateAcw = true)]
	public sealed class Priority : Java.Lang.Enum
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000070FC File Offset: 0x000052FC
		[Register("HIGH")]
		public static Priority High
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("HIGH.Lcom/bumptech/glide/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000712C File Offset: 0x0000532C
		[Register("IMMEDIATE")]
		public static Priority Immediate
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("IMMEDIATE.Lcom/bumptech/glide/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000715C File Offset: 0x0000535C
		[Register("LOW")]
		public static Priority Low
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("LOW.Lcom/bumptech/glide/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000718C File Offset: 0x0000538C
		[Register("NORMAL")]
		public static Priority Normal
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("NORMAL.Lcom/bumptech/glide/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000071BC File Offset: 0x000053BC
		internal static IntPtr class_ref
		{
			get
			{
				return Priority._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000221 RID: 545 RVA: 0x000071E0 File Offset: 0x000053E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Priority._members;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000071E8 File Offset: 0x000053E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Priority._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000720C File Offset: 0x0000540C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Priority._members.ManagedPeerType;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007218 File Offset: 0x00005418
		internal Priority(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007224 File Offset: 0x00005424
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/Priority;", "")]
		public unsafe static Priority ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Priority @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Priority>(Priority._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/Priority;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007290 File Offset: 0x00005490
		[Register("values", "()[Lcom/bumptech/glide/Priority;", "")]
		public static Priority[] Values()
		{
			return (Priority[])JNIEnv.GetArray(Priority._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/Priority;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Priority));
		}

		// Token: 0x0400005F RID: 95
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Priority", typeof(Priority));
	}
}
