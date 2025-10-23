using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000E0 RID: 224
	[Register("com/bumptech/glide/load/PreferredColorSpace", DoNotGenerateAcw = true)]
	public sealed class PreferredColorSpace : Java.Lang.Enum
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00023264 File Offset: 0x00021464
		[Register("DISPLAY_P3")]
		public static PreferredColorSpace DisplayP3
		{
			get
			{
				return Java.Lang.Object.GetObject<PreferredColorSpace>(PreferredColorSpace._members.StaticFields.GetObjectValue("DISPLAY_P3.Lcom/bumptech/glide/load/PreferredColorSpace;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00023294 File Offset: 0x00021494
		[Register("SRGB")]
		public static PreferredColorSpace Srgb
		{
			get
			{
				return Java.Lang.Object.GetObject<PreferredColorSpace>(PreferredColorSpace._members.StaticFields.GetObjectValue("SRGB.Lcom/bumptech/glide/load/PreferredColorSpace;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000232C4 File Offset: 0x000214C4
		internal static IntPtr class_ref
		{
			get
			{
				return PreferredColorSpace._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000232E8 File Offset: 0x000214E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PreferredColorSpace._members;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000232F0 File Offset: 0x000214F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PreferredColorSpace._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00023314 File Offset: 0x00021514
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PreferredColorSpace._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00023320 File Offset: 0x00021520
		internal PreferredColorSpace(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002332C File Offset: 0x0002152C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/PreferredColorSpace;", "")]
		public unsafe static PreferredColorSpace ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PreferredColorSpace @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PreferredColorSpace>(PreferredColorSpace._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/PreferredColorSpace;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00023398 File Offset: 0x00021598
		[Register("values", "()[Lcom/bumptech/glide/load/PreferredColorSpace;", "")]
		public static PreferredColorSpace[] Values()
		{
			return (PreferredColorSpace[])JNIEnv.GetArray(PreferredColorSpace._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/PreferredColorSpace;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PreferredColorSpace));
		}

		// Token: 0x040002CA RID: 714
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/PreferredColorSpace", typeof(PreferredColorSpace));
	}
}
