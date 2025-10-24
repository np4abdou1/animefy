using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017F RID: 383
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/IntegerArrayAdapter", DoNotGenerateAcw = true)]
	public sealed class IntegerArrayAdapter : Java.Lang.Object
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0003D194 File Offset: 0x0003B394
		internal static IntPtr class_ref
		{
			get
			{
				return IntegerArrayAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntegerArrayAdapter._members;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0003D1C0 File Offset: 0x0003B3C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntegerArrayAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0003D1E4 File Offset: 0x0003B3E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntegerArrayAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
		internal IntegerArrayAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0003D1FC File Offset: 0x0003B3FC
		[Register(".ctor", "()V", "")]
		public IntegerArrayAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(IntegerArrayAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			IntegerArrayAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x0003D26A File Offset: 0x0003B46A
		public int ElementSizeInBytes
		{
			[Register("getElementSizeInBytes", "()I", "")]
			get
			{
				return IntegerArrayAdapter._members.InstanceMethods.InvokeAbstractInt32Method("getElementSizeInBytes.()I", this, null);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0003D284 File Offset: 0x0003B484
		public string Tag
		{
			[Register("getTag", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(IntegerArrayAdapter._members.InstanceMethods.InvokeAbstractObjectMethod("getTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0003D2B8 File Offset: 0x0003B4B8
		[Register("getArrayLength", "([I)I", "")]
		public unsafe int GetArrayLength(int[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = IntegerArrayAdapter._members.InstanceMethods.InvokeAbstractInt32Method("getArrayLength.([I)I", this, ptr);
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

		// Token: 0x06001324 RID: 4900 RVA: 0x0003D328 File Offset: 0x0003B528
		[Register("newArray", "(I)[I", "")]
		public unsafe int[] NewArray(int length)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(length);
			return (int[])JNIEnv.GetArray(IntegerArrayAdapter._members.InstanceMethods.InvokeAbstractObjectMethod("newArray.(I)[I", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x0400048C RID: 1164
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/IntegerArrayAdapter", typeof(IntegerArrayAdapter));
	}
}
