using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000C8 RID: 200
	[Register("com/bumptech/glide/load/DecodeFormat", DoNotGenerateAcw = true)]
	public sealed class DecodeFormat : Java.Lang.Enum
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x000204BC File Offset: 0x0001E6BC
		[Register("DEFAULT")]
		public static DecodeFormat Default
		{
			get
			{
				return Java.Lang.Object.GetObject<DecodeFormat>(DecodeFormat._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/DecodeFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x000204EC File Offset: 0x0001E6EC
		[Register("PREFER_ARGB_8888")]
		public static DecodeFormat PreferArgb8888
		{
			get
			{
				return Java.Lang.Object.GetObject<DecodeFormat>(DecodeFormat._members.StaticFields.GetObjectValue("PREFER_ARGB_8888.Lcom/bumptech/glide/load/DecodeFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0002051C File Offset: 0x0001E71C
		[Register("PREFER_RGB_565")]
		public static DecodeFormat PreferRgb565
		{
			get
			{
				return Java.Lang.Object.GetObject<DecodeFormat>(DecodeFormat._members.StaticFields.GetObjectValue("PREFER_RGB_565.Lcom/bumptech/glide/load/DecodeFormat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002054C File Offset: 0x0001E74C
		internal static IntPtr class_ref
		{
			get
			{
				return DecodeFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00020570 File Offset: 0x0001E770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DecodeFormat._members;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00020578 File Offset: 0x0001E778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DecodeFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002059C File Offset: 0x0001E79C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DecodeFormat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000205A8 File Offset: 0x0001E7A8
		internal DecodeFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000205B4 File Offset: 0x0001E7B4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/DecodeFormat;", "")]
		public unsafe static DecodeFormat ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			DecodeFormat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DecodeFormat>(DecodeFormat._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/DecodeFormat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00020620 File Offset: 0x0001E820
		[Register("values", "()[Lcom/bumptech/glide/load/DecodeFormat;", "")]
		public static DecodeFormat[] Values()
		{
			return (DecodeFormat[])JNIEnv.GetArray(DecodeFormat._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/DecodeFormat;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DecodeFormat));
		}

		// Token: 0x0400028F RID: 655
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/DecodeFormat", typeof(DecodeFormat));
	}
}
