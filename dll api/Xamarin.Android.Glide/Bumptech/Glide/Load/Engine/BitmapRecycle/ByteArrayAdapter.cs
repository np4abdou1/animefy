using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000176 RID: 374
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/ByteArrayAdapter", DoNotGenerateAcw = true)]
	public sealed class ByteArrayAdapter : Java.Lang.Object
	{
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		internal static IntPtr class_ref
		{
			get
			{
				return ByteArrayAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteArrayAdapter._members;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0003BEF0 File Offset: 0x0003A0F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteArrayAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0003BF14 File Offset: 0x0003A114
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteArrayAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0003BF20 File Offset: 0x0003A120
		internal ByteArrayAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0003BF2C File Offset: 0x0003A12C
		[Register(".ctor", "()V", "")]
		public ByteArrayAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ByteArrayAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ByteArrayAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0003BF9A File Offset: 0x0003A19A
		public int ElementSizeInBytes
		{
			[Register("getElementSizeInBytes", "()I", "")]
			get
			{
				return ByteArrayAdapter._members.InstanceMethods.InvokeAbstractInt32Method("getElementSizeInBytes.()I", this, null);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003BFB4 File Offset: 0x0003A1B4
		public string Tag
		{
			[Register("getTag", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ByteArrayAdapter._members.InstanceMethods.InvokeAbstractObjectMethod("getTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
		[Register("getArrayLength", "([B)I", "")]
		public unsafe int GetArrayLength(byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ByteArrayAdapter._members.InstanceMethods.InvokeAbstractInt32Method("getArrayLength.([B)I", this, ptr);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0003C058 File Offset: 0x0003A258
		[Register("newArray", "(I)[B", "")]
		public unsafe byte[] NewArray(int length)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(length);
			return (byte[])JNIEnv.GetArray(ByteArrayAdapter._members.InstanceMethods.InvokeAbstractObjectMethod("newArray.(I)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0400045E RID: 1118
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/ByteArrayAdapter", typeof(ByteArrayAdapter));
	}
}
