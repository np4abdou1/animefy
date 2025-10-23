using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003E RID: 62
	[Register("com/bumptech/glide/MemoryCategory", DoNotGenerateAcw = true)]
	public sealed class MemoryCategory : Java.Lang.Enum
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00006F24 File Offset: 0x00005124
		[Register("HIGH")]
		public static MemoryCategory High
		{
			get
			{
				return Java.Lang.Object.GetObject<MemoryCategory>(MemoryCategory._members.StaticFields.GetObjectValue("HIGH.Lcom/bumptech/glide/MemoryCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00006F54 File Offset: 0x00005154
		[Register("LOW")]
		public static MemoryCategory Low
		{
			get
			{
				return Java.Lang.Object.GetObject<MemoryCategory>(MemoryCategory._members.StaticFields.GetObjectValue("LOW.Lcom/bumptech/glide/MemoryCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00006F84 File Offset: 0x00005184
		[Register("NORMAL")]
		public static MemoryCategory Normal
		{
			get
			{
				return Java.Lang.Object.GetObject<MemoryCategory>(MemoryCategory._members.StaticFields.GetObjectValue("NORMAL.Lcom/bumptech/glide/MemoryCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00006FB4 File Offset: 0x000051B4
		internal static IntPtr class_ref
		{
			get
			{
				return MemoryCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00006FD8 File Offset: 0x000051D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MemoryCategory._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00006FE0 File Offset: 0x000051E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MemoryCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00007004 File Offset: 0x00005204
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MemoryCategory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007010 File Offset: 0x00005210
		internal MemoryCategory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000701A File Offset: 0x0000521A
		public float Multiplier
		{
			[Register("getMultiplier", "()F", "")]
			get
			{
				return MemoryCategory._members.InstanceMethods.InvokeAbstractSingleMethod("getMultiplier.()F", this, null);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00007034 File Offset: 0x00005234
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/MemoryCategory;", "")]
		public unsafe static MemoryCategory ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			MemoryCategory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MemoryCategory>(MemoryCategory._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/MemoryCategory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000070A0 File Offset: 0x000052A0
		[Register("values", "()[Lcom/bumptech/glide/MemoryCategory;", "")]
		public static MemoryCategory[] Values()
		{
			return (MemoryCategory[])JNIEnv.GetArray(MemoryCategory._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/MemoryCategory;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(MemoryCategory));
		}

		// Token: 0x0400005E RID: 94
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/MemoryCategory", typeof(MemoryCategory));
	}
}
