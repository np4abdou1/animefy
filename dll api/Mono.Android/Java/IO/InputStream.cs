using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x0200041B RID: 1051
	[Register("java/io/InputStream", DoNotGenerateAcw = true)]
	public abstract class InputStream : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x0007DFB2 File Offset: 0x0007C1B2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputStream._members;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x0007DFBC File Offset: 0x0007C1BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000021E0 File Offset: 0x000003E0
		protected InputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x0007DFEC File Offset: 0x0007C1EC
		private static Delegate GetCloseHandler()
		{
			if (InputStream.cb_close == null)
			{
				InputStream.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InputStream.n_Close));
			}
			return InputStream.cb_close;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0007E010 File Offset: 0x0007C210
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x0007E01F File Offset: 0x0007C21F
		public virtual void Close()
		{
			InputStream._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x0007E038 File Offset: 0x0007C238
		private static Delegate GetReadHandler()
		{
			if (InputStream.cb_read == null)
			{
				InputStream.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(InputStream.n_Read));
			}
			return InputStream.cb_read;
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x0007E05C File Offset: 0x0007C25C
		private static int n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<InputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06002E07 RID: 11783
		public abstract int Read();

		// Token: 0x06002E08 RID: 11784 RVA: 0x0007E06B File Offset: 0x0007C26B
		private static Delegate GetRead_arrayBHandler()
		{
			if (InputStream.cb_read_arrayB == null)
			{
				InputStream.cb_read_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(InputStream.n_Read_arrayB));
			}
			return InputStream.cb_read_arrayB;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0007E090 File Offset: 0x0007C290
		private static int n_Read_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_b)
		{
			InputStream @object = Java.Lang.Object.GetObject<InputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_b, JniHandleOwnership.DoNotTransfer, typeof(byte));
			int result = @object.Read(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_b);
			}
			return result;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x0007E0CC File Offset: 0x0007C2CC
		public unsafe virtual int Read(byte[] b)
		{
			IntPtr intPtr = JNIEnv.NewArray(b);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = InputStream._members.InstanceMethods.InvokeVirtualInt32Method("read.([B)I", this, ptr);
			}
			finally
			{
				if (b != null)
				{
					JNIEnv.CopyArray(intPtr, b);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x0007E13C File Offset: 0x0007C33C
		private static Delegate GetRead_arrayBIIHandler()
		{
			if (InputStream.cb_read_arrayBII == null)
			{
				InputStream.cb_read_arrayBII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_I(InputStream.n_Read_arrayBII));
			}
			return InputStream.cb_read_arrayBII;
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x0007E160 File Offset: 0x0007C360
		private static int n_Read_arrayBII(IntPtr jnienv, IntPtr native__this, IntPtr native_b, int off, int len)
		{
			InputStream @object = Java.Lang.Object.GetObject<InputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_b, JniHandleOwnership.DoNotTransfer, typeof(byte));
			int result = @object.Read(array, off, len);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_b);
			}
			return result;
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x0007E1A0 File Offset: 0x0007C3A0
		public unsafe virtual int Read(byte[] b, int off, int len)
		{
			IntPtr intPtr = JNIEnv.NewArray(b);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(off);
				ptr[2] = new JniArgumentValue(len);
				result = InputStream._members.InstanceMethods.InvokeVirtualInt32Method("read.([BII)I", this, ptr);
			}
			finally
			{
				if (b != null)
				{
					JNIEnv.CopyArray(intPtr, b);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x04001216 RID: 4630
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/InputStream", typeof(InputStream));

		// Token: 0x04001217 RID: 4631
		private static Delegate cb_close;

		// Token: 0x04001218 RID: 4632
		private static Delegate cb_read;

		// Token: 0x04001219 RID: 4633
		private static Delegate cb_read_arrayB;

		// Token: 0x0400121A RID: 4634
		private static Delegate cb_read_arrayBII;
	}
}
