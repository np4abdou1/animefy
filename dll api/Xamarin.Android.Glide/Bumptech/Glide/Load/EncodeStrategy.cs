using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000C9 RID: 201
	[Register("com/bumptech/glide/load/EncodeStrategy", DoNotGenerateAcw = true)]
	public sealed class EncodeStrategy : Java.Lang.Enum
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002067C File Offset: 0x0001E87C
		[Register("NONE")]
		public static EncodeStrategy None
		{
			get
			{
				return Java.Lang.Object.GetObject<EncodeStrategy>(EncodeStrategy._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/EncodeStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x000206AC File Offset: 0x0001E8AC
		[Register("SOURCE")]
		public static EncodeStrategy Source
		{
			get
			{
				return Java.Lang.Object.GetObject<EncodeStrategy>(EncodeStrategy._members.StaticFields.GetObjectValue("SOURCE.Lcom/bumptech/glide/load/EncodeStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x000206DC File Offset: 0x0001E8DC
		[Register("TRANSFORMED")]
		public static EncodeStrategy Transformed
		{
			get
			{
				return Java.Lang.Object.GetObject<EncodeStrategy>(EncodeStrategy._members.StaticFields.GetObjectValue("TRANSFORMED.Lcom/bumptech/glide/load/EncodeStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0002070C File Offset: 0x0001E90C
		internal static IntPtr class_ref
		{
			get
			{
				return EncodeStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00020730 File Offset: 0x0001E930
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EncodeStrategy._members;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00020738 File Offset: 0x0001E938
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EncodeStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002075C File Offset: 0x0001E95C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EncodeStrategy._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00020768 File Offset: 0x0001E968
		internal EncodeStrategy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00020774 File Offset: 0x0001E974
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/EncodeStrategy;", "")]
		public unsafe static EncodeStrategy ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			EncodeStrategy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<EncodeStrategy>(EncodeStrategy._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/EncodeStrategy;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000207E0 File Offset: 0x0001E9E0
		[Register("values", "()[Lcom/bumptech/glide/load/EncodeStrategy;", "")]
		public static EncodeStrategy[] Values()
		{
			return (EncodeStrategy[])JNIEnv.GetArray(EncodeStrategy._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/EncodeStrategy;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(EncodeStrategy));
		}

		// Token: 0x04000290 RID: 656
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/EncodeStrategy", typeof(EncodeStrategy));
	}
}
