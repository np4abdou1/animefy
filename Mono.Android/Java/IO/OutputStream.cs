using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000420 RID: 1056
	[Register("java/io/OutputStream", DoNotGenerateAcw = true)]
	public abstract class OutputStream : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IFlushable
	{
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x0007E483 File Offset: 0x0007C683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OutputStream._members;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x0007E48C File Offset: 0x0007C68C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OutputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x0007E4B0 File Offset: 0x0007C6B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OutputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000021E0 File Offset: 0x000003E0
		protected OutputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x0007E4BC File Offset: 0x0007C6BC
		private static Delegate GetCloseHandler()
		{
			if (OutputStream.cb_close == null)
			{
				OutputStream.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(OutputStream.n_Close));
			}
			return OutputStream.cb_close;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x0007E4E0 File Offset: 0x0007C6E0
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<OutputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0007E4EF File Offset: 0x0007C6EF
		public virtual void Close()
		{
			OutputStream._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x0007E508 File Offset: 0x0007C708
		private static Delegate GetFlushHandler()
		{
			if (OutputStream.cb_flush == null)
			{
				OutputStream.cb_flush = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(OutputStream.n_Flush));
			}
			return OutputStream.cb_flush;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x0007E52C File Offset: 0x0007C72C
		private static void n_Flush(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<OutputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flush();
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x0007E53B File Offset: 0x0007C73B
		public virtual void Flush()
		{
			OutputStream._members.InstanceMethods.InvokeVirtualVoidMethod("flush.()V", this, null);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0007E554 File Offset: 0x0007C754
		private static Delegate GetWrite_arrayBHandler()
		{
			if (OutputStream.cb_write_arrayB == null)
			{
				OutputStream.cb_write_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(OutputStream.n_Write_arrayB));
			}
			return OutputStream.cb_write_arrayB;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x0007E578 File Offset: 0x0007C778
		private static void n_Write_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_b)
		{
			OutputStream @object = Java.Lang.Object.GetObject<OutputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_b, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.Write(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_b);
			}
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
		public unsafe virtual void Write(byte[] b)
		{
			IntPtr intPtr = JNIEnv.NewArray(b);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				OutputStream._members.InstanceMethods.InvokeVirtualVoidMethod("write.([B)V", this, ptr);
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
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0007E620 File Offset: 0x0007C820
		private static Delegate GetWrite_arrayBIIHandler()
		{
			if (OutputStream.cb_write_arrayBII == null)
			{
				OutputStream.cb_write_arrayBII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(OutputStream.n_Write_arrayBII));
			}
			return OutputStream.cb_write_arrayBII;
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0007E644 File Offset: 0x0007C844
		private static void n_Write_arrayBII(IntPtr jnienv, IntPtr native__this, IntPtr native_b, int off, int len)
		{
			OutputStream @object = Java.Lang.Object.GetObject<OutputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_b, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.Write(array, off, len);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_b);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x0007E684 File Offset: 0x0007C884
		public unsafe virtual void Write(byte[] b, int off, int len)
		{
			IntPtr intPtr = JNIEnv.NewArray(b);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(off);
				ptr[2] = new JniArgumentValue(len);
				OutputStream._members.InstanceMethods.InvokeVirtualVoidMethod("write.([BII)V", this, ptr);
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
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x0007E718 File Offset: 0x0007C918
		private static Delegate GetWrite_IHandler()
		{
			if (OutputStream.cb_write_I == null)
			{
				OutputStream.cb_write_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(OutputStream.n_Write_I));
			}
			return OutputStream.cb_write_I;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0007E73C File Offset: 0x0007C93C
		private static void n_Write_I(IntPtr jnienv, IntPtr native__this, int b)
		{
			Java.Lang.Object.GetObject<OutputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Write(b);
		}

		// Token: 0x06002E34 RID: 11828
		public abstract void Write(int b);

		// Token: 0x0400121F RID: 4639
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/OutputStream", typeof(OutputStream));

		// Token: 0x04001220 RID: 4640
		private static Delegate cb_close;

		// Token: 0x04001221 RID: 4641
		private static Delegate cb_flush;

		// Token: 0x04001222 RID: 4642
		private static Delegate cb_write_arrayB;

		// Token: 0x04001223 RID: 4643
		private static Delegate cb_write_arrayBII;

		// Token: 0x04001224 RID: 4644
		private static Delegate cb_write_I;
	}
}
