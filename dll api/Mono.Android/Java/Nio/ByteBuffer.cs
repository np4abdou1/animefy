using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio
{
	// Token: 0x02000373 RID: 883
	[Register("java/nio/ByteBuffer", DoNotGenerateAcw = true)]
	public abstract class ByteBuffer : Buffer, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0006F28B File Offset: 0x0006D48B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBuffer._members;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0006F294 File Offset: 0x0006D494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBuffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x0006F2B8 File Offset: 0x0006D4B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBuffer._members.ManagedPeerType;
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0006F253 File Offset: 0x0006D453
		protected ByteBuffer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x0006F2C4 File Offset: 0x0006D4C4
		private static Delegate GetCompareTo_Ljava_nio_ByteBuffer_Handler()
		{
			if (ByteBuffer.cb_compareTo_Ljava_nio_ByteBuffer_ == null)
			{
				ByteBuffer.cb_compareTo_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ByteBuffer.n_CompareTo_Ljava_nio_ByteBuffer_));
			}
			return ByteBuffer.cb_compareTo_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
		private static int n_CompareTo_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_that)
		{
			ByteBuffer @object = Java.Lang.Object.GetObject<ByteBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object2 = Java.Lang.Object.GetObject<ByteBuffer>(native_that, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0006F30C File Offset: 0x0006D50C
		public unsafe virtual int CompareTo(ByteBuffer that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = ByteBuffer._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/nio/ByteBuffer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0006F374 File Offset: 0x0006D574
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<ByteBuffer>());
		}

		// Token: 0x0400100B RID: 4107
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/ByteBuffer", typeof(ByteBuffer));

		// Token: 0x0400100C RID: 4108
		private static Delegate cb_compareTo_Ljava_nio_ByteBuffer_;
	}
}
